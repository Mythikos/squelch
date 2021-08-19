using Android.Content.PM;
using Android.Graphics;
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
        private DateTime _blackoutStartDateTime;
        private DateTime _blackoutEndDateTime;
        private BlackoutItem.BlackoutDifficultyCode _blackoutDifficulty;
        private UIApplicationListAdapter _applicationListAdapter;
        private List<UIApplicationItem> _applicationList;

        // Constants
        private const int STEP_DIFFICULTY = 1, STEP_BID = 2, STEP_DATE_RANGE = 3, STEP_APPLICATIONS = 4, STEP_REVIEW = 5;
        #endregion

        #region Native Events
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this._blackoutStartDateTime = DateTime.Now;
            this._blackoutEndDateTime = DateTime.Now;
            this._blackoutDifficulty = BlackoutItem.BlackoutDifficultyCode.Veteran;
            this.HasOptionsMenu = true;
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
                this._rootLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_blackout_setup_root_layout);
                this._titleLabel = view.FindViewById<TextView>(Resource.Id.fragment_blackout_setup_title);
                this._problemLabel = view.FindViewById<TextView>(Resource.Id.fragment_blackout_setup_problem_label);

                //
                // Difficulty related
                this._difficultyLayout = view.FindViewById<ScrollView>(Resource.Id.fragment_blackout_setup_difficulty_layout);
                this._difficultyNoviceButton = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_difficulty_novice_button);
                this._difficultyVeteranButton = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_difficulty_veteran_button);
                this._difficultyMasterButton = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_difficulty_master_button);

                this._difficultyNoviceButton.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimary));
                this._difficultyVeteranButton.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimary));
                this._difficultyMasterButton.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimary));

                this._difficultyNoviceButton.Click += (s, e) =>
                {
                    this._difficultyNoviceButton.Background.Mutate();
                    this._difficultyNoviceButton.Background.SetColorFilter(new Color(ContextCompat.GetColor(this.Context, Resource.Color.difficultyNovice)), PorterDuff.Mode.SrcAtop);
                    this._difficultyNoviceButton.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.difficultyNoviceForeground));

                    this._difficultyVeteranButton.Background.Mutate();
                    this._difficultyVeteranButton.Background.ClearColorFilter();
                    this._difficultyVeteranButton.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimary));

                    this._difficultyMasterButton.Background.Mutate();
                    this._difficultyMasterButton.Background.ClearColorFilter();
                    this._difficultyMasterButton.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimary));

                    this._blackoutDifficulty = BlackoutItem.BlackoutDifficultyCode.Novice;
                };
                this._difficultyVeteranButton.Click += (s, e) =>
                {
                    this._difficultyNoviceButton.Background.Mutate();
                    this._difficultyNoviceButton.Background.ClearColorFilter();
                    this._difficultyNoviceButton.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimary));

                    this._difficultyVeteranButton.Background.Mutate();
                    this._difficultyVeteranButton.Background.SetColorFilter(new Color(ContextCompat.GetColor(this.Context, Resource.Color.difficultyVeteran)), PorterDuff.Mode.SrcAtop);
                    this._difficultyVeteranButton.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.difficultyVeteranForeground));

                    this._difficultyMasterButton.Background.Mutate();
                    this._difficultyMasterButton.Background.ClearColorFilter();
                    this._difficultyMasterButton.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimary));

                    this._blackoutDifficulty = BlackoutItem.BlackoutDifficultyCode.Veteran;
                };
                this._difficultyMasterButton.Click += (s, e) =>
                {
                    this._difficultyNoviceButton.Background.Mutate();
                    this._difficultyNoviceButton.Background.ClearColorFilter();
                    this._difficultyNoviceButton.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimary));

                    this._difficultyVeteranButton.Background.Mutate();
                    this._difficultyVeteranButton.Background.ClearColorFilter();
                    this._difficultyVeteranButton.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimary));

                    this._difficultyMasterButton.Background.Mutate();
                    this._difficultyMasterButton.Background.SetColorFilter(new Color(ContextCompat.GetColor(this.Context, Resource.Color.difficultyMaster)), PorterDuff.Mode.SrcAtop);
                    this._difficultyMasterButton.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.difficultyMasterForeground));

                    this._blackoutDifficulty = BlackoutItem.BlackoutDifficultyCode.Master;
                };
                this._difficultyVeteranButton.CallOnClick(); // Default to novice difficulty


                //
                // Bid related
                this._bidLayout = view.FindViewById<NestedScrollView>(Resource.Id.fragment_blackout_setup_bid_layout);
                this._bidNumberPicker = view.FindViewById<NumberPicker>(Resource.Id.fragment_blackout_setup_bid_number_picker);
                this._bidValidValueRangeLabel = view.FindViewById<TextView>(Resource.Id.fragment_blackout_setup_bid_valid_values_label);

                //
                // Date range related
                this._daterangeLayout = view.FindViewById<ScrollView>(Resource.Id.fragment_blackout_setup_date_range_layout);
                this._dateRangeStartDateButton = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_start_date_button);
                this._dateRangeStartTimeButton = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_start_time_button);
                this._dateRangeEndDateButton = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_end_date_button);
                this._dateRangeEndTimeButton = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_end_time_button);
                this._dateRangeStartNowButton = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_start_now_button);
                this._dateRangeStartPlus1Button = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_start_plus1_button);
                this._dateRangeStartPlus5Button = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_start_plus5_button);
                this._dateRangeStartPlus10Button = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_start_plus10_button);
                this._dateRangeStartPlus30Button = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_start_plus30_button);
                this._dateRangeEndPlus1Button = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_end_plus1_button);
                this._dateRangeEndPlus5Button = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_end_plus5_button);
                this._dateRangeEndPlus10Button = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_end_plus10_button);
                this._dateRangeEndPlus30Button = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_date_range_end_plus30_button);


                this._dateRangeStartDateButton.Click += delegate
                {
                    DatePickerDialogFragment datePickerFragment = DatePickerDialogFragment.NewInstance(delegate (DateTime dateTime)
                    {
                        this._dateRangeStartDateButton.Text = DateUtils.FormatDateLong(this.Context, dateTime);
                        this._blackoutStartDateTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, this._blackoutStartDateTime.Hour, this._blackoutStartDateTime.Minute, this._blackoutStartDateTime.Second);
                    });
                    datePickerFragment.Show(this.FragmentManager, $"{this.GetType().Name}{typeof(DatePickerDialogFragment).Name}");
                };
                this._dateRangeStartTimeButton.Click += delegate
                {
                    TimePickerDialogFragment timePickerFragment = TimePickerDialogFragment.NewInstance(delegate (DateTime dateTime)
                    {
                        this._dateRangeStartTimeButton.Text = DateUtils.FormatTime(this.Context, dateTime, UserSettings.FormatTimeAsTwelveHour);
                        this._blackoutStartDateTime = new DateTime(this._blackoutStartDateTime.Year, this._blackoutStartDateTime.Month, this._blackoutStartDateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second);
                    });
                    timePickerFragment.Show(this.FragmentManager, $"{this.GetType().Name}{typeof(DatePickerDialogFragment).Name}");
                };
                this._dateRangeEndDateButton.Click += delegate
                {
                    DatePickerDialogFragment datePickerFragment = DatePickerDialogFragment.NewInstance(delegate (DateTime dateTime)
                    {
                        this._dateRangeEndDateButton.Text = DateUtils.FormatDateLong(this.Context, dateTime);
                        this._blackoutEndDateTime = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, this._blackoutEndDateTime.Hour, this._blackoutEndDateTime.Minute, this._blackoutEndDateTime.Second);
                    });
                    datePickerFragment.Show(this.FragmentManager, $"{this.GetType().Name}{typeof(DatePickerDialogFragment).Name}");
                };
                this._dateRangeEndTimeButton.Click += delegate
                {
                    TimePickerDialogFragment timePickerFragment = TimePickerDialogFragment.NewInstance(delegate (DateTime dateTime)
                    {
                        this._dateRangeEndTimeButton.Text = DateUtils.FormatTime(this.Context, dateTime, UserSettings.FormatTimeAsTwelveHour);
                        this._blackoutEndDateTime = new DateTime(this._blackoutEndDateTime.Year, this._blackoutEndDateTime.Month, this._blackoutEndDateTime.Day, dateTime.Hour, dateTime.Minute, dateTime.Second);
                    });
                    timePickerFragment.Show(this.FragmentManager, $"{this.GetType().Name}{typeof(DatePickerDialogFragment).Name}");
                };

                this._dateRangeStartNowButton.Click += delegate { this.PlusNMinutesButton_Click(ref this._blackoutStartDateTime, ref this._dateRangeStartDateButton, ref this._dateRangeStartTimeButton, -1); };
                this._dateRangeStartPlus1Button.Click += delegate { this.PlusNMinutesButton_Click(ref this._blackoutStartDateTime, ref this._dateRangeStartDateButton, ref this._dateRangeStartTimeButton, 1); };
                this._dateRangeStartPlus5Button.Click += delegate { this.PlusNMinutesButton_Click(ref this._blackoutStartDateTime, ref this._dateRangeStartDateButton, ref this._dateRangeStartTimeButton, 5); };
                this._dateRangeStartPlus10Button.Click += delegate { this.PlusNMinutesButton_Click(ref this._blackoutStartDateTime, ref this._dateRangeStartDateButton, ref this._dateRangeStartTimeButton, 10); };
                this._dateRangeStartPlus30Button.Click += delegate { this.PlusNMinutesButton_Click(ref this._blackoutStartDateTime, ref this._dateRangeStartDateButton, ref this._dateRangeStartTimeButton, 30); };

                this._dateRangeEndPlus1Button.Click += delegate { this.PlusNMinutesButton_Click(ref this._blackoutEndDateTime, ref this._dateRangeEndDateButton, ref this._dateRangeEndTimeButton, 1); };
                this._dateRangeEndPlus5Button.Click += delegate { this.PlusNMinutesButton_Click(ref this._blackoutEndDateTime, ref this._dateRangeEndDateButton, ref this._dateRangeEndTimeButton, 5); };
                this._dateRangeEndPlus10Button.Click += delegate { this.PlusNMinutesButton_Click(ref this._blackoutEndDateTime, ref this._dateRangeEndDateButton, ref this._dateRangeEndTimeButton, 10); };
                this._dateRangeEndPlus30Button.Click += delegate { this.PlusNMinutesButton_Click(ref this._blackoutEndDateTime, ref this._dateRangeEndDateButton, ref this._dateRangeEndTimeButton, 30); };

                //
                // Application related
                this._applicationLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_blackout_setup_application_layout);
                this._applicationRecyclerView = view.FindViewById<RecyclerView>(Resource.Id.fragment_blackout_setup_application_recycler_view);

                // Init the instance application list
                this.ApplicationList_Initialize();

                // Init the application list adapter
                this._applicationListAdapter = new UIApplicationListAdapter(new List<UIApplicationItem>());
                this._applicationRecyclerView.AddItemDecoration(new DividerItemDecoration(this.Context, DividerItemDecoration.Vertical));
                this._applicationRecyclerView.SetLayoutManager(new LinearLayoutManager(this.Context));
                this._applicationRecyclerView.SetItemAnimator(new DefaultItemAnimator());
                this._applicationRecyclerView.SetAdapter(this._applicationListAdapter);
                this._applicationListAdapter.OnApplicationSelected += this.ApplicationListAdapter_OnApplicationSelected;
                //ViewCompat.SetNestedScrollingEnabled(_applicationRecyclerView, false); // Normalize scrolling in nested scroll view

                //
                // Review related
                this._reviewLayout = view.FindViewById<ScrollView>(Resource.Id.fragment_blackout_setup_review_layout);
                this._reviewDifficultyLabel = view.FindViewById<TextView>(Resource.Id.fragment_blackout_setup_review_difficulty_label);
                this._reviewBidLabel = view.FindViewById<TextView>(Resource.Id.fragment_blackout_setup_review_bid_label);
                this._reviewStartDateTimeLabel = view.FindViewById<TextView>(Resource.Id.fragment_blackout_setup_review_start_date_label);
                this._reviewEndDateTimeLabel = view.FindViewById<TextView>(Resource.Id.fragment_blackout_setup_review_end_date_label);
                this._reviewBlacklistLabel = view.FindViewById<TextView>(Resource.Id.fragment_blackout_setup_review_blacklist_label);

                //
                // Working/Status related
                this._dialogPositiveButton = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_button_positive);
                this._dialogNegativeButton = view.FindViewById<Button>(Resource.Id.fragment_blackout_setup_button_negative);
                this._dialogPositiveButton.Click += this.PositiveButton_Click;
                this._dialogNegativeButton.Click += this.NegativeButton_Click;

                //
                // Setup navbar
                ((MainActivity)this.Activity).SetupNavigation(Resource.String.text_blackout_setup, false, true);

                //
                // Set view stuff
                this._stepId = 0;
                this._problemLabel.Text = string.Empty;
                this._dialogPositiveButton.SetButtonText(this.GetString(Resource.String.text_next));
                this._dialogNegativeButton.SetButtonText(this.GetString(Resource.String.text_cancel));
                this.PositiveButton_Click(this, null);
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
            this._applicationShowSystemAppsCheckbox = (CheckBox)this.LayoutInflater.Inflate(Resource.Drawable.check_box_right, null);
            this._applicationShowSystemAppsCheckbox.Checked = false;
            this._applicationShowSystemAppsCheckbox.Click += delegate { this.ApplicationList_Filter(); };
            this._applicationShowSystemAppsCheckbox.Text = this.GetString(Resource.String.text_show_system_applications);
            this._applicationShowSystemAppsCheckbox.SetTextColor(ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimaryForeground)); // This is the title bar which is colorPrimary
            this._applicationShowSystemAppsCheckbox.ButtonTintList = ContextCompat.GetColorStateList(this.Context, Resource.Color.colorPrimaryForeground); // This is the title bar which is colorPrimary

            // Add new item to menu
            this._applicationShowSystemAppsMenuItem = menu.Add(this.GetString(Resource.String.text_show_system_applications));
            this._applicationShowSystemAppsMenuItem.SetActionView(this._applicationShowSystemAppsCheckbox);
            this._applicationShowSystemAppsMenuItem.SetShowAsAction(ShowAsAction.Always);
            this._applicationShowSystemAppsMenuItem.SetVisible((this._stepId == STEP_APPLICATIONS) ? true : false);
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
                uiApplicationItem = this._applicationListAdapter.ApplicationList[index];
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
            this.SetIsWorking(true);


            try
            {
                // Disable next and back button
                this._dialogPositiveButton.Enabled = false;
                this._dialogNegativeButton.Enabled = false;

                // Determine action
                if (this._dialogPositiveButton.Text.Equals(this.GetString(Resource.String.text_next))) // This is dumb but meh
                {
                    this.NextStep();
                }
                else if (this._dialogPositiveButton.Text.Equals(this.GetString(Resource.String.text_finish))) // This is dumb but meh
                {
                    //
                    // Assign the values
                    BlackoutItem blackoutItem = new BlackoutItem
                    {
                        ScheduledStartDateTime = _blackoutStartDateTime,
                        ScheduledEndDateTime = _blackoutEndDateTime,
                        DifficultyCode = _blackoutDifficulty,
                        Bid = this._bidNumberPicker.Value,
                        Blacklist = this._applicationList.Where(x => x.IsSelected).Select(x => x.PackageName).ToList()
                    }.SetBlackoutPending();
                    await BlackoutDatabase.UpsertAsync(blackoutItem);

                    //
                    // Dismiss
                    this.FragmentManager.PopBackStack();
                }

                // Enable next and back button
                this._dialogPositiveButton.Enabled = true;
                this._dialogNegativeButton.Enabled = true;
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"PositiveButton_Click: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
            finally
            {
                // Set no longer working
                this.SetIsWorking(false);

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
            this.SetIsWorking(true);


            try
            {
                // Disable next and back button
                this._dialogPositiveButton.Enabled = false;
                this._dialogNegativeButton.Enabled = false;

                // Determine action
                if (this._dialogNegativeButton.Text.Equals(this.GetString(Resource.String.text_back)))
                {
                    this.PreviousStep();
                }
                else if (this._dialogNegativeButton.Text.Equals(this.GetString(Resource.String.text_cancel)))
                {
                    this.ConfirmClose();
                }

                // Enable next and back button
                this._dialogPositiveButton.Enabled = true;
                this._dialogNegativeButton.Enabled = true;
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"NegativeButton_Click: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
            finally
            {
                // Set no longer working
                this.SetIsWorking(false);

            }
        }

        public void PlusNMinutesButton_Click(ref DateTime datetime, ref Button dateButton, ref Button timeButton, int minutes)
        {
            // Increment
            if (minutes == -1)
            {
                datetime = DateTime.Now;
            }
            else
            {
                datetime = datetime.AddMinutes(minutes);
            }

            // Set labels
            dateButton.Text = DateUtils.FormatDateLong(this.Context, datetime);
            timeButton.Text = DateUtils.FormatTime(this.Context, datetime, UserSettings.FormatTimeAsTwelveHour);
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
            ViewUtils.SetViewAndChildrenEnabled(this._rootLayout, !isWorking);

            // Report to parent
            if (this.Activity is IIndeterminateProgressReporter)
            {
                ((IIndeterminateProgressReporter)this.Activity).SetProgressBarState(isWorking);
            }
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
                this._applicationList = new List<UIApplicationItem>();

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
                    {
                        continue;
                    }

                    // Do we have categories?
                    if (Build.VERSION.SdkInt >= BuildVersionCodes.O)
                    {
                        category = ((applicationInfo.Category != ApplicationCategories.Undefined) ? applicationInfo.Category.ToString() : string.Empty);
                    }

                    // Is this app in the recommended block list?
                    if (EnforcerUtils.ShouldBlockApplication(this.Context, applicationInfo.PackageName))
                    {
                        isSelected = true;
                    }

                    // Add it to the UI application list
                    this._applicationList.Add(new UIApplicationItem(this.Context, applicationInfo)
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
                if (this._applicationShowSystemAppsCheckbox.Checked)
                {
                    this._applicationListAdapter.ApplicationList = this._applicationList
                        .OrderBy(x => x.Name)
                        .ToList()
                        .Copy();
                }
                else
                {
                    this._applicationListAdapter.ApplicationList = this._applicationList
                        .Where(x => x.IsSystem == false)
                        .OrderBy(x => x.Name)
                        .ToList()
                        .Copy();
                }

                //
                // Apply difficulty settings
                foreach (UIApplicationItem uiApplicationItem in this._applicationListAdapter.ApplicationList)
                {
                    uiApplicationItem.IsDifficultyLocked = false;
                    if (EnforcerUtils.ShouldBlockApplication(this.Context, uiApplicationItem.PackageName) || uiApplicationItem.IsSystem == false)
                    {
                        switch (this._blackoutDifficulty)
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
                this._applicationListAdapter.NotifyDataSetChanged();
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
                if (await this.ValidateStep(this._stepId))
                {
                    this.ProcessStep(++this._stepId);
                }
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
                this.ProcessStep(--this._stepId);
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
                        this._dialogPositiveButton.SetText(Resource.String.text_next);
                        this._dialogNegativeButton.SetText(Resource.String.text_cancel);
                        this._titleLabel.SetText(Resource.String.fragment_blackout_setup_difficulty_title);
                        this._difficultyLayout.Visibility = ViewStates.Visible;
                        this._bidLayout.Visibility = ViewStates.Gone;
                        this._daterangeLayout.Visibility = ViewStates.Gone;
                        this._applicationLayout.Visibility = this._applicationShowSystemAppsCheckbox.Visibility = ViewStates.Gone;
                        this._reviewLayout.Visibility = ViewStates.Gone;
                        break;
                    case STEP_BID:
                        this._dialogPositiveButton.SetText(Resource.String.text_next);
                        this._dialogNegativeButton.SetText(Resource.String.text_back);
                        this._titleLabel.SetText(Resource.String.fragment_blackout_setup_bid_title);
                        this._difficultyLayout.Visibility = ViewStates.Gone;
                        this._bidLayout.Visibility = ViewStates.Visible;
                        this._daterangeLayout.Visibility = ViewStates.Gone;
                        this._applicationLayout.Visibility = this._applicationShowSystemAppsCheckbox.Visibility = ViewStates.Gone;
                        this._reviewLayout.Visibility = ViewStates.Gone;
                        switch (this._blackoutDifficulty)
                        {
                            case BlackoutItem.BlackoutDifficultyCode.Novice:
                                this._bidNumberPicker.MinValue = 0;
                                this._bidNumberPicker.MaxValue = 250;
                                break;
                            case BlackoutItem.BlackoutDifficultyCode.Veteran:
                                this._bidNumberPicker.MinValue = 1;
                                this._bidNumberPicker.MaxValue = 250;
                                break;
                            case BlackoutItem.BlackoutDifficultyCode.Master:
                                this._bidNumberPicker.MinValue = 1;
                                this._bidNumberPicker.MaxValue = 250;
                                break;
                        }
                        this._bidNumberPicker.Value = this._bidNumberPicker.MinValue;
                        this._bidValidValueRangeLabel.Text = string.Format(this.GetString(Resource.String.fragment_blackout_setup_bid_range), this._bidNumberPicker.MinValue, this._bidNumberPicker.MaxValue);
                        break;
                    case STEP_DATE_RANGE:
                        this._dialogPositiveButton.SetText(Resource.String.text_next);
                        this._dialogNegativeButton.SetText(Resource.String.text_back);
                        this._titleLabel.SetText(Resource.String.fragment_blackout_setup_date_range_title);
                        this._difficultyLayout.Visibility = ViewStates.Gone;
                        this._bidLayout.Visibility = ViewStates.Gone;
                        this._daterangeLayout.Visibility = ViewStates.Visible;
                        this._applicationLayout.Visibility = this._applicationShowSystemAppsCheckbox.Visibility = ViewStates.Gone;
                        this._reviewLayout.Visibility = ViewStates.Gone;
                        break;
                    case STEP_APPLICATIONS:
                        this._dialogPositiveButton.SetText(Resource.String.text_next);
                        this._dialogNegativeButton.SetText(Resource.String.text_back);
                        this._titleLabel.SetText(Resource.String.fragment_blackout_setup_application_selection_title);
                        this._difficultyLayout.Visibility = ViewStates.Gone;
                        this._bidLayout.Visibility = ViewStates.Gone;
                        this._daterangeLayout.Visibility = ViewStates.Gone;
                        this._applicationLayout.Visibility = this._applicationShowSystemAppsCheckbox.Visibility = ViewStates.Visible;
                        this._reviewLayout.Visibility = ViewStates.Gone;
                        this.ApplicationList_Filter();
                        break;
                    case STEP_REVIEW:
                        int blackoutDifficultyTextResourceId = Resource.String.text_unknown;
                        switch (this._blackoutDifficulty)
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

                        this._dialogPositiveButton.SetText(Resource.String.text_finish);
                        this._dialogNegativeButton.SetText(Resource.String.text_back);
                        this._titleLabel.SetText(Resource.String.fragment_blackout_setup_review_title);
                        this._difficultyLayout.Visibility = ViewStates.Gone;
                        this._bidLayout.Visibility = ViewStates.Gone;
                        this._daterangeLayout.Visibility = ViewStates.Gone;
                        this._applicationLayout.Visibility = this._applicationShowSystemAppsCheckbox.Visibility = ViewStates.Gone;
                        this._reviewLayout.Visibility = ViewStates.Visible;
                        this._reviewDifficultyLabel.SetText(blackoutDifficultyTextResourceId);
                        this._reviewBidLabel.Text = $"${this._bidNumberPicker.Value}";
                        this._reviewStartDateTimeLabel.Text = $"{DateUtils.FormatDateLong(this.Context, this._blackoutStartDateTime)} @ {DateUtils.FormatTime(this.Context, this._blackoutStartDateTime, UserSettings.FormatTimeAsTwelveHour)}";
                        this._reviewEndDateTimeLabel.Text = $"{DateUtils.FormatDateLong(this.Context, this._blackoutEndDateTime)} @ {DateUtils.FormatTime(this.Context, this._blackoutEndDateTime, UserSettings.FormatTimeAsTwelveHour)}";
                        this._reviewBlacklistLabel.Text = string.Join(", ", this._applicationList.Where(x => x.IsSelected).Select(x => x.Name).ToList());
                        break;
                    default:
                        this._difficultyLayout.Visibility = ViewStates.Gone;
                        this._bidLayout.Visibility = ViewStates.Gone;
                        this._daterangeLayout.Visibility = ViewStates.Gone;
                        this._applicationLayout.Visibility = this._applicationShowSystemAppsCheckbox.Visibility = ViewStates.Gone;
                        this._reviewLayout.Visibility = ViewStates.Gone;
                        break;
                }

                // Set the menu state based on the result of the switch
                this._applicationShowSystemAppsMenuItem.SetVisible((this._applicationLayout.Visibility == ViewStates.Visible) ? true : false);
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
            try
            {
                // Reset
                this._problemLabel.Text = string.Empty;

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
                        if (this._blackoutEndDateTime < DateTime.Now) // The end date is before the current time, whats the point?
                        {
                            this._problemLabel.Text += this.GetString(Resource.String.fragment_blackout_setup_validation_end_date_in_the_past) + " ";
                            return false;
                        }

                        if (this._blackoutStartDateTime > this._blackoutEndDateTime) // Start date must be before the end date
                        {
                            this._problemLabel.Text += this.GetString(Resource.String.fragment_blackout_setup_validation_start_date_cannot_be_greater_than_end_date) + " ";
                            return false;
                        }

                        if ((this._blackoutEndDateTime - this._blackoutStartDateTime).TotalMinutes < 1) // Blackout must be more than 1 minute
                        {
                            this._problemLabel.Text += this.GetString(Resource.String.fragment_blackout_setup_validation_duration_of_blackout_must_be_greater_than_1_minute) + " ";
                            return false;
                        }

                        if (this._blackoutEndDateTime.Subtract(DateTime.Now).TotalDays > 30) // Blackout must be less than 30 days
                        {
                            this._problemLabel.Text += this.GetString(Resource.String.fragment_blackout_setup_validation_duration_of_blackout_must_be_less_than_30_days) + " ";
                            return false;
                        }

                        if (await BlackoutDatabase.HasConflictInRangeAsync(this._blackoutStartDateTime, this._blackoutEndDateTime))
                        {
                            this._problemLabel.Text += this.GetString(Resource.String.fragment_blackout_setup_validation_blackout_overlaps) + " ";
                            return false;
                        }
                        break;
                    case STEP_APPLICATIONS:
                        // Applications
                        if (this._applicationList.Where(x => x.IsSelected).Select(x => x.PackageName).ToList().Count() <= 0)
                        {
                            this._problemLabel.Text += this.GetString(Resource.String.fragment_blackout_setup_validation_no_application_selected) + " ";
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