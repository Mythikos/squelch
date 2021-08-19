using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Listener {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='PieRadarChartTouchListener']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/listener/PieRadarChartTouchListener", DoNotGenerateAcw=true)]
	public partial class PieRadarChartTouchListener : global::MikePhil.Charting.Listener.ChartTouchListener {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/listener/PieRadarChartTouchListener", typeof (PieRadarChartTouchListener));

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

		protected PieRadarChartTouchListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='PieRadarChartTouchListener']/constructor[@name='PieRadarChartTouchListener' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.charts.PieRadarChartBase&lt;?&gt;']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/charts/PieRadarChartBase;)V", "")]
		public unsafe PieRadarChartTouchListener (global::MikePhil.Charting.Charts.PieRadarChartBase chart) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/charts/PieRadarChartBase;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((chart == null) ? IntPtr.Zero : ((global::Java.Lang.Object) chart).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (chart);
			}
		}

		static Delegate cb_computeScroll;
#pragma warning disable 0169
		static Delegate GetComputeScrollHandler ()
		{
			if (cb_computeScroll == null)
				cb_computeScroll = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ComputeScroll);
			return cb_computeScroll;
		}

		static void n_ComputeScroll (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.PieRadarChartTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ComputeScroll ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='PieRadarChartTouchListener']/method[@name='computeScroll' and count(parameter)=0]"
		[Register ("computeScroll", "()V", "GetComputeScrollHandler")]
		public virtual unsafe void ComputeScroll ()
		{
			const string __id = "computeScroll.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ == null)
				cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_);
			return cb_onTouch_Landroid_view_View_Landroid_view_MotionEvent_;
		}

		static bool n_OnTouch_Landroid_view_View_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_v, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.PieRadarChartTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var v = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_v, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouch (v, e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='PieRadarChartTouchListener']/method[@name='onTouch' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.view.MotionEvent']]"
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
				global::System.GC.KeepAlive (v);
				global::System.GC.KeepAlive (e);
			}
		}

		static Delegate cb_setGestureStartAngle_FF;
#pragma warning disable 0169
		static Delegate GetSetGestureStartAngle_FFHandler ()
		{
			if (cb_setGestureStartAngle_FF == null)
				cb_setGestureStartAngle_FF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFF_V) n_SetGestureStartAngle_FF);
			return cb_setGestureStartAngle_FF;
		}

		static void n_SetGestureStartAngle_FF (IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.PieRadarChartTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetGestureStartAngle (x, y);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='PieRadarChartTouchListener']/method[@name='setGestureStartAngle' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setGestureStartAngle", "(FF)V", "GetSetGestureStartAngle_FFHandler")]
		public virtual unsafe void SetGestureStartAngle (float x, float y)
		{
			const string __id = "setGestureStartAngle.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_stopDeceleration;
#pragma warning disable 0169
		static Delegate GetStopDecelerationHandler ()
		{
			if (cb_stopDeceleration == null)
				cb_stopDeceleration = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_StopDeceleration);
			return cb_stopDeceleration;
		}

		static void n_StopDeceleration (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.PieRadarChartTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopDeceleration ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='PieRadarChartTouchListener']/method[@name='stopDeceleration' and count(parameter)=0]"
		[Register ("stopDeceleration", "()V", "GetStopDecelerationHandler")]
		public virtual unsafe void StopDeceleration ()
		{
			const string __id = "stopDeceleration.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_updateGestureRotation_FF;
#pragma warning disable 0169
		static Delegate GetUpdateGestureRotation_FFHandler ()
		{
			if (cb_updateGestureRotation_FF == null)
				cb_updateGestureRotation_FF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFF_V) n_UpdateGestureRotation_FF);
			return cb_updateGestureRotation_FF;
		}

		static void n_UpdateGestureRotation_FF (IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.PieRadarChartTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UpdateGestureRotation (x, y);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='PieRadarChartTouchListener']/method[@name='updateGestureRotation' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("updateGestureRotation", "(FF)V", "GetUpdateGestureRotation_FFHandler")]
		public virtual unsafe void UpdateGestureRotation (float x, float y)
		{
			const string __id = "updateGestureRotation.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
