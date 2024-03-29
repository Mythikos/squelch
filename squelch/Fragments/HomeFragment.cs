﻿using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.CardView.Widget;
using AndroidX.Fragment.App;
using Squelch.Activities;
using Squelch.Library;
using Squelch.Library.Data;
using Squelch.Library.Entities;
using Squelch.Library.Extensions;
using Squelch.Library.Interfaces;
using Squelch.Library.Utilities;
using System;
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

        private CardView _donationCard;
        private TextView _donationMessage;
        private Button _donationPositiveButton, _donationNegativeButton, _donationNeutralButton;
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
                this._rootLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_home_root_layout);
                this._setupBlackoutButton = view.FindViewById<Button>(Resource.Id.fragment_home_setup_blackout_button);
                this._statsHoursSavedTitle = view.FindViewById<TextView>(Resource.Id.fragment_home_stats_layout_hours_saved_title);
                this._greetingLabel = view.FindViewById<TextView>(Resource.Id.fragment_home_greeting_label);

                this._nextBlackoutCard = view.FindViewById<CardView>(Resource.Id.fragment_home_next_blackout_card);
                this._nextBlackoutStartDateLabel = view.FindViewById<TextView>(Resource.Id.fragment_home_next_blackout_card_start_date_label);
                this._nextBlackoutDifficultyLabel = view.FindViewById<TextView>(Resource.Id.fragment_home_next_blackout_card_difficulty_label);

                //
                // Feedback stuff
                this._feedbackCard = view.FindViewById<CardView>(Resource.Id.fragment_home_feedback_card);
                this._feedbackMessage = view.FindViewById<TextView>(Resource.Id.fragment_home_feedback_card_inquiry_message);
                this._feedbackPositiveButton = view.FindViewById<Button>(Resource.Id.fragment_home_feedback_card_inquiry_positive_button);
                this._feedbackNegativeButton = view.FindViewById<Button>(Resource.Id.fragment_home_feedback_card_inquiry_negative_button);

                this._feedbackMessage.Text = this.GetString(Resource.String.fragment_home_feedback_message_neutral);
                this._feedbackPositiveButton.Click += delegate
                {
                    if (this._feedbackMessage.Text.Equals(this.GetString(Resource.String.fragment_home_feedback_message_neutral)))
                    {
                        this._feedbackMessage.Text = this.GetString(Resource.String.fragment_home_feedback_message_positive);
                        this._feedbackPositiveButton.Text = this.GetString(Resource.String.text_sure_exclamation);
                        this._feedbackNegativeButton.Text = this.GetString(Resource.String.text_no_thanks);
                    }
                    else
                    {
                        this.FragmentManager.SetFragment(typeof(FeedbackFragment), true, false);
                    }
                };
                this._feedbackNegativeButton.Click += delegate
                {
                    if (this._feedbackMessage.Text.Equals(this.GetString(Resource.String.fragment_home_feedback_message_neutral)))
                    {
                        this._feedbackMessage.Text = this.GetString(Resource.String.fragment_home_feedback_message_negative);
                        this._feedbackPositiveButton.Text = this.GetString(Resource.String.text_sure_exclamation);
                        this._feedbackNegativeButton.Text = this.GetString(Resource.String.text_no_thanks);
                    }
                    else
                    {
                        UserSettings.SetFlagValue(UserSettings.FlagKeys.Feedback_Status, "skipped");
                        UserSettings.SetFlagValue(UserSettings.FlagKeys.Feedback_StatusUpdatedOn, DateTime.Now.ToString());
                        this._feedbackCard.Visibility = ViewStates.Gone;
                    }
                };

                this._feedbackCard.Visibility = ViewStates.Gone;

                //
                // Donation stuff
                this._donationCard = view.FindViewById<CardView>(Resource.Id.fragment_home_donation_card);
                this._donationMessage = view.FindViewById<TextView>(Resource.Id.fragment_home_donation_card_inquiry_message);
                this._donationPositiveButton = view.FindViewById<Button>(Resource.Id.fragment_home_donation_card_inquiry_positive_button);
                this._donationNeutralButton = view.FindViewById<Button>(Resource.Id.fragment_home_donation_card_inquiry_neutral_button);
                this._donationNegativeButton = view.FindViewById<Button>(Resource.Id.fragment_home_donation_card_inquiry_negative_button);

                this._donationPositiveButton.Click += delegate
                {
                    this.ChildFragmentManager.ShowDialogFragment(typeof(DonationDialogFragment));
                };
                this._donationNeutralButton.Click += delegate
                {
                    UserSettings.SetFlagValue(UserSettings.FlagKeys.Donation_Status, "skipped");
                    UserSettings.SetFlagValue(UserSettings.FlagKeys.Donation_StatusUpdatedOn, DateTime.Now.ToString());
                    this._donationCard.Visibility = ViewStates.Gone;
                };
                this._donationNegativeButton.Click += delegate
                {
                    UserSettings.SetFlagValue(UserSettings.FlagKeys.Donation_Status, "never");
                    UserSettings.SetFlagValue(UserSettings.FlagKeys.Donation_StatusUpdatedOn, DateTime.Now.ToString());
                    this._donationCard.Visibility = ViewStates.Gone;
                };

                this._donationCard.Visibility = ViewStates.Gone;

                //
                // Setup events
                this._setupBlackoutButton.Click += delegate
                {
                    if (PermissionUtils.HasRequiredPermissions(this.Context, true) == true)
                    {
                        this.FragmentManager.SetFragment(typeof(BlackoutSetupFragment), true, false);
                    }
                };

                this._nextBlackoutCard.Click += async delegate
                {
                    await this.ShowFutureBlackoutInfo();
                };

                //
                // Setup navbar
                ((MainActivity)this.Activity).SetupNavigation(Resource.String.text_home, true, false);

                //
                // Call UI display methods
                this.UIDisplayGreeting();
                this.UIDisplayFutureBlackoutInfo();
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
                BlackoutDatabase.BlackoutTableChanged += this.BlackoutDatabase_BlackoutTableChanged;
                UserSettings.SettingChanged += this.UserSettings_SettingChanged;
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
                BlackoutDatabase.BlackoutTableChanged -= this.BlackoutDatabase_BlackoutTableChanged;
                UserSettings.SettingChanged -= this.UserSettings_SettingChanged;
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnStop: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        public override async void OnResume()
        {
            base.OnResume();

            int finishedBlackoutCount = 0;
            DateTime lastPrompt;

            try
            {
                //
                // Get blackout count
                finishedBlackoutCount = (await BlackoutDatabase.FindAllAsync(BlackoutItem.BlackoutStatusCode.Finished)).Count();

                //
                // Ask for feedback
                if (finishedBlackoutCount >= 3)
                {
                    if (UserSettings.GetFlagValue(UserSettings.FlagKeys.Feedback_Status, "false").Equals("false", StringComparison.OrdinalIgnoreCase))
                    {
                        // They havent been prompted yet
                        this._feedbackCard.Visibility = ViewStates.Visible;
                    }
                    else if (UserSettings.GetFlagValue(UserSettings.FlagKeys.Feedback_Status, "false").Equals("skipped", StringComparison.OrdinalIgnoreCase))
                    {
                        // They skipped when asked before
                        lastPrompt = DateTime.Parse(UserSettings.GetFlagValue(UserSettings.FlagKeys.Feedback_StatusUpdatedOn, DateTime.Now.ToString()));
                        if (DateTime.Now.Subtract(lastPrompt).TotalDays >= 5)
                        {
                            this._feedbackCard.Visibility = ViewStates.Visible;
                        }
                    }
                }

                //
                // Ask for donations?
                if (finishedBlackoutCount >= 5)
                {
                    if (UserSettings.GetFlagValue(UserSettings.FlagKeys.Donation_Status, "false").Equals("true", StringComparison.OrdinalIgnoreCase)
                        || UserSettings.GetFlagValue(UserSettings.FlagKeys.Donation_Status, "false").Equals("never", StringComparison.OrdinalIgnoreCase))
                    {
                        // They donated before, lets wait a while before asking again
                        lastPrompt = DateTime.Parse(UserSettings.GetFlagValue(UserSettings.FlagKeys.Donation_StatusUpdatedOn, DateTime.Now.ToString()));
                        if (DateTime.Now.Subtract(lastPrompt).TotalDays >= 180)
                        {
                            this._donationCard.Visibility = ViewStates.Visible;
                        }
                    }
                    else if (UserSettings.GetFlagValue(UserSettings.FlagKeys.Donation_Status, "false").Equals("false", StringComparison.OrdinalIgnoreCase))
                    {
                        this._donationCard.Visibility = ViewStates.Visible;
                    }
                    else if (UserSettings.GetFlagValue(UserSettings.FlagKeys.Donation_Status, "false").Equals("skipped", StringComparison.OrdinalIgnoreCase))
                    {
                        // They skipped when asked before
                        lastPrompt = DateTime.Parse(UserSettings.GetFlagValue(UserSettings.FlagKeys.Donation_StatusUpdatedOn, DateTime.Now.ToString()));
                        if (DateTime.Now.Subtract(lastPrompt).TotalDays >= 14)
                        {
                            this._donationCard.Visibility = ViewStates.Visible;
                        }
                    }
                }

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
        /// Displays an alert dialog showing the details about the pending blackout
        /// </summary>
        /// <returns></returns>
        private async Task ShowFutureBlackoutInfo()
        {
            BlackoutItem blackoutItem;

            //
            // Starting work
            this.SetIsWorking(true);

            try
            {
                //
                // Get the blackout
                blackoutItem = await BlackoutDatabase.GetFirstPendingBlackoutAsync();
                if (blackoutItem != null)
                {
                    DisplayUtils.ShowBlackoutDetailsAlertDialog(this.Context, blackoutItem, true);
                }
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"ShowFutureBlackoutInfo: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
            finally
            {
                //
                // No longer working
                this.SetIsWorking(false);
            }
        }
        #endregion

        #region Interface Methods
        /// <summary>
        /// Updates the display elements associated with the user greeting
        /// </summary>
        private void UIDisplayGreeting()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(UserSettings.FirstName))
                {
                    MainThread.BeginInvokeOnMainThread(() => this._greetingLabel.Text = this.Resources.GetStringArray(Resource.Array.fragment_home_greeting_list_with_no_name).ToList().Random());
                }
                else
                {
                    MainThread.BeginInvokeOnMainThread(() => this._greetingLabel.Text = string.Format(this.Resources.GetStringArray(Resource.Array.fragment_home_greeting_list_with_name).ToList().Random(), UserSettings.FirstName));
                }
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
                BlackoutItem blackoutItem = await BlackoutDatabase.GetFirstPendingBlackoutAsync();
                if (blackoutItem != default(BlackoutItem))
                {
                    MainThread.BeginInvokeOnMainThread(() =>
                    {
                        int blackoutDifficultyTextResourceId = Resource.String.text_unknown;
                        switch (blackoutItem.DifficultyCode)
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

                        this._nextBlackoutStartDateLabel.Text = $"{this.GetString(Resource.String.text_blackout_start_date_col)} {DateUtils.FormatDateShort(this.Context, blackoutItem.ScheduledStartDateTime)} @ {DateUtils.FormatTime(this.Context, blackoutItem.ScheduledStartDateTime, UserSettings.FormatTimeAsTwelveHour)}";
                        this._nextBlackoutDifficultyLabel.Text = $"{this.GetString(Resource.String.text_blackout_difficulty_col)} {this.GetString(blackoutDifficultyTextResourceId)}";
                        this._nextBlackoutCard.Visibility = ViewStates.Visible;
                    });
                }
                else
                {
                    MainThread.BeginInvokeOnMainThread(() =>
                    {
                        this._nextBlackoutCard.Visibility = ViewStates.Gone;
                        this._nextBlackoutStartDateLabel.Text = $"{this.GetString(Resource.String.text_blackout_start_date_col)} {this.GetString(Resource.String.text_not_available_abbreviated)}";
                        this._nextBlackoutDifficultyLabel.Text = $"{this.GetString(Resource.String.text_blackout_difficulty_col)} {this.GetString(Resource.String.text_not_available_abbreviated)}";
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
                this.UIDisplayFutureBlackoutInfo();
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
                this.UIDisplayGreeting();
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"UserSettings_SettingChanged: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }
        #endregion
    }
}