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
using Squelch.Activities;
using Squelch.Library;

namespace Squelch.Fragments
{
    public class StatisticsFragment : AndroidX.Fragment.App.Fragment
    {
        #region Instance Variables
        private static readonly string _tag = typeof(StatisticsFragment).FullName;
        #endregion

        #region Native Events
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view;

            //
            // Inflate the layour
            view = inflater.Inflate(Resource.Layout.fragment_statistics, container, false);

            try
            {
                //
                // Setup navbar
                ((MainActivity)this.Activity).SetupNavigation(Resource.String.title_statistics, true, false);
            }
            catch (Exception ex)
            {
                Logger.Write(_tag, $"OnCreateView: {Logger.CreateExceptionString(ex)}", Logger.Severity.Error);
            }

            //
            // Return the inflated view
            return view;
        }
        #endregion
    }
}