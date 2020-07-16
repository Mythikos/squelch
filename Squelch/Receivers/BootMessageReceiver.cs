using Android.App;
using Android.Content;
using Squelch.Services;
using Android.Support.V4.Content;
using System;
using Squelch.Library;

namespace Squelch.Receivers
{
    [BroadcastReceiver(Label = "Squelch Boot Receiver", Enabled = true, DirectBootAware = true)]
    [IntentFilter(new[] { /*Intent.ActionLockedBootCompleted,*/ Intent.ActionBootCompleted }, Priority = 999 )]
    class BootMessageReceiver : BroadcastReceiver
    {
        #region Instance Variables
        private static readonly string s_tag = typeof(BootMessageReceiver).Name;
        #endregion

        public override void OnReceive(Context context, Intent intent)
        {
            try
            {
                if (/*intent.Action.Equals(Intent.ActionLockedBootCompleted) ||*/ intent.Action.Equals(Intent.ActionBootCompleted))
				    ContextCompat.StartForegroundService(context, new Intent(context, typeof(EnforcerService)).SetAction(EnforcerService.ACTION_START));
            } 
            catch(Exception ex)
            {
                Logger.Write(s_tag, $"OnReceive: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }
    }
}