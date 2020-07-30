using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Animation {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.animation']/class[@name='ChartAnimator']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/animation/ChartAnimator", DoNotGenerateAcw=true)]
	public partial class ChartAnimator : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.animation']/class[@name='ChartAnimator']/field[@name='mPhaseX']"
		[Register ("mPhaseX")]
		protected float MPhaseX {
			get {
				const string __id = "mPhaseX.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mPhaseX.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.animation']/class[@name='ChartAnimator']/field[@name='mPhaseY']"
		[Register ("mPhaseY")]
		protected float MPhaseY {
			get {
				const string __id = "mPhaseY.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mPhaseY.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/animation/ChartAnimator", typeof (ChartAnimator));
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

		protected ChartAnimator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.animation']/class[@name='ChartAnimator']/constructor[@name='ChartAnimator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ChartAnimator ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.animation']/class[@name='ChartAnimator']/constructor[@name='ChartAnimator' and count(parameter)=1 and parameter[1][@type='android.animation.ValueAnimator.AnimatorUpdateListener']]"
		[Register (".ctor", "(Landroid/animation/ValueAnimator$AnimatorUpdateListener;)V", "")]
		public unsafe ChartAnimator (global::Android.Animation.ValueAnimator.IAnimatorUpdateListener listener)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/animation/ValueAnimator$AnimatorUpdateListener;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getPhaseX;
#pragma warning disable 0169
		static Delegate GetGetPhaseXHandler ()
		{
			if (cb_getPhaseX == null)
				cb_getPhaseX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPhaseX);
			return cb_getPhaseX;
		}

		static float n_GetPhaseX (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Animation.ChartAnimator __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.ChartAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PhaseX;
		}
#pragma warning restore 0169

		static Delegate cb_setPhaseX_F;
#pragma warning disable 0169
		static Delegate GetSetPhaseX_FHandler ()
		{
			if (cb_setPhaseX_F == null)
				cb_setPhaseX_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetPhaseX_F);
			return cb_setPhaseX_F;
		}

		static void n_SetPhaseX_F (IntPtr jnienv, IntPtr native__this, float phase)
		{
			global::MikePhil.Charting.Animation.ChartAnimator __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.ChartAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PhaseX = phase;
		}
#pragma warning restore 0169

		public virtual unsafe float PhaseX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.animation']/class[@name='ChartAnimator']/method[@name='getPhaseX' and count(parameter)=0]"
			[Register ("getPhaseX", "()F", "GetGetPhaseXHandler")]
			get {
				const string __id = "getPhaseX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.animation']/class[@name='ChartAnimator']/method[@name='setPhaseX' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setPhaseX", "(F)V", "GetSetPhaseX_FHandler")]
			set {
				const string __id = "setPhaseX.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPhaseY;
#pragma warning disable 0169
		static Delegate GetGetPhaseYHandler ()
		{
			if (cb_getPhaseY == null)
				cb_getPhaseY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPhaseY);
			return cb_getPhaseY;
		}

		static float n_GetPhaseY (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Animation.ChartAnimator __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.ChartAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PhaseY;
		}
#pragma warning restore 0169

		static Delegate cb_setPhaseY_F;
#pragma warning disable 0169
		static Delegate GetSetPhaseY_FHandler ()
		{
			if (cb_setPhaseY_F == null)
				cb_setPhaseY_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetPhaseY_F);
			return cb_setPhaseY_F;
		}

		static void n_SetPhaseY_F (IntPtr jnienv, IntPtr native__this, float phase)
		{
			global::MikePhil.Charting.Animation.ChartAnimator __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.ChartAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PhaseY = phase;
		}
#pragma warning restore 0169

		public virtual unsafe float PhaseY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.animation']/class[@name='ChartAnimator']/method[@name='getPhaseY' and count(parameter)=0]"
			[Register ("getPhaseY", "()F", "GetGetPhaseYHandler")]
			get {
				const string __id = "getPhaseY.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.animation']/class[@name='ChartAnimator']/method[@name='setPhaseY' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setPhaseY", "(F)V", "GetSetPhaseY_FHandler")]
			set {
				const string __id = "setPhaseY.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_animateX_I;
#pragma warning disable 0169
		static Delegate GetAnimateX_IHandler ()
		{
			if (cb_animateX_I == null)
				cb_animateX_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_AnimateX_I);
			return cb_animateX_I;
		}

		static void n_AnimateX_I (IntPtr jnienv, IntPtr native__this, int durationMillis)
		{
			global::MikePhil.Charting.Animation.ChartAnimator __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.ChartAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AnimateX (durationMillis);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.animation']/class[@name='ChartAnimator']/method[@name='animateX' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("animateX", "(I)V", "GetAnimateX_IHandler")]
		public virtual unsafe void AnimateX (int durationMillis)
		{
			const string __id = "animateX.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (durationMillis);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_animateX_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_;
#pragma warning disable 0169
		static Delegate GetAnimateX_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_Handler ()
		{
			if (cb_animateX_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_ == null)
				cb_animateX_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_AnimateX_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_);
			return cb_animateX_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_;
		}

		static void n_AnimateX_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_ (IntPtr jnienv, IntPtr native__this, int durationMillis, IntPtr native_easing)
		{
			global::MikePhil.Charting.Animation.ChartAnimator __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.ChartAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Animation.Easing.IEasingFunction easing = (global::MikePhil.Charting.Animation.Easing.IEasingFunction)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.Easing.IEasingFunction> (native_easing, JniHandleOwnership.DoNotTransfer);
			__this.AnimateX (durationMillis, easing);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.animation']/class[@name='ChartAnimator']/method[@name='animateX' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.github.mikephil.charting.animation.Easing.EasingFunction']]"
		[Register ("animateX", "(ILcom/github/mikephil/charting/animation/Easing$EasingFunction;)V", "GetAnimateX_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_Handler")]
		public virtual unsafe void AnimateX (int durationMillis, global::MikePhil.Charting.Animation.Easing.IEasingFunction easing)
		{
			const string __id = "animateX.(ILcom/github/mikephil/charting/animation/Easing$EasingFunction;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (durationMillis);
				__args [1] = new JniArgumentValue ((easing == null) ? IntPtr.Zero : ((global::Java.Lang.Object) easing).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_animateX_ILcom_github_mikephil_charting_animation_Easing_EasingOption_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetAnimateX_ILcom_github_mikephil_charting_animation_Easing_EasingOption_Handler ()
		{
			if (cb_animateX_ILcom_github_mikephil_charting_animation_Easing_EasingOption_ == null)
				cb_animateX_ILcom_github_mikephil_charting_animation_Easing_EasingOption_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_AnimateX_ILcom_github_mikephil_charting_animation_Easing_EasingOption_);
			return cb_animateX_ILcom_github_mikephil_charting_animation_Easing_EasingOption_;
		}

		[Obsolete]
		static void n_AnimateX_ILcom_github_mikephil_charting_animation_Easing_EasingOption_ (IntPtr jnienv, IntPtr native__this, int durationMillis, IntPtr native_easing)
		{
			global::MikePhil.Charting.Animation.ChartAnimator __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.ChartAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Animation.Easing.EasingOption easing = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.Easing.EasingOption> (native_easing, JniHandleOwnership.DoNotTransfer);
			__this.AnimateX (durationMillis, easing);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.animation']/class[@name='ChartAnimator']/method[@name='animateX' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.github.mikephil.charting.animation.Easing.EasingOption']]"
		[Obsolete (@"deprecated")]
		[Register ("animateX", "(ILcom/github/mikephil/charting/animation/Easing$EasingOption;)V", "GetAnimateX_ILcom_github_mikephil_charting_animation_Easing_EasingOption_Handler")]
		public virtual unsafe void AnimateX (int durationMillis, global::MikePhil.Charting.Animation.Easing.EasingOption easing)
		{
			const string __id = "animateX.(ILcom/github/mikephil/charting/animation/Easing$EasingOption;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (durationMillis);
				__args [1] = new JniArgumentValue ((easing == null) ? IntPtr.Zero : ((global::Java.Lang.Object) easing).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_animateXY_II;
#pragma warning disable 0169
		static Delegate GetAnimateXY_IIHandler ()
		{
			if (cb_animateXY_II == null)
				cb_animateXY_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_AnimateXY_II);
			return cb_animateXY_II;
		}

		static void n_AnimateXY_II (IntPtr jnienv, IntPtr native__this, int durationMillisX, int durationMillisY)
		{
			global::MikePhil.Charting.Animation.ChartAnimator __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.ChartAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AnimateXY (durationMillisX, durationMillisY);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.animation']/class[@name='ChartAnimator']/method[@name='animateXY' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("animateXY", "(II)V", "GetAnimateXY_IIHandler")]
		public virtual unsafe void AnimateXY (int durationMillisX, int durationMillisY)
		{
			const string __id = "animateXY.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (durationMillisX);
				__args [1] = new JniArgumentValue (durationMillisY);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_animateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_;
#pragma warning disable 0169
		static Delegate GetAnimateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_Handler ()
		{
			if (cb_animateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_ == null)
				cb_animateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_AnimateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_);
			return cb_animateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_;
		}

		static void n_AnimateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_ (IntPtr jnienv, IntPtr native__this, int durationMillisX, int durationMillisY, IntPtr native_easing)
		{
			global::MikePhil.Charting.Animation.ChartAnimator __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.ChartAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Animation.Easing.IEasingFunction easing = (global::MikePhil.Charting.Animation.Easing.IEasingFunction)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.Easing.IEasingFunction> (native_easing, JniHandleOwnership.DoNotTransfer);
			__this.AnimateXY (durationMillisX, durationMillisY, easing);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.animation']/class[@name='ChartAnimator']/method[@name='animateXY' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.github.mikephil.charting.animation.Easing.EasingFunction']]"
		[Register ("animateXY", "(IILcom/github/mikephil/charting/animation/Easing$EasingFunction;)V", "GetAnimateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_Handler")]
		public virtual unsafe void AnimateXY (int durationMillisX, int durationMillisY, global::MikePhil.Charting.Animation.Easing.IEasingFunction easing)
		{
			const string __id = "animateXY.(IILcom/github/mikephil/charting/animation/Easing$EasingFunction;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (durationMillisX);
				__args [1] = new JniArgumentValue (durationMillisY);
				__args [2] = new JniArgumentValue ((easing == null) ? IntPtr.Zero : ((global::Java.Lang.Object) easing).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_animateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_Lcom_github_mikephil_charting_animation_Easing_EasingFunction_;
#pragma warning disable 0169
		static Delegate GetAnimateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_Lcom_github_mikephil_charting_animation_Easing_EasingFunction_Handler ()
		{
			if (cb_animateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_Lcom_github_mikephil_charting_animation_Easing_EasingFunction_ == null)
				cb_animateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_Lcom_github_mikephil_charting_animation_Easing_EasingFunction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_AnimateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_Lcom_github_mikephil_charting_animation_Easing_EasingFunction_);
			return cb_animateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_Lcom_github_mikephil_charting_animation_Easing_EasingFunction_;
		}

		static void n_AnimateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_Lcom_github_mikephil_charting_animation_Easing_EasingFunction_ (IntPtr jnienv, IntPtr native__this, int durationMillisX, int durationMillisY, IntPtr native_easingX, IntPtr native_easingY)
		{
			global::MikePhil.Charting.Animation.ChartAnimator __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.ChartAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Animation.Easing.IEasingFunction easingX = (global::MikePhil.Charting.Animation.Easing.IEasingFunction)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.Easing.IEasingFunction> (native_easingX, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Animation.Easing.IEasingFunction easingY = (global::MikePhil.Charting.Animation.Easing.IEasingFunction)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.Easing.IEasingFunction> (native_easingY, JniHandleOwnership.DoNotTransfer);
			__this.AnimateXY (durationMillisX, durationMillisY, easingX, easingY);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.animation']/class[@name='ChartAnimator']/method[@name='animateXY' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.github.mikephil.charting.animation.Easing.EasingFunction'] and parameter[4][@type='com.github.mikephil.charting.animation.Easing.EasingFunction']]"
		[Register ("animateXY", "(IILcom/github/mikephil/charting/animation/Easing$EasingFunction;Lcom/github/mikephil/charting/animation/Easing$EasingFunction;)V", "GetAnimateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_Lcom_github_mikephil_charting_animation_Easing_EasingFunction_Handler")]
		public virtual unsafe void AnimateXY (int durationMillisX, int durationMillisY, global::MikePhil.Charting.Animation.Easing.IEasingFunction easingX, global::MikePhil.Charting.Animation.Easing.IEasingFunction easingY)
		{
			const string __id = "animateXY.(IILcom/github/mikephil/charting/animation/Easing$EasingFunction;Lcom/github/mikephil/charting/animation/Easing$EasingFunction;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (durationMillisX);
				__args [1] = new JniArgumentValue (durationMillisY);
				__args [2] = new JniArgumentValue ((easingX == null) ? IntPtr.Zero : ((global::Java.Lang.Object) easingX).Handle);
				__args [3] = new JniArgumentValue ((easingY == null) ? IntPtr.Zero : ((global::Java.Lang.Object) easingY).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_animateXY_IILcom_github_mikephil_charting_animation_Easing_EasingOption_Lcom_github_mikephil_charting_animation_Easing_EasingOption_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetAnimateXY_IILcom_github_mikephil_charting_animation_Easing_EasingOption_Lcom_github_mikephil_charting_animation_Easing_EasingOption_Handler ()
		{
			if (cb_animateXY_IILcom_github_mikephil_charting_animation_Easing_EasingOption_Lcom_github_mikephil_charting_animation_Easing_EasingOption_ == null)
				cb_animateXY_IILcom_github_mikephil_charting_animation_Easing_EasingOption_Lcom_github_mikephil_charting_animation_Easing_EasingOption_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_AnimateXY_IILcom_github_mikephil_charting_animation_Easing_EasingOption_Lcom_github_mikephil_charting_animation_Easing_EasingOption_);
			return cb_animateXY_IILcom_github_mikephil_charting_animation_Easing_EasingOption_Lcom_github_mikephil_charting_animation_Easing_EasingOption_;
		}

		[Obsolete]
		static void n_AnimateXY_IILcom_github_mikephil_charting_animation_Easing_EasingOption_Lcom_github_mikephil_charting_animation_Easing_EasingOption_ (IntPtr jnienv, IntPtr native__this, int durationMillisX, int durationMillisY, IntPtr native_easingX, IntPtr native_easingY)
		{
			global::MikePhil.Charting.Animation.ChartAnimator __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.ChartAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Animation.Easing.EasingOption easingX = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.Easing.EasingOption> (native_easingX, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Animation.Easing.EasingOption easingY = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.Easing.EasingOption> (native_easingY, JniHandleOwnership.DoNotTransfer);
			__this.AnimateXY (durationMillisX, durationMillisY, easingX, easingY);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.animation']/class[@name='ChartAnimator']/method[@name='animateXY' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.github.mikephil.charting.animation.Easing.EasingOption'] and parameter[4][@type='com.github.mikephil.charting.animation.Easing.EasingOption']]"
		[Obsolete (@"deprecated")]
		[Register ("animateXY", "(IILcom/github/mikephil/charting/animation/Easing$EasingOption;Lcom/github/mikephil/charting/animation/Easing$EasingOption;)V", "GetAnimateXY_IILcom_github_mikephil_charting_animation_Easing_EasingOption_Lcom_github_mikephil_charting_animation_Easing_EasingOption_Handler")]
		public virtual unsafe void AnimateXY (int durationMillisX, int durationMillisY, global::MikePhil.Charting.Animation.Easing.EasingOption easingX, global::MikePhil.Charting.Animation.Easing.EasingOption easingY)
		{
			const string __id = "animateXY.(IILcom/github/mikephil/charting/animation/Easing$EasingOption;Lcom/github/mikephil/charting/animation/Easing$EasingOption;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (durationMillisX);
				__args [1] = new JniArgumentValue (durationMillisY);
				__args [2] = new JniArgumentValue ((easingX == null) ? IntPtr.Zero : ((global::Java.Lang.Object) easingX).Handle);
				__args [3] = new JniArgumentValue ((easingY == null) ? IntPtr.Zero : ((global::Java.Lang.Object) easingY).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_animateY_I;
#pragma warning disable 0169
		static Delegate GetAnimateY_IHandler ()
		{
			if (cb_animateY_I == null)
				cb_animateY_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_AnimateY_I);
			return cb_animateY_I;
		}

		static void n_AnimateY_I (IntPtr jnienv, IntPtr native__this, int durationMillis)
		{
			global::MikePhil.Charting.Animation.ChartAnimator __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.ChartAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AnimateY (durationMillis);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.animation']/class[@name='ChartAnimator']/method[@name='animateY' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("animateY", "(I)V", "GetAnimateY_IHandler")]
		public virtual unsafe void AnimateY (int durationMillis)
		{
			const string __id = "animateY.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (durationMillis);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_animateY_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_;
#pragma warning disable 0169
		static Delegate GetAnimateY_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_Handler ()
		{
			if (cb_animateY_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_ == null)
				cb_animateY_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_AnimateY_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_);
			return cb_animateY_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_;
		}

		static void n_AnimateY_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_ (IntPtr jnienv, IntPtr native__this, int durationMillis, IntPtr native_easing)
		{
			global::MikePhil.Charting.Animation.ChartAnimator __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.ChartAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Animation.Easing.IEasingFunction easing = (global::MikePhil.Charting.Animation.Easing.IEasingFunction)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.Easing.IEasingFunction> (native_easing, JniHandleOwnership.DoNotTransfer);
			__this.AnimateY (durationMillis, easing);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.animation']/class[@name='ChartAnimator']/method[@name='animateY' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.github.mikephil.charting.animation.Easing.EasingFunction']]"
		[Register ("animateY", "(ILcom/github/mikephil/charting/animation/Easing$EasingFunction;)V", "GetAnimateY_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_Handler")]
		public virtual unsafe void AnimateY (int durationMillis, global::MikePhil.Charting.Animation.Easing.IEasingFunction easing)
		{
			const string __id = "animateY.(ILcom/github/mikephil/charting/animation/Easing$EasingFunction;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (durationMillis);
				__args [1] = new JniArgumentValue ((easing == null) ? IntPtr.Zero : ((global::Java.Lang.Object) easing).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_animateY_ILcom_github_mikephil_charting_animation_Easing_EasingOption_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetAnimateY_ILcom_github_mikephil_charting_animation_Easing_EasingOption_Handler ()
		{
			if (cb_animateY_ILcom_github_mikephil_charting_animation_Easing_EasingOption_ == null)
				cb_animateY_ILcom_github_mikephil_charting_animation_Easing_EasingOption_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_AnimateY_ILcom_github_mikephil_charting_animation_Easing_EasingOption_);
			return cb_animateY_ILcom_github_mikephil_charting_animation_Easing_EasingOption_;
		}

		[Obsolete]
		static void n_AnimateY_ILcom_github_mikephil_charting_animation_Easing_EasingOption_ (IntPtr jnienv, IntPtr native__this, int durationMillis, IntPtr native_easing)
		{
			global::MikePhil.Charting.Animation.ChartAnimator __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.ChartAnimator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Animation.Easing.EasingOption easing = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.Easing.EasingOption> (native_easing, JniHandleOwnership.DoNotTransfer);
			__this.AnimateY (durationMillis, easing);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.animation']/class[@name='ChartAnimator']/method[@name='animateY' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.github.mikephil.charting.animation.Easing.EasingOption']]"
		[Obsolete (@"deprecated")]
		[Register ("animateY", "(ILcom/github/mikephil/charting/animation/Easing$EasingOption;)V", "GetAnimateY_ILcom_github_mikephil_charting_animation_Easing_EasingOption_Handler")]
		public virtual unsafe void AnimateY (int durationMillis, global::MikePhil.Charting.Animation.Easing.EasingOption easing)
		{
			const string __id = "animateY.(ILcom/github/mikephil/charting/animation/Easing$EasingOption;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (durationMillis);
				__args [1] = new JniArgumentValue ((easing == null) ? IntPtr.Zero : ((global::Java.Lang.Object) easing).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
