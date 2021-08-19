using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.mikephil.charting.listener']/interface[@name='OnChartValueSelectedListener']"
	[Register ("com/github/mikephil/charting/listener/OnChartValueSelectedListener", "", "MikePhil.Charting.Listener.IOnChartValueSelectedListenerSupportInvoker")]
	public partial interface IOnChartValueSelectedListenerSupport : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/interface[@name='OnChartValueSelectedListener']/method[@name='onNothingSelected' and count(parameter)=0]"
		[Register ("onNothingSelected", "()V", "GetOnNothingSelectedHandler:MikePhil.Charting.Listener.IOnChartValueSelectedListenerSupportInvoker, library-mpandroidchart")]
		void OnNothingSelected ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/interface[@name='OnChartValueSelectedListener']/method[@name='onValueSelected' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.data.Entry'] and parameter[2][@type='com.github.mikephil.charting.highlight.Highlight']]"
		[Register ("onValueSelected", "(Lcom/github/mikephil/charting/data/Entry;Lcom/github/mikephil/charting/highlight/Highlight;)V", "GetOnValueSelected_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_Handler:MikePhil.Charting.Listener.IOnChartValueSelectedListenerSupportInvoker, library-mpandroidchart")]
		void OnValueSelected (global::MikePhil.Charting.Data.Entry p0, global::MikePhil.Charting.Highlight.Highlight p1);

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/listener/OnChartValueSelectedListener", DoNotGenerateAcw=true)]
	internal partial class IOnChartValueSelectedListenerSupportInvoker : global::Java.Lang.Object, IOnChartValueSelectedListenerSupport {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/listener/OnChartValueSelectedListener", typeof (IOnChartValueSelectedListenerSupportInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IOnChartValueSelectedListenerSupport GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnChartValueSelectedListenerSupport> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.github.mikephil.charting.listener.OnChartValueSelectedListener'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnChartValueSelectedListenerSupportInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onNothingSelected;
#pragma warning disable 0169
		static Delegate GetOnNothingSelectedHandler ()
		{
			if (cb_onNothingSelected == null)
				cb_onNothingSelected = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnNothingSelected);
			return cb_onNothingSelected;
		}

		static void n_OnNothingSelected (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.IOnChartValueSelectedListenerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnNothingSelected ();
		}
#pragma warning restore 0169

		IntPtr id_onNothingSelected;
		public unsafe void OnNothingSelected ()
		{
			if (id_onNothingSelected == IntPtr.Zero)
				id_onNothingSelected = JNIEnv.GetMethodID (class_ref, "onNothingSelected", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onNothingSelected);
		}

		static Delegate cb_onValueSelected_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_;
#pragma warning disable 0169
		static Delegate GetOnValueSelected_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_Handler ()
		{
			if (cb_onValueSelected_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_ == null)
				cb_onValueSelected_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnValueSelected_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_);
			return cb_onValueSelected_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_;
		}

		static void n_OnValueSelected_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.IOnChartValueSelectedListenerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.Entry> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnValueSelected (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onValueSelected_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_;
		public unsafe void OnValueSelected (global::MikePhil.Charting.Data.Entry p0, global::MikePhil.Charting.Highlight.Highlight p1)
		{
			if (id_onValueSelected_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_ == IntPtr.Zero)
				id_onValueSelected_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_ = JNIEnv.GetMethodID (class_ref, "onValueSelected", "(Lcom/github/mikephil/charting/data/Entry;Lcom/github/mikephil/charting/highlight/Highlight;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onValueSelected_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_, __args);
		}

	}
}
