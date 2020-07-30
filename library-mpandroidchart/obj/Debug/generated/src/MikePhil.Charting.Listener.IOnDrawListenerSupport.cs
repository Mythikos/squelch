using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.mikephil.charting.listener']/interface[@name='OnDrawListener']"
	[Register ("com/github/mikephil/charting/listener/OnDrawListener", "", "MikePhil.Charting.Listener.IOnDrawListenerSupportInvoker")]
	public partial interface IOnDrawListenerSupport : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/interface[@name='OnDrawListener']/method[@name='onDrawFinished' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.DataSet&lt;?&gt;']]"
		[Register ("onDrawFinished", "(Lcom/github/mikephil/charting/data/DataSet;)V", "GetOnDrawFinished_Lcom_github_mikephil_charting_data_DataSet_Handler:MikePhil.Charting.Listener.IOnDrawListenerSupportInvoker, library-mpandroidchart")]
		void OnDrawFinished (global::MikePhil.Charting.Data.DataSet p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/interface[@name='OnDrawListener']/method[@name='onEntryAdded' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.Entry']]"
		[Register ("onEntryAdded", "(Lcom/github/mikephil/charting/data/Entry;)V", "GetOnEntryAdded_Lcom_github_mikephil_charting_data_Entry_Handler:MikePhil.Charting.Listener.IOnDrawListenerSupportInvoker, library-mpandroidchart")]
		void OnEntryAdded (global::MikePhil.Charting.Data.Entry p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/interface[@name='OnDrawListener']/method[@name='onEntryMoved' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.Entry']]"
		[Register ("onEntryMoved", "(Lcom/github/mikephil/charting/data/Entry;)V", "GetOnEntryMoved_Lcom_github_mikephil_charting_data_Entry_Handler:MikePhil.Charting.Listener.IOnDrawListenerSupportInvoker, library-mpandroidchart")]
		void OnEntryMoved (global::MikePhil.Charting.Data.Entry p0);

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/listener/OnDrawListener", DoNotGenerateAcw=true)]
	internal partial class IOnDrawListenerSupportInvoker : global::Java.Lang.Object, IOnDrawListenerSupport {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/listener/OnDrawListener", typeof (IOnDrawListenerSupportInvoker));

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

		public static IOnDrawListenerSupport GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnDrawListenerSupport> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.github.mikephil.charting.listener.OnDrawListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnDrawListenerSupportInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onDrawFinished_Lcom_github_mikephil_charting_data_DataSet_;
#pragma warning disable 0169
		static Delegate GetOnDrawFinished_Lcom_github_mikephil_charting_data_DataSet_Handler ()
		{
			if (cb_onDrawFinished_Lcom_github_mikephil_charting_data_DataSet_ == null)
				cb_onDrawFinished_Lcom_github_mikephil_charting_data_DataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnDrawFinished_Lcom_github_mikephil_charting_data_DataSet_);
			return cb_onDrawFinished_Lcom_github_mikephil_charting_data_DataSet_;
		}

		static void n_OnDrawFinished_Lcom_github_mikephil_charting_data_DataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Listener.IOnDrawListenerSupport __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.IOnDrawListenerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.DataSet p0 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnDrawFinished (p0);
		}
#pragma warning restore 0169

		IntPtr id_onDrawFinished_Lcom_github_mikephil_charting_data_DataSet_;
		public unsafe void OnDrawFinished (global::MikePhil.Charting.Data.DataSet p0)
		{
			if (id_onDrawFinished_Lcom_github_mikephil_charting_data_DataSet_ == IntPtr.Zero)
				id_onDrawFinished_Lcom_github_mikephil_charting_data_DataSet_ = JNIEnv.GetMethodID (class_ref, "onDrawFinished", "(Lcom/github/mikephil/charting/data/DataSet;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onDrawFinished_Lcom_github_mikephil_charting_data_DataSet_, __args);
		}

		static Delegate cb_onEntryAdded_Lcom_github_mikephil_charting_data_Entry_;
#pragma warning disable 0169
		static Delegate GetOnEntryAdded_Lcom_github_mikephil_charting_data_Entry_Handler ()
		{
			if (cb_onEntryAdded_Lcom_github_mikephil_charting_data_Entry_ == null)
				cb_onEntryAdded_Lcom_github_mikephil_charting_data_Entry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnEntryAdded_Lcom_github_mikephil_charting_data_Entry_);
			return cb_onEntryAdded_Lcom_github_mikephil_charting_data_Entry_;
		}

		static void n_OnEntryAdded_Lcom_github_mikephil_charting_data_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Listener.IOnDrawListenerSupport __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.IOnDrawListenerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.Entry p0 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.Entry> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnEntryAdded (p0);
		}
#pragma warning restore 0169

		IntPtr id_onEntryAdded_Lcom_github_mikephil_charting_data_Entry_;
		public unsafe void OnEntryAdded (global::MikePhil.Charting.Data.Entry p0)
		{
			if (id_onEntryAdded_Lcom_github_mikephil_charting_data_Entry_ == IntPtr.Zero)
				id_onEntryAdded_Lcom_github_mikephil_charting_data_Entry_ = JNIEnv.GetMethodID (class_ref, "onEntryAdded", "(Lcom/github/mikephil/charting/data/Entry;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEntryAdded_Lcom_github_mikephil_charting_data_Entry_, __args);
		}

		static Delegate cb_onEntryMoved_Lcom_github_mikephil_charting_data_Entry_;
#pragma warning disable 0169
		static Delegate GetOnEntryMoved_Lcom_github_mikephil_charting_data_Entry_Handler ()
		{
			if (cb_onEntryMoved_Lcom_github_mikephil_charting_data_Entry_ == null)
				cb_onEntryMoved_Lcom_github_mikephil_charting_data_Entry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnEntryMoved_Lcom_github_mikephil_charting_data_Entry_);
			return cb_onEntryMoved_Lcom_github_mikephil_charting_data_Entry_;
		}

		static void n_OnEntryMoved_Lcom_github_mikephil_charting_data_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Listener.IOnDrawListenerSupport __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.IOnDrawListenerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.Entry p0 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.Entry> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnEntryMoved (p0);
		}
#pragma warning restore 0169

		IntPtr id_onEntryMoved_Lcom_github_mikephil_charting_data_Entry_;
		public unsafe void OnEntryMoved (global::MikePhil.Charting.Data.Entry p0)
		{
			if (id_onEntryMoved_Lcom_github_mikephil_charting_data_Entry_ == IntPtr.Zero)
				id_onEntryMoved_Lcom_github_mikephil_charting_data_Entry_ = JNIEnv.GetMethodID (class_ref, "onEntryMoved", "(Lcom/github/mikephil/charting/data/Entry;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onEntryMoved_Lcom_github_mikephil_charting_data_Entry_, __args);
		}

	}

}
