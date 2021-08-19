using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Jobs {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='ViewPortJob']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/jobs/ViewPortJob", DoNotGenerateAcw=true)]
	public abstract partial class ViewPortJob : global::MikePhil.Charting.Util.ObjectPool.Poolable, global::Java.Lang.IRunnable {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='ViewPortJob']/field[@name='mTrans']"
		[Register ("mTrans")]
		protected global::MikePhil.Charting.Util.Transformer MTrans {
			get {
				const string __id = "mTrans.Lcom/github/mikephil/charting/utils/Transformer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mTrans.Lcom/github/mikephil/charting/utils/Transformer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='ViewPortJob']/field[@name='mViewPortHandler']"
		[Register ("mViewPortHandler")]
		protected global::MikePhil.Charting.Util.ViewPortHandler MViewPortHandler {
			get {
				const string __id = "mViewPortHandler.Lcom/github/mikephil/charting/utils/ViewPortHandler;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mViewPortHandler.Lcom/github/mikephil/charting/utils/ViewPortHandler;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='ViewPortJob']/field[@name='pts']"
		[Register ("pts")]
		protected IList<float> Pts {
			get {
				const string __id = "pts.[F";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<float>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "pts.[F";

				IntPtr native_value = global::Android.Runtime.JavaArray<float>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='ViewPortJob']/field[@name='view']"
		[Register ("view")]
		protected global::Android.Views.View View {
			get {
				const string __id = "view.Landroid/view/View;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Views.View> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "view.Landroid/view/View;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/jobs/ViewPortJob", typeof (ViewPortJob));

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

		protected ViewPortJob (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='ViewPortJob']/constructor[@name='ViewPortJob' and count(parameter)=5 and parameter[1][@type='com.github.mikephil.charting.utils.ViewPortHandler'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='com.github.mikephil.charting.utils.Transformer'] and parameter[5][@type='android.view.View']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/utils/ViewPortHandler;FFLcom/github/mikephil/charting/utils/Transformer;Landroid/view/View;)V", "")]
		public unsafe ViewPortJob (global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler, float xValue, float yValue, global::MikePhil.Charting.Util.Transformer trans, global::Android.Views.View v) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getXValue;
#pragma warning disable 0169
		static Delegate GetGetXValueHandler ()
		{
			if (cb_getXValue == null)
				cb_getXValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetXValue);
			return cb_getXValue;
		}

		static float n_GetXValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.ViewPortJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XValue;
		}
#pragma warning restore 0169

		public virtual unsafe float XValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='ViewPortJob']/method[@name='getXValue' and count(parameter)=0]"
			[Register ("getXValue", "()F", "GetGetXValueHandler")]
			get {
				const string __id = "getXValue.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getYValue;
#pragma warning disable 0169
		static Delegate GetGetYValueHandler ()
		{
			if (cb_getYValue == null)
				cb_getYValue = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetYValue);
			return cb_getYValue;
		}

		static float n_GetYValue (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.ViewPortJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YValue;
		}
#pragma warning restore 0169

		public virtual unsafe float YValue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='ViewPortJob']/method[@name='getYValue' and count(parameter)=0]"
			[Register ("getYValue", "()F", "GetGetYValueHandler")]
			get {
				const string __id = "getYValue.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.ViewPortJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		[Register ("run", "()V", "GetRunHandler")]
		public abstract void Run ();

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/jobs/ViewPortJob", DoNotGenerateAcw=true)]
	internal partial class ViewPortJobInvoker : ViewPortJob {
		public ViewPortJobInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/jobs/ViewPortJob", typeof (ViewPortJobInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		[Register ("run", "()V", "GetRunHandler")]
		public override unsafe void Run ()
		{
			const string __id = "run.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ObjectPool.Poolable']/method[@name='instantiate' and count(parameter)=0]"
		[Register ("instantiate", "()Lcom/github/mikephil/charting/utils/ObjectPool$Poolable;", "GetInstantiateHandler")]
		protected override unsafe global::MikePhil.Charting.Util.ObjectPool.Poolable Instantiate ()
		{
			const string __id = "instantiate.()Lcom/github/mikephil/charting/utils/ObjectPool$Poolable;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ObjectPool.Poolable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
