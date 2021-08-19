using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Jobs {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='MoveViewJob']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/jobs/MoveViewJob", DoNotGenerateAcw=true)]
	public partial class MoveViewJob : global::MikePhil.Charting.Jobs.ViewPortJob {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/jobs/MoveViewJob", typeof (MoveViewJob));

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

		protected MoveViewJob (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='MoveViewJob']/constructor[@name='MoveViewJob' and count(parameter)=5 and parameter[1][@type='com.github.mikephil.charting.utils.ViewPortHandler'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='com.github.mikephil.charting.utils.Transformer'] and parameter[5][@type='android.view.View']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/utils/ViewPortHandler;FFLcom/github/mikephil/charting/utils/Transformer;Landroid/view/View;)V", "")]
		public unsafe MoveViewJob (global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler, float xValue, float yValue, global::MikePhil.Charting.Util.Transformer trans, global::Android.Views.View v) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/utils/ViewPortHandler;FFLcom/github/mikephil/charting/utils/Transformer;Landroid/view/View;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((viewPortHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPortHandler).Handle);
				__args [1] = new JniArgumentValue (xValue);
				__args [2] = new JniArgumentValue (yValue);
				__args [3] = new JniArgumentValue ((trans == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trans).Handle);
				__args [4] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (viewPortHandler);
				global::System.GC.KeepAlive (trans);
				global::System.GC.KeepAlive (v);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='MoveViewJob']/method[@name='getInstance' and count(parameter)=5 and parameter[1][@type='com.github.mikephil.charting.utils.ViewPortHandler'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='com.github.mikephil.charting.utils.Transformer'] and parameter[5][@type='android.view.View']]"
		[Register ("getInstance", "(Lcom/github/mikephil/charting/utils/ViewPortHandler;FFLcom/github/mikephil/charting/utils/Transformer;Landroid/view/View;)Lcom/github/mikephil/charting/jobs/MoveViewJob;", "")]
		public static unsafe global::MikePhil.Charting.Jobs.MoveViewJob GetInstance (global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler, float xValue, float yValue, global::MikePhil.Charting.Util.Transformer trans, global::Android.Views.View v)
		{
			const string __id = "getInstance.(Lcom/github/mikephil/charting/utils/ViewPortHandler;FFLcom/github/mikephil/charting/utils/Transformer;Landroid/view/View;)Lcom/github/mikephil/charting/jobs/MoveViewJob;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((viewPortHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPortHandler).Handle);
				__args [1] = new JniArgumentValue (xValue);
				__args [2] = new JniArgumentValue (yValue);
				__args [3] = new JniArgumentValue ((trans == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trans).Handle);
				__args [4] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.MoveViewJob> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (viewPortHandler);
				global::System.GC.KeepAlive (trans);
				global::System.GC.KeepAlive (v);
			}
		}

		static Delegate cb_instantiate;
#pragma warning disable 0169
		static Delegate GetInstantiateHandler ()
		{
			if (cb_instantiate == null)
				cb_instantiate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Instantiate);
			return cb_instantiate;
		}

		static IntPtr n_Instantiate (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.MoveViewJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Instantiate ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='MoveViewJob']/method[@name='instantiate' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='MoveViewJob']/method[@name='recycleInstance' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.jobs.MoveViewJob']]"
		[Register ("recycleInstance", "(Lcom/github/mikephil/charting/jobs/MoveViewJob;)V", "")]
		public static unsafe void RecycleInstance (global::MikePhil.Charting.Jobs.MoveViewJob instance)
		{
			const string __id = "recycleInstance.(Lcom/github/mikephil/charting/jobs/MoveViewJob;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((instance == null) ? IntPtr.Zero : ((global::Java.Lang.Object) instance).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (instance);
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.MoveViewJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='MoveViewJob']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public override unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
