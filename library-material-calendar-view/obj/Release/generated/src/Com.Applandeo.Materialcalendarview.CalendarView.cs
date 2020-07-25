using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Applandeo.Materialcalendarview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/CalendarView", DoNotGenerateAcw=true)]
	public partial class CalendarView : global::Android.Widget.LinearLayout {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/field[@name='CLASSIC']"
		[Register ("CLASSIC")]
		public const int Classic = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/field[@name='MANY_DAYS_PICKER']"
		[Register ("MANY_DAYS_PICKER")]
		public const int ManyDaysPicker = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/field[@name='ONE_DAY_PICKER']"
		[Register ("ONE_DAY_PICKER")]
		public const int OneDayPicker = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/field[@name='RANGE_PICKER']"
		[Register ("RANGE_PICKER")]
		public const int RangePicker = (int) 3;
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/applandeo/materialcalendarview/CalendarView", typeof (CalendarView));
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

		protected CalendarView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/constructor[@name='CalendarView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe CalendarView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/constructor[@name='CalendarView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe CalendarView (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyleAttr)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyleAttr);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/constructor[@name='CalendarView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applandeo.materialcalendarview.utils.CalendarProperties']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/applandeo/materialcalendarview/utils/CalendarProperties;)V", "")]
		protected unsafe CalendarView (global::Android.Content.Context context, global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties calendarProperties)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/applandeo/materialcalendarview/utils/CalendarProperties;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((calendarProperties == null) ? IntPtr.Zero : ((global::Java.Lang.Object) calendarProperties).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getCurrentPageDate;
#pragma warning disable 0169
		static Delegate GetGetCurrentPageDateHandler ()
		{
			if (cb_getCurrentPageDate == null)
				cb_getCurrentPageDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCurrentPageDate);
			return cb_getCurrentPageDate;
		}

		static IntPtr n_GetCurrentPageDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CurrentPageDate);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Calendar CurrentPageDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='getCurrentPageDate' and count(parameter)=0]"
			[Register ("getCurrentPageDate", "()Ljava/util/Calendar;", "GetGetCurrentPageDateHandler")]
			get {
				const string __id = "getCurrentPageDate.()Ljava/util/Calendar;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFirstSelectedDate;
#pragma warning disable 0169
		static Delegate GetGetFirstSelectedDateHandler ()
		{
			if (cb_getFirstSelectedDate == null)
				cb_getFirstSelectedDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFirstSelectedDate);
			return cb_getFirstSelectedDate;
		}

		static IntPtr n_GetFirstSelectedDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FirstSelectedDate);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Calendar FirstSelectedDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='getFirstSelectedDate' and count(parameter)=0]"
			[Register ("getFirstSelectedDate", "()Ljava/util/Calendar;", "GetGetFirstSelectedDateHandler")]
			get {
				const string __id = "getFirstSelectedDate.()Ljava/util/Calendar;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedDate;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetSelectedDateHandler ()
		{
			if (cb_getSelectedDate == null)
				cb_getSelectedDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectedDate);
			return cb_getSelectedDate;
		}

		[Obsolete]
		static IntPtr n_GetSelectedDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectedDate);
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe global::Java.Util.Calendar SelectedDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='getSelectedDate' and count(parameter)=0]"
			[Register ("getSelectedDate", "()Ljava/util/Calendar;", "GetGetSelectedDateHandler")]
			get {
				const string __id = "getSelectedDate.()Ljava/util/Calendar;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSelectedDates;
#pragma warning disable 0169
		static Delegate GetGetSelectedDatesHandler ()
		{
			if (cb_getSelectedDates == null)
				cb_getSelectedDates = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSelectedDates);
			return cb_getSelectedDates;
		}

		static IntPtr n_GetSelectedDates (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Util.Calendar>.ToLocalJniHandle (__this.SelectedDates);
		}
#pragma warning restore 0169

		static Delegate cb_setSelectedDates_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetSelectedDates_Ljava_util_List_Handler ()
		{
			if (cb_setSelectedDates_Ljava_util_List_ == null)
				cb_setSelectedDates_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSelectedDates_Ljava_util_List_);
			return cb_setSelectedDates_Ljava_util_List_;
		}

		static void n_SetSelectedDates_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_selectedDates)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var selectedDates = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.FromJniHandle (native_selectedDates, JniHandleOwnership.DoNotTransfer);
			__this.SelectedDates = selectedDates;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Util.Calendar> SelectedDates {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='getSelectedDates' and count(parameter)=0]"
			[Register ("getSelectedDates", "()Ljava/util/List;", "GetGetSelectedDatesHandler")]
			get {
				const string __id = "getSelectedDates.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Java.Util.Calendar>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setSelectedDates' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.util.Calendar&gt;']]"
			[Register ("setSelectedDates", "(Ljava/util/List;)V", "GetSetSelectedDates_Ljava_util_List_Handler")]
			set {
				const string __id = "setSelectedDates.(Ljava/util/List;)V";
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

		static Delegate cb_setAbbreviationsBarVisibility_I;
#pragma warning disable 0169
		static Delegate GetSetAbbreviationsBarVisibility_IHandler ()
		{
			if (cb_setAbbreviationsBarVisibility_I == null)
				cb_setAbbreviationsBarVisibility_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAbbreviationsBarVisibility_I);
			return cb_setAbbreviationsBarVisibility_I;
		}

		static void n_SetAbbreviationsBarVisibility_I (IntPtr jnienv, IntPtr native__this, int visibility)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAbbreviationsBarVisibility (visibility);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setAbbreviationsBarVisibility' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAbbreviationsBarVisibility", "(I)V", "GetSetAbbreviationsBarVisibility_IHandler")]
		public virtual unsafe void SetAbbreviationsBarVisibility (int visibility)
		{
			const string __id = "setAbbreviationsBarVisibility.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (visibility);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDate_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetSetDate_Ljava_util_Calendar_Handler ()
		{
			if (cb_setDate_Ljava_util_Calendar_ == null)
				cb_setDate_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDate_Ljava_util_Calendar_);
			return cb_setDate_Ljava_util_Calendar_;
		}

		static void n_SetDate_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_date)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar date = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_date, JniHandleOwnership.DoNotTransfer);
			__this.SetDate (date);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setDate' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register ("setDate", "(Ljava/util/Calendar;)V", "GetSetDate_Ljava_util_Calendar_Handler")]
		public virtual unsafe void SetDate (global::Java.Util.Calendar date)
		{
			const string __id = "setDate.(Ljava/util/Calendar;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((date == null) ? IntPtr.Zero : ((global::Java.Lang.Object) date).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDate_Ljava_util_Date_;
#pragma warning disable 0169
		static Delegate GetSetDate_Ljava_util_Date_Handler ()
		{
			if (cb_setDate_Ljava_util_Date_ == null)
				cb_setDate_Ljava_util_Date_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDate_Ljava_util_Date_);
			return cb_setDate_Ljava_util_Date_;
		}

		static void n_SetDate_Ljava_util_Date_ (IntPtr jnienv, IntPtr native__this, IntPtr native_currentDate)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Date currentDate = global::Java.Lang.Object.GetObject<global::Java.Util.Date> (native_currentDate, JniHandleOwnership.DoNotTransfer);
			__this.SetDate (currentDate);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setDate' and count(parameter)=1 and parameter[1][@type='java.util.Date']]"
		[Register ("setDate", "(Ljava/util/Date;)V", "GetSetDate_Ljava_util_Date_Handler")]
		public virtual unsafe void SetDate (global::Java.Util.Date currentDate)
		{
			const string __id = "setDate.(Ljava/util/Date;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((currentDate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) currentDate).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

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
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var disabledDays = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.FromJniHandle (native_disabledDays, JniHandleOwnership.DoNotTransfer);
			__this.SetDisabledDays (disabledDays);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setDisabledDays' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.util.Calendar&gt;']]"
		[Register ("setDisabledDays", "(Ljava/util/List;)V", "GetSetDisabledDays_Ljava_util_List_Handler")]
		public virtual unsafe void SetDisabledDays (global::System.Collections.Generic.IList<global::Java.Util.Calendar> disabledDays)
		{
			const string __id = "setDisabledDays.(Ljava/util/List;)V";
			IntPtr native_disabledDays = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.ToLocalJniHandle (disabledDays);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_disabledDays);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_disabledDays);
			}
		}

		static Delegate cb_setEvents_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetEvents_Ljava_util_List_Handler ()
		{
			if (cb_setEvents_Ljava_util_List_ == null)
				cb_setEvents_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEvents_Ljava_util_List_);
			return cb_setEvents_Ljava_util_List_;
		}

		static void n_SetEvents_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventDays)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var eventDays = global::Android.Runtime.JavaList<global::Com.Applandeo.Materialcalendarview.EventDay>.FromJniHandle (native_eventDays, JniHandleOwnership.DoNotTransfer);
			__this.SetEvents (eventDays);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setEvents' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applandeo.materialcalendarview.EventDay&gt;']]"
		[Register ("setEvents", "(Ljava/util/List;)V", "GetSetEvents_Ljava_util_List_Handler")]
		public virtual unsafe void SetEvents (global::System.Collections.Generic.IList<global::Com.Applandeo.Materialcalendarview.EventDay> eventDays)
		{
			const string __id = "setEvents.(Ljava/util/List;)V";
			IntPtr native_eventDays = global::Android.Runtime.JavaList<global::Com.Applandeo.Materialcalendarview.EventDay>.ToLocalJniHandle (eventDays);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_eventDays);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_eventDays);
			}
		}

		static Delegate cb_setForwardButtonImage_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetForwardButtonImage_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setForwardButtonImage_Landroid_graphics_drawable_Drawable_ == null)
				cb_setForwardButtonImage_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetForwardButtonImage_Landroid_graphics_drawable_Drawable_);
			return cb_setForwardButtonImage_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetForwardButtonImage_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			__this.SetForwardButtonImage (drawable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setForwardButtonImage' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setForwardButtonImage", "(Landroid/graphics/drawable/Drawable;)V", "GetSetForwardButtonImage_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetForwardButtonImage (global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "setForwardButtonImage.(Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setHeaderColor_I;
#pragma warning disable 0169
		static Delegate GetSetHeaderColor_IHandler ()
		{
			if (cb_setHeaderColor_I == null)
				cb_setHeaderColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHeaderColor_I);
			return cb_setHeaderColor_I;
		}

		static void n_SetHeaderColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHeaderColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setHeaderColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHeaderColor", "(I)V", "GetSetHeaderColor_IHandler")]
		public virtual unsafe void SetHeaderColor (int color)
		{
			const string __id = "setHeaderColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setHeaderLabelColor_I;
#pragma warning disable 0169
		static Delegate GetSetHeaderLabelColor_IHandler ()
		{
			if (cb_setHeaderLabelColor_I == null)
				cb_setHeaderLabelColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHeaderLabelColor_I);
			return cb_setHeaderLabelColor_I;
		}

		static void n_SetHeaderLabelColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHeaderLabelColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setHeaderLabelColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHeaderLabelColor", "(I)V", "GetSetHeaderLabelColor_IHandler")]
		public virtual unsafe void SetHeaderLabelColor (int color)
		{
			const string __id = "setHeaderLabelColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setHeaderVisibility_I;
#pragma warning disable 0169
		static Delegate GetSetHeaderVisibility_IHandler ()
		{
			if (cb_setHeaderVisibility_I == null)
				cb_setHeaderVisibility_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHeaderVisibility_I);
			return cb_setHeaderVisibility_I;
		}

		static void n_SetHeaderVisibility_I (IntPtr jnienv, IntPtr native__this, int visibility)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHeaderVisibility (visibility);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setHeaderVisibility' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHeaderVisibility", "(I)V", "GetSetHeaderVisibility_IHandler")]
		public virtual unsafe void SetHeaderVisibility (int visibility)
		{
			const string __id = "setHeaderVisibility.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (visibility);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

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
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var highlightedDays = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.FromJniHandle (native_highlightedDays, JniHandleOwnership.DoNotTransfer);
			__this.SetHighlightedDays (highlightedDays);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setHighlightedDays' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.util.Calendar&gt;']]"
		[Register ("setHighlightedDays", "(Ljava/util/List;)V", "GetSetHighlightedDays_Ljava_util_List_Handler")]
		public virtual unsafe void SetHighlightedDays (global::System.Collections.Generic.IList<global::Java.Util.Calendar> highlightedDays)
		{
			const string __id = "setHighlightedDays.(Ljava/util/List;)V";
			IntPtr native_highlightedDays = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.ToLocalJniHandle (highlightedDays);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_highlightedDays);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_highlightedDays);
			}
		}

		static Delegate cb_setMaximumDate_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetSetMaximumDate_Ljava_util_Calendar_Handler ()
		{
			if (cb_setMaximumDate_Ljava_util_Calendar_ == null)
				cb_setMaximumDate_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMaximumDate_Ljava_util_Calendar_);
			return cb_setMaximumDate_Ljava_util_Calendar_;
		}

		static void n_SetMaximumDate_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_calendar)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			__this.SetMaximumDate (calendar);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setMaximumDate' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register ("setMaximumDate", "(Ljava/util/Calendar;)V", "GetSetMaximumDate_Ljava_util_Calendar_Handler")]
		public virtual unsafe void SetMaximumDate (global::Java.Util.Calendar calendar)
		{
			const string __id = "setMaximumDate.(Ljava/util/Calendar;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((calendar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) calendar).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMinimumDate_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetSetMinimumDate_Ljava_util_Calendar_Handler ()
		{
			if (cb_setMinimumDate_Ljava_util_Calendar_ == null)
				cb_setMinimumDate_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMinimumDate_Ljava_util_Calendar_);
			return cb_setMinimumDate_Ljava_util_Calendar_;
		}

		static void n_SetMinimumDate_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_calendar)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			__this.SetMinimumDate (calendar);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setMinimumDate' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register ("setMinimumDate", "(Ljava/util/Calendar;)V", "GetSetMinimumDate_Ljava_util_Calendar_Handler")]
		public virtual unsafe void SetMinimumDate (global::Java.Util.Calendar calendar)
		{
			const string __id = "setMinimumDate.(Ljava/util/Calendar;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((calendar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) calendar).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

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
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener onDayClickListener = (global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener)global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener> (native_onDayClickListener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnDayClickListener (onDayClickListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setOnDayClickListener' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.listeners.OnDayClickListener']]"
		[Register ("setOnDayClickListener", "(Lcom/applandeo/materialcalendarview/listeners/OnDayClickListener;)V", "GetSetOnDayClickListener_Lcom_applandeo_materialcalendarview_listeners_OnDayClickListener_Handler")]
		public virtual unsafe void SetOnDayClickListener (global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener onDayClickListener)
		{
			const string __id = "setOnDayClickListener.(Lcom/applandeo/materialcalendarview/listeners/OnDayClickListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((onDayClickListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onDayClickListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_Handler ()
		{
			if (cb_setOnForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_ == null)
				cb_setOnForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_);
			return cb_setOnForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_;
		}

		static void n_SetOnForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener listener = (global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener)global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnForwardPageChangeListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setOnForwardPageChangeListener' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.listeners.OnCalendarPageChangeListener']]"
		[Register ("setOnForwardPageChangeListener", "(Lcom/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListener;)V", "GetSetOnForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_Handler")]
		public virtual unsafe void SetOnForwardPageChangeListener (global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener listener)
		{
			const string __id = "setOnForwardPageChangeListener.(Lcom/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetOnPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_Handler ()
		{
			if (cb_setOnPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_ == null)
				cb_setOnPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_);
			return cb_setOnPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_;
		}

		static void n_SetOnPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener listener = (global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener)global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnPreviousPageChangeListener (listener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setOnPreviousPageChangeListener' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.listeners.OnCalendarPageChangeListener']]"
		[Register ("setOnPreviousPageChangeListener", "(Lcom/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListener;)V", "GetSetOnPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_Handler")]
		public virtual unsafe void SetOnPreviousPageChangeListener (global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener listener)
		{
			const string __id = "setOnPreviousPageChangeListener.(Lcom/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPreviousButtonImage_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetPreviousButtonImage_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setPreviousButtonImage_Landroid_graphics_drawable_Drawable_ == null)
				cb_setPreviousButtonImage_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPreviousButtonImage_Landroid_graphics_drawable_Drawable_);
			return cb_setPreviousButtonImage_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetPreviousButtonImage_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			__this.SetPreviousButtonImage (drawable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setPreviousButtonImage' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
		[Register ("setPreviousButtonImage", "(Landroid/graphics/drawable/Drawable;)V", "GetSetPreviousButtonImage_Landroid_graphics_drawable_Drawable_Handler")]
		public virtual unsafe void SetPreviousButtonImage (global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "setPreviousButtonImage.(Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

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
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetSwipeEnabled (swipeEnabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='setSwipeEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setSwipeEnabled", "(Z)V", "GetSetSwipeEnabled_ZHandler")]
		public virtual unsafe void SetSwipeEnabled (bool swipeEnabled)
		{
			const string __id = "setSwipeEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (swipeEnabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_showCurrentMonthPage;
#pragma warning disable 0169
		static Delegate GetShowCurrentMonthPageHandler ()
		{
			if (cb_showCurrentMonthPage == null)
				cb_showCurrentMonthPage = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ShowCurrentMonthPage);
			return cb_showCurrentMonthPage;
		}

		static void n_ShowCurrentMonthPage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.CalendarView __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.CalendarView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowCurrentMonthPage ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarView']/method[@name='showCurrentMonthPage' and count(parameter)=0]"
		[Register ("showCurrentMonthPage", "()V", "GetShowCurrentMonthPageHandler")]
		public virtual unsafe void ShowCurrentMonthPage ()
		{
			const string __id = "showCurrentMonthPage.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

#region "Event implementation for Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener"
		public event EventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.DayClickEventArgs> DayClick {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerImplementor>(
						ref weak_implementor_SetOnDayClickListener,
						__CreateIOnDayClickListenerImplementor,
						SetOnDayClickListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerImplementor>(
						ref weak_implementor_SetOnDayClickListener,
						global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerImplementor.__IsEmpty,
						__v => SetOnDayClickListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnDayClickListener;

		global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerImplementor __CreateIOnDayClickListenerImplementor ()
		{
			return new global::Com.Applandeo.Materialcalendarview.Listeners.IOnDayClickListenerImplementor (this);
		}
#endregion
#region "Event implementation for Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener"
		public event EventHandler ForwardPageChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListenerImplementor>(
						ref weak_implementor_SetOnForwardPageChangeListener,
						__CreateIOnCalendarPageChangeListenerImplementor,
						SetOnForwardPageChangeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListenerImplementor>(
						ref weak_implementor_SetOnForwardPageChangeListener,
						global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListenerImplementor.__IsEmpty,
						__v => SetOnForwardPageChangeListener (null),
						__h => __h.Handler -= value);
			}
		}

		public event EventHandler PreviousPageChange {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListenerImplementor>(
						ref weak_implementor_SetOnPreviousPageChangeListener,
						__CreateIOnCalendarPageChangeListenerImplementor,
						SetOnPreviousPageChangeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener, global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListenerImplementor>(
						ref weak_implementor_SetOnPreviousPageChangeListener,
						global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListenerImplementor.__IsEmpty,
						__v => SetOnPreviousPageChangeListener (null),
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_SetOnForwardPageChangeListener;
		WeakReference weak_implementor_SetOnPreviousPageChangeListener;

		global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListenerImplementor __CreateIOnCalendarPageChangeListenerImplementor ()
		{
			return new global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListenerImplementor (this);
		}
#endregion
	}
}
