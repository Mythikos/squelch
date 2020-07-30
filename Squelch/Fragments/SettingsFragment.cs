using Android.Content;
using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using Squelch.Activities;
using Squelch.Library;
using Squelch.Library.Data;
using Squelch.Library.Extensions;
using Squelch.Library.Interfaces;
using Squelch.Library.Singletons;
using Squelch.Library.Utilities;
using System;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Squelch.Fragments
{
    public class SettingsFragment : Fragment
    {
        #region Instance Variables
        private static readonly string _tag = typeof(SettingsFragment).FullName;

        // Parent view items
        private LinearLayout _rootLayout;

        // User settings related
        private LinearLayout _idLayout, _firstNameLayout, _lastNameLayout;
        private TextView _idContentLabel, _firstNameContentLabel, _lastNameContentLabel;

        // Permissions settings related
        private LinearLayout _usageStatsLayout, _applicationOverlayLayout;
        private TextView _usageStatsStateLabel, _applicationOverlayStateLabel;

        // About settings related
        private LinearLayout _versionLayout, _privacyPolicyLayout, _eulaLayout, _openSourceLayout;
        private TextView _versionContentLabel;

        private delegate Task InputCallback(string value);
        #endregion

        #region Native Events
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view;

            //
            // Inflate the layour
            view = inflater.Inflate(Resource.Layout.fragment_settings, container, false);

            try
            {
                _rootLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_settings_root_layout);

                //
                // Setting: User
                _idLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_settings_user_id_layout);
                _idContentLabel = view.FindViewById<TextView>(Resource.Id.fragment_settings_user_id_content_label);
                _idLayout.Click += async delegate
                {
                    try
                    {
                        SetIsWorking(true);

                        await Clipboard.SetTextAsync(_versionContentLabel.Text);
                        DisplayUtils.ShowToast(this.Context, "Id copied to clipboard");
                    }
                    finally { SetIsWorking(false); }
                };

                _firstNameLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_settings_user_first_name_layout);
                _firstNameContentLabel = view.FindViewById<TextView>(Resource.Id.fragment_settings_user_first_name_content_label);
                _firstNameLayout.Click += delegate
                {
                    try
                    {
                        SetIsWorking(true);
                        DisplayUtils.ShowGenericSingleInputAlertDialog(
                            this.Context,
                            Resources.GetString(Resource.String.label_first_name),
                            "Please provide your first name",
                            UserSettings.FirstName,
                            Resources.GetString(Resource.String.label_first_name),
                            Android.Text.InputTypes.ClassText,
                            true,
                            true,
                            "Save",
                            async delegate (string value) 
                            { 
                                UserSettings.FirstName = value?.Trim();
                                await RedrawView();
                            },
                            "Cancel",
                            null
                        );
                    }
                    finally { SetIsWorking(false); }
                };

                _lastNameLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_settings_user_last_name_layout);
                _lastNameContentLabel = view.FindViewById<TextView>(Resource.Id.fragment_settings_user_last_name_content_label);
                _lastNameLayout.Click += delegate
                {
                    try
                    {
                        SetIsWorking(true);
                        var dialog = DisplayUtils.ShowGenericSingleInputAlertDialog(
                            this.Context,
                            Resources.GetString(Resource.String.label_last_name),
                            "Please provide your last name",
                            UserSettings.LastName,
                            Resources.GetString(Resource.String.label_last_name),
                            Android.Text.InputTypes.ClassText,
                            true,
                            true,
                            "Save",
                            async delegate (string value) { 
                                UserSettings.LastName = value?.Trim();
                                await RedrawView();
                            },
                            "Cancel",
                            null
                        );
                    }
                    finally { SetIsWorking(false); }
                };

                //
                // Setting: Permissions
                _usageStatsLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_settings_permissions_usage_stats_layout);
                _usageStatsStateLabel = view.FindViewById<TextView>(Resource.Id.fragment_settings_permissions_usage_stats_state_label);
                _usageStatsLayout.Click += delegate
                {
                    this.Context.StartActivity(new Intent(Android.Provider.Settings.ActionUsageAccessSettings));
                };

                _applicationOverlayLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_settings_permissions_application_overlay_layout);
                _applicationOverlayStateLabel = view.FindViewById<TextView>(Resource.Id.fragment_settings_permissions_application_overlay_state_label);
                _applicationOverlayLayout.Click += delegate
                {
                    this.Context.StartActivity(new Intent(Android.Provider.Settings.ActionManageOverlayPermission));
                };

                //
                // Setting: About
                _versionLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_settings_about_version_layout);
                _versionContentLabel = view.FindViewById<TextView>(Resource.Id.fragment_settings_about_version_content_label);
                _versionLayout.Click += async delegate
                {
                    try
                    {
                        SetIsWorking(true);

                        await Clipboard.SetTextAsync(_versionContentLabel.Text);
                        DisplayUtils.ShowToast(this.Context, "Version copied to clipboard");
                    }
                    finally { SetIsWorking(false); }
                };

                _privacyPolicyLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_settings_about_privacy_policy_layout);
                _privacyPolicyLayout.Click += delegate
                {
                    try
                    {
                        SetIsWorking(true);

                        Intent linkIntent = new Intent(Intent.ActionView);
                        linkIntent.SetData(Android.Net.Uri.Parse(this.Resources.GetString(Resource.String.link_squelch_privacy_policy)));
                        StartActivity(linkIntent);
                    }
                    finally { SetIsWorking(false); }
                };

                _eulaLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_settings_about_eula_layout);
                _eulaLayout.Click += delegate
                {
                    try
                    {
                        SetIsWorking(true);

                        Intent linkIntent = new Intent(Intent.ActionView);
                        linkIntent.SetData(Android.Net.Uri.Parse(this.Resources.GetString(Resource.String.link_squelch_end_user_licensing_agreement)));
                        StartActivity(linkIntent);
                    }
                    finally { SetIsWorking(false); }
                };

                _openSourceLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_settings_about_open_source_layout);
                _openSourceLayout.Click += delegate
                {
                    try
                    {
                        this.ChildFragmentManager.ShowDialogFragment(typeof(OpenSourceDialogFragment));
                    }
                    finally { SetIsWorking(false); }
                };

                //
                // Setup navbar
                ((MainActivity)this.Activity).SetupNavigation(Resource.String.title_settings, true, false);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnCreateView: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            //
            // Return the inflated view
            return view;
        }

        public override async void OnResume()
        {
            base.OnResume();

            FirebaseAnalyticsManager firebaseAnalyticsManager;

            try
            {
                //
                // Redraw the view
                await RedrawView();

                //
                // Set firebase screen
                firebaseAnalyticsManager = FirebaseAnalyticsManager.GetInstance();
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
                ((IIndeterminateProgressReporter)this.Activity).SetProgressBarState(isWorking);
        }

        /// <summary>
        /// Redraws the view
        /// </summary>
        /// <returns></returns>
		private async Task RedrawView()
        {
            //
            // Vars
            string userId = string.Empty;
            string userFirstName = string.Empty;
            string userLastName = string.Empty;
            string usageStatsState = string.Empty;
            string applicationOverlayState = string.Empty;
            string selfVersionName = string.Empty;
            string selfVersionCode = string.Empty;

            //
            // Start working animation
            SetIsWorking(true);

            try
            {
                //
                // Get setting data
                await Task.Factory.StartNew(async () =>
                {
                    userId = UserSettings.Id;
                    userFirstName = UserSettings.FirstName;
                    userLastName = UserSettings.LastName;

                    usageStatsState = (PermissionUtils.GetUsageDataPermission(this.Context, false)) ? "Active" : "Inactive";
                    applicationOverlayState = (PermissionUtils.GetApplicationOverlayPermission(this.Context, false)) ? "Active" : "Inactive";

                    selfVersionName = await GeneralUtils.SelfVersionNameAsync(this.Context);
                    selfVersionCode = (await GeneralUtils.SelfVersionCodeAsync(this.Context)).ToString();
                });

                //
                // Assign view values
                _idContentLabel.Text = (string.IsNullOrWhiteSpace(userId) ? "(undefined)" : userId);
                _firstNameContentLabel.Text = (string.IsNullOrWhiteSpace(userFirstName) ? "(undefined)" : userFirstName);
                _lastNameContentLabel.Text = (string.IsNullOrWhiteSpace(userLastName) ? "(undefined)" : userLastName);

                _usageStatsStateLabel.Text = (string.IsNullOrWhiteSpace(usageStatsState) ? "(undefined)" : usageStatsState);
                _applicationOverlayStateLabel.Text = (string.IsNullOrWhiteSpace(applicationOverlayState) ? "(undefined)" : applicationOverlayState);

                _versionContentLabel.Text = $"Version {selfVersionName} - Build {selfVersionCode}";
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"RedrawView: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
            finally
            {
                //
                // End working animation
                SetIsWorking(false);
            }
        }
        #endregion
    }
}