using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Formatter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/interface[@name='IFillFormatter']"
	[Register ("com/github/mikephil/charting/formatter/IFillFormatter", "", "MikePhil.Charting.Formatter.IFillFormatterInvoker")]
	public partial interface IFillFormatter : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/interface[@name='IFillFormatter']/method[@name='getFillLinePosition' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.interfaces.datasets.ILineDataSet'] and parameter[2][@type='com.github.mikephil.charting.interfaces.dataprovider.LineDataProvider']]"
		[Register ("getFillLinePosition", "(Lcom/github/mikephil/charting/interfaces/datasets/ILineDataSet;Lcom/github/mikephil/charting/interfaces/dataprovider/LineDataProvider;)F", "GetGetFillLinePosition_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_interfaces_dataprovider_LineDataProvider_Handler:MikePhil.Charting.Formatter.IFillFormatterInvoker, library-mpandroidchart")]
		float GetFillLinePosition (global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet p0, global::MikePhil.Charting.Interfaces.Dataprovider.ILineDataProvider p1);

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/formatter/IFillFormatter", DoNotGenerateAcw=true)]
	internal partial class IFillFormatterInvoker : global::Java.Lang.Object, IFillFormatter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/formatter/IFillFormatter", typeof (IFillFormatterInvoker));

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

		public static IFillFormatter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFillFormatter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.github.mikephil.charting.formatter.IFillFormatter'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFillFormatterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getFillLinePosition_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_interfaces_dataprovider_LineDataProvider_;
#pragma warning disable 0169
		static Delegate GetGetFillLinePosition_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_interfaces_dataprovider_LineDataProvider_Handler ()
		{
			if (cb_getFillLinePosition_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_interfaces_dataprovider_LineDataProvider_ == null)
				cb_getFillLinePosition_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_interfaces_dataprovider_LineDataProvider_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_F) n_GetFillLinePosition_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_interfaces_dataprovider_LineDataProvider_);
			return cb_getFillLinePosition_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_interfaces_dataprovider_LineDataProvider_;
		}

		static float n_GetFillLinePosition_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_interfaces_dataprovider_LineDataProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IFillFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = (global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::MikePhil.Charting.Interfaces.Dataprovider.ILineDataProvider)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ILineDataProvider> (native_p1, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetFillLinePosition (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getFillLinePosition_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_interfaces_dataprovider_LineDataProvider_;
		public unsafe float GetFillLinePosition (global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet p0, global::MikePhil.Charting.Interfaces.Dataprovider.ILineDataProvider p1)
		{
			if (id_getFillLinePosition_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_interfaces_dataprovider_LineDataProvider_ == IntPtr.Zero)
				id_getFillLinePosition_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_interfaces_dataprovider_LineDataProvider_ = JNIEnv.GetMethodID (class_ref, "getFillLinePosition", "(Lcom/github/mikephil/charting/interfaces/datasets/ILineDataSet;Lcom/github/mikephil/charting/interfaces/dataprovider/LineDataProvider;)F");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			var __ret = JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getFillLinePosition_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_interfaces_dataprovider_LineDataProvider_, __args);
			return __ret;
		}

	}
}
