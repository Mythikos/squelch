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
    }
}