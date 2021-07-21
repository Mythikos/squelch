using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ScatterData']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/ScatterData", DoNotGenerateAcw=true)]
	public partial class ScatterData : global::MikePhil.Charting.Data.BarLineScatterCandleBubbleData {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/data/ScatterData", typeof (ScatterData));
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

		protected ScatterData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ScatterData']/constructor[@name='ScatterData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ScatterData ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ScatterData']/constructor[@name='ScatterData' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.interfaces.datasets.IScatterDataSet...']]"
		[Register (".ctor", "([Lcom/github/mikephil/charting/interfaces/datasets/IScatterDataSet;)V", "")]
		public unsafe ScatterData (params global::MikePhil.Charting.Interfaces.Datasets.IScatterDataSet[] dataSets)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Lcom/github/mikephil/charting/interfaces/datasets/IScatterDataSet;)V";

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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ScatterData']/constructor[@name='ScatterData' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.github.mikephil.charting.interfaces.datasets.IScatterDataSet&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe ScatterData (global::System.Collections.Generic.IList<global::MikePhil.Charting.Interfaces.Datasets.IScatterDataSet> dataSets)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_dataSets = global::Android.Runtime.JavaList<global::MikePhil.Charting.Interfaces.Datasets.IScatterDataSet>.ToLocalJniHandle (dataSets);
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

		static Delegate cb_getGreatestShapeSize;
#pragma warning disable 0169
		static Delegate GetGetGreatestShapeSizeHandler ()
		{
			if (cb_getGreatestShapeSize == null)
				cb_getGreatestShapeSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetGreatestShapeSize);
			return cb_getGreatestShapeSize;
		}

		static float n_GetGreatestShapeSize (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.ScatterData __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ScatterData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GreatestShapeSize;
		}
#pragma warning restore 0169

		public virtual unsafe float GreatestShapeSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ScatterData']/method[@name='getGreatestShapeSize' and count(parameter)=0]"
			[Register ("getGreatestShapeSize", "()F", "GetGetGreatestShapeSizeHandler")]
			get {
				const string __id = "getGreatestShapeSize.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
