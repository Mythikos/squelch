using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Listener {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/listener/ChartTouchListener", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.github.mikephil.charting.charts.Chart<?>"})]
	public abstract partial class ChartTouchListener : global::Android.Views.GestureDetector.SimpleOnGestureListener, global::Android.Views.View.IOnTouchListener {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener']/field[@name='DRAG']"
		[Register ("DRAG")]
		protected const int Drag = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener']/field[@name='NONE']"
		[Register ("NONE")]
		protected const int None = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener']/field[@name='PINCH_ZOOM']"
		[Register ("PINCH_ZOOM")]
		protected const int PinchZoom = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener']/field[@name='POST_ZOOM']"
		[Register ("POST_ZOOM")]
		protected const int PostZoom = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener']/field[@name='ROTATE']"
		[Register ("ROTATE")]
		protected const int Rotate = (int) 6;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener']/field[@name='X_ZOOM']"
		[Register ("X_ZOOM")]
		protected const int XZoom = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener']/field[@name='Y_ZOOM']"
		[Register ("Y_ZOOM")]
		protected const int YZoom = (int) 3;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener']/field[@name='mChart']"
		[Register ("mChart")]
		protected global::MikePhil.Charting.Charts.Chart MChart {
			get {
				const string __id = "mChart.Lcom/github/mikephil/charting/charts/Chart;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mChart.Lcom/github/mikephil/charting/charts/Chart;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener']/field[@name='mGestureDetector']"
		[Register ("mGestureDetector")]
		protected global::Android.Views.GestureDetector MGestureDetector {
			get {
				const string __id = "mGestureDetector.Landroid/view/GestureDetector;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Views.GestureDetector> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mGestureDetector.Landroid/view/GestureDetector;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener']/field[@name='mLastGesture']"
		[Register ("mLastGesture")]
		protected global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture MLastGesture {
			get {
				const string __id = "mLastGesture.Lcom/github/mikephil/charting/listener/ChartTouchListener$ChartGesture;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mLastGesture.Lcom/github/mikephil/charting/listener/ChartTouchListener$ChartGesture;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener']/field[@name='mLastHighlighted']"
		[Register ("mLastHighlighted")]
		protected global::MikePhil.Charting.Highlight.Highlight MLastHighlighted {
			get {
				const string __id = "mLastHighlighted.Lcom/github/mikephil/charting/highlight/Highlight;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mLastHighlighted.Lcom/github/mikephil/charting/highlight/Highlight;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener']/field[@name='mTouchMode']"
		[Register ("mTouchMode")]
		protected int MTouchMode {
			get {
				const string __id = "mTouchMode.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mTouchMode.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener.ChartGesture']"
		[global::Android.Runtime.Register ("com/github/mikephil/charting/listener/ChartTouchListener$ChartGesture", DoNotGenerateAcw=true)]
		public sealed partial class ChartGesture : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener.ChartGesture']/field[@name='DOUBLE_TAP']"
			[Register ("DOUBLE_TAP")]
			public static global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture DoubleTap {
				get {
					const string __id = "DOUBLE_TAP.Lcom/github/mikephil/charting/listener/ChartTouchListener$ChartGesture;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener.ChartGesture']/field[@name='DRAG']"
			[Register ("DRAG")]
			public static global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture Drag {
				get {
					const string __id = "DRAG.Lcom/github/mikephil/charting/listener/ChartTouchListener$ChartGesture;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener.ChartGesture']/field[@name='FLING']"
			[Register ("FLING")]
			public static global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture Fling {
				get {
					const string __id = "FLING.Lcom/github/mikephil/charting/listener/ChartTouchListener$ChartGesture;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener.ChartGesture']/field[@name='LONG_PRESS']"
			[Register ("LONG_PRESS")]
			public static global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture LongPress {
				get {
					const string __id = "LONG_PRESS.Lcom/github/mikephil/charting/listener/ChartTouchListener$ChartGesture;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener.ChartGesture']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture None {
				get {
					const string __id = "NONE.Lcom/github/mikephil/charting/listener/ChartTouchListener$ChartGesture;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener.ChartGesture']/field[@name='PINCH_ZOOM']"
			[Register ("PINCH_ZOOM")]
			public static global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture PinchZoom {
				get {
					const string __id = "PINCH_ZOOM.Lcom/github/mikephil/charting/listener/ChartTouchListener$ChartGesture;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener.ChartGesture']/field[@name='ROTATE']"
			[Register ("ROTATE")]
			public static global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture Rotate {
				get {
					const string __id = "ROTATE.Lcom/github/mikephil/charting/listener/ChartTouchListener$ChartGesture;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener.ChartGesture']/field[@name='SINGLE_TAP']"
			[Register ("SINGLE_TAP")]
			public static global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture SingleTap {
				get {
					const string __id = "SINGLE_TAP.Lcom/github/mikephil/charting/listener/ChartTouchListener$ChartGesture;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener.ChartGesture']/field[@name='X_ZOOM']"
			[Register ("X_ZOOM")]
			public static global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture XZoom {
				get {
					const string __id = "X_ZOOM.Lcom/github/mikephil/charting/listener/ChartTouchListener$ChartGesture;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener.ChartGesture']/field[@name='Y_ZOOM']"
			[Register ("Y_ZOOM")]
			public static global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture YZoom {
				get {
					const string __id = "Y_ZOOM.Lcom/github/mikephil/charting/listener/ChartTouchListener$ChartGesture;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/listener/ChartTouchListener$ChartGesture", typeof (ChartGesture));
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

			internal ChartGesture (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener.ChartGesture']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/github/mikephil/charting/listener/ChartTouchListener$ChartGesture;", "")]
			public static unsafe global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/github/mikephil/charting/listener/ChartTouchListener$ChartGesture;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener.ChartGesture']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/github/mikephil/charting/listener/ChartTouchListener$ChartGesture;", "")]
			public static unsafe global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture[] Values ()
			{
				const string __id = "values.()[Lcom/github/mikephil/charting/listener/ChartTouchListener$ChartGesture;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/listener/ChartTouchListener", typeof (ChartTouchListener));
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

		protected ChartTouchListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener']/constructor[@name='ChartTouchListener' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/charts/Chart;)V", "")]
		public unsafe ChartTouchListener (global::Java.Lang.Object chart)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/charts/Chart;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_chart = JNIEnv.ToLocalJniHandle (chart);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_chart);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_chart);
			}
		}

		static Delegate cb_getLastGesture;
#pragma warning disable 0169
		static Delegate GetGetLastGestureHandler ()
		{
			if (cb_getLastGesture == null)
				cb_getLastGesture = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLastGesture);
			return cb_getLastGesture;
		}

		static IntPtr n_GetLastGesture (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Listener.ChartTouchListener __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LastGesture);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture LastGesture {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener']/method[@name='getLastGesture' and count(parameter)=0]"
			[Register ("getLastGesture", "()Lcom/github/mikephil/charting/listener/ChartTouchListener$ChartGesture;", "GetGetLastGestureHandler")]
			get {
				const string __id = "getLastGesture.()Lcom/github/mikephil/charting/listener/ChartTouchListener$ChartGesture;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener.ChartGesture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTouchMode;
#pragma warning disable 0169
		static Delegate GetGetTouchModeHandler ()
		{
			if (cb_getTouchMode == null)
				cb_getTouchMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetTouchMode);
			return cb_getTouchMode;
		}

		static int n_GetTouchMode (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Listener.ChartTouchListener __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TouchMode;
		}
#pragma warning restore 0169

		public virtual unsafe int TouchMode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener']/method[@name='getTouchMode' and count(parameter)=0]"
			[Register ("getTouchMode", "()I", "GetGetTouchModeHandler")]
			get {
				const string __id = "getTouchMode.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener']/method[@name='distance' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("distance", "(FFFF)F", "")]
		protected static unsafe float Distance (float eventX, float startX, float eventY, float startY)
		{
			const string __id = "distance.(FFFF)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (eventX);
				__args [1] = new JniArgumentValue (startX);
				__args [2] = new JniArgumentValue (eventY);
				__args [3] = new JniArgumentValue (startY);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_endAction_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetEndAction_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_endAction_Landroid_view_MotionEvent_ == null)
				cb_endAction_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_EndAction_Landroid_view_MotionEvent_);
			return cb_endAction_Landroid_view_MotionEvent_;
		}

		static void n_EndAction_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_me)
		{
			global::MikePhil.Charting.Listener.ChartTouchListener __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent me = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_me, JniHandleOwnership.DoNotTransfer);
			__this.EndAction (me);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener']/method[@name='endAction' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("endAction", "(Landroid/view/MotionEvent;)V", "GetEndAction_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe void EndAction (global::Android.Views.MotionEvent me)
		{
			const string __id = "endAction.(Landroid/view/MotionEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((me == null) ? IntPtr.Zero : ((global::Java.Lang.Object) me).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_performHighlight_Lcom_github_mikephil_charting_highlight_Highlight_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetPerformHighlight_Lcom_github_mikephil_charting_highlight_Highlight_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_performHighlight_Lcom_github_mikephil_charting_highlight_Highlight_Landroid_view_MotionEvent_ == null)
				cb_performHighlight_Lcom_github_mikephil_charting_highlight_Highlight_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_PerformHighlight_Lcom_github_mikephil_charting_highlight_Highlight_Landroid_view_MotionEvent_);
			return cb_performHighlight_Lcom_github_mikephil_charting_highlight_Highlight_Landroid_view_MotionEvent_;
		}

		static void n_PerformHighlight_Lcom_github_mikephil_charting_highlight_Highlight_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_h, IntPtr native_e)
		{
			global::MikePhil.Charting.Listener.ChartTouchListener __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Highlight.Highlight h = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (native_h, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.PerformHighlight (h, e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener']/method[@name='performHighlight' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.highlight.Highlight'] and parameter[2][@type='android.view.MotionEvent']]"
		[Register ("performHighlight", "(Lcom/github/mikephil/charting/highlight/Highlight;Landroid/view/MotionEvent;)V", "GetPerformHighlight_Lcom_github_mikephil_charting_highlight_Highlight_Landroid_view_MotionEvent_Handler")]
		protected virtual unsafe void PerformHighlight (global::MikePhil.Charting.Highlight.Highlight h, global::Android.Views.MotionEvent e)
		{
			const string __id = "performHighlight.(Lcom/github/mikephil/charting/highlight/Highlight;Landroid/view/MotionEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((h == null) ? IntPtr.Zero : ((global::Java.Lang.Object) h).Handle);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setLastHighlighted_Lcom_github_mikephil_charting_highlight_Highlight_;
#pragma warning disable 0169
		static Delegate GetSetLastHighlighted_Lcom_github_mikephil_charting_highlight_Highlight_Handler ()
		{
			if (cb_setLastHighlighted_Lcom_github_mikephil_charting_highlight_Highlight_ == null)
				cb_setLastHighlighted_Lcom_github_mikephil_charting_highlight_Highlight_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLastHighlighted_Lcom_github_mikephil_charting_highlight_Highlight_);
			return cb_setLastHighlighted_Lcom_github_mikephil_charting_highlight_Highlight_;
		}

		static void n_SetLastHighlighted_Lcom_github_mikephil_charting_highlight_Highlight_ (IntPtr jnienv, IntPtr native__this, IntPtr native_high)
		{
			global::MikePhil.Charting.Listener.ChartTouchListener __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Highlight.Highlight high = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (native_high, JniHandleOwnership.DoNotTransfer);
			__this.SetLastHighlighted (high);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener']/method[@name='setLastHighlighted' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.highlight.Highlight']]"
		[Register ("setLastHighlighted", "(Lcom/github/mikephil/charting/highlight/Highlight;)V", "GetSetLastHighlighted_Lcom_github_mikephil_charting_highlight_Highlight_Handler")]
		public virtual unsafe void SetLastHighlighted (global::MikePhil.Charting.Highlight.Highlight high)
		{
			const string __id = "setLastHighlighted.(Lcom/github/mikephil/charting/highlight/Highlight;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((high == null) ? IntPtr.Zero : ((global::Java.Lang.Object) high).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_startAction_Landroid_view_MotionEvent_;
#pragma warning disable 0169
		static Delegate GetStartAction_Landroid_view_MotionEvent_Handler ()
		{
			if (cb_startAction_Landroid_view_MotionEvent_ == null)
				cb_startAction_Landroid_view_MotionEvent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_StartAction_Landroid_view_MotionEvent_);
			return cb_startAction_Landroid_view_MotionEvent_;
		}

		static void n_StartAction_Landroid_view_MotionEvent_ (IntPtr jnienv, IntPtr native__this, IntPtr native_me)
		{
			global::MikePhil.Charting.Listener.ChartTouchListener __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent me = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_me, JniHandleOwnership.DoNotTransfer);
			__this.StartAction (me);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.listener']/class[@name='ChartTouchListener']/method[@name='startAction' and count(parameter)=1 and parameter[1][@type='android.view.MotionEvent']]"
		[Register ("startAction", "(Landroid/view/MotionEvent;)V", "GetStartAction_Landroid_view_MotionEvent_Handler")]
		public virtual unsafe void StartAction (global::Android.Views.MotionEvent me)
		{
			const string __id = "startAction.(Landroid/view/MotionEvent;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((me == null) ? IntPtr.Zero : ((global::Java.Lang.Object) me).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::MikePhil.Charting.Listener.ChartTouchListener __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View v = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_v, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.MotionEvent e = global::Java.Lang.Object.GetObject<global::Android.Views.MotionEvent> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.OnTouch (v, e);
			return __ret;
		}
#pragma warning restore 0169

		[Register ("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
		public abstract global::System.Boolean OnTouch (global::Android.Views.View v, global::Android.Views.MotionEvent e);

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/listener/ChartTouchListener", DoNotGenerateAcw=true)]
	internal partial class ChartTouchListenerInvoker : ChartTouchListener {

		public ChartTouchListenerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/github/mikephil/charting/listener/ChartTouchListener", typeof (ChartTouchListenerInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		[Register ("onTouch", "(Landroid/view/View;Landroid/view/MotionEvent;)Z", "GetOnTouch_Landroid_view_View_Landroid_view_MotionEvent_Handler")]
		public override unsafe global::System.Boolean OnTouch (global::Android.Views.View v, global::Android.Views.MotionEvent e)
		{
			const string __id = "onTouch.(Landroid/view/View;Landroid/view/MotionEvent;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((v == null) ? IntPtr.Zero : ((global::Java.Lang.Object) v).Handle);
				__args [1] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}

}
