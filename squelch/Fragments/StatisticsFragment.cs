using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Core.Content;
using Java.Text;
using MikePhil.Charting.Charts;
using MikePhil.Charting.Data;
using MikePhil.Charting.Formatter;
using MikePhil.Charting.Util;
using Squelch.Activities;
using Squelch.Library;
using Squelch.Library.Data;
using Squelch.Library.Entities;
using Squelch.Library.Interfaces;
using Squelch.Library.Utilities;
using System;
using System.Collections.Generic;

namespace Squelch.Fragments
{
    public class StatisticsFragment : AndroidX.Fragment.App.Fragment
    {
        #region Instance Variables
        private static readonly string _tag = typeof(StatisticsFragment).FullName;

        private LinearLayout _rootLayout;
        private TextView _totalBlackouts, _totalBids, _totalTimeSaved;
        private PieChart _statusPieChart, _difficultyPieChart, _bidPieChart;
        private Button _filterOneWeekButton, _filterOneMonthButton, _filterOneYearButton;
        private enum DateFilter { Unknown, OneWeek, OneMonth, OneYear }
        private DateFilter _dateFilterState = DateFilter.Unknown;
        #endregion

        #region Native Events
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view;

            //
            // Inflate the layour
            view = inflater.Inflate(Resource.Layout.fragment_statistics, container, false);

            try
            {
                //
                // Get elements
                this._rootLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_statistics_root_layout);
                this._totalBlackouts = view.FindViewById<TextView>(Resource.Id.fragment_statistics_overview_total_blackouts);
                this._totalBids = view.FindViewById<TextView>(Resource.Id.fragment_statistics_overview_total_bids);
                this._totalTimeSaved = view.FindViewById<TextView>(Resource.Id.fragment_statistics_overview_total_time);
                this._filterOneWeekButton = view.FindViewById<Button>(Resource.Id.fragment_statistics_filter_one_week);
                this._filterOneMonthButton = view.FindViewById<Button>(Resource.Id.fragment_statistics_filter_one_month);
                this._filterOneYearButton = view.FindViewById<Button>(Resource.Id.fragment_statistics_filter_one_year);

                this._statusPieChart = view.FindViewById<PieChart>(Resource.Id.fragment_statistics_blackout_status_pie_chart);
                this._statusPieChart.Description = new MikePhil.Charting.Components.Description() { Text = this.GetString(Resource.String.fragment_statistics_chart_description_outcomes) };
                this._statusPieChart.DrawHoleEnabled = true;
                this._statusPieChart.RotationEnabled = false;
                this._statusPieChart.HighlightPerTapEnabled = false;
                this._statusPieChart.HoleRadius = 50f;
                this._statusPieChart.TransparentCircleRadius = 60f;
                this._statusPieChart.SetTransparentCircleColor(Color.White);
                this._statusPieChart.SetHoleColor(Color.White);
                this._statusPieChart.SetTransparentCircleAlpha(125);
                this._statusPieChart.SetDrawCenterText(true);

                this._difficultyPieChart = view.FindViewById<PieChart>(Resource.Id.fragment_statistics_blackout_difficulty_pie_chart);
                this._difficultyPieChart.Description = new MikePhil.Charting.Components.Description() { Text = this.GetString(Resource.String.fragment_statistics_chart_description_difficulties) };
                this._difficultyPieChart.DrawHoleEnabled = true;
                this._difficultyPieChart.RotationEnabled = false;
                this._difficultyPieChart.HighlightPerTapEnabled = false;
                this._difficultyPieChart.HoleRadius = 50f;
                this._difficultyPieChart.TransparentCircleRadius = 60f;
                this._difficultyPieChart.SetHoleColor(Color.White);
                this._difficultyPieChart.SetTransparentCircleColor(Color.White);
                this._difficultyPieChart.SetTransparentCircleAlpha(125);
                this._difficultyPieChart.SetDrawCenterText(true);

                this._bidPieChart = view.FindViewById<PieChart>(Resource.Id.fragment_statistics_blackout_bid_pie_chart);
                this._bidPieChart.Description = new MikePhil.Charting.Components.Description() { Text = this.GetString(Resource.String.fragment_statistics_chart_description_bids) };
                this._bidPieChart.DrawHoleEnabled = true;
                this._bidPieChart.RotationEnabled = false;
                this._bidPieChart.HighlightPerTapEnabled = false;
                this._bidPieChart.HoleRadius = 50f;
                this._bidPieChart.TransparentCircleRadius = 60f;
                this._bidPieChart.SetHoleColor(Color.White);
                this._bidPieChart.SetTransparentCircleColor(Color.White);
                this._bidPieChart.SetTransparentCircleAlpha(125);
                this._bidPieChart.SetDrawCenterText(true);

                //
                // Hookup events
                this._filterOneWeekButton.Click += delegate { this.UpdateFilter(DateFilter.OneWeek); };
                this._filterOneMonthButton.Click += delegate { this.UpdateFilter(DateFilter.OneMonth); };
                this._filterOneYearButton.Click += delegate { this.UpdateFilter(DateFilter.OneYear); };

                //
                // Setup navbar
                ((MainActivity)this.Activity).SetupNavigation(Resource.String.text_statistics, true, false);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnCreateView: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            //
            // Return the inflated view
            return view;
        }

        public override void OnResume()
        {
            base.OnResume();

            try
            {
                //
                // update view
                if (this._dateFilterState == DateFilter.Unknown)
                {
                    this._dateFilterState = DateFilter.OneWeek;
                }

                this.UpdateFilter(this._dateFilterState);

                //
                // Set firebase screen
                FirebaseAnalyticsUtils.SetCurrentScreen(this);

            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnResume: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }
        #endregion

        #region Control Events
        private void UpdateFilter(DateFilter filter)
        {
            try
            {
                this._dateFilterState = filter;

                // Toggle button states
                this.ToggleFilterButtonState(this._filterOneWeekButton, (this._dateFilterState.Equals(DateFilter.OneWeek) ? true : false));
                this.ToggleFilterButtonState(this._filterOneMonthButton, (this._dateFilterState.Equals(DateFilter.OneMonth) ? true : false));
                this.ToggleFilterButtonState(this._filterOneYearButton, (this._dateFilterState.Equals(DateFilter.OneYear) ? true : false));

                // Update data
                this.UIUpdateStats(this._dateFilterState);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"UpdateFilter: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }
        #endregion

        #region Helper Methods
        /// <summary>
        /// Displays the working progress indicator
        /// </summary>
        /// <param name="bIsWorking"></param>
        private void SetIsWorking(bool isWorking)
        {
            // Toggle views
            Library.Utilities.ViewUtils.SetViewAndChildrenEnabled(this._rootLayout, !isWorking);

            // Report to parent
            if (this.Activity is IIndeterminateProgressReporter)
            {
                ((IIndeterminateProgressReporter)this.Activity).SetProgressBarState(isWorking);
            }
        }
        #endregion

        #region UI Helper Methods
        private async void UIUpdateStats(DateFilter filter)
        {
            Dictionary<string, string> blackoutStatistics;
            DateTime startDateTime;
            List<PieEntry> pieDataEntries;
            PieDataSet pieDataSet;
            PieData pieData;

            try
            {
                //
                // Set working
                this.SetIsWorking(true);

                //
                // Determine starting date (in past)
                switch (filter)
                {
                    case DateFilter.OneWeek:
                        startDateTime = DateTime.Now.AddDays(-7);
                        break;
                    case DateFilter.OneMonth:
                        startDateTime = DateTime.Now.AddMonths(-1);
                        break;
                    case DateFilter.OneYear:
                        startDateTime = DateTime.Now.AddYears(-1);
                        break;
                    default:
                        startDateTime = DateTime.MinValue;
                        break;
                }

                //
                // Get stats from database
                blackoutStatistics = await BlackoutDatabase.GetBlackoutStatistics(startDateTime, DateTime.Now);

                //
                // Update view
                this._totalBids.Text = $"${blackoutStatistics.GetValueOrDefault("total_bids_all", "0")}";
                this._totalTimeSaved.Text = $"{this.ParseMinutesForDisplay(double.Parse(blackoutStatistics.GetValueOrDefault("total_milliseconds_saved_all", "0")))}";
                this._totalBlackouts.Text = $"{blackoutStatistics.GetValueOrDefault("total_blackouts_all", "0")}";

                //
                // Status chart
                pieDataEntries = new List<PieEntry>();
                foreach (BlackoutItem.BlackoutResultCode resultCode in Enum.GetValues(typeof(BlackoutItem.BlackoutResultCode)))
                {
                    if (resultCode.Equals(BlackoutItem.BlackoutResultCode.Pending))
                    {
                        continue;
                    }

                    float value = float.Parse(blackoutStatistics.GetValueOrDefault($"total_blackouts_{resultCode.ToString().ToLower()}", "0"));
                    if (value > 0)
                    {
                        int blackoutResultTextResourceId = Resource.String.text_unknown;
                        switch (resultCode)
                        {
                            case BlackoutItem.BlackoutResultCode.Success:
                                blackoutResultTextResourceId = Resource.String.text_success;
                                break;
                            case BlackoutItem.BlackoutResultCode.Failed:
                                blackoutResultTextResourceId = Resource.String.text_failed;
                                break;
                            case BlackoutItem.BlackoutResultCode.Skipped:
                                blackoutResultTextResourceId = Resource.String.text_skipped;
                                break;
                            case BlackoutItem.BlackoutResultCode.Cancelled:
                                blackoutResultTextResourceId = Resource.String.text_cancelled;
                                break;
                        }

                        pieDataEntries.Add(new PieEntry(value, this.GetString(blackoutResultTextResourceId)));
                    }
                }

                pieDataSet = new PieDataSet(pieDataEntries, string.Empty);
                pieDataSet.SetDrawIcons(false);
                pieDataSet.SetColors(this.GetPieChartColors().ToArray());

                pieData = new PieData(pieDataSet);
                pieData.SetValueFormatter(new IntFormatter());
                pieData.SetValueTextSize(12f);
                pieData.SetValueTextColor(ContextCompat.GetColor(this.Context, Resource.Color.White));

                this._statusPieChart.Data = pieData;
                this._statusPieChart.HighlightValues(null);
                this._statusPieChart.Invalidate();
                this._statusPieChart.AnimateY(1400, MikePhil.Charting.Animation.Easing.EaseInOutQuad);

                //
                // Difficulty chart
                pieDataEntries = new List<PieEntry>();
                foreach (BlackoutItem.BlackoutDifficultyCode difficultyCode in Enum.GetValues(typeof(BlackoutItem.BlackoutDifficultyCode)))
                {
                    if (difficultyCode.Equals(BlackoutItem.BlackoutResultCode.Pending))
                    {
                        continue;
                    }

                    float value = float.Parse(blackoutStatistics.GetValueOrDefault($"total_blackouts_{difficultyCode.ToString().ToLower()}", "0"));
                    if (value > 0)
                    {
                        int blackoutDifficultyTextResourceId = Resource.String.text_unknown;
                        switch (difficultyCode)
                        {
                            case BlackoutItem.BlackoutDifficultyCode.Novice:
                                blackoutDifficultyTextResourceId = Resource.String.text_novice;
                                break;
                            case BlackoutItem.BlackoutDifficultyCode.Veteran:
                                blackoutDifficultyTextResourceId = Resource.String.text_veteran;
                                break;
                            case BlackoutItem.BlackoutDifficultyCode.Master:
                                blackoutDifficultyTextResourceId = Resource.String.text_master;
                                break;
                            case BlackoutItem.BlackoutDifficultyCode.Nightmare:
                                blackoutDifficultyTextResourceId = Resource.String.text_nightmare;
                                break;
                        }

                        pieDataEntries.Add(new PieEntry(value, this.GetString(blackoutDifficultyTextResourceId)));
                    }
                }

                pieDataSet = new PieDataSet(pieDataEntries, string.Empty);
                pieDataSet.SetDrawIcons(false);
                pieDataSet.SetColors(this.GetPieChartColors().ToArray());

                pieData = new PieData(pieDataSet);
                pieData.SetValueFormatter(new IntFormatter());
                pieData.SetValueTextSize(12f);
                pieData.SetValueTextColor(ContextCompat.GetColor(this.Context, Resource.Color.White));

                this._difficultyPieChart.Data = pieData;
                this._difficultyPieChart.HighlightValues(null);
                this._difficultyPieChart.Invalidate();
                this._difficultyPieChart.AnimateY(1400, MikePhil.Charting.Animation.Easing.EaseInOutQuad);

                //
                // Bid chart
                pieDataEntries = new List<PieEntry>();
                foreach (BlackoutItem.BlackoutResultCode resultCode in Enum.GetValues(typeof(BlackoutItem.BlackoutResultCode)))
                {
                    if (resultCode.Equals(BlackoutItem.BlackoutResultCode.Pending))
                    {
                        continue;
                    }

                    float value = float.Parse(blackoutStatistics.GetValueOrDefault($"total_bids_{resultCode.ToString().ToLower()}", "0"));
                    if (value > 0)
                    {
                        int blackoutResultTextResourceId = Resource.String.text_unknown;
                        switch (resultCode)
                        {
                            case BlackoutItem.BlackoutResultCode.Success:
                                blackoutResultTextResourceId = Resource.String.text_success;
                                break;
                            case BlackoutItem.BlackoutResultCode.Failed:
                                blackoutResultTextResourceId = Resource.String.text_failed;
                                break;
                            case BlackoutItem.BlackoutResultCode.Skipped:
                                blackoutResultTextResourceId = Resource.String.text_skipped;
                                break;
                            case BlackoutItem.BlackoutResultCode.Cancelled:
                                blackoutResultTextResourceId = Resource.String.text_cancelled;
                                break;
                        }

                        pieDataEntries.Add(new PieEntry(value, this.GetString(blackoutResultTextResourceId)));
                    }
                }

                pieDataSet = new PieDataSet(pieDataEntries, string.Empty);
                pieDataSet.SetDrawIcons(false);
                pieDataSet.SetColors(this.GetPieChartColors().ToArray());

                pieData = new PieData(pieDataSet);
                pieData.SetValueFormatter(new MoneyFormatter());
                pieData.SetValueTextSize(12f);
                pieData.SetValueTextColor(ContextCompat.GetColor(this.Context, Resource.Color.White));

                this._bidPieChart.Data = pieData;
                this._bidPieChart.HighlightValues(null);
                this._bidPieChart.Invalidate();
                this._bidPieChart.AnimateY(1400, MikePhil.Charting.Animation.Easing.EaseInOutQuad);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"UIUpdateStats: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
            finally
            {
                this.SetIsWorking(false);
            }
        }

        private string ParseMinutesForDisplay(double milliseconds)
        {
            string result = string.Empty;
            TimeSpan span = TimeSpan.FromMilliseconds(milliseconds);

            if (span.Hours > 0)
            {
                result = $"{Math.Round(span.TotalHours, 1)} {this.GetString(Resource.String.text_hour_both_abbreviated)}";
            }
            else if (span.Minutes > 0)
            {
                result = $"{Math.Round(span.TotalMinutes, 1)} {this.GetString(Resource.String.text_minute_both_abbreviated)}";
            }
            else
            {
                result = $"{span.Seconds} {this.GetString(Resource.String.text_second_both_abbreviated)}";
            }

            return result;
        }

        private void ToggleFilterButtonState(Button button, bool active)
        {
            if (active)
            {
                button.Background.Mutate();
                button.Background.SetColorFilter(new Color(ContextCompat.GetColor(this.Context, Resource.Color.colorAccent)), PorterDuff.Mode.SrcAtop);
                button.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.colorAccentForeground));
            }
            else
            {
                button.Background.Mutate();
                button.Background.SetColorFilter(new Color(ContextCompat.GetColor(this.Context, Resource.Color.colorPrimary)), PorterDuff.Mode.SrcAtop);
                button.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimaryForeground));
            }
        }

        private List<int> GetPieChartColors()
        {
            List<int> colors = new List<int>
            {

                //foreach (int c in ColorTemplate.VordiplomColors)
                //    colors.Add(c);

                //foreach (int c in ColorTemplate.JoyfulColors)
                //    colors.Add(c);

                //foreach (int c in ColorTemplate.ColorfulColors)
                //    colors.Add(c);

                //foreach (int c in ColorTemplate.LibertyColors)
                //    colors.Add(c);

                //foreach (int c in ColorTemplate.PastelColors)
                //    colors.Add(c);

                new Color(134, 155, 160),
                new Color(43, 72, 106),
                new Color(163, 155, 176),
                new Color(210, 187, 162),
                new Color(90, 119, 2)
            };
            foreach (int c in ColorTemplate.LibertyColors)
            {
                colors.Add(c);
            }

            return colors;
        }
        #endregion

        #region Private Classes
        private class IntFormatter : LargeValueFormatter
        {
            private DecimalFormat format = new DecimalFormat("###,###,###");

            public override string GetFormattedValue(float value, Entry entry, int dataSetIndex, ViewPortHandler viewPortHandler)
            {
                return this.format.Format(entry.GetY());
            }
        }

        private class MoneyFormatter : LargeValueFormatter
        {
            private DecimalFormat format = new DecimalFormat("###,###,###");

            public override string GetFormattedValue(float value, Entry entry, int dataSetIndex, ViewPortHandler viewPortHandler)
            {
                return "$" + this.format.Format(entry.GetY());
            }
        }
        #endregion
    }
}