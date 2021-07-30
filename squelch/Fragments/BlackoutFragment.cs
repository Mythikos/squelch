using Android.Animation;
using Android.Content.PM;
using Android.OS;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;
using AndroidX.AppCompat.Widget;
using AndroidX.Core.Widget;
using AndroidX.Fragment.App;
using Google.Android.Material.Snackbar;
using Squelch.Activities;
using Squelch.Library;
using Squelch.Library.Data;
using Squelch.Library.Entities;
using Squelch.Library.Utilities;
using System;
using System.Collections.Generic;
using Xamarin.Essentials;

namespace Squelch.Fragments
{
    public class BlackoutFragment : Fragment
    {
        #region Instance Variables
        private static readonly string _tag = typeof(BlackoutFragment).FullName;

        private LinearLayout _rootLayout;
        private TableLayout _informationLayout;
        private TableLayout _blacklistLayout;
        private Button _unlockButton;
        private ProgressBar _progressIndicator;
        private AppCompatTextView _timeRemainingLabel;
        private TextView _difficultyLabel;
        private TextView _bidLabel;

        private System.Timers.Timer _refreshTimer;
        private BlackoutItem _activeBlackout;
        private Android.App.AlertDialog _permissionDialog;

        private const int INDICATOR_MAX_VALUE = 100;
        #endregion

        #region Native Methods
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view;

            //
            // Inflate the layour
            view = inflater.Inflate(Resource.Layout.fragment_blackout, container, false);

            try
            {
                //
                // Set view items
                this._rootLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_blackout_root_layout);
                this._informationLayout = view.FindViewById<TableLayout>(Resource.Id.fragment_blackout_information_layout);
                this._blacklistLayout = view.FindViewById<TableLayout>(Resource.Id.fragment_blackout_blacklist_layout);
                this._progressIndicator = view.FindViewById<ProgressBar>(Resource.Id.fragment_blackout_progress_indicator);
                this._timeRemainingLabel = view.FindViewById<AppCompatTextView>(Resource.Id.fragment_blackout_time_remaining);
                this._difficultyLabel = view.FindViewById<TextView>(Resource.Id.fragment_blackout_information_difficulty_label);
                this._bidLabel = view.FindViewById<TextView>(Resource.Id.fragment_blackout_information_bid_label);
                this._unlockButton = view.FindViewById<Button>(Resource.Id.fragment_blackout_button_unlock);

                //
                // Hookup event
                this._unlockButton.Click += this.UnlockButton_Click;

                //
                // Setup navbar
                ((MainActivity)this.Activity).SetupNavigation(Resource.String.text_blackout, false, false);

                //
                // Prepare view
                TextViewCompat.SetAutoSizeTextTypeWithDefaults(this._timeRemainingLabel, TextViewCompat.AutoSizeTextTypeUniform);

                this._progressIndicator.Max = INDICATOR_MAX_VALUE;
                this._progressIndicator.Progress = INDICATOR_MAX_VALUE;
                this._progressIndicator.SecondaryProgress = INDICATOR_MAX_VALUE;
                this._timeRemainingLabel.Text = "00:00:00";
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
                // Start timer
                if (this._refreshTimer == null)
                {
                    this._refreshTimer = new System.Timers.Timer
                    {
                        Interval = 1000
                    };
                    this._refreshTimer.Elapsed += this.RefreshTimer_Elapsed;
                    Logger.Write(_tag, "OnStart: Timer created", Logger.Severity.Info);
                }
                this._refreshTimer.Start();
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
                // Stop timer
                if (this._refreshTimer != null)
                {
                    this._refreshTimer.Stop();
                    this._refreshTimer.Dispose();
                    this._refreshTimer = null;
                }

                //
                // Close usage stats dialog
                if (this._permissionDialog != null)
                {
                    this._permissionDialog.Dismiss();
                }
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
                // Get the active blackout
                this._activeBlackout = await BlackoutDatabase.GetFirstActiveBlackoutAsync();
                this.UIDisplayInformation();
                this.UIDisplayBlacklist();

                //
                // Set firebase screen
                FirebaseAnalyticsUtils.SetCurrentScreen(this);

                //
                // Check permissions and ask for it if we need it
                // NOTE: THIS MIGHT CAUSE ISSUES IF USAGE STATS SETTINGS SECTION IS BEING BLOCKED...
                if (this._permissionDialog == null && PermissionUtils.GetUsageDataPermission(this.Context) == false)
                {
                    PermissionUtils.GetUsageDataPermission(this.Context, true, (Android.App.AlertDialog dialog) =>
                    {
                        // Get the dialog
                        this._permissionDialog = dialog;
                        this._permissionDialog.DismissEvent += delegate { this._permissionDialog = null; };
                    });
                }

                // NOTE: THIS MIGHT CAUSE ISSUES IF OVERLAY SETTINGS SECTION IS BEING BLOCKED...
                if (this._permissionDialog == null && PermissionUtils.GetApplicationOverlayPermission(this.Context) == false)
                {
                    PermissionUtils.GetApplicationOverlayPermission(this.Context, true, (Android.App.AlertDialog dialog) =>
                    {
                        // Get the dialog
                        this._permissionDialog = dialog;
                        this._permissionDialog.DismissEvent += delegate { this._permissionDialog = null; };
                    });
                }
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnResume: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }
        #endregion

        #region Event Handlers
        /// <summary>
        /// Unlock button click event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UnlockButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Make sure blackout is present
                if (this._activeBlackout == null)
                {
                    DisplayUtils.ShowSnackbar(this.View, Resource.String.error_unable_to_determine_blackout, Snackbar.LengthIndefinite);
                    return;
                }

                DisplayUtils.ShowGenericAlertDialog(this.Context, Resource.String.text_confirm, Resource.String.fragment_blackout_confirmation_message, true, Resource.String.text_yes, delegate { this.ProcessUnlock(this._activeBlackout.Bid); }, Resource.String.text_no, delegate { });
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"UnlockButton_Click: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Refresh timer elapsed event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                this.UIDisplayProgress();
                this.UIDisplayTimeRemaining();
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"RefreshTimer_Tick: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }
        #endregion

        #region UI Helper Methods
        /// <summary>
        /// Updates the progress indicator to reflect time remaining
        /// </summary>
        private void UIDisplayProgress()
        {
            double totalSeconds;
            double elapsedSeconds;
            int percentageComplete;
            ObjectAnimator animator;

            try
            {
                //
                // Sanity
                if (this._activeBlackout == null)
                {
                    return;
                }

                //
                // Calculate progress
                totalSeconds = Math.Max((this._activeBlackout.ScheduledEndDateTime - this._activeBlackout.ScheduledStartDateTime).TotalSeconds, 0);
                elapsedSeconds = Math.Max((this._activeBlackout.ScheduledEndDateTime - DateTime.Now).TotalSeconds, 0);
                percentageComplete = (int)Math.Floor((INDICATOR_MAX_VALUE / totalSeconds) * elapsedSeconds);
                if (percentageComplete < 1)
                {
                    percentageComplete = 1;
                }

                //
                // Display
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    animator = ObjectAnimator.OfInt(this._progressIndicator, "progress", this._progressIndicator.Progress, percentageComplete);
                    animator.SetDuration(1000);
                    animator.SetInterpolator(new LinearInterpolator());
                    animator.Start();
                });
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"UIUpdateProgress: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Updates the time remaining label to show exact hours/minutes/seconds remaining
        /// </summary>
        private void UIDisplayTimeRemaining()
        {
            TimeSpan timeRemaining;
            double totalHours;
            double totalMinutes;
            double totalSeconds;

            try
            {
                //
                // Sanity
                if (this._activeBlackout == null)
                {
                    return;
                }

                //
                // Calculate time remaining
                timeRemaining = this._activeBlackout.ScheduledEndDateTime.Subtract(DateTime.Now);
                totalHours = Math.Max((timeRemaining.Days * 24) + timeRemaining.Hours, 0);
                totalMinutes = Math.Max(timeRemaining.Minutes, 0);
                totalSeconds = Math.Max(timeRemaining.Seconds, 0);

                //
                // Display and make visible
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    this._timeRemainingLabel.Text = $"{totalHours.ToString("00")}:{totalMinutes.ToString("00")}:{totalSeconds.ToString("00")}";
                    if (this._timeRemainingLabel.Visibility != ViewStates.Visible)
                    {
                        this._timeRemainingLabel.Visibility = ViewStates.Visible;
                    }
                });
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"UIUpdateTimeRemaining: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Updates the basic info panel
        /// </summary>
        private void UIDisplayInformation()
        {
            try
            {
                //
                // Sanity
                if (this._activeBlackout == null)
                {
                    return;
                }

                //
                // Display and make visible
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    if (this._informationLayout.Visibility != ViewStates.Visible)
                    {
                        string difficultyText = this.GetString(Resource.String.text_unknown);
                        if (this._activeBlackout != null)
                        {
                            switch (this._activeBlackout.DifficultyCode)
                            {
                                case BlackoutItem.BlackoutDifficultyCode.Novice:
                                    difficultyText = this.GetString(Resource.String.text_novice);
                                    break;
                                case BlackoutItem.BlackoutDifficultyCode.Veteran:
                                    difficultyText = this.GetString(Resource.String.text_veteran);
                                    break;
                                case BlackoutItem.BlackoutDifficultyCode.Master:
                                    difficultyText = this.GetString(Resource.String.text_master);
                                    break;
                                case BlackoutItem.BlackoutDifficultyCode.Nightmare:
                                    difficultyText = this.GetString(Resource.String.text_nightmare);
                                    break;
                                default:
                                    difficultyText = this.GetString(Resource.String.text_unknown);
                                    break;
                            }
                        }

                        this._difficultyLabel.Text = difficultyText;
                        this._bidLabel.Text = this._activeBlackout != null ? $"${this._activeBlackout.Bid}" : this.GetString(Resource.String.text_unknown);
                        this._informationLayout.Visibility = ViewStates.Visible;
                    }
                });
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"UIUpdateTimeRemaining: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Updates the blacklist panel
        /// </summary>
        private void UIDisplayBlacklist()
        {
            string applicationName;
            int @switch = 0;
            TableRow newRow = null;
            TextView applicationText = null;
            List<TableRow> rows = null;
            PackageManager packageManager = null;

            try
            {
                //
                // Sanity
                if (this._activeBlackout == null)
                {
                    return;
                }

                //
                // Init
                rows = new List<TableRow>();
                packageManager = this.Context.PackageManager;

                //
                // Build the rows!
                foreach (string packageName in this._activeBlackout.Blacklist)
                {
                    applicationName = packageManager.GetApplicationInfo(packageName, PackageInfoFlags.MatchAll).LoadLabel(packageManager);
                    if (string.IsNullOrWhiteSpace(applicationName) == false)
                    {
                        // Create new text view
                        applicationText = new TextView(this.Context)
                        {
                            //LayoutParameters = new TableLayout.LayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent),// { Gravity = GravityFlags.Center },
                            Gravity = GravityFlags.Center,
                            Text = applicationName
                        };
                        applicationText.SetPadding(10, 10, 10, 10);

                        // If the column count is 0, initialize new row
                        if (@switch == 0)
                        {
                            rows.Add(newRow = new TableRow(this.Context));
                            newRow.AddView(applicationText);
                            @switch++;
                        }
                        // If the column count is 1, just add the new text
                        else if (@switch == 1)
                        {
                            newRow.AddView(applicationText);
                            @switch--;
                        }
                    };
                }

                MainThread.BeginInvokeOnMainThread(() =>
                {
                    if (this._blacklistLayout.Visibility != ViewStates.Visible)
                    {
                        foreach (TableRow row in rows)
                        {
                            this._blacklistLayout.AddView(row);
                        }

                        this._blacklistLayout.Visibility = ViewStates.Visible;
                    }
                });
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"UIDisplayBlacklist: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }
        #endregion

        #region In App Purchases
        /// <summary>
        /// Processes the update to the blackout item and askes for payment if required
        /// </summary>
        /// <param name="bid"></param>
        private async void ProcessUnlock(int bid)
        {
            try
            {
                // Is the bid greater than $0?
                if (bid > 0)
                {
                    InAppPurchaseUtils.PurchaseResult result = await InAppPurchaseUtils.PurchaseAsync($"device_unlock_{bid.ToString().PadLeft(3, '0')}", true);
                    if (result.Successful == true)
                    {
                        this._activeBlackout.SetBlackoutFinished(BlackoutItem.BlackoutResultCode.Failed);
                        await BlackoutDatabase.UpsertAsync(this._activeBlackout);
                        DisplayUtils.ShowSnackbar(this.View, Resource.String.fragment_blackout_unlocked, Snackbar.LengthLong);
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(this.GetString(result.MessageResourceId)) == false)
                        {
                            DisplayUtils.ShowSnackbar(this.View, result.MessageResourceId, Snackbar.LengthLong);
                        }
                    }
                }
                else
                {
                    this._activeBlackout.SetBlackoutFinished(BlackoutItem.BlackoutResultCode.Failed);
                    await BlackoutDatabase.UpsertAsync(this._activeBlackout);
                    DisplayUtils.ShowSnackbar(this.View, Resource.String.fragment_blackout_unlocked, Snackbar.LengthLong);
                }
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"ProcessUnlock: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }
        #endregion
    }
}