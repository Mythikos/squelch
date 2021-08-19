using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieData']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/PieData", DoNotGenerateAcw=true)]
	public partial class PieData : global::MikePhil.Charting.Data.ChartData {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/PieData", typeof (PieData));

		internal static new IntPtr class_ref {
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

		protected PieData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieData']/constructor[@name='PieData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe PieData () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieData']/constructor[@name='PieData' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.interfaces.datasets.IPieDataSet']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/interfaces/datasets/IPieDataSet;)V", "")]
		public unsafe PieData (global::MikePhil.Charting.Interfaces.Datasets.IPieDataSet dataSet) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/interfaces/datasets/IPieDataSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSet).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (dataSet);
			}
		}

		static Delegate cb_getDataSet;
#pragma warning disable 0169
		static Delegate GetGetDataSetHandler ()
		{
			if (cb_getDataSet == null)
				cb_getDataSet = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDataSet);
			return cb_getDataSet;
		}

		static IntPtr n_GetDataSet (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DataSet);
		}
#pragma warning restore 0169

		static Delegate cb_setDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IPieDataSet_;
#pragma warning disable 0169
		static Delegate GetSetDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IPieDataSet_Handler ()
		{
			if (cb_setDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IPieDataSet_ == null)
				cb_setDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IPieDataSet_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IPieDataSet_);
			return cb_setDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IPieDataSet_;
		}

		static void n_SetDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IPieDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dataSet)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dataSet = (global::MikePhil.Charting.Interfaces.Datasets.IPieDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IPieDataSet> (native_dataSet, JniHandleOwnership.DoNotTransfer);
			__this.DataSet = dataSet;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Interfaces.Datasets.IPieDataSet DataSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieData']/method[@name='getDataSet' and count(parameter)=0]"
			[Register ("getDataSet", "()Lcom/github/mikephil/charting/interfaces/datasets/IPieDataSet;", "GetGetDataSetHandler")]
			get {
				const string __id = "getDataSet.()Lcom/github/mikephil/charting/interfaces/datasets/IPieDataSet;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IPieDataSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieData']/method[@name='setDataSet' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.interfaces.datasets.IPieDataSet']]"
			[Register ("setDataSet", "(Lcom/github/mikephil/charting/interfaces/datasets/IPieDataSet;)V", "GetSetDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IPieDataSet_Handler")]
			set {
				const string __id = "setDataSet.(Lcom/github/mikephil/charting/interfaces/datasets/IPieDataSet;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getYValueSum;
#pragma warning disable 0169
		static Delegate GetGetYValueSumHandler ()
		{
			if (cb_getYValueSum == null)
				cb_getYValueSum = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetYValueSum);
			return cb_getYValueSum;
		}

		static float n_GetYValueSum (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YValueSum;
		}
#pragma warning restore 0169

		public virtual unsafe float YValueSum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieData']/method[@name='getYValueSum' and count(parameter)=0]"
			[Register ("getYValueSum", "()F", "GetGetYValueSumHandler")]
			get {
				const string __id = "getYValueSum.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
