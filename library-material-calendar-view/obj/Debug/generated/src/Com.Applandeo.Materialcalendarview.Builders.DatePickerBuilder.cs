using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Applandeo.Materialcalendarview.Builders {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/builders/DatePickerBuilder", DoNotGenerateAcw=true)]
	public partial class DatePickerBuilder : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/applandeo/materialcalendarview/builders/DatePickerBuilder", typeof (DatePickerBuilder));
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

		protected DatePickerBuilder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/constructor[@name='DatePickerBuilder' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applandeo.materialcalendarview.listeners.OnSelectDateListener']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/applandeo/materialcalendarview/listeners/OnSelectDateListener;)V", "")]
		public unsafe DatePickerBuilder (global::Android.Content.Context context, global::Com.Applandeo.Materialcalendarview.Listeners.IOnSelectDateListener onSelectDateListener)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Lcom/applandeo/materialcalendarview/listeners/OnSelectDateListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((onSelectDateListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onSelectDateListener).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_abbreviationsBarColor_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetAbbreviationsBarColor_IHandler ()
		{
			if (cb_abbreviationsBarColor_I == null)
				cb_abbreviationsBarColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_AbbreviationsBarColor_I);
			return cb_abbreviationsBarColor_I;
		}

		[Obsolete]
		static IntPtr n_AbbreviationsBarColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AbbreviationsBarColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='abbreviationsBarColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("abbreviationsBarColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetAbbreviationsBarColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder AbbreviationsBarColor (int color)
		{
			const string __id = "abbreviationsBarColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_abbreviationsBarVisibility_I;
#pragma warning disable 0169
		static Delegate GetAbbreviationsBarVisibility_IHandler ()
		{
			if (cb_abbreviationsBarVisibility_I == null)
				cb_abbreviationsBarVisibility_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_AbbreviationsBarVisibility_I);
			return cb_abbreviationsBarVisibility_I;
		}

		static IntPtr n_AbbreviationsBarVisibility_I (IntPtr jnienv, IntPtr native__this, int visibility)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AbbreviationsBarVisibility (visibility));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='abbreviationsBarVisibility' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("abbreviationsBarVisibility", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetAbbreviationsBarVisibility_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder AbbreviationsBarVisibility (int visibility)
		{
			const string __id = "abbreviationsBarVisibility.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (visibility);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_abbreviationsLabelsColor_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetAbbreviationsLabelsColor_IHandler ()
		{
			if (cb_abbreviationsLabelsColor_I == null)
				cb_abbreviationsLabelsColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_AbbreviationsLabelsColor_I);
			return cb_abbreviationsLabelsColor_I;
		}

		[Obsolete]
		static IntPtr n_AbbreviationsLabelsColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AbbreviationsLabelsColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='abbreviationsLabelsColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("abbreviationsLabelsColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetAbbreviationsLabelsColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder AbbreviationsLabelsColor (int color)
		{
			const string __id = "abbreviationsLabelsColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_anotherMonthsDaysLabelsColor_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetAnotherMonthsDaysLabelsColor_IHandler ()
		{
			if (cb_anotherMonthsDaysLabelsColor_I == null)
				cb_anotherMonthsDaysLabelsColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_AnotherMonthsDaysLabelsColor_I);
			return cb_anotherMonthsDaysLabelsColor_I;
		}

		[Obsolete]
		static IntPtr n_AnotherMonthsDaysLabelsColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AnotherMonthsDaysLabelsColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='anotherMonthsDaysLabelsColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("anotherMonthsDaysLabelsColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetAnotherMonthsDaysLabelsColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder AnotherMonthsDaysLabelsColor (int color)
		{
			const string __id = "anotherMonthsDaysLabelsColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_build;
#pragma warning disable 0169
		static Delegate GetBuildHandler ()
		{
			if (cb_build == null)
				cb_build = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Build);
			return cb_build;
		}

		static IntPtr n_Build (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Build ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='build' and count(parameter)=0]"
		[Register ("build", "()Lcom/applandeo/materialcalendarview/DatePicker;", "GetBuildHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.DatePicker Build ()
		{
			const string __id = "build.()Lcom/applandeo/materialcalendarview/DatePicker;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.DatePicker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_date_Ljava_util_Calendar_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetDate_Ljava_util_Calendar_Handler ()
		{
			if (cb_date_Ljava_util_Calendar_ == null)
				cb_date_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Date_Ljava_util_Calendar_);
			return cb_date_Ljava_util_Calendar_;
		}

		[Obsolete]
		static IntPtr n_Date_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_calendar)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Date (calendar));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='date' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Obsolete (@"deprecated")]
		[Register ("date", "(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetDate_Ljava_util_Calendar_Handler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder Date (global::Java.Util.Calendar calendar)
		{
			const string __id = "date.(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((calendar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) calendar).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_daysLabelsColor_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetDaysLabelsColor_IHandler ()
		{
			if (cb_daysLabelsColor_I == null)
				cb_daysLabelsColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_DaysLabelsColor_I);
			return cb_daysLabelsColor_I;
		}

		[Obsolete]
		static IntPtr n_DaysLabelsColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DaysLabelsColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='daysLabelsColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("daysLabelsColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetDaysLabelsColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder DaysLabelsColor (int color)
		{
			const string __id = "daysLabelsColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_dialogButtonsColor_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetDialogButtonsColor_IHandler ()
		{
			if (cb_dialogButtonsColor_I == null)
				cb_dialogButtonsColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_DialogButtonsColor_I);
			return cb_dialogButtonsColor_I;
		}

		[Obsolete]
		static IntPtr n_DialogButtonsColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DialogButtonsColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='dialogButtonsColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("dialogButtonsColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetDialogButtonsColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder DialogButtonsColor (int color)
		{
			const string __id = "dialogButtonsColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_disabledDays_Ljava_util_List_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetDisabledDays_Ljava_util_List_Handler ()
		{
			if (cb_disabledDays_Ljava_util_List_ == null)
				cb_disabledDays_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DisabledDays_Ljava_util_List_);
			return cb_disabledDays_Ljava_util_List_;
		}

		[Obsolete]
		static IntPtr n_DisabledDays_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_disabledDays)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var disabledDays = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.FromJniHandle (native_disabledDays, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DisabledDays (disabledDays));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='disabledDays' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.util.Calendar&gt;']]"
		[Obsolete (@"deprecated")]
		[Register ("disabledDays", "(Ljava/util/List;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetDisabledDays_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder DisabledDays (global::System.Collections.Generic.IList<global::Java.Util.Calendar> disabledDays)
		{
			const string __id = "disabledDays.(Ljava/util/List;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			IntPtr native_disabledDays = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.ToLocalJniHandle (disabledDays);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_disabledDays);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_disabledDays);
			}
		}

		static Delegate cb_disabledDaysLabelsColor_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetDisabledDaysLabelsColor_IHandler ()
		{
			if (cb_disabledDaysLabelsColor_I == null)
				cb_disabledDaysLabelsColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_DisabledDaysLabelsColor_I);
			return cb_disabledDaysLabelsColor_I;
		}

		[Obsolete]
		static IntPtr n_DisabledDaysLabelsColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DisabledDaysLabelsColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='disabledDaysLabelsColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("disabledDaysLabelsColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetDisabledDaysLabelsColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder DisabledDaysLabelsColor (int color)
		{
			const string __id = "disabledDaysLabelsColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_forwardButtonSrc_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetForwardButtonSrc_IHandler ()
		{
			if (cb_forwardButtonSrc_I == null)
				cb_forwardButtonSrc_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ForwardButtonSrc_I);
			return cb_forwardButtonSrc_I;
		}

		[Obsolete]
		static IntPtr n_ForwardButtonSrc_I (IntPtr jnienv, IntPtr native__this, int drawable)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ForwardButtonSrc (drawable));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='forwardButtonSrc' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("forwardButtonSrc", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetForwardButtonSrc_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder ForwardButtonSrc (int drawable)
		{
			const string __id = "forwardButtonSrc.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (drawable);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_forwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_Handler ()
		{
			if (cb_forwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_ == null)
				cb_forwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_);
			return cb_forwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_;
		}

		[Obsolete]
		static IntPtr n_ForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener listener = (global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener)global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ForwardPageChangeListener (listener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='forwardPageChangeListener' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.listeners.OnCalendarPageChangeListener']]"
		[Obsolete (@"deprecated")]
		[Register ("forwardPageChangeListener", "(Lcom/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListener;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_Handler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder ForwardPageChangeListener (global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener listener)
		{
			const string __id = "forwardPageChangeListener.(Lcom/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListener;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_headerColor_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetHeaderColor_IHandler ()
		{
			if (cb_headerColor_I == null)
				cb_headerColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_HeaderColor_I);
			return cb_headerColor_I;
		}

		[Obsolete]
		static IntPtr n_HeaderColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HeaderColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='headerColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("headerColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetHeaderColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder HeaderColor (int color)
		{
			const string __id = "headerColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_headerLabelColor_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetHeaderLabelColor_IHandler ()
		{
			if (cb_headerLabelColor_I == null)
				cb_headerLabelColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_HeaderLabelColor_I);
			return cb_headerLabelColor_I;
		}

		[Obsolete]
		static IntPtr n_HeaderLabelColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HeaderLabelColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='headerLabelColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("headerLabelColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetHeaderLabelColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder HeaderLabelColor (int color)
		{
			const string __id = "headerLabelColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_headerVisibility_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetHeaderVisibility_IHandler ()
		{
			if (cb_headerVisibility_I == null)
				cb_headerVisibility_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_HeaderVisibility_I);
			return cb_headerVisibility_I;
		}

		[Obsolete]
		static IntPtr n_HeaderVisibility_I (IntPtr jnienv, IntPtr native__this, int visibility)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HeaderVisibility (visibility));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='headerVisibility' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("headerVisibility", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetHeaderVisibility_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder HeaderVisibility (int visibility)
		{
			const string __id = "headerVisibility.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (visibility);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_highlightedDays_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetHighlightedDays_Ljava_util_List_Handler ()
		{
			if (cb_highlightedDays_Ljava_util_List_ == null)
				cb_highlightedDays_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_HighlightedDays_Ljava_util_List_);
			return cb_highlightedDays_Ljava_util_List_;
		}

		static IntPtr n_HighlightedDays_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_highlightedDays)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var highlightedDays = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.FromJniHandle (native_highlightedDays, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.HighlightedDays (highlightedDays));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='highlightedDays' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.util.Calendar&gt;']]"
		[Register ("highlightedDays", "(Ljava/util/List;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetHighlightedDays_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder HighlightedDays (global::System.Collections.Generic.IList<global::Java.Util.Calendar> highlightedDays)
		{
			const string __id = "highlightedDays.(Ljava/util/List;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			IntPtr native_highlightedDays = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.ToLocalJniHandle (highlightedDays);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_highlightedDays);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_highlightedDays);
			}
		}

		static Delegate cb_highlightedDaysLabelsColor_I;
#pragma warning disable 0169
		static Delegate GetHighlightedDaysLabelsColor_IHandler ()
		{
			if (cb_highlightedDaysLabelsColor_I == null)
				cb_highlightedDaysLabelsColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_HighlightedDaysLabelsColor_I);
			return cb_highlightedDaysLabelsColor_I;
		}

		static IntPtr n_HighlightedDaysLabelsColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HighlightedDaysLabelsColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='highlightedDaysLabelsColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("highlightedDaysLabelsColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetHighlightedDaysLabelsColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder HighlightedDaysLabelsColor (int color)
		{
			const string __id = "highlightedDaysLabelsColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_maximumDate_Ljava_util_Calendar_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetMaximumDate_Ljava_util_Calendar_Handler ()
		{
			if (cb_maximumDate_Ljava_util_Calendar_ == null)
				cb_maximumDate_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MaximumDate_Ljava_util_Calendar_);
			return cb_maximumDate_Ljava_util_Calendar_;
		}

		[Obsolete]
		static IntPtr n_MaximumDate_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_calendar)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MaximumDate (calendar));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='maximumDate' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Obsolete (@"deprecated")]
		[Register ("maximumDate", "(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetMaximumDate_Ljava_util_Calendar_Handler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder MaximumDate (global::Java.Util.Calendar calendar)
		{
			const string __id = "maximumDate.(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((calendar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) calendar).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_minimumDate_Ljava_util_Calendar_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetMinimumDate_Ljava_util_Calendar_Handler ()
		{
			if (cb_minimumDate_Ljava_util_Calendar_ == null)
				cb_minimumDate_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MinimumDate_Ljava_util_Calendar_);
			return cb_minimumDate_Ljava_util_Calendar_;
		}

		[Obsolete]
		static IntPtr n_MinimumDate_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_calendar)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MinimumDate (calendar));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='minimumDate' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Obsolete (@"deprecated")]
		[Register ("minimumDate", "(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetMinimumDate_Ljava_util_Calendar_Handler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder MinimumDate (global::Java.Util.Calendar calendar)
		{
			const string __id = "minimumDate.(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((calendar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) calendar).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_pagesColor_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetPagesColor_IHandler ()
		{
			if (cb_pagesColor_I == null)
				cb_pagesColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_PagesColor_I);
			return cb_pagesColor_I;
		}

		[Obsolete]
		static IntPtr n_PagesColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PagesColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='pagesColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("pagesColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetPagesColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder PagesColor (int color)
		{
			const string __id = "pagesColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_pickerType_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetPickerType_IHandler ()
		{
			if (cb_pickerType_I == null)
				cb_pickerType_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_PickerType_I);
			return cb_pickerType_I;
		}

		[Obsolete]
		static IntPtr n_PickerType_I (IntPtr jnienv, IntPtr native__this, int calendarType)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PickerType (calendarType));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='pickerType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("pickerType", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetPickerType_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder PickerType (int calendarType)
		{
			const string __id = "pickerType.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (calendarType);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_previousButtonSrc_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetPreviousButtonSrc_IHandler ()
		{
			if (cb_previousButtonSrc_I == null)
				cb_previousButtonSrc_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_PreviousButtonSrc_I);
			return cb_previousButtonSrc_I;
		}

		[Obsolete]
		static IntPtr n_PreviousButtonSrc_I (IntPtr jnienv, IntPtr native__this, int drawable)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PreviousButtonSrc (drawable));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='previousButtonSrc' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("previousButtonSrc", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetPreviousButtonSrc_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder PreviousButtonSrc (int drawable)
		{
			const string __id = "previousButtonSrc.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (drawable);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_previousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_Handler ()
		{
			if (cb_previousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_ == null)
				cb_previousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_PreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_);
			return cb_previousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_;
		}

		[Obsolete]
		static IntPtr n_PreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener listener = (global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener)global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.PreviousPageChangeListener (listener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='previousPageChangeListener' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.listeners.OnCalendarPageChangeListener']]"
		[Obsolete (@"deprecated")]
		[Register ("previousPageChangeListener", "(Lcom/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListener;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_Handler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder PreviousPageChangeListener (global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener listener)
		{
			const string __id = "previousPageChangeListener.(Lcom/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListener;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_selectedDays_Ljava_util_List_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSelectedDays_Ljava_util_List_Handler ()
		{
			if (cb_selectedDays_Ljava_util_List_ == null)
				cb_selectedDays_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SelectedDays_Ljava_util_List_);
			return cb_selectedDays_Ljava_util_List_;
		}

		[Obsolete]
		static IntPtr n_SelectedDays_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_selectedDays)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var selectedDays = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.FromJniHandle (native_selectedDays, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SelectedDays (selectedDays));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='selectedDays' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.util.Calendar&gt;']]"
		[Obsolete (@"deprecated")]
		[Register ("selectedDays", "(Ljava/util/List;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSelectedDays_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SelectedDays (global::System.Collections.Generic.IList<global::Java.Util.Calendar> selectedDays)
		{
			const string __id = "selectedDays.(Ljava/util/List;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			IntPtr native_selectedDays = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.ToLocalJniHandle (selectedDays);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_selectedDays);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_selectedDays);
			}
		}

		static Delegate cb_selectionColor_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSelectionColor_IHandler ()
		{
			if (cb_selectionColor_I == null)
				cb_selectionColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SelectionColor_I);
			return cb_selectionColor_I;
		}

		[Obsolete]
		static IntPtr n_SelectionColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectionColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='selectionColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("selectionColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSelectionColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SelectionColor (int color)
		{
			const string __id = "selectionColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_selectionLabelColor_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSelectionLabelColor_IHandler ()
		{
			if (cb_selectionLabelColor_I == null)
				cb_selectionLabelColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SelectionLabelColor_I);
			return cb_selectionLabelColor_I;
		}

		[Obsolete]
		static IntPtr n_SelectionLabelColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SelectionLabelColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='selectionLabelColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("selectionLabelColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSelectionLabelColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SelectionLabelColor (int color)
		{
			const string __id = "selectionLabelColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAbbreviationsBarColor_I;
#pragma warning disable 0169
		static Delegate GetSetAbbreviationsBarColor_IHandler ()
		{
			if (cb_setAbbreviationsBarColor_I == null)
				cb_setAbbreviationsBarColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetAbbreviationsBarColor_I);
			return cb_setAbbreviationsBarColor_I;
		}

		static IntPtr n_SetAbbreviationsBarColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAbbreviationsBarColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setAbbreviationsBarColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAbbreviationsBarColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetAbbreviationsBarColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetAbbreviationsBarColor (int color)
		{
			const string __id = "setAbbreviationsBarColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAbbreviationsLabelsColor_I;
#pragma warning disable 0169
		static Delegate GetSetAbbreviationsLabelsColor_IHandler ()
		{
			if (cb_setAbbreviationsLabelsColor_I == null)
				cb_setAbbreviationsLabelsColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetAbbreviationsLabelsColor_I);
			return cb_setAbbreviationsLabelsColor_I;
		}

		static IntPtr n_SetAbbreviationsLabelsColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAbbreviationsLabelsColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setAbbreviationsLabelsColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAbbreviationsLabelsColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetAbbreviationsLabelsColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetAbbreviationsLabelsColor (int color)
		{
			const string __id = "setAbbreviationsLabelsColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setAnotherMonthsDaysLabelsColor_I;
#pragma warning disable 0169
		static Delegate GetSetAnotherMonthsDaysLabelsColor_IHandler ()
		{
			if (cb_setAnotherMonthsDaysLabelsColor_I == null)
				cb_setAnotherMonthsDaysLabelsColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetAnotherMonthsDaysLabelsColor_I);
			return cb_setAnotherMonthsDaysLabelsColor_I;
		}

		static IntPtr n_SetAnotherMonthsDaysLabelsColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetAnotherMonthsDaysLabelsColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setAnotherMonthsDaysLabelsColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setAnotherMonthsDaysLabelsColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetAnotherMonthsDaysLabelsColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetAnotherMonthsDaysLabelsColor (int color)
		{
			const string __id = "setAnotherMonthsDaysLabelsColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDate_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetSetDate_Ljava_util_Calendar_Handler ()
		{
			if (cb_setDate_Ljava_util_Calendar_ == null)
				cb_setDate_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDate_Ljava_util_Calendar_);
			return cb_setDate_Ljava_util_Calendar_;
		}

		static IntPtr n_SetDate_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_calendar)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDate (calendar));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setDate' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register ("setDate", "(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetDate_Ljava_util_Calendar_Handler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetDate (global::Java.Util.Calendar calendar)
		{
			const string __id = "setDate.(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((calendar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) calendar).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDaysLabelsColor_I;
#pragma warning disable 0169
		static Delegate GetSetDaysLabelsColor_IHandler ()
		{
			if (cb_setDaysLabelsColor_I == null)
				cb_setDaysLabelsColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetDaysLabelsColor_I);
			return cb_setDaysLabelsColor_I;
		}

		static IntPtr n_SetDaysLabelsColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDaysLabelsColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setDaysLabelsColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDaysLabelsColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetDaysLabelsColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetDaysLabelsColor (int color)
		{
			const string __id = "setDaysLabelsColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDialogButtonsColor_I;
#pragma warning disable 0169
		static Delegate GetSetDialogButtonsColor_IHandler ()
		{
			if (cb_setDialogButtonsColor_I == null)
				cb_setDialogButtonsColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetDialogButtonsColor_I);
			return cb_setDialogButtonsColor_I;
		}

		static IntPtr n_SetDialogButtonsColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDialogButtonsColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setDialogButtonsColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDialogButtonsColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetDialogButtonsColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetDialogButtonsColor (int color)
		{
			const string __id = "setDialogButtonsColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setDisabledDays_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetDisabledDays_Ljava_util_List_Handler ()
		{
			if (cb_setDisabledDays_Ljava_util_List_ == null)
				cb_setDisabledDays_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetDisabledDays_Ljava_util_List_);
			return cb_setDisabledDays_Ljava_util_List_;
		}

		static IntPtr n_SetDisabledDays_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_disabledDays)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var disabledDays = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.FromJniHandle (native_disabledDays, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetDisabledDays (disabledDays));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setDisabledDays' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.util.Calendar&gt;']]"
		[Register ("setDisabledDays", "(Ljava/util/List;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetDisabledDays_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetDisabledDays (global::System.Collections.Generic.IList<global::Java.Util.Calendar> disabledDays)
		{
			const string __id = "setDisabledDays.(Ljava/util/List;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			IntPtr native_disabledDays = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.ToLocalJniHandle (disabledDays);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_disabledDays);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_disabledDays);
			}
		}

		static Delegate cb_setDisabledDaysLabelsColor_I;
#pragma warning disable 0169
		static Delegate GetSetDisabledDaysLabelsColor_IHandler ()
		{
			if (cb_setDisabledDaysLabelsColor_I == null)
				cb_setDisabledDaysLabelsColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetDisabledDaysLabelsColor_I);
			return cb_setDisabledDaysLabelsColor_I;
		}

		static IntPtr n_SetDisabledDaysLabelsColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetDisabledDaysLabelsColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setDisabledDaysLabelsColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDisabledDaysLabelsColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetDisabledDaysLabelsColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetDisabledDaysLabelsColor (int color)
		{
			const string __id = "setDisabledDaysLabelsColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setEvents_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetEvents_Ljava_util_List_Handler ()
		{
			if (cb_setEvents_Ljava_util_List_ == null)
				cb_setEvents_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetEvents_Ljava_util_List_);
			return cb_setEvents_Ljava_util_List_;
		}

		static IntPtr n_SetEvents_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_eventDays)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var eventDays = global::Android.Runtime.JavaList<global::Com.Applandeo.Materialcalendarview.EventDay>.FromJniHandle (native_eventDays, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetEvents (eventDays));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setEvents' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.applandeo.materialcalendarview.EventDay&gt;']]"
		[Register ("setEvents", "(Ljava/util/List;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetEvents_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetEvents (global::System.Collections.Generic.IList<global::Com.Applandeo.Materialcalendarview.EventDay> eventDays)
		{
			const string __id = "setEvents.(Ljava/util/List;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			IntPtr native_eventDays = global::Android.Runtime.JavaList<global::Com.Applandeo.Materialcalendarview.EventDay>.ToLocalJniHandle (eventDays);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_eventDays);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_eventDays);
			}
		}

		static Delegate cb_setForwardButtonSrc_I;
#pragma warning disable 0169
		static Delegate GetSetForwardButtonSrc_IHandler ()
		{
			if (cb_setForwardButtonSrc_I == null)
				cb_setForwardButtonSrc_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetForwardButtonSrc_I);
			return cb_setForwardButtonSrc_I;
		}

		static IntPtr n_SetForwardButtonSrc_I (IntPtr jnienv, IntPtr native__this, int drawable)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetForwardButtonSrc (drawable));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setForwardButtonSrc' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setForwardButtonSrc", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetForwardButtonSrc_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetForwardButtonSrc (int drawable)
		{
			const string __id = "setForwardButtonSrc.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (drawable);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_Handler ()
		{
			if (cb_setForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_ == null)
				cb_setForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_);
			return cb_setForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_;
		}

		static IntPtr n_SetForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener listener = (global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener)global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetForwardPageChangeListener (listener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setForwardPageChangeListener' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.listeners.OnCalendarPageChangeListener']]"
		[Register ("setForwardPageChangeListener", "(Lcom/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListener;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetForwardPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_Handler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetForwardPageChangeListener (global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener listener)
		{
			const string __id = "setForwardPageChangeListener.(Lcom/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListener;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setHeaderColor_I;
#pragma warning disable 0169
		static Delegate GetSetHeaderColor_IHandler ()
		{
			if (cb_setHeaderColor_I == null)
				cb_setHeaderColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetHeaderColor_I);
			return cb_setHeaderColor_I;
		}

		static IntPtr n_SetHeaderColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetHeaderColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setHeaderColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHeaderColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetHeaderColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetHeaderColor (int color)
		{
			const string __id = "setHeaderColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setHeaderLabelColor_I;
#pragma warning disable 0169
		static Delegate GetSetHeaderLabelColor_IHandler ()
		{
			if (cb_setHeaderLabelColor_I == null)
				cb_setHeaderLabelColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetHeaderLabelColor_I);
			return cb_setHeaderLabelColor_I;
		}

		static IntPtr n_SetHeaderLabelColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetHeaderLabelColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setHeaderLabelColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHeaderLabelColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetHeaderLabelColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetHeaderLabelColor (int color)
		{
			const string __id = "setHeaderLabelColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setHeaderVisibility_I;
#pragma warning disable 0169
		static Delegate GetSetHeaderVisibility_IHandler ()
		{
			if (cb_setHeaderVisibility_I == null)
				cb_setHeaderVisibility_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetHeaderVisibility_I);
			return cb_setHeaderVisibility_I;
		}

		static IntPtr n_SetHeaderVisibility_I (IntPtr jnienv, IntPtr native__this, int visibility)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetHeaderVisibility (visibility));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setHeaderVisibility' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHeaderVisibility", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetHeaderVisibility_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetHeaderVisibility (int visibility)
		{
			const string __id = "setHeaderVisibility.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (visibility);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMaximumDate_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetSetMaximumDate_Ljava_util_Calendar_Handler ()
		{
			if (cb_setMaximumDate_Ljava_util_Calendar_ == null)
				cb_setMaximumDate_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMaximumDate_Ljava_util_Calendar_);
			return cb_setMaximumDate_Ljava_util_Calendar_;
		}

		static IntPtr n_SetMaximumDate_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_calendar)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMaximumDate (calendar));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setMaximumDate' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register ("setMaximumDate", "(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetMaximumDate_Ljava_util_Calendar_Handler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetMaximumDate (global::Java.Util.Calendar calendar)
		{
			const string __id = "setMaximumDate.(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((calendar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) calendar).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMaximumDaysRange_I;
#pragma warning disable 0169
		static Delegate GetSetMaximumDaysRange_IHandler ()
		{
			if (cb_setMaximumDaysRange_I == null)
				cb_setMaximumDaysRange_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetMaximumDaysRange_I);
			return cb_setMaximumDaysRange_I;
		}

		static IntPtr n_SetMaximumDaysRange_I (IntPtr jnienv, IntPtr native__this, int maximumDaysRange)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetMaximumDaysRange (maximumDaysRange));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setMaximumDaysRange' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaximumDaysRange", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetMaximumDaysRange_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetMaximumDaysRange (int maximumDaysRange)
		{
			const string __id = "setMaximumDaysRange.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maximumDaysRange);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setMinimumDate_Ljava_util_Calendar_;
#pragma warning disable 0169
		static Delegate GetSetMinimumDate_Ljava_util_Calendar_Handler ()
		{
			if (cb_setMinimumDate_Ljava_util_Calendar_ == null)
				cb_setMinimumDate_Ljava_util_Calendar_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetMinimumDate_Ljava_util_Calendar_);
			return cb_setMinimumDate_Ljava_util_Calendar_;
		}

		static IntPtr n_SetMinimumDate_Ljava_util_Calendar_ (IntPtr jnienv, IntPtr native__this, IntPtr native_calendar)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Calendar calendar = global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (native_calendar, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetMinimumDate (calendar));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setMinimumDate' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register ("setMinimumDate", "(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetMinimumDate_Ljava_util_Calendar_Handler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetMinimumDate (global::Java.Util.Calendar calendar)
		{
			const string __id = "setMinimumDate.(Ljava/util/Calendar;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((calendar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) calendar).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setNavigationVisibility_I;
#pragma warning disable 0169
		static Delegate GetSetNavigationVisibility_IHandler ()
		{
			if (cb_setNavigationVisibility_I == null)
				cb_setNavigationVisibility_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetNavigationVisibility_I);
			return cb_setNavigationVisibility_I;
		}

		static IntPtr n_SetNavigationVisibility_I (IntPtr jnienv, IntPtr native__this, int visibility)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetNavigationVisibility (visibility));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setNavigationVisibility' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setNavigationVisibility", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetNavigationVisibility_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetNavigationVisibility (int visibility)
		{
			const string __id = "setNavigationVisibility.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (visibility);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPagesColor_I;
#pragma warning disable 0169
		static Delegate GetSetPagesColor_IHandler ()
		{
			if (cb_setPagesColor_I == null)
				cb_setPagesColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetPagesColor_I);
			return cb_setPagesColor_I;
		}

		static IntPtr n_SetPagesColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetPagesColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setPagesColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPagesColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetPagesColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetPagesColor (int color)
		{
			const string __id = "setPagesColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPickerType_I;
#pragma warning disable 0169
		static Delegate GetSetPickerType_IHandler ()
		{
			if (cb_setPickerType_I == null)
				cb_setPickerType_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetPickerType_I);
			return cb_setPickerType_I;
		}

		static IntPtr n_SetPickerType_I (IntPtr jnienv, IntPtr native__this, int calendarType)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetPickerType (calendarType));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setPickerType' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPickerType", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetPickerType_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetPickerType (int calendarType)
		{
			const string __id = "setPickerType.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (calendarType);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPreviousButtonSrc_I;
#pragma warning disable 0169
		static Delegate GetSetPreviousButtonSrc_IHandler ()
		{
			if (cb_setPreviousButtonSrc_I == null)
				cb_setPreviousButtonSrc_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetPreviousButtonSrc_I);
			return cb_setPreviousButtonSrc_I;
		}

		static IntPtr n_SetPreviousButtonSrc_I (IntPtr jnienv, IntPtr native__this, int drawable)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetPreviousButtonSrc (drawable));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setPreviousButtonSrc' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPreviousButtonSrc", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetPreviousButtonSrc_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetPreviousButtonSrc (int drawable)
		{
			const string __id = "setPreviousButtonSrc.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (drawable);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_;
#pragma warning disable 0169
		static Delegate GetSetPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_Handler ()
		{
			if (cb_setPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_ == null)
				cb_setPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_);
			return cb_setPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_;
		}

		static IntPtr n_SetPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_listener)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener listener = (global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener)global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener> (native_listener, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetPreviousPageChangeListener (listener));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setPreviousPageChangeListener' and count(parameter)=1 and parameter[1][@type='com.applandeo.materialcalendarview.listeners.OnCalendarPageChangeListener']]"
		[Register ("setPreviousPageChangeListener", "(Lcom/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListener;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetPreviousPageChangeListener_Lcom_applandeo_materialcalendarview_listeners_OnCalendarPageChangeListener_Handler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetPreviousPageChangeListener (global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener listener)
		{
			const string __id = "setPreviousPageChangeListener.(Lcom/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListener;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSelectedDays_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetSelectedDays_Ljava_util_List_Handler ()
		{
			if (cb_setSelectedDays_Ljava_util_List_ == null)
				cb_setSelectedDays_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetSelectedDays_Ljava_util_List_);
			return cb_setSelectedDays_Ljava_util_List_;
		}

		static IntPtr n_SetSelectedDays_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_selectedDays)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var selectedDays = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.FromJniHandle (native_selectedDays, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SetSelectedDays (selectedDays));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setSelectedDays' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.util.Calendar&gt;']]"
		[Register ("setSelectedDays", "(Ljava/util/List;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetSelectedDays_Ljava_util_List_Handler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetSelectedDays (global::System.Collections.Generic.IList<global::Java.Util.Calendar> selectedDays)
		{
			const string __id = "setSelectedDays.(Ljava/util/List;)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			IntPtr native_selectedDays = global::Android.Runtime.JavaList<global::Java.Util.Calendar>.ToLocalJniHandle (selectedDays);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_selectedDays);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_selectedDays);
			}
		}

		static Delegate cb_setSelectionColor_I;
#pragma warning disable 0169
		static Delegate GetSetSelectionColor_IHandler ()
		{
			if (cb_setSelectionColor_I == null)
				cb_setSelectionColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetSelectionColor_I);
			return cb_setSelectionColor_I;
		}

		static IntPtr n_SetSelectionColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSelectionColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setSelectionColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSelectionColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetSelectionColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetSelectionColor (int color)
		{
			const string __id = "setSelectionColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setSelectionLabelColor_I;
#pragma warning disable 0169
		static Delegate GetSetSelectionLabelColor_IHandler ()
		{
			if (cb_setSelectionLabelColor_I == null)
				cb_setSelectionLabelColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetSelectionLabelColor_I);
			return cb_setSelectionLabelColor_I;
		}

		static IntPtr n_SetSelectionLabelColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetSelectionLabelColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setSelectionLabelColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setSelectionLabelColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetSelectionLabelColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetSelectionLabelColor (int color)
		{
			const string __id = "setSelectionLabelColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTodayColor_I;
#pragma warning disable 0169
		static Delegate GetSetTodayColor_IHandler ()
		{
			if (cb_setTodayColor_I == null)
				cb_setTodayColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetTodayColor_I);
			return cb_setTodayColor_I;
		}

		static IntPtr n_SetTodayColor_I (IntPtr jnienv, IntPtr native__this, int todayColor)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTodayColor (todayColor));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setTodayColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTodayColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetTodayColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetTodayColor (int todayColor)
		{
			const string __id = "setTodayColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (todayColor);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setTodayLabelColor_I;
#pragma warning disable 0169
		static Delegate GetSetTodayLabelColor_IHandler ()
		{
			if (cb_setTodayLabelColor_I == null)
				cb_setTodayLabelColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SetTodayLabelColor_I);
			return cb_setTodayLabelColor_I;
		}

		static IntPtr n_SetTodayLabelColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetTodayLabelColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='setTodayLabelColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTodayLabelColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetSetTodayLabelColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder SetTodayLabelColor (int color)
		{
			const string __id = "setTodayLabelColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_todayLabelColor_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetTodayLabelColor_IHandler ()
		{
			if (cb_todayLabelColor_I == null)
				cb_todayLabelColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_TodayLabelColor_I);
			return cb_todayLabelColor_I;
		}

		[Obsolete]
		static IntPtr n_TodayLabelColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TodayLabelColor (color));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.builders']/class[@name='DatePickerBuilder']/method[@name='todayLabelColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("todayLabelColor", "(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;", "GetTodayLabelColor_IHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder TodayLabelColor (int color)
		{
			const string __id = "todayLabelColor.(I)Lcom/applandeo/materialcalendarview/builders/DatePickerBuilder;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Builders.DatePickerBuilder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
