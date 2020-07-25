using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Applandeo.Materialcalendarview.Listeners {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.applandeo.materialcalendarview.listeners']/interface[@name='OnCalendarPageChangeListener']"
	[Register ("com/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListener", "", "Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListenerInvoker")]
	public partial interface IOnCalendarPageChangeListener : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.listeners']/interface[@name='OnCalendarPageChangeListener']/method[@name='onChange' and count(parameter)=0]"
		[Register ("onChange", "()V", "GetOnChangeHandler:Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListenerInvoker, library-material-calendar-view")]
		void OnChange ();

	}

	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListener", DoNotGenerateAcw=true)]
	internal partial class IOnCalendarPageChangeListenerInvoker : global::Java.Lang.Object, IOnCalendarPageChangeListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListener", typeof (IOnCalendarPageChangeListenerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IOnCalendarPageChangeListener GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnCalendarPageChangeListener> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.applandeo.materialcalendarview.listeners.OnCalendarPageChangeListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnCalendarPageChangeListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onChange;
#pragma warning disable 0169
		static Delegate GetOnChangeHandler ()
		{
			if (cb_onChange == null)
				cb_onChange = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnChange);
			return cb_onChange;
		}

		static void n_OnChange (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnChange ();
		}
#pragma warning restore 0169

		IntPtr id_onChange;
		public unsafe void OnChange ()
		{
			if (id_onChange == IntPtr.Zero)
				id_onChange = JNIEnv.GetMethodID (class_ref, "onChange", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChange);
		}

	}

	[global::Android.Runtime.Register ("mono/com/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListenerImplementor")]
	internal sealed partial class IOnCalendarPageChangeListenerImplementor : global::Java.Lang.Object, IOnCalendarPageChangeListener {

		object sender;

		public IOnCalendarPageChangeListenerImplementor (object sender)
			: base (
				global::Android.Runtime.JNIEnv.StartCreateInstance ("mono/com/applandeo/materialcalendarview/listeners/OnCalendarPageChangeListenerImplementor", "()V"),
				JniHandleOwnership.TransferLocalRef)
		{
			global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
			this.sender = sender;
		}

#pragma warning disable 0649
		public EventHandler Handler;
#pragma warning restore 0649

		public void OnChange ()
		{
			var __h = Handler;
			if (__h != null)
				__h (sender, new EventArgs ());
		}

		internal static bool __IsEmpty (IOnCalendarPageChangeListenerImplementor value)
		{
			return value.Handler == null;
		}
	}

}
