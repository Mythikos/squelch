using Android.OS;
using Android.Support.V4.Content;
using Android.Views;
using Android.Widget;
using AndroidX.ConstraintLayout.Widget;
using AndroidX.Fragment.App;
using Java.Security.Acl;
using Java.Sql;
using Squelch.Activities;
using Squelch.Library;
using Squelch.Library.Data;
using Squelch.Library.Entities;
using Squelch.Library.Extensions;
using Squelch.Library.Interfaces;
using Squelch.Library.Singletons;
using Squelch.Library.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squelch.Fragments
{
    public class ScheduleFragment : Fragment
    {
        #region Instance Variables
        private static readonly string _tag = typeof(ScheduleFragment).FullName;

        private LinearLayout _rootLayout, _itemLayout;
        #endregion

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view;

            //
            // Inflate the layour
            view = inflater.Inflate(Resource.Layout.fragment_schedule, container, false);

            try
            {
                _rootLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_schedule_root_layout);
                _itemLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_schedule_schedule_items);

                //
                // Setup navbar
                ((MainActivity)this.Activity).SetupNavigation(Resource.String.title_schedule, true, false);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnCreateView: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            //
            // Return the inflated view
            return view;
        }

        public async override void OnResume()
        {
            base.OnResume();

            try
            {
                //
                // Set firebase screen
                var firebaseAnalyticsManager = FirebaseAnalyticsManager.GetInstance();
                firebaseAnalyticsManager.SetCurrentScreen(this);

                //
                // Load blackouts
                var blackoutList = await BlackoutDatabase.FindAllAsync(BlackoutItem.BlackoutStatusCode.Pending);
                await this.CreateAndAttachSchedule(blackoutList);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnResume: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        #region Helper Methods
        /// <summary>
        /// Displays the working progress indicator
        /// </summary>
        /// <param name="bIsWorking"></param>
        private void SetIsWorking(bool isWorking)
        {
            // Toggle views
            ViewUtils.SetViewAndChildrenEnabled(_rootLayout, !isWorking);

            // Report to parent
            if (this.Activity is IIndeterminateProgressReporter)
                ((IIndeterminateProgressReporter)this.Activity).SetProgressBarState(isWorking, true);
        }

        private async Task CreateAndAttachSchedule(List<BlackoutItem> pendingBlackouts)
        {
            // Set working!
            SetIsWorking(true);

            try
            {
                if (pendingBlackouts.Count > 0)
                {
                    // Clear items
                    Xamarin.Essentials.MainThread.BeginInvokeOnMainThread(() =>
                    {
                        this._itemLayout.RemoveAllViews();
                    });

                    // Build new ones
                    await Task.Factory.StartNew(() =>
                    {
                        // Group all blackouts into dates
                        var groupings = pendingBlackouts.OrderBy(x => x.StartDateTime).Select(x => Tuple.Create<string, string>(x.StartDateTime.ToString("MMMM yyyy"), x.StartDateTime.DayLabelFriendly(DateTime.Today))).Distinct();
                        foreach (Tuple<string, string> grouping in groupings)
                        {
                            var dayLabel = new TextView(this.Context);
                            dayLabel.LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
                            dayLabel.Text = grouping.Item2;
                            dayLabel.SetTextSize(Android.Util.ComplexUnitType.Dip, 20);
                            dayLabel.SetTypeface(null, Android.Graphics.TypefaceStyle.Bold);

                            //var dateLabel = new TextView(this.Context);
                            //dateLabel.LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
                            //dateLabel.Text = grouping.Item1;
                            //dateLabel.SetTextSize(Android.Util.ComplexUnitType.Dip, 10);
                            //dateLabel.SetTypeface(null, Android.Graphics.TypefaceStyle.Bold);

                            var itemParent = new LinearLayout(this.Context);
                            itemParent.LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
                            itemParent.Orientation = Orientation.Vertical;

                            var groupedBlackouts = pendingBlackouts.Where(x => x.StartDateTime.DayLabelFriendly(DateTime.Today).Equals(grouping.Item2)).OrderBy(x => x.StartDateTime);
                            foreach (BlackoutItem groupedBlackout in groupedBlackouts)
                            {
                                var itemView = this.LayoutInflater.Inflate(Resource.Layout.template_schedule_row, null);
                                var layoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
                                layoutParameters.BottomMargin = 10;
                                itemView.LayoutParameters = layoutParameters;
                                itemView.Click += delegate { DisplayUtils.ShowBlackoutDetailsAlertDialog(this.Context, groupedBlackout, true); };
                                
                                switch (groupedBlackout.DifficultyCode)
                                {
                                    case BlackoutItem.BlackoutDifficultyCode.Novice:
                                        itemView.BackgroundTintList = ContextCompat.GetColorStateList(this.Context, Resource.Color.colorAccent);
                                        break;
                                    case BlackoutItem.BlackoutDifficultyCode.Veteran:
                                        itemView.BackgroundTintList = ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimary);
                                        break;
                                    case BlackoutItem.BlackoutDifficultyCode.Master:
                                        itemView.BackgroundTintList = ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimaryDark);
                                        break;
                                    case BlackoutItem.BlackoutDifficultyCode.Nightmare:
                                    default:
                                        itemView.BackgroundTintList = ContextCompat.GetColorStateList(this.Context, Resource.Color.colorAccent);
                                        break;
                                }

                                var itemHoursLabel = itemView.FindViewById<TextView>(Resource.Id.template_schedule_row_hours_label);
                                itemHoursLabel.Text = $"{Math.Round((groupedBlackout.EndDateTime - groupedBlackout.StartDateTime).TotalHours, 1).ToString()} Hours";

                                var itemRangeLabel = itemView.FindViewById<TextView>(Resource.Id.template_schedule_row_range_label);
                                itemRangeLabel.Text = $"Starts at {groupedBlackout.StartDateTime.ToString("h:mm tt")}";

                                itemParent.AddView(itemView);
                            }

                            // Attach new items
                            Xamarin.Essentials.MainThread.BeginInvokeOnMainThread(() =>
                            {
                                this._itemLayout.AddView(dayLabel);
                                //this._itemLayout.AddView(dateLabel);
                                this._itemLayout.AddView(itemParent);
                            });
                        }
                    });
                }
            }
            finally
            {
                SetIsWorking(false);
            }
        }
        #endregion
    }
}