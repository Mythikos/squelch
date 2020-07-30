using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BubbleData']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/BubbleData", DoNotGenerateAcw=true)]
	public partial class BubbleData : global::MikePhil.Charting.Data.BarLineScatterCandleBubbleData {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/BubbleData", typeof (BubbleData));
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

		protected BubbleData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BubbleData']/constructor[@name='BubbleData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BubbleData ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BubbleData']/constructor[@name='BubbleData' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.interfaces.datasets.IBubbleDataSet...']]"
		[Register (".ctor", "([Lcom/github/mikephil/charting/interfaces/datasets/IBubbleDataSet;)V", "")]
		public unsafe BubbleData (params global::MikePhil.Charting.Interfaces.Datasets.IBubbleDataSet[] dataSets)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Lcom/github/mikephil/charting/interfaces/datasets/IBubbleDataSet;)V";

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BubbleData']/constructor[@name='BubbleData' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.github.mikephil.charting.interfaces.datasets.IBubbleDataSet&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe BubbleData (global::System.Collections.Generic.IList<global::MikePhil.Charting.Interfaces.Datasets.IBubbleDataSet> dataSets)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_dataSets = global::Android.Runtime.JavaList<global::MikePhil.Charting.Interfaces.Datasets.IBubbleDataSet>.ToLocalJniHandle (dataSets);
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

		static Delegate cb_setHighlightCircleWidth_F;
#pragma warning disable 0169
		static Delegate GetSetHighlightCircleWidth_FHandler ()
		{
			if (cb_setHighlightCircleWidth_F == null)
				cb_setHighlightCircleWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetHighlightCircleWidth_F);
			return cb_setHighlightCircleWidth_F;
		}

		static void n_SetHighlightCircleWidth_F (IntPtr jnienv, IntPtr native__this, float width)
		{
			global::MikePhil.Charting.Data.BubbleData __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BubbleData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHighlightCircleWidth (width);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BubbleData']/method[@name='setHighlightCircleWidth' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setHighlightCircleWidth", "(F)V", "GetSetHighlightCircleWidth_FHandler")]
		public virtual unsafe void SetHighlightCircleWidth (float width)
		{
			const string __id = "setHighlightCircleWidth.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (width);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
