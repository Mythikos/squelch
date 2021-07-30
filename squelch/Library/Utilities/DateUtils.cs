using Android.Content;
using Android.Icu.Text;
using System;
using TextFormatter = Android.Text.Format;

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
                result = DateUtils.FormatDateCustom(context, inputDate, "EEEE");
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
            else if (temporalLabel.Equals(DateUtils.FormatDateCustom(context, today.AddDays(2), "EEEE"), StringComparison.OrdinalIgnoreCase))
            {
                result = today.AddDays(2);
            }
            else if (temporalLabel.Equals(DateUtils.FormatDateCustom(context, today.AddDays(3), "EEEE"), StringComparison.OrdinalIgnoreCase))
            {
                result = today.AddDays(3);
            }
            else if (temporalLabel.Equals(DateUtils.FormatDateCustom(context, today.AddDays(4), "EEEE"), StringComparison.OrdinalIgnoreCase))
            {
                result = today.AddDays(4);
            }
            else if (temporalLabel.Equals(DateUtils.FormatDateCustom(context, today.AddDays(5), "EEEE"), StringComparison.OrdinalIgnoreCase))
            {
                result = today.AddDays(5);
            }
            else if (temporalLabel.Equals(DateUtils.FormatDateCustom(context, today.AddDays(6), "EEEE"), StringComparison.OrdinalIgnoreCase))
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
        internal static string FormatDateLong(Context context, DateTime inputDate)
        {
            return TextFormatter.DateUtils.FormatDateTime(context, new DateTimeOffset(inputDate).ToUnixTimeMilliseconds(), TextFormatter.FormatStyleFlags.ShowDate | TextFormatter.FormatStyleFlags.ShowWeekday | TextFormatter.FormatStyleFlags.ShowYear);
        }

        /// <summary>
        /// Converts datetime to the shortened standard display format
        /// </summary>
        /// <param name="inputDate"></param>
        /// <returns></returns>
        internal static string FormatDateShort(Context context, DateTime inputDate)
        {
            return TextFormatter.DateUtils.FormatDateTime(context, new DateTimeOffset(inputDate).ToUnixTimeMilliseconds(), TextFormatter.FormatStyleFlags.ShowDate | TextFormatter.FormatStyleFlags.ShowYear);
        }

        /// <summary>
        /// Converts datetime to the specified format specified
        /// </summary>
        /// <param name="inputDate"></param>
        /// <param name="format"></param>
        /// <returns></returns>
        internal static string FormatDateCustom(Context context, DateTime inputDate, string format)
        {
            return new SimpleDateFormat(format).Format(new DateTimeOffset(inputDate).ToUnixTimeMilliseconds());
        }

        /// <summary>
        /// Converts datetime to the standard display time format
        /// </summary>
        /// <param name="inputTime"></param>
        /// <returns></returns>
        internal static string FormatTime(Context context, DateTime inputTime, bool formatTimeAsTwelveHour)
        {
            if (formatTimeAsTwelveHour)
            {
                return TextFormatter.DateUtils.FormatDateTime(context, new DateTimeOffset(inputTime).ToUnixTimeMilliseconds(), TextFormatter.FormatStyleFlags.ShowTime | TextFormatter.FormatStyleFlags.TwelveHour | TextFormatter.FormatStyleFlags.CapAmpm);
            }
            else
            {
                return TextFormatter.DateUtils.FormatDateTime(context, new DateTimeOffset(inputTime).ToUnixTimeMilliseconds(), TextFormatter.FormatStyleFlags.ShowTime | TextFormatter.FormatStyleFlags.TwentyFourHour);
            }
        }
    }
}