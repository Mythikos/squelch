using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarLineScatterCandleBubbleData']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/BarLineScatterCandleBubbleData", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.github.mikephil.charting.interfaces.datasets.IBarLineScatterCandleBubbleDataSet<? extends com.github.mikephil.charting.data.Entry>"})]
	public abstract partial class BarLineScatterCandleBubbleData : global::MikePhil.Charting.Data.ChartData {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/BarLineScatterCandleBubbleData", typeof (BarLineScatterCandleBubbleData));
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

		protected BarLineScatterCandleBubbleData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarLineScatterCandleBubbleData']/constructor[@name='BarLineScatterCandleBubbleData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BarLineScatterCandleBubbleData ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarLineScatterCandleBubbleData']/constructor[@name='BarLineScatterCandleBubbleData' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;T&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe BarLineScatterCandleBubbleData (global::System.Collections.IList sets)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_sets = global::Android.Runtime.JavaList.ToLocalJniHandle (sets);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sets);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sets);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarLineScatterCandleBubbleData']/constructor[@name='BarLineScatterCandleBubbleData' and count(parameter)=1 and parameter[1][@type='T...']]"
		[Register (".ctor", "([Lcom/github/mikephil/charting/interfaces/datasets/IBarLineScatterCandleBubbleDataSet;)V", "")]
		public unsafe BarLineScatterCandleBubbleData (params global::Java.Lang.Object[] sets)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Lcom/github/mikephil/charting/interfaces/datasets/IBarLineScatterCandleBubbleDataSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_sets = JNIEnv.NewArray (sets);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sets);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (sets != null) {
					JNIEnv.CopyArray (native_sets, sets);
					JNIEnv.DeleteLocalRef (native_sets);
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/BarLineScatterCandleBubbleData", DoNotGenerateAcw=true)]
	internal partial class BarLineScatterCandleBubbleDataInvoker : BarLineScatterCandleBubbleData {

		public BarLineScatterCandleBubbleDataInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/BarLineScatterCandleBubbleData", typeof (BarLineScatterCandleBubbleDataInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
