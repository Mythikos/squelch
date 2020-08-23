using System;
using System.Collections.Generic;
using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Core.Content;
using Java.Interop;
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
                _rootLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_statistics_root_layout);
                _totalBlackouts = view.FindViewById<TextView>(Resource.Id.fragment_statistics_overview_total_blackouts);
                _totalBids = view.FindViewById<TextView>(Resource.Id.fragment_statistics_overview_total_bids);
                _totalTimeSaved = view.FindViewById<TextView>(Resource.Id.fragment_statistics_overview_total_time);
                _filterOneWeekButton = view.FindViewById<Button>(Resource.Id.fragment_statistics_filter_one_week);
                _filterOneMonthButton = view.FindViewById<Button>(Resource.Id.fragment_statistics_filter_one_month);
                _filterOneYearButton = view.FindViewById<Button>(Resource.Id.fragment_statistics_filter_one_year);

                _statusPieChart = view.FindViewById<PieChart>(Resource.Id.fragment_statistics_blackout_status_pie_chart);
                _statusPieChart.Description = new MikePhil.Charting.Components.Description() { Text = GetString(Resource.String.fragment_statistics_chart_description_outcomes) };
                _statusPieChart.DrawHoleEnabled = true;
                _statusPieChart.RotationEnabled = false;
                _statusPieChart.HighlightPerTapEnabled = false;
                _statusPieChart.HoleRadius = 50f;
                _statusPieChart.TransparentCircleRadius = 60f;
                _statusPieChart.SetTransparentCircleColor(Color.White);
                _statusPieChart.SetHoleColor(Color.White);
                _statusPieChart.SetTransparentCircleAlpha(125);
                _statusPieChart.SetDrawCenterText(true);

                _difficultyPieChart = view.FindViewById<PieChart>(Resource.Id.fragment_statistics_blackout_difficulty_pie_chart);
                _difficultyPieChart.Description = new MikePhil.Charting.Components.Description() { Text = GetString(Resource.String.fragment_statistics_chart_description_difficulties) };
                _difficultyPieChart.DrawHoleEnabled = true;
                _difficultyPieChart.RotationEnabled = false;
                _difficultyPieChart.HighlightPerTapEnabled = false;
                _difficultyPieChart.HoleRadius = 50f;
                _difficultyPieChart.TransparentCircleRadius = 60f;
                _difficultyPieChart.SetHoleColor(Color.White);
                _difficultyPieChart.SetTransparentCircleColor(Color.White);
                _difficultyPieChart.SetTransparentCircleAlpha(125);
                _difficultyPieChart.SetDrawCenterText(true);

                _bidPieChart = view.FindViewById<PieChart>(Resource.Id.fragment_statistics_blackout_bid_pie_chart);
                _bidPieChart.Description = new MikePhil.Charting.Components.Description() { Text = GetString(Resource.String.fragment_statistics_chart_description_bids) };
                _bidPieChart.DrawHoleEnabled = true;
                _bidPieChart.RotationEnabled = false;
                _bidPieChart.HighlightPerTapEnabled = false;
                _bidPieChart.HoleRadius = 50f;
                _bidPieChart.TransparentCircleRadius = 60f;
                _bidPieChart.SetHoleColor(Color.White);
                _bidPieChart.SetTransparentCircleColor(Color.White);
                _bidPieChart.SetTransparentCircleAlpha(125);
                _bidPieChart.SetDrawCenterText(true);

                //
                // Hookup events
                _filterOneWeekButton.Click += delegate { UpdateFilter(DateFilter.OneWeek); };
                _filterOneMonthButton.Click += delegate { UpdateFilter(DateFilter.OneMonth); };
                _filterOneYearButton.Click += delegate { UpdateFilter(DateFilter.OneYear); };

                //
                // Setup navbar
                ((MainActivity)this.Activity).SetupNavigation(Resource.String.title_statistics, true, false);
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
                if (_dateFilterState == DateFilter.Unknown)
                    _dateFilterState = DateFilter.OneWeek;
                UpdateFilter(_dateFilterState);

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
                _dateFilterState = filter;

                // Toggle button states
                ToggleFilterButtonState(_filterOneWeekButton, (_dateFilterState.Equals(DateFilter.OneWeek) ? true : false));
                ToggleFilterButtonState(_filterOneMonthButton, (_dateFilterState.Equals(DateFilter.OneMonth) ? true : false));
                ToggleFilterButtonState(_filterOneYearButton, (_dateFilterState.Equals(DateFilter.OneYear) ? true : false));

                // Update data
                UIUpdateStats(_dateFilterState);
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
            Library.Utilities.ViewUtils.SetViewAndChildrenEnabled(_rootLayout, !isWorking);

            // Report to parent
            if (this.Activity is IIndeterminateProgressReporter)
                ((IIndeterminateProgressReporter)this.Activity).SetProgressBarState(isWorking);
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
                SetIsWorking(true);

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
                _totalBids.Text = $"${blackoutStatistics.GetValueOrDefault("total_bids_all", "0")}";
                _totalTimeSaved.Text = $"{ParseMinutesForDisplay(double.Parse(blackoutStatistics.GetValueOrDefault("total_milliseconds_saved_all", "0")))}";
                _totalBlackouts.Text = $"{blackoutStatistics.GetValueOrDefault("total_blackouts_all", "0")}";

                //
                // Status chart
                pieDataEntries = new List<PieEntry>();
                foreach (BlackoutItem.BlackoutResultCode resultCode in Enum.GetValues(typeof(BlackoutItem.BlackoutResultCode)))
                {
                    if (resultCode.Equals(BlackoutItem.BlackoutResultCode.Pending))
                        continue;

                    var value = float.Parse(blackoutStatistics.GetValueOrDefault($"total_blackouts_{resultCode.ToString().ToLower()}", "0"));
                    if (value > 0)
                    {
                        pieDataEntries.Add(new PieEntry(value, resultCode.ToString()));
                    }
                }

                pieDataSet = new PieDataSet(pieDataEntries, string.Empty);
                pieDataSet.SetDrawIcons(false);
                pieDataSet.SetColors(GetPieChartColors().ToArray());

                pieData = new PieData(pieDataSet);
                pieData.SetValueFormatter(new IntFormatter());
                pieData.SetValueTextSize(12f);
                pieData.SetValueTextColor(ContextCompat.GetColor(this.Context, Resource.Color.White));

                _statusPieChart.Data = pieData;
                _statusPieChart.HighlightValues(null);
                _statusPieChart.Invalidate();
                _statusPieChart.AnimateY(1400, MikePhil.Charting.Animation.Easing.EaseInOutQuad);

                //
                // Difficulty chart
                pieDataEntries = new List<PieEntry>();
                foreach (BlackoutItem.BlackoutDifficultyCode difficultyCode in Enum.GetValues(typeof(BlackoutItem.BlackoutDifficultyCode)))
                {
                    if (difficultyCode.Equals(BlackoutItem.BlackoutResultCode.Pending))
                        continue;

                    var value = float.Parse(blackoutStatistics.GetValueOrDefault($"total_blackouts_{difficultyCode.ToString().ToLower()}", "0"));
                    if (value > 0)
                    {
                        pieDataEntries.Add(new PieEntry(value, difficultyCode.ToString()));
                    }
                }

                pieDataSet = new PieDataSet(pieDataEntries, string.Empty);
                pieDataSet.SetDrawIcons(false);
                pieDataSet.SetColors(GetPieChartColors().ToArray());

                pieData = new PieData(pieDataSet);
                pieData.SetValueFormatter(new IntFormatter());
                pieData.SetValueTextSize(12f);
                pieData.SetValueTextColor(ContextCompat.GetColor(this.Context, Resource.Color.White));

                _difficultyPieChart.Data = pieData;
                _difficultyPieChart.HighlightValues(null);
                _difficultyPieChart.Invalidate();
                _difficultyPieChart.AnimateY(1400, MikePhil.Charting.Animation.Easing.EaseInOutQuad);

                //
                // Bid chart
                pieDataEntries = new List<PieEntry>();
                foreach (BlackoutItem.BlackoutResultCode resultCode in Enum.GetValues(typeof(BlackoutItem.BlackoutResultCode)))
                {
                    if (resultCode.Equals(BlackoutItem.BlackoutResultCode.Pending))
                        continue;

                    var value = float.Parse(blackoutStatistics.GetValueOrDefault($"total_bids_{resultCode.ToString().ToLower()}", "0"));
                    if (value > 0)
                    {
                        pieDataEntries.Add(new PieEntry(value, resultCode.ToString()));
                    }
                }

                pieDataSet = new PieDataSet(pieDataEntries, string.Empty);
                pieDataSet.SetDrawIcons(false);
                pieDataSet.SetColors(GetPieChartColors().ToArray());

                pieData = new PieData(pieDataSet);
                pieData.SetValueFormatter(new MoneyFormatter());
                pieData.SetValueTextSize(12f);
                pieData.SetValueTextColor(ContextCompat.GetColor(this.Context, Resource.Color.White));

                _bidPieChart.Data = pieData;
                _bidPieChart.HighlightValues(null);
                _bidPieChart.Invalidate();
                _bidPieChart.AnimateY(1400, MikePhil.Charting.Animation.Easing.EaseInOutQuad);
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
                result = $"{Math.Round(span.TotalHours, 1)} hr(s)";
            }
            else if (span.Minutes > 0)
            {
                result = $"{Math.Round(span.TotalMinutes, 1)} min(s)";
            }
            else
            {
                result = $"{span.Seconds} sec(s)";
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
            List<int> colors = new List<int>();

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

            colors.Add(new Color(134, 155, 160));
            colors.Add(new Color(43, 72, 106));
            colors.Add(new Color(163, 155, 176));
            colors.Add(new Color(210, 187, 162));
            colors.Add(new Color(90, 119, 2));
            foreach (int c in ColorTemplate.LibertyColors)
                colors.Add(c);

            return colors;
        }
        #endregion

        #region Private Classes
        private class IntFormatter : LargeValueFormatter
        {
            private DecimalFormat format = new DecimalFormat("###,###,###");

            public override string GetFormattedValue(float value, Entry entry, int dataSetIndex, ViewPortHandler viewPortHandler)
            {
                return format.Format(entry.GetY());
            }
        }

        private class MoneyFormatter : LargeValueFormatter
        {
            private DecimalFormat format = new DecimalFormat("###,###,###");

            public override string GetFormattedValue(float value, Entry entry, int dataSetIndex, ViewPortHandler viewPortHandler)
            {
                return "$" + format.Format(entry.GetY());
            }
        }
        #endregion
    }
}