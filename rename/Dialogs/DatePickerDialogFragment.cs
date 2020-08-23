using Android.App;
using Android.OS;
using Android.Widget;
using Squelch.Library;
using System;

namespace Squelch.Dialogs
{
    internal class DatePickerDialogFragment : AndroidX.Fragment.App.DialogFragment, DatePickerDialog.IOnDateSetListener
    {
        #region Instance Variables
        private static readonly string _tag = typeof(DatePickerDialogFragment).FullName;
        Action<DateTime> _dateSelectedHandler = delegate { };
        #endregion

        public static DatePickerDialogFragment NewInstance(Action<DateTime> onDateSelected)
        {
            DatePickerDialogFragment pickerFragment = null;

            try
            {
                pickerFragment = new DatePickerDialogFragment();
                pickerFragment._dateSelectedHandler = (onDateSelected != null) ? onDateSelected : null;
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"NewInstance: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            return pickerFragment;
        }

        public override Dialog OnCreateDialog(Bundle savedInstanceState)
        {
            DateTime now;
            DatePickerDialog pickerDialog = null;

            try
            {
                now = DateTime.Now;
                pickerDialog = new DatePickerDialog(Activity, this, now.Year, now.Month - 1, now.Day);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnCreateDialog: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            return pickerDialog;
        }

        public void OnDateSet(DatePicker view, int year, int monthOfYear, int dayOfMonth)
        {
            DateTime selectedDate;

            try
            {
                selectedDate = new DateTime(year, monthOfYear + 1, dayOfMonth);
                _dateSelectedHandler(selectedDate);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnDateSet: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }
        }
    }
}