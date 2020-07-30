using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Formatter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/interface[@name='IValueFormatter']"
	[Register ("com/github/mikephil/charting/formatter/IValueFormatter", "", "MikePhil.Charting.Formatter.IValueFormatterInvoker")]
	public partial interface IValueFormatter : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/interface[@name='IValueFormatter']/method[@name='getFormattedValue' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='com.github.mikephil.charting.data.Entry'] and parameter[3][@type='int'] and parameter[4][@type='com.github.mikephil.charting.utils.ViewPortHandler']]"
		[Register ("getFormattedValue", "(FLcom/github/mikephil/charting/data/Entry;ILcom/github/mikephil/charting/utils/ViewPortHandler;)Ljava/lang/String;", "GetGetFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_Handler:MikePhil.Charting.Formatter.IValueFormatterInvoker, library-mpandroidchart")]
		string GetFormattedValue (float p0, global::MikePhil.Charting.Data.Entry p1, int p2, global::MikePhil.Charting.Util.ViewPortHandler p3);

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/formatter/IValueFormatter", DoNotGenerateAcw=true)]
	internal partial class IValueFormatterInvoker : global::Java.Lang.Object, IValueFormatter {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/formatter/IValueFormatter", typeof (IValueFormatterInvoker));

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

		public static IValueFormatter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IValueFormatter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.github.mikephil.charting.formatter.IValueFormatter"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IValueFormatterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_;
#pragma warning disable 0169
		static Delegate GetGetFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_Handler ()
		{
			if (cb_getFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_ == null)
				cb_getFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr, int, IntPtr, IntPtr>) n_GetFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_);
			return cb_getFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_;
		}

		static IntPtr n_GetFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_ (IntPtr jnienv, IntPtr native__this, float p0, IntPtr native_p1, int p2, IntPtr native_p3)
		{
			global::MikePhil.Charting.Formatter.IValueFormatter __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IValueFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.Entry p1 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.Entry> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Util.ViewPortHandler p3 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (native_p3, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetFormattedValue (p0, p1, p2, p3));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_;
		public unsafe string GetFormattedValue (float p0, global::MikePhil.Charting.Data.Entry p1, int p2, global::MikePhil.Charting.Util.ViewPortHandler p3)
		{
			if (id_getFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_ == IntPtr.Zero)
				id_getFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_ = JNIEnv.GetMethodID (class_ref, "getFormattedValue", "(FLcom/github/mikephil/charting/data/Entry;ILcom/github/mikephil/charting/utils/ViewPortHandler;)Ljava/lang/String;");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue (p0);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (p2);
			__args [3] = new JValue ((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p3).Handle);
			string __ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

	}

}