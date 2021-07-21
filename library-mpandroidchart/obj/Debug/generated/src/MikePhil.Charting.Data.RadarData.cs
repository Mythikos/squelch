using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarData']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/RadarData", DoNotGenerateAcw=true)]
	public partial class RadarData : global::MikePhil.Charting.Data.ChartData {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/data/RadarData", typeof (RadarData));
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

		protected RadarData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarData']/constructor[@name='RadarData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RadarData ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarData']/constructor[@name='RadarData' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.interfaces.datasets.IRadarDataSet...']]"
		[Register (".ctor", "([Lcom/github/mikephil/charting/interfaces/datasets/IRadarDataSet;)V", "")]
		public unsafe RadarData (params global::MikePhil.Charting.Interfaces.Datasets.IRadarDataSet[] dataSets)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Lcom/github/mikephil/charting/interfaces/datasets/IRadarDataSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_dataSets = JNIEnv.NewArray (dataSets);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_dataSets);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (dataSets != null) {
					JNIEnv.CopyArray (native_dataSets, dataSets);
					JNIEnv.DeleteLocalRef (native_dataSets);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarData']/constructor[@name='RadarData' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.github.mikephil.charting.interfaces.datasets.IRadarDataSet&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe RadarData (global::System.Collections.Generic.IList<global::MikePhil.Charting.Interfaces.Datasets.IRadarDataSet> dataSets)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_dataSets = global::Android.Runtime.JavaList<global::MikePhil.Charting.Interfaces.Datasets.IRadarDataSet>.ToLocalJniHandle (dataSets);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_dataSets);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_dataSets);
			}
		}

		static Delegate cb_getLabels;
#pragma warning disable 0169
		static Delegate GetGetLabelsHandler ()
		{
			if (cb_getLabels == null)
				cb_getLabels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLabels);
			return cb_getLabels;
		}

		static IntPtr n_GetLabels (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.RadarData __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.RadarData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<string>.ToLocalJniHandle (__this.Labels);
		}
#pragma warning restore 0169

		static Delegate cb_setLabels_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetLabels_Ljava_util_List_Handler ()
		{
			if (cb_setLabels_Ljava_util_List_ == null)
				cb_setLabels_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLabels_Ljava_util_List_);
			return cb_setLabels_Ljava_util_List_;
		}

		static void n_SetLabels_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_labels)
		{
			global::MikePhil.Charting.Data.RadarData __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.RadarData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var labels = global::Android.Runtime.JavaList<string>.FromJniHandle (native_labels, JniHandleOwnership.DoNotTransfer);
			__this.Labels = labels;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<string> Labels {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarData']/method[@name='getLabels' and count(parameter)=0]"
			[Register ("getLabels", "()Ljava/util/List;", "GetGetLabelsHandler")]
			get {
				const string __id = "getLabels.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<string>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarData']/method[@name='setLabels' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
			[Register ("setLabels", "(Ljava/util/List;)V", "GetSetLabels_Ljava_util_List_Handler")]
			set {
				const string __id = "setLabels.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_setLabels_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLabels_arrayLjava_lang_String_Handler ()
		{
			if (cb_setLabels_arrayLjava_lang_String_ == null)
				cb_setLabels_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLabels_arrayLjava_lang_String_);
			return cb_setLabels_arrayLjava_lang_String_;
		}

		static void n_SetLabels_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_labels)
		{
			global::MikePhil.Charting.Data.RadarData __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.RadarData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] labels = (string[]) JNIEnv.GetArray (native_labels, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetLabels (labels);
			if (labels != null)
				JNIEnv.CopyArray (labels, native_labels);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarData']/method[@name='setLabels' and count(parameter)=1 and parameter[1][@type='java.lang.String...']]"
		[Register ("setLabels", "([Ljava/lang/String;)V", "GetSetLabels_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetLabels (params string[] labels)
		{
			const string __id = "setLabels.([Ljava/lang/String;)V";
			IntPtr native_labels = JNIEnv.NewArray (labels);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_labels);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (labels != null) {
					JNIEnv.CopyArray (native_labels, labels);
					JNIEnv.DeleteLocalRef (native_labels);
				}
			}
		}

	}
}
