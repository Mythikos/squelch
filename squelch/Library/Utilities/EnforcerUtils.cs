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
        /// The list of applications the app will suggest to blacklist
        /// </summary>
        internal static List<Tuple<string, string, string>> _recommendedBlacklist = new List<Tuple<string, string, string>> { // packagename, comparison type, reaction type
                Tuple.Create("com.android.settings", "Equals", "Any"), // Android Settings
                Tuple.Create("com.android.vending", "Equals", "Any"), // Google Play
                Tuple.Create("packageinstaller", "Contains", "Activity"), // Package installer / uninstaller
                Tuple.Create("com.lge.settings.easy", "Equals", "Any"), // LG Custom Settings
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
                foreach (Tuple<string, string, string> appBlacklistTuple in _recommendedBlacklist)
                {
                    if (appBlacklistTuple.Item2.Equals("Equals"))
                    {
                        if (packageName.Equals(appBlacklistTuple.Item1, StringComparison.OrdinalIgnoreCase))
                        {
                            return true;
                        }
                    }
                    else if (appBlacklistTuple.Item2.Equals("Contains"))
                    {
                        if (packageName.Contains(appBlacklistTuple.Item1, StringComparison.OrdinalIgnoreCase))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Checks if the package name is a system package and returns true if the overlay is adequate to block it, otherwise false
        /// </summary>
        /// <param name="context"></param>
        /// <param name="packageName"></param>
        /// <returns></returns>
        internal static bool CanUseOverlay(Context context, string packageName)
        {
            if (context.PackageManager.IsSystemApplication(packageName))
            {
                foreach (Tuple<string, string, string> appBlacklistTuple in _recommendedBlacklist)
                {
                    if (packageName.Equals(appBlacklistTuple.Item1, StringComparison.OrdinalIgnoreCase))
                    {
                        if (appBlacklistTuple.Item3.Equals("Any") || appBlacklistTuple.Item3.Equals("Overlay"))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}