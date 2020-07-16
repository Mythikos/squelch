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
    internal static class ViewUtils
    {
        #region Instance Variables
        private static readonly string s_tag = typeof(ViewUtils).FullName;
        #endregion

        internal static Android.Text.ISpanned FormattedTextFromHTML(string text)
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.N)
                return Android.Text.Html.FromHtml(text, Android.Text.FromHtmlOptions.ModeLegacy);
            else
                return Android.Text.Html.FromHtml(text);
        }

        internal static void SetViewAndChildrenEnabled(View view, bool enabled, bool ignoreToolbar = true)
        {
            if (ignoreToolbar == true && (view is Toolbar))
                return;

            view.Enabled = enabled;
            if (view is ViewGroup)
            {
                var viewGroup = (ViewGroup)view;
                for (int i = 0; i < viewGroup.ChildCount; i++)
                {
                    var child = viewGroup.GetChildAt(i);
                    if (child != null)
                        SetViewAndChildrenEnabled(child, enabled, ignoreToolbar);
                }
            }
        }
    }
}