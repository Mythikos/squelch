using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Applandeo.Materialcalendarview.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DateUtils']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/utils/DateUtils", DoNotGenerateAcw=true)]
	public partial class DateUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/applandeo/materialcalendarview/utils/DateUtils", typeof (DateUtils));
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

		protected DateUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DateUtils']/constructor[@name='DateUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DateUtils ()
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

		public static unsafe global::Java.Util.Calendar Calendar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DateUtils']/method[@name='getCalendar' and count(parameter)=0]"
			[Register ("getCalendar", "()Ljava/util/Calendar;", "")]
			get {
				const string __id = "getCalendar.()Ljava/util/Calendar;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DateUtils']/method[@name='getMonthAndYearDate' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.util.Calendar']]"
		[Register ("getMonthAndYearDate", "(Landroid/content/Context;Ljava/util/Calendar;)Ljava/lang/String;", "")]
		public static unsafe string GetMonthAndYearDate (global::Android.Content.Context context, global::Java.Util.Calendar calendar)
		{
			const string __id = "getMonthAndYearDate.(Landroid/content/Context;Ljava/util/Calendar;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((calendar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) calendar).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DateUtils']/method[@name='getMonthsBetweenDates' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='java.util.Calendar']]"
		[Register ("getMonthsBetweenDates", "(Ljava/util/Calendar;Ljava/util/Calendar;)I", "")]
		public static unsafe int GetMonthsBetweenDates (global::Java.Util.Calendar startCalendar, global::Java.Util.Calendar endCalendar)
		{
			const string __id = "getMonthsBetweenDates.(Ljava/util/Calendar;Ljava/util/Calendar;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((startCalendar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) startCalendar).Handle);
				__args [1] = new JniArgumentValue ((endCalendar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) endCalendar).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DateUtils']/method[@name='isFullDatesRange' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.util.Calendar&gt;']]"
		[Register ("isFullDatesRange", "(Ljava/util/List;)Z", "")]
		public static unsafe bool IsFullDatesRange (global::System.Collections.Generic.IList<global::Java.Util.Calendar> days)
		{
			const string __id = "isFullDatesRange.(Ljava/util/List;)Z";
			IntPtr native_days = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.ToLocalJniHandle (days);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_days);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_days);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DateUtils']/method[@name='isMonthAfter' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='java.util.Calendar']]"
		[Register ("isMonthAfter", "(Ljava/util/Calendar;Ljava/util/Calendar;)Z", "")]
		public static unsafe bool IsMonthAfter (global::Java.Util.Calendar firstCalendar, global::Java.Util.Calendar secondCalendar)
		{
			const string __id = "isMonthAfter.(Ljava/util/Calendar;Ljava/util/Calendar;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((firstCalendar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) firstCalendar).Handle);
				__args [1] = new JniArgumentValue ((secondCalendar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) secondCalendar).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DateUtils']/method[@name='isMonthBefore' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='java.util.Calendar']]"
		[Register ("isMonthBefore", "(Ljava/util/Calendar;Ljava/util/Calendar;)Z", "")]
		public static unsafe bool IsMonthBefore (global::Java.Util.Calendar firstCalendar, global::Java.Util.Calendar secondCalendar)
		{
			const string __id = "isMonthBefore.(Ljava/util/Calendar;Ljava/util/Calendar;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((firstCalendar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) firstCalendar).Handle);
				__args [1] = new JniArgumentValue ((secondCalendar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) secondCalendar).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='DateUtils']/method[@name='setMidnight' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register ("setMidnight", "(Ljava/util/Calendar;)V", "")]
		public static unsafe void SetMidnight (global::Java.Util.Calendar calendar)
		{
			const string __id = "setMidnight.(Ljava/util/Calendar;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((calendar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) calendar).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
