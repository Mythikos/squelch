using Android.Content;
using Squelch.Library;
using System;

namespace Squelch.Receivers
{
    internal class GenericBroadcastReceiver : BroadcastReceiver
    {
        #region Instance Variables
        private static readonly string s_tag = typeof(GenericBroadcastReceiver).FullName;
        Action<Context, Intent> _broadcastReceived = null;
        #endregion

        public GenericBroadcastReceiver(Action<Context, Intent> onBroadcastReceived)
        {
            try
            {
                if (onBroadcastReceived != null)
                    _broadcastReceived = onBroadcastReceived;
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"GenericBroadcastReceiver: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }

        public override void OnReceive(Context context, Intent intent)
        {
            try
            {
                if (_broadcastReceived != null)
                    _broadcastReceived(context, intent);
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"OnReceive: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }
    }
}