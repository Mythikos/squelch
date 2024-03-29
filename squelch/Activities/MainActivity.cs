﻿using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Content.Res;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using AndroidX.Core.Content;
using Google.Android.Material.BottomNavigation;
using Google.Android.Material.FloatingActionButton;
using Squelch.Fragments;
using Squelch.Library;
using Squelch.Library.Data;
using Squelch.Library.Extensions;
using Squelch.Library.Interfaces;
using Squelch.Library.Utilities;
using Squelch.Receivers;
using Squelch.Services;
using Squelch.Views.Navigation;
using System;

namespace Squelch.Activities
{
    [Activity(Label = "@string/text_app_name", Theme = "@style/AppTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize, ResizeableActivity = false)]
    public class MainActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener, IIndeterminateProgressReporter
    {
        #region Instance Variables
        private static readonly string s_tag = typeof(MainActivity).FullName;

        private GenericBroadcastReceiver _blackoutStartedReceiver;
        private GenericBroadcastReceiver _blackoutEndedReceiver;

        private FrameLayout _fragmentLayout;
        internal ProgressBar ProgressBar { get; private set; }
        internal CurvedBottomNavigationView NavigationBar { get; private set; }
        internal FloatingActionButton NavigationBarSetupBlackoutButton { get; private set; }
        internal Configuration CurrentConfiguration { get; private set; }

        internal const int PERMISSION_INTERNET = 0;
        internal const int PERMISSION_RECEIVE_BOOT_COMPLETED = 1;
        internal const int PERMISSION_USAGE_STATS = 2;
        internal const int PERMISSION_FOREGROUND_SERIVCE = 3;
        internal const int PERMISSION_SYSTEM_ALERT_WINDOW = 4;
        #endregion

        #region Native Events
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            //
            // Setup framework stuff
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
#if DEBUG
            Firebase.Crashlytics.FirebaseCrashlytics.Instance.SetCrashlyticsCollectionEnabled(false);
#else
            Firebase.Crashlytics.FirebaseCrashlytics.Instance.SetCrashlyticsCollectionEnabled(true);
#endif
            Firebase.Crashlytics.FirebaseCrashlytics.Instance.SetUserId(UserSettings.Id);
            Firebase.Crashlytics.FirebaseCrashlytics.Instance.SendUnsentReports();

            //
            // Set layout and get view elements
            this.SetContentView(Resource.Layout.activity_main);

            this._fragmentLayout = this.FindViewById<FrameLayout>(Resource.Id.activity_main_fragment_layout);
            this.ProgressBar = this.FindViewById<ProgressBar>(Resource.Id.activity_main_progress_bar);

            this.NavigationBar = this.FindViewById<CurvedBottomNavigationView>(Resource.Id.activity_main_navigation);
            this.NavigationBar.SetOnNavigationItemSelectedListener(this);

            this.NavigationBarSetupBlackoutButton = this.FindViewById<FloatingActionButton>(Resource.Id.activity_main_setup_blackout_fab_button);
            this.NavigationBarSetupBlackoutButton.Click += delegate { this.SupportFragmentManager.SetFragment(typeof(BlackoutSetupFragment), true, false); };

            //
            // Instantiate
            this._blackoutStartedReceiver = new GenericBroadcastReceiver(this.BlackoutBroadcastReceived);
            this._blackoutEndedReceiver = new GenericBroadcastReceiver(this.BlackoutBroadcastReceived);
            this.CurrentConfiguration = this.Resources.Configuration;

            //
            // Default view values
            this.SetProgressBarState(false);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            base.OnActivityResult(requestCode, resultCode, data);
        }

        public bool OnNavigationItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.navigation_home:
                    this.SupportFragmentManager.SetFragment(typeof(HomeFragment), true, true);
                    return true;
                case Resource.Id.navigation_schedule:
                    this.SupportFragmentManager.SetFragment(typeof(ScheduleFragment), true, true);
                    return true;
                case Resource.Id.navigation_settings:
                    this.SupportFragmentManager.SetFragment(typeof(SettingsFragment), true, true);
                    return true;
                case Resource.Id.navigation_statistics:
                    this.SupportFragmentManager.SetFragment(typeof(StatisticsFragment), true, true);
                    return true;
            }
            return false;
        }

        public override void OnBackPressed()
        {
            AndroidX.Fragment.App.Fragment fragment;

            // Check if we have anything to pop
            if (this.SupportFragmentManager.BackStackEntryCount <= 1)
            {
                return;
            }

            // Make sure we dont have the blackout fragment open
            fragment = this.SupportFragmentManager.FindFragmentByTag(typeof(BlackoutFragment).Name);
            if (fragment != null && fragment.IsVisible)
            {
                return;
            }

            // Proceed as normal
            base.OnBackPressed();
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                case Resource.Id.homeAsUp:
                    if (this.SupportFragmentManager.BackStackEntryCount > 0)
                    {
                        this.SupportFragmentManager.PopBackStack();
                    }

                    return true;
                default:
                    break;
            }

            return base.OnOptionsItemSelected(item);
        }

        protected override async void OnStart()
        {
            base.OnStart();

            //
            // Request permissions
            try
            {
                if (this.CheckSelfPermission(Android.Manifest.Permission.Internet) != Permission.Granted)
                {
                    this.RequestPermissions(new string[] { Android.Manifest.Permission.Internet }, PERMISSION_INTERNET);
                    Logger.Write(s_tag, "OnStart: Requesting Internet permission", Logger.Severity.Info);
                }

                if (this.CheckSelfPermission(Android.Manifest.Permission.ReceiveBootCompleted) != Permission.Granted)
                {
                    this.RequestPermissions(new string[] { Android.Manifest.Permission.ReceiveBootCompleted }, PERMISSION_RECEIVE_BOOT_COMPLETED);
                    Logger.Write(s_tag, "OnStart: Requesting ReceiveBootComplete permission", Logger.Severity.Info);
                }

                if (this.CheckSelfPermission(Android.Manifest.Permission.PackageUsageStats) != Permission.Granted)
                {
                    this.RequestPermissions(new string[] { Android.Manifest.Permission.PackageUsageStats }, PERMISSION_USAGE_STATS);
                    Logger.Write(s_tag, "OnStart: Requesting PackageUsageStats permission", Logger.Severity.Info);
                }

                if (this.CheckSelfPermission(Android.Manifest.Permission.SystemAlertWindow) != Permission.Granted)
                {
                    this.RequestPermissions(new string[] { Android.Manifest.Permission.SystemAlertWindow }, PERMISSION_SYSTEM_ALERT_WINDOW);
                    Logger.Write(s_tag, "OnStart: Requesting SystemAlertWindow permission", Logger.Severity.Info);
                }

                // Only android Pie or higher require this permission request
                if (Build.VERSION.SdkInt >= BuildVersionCodes.P)
                {
                    if (this.CheckSelfPermission(Android.Manifest.Permission.ForegroundService) != Permission.Granted)
                    {
                        this.RequestPermissions(new string[] { Android.Manifest.Permission.ForegroundService }, PERMISSION_FOREGROUND_SERIVCE);
                        Logger.Write(s_tag, "OnStart: Requesting ForegroundService permission", Logger.Severity.Info);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"OnStart: Error occured when requesting required permissions: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            //
            // Perform any cleaning actions against the database
            try
            {
#if DEBUG
                ///////////////////////////
                //await Debugger.SqliteDatabaseTest(this);
                await Debugger.InsertTestBlackoutData(this);
                ///////////////////////////
#endif
                await BlackoutDatabase.Scrub();
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"OnStart: Error occured when attempting to perform database maintenance: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            //
            // Register broadcast receivers
            try
            {
                IntentFilter blackoutStartedFilter = new IntentFilter();
                blackoutStartedFilter.AddAction(EnforcerService.BROADCAST_BLACKOUT_STARTED);
                this.RegisterReceiver(this._blackoutStartedReceiver, blackoutStartedFilter);
                Logger.Write(s_tag, "OnStart: Registered blackout started receiver", Logger.Severity.Info);

                IntentFilter blackoutEndedFilter = new IntentFilter();
                blackoutEndedFilter.AddAction(EnforcerService.BROADCAST_BLACKOUT_ENDED);
                this.RegisterReceiver(this._blackoutEndedReceiver, blackoutEndedFilter);
                Logger.Write(s_tag, "OnStart: Registered blackout ended receiver", Logger.Severity.Info);
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"OnStart: Error occured when attempting to register blackout broadcast receivers: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        protected override void OnStop()
        {
            base.OnStop();

            //
            // Unregister the blackout receivers
            try
            {
                this.UnregisterReceiver(this._blackoutStartedReceiver);
                Logger.Write(s_tag, "OnStop: Unregistered blackout started receiver", Logger.Severity.Info);

                this.UnregisterReceiver(this._blackoutEndedReceiver);
                Logger.Write(s_tag, "OnStop: Unregistered blackout ended receiver", Logger.Severity.Info);
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"OnStop: Error occured when attempting to unregister the blackout broadcast receivers: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        protected override async void OnPostResume()
        {
            base.OnPostResume();

            try
            {
                //
                // Determine what fragment to load
                if (string.IsNullOrWhiteSpace(UserSettings.GetFlagValue(UserSettings.FlagKeys.FirstTimeSetup_IsCompleted))) // First time setup
                {
                    this.SupportFragmentManager.SetFragment(typeof(FirstTimeSetupFragment), false, true);
                }
                else if (await BlackoutDatabase.HasActiveBackoutAsync())
                {
                    this.SupportFragmentManager.SetFragment(typeof(BlackoutFragment), false, true);

                    //
                    // Try to start the enforcer service
                    if (EnforcerService.IsRunning == false)
                    {
                        Logger.Write(s_tag, $"OnPostResume: EnforcerService is not running, starting it", Logger.Severity.Info);
                        ContextCompat.StartForegroundService(this, new Intent(this, typeof(EnforcerService)).SetAction(EnforcerService.ACTION_START));
                    }
                }
                else
                {
                    // Grab state-dependant fragments from the fragment manager
                    AndroidX.Fragment.App.Fragment firstTimeSetupFragment = this.SupportFragmentManager.FindFragmentByTag(typeof(FirstTimeSetupFragment).Name);
                    AndroidX.Fragment.App.Fragment blackoutFragment = this.SupportFragmentManager.FindFragmentByTag(typeof(BlackoutFragment).Name);

                    // If there isnt a fragment assigned, or if the fragment assigned is one of the state-dependant fragments, force it home
                    if ((this._fragmentLayout != null && this._fragmentLayout.ChildCount <= 0) || firstTimeSetupFragment?.IsResumed == true || blackoutFragment?.IsResumed == true)
                    {
                        this.SupportFragmentManager.SetFragment(typeof(HomeFragment), true, true);
                    }

                    //
                    // Try to start the enforcer service
                    if (EnforcerService.IsRunning == false)
                    {
                        Logger.Write(s_tag, $"OnPostResume: EnforcerService is not running, starting it", Logger.Severity.Info);
                        ContextCompat.StartForegroundService(this, new Intent(this, typeof(EnforcerService)).SetAction(EnforcerService.ACTION_START));
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"OnPostResume: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }
#endregion

#region Event Handlers
        internal void BlackoutBroadcastReceived(Context context, Intent intent)
        {
            try
            {
                // If squelch is not in the foreground, we don't want to try and set the fragment
                if (GeneralUtils.SelfIsInForeground(context))
                {
                    if (intent.Action.Equals(EnforcerService.BROADCAST_BLACKOUT_STARTED))
                    {
                        this.SupportFragmentManager.SetFragment(typeof(BlackoutFragment), false, false);
                    }
                    else if (intent.Action.Equals(EnforcerService.BROADCAST_BLACKOUT_ENDED))
                    {
                        this.SupportFragmentManager.SetFragment(typeof(HomeFragment), true, true);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"BlackoutBroadcastReceived: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }
#endregion

#region Helper Methods
        public void SetupNavigation(int titleResourceId, bool showNavigationBar, bool showActionbarBackButton)
        {
            this.Title = this.GetString(titleResourceId);
            this.NavigationBar.Visibility = (showNavigationBar) ? ViewStates.Visible : ViewStates.Gone;
            this.NavigationBarSetupBlackoutButton.Visibility = (showNavigationBar) ? ViewStates.Visible : ViewStates.Gone;
            this.SupportActionBar.SetDisplayHomeAsUpEnabled(showActionbarBackButton);
        }
#endregion

#region Interface Methods
        public void SetProgressBarState(bool visible)
        {
            RelativeLayout.LayoutParams layoutParameters;

            if (this.ProgressBar != null)
            {
                this.ProgressBar.Visibility = visible ? ViewStates.Visible : ViewStates.Gone;

                // Remove padding from bar
                layoutParameters = new RelativeLayout.LayoutParams(RelativeLayout.LayoutParams.MatchParent, RelativeLayout.LayoutParams.WrapContent);
                layoutParameters.SetMargins(0, 0, 0, 0);
                this.ProgressBar.LayoutParameters = layoutParameters;
            }
        }
#endregion
    }
}

