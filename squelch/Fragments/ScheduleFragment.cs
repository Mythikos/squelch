using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Core.Content;
using AndroidX.Fragment.App;
using Squelch.Activities;
using Squelch.Library;
using Squelch.Library.Data;
using Squelch.Library.Entities;
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
                this._rootLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_schedule_root_layout);
                this._itemLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_schedule_schedule_items);

                //
                // Setup navbar
                ((MainActivity)this.Activity).SetupNavigation(Resource.String.text_schedule, true, false);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnCreateView: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            //
            // Return the inflated view
            return view;
        }

        public override async void OnResume()
        {
            base.OnResume();

            try
            {
                //
                // Subscribe to event handlers
                BlackoutDatabase.BlackoutTableChanged += this.UIDisplaySchedule;

                //
                // Display the current schedule
                this.UIDisplaySchedule();

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
                BlackoutDatabase.BlackoutTableChanged -= this.UIDisplaySchedule;
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
            ViewUtils.SetViewAndChildrenEnabled(this._rootLayout, !isWorking);

            // Report to parent
            if (this.Activity is IIndeterminateProgressReporter)
            {
                ((IIndeterminateProgressReporter)this.Activity).SetProgressBarState(isWorking);
            }
        }

        private async void UIDisplaySchedule()
        {
            List<BlackoutItem> pendingBlackouts;

            // Set working!
            this.SetIsWorking(true);

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
                        IEnumerable<string> temporalLabels = pendingBlackouts.OrderBy(x => x.ScheduledStartDateTime).Select(x => DateUtils.GetTemporalLabel(this.Context, x.ScheduledStartDateTime, DateTime.Today)).Distinct();
                        foreach (string label in temporalLabels)
                        {
                            TextView temporalLabel = new TextView(this.Context)
                            {
                                LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent),
                                Text = label
                            };
                            temporalLabel.SetTextSize(Android.Util.ComplexUnitType.Dip, 20);
                            temporalLabel.SetTypeface(null, Android.Graphics.TypefaceStyle.Bold);

                            TextView dateLabel = new TextView(this.Context);
                            DateTime? dateFromTemporal = DateUtils.GetDateTimeFromTemporalLabel(this.Context, label, DateTime.Today);
                            dateLabel.LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
                            dateLabel.Text = dateFromTemporal != null ? DateUtils.FormatDateCustom(this.Context, dateFromTemporal.Value, "MMMM yyyy") : string.Empty;
                            dateLabel.SetTextSize(Android.Util.ComplexUnitType.Dip, 10);
                            dateLabel.SetTypeface(null, Android.Graphics.TypefaceStyle.Bold);

                            LinearLayout itemParent = new LinearLayout(this.Context)
                            {
                                LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                                Orientation = Orientation.Vertical
                            };

                            IOrderedEnumerable<BlackoutItem> groupedBlackouts = pendingBlackouts.Where(x => DateUtils.GetTemporalLabel(this.Context, x.ScheduledStartDateTime, DateTime.Today).Equals(label, StringComparison.OrdinalIgnoreCase)).OrderBy(x => x.ScheduledStartDateTime);
                            foreach (BlackoutItem groupedBlackout in groupedBlackouts)
                            {
                                // Get layout and components
                                View itemView = this.LayoutInflater.Inflate(Resource.Layout.template_schedule_row, null);
                                TextView itemHoursLabel = itemView.FindViewById<TextView>(Resource.Id.template_schedule_row_hours_label);
                                TextView itemRangeLabel = itemView.FindViewById<TextView>(Resource.Id.template_schedule_row_range_label);

                                // Setup layout
                                LinearLayout.LayoutParams layoutParameters = new LinearLayout.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent)
                                {
                                    LeftMargin = 15,
                                    RightMargin = 15,
                                    BottomMargin = 10
                                };
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
                                itemHoursLabel.Text = string.Format(this.GetString(Resource.String.fragment_schedule_hours_label), Math.Round((groupedBlackout.ScheduledEndDateTime - groupedBlackout.ScheduledStartDateTime).TotalHours, 1).ToString());
                                itemRangeLabel.Text = string.Format(this.GetString(Resource.String.fragment_schedule_range_label), DateUtils.FormatTime(this.Context, groupedBlackout.ScheduledStartDateTime, UserSettings.FormatTimeAsTwelveHour));
                                itemParent.AddView(itemView);
                            }

                            View spacer = new View(this.Context)
                            {
                                LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, 20)
                            };

                            MainThread.BeginInvokeOnMainThread(() =>
                            {
                                // Attach new items
                                this._itemLayout.AddView(temporalLabel);
                                if (!string.IsNullOrWhiteSpace(dateLabel.Text))
                                {
                                    this._itemLayout.AddView(dateLabel);
                                }

                                this._itemLayout.AddView(itemParent);
                                this._itemLayout.AddView(spacer);
                            });
                        }
                    });
                }
                else
                {
                    TextView noItemsLabel = new TextView(this.Context)
                    {
                        LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.MatchParent, ViewGroup.LayoutParams.WrapContent),
                        Text = this.GetString(Resource.String.fragment_schedule_notice_no_items),
                        Gravity = GravityFlags.Center
                    };
                    noItemsLabel.SetTextSize(Android.Util.ComplexUnitType.Dip, 16);
                    noItemsLabel.SetTypeface(null, Android.Graphics.TypefaceStyle.Bold);
                    this._itemLayout.AddView(noItemsLabel);
                }
            }
            finally
            {
                this.SetIsWorking(false);
            }
        }
        #endregion
    }
}