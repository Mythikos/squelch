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
using Squelch.Library.Extensions;
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
        /// <param name="messageTextResourceId"></param>
        /// <param name="length"></param>
        internal static void ShowToast(Context context, int messageTextResourceId, ToastLength length = ToastLength.Short)
        {
            Toast.MakeText(context, messageTextResourceId, length).Show();
        }

        /// <summary>
        /// Shows a snackbar on screen
        /// </summary>
        /// <param name="view"></param>
        /// <param name="messageTextResourceId"></param>
        /// <param name="length"></param>
        /// <param name="actionTextResourceId"></param>
        /// <param name="clickHandler"></param>
        internal static void ShowSnackbar(Android.Views.View view, int messageTextResourceId, int length = Snackbar.LengthShort, int actionTextResourceId = Resource.String.text_ok, Action<Android.Views.View> clickHandler = null)
        {
            Snackbar.Make(view, messageTextResourceId, length).SetAction(view.Context.GetString(actionTextResourceId), clickHandler).Show();
        }

        /// <summary>
        /// Creates and shows an alert dialog
        /// </summary>
        /// <param name="context"></param>
        /// <param name="titleTextResourceId"></param>
        /// <param name="messageTextResourceId"></param>
        /// <param name="cancelable"></param>
        /// <param name="positiveButtonTextResourceId"></param>
        /// <param name="positiveAction"></param>
        /// <param name="negativeButtonTextResourceId"></param>
        /// <param name="negativeAction"></param>
        /// <returns></returns>
        internal static AlertDialog ShowGenericAlertDialog(Context context, int titleTextResourceId, int messageTextResourceId, bool cancelable = true, int? positiveButtonTextResourceId = null, Action positiveAction = null, int? negativeButtonTextResourceId = null, Action negativeAction = null)
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
                titleLabel.Text = context.GetString(titleTextResourceId);

                descriptionLabel = layout.FindViewById<TextView>(Resource.Id.dialog_generic_desciption_label);
                descriptionLabel.Text = context.GetString(messageTextResourceId);

                // Setup the positive button
                if (positiveButtonTextResourceId != null)
                {
                    positiveButton = layout.FindViewById<Button>(Resource.Id.dialog_generic_positive_button);
                    positiveButton.Visibility = ViewStates.Visible;
                    positiveButton.Text = context.GetString(positiveButtonTextResourceId.Value);
                    positiveButton.Click += delegate
                    {
                        positiveAction?.Invoke();
                        if (dialog != null)
                            dialog.Dismiss();
                    };
                }

                // Setup the negative button
                if (negativeButtonTextResourceId != null)
                {
                    negativeButton = layout.FindViewById<Button>(Resource.Id.dialog_generic_negative_button);
                    negativeButton.Visibility = ViewStates.Visible;
                    negativeButton.Text = context.GetString(negativeButtonTextResourceId.Value);
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
        /// <param name="titleTextResourceId"></param>
        /// <param name="messageTextResourceId"></param>
        /// <param name="cancelable"></param>
        /// <param name="positiveButtonTextResourceId"></param>
        /// <param name="positiveAction"></param>
        /// <param name="negativeButtonTextResourceId"></param>
        /// <param name="negativeAction"></param>
        /// <returns></returns>
        internal static AlertDialog ShowGenericSingleInputAlertDialog(Context context, int titleTextResourceId, int messageTextResourceId, string inputValueText = null, int? inputHintTextResourceId = null, InputTypes inputType = InputTypes.ClassText, bool focusInput = true, bool cancelable = true, int? positiveButtonTextResourceId = null, Action<string> positiveAction = null, int? negativeButtonTextResourceId = null, Action<string> negativeAction = null)
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
                titleLabel.Text = context.GetString(titleTextResourceId);

                descriptionLabel = layout.FindViewById<TextView>(Resource.Id.dialog_generic_single_input_desciption_label);
                descriptionLabel.Text = context.GetString(messageTextResourceId);

                // Set input hint
                textInput = layout.FindViewById<TextInputEditText>(Resource.Id.dialog_generic_single_input_text_input);
                textInput.Hint = inputHintTextResourceId == null ? context.GetString(inputHintTextResourceId.Value) : string.Empty;
                textInput.Text = inputValueText ?? string.Empty;
                textInput.InputType = inputType;

                // Setup the positive button
                if (positiveButtonTextResourceId != null)
                {
                    positiveButton = layout.FindViewById<Button>(Resource.Id.dialog_generic_single_input_positive_button);
                    positiveButton.Visibility = ViewStates.Visible;
                    positiveButton.Text = context.GetString(positiveButtonTextResourceId.Value);
                    positiveButton.Click += delegate
                    {
                        positiveAction?.Invoke(textInput.Text);
                        if (dialog != null)
                            dialog.Dismiss();
                    };
                }

                // Setup the negative button
                if (negativeButtonTextResourceId != null)
                {
                    negativeButton = layout.FindViewById<Button>(Resource.Id.dialog_generic_single_input_negative_button);
                    negativeButton.Visibility = ViewStates.Visible;
                    negativeButton.Text = context.GetString(negativeButtonTextResourceId.Value);
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
            string difficultyText, statusText, resultText;

            //
            // Create dialog builder instance
            using (AlertDialog.Builder builder = new AlertDialog.Builder(context))
            {
                // Inflate layout
                layoutInflater = (LayoutInflater)context.GetSystemService(Context.LayoutInflaterService);
                layout = layoutInflater.Inflate(Resource.Layout.dialog_blackout_details, null);

                // Set title and message
                startDateLabel = layout.FindViewById<TextView>(Resource.Id.dialog_blackout_details_data_layout_start_date_label);
                startDateLabel.Text = $"{blackoutItem.ScheduledStartDateTime.FormatDate()} @ {blackoutItem.ScheduledStartDateTime.FormatTime()}";

                endDateLabel = layout.FindViewById<TextView>(Resource.Id.dialog_blackout_details_data_layout_end_date_label);
                endDateLabel.Text = $"{blackoutItem.ScheduledEndDateTime.FormatDate()} @ {blackoutItem.ScheduledEndDateTime.FormatTime()}";

                bidLabel = layout.FindViewById<TextView>(Resource.Id.dialog_blackout_details_data_layout_bid_label);
                bidLabel.Text = $"${blackoutItem.Bid}";

                difficultyLabel = layout.FindViewById<TextView>(Resource.Id.dialog_blackout_details_data_layout_difficulty_label);
                difficultyText = context.GetString(Resource.String.text_unknown);
                switch (blackoutItem.DifficultyCode)
                {
                    case BlackoutItem.BlackoutDifficultyCode.Novice:
                        difficultyText = context.GetString(Resource.String.text_novice);
                        break;
                    case BlackoutItem.BlackoutDifficultyCode.Veteran:
                        difficultyText = context.GetString(Resource.String.text_veteran);
                        break;
                    case BlackoutItem.BlackoutDifficultyCode.Master:
                        difficultyText = context.GetString(Resource.String.text_master);
                        break;
                    case BlackoutItem.BlackoutDifficultyCode.Nightmare:
                        difficultyText = context.GetString(Resource.String.text_nightmare);
                        break;
                    default:
                        difficultyText = context.GetString(Resource.String.text_unknown);
                        break;
                }
                difficultyLabel.Text = difficultyText;

                statusLabel = layout.FindViewById<TextView>(Resource.Id.dialog_blackout_details_data_layout_status_label);
                statusText = context.GetString(Resource.String.text_unknown);
                switch(blackoutItem.StatusCode)
                {
                    case BlackoutItem.BlackoutStatusCode.Active:
                        statusText = context.GetString(Resource.String.text_active);
                        break;
                    case BlackoutItem.BlackoutStatusCode.Finished:
                        statusText = context.GetString(Resource.String.text_finished);
                        break;
                    case BlackoutItem.BlackoutStatusCode.Pending:
                        statusText = context.GetString(Resource.String.text_pending);
                        break;
                }
                statusLabel.Text = statusText;

                resultLabel = layout.FindViewById<TextView>(Resource.Id.dialog_blackout_details_data_layout_result_label);
                resultText = context.GetString(Resource.String.text_unknown);
                switch(blackoutItem.ResultCode)
                {
                    case BlackoutItem.BlackoutResultCode.Cancelled:
                        resultText = context.GetString(Resource.String.text_cancelled);
                        break;
                    case BlackoutItem.BlackoutResultCode.Failed:
                        resultText = context.GetString(Resource.String.text_failed);
                        break;
                    case BlackoutItem.BlackoutResultCode.Pending:
                        resultText = context.GetString(Resource.String.text_pending);
                        break;
                    case BlackoutItem.BlackoutResultCode.Skipped:
                        resultText = context.GetString(Resource.String.text_skipped);
                        break;
                    case BlackoutItem.BlackoutResultCode.Success:
                        resultText = context.GetString(Resource.String.text_success);
                        break;
                }
                resultLabel.Text = resultText;

                blacklistLabel = layout.FindViewById<TextView>(Resource.Id.dialog_blackout_details_data_layout_blacklist_label);
                blacklistLabel.Text = $"{string.Join(", ", context.PackageManager.GetInstalledApplications(PackageInfoFlags.MatchAll).ToList().Where(x => blackoutItem.Blacklist.Contains(x.PackageName)).Select(x => x.LoadLabel(context.PackageManager)).ToList())}";

                // Setup the positive button
                positiveButton = layout.FindViewById<Button>(Resource.Id.dialog_blackout_details_positive_button);
                positiveButton.Visibility = ViewStates.Visible;
                positiveButton.SetText(Resource.String.text_ok);
                positiveButton.Click += delegate
                {
                    if (dialog != null)
                        dialog.Dismiss();
                };

                // Setup the negative button
                negativeButton = layout.FindViewById<Button>(Resource.Id.dialog_blackout_details_negative_button);
                if (blackoutItem.ScheduledStartDateTime >= DateTime.Now.AddMinutes(1))
                {
                    negativeButton.Visibility = ViewStates.Visible;
                    negativeButton.SetText(Resource.String.text_cancel);
                    negativeButton.Click += delegate
                    {
                        DisplayUtils.ShowGenericAlertDialog(context, Resource.String.text_confirm, Resource.String.text_are_you_sure_cancel, true,
                            Resource.String.text_yes, async delegate
                            {
                                if (blackoutItem.ScheduledStartDateTime <= DateTime.Now || blackoutItem.IsBlackoutCancelled())
                                {
                                    DisplayUtils.ShowToast(context, Resource.String.error_unable_to_perform_this_action, ToastLength.Long);
                                }
                                else
                                {
                                    blackoutItem.SetBlackoutFinished(BlackoutItem.BlackoutResultCode.Cancelled);
                                    await BlackoutDatabase.UpsertAsync(blackoutItem);

                                    // Report the cancellation event
                                    FirebaseAnalyticsUtils.SendBlackoutEvent(FirebaseAnalyticsUtils.EVENT_BLACKOUT_CANCELLED, blackoutItem);
                                }

                                if (dialog != null)
                                    dialog.Dismiss();
                            },
                            Resource.String.text_no
                        );
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