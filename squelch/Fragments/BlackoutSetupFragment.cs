﻿using Android.Content.PM;
using Android.Graphics;
using Android.Opengl;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Core.Content;
using AndroidX.Core.Widget;
using AndroidX.Fragment.App;
using AndroidX.RecyclerView.Widget;
using Squelch.Activities;
using Squelch.Dialogs;
using Squelch.Library;
using Squelch.Library.Data;
using Squelch.Library.Entities;
using Squelch.Library.Extensions;
using Squelch.Library.Interfaces;
using Squelch.Library.UI;
using Squelch.Library.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Squelch.Fragments
{
    public class BlackoutSetupFragment : Fragment
    {
        #region Instance Variables
        private static readonly string _tag = typeof(BlackoutSetupFragment).FullName;

        // Controls
        private LinearLayout _rootLayout;
        private TextView _titleLabel, _problemLabel;
        private Button _dialogPositiveButton, _dialogNegativeButton;

        // Difficulty
        private ScrollView _difficultyLayout;
        private Button _difficultyNoviceButton, _difficultyVeteranButton, _difficultyMasterButton;

        // Bid
        private NestedScrollView _bidLayout;
        private NumberPicker _bidNumberPicker;
        private TextView _bidValidValueRangeLabel;

        // Date range stuff
        private ScrollView _daterangeLayout;
        private Button _dateRangeStartDateButton, _dateRangeStartTimeButton, _dateRangeEndDateButton, _dateRangeEndTimeButton;
        private Button _dateRangeStartNowButton, _dateRangeStartPlus1Button, _dateRangeStartPlus5Button, _dateRangeStartPlus10Button, _dateRangeStartPlus30Button;
        private Button _dateRangeEndPlus1Button, _dateRangeEndPlus5Button, _dateRangeEndPlus10Button, _dateRangeEndPlus30Button;

        // Apps
        private LinearLayout _applicationLayout;
        private RecyclerView _applicationRecyclerView;
        private CheckBox _applicationShowSystemAppsCheckbox;
        private IMenuItem _applicationShowSystemAppsMenuItem;

        // Review
        private ScrollView _reviewLayout;
        private TextView _reviewDifficultyLabel, _reviewBidLabel, _reviewStartDateTimeLabel, _reviewEndDateTimeLabel, _reviewBlacklistLabel;

        // Instance variables
        private int _stepId;
        private BlackoutItem.BlackoutDifficultyCode _blackoutDifficulty;
        UIApplicationListAdapter _applicationListAdapter;
        List<UIApplicationItem> _applicationList;

        // Constants
        private const int STEP_DIFFICULTY = 1, STEP_BID = 2, STEP_DATE_RANGE = 3, STEP_APPLICATIONS = 4, STEP_REVIEW = 5;
        #endregion

        #region Native Events
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            _blackoutDifficulty = BlackoutItem.BlackoutDifficultyCode.Veteran;
            HasOptionsMenu = true;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view;

            //
            // Inflate the layour
            view = inflater.Inflate(Resource.Layout.fragment_blackout_setup, container, false);


            try
            {
                //
                // Get view elements
                _rootLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_blackout_setup_root_layout);
                _titleLabel = view.FindViewById<TextView>(Resource.Id.fragment_blackout_setup_title);
                _problemLabel = view.FindViewById<TextView>(Resource.Id.fragment_blackout_setup_problem_label);

                //
                // Difficulty related
                _difficultyLayout = view.FindViewById<ScrollView>(Resource.Id.fragment_blackout_setup_difficulty_layout);
                _difficultyNoviceButton = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_difficulty_novice_button);
                _difficultyVeteranButton = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_difficulty_veteran_button);
                _difficultyMasterButton = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_difficulty_master_button);

                _difficultyNoviceButton.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimary));
                _difficultyVeteranButton.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimary));
                _difficultyMasterButton.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimary));

                _difficultyNoviceButton.Click += (s, e) =>
                {
                    _difficultyNoviceButton.Background.Mutate();
                    _difficultyNoviceButton.Background.SetColorFilter(new Color(ContextCompat.GetColor(this.Context, Resource.Color.difficultyNovice)), PorterDuff.Mode.SrcAtop);
                    _difficultyNoviceButton.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.difficultyNoviceForeground));

                    _difficultyVeteranButton.Background.Mutate();
                    _difficultyVeteranButton.Background.ClearColorFilter();
                    _difficultyVeteranButton.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimary));

                    _difficultyMasterButton.Background.Mutate();
                    _difficultyMasterButton.Background.ClearColorFilter();
                    _difficultyMasterButton.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimary));

                    _blackoutDifficulty = BlackoutItem.BlackoutDifficultyCode.Novice;
                };
                _difficultyVeteranButton.Click += (s, e) =>
                {
                    _difficultyNoviceButton.Background.Mutate();
                    _difficultyNoviceButton.Background.ClearColorFilter();
                    _difficultyNoviceButton.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimary));

                    _difficultyVeteranButton.Background.Mutate();
                    _difficultyVeteranButton.Background.SetColorFilter(new Color(ContextCompat.GetColor(this.Context, Resource.Color.difficultyVeteran)), PorterDuff.Mode.SrcAtop);
                    _difficultyVeteranButton.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.difficultyVeteranForeground));

                    _difficultyMasterButton.Background.Mutate();
                    _difficultyMasterButton.Background.ClearColorFilter();
                    _difficultyMasterButton.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimary));

                    _blackoutDifficulty = BlackoutItem.BlackoutDifficultyCode.Veteran;
                };
                _difficultyMasterButton.Click += (s, e) =>
                {
                    _difficultyNoviceButton.Background.Mutate();
                    _difficultyNoviceButton.Background.ClearColorFilter();
                    _difficultyNoviceButton.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimary));

                    _difficultyVeteranButton.Background.Mutate();
                    _difficultyVeteranButton.Background.ClearColorFilter();
                    _difficultyVeteranButton.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimary));

                    _difficultyMasterButton.Background.Mutate();
                    _difficultyMasterButton.Background.SetColorFilter(new Color(ContextCompat.GetColor(this.Context, Resource.Color.difficultyMaster)), PorterDuff.Mode.SrcAtop);
                    _difficultyMasterButton.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.difficultyMasterForeground));

                    _blackoutDifficulty = BlackoutItem.BlackoutDifficultyCode.Master;
                };
                _difficultyVeteranButton.CallOnClick(); // Default to novice difficulty


                //
                // Bid related
                _bidLayout = view.FindViewById<NestedScrollView>(Resource.Id.fragment_blackout_setup_bid_layout);
                _bidNumberPicker = view.FindViewById<NumberPicker>(Resource.Id.fragment_blackout_setup_bid_number_picker);
                _bidValidValueRangeLabel = view.FindViewById<TextView>(Resource.Id.fragment_blackout_setup_bid_valid_values_label);

                //
                // Date range related
                _daterangeLayout = view.FindViewById<ScrollView>(Resource.Id.fragment_blackout_setup_date_range_layout);
                _dateRangeStartDateButton = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_start_date_button);
                _dateRangeStartTimeButton = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_start_time_button);
                _dateRangeEndDateButton = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_end_date_button);
                _dateRangeEndTimeButton = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_end_time_button);
                _dateRangeStartNowButton = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_start_now_button);
                _dateRangeStartPlus1Button = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_start_plus1_button);
                _dateRangeStartPlus5Button = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_start_plus5_button);
                _dateRangeStartPlus10Button = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_start_plus10_button);
                _dateRangeStartPlus30Button = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_start_plus30_button);
                _dateRangeEndPlus1Button = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_end_plus1_button);
                _dateRangeEndPlus5Button = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_end_plus5_button);
                _dateRangeEndPlus10Button = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_end_plus10_button);
                _dateRangeEndPlus30Button = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_end_plus30_button);


                _dateRangeStartDateButton.Click += delegate
                {
                    DatePickerDialogFragment datePickerFragment = DatePickerDialogFragment.NewInstance(delegate (DateTime dateTime)
                    {
                        _dateRangeStartDateButton.Text = DateUtils.FormatDateLong(dateTime);
                    });
                    datePickerFragment.Show(this.FragmentManager, $"{this.GetType().Name}{typeof(DatePickerDialogFragment).Name}");
                };
                _dateRangeStartTimeButton.Click += delegate
                {
                    TimePickerDialogFragment timePickerFragment = TimePickerDialogFragment.NewInstance(delegate (DateTime dateTime)
                    {
                        _dateRangeStartTimeButton.Text = DateUtils.FormatTime(dateTime, UserSettings.FormatTimeAsMilitary);
                    });
                    timePickerFragment.Show(this.FragmentManager, $"{this.GetType().Name}{typeof(DatePickerDialogFragment).Name}");
                };
                _dateRangeEndDateButton.Click += delegate
                {
                    DatePickerDialogFragment datePickerFragment = DatePickerDialogFragment.NewInstance(delegate (DateTime dateTime)
                    {
                        _dateRangeEndDateButton.Text = DateUtils.FormatDateLong(dateTime);
                    });
                    datePickerFragment.Show(this.FragmentManager, $"{this.GetType().Name}{typeof(DatePickerDialogFragment).Name}");
                };
                _dateRangeEndTimeButton.Click += delegate
                {
                    TimePickerDialogFragment timePickerFragment = TimePickerDialogFragment.NewInstance(delegate (DateTime dateTime)
                    {
                        _dateRangeEndTimeButton.Text = DateUtils.FormatTime(dateTime, UserSettings.FormatTimeAsMilitary);
                    });
                    timePickerFragment.Show(this.FragmentManager, $"{this.GetType().Name}{typeof(DatePickerDialogFragment).Name}");
                };

                _dateRangeStartNowButton.Click += delegate
                {
                    DateTime dateTime;

                    // Just get the time as of right now
                    dateTime = DateTime.Now;

                    // Set labels
                    _dateRangeStartDateButton.Text = DateUtils.FormatDateLong(dateTime);
                    _dateRangeStartTimeButton.Text = DateUtils.FormatTime(dateTime, UserSettings.FormatTimeAsMilitary);
                };

                _dateRangeStartPlus1Button.Click += delegate
                {
                    DateTime dateTime;

                    // Both date and time are not valid
                    if (DateTime.TryParse($"{_dateRangeStartDateButton.Text} {_dateRangeStartTimeButton.Text}", out dateTime) == false)
                        // Time is not valid
                        if (DateTime.TryParse($"{DateUtils.FormatDateLong(DateTime.Now)} {_dateRangeStartTimeButton.Text}", out dateTime) == false)
                            // Date is not valid
                            if (DateTime.TryParse($"{_dateRangeStartDateButton.Text} {DateUtils.FormatTime(DateTime.Now, UserSettings.FormatTimeAsMilitary)}", out dateTime) == false)
                                dateTime = DateTime.Now;

                    // Set labels
                    _dateRangeStartDateButton.Text = DateUtils.FormatDateLong(dateTime.AddMinutes(1));
                    _dateRangeStartTimeButton.Text = DateUtils.FormatTime(dateTime.AddMinutes(1), UserSettings.FormatTimeAsMilitary);
                };
                _dateRangeStartPlus5Button.Click += delegate
                {
                    DateTime dateTime;

                    // Both date and time are not valid
                    if (DateTime.TryParse($"{_dateRangeStartDateButton.Text} {_dateRangeStartTimeButton.Text}", out dateTime) == false)
                        // Time is not valid
                        if (DateTime.TryParse($"{DateUtils.FormatDateLong(DateTime.Now)} {_dateRangeStartTimeButton.Text}", out dateTime) == false)
                            // Date is not valid
                            if (DateTime.TryParse($"{_dateRangeStartDateButton.Text} {DateUtils.FormatTime(DateTime.Now, UserSettings.FormatTimeAsMilitary)}", out dateTime) == false)
                                dateTime = DateTime.Now;

                    // Set labels
                    _dateRangeStartDateButton.Text = DateUtils.FormatDateLong(dateTime.AddMinutes(5));
                    _dateRangeStartTimeButton.Text = DateUtils.FormatTime(dateTime.AddMinutes(5), UserSettings.FormatTimeAsMilitary);
                };
                _dateRangeStartPlus10Button.Click += delegate
                {
                    DateTime dateTime;

                    // Both date and time are not valid
                    if (DateTime.TryParse($"{_dateRangeStartDateButton.Text} {_dateRangeStartTimeButton.Text}", out dateTime) == false)
                        // Time is not valid
                        if (DateTime.TryParse($"{DateUtils.FormatDateLong(DateTime.Now)} {_dateRangeStartTimeButton.Text}", out dateTime) == false)
                            // Date is not valid
                            if (DateTime.TryParse($"{_dateRangeStartDateButton.Text} {DateUtils.FormatTime(DateTime.Now, UserSettings.FormatTimeAsMilitary)}", out dateTime) == false)
                                dateTime = DateTime.Now;

                    // Set labels
                    _dateRangeStartDateButton.Text = DateUtils.FormatDateLong(dateTime.AddMinutes(10));
                    _dateRangeStartTimeButton.Text = DateUtils.FormatTime(dateTime.AddMinutes(10), UserSettings.FormatTimeAsMilitary);
                };
                _dateRangeStartPlus30Button.Click += delegate
                {
                    DateTime dateTime;

                    // Both date and time are not valid
                    if (DateTime.TryParse($"{_dateRangeStartDateButton.Text} {_dateRangeStartTimeButton.Text}", out dateTime) == false)
                        // Time is not valid
                        if (DateTime.TryParse($"{DateUtils.FormatDateLong(DateTime.Now)} {_dateRangeStartTimeButton.Text}", out dateTime) == false)
                            // Date is not valid
                            if (DateTime.TryParse($"{_dateRangeStartDateButton.Text} {DateUtils.FormatTime(DateTime.Now, UserSettings.FormatTimeAsMilitary)}", out dateTime) == false)
                                dateTime = DateTime.Now;

                    // Set labels
                    _dateRangeStartDateButton.Text = DateUtils.FormatDateLong(dateTime.AddMinutes(30));
                    _dateRangeStartTimeButton.Text = DateUtils.FormatTime(dateTime.AddMinutes(30), UserSettings.FormatTimeAsMilitary);
                };

                _dateRangeEndPlus1Button.Click += delegate
                {
                    DateTime dateTime;

                    // Both date and time are not valid
                    if (DateTime.TryParse($"{_dateRangeEndDateButton.Text} {_dateRangeEndTimeButton.Text}", out dateTime) == false)
                        // Time is not valid
                        if (DateTime.TryParse($"{DateUtils.FormatDateLong(DateTime.Now)} {_dateRangeEndTimeButton.Text}", out dateTime) == false)
                            // Date is not valid
                            if (DateTime.TryParse($"{_dateRangeEndDateButton.Text} {DateUtils.FormatTime(DateTime.Now, UserSettings.FormatTimeAsMilitary)}", out dateTime) == false)
                                dateTime = DateTime.Now;

                    // Set labels
                    _dateRangeEndDateButton.Text = DateUtils.FormatDateLong(dateTime.AddMinutes(1));
                    _dateRangeEndTimeButton.Text = DateUtils.FormatTime(dateTime.AddMinutes(1), UserSettings.FormatTimeAsMilitary);
                };
                _dateRangeEndPlus5Button.Click += delegate
                {
                    DateTime dateTime;

                    // Both date and time are not valid
                    if (DateTime.TryParse($"{_dateRangeEndDateButton.Text} {_dateRangeEndTimeButton.Text}", out dateTime) == false)
                        // Time is not valid
                        if (DateTime.TryParse($"{DateUtils.FormatDateLong(DateTime.Now)} {_dateRangeEndTimeButton.Text}", out dateTime) == false)
                            // Date is not valid
                            if (DateTime.TryParse($"{_dateRangeEndDateButton.Text} {DateUtils.FormatTime(DateTime.Now, UserSettings.FormatTimeAsMilitary)}", out dateTime) == false)
                                dateTime = DateTime.Now;

                    // Set labels
                    _dateRangeEndDateButton.Text = DateUtils.FormatDateLong(dateTime.AddMinutes(5));
                    _dateRangeEndTimeButton.Text = DateUtils.FormatTime(dateTime.AddMinutes(5), UserSettings.FormatTimeAsMilitary);
                };
                _dateRangeEndPlus10Button.Click += delegate
                {
                    DateTime dateTime;

                    // Both date and time are not valid
                    if (DateTime.TryParse($"{_dateRangeEndDateButton.Text} {_dateRangeEndTimeButton.Text}", out dateTime) == false)
                        // Time is not valid
                        if (DateTime.TryParse($"{DateUtils.FormatDateLong(DateTime.Now)} {_dateRangeEndTimeButton.Text}", out dateTime) == false)
                            // Date is not valid
                            if (DateTime.TryParse($"{_dateRangeEndDateButton.Text} {DateUtils.FormatTime(DateTime.Now, UserSettings.FormatTimeAsMilitary)}", out dateTime) == false)
                                dateTime = DateTime.Now;

                    // Set labels
                    _dateRangeEndDateButton.Text = DateUtils.FormatDateLong(dateTime.AddMinutes(10));
                    _dateRangeEndTimeButton.Text = DateUtils.FormatTime(dateTime.AddMinutes(10), UserSettings.FormatTimeAsMilitary);
                };
                _dateRangeEndPlus30Button.Click += delegate
                {
                    DateTime dateTime;

                    // Both date and time are not valid
                    if (DateTime.TryParse($"{_dateRangeEndDateButton.Text} {_dateRangeEndTimeButton.Text}", out dateTime) == false)
                        // Time is not valid
                        if (DateTime.TryParse($"{DateUtils.FormatDateLong(DateTime.Now)} {_dateRangeEndTimeButton.Text}", out dateTime) == false)
                            // Date is not valid
                            if (DateTime.TryParse($"{_dateRangeEndDateButton.Text} {DateUtils.FormatTime(DateTime.Now, UserSettings.FormatTimeAsMilitary)}", out dateTime) == false)
                                dateTime = DateTime.Now;

                    // Set labels
                    _dateRangeEndDateButton.Text = DateUtils.FormatDateLong(dateTime.AddMinutes(30));
                    _dateRangeEndTimeButton.Text = DateUtils.FormatTime(dateTime.AddMinutes(30), UserSettings.FormatTimeAsMilitary);
                };

                //
                // Application related
                _applicationLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_blackout_setup_application_layout);
                _applicationRecyclerView = view.FindViewById<RecyclerView>(Resource.Id.fragment_blackout_setup_application_recycler_view);

                // Init the instance application list
                ApplicationList_Initialize();

                // Init the application list adapter
                _applicationListAdapter = new UIApplicationListAdapter(new List<UIApplicationItem>());
                _applicationRecyclerView.AddItemDecoration(new DividerItemDecoration(this.Context, DividerItemDecoration.Vertical));
                _applicationRecyclerView.SetLayoutManager(new LinearLayoutManager(this.Context));
                _applicationRecyclerView.SetItemAnimator(new DefaultItemAnimator());
                _applicationRecyclerView.SetAdapter(_applicationListAdapter);
                _applicationListAdapter.OnApplicationSelected += ApplicationListAdapter_OnApplicationSelected;
                //ViewCompat.SetNestedScrollingEnabled(_applicationRecyclerView, false); // Normalize scrolling in nested scroll view

                //
                // Review related
                _reviewLayout = view.FindViewById<ScrollView>(Resource.Id.fragment_blackout_setup_review_layout);
                _reviewDifficultyLabel = view.FindViewById<TextView>(Resource.Id.fragment_blackout_setup_review_difficulty_label);
                _reviewBidLabel = view.FindViewById<TextView>(Resource.Id.fragment_blackout_setup_review_bid_label);
                _reviewStartDateTimeLabel = view.FindViewById<TextView>(Resource.Id.fragment_blackout_setup_review_start_date_label);
                _reviewEndDateTimeLabel = view.FindViewById<TextView>(Resource.Id.fragment_blackout_setup_review_end_date_label);
                _reviewBlacklistLabel = view.FindViewById<TextView>(Resource.Id.fragment_blackout_setup_review_blacklist_label);

                //
                // Working/Status related
                _dialogPositiveButton = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_button_positive);
                _dialogNegativeButton = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_button_negative);
                _dialogPositiveButton.Click += PositiveButton_Click;
                _dialogNegativeButton.Click += NegativeButton_Click;

                //
                // Setup navbar
                ((MainActivity)this.Activity).SetupNavigation(Resource.String.text_blackout_setup, false, true);

                //
                // Set view stuff
                _stepId = 0;
                _problemLabel.Text = string.Empty;
                _dialogPositiveButton.SetButtonText(GetString(Resource.String.text_next));
                _dialogNegativeButton.SetButtonText(GetString(Resource.String.text_cancel));
                PositiveButton_Click(this, null);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnCreateView: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            // return the view
            return view;
        }

        public override void OnResume()
        {
            base.OnResume();

            try
            {
                //
                // Set firebase screen
                FirebaseAnalyticsUtils.SetCurrentScreen(this);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnResume: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        public override void OnCreateOptionsMenu(IMenu menu, MenuInflater inflater)
        {
            // Create a new checkbox to add to the options menu
            _applicationShowSystemAppsCheckbox = (CheckBox)this.LayoutInflater.Inflate(Resource.Drawable.check_box_right, null);
            _applicationShowSystemAppsCheckbox.Checked = false;
            _applicationShowSystemAppsCheckbox.Click += delegate { ApplicationList_Filter(); };
            _applicationShowSystemAppsCheckbox.Text = GetString(Resource.String.text_show_system_applications);
            _applicationShowSystemAppsCheckbox.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimaryForeground)); // This is the title bar which is colorPrimary
            _applicationShowSystemAppsCheckbox.ButtonTintList = ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimaryForeground); // This is the title bar which is colorPrimary

            // Add new item to menu
            _applicationShowSystemAppsMenuItem = menu.Add(GetString(Resource.String.text_show_system_applications));
            _applicationShowSystemAppsMenuItem.SetActionView(_applicationShowSystemAppsCheckbox);
            _applicationShowSystemAppsMenuItem.SetShowAsAction(ShowAsAction.Always);
            _applicationShowSystemAppsMenuItem.SetVisible((_stepId == STEP_APPLICATIONS) ? true : false);
        }
        #endregion

        #region Control Events
        /// <summary>
        /// Called when an application from the application list is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="index"></param>
        private void ApplicationListAdapter_OnApplicationSelected(object sender, int index)
        {
            UIApplicationItem uiApplicationItem;

            try
            {
                uiApplicationItem = _applicationListAdapter.ApplicationList[index];
                if (uiApplicationItem != null)
                {
                    // If its locked, its being forced for one reason or another, dont allow a toggle
                    if (uiApplicationItem.IsDifficultyLocked)
                    {
                        DisplayUtils.ShowGenericAlertDialog(this.Context, Resource.String.text_notice, Resource.String.fragment_blackout_setup_application_selection_blocked_by_difficulty_warning, true, Resource.String.text_ok);
                    }

                    // If its recommended to be locked, notify them (and then unlock it if they are being stingy)
                    else if (uiApplicationItem.IsSelected && EnforcerUtils.ShouldBlockApplication(this.Context, uiApplicationItem.PackageName))
                    {
                        DisplayUtils.ShowGenericAlertDialog(this.Context, Resource.String.text_notice, Resource.String.fragment_blackout_setup_application_selection_circumvents_behavior_warning, true, Resource.String.text_unlock, delegate { uiApplicationItem.SetSelected(false); }, Resource.String.text_cancel);
                    }

                    // Toggle as normal
                    else
                    {
                        uiApplicationItem.ToggleSelected();
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"ApplicationListAdapter_OnApplicationSelected: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Processes the positive button click
        /// </summary>
        /// <param name="dialog"></param>
        /// <param name="which"></param>
        private async void PositiveButton_Click(object sender, EventArgs e)
        {
            // Set is working
            SetIsWorking(true);


            try
            {
                // Disable next and back button
                _dialogPositiveButton.Enabled = false;
                _dialogNegativeButton.Enabled = false;

                // Determine action
                if (_dialogPositiveButton.Text.Equals(GetString(Resource.String.text_next))) // This is dumb but meh
                {
                    NextStep();
                }
                else if (_dialogPositiveButton.Text.Equals(GetString(Resource.String.text_finish))) // This is dumb but meh
                {
                    //
                    // Assign the values
                    BlackoutItem blackoutItem = new BlackoutItem
                    {
                        ScheduledStartDateTime = DateTime.Parse($"{_dateRangeStartDateButton.Text} {_dateRangeStartTimeButton.Text}"),
                        ScheduledEndDateTime = DateTime.Parse($"{_dateRangeEndDateButton.Text} {_dateRangeEndTimeButton.Text}"),
                        DifficultyCode = _blackoutDifficulty,
                        Bid = _bidNumberPicker.Value,
                        Blacklist = _applicationList.Where(x => x.IsSelected).Select(x => x.PackageName).ToList()
                    }.SetBlackoutPending();
                    await BlackoutDatabase.UpsertAsync(blackoutItem);

                    //
                    // Dismiss
                    this.FragmentManager.PopBackStack();
                }

                // Enable next and back button
                _dialogPositiveButton.Enabled = true;
                _dialogNegativeButton.Enabled = true;
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"PositiveButton_Click: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
            finally
            {
                // Set no longer working
                SetIsWorking(false);

            }
        }

        /// <summary>
        /// Processes the negative button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NegativeButton_Click(object sender, EventArgs e)
        {
            // Set is working
            SetIsWorking(true);


            try
            {
                // Disable next and back button
                _dialogPositiveButton.Enabled = false;
                _dialogNegativeButton.Enabled = false;

                // Determine action
                if (_dialogNegativeButton.Text.Equals(GetString(Resource.String.text_back)))
                {
                    PreviousStep();
                }
                else if (_dialogNegativeButton.Text.Equals(GetString(Resource.String.text_cancel)))
                {
                    ConfirmClose();
                }

                // Enable next and back button
                _dialogPositiveButton.Enabled = true;
                _dialogNegativeButton.Enabled = true;
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"NegativeButton_Click: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
            finally
            {
                // Set no longer working
                SetIsWorking(false);

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
            ViewUtils.SetViewAndChildrenEnabled(_rootLayout, !isWorking);

            // Report to parent
            if (this.Activity is IIndeterminateProgressReporter)
                ((IIndeterminateProgressReporter)this.Activity).SetProgressBarState(isWorking);
        }

        /// <summary>
        /// Confirms with the user that they want to close the setup
        /// </summary>
        private void ConfirmClose()
        {
            try
            {
                DisplayUtils.ShowGenericAlertDialog(this.Context, Resource.String.text_confirm, Resource.String.text_are_you_sure_cancel, true, Resource.String.text_yes, delegate { this.FragmentManager.PopBackStack(); }, Resource.String.text_no);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"ConfirmClose: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Builds the global application list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApplicationList_Initialize()
        {
            //
            // Vars
            bool isSystem = false;
            bool isSelected = false;
            string category = string.Empty;

            try
            {
                //
                // Init
                _applicationList = new List<UIApplicationItem>();

                //
                // Sift through and setup items
                foreach (ApplicationInfo applicationInfo in this.Context.PackageManager.GetInstalledApplications(true))
                {
                    // (Re)init
                    isSystem = (applicationInfo.Flags & ApplicationInfoFlags.System) == ApplicationInfoFlags.System;
                    isSelected = false;
                    category = string.Empty;

                    // Is this squelch?
                    if (applicationInfo.PackageName.Equals(this.Context.PackageName))
                        continue;

                    // Do we have categories?
                    if (Build.VERSION.SdkInt >= BuildVersionCodes.O)
                        category = ((applicationInfo.Category != ApplicationCategories.Undefined) ? applicationInfo.Category.ToString() : string.Empty);

                    // Is this app in the recommended block list?
                    if (EnforcerUtils.ShouldBlockApplication(this.Context, applicationInfo.PackageName))
                        isSelected = true;

                    // Add it to the UI application list
                    _applicationList.Add(new UIApplicationItem(this.Context, applicationInfo)
                    {
                        Category = category,
                        IsSelected = isSelected,
                        IsSystem = isSystem
                    });
                }
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"ApplicationList_Initialize: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Called when the application list is being updated
        /// </summary>
        private void ApplicationList_Filter()
        {
            try
            {
                //
                // Add / remove system apps
                if (_applicationShowSystemAppsCheckbox.Checked)
                {
                    _applicationListAdapter.ApplicationList = _applicationList
                        .OrderBy(x => x.Name)
                        .ToList()
                        .Copy();
                }
                else
                {
                    _applicationListAdapter.ApplicationList = _applicationList
                        .Where(x => x.IsSystem == false)
                        .OrderBy(x => x.Name)
                        .ToList()
                        .Copy();
                }

                //
                // Apply difficulty settings
                foreach (UIApplicationItem uiApplicationItem in _applicationListAdapter.ApplicationList)
                {
                    uiApplicationItem.IsDifficultyLocked = false;
                    if (EnforcerUtils.ShouldBlockApplication(this.Context, uiApplicationItem.PackageName) || uiApplicationItem.IsSystem == false)
                    {
                        switch (_blackoutDifficulty)
                        {
                            case BlackoutItem.BlackoutDifficultyCode.Novice:
                            case BlackoutItem.BlackoutDifficultyCode.Veteran:
                                break;
                            case BlackoutItem.BlackoutDifficultyCode.Master:
                                uiApplicationItem.IsSelected = true;
                                uiApplicationItem.IsDifficultyLocked = true;
                                break;
                        }
                    }
                }

                //
                // Notify change
                _applicationListAdapter.NotifyDataSetChanged();
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnCreateView: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }
        #endregion

        #region Step Methods
        /// <summary>
        /// Helper method to increment to next step
        /// </summary>
        private async void NextStep()
        {
            try
            {
                if (await ValidateStep(_stepId))
                    ProcessStep(++_stepId);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"NextStep: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Helper method to decrement to the previous step
        /// </summary>
        private void PreviousStep()
        {
            try
            {
                ProcessStep(--_stepId);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"PreviousStep: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Sets the view up for the currently set step
        /// </summary>
        /// <param name="stepId"></param>
        private void ProcessStep(int step)
        {
            try
            {
                // Handle move and view state
                switch (step)
                {
                    case STEP_DIFFICULTY:
                        _dialogPositiveButton.SetText(Resource.String.text_next);
                        _dialogNegativeButton.SetText(Resource.String.text_cancel);
                        _titleLabel.SetText(Resource.String.fragment_blackout_setup_difficulty_title);
                        _difficultyLayout.Visibility = ViewStates.Visible;
                        _bidLayout.Visibility = ViewStates.Gone;
                        _daterangeLayout.Visibility = ViewStates.Gone;
                        _applicationLayout.Visibility = _applicationShowSystemAppsCheckbox.Visibility = ViewStates.Gone;
                        _reviewLayout.Visibility = ViewStates.Gone;
                        break;
                    case STEP_BID:
                        _dialogPositiveButton.SetText(Resource.String.text_next);
                        _dialogNegativeButton.SetText(Resource.String.text_back);
                        _titleLabel.SetText(Resource.String.fragment_blackout_setup_bid_title);
                        _difficultyLayout.Visibility = ViewStates.Gone;
                        _bidLayout.Visibility = ViewStates.Visible;
                        _daterangeLayout.Visibility = ViewStates.Gone;
                        _applicationLayout.Visibility = _applicationShowSystemAppsCheckbox.Visibility = ViewStates.Gone;
                        _reviewLayout.Visibility = ViewStates.Gone;
                        switch (_blackoutDifficulty)
                        {
                            case BlackoutItem.BlackoutDifficultyCode.Novice:
                                _bidNumberPicker.MinValue = 0;
                                _bidNumberPicker.MaxValue = 250;
                                break;
                            case BlackoutItem.BlackoutDifficultyCode.Veteran:
                                _bidNumberPicker.MinValue = 1;
                                _bidNumberPicker.MaxValue = 250;
                                break;
                            case BlackoutItem.BlackoutDifficultyCode.Master:
                                _bidNumberPicker.MinValue = 1;
                                _bidNumberPicker.MaxValue = 250;
                                break;
                        }
                        _bidNumberPicker.Value = _bidNumberPicker.MinValue;
                        _bidValidValueRangeLabel.Text = string.Format(GetString(Resource.String.fragment_blackout_setup_bid_range), _bidNumberPicker.MinValue, _bidNumberPicker.MaxValue);
                        break;
                    case STEP_DATE_RANGE:
                        _dialogPositiveButton.SetText(Resource.String.text_next);
                        _dialogNegativeButton.SetText(Resource.String.text_back);
                        _titleLabel.SetText(Resource.String.fragment_blackout_setup_date_range_title);
                        _difficultyLayout.Visibility = ViewStates.Gone;
                        _bidLayout.Visibility = ViewStates.Gone;
                        _daterangeLayout.Visibility = ViewStates.Visible;
                        _applicationLayout.Visibility = _applicationShowSystemAppsCheckbox.Visibility = ViewStates.Gone;
                        _reviewLayout.Visibility = ViewStates.Gone;
                        break;
                    case STEP_APPLICATIONS:
                        _dialogPositiveButton.SetText(Resource.String.text_next);
                        _dialogNegativeButton.SetText(Resource.String.text_back);
                        _titleLabel.SetText(Resource.String.fragment_blackout_setup_application_selection_title);
                        _difficultyLayout.Visibility = ViewStates.Gone;
                        _bidLayout.Visibility = ViewStates.Gone;
                        _daterangeLayout.Visibility = ViewStates.Gone;
                        _applicationLayout.Visibility = _applicationShowSystemAppsCheckbox.Visibility = ViewStates.Visible;
                        _reviewLayout.Visibility = ViewStates.Gone;
                        ApplicationList_Filter();
                        break;
                    case STEP_REVIEW:
                        var blackoutDifficultyTextResourceId = Resource.String.text_unknown;
                        switch (_blackoutDifficulty)
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

                        _dialogPositiveButton.SetText(Resource.String.text_finish);
                        _dialogNegativeButton.SetText(Resource.String.text_back);
                        _titleLabel.SetText(Resource.String.fragment_blackout_setup_review_title);
                        _difficultyLayout.Visibility = ViewStates.Gone;
                        _bidLayout.Visibility = ViewStates.Gone;
                        _daterangeLayout.Visibility = ViewStates.Gone;
                        _applicationLayout.Visibility = _applicationShowSystemAppsCheckbox.Visibility = ViewStates.Gone;
                        _reviewLayout.Visibility = ViewStates.Visible;
                        _reviewDifficultyLabel.SetText(blackoutDifficultyTextResourceId);
                        _reviewBidLabel.Text = $"${_bidNumberPicker.Value}";
                        _reviewStartDateTimeLabel.Text = $"{_dateRangeStartDateButton.Text} @ {_dateRangeStartTimeButton.Text}";
                        _reviewEndDateTimeLabel.Text = $"{_dateRangeEndDateButton.Text} @ {_dateRangeEndTimeButton.Text}";
                        _reviewBlacklistLabel.Text = string.Join(", ", _applicationList.Where(x => x.IsSelected).Select(x => x.Name).ToList());
                        break;
                    default:
                        _difficultyLayout.Visibility = ViewStates.Gone;
                        _bidLayout.Visibility = ViewStates.Gone;
                        _daterangeLayout.Visibility = ViewStates.Gone;
                        _applicationLayout.Visibility = _applicationShowSystemAppsCheckbox.Visibility = ViewStates.Gone;
                        _reviewLayout.Visibility = ViewStates.Gone;
                        break;
                }

                // Set the menu state based on the result of the switch
                _applicationShowSystemAppsMenuItem.SetVisible((_applicationLayout.Visibility == ViewStates.Visible) ? true : false);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"ProcessStep: {step}: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Validates the input step
        /// </summary>
        /// <param name="step"></param>
        /// <returns></returns>
        private async Task<bool> ValidateStep(int step)
        {
            DateTime startDateTime;
            DateTime endDateTime;

            try
            {
                // Reset
                _problemLabel.Text = string.Empty;

                // Which step are we validating
                switch (step)
                {
                    case STEP_DIFFICULTY:
                        // Difficulty
                        // Nothing needs to be checked
                        break;
                    case STEP_BID:
                        // Bid
                        // Nothing needs to be checked
                        break;
                    case STEP_DATE_RANGE:
                        // Date Ranges
                        if (DateTime.TryParse($"{_dateRangeStartDateButton.Text} {_dateRangeStartTimeButton.Text}", out startDateTime) == false) // Start date is valid
                        {
                            _problemLabel.Text += this.GetString(Resource.String.fragment_blackout_setup_validation_start_date_invalid) + " ";
                            return false;
                        }

                        if (DateTime.TryParse($"{_dateRangeEndDateButton.Text} {_dateRangeEndTimeButton.Text}", out endDateTime) == false) // End date is valid
                        {
                            _problemLabel.Text += this.GetString(Resource.String.fragment_blackout_setup_validation_end_date_invalid) + " ";
                            return false;
                        }

                        if (endDateTime < DateTime.Now) // The end date is before the current time, whats the point?
                        {
                            _problemLabel.Text += this.GetString(Resource.String.fragment_blackout_setup_validation_end_date_in_the_past) + " ";
                            return false;
                        }

                        if (startDateTime > endDateTime) // Start date must be before the end date
                        {
                            _problemLabel.Text += this.GetString(Resource.String.fragment_blackout_setup_validation_start_date_cannot_be_greater_than_end_date) + " ";
                            return false;
                        }

                        if ((endDateTime - startDateTime).TotalMinutes < 1) // Blackout must be more than 1 minute
                        {
                            _problemLabel.Text += this.GetString(Resource.String.fragment_blackout_setup_validation_duration_of_blackout_must_be_greater_than_1_minute) + " ";
                            return false;
                        }

                        if (endDateTime.Subtract(DateTime.Now).TotalDays > 30) // Blackout must be less than 30 days
                        {
                            _problemLabel.Text += this.GetString(Resource.String.fragment_blackout_setup_validation_duration_of_blackout_must_be_less_than_30_days) + " ";
                            return false;
                        }

                        if (await BlackoutDatabase.HasConflictInRangeAsync(startDateTime, endDateTime))
                        {
                            _problemLabel.Text += this.GetString(Resource.String.fragment_blackout_setup_validation_blackout_overlaps) + " ";
                            return false;
                        }
                        break;
                    case STEP_APPLICATIONS:
                        // Applications
                        if (_applicationList.Where(x => x.IsSelected).Select(x => x.PackageName).ToList().Count() <= 0)
                        {
                            _problemLabel.Text += this.GetString(Resource.String.fragment_blackout_setup_validation_no_application_selected) + " ";
                            return false;
                        }
                        break;
                    case STEP_REVIEW:
                        // Review
                        break;
                }
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"ValidateStep: {step}: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            return true;
        }
        #endregion
    }
}