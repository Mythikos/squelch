using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.CardView.Widget;
using AndroidX.Fragment.App;
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
using Xamarin.Essentials;

namespace Squelch.Fragments
{
    public class HomeFragment : Fragment
    {
        #region Instance Variables
        private static readonly string _tag = typeof(HomeFragment).FullName;

        private TextView _greetingLabel, _statsHoursSavedTitle;
        private Button _setupBlackoutButton;
        private LinearLayout _rootLayout;

        private CardView _nextBlackoutCard;
        private TextView _nextBlackoutStartDateLabel, _nextBlackoutDifficultyLabel;

        private CardView _feedbackCard;
        private TextView _feedbackMessage;
        private Button _feedbackPositiveButton, _feedbackNegativeButton;

        private const string FEEDBACK_MESSAGE_NEUTRAL = "Hey! Are you enjoying squelch?";
        private const string FEEDBACK_MESSAGE_POSITIVE = "Awesome! Can you give us some feedback on your experience?";
        private const string FEEDBACK_MESSAGE_NEGATIVE = "Oh no, we are sorry to hear that! Can you give us some feedback so we can better your experience in the future?";
        #endregion

        #region Native Events
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view;

            //
            // Inflate the layour
            view = inflater.Inflate(Resource.Layout.fragment_home, container, false);

            try
            {
                _rootLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_home_root_layout);
                _setupBlackoutButton = view.FindViewById<Button>(Resource.Id.fragment_home_setup_blackout_button);
                _statsHoursSavedTitle = view.FindViewById<TextView>(Resource.Id.fragment_home_stats_layout_hours_saved_title);
                _greetingLabel = view.FindViewById<TextView>(Resource.Id.fragment_home_greeting_label);

                _nextBlackoutCard = view.FindViewById<CardView>(Resource.Id.fragment_home_next_blackout_card);
                _nextBlackoutStartDateLabel = view.FindViewById<TextView>(Resource.Id.fragment_home_next_blackout_card_start_date_label);
                _nextBlackoutDifficultyLabel = view.FindViewById<TextView>(Resource.Id.fragment_home_next_blackout_card_difficulty_label);

                _feedbackCard = view.FindViewById<CardView>(Resource.Id.fragment_home_feedback_card);
                _feedbackMessage = view.FindViewById<TextView>(Resource.Id.fragment_home_feedback_card_inquiry_message);
                _feedbackPositiveButton = view.FindViewById<Button>(Resource.Id.fragment_home_feedback_card_inquiry_positive_button);
                _feedbackNegativeButton = view.FindViewById<Button>(Resource.Id.fragment_home_feedback_card_inquiry_negative_button);

                //
                // Setup feedback stuff
                _feedbackMessage.Text = FEEDBACK_MESSAGE_NEUTRAL;
                _feedbackPositiveButton.Click += delegate
                {
                    if (_feedbackMessage.Text.Equals(FEEDBACK_MESSAGE_NEUTRAL))
                    {
                        _feedbackMessage.Text = FEEDBACK_MESSAGE_POSITIVE;
                        _feedbackPositiveButton.Text = "Sure";
                        _feedbackNegativeButton.Text = "No thanks";
                    }
                    else
                    {
                        this.FragmentManager.SetFragment(typeof(FeedbackFragment), true, false);
                    }
                };
                _feedbackNegativeButton.Click += delegate
                {
                    if (_feedbackMessage.Text.Equals(FEEDBACK_MESSAGE_NEUTRAL))
                    {
                        _feedbackMessage.Text = FEEDBACK_MESSAGE_NEGATIVE;
                        _feedbackPositiveButton.Text = "Sure";
                        _feedbackNegativeButton.Text = "No thanks";
                    }
                    else
                    {
                        UserSettings.SetFlagValue(UserSettings.FlagKeys.Feedback_Status, "skipped");
                        UserSettings.SetFlagValue(UserSettings.FlagKeys.Feedback_StatusUpdatedOn, DateTime.Now.ToString());
                        _feedbackCard.Visibility = ViewStates.Gone;
                    }
                };

                //
                // Setup events
                _setupBlackoutButton.Click += delegate
                {
                    if (PermissionUtils.HasRequiredPermissions(this.Context, true) == true)
                        this.FragmentManager.SetFragment(typeof(BlackoutSetupFragment), true, false);
                };
                
                _nextBlackoutCard.Click += async delegate 
                { 
                    await ShowFutureBlackoutInfo(); 
                };

                //
                // Setup navbar
                ((MainActivity)this.Activity).SetupNavigation(Resource.String.title_home, true, false);

                //
                // Call UI display methods
                UIDisplayGreeting();
                UIDisplayFutureBlackoutInfo();
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnCreateView: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            //
            // Return the inflated view
            return view;
        }

        public override void OnStart()
        {
            base.OnStart();

            try
            {
                //
                // Subscribe to events
                BlackoutDatabase.BlackoutTableChanged += BlackoutDatabase_BlackoutTableChanged;
                UserSettings.SettingChanged += UserSettings_SettingChanged;
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnStart: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        public override void OnStop()
        {
            base.OnStop();

            try
            {
                //
                // Unsubscribe from events
                BlackoutDatabase.BlackoutTableChanged -= BlackoutDatabase_BlackoutTableChanged;
                UserSettings.SettingChanged -= UserSettings_SettingChanged;
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnStop: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        public override async void OnResume()
        {
            base.OnResume();

            try
            {
                //
                // Ask for feedback
                if ((await BlackoutDatabase.FindAllAsync(BlackoutItem.BlackoutStatusCode.Finished)).Count() >= 3)
                {
                    if (UserSettings.GetFlagValue(UserSettings.FlagKeys.Feedback_Status, "false") == "false")
                    {
                        // They havent been prompted yet
                        _feedbackCard.Visibility = ViewStates.Visible;
                    }
                    else if (UserSettings.GetFlagValue(UserSettings.FlagKeys.Feedback_Status, "false") == "skipped")
                    {
                        // They skipped when asked before
                        var lastPrompted = DateTime.Parse(UserSettings.GetFlagValue(UserSettings.FlagKeys.Feedback_StatusUpdatedOn, DateTime.Now.ToString()));
                        if (DateTime.Now.Subtract(lastPrompted).TotalDays >= 5)
                            _feedbackCard.Visibility = ViewStates.Visible;
                    }
                }

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

        /// <summary>
        /// Displays an alert dialog showing the details about the pending blackout
        /// </summary>
        /// <returns></returns>
        private async Task ShowFutureBlackoutInfo()
        {
            BlackoutItem blackoutItem;

            //
            // Starting work
            SetIsWorking(true);

            try
            {
                //
                // Get the blackout
                blackoutItem = await BlackoutDatabase.GetFirstPendingBlackoutAsync();
                if (blackoutItem != null)
                    DisplayUtils.ShowBlackoutDetailsAlertDialog(this.Context, blackoutItem, true);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"ShowFutureBlackoutInfo: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
            finally
            {
                //
                // No longer working
                SetIsWorking(false);
            }
        }
        #endregion

        #region Interface Methods
        /// <summary>
        /// Updates the display elements associated with the user greeting
        /// </summary>
        private void UIDisplayGreeting()
        {
            List<string> greetings;

            try
            {
                greetings = new List<string> { "Hello", "Welcome back", "Howdy", "Whats up", "How's it going", "Hey", "Nice to see you" };
                if (string.IsNullOrWhiteSpace(UserSettings.FirstName))
                    MainThread.BeginInvokeOnMainThread(() => _greetingLabel.Text = $"{greetings.Random()}!");
                else
                    MainThread.BeginInvokeOnMainThread(() => _greetingLabel.Text = $"{greetings.Random()}, {UserSettings.FirstName}!");
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"UIDisplayGreeting: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Updates the display elements associated with the next pending blackout information
        /// </summary>
        private async void UIDisplayFutureBlackoutInfo()
        {
            try
            {
                var blackoutItem = await BlackoutDatabase.GetFirstPendingBlackoutAsync();
                if (blackoutItem != default(BlackoutItem))
                {
                    MainThread.BeginInvokeOnMainThread(() =>
                    { 
                        _nextBlackoutStartDateLabel.Text = $"{Resources.GetString(Resource.String.label_col_blackout_start_date)} {blackoutItem.StartDateTime.ToString("MM/dd/yyyy hh:mm tt")}";
                        _nextBlackoutDifficultyLabel.Text = $"{Resources.GetString(Resource.String.label_col_blackout_difficulty)} {blackoutItem.DifficultyCode.ToString()}";
                        _nextBlackoutCard.Visibility = ViewStates.Visible;
                    });
                }
                else
                {
                    MainThread.BeginInvokeOnMainThread(() =>
                    {
                        _nextBlackoutCard.Visibility = ViewStates.Gone;
                        _nextBlackoutStartDateLabel.Text = $"{Resources.GetString(Resource.String.label_col_blackout_start_date)} n/a";
                        _nextBlackoutDifficultyLabel.Text = $"{Resources.GetString(Resource.String.label_col_blackout_difficulty)} n/a";
                    });
                }
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"UIDisplayFutureBlackout: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }
        #endregion

        #region Event Methods
        /// <summary>
        /// Called when the blackout database reports a change to its data
        /// </summary>
        private void BlackoutDatabase_BlackoutTableChanged()
        {
            try
            {
                UIDisplayFutureBlackoutInfo();
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"BlackoutDatabaseAsync_BlackoutTableChanged: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Called when the user settings class reports a change to its data
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        private void UserSettings_SettingChanged(string arg1, string arg2)
        {
            try
            {
                UIDisplayGreeting();
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"UserSettings_SettingChanged: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }
        #endregion
    }
}