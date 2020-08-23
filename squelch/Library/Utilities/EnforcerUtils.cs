using Android.Content;
using Squelch.Library.Extensions;
using System;
using System.Collections.Generic;

namespace Squelch.Library.Utilities
{
    internal static class EnforcerUtils
    {
        #region Instance Variables
        private static readonly string s_tag = typeof(EnforcerUtils).FullName;
        #endregion

        /// <summary>
        /// The lsit of applications the app will suggest to blacklist
        /// </summary>
        internal static List<Tuple<string, string>> _recommendedBlacklist = new List<Tuple<string, string>> {
                Tuple.Create("com.android.settings", "Equals"), // Android Settings
                Tuple.Create("com.android.vending", "Equals"), // Google Play
                Tuple.Create("packageinstaller", "Contains"), // Package installer / uninstaller

                Tuple.Create("com.lge.settings.easy", "Equals"), // LG Custom Settings
            };

        /// <summary>
        /// Returns true if the specified package is recommended to be blocked.
        /// I.g., Google Play, Package Installer, Settings Menu, etc.
        /// </summary>
        /// <param name="packageName"></param>
        /// <returns></returns>
        internal static bool ShouldBlockApplication(Context context, string packageName)
        {
            if (context.PackageManager.IsSystemApplication(packageName))
            {
                foreach (Tuple<string, string> appBlacklistTuple in _recommendedBlacklist)
                {
                    if (appBlacklistTuple.Item2.Equals("Equals"))
                    {
                        if (packageName.Equals(appBlacklistTuple.Item1, StringComparison.OrdinalIgnoreCase))
                            return true;
                    }
                    else if (appBlacklistTuple.Item2.Equals("Contains"))
                    {
                        if (packageName.Contains(appBlacklistTuple.Item1, StringComparison.OrdinalIgnoreCase))
                            return true;
                    }
                }
            }

            return false;
        }
    }
}