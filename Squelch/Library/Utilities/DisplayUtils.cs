using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Text;
using Android.Views;
using Android.Widget;
using Google.Android.Material.Snackbar;
using Google.Android.Material.TextField;
using Squelch.Library.Data;
using Squelch.Library.Entities;
using Squelch.Library.Singletons;
using System;
using System.Linq;

namespace Squelch.Library.Utilities
{
    internal static class DisplayUtils
    {
        /// <summary>
        /// Shows a toast notification
        /// </summary>
        /// <param name="context"></param>
        /// <param name="message"></param>
        /// <param name="length"></param>
        internal static void ShowToast(Context context, string message, ToastLength length = ToastLength.Short)
        {
            Toast.MakeText(context, message, length).Show();
        }

        /// <summary>
        /// Shows a snackbar on screen
        /// </summary>
        /// <param name="view"></param>
        /// <param name="message"></param>
        /// <param name="length"></param>
        /// <param name="actionText"></param>
        /// <param name="clickHandler"></param>
        internal static void ShowSnackbar(Android.Views.View view, string message, int length = Snackbar.LengthShort, string actionText = "OK", Action<Android.Views.View> clickHandler = null)
        {
            Snackbar.Make(view, message, length).SetAction(actionText, clickHandler).Show();
        }

        /// <summary>
        /// Creates and shows an alert dialog
        /// </summary>
        /// <param name="context"></param>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="cancelable"></param>
        /// <param name="positiveButtonText"></param>
        /// <param name="positiveAction"></param>
        /// <param name="negativeButtonText"></param>
        /// <param name="negativeAction"></param>
        /// <returns></returns>
        internal static AlertDialog ShowGenericAlertDialog(Context context, string title, string message, bool cancelable = true, string positiveButtonText = null, Action positiveAction = null, string negativeButtonText = null, Action negativeAction = null)
        {
            AlertDialog dialog = null;
            View layout;
            LayoutInflater layoutInflater;
            TextView titleLabel, descriptionLabel;
            Button positiveButton, negativeButton;

            //
            // Create dialog builder instance
            using (AlertDialog.Builder builder = new AlertDialog.Builder(context))
            {
                // Inflate layout
                layoutInflater = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
                layout = layoutInflater.Inflate(Resource.Layout.dialog_generic, null);

                // Set title and message
                titleLabel = layout.FindViewById<TextView>(Resource.Id.dialog_generic_title_label);
                titleLabel.Text = title;

                descriptionLabel = layout.FindViewById<TextView>(Resource.Id.dialog_generic_desciption_label);
                descriptionLabel.Text = message;

                // Setup the positive button
                if (string.IsNullOrWhiteSpace(positiveButtonText) == false)
                {
                    positiveButton = layout.FindViewById<Button>(Resource.Id.dialog_generic_positive_button);
                    positiveButton.Visibility = ViewStates.Visible;
                    positiveButton.Text = positiveButtonText;
                    positiveButton.Click += delegate
                    {
                        positiveAction?.Invoke();
                        if (dialog != null)
                            dialog.Dismiss();
                    };
                }

                // Setup the negative button
                if (string.IsNullOrWhiteSpace(negativeButtonText) == false)
                {
                    negativeButton = layout.FindViewById<Button>(Resource.Id.dialog_generic_negative_button);
                    negativeButton.Visibility = ViewStates.Visible;
                    negativeButton.Text = negativeButtonText;
                    negativeButton.Click += delegate
                    {
                        negativeAction?.Invoke();
                        if (dialog != null)
                            dialog.Dismiss();
                    };
                }

                // Set the view
                builder.SetView(layout);

                // Set if the dialog can be cancelled without the negative button
                builder.SetCancelable(cancelable);

                //
                // Create and show the dialog
                dialog = builder.Create();
                dialog.Show();
            }

            // Return this dialog
            return dialog;
        }

        /// <summary>
        /// Creates and shows an alert dialog
        /// </summary>
        /// <param name="context"></param>
        /// <param name="title"></param>
        /// <param name="message"></param>
        /// <param name="cancelable"></param>
        /// <param name="positiveButtonText"></param>
        /// <param name="positiveAction"></param>
        /// <param name="negativeButtonText"></param>
        /// <param name="negativeAction"></param>
        /// <returns></returns>
        internal static AlertDialog ShowGenericSingleInputAlertDialog(Context context, string title, string message, string inputValue = null, string inputHint = null, InputTypes inputType = InputTypes.ClassText, bool focusInput = true, bool cancelable = true, string positiveButtonText = null, Action<string> positiveAction = null, string negativeButtonText = null, Action<string> negativeAction = null)
        {
            AlertDialog dialog = null;
            View layout;
            LayoutInflater layoutInflater;
            TextView titleLabel, descriptionLabel;
            Button positiveButton, negativeButton;
            TextInputEditText textInput;

            //
            // Create dialog builder instance
            using (AlertDialog.Builder builder = new AlertDialog.Builder(context))
            {
                // Inflate layout
                layoutInflater = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
                layout = layoutInflater.Inflate(Resource.Layout.dialog_generic_single_input, null);

                // Set title and message
                titleLabel = layout.FindViewById<TextView>(Resource.Id.dialog_generic_single_input_title_label);
                titleLabel.Text = title;

                descriptionLabel = layout.FindViewById<TextView>(Resource.Id.dialog_generic_single_input_desciption_label);
                descriptionLabel.Text = message;

                // Set input hint
                textInput = layout.FindViewById<TextInputEditText>(Resource.Id.dialog_generic_single_input_text_input);
                textInput.Hint = inputHint ?? string.Empty;
                textInput.Text = inputValue ?? string.Empty;
                textInput.InputType = inputType;

                // Setup the positive button
                if (string.IsNullOrWhiteSpace(positiveButtonText) == false)
                {
                    positiveButton = layout.FindViewById<Button>(Resource.Id.dialog_generic_single_input_positive_button);
                    positiveButton.Visibility = ViewStates.Visible;
                    positiveButton.Text = positiveButtonText;
                    positiveButton.Click += delegate
                    {
                        positiveAction?.Invoke(textInput.Text);
                        if (dialog != null)
                            dialog.Dismiss();
                    };
                }

                // Setup the negative button
                if (string.IsNullOrWhiteSpace(negativeButtonText) == false)
                {
                    negativeButton = layout.FindViewById<Button>(Resource.Id.dialog_generic_single_input_negative_button);
                    negativeButton.Visibility = ViewStates.Visible;
                    negativeButton.Text = negativeButtonText;
                    negativeButton.Click += delegate
                    {
                        negativeAction?.Invoke(textInput.Text);
                        if (dialog != null)
                            dialog.Dismiss();
                    };
                }

                // Set the view
                builder.SetView(layout);

                // Set if the dialog can be cancelled without the negative button
                builder.SetCancelable(cancelable);

                //
                // Create and show the dialog
                dialog = builder.Create();
                if (focusInput)
                    dialog.Window.SetSoftInputMode(SoftInput.StateVisible);
                dialog.Show();

                //
                // Handle focus
                if (focusInput)
                    textInput.RequestFocus();
            }

            // Return this dialog
            return dialog;
        }

        /// <summary>
        /// Creates and shows an alert dialog that shows blackout information
        /// </summary>
        /// <param name="context"></param>
        /// <param name="blackoutItem"></param>
        /// <param name="cancelable"></param>
        /// <returns></returns>
        internal static AlertDialog ShowBlackoutDetailsAlertDialog(Context context, BlackoutItem blackoutItem, bool cancelable = true)
        {
            AlertDialog dialog = null;
            View layout;
            LayoutInflater layoutInflater;
            TextView startDateLabel, endDateLabel, bidLabel, difficultyLabel, statusLabel, resultLabel, blacklistLabel;
            Button positiveButton, negativeButton;

            //
            // Create dialog builder instance
            using (AlertDialog.Builder builder = new AlertDialog.Builder(context))
            {
                // Inflate layout
                layoutInflater = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
                layout = layoutInflater.Inflate(Resource.Layout.dialog_blackout_details, null);

                // Set title and message
                startDateLabel = layout.FindViewById<TextView>(Resource.Id.dialog_blackout_details_data_layout_start_date_label);
                startDateLabel.Text = $"{blackoutItem.StartDateTime}";

                endDateLabel = layout.FindViewById<TextView>(Resource.Id.dialog_blackout_details_data_layout_end_date_label);
                endDateLabel.Text = $"{blackoutItem.EndDateTime}";

                bidLabel = layout.FindViewById<TextView>(Resource.Id.dialog_blackout_details_data_layout_bid_label);
                bidLabel.Text = $"${blackoutItem.Bid}";

                difficultyLabel = layout.FindViewById<TextView>(Resource.Id.dialog_blackout_details_data_layout_difficulty_label);
                difficultyLabel.Text = $"{blackoutItem.DifficultyCode}";

                statusLabel = layout.FindViewById<TextView>(Resource.Id.dialog_blackout_details_data_layout_status_label);
                statusLabel.Text = $"{blackoutItem.StatusCode}";

                resultLabel = layout.FindViewById<TextView>(Resource.Id.dialog_blackout_details_data_layout_result_label);
                resultLabel.Text = $"{blackoutItem.ResultCode}";

                blacklistLabel = layout.FindViewById<TextView>(Resource.Id.dialog_blackout_details_data_layout_blacklist_label);
                blacklistLabel.Text = $"{string.Join(", ", context.PackageManager.GetInstalledApplications(PackageInfoFlags.MatchAll).ToList().Where(x => blackoutItem.Blacklist.Contains(x.PackageName)).Select(x => x.LoadLabel(context.PackageManager)).ToList())}";

                // Setup the positive button
                positiveButton = layout.FindViewById<Button>(Resource.Id.dialog_blackout_details_positive_button);
                positiveButton.Visibility = ViewStates.Visible;
                positiveButton.SetText(Resource.String.action_ok);
                positiveButton.Click += delegate
                {
                    if (dialog != null)
                        dialog.Dismiss();
                };

                // Setup the negative button
                negativeButton = layout.FindViewById<Button>(Resource.Id.dialog_blackout_details_negative_button);
                if (blackoutItem.StartDateTime >= DateTime.Now.AddMinutes(1))
                {
                    negativeButton.Visibility = ViewStates.Visible;
                    negativeButton.SetText(Resource.String.action_cancel);
                    negativeButton.Click += async delegate
                    {
                        // You cant cancel the blackout if it has already started ;)
                        if (blackoutItem.StartDateTime <= DateTime.Now || blackoutItem.IsBlackoutCancelled())
                        {
                            DisplayUtils.ShowToast(context, "Unable to cancel the blackout at this time.", ToastLength.Long);
                        }
                        else
                        {
                            blackoutItem.SetBlackoutFinished(BlackoutItem.BlackoutResultCode.Cancelled);
                            await BlackoutDatabase.UpsertAsync(blackoutItem);

                            // Report the cancellation event
                            var firebaseAnalyticsManager = FirebaseAnalyticsManager.GetInstance();
                            firebaseAnalyticsManager.SendBlackoutEvent(FirebaseAnalyticsManager.EVENT_BLACKOUT_CANCELLED, blackoutItem);
                        }

                        if (dialog != null)
                            dialog.Dismiss();
                    };
                }

                // Set the view
                builder.SetView(layout);

                // Set if the dialog can be cancelled without the negative button
                builder.SetCancelable(cancelable);

                //
                // Create and show the dialog
                dialog = builder.Create();
                dialog.Show();
            }

            // Return this dialog
            return dialog;
        }
    }
}