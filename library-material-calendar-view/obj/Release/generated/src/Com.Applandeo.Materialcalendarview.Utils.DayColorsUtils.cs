using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Applandeo.Materialcalendarview.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DayColorsUtils']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/utils/DayColorsUtils", DoNotGenerateAcw=true)]
	public partial class DayColorsUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/applandeo/materialcalendarview/utils/DayColorsUtils", typeof (DayColorsUtils));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected DayColorsUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DayColorsUtils']/constructor[@name='DayColorsUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DayColorsUtils ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DayColorsUtils']/method[@name='setCurrentMonthDayColors' and count(parameter)=4 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='java.util.Calendar'] and parameter[3][@type='android.widget.TextView'] and parameter[4][@type='com.applandeo.materialcalendarview.utils.CalendarProperties']]"
		[Register ("setCurrentMonthDayColors", "(Ljava/util/Calendar;Ljava/util/Calendar;Landroid/widget/TextView;Lcom/applandeo/materialcalendarview/utils/CalendarProperties;)V", "")]
		public static unsafe void SetCurrentMonthDayColors (global::Java.Util.Calendar day, global::Java.Util.Calendar today, global::Android.Widget.TextView dayLabel, global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties calendarProperties)
		{
			const string __id = "setCurrentMonthDayColors.(Ljava/util/Calendar;Ljava/util/Calendar;Landroid/widget/TextView;Lcom/applandeo/materialcalendarview/utils/CalendarProperties;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((day == null) ? IntPtr.Zero : ((global::Java.Lang.Object) day).Handle);
				__args [1] = new JniArgumentValue ((today == null) ? IntPtr.Zero : ((global::Java.Lang.Object) today).Handle);
				__args [2] = new JniArgumentValue ((dayLabel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dayLabel).Handle);
				__args [3] = new JniArgumentValue ((calendarProperties == null) ? IntPtr.Zero : ((global::Java.Lang.Object) calendarProperties).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DayColorsUtils']/method[@name='setDayColors' and count(parameter)=4 and parameter[1][@type='android.widget.TextView'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("setDayColors", "(Landroid/widget/TextView;III)V", "")]
		public static unsafe void SetDayColors (global::Android.Widget.TextView textView, int textColor, int typeface, int background)
		{
			const string __id = "setDayColors.(Landroid/widget/TextView;III)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((textView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) textView).Handle);
				__args [1] = new JniArgumentValue (textColor);
				__args [2] = new JniArgumentValue (typeface);
				__args [3] = new JniArgumentValue (background);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DayColorsUtils']/method[@name='setSelectedDayColors' and count(parameter)=2 and parameter[1][@type='android.widget.TextView'] and parameter[2][@type='com.applandeo.materialcalendarview.utils.CalendarProperties']]"
		[Register ("setSelectedDayColors", "(Landroid/widget/TextView;Lcom/applandeo/materialcalendarview/utils/CalendarProperties;)V", "")]
		public static unsafe void SetSelectedDayColors (global::Android.Widget.TextView dayLabel, global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties calendarProperties)
		{
			const string __id = "setSelectedDayColors.(Landroid/widget/TextView;Lcom/applandeo/materialcalendarview/utils/CalendarProperties;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dayLabel == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dayLabel).Handle);
				__args [1] = new JniArgumentValue ((calendarProperties == null) ? IntPtr.Zero : ((global::Java.Lang.Object) calendarProperties).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
