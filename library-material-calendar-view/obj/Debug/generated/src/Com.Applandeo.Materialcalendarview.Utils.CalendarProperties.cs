using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Applandeo.Materialcalendarview.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/utils/CalendarProperties", DoNotGenerateAcw=true)]
	public partial class CalendarProperties : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/field[@name='CALENDAR_SIZE']"
		[Register ("CALENDAR_SIZE")]
		public const int CalendarSize = (int) 2401;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/field[@name='FIRST_VISIBLE_PAGE']"
		[Register ("FIRST_VISIBLE_PAGE")]
		public const int FirstVisiblePage = (int) 1200;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/applandeo/materialcalendarview/utils/CalendarProperties", typeof (CalendarProperties));
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

		protected CalendarProperties (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/constructor[@name='CalendarProperties' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CalendarProperties (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getAbbreviationsBarColor;
#pragma warning disable 0169
		static Delegate GetGetAbbreviationsBarColorHandler ()
		{
			if (cb_getAbbreviationsBarColor == null)
				cb_getAbbreviationsBarColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAbbreviationsBarColor);
			return cb_getAbbreviationsBarColor;
		}

		static int n_GetAbbreviationsBarColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AbbreviationsBarColor;
		}
#pragma warning restore 0169

		static Delegate cb_setAbbreviationsBarColor_I;
#pragma warning disable 0169
		static Delegate GetSetAbbreviationsBarColor_IHandler ()
		{
			if (cb_setAbbreviationsBarColor_I == null)
				cb_setAbbreviationsBarColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAbbreviationsBarColor_I);
			return cb_setAbbreviationsBarColor_I;
		}

		static void n_SetAbbreviationsBarColor_I (IntPtr jnienv, IntPtr native__this, int abbreviationsBarColor)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AbbreviationsBarColor = abbreviationsBarColor;
		}
#pragma warning restore 0169

		public virtual unsafe int AbbreviationsBarColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getAbbreviationsBarColor' and count(parameter)=0]"
			[Register ("getAbbreviationsBarColor", "()I", "GetGetAbbreviationsBarColorHandler")]
			get {
				const string __id = "getAbbreviationsBarColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setAbbreviationsBarColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAbbreviationsBarColor", "(I)V", "GetSetAbbreviationsBarColor_IHandler")]
			set {
				const string __id = "setAbbreviationsBarColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAbbreviationsBarVisibility;
#pragma warning disable 0169
		static Delegate GetGetAbbreviationsBarVisibilityHandler ()
		{
			if (cb_getAbbreviationsBarVisibility == null)
				cb_getAbbreviationsBarVisibility = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAbbreviationsBarVisibility);
			return cb_getAbbreviationsBarVisibility;
		}

		static int n_GetAbbreviationsBarVisibility (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AbbreviationsBarVisibility;
		}
#pragma warning restore 0169

		static Delegate cb_setAbbreviationsBarVisibility_I;
#pragma warning disable 0169
		static Delegate GetSetAbbreviationsBarVisibility_IHandler ()
		{
			if (cb_setAbbreviationsBarVisibility_I == null)
				cb_setAbbreviationsBarVisibility_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAbbreviationsBarVisibility_I);
			return cb_setAbbreviationsBarVisibility_I;
		}

		static void n_SetAbbreviationsBarVisibility_I (IntPtr jnienv, IntPtr native__this, int abbreviationsBarVisbility)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AbbreviationsBarVisibility = abbreviationsBarVisbility;
		}
#pragma warning restore 0169

		public virtual unsafe int AbbreviationsBarVisibility {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getAbbreviationsBarVisibility' and count(parameter)=0]"
			[Register ("getAbbreviationsBarVisibility", "()I", "GetGetAbbreviationsBarVisibilityHandler")]
			get {
				const string __id = "getAbbreviationsBarVisibility.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setAbbreviationsBarVisibility' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAbbreviationsBarVisibility", "(I)V", "GetSetAbbreviationsBarVisibility_IHandler")]
			set {
				const string __id = "setAbbreviationsBarVisibility.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAbbreviationsLabelsColor;
#pragma warning disable 0169
		static Delegate GetGetAbbreviationsLabelsColorHandler ()
		{
			if (cb_getAbbreviationsLabelsColor == null)
				cb_getAbbreviationsLabelsColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAbbreviationsLabelsColor);
			return cb_getAbbreviationsLabelsColor;
		}

		static int n_GetAbbreviationsLabelsColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AbbreviationsLabelsColor;
		}
#pragma warning restore 0169

		static Delegate cb_setAbbreviationsLabelsColor_I;
#pragma warning disable 0169
		static Delegate GetSetAbbreviationsLabelsColor_IHandler ()
		{
			if (cb_setAbbreviationsLabelsColor_I == null)
				cb_setAbbreviationsLabelsColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAbbreviationsLabelsColor_I);
			return cb_setAbbreviationsLabelsColor_I;
		}

		static void n_SetAbbreviationsLabelsColor_I (IntPtr jnienv, IntPtr native__this, int abbreviationsLabelsColor)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AbbreviationsLabelsColor = abbreviationsLabelsColor;
		}
#pragma warning restore 0169

		public virtual unsafe int AbbreviationsLabelsColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getAbbreviationsLabelsColor' and count(parameter)=0]"
			[Register ("getAbbreviationsLabelsColor", "()I", "GetGetAbbreviationsLabelsColorHandler")]
			get {
				const string __id = "getAbbreviationsLabelsColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setAbbreviationsLabelsColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAbbreviationsLabelsColor", "(I)V", "GetSetAbbreviationsLabelsColor_IHandler")]
			set {
				const string __id = "setAbbreviationsLabelsColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAnotherMonthsDaysLabelsColor;
#pragma warning disable 0169
		static Delegate GetGetAnotherMonthsDaysLabelsColorHandler ()
		{
			if (cb_getAnotherMonthsDaysLabelsColor == null)
				cb_getAnotherMonthsDaysLabelsColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAnotherMonthsDaysLabelsColor);
			return cb_getAnotherMonthsDaysLabelsColor;
		}

		static int n_GetAnotherMonthsDaysLabelsColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AnotherMonthsDaysLabelsColor;
		}
#pragma warning restore 0169

		static Delegate cb_setAnotherMonthsDaysLabelsColor_I;
#pragma warning disable 0169
		static Delegate GetSetAnotherMonthsDaysLabelsColor_IHandler ()
		{
			if (cb_setAnotherMonthsDaysLabelsColor_I == null)
				cb_setAnotherMonthsDaysLabelsColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAnotherMonthsDaysLabelsColor_I);
			return cb_setAnotherMonthsDaysLabelsColor_I;
		}

		static void n_SetAnotherMonthsDaysLabelsColor_I (IntPtr jnienv, IntPtr native__this, int anotherMonthsDaysLabelsColor)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AnotherMonthsDaysLabelsColor = anotherMonthsDaysLabelsColor;
		}
#pragma warning restore 0169

		public virtual unsafe int AnotherMonthsDaysLabelsColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getAnotherMonthsDaysLabelsColor' and count(parameter)=0]"
			[Register ("getAnotherMonthsDaysLabelsColor", "()I", "GetGetAnotherMonthsDaysLabelsColorHandler")]
			get {
				const string __id = "getAnotherMonthsDaysLabelsColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setAnotherMonthsDaysLabelsColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAnotherMonthsDaysLabelsColor", "(I)V", "GetSetAnotherMonthsDaysLabelsColor_IHandler")]
			set {
				const string __id = "setAnotherMonthsDaysLabelsColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCalendar;
#pragma warning disable 0169
		static Delegate GetGetCalendarHandler ()
		{
			if (cb_getCalendar == null)
				cb_getCalendar = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCalendar);
			return cb_getCalendar;
		}

		static IntPtr n_GetCalendar (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Calendar);
		}
#pragma warning restore 0169

		static Delegate cb_setCalendar_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetSetCalendar_Ljava_util_Calendar_Handler ()
		{
			if (cb_setCalendar_Ljava_util_Calendar_ == null)
				cb_setCalendar_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCalendar_Ljava_util_Calendar_);
			return cb_setCalendar_Ljava_util_Calendar_;
		}

		static void n_SetCalendar_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_calendar)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			__this.Calendar = calendar;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Calendar Calendar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getCalendar' and count(parameter)=0]"
			[Register ("getCalendar", "()Ljava/util/Calendar;", "GetGetCalendarHandler")]
			get {
				const string __id = "getCalendar.()Ljava/util/Calendar;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setCalendar' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
			[Register ("setCalendar", "(Ljava/util/Calendar;)V", "GetSetCalendar_Ljava_util_Calendar_Handler")]
			set {
				const string __id = "setCalendar.(Ljava/util/Calendar;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCalendarType;
#pragma warning disable 0169
		static Delegate GetGetCalendarTypeHandler ()
		{
			if (cb_getCalendarType == null)
				cb_getCalendarType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCalendarType);
			return cb_getCalendarType;
		}

		static int n_GetCalendarType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CalendarType;
		}
#pragma warning restore 0169

		static Delegate cb_setCalendarType_I;
#pragma warning disable 0169
		static Delegate GetSetCalendarType_IHandler ()
		{
			if (cb_setCalendarType_I == null)
				cb_setCalendarType_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCalendarType_I);
			return cb_setCalendarType_I;
		}

		static void n_SetCalendarType_I (IntPtr jnienv, IntPtr native__this, int calendarType)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalendarType = calendarType;
		}
#pragma warning restore 0169

		public virtual unsafe int CalendarType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getCalendarType' and count(parameter)=0]"
			[Register ("getCalendarType", "()I", "GetGetCalendarTypeHandler")]
			get {
				const string __id = "getCalendarType.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setCalendarType' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCalendarType", "(I)V", "GetSetCalendarType_IHandler")]
			set {
				const string __id = "setCalendarType.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDaysLabelsColor;
#pragma warning disable 0169
		static Delegate GetGetDaysLabelsColorHandler ()
		{
			if (cb_getDaysLabelsColor == null)
				cb_getDaysLabelsColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDaysLabelsColor);
			return cb_getDaysLabelsColor;
		}

		static int n_GetDaysLabelsColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DaysLabelsColor;
		}
#pragma warning restore 0169

		static Delegate cb_setDaysLabelsColor_I;
#pragma warning disable 0169
		static Delegate GetSetDaysLabelsColor_IHandler ()
		{
			if (cb_setDaysLabelsColor_I == null)
				cb_setDaysLabelsColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDaysLabelsColor_I);
			return cb_setDaysLabelsColor_I;
		}

		static void n_SetDaysLabelsColor_I (IntPtr jnienv, IntPtr native__this, int daysLabelsColor)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DaysLabelsColor = daysLabelsColor;
		}
#pragma warning restore 0169

		public virtual unsafe int DaysLabelsColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getDaysLabelsColor' and count(parameter)=0]"
			[Register ("getDaysLabelsColor", "()I", "GetGetDaysLabelsColorHandler")]
			get {
				const string __id = "getDaysLabelsColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setDaysLabelsColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDaysLabelsColor", "(I)V", "GetSetDaysLabelsColor_IHandler")]
			set {
				const string __id = "setDaysLabelsColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDialogButtonsColor;
#pragma warning disable 0169
		static Delegate GetGetDialogButtonsColorHandler ()
		{
			if (cb_getDialogButtonsColor == null)
				cb_getDialogButtonsColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDialogButtonsColor);
			return cb_getDialogButtonsColor;
		}

		static int n_GetDialogButtonsColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DialogButtonsColor;
		}
#pragma warning restore 0169

		static Delegate cb_setDialogButtonsColor_I;
#pragma warning disable 0169
		static Delegate GetSetDialogButtonsColor_IHandler ()
		{
			if (cb_setDialogButtonsColor_I == null)
				cb_setDialogButtonsColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDialogButtonsColor_I);
			return cb_setDialogButtonsColor_I;
		}

		static void n_SetDialogButtonsColor_I (IntPtr jnienv, IntPtr native__this, int dialogButtonsColor)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DialogButtonsColor = dialogButtonsColor;
		}
#pragma warning restore 0169

		public virtual unsafe int DialogButtonsColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getDialogButtonsColor' and count(parameter)=0]"
			[Register ("getDialogButtonsColor", "()I", "GetGetDialogButtonsColorHandler")]
			get {
				const string __id = "getDialogButtonsColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setDialogButtonsColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDialogButtonsColor", "(I)V", "GetSetDialogButtonsColor_IHandler")]
			set {
				const string __id = "setDialogButtonsColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDisabledDays;
#pragma warning disable 0169
		static Delegate GetGetDisabledDaysHandler ()
		{
			if (cb_getDisabledDays == null)
				cb_getDisabledDays = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisabledDays);
			return cb_getDisabledDays;
		}

		static IntPtr n_GetDisabledDays (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Util.Calendar>.ToLocalJniHandle (__this.DisabledDays);
		}
#pragma warning restore 0169

		static Delegate cb_setDisabledDays_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetDisabledDays_Ljava_util_List_Handler ()
		{
			if (cb_setDisabledDays_Ljava_util_List_ == null)
				cb_setDisabledDays_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDisabledDays_Ljava_util_List_);
			return cb_setDisabledDays_Ljava_util_List_;
		}

		static void n_SetDisabledDays_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_disabledDays)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var disabledDays = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.FromJniHandle (native_disabledDays, JniHandleOwnership.DoNotTransfer);
			__this.DisabledDays = disabledDays;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Util.Calendar> DisabledDays {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getDisabledDays' and count(parameter)=0]"
			[Register ("getDisabledDays", "()Ljava/util/List;", "GetGetDisabledDaysHandler")]
			get {
				const string __id = "getDisabledDays.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Java.Util.Calendar>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setDisabledDays' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.util.Calendar&gt;']]"
			[Register ("setDisabledDays", "(Ljava/util/List;)V", "GetSetDisabledDays_Ljava_util_List_Handler")]
			set {
				const string __id = "setDisabledDays.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getDisabledDaysLabelsColor;
#pragma warning disable 0169
		static Delegate GetGetDisabledDaysLabelsColorHandler ()
		{
			if (cb_getDisabledDaysLabelsColor == null)
				cb_getDisabledDaysLabelsColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDisabledDaysLabelsColor);
			return cb_getDisabledDaysLabelsColor;
		}

		static int n_GetDisabledDaysLabelsColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DisabledDaysLabelsColor;
		}
#pragma warning restore 0169

		static Delegate cb_setDisabledDaysLabelsColor_I;
#pragma warning disable 0169
		static Delegate GetSetDisabledDaysLabelsColor_IHandler ()
		{
			if (cb_setDisabledDaysLabelsColor_I == null)
				cb_setDisabledDaysLabelsColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDisabledDaysLabelsColor_I);
			return cb_setDisabledDaysLabelsColor_I;
		}

		static void n_SetDisabledDaysLabelsColor_I (IntPtr jnienv, IntPtr native__this, int disabledDaysLabelsColor)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisabledDaysLabelsColor = disabledDaysLabelsColor;
		}
#pragma warning restore 0169

		public virtual unsafe int DisabledDaysLabelsColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getDisabledDaysLabelsColor' and count(parameter)=0]"
			[Register ("getDisabledDaysLabelsColor", "()I", "GetGetDisabledDaysLabelsColorHandler")]
			get {
				const string __id = "getDisabledDaysLabelsColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setDisabledDaysLabelsColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDisabledDaysLabelsColor", "(I)V", "GetSetDisabledDaysLabelsColor_IHandler")]
			set {
				const string __id = "setDisabledDaysLabelsColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEventDays;
#pragma warning disable 0169
		static Delegate GetGetEventDaysHandler ()
		{
			if (cb_getEventDays == null)
				cb_getEventDays = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEventDays);
			return cb_getEventDays;
		}

		static IntPtr n_GetEventDays (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applandeo.Materialcalendarview.EventDay>.ToLocalJniHandle (__this.EventDays);
		}
#pragma warning restore 0169

		static Delegate cb_setEventDays_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetEventDays_Ljava_util_List_Handler ()
		{
			if (cb_setEventDays_Ljava_util_List_ == null)
				cb_setEventDays_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEventDays_Ljava_util_List_);
			return cb_setEventDays_Ljava_util_List_;
		}

		static void n_SetEventDays_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventDays)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var eventDays = global::Android.Runtime.JavaList<global::Com.Applandeo.Materialcalendarview.EventDay>.FromJniHandle (native_eventDays, JniHandleOwnership.DoNotTransfer);
			__this.EventDays = eventDays;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applandeo.Materialcalendarview.EventDay> EventDays {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getEventDays' and count(parameter)=0]"
			[Register ("getEventDays", "()Ljava/util/List;", "GetGetEventDaysHandler")]
			get {
				const string __id = "getEventDays.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Applandeo.Materialcalendarview.EventDay>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setEventDays' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applandeo.materialcalendarview.EventDay&gt;']]"
			[Register ("setEventDays", "(Ljava/util/List;)V", "GetSetEventDays_Ljava_util_List_Handler")]
			set {
				const string __id = "setEventDays.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Com.Applandeo.Materialcalendarview.EventDay>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getEventsEnabled;
#pragma warning disable 0169
		static Delegate GetGetEventsEnabledHandler ()
		{
			if (cb_getEventsEnabled == null)
				cb_getEventsEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetEventsEnabled);
			return cb_getEventsEnabled;
		}

		static bool n_GetEventsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EventsEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setEventsEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetEventsEnabled_ZHandler ()
		{
			if (cb_setEventsEnabled_Z == null)
				cb_setEventsEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEventsEnabled_Z);
			return cb_setEventsEnabled_Z;
		}

		static void n_SetEventsEnabled_Z (IntPtr jnienv, IntPtr native__this, bool eventsEnabled)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EventsEnabled = eventsEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool EventsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getEventsEnabled' and count(parameter)=0]"
			[Register ("getEventsEnabled", "()Z", "GetGetEventsEnabledHandler")]
			get {
				const string __id = "getEventsEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setEventsEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEventsEnabled", "(Z)V", "GetSetEventsEnabled_ZHandler")]
			set {
				const string __id = "setEventsEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFirstPageCalendarDate;
#pragma warning disable 0169
		static Delegate GetGetFirstPageCalendarDateHandler ()
		{
			if (cb_getFirstPageCalendarDate == null)
				cb_getFirstPageCalendarDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFirstPageCalendarDate);
			return cb_getFirstPageCalendarDate;
		}

		static IntPtr n_GetFirstPageCalendarDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FirstPageCalendarDate);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Calendar FirstPageCalendarDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getFirstPageCalendarDate' and count(parameter)=0]"
			[Register ("getFirstPageCalendarDate", "()Ljava/util/Calendar;", "GetGetFirstPageCalendarDateHandler")]
			get {
				const string __id = "getFirstPageCalendarDate.()Ljava/util/Calendar;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getForwardButtonSrc;
#pragma warning disable 0169
		static Delegate GetGetForwardButtonSrcHandler ()
		{
			if (cb_getForwardButtonSrc == null)
				cb_getForwardButtonSrc = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetForwardButtonSrc);
			return cb_getForwardButtonSrc;
		}

		static IntPtr n_GetForwardButtonSrc (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ForwardButtonSrc);
		}
#pragma warning restore 0169

		static Delegate cb_setForwardButtonSrc_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetForwardButtonSrc_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setForwardButtonSrc_Landroid_graphics_drawable_Drawable_ == null)
				cb_setForwardButtonSrc_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetForwardButtonSrc_Landroid_graphics_drawable_Drawable_);
			return cb_setForwardButtonSrc_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetForwardButtonSrc_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_forwardButtonSrc)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable forwardButtonSrc = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_forwardButtonSrc, JniHandleOwnership.DoNotTransfer);
			__this.ForwardButtonSrc = forwardButtonSrc;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Drawables.Drawable ForwardButtonSrc {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getForwardButtonSrc' and count(parameter)=0]"
			[Register ("getForwardButtonSrc", "()Landroid/graphics/drawable/Drawable;", "GetGetForwardButtonSrcHandler")]
			get {
				const string __id = "getForwardButtonSrc.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setForwardButtonSrc' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setForwardButtonSrc", "(Landroid/graphics/drawable/Drawable;)V", "GetSetForwardButtonSrc_Landroid_graphics_drawable_Drawable_Handler")]
			set {
				const string __id = "setForwardButtonSrc.(Landroid/graphics/drawable/Drawable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHeaderColor;
#pragma warning disable 0169
		static Delegate GetGetHeaderColorHandler ()
		{
			if (cb_getHeaderColor == null)
				cb_getHeaderColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeaderColor);
			return cb_getHeaderColor;
		}

		static int n_GetHeaderColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeaderColor;
		}
#pragma warning restore 0169

		static Delegate cb_setHeaderColor_I;
#pragma warning disable 0169
		static Delegate GetSetHeaderColor_IHandler ()
		{
			if (cb_setHeaderColor_I == null)
				cb_setHeaderColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHeaderColor_I);
			return cb_setHeaderColor_I;
		}

		static void n_SetHeaderColor_I (IntPtr jnienv, IntPtr native__this, int headerColor)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HeaderColor = headerColor;
		}
#pragma warning restore 0169

		public virtual unsafe int HeaderColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getHeaderColor' and count(parameter)=0]"
			[Register ("getHeaderColor", "()I", "GetGetHeaderColorHandler")]
			get {
				const string __id = "getHeaderColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setHeaderColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHeaderColor", "(I)V", "GetSetHeaderColor_IHandler")]
			set {
				const string __id = "setHeaderColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHeaderLabelColor;
#pragma warning disable 0169
		static Delegate GetGetHeaderLabelColorHandler ()
		{
			if (cb_getHeaderLabelColor == null)
				cb_getHeaderLabelColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeaderLabelColor);
			return cb_getHeaderLabelColor;
		}

		static int n_GetHeaderLabelColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeaderLabelColor;
		}
#pragma warning restore 0169

		static Delegate cb_setHeaderLabelColor_I;
#pragma warning disable 0169
		static Delegate GetSetHeaderLabelColor_IHandler ()
		{
			if (cb_setHeaderLabelColor_I == null)
				cb_setHeaderLabelColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHeaderLabelColor_I);
			return cb_setHeaderLabelColor_I;
		}

		static void n_SetHeaderLabelColor_I (IntPtr jnienv, IntPtr native__this, int headerLabelColor)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HeaderLabelColor = headerLabelColor;
		}
#pragma warning restore 0169

		public virtual unsafe int HeaderLabelColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getHeaderLabelColor' and count(parameter)=0]"
			[Register ("getHeaderLabelColor", "()I", "GetGetHeaderLabelColorHandler")]
			get {
				const string __id = "getHeaderLabelColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setHeaderLabelColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHeaderLabelColor", "(I)V", "GetSetHeaderLabelColor_IHandler")]
			set {
				const string __id = "setHeaderLabelColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHeaderVisibility;
#pragma warning disable 0169
		static Delegate GetGetHeaderVisibilityHandler ()
		{
			if (cb_getHeaderVisibility == null)
				cb_getHeaderVisibility = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeaderVisibility);
			return cb_getHeaderVisibility;
		}

		static int n_GetHeaderVisibility (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HeaderVisibility;
		}
#pragma warning restore 0169

		static Delegate cb_setHeaderVisibility_I;
#pragma warning disable 0169
		static Delegate GetSetHeaderVisibility_IHandler ()
		{
			if (cb_setHeaderVisibility_I == null)
				cb_setHeaderVisibility_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHeaderVisibility_I);
			return cb_setHeaderVisibility_I;
		}

		static void n_SetHeaderVisibility_I (IntPtr jnienv, IntPtr native__this, int headerVisibility)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HeaderVisibility = headerVisibility;
		}
#pragma warning restore 0169

		public virtual unsafe int HeaderVisibility {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getHeaderVisibility' and count(parameter)=0]"
			[Register ("getHeaderVisibility", "()I", "GetGetHeaderVisibilityHandler")]
			get {
				const string __id = "getHeaderVisibility.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setHeaderVisibility' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHeaderVisibility", "(I)V", "GetSetHeaderVisibility_IHandler")]
			set {
				const string __id = "setHeaderVisibility.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHighlightedDays;
#pragma warning disable 0169
		static Delegate GetGetHighlightedDaysHandler ()
		{
			if (cb_getHighlightedDays == null)
				cb_getHighlightedDays = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHighlightedDays);
			return cb_getHighlightedDays;
		}

		static IntPtr n_GetHighlightedDays (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Util.Calendar>.ToLocalJniHandle (__this.HighlightedDays);
		}
#pragma warning restore 0169

		static Delegate cb_setHighlightedDays_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetHighlightedDays_Ljava_util_List_Handler ()
		{
			if (cb_setHighlightedDays_Ljava_util_List_ == null)
				cb_setHighlightedDays_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHighlightedDays_Ljava_util_List_);
			return cb_setHighlightedDays_Ljava_util_List_;
		}

		static void n_SetHighlightedDays_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_highlightedDays)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var highlightedDays = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.FromJniHandle (native_highlightedDays, JniHandleOwnership.DoNotTransfer);
			__this.HighlightedDays = highlightedDays;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Util.Calendar> HighlightedDays {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getHighlightedDays' and count(parameter)=0]"
			[Register ("getHighlightedDays", "()Ljava/util/List;", "GetGetHighlightedDaysHandler")]
			get {
				const string __id = "getHighlightedDays.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Java.Util.Calendar>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setHighlightedDays' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.util.Calendar&gt;']]"
			[Register ("setHighlightedDays", "(Ljava/util/List;)V", "GetSetHighlightedDays_Ljava_util_List_Handler")]
			set {
				const string __id = "setHighlightedDays.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getHighlightedDaysLabelsColor;
#pragma warning disable 0169
		static Delegate GetGetHighlightedDaysLabelsColorHandler ()
		{
			if (cb_getHighlightedDaysLabelsColor == null)
				cb_getHighlightedDaysLabelsColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHighlightedDaysLabelsColor);
			return cb_getHighlightedDaysLabelsColor;
		}

		static int n_GetHighlightedDaysLabelsColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighlightedDaysLabelsColor;
		}
#pragma warning restore 0169

		static Delegate cb_setHighlightedDaysLabelsColor_I;
#pragma warning disable 0169
		static Delegate GetSetHighlightedDaysLabelsColor_IHandler ()
		{
			if (cb_setHighlightedDaysLabelsColor_I == null)
				cb_setHighlightedDaysLabelsColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHighlightedDaysLabelsColor_I);
			return cb_setHighlightedDaysLabelsColor_I;
		}

		static void n_SetHighlightedDaysLabelsColor_I (IntPtr jnienv, IntPtr native__this, int highlightedDaysLabelsColor)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighlightedDaysLabelsColor = highlightedDaysLabelsColor;
		}
#pragma warning restore 0169

		public virtual unsafe int HighlightedDaysLabelsColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getHighlightedDaysLabelsColor' and count(parameter)=0]"
			[Register ("getHighlightedDaysLabelsColor", "()I", "GetGetHighlightedDaysLabelsColorHandler")]
			get {
				const string __id = "getHighlightedDaysLabelsColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setHighlightedDaysLabelsColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHighlightedDaysLabelsColor", "(I)V", "GetSetHighlightedDaysLabelsColor_IHandler")]
			set {
				const string __id = "setHighlightedDaysLabelsColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getItemLayoutResource;
#pragma warning disable 0169
		static Delegate GetGetItemLayoutResourceHandler ()
		{
			if (cb_getItemLayoutResource == null)
				cb_getItemLayoutResource = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetItemLayoutResource);
			return cb_getItemLayoutResource;
		}

		static int n_GetItemLayoutResource (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ItemLayoutResource;
		}
#pragma warning restore 0169

		static Delegate cb_setItemLayoutResource_I;
#pragma warning disable 0169
		static Delegate GetSetItemLayoutResource_IHandler ()
		{
			if (cb_setItemLayoutResource_I == null)
				cb_setItemLayoutResource_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetItemLayoutResource_I);
			return cb_setItemLayoutResource_I;
		}

		static void n_SetItemLayoutResource_I (IntPtr jnienv, IntPtr native__this, int itemLayoutResource)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ItemLayoutResource = itemLayoutResource;
		}
#pragma warning restore 0169

		public virtual unsafe int ItemLayoutResource {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getItemLayoutResource' and count(parameter)=0]"
			[Register ("getItemLayoutResource", "()I", "GetGetItemLayoutResourceHandler")]
			get {
				const string __id = "getItemLayoutResource.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setItemLayoutResource' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setItemLayoutResource", "(I)V", "GetSetItemLayoutResource_IHandler")]
			set {
				const string __id = "setItemLayoutResource.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaximumDate;
#pragma warning disable 0169
		static Delegate GetGetMaximumDateHandler ()
		{
			if (cb_getMaximumDate == null)
				cb_getMaximumDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMaximumDate);
			return cb_getMaximumDate;
		}

		static IntPtr n_GetMaximumDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MaximumDate);
		}
#pragma warning restore 0169

		static Delegate cb_setMaximumDate_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetSetMaximumDate_Ljava_util_Calendar_Handler ()
		{
			if (cb_setMaximumDate_Ljava_util_Calendar_ == null)
				cb_setMaximumDate_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMaximumDate_Ljava_util_Calendar_);
			return cb_setMaximumDate_Ljava_util_Calendar_;
		}

		static void n_SetMaximumDate_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_maximumDate)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar maximumDate = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_maximumDate, JniHandleOwnership.DoNotTransfer);
			__this.MaximumDate = maximumDate;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Calendar MaximumDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getMaximumDate' and count(parameter)=0]"
			[Register ("getMaximumDate", "()Ljava/util/Calendar;", "GetGetMaximumDateHandler")]
			get {
				const string __id = "getMaximumDate.()Ljava/util/Calendar;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setMaximumDate' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
			[Register ("setMaximumDate", "(Ljava/util/Calendar;)V", "GetSetMaximumDate_Ljava_util_Calendar_Handler")]
			set {
				const string __id = "setMaximumDate.(Ljava/util/Calendar;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaximumDaysRange;
#pragma warning disable 0169
		static Delegate GetGetMaximumDaysRangeHandler ()
		{
			if (cb_getMaximumDaysRange == null)
				cb_getMaximumDaysRange = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaximumDaysRange);
			return cb_getMaximumDaysRange;
		}

		static int n_GetMaximumDaysRange (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaximumDaysRange;
		}
#pragma warning restore 0169

		static Delegate cb_setMaximumDaysRange_I;
#pragma warning disable 0169
		static Delegate GetSetMaximumDaysRange_IHandler ()
		{
			if (cb_setMaximumDaysRange_I == null)
				cb_setMaximumDaysRange_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaximumDaysRange_I);
			return cb_setMaximumDaysRange_I;
		}

		static void n_SetMaximumDaysRange_I (IntPtr jnienv, IntPtr native__this, int maximumDaysRange)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaximumDaysRange = maximumDaysRange;
		}
#pragma warning restore 0169

		public virtual unsafe int MaximumDaysRange {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getMaximumDaysRange' and count(parameter)=0]"
			[Register ("getMaximumDaysRange", "()I", "GetGetMaximumDaysRangeHandler")]
			get {
				const string __id = "getMaximumDaysRange.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setMaximumDaysRange' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setMaximumDaysRange", "(I)V", "GetSetMaximumDaysRange_IHandler")]
			set {
				const string __id = "setMaximumDaysRange.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMinimumDate;
#pragma warning disable 0169
		static Delegate GetGetMinimumDateHandler ()
		{
			if (cb_getMinimumDate == null)
				cb_getMinimumDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMinimumDate);
			return cb_getMinimumDate;
		}

		static IntPtr n_GetMinimumDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MinimumDate);
		}
#pragma warning restore 0169

		static Delegate cb_setMinimumDate_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetSetMinimumDate_Ljava_util_Calendar_Handler ()
		{
			if (cb_setMinimumDate_Ljava_util_Calendar_ == null)
				cb_setMinimumDate_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMinimumDate_Ljava_util_Calendar_);
			return cb_setMinimumDate_Ljava_util_Calendar_;
		}

		static void n_SetMinimumDate_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_minimumDate)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar minimumDate = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_minimumDate, JniHandleOwnership.DoNotTransfer);
			__this.MinimumDate = minimumDate;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Calendar MinimumDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getMinimumDate' and count(parameter)=0]"
			[Register ("getMinimumDate", "()Ljava/util/Calendar;", "GetGetMinimumDateHandler")]
			get {
				const string __id = "getMinimumDate.()Ljava/util/Calendar;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setMinimumDate' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
			[Register ("setMinimumDate", "(Ljava/util/Calendar;)V", "GetSetMinimumDate_Ljava_util_Calendar_Handler")]
			set {
				const string __id = "setMinimumDate.(Ljava/util/Calendar;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNavigationVisibility;
#pragma warning disable 0169
		static Delegate GetGetNavigationVisibilityHandler ()
		{
			if (cb_getNavigationVisibility == null)
				cb_getNavigationVisibility = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNavigationVisibility);
			return cb_getNavigationVisibility;
		}

		static int n_GetNavigationVisibility (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NavigationVisibility;
		}
#pragma warning restore 0169

		static Delegate cb_setNavigationVisibility_I;
#pragma warning disable 0169
		static Delegate GetSetNavigationVisibility_IHandler ()
		{
			if (cb_setNavigationVisibility_I == null)
				cb_setNavigationVisibility_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNavigationVisibility_I);
			return cb_setNavigationVisibility_I;
		}

		static void n_SetNavigationVisibility_I (IntPtr jnienv, IntPtr native__this, int navigationVisibility)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NavigationVisibility = navigationVisibility;
		}
#pragma warning restore 0169

		public virtual unsafe int NavigationVisibility {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getNavigationVisibility' and count(parameter)=0]"
			[Register ("getNavigationVisibility", "()I", "GetGetNavigationVisibilityHandler")]
			get {
				const string __id = "getNavigationVisibility.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setNavigationVisibility' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNavigationVisibility", "(I)V", "GetSetNavigationVisibility_IHandler")]
			set {
				const string __id = "setNavigationVisibility.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOnDayClickListener;
#pragma warning disable 0169
		static Delegate GetGetOnDayClickListenerHandler ()
		{
			if (cb_getOnDayClickListener == null)
				cb_getOnDayClickListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnDayClickListener);
			return cb_getOnDayClickListener;
		}

		static IntPtr n_GetOnDayClickListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnDayClickListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_;
#pragma warning disable 0169
		static Delegate GetSetOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_Handler ()
		{
			if (cb_setOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_ == null)
				cb_setOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_);
			return cb_setOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_;
		}

		static void n_SetOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onDayClickListener)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener onDayClickListener = (global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener)global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener> (native_onDayClickListener, JniHandleOwnership.DoNotTransfer);
			__this.OnDayClickListener = onDayClickListener;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener OnDayClickListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getOnDayClickListener' and count(parameter)=0]"
			[Register ("getOnDayClickListener", "()Lcom/applandeo/materialcalendarview/listeners/OnDayClickListener;", "GetGetOnDayClickListenerHandler")]
			get {
				const string __id = "getOnDayClickListener.()Lcom/applandeo/materialcalendarview/listeners/OnDayClickListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setOnDayClickListener' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.listeners.OnDayClickListener']]"
			[Register ("setOnDayClickListener", "(Lcom/applandeo/materialcalendarview/listeners/OnDayClickListener;)V", "GetSetOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_Handler")]
			set {
				const string __id = "setOnDayClickListener.(Lcom/applandeo/materialcalendarview/listeners/OnDayClickListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOnForwardPageChangeListener;
#pragma warning disable 0169
		static Delegate GetGetOnForwardPageChangeListenerHandler ()
		{
			if (cb_getOnForwardPageChangeListener == null)
				cb_getOnForwardPageChangeListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnForwardPageChangeListener);
			return cb_getOnForwardPageChangeListener;
		}

		static IntPtr n_GetOnForwardPageChangeListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnForwardPageChangeListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_Handler ()
		{
			if (cb_setOnForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_ == null)
				cb_setOnForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_);
			return cb_setOnForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_;
		}

		static void n_SetOnForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onForwardButtonClickListener)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener onForwardButtonClickListener = (global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener)global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener> (native_onForwardButtonClickListener, JniHandleOwnership.DoNotTransfer);
			__this.OnForwardPageChangeListener = onForwardButtonClickListener;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener OnForwardPageChangeListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getOnForwardPageChangeListener' and count(parameter)=0]"
			[Register ("getOnForwardPageChangeListener", "()Lcom/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListener;", "GetGetOnForwardPageChangeListenerHandler")]
			get {
				const string __id = "getOnForwardPageChangeListener.()Lcom/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setOnForwardPageChangeListener' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.listeners.OnCalendarPageChangeListener']]"
			[Register ("setOnForwardPageChangeListener", "(Lcom/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListener;)V", "GetSetOnForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_Handler")]
			set {
				const string __id = "setOnForwardPageChangeListener.(Lcom/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOnPreviousPageChangeListener;
#pragma warning disable 0169
		static Delegate GetGetOnPreviousPageChangeListenerHandler ()
		{
			if (cb_getOnPreviousPageChangeListener == null)
				cb_getOnPreviousPageChangeListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnPreviousPageChangeListener);
			return cb_getOnPreviousPageChangeListener;
		}

		static IntPtr n_GetOnPreviousPageChangeListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnPreviousPageChangeListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_Handler ()
		{
			if (cb_setOnPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_ == null)
				cb_setOnPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_);
			return cb_setOnPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_;
		}

		static void n_SetOnPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onPreviousButtonClickListener)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener onPreviousButtonClickListener = (global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener)global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener> (native_onPreviousButtonClickListener, JniHandleOwnership.DoNotTransfer);
			__this.OnPreviousPageChangeListener = onPreviousButtonClickListener;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener OnPreviousPageChangeListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getOnPreviousPageChangeListener' and count(parameter)=0]"
			[Register ("getOnPreviousPageChangeListener", "()Lcom/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListener;", "GetGetOnPreviousPageChangeListenerHandler")]
			get {
				const string __id = "getOnPreviousPageChangeListener.()Lcom/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setOnPreviousPageChangeListener' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.listeners.OnCalendarPageChangeListener']]"
			[Register ("setOnPreviousPageChangeListener", "(Lcom/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListener;)V", "GetSetOnPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_Handler")]
			set {
				const string __id = "setOnPreviousPageChangeListener.(Lcom/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOnSelectDateListener;
#pragma warning disable 0169
		static Delegate GetGetOnSelectDateListenerHandler ()
		{
			if (cb_getOnSelectDateListener == null)
				cb_getOnSelectDateListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnSelectDateListener);
			return cb_getOnSelectDateListener;
		}

		static IntPtr n_GetOnSelectDateListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnSelectDateListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnSelectDateListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_;
#pragma warning disable 0169
		static Delegate GetSetOnSelectDateListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_Handler ()
		{
			if (cb_setOnSelectDateListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_ == null)
				cb_setOnSelectDateListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnSelectDateListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_);
			return cb_setOnSelectDateListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_;
		}

		static void n_SetOnSelectDateListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onSelectDateListener)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListener onSelectDateListener = (global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListener)global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListener> (native_onSelectDateListener, JniHandleOwnership.DoNotTransfer);
			__this.OnSelectDateListener = onSelectDateListener;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListener OnSelectDateListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getOnSelectDateListener' and count(parameter)=0]"
			[Register ("getOnSelectDateListener", "()Lcom/applandeo/materialcalendarview/listeners/OnSelectDateListener;", "GetGetOnSelectDateListenerHandler")]
			get {
				const string __id = "getOnSelectDateListener.()Lcom/applandeo/materialcalendarview/listeners/OnSelectDateListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setOnSelectDateListener' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.listeners.OnSelectDateListener']]"
			[Register ("setOnSelectDateListener", "(Lcom/applandeo/materialcalendarview/listeners/OnSelectDateListener;)V", "GetSetOnSelectDateListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectDateListener_Handler")]
			set {
				const string __id = "setOnSelectDateListener.(Lcom/applandeo/materialcalendarview/listeners/OnSelectDateListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOnSelectionAbilityListener;
#pragma warning disable 0169
		static Delegate GetGetOnSelectionAbilityListenerHandler ()
		{
			if (cb_getOnSelectionAbilityListener == null)
				cb_getOnSelectionAbilityListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnSelectionAbilityListener);
			return cb_getOnSelectionAbilityListener;
		}

		static IntPtr n_GetOnSelectionAbilityListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnSelectionAbilityListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnSelectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_;
#pragma warning disable 0169
		static Delegate GetSetOnSelectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_Handler ()
		{
			if (cb_setOnSelectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_ == null)
				cb_setOnSelectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnSelectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_);
			return cb_setOnSelectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_;
		}

		static void n_SetOnSelectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_onSelectionAbilityListener)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListener onSelectionAbilityListener = (global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListener)global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListener> (native_onSelectionAbilityListener, JniHandleOwnership.DoNotTransfer);
			__this.OnSelectionAbilityListener = onSelectionAbilityListener;
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListener OnSelectionAbilityListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getOnSelectionAbilityListener' and count(parameter)=0]"
			[Register ("getOnSelectionAbilityListener", "()Lcom/applandeo/materialcalendarview/listeners/OnSelectionAbilityListener;", "GetGetOnSelectionAbilityListenerHandler")]
			get {
				const string __id = "getOnSelectionAbilityListener.()Lcom/applandeo/materialcalendarview/listeners/OnSelectionAbilityListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setOnSelectionAbilityListener' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.listeners.OnSelectionAbilityListener']]"
			[Register ("setOnSelectionAbilityListener", "(Lcom/applandeo/materialcalendarview/listeners/OnSelectionAbilityListener;)V", "GetSetOnSelectionAbilityListener_Lcom_applandeo_materialcalendarview_listeners_OnSelectionAbilityListener_Handler")]
			set {
				const string __id = "setOnSelectionAbilityListener.(Lcom/applandeo/materialcalendarview/listeners/OnSelectionAbilityListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPagesColor;
#pragma warning disable 0169
		static Delegate GetGetPagesColorHandler ()
		{
			if (cb_getPagesColor == null)
				cb_getPagesColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPagesColor);
			return cb_getPagesColor;
		}

		static int n_GetPagesColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PagesColor;
		}
#pragma warning restore 0169

		static Delegate cb_setPagesColor_I;
#pragma warning disable 0169
		static Delegate GetSetPagesColor_IHandler ()
		{
			if (cb_setPagesColor_I == null)
				cb_setPagesColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPagesColor_I);
			return cb_setPagesColor_I;
		}

		static void n_SetPagesColor_I (IntPtr jnienv, IntPtr native__this, int pagesColor)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PagesColor = pagesColor;
		}
#pragma warning restore 0169

		public virtual unsafe int PagesColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getPagesColor' and count(parameter)=0]"
			[Register ("getPagesColor", "()I", "GetGetPagesColorHandler")]
			get {
				const string __id = "getPagesColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setPagesColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setPagesColor", "(I)V", "GetSetPagesColor_IHandler")]
			set {
				const string __id = "setPagesColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPreviousButtonSrc;
#pragma warning disable 0169
		static Delegate GetGetPreviousButtonSrcHandler ()
		{
			if (cb_getPreviousButtonSrc == null)
				cb_getPreviousButtonSrc = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPreviousButtonSrc);
			return cb_getPreviousButtonSrc;
		}

		static IntPtr n_GetPreviousButtonSrc (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PreviousButtonSrc);
		}
#pragma warning restore 0169

		static Delegate cb_setPreviousButtonSrc_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetPreviousButtonSrc_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setPreviousButtonSrc_Landroid_graphics_drawable_Drawable_ == null)
				cb_setPreviousButtonSrc_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPreviousButtonSrc_Landroid_graphics_drawable_Drawable_);
			return cb_setPreviousButtonSrc_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetPreviousButtonSrc_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_previousButtonSrc)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable previousButtonSrc = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_previousButtonSrc, JniHandleOwnership.DoNotTransfer);
			__this.PreviousButtonSrc = previousButtonSrc;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Drawables.Drawable PreviousButtonSrc {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getPreviousButtonSrc' and count(parameter)=0]"
			[Register ("getPreviousButtonSrc", "()Landroid/graphics/drawable/Drawable;", "GetGetPreviousButtonSrcHandler")]
			get {
				const string __id = "getPreviousButtonSrc.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setPreviousButtonSrc' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setPreviousButtonSrc", "(Landroid/graphics/drawable/Drawable;)V", "GetSetPreviousButtonSrc_Landroid_graphics_drawable_Drawable_Handler")]
			set {
				const string __id = "setPreviousButtonSrc.(Landroid/graphics/drawable/Drawable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedDays;
#pragma warning disable 0169
		static Delegate GetGetSelectedDaysHandler ()
		{
			if (cb_getSelectedDays == null)
				cb_getSelectedDays = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectedDays);
			return cb_getSelectedDays;
		}

		static IntPtr n_GetSelectedDays (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay>.ToLocalJniHandle (__this.SelectedDays);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay> SelectedDays {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getSelectedDays' and count(parameter)=0]"
			[Register ("getSelectedDays", "()Ljava/util/List;", "GetGetSelectedDaysHandler")]
			get {
				const string __id = "getSelectedDays.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectionColor;
#pragma warning disable 0169
		static Delegate GetGetSelectionColorHandler ()
		{
			if (cb_getSelectionColor == null)
				cb_getSelectionColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSelectionColor);
			return cb_getSelectionColor;
		}

		static int n_GetSelectionColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectionColor;
		}
#pragma warning restore 0169

		static Delegate cb_setSelectionColor_I;
#pragma warning disable 0169
		static Delegate GetSetSelectionColor_IHandler ()
		{
			if (cb_setSelectionColor_I == null)
				cb_setSelectionColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelectionColor_I);
			return cb_setSelectionColor_I;
		}

		static void n_SetSelectionColor_I (IntPtr jnienv, IntPtr native__this, int selectionColor)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectionColor = selectionColor;
		}
#pragma warning restore 0169

		public virtual unsafe int SelectionColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getSelectionColor' and count(parameter)=0]"
			[Register ("getSelectionColor", "()I", "GetGetSelectionColorHandler")]
			get {
				const string __id = "getSelectionColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setSelectionColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectionColor", "(I)V", "GetSetSelectionColor_IHandler")]
			set {
				const string __id = "setSelectionColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectionLabelColor;
#pragma warning disable 0169
		static Delegate GetGetSelectionLabelColorHandler ()
		{
			if (cb_getSelectionLabelColor == null)
				cb_getSelectionLabelColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSelectionLabelColor);
			return cb_getSelectionLabelColor;
		}

		static int n_GetSelectionLabelColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectionLabelColor;
		}
#pragma warning restore 0169

		static Delegate cb_setSelectionLabelColor_I;
#pragma warning disable 0169
		static Delegate GetSetSelectionLabelColor_IHandler ()
		{
			if (cb_setSelectionLabelColor_I == null)
				cb_setSelectionLabelColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSelectionLabelColor_I);
			return cb_setSelectionLabelColor_I;
		}

		static void n_SetSelectionLabelColor_I (IntPtr jnienv, IntPtr native__this, int selectionLabelColor)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectionLabelColor = selectionLabelColor;
		}
#pragma warning restore 0169

		public virtual unsafe int SelectionLabelColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getSelectionLabelColor' and count(parameter)=0]"
			[Register ("getSelectionLabelColor", "()I", "GetGetSelectionLabelColorHandler")]
			get {
				const string __id = "getSelectionLabelColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setSelectionLabelColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSelectionLabelColor", "(I)V", "GetSetSelectionLabelColor_IHandler")]
			set {
				const string __id = "setSelectionLabelColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSwipeEnabled;
#pragma warning disable 0169
		static Delegate GetGetSwipeEnabledHandler ()
		{
			if (cb_getSwipeEnabled == null)
				cb_getSwipeEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetSwipeEnabled);
			return cb_getSwipeEnabled;
		}

		static bool n_GetSwipeEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SwipeEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setSwipeEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetSwipeEnabled_ZHandler ()
		{
			if (cb_setSwipeEnabled_Z == null)
				cb_setSwipeEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetSwipeEnabled_Z);
			return cb_setSwipeEnabled_Z;
		}

		static void n_SetSwipeEnabled_Z (IntPtr jnienv, IntPtr native__this, bool swipeEnabled)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SwipeEnabled = swipeEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool SwipeEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getSwipeEnabled' and count(parameter)=0]"
			[Register ("getSwipeEnabled", "()Z", "GetGetSwipeEnabledHandler")]
			get {
				const string __id = "getSwipeEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setSwipeEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setSwipeEnabled", "(Z)V", "GetSetSwipeEnabled_ZHandler")]
			set {
				const string __id = "setSwipeEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTodayColor;
#pragma warning disable 0169
		static Delegate GetGetTodayColorHandler ()
		{
			if (cb_getTodayColor == null)
				cb_getTodayColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTodayColor);
			return cb_getTodayColor;
		}

		static int n_GetTodayColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TodayColor;
		}
#pragma warning restore 0169

		static Delegate cb_setTodayColor_I;
#pragma warning disable 0169
		static Delegate GetSetTodayColor_IHandler ()
		{
			if (cb_setTodayColor_I == null)
				cb_setTodayColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTodayColor_I);
			return cb_setTodayColor_I;
		}

		static void n_SetTodayColor_I (IntPtr jnienv, IntPtr native__this, int todayColor)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TodayColor = todayColor;
		}
#pragma warning restore 0169

		public virtual unsafe int TodayColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getTodayColor' and count(parameter)=0]"
			[Register ("getTodayColor", "()I", "GetGetTodayColorHandler")]
			get {
				const string __id = "getTodayColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setTodayColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTodayColor", "(I)V", "GetSetTodayColor_IHandler")]
			set {
				const string __id = "setTodayColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTodayLabelColor;
#pragma warning disable 0169
		static Delegate GetGetTodayLabelColorHandler ()
		{
			if (cb_getTodayLabelColor == null)
				cb_getTodayLabelColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTodayLabelColor);
			return cb_getTodayLabelColor;
		}

		static int n_GetTodayLabelColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TodayLabelColor;
		}
#pragma warning restore 0169

		static Delegate cb_setTodayLabelColor_I;
#pragma warning disable 0169
		static Delegate GetSetTodayLabelColor_IHandler ()
		{
			if (cb_setTodayLabelColor_I == null)
				cb_setTodayLabelColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTodayLabelColor_I);
			return cb_setTodayLabelColor_I;
		}

		static void n_SetTodayLabelColor_I (IntPtr jnienv, IntPtr native__this, int todayLabelColor)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TodayLabelColor = todayLabelColor;
		}
#pragma warning restore 0169

		public virtual unsafe int TodayLabelColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='getTodayLabelColor' and count(parameter)=0]"
			[Register ("getTodayLabelColor", "()I", "GetGetTodayLabelColorHandler")]
			get {
				const string __id = "getTodayLabelColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setTodayLabelColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTodayLabelColor", "(I)V", "GetSetTodayLabelColor_IHandler")]
			set {
				const string __id = "setTodayLabelColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_setSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_;
#pragma warning disable 0169
		static Delegate GetSetSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_Handler ()
		{
			if (cb_setSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_ == null)
				cb_setSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_);
			return cb_setSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_;
		}

		static void n_SetSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_ (IntPtr jnienv, IntPtr native__this, IntPtr native_selectedDay)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay selectedDay = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay> (native_selectedDay, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectedDay (selectedDay);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setSelectedDay' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.utils.SelectedDay']]"
		[Register ("setSelectedDay", "(Lcom/applandeo/materialcalendarview/utils/SelectedDay;)V", "GetSetSelectedDay_Lcom_applandeo_materialcalendarview_utils_SelectedDay_Handler")]
		public virtual unsafe void SetSelectedDay (global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay selectedDay)
		{
			const string __id = "setSelectedDay.(Lcom/applandeo/materialcalendarview/utils/SelectedDay;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((selectedDay == null) ? IntPtr.Zero : ((global::Java.Lang.Object) selectedDay).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSelectedDay_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetSetSelectedDay_Ljava_util_Calendar_Handler ()
		{
			if (cb_setSelectedDay_Ljava_util_Calendar_ == null)
				cb_setSelectedDay_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSelectedDay_Ljava_util_Calendar_);
			return cb_setSelectedDay_Ljava_util_Calendar_;
		}

		static void n_SetSelectedDay_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_calendar)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectedDay (calendar);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setSelectedDay' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register ("setSelectedDay", "(Ljava/util/Calendar;)V", "GetSetSelectedDay_Ljava_util_Calendar_Handler")]
		public virtual unsafe void SetSelectedDay (global::Java.Util.Calendar calendar)
		{
			const string __id = "setSelectedDay.(Ljava/util/Calendar;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((calendar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) calendar).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSelectedDays_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetSelectedDays_Ljava_util_List_Handler ()
		{
			if (cb_setSelectedDays_Ljava_util_List_ == null)
				cb_setSelectedDays_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSelectedDays_Ljava_util_List_);
			return cb_setSelectedDays_Ljava_util_List_;
		}

		static void n_SetSelectedDays_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_selectedDays)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var selectedDays = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.FromJniHandle (native_selectedDays, JniHandleOwnership.DoNotTransfer);
			__this.SetSelectedDays (selectedDays);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='CalendarProperties']/method[@name='setSelectedDays' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.util.Calendar&gt;']]"
		[Register ("setSelectedDays", "(Ljava/util/List;)V", "GetSetSelectedDays_Ljava_util_List_Handler")]
		public virtual unsafe void SetSelectedDays (global::System.Collections.Generic.IList<global::Java.Util.Calendar> selectedDays)
		{
			const string __id = "setSelectedDays.(Ljava/util/List;)V";
			IntPtr native_selectedDays = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.ToLocalJniHandle (selectedDays);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_selectedDays);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_selectedDays);
			}
		}

#region "Event implementation for Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener"
		public event EventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.DayClickEventArgs> DayClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerImplementor>(
						ref weak_implementor___SetOnDayClickListener,
						__CreateIOnDayClickListenerImplementor,
						__v => OnDayClickListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerImplementor>(
						ref weak_implementor___SetOnDayClickListener,
						global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerImplementor.__IsEmpty,
						__v => OnDayClickListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnDayClickListener;

		global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerImplementor __CreateIOnDayClickListenerImplementor ()
		{
			return new global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener"
		public event EventHandler ForwardPageChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListenerImplementor>(
						ref weak_implementor___SetOnForwardPageChangeListener,
						__CreateIOnCalendarPageChangeListenerImplementor,
						__v => OnForwardPageChangeListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListenerImplementor>(
						ref weak_implementor___SetOnForwardPageChangeListener,
						global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListenerImplementor.__IsEmpty,
						__v => OnForwardPageChangeListener = null,
						__h => __h.Handler -= value);
			}
		}

		public event EventHandler PreviousPageChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListenerImplementor>(
						ref weak_implementor___SetOnPreviousPageChangeListener,
						__CreateIOnCalendarPageChangeListenerImplementor,
						__v => OnPreviousPageChangeListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListenerImplementor>(
						ref weak_implementor___SetOnPreviousPageChangeListener,
						global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListenerImplementor.__IsEmpty,
						__v => OnPreviousPageChangeListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnForwardPageChangeListener;
		WeakReference weak_implementor___SetOnPreviousPageChangeListener;

		global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListenerImplementor __CreateIOnCalendarPageChangeListenerImplementor ()
		{
			return new global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListener"
		public event EventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.SelectDateEventArgs> SelectDate {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListenerImplementor>(
						ref weak_implementor___SetOnSelectDateListener,
						__CreateIOnSelectDateListenerImplementor,
						__v => OnSelectDateListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListenerImplementor>(
						ref weak_implementor___SetOnSelectDateListener,
						global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListenerImplementor.__IsEmpty,
						__v => OnSelectDateListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnSelectDateListener;

		global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListenerImplementor __CreateIOnSelectDateListenerImplementor ()
		{
			return new global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListener"
		public event EventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.SelectionAbilityEventArgs> SelectionAbility {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListenerImplementor>(
						ref weak_implementor___SetOnSelectionAbilityListener,
						__CreateIOnSelectionAbilityListenerImplementor,
						__v => OnSelectionAbilityListener = __v,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListenerImplementor>(
						ref weak_implementor___SetOnSelectionAbilityListener,
						global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListenerImplementor.__IsEmpty,
						__v => OnSelectionAbilityListener = null,
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor___SetOnSelectionAbilityListener;

		global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListenerImplementor __CreateIOnSelectionAbilityListenerImplementor ()
		{
			return new global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectionAbilityListenerImplementor (this);
		}
#endregion
	}
}
