using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Formatter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/interface[@name='IAxisValueFormatter']"
	[Register ("com/github/mikephil/charting/formatter/IAxisValueFormatter", "", "MikePhil.Charting.Formatter.IAxisValueFormatterInvoker")]
	public partial interface IAxisValueFormatter : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/interface[@name='IAxisValueFormatter']/method[@name='getFormattedValue' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='com.github.mikephil.charting.components.AxisBase']]"
		[Register ("getFormattedValue", "(FLcom/github/mikephil/charting/components/AxisBase;)Ljava/lang/String;", "GetGetFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_Handler:MikePhil.Charting.Formatter.IAxisValueFormatterInvoker, library-mpandroidchart")]
		string GetFormattedValue (float p0, global::MikePhil.Charting.Components.AxisBase p1);

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/formatter/IAxisValueFormatter", DoNotGenerateAcw=true)]
	internal partial class IAxisValueFormatterInvoker : global::Java.Lang.Object, IAxisValueFormatter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/formatter/IAxisValueFormatter", typeof (IAxisValueFormatterInvoker));

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

		public static IAxisValueFormatter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IAxisValueFormatter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.github.mikephil.charting.formatter.IAxisValueFormatter'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IAxisValueFormatterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_;
#pragma warning disable 0169
		static Delegate GetGetFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_Handler ()
		{
			if (cb_getFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_ == null)
				cb_getFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFL_L) n_GetFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_);
			return cb_getFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_;
		}

		static IntPtr n_GetFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_ (IntPtr jnienv, IntPtr native__this, float p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IAxisValueFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetFormattedValue (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_;
		public unsafe string GetFormattedValue (float p0, global::MikePhil.Charting.Components.AxisBase p1)
		{
			if (id_getFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_ == IntPtr.Zero)
				id_getFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_ = JNIEnv.GetMethodID (class_ref, "getFormattedValue", "(FLcom/github/mikephil/charting/components/AxisBase;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}
}
