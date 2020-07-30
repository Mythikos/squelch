using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Listener {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='BarLineChartTouchListener']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/listener/BarLineChartTouchListener", DoNotGenerateAcw=true)]
	public partial class BarLineChartTouchListener : global::MikePhil.Charting.Listener.ChartTouchListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/listener/BarLineChartTouchListener", typeof (BarLineChartTouchListener));
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

		protected BarLineChartTouchListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='BarLineChartTouchListener']/constructor[@name='BarLineChartTouchListener' and count(parameter)=3 and parameter[1][@type='com.github.mikephil.charting.charts.BarLineChartBase&lt;? extends com.github.mikephil.charting.data.BarLineScatterCandleBubbleData&lt;? extends com.github.mikephil.charting.interfaces.datasets.IBarLineScatterCandleBubbleDataSet&lt;? extends com.github.mikephil.charting.data.Entry&gt;&gt;&gt;'] and parameter[2][@type='android.graphics.Matrix'] and parameter[3][@type='float']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/charts/BarLineChartBase;Landroid/graphics/Matrix;F)V", "")]
		public unsafe BarLineChartTouchListener (global::MikePhil.Charting.Charts.BarLineChartBase chart, global::Android.Graphics.Matrix touchMatrix, float dragTriggerDistance)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/charts/BarLineChartBase;Landroid/graphics/Matrix;F)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((chart == null) ? IntPtr.Zero : ((global::Java.Lang.Object) chart).Handle);
				__args [1] = new JniArgumentValue ((touchMatrix == null) ? IntPtr.Zero : ((global::Java.Lang.Object) touchMatrix).Handle);
				__args [2] = new JniArgumentValue (dragTriggerDistance);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getMatrix;
#pragma warning disable 0169
		static Delegate GetGetMatrixHandler ()
		{
			if (cb_getMatrix == null)
				cb_getMatrix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMatrix);
			return cb_getMatrix;
		}

		static IntPtr n_GetMatrix (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Listener.BarLineChartTouchListener __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.BarLineChartTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Matrix);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Matrix Matrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='BarLineChartTouchListener']/method[@name='getMatrix' and count(parameter)=0]"
			[Register ("getMatrix", "()Landroid/graphics/Matrix;", "GetGetMatrixHandler")]
			get {
				const string __id = "getMatrix.()Landroid/graphics/Matrix;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_computeScroll;
#pragma warning disable 0169
		static Delegate GetComputeScrollHandler ()
		{
			if (cb_computeScroll == null)
				cb_computeScroll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ComputeScroll);
			return cb_computeScroll;
		}

		static void n_ComputeScroll (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Listener.BarLineChartTouchListener __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.BarLineChartTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ComputeScroll ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='BarLineChartTouchListener']/method[@name='computeScroll' and count(parameter)=0]"
		[Register ("computeScroll", "()V", "GetComputeScrollHandler")]
		public virtual unsafe void ComputeScroll ()
		{
			const string __id = "computeScroll.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getTrans_FF;
#pragma warning disable 0169
		static Delegate GetGetTrans_FFHandler ()
		{
			if (cb_getTrans_FF == null)
				cb_getTrans_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_GetTrans_FF);
			return cb_getTrans_FF;
		}

		static IntPtr n_GetTrans_FF (IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			global::MikePhil.Charting.Listener.BarLineChartTouchListener __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.BarLineChartTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetTrans (x, y));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='BarLineChartTouchListener']/method[@name='getTrans' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("getTrans", "(FF)Lcom/github/mikephil/charting/utils/MPPointF;", "GetGetTrans_FFHandler")]
		public virtual unsafe global::MikePhil.Charting.Util.MPPointF GetTrans (float x, float y)
		{
			const string __id = "getTrans.(FF)Lcom/github/mikephil/charting/utils/MPPointF;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == null)
				cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_);
			return cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_v, IntPtr native_e)
		{
			global::MikePhil.Charting.Listener.BarLineChartTouchListener __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.BarLineChartTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View v = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_v, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouch (v, e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='BarLineChartTouchListener']/method[@name='onTouch' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.MotionEvent']]"
		[Register ("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
		public override unsafe bool OnTouch (global::Android.Views.View v, global::Android.Views.MotionEvent e)
		{
			const string __id = "onTouch.(Landroid/view/View;Landroid/view/MotionEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setDragTriggerDist_F;
#pragma warning disable 0169
		static Delegate GetSetDragTriggerDist_FHandler ()
		{
			if (cb_setDragTriggerDist_F == null)
				cb_setDragTriggerDist_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetDragTriggerDist_F);
			return cb_setDragTriggerDist_F;
		}

		static void n_SetDragTriggerDist_F (IntPtr jnienv, IntPtr native__this, float dragTriggerDistance)
		{
			global::MikePhil.Charting.Listener.BarLineChartTouchListener __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.BarLineChartTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDragTriggerDist (dragTriggerDistance);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='BarLineChartTouchListener']/method[@name='setDragTriggerDist' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setDragTriggerDist", "(F)V", "GetSetDragTriggerDist_FHandler")]
		public virtual unsafe void SetDragTriggerDist (float dragTriggerDistance)
		{
			const string __id = "setDragTriggerDist.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dragTriggerDistance);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_stopDeceleration;
#pragma warning disable 0169
		static Delegate GetStopDecelerationHandler ()
		{
			if (cb_stopDeceleration == null)
				cb_stopDeceleration = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopDeceleration);
			return cb_stopDeceleration;
		}

		static void n_StopDeceleration (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Listener.BarLineChartTouchListener __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.BarLineChartTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopDeceleration ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='BarLineChartTouchListener']/method[@name='stopDeceleration' and count(parameter)=0]"
		[Register ("stopDeceleration", "()V", "GetStopDecelerationHandler")]
		public virtual unsafe void StopDeceleration ()
		{
			const string __id = "stopDeceleration.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
