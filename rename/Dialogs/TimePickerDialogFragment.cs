using Android.App;
using Android.OS;
using Squelch.Library;
using System;
using Android.Text.Format;
using Android.Widget;

namespace Squelch.Dialogs
{
    internal class TimePickerDialogFragment : AndroidX.Fragment.App.DialogFragment, TimePickerDialog.IOnTimeSetListener
    {
        #region Instance Variables
        private static readonly string _tag = typeof(TimePickerDialogFragment).FullName;
        Action<DateTime> _timeSelectedHandler = delegate { };
        #endregion

        public static TimePickerDialogFragment NewInstance(Action<DateTime> onTimeSelected)
        {
            TimePickerDialogFragment pickerFragment = null;

            try
            {
                pickerFragment = new TimePickerDialogFragment();
                pickerFragment._timeSelectedHandler = (onTimeSelected != null) ? onTimeSelected : null;
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"NewInstance: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            return pickerFragment;
        }

        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {
            DateTime currentTime;
            bool is24HourFormat;
            TimePickerDialog pickerDialog = null;

            try
            {
                currentTime = DateTime.Now;
                is24HourFormat = DateFormat.Is24HourFormat(Activity);
                pickerDialog = new TimePickerDialog(Activity, this, currentTime.Hour, currentTime.Minute, is24HourFormat);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnCreateDialog: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            return pickerDialog;
        }

        public void OnTimeSet(TimePicker view, int hourOfDay, int minute)
        {
            DateTime currentTime;
            DateTime selectedTime;

            try
            {
                currentTime = DateTime.Now;
                selectedTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, hourOfDay, minute, 0);
                _timeSelectedHandler(selectedTime);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnTimeSet: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }
    }
}