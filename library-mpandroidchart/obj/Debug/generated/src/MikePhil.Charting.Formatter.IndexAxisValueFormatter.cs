using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Formatter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='IndexAxisValueFormatter']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/formatter/IndexAxisValueFormatter", DoNotGenerateAcw=true)]
	public partial class IndexAxisValueFormatter : global::Java.Lang.Object, global::MikePhil.Charting.Formatter.IAxisValueFormatter {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/formatter/IndexAxisValueFormatter", typeof (IndexAxisValueFormatter));
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

		protected IndexAxisValueFormatter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='IndexAxisValueFormatter']/constructor[@name='IndexAxisValueFormatter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe IndexAxisValueFormatter ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='IndexAxisValueFormatter']/constructor[@name='IndexAxisValueFormatter' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register (".ctor", "([Ljava/lang/String;)V", "")]
		public unsafe IndexAxisValueFormatter (string[] values)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_values);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='IndexAxisValueFormatter']/constructor[@name='IndexAxisValueFormatter' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/util/Collection;)V", "")]
		public unsafe IndexAxisValueFormatter (global::System.Collections.Generic.ICollection<string> values)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Collection;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_values = global::Android.Runtime.JavaCollection<string>.ToLocalJniHandle (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_values);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_values);
			}
		}

		static Delegate cb_getFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_;
#pragma warning disable 0169
		static Delegate GetGetFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_Handler ()
		{
			if (cb_getFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_ == null)
				cb_getFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr, IntPtr>) n_GetFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_);
			return cb_getFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_;
		}

		static IntPtr n_GetFormattedValue_FLcom_github_mikephil_charting_components_AxisBase_ (IntPtr jnienv, IntPtr native__this, float value, IntPtr native_axis)
		{
			global::MikePhil.Charting.Formatter.IndexAxisValueFormatter __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IndexAxisValueFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.AxisBase axis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (native_axis, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetFormattedValue (value, axis));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='IndexAxisValueFormatter']/method[@name='getFormattedValue' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='com.github.mikephil.charting.components.AxisBase']]"
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
			}
		}

		static Delegate cb_getValues;
#pragma warning disable 0169
		static Delegate GetGetValuesHandler ()
		{
			if (cb_getValues == null)
				cb_getValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValues);
			return cb_getValues;
		}

		static IntPtr n_GetValues (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Formatter.IndexAxisValueFormatter __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IndexAxisValueFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetValues ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='IndexAxisValueFormatter']/method[@name='getValues' and count(parameter)=0]"
		[Register ("getValues", "()[Ljava/lang/String;", "GetGetValuesHandler")]
		public virtual unsafe string[] GetValues ()
		{
			const string __id = "getValues.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_setValues_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetValues_arrayLjava_lang_String_Handler ()
		{
			if (cb_setValues_arrayLjava_lang_String_ == null)
				cb_setValues_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValues_arrayLjava_lang_String_);
			return cb_setValues_arrayLjava_lang_String_;
		}

		static void n_SetValues_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_values)
		{
			global::MikePhil.Charting.Formatter.IndexAxisValueFormatter __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IndexAxisValueFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] values = (string[]) JNIEnv.GetArray (native_values, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetValues (values);
			if (values != null)
				JNIEnv.CopyArray (values, native_values);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='IndexAxisValueFormatter']/method[@name='setValues' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setValues", "([Ljava/lang/String;)V", "GetSetValues_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetValues (string[] values)
		{
			const string __id = "setValues.([Ljava/lang/String;)V";
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_values);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

	}
}
