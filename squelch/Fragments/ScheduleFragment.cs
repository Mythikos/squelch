using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Core.Content;
using AndroidX.Fragment.App;
using Squelch.Activities;
using Squelch.Library;
using Squelch.Library.Data;
using Squelch.Library.Entities;
using Squelch.Library.Extensions;
using Squelch.Library.Interfaces;
using Squelch.Library.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;

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
                // Subscribe to event handlers
                BlackoutDatabase.BlackoutTableChanged += UIDisplaySchedule;

                //
                // Display the current schedule
                UIDisplaySchedule();

                //
                // Set firebase screen
                FirebaseAnalyticsUtils.SetCurrentScreen(this);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnResume: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        public override void OnPause()
        {
            base.OnPause();

            try
            {
                //
                // Unsubscribe to event handlers
                BlackoutDatabase.BlackoutTableChanged -= UIDisplaySchedule;
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnPause: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
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
                ((IIndeterminateProgressReporter)this.Activity).SetProgressBarState(isWorking);
        }


        private async void UIDisplaySchedule()
        {
            List<BlackoutItem> pendingBlackouts;

            // Set working!
            SetIsWorking(true);

            try
            {
                // Clear items
                this._itemLayout.RemoveAllViews();

                // Load blackouts
                pendingBlackouts = await BlackoutDatabase.FindAllAsync(BlackoutItem.BlackoutStatusCode.Pending);
                if (pendingBlackouts.Count > 0)
                {
                    // Build new ones
                    await Task.Factory.StartNew(() =>
                    {
                        // Group all blackouts into dates
                        var temporalLabels = pendingBlackouts.OrderBy(x => x.ScheduledStartDateTime).Select(x => x.ScheduledStartDateTime.TemporalLabel(DateTime.Today)).Distinct();
                        foreach (string label in temporalLabels)
                        {
                            var temporalLabel = new TextView(this.Context);
                            temporalLabel.LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
                            temporalLabel.Text = label;
                            temporalLabel.SetTextSize(Android.Util.ComplexUnitType.Dip, 20);
                            temporalLabel.SetTypeface(null, Android.Graphics.TypefaceStyle.Bold);

                            var dateLabel = new TextView(this.Context);
                            dateLabel.LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
                            dateLabel.Text = DateTimeExt.DateTimeFromTemporalLabel(label, (DateTime)DateTime.Today)?.ToString("MMMM yyyy") ?? string.Empty;
                            dateLabel.SetTextSize(Android.Util.ComplexUnitType.Dip, 10);
                            dateLabel.SetTypeface(null, Android.Graphics.TypefaceStyle.Bold);

                            var itemParent = new LinearLayout(this.Context);
                            itemParent.LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
                            itemParent.Orientation = Orientation.Vertical;

                            var groupedBlackouts = pendingBlackouts.Where(x => x.ScheduledStartDateTime.TemporalLabel(DateTime.Today).Equals(label, StringComparison.OrdinalIgnoreCase)).OrderBy(x => x.ScheduledStartDateTime);
                            foreach (BlackoutItem groupedBlackout in groupedBlackouts)
                            {
                                // Get layout and components
                                var itemView = this.LayoutInflater.Inflate(Resource.Layout.template_schedule_row, null);
                                var itemHoursLabel = itemView.FindViewById<TextView>(Resource.Id.template_schedule_row_hours_label);
                                var itemRangeLabel = itemView.FindViewById<TextView>(Resource.Id.template_schedule_row_range_label);

                                // Setup layout
                                var layoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
                                layoutParameters.LeftMargin = 15;
                                layoutParameters.RightMargin = 15;
                                layoutParameters.BottomMargin = 10;
                                itemView.LayoutParameters = layoutParameters;
                                itemView.Click += delegate { DisplayUtils.ShowBlackoutDetailsAlertDialog(this.Context, groupedBlackout, true); };
                                switch (groupedBlackout.DifficultyCode)
                                {
                                    case BlackoutItem.BlackoutDifficultyCode.Novice:
                                        itemView.BackgroundTintList = ContextCompat.GetColorStateList(this.Context, Resource.Color.difficultyNovice);
                                        itemHoursLabel.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.difficultyNoviceForeground));
                                        itemRangeLabel.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.difficultyNoviceForeground));
                                        break;
                                    case BlackoutItem.BlackoutDifficultyCode.Veteran:
                                        itemView.BackgroundTintList = ContextCompat.GetColorStateList(this.Context, Resource.Color.difficultyVeteran);
                                        itemHoursLabel.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.difficultyVeteranForeground));
                                        itemRangeLabel.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.difficultyVeteranForeground));
                                        break;
                                    case BlackoutItem.BlackoutDifficultyCode.Master:
                                        itemView.BackgroundTintList = ContextCompat.GetColorStateList(this.Context, Resource.Color.difficultyMaster);
                                        itemHoursLabel.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.difficultyMasterForeground));
                                        itemRangeLabel.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.difficultyMasterForeground));
                                        break;
                                    case BlackoutItem.BlackoutDifficultyCode.Nightmare:
                                    default:
                                        itemView.BackgroundTintList = ContextCompat.GetColorStateList(this.Context, Resource.Color.difficultyNightmare);
                                        itemHoursLabel.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.difficultyNightmareForeground));
                                        itemRangeLabel.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.difficultyNightmareForeground));
                                        break;
                                }
                                itemHoursLabel.Text = $"{Math.Round((groupedBlackout.ScheduledEndDateTime - groupedBlackout.ScheduledStartDateTime).TotalHours, 1).ToString()} Hours";
                                itemRangeLabel.Text = $"Starts at {groupedBlackout.ScheduledStartDateTime.ToString("h:mm tt")}";
                                itemParent.AddView(itemView);
                            }

                            var spacer = new View(this.Context);
                            spacer.LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, 20);

                            MainThread.BeginInvokeOnMainThread(() =>
                            {
                                // Attach new items
                                this._itemLayout.AddView(temporalLabel);
                                if (!string.IsNullOrWhiteSpace(dateLabel.Text))
                                    this._itemLayout.AddView(dateLabel);
                                this._itemLayout.AddView(itemParent);
                                this._itemLayout.AddView(spacer);
                            });
                        }
                    });
                }
                else
                {
                    var noItemsLabel = new TextView(this.Context);
                    noItemsLabel.LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent);
                    noItemsLabel.Text = GetString(Resource.String.fragment_schedule_notice_no_items);
                    noItemsLabel.Gravity = GravityFlags.Center;
                    noItemsLabel.SetTextSize(Android.Util.ComplexUnitType.Dip, 16);
                    noItemsLabel.SetTypeface(null, Android.Graphics.TypefaceStyle.Bold);
                    this._itemLayout.AddView(noItemsLabel);
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