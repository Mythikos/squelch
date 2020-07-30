using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleData']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/CandleData", DoNotGenerateAcw=true)]
	public partial class CandleData : global::MikePhil.Charting.Data.BarLineScatterCandleBubbleData {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/CandleData", typeof (CandleData));
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

		protected CandleData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleData']/constructor[@name='CandleData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CandleData ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleData']/constructor[@name='CandleData' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.interfaces.datasets.ICandleDataSet...']]"
		[Register (".ctor", "([Lcom/github/mikephil/charting/interfaces/datasets/ICandleDataSet;)V", "")]
		public unsafe CandleData (params global::MikePhil.Charting.Interfaces.Datasets.ICandleDataSet[] dataSets)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Lcom/github/mikephil/charting/interfaces/datasets/ICandleDataSet;)V";

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleData']/constructor[@name='CandleData' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.github.mikephil.charting.interfaces.datasets.ICandleDataSet&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe CandleData (global::System.Collections.Generic.IList<global::MikePhil.Charting.Interfaces.Datasets.ICandleDataSet> dataSets)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_dataSets = global::Android.Runtime.JavaList<global::MikePhil.Charting.Interfaces.Datasets.ICandleDataSet>.ToLocalJniHandle (dataSets);
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

	}
}
