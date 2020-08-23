using Android.Opengl;
using Android.OS;
using Android.Text;
using Android.Views;
using Android.Widget;
using AndroidX.Core.Content;
using AndroidX.Fragment.App;
using Squelch.Activities;
using Squelch.Library;
using Squelch.Library.Data;
using Squelch.Library.Entities;
using Squelch.Library.Extensions;
using Squelch.Library.Interfaces;
using Squelch.Library.Utilities;
using System;

namespace Squelch.Fragments
{
    public class FirstTimeSetupFragment : Fragment
    {
        #region Instance Variables
        private static readonly string _tag = typeof(FirstTimeSetupFragment).FullName;

        // Controls
        private LinearLayout _rootLayout;
        private TextView _problemLabel, _dataConsentLabel;
        private Button _dialogPositiveButton;

        // Welcome
        private LinearLayout _welcomeLayout;

        // Usage data
        private LinearLayout _specialPermissionsLayout;
        private LinearLayout _specialPermissionsUsageStatsSettingsLayout;
        private LinearLayout _specialPermissionsApplicationOverlaySettingsLayout;
        private ImageView _specialPermissionsUsageStatsSettingsStatusImage;
        private ImageView _specialPermissionsApplicationOverlaySettingsStatusImage;

        // Name
        private LinearLayout _userNameLayout;
        private EditText _firstNameInput, _lastNameInput;

        private int _stepId;
        private const int STEP_WELCOME = 1, STEP_SPECIAL_PERMISSIONS = 2, STEP_PERSONALIZE = 3;
        #endregion

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view;

            //
            // Inflate the layour
            view = inflater.Inflate(Resource.Layout.fragment_first_time_setup, container, false);

            try
            {
                //
                // Get view elements
                _rootLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_first_time_setup_root_layout);
                _problemLabel = view.FindViewById<TextView>(Resource.Id.fragment_first_time_setup_problem_label);
                _dataConsentLabel = view.FindViewById<TextView>(Resource.Id.fragment_first_time_setup_data_consent_label);
                _dataConsentLabel.TextFormatted = ViewUtils.FormattedTextFromHTML(GetString(Resource.String.consent_statement));
                _dataConsentLabel.MovementMethod = Android.Text.Method.LinkMovementMethod.Instance;

                //
                // Welcome layout
                _welcomeLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_first_time_setup_welcome_layout);

                //
                // Usage data layout
                _specialPermissionsLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_first_time_setup_special_permission_layout);
                _specialPermissionsUsageStatsSettingsLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_first_time_setup_special_permission_usage_data_layout);
                _specialPermissionsApplicationOverlaySettingsLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_first_time_setup_special_permission_application_overlay_layout);
                _specialPermissionsUsageStatsSettingsStatusImage = view.FindViewById<ImageView>(Resource.Id.fragment_first_time_setup_special_permission_usage_data_status_image);
                _specialPermissionsApplicationOverlaySettingsStatusImage = view.FindViewById<ImageView>(Resource.Id.fragment_first_time_setup_special_permission_application_overlay_status_image);
                _specialPermissionsUsageStatsSettingsLayout.Click += delegate { PermissionUtils.GetUsageDataPermission(this.Context, true); UIHandleSpecialPermissions(); };
                _specialPermissionsApplicationOverlaySettingsLayout.Click += delegate { PermissionUtils.GetApplicationOverlayPermission(this.Context, true); UIHandleSpecialPermissions(); };

                //
                // User name layout
                _userNameLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_first_time_setup_personalize_layout);
                _firstNameInput = view.FindViewById<EditText>(Resource.Id.fragment_first_time_setup_personalize_first_name_input);
                _lastNameInput = view.FindViewById<EditText>(Resource.Id.fragment_first_time_setup_personalize_last_name_input);

                _lastNameInput.EditorAction += (s, e) =>
                {
                    e.Handled = false;
                    if (e.ActionId == Android.Views.InputMethods.ImeAction.Done)
                    {
                        _dialogPositiveButton.CallOnClick();
                        e.Handled = true;
                    }
                };

                //
                // Working/Status related
                _dialogPositiveButton = view.FindViewById<Button>(Resource.Id.fragment_first_time_setup_button_positive);
                _dialogPositiveButton.Click += PositiveButton_Click;

                //
                // Make the soft keyboard close when content other than edit text is clicked
                _rootLayout.Touch += (s, e) => { GeneralUtils.HideSoftKeyboard(this.Activity, this.Context); };

                //
                // Set view stuff
                _stepId = 0;
                _problemLabel.Text = string.Empty;
                _dialogPositiveButton.SetText(Resource.String.text_get_started);
                PositiveButton_Click(this, null);

                //
                // Setup toolbar
                ((MainActivity)this.Activity).SetupNavigation(Resource.String.title_first_time_setup, false, false);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnCreateView: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            //
            // Return the view
            return view;
        }

        public override void OnResume()
        {
            base.OnResume();

            try
            {
                if (_stepId == STEP_SPECIAL_PERMISSIONS)
                    UIHandleSpecialPermissions();

                //
                // Set firebase screen
                FirebaseAnalyticsUtils.SetCurrentScreen(this);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnResume: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        #region Control Events
        /// <summary>
        /// Processes the positive button click
        /// </summary>
        /// <param name="dialog"></param>
        /// <param name="which"></param>
        private void PositiveButton_Click(object sender, EventArgs e)
        {
            // Set is working
            SetIsWorking(true);

            try
            {
                // Determine action
                if (_dialogPositiveButton.Text.Equals(GetString(Resource.String.text_finish), StringComparison.OrdinalIgnoreCase))
                {
                    UserSettings.Id = UserItem.CreateNewId();

                    if (!string.IsNullOrWhiteSpace(_firstNameInput.Text) || !string.IsNullOrWhiteSpace(_lastNameInput.Text))
                    {
                        UserSettings.FirstName = _firstNameInput.Text.Trim();
                        UserSettings.LastName = _lastNameInput.Text.Trim();
                    }

                    UserSettings.SetFlagValue(UserSettings.FlagKeys.FirstTimeSetup_IsCompleted, true.ToString());
                    UserSettings.SetFlagValue(UserSettings.FlagKeys.FirstTimeSetup_CompletedOn, DateTime.Now.ToString());

                    // Close soft input
                    GeneralUtils.HideSoftKeyboard(this.Activity, this.Context);

                    // Nav home
                    this.FragmentManager.SetFragment(typeof(HomeFragment), true, true);
                }
                else
                {
                    NextStep();
                }
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
        #endregion

        #region Helper Methods
        /// <summary>
        /// Displays the working progress indicator
        /// </summary>
        /// <param name="bIsWorking"></param>
        private void SetIsWorking(bool isWorking)
        {
            // Report to parent
            if (this.Activity is IIndeterminateProgressReporter)
                ((IIndeterminateProgressReporter)this.Activity).SetProgressBarState(isWorking);
        }

        /// <summary>
        /// Invokes the overlay permission request
        /// </summary>
        /// <param name="showPrompt"></param>
        private void UIHandleSpecialPermissions()
        {
            bool usageDataEnabled = false;
            bool applicationOverlayEnabled = false;
            Android.Graphics.Drawables.Drawable imageViewGood;
            Android.Graphics.Drawables.Drawable imageViewBad;

            try
            {
                if (_stepId == STEP_SPECIAL_PERMISSIONS)
                {
                    usageDataEnabled = PermissionUtils.GetUsageDataPermission(this.Context, false);
                    applicationOverlayEnabled = PermissionUtils.GetApplicationOverlayPermission(this.Context, false);

                    imageViewGood = ContextCompat.GetDrawable(this.Context, Resource.Drawable.ic_check);
                    imageViewGood.SetColorFilter(new Android.Graphics.Color(ContextCompat.GetColor(this.Context, Resource.Color.Green)), Android.Graphics.PorterDuff.Mode.SrcAtop);

                    imageViewBad = ContextCompat.GetDrawable(this.Context, Resource.Drawable.ic_close);
                    imageViewBad.SetColorFilter(new Android.Graphics.Color(ContextCompat.GetColor(this.Context, Resource.Color.DarkRed)), Android.Graphics.PorterDuff.Mode.SrcAtop);

                    _specialPermissionsUsageStatsSettingsLayout.Clickable = !usageDataEnabled;
                    _specialPermissionsUsageStatsSettingsStatusImage.SetImageDrawable((usageDataEnabled == true ? imageViewGood : imageViewBad));

                    _specialPermissionsApplicationOverlaySettingsLayout.Clickable = !applicationOverlayEnabled;
                    _specialPermissionsApplicationOverlaySettingsStatusImage.SetImageDrawable((applicationOverlayEnabled == true ? imageViewGood : imageViewBad));

                    _dialogPositiveButton.Visibility = (usageDataEnabled && applicationOverlayEnabled) ? ViewStates.Visible : ViewStates.Gone;
                }
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"HandleOverlayRequest: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }
        #endregion

        #region Step Methods
        /// <summary>
        /// Helper method to increment to next step
        /// </summary>
        private void NextStep()
        {
            try
            {
                if (ValidateStep(_stepId))
                    ProcessStep(++_stepId);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"NextStep: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
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
                // Handle move
                switch (step)
                {
                    case STEP_WELCOME:
                        _dialogPositiveButton.SetText(Resource.String.text_get_started);
                        _welcomeLayout.Visibility = ViewStates.Visible;
                        _specialPermissionsLayout.Visibility = ViewStates.Gone;
                        _userNameLayout.Visibility = ViewStates.Gone;
                        _dataConsentLabel.Visibility = ViewStates.Gone;
                        _dialogPositiveButton.Visibility = ViewStates.Visible;
                        break;
                    case STEP_SPECIAL_PERMISSIONS:
                        _dialogPositiveButton.SetText(Resource.String.text_next);
                        _welcomeLayout.Visibility = ViewStates.Gone;
                        _specialPermissionsLayout.Visibility = ViewStates.Visible;
                        _userNameLayout.Visibility = ViewStates.Gone;
                        _dataConsentLabel.Visibility = ViewStates.Gone;
                        _dialogPositiveButton.Visibility = ViewStates.Gone;
                        if (PermissionUtils.GetUsageDataPermission(this.Context, false) == true
                            && PermissionUtils.GetApplicationOverlayPermission(this.Context, false) == true)
                            PositiveButton_Click(this, null);
                        else
                            UIHandleSpecialPermissions();
                        break;
                    case STEP_PERSONALIZE:
                        _dialogPositiveButton.SetText(Resource.String.text_finish);
                        _welcomeLayout.Visibility = ViewStates.Gone;
                        _specialPermissionsLayout.Visibility = ViewStates.Gone;
                        _userNameLayout.Visibility = ViewStates.Visible;
                        _dataConsentLabel.Visibility = ViewStates.Visible;
                        _dialogPositiveButton.Visibility = ViewStates.Visible;
                        break;
                    default:
                        _welcomeLayout.Visibility = ViewStates.Gone;
                        _specialPermissionsLayout.Visibility = ViewStates.Gone;
                        _userNameLayout.Visibility = ViewStates.Gone;
                        _dataConsentLabel.Visibility = ViewStates.Gone;
                        _dialogPositiveButton.Visibility = ViewStates.Visible;
                        break;
                }
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
        private bool ValidateStep(int step)
        {
            try
            {
                // Reset
                _problemLabel.Text = string.Empty;

                // Which step are we validating
                switch (step)
                {
                    case STEP_WELCOME:
                        break;
                    case STEP_SPECIAL_PERMISSIONS:
                        break;
                    case STEP_PERSONALIZE:
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