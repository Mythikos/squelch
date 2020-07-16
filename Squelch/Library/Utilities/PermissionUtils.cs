using Android.App;
using Android.Content;
using Android.OS;
using System;

namespace Squelch.Library.Utilities
{
    internal static class PermissionUtils
    {
        #region Instance Variables
        private static readonly string s_tag = typeof(PermissionUtils).FullName;
        #endregion

        /// <summary>
        /// Checks if the process has usage data permissions. Will also show a prompt to enable it, if showPrompt == true
        /// </summary>
        /// <param name="context"></param>
        /// <param name="showDialog"></param>
        /// <param name="onDialogShown"></param>
        /// <returns></returns>
        internal static bool GetUsageDataPermission(Context context, bool showDialog = false, Action<AlertDialog> onDialogShown = null)
        {
            AppOpsManager opsManager;
            AppOpsManagerMode mode;
            AlertDialog dialog;

            // Check usage stats permissions
            opsManager = (AppOpsManager)context.GetSystemService(Context.AppOpsService);
            mode = opsManager.CheckOpNoThrow(AppOpsManager.OpstrGetUsageStats, Android.OS.Process.MyUid(), context.PackageName);

            // Prompt if we need too
            if (mode != AppOpsManagerMode.Allowed)
            {
                if (showDialog)
                {
                    using (AlertDialog.Builder builder = new AlertDialog.Builder(context))
                    {
                        builder.SetMessage($"Squelch needs the ability to monitor usage stats of your device.{System.Environment.NewLine}{System.Environment.NewLine}Press OK and we will take you to the setting, otherwise press Cancel.");
                        builder.SetPositiveButton("Ok", delegate (object sender, DialogClickEventArgs args)
                        {
                            context.StartActivity(new Intent(Android.Provider.Settings.ActionUsageAccessSettings));
                        });
                        builder.SetNegativeButton("Cancel", delegate (object sender, DialogClickEventArgs args)
                        {
                            if (sender != null && sender is Dialog)
                                ((Dialog)sender).Dismiss();
                        });

                        dialog = builder.Create();
                        dialog.Show();

                        // Callback to onshow
                        onDialogShown?.Invoke(dialog);
                    }
                }

                return false;
            }

            return true;
        }

        /// <summary>
        /// Checks if the process has system alert permission. Will also show a prompt to enable it, if showPrompt == true
        /// </summary>
        /// <param name="context"></param>
        /// <param name="showDialog"></param>
        /// <param name="onDialogShown"></param>
        /// <returns></returns>
        internal static bool GetApplicationOverlayPermission(Context context, bool showDialog = false, Action<AlertDialog> onDialogShown = null)
        {
            AppOpsManager opsManager;
            AppOpsManagerMode mode;
            AlertDialog dialog;

            // Pre-M allowed this functionality
            if (Build.VERSION.SdkInt < BuildVersionCodes.M)
                return true;

            // Check permissions
            opsManager = (AppOpsManager)context.GetSystemService(Context.AppOpsService);
            mode = opsManager.CheckOpNoThrow(AppOpsManager.OpstrSystemAlertWindow, Process.MyUid(), context.PackageName);

            // Prompt if we need too
            if (mode != AppOpsManagerMode.Allowed)
            {
                if (showDialog)
                {
                    using (AlertDialog.Builder builder = new AlertDialog.Builder(context))
                    {
                        builder.SetMessage($"Squelch needs the ability to draw system overlays.{System.Environment.NewLine}{System.Environment.NewLine}Press OK and we will take you to the setting, otherwise press Cancel.");
                        builder.SetPositiveButton("Ok", delegate (object sender, DialogClickEventArgs args)
                        {
                            context.StartActivity(new Intent(Android.Provider.Settings.ActionManageOverlayPermission));
                        });
                        builder.SetNegativeButton("Cancel", delegate (object sender, DialogClickEventArgs args)
                        {
                            if (sender != null && sender is Dialog)
                                ((Dialog)sender).Dismiss();
                        });

                        dialog = builder.Create();
                        dialog.Show();

                        // Callback to onshow
                        onDialogShown?.Invoke(dialog);
                    }
                }

                return false;
            }

            return true;
        }

        /// <summary>
        /// Convenience method to check if the user has granted all required permissions. Will also show the prompt for the missing permission if showPrompt == true
        /// </summary>
        /// <param name="context"></param>
        /// <param name="showDialog"></param>
        /// <returns></returns>
        internal static bool HasRequiredPermissions(Context context, bool showDialog = false)
        {
            bool hasPermission = true;

            if (hasPermission)
                hasPermission = PermissionUtils.GetUsageDataPermission(context, showDialog);

            if (hasPermission)
                hasPermission = PermissionUtils.GetApplicationOverlayPermission(context, showDialog);

            return hasPermission;
        }
    }
}