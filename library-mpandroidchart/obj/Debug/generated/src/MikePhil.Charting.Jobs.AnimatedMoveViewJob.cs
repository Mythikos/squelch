using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Jobs {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedMoveViewJob']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/jobs/AnimatedMoveViewJob", DoNotGenerateAcw=true)]
	public partial class AnimatedMoveViewJob : global::MikePhil.Charting.Jobs.AnimatedViewPortJob {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/jobs/AnimatedMoveViewJob", typeof (AnimatedMoveViewJob));
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

		protected AnimatedMoveViewJob (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedMoveViewJob']/constructor[@name='AnimatedMoveViewJob' and count(parameter)=8 and parameter[1][@type='com.github.mikephil.charting.utils.ViewPortHandler'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='com.github.mikephil.charting.utils.Transformer'] and parameter[5][@type='android.view.View'] and parameter[6][@type='float'] and parameter[7][@type='float'] and parameter[8][@type='long']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/utils/ViewPortHandler;FFLcom/github/mikephil/charting/utils/Transformer;Landroid/view/View;FFJ)V", "")]
		public unsafe AnimatedMoveViewJob (global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler, float xValue, float yValue, global::MikePhil.Charting.Util.Transformer trans, global::Android.Views.View v, float xOrigin, float yOrigin, long duration)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/utils/ViewPortHandler;FFLcom/github/mikephil/charting/utils/Transformer;Landroid/view/View;FFJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((viewPortHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPortHandler).Handle);
				__args [1] = new JniArgumentValue (xValue);
				__args [2] = new JniArgumentValue (yValue);
				__args [3] = new JniArgumentValue ((trans == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trans).Handle);
				__args [4] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				__args [5] = new JniArgumentValue (xOrigin);
				__args [6] = new JniArgumentValue (yOrigin);
				__args [7] = new JniArgumentValue (duration);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedMoveViewJob']/method[@name='getInstance' and count(parameter)=8 and parameter[1][@type='com.github.mikephil.charting.utils.ViewPortHandler'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='com.github.mikephil.charting.utils.Transformer'] and parameter[5][@type='android.view.View'] and parameter[6][@type='float'] and parameter[7][@type='float'] and parameter[8][@type='long']]"
		[Register ("getInstance", "(Lcom/github/mikephil/charting/utils/ViewPortHandler;FFLcom/github/mikephil/charting/utils/Transformer;Landroid/view/View;FFJ)Lcom/github/mikephil/charting/jobs/AnimatedMoveViewJob;", "")]
		public static unsafe global::MikePhil.Charting.Jobs.AnimatedMoveViewJob GetInstance (global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler, float xValue, float yValue, global::MikePhil.Charting.Util.Transformer trans, global::Android.Views.View v, float xOrigin, float yOrigin, long duration)
		{
			const string __id = "getInstance.(Lcom/github/mikephil/charting/utils/ViewPortHandler;FFLcom/github/mikephil/charting/utils/Transformer;Landroid/view/View;FFJ)Lcom/github/mikephil/charting/jobs/AnimatedMoveViewJob;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((viewPortHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPortHandler).Handle);
				__args [1] = new JniArgumentValue (xValue);
				__args [2] = new JniArgumentValue (yValue);
				__args [3] = new JniArgumentValue ((trans == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trans).Handle);
				__args [4] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				__args [5] = new JniArgumentValue (xOrigin);
				__args [6] = new JniArgumentValue (yOrigin);
				__args [7] = new JniArgumentValue (duration);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.AnimatedMoveViewJob> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_instantiate;
#pragma warning disable 0169
		static Delegate GetInstantiateHandler ()
		{
			if (cb_instantiate == null)
				cb_instantiate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Instantiate);
			return cb_instantiate;
		}

		static IntPtr n_Instantiate (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Jobs.AnimatedMoveViewJob __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.AnimatedMoveViewJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Instantiate ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedMoveViewJob']/method[@name='instantiate' and count(parameter)=0]"
		[Register ("instantiate", "()Lcom/github/mikephil/charting/utils/ObjectPool$Poolable;", "GetInstantiateHandler")]
		protected override unsafe global::MikePhil.Charting.Util.ObjectPool.Poolable Instantiate ()
		{
			const string __id = "instantiate.()Lcom/github/mikephil/charting/utils/ObjectPool$Poolable;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ObjectPool.Poolable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedMoveViewJob']/method[@name='recycleInstance' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.jobs.AnimatedMoveViewJob']]"
		[Register ("recycleInstance", "(Lcom/github/mikephil/charting/jobs/AnimatedMoveViewJob;)V", "")]
		public static unsafe void RecycleInstance (global::MikePhil.Charting.Jobs.AnimatedMoveViewJob instance)
		{
			const string __id = "recycleInstance.(Lcom/github/mikephil/charting/jobs/AnimatedMoveViewJob;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((instance == null) ? IntPtr.Zero : ((global::Java.Lang.Object) instance).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		static Delegate cb_recycleSelf;
#pragma warning disable 0169
		static Delegate GetRecycleSelfHandler ()
		{
			if (cb_recycleSelf == null)
				cb_recycleSelf = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RecycleSelf);
			return cb_recycleSelf;
		}

		static void n_RecycleSelf (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Jobs.AnimatedMoveViewJob __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.AnimatedMoveViewJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecycleSelf ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedMoveViewJob']/method[@name='recycleSelf' and count(parameter)=0]"
		[Register ("recycleSelf", "()V", "GetRecycleSelfHandler")]
		public override unsafe void RecycleSelf ()
		{
			const string __id = "recycleSelf.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
