using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Applandeo.Materialcalendarview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='DatePicker']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/DatePicker", DoNotGenerateAcw=true)]
	public partial class DatePicker : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/applandeo/materialcalendarview/DatePicker", typeof (DatePicker));
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

		protected DatePicker (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='DatePicker']/constructor[@name='DatePicker' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.applandeo.materialcalendarview.utils.CalendarProperties']]"
		[Register (".ctor", "(Landroid/content/Context;Lcom/applandeo/materialcalendarview/utils/CalendarProperties;)V", "")]
		public unsafe DatePicker (global::Android.Content.Context context, global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties calendarProperties)
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

		static Delegate cb_show;
#pragma warning disable 0169
		static Delegate GetShowHandler ()
		{
			if (cb_show == null)
				cb_show = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Show);
			return cb_show;
		}

		static IntPtr n_Show (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.DatePicker __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.DatePicker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Show ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='DatePicker']/method[@name='show' and count(parameter)=0]"
		[Register ("show", "()Lcom/applandeo/materialcalendarview/DatePicker;", "GetShowHandler")]
		public virtual unsafe global::Com.Applandeo.Materialcalendarview.DatePicker Show ()
		{
			const string __id = "show.()Lcom/applandeo/materialcalendarview/DatePicker;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.DatePicker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
