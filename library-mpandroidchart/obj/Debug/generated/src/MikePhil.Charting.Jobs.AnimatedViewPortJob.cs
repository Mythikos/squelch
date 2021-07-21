using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Jobs {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedViewPortJob']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/jobs/AnimatedViewPortJob", DoNotGenerateAcw=true)]
	public abstract partial class AnimatedViewPortJob : global::MikePhil.Charting.Jobs.ViewPortJob, global::Android.Animation.Animator.IAnimatorListener, global::Android.Animation.ValueAnimator.IAnimatorUpdateListener {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedViewPortJob']/field[@name='animator']"
		[Register ("animator")]
		protected global::Android.Animation.ObjectAnimator Animator {
			get {
				const string __id = "animator.Landroid/animation/ObjectAnimator;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Animation.ObjectAnimator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "animator.Landroid/animation/ObjectAnimator;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/jobs/AnimatedViewPortJob", typeof (AnimatedViewPortJob));
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

		protected AnimatedViewPortJob (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedViewPortJob']/constructor[@name='AnimatedViewPortJob' and count(parameter)=8 and parameter[1][@type='com.github.mikephil.charting.utils.ViewPortHandler'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='com.github.mikephil.charting.utils.Transformer'] and parameter[5][@type='android.view.View'] and parameter[6][@type='float'] and parameter[7][@type='float'] and parameter[8][@type='long']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/utils/ViewPortHandler;FFLcom/github/mikephil/charting/utils/Transformer;Landroid/view/View;FFJ)V", "")]
		public unsafe AnimatedViewPortJob (global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler, float xValue, float yValue, global::MikePhil.Charting.Util.Transformer trans, global::Android.Views.View v, float xOrigin, float yOrigin, long duration)
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

		static Delegate cb_getPhase;
#pragma warning disable 0169
		static Delegate GetGetPhaseHandler ()
		{
			if (cb_getPhase == null)
				cb_getPhase = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPhase);
			return cb_getPhase;
		}

		static float n_GetPhase (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Jobs.AnimatedViewPortJob __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.AnimatedViewPortJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Phase;
		}
#pragma warning restore 0169

		static Delegate cb_setPhase_F;
#pragma warning disable 0169
		static Delegate GetSetPhase_FHandler ()
		{
			if (cb_setPhase_F == null)
				cb_setPhase_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetPhase_F);
			return cb_setPhase_F;
		}

		static void n_SetPhase_F (IntPtr jnienv, IntPtr native__this, float phase)
		{
			global::MikePhil.Charting.Jobs.AnimatedViewPortJob __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.AnimatedViewPortJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Phase = phase;
		}
#pragma warning restore 0169

		public virtual unsafe float Phase {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedViewPortJob']/method[@name='getPhase' and count(parameter)=0]"
			[Register ("getPhase", "()F", "GetGetPhaseHandler")]
			get {
				const string __id = "getPhase.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedViewPortJob']/method[@name='setPhase' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setPhase", "(F)V", "GetSetPhase_FHandler")]
			set {
				const string __id = "setPhase.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getXOrigin;
#pragma warning disable 0169
		static Delegate GetGetXOriginHandler ()
		{
			if (cb_getXOrigin == null)
				cb_getXOrigin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetXOrigin);
			return cb_getXOrigin;
		}

		static float n_GetXOrigin (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Jobs.AnimatedViewPortJob __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.AnimatedViewPortJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XOrigin;
		}
#pragma warning restore 0169

		public virtual unsafe float XOrigin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedViewPortJob']/method[@name='getXOrigin' and count(parameter)=0]"
			[Register ("getXOrigin", "()F", "GetGetXOriginHandler")]
			get {
				const string __id = "getXOrigin.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getYOrigin;
#pragma warning disable 0169
		static Delegate GetGetYOriginHandler ()
		{
			if (cb_getYOrigin == null)
				cb_getYOrigin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetYOrigin);
			return cb_getYOrigin;
		}

		static float n_GetYOrigin (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Jobs.AnimatedViewPortJob __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.AnimatedViewPortJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YOrigin;
		}
#pragma warning restore 0169

		public virtual unsafe float YOrigin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedViewPortJob']/method[@name='getYOrigin' and count(parameter)=0]"
			[Register ("getYOrigin", "()F", "GetGetYOriginHandler")]
			get {
				const string __id = "getYOrigin.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_onAnimationCancel_Landroid_animation_Animator_;
#pragma warning disable 0169
		static Delegate GetOnAnimationCancel_Landroid_animation_Animator_Handler ()
		{
			if (cb_onAnimationCancel_Landroid_animation_Animator_ == null)
				cb_onAnimationCancel_Landroid_animation_Animator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationCancel_Landroid_animation_Animator_);
			return cb_onAnimationCancel_Landroid_animation_Animator_;
		}

		static void n_OnAnimationCancel_Landroid_animation_Animator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
		{
			global::MikePhil.Charting.Jobs.AnimatedViewPortJob __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.AnimatedViewPortJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Animation.Animator animation = global::Java.Lang.Object.GetObject<global::Android.Animation.Animator> (native_animation, JniHandleOwnership.DoNotTransfer);
			__this.OnAnimationCancel (animation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedViewPortJob']/method[@name='onAnimationCancel' and count(parameter)=1 and parameter[1][@type='android.animation.Animator']]"
		[Register ("onAnimationCancel", "(Landroid/animation/Animator;)V", "GetOnAnimationCancel_Landroid_animation_Animator_Handler")]
		public virtual unsafe void OnAnimationCancel (global::Android.Animation.Animator animation)
		{
			const string __id = "onAnimationCancel.(Landroid/animation/Animator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((animation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) animation).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onAnimationEnd_Landroid_animation_Animator_;
#pragma warning disable 0169
		static Delegate GetOnAnimationEnd_Landroid_animation_Animator_Handler ()
		{
			if (cb_onAnimationEnd_Landroid_animation_Animator_ == null)
				cb_onAnimationEnd_Landroid_animation_Animator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationEnd_Landroid_animation_Animator_);
			return cb_onAnimationEnd_Landroid_animation_Animator_;
		}

		static void n_OnAnimationEnd_Landroid_animation_Animator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
		{
			global::MikePhil.Charting.Jobs.AnimatedViewPortJob __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.AnimatedViewPortJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Animation.Animator animation = global::Java.Lang.Object.GetObject<global::Android.Animation.Animator> (native_animation, JniHandleOwnership.DoNotTransfer);
			__this.OnAnimationEnd (animation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedViewPortJob']/method[@name='onAnimationEnd' and count(parameter)=1 and parameter[1][@type='android.animation.Animator']]"
		[Register ("onAnimationEnd", "(Landroid/animation/Animator;)V", "GetOnAnimationEnd_Landroid_animation_Animator_Handler")]
		public virtual unsafe void OnAnimationEnd (global::Android.Animation.Animator animation)
		{
			const string __id = "onAnimationEnd.(Landroid/animation/Animator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((animation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) animation).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onAnimationRepeat_Landroid_animation_Animator_;
#pragma warning disable 0169
		static Delegate GetOnAnimationRepeat_Landroid_animation_Animator_Handler ()
		{
			if (cb_onAnimationRepeat_Landroid_animation_Animator_ == null)
				cb_onAnimationRepeat_Landroid_animation_Animator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationRepeat_Landroid_animation_Animator_);
			return cb_onAnimationRepeat_Landroid_animation_Animator_;
		}

		static void n_OnAnimationRepeat_Landroid_animation_Animator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
		{
			global::MikePhil.Charting.Jobs.AnimatedViewPortJob __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.AnimatedViewPortJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Animation.Animator animation = global::Java.Lang.Object.GetObject<global::Android.Animation.Animator> (native_animation, JniHandleOwnership.DoNotTransfer);
			__this.OnAnimationRepeat (animation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedViewPortJob']/method[@name='onAnimationRepeat' and count(parameter)=1 and parameter[1][@type='android.animation.Animator']]"
		[Register ("onAnimationRepeat", "(Landroid/animation/Animator;)V", "GetOnAnimationRepeat_Landroid_animation_Animator_Handler")]
		public virtual unsafe void OnAnimationRepeat (global::Android.Animation.Animator animation)
		{
			const string __id = "onAnimationRepeat.(Landroid/animation/Animator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((animation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) animation).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onAnimationStart_Landroid_animation_Animator_;
#pragma warning disable 0169
		static Delegate GetOnAnimationStart_Landroid_animation_Animator_Handler ()
		{
			if (cb_onAnimationStart_Landroid_animation_Animator_ == null)
				cb_onAnimationStart_Landroid_animation_Animator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationStart_Landroid_animation_Animator_);
			return cb_onAnimationStart_Landroid_animation_Animator_;
		}

		static void n_OnAnimationStart_Landroid_animation_Animator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
		{
			global::MikePhil.Charting.Jobs.AnimatedViewPortJob __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.AnimatedViewPortJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Animation.Animator animation = global::Java.Lang.Object.GetObject<global::Android.Animation.Animator> (native_animation, JniHandleOwnership.DoNotTransfer);
			__this.OnAnimationStart (animation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedViewPortJob']/method[@name='onAnimationStart' and count(parameter)=1 and parameter[1][@type='android.animation.Animator']]"
		[Register ("onAnimationStart", "(Landroid/animation/Animator;)V", "GetOnAnimationStart_Landroid_animation_Animator_Handler")]
		public virtual unsafe void OnAnimationStart (global::Android.Animation.Animator animation)
		{
			const string __id = "onAnimationStart.(Landroid/animation/Animator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((animation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) animation).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_onAnimationUpdate_Landroid_animation_ValueAnimator_;
#pragma warning disable 0169
		static Delegate GetOnAnimationUpdate_Landroid_animation_ValueAnimator_Handler ()
		{
			if (cb_onAnimationUpdate_Landroid_animation_ValueAnimator_ == null)
				cb_onAnimationUpdate_Landroid_animation_ValueAnimator_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnAnimationUpdate_Landroid_animation_ValueAnimator_);
			return cb_onAnimationUpdate_Landroid_animation_ValueAnimator_;
		}

		static void n_OnAnimationUpdate_Landroid_animation_ValueAnimator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_animation)
		{
			global::MikePhil.Charting.Jobs.AnimatedViewPortJob __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.AnimatedViewPortJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Animation.ValueAnimator animation = global::Java.Lang.Object.GetObject<global::Android.Animation.ValueAnimator> (native_animation, JniHandleOwnership.DoNotTransfer);
			__this.OnAnimationUpdate (animation);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedViewPortJob']/method[@name='onAnimationUpdate' and count(parameter)=1 and parameter[1][@type='android.animation.ValueAnimator']]"
		[Register ("onAnimationUpdate", "(Landroid/animation/ValueAnimator;)V", "GetOnAnimationUpdate_Landroid_animation_ValueAnimator_Handler")]
		public virtual unsafe void OnAnimationUpdate (global::Android.Animation.ValueAnimator animation)
		{
			const string __id = "onAnimationUpdate.(Landroid/animation/ValueAnimator;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((animation == null) ? IntPtr.Zero : ((global::Java.Lang.Object) animation).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::MikePhil.Charting.Jobs.AnimatedViewPortJob __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.AnimatedViewPortJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RecycleSelf ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedViewPortJob']/method[@name='recycleSelf' and count(parameter)=0]"
		[Register ("recycleSelf", "()V", "GetRecycleSelfHandler")]
		public abstract void RecycleSelf ();

		static Delegate cb_resetAnimator;
#pragma warning disable 0169
		static Delegate GetResetAnimatorHandler ()
		{
			if (cb_resetAnimator == null)
				cb_resetAnimator = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetAnimator);
			return cb_resetAnimator;
		}

		static void n_ResetAnimator (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Jobs.AnimatedViewPortJob __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.AnimatedViewPortJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetAnimator ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedViewPortJob']/method[@name='resetAnimator' and count(parameter)=0]"
		[Register ("resetAnimator", "()V", "GetResetAnimatorHandler")]
		protected virtual unsafe void ResetAnimator ()
		{
			const string __id = "resetAnimator.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::MikePhil.Charting.Jobs.AnimatedViewPortJob __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Jobs.AnimatedViewPortJob> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedViewPortJob']/method[@name='run' and count(parameter)=0]"
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

	[global::Android.Runtime.Register ("com/github/mikephil/charting/jobs/AnimatedViewPortJob", DoNotGenerateAcw=true)]
	internal partial class AnimatedViewPortJobInvoker : AnimatedViewPortJob {

		public AnimatedViewPortJobInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/github/mikephil/charting/jobs/AnimatedViewPortJob", typeof (AnimatedViewPortJobInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.jobs']/class[@name='AnimatedViewPortJob']/method[@name='recycleSelf' and count(parameter)=0]"
		[Register ("recycleSelf", "()V", "GetRecycleSelfHandler")]
		public override unsafe void RecycleSelf ()
		{
			const string __id = "recycleSelf.()V";
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
