using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.OS;
using Firebase.Analytics;
using Firebase.Auth;
using Squelch.Library.Data;
using Squelch.Library.Entities;

namespace Squelch.Library.Singletons
{
    internal class FirebaseAnalyticsManager
    {
        #region Singleton Support
        #region Instance Variables and Properties
        private static FirebaseAnalyticsManager _instance = null;
        public static FirebaseAnalyticsManager GetInstance()
        {
            if (_instance == null)
                _instance = new FirebaseAnalyticsManager();

            return _instance;
        }
        #endregion

        #region Construtors
        private FirebaseAnalyticsManager()
        {
            _analytics = FirebaseAnalytics.GetInstance(Application.Context);
            _analytics.SetUserId(UserSettings.Id);
#if DEBUG
            _analytics.SetAnalyticsCollectionEnabled(false);
#else
            _analytics.SetAnalyticsCollectionEnabled(true);
#endif
        }
        #endregion
        #endregion

        #region Instance Variables
        private static readonly string s_tag = typeof(FirebaseAnalyticsManager).FullName;
        private FirebaseAnalytics _analytics;
        #endregion

        #region Constants
        internal const string EVENT_BLACKOUT_FAILED = "blackout_failed";
        internal const string EVENT_BLACKOUT_CANCELLED = "blackout_cancelled";
        internal const string EVENT_BLACKOUT_SUCCESSFUL = "blackout_successful";
        #endregion

        public void SetCurrentScreen(Activity activity)
        {
            try
            {
                _analytics.SetCurrentScreen(activity, activity.GetType().Name, activity.GetType().Name);
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, ex, Logger.Severity.Error);
            }
        }

        public void SetCurrentScreen(AndroidX.Fragment.App.Fragment fragment)
        {
            try
            {
                _analytics.SetCurrentScreen(fragment.Activity, fragment.GetType().Name, fragment.GetType().Name);
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, ex, Logger.Severity.Error);
            }
        }

        public void SendEvent(string eventName, Bundle analyticBundle)
        {
            try
            {
                _analytics.LogEvent(eventName, analyticBundle);
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, ex, Logger.Severity.Error);
            }
        }

        #region Helper Methods
        public void SendBlackoutEvent(string eventName, BlackoutItem blackout)
        {
            Bundle analyticBundle;
            Dictionary<string, int> blockedApplicationCountByCategory;
            string primaryCategoryBlocked = string.Empty;
            string secondaryCategoryBlocked = string.Empty;
            string tertiaryCategoryBlocked = string.Empty;

            try
            {
                //
                // Top 3 categories
                // Initialize category list and count apps blocked by category
                blockedApplicationCountByCategory = new Dictionary<string, int>();
                blockedApplicationCountByCategory.Add("audio", 0); // ApplicationCategories.Audio
                blockedApplicationCountByCategory.Add("game", 0); // ApplicationCategories.Game
                blockedApplicationCountByCategory.Add("image", 0); // ApplicationCategories.Image
                blockedApplicationCountByCategory.Add("maps", 0); // ApplicationCategories.Maps
                blockedApplicationCountByCategory.Add("news", 0); // ApplicationCategories.News
                blockedApplicationCountByCategory.Add("productivity", 0); // ApplicationCategories.Productivity
                blockedApplicationCountByCategory.Add("social", 0); // ApplicationCategories.Social
                blockedApplicationCountByCategory.Add("video", 0); // ApplicationCategories.Video
                blockedApplicationCountByCategory.Add("undefined", 0); // ApplicationCategories.Undefined

                if (Build.VERSION.SdkInt >= BuildVersionCodes.O)
                {
                    foreach (string packageName in blackout.Blacklist)
                    {
                        if (string.IsNullOrWhiteSpace(packageName) == false)
                        {
                            var applicationInfo = Application.Context.PackageManager.GetPackageInfo(packageName, Android.Content.PM.PackageInfoFlags.MatchAll)?.ApplicationInfo;
                            if (applicationInfo != null)
                            {
                                var category = applicationInfo.Category.ToString().ToLower();
                                if (blockedApplicationCountByCategory.ContainsKey(category))
                                    blockedApplicationCountByCategory[category] += 1;
                                else
                                    blockedApplicationCountByCategory["undefined"] += 1;
                            }
                        }
                    }
                }
                else
                {
                    blockedApplicationCountByCategory["undefined"] = blackout.Blacklist.Count();
                }

                // Snag the categories in a ranked order
                primaryCategoryBlocked = blockedApplicationCountByCategory.OrderByDescending(x => x.Value).FirstOrDefault().Key;
                secondaryCategoryBlocked = blockedApplicationCountByCategory.OrderByDescending(x => x.Value).FirstOrDefault(x => x.Key.Equals(primaryCategoryBlocked) == false).Key;
                tertiaryCategoryBlocked = blockedApplicationCountByCategory.OrderByDescending(x => x.Value).FirstOrDefault(x => x.Key.Equals(primaryCategoryBlocked) == false && x.Key.Equals(secondaryCategoryBlocked) == false).Key;

                //
                // Build the analytics bundle
                analyticBundle = new Bundle();
                analyticBundle.PutString(FirebaseAnalytics.Param.ItemCategory, "blackout");
                analyticBundle.PutString("blackout_bid", blackout.Bid.ToString());
                analyticBundle.PutString("blackout_difficulty", blackout.DifficultyCode.ToString().ToLower());

                analyticBundle.PutString("blackout_startdatetime_hour", blackout.StartDateTime.Hour.ToString());
                analyticBundle.PutString("blackout_startdatetime_day_of_week", blackout.StartDateTime.DayOfWeek.ToString());

                analyticBundle.PutString("blackout_enddatetime_hour", blackout.EndDateTime.Hour.ToString());
                analyticBundle.PutString("blackout_enddatetime_day_of_week", blackout.EndDateTime.DayOfWeek.ToString());

                if (blockedApplicationCountByCategory[primaryCategoryBlocked] > 0)
                    analyticBundle.PutString("blackout_category_blocked_primary", primaryCategoryBlocked);

                if (blockedApplicationCountByCategory[secondaryCategoryBlocked] > 0)
                    analyticBundle.PutString("blackout_category_blocked_secondary", secondaryCategoryBlocked);

                if (blockedApplicationCountByCategory[tertiaryCategoryBlocked] > 0)
                    analyticBundle.PutString("blackout_category_blocked_tertiary", tertiaryCategoryBlocked);

                // Log the event
                this.SendEvent(eventName, analyticBundle);
            }
            catch (Exception ex)
            {
                Logger.Write(s_tag, ex, Logger.Severity.Error);
            }
        }
        #endregion
    }
}