using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Jobs {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedZoomJob']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/jobs/AnimatedZoomJob", DoNotGenerateAcw=true)]
	public partial class AnimatedZoomJob : global::MikePhil.Charting.Jobs.AnimatedViewPortJob, global::Android.Animation.Animator.IAnimatorListener {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedZoomJob']/field[@name='mOnAnimationUpdateMatrixBuffer']"
		[Register ("mOnAnimationUpdateMatrixBuffer")]
		protected global::Android.Graphics.Matrix MOnAnimationUpdateMatrixBuffer {
			get {
				const string __id = "mOnAnimationUpdateMatrixBuffer.Landroid/graphics/Matrix;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mOnAnimationUpdateMatrixBuffer.Landroid/graphics/Matrix;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedZoomJob']/field[@name='xAxisRange']"
		[Register ("xAxisRange")]
		protected float XAxisRange {
			get {
				const string __id = "xAxisRange.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "xAxisRange.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedZoomJob']/field[@name='yAxis']"
		[Register ("yAxis")]
		protected global::MikePhil.Charting.Components.YAxis YAxis {
			get {
				const string __id = "yAxis.Lcom/github/mikephil/charting/components/YAxis;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "yAxis.Lcom/github/mikephil/charting/components/YAxis;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedZoomJob']/field[@name='zoomCenterX']"
		[Register ("zoomCenterX")]
		protected float ZoomCenterX {
			get {
				const string __id = "zoomCenterX.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "zoomCenterX.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedZoomJob']/field[@name='zoomCenterY']"
		[Register ("zoomCenterY")]
		protected float ZoomCenterY {
			get {
				const string __id = "zoomCenterY.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "zoomCenterY.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedZoomJob']/field[@name='zoomOriginX']"
		[Register ("zoomOriginX")]
		protected float ZoomOriginX {
			get {
				const string __id = "zoomOriginX.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "zoomOriginX.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedZoomJob']/field[@name='zoomOriginY']"
		[Register ("zoomOriginY")]
		protected float ZoomOriginY {
			get {
				const string __id = "zoomOriginY.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "zoomOriginY.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/jobs/AnimatedZoomJob", typeof (AnimatedZoomJob));

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

		protected AnimatedZoomJob (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedZoomJob']/constructor[@name='AnimatedZoomJob' and count(parameter)=14 and parameter[1][@type='com.github.mikephil.charting.utils.ViewPortHandler'] and parameter[2][@type='android.view.View'] and parameter[3][@type='com.github.mikephil.charting.utils.Transformer'] and parameter[4][@type='com.github.mikephil.charting.components.YAxis'] and parameter[5][@type='float'] and parameter[6][@type='float'] and parameter[7][@type='float'] and parameter[8][@type='float'] and parameter[9][@type='float'] and parameter[10][@type='float'] and parameter[11][@type='float'] and parameter[12][@type='float'] and parameter[13][@type='float'] and parameter[14][@type='long']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/utils/ViewPortHandler;Landroid/view/View;Lcom/github/mikephil/charting/utils/Transformer;Lcom/github/mikephil/charting/components/YAxis;FFFFFFFFFJ)V", "")]
		public unsafe AnimatedZoomJob (global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler, global::Android.Views.View v, global::MikePhil.Charting.Util.Transformer trans, global::MikePhil.Charting.Components.YAxis axis, float xAxisRange, float scaleX, float scaleY, float xOrigin, float yOrigin, float zoomCenterX, float zoomCenterY, float zoomOriginX, float zoomOriginY, long duration) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/utils/ViewPortHandler;Landroid/view/View;Lcom/github/mikephil/charting/utils/Transformer;Lcom/github/mikephil/charting/components/YAxis;FFFFFFFFFJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [14];
				__args [0] = new JniArgumentValue ((viewPortHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPortHandler).Handle);
				__args [1] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				__args [2] = new JniArgumentValue ((trans == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trans).Handle);
				__args [3] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				__args [4] = new JniArgumentValue (xAxisRange);
				__args [5] = new JniArgumentValue (scaleX);
				__args [6] = new JniArgumentValue (scaleY);
				__args [7] = new JniArgumentValue (xOrigin);
				__args [8] = new JniArgumentValue (yOrigin);
				__args [9] = new JniArgumentValue (zoomCenterX);
				__args [10] = new JniArgumentValue (zoomCenterY);
				__args [11] = new JniArgumentValue (zoomOriginX);
				__args [12] = new JniArgumentValue (zoomOriginY);
				__args [13] = new JniArgumentValue (duration);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (viewPortHandler);
				global::System.GC.KeepAlive (v);
				global::System.GC.KeepAlive (trans);
				global::System.GC.KeepAlive (axis);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedZoomJob']/method[@name='getInstance' and count(parameter)=14 and parameter[1][@type='com.github.mikephil.charting.utils.ViewPortHandler'] and parameter[2][@type='android.view.View'] and parameter[3][@type='com.github.mikephil.charting.utils.Transformer'] and parameter[4][@type='com.github.mikephil.charting.components.YAxis'] and parameter[5][@type='float'] and parameter[6][@type='float'] and parameter[7][@type='float'] and parameter[8][@type='float'] and parameter[9][@type='float'] and parameter[10][@type='float'] and parameter[11][@type='float'] and parameter[12][@type='float'] and parameter[13][@type='float'] and parameter[14][@type='long']]"
		[Register ("getInstance", "(Lcom/github/mikephil/charting/utils/ViewPortHandler;Landroid/view/View;Lcom/github/mikephil/charting/utils/Transformer;Lcom/github/mikephil/charting/components/YAxis;FFFFFFFFFJ)Lcom/github/mikephil/charting/jobs/AnimatedZoomJob;", "")]
		public static unsafe global::MikePhil.Charting.Jobs.AnimatedZoomJob GetInstance (global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler, global::Android.Views.View v, global::MikePhil.Charting.Util.Transformer trans, global::MikePhil.Charting.Components.YAxis axis, float xAxisRange, float scaleX, float scaleY, float xOrigin, float yOrigin, float zoomCenterX, float zoomCenterY, float zoomOriginX, float zoomOriginY, long duration)
		{
			const string __id = "getInstance.(Lcom/github/mikephil/charting/utils/ViewPortHandler;Landroid/view/View;Lcom/github/mikephil/charting/utils/Transformer;Lcom/github/mikephil/charting/components/YAxis;FFFFFFFFFJ)Lcom/github/mikephil/charting/jobs/AnimatedZoomJob;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [14];
				__args [0] = new JniArgumentValue ((viewPortHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPortHandler).Handle);
				__args [1] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				__args [2] = new JniArgumentValue ((trans == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trans).Handle);
				__args [3] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				__args [4] = new JniArgumentValue (xAxisRange);
				__args [5] = new JniArgumentValue (scaleX);
				__args [6] = new JniArgumentValue (scaleY);
				__args [7] = new JniArgumentValue (xOrigin);
				__args [8] = new JniArgumentValue (yOrigin);
				__args [9] = new JniArgumentValue (zoomCenterX);
				__args [10] = new JniArgumentValue (zoomCenterY);
				__args [11] = new JniArgumentValue (zoomOriginX);
				__args [12] = new JniArgumentValue (zoomOriginY);
				__args [13] = new JniArgumentValue (duration);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.AnimatedZoomJob> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (viewPortHandler);
				global::System.GC.KeepAlive (v);
				global::System.GC.KeepAlive (trans);
				global::System.GC.KeepAlive (axis);
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
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.AnimatedZoomJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Instantiate ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedZoomJob']/method[@name='instantiate' and count(parameter)=0]"
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

		static Delegate cb_recycleSelf;
#pragma warning disable 0169
		static Delegate GetRecycleSelfHandler ()
		{
			if (cb_recycleSelf == null)
				cb_recycleSelf = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_RecycleSelf);
			return cb_recycleSelf;
		}

		static void n_RecycleSelf (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.AnimatedZoomJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecycleSelf ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedZoomJob']/method[@name='recycleSelf' and count(parameter)=0]"
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
