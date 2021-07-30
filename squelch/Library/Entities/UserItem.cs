using System;
using System.Collections.Generic;
using System.Linq;

namespace Squelch.Library.Entities
{
    internal class UserItem
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public bool FormatTimeAsTwelveHour { get; set; }
        public Dictionary<string, string> Flags;

        public UserItem()
        {
            this.Id = UserItem.CreateNewId();
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
            this.EmailAddress = string.Empty;
            this.FormatTimeAsTwelveHour = true;
            this.Flags = new Dictionary<string, string>();
        }

        public void SetFlag(string key, string value)
        {
            if (this.Flags.Keys.Contains(key))
            {
                this.Flags[key] = value;
            }
            else
            {
                this.Flags.Add(key, value);
            }
        }

        public string GetFlag(string key)
        {
            if (this.Flags.Keys.Contains(key))
            {
                return this.Flags[key];
            }
            else
            {
                return string.Empty;
            }
        }

        public void RemoveFlag(string key)
        {
            if (this.Flags.Keys.Contains(key))
            {
                this.Flags.Remove(key);
            }
        }

        public static string CreateNewId()
        {
            return Guid.NewGuid().ToString().Replace("-", string.Empty).Replace("{", string.Empty).Replace("}", string.Empty);
        }
    }
}