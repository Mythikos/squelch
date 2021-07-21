using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Formatter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='StackedValueFormatter']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/formatter/StackedValueFormatter", DoNotGenerateAcw=true)]
	public partial class StackedValueFormatter : global::Java.Lang.Object, global::MikePhil.Charting.Formatter.IValueFormatter {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/formatter/StackedValueFormatter", typeof (StackedValueFormatter));
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

		protected StackedValueFormatter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='StackedValueFormatter']/constructor[@name='StackedValueFormatter' and count(parameter)=3 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='int']]"
		[Register (".ctor", "(ZLjava/lang/String;I)V", "")]
		public unsafe StackedValueFormatter (bool drawWholeStack, string appendix, int decimals)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ZLjava/lang/String;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_appendix = JNIEnv.NewString (appendix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (drawWholeStack);
				__args [1] = new JniArgumentValue (native_appendix);
				__args [2] = new JniArgumentValue (decimals);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_appendix);
			}
		}

		static Delegate cb_getFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_;
#pragma warning disable 0169
		static Delegate GetGetFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_Handler ()
		{
			if (cb_getFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_ == null)
				cb_getFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr, int, IntPtr, IntPtr>) n_GetFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_);
			return cb_getFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_;
		}

		static IntPtr n_GetFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_ (IntPtr jnienv, IntPtr native__this, float value, IntPtr native_entry, int dataSetIndex, IntPtr native_viewPortHandler)
		{
			global::MikePhil.Charting.Formatter.StackedValueFormatter __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.StackedValueFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.Entry entry = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.Entry> (native_entry, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (native_viewPortHandler, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetFormattedValue (value, entry, dataSetIndex, viewPortHandler));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='StackedValueFormatter']/method[@name='getFormattedValue' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='com.github.mikephil.charting.data.Entry'] and parameter[3][@type='int'] and parameter[4][@type='com.github.mikephil.charting.utils.ViewPortHandler']]"
		[Register ("getFormattedValue", "(FLcom/github/mikephil/charting/data/Entry;ILcom/github/mikephil/charting/utils/ViewPortHandler;)Ljava/lang/String;", "GetGetFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_Handler")]
		public virtual unsafe string GetFormattedValue (float value, global::MikePhil.Charting.Data.Entry entry, int dataSetIndex, global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler)
		{
			const string __id = "getFormattedValue.(FLcom/github/mikephil/charting/data/Entry;ILcom/github/mikephil/charting/utils/ViewPortHandler;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (value);
				__args [1] = new JniArgumentValue ((entry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) entry).Handle);
				__args [2] = new JniArgumentValue (dataSetIndex);
				__args [3] = new JniArgumentValue ((viewPortHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPortHandler).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
