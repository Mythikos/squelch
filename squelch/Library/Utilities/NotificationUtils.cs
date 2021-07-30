using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using AndroidX.Core.App;
using Squelch.Activities;

namespace Squelch.Library.Utilities
{
    internal static class NotificationUtils
    {
        #region Instance Variables
        private static readonly string s_tag = typeof(NotificationUtils).FullName;
        #endregion

        /// <summary>
        /// Creates a notification object that can then be opened and shown
        /// </summary>
        /// <param name="context"></param>
        /// <param name="channelId"></param>
        /// <param name="title"></param>
        /// <param name="content"></param>
        /// <param name="ongoing"></param>
        /// <param name="notificationImportance"></param>
        /// <returns></returns>
        internal static Notification CreateNotification(Context context, string channelId, string title, string content, bool ongoing = false, NotificationImportance notificationImportance = NotificationImportance.Default)
        {
            PendingIntent mainActivityIntent = PendingIntent.GetActivity(context, 0, new Intent(context, typeof(MainActivity)), 0);
            NotificationManager notificationManager = (NotificationManager)context.GetSystemService(Context.NotificationService);
            NotificationCompat.Builder builder = new NotificationCompat.Builder(context, channelId)
                .SetSmallIcon(Android.Resource.Drawable.SymDefAppIcon)
                .SetContentTitle(title)
                .SetContentText(content)
                .SetContentIntent(mainActivityIntent)
                .SetPriority(NotificationCompat.PriorityDefault)
                .SetSmallIcon(Resource.Drawable.ic_logo_notification_white)
                .SetLargeIcon(BitmapFactory.DecodeResource(context.Resources, Resource.Drawable.ic_logo_notification))
                .SetOngoing(ongoing);

            ///////////////////////////////////////////////////////////////////
            /// Platform: OREO +                                            ///
            /// Only android Oreo or higher require a notification channel  ///
            ///////////////////////////////////////////////////////////////////
            if (Build.VERSION.SdkInt >= BuildVersionCodes.O)
            {
                Java.Lang.ICharSequence[] name = CharSequence.ArrayFromStringArray(new string[] { "Squelch" });
                NotificationChannel channel = notificationManager.GetNotificationChannel(channelId);
                if (channel == null)
                {
                    channel = new NotificationChannel(channelId, name[0], notificationImportance)
                    {
                        Description = "Squelch Notifications"
                    };
                    notificationManager.CreateNotificationChannel(channel);
                }
            }
            ///////////////////////////////////////////////////////////////////

            return builder.Build();
        }
    }
}