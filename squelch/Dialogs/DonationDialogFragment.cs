using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Core.Content;
using AndroidX.Core.Widget;
using AndroidX.Fragment.App;
using Google.Android.Material.Snackbar;
using Squelch.Library;
using Squelch.Library.Data;
using Squelch.Library.Extensions;
using Squelch.Library.Interfaces;
using Squelch.Library.Utilities;
using System;

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
                this._rootLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_donation_root_layout);
                this._preset1RadioButton = view.FindViewById<RadioButton>(Resource.Id.fragment_donation_button_preset_1);
                this._preset2RadioButton = view.FindViewById<RadioButton>(Resource.Id.fragment_donation_button_preset_2);
                this._preset3RadioButton = view.FindViewById<RadioButton>(Resource.Id.fragment_donation_button_preset_3);
                this._otherRadioButton = view.FindViewById<RadioButton>(Resource.Id.fragment_donation_button_other);
                this._otherPickerView = view.FindViewById<NestedScrollView>(Resource.Id.fragment_donation_other_picker_view);
                this._otherNumberPicker = view.FindViewById<NumberPicker>(Resource.Id.fragment_donation_other_number_picker);
                this._positiveButton = view.FindViewById<Button>(Resource.Id.fragment_donation_positive_button);
                this._negativeButton = view.FindViewById<Button>(Resource.Id.fragment_donation_negative_button);

                //
                // Setup events
                this._preset1RadioButton.Click += this.RadioButton_Click;
                this._preset2RadioButton.Click += this.RadioButton_Click;
                this._preset3RadioButton.Click += this.RadioButton_Click;
                this._otherRadioButton.Click += this.RadioButton_Click;

                this._positiveButton.Click += async delegate
                {
                    //
                    // Get donation amount
                    int amount = 0;
                    if (this._preset1RadioButton.Checked == true)
                    {
                        amount = int.Parse(this._preset1RadioButton.Text.Replace("$", string.Empty).Replace(" ", string.Empty));
                    }
                    else if (this._preset2RadioButton.Checked == true)
                    {
                        amount = int.Parse(this._preset2RadioButton.Text.Replace("$", string.Empty).Replace(" ", string.Empty));
                    }
                    else if (this._preset3RadioButton.Checked == true)
                    {
                        amount = int.Parse(this._preset3RadioButton.Text.Replace("$", string.Empty).Replace(" ", string.Empty));
                    }
                    else if (this._otherRadioButton.Checked == true)
                    {
                        amount = this._otherNumberPicker.Value;
                    }

                    //
                    // Process donation
                    InAppPurchaseUtils.PurchaseResult result = await InAppPurchaseUtils.PurchaseAsync($"donation_{amount.ToString().PadLeft(3, '0')}", true);
                    if (result.Successful == true)
                    {
                        // Set flag
                        UserSettings.SetFlagValue(UserSettings.FlagKeys.Donation_Status, true.ToString());
                        UserSettings.SetFlagValue(UserSettings.FlagKeys.Donation_StatusUpdatedOn, DateTime.Now.ToString());

                        // Refresh parent and close
                        DisplayUtils.ShowSnackbar(this.ParentFragment.View, Resource.String.fragment_donation_thank_you, Snackbar.LengthLong);
                        this.ParentFragment.FragmentManager.RefreshFragment(this.ParentFragment);
                        this.Dismiss();
                    }
                    else
                    {
                        if (string.IsNullOrWhiteSpace(this.GetString(result.MessageResourceId)) == false)
                        {
                            DisplayUtils.ShowSnackbar(this.ParentFragment.View, result.MessageResourceId, Snackbar.LengthLong);
                        }
                        else
                        {
                            DisplayUtils.ShowSnackbar(this.ParentFragment.View, Resource.String.error_unexpected_error_occured, Snackbar.LengthLong);
                        }
                    }
                };

                this._negativeButton.Click += delegate
                {
                    this.Dismiss();
                };

                //
                // Setup view
                this._positiveButton.Visibility = ViewStates.Gone;
                this._otherNumberPicker.MinValue = 1;
                this._otherNumberPicker.MaxValue = 250;
                this._otherNumberPicker.Value = 5;
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

            try
            {
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

        #region Control Events
        private void RadioButton_Click(object sender, EventArgs e)
        {
            if (this._preset1RadioButton.Checked == true || this._preset2RadioButton.Checked == true || this._preset3RadioButton.Checked == true)
            {
                this._positiveButton.Visibility = ViewStates.Visible;
                this._otherPickerView.Visibility = ViewStates.Gone;
                this._otherRadioButton.Background = ContextCompat.GetDrawable(this.Context, Resource.Drawable.rounded_corners_ripple);
            }
            else if (this._otherRadioButton.Checked == true)
            {
                this._positiveButton.Visibility = ViewStates.Visible;
                this._otherPickerView.Visibility = ViewStates.Visible;
                this._otherRadioButton.Background = ContextCompat.GetDrawable(this.Context, Resource.Drawable.rounded_corners_top);
            }
            else
            {
                this._positiveButton.Visibility = ViewStates.Gone;
                this._otherPickerView.Visibility = ViewStates.Gone;
                this._otherRadioButton.Background = ContextCompat.GetDrawable(this.Context, Resource.Drawable.rounded_corners_ripple);
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
        #endregion
    }
}