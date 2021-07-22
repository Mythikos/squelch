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
                _rootLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_blackout_root_layout);
                _informationLayout = view.FindViewById<TableLayout>(Resource.Id.fragment_blackout_information_layout);
                _blacklistLayout = view.FindViewById<TableLayout>(Resource.Id.fragment_blackout_blacklist_layout);
                _progressIndicator = view.FindViewById<ProgressBar>(Resource.Id.fragment_blackout_progress_indicator);
                _timeRemainingLabel = view.FindViewById<AppCompatTextView>(Resource.Id.fragment_blackout_time_remaining);
                _difficultyLabel = view.FindViewById<TextView>(Resource.Id.fragment_blackout_information_difficulty_label);
                _bidLabel = view.FindViewById<TextView>(Resource.Id.fragment_blackout_information_bid_label);
                _unlockButton = view.FindViewById<Button>(Resource.Id.fragment_blackout_button_unlock);

                //
                // Hookup event
                _unlockButton.Click += UnlockButton_Click;

                //
                // Setup navbar
                ((MainActivity)this.Activity).SetupNavigation(Resource.String.text_blackout, false, false);

                //
                // Prepare view
                TextViewCompat.SetAutoSizeTextTypeWithDefaults(_timeRemainingLabel, TextViewCompat.AutoSizeTextTypeUniform);

                _progressIndicator.Max = INDICATOR_MAX_VALUE;
                _progressIndicator.Progress = INDICATOR_MAX_VALUE;
                _progressIndicator.SecondaryProgress = INDICATOR_MAX_VALUE;
                _timeRemainingLabel.Text = "00:00:00";
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
                if (_refreshTimer == null)
                {
                    _refreshTimer = new System.Timers.Timer();
                    _refreshTimer.Interval = 1000;
                    _refreshTimer.Elapsed += RefreshTimer_Elapsed;
                    Logger.Write(_tag, "OnStart: Timer created", Logger.Severity.Info);
                }
                _refreshTimer.Start();
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
                if (_refreshTimer != null)
                {
                    _refreshTimer.Stop();
                    _refreshTimer.Dispose();
                    _refreshTimer = null;
                }

                //
                // Close usage stats dialog
                if (_permissionDialog != null)
                    _permissionDialog.Dismiss();
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnStop: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        public async override void OnResume()
        {
            base.OnResume();

            try
            {
                //
                // Get the active blackout
                _activeBlackout = await BlackoutDatabase.GetFirstActiveBlackoutAsync();
                UIDisplayInformation();
                UIDisplayBlacklist();

                //
                // Set firebase screen
                FirebaseAnalyticsUtils.SetCurrentScreen(this);

                //
                // Check permissions and ask for it if we need it
                // NOTE: THIS MIGHT CAUSE ISSUES IF USAGE STATS SETTINGS SECTION IS BEING BLOCKED...
                if (_permissionDialog == null && PermissionUtils.GetUsageDataPermission(this.Context) == false)
                {
                    PermissionUtils.GetUsageDataPermission(this.Context, true, (Android.App.AlertDialog dialog) =>
                    {
                        // Get the dialog
                        _permissionDialog = dialog;
                        _permissionDialog.DismissEvent += delegate { _permissionDialog = null; };
                    });
                }

                // NOTE: THIS MIGHT CAUSE ISSUES IF OVERLAY SETTINGS SECTION IS BEING BLOCKED...
                if (_permissionDialog == null && PermissionUtils.GetApplicationOverlayPermission(this.Context) == false)
                {
                    PermissionUtils.GetApplicationOverlayPermission(this.Context, true, (Android.App.AlertDialog dialog) =>
                    {
                        // Get the dialog
                        _permissionDialog = dialog;
                        _permissionDialog.DismissEvent += delegate { _permissionDialog = null; };
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
                if (_activeBlackout == null)
                {
                    DisplayUtils.ShowSnackbar(this.View, GetString(Resource.String.error_unable_to_determine_blackout), Snackbar.LengthIndefinite);
                    return;
                }

                DisplayUtils.ShowGenericAlertDialog(this.Context, GetString(Resource.String.text_confirm), GetString(Resource.String.fragment_blackout_confirmation_message), true, GetString(Resource.String.text_yes), delegate { ProcessUnlock(_activeBlackout.Bid); }, GetString(Resource.String.text_no), delegate { });
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
                UIDisplayProgress();
                UIDisplayTimeRemaining();
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
                if (_activeBlackout == null)
                    return;

                //
                // Calculate progress
                totalSeconds = Math.Max((_activeBlackout.ScheduledEndDateTime - _activeBlackout.ScheduledStartDateTime).TotalSeconds, 0);
                elapsedSeconds = Math.Max((_activeBlackout.ScheduledEndDateTime - DateTime.Now).TotalSeconds, 0);
                percentageComplete = (int)Math.Floor((INDICATOR_MAX_VALUE / totalSeconds) * elapsedSeconds);
                if (percentageComplete < 1)
                    percentageComplete = 1;

                //
                // Display
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    animator = ObjectAnimator.OfInt(_progressIndicator, "progress", _progressIndicator.Progress, percentageComplete);
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
                if (_activeBlackout == null)
                    return;

                //
                // Calculate time remaining
                timeRemaining = _activeBlackout.ScheduledEndDateTime.Subtract(DateTime.Now);
                totalHours = Math.Max((timeRemaining.Days * 24) + timeRemaining.Hours, 0);
                totalMinutes = Math.Max(timeRemaining.Minutes, 0);
                totalSeconds = Math.Max(timeRemaining.Seconds, 0);

                //
                // Display and make visible
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    _timeRemainingLabel.Text = $"{totalHours.ToString("00")}:{totalMinutes.ToString("00")}:{totalSeconds.ToString("00")}";
                    if (_timeRemainingLabel.Visibility != ViewStates.Visible)
                        _timeRemainingLabel.Visibility = ViewStates.Visible;
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
                if (_activeBlackout == null)
                    return;

                //
                // Display and make visible
                MainThread.BeginInvokeOnMainThread(() =>
                {
                    if (_informationLayout.Visibility != ViewStates.Visible)
                    {
                        var difficultyText = this.GetString(Resource.String.text_unknown);
                        if (_activeBlackout != null)
                        {
                            switch (_activeBlackout.DifficultyCode)
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

                        _difficultyLabel.Text = difficultyText;
                        _bidLabel.Text = _activeBlackout != null ? $"${_activeBlackout.Bid}" : this.GetString(Resource.String.text_unknown);
                        _informationLayout.Visibility = ViewStates.Visible;
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
                if (_activeBlackout == null)
                    return;

                //
                // Init
                rows = new List<TableRow>();
                packageManager = this.Context.PackageManager;

                //
                // Build the rows!
                foreach (string packageName in _activeBlackout.Blacklist)
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
                    if (_blacklistLayout.Visibility != ViewStates.Visible)
                    {
                        foreach (TableRow row in rows)
                            _blacklistLayout.AddView(row);

                        _blacklistLayout.Visibility = ViewStates.Visible;
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
                    (bool, string) result = await InAppPurchaseUtils.PurchaseAsync($"device_unlock_{bid.ToString().PadLeft(3, '0')}", true);
                    if (result.Item1 == true)
                    {
                        _activeBlackout.SetBlackoutFinished(BlackoutItem.BlackoutResultCode.Failed);
                        await BlackoutDatabase.UpsertAsync(_activeBlackout);
                        DisplayUtils.ShowSnackbar(this.View, this.GetString(Resource.String.fragment_blackout_unlocked), Snackbar.LengthLong);
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(result.Item2) == false)
                            DisplayUtils.ShowSnackbar(this.View, result.Item2, Snackbar.LengthLong);
                    }
                }
                else
                {
                    _activeBlackout.SetBlackoutFinished(BlackoutItem.BlackoutResultCode.Failed);
                    await BlackoutDatabase.UpsertAsync(_activeBlackout);
                    DisplayUtils.ShowSnackbar(this.View, this.GetString(Resource.String.fragment_blackout_unlocked), Snackbar.LengthLong);
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