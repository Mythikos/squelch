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
        public static string DayLabelFriendly(this DateTime inputDate, DateTime today)
        {
            var dayDifference = (inputDate - today).Days;

            if (dayDifference <= 0)
            {
                return "Today";
            }
            else if (dayDifference <= 1)
            {
                return "Tomorrow";
            }
            else if (dayDifference <= 6)
            {
                return inputDate.DayOfWeek.ToString();
            }
            else if (dayDifference <= 13)
            {
                return "Next Week";
            }
            else if (inputDate.Month == today.Month && inputDate.Year == today.Year)
            {
                return "This Month";
            }
            else if (inputDate.Month == today.AddMonths(1).Month && inputDate.Year == today.AddMonths(1).Year)
            {
                return "Next Month";
            }
            else
            {
                return "In the future";
            }
        }
    }
}