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

namespace Squelch.Library.Utilities
{
    internal static class DateUtils
    {
        /// <summary>
        /// Creates a temporal label that represents how far into the future the input date is compared to today
        /// </summary>
        /// <param name="context"></param>
        /// <param name="inputDate"></param>
        /// <param name="today"></param>
        /// <returns></returns>
        internal static string GetTemporalLabel(Context context, DateTime inputDate, DateTime today)
        {
            string result = string.Empty;
            int dayDifference = (inputDate - today).Days;

            if (dayDifference <= 0)
            {
                result = context.GetString(Resource.String.text_today);
            }
            else if (dayDifference <= 1)
            {
                result = context.GetString(Resource.String.text_tomorrow);
            }
            else if (dayDifference <= 6)
            {
                result = inputDate.ToString("dddd", System.Globalization.CultureInfo.DefaultThreadCurrentCulture);
            }
            else if (dayDifference <= 13)
            {
                result = context.GetString(Resource.String.text_next_week);
            }
            else if (inputDate.Month == today.Month && inputDate.Year == today.Year)
            {
                result = context.GetString(Resource.String.text_this_month);
            }
            else if (inputDate.Month == today.AddMonths(1).Month && inputDate.Year == today.AddMonths(1).Year)
            {
                result = context.GetString(Resource.String.text_next_month);
            }
            else
            {
                result = context.GetString(Resource.String.text_in_the_future);
            }

            return result;
        }

        /// <summary>
        /// Converts a temporal label back to date time. Reliability of datetime value changes depending on the temporal label received.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="temporalLabel"></param>
        /// <param name="today"></param>
        /// <returns></returns>
        internal static DateTime? GetDateTimeFromTemporalLabel(Context context, string temporalLabel, DateTime today)
        {
            DateTime? result = null;

            if (temporalLabel.Equals(context.GetString(Resource.String.text_today), StringComparison.OrdinalIgnoreCase))
            {
                result = today;
            }
            else if (temporalLabel.Equals(context.GetString(Resource.String.text_tomorrow), StringComparison.OrdinalIgnoreCase))
            {
                result = today.AddDays(1);
            }
            else if (temporalLabel.Equals(today.AddDays(2).ToString("dddd", System.Globalization.CultureInfo.DefaultThreadCurrentCulture), StringComparison.OrdinalIgnoreCase))
            {
                result = today.AddDays(2);
            }
            else if (temporalLabel.Equals(today.AddDays(3).ToString("dddd", System.Globalization.CultureInfo.DefaultThreadCurrentCulture), StringComparison.OrdinalIgnoreCase))
            {
                result = today.AddDays(3);
            }
            else if (temporalLabel.Equals(today.AddDays(4).ToString("dddd", System.Globalization.CultureInfo.DefaultThreadCurrentCulture), StringComparison.OrdinalIgnoreCase))
            {
                result = today.AddDays(4);
            }
            else if (temporalLabel.Equals(today.AddDays(5).ToString("dddd", System.Globalization.CultureInfo.DefaultThreadCurrentCulture), StringComparison.OrdinalIgnoreCase))
            {
                result = today.AddDays(5);
            }
            else if (temporalLabel.Equals(today.AddDays(6).ToString("dddd", System.Globalization.CultureInfo.DefaultThreadCurrentCulture), StringComparison.OrdinalIgnoreCase))
            {
                result = today.AddDays(6);
            }
            else if (temporalLabel.Equals(context.GetString(Resource.String.text_next_week), StringComparison.OrdinalIgnoreCase))
            {
                result = today.AddDays(7);
            }
            else if (temporalLabel.Equals(context.GetString(Resource.String.text_this_month), StringComparison.OrdinalIgnoreCase))
            {
                result = today;
            }
            else if (temporalLabel.Equals(context.GetString(Resource.String.text_next_month), StringComparison.OrdinalIgnoreCase))
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

        /// <summary>
        /// Returns only the date portion of the DateTime value
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        internal static DateTime ToDate(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day);
        }

        /// <summary>
        /// Returns only the time portion of the DateTime value
        /// </summary>
        /// <returns></returns>
        internal static TimeSpan ToTime(DateTime date)
        {
            return new TimeSpan(date.Hour, date.Minute, date.Second);
        }

        /// <summary>
        /// Converts datetime to the standard display format
        /// </summary>
        /// <param name="inputDate"></param>
        /// <returns></returns>
        internal static string FormatDateLong(DateTime inputDate)
        {
            return inputDate.ToString("dddd, MMMM dd, yyyy", System.Globalization.CultureInfo.DefaultThreadCurrentCulture);
        }

        /// <summary>
        /// Converts datetime to the shortened standard display format
        /// </summary>
        /// <param name="inputDate"></param>
        /// <returns></returns>
        internal static string FormatDateShort(DateTime inputDate)
        {
            return inputDate.ToString("MM/dd/yyyy", System.Globalization.CultureInfo.DefaultThreadCurrentCulture);
        }

        /// <summary>
        /// Converts datetime to the specified format specified
        /// </summary>
        /// <param name="inputDate"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        internal static string FormatDateCustom(DateTime inputDate, string format)
        {
            return inputDate.ToString(format, System.Globalization.CultureInfo.DefaultThreadCurrentCulture);
        }

        /// <summary>
        /// Converts datetime to the standard display time format
        /// </summary>
        /// <param name="inputTime"></param>
        /// <returns></returns>
        internal static string FormatTime(DateTime inputTime, bool formatTimeAsMilitary)
        {
            if (formatTimeAsMilitary)
                return inputTime.ToString("HHmm", System.Globalization.CultureInfo.DefaultThreadCurrentCulture);
            else
                return inputTime.ToString("hh:mm tt", System.Globalization.CultureInfo.DefaultThreadCurrentCulture);
        }
    }
}