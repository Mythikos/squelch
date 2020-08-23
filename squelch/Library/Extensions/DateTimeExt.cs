using System;

namespace Squelch.Library.Extensions
{
    internal static class DateTimeExt
    {
        /// <summary>
        /// Returns only the date portion of the DateTime value
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static DateTime ToDate(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day);
        }

        /// <summary>
        /// Returns only the time portion of the DateTime value
        /// </summary>
        /// <returns></returns>
        public static TimeSpan ToTime(this DateTime date)
        {
            return new TimeSpan(date.Hour, date.Minute, date.Second);
        }

        /// <summary>
        /// Converts datetime to the standard display date format
        /// </summary>
        /// <param name="inputDate"></param>
        /// <returns></returns>
        public static string FormatDate(this DateTime inputDate)
        {
            return inputDate.ToString("dddd, MMMM dd, yyyy");
        }

        /// <summary>
        /// Converts datetime to the standard display time format
        /// </summary>
        /// <param name="inputTime"></param>
        /// <returns></returns>
        public static string FormatTime(this DateTime inputTime)
        {
            return inputTime.ToString("hh:mm tt");
        }

        /// <summary>
        /// Returns the day's suffix (i.g., st, nd, th)
        /// </summary>
        /// <param name="inputDate"></param>
        /// <returns></returns>
        public static string DaySuffix(this DateTime inputDate)
        {
            return (inputDate.Day % 10 == 1 && inputDate.Day != 11) ? "st" : (inputDate.Day % 10 == 2 && inputDate.Day != 12) ? "nd" : (inputDate.Day % 10 == 3 && inputDate.Day != 13) ? "rd" : "th";
        }

        /// <summary>
        /// Returns a friendly day label (i.g., Tomorrow, Today, Next Week, Future)
        /// </summary>
        /// <param name="inputDate"></param>
        /// <returns></returns>
        public static string TemporalLabel(this DateTime inputDate, DateTime today)
        {
            string result = string.Empty;
            int dayDifference = (inputDate - today).Days;

            if (dayDifference <= 0)
            {
                result = "Today";
            }
            else if (dayDifference <= 1)
            {
                result = "Tomorrow";
            }
            else if (dayDifference <= 6)
            {
                result = inputDate.DayOfWeek.ToString();
            }
            else if (dayDifference <= 13)
            {
                result = "Next Week";
            }
            else if (inputDate.Month == today.Month && inputDate.Year == today.Year)
            {
                result = "This Month";
            }
            else if (inputDate.Month == today.AddMonths(1).Month && inputDate.Year == today.AddMonths(1).Year)
            {
                result = "Next Month";
            }
            else
            {
                result = "In the future";
            }

            return result;
        }

        /// <summary>
        /// Not really a datetime extension, but seemed fitting to let it live here
        /// </summary>
        /// <param name="temporalLabel"></param>
        /// <returns></returns>
        public static DateTime? DateTimeFromTemporalLabel(this string temporalLabel, DateTime today)
        {
            DateTime? result = null;

            if (temporalLabel.Equals("today", StringComparison.OrdinalIgnoreCase))
            {
                result = today;
            }
            else if (temporalLabel.Equals("tomorrow", StringComparison.OrdinalIgnoreCase))
            {
                result = today.AddDays(1);
            }
            else if (temporalLabel.Equals("monday", StringComparison.OrdinalIgnoreCase)
                || temporalLabel.Equals("tuesday", StringComparison.OrdinalIgnoreCase)
                || temporalLabel.Equals("wednesday", StringComparison.OrdinalIgnoreCase)
                || temporalLabel.Equals("thursday", StringComparison.OrdinalIgnoreCase)
                || temporalLabel.Equals("friday", StringComparison.OrdinalIgnoreCase)
                || temporalLabel.Equals("saturday", StringComparison.OrdinalIgnoreCase)
                || temporalLabel.Equals("sunday", StringComparison.OrdinalIgnoreCase))
            {
                var dayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), temporalLabel);
                var dayDifference = ((int)dayOfWeek - (int)today.DayOfWeek + 7) % 7;
                result = today.AddDays(dayDifference);
            }
            else if (temporalLabel.Equals("next week", StringComparison.OrdinalIgnoreCase))
            {
                result = today.AddDays(7);
            }
            else if (temporalLabel.Equals("this month", StringComparison.OrdinalIgnoreCase))
            {
                result = today;
            }
            else if (temporalLabel.Equals("next month", StringComparison.OrdinalIgnoreCase))
            {
                result = today.AddMonths(1);
            }
            else
            {
                // "In the future" is indeterminate, no date representation available
                result = null;
            }

            return result;
        }
    }
}