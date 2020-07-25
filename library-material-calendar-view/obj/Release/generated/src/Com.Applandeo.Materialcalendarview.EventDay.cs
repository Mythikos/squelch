using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Applandeo.Materialcalendarview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='EventDay']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/EventDay", DoNotGenerateAcw=true)]
	public partial class EventDay : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/applandeo/materialcalendarview/EventDay", typeof (EventDay));
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

		protected EventDay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='EventDay']/constructor[@name='EventDay' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register (".ctor", "(Ljava/util/Calendar;)V", "")]
		public unsafe EventDay (global::Java.Util.Calendar day)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Calendar;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((day == null) ? IntPtr.Zero : ((global::Java.Lang.Object) day).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='EventDay']/constructor[@name='EventDay' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register (".ctor", "(Ljava/util/Calendar;Landroid/graphics/drawable/Drawable;)V", "")]
		public unsafe EventDay (global::Java.Util.Calendar day, global::Android.Graphics.Drawables.Drawable drawable)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Calendar;Landroid/graphics/drawable/Drawable;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((day == null) ? IntPtr.Zero : ((global::Java.Lang.Object) day).Handle);
				__args [1] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='EventDay']/constructor[@name='EventDay' and count(parameter)=3 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='android.graphics.drawable.Drawable'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/util/Calendar;Landroid/graphics/drawable/Drawable;I)V", "")]
		public unsafe EventDay (global::Java.Util.Calendar day, global::Android.Graphics.Drawables.Drawable drawable, int labelColor)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Calendar;Landroid/graphics/drawable/Drawable;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((day == null) ? IntPtr.Zero : ((global::Java.Lang.Object) day).Handle);
				__args [1] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				__args [2] = new JniArgumentValue (labelColor);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='EventDay']/constructor[@name='EventDay' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Ljava/util/Calendar;I)V", "")]
		public unsafe EventDay (global::Java.Util.Calendar day, int drawable)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Calendar;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((day == null) ? IntPtr.Zero : ((global::Java.Lang.Object) day).Handle);
				__args [1] = new JniArgumentValue (drawable);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='EventDay']/constructor[@name='EventDay' and count(parameter)=3 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Ljava/util/Calendar;II)V", "")]
		public unsafe EventDay (global::Java.Util.Calendar day, int drawable, int labelColor)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Calendar;II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((day == null) ? IntPtr.Zero : ((global::Java.Lang.Object) day).Handle);
				__args [1] = new JniArgumentValue (drawable);
				__args [2] = new JniArgumentValue (labelColor);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
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
			global::Com.Applandeo.Materialcalendarview.EventDay __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.EventDay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Calendar);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Calendar Calendar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='EventDay']/method[@name='getCalendar' and count(parameter)=0]"
			[Register ("getCalendar", "()Ljava/util/Calendar;", "GetGetCalendarHandler")]
			get {
				const string __id = "getCalendar.()Ljava/util/Calendar;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Calendar> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isEnabled;
#pragma warning disable 0169
		static Delegate GetIsEnabledHandler ()
		{
			if (cb_isEnabled == null)
				cb_isEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnabled);
			return cb_isEnabled;
		}

		static bool n_IsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.EventDay __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.EventDay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Enabled;
		}
#pragma warning restore 0169

		static Delegate cb_setEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetEnabled_ZHandler ()
		{
			if (cb_setEnabled_Z == null)
				cb_setEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetEnabled_Z);
			return cb_setEnabled_Z;
		}

		static void n_SetEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::Com.Applandeo.Materialcalendarview.EventDay __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.EventDay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enabled = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool Enabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='EventDay']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Z", "GetIsEnabledHandler")]
			get {
				const string __id = "isEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='EventDay']/method[@name='setEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnabled", "(Z)V", "GetSetEnabled_ZHandler")]
			set {
				const string __id = "setEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getImageDrawable;
#pragma warning disable 0169
		static Delegate GetGetImageDrawableHandler ()
		{
			if (cb_getImageDrawable == null)
				cb_getImageDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetImageDrawable);
			return cb_getImageDrawable;
		}

		static IntPtr n_GetImageDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.EventDay __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.EventDay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ImageDrawable);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object ImageDrawable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='EventDay']/method[@name='getImageDrawable' and count(parameter)=0]"
			[Register ("getImageDrawable", "()Ljava/lang/Object;", "GetGetImageDrawableHandler")]
			get {
				const string __id = "getImageDrawable.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLabelColor;
#pragma warning disable 0169
		static Delegate GetGetLabelColorHandler ()
		{
			if (cb_getLabelColor == null)
				cb_getLabelColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLabelColor);
			return cb_getLabelColor;
		}

		static int n_GetLabelColor (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.EventDay __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.EventDay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LabelColor;
		}
#pragma warning restore 0169

		public virtual unsafe int LabelColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='EventDay']/method[@name='getLabelColor' and count(parameter)=0]"
			[Register ("getLabelColor", "()I", "GetGetLabelColorHandler")]
			get {
				const string __id = "getLabelColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
