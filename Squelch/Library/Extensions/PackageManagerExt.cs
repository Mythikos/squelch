using Android.Content.PM;
using Java.Util.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Squelch.Library;

namespace Squelch.Library.Extensions
{
    internal static class PackageManagerExt
    {
        /// <summary>
        /// Returns a list of installed applications on this device
        /// </summary>
        /// <param name="packageManager"></param>
        /// <param name="includeSystemApplications"></param>
        /// <returns></returns>
        public static List<ApplicationInfo> GetInstalledApplications(this PackageManager packageManager, bool includeSystemApplications)
        {
            List<ApplicationInfo> applications = null;

            if (includeSystemApplications == true)
                applications = packageManager.GetInstalledApplications(PackageInfoFlags.MatchAll).ToList();
            else
                applications = packageManager.GetInstalledApplications(PackageInfoFlags.MatchAll).Where(x => (x.Flags & ApplicationInfoFlags.System) != ApplicationInfoFlags.System).ToList();

            return applications ?? new List<ApplicationInfo>();
        }

        /// <summary>
        /// Returns true if the app is a system application
        /// </summary>
        /// <param name="context"></param>
        /// <param name="packageName"></param>
        /// <returns></returns>
        public static bool IsSystemApplication(this PackageManager packageManager, string packageName)
        {
            PackageInfo packageInfo;

            packageInfo = packageManager.GetPackageInfo(packageName, 0);
            return (packageInfo.ApplicationInfo.Flags & ApplicationInfoFlags.System) == ApplicationInfoFlags.System;

            return false;
        }
    }
}