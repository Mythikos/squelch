using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Applandeo.Materialcalendarview.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='SelectedDay']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/utils/SelectedDay", DoNotGenerateAcw=true)]
	public partial class SelectedDay : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/applandeo/materialcalendarview/utils/SelectedDay", typeof (SelectedDay));
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

		protected SelectedDay (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='SelectedDay']/constructor[@name='SelectedDay' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='java.util.Calendar']]"
		[Register (".ctor", "(Landroid/view/View;Ljava/util/Calendar;)V", "")]
		public unsafe SelectedDay (global::Android.Views.View view, global::Java.Util.Calendar calendar)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/view/View;Ljava/util/Calendar;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((calendar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) calendar).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='SelectedDay']/constructor[@name='SelectedDay' and count(parameter)=1 and parameter[1][@type='java.util.Calendar']]"
		[Register (".ctor", "(Ljava/util/Calendar;)V", "")]
		public unsafe SelectedDay (global::Java.Util.Calendar calendar)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Calendar;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((calendar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) calendar).Handle);
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
			global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Calendar);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Util.Calendar Calendar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='SelectedDay']/method[@name='getCalendar' and count(parameter)=0]"
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

		static Delegate cb_getView;
#pragma warning disable 0169
		static Delegate GetGetViewHandler ()
		{
			if (cb_getView == null)
				cb_getView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetView);
			return cb_getView;
		}

		static IntPtr n_GetView (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.View);
		}
#pragma warning restore 0169

		static Delegate cb_setView_Landroid_view_View_;
#pragma warning disable 0169
		static Delegate GetSetView_Landroid_view_View_Handler ()
		{
			if (cb_setView_Landroid_view_View_ == null)
				cb_setView_Landroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetView_Landroid_view_View_);
			return cb_setView_Landroid_view_View_;
		}

		static void n_SetView_Landroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_view)
		{
			global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Utils.SelectedDay> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.View = view;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Views.View View {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='SelectedDay']/method[@name='getView' and count(parameter)=0]"
			[Register ("getView", "()Landroid/view/View;", "GetGetViewHandler")]
			get {
				const string __id = "getView.()Landroid/view/View;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='SelectedDay']/method[@name='setView' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
			[Register ("setView", "(Landroid/view/View;)V", "GetSetView_Landroid_view_View_Handler")]
			set {
				const string __id = "setView.(Landroid/view/View;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
