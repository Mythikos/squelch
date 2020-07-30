using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using Google.Android.Material.Snackbar;
using Squelch.Activities;
using Squelch.Library;
using Squelch.Library.Data;
using Squelch.Library.Interfaces;
using Squelch.Library.Singletons;
using Squelch.Library.Utilities;
using System;
using System.Collections.Generic;
using AndroidX.Core.Widget;
using AndroidX.Core.Content.Resources;
using Android.Support.V4.Content;
using Squelch.Library.Extensions;
using System.Threading.Tasks;

namespace Squelch.Fragments
{
    public class DonationDialogFragment : DialogFragment
    {
        #region Instance Variables
        private static readonly string _tag = typeof(DonationDialogFragment).FullName;

        // Parent view items
        private LinearLayout _rootLayout;
        private RadioButton _preset1RadioButton, _preset2RadioButton, _preset3RadioButton, _otherRadioButton;
        private NestedScrollView _otherPickerView;
        private NumberPicker _otherNumberPicker;
        private Button _negativeButton, _positiveButton;
        #endregion

        #region Native Methods
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.RequireParentFragment();
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view;

            //
            // Inflate the layour
            view = inflater.Inflate(Resource.Layout.dialog_fragment_donation, container, false);

            try
            {
                _rootLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_donation_root_layout);
                _preset1RadioButton = view.FindViewById<RadioButton>(Resource.Id.fragment_donation_button_preset_1);
                _preset2RadioButton = view.FindViewById<RadioButton>(Resource.Id.fragment_donation_button_preset_2);
                _preset3RadioButton = view.FindViewById<RadioButton>(Resource.Id.fragment_donation_button_preset_3);
                _otherRadioButton = view.FindViewById<RadioButton>(Resource.Id.fragment_donation_button_other);
                _otherPickerView = view.FindViewById<NestedScrollView>(Resource.Id.fragment_donation_other_picker_view);
                _otherNumberPicker = view.FindViewById<NumberPicker>(Resource.Id.fragment_donation_other_number_picker);
                _positiveButton = view.FindViewById<Button>(Resource.Id.fragment_donation_positive_button);
                _negativeButton = view.FindViewById<Button>(Resource.Id.fragment_donation_negative_button);

                //
                // Setup events
                _preset1RadioButton.Click += RadioButton_Click;
                _preset2RadioButton.Click += RadioButton_Click;
                _preset3RadioButton.Click += RadioButton_Click;
                _otherRadioButton.Click += RadioButton_Click;

                _positiveButton.Click += async delegate
                {
                    //
                    // Get donation amount
                    int amount = 0;
                    if (_preset1RadioButton.Checked == true)
                        amount = int.Parse(_preset1RadioButton.Text.Replace("$", string.Empty).Replace(" ", string.Empty));
                    else if (_preset2RadioButton.Checked == true)
                        amount = int.Parse(_preset2RadioButton.Text.Replace("$", string.Empty).Replace(" ", string.Empty));
                    else if (_preset3RadioButton.Checked == true)
                        amount = int.Parse(_preset3RadioButton.Text.Replace("$", string.Empty).Replace(" ", string.Empty));
                    else if (_otherRadioButton.Checked == true)
                        amount = _otherNumberPicker.Value;

                    //
                    // Process donation
                    (bool, string) result = await InAppPurchaseUtils.PurchaseAsync($"squelch_donation_{amount.ToString().PadLeft(3, '0')}", true);
                    if (result.Item1 == true)
                    {
                        // Set flag
                        UserSettings.SetFlagValue(UserSettings.FlagKeys.Donation_Status, true.ToString());
                        UserSettings.SetFlagValue(UserSettings.FlagKeys.Donation_StatusUpdatedOn, DateTime.Now.ToString());

                        // Refresh parent and close
                        DisplayUtils.ShowSnackbar(this.ParentFragment.View, "Thank you for your donation!", Snackbar.LengthLong);
                        this.ParentFragment.FragmentManager.RefreshFragment(this.ParentFragment);
                        this.Dismiss();
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(result.Item2) == false)
                        {
                            DisplayUtils.ShowSnackbar(this.ParentFragment.View, result.Item2, Snackbar.LengthLong);
                        }
                        else
                        {
                            DisplayUtils.ShowSnackbar(this.ParentFragment.View, "An unexpected error occurred. Please try again.", Snackbar.LengthLong);
                        }
                    }
                };

                _negativeButton.Click += delegate
                {
                    this.Dismiss();
                };

                //
                // Setup view
                _positiveButton.Visibility = ViewStates.Gone;
                _otherNumberPicker.MinValue = 1;
                _otherNumberPicker.MaxValue = 400;
                _otherNumberPicker.Value = 5;
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnCreateView: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            //
            // Return the inflated view
            return view;
        }

        public override void OnResume()
        {
            base.OnResume();

            FirebaseAnalyticsManager firebaseAnalyticsManager;

            try
            {
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

        #region Control Events
        private void RadioButton_Click(object sender, EventArgs e)
        {
            if (_preset1RadioButton.Checked == true || _preset2RadioButton.Checked == true || _preset3RadioButton.Checked == true)
            {
                _positiveButton.Visibility = ViewStates.Visible;
                _otherPickerView.Visibility = ViewStates.Gone;
                _otherRadioButton.Background = ContextCompat.GetDrawable(this.Context, Resource.Drawable.rounded_corners_ripple);
            }
            else if (_otherRadioButton.Checked == true)
            {
                _positiveButton.Visibility = ViewStates.Visible;
                _otherPickerView.Visibility = ViewStates.Visible;
                _otherRadioButton.Background = ContextCompat.GetDrawable(this.Context, Resource.Drawable.rounded_corners_top);
            }
            else
            {
                _positiveButton.Visibility = ViewStates.Gone;
                _otherPickerView.Visibility = ViewStates.Gone;
                _otherRadioButton.Background = ContextCompat.GetDrawable(this.Context, Resource.Drawable.rounded_corners_ripple);
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
        #endregion
    }
}