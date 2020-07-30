using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Listener {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.mikephil.charting.listener']/interface[@name='OnChartGestureListener']"
	[Register ("com/github/mikephil/charting/listener/OnChartGestureListener", "", "MikePhil.Charting.Listener.IOnChartGestureListenerSupportInvoker")]
	public partial interface IOnChartGestureListenerSupport : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/interface[@name='OnChartGestureListener']/method[@name='onChartDoubleTapped' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onChartDoubleTapped", "(Landroid/view/MotionEvent;)V", "GetOnChartDoubleTapped_Landroid_view_MotionEvent_Handler:MikePhil.Charting.Listener.IOnChartGestureListenerSupportInvoker, library-mpandroidchart")]
		void OnChartDoubleTapped (global::Android.Views.MotionEvent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/interface[@name='OnChartGestureListener']/method[@name='onChartFling' and count(parameter)=4 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='android.view.MotionEvent'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("onChartFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)V", "GetOnChartFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFHandler:MikePhil.Charting.Listener.IOnChartGestureListenerSupportInvoker, library-mpandroidchart")]
		void OnChartFling (global::Android.Views.MotionEvent p0, global::Android.Views.MotionEvent p1, float p2, float p3);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/interface[@name='OnChartGestureListener']/method[@name='onChartGestureEnd' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='com.github.mikephil.charting.listener.ChartTouchListener.ChartGesture']]"
		[Register ("onChartGestureEnd", "(Landroid/view/MotionEvent;Lcom/github/mikephil/charting/listener/ChartTouchListener$ChartGesture;)V", "GetOnChartGestureEnd_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_Handler:MikePhil.Charting.Listener.IOnChartGestureListenerSupportInvoker, library-mpandroidchart")]
		void OnChartGestureEnd (global::Android.Views.MotionEvent p0, global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/interface[@name='OnChartGestureListener']/method[@name='onChartGestureStart' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='com.github.mikephil.charting.listener.ChartTouchListener.ChartGesture']]"
		[Register ("onChartGestureStart", "(Landroid/view/MotionEvent;Lcom/github/mikephil/charting/listener/ChartTouchListener$ChartGesture;)V", "GetOnChartGestureStart_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_Handler:MikePhil.Charting.Listener.IOnChartGestureListenerSupportInvoker, library-mpandroidchart")]
		void OnChartGestureStart (global::Android.Views.MotionEvent p0, global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/interface[@name='OnChartGestureListener']/method[@name='onChartLongPressed' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onChartLongPressed", "(Landroid/view/MotionEvent;)V", "GetOnChartLongPressed_Landroid_view_MotionEvent_Handler:MikePhil.Charting.Listener.IOnChartGestureListenerSupportInvoker, library-mpandroidchart")]
		void OnChartLongPressed (global::Android.Views.MotionEvent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/interface[@name='OnChartGestureListener']/method[@name='onChartScale' and count(parameter)=3 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("onChartScale", "(Landroid/view/MotionEvent;FF)V", "GetOnChartScale_Landroid_view_MotionEvent_FFHandler:MikePhil.Charting.Listener.IOnChartGestureListenerSupportInvoker, library-mpandroidchart")]
		void OnChartScale (global::Android.Views.MotionEvent p0, float p1, float p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/interface[@name='OnChartGestureListener']/method[@name='onChartSingleTapped' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("onChartSingleTapped", "(Landroid/view/MotionEvent;)V", "GetOnChartSingleTapped_Landroid_view_MotionEvent_Handler:MikePhil.Charting.Listener.IOnChartGestureListenerSupportInvoker, library-mpandroidchart")]
		void OnChartSingleTapped (global::Android.Views.MotionEvent p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/interface[@name='OnChartGestureListener']/method[@name='onChartTranslate' and count(parameter)=3 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("onChartTranslate", "(Landroid/view/MotionEvent;FF)V", "GetOnChartTranslate_Landroid_view_MotionEvent_FFHandler:MikePhil.Charting.Listener.IOnChartGestureListenerSupportInvoker, library-mpandroidchart")]
		void OnChartTranslate (global::Android.Views.MotionEvent p0, float p1, float p2);

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/listener/OnChartGestureListener", DoNotGenerateAcw=true)]
	internal partial class IOnChartGestureListenerSupportInvoker : global::Java.Lang.Object, IOnChartGestureListenerSupport {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/listener/OnChartGestureListener", typeof (IOnChartGestureListenerSupportInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IOnChartGestureListenerSupport GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IOnChartGestureListenerSupport> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.github.mikephil.charting.listener.OnChartGestureListener"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IOnChartGestureListenerSupportInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_onChartDoubleTapped_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnChartDoubleTapped_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onChartDoubleTapped_Landroid_view_MotionEvent_ == null)
				cb_onChartDoubleTapped_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnChartDoubleTapped_Landroid_view_MotionEvent_);
			return cb_onChartDoubleTapped_Landroid_view_MotionEvent_;
		}

		static void n_OnChartDoubleTapped_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Listener.IOnChartGestureListenerSupport __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.IOnChartGestureListenerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnChartDoubleTapped (p0);
		}
#pragma warning restore 0169

		IntPtr id_onChartDoubleTapped_Landroid_view_MotionEvent_;
		public unsafe void OnChartDoubleTapped (global::Android.Views.MotionEvent p0)
		{
			if (id_onChartDoubleTapped_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onChartDoubleTapped_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onChartDoubleTapped", "(Landroid/view/MotionEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChartDoubleTapped_Landroid_view_MotionEvent_, __args);
		}

		static Delegate cb_onChartFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
#pragma warning disable 0169
		static Delegate GetOnChartFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FFHandler ()
		{
			if (cb_onChartFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF == null)
				cb_onChartFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, float, float>) n_OnChartFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF);
			return cb_onChartFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
		}

		static void n_OnChartFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, float p2, float p3)
		{
			global::MikePhil.Charting.Listener.IOnChartGestureListenerSupport __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.IOnChartGestureListenerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p1 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnChartFling (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		IntPtr id_onChartFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF;
		public unsafe void OnChartFling (global::Android.Views.MotionEvent p0, global::Android.Views.MotionEvent p1, float p2, float p3)
		{
			if (id_onChartFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF == IntPtr.Zero)
				id_onChartFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF = JNIEnv.GetMethodID (class_ref, "onChartFling", "(Landroid/view/MotionEvent;Landroid/view/MotionEvent;FF)V");
			JValue* __args = stackalloc JValue [4];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChartFling_Landroid_view_MotionEvent_Landroid_view_MotionEvent_FF, __args);
		}

		static Delegate cb_onChartGestureEnd_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_;
#pragma warning disable 0169
		static Delegate GetOnChartGestureEnd_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_Handler ()
		{
			if (cb_onChartGestureEnd_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_ == null)
				cb_onChartGestureEnd_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnChartGestureEnd_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_);
			return cb_onChartGestureEnd_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_;
		}

		static void n_OnChartGestureEnd_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::MikePhil.Charting.Listener.IOnChartGestureListenerSupport __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.IOnChartGestureListenerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture p1 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnChartGestureEnd (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onChartGestureEnd_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_;
		public unsafe void OnChartGestureEnd (global::Android.Views.MotionEvent p0, global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture p1)
		{
			if (id_onChartGestureEnd_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_ == IntPtr.Zero)
				id_onChartGestureEnd_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_ = JNIEnv.GetMethodID (class_ref, "onChartGestureEnd", "(Landroid/view/MotionEvent;Lcom/github/mikephil/charting/listener/ChartTouchListener$ChartGesture;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChartGestureEnd_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_, __args);
		}

		static Delegate cb_onChartGestureStart_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_;
#pragma warning disable 0169
		static Delegate GetOnChartGestureStart_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_Handler ()
		{
			if (cb_onChartGestureStart_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_ == null)
				cb_onChartGestureStart_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnChartGestureStart_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_);
			return cb_onChartGestureStart_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_;
		}

		static void n_OnChartGestureStart_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::MikePhil.Charting.Listener.IOnChartGestureListenerSupport __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.IOnChartGestureListenerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture p1 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnChartGestureStart (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_onChartGestureStart_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_;
		public unsafe void OnChartGestureStart (global::Android.Views.MotionEvent p0, global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture p1)
		{
			if (id_onChartGestureStart_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_ == IntPtr.Zero)
				id_onChartGestureStart_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_ = JNIEnv.GetMethodID (class_ref, "onChartGestureStart", "(Landroid/view/MotionEvent;Lcom/github/mikephil/charting/listener/ChartTouchListener$ChartGesture;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChartGestureStart_Landroid_view_MotionEvent_Lcom_github_mikephil_charting_listener_ChartTouchListener_ChartGesture_, __args);
		}

		static Delegate cb_onChartLongPressed_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnChartLongPressed_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onChartLongPressed_Landroid_view_MotionEvent_ == null)
				cb_onChartLongPressed_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnChartLongPressed_Landroid_view_MotionEvent_);
			return cb_onChartLongPressed_Landroid_view_MotionEvent_;
		}

		static void n_OnChartLongPressed_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Listener.IOnChartGestureListenerSupport __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.IOnChartGestureListenerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnChartLongPressed (p0);
		}
#pragma warning restore 0169

		IntPtr id_onChartLongPressed_Landroid_view_MotionEvent_;
		public unsafe void OnChartLongPressed (global::Android.Views.MotionEvent p0)
		{
			if (id_onChartLongPressed_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onChartLongPressed_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onChartLongPressed", "(Landroid/view/MotionEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChartLongPressed_Landroid_view_MotionEvent_, __args);
		}

		static Delegate cb_onChartScale_Landroid_view_MotionEvent_FF;
#pragma warning disable 0169
		static Delegate GetOnChartScale_Landroid_view_MotionEvent_FFHandler ()
		{
			if (cb_onChartScale_Landroid_view_MotionEvent_FF == null)
				cb_onChartScale_Landroid_view_MotionEvent_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float>) n_OnChartScale_Landroid_view_MotionEvent_FF);
			return cb_onChartScale_Landroid_view_MotionEvent_FF;
		}

		static void n_OnChartScale_Landroid_view_MotionEvent_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2)
		{
			global::MikePhil.Charting.Listener.IOnChartGestureListenerSupport __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.IOnChartGestureListenerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnChartScale (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onChartScale_Landroid_view_MotionEvent_FF;
		public unsafe void OnChartScale (global::Android.Views.MotionEvent p0, float p1, float p2)
		{
			if (id_onChartScale_Landroid_view_MotionEvent_FF == IntPtr.Zero)
				id_onChartScale_Landroid_view_MotionEvent_FF = JNIEnv.GetMethodID (class_ref, "onChartScale", "(Landroid/view/MotionEvent;FF)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChartScale_Landroid_view_MotionEvent_FF, __args);
		}

		static Delegate cb_onChartSingleTapped_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetOnChartSingleTapped_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_onChartSingleTapped_Landroid_view_MotionEvent_ == null)
				cb_onChartSingleTapped_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnChartSingleTapped_Landroid_view_MotionEvent_);
			return cb_onChartSingleTapped_Landroid_view_MotionEvent_;
		}

		static void n_OnChartSingleTapped_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Listener.IOnChartGestureListenerSupport __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.IOnChartGestureListenerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnChartSingleTapped (p0);
		}
#pragma warning restore 0169

		IntPtr id_onChartSingleTapped_Landroid_view_MotionEvent_;
		public unsafe void OnChartSingleTapped (global::Android.Views.MotionEvent p0)
		{
			if (id_onChartSingleTapped_Landroid_view_MotionEvent_ == IntPtr.Zero)
				id_onChartSingleTapped_Landroid_view_MotionEvent_ = JNIEnv.GetMethodID (class_ref, "onChartSingleTapped", "(Landroid/view/MotionEvent;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChartSingleTapped_Landroid_view_MotionEvent_, __args);
		}

		static Delegate cb_onChartTranslate_Landroid_view_MotionEvent_FF;
#pragma warning disable 0169
		static Delegate GetOnChartTranslate_Landroid_view_MotionEvent_FFHandler ()
		{
			if (cb_onChartTranslate_Landroid_view_MotionEvent_FF == null)
				cb_onChartTranslate_Landroid_view_MotionEvent_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float>) n_OnChartTranslate_Landroid_view_MotionEvent_FF);
			return cb_onChartTranslate_Landroid_view_MotionEvent_FF;
		}

		static void n_OnChartTranslate_Landroid_view_MotionEvent_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2)
		{
			global::MikePhil.Charting.Listener.IOnChartGestureListenerSupport __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.IOnChartGestureListenerSupport> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent p0 = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnChartTranslate (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_onChartTranslate_Landroid_view_MotionEvent_FF;
		public unsafe void OnChartTranslate (global::Android.Views.MotionEvent p0, float p1, float p2)
		{
			if (id_onChartTranslate_Landroid_view_MotionEvent_FF == IntPtr.Zero)
				id_onChartTranslate_Landroid_view_MotionEvent_FF = JNIEnv.GetMethodID (class_ref, "onChartTranslate", "(Landroid/view/MotionEvent;FF)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onChartTranslate_Landroid_view_MotionEvent_FF, __args);
		}

	}

}
