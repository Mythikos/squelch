using Android.Content;
using Squelch.Library;
using System;

namespace Squelch.Receivers
{
    internal class GenericBroadcastReceiver : BroadcastReceiver
    {
        #region Instance Variables
        private static readonly string s_tag = typeof(GenericBroadcastReceiver).FullName;
        private Action<Context, Intent> _broadcastReceived = null;
        #endregion

        public GenericBroadcastReceiver(Action<Context, Intent> onBroadcastReceived)
        {
            try
            {
                if (onBroadcastReceived != null)
                {
                    this._broadcastReceived = onBroadcastReceived;
                }
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
                if (this._broadcastReceived != null)
                {
                    this._broadcastReceived(context, intent);
                }
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, $"OnReceive: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }
    }
}