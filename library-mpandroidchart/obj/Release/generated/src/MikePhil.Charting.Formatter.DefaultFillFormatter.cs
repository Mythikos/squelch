using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Formatter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='DefaultFillFormatter']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/formatter/DefaultFillFormatter", DoNotGenerateAcw=true)]
	public partial class DefaultFillFormatter : global::Java.Lang.Object, global::MikePhil.Charting.Formatter.IFillFormatter {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/formatter/DefaultFillFormatter", typeof (DefaultFillFormatter));
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

		protected DefaultFillFormatter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='DefaultFillFormatter']/constructor[@name='DefaultFillFormatter' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DefaultFillFormatter ()
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

		static Delegate cb_getFillLinePosition_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_interfaces_dataprovider_LineDataProvider_;
#pragma warning disable 0169
		static Delegate GetGetFillLinePosition_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_interfaces_dataprovider_LineDataProvider_Handler ()
		{
			if (cb_getFillLinePosition_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_interfaces_dataprovider_LineDataProvider_ == null)
				cb_getFillLinePosition_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_interfaces_dataprovider_LineDataProvider_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, float>) n_GetFillLinePosition_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_interfaces_dataprovider_LineDataProvider_);
			return cb_getFillLinePosition_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_interfaces_dataprovider_LineDataProvider_;
		}

		static float n_GetFillLinePosition_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_interfaces_dataprovider_LineDataProvider_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dataSet, IntPtr native_dataProvider)
		{
			global::MikePhil.Charting.Formatter.DefaultFillFormatter __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.DefaultFillFormatter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet dataSet = (global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (native_dataSet, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Interfaces.Dataprovider.ILineDataProvider dataProvider = (global::MikePhil.Charting.Interfaces.Dataprovider.ILineDataProvider)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ILineDataProvider> (native_dataProvider, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetFillLinePosition (dataSet, dataProvider);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.formatter']/class[@name='DefaultFillFormatter']/method[@name='getFillLinePosition' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.interfaces.datasets.ILineDataSet'] and parameter[2][@type='com.github.mikephil.charting.interfaces.dataprovider.LineDataProvider']]"
		[Register ("getFillLinePosition", "(Lcom/github/mikephil/charting/interfaces/datasets/ILineDataSet;Lcom/github/mikephil/charting/interfaces/dataprovider/LineDataProvider;)F", "GetGetFillLinePosition_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_interfaces_dataprovider_LineDataProvider_Handler")]
		public virtual unsafe float GetFillLinePosition (global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet dataSet, global::MikePhil.Charting.Interfaces.Dataprovider.ILineDataProvider dataProvider)
		{
			const string __id = "getFillLinePosition.(Lcom/github/mikephil/charting/interfaces/datasets/ILineDataSet;Lcom/github/mikephil/charting/interfaces/dataprovider/LineDataProvider;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((dataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSet).Handle);
				__args [1] = new JniArgumentValue ((dataProvider == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataProvider).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
