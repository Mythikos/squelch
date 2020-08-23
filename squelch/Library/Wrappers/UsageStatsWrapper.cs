using Android.App.Usage;
using Android.Content;
using Android.Content.PM;
using Java.Util;
using System;

namespace Squelch.Library.Wrappers
{
    internal class UsageStatsWrapper
    {
        #region Properties
        public ApplicationInfo ForegroundApplication { get; private set; }
        public DateTime LastUpdate { get; private set; }
        #endregion

        #region Instance Variables
        private static readonly string s_tag = typeof(UsageStatsWrapper).FullName;
        private Context _context;
        #endregion

        #region Constructors
        public UsageStatsWrapper(Context context)
        {
            this._context = context;
        }
        #endregion

        /// <summary>
        /// Updates the class' properties. Must be called frequently to keep properties up to date.
        /// </summary>
        public void Update()
        {
            Date targetDate;
            string foregroundPackageName;
            long lastTimeStamp;
            UsageStatsManager usageStatsManager;
            UsageEvents usageEvents;
            UsageEvents.Event usageEvent;

            //
            // Init
            lastTimeStamp = 0;
            targetDate = new Date();
            foregroundPackageName = string.Empty;
            usageStatsManager = (UsageStatsManager)this._context.GetSystemService(Context.UsageStatsService);

            //
            // Do we have the usage stats manager?
            if (usageStatsManager != null)
            {
                usageEvents = usageStatsManager.QueryEvents(targetDate.Time - (1000 * 1000), targetDate.Time);
                while (usageEvents.HasNextEvent)
                {
                    usageEvent = new UsageEvents.Event();
                    usageEvents.GetNextEvent(usageEvent);
                    if (usageEvent.EventType == UsageEventType.MoveToForeground || usageEvent.EventType == UsageEventType.UserInteraction)
                    {
                        if (usageEvent.TimeStamp > lastTimeStamp)
                        {
                            lastTimeStamp = usageEvent.TimeStamp;
                            foregroundPackageName = usageEvent.PackageName;
                        }
                    }
                }
            }

            //
            // Load the application's info
            if (string.IsNullOrWhiteSpace(foregroundPackageName) == false)
                this.ForegroundApplication = this._context.PackageManager.GetApplicationInfo(foregroundPackageName, PackageInfoFlags.MatchAll);

            //
            // Update last update time
            this.LastUpdate = DateTime.Now;
        }
    }
}