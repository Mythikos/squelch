using Android.OS;
using Android.Views;
using Android.Widget;
using AndroidX.Fragment.App;
using Squelch.Activities;
using Squelch.Library;
using Squelch.Library.Utilities;
using System;

namespace Squelch.Fragments
{
    public class CalendarFragment : Fragment
    {
        #region Instance Variables
        private static readonly string _tag = typeof(CalendarFragment).FullName;

        private LinearLayout _rootLayout;
        private Com.Applandeo.Materialcalendarview.CalendarView _calendarView;
        #endregion

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view;

            //
            // Inflate the layour
            view = inflater.Inflate(Resource.Layout.fragment_calendar, container, false);

            try
            {
                _rootLayout = view.FindViewById<LinearLayout>(Resource.Id.fragment_calendar_root_layout);
                _calendarView = view.FindViewById<Com.Applandeo.Materialcalendarview.CalendarView>(Resource.Id.fragment_calendar_calendar_view);
                _calendarView.ForwardPageChange += CalendarView_ForwardPageChange;
                _calendarView.PreviousPageChange += CalendarView_PreviousPageChange;

                //
                // Setup navbar
                ((MainActivity)this.Activity).SetupNavigation(Resource.String.title_calendar, true, false);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnCreateView: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            //
            // Return the inflated view
            return view;
        }

        private void CalendarView_PreviousPageChange(object sender, EventArgs e)
        {
            DisplayUtils.ShowToast(this.Context, "Previous", ToastLength.Long);
        }

        private void CalendarView_ForwardPageChange(object sender, EventArgs e)
        {
            DisplayUtils.ShowToast(this.Context, "Forward", ToastLength.Long);
        }
    }
}