using System;
using System.Collections.Generic;
using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Core.Content;
using MikePhil.Charting.Charts;
using MikePhil.Charting.Data;
using MikePhil.Charting.Formatter;
using MikePhil.Charting.Util;
using Squelch.Activities;
using Squelch.Library;
using Squelch.Library.Data;
using Squelch.Library.Entities;
using Squelch.Library.Singletons;

namespace Squelch.Fragments
{
    public class StatisticsFragment : AndroidX.Fragment.App.Fragment
    {
        #region Instance Variables
        private static readonly string _tag = typeof(StatisticsFragment).FullName;

        private TextView _totalBlackouts, _totalBids, _totalTimeSaved;
        private PieChart _statusPieChart;
        private Button _filterOneWeekButton, _filterOneMonthButton, _filterOneYearButton;
        private enum Filter { Unknown, OneWeek, OneMonth, OneYear }
        private Filter _filterState;
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
                _totalBlackouts = view.FindViewById<TextView>(Resource.Id.fragment_statistics_overview_total_blackouts);
                _totalBids = view.FindViewById<TextView>(Resource.Id.fragment_statistics_overview_total_bids);
                _totalTimeSaved = view.FindViewById<TextView>(Resource.Id.fragment_statistics_overview_total_time);
                _filterOneWeekButton = view.FindViewById<Button>(Resource.Id.fragment_statistics_filter_one_week);
                _filterOneMonthButton = view.FindViewById<Button>(Resource.Id.fragment_statistics_filter_one_month);
                _filterOneYearButton = view.FindViewById<Button>(Resource.Id.fragment_statistics_filter_one_year);

                _statusPieChart = view.FindViewById<PieChart>(Resource.Id.fragment_statistics_blackout_statuses_pie_chart);
                _statusPieChart.Description.Enabled = false;
                _statusPieChart.DrawHoleEnabled = true;
                _statusPieChart.RotationEnabled = false;
                _statusPieChart.HighlightPerTapEnabled = false;
                _statusPieChart.HoleRadius = 40f;
                _statusPieChart.TransparentCircleRadius = 60f;
                _statusPieChart.SetHoleColor(Color.White);
                _statusPieChart.SetTransparentCircleColor(Color.White);
                _statusPieChart.SetTransparentCircleAlpha(125);
                _statusPieChart.SetDrawCenterText(true);
                _statusPieChart.AnimateY(1400, MikePhil.Charting.Animation.Easing.EaseInOutQuad);

                //
                // Hookup events
                _filterOneWeekButton.Click += delegate { UpdateFilter(Filter.OneWeek); };
                _filterOneMonthButton.Click += delegate { UpdateFilter(Filter.OneMonth); };
                _filterOneYearButton.Click += delegate { UpdateFilter(Filter.OneYear); };

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
                UpdateFilter(_filterState);

                //
                // Set firebase screen
                var firebaseAnalyticsManager = FirebaseAnalyticsManager.GetInstance();
                firebaseAnalyticsManager.SetCurrentScreen(this);

            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnResume: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }
        #endregion

        #region Control Events
        private void UpdateFilter(Filter filter)
        {
            _filterState = filter;

            // Toggle button states
            ToggleFilterButtonState(_filterOneWeekButton, (_filterState.Equals(Filter.OneWeek) ? true : false));
            ToggleFilterButtonState(_filterOneMonthButton, (_filterState.Equals(Filter.OneMonth) ? true : false));
            ToggleFilterButtonState(_filterOneYearButton, (_filterState.Equals(Filter.OneYear) ? true : false));

            // Update data
            UIUpdateStats(_filterState);
        }
        #endregion

        #region Helper Methods
        private async void UIUpdateStats(Filter filter)
        {
            Dictionary<string, string> blackoutStatistics;
            DateTime startDateTime;

            try
            {
                //
                // Determine starting date (in past)
                switch (filter)
                {
                    case Filter.OneWeek:
                        startDateTime = DateTime.Now.AddDays(-7);
                        break;
                    case Filter.OneMonth:
                        startDateTime = DateTime.Now.AddMonths(-1);
                        break;
                    case Filter.OneYear:
                        startDateTime = DateTime.Now.AddYears(-1);
                        break;
                    default:
                        startDateTime = DateTime.MinValue;
                        break;
                }

                //
                // Get stats from database
                blackoutStatistics = await BlackoutDatabase.GetBlackoutStatistics(startDateTime, DateTime.Now);
                var all = await BlackoutDatabase.FindAllAsync();
                //
                // Update view
                _totalBids.Text = $"${blackoutStatistics.GetValueOrDefault("total_bids_all", "0")}";
                _totalTimeSaved.Text = $"{ParseMinutesForDisplay(double.Parse(blackoutStatistics.GetValueOrDefault("total_milliseconds_saved_all", "0")))}";
                _totalBlackouts.Text = $"{blackoutStatistics.GetValueOrDefault("total_blackouts_all", "0")}";

                //
                // Status chart
                var statusDataEntries = new List<PieEntry>();
                foreach (BlackoutItem.BlackoutResultCode resultCode in Enum.GetValues(typeof(BlackoutItem.BlackoutResultCode)))
                {
                    //if (resultCode.Equals(BlackoutItem.BlackoutResultCode.Skipped) || resultCode.Equals(BlackoutItem.BlackoutResultCode.Pending))
                    //    continue;

                    var value = float.Parse(blackoutStatistics.GetValueOrDefault($"total_blackouts_{resultCode.ToString().ToLower()}", "0"));
                    if (value > 0)
                    {
                        statusDataEntries.Add(new PieEntry(value, resultCode.ToString()));
                    }
                }

                var statusDataSet = new PieDataSet(statusDataEntries, string.Empty);
                statusDataSet.SetDrawIcons(false);
                statusDataSet.SetColors(GetPieChartColors().ToArray());

                var statusData = new PieData(statusDataSet);
                statusData.SetValueTextSize(12f);
                statusData.SetValueTextColor(Color.White);

                _statusPieChart.Data = statusData;
                _statusPieChart.HighlightValues(null);
                _statusPieChart.Invalidate();
            }
            catch (Exception ex)
            {

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

            foreach (int c in ColorTemplate.ColorfulColors)
                colors.Add(c);

            //foreach (int c in ColorTemplate.LibertyColors)
            //    colors.Add(c);

            //foreach (int c in ColorTemplate.PastelColors)
            //    colors.Add(c);

            return colors;
        }
        #endregion
    }
}