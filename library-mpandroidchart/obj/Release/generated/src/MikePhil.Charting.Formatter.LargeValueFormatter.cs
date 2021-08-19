using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Formatter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='LargeValueFormatter']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/formatter/LargeValueFormatter", DoNotGenerateAcw=true)]
	public partial class LargeValueFormatter : global::Java.Lang.Object, global::MikePhil.Charting.Formatter.IAxisValueFormatter, global::MikePhil.Charting.Formatter.IValueFormatter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/formatter/LargeValueFormatter", typeof (LargeValueFormatter));

		internal static IntPtr class_ref {
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
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected LargeValueFormatter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='LargeValueFormatter']/constructor[@name='LargeValueFormatter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LargeValueFormatter () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='LargeValueFormatter']/constructor[@name='LargeValueFormatter' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe LargeValueFormatter (string appendix) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_appendix = JNIEnv.NewString (appendix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_appendix);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_appendix);
			}
		}

		static Delegate cb_getDecimalDigits;
#pragma warning disable 0169
		static Delegate GetGetDecimalDigitsHandler ()
		{
			if (cb_getDecimalDigits == null)
				cb_getDecimalDigits = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetDecimalDigits);
			return cb_getDecimalDigits;
		}

		static int n_GetDecimalDigits (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.LargeValueFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DecimalDigits;
		}
#pragma warning restore 0169

		public virtual unsafe int DecimalDigits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='LargeValueFormatter']/method[@name='getDecimalDigits' and count(parameter)=0]"
			[Register ("getDecimalDigits", "()I", "GetGetDecimalDigitsHandler")]
			get {
				const string __id = "getDecimalDigits.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_;
#pragma warning disable 0169
		static Delegate GetGetFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_Handler ()
		{
			if (cb_getFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_ == null)
				cb_getFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFL_L) n_GetFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_);
			return cb_getFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_;
		}

		static IntPtr n_GetFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_ (IntPtr jnienv, IntPtr native__this, float value, IntPtr native_axis)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.LargeValueFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var axis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (native_axis, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetFormattedValue (value, axis));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='LargeValueFormatter']/method[@name='getFormattedValue' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='com.github.mikephil.charting.components.AxisBase']]"
		[Register ("getFormattedValue", "(FLcom/github/mikephil/charting/components/AxisBase;)Ljava/lang/String;", "GetGetFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_Handler")]
		public virtual unsafe string GetFormattedValue (float value, global::MikePhil.Charting.Components.AxisBase axis)
		{
			const string __id = "getFormattedValue.(FLcom/github/mikephil/charting/components/AxisBase;)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (value);
				__args [1] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (axis);
			}
		}

		static Delegate cb_getFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_;
#pragma warning disable 0169
		static Delegate GetGetFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_Handler ()
		{
			if (cb_getFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_ == null)
				cb_getFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFLIL_L) n_GetFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_);
			return cb_getFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_;
		}

		static IntPtr n_GetFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_ (IntPtr jnienv, IntPtr native__this, float value, IntPtr native_entry, int dataSetIndex, IntPtr native_viewPortHandler)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.LargeValueFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var entry = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.Entry> (native_entry, JniHandleOwnership.DoNotTransfer);
			var viewPortHandler = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (native_viewPortHandler, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetFormattedValue (value, entry, dataSetIndex, viewPortHandler));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='LargeValueFormatter']/method[@name='getFormattedValue' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='com.github.mikephil.charting.data.Entry'] and parameter[3][@type='int'] and parameter[4][@type='com.github.mikephil.charting.utils.ViewPortHandler']]"
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
				global::System.GC.KeepAlive (entry);
				global::System.GC.KeepAlive (viewPortHandler);
			}
		}

		static Delegate cb_setAppendix_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppendix_Ljava_lang_String_Handler ()
		{
			if (cb_setAppendix_Ljava_lang_String_ == null)
				cb_setAppendix_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetAppendix_Ljava_lang_String_);
			return cb_setAppendix_Ljava_lang_String_;
		}

		static void n_SetAppendix_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_appendix)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.LargeValueFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var appendix = JNIEnv.GetString (native_appendix, JniHandleOwnership.DoNotTransfer);
			__this.SetAppendix (appendix);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='LargeValueFormatter']/method[@name='setAppendix' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setAppendix", "(Ljava/lang/String;)V", "GetSetAppendix_Ljava_lang_String_Handler")]
		public virtual unsafe void SetAppendix (string appendix)
		{
			const string __id = "setAppendix.(Ljava/lang/String;)V";
			IntPtr native_appendix = JNIEnv.NewString (appendix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_appendix);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_appendix);
			}
		}

		static Delegate cb_setMaxLength_I;
#pragma warning disable 0169
		static Delegate GetSetMaxLength_IHandler ()
		{
			if (cb_setMaxLength_I == null)
				cb_setMaxLength_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetMaxLength_I);
			return cb_setMaxLength_I;
		}

		static void n_SetMaxLength_I (IntPtr jnienv, IntPtr native__this, int maxLength)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.LargeValueFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxLength (maxLength);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='LargeValueFormatter']/method[@name='setMaxLength' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxLength", "(I)V", "GetSetMaxLength_IHandler")]
		public virtual unsafe void SetMaxLength (int maxLength)
		{
			const string __id = "setMaxLength.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxLength);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setSuffix_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetSuffix_arrayLjava_lang_String_Handler ()
		{
			if (cb_setSuffix_arrayLjava_lang_String_ == null)
				cb_setSuffix_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetSuffix_arrayLjava_lang_String_);
			return cb_setSuffix_arrayLjava_lang_String_;
		}

		static void n_SetSuffix_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_suffix)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.LargeValueFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var suffix = (string[]) JNIEnv.GetArray (native_suffix, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetSuffix (suffix);
			if (suffix != null)
				JNIEnv.CopyArray (suffix, native_suffix);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='LargeValueFormatter']/method[@name='setSuffix' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setSuffix", "([Ljava/lang/String;)V", "GetSetSuffix_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetSuffix (string[] suffix)
		{
			const string __id = "setSuffix.([Ljava/lang/String;)V";
			IntPtr native_suffix = JNIEnv.NewArray (suffix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_suffix);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (suffix != null) {
					JNIEnv.CopyArray (native_suffix, suffix);
					JNIEnv.DeleteLocalRef (native_suffix);
				}
				global::System.GC.KeepAlive (suffix);
			}
		}

	}
}
