using Android.App;
using Android.App.Usage;
using Android.Content;
using Android.Content.PM;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Squelch.Library;
using Squelch.Library.Data;
using Squelch.Library.Entities;
using Squelch.Library.Utilities;
using Squelch.Library.Wrappers;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Essentials;

namespace Squelch.Services
{
    [Service(Label = "Squelch Enforcer", Enabled = true)]
    internal class EnforcerService : Service
    {
        #region Properties
        internal static bool IsRunning { get; private set; } = false;
        #endregion

        #region Instance Variables
        private static readonly string s_tag = typeof(EnforcerService).FullName;
        private Timer _tmrPollingForBlackout = null;
        private Timer _tmrEnforceBlackout = null;
        private UsageStatsWrapper _usageStatsWrapper;
        private NotificationManager _notificationManager = null;
        private int? _activeBlackoutId = null; // Needs to be the id
        private DateTime? _nextEnforcementTime = null;

        // Overlay
        private IWindowManager _windowManager = null;
        private View _overlayView = null;
        private WindowManagerLayoutParams _overlayLayoutParameters = null;
        private TextView _overlayNoticeLabel = null;
        private Button _overlayBackButton = null;
        private Button _overlayUnlockButton = null;

        // Constants
        internal const int FOREGROUND_ID = 3000;
        internal const string BROADCAST_BLACKOUT_STARTED = "com.squelch.android.enforcerservice.broadcast.BLACKOUT_STARTED";
        internal const string BROADCAST_BLACKOUT_ENDED = "com.squelch.android.enforcerservice.broadcast.BLACKOUT_ENDED";
        internal const string ACTION_START = "com.squelch.android.enforcerservice.action.START";
        internal const string ACTION_STOP = "com.squelch.android.enforcerservice.action.STOP"; // Not used

        private const long ENFORCEMENT_POLLING_TIMER_MILLIS = 5000;
        private const long ENFORCEMENT_REACT_TIMER_MILLIS = 500;
        private const string NOTIFICATION_CHANNEL_ID = "enforcer_service_notification_channel";
        private const string NOTIFICATION_TITLE = "Enforcer";
        private const string NOTIFICATION_MESSAGE_WAITING = "Waiting for blackout";
        private const string NOTIFICATION_MESSAGE_ACTIVE = "Blackout is active";
        #endregion

        #region Native Methods
        public override void OnCreate()
        {
            base.OnCreate();

            //
            // Call start foreground (required for android 9 +)
            StartForeground(FOREGROUND_ID, NotificationUtils.CreateNotification(this, NOTIFICATION_CHANNEL_ID, NOTIFICATION_TITLE, NOTIFICATION_MESSAGE_WAITING, true, NotificationImportance.Low));

            //
            // Initialize overlay and window manager
            this._windowManager = GetSystemService(Context.WindowService).JavaCast<IWindowManager>();
            var inflater = (LayoutInflater)GetSystemService(Context.LayoutInflaterService);
            _overlayView = inflater.Inflate(Resource.Layout.overlay_blackout, null);
            _overlayNoticeLabel = _overlayView.FindViewById<TextView>(Resource.Id.overlay_blackout_notice_label);
            _overlayBackButton = _overlayView.FindViewById<Button>(Resource.Id.overlay_blackout_back_button);
            _overlayUnlockButton = _overlayView.FindViewById<Button>(Resource.Id.overlay_blackout_squelch_button);

            _overlayBackButton.Click += delegate
            {
                //
                // Open the app launcher
                GeneralUtils.OpenLauncherActivity(this);

                //
                // Remove overlay
                this._nextEnforcementTime = DateTime.Now.AddSeconds(1);
                if (this._overlayView.IsShown == true)
                    this._windowManager.RemoveView(_overlayView);
            };

            _overlayUnlockButton.Click += delegate
            {
                //
                // Open main activity
                GeneralUtils.OpenSelfActivity(this);

                //
                // Remove overlay
                this._nextEnforcementTime = DateTime.Now.AddSeconds(1);
                if (this._overlayView.IsShown == true)
                    this._windowManager.RemoveView(_overlayView);
            };

            _overlayLayoutParameters = new WindowManagerLayoutParams(
                        WindowManagerLayoutParams.MatchParent,
                        WindowManagerLayoutParams.MatchParent,
                        (Build.VERSION.SdkInt >= BuildVersionCodes.O ? WindowManagerTypes.ApplicationOverlay : WindowManagerTypes.SystemAlert),
                        WindowManagerFlags.NotFocusable | WindowManagerFlags.NotTouchModal,
                        Format.Translucent);
            _overlayLayoutParameters.Gravity = GravityFlags.Left | GravityFlags.Top;
            _overlayLayoutParameters.X = 0;
            _overlayLayoutParameters.Y = 0;
            _overlayLayoutParameters.WindowAnimations = Android.Resource.Style.AnimationToast;
        }

        public override void OnDestroy()
        {
            base.OnDestroy();

            //
            // Remove the overlay
            if (_overlayView != null)
                if (_overlayView.IsShown == true)
                    this._windowManager.RemoveView(_overlayView);
        }

        public override IBinder OnBind(Intent intent)
        {
            return null;
        }

        /// <summary>
        /// Depending on intent, either enlist as foreground and prepare service or shutdown the service.
        /// </summary>
        /// <param name="intent"></param>
        /// <param name="flags"></param>
        /// <param name="startId"></param>
        /// <returns></returns>
        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            string action = string.Empty;
            try
            {
                action = intent?.Action;
                if (string.IsNullOrWhiteSpace(action))
                {
                    Logger.Write(s_tag, $"StartCommandResult: No action was recieved by method... assuming {ACTION_START}", Logger.Severity.Warn);
                    action = ACTION_START;
                }

                switch (intent?.Action)
                {
                    case ACTION_START:
                        if (EnforcerService.IsRunning == false)
                            InitializeService();
                        else
                            Logger.Write(s_tag, $"StartCommandResult: {ACTION_START} action received but the service is already running", Logger.Severity.Warn);
                        break;
                    case ACTION_STOP:
                        if (EnforcerService.IsRunning == true)
                            DeinitializeService();
                        else
                            Logger.Write(s_tag, $"StartCommandResult: {ACTION_STOP} action received but the service is already stopped", Logger.Severity.Warn);
                        break;
                    default:
                        Logger.Write(s_tag, $"StartCommandResult: Action not supported by service", Logger.Severity.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"StartCommandResult: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            return StartCommandResult.Sticky;
            //return StartCommandResult.RedeliverIntent;
        }
        #endregion

        #region Helper Methods
        /// <summary>
        /// Initializes the service
        /// </summary>
        private void InitializeService()
        {
            try
            {
                //
                // Set instance vars
                this._usageStatsWrapper = new UsageStatsWrapper(this);
                this._notificationManager = (NotificationManager)GetSystemService(Context.NotificationService);
                this._activeBlackoutId = null;
                this._nextEnforcementTime = null;

                //
                // Create timers
                this._tmrPollingForBlackout = new Timer() { Interval = ENFORCEMENT_POLLING_TIMER_MILLIS };
                this._tmrPollingForBlackout.Elapsed += PollForBlackout;
                this._tmrPollingForBlackout.Start();

                this._tmrEnforceBlackout = new Timer() { Interval = ENFORCEMENT_REACT_TIMER_MILLIS };
                this._tmrEnforceBlackout.Elapsed += EnforceBlackout;
                this._tmrEnforceBlackout.Stop();

                //
                // Set IsRunning flag
                EnforcerService.IsRunning = true;

                Logger.Write(s_tag, $"InitializeService: Service has initialized successfully", Logger.Severity.Info);
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"InitializeService: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Deinitializes the service
        /// </summary>
        private void DeinitializeService()
        {
            try
            {
                // Set instance vars
                this._usageStatsWrapper = null;
                this._notificationManager = null;
                this._activeBlackoutId = null;
                this._nextEnforcementTime = null;

                // Kill timers
                if (this._tmrPollingForBlackout != null)
                {
                    this._tmrPollingForBlackout.Stop();
                    this._tmrPollingForBlackout.Dispose();
                    this._tmrPollingForBlackout = null;
                }

                if (this._tmrEnforceBlackout != null)
                {
                    this._tmrEnforceBlackout.Stop();
                    this._tmrEnforceBlackout.Dispose();
                    this._tmrPollingForBlackout = null;
                }

                //
                // Set IsRunning flag
                EnforcerService.IsRunning = false;

                Logger.Write(s_tag, $"DeinitializeService: Service has deinitialized successfully.", Logger.Severity.Info);
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"DeinitializeService: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

        }

        /// <summary>
        /// Starts a new blackout by setting respective variables and starting the enforcement timer
        /// </summary>
        /// <param name="activeBlackoutItem"></param>
        private async Task StartBlackout(BlackoutItem activeBlackoutItem)
        {
            try
            {
                //
                // Sanity
                if (activeBlackoutItem == null)
                    throw new ArgumentNullException("activeBlackoutItem");

                if (activeBlackoutItem.IsBlackoutPending() == false && activeBlackoutItem.IsBlackoutActive() == false)
                    throw new InvalidOperationException("Input blackout item is not in the correct state");

                //
                // Set the blackout item as active
                activeBlackoutItem.SetBlackoutActive();
                await BlackoutDatabase.UpsertAsync(activeBlackoutItem);
                this._activeBlackoutId = activeBlackoutItem.Id;
                this._nextEnforcementTime = null;

                //
                // Set instance variables and cycle timers
                this._tmrPollingForBlackout.Stop();
                this._tmrEnforceBlackout.Start();

                //
                // See if we need to immediately react
                try
                {
                    if (GeneralUtils.SelfIsInForeground(this) == false)
                        React();
                }
                catch (Exception ex)
                {
                    Logger.Write(s_tag, $"StartBlackout: Squelch was detected as in the background when a blackout started and encountered an error when attempting to move to the foreground: {Logger.CreateExceptionString(ex)}", Logger.Severity.Warn);
                }

                //
                // Update foreground notification
                if (this._notificationManager == null)
                    this._notificationManager = (NotificationManager)GetSystemService(Context.NotificationService);
                this._notificationManager.Notify(FOREGROUND_ID, NotificationUtils.CreateNotification(this, NOTIFICATION_CHANNEL_ID, NOTIFICATION_TITLE, NOTIFICATION_MESSAGE_ACTIVE, true, NotificationImportance.Low));

                //
                // Send a broadcast that the blackout has started
                SendBroadcast(new Intent(BROADCAST_BLACKOUT_STARTED));

                Logger.Write(s_tag, $"StartBlackout: Blackout has been started", Logger.Severity.Info);
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"StartBlackout: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Ends the blackout by reseting respective variables and restarting poll timer
        /// </summary>
        private async Task EndBlackout()
        {
            //
            // Vars
            BlackoutItem blackoutItem;

            try
            {
                if (_activeBlackoutId != null)
                {
                    blackoutItem = await BlackoutDatabase.FindAsync(_activeBlackoutId.GetValueOrDefault());
                    if (blackoutItem != null)
                    {
                        //
                        // Update the active blackout item
                        if (blackoutItem.StatusCode != BlackoutItem.BlackoutStatusCode.Finished) // Is the item still pending/active?
                        {
                            blackoutItem.SetBlackoutFinished(BlackoutItem.BlackoutResultCode.Success); // Must be a success - wasn't yet assigned
                            await BlackoutDatabase.UpsertAsync(blackoutItem);
                        }

                        //
                        // Send blackout analytics
                        if (blackoutItem.IsBlackoutSuccessful())
                            FirebaseAnalyticsUtils.SendBlackoutEvent(FirebaseAnalyticsUtils.EVENT_BLACKOUT_SUCCESSFUL, blackoutItem);
                        else if (blackoutItem.IsBlackoutFailed())
                            FirebaseAnalyticsUtils.SendBlackoutEvent(FirebaseAnalyticsUtils.EVENT_BLACKOUT_FAILED, blackoutItem);
                        else if (blackoutItem.IsBlackoutCancelled())
                            FirebaseAnalyticsUtils.SendBlackoutEvent(FirebaseAnalyticsUtils.EVENT_BLACKOUT_CANCELLED, blackoutItem);
                    }
                }

                //
                // Set instance variables and cycle timers
                this._activeBlackoutId = null;
                this._nextEnforcementTime = null;
                this._tmrPollingForBlackout.Start();
                this._tmrEnforceBlackout.Stop();

                //
                // Update foreground notification
                if (this._notificationManager == null)
                    this._notificationManager = (NotificationManager)GetSystemService(Context.NotificationService);
                this._notificationManager.Notify(FOREGROUND_ID, NotificationUtils.CreateNotification(this, NOTIFICATION_CHANNEL_ID, NOTIFICATION_TITLE, NOTIFICATION_MESSAGE_WAITING, true, NotificationImportance.Low));

                //
                // Send a broadcast that the blackout has ended
                SendBroadcast(new Intent(BROADCAST_BLACKOUT_ENDED));

                Logger.Write(s_tag, $"EndBlackout: Blackout has been ended", Logger.Severity.Info);
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"EndBlackout: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Opens the main activity (which opens the app)
        /// </summary>
        private void React(ApplicationInfo application = null)
        {
            string noticeLabel = string.Empty;
            string applicationLabel = string.Empty;

            //
            // Close system dialogs as they will prevent squelch from opening
            try
            {
                SendBroadcast(new Intent(Intent.ActionCloseSystemDialogs));

                Logger.Write(s_tag, $"React: System dialogs have been requested to close", Logger.Severity.Info);
            }
            catch (Exception ex) { Logger.Write(s_tag, $"React: Failure occured when attempting to close system dialogs: {Logger.CreateExceptionString(ex)}", Logger.Severity.Warn); }

            //
            // Check if we have permission to draw over apps
            if (PermissionUtils.GetApplicationOverlayPermission(this, false) == true)
            {
                // Build overlay
                try
                {
                    // Is it already being shown?
                    if (_overlayView.IsShown == false)
                    {
                        Logger.Write(s_tag, "React: Showing overlay", Logger.Severity.Debug);

                        // Load application label
                        if (application != null)
                            applicationLabel = application.LoadLabel(this.PackageManager);

                        if (string.IsNullOrWhiteSpace(applicationLabel) == true)
                            applicationLabel = $"That application";

                        // Display it
                        MainThread.BeginInvokeOnMainThread(() =>
                        {
                            _overlayNoticeLabel.SetText($"{applicationLabel} is on your blacklist!", TextView.BufferType.Editable);
                            if (this._overlayView.IsShown == false)
                                this._windowManager.AddView(_overlayView, _overlayLayoutParameters);
                        });
                        Logger.Write(s_tag, $"React: Overlay has been requested to start", Logger.Severity.Info);
                    }
                    else
                    {
                        Logger.Write(s_tag, "React: React attempted to show already visible overlay", Logger.Severity.Debug);
                    }
                }
                catch (Exception ex)
                {
                    Logger.Write(s_tag, $"React: Failure occured when attempting to open the blackout overlay: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
                    GeneralUtils.OpenSelfActivity(this);
                }
            }
            else
            {
                // Open main activity
                try
                {
                    GeneralUtils.OpenSelfActivity(this);
                    Logger.Write(s_tag, $"React: Main activity has been requested to start", Logger.Severity.Info);
                }
                catch (Exception ex)
                {
                    Logger.Write(s_tag, $"React: Failure occured when attempting to open the main activity: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
                }
            }
        }

        /// <summary>
        /// Uses aggregated usage stats and recent usage events to determine if the enforcement service needs to react to an event.
        /// </summary>
        /// <param name="beginTime"></param>
        /// <param name="endTime"></param>
        /// <returns></returns>
        private Tuple<bool, ApplicationInfo> ShouldReact(List<string> blacklist)
        {
            // Vars
            Tuple<bool, ApplicationInfo> result;

            try
            {
                result = Tuple.Create<bool, ApplicationInfo>(false, null);

                Logger.Write(s_tag, $"ShouldReact: {this._usageStatsWrapper?.ForegroundApplication?.PackageName} is currenly in the foreground", Logger.Severity.Info);
                foreach (string packageName in blacklist)
                {
                    if (this._usageStatsWrapper?.ForegroundApplication?.PackageName.Equals(packageName, StringComparison.OrdinalIgnoreCase) == true)
                    {
                        Logger.Write(s_tag, $"ShouldReact: {packageName} is in the foreground and is on the blacklist", Logger.Severity.Info);
                        result = Tuple.Create<bool, ApplicationInfo>(true, this._usageStatsWrapper.ForegroundApplication);
                        break;
                    }
                }
                Logger.Write(s_tag, $"ShouldReact: Should react? {result.Item1}", Logger.Severity.Info);
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"ShouldReact: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
                result = Tuple.Create<bool, ApplicationInfo>(true, null);
            }

            // Return the result
            return result;
        }
        #endregion

        #region Timer Methods
        /// <summary>
        /// Checks for if a blackout is now active
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public async void PollForBlackout(object sender, ElapsedEventArgs e)
        {
            // Vars
            BlackoutItem blackoutItem;

            try
            {
                //
                // Is there any blackouts? 
                if (await BlackoutDatabase.CountAsync() > 0)
                {
                    blackoutItem = await BlackoutDatabase.GetFirstActiveBlackoutAsync(); // Grab the first active blackout first
                    if (blackoutItem == null)
                        blackoutItem = await BlackoutDatabase.GetFirstPendingBlackoutAsync(DateTime.Now);
                    //blackoutItem = await BlackoutDatabase.GetFirstBlackoutAsync(DateTime.Now, BlackoutItem.BlackoutStatusCode.Pending); // Otherwise, grab the first pending blackout

                    // Did we find a blackout item?
                    if (blackoutItem != null)
                    {
                        Logger.Write(s_tag, "PollForBlackout: Found a blackout that is ready to begin", Logger.Severity.Info);
                        await StartBlackout(blackoutItem); // Start the blackout
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"PollForBlackout: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        /// <summary>
        /// Enforces the blackout conditions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public async void EnforceBlackout(object sender, ElapsedEventArgs e)
        {
            // Vars
            DateTime currentDateTime;
            BlackoutItem blackoutItem;

            try
            {
                //
                // Init
                currentDateTime = DateTime.Now;

                //
                // Are we currently delaying enforcement?
                if (this._nextEnforcementTime == null)
                {
                    //
                    // We have a blackout item right?
                    if (this._activeBlackoutId != null)
                    {
                        blackoutItem = await BlackoutDatabase.FindAsync(_activeBlackoutId.GetValueOrDefault());
                        if (blackoutItem != null)
                        {
                            //
                            // Check to see if the active blackout item is still within the correct timespan and has the correct status code
                            if (blackoutItem.ScheduledStartDateTime < currentDateTime && blackoutItem.ScheduledEndDateTime >= currentDateTime && blackoutItem.StatusCode != BlackoutItem.BlackoutStatusCode.Finished)
                            {
                                // Are we in the background?
                                if (GeneralUtils.SelfIsInForeground(this) == false)
                                {
                                    try
                                    {
                                        // Do we have permission
                                        if (PermissionUtils.GetUsageDataPermission(this, false) == true)
                                        {
                                            if (this._usageStatsWrapper == null)
                                                this._usageStatsWrapper = new UsageStatsWrapper(this);
                                            this._usageStatsWrapper.Update(); // Must be called each update

                                            // Should we react?
                                            var shouldReact = ShouldReact(blackoutItem.Blacklist);
                                            if (shouldReact.Item1 == true)
                                            {
                                                // Yep!
                                                Logger.Write(s_tag, $"EnforceBlackout: Reacting to blocked usage", Logger.Severity.Info);
                                                React(shouldReact.Item2);
                                            }

                                        }
                                        else
                                        {
                                            // Dont have permission
                                            GeneralUtils.OpenSelfActivity(this);
                                            Logger.Write(s_tag, $"EnforceBlackout: Process does not have Usage Stats permission. Assuming we need to react.", Logger.Severity.Warn);
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        Logger.Write(s_tag, $"EnforceBlackout: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
                                    }
                                }
                            }
                            else
                            {
                                Logger.Write(s_tag, $"EnforceBlackout: Blackout is no longer valid", Logger.Severity.Info);

                                // Blackout is no longer in a valid time range or a valid status, lets end
                                await EndBlackout();
                            }
                        }
                        else
                        {
                            Logger.Write(s_tag, $"EnforceBlackout: Unable to locate a blackout with the current active blackout id... ending blackout", Logger.Severity.Wtf);

                            // If the blackout cant be found anymore.... just exit?
                            try { await EndBlackout(); } catch (Exception iex) { Log.Error(s_tag, $"EnforceBlackout: Last ditch effort to recover from null blackout failed: {iex.Message}"); } // Attempt to end the erroneous blackout
                        }
                    }
                    else
                    {
                        Logger.Write(s_tag, $"EnforceBlackout: Active blackout id is null... ending blackout", Logger.Severity.Wtf);

                        // If the blackout cant be found anymore.... just exit?
                        try { await EndBlackout(); } catch (Exception iex) { Log.Error(s_tag, $"EnforceBlackout: Last ditch effort to recover from null blackout id failed: {iex.Message}"); } // Attempt to end the erroneous blackout
                    }
                }
                else
                {
                    // Delay is active, is it time to end it?
                    if (this._nextEnforcementTime <= currentDateTime)
                    {
                        Logger.Write(s_tag, $"EnforceBlackout: Enforcement time delay reset.", Logger.Severity.Debug);
                        this._nextEnforcementTime = null;
                    }
                    else
                    {
                        Logger.Write(s_tag, $"EnforceBlackout: Enforcement time is being delayed.", Logger.Severity.Debug);
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error(s_tag, $"EnforceBlackout: Error occured when attempting to enforce active blackout: {ex.Message}");
                try { React(); } catch (Exception iex) { Log.Error(s_tag, $"EnforceBlackout: Last ditch effort to recover from EnforceBlackout exception failed: {iex.Message}"); } // Attempt to open the main activity in the case of error
            }
        }
        #endregion
    }
}