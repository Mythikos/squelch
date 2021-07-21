using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/renderer/LineChartRenderer", DoNotGenerateAcw=true)]
	public partial class LineChartRenderer : global::MikePhil.Charting.Renderer.LineRadarRenderer {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']/field[@name='cubicFillPath']"
		[Register ("cubicFillPath")]
		protected global::Android.Graphics.Path CubicFillPath {
			get {
				const string __id = "cubicFillPath.Landroid/graphics/Path;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Path> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cubicFillPath.Landroid/graphics/Path;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']/field[@name='cubicPath']"
		[Register ("cubicPath")]
		protected global::Android.Graphics.Path CubicPath {
			get {
				const string __id = "cubicPath.Landroid/graphics/Path;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Path> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "cubicPath.Landroid/graphics/Path;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']/field[@name='mBitmapCanvas']"
		[Register ("mBitmapCanvas")]
		protected global::Android.Graphics.Canvas MBitmapCanvas {
			get {
				const string __id = "mBitmapCanvas.Landroid/graphics/Canvas;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mBitmapCanvas.Landroid/graphics/Canvas;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']/field[@name='mBitmapConfig']"
		[Register ("mBitmapConfig")]
		protected global::Android.Graphics.Bitmap.Config MBitmapConfig {
			get {
				const string __id = "mBitmapConfig.Landroid/graphics/Bitmap$Config;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.Config> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mBitmapConfig.Landroid/graphics/Bitmap$Config;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']/field[@name='mChart']"
		[Register ("mChart")]
		protected global::MikePhil.Charting.Interfaces.Dataprovider.ILineDataProvider MChart {
			get {
				const string __id = "mChart.Lcom/github/mikephil/charting/interfaces/dataprovider/LineDataProvider;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ILineDataProvider> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mChart.Lcom/github/mikephil/charting/interfaces/dataprovider/LineDataProvider;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']/field[@name='mCirclePaintInner']"
		[Register ("mCirclePaintInner")]
		protected global::Android.Graphics.Paint MCirclePaintInner {
			get {
				const string __id = "mCirclePaintInner.Landroid/graphics/Paint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mCirclePaintInner.Landroid/graphics/Paint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']/field[@name='mDrawBitmap']"
		[Register ("mDrawBitmap")]
		protected global::Java.Lang.Ref.WeakReference MDrawBitmap {
			get {
				const string __id = "mDrawBitmap.Ljava/lang/ref/WeakReference;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Ref.WeakReference> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDrawBitmap.Ljava/lang/ref/WeakReference;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']/field[@name='mGenerateFilledPathBuffer']"
		[Register ("mGenerateFilledPathBuffer")]
		protected global::Android.Graphics.Path MGenerateFilledPathBuffer {
			get {
				const string __id = "mGenerateFilledPathBuffer.Landroid/graphics/Path;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Path> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mGenerateFilledPathBuffer.Landroid/graphics/Path;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/renderer/LineChartRenderer", typeof (LineChartRenderer));
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

		protected LineChartRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']/constructor[@name='LineChartRenderer' and count(parameter)=3 and parameter[1][@type='com.github.mikephil.charting.interfaces.dataprovider.LineDataProvider'] and parameter[2][@type='com.github.mikephil.charting.animation.ChartAnimator'] and parameter[3][@type='com.github.mikephil.charting.utils.ViewPortHandler']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/interfaces/dataprovider/LineDataProvider;Lcom/github/mikephil/charting/animation/ChartAnimator;Lcom/github/mikephil/charting/utils/ViewPortHandler;)V", "")]
		public unsafe LineChartRenderer (global::MikePhil.Charting.Interfaces.Dataprovider.ILineDataProvider chart, global::MikePhil.Charting.Animation.ChartAnimator animator, global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/interfaces/dataprovider/LineDataProvider;Lcom/github/mikephil/charting/animation/ChartAnimator;Lcom/github/mikephil/charting/utils/ViewPortHandler;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((chart == null) ? IntPtr.Zero : ((global::Java.Lang.Object) chart).Handle);
				__args [1] = new JniArgumentValue ((animator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) animator).Handle);
				__args [2] = new JniArgumentValue ((viewPortHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPortHandler).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getBitmapConfig;
#pragma warning disable 0169
		static Delegate GetGetBitmapConfigHandler ()
		{
			if (cb_getBitmapConfig == null)
				cb_getBitmapConfig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBitmapConfig);
			return cb_getBitmapConfig;
		}

		static IntPtr n_GetBitmapConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Renderer.LineChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LineChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BitmapConfig);
		}
#pragma warning restore 0169

		static Delegate cb_setBitmapConfig_Landroid_graphics_Bitmap_Config_;
#pragma warning disable 0169
		static Delegate GetSetBitmapConfig_Landroid_graphics_Bitmap_Config_Handler ()
		{
			if (cb_setBitmapConfig_Landroid_graphics_Bitmap_Config_ == null)
				cb_setBitmapConfig_Landroid_graphics_Bitmap_Config_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBitmapConfig_Landroid_graphics_Bitmap_Config_);
			return cb_setBitmapConfig_Landroid_graphics_Bitmap_Config_;
		}

		static void n_SetBitmapConfig_Landroid_graphics_Bitmap_Config_ (IntPtr jnienv, IntPtr native__this, IntPtr native_config)
		{
			global::MikePhil.Charting.Renderer.LineChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LineChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap.Config config = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.Config> (native_config, JniHandleOwnership.DoNotTransfer);
			__this.BitmapConfig = config;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Bitmap.Config BitmapConfig {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']/method[@name='getBitmapConfig' and count(parameter)=0]"
			[Register ("getBitmapConfig", "()Landroid/graphics/Bitmap$Config;", "GetGetBitmapConfigHandler")]
			get {
				const string __id = "getBitmapConfig.()Landroid/graphics/Bitmap$Config;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.Config> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']/method[@name='setBitmapConfig' and count(parameter)=1 and parameter[1][@type='android.graphics.Bitmap.Config']]"
			[Register ("setBitmapConfig", "(Landroid/graphics/Bitmap$Config;)V", "GetSetBitmapConfig_Landroid_graphics_Bitmap_Config_Handler")]
			set {
				const string __id = "setBitmapConfig.(Landroid/graphics/Bitmap$Config;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_drawCircles_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDrawCircles_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_drawCircles_Landroid_graphics_Canvas_ == null)
				cb_drawCircles_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DrawCircles_Landroid_graphics_Canvas_);
			return cb_drawCircles_Landroid_graphics_Canvas_;
		}

		static void n_DrawCircles_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			global::MikePhil.Charting.Renderer.LineChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LineChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.DrawCircles (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']/method[@name='drawCircles' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawCircles", "(Landroid/graphics/Canvas;)V", "GetDrawCircles_Landroid_graphics_Canvas_Handler")]
		protected virtual unsafe void DrawCircles (global::Android.Graphics.Canvas c)
		{
			const string __id = "drawCircles.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawCubicBezier_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_;
#pragma warning disable 0169
		static Delegate GetDrawCubicBezier_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Handler ()
		{
			if (cb_drawCubicBezier_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_ == null)
				cb_drawCubicBezier_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DrawCubicBezier_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_);
			return cb_drawCubicBezier_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_;
		}

		static void n_DrawCubicBezier_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dataSet)
		{
			global::MikePhil.Charting.Renderer.LineChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LineChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet dataSet = (global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (native_dataSet, JniHandleOwnership.DoNotTransfer);
			__this.DrawCubicBezier (dataSet);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']/method[@name='drawCubicBezier' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.interfaces.datasets.ILineDataSet']]"
		[Register ("drawCubicBezier", "(Lcom/github/mikephil/charting/interfaces/datasets/ILineDataSet;)V", "GetDrawCubicBezier_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Handler")]
		protected virtual unsafe void DrawCubicBezier (global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet dataSet)
		{
			const string __id = "drawCubicBezier.(Lcom/github/mikephil/charting/interfaces/datasets/ILineDataSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSet).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawCubicFill_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Landroid_graphics_Path_Lcom_github_mikephil_charting_utils_Transformer_Lcom_github_mikephil_charting_renderer_BarLineScatterCandleBubbleRenderer_XBounds_;
#pragma warning disable 0169
		static Delegate GetDrawCubicFill_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Landroid_graphics_Path_Lcom_github_mikephil_charting_utils_Transformer_Lcom_github_mikephil_charting_renderer_BarLineScatterCandleBubbleRenderer_XBounds_Handler ()
		{
			if (cb_drawCubicFill_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Landroid_graphics_Path_Lcom_github_mikephil_charting_utils_Transformer_Lcom_github_mikephil_charting_renderer_BarLineScatterCandleBubbleRenderer_XBounds_ == null)
				cb_drawCubicFill_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Landroid_graphics_Path_Lcom_github_mikephil_charting_utils_Transformer_Lcom_github_mikephil_charting_renderer_BarLineScatterCandleBubbleRenderer_XBounds_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DrawCubicFill_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Landroid_graphics_Path_Lcom_github_mikephil_charting_utils_Transformer_Lcom_github_mikephil_charting_renderer_BarLineScatterCandleBubbleRenderer_XBounds_);
			return cb_drawCubicFill_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Landroid_graphics_Path_Lcom_github_mikephil_charting_utils_Transformer_Lcom_github_mikephil_charting_renderer_BarLineScatterCandleBubbleRenderer_XBounds_;
		}

		static void n_DrawCubicFill_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Landroid_graphics_Path_Lcom_github_mikephil_charting_utils_Transformer_Lcom_github_mikephil_charting_renderer_BarLineScatterCandleBubbleRenderer_XBounds_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_dataSet, IntPtr native_spline, IntPtr native_trans, IntPtr native_bounds)
		{
			global::MikePhil.Charting.Renderer.LineChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LineChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet dataSet = (global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (native_dataSet, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Path spline = global::Java.Lang.Object.GetObject<global::Android.Graphics.Path> (native_spline, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Util.Transformer trans = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (native_trans, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Renderer.BarLineScatterCandleBubbleRenderer.XBounds bounds = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.BarLineScatterCandleBubbleRenderer.XBounds> (native_bounds, JniHandleOwnership.DoNotTransfer);
			__this.DrawCubicFill (c, dataSet, spline, trans, bounds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']/method[@name='drawCubicFill' and count(parameter)=5 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.github.mikephil.charting.interfaces.datasets.ILineDataSet'] and parameter[3][@type='android.graphics.Path'] and parameter[4][@type='com.github.mikephil.charting.utils.Transformer'] and parameter[5][@type='com.github.mikephil.charting.renderer.BarLineScatterCandleBubbleRenderer.XBounds']]"
		[Register ("drawCubicFill", "(Landroid/graphics/Canvas;Lcom/github/mikephil/charting/interfaces/datasets/ILineDataSet;Landroid/graphics/Path;Lcom/github/mikephil/charting/utils/Transformer;Lcom/github/mikephil/charting/renderer/BarLineScatterCandleBubbleRenderer$XBounds;)V", "GetDrawCubicFill_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Landroid_graphics_Path_Lcom_github_mikephil_charting_utils_Transformer_Lcom_github_mikephil_charting_renderer_BarLineScatterCandleBubbleRenderer_XBounds_Handler")]
		protected virtual unsafe void DrawCubicFill (global::Android.Graphics.Canvas c, global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet dataSet, global::Android.Graphics.Path spline, global::MikePhil.Charting.Util.Transformer trans, global::MikePhil.Charting.Renderer.BarLineScatterCandleBubbleRenderer.XBounds bounds)
		{
			const string __id = "drawCubicFill.(Landroid/graphics/Canvas;Lcom/github/mikephil/charting/interfaces/datasets/ILineDataSet;Landroid/graphics/Path;Lcom/github/mikephil/charting/utils/Transformer;Lcom/github/mikephil/charting/renderer/BarLineScatterCandleBubbleRenderer$XBounds;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue ((dataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSet).Handle);
				__args [2] = new JniArgumentValue ((spline == null) ? IntPtr.Zero : ((global::Java.Lang.Object) spline).Handle);
				__args [3] = new JniArgumentValue ((trans == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trans).Handle);
				__args [4] = new JniArgumentValue ((bounds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bounds).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawData_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDrawData_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_drawData_Landroid_graphics_Canvas_ == null)
				cb_drawData_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DrawData_Landroid_graphics_Canvas_);
			return cb_drawData_Landroid_graphics_Canvas_;
		}

		static void n_DrawData_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			global::MikePhil.Charting.Renderer.LineChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LineChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.DrawData (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']/method[@name='drawData' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawData", "(Landroid/graphics/Canvas;)V", "GetDrawData_Landroid_graphics_Canvas_Handler")]
		public override unsafe void DrawData (global::Android.Graphics.Canvas c)
		{
			const string __id = "drawData.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_;
#pragma warning disable 0169
		static Delegate GetDrawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Handler ()
		{
			if (cb_drawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_ == null)
				cb_drawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DrawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_);
			return cb_drawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_;
		}

		static void n_DrawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_dataSet)
		{
			global::MikePhil.Charting.Renderer.LineChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LineChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet dataSet = (global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (native_dataSet, JniHandleOwnership.DoNotTransfer);
			__this.DrawDataSet (c, dataSet);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']/method[@name='drawDataSet' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.github.mikephil.charting.interfaces.datasets.ILineDataSet']]"
		[Register ("drawDataSet", "(Landroid/graphics/Canvas;Lcom/github/mikephil/charting/interfaces/datasets/ILineDataSet;)V", "GetDrawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Handler")]
		protected virtual unsafe void DrawDataSet (global::Android.Graphics.Canvas c, global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet dataSet)
		{
			const string __id = "drawDataSet.(Landroid/graphics/Canvas;Lcom/github/mikephil/charting/interfaces/datasets/ILineDataSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue ((dataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSet).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawExtras_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDrawExtras_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_drawExtras_Landroid_graphics_Canvas_ == null)
				cb_drawExtras_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DrawExtras_Landroid_graphics_Canvas_);
			return cb_drawExtras_Landroid_graphics_Canvas_;
		}

		static void n_DrawExtras_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			global::MikePhil.Charting.Renderer.LineChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LineChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.DrawExtras (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']/method[@name='drawExtras' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawExtras", "(Landroid/graphics/Canvas;)V", "GetDrawExtras_Landroid_graphics_Canvas_Handler")]
		public override unsafe void DrawExtras (global::Android.Graphics.Canvas c)
		{
			const string __id = "drawExtras.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_;
#pragma warning disable 0169
		static Delegate GetDrawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_Handler ()
		{
			if (cb_drawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_ == null)
				cb_drawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DrawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_);
			return cb_drawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_;
		}

		static void n_DrawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_indices)
		{
			global::MikePhil.Charting.Renderer.LineChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LineChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Highlight.Highlight[] indices = (global::MikePhil.Charting.Highlight.Highlight[]) JNIEnv.GetArray (native_indices, JniHandleOwnership.DoNotTransfer, typeof (global::MikePhil.Charting.Highlight.Highlight));
			__this.DrawHighlighted (c, indices);
			if (indices != null)
				JNIEnv.CopyArray (indices, native_indices);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']/method[@name='drawHighlighted' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.github.mikephil.charting.highlight.Highlight[]']]"
		[Register ("drawHighlighted", "(Landroid/graphics/Canvas;[Lcom/github/mikephil/charting/highlight/Highlight;)V", "GetDrawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_Handler")]
		public override unsafe void DrawHighlighted (global::Android.Graphics.Canvas c, global::MikePhil.Charting.Highlight.Highlight[] indices)
		{
			const string __id = "drawHighlighted.(Landroid/graphics/Canvas;[Lcom/github/mikephil/charting/highlight/Highlight;)V";
			IntPtr native_indices = JNIEnv.NewArray (indices);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue (native_indices);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (indices != null) {
					JNIEnv.CopyArray (native_indices, indices);
					JNIEnv.DeleteLocalRef (native_indices);
				}
			}
		}

		static Delegate cb_drawHorizontalBezier_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_;
#pragma warning disable 0169
		static Delegate GetDrawHorizontalBezier_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Handler ()
		{
			if (cb_drawHorizontalBezier_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_ == null)
				cb_drawHorizontalBezier_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DrawHorizontalBezier_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_);
			return cb_drawHorizontalBezier_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_;
		}

		static void n_DrawHorizontalBezier_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dataSet)
		{
			global::MikePhil.Charting.Renderer.LineChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LineChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet dataSet = (global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (native_dataSet, JniHandleOwnership.DoNotTransfer);
			__this.DrawHorizontalBezier (dataSet);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']/method[@name='drawHorizontalBezier' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.interfaces.datasets.ILineDataSet']]"
		[Register ("drawHorizontalBezier", "(Lcom/github/mikephil/charting/interfaces/datasets/ILineDataSet;)V", "GetDrawHorizontalBezier_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Handler")]
		protected virtual unsafe void DrawHorizontalBezier (global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet dataSet)
		{
			const string __id = "drawHorizontalBezier.(Lcom/github/mikephil/charting/interfaces/datasets/ILineDataSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSet).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawLinear_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_;
#pragma warning disable 0169
		static Delegate GetDrawLinear_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Handler ()
		{
			if (cb_drawLinear_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_ == null)
				cb_drawLinear_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_DrawLinear_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_);
			return cb_drawLinear_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_;
		}

		static void n_DrawLinear_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_dataSet)
		{
			global::MikePhil.Charting.Renderer.LineChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LineChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet dataSet = (global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (native_dataSet, JniHandleOwnership.DoNotTransfer);
			__this.DrawLinear (c, dataSet);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']/method[@name='drawLinear' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.github.mikephil.charting.interfaces.datasets.ILineDataSet']]"
		[Register ("drawLinear", "(Landroid/graphics/Canvas;Lcom/github/mikephil/charting/interfaces/datasets/ILineDataSet;)V", "GetDrawLinear_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Handler")]
		protected virtual unsafe void DrawLinear (global::Android.Graphics.Canvas c, global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet dataSet)
		{
			const string __id = "drawLinear.(Landroid/graphics/Canvas;Lcom/github/mikephil/charting/interfaces/datasets/ILineDataSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue ((dataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSet).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawLinearFill_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_utils_Transformer_Lcom_github_mikephil_charting_renderer_BarLineScatterCandleBubbleRenderer_XBounds_;
#pragma warning disable 0169
		static Delegate GetDrawLinearFill_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_utils_Transformer_Lcom_github_mikephil_charting_renderer_BarLineScatterCandleBubbleRenderer_XBounds_Handler ()
		{
			if (cb_drawLinearFill_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_utils_Transformer_Lcom_github_mikephil_charting_renderer_BarLineScatterCandleBubbleRenderer_XBounds_ == null)
				cb_drawLinearFill_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_utils_Transformer_Lcom_github_mikephil_charting_renderer_BarLineScatterCandleBubbleRenderer_XBounds_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DrawLinearFill_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_utils_Transformer_Lcom_github_mikephil_charting_renderer_BarLineScatterCandleBubbleRenderer_XBounds_);
			return cb_drawLinearFill_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_utils_Transformer_Lcom_github_mikephil_charting_renderer_BarLineScatterCandleBubbleRenderer_XBounds_;
		}

		static void n_DrawLinearFill_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_utils_Transformer_Lcom_github_mikephil_charting_renderer_BarLineScatterCandleBubbleRenderer_XBounds_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_dataSet, IntPtr native_trans, IntPtr native_bounds)
		{
			global::MikePhil.Charting.Renderer.LineChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LineChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet dataSet = (global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (native_dataSet, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Util.Transformer trans = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (native_trans, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Renderer.BarLineScatterCandleBubbleRenderer.XBounds bounds = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.BarLineScatterCandleBubbleRenderer.XBounds> (native_bounds, JniHandleOwnership.DoNotTransfer);
			__this.DrawLinearFill (c, dataSet, trans, bounds);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']/method[@name='drawLinearFill' and count(parameter)=4 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.github.mikephil.charting.interfaces.datasets.ILineDataSet'] and parameter[3][@type='com.github.mikephil.charting.utils.Transformer'] and parameter[4][@type='com.github.mikephil.charting.renderer.BarLineScatterCandleBubbleRenderer.XBounds']]"
		[Register ("drawLinearFill", "(Landroid/graphics/Canvas;Lcom/github/mikephil/charting/interfaces/datasets/ILineDataSet;Lcom/github/mikephil/charting/utils/Transformer;Lcom/github/mikephil/charting/renderer/BarLineScatterCandleBubbleRenderer$XBounds;)V", "GetDrawLinearFill_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_Lcom_github_mikephil_charting_utils_Transformer_Lcom_github_mikephil_charting_renderer_BarLineScatterCandleBubbleRenderer_XBounds_Handler")]
		protected virtual unsafe void DrawLinearFill (global::Android.Graphics.Canvas c, global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet dataSet, global::MikePhil.Charting.Util.Transformer trans, global::MikePhil.Charting.Renderer.BarLineScatterCandleBubbleRenderer.XBounds bounds)
		{
			const string __id = "drawLinearFill.(Landroid/graphics/Canvas;Lcom/github/mikephil/charting/interfaces/datasets/ILineDataSet;Lcom/github/mikephil/charting/utils/Transformer;Lcom/github/mikephil/charting/renderer/BarLineScatterCandleBubbleRenderer$XBounds;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue ((dataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSet).Handle);
				__args [2] = new JniArgumentValue ((trans == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trans).Handle);
				__args [3] = new JniArgumentValue ((bounds == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bounds).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawValues_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDrawValues_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_drawValues_Landroid_graphics_Canvas_ == null)
				cb_drawValues_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DrawValues_Landroid_graphics_Canvas_);
			return cb_drawValues_Landroid_graphics_Canvas_;
		}

		static void n_DrawValues_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			global::MikePhil.Charting.Renderer.LineChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LineChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.DrawValues (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']/method[@name='drawValues' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawValues", "(Landroid/graphics/Canvas;)V", "GetDrawValues_Landroid_graphics_Canvas_Handler")]
		public override unsafe void DrawValues (global::Android.Graphics.Canvas c)
		{
			const string __id = "drawValues.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_initBuffers;
#pragma warning disable 0169
		static Delegate GetInitBuffersHandler ()
		{
			if (cb_initBuffers == null)
				cb_initBuffers = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_InitBuffers);
			return cb_initBuffers;
		}

		static void n_InitBuffers (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Renderer.LineChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LineChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitBuffers ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']/method[@name='initBuffers' and count(parameter)=0]"
		[Register ("initBuffers", "()V", "GetInitBuffersHandler")]
		public override unsafe void InitBuffers ()
		{
			const string __id = "initBuffers.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_releaseBitmap;
#pragma warning disable 0169
		static Delegate GetReleaseBitmapHandler ()
		{
			if (cb_releaseBitmap == null)
				cb_releaseBitmap = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReleaseBitmap);
			return cb_releaseBitmap;
		}

		static void n_ReleaseBitmap (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Renderer.LineChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LineChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseBitmap ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineChartRenderer']/method[@name='releaseBitmap' and count(parameter)=0]"
		[Register ("releaseBitmap", "()V", "GetReleaseBitmapHandler")]
		public virtual unsafe void ReleaseBitmap ()
		{
			const string __id = "releaseBitmap.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
