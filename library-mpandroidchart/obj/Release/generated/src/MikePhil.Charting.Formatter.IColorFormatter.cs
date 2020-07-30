using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Formatter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/interface[@name='ColorFormatter']"
	[Register ("com/github/mikephil/charting/formatter/ColorFormatter", "", "MikePhil.Charting.Formatter.IColorFormatterInvoker")]
	public partial interface IColorFormatter : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/interface[@name='ColorFormatter']/method[@name='getColor' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.github.mikephil.charting.data.Entry'] and parameter[3][@type='com.github.mikephil.charting.interfaces.datasets.IDataSet']]"
		[Register ("getColor", "(ILcom/github/mikephil/charting/data/Entry;Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;)I", "GetGetColor_ILcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_Handler:MikePhil.Charting.Formatter.IColorFormatterInvoker, library-mpandroidchart")]
		int GetColor (int p0, global::MikePhil.Charting.Data.Entry p1, global::MikePhil.Charting.Interfaces.Datasets.IDataSet p2);

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/formatter/ColorFormatter", DoNotGenerateAcw=true)]
	internal partial class IColorFormatterInvoker : global::Java.Lang.Object, IColorFormatter {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/formatter/ColorFormatter", typeof (IColorFormatterInvoker));

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

		public static IColorFormatter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IColorFormatter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.github.mikephil.charting.formatter.ColorFormatter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IColorFormatterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getColor_ILcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_;
#pragma warning disable 0169
		static Delegate GetGetColor_ILcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_Handler ()
		{
			if (cb_getColor_ILcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ == null)
				cb_getColor_ILcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, int>) n_GetColor_ILcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_);
			return cb_getColor_ILcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_;
		}

		static int n_GetColor_ILcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::MikePhil.Charting.Formatter.IColorFormatter __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IColorFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.Entry p1 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.Entry> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet p2 = (global::MikePhil.Charting.Interfaces.Datasets.IDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetColor (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getColor_ILcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_;
		public unsafe int GetColor (int p0, global::MikePhil.Charting.Data.Entry p1, global::MikePhil.Charting.Interfaces.Datasets.IDataSet p2)
		{
			if (id_getColor_ILcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ == IntPtr.Zero)
				id_getColor_ILcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ = JNIEnv.GetMethodID (class_ref, "getColor", "(ILcom/github/mikephil/charting/data/Entry;Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;)I");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColor_ILcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_, __args);
			return __ret;
		}

	}

}
