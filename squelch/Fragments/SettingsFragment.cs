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
using Squelch.Library.Utilities;
using System;
using System.Collections.Generic;
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
        private LinearLayout _idLayout, _firstNameLayout, _lastNameLayout, _timeFormatLayout;
        private TextView _idContentLabel, _firstNameContentLabel, _lastNameContentLabel, _timeFormatContentLabel;

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
                this._rootLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_settings_root_layout);

                //
                // Setting: User
                this._idLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_settings_user_id_layout);
                this._idContentLabel = view.FindViewById<TextView>(Resource.Id.fragment_settings_user_id_content_label);
                this._idLayout.Click += async delegate
                {
                    try
                    {
                        this.SetIsWorking(true);

                        await Clipboard.SetTextAsync(this._versionContentLabel.Text);
                        DisplayUtils.ShowToast(this.Context, Resource.String.fragment_settings_toast_id_copied);
                    }
                    finally { this.SetIsWorking(false); }
                };

                this._firstNameLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_settings_user_first_name_layout);
                this._firstNameContentLabel = view.FindViewById<TextView>(Resource.Id.fragment_settings_user_first_name_content_label);
                this._firstNameLayout.Click += delegate
                {
                    try
                    {
                        this.SetIsWorking(true);
                        DisplayUtils.ShowGenericSingleInputAlertDialog(
                            this.Context,
                            Resource.String.text_first_name,
                            Resource.String.fragment_settings_prompt_first_name,
                            UserSettings.FirstName,
                            Resource.String.text_first_name,
                            Android.Text.InputTypes.ClassText,
                            true,
                            true,
                            Resource.String.text_save,
                            async delegate (string value)
                            {
                                UserSettings.FirstName = value?.Trim();
                                await this.RedrawView();
                            },
                            Resource.String.text_cancel,
                            null
                        );
                    }
                    finally { this.SetIsWorking(false); }
                };

                this._lastNameLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_settings_user_last_name_layout);
                this._lastNameContentLabel = view.FindViewById<TextView>(Resource.Id.fragment_settings_user_last_name_content_label);
                this._lastNameLayout.Click += delegate
                {
                    try
                    {
                        this.SetIsWorking(true);
                        Android.App.AlertDialog dialog = DisplayUtils.ShowGenericSingleInputAlertDialog(
                            this.Context,
                            Resource.String.text_last_name,
                            Resource.String.fragment_settings_prompt_last_name,
                            UserSettings.LastName,
                            Resource.String.text_last_name,
                            Android.Text.InputTypes.ClassText,
                            true,
                            true,
                            Resource.String.text_save,
                            async delegate (string value)
                            {
                                UserSettings.LastName = value?.Trim();
                                await this.RedrawView();
                            },
                            Resource.String.text_cancel,
                            null
                        );
                    }
                    finally { this.SetIsWorking(false); }
                };

                this._timeFormatLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_settings_user_time_format_layout);
                this._timeFormatContentLabel = view.FindViewById<TextView>(Resource.Id.fragment_settings_user_time_format_content_label);
                this._timeFormatLayout.Click += delegate
                {
                    try
                    {
                        this.SetIsWorking(true);
                        Android.App.AlertDialog dialog = DisplayUtils.ShowGenericSingleComboAlertDialog(
                            this.Context,
                            Resource.String.text_time_format,
                            Resource.String.fragment_settings_prompt_time_format,
                            new List<int>() { Resource.String.fragment_settings_user_time_format_twelve_hour, Resource.String.fragment_settings_user_time_format_twenty_four_hour },
                            UserSettings.FormatTimeAsTwelveHour ? Resource.String.fragment_settings_user_time_format_twelve_hour : Resource.String.fragment_settings_user_time_format_twenty_four_hour,
                            Android.Text.InputTypes.ClassText,
                            true,
                            true,
                            Resource.String.text_save,
                            async delegate (string value)
                            {
                                UserSettings.FormatTimeAsTwelveHour = value.Equals(this.GetString(Resource.String.fragment_settings_user_time_format_twelve_hour));
                                await this.RedrawView();
                            },
                            Resource.String.text_cancel,
                            null
                        );
                    }
                    finally { this.SetIsWorking(false); }
                };

                //
                // Setting: Permissions
                this._usageStatsLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_settings_permissions_usage_stats_layout);
                this._usageStatsStateLabel = view.FindViewById<TextView>(Resource.Id.fragment_settings_permissions_usage_stats_state_label);
                this._usageStatsLayout.Click += delegate
                {
                    this.Context.StartActivity(new Intent(Android.Provider.Settings.ActionUsageAccessSettings));
                };

                this._applicationOverlayLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_settings_permissions_application_overlay_layout);
                this._applicationOverlayStateLabel = view.FindViewById<TextView>(Resource.Id.fragment_settings_permissions_application_overlay_state_label);
                this._applicationOverlayLayout.Click += delegate
                {
                    this.Context.StartActivity(new Intent(Android.Provider.Settings.ActionManageOverlayPermission));
                };

                //
                // Setting: About
                this._versionLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_settings_about_version_layout);
                this._versionContentLabel = view.FindViewById<TextView>(Resource.Id.fragment_settings_about_version_content_label);
                this._versionLayout.Click += async delegate
                {
                    try
                    {
                        this.SetIsWorking(true);

                        await Clipboard.SetTextAsync(this._versionContentLabel.Text);
                        DisplayUtils.ShowToast(this.Context, Resource.String.fragment_settings_toast_version_copied);
                    }
                    finally { this.SetIsWorking(false); }
                };

                this._privacyPolicyLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_settings_about_privacy_policy_layout);
                this._privacyPolicyLayout.Click += delegate
                {
                    try
                    {
                        this.SetIsWorking(true);

                        Intent linkIntent = new Intent(Intent.ActionView);
                        linkIntent.SetData(Android.Net.Uri.Parse(this.Resources.GetString(Resource.String.link_squelch_privacy_policy)));
                        this.StartActivity(linkIntent);
                    }
                    finally { this.SetIsWorking(false); }
                };

                this._eulaLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_settings_about_eula_layout);
                this._eulaLayout.Click += delegate
                {
                    try
                    {
                        this.SetIsWorking(true);

                        Intent linkIntent = new Intent(Intent.ActionView);
                        linkIntent.SetData(Android.Net.Uri.Parse(this.Resources.GetString(Resource.String.link_squelch_end_user_licensing_agreement)));
                        this.StartActivity(linkIntent);
                    }
                    finally { this.SetIsWorking(false); }
                };

                this._openSourceLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_settings_about_open_source_layout);
                this._openSourceLayout.Click += delegate
                {
                    try
                    {
                        this.ChildFragmentManager.ShowDialogFragment(typeof(OpenSourceDialogFragment));
                    }
                    finally { this.SetIsWorking(false); }
                };

                //
                // Setup navbar
                ((MainActivity)this.Activity).SetupNavigation(Resource.String.text_settings, true, false);
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

            try
            {
                //
                // Redraw the view
                await this.RedrawView();

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
            bool userFormatTimeAsMilitary = false;
            string usageStatsState = string.Empty;
            string applicationOverlayState = string.Empty;
            string selfVersionName = string.Empty;
            string selfVersionCode = string.Empty;

            //
            // Start working animation
            this.SetIsWorking(true);

            try
            {
                //
                // Get setting data
                await Task.Factory.StartNew(async () =>
                {
                    userId = UserSettings.Id;
                    userFirstName = UserSettings.FirstName;
                    userLastName = UserSettings.LastName;
                    userFormatTimeAsMilitary = UserSettings.FormatTimeAsTwelveHour;

                    usageStatsState = (PermissionUtils.GetUsageDataPermission(this.Context, false)) ? this.GetString(Resource.String.text_active) : this.GetString(Resource.String.text_inactive);
                    applicationOverlayState = (PermissionUtils.GetApplicationOverlayPermission(this.Context, false)) ? this.GetString(Resource.String.text_active) : this.GetString(Resource.String.text_inactive);

                    selfVersionName = await GeneralUtils.SelfVersionNameAsync(this.Context);
                    selfVersionCode = (await GeneralUtils.SelfVersionCodeAsync(this.Context)).ToString();
                });

                //
                // Assign view values
                this._idContentLabel.Text = (string.IsNullOrWhiteSpace(userId) ? this.GetString(Resource.String.text_undefined_input) : userId);
                this._firstNameContentLabel.Text = (string.IsNullOrWhiteSpace(userFirstName) ? this.GetString(Resource.String.text_undefined_input) : userFirstName);
                this._lastNameContentLabel.Text = (string.IsNullOrWhiteSpace(userLastName) ? this.GetString(Resource.String.text_undefined_input) : userLastName);
                this._timeFormatContentLabel.Text = (userFormatTimeAsMilitary) ? this.GetString(Resource.String.fragment_settings_user_time_format_twelve_hour) : this.GetString(Resource.String.fragment_settings_user_time_format_twenty_four_hour);

                this._usageStatsStateLabel.Text = (string.IsNullOrWhiteSpace(usageStatsState) ? this.GetString(Resource.String.text_undefined_input) : usageStatsState);
                this._applicationOverlayStateLabel.Text = (string.IsNullOrWhiteSpace(applicationOverlayState) ? this.GetString(Resource.String.text_undefined_input) : applicationOverlayState);

                this._versionContentLabel.Text = string.Format(this.GetString(Resource.String.fragment_settings_version_and_build), selfVersionName, selfVersionCode);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"RedrawView: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
            finally
            {
                //
                // End working animation
                this.SetIsWorking(false);
            }
        }
        #endregion
    }
}