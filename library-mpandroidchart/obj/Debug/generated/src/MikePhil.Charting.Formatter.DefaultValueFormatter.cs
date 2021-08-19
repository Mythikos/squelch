using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Formatter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='DefaultValueFormatter']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/formatter/DefaultValueFormatter", DoNotGenerateAcw=true)]
	public partial class DefaultValueFormatter : global::Java.Lang.Object, global::MikePhil.Charting.Formatter.IValueFormatter {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='DefaultValueFormatter']/field[@name='mDecimalDigits']"
		[Register ("mDecimalDigits")]
		protected int MDecimalDigits {
			get {
				const string __id = "mDecimalDigits.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mDecimalDigits.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='DefaultValueFormatter']/field[@name='mFormat']"
		[Register ("mFormat")]
		protected global::Java.Text.DecimalFormat MFormat {
			get {
				const string __id = "mFormat.Ljava/text/DecimalFormat;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Text.DecimalFormat> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mFormat.Ljava/text/DecimalFormat;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/formatter/DefaultValueFormatter", typeof (DefaultValueFormatter));

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

		protected DefaultValueFormatter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='DefaultValueFormatter']/constructor[@name='DefaultValueFormatter' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe DefaultValueFormatter (int digits) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (digits);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.DefaultValueFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DecimalDigits;
		}
#pragma warning restore 0169

		public virtual unsafe int DecimalDigits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='DefaultValueFormatter']/method[@name='getDecimalDigits' and count(parameter)=0]"
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
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.DefaultValueFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var entry = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.Entry> (native_entry, JniHandleOwnership.DoNotTransfer);
			var viewPortHandler = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (native_viewPortHandler, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetFormattedValue (value, entry, dataSetIndex, viewPortHandler));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='DefaultValueFormatter']/method[@name='getFormattedValue' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='com.github.mikephil.charting.data.Entry'] and parameter[3][@type='int'] and parameter[4][@type='com.github.mikephil.charting.utils.ViewPortHandler']]"
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

		static Delegate cb_setup_I;
#pragma warning disable 0169
		static Delegate GetSetup_IHandler ()
		{
			if (cb_setup_I == null)
				cb_setup_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_Setup_I);
			return cb_setup_I;
		}

		static void n_Setup_I (IntPtr jnienv, IntPtr native__this, int digits)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.DefaultValueFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Setup (digits);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='DefaultValueFormatter']/method[@name='setup' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setup", "(I)V", "GetSetup_IHandler")]
		public virtual unsafe void Setup (int digits)
		{
			const string __id = "setup.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (digits);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
