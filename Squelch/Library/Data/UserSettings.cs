using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using Squelch.Library.Entities;

namespace Squelch.Library.Data
{
    internal static class UserSettings
    {
        public enum FlagKeys 
        { 
            FirstTimeSetup_IsCompleted, // Possible values: true, false
            FirstTimeSetup_CompletedOn, // Possible values: a datetime that represents the time of the above value

            Feedback_Status, // Possible values: true, false, skipped
            Feedback_StatusUpdatedOn // Possible values: a datetime that represents the time of the above value
        }

        private const string PATTERN_FLAG_NAME = "Flag_{0}";
        
        private static ISettings AppSettings => CrossSettings.Current;

        #region Events
        public static event Action<string, string> SettingChanged;
        private static void OnChange(string key, string value) => SettingChanged?.Invoke(key, value);
        #endregion

        #region Settings Properties
        public static string Id
        {
            get { return AppSettings.GetValueOrDefault(nameof(Id), UserItem.CreateNewId()); }
            set { AppSettings.AddOrUpdateValue(nameof(Id), value); OnChange(nameof(Id), value); }
        }

        public static string FirstName
        {
            get { return AppSettings.GetValueOrDefault(nameof(FirstName), string.Empty); }
            set { AppSettings.AddOrUpdateValue(nameof(FirstName), value); OnChange(nameof(FirstName), value); }
        }

        public static string LastName
        {
            get { return AppSettings.GetValueOrDefault(nameof(LastName), string.Empty); }
            set { AppSettings.AddOrUpdateValue(nameof(LastName), value); OnChange(nameof(LastName), value); }
        }

        public static string EmailAddress
        {
            get { return AppSettings.GetValueOrDefault(nameof(EmailAddress), string.Empty); }
            set { AppSettings.AddOrUpdateValue(nameof(EmailAddress), value); OnChange(nameof(EmailAddress), value); }
        }
        #endregion

        #region Flag Methods
        public static string GetFlagValue(FlagKeys flag, string defaultValue = null)
        {
            return AppSettings.GetValueOrDefault(string.Format(PATTERN_FLAG_NAME, flag), defaultValue ?? string.Empty);
        }

        public static void SetFlagValue(FlagKeys flag, string value)
        {
            AppSettings.AddOrUpdateValue(string.Format(PATTERN_FLAG_NAME, flag), value);
            OnChange(string.Format(PATTERN_FLAG_NAME, flag), value);
        }
        #endregion

        #region Helper Properties
        public static UserItem UserItem
        {
            get
            {
                // Init
                var userItem = new UserItem()
                {
                    Id = UserSettings.Id,
                    FirstName = UserSettings.FirstName,
                    LastName = UserSettings.LastName
                };

                // Iterate over flags and add to flag dictionary
                foreach (FlagKeys flag in Enum.GetNames(typeof(FlagKeys)).Select(x => Enum.Parse(typeof(FlagKeys), x)))
                    userItem.Flags.Add(string.Format(PATTERN_FLAG_NAME, flag), UserSettings.GetFlagValue(flag));

                // return
                return userItem;
            }
        }

        public static string FullName
        {
            get
            {
                return (
                    (string.IsNullOrWhiteSpace(UserSettings.FirstName) ? string.Empty : UserSettings.FirstName) 
                    + (string.IsNullOrWhiteSpace(UserSettings.LastName) ? string.Empty : " " + UserSettings.LastName)
                ).Trim();
            }
        }

        public static string NameInitial
        {
            get
            {
                if (!string.IsNullOrWhiteSpace(UserSettings.FirstName))
                    return UserSettings.FirstName[0].ToString().ToUpper();
                else if (!string.IsNullOrWhiteSpace(UserSettings.LastName))
                    return UserSettings.LastName[0].ToString().ToUpper();
                else
                    return string.Empty;
            }
        }
        #endregion
    }
}