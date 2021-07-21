using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Jobs {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='ZoomJob']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/jobs/ZoomJob", DoNotGenerateAcw=true)]
	public partial class ZoomJob : global::MikePhil.Charting.Jobs.ViewPortJob {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='ZoomJob']/field[@name='axisDependency']"
		[Register ("axisDependency")]
		protected global::MikePhil.Charting.Components.YAxis.AxisDependency AxisDependency {
			get {
				const string __id = "axisDependency.Lcom/github/mikephil/charting/components/YAxis$AxisDependency;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "axisDependency.Lcom/github/mikephil/charting/components/YAxis$AxisDependency;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='ZoomJob']/field[@name='mRunMatrixBuffer']"
		[Register ("mRunMatrixBuffer")]
		protected global::Android.Graphics.Matrix MRunMatrixBuffer {
			get {
				const string __id = "mRunMatrixBuffer.Landroid/graphics/Matrix;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mRunMatrixBuffer.Landroid/graphics/Matrix;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='ZoomJob']/field[@name='scaleX']"
		[Register ("scaleX")]
		protected float ScaleX {
			get {
				const string __id = "scaleX.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "scaleX.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='ZoomJob']/field[@name='scaleY']"
		[Register ("scaleY")]
		protected float ScaleY {
			get {
				const string __id = "scaleY.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "scaleY.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/jobs/ZoomJob", typeof (ZoomJob));
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

		protected ZoomJob (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='ZoomJob']/constructor[@name='ZoomJob' and count(parameter)=8 and parameter[1][@type='com.github.mikephil.charting.utils.ViewPortHandler'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='com.github.mikephil.charting.utils.Transformer'] and parameter[7][@type='com.github.mikephil.charting.components.YAxis.AxisDependency'] and parameter[8][@type='android.view.View']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/utils/ViewPortHandler;FFFFLcom/github/mikephil/charting/utils/Transformer;Lcom/github/mikephil/charting/components/YAxis$AxisDependency;Landroid/view/View;)V", "")]
		public unsafe ZoomJob (global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler, float scaleX, float scaleY, float xValue, float yValue, global::MikePhil.Charting.Util.Transformer trans, global::MikePhil.Charting.Components.YAxis.AxisDependency axis, global::Android.Views.View v)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/utils/ViewPortHandler;FFFFLcom/github/mikephil/charting/utils/Transformer;Lcom/github/mikephil/charting/components/YAxis$AxisDependency;Landroid/view/View;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((viewPortHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPortHandler).Handle);
				__args [1] = new JniArgumentValue (scaleX);
				__args [2] = new JniArgumentValue (scaleY);
				__args [3] = new JniArgumentValue (xValue);
				__args [4] = new JniArgumentValue (yValue);
				__args [5] = new JniArgumentValue ((trans == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trans).Handle);
				__args [6] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				__args [7] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='ZoomJob']/method[@name='getInstance' and count(parameter)=8 and parameter[1][@type='com.github.mikephil.charting.utils.ViewPortHandler'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='com.github.mikephil.charting.utils.Transformer'] and parameter[7][@type='com.github.mikephil.charting.components.YAxis.AxisDependency'] and parameter[8][@type='android.view.View']]"
		[Register ("getInstance", "(Lcom/github/mikephil/charting/utils/ViewPortHandler;FFFFLcom/github/mikephil/charting/utils/Transformer;Lcom/github/mikephil/charting/components/YAxis$AxisDependency;Landroid/view/View;)Lcom/github/mikephil/charting/jobs/ZoomJob;", "")]
		public static unsafe global::MikePhil.Charting.Jobs.ZoomJob GetInstance (global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler, float scaleX, float scaleY, float xValue, float yValue, global::MikePhil.Charting.Util.Transformer trans, global::MikePhil.Charting.Components.YAxis.AxisDependency axis, global::Android.Views.View v)
		{
			const string __id = "getInstance.(Lcom/github/mikephil/charting/utils/ViewPortHandler;FFFFLcom/github/mikephil/charting/utils/Transformer;Lcom/github/mikephil/charting/components/YAxis$AxisDependency;Landroid/view/View;)Lcom/github/mikephil/charting/jobs/ZoomJob;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((viewPortHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPortHandler).Handle);
				__args [1] = new JniArgumentValue (scaleX);
				__args [2] = new JniArgumentValue (scaleY);
				__args [3] = new JniArgumentValue (xValue);
				__args [4] = new JniArgumentValue (yValue);
				__args [5] = new JniArgumentValue ((trans == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trans).Handle);
				__args [6] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				__args [7] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.ZoomJob> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::MikePhil.Charting.Jobs.ZoomJob __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.ZoomJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Instantiate ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='ZoomJob']/method[@name='instantiate' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='ZoomJob']/method[@name='recycleInstance' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.jobs.ZoomJob']]"
		[Register ("recycleInstance", "(Lcom/github/mikephil/charting/jobs/ZoomJob;)V", "")]
		public static unsafe void RecycleInstance (global::MikePhil.Charting.Jobs.ZoomJob instance)
		{
			const string __id = "recycleInstance.(Lcom/github/mikephil/charting/jobs/ZoomJob;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((instance == null) ? IntPtr.Zero : ((global::Java.Lang.Object) instance).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Jobs.ZoomJob __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.ZoomJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='ZoomJob']/method[@name='run' and count(parameter)=0]"
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
