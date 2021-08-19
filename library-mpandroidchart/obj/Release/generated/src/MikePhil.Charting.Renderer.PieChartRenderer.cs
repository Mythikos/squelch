using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/renderer/PieChartRenderer", DoNotGenerateAcw=true)]
	public partial class PieChartRenderer : global::MikePhil.Charting.Renderer.DataRenderer {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/field[@name='mBitmapCanvas']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/field[@name='mChart']"
		[Register ("mChart")]
		protected global::MikePhil.Charting.Charts.PieChart MChart {
			get {
				const string __id = "mChart.Lcom/github/mikephil/charting/charts/PieChart;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mChart.Lcom/github/mikephil/charting/charts/PieChart;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/field[@name='mDrawBitmap']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/field[@name='mDrawCenterTextPathBuffer']"
		[Register ("mDrawCenterTextPathBuffer")]
		protected global::Android.Graphics.Path MDrawCenterTextPathBuffer {
			get {
				const string __id = "mDrawCenterTextPathBuffer.Landroid/graphics/Path;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Path> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDrawCenterTextPathBuffer.Landroid/graphics/Path;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/field[@name='mDrawHighlightedRectF']"
		[Register ("mDrawHighlightedRectF")]
		protected global::Android.Graphics.RectF MDrawHighlightedRectF {
			get {
				const string __id = "mDrawHighlightedRectF.Landroid/graphics/RectF;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDrawHighlightedRectF.Landroid/graphics/RectF;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/field[@name='mHolePaint']"
		[Register ("mHolePaint")]
		protected global::Android.Graphics.Paint MHolePaint {
			get {
				const string __id = "mHolePaint.Landroid/graphics/Paint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mHolePaint.Landroid/graphics/Paint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/field[@name='mTransparentCirclePaint']"
		[Register ("mTransparentCirclePaint")]
		protected global::Android.Graphics.Paint MTransparentCirclePaint {
			get {
				const string __id = "mTransparentCirclePaint.Landroid/graphics/Paint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mTransparentCirclePaint.Landroid/graphics/Paint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/field[@name='mValueLinePaint']"
		[Register ("mValueLinePaint")]
		protected global::Android.Graphics.Paint MValueLinePaint {
			get {
				const string __id = "mValueLinePaint.Landroid/graphics/Paint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mValueLinePaint.Landroid/graphics/Paint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/renderer/PieChartRenderer", typeof (PieChartRenderer));

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

		protected PieChartRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/constructor[@name='PieChartRenderer' and count(parameter)=3 and parameter[1][@type='com.github.mikephil.charting.charts.PieChart'] and parameter[2][@type='com.github.mikephil.charting.animation.ChartAnimator'] and parameter[3][@type='com.github.mikephil.charting.utils.ViewPortHandler']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/charts/PieChart;Lcom/github/mikephil/charting/animation/ChartAnimator;Lcom/github/mikephil/charting/utils/ViewPortHandler;)V", "")]
		public unsafe PieChartRenderer (global::MikePhil.Charting.Charts.PieChart chart, global::MikePhil.Charting.Animation.ChartAnimator animator, global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/charts/PieChart;Lcom/github/mikephil/charting/animation/ChartAnimator;Lcom/github/mikephil/charting/utils/ViewPortHandler;)V";

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
				global::System.GC.KeepAlive (chart);
				global::System.GC.KeepAlive (animator);
				global::System.GC.KeepAlive (viewPortHandler);
			}
		}

		static Delegate cb_getPaintCenterText;
#pragma warning disable 0169
		static Delegate GetGetPaintCenterTextHandler ()
		{
			if (cb_getPaintCenterText == null)
				cb_getPaintCenterText = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPaintCenterText);
			return cb_getPaintCenterText;
		}

		static IntPtr n_GetPaintCenterText (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.PieChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PaintCenterText);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Text.TextPaint PaintCenterText {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/method[@name='getPaintCenterText' and count(parameter)=0]"
			[Register ("getPaintCenterText", "()Landroid/text/TextPaint;", "GetGetPaintCenterTextHandler")]
			get {
				const string __id = "getPaintCenterText.()Landroid/text/TextPaint;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Text.TextPaint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPaintEntryLabels;
#pragma warning disable 0169
		static Delegate GetGetPaintEntryLabelsHandler ()
		{
			if (cb_getPaintEntryLabels == null)
				cb_getPaintEntryLabels = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPaintEntryLabels);
			return cb_getPaintEntryLabels;
		}

		static IntPtr n_GetPaintEntryLabels (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.PieChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PaintEntryLabels);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Paint PaintEntryLabels {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/method[@name='getPaintEntryLabels' and count(parameter)=0]"
			[Register ("getPaintEntryLabels", "()Landroid/graphics/Paint;", "GetGetPaintEntryLabelsHandler")]
			get {
				const string __id = "getPaintEntryLabels.()Landroid/graphics/Paint;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPaintHole;
#pragma warning disable 0169
		static Delegate GetGetPaintHoleHandler ()
		{
			if (cb_getPaintHole == null)
				cb_getPaintHole = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPaintHole);
			return cb_getPaintHole;
		}

		static IntPtr n_GetPaintHole (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.PieChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PaintHole);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Paint PaintHole {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/method[@name='getPaintHole' and count(parameter)=0]"
			[Register ("getPaintHole", "()Landroid/graphics/Paint;", "GetGetPaintHoleHandler")]
			get {
				const string __id = "getPaintHole.()Landroid/graphics/Paint;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPaintTransparentCircle;
#pragma warning disable 0169
		static Delegate GetGetPaintTransparentCircleHandler ()
		{
			if (cb_getPaintTransparentCircle == null)
				cb_getPaintTransparentCircle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPaintTransparentCircle);
			return cb_getPaintTransparentCircle;
		}

		static IntPtr n_GetPaintTransparentCircle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.PieChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PaintTransparentCircle);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Paint PaintTransparentCircle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/method[@name='getPaintTransparentCircle' and count(parameter)=0]"
			[Register ("getPaintTransparentCircle", "()Landroid/graphics/Paint;", "GetGetPaintTransparentCircleHandler")]
			get {
				const string __id = "getPaintTransparentCircle.()Landroid/graphics/Paint;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_calculateMinimumRadiusForSpacedSlice_Lcom_github_mikephil_charting_utils_MPPointF_FFFFFF;
#pragma warning disable 0169
		static Delegate GetCalculateMinimumRadiusForSpacedSlice_Lcom_github_mikephil_charting_utils_MPPointF_FFFFFFHandler ()
		{
			if (cb_calculateMinimumRadiusForSpacedSlice_Lcom_github_mikephil_charting_utils_MPPointF_FFFFFF == null)
				cb_calculateMinimumRadiusForSpacedSlice_Lcom_github_mikephil_charting_utils_MPPointF_FFFFFF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLFFFFFF_F) n_CalculateMinimumRadiusForSpacedSlice_Lcom_github_mikephil_charting_utils_MPPointF_FFFFFF);
			return cb_calculateMinimumRadiusForSpacedSlice_Lcom_github_mikephil_charting_utils_MPPointF_FFFFFF;
		}

		static float n_CalculateMinimumRadiusForSpacedSlice_Lcom_github_mikephil_charting_utils_MPPointF_FFFFFF (IntPtr jnienv, IntPtr native__this, IntPtr native_center, float radius, float angle, float arcStartPointX, float arcStartPointY, float startAngle, float sweepAngle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.PieChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var center = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (native_center, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.CalculateMinimumRadiusForSpacedSlice (center, radius, angle, arcStartPointX, arcStartPointY, startAngle, sweepAngle);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/method[@name='calculateMinimumRadiusForSpacedSlice' and count(parameter)=7 and parameter[1][@type='com.github.mikephil.charting.utils.MPPointF'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='float'] and parameter[7][@type='float']]"
		[Register ("calculateMinimumRadiusForSpacedSlice", "(Lcom/github/mikephil/charting/utils/MPPointF;FFFFFF)F", "GetCalculateMinimumRadiusForSpacedSlice_Lcom_github_mikephil_charting_utils_MPPointF_FFFFFFHandler")]
		protected virtual unsafe float CalculateMinimumRadiusForSpacedSlice (global::MikePhil.Charting.Util.MPPointF center, float radius, float angle, float arcStartPointX, float arcStartPointY, float startAngle, float sweepAngle)
		{
			const string __id = "calculateMinimumRadiusForSpacedSlice.(Lcom/github/mikephil/charting/utils/MPPointF;FFFFFF)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((center == null) ? IntPtr.Zero : ((global::Java.Lang.Object) center).Handle);
				__args [1] = new JniArgumentValue (radius);
				__args [2] = new JniArgumentValue (angle);
				__args [3] = new JniArgumentValue (arcStartPointX);
				__args [4] = new JniArgumentValue (arcStartPointY);
				__args [5] = new JniArgumentValue (startAngle);
				__args [6] = new JniArgumentValue (sweepAngle);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (center);
			}
		}

		static Delegate cb_drawCenterText_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDrawCenterText_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_drawCenterText_Landroid_graphics_Canvas_ == null)
				cb_drawCenterText_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DrawCenterText_Landroid_graphics_Canvas_);
			return cb_drawCenterText_Landroid_graphics_Canvas_;
		}

		static void n_DrawCenterText_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.PieChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.DrawCenterText (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/method[@name='drawCenterText' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawCenterText", "(Landroid/graphics/Canvas;)V", "GetDrawCenterText_Landroid_graphics_Canvas_Handler")]
		protected virtual unsafe void DrawCenterText (global::Android.Graphics.Canvas c)
		{
			const string __id = "drawCenterText.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
			}
		}

		static Delegate cb_drawData_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDrawData_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_drawData_Landroid_graphics_Canvas_ == null)
				cb_drawData_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DrawData_Landroid_graphics_Canvas_);
			return cb_drawData_Landroid_graphics_Canvas_;
		}

		static void n_DrawData_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.PieChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.DrawData (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/method[@name='drawData' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawData", "(Landroid/graphics/Canvas;)V", "GetDrawData_Landroid_graphics_Canvas_Handler")]
		public override unsafe void DrawData (global::Android.Graphics.Canvas c)
		{
			const string __id = "drawData.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
			}
		}

		static Delegate cb_drawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IPieDataSet_;
#pragma warning disable 0169
		static Delegate GetDrawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IPieDataSet_Handler ()
		{
			if (cb_drawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IPieDataSet_ == null)
				cb_drawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IPieDataSet_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_DrawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IPieDataSet_);
			return cb_drawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IPieDataSet_;
		}

		static void n_DrawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IPieDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_dataSet)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.PieChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			var dataSet = (global::MikePhil.Charting.Interfaces.Datasets.IPieDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IPieDataSet> (native_dataSet, JniHandleOwnership.DoNotTransfer);
			__this.DrawDataSet (c, dataSet);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/method[@name='drawDataSet' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.github.mikephil.charting.interfaces.datasets.IPieDataSet']]"
		[Register ("drawDataSet", "(Landroid/graphics/Canvas;Lcom/github/mikephil/charting/interfaces/datasets/IPieDataSet;)V", "GetDrawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IPieDataSet_Handler")]
		protected virtual unsafe void DrawDataSet (global::Android.Graphics.Canvas c, global::MikePhil.Charting.Interfaces.Datasets.IPieDataSet dataSet)
		{
			const string __id = "drawDataSet.(Landroid/graphics/Canvas;Lcom/github/mikephil/charting/interfaces/datasets/IPieDataSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue ((dataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSet).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
				global::System.GC.KeepAlive (dataSet);
			}
		}

		static Delegate cb_drawEntryLabel_Landroid_graphics_Canvas_Ljava_lang_String_FF;
#pragma warning disable 0169
		static Delegate GetDrawEntryLabel_Landroid_graphics_Canvas_Ljava_lang_String_FFHandler ()
		{
			if (cb_drawEntryLabel_Landroid_graphics_Canvas_Ljava_lang_String_FF == null)
				cb_drawEntryLabel_Landroid_graphics_Canvas_Ljava_lang_String_FF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLFF_V) n_DrawEntryLabel_Landroid_graphics_Canvas_Ljava_lang_String_FF);
			return cb_drawEntryLabel_Landroid_graphics_Canvas_Ljava_lang_String_FF;
		}

		static void n_DrawEntryLabel_Landroid_graphics_Canvas_Ljava_lang_String_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_label, float x, float y)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.PieChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			var label = JNIEnv.GetString (native_label, JniHandleOwnership.DoNotTransfer);
			__this.DrawEntryLabel (c, label, x, y);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/method[@name='drawEntryLabel' and count(parameter)=4 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("drawEntryLabel", "(Landroid/graphics/Canvas;Ljava/lang/String;FF)V", "GetDrawEntryLabel_Landroid_graphics_Canvas_Ljava_lang_String_FFHandler")]
		protected virtual unsafe void DrawEntryLabel (global::Android.Graphics.Canvas c, string label, float x, float y)
		{
			const string __id = "drawEntryLabel.(Landroid/graphics/Canvas;Ljava/lang/String;FF)V";
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue (native_label);
				__args [2] = new JniArgumentValue (x);
				__args [3] = new JniArgumentValue (y);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_label);
				global::System.GC.KeepAlive (c);
			}
		}

		static Delegate cb_drawExtras_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDrawExtras_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_drawExtras_Landroid_graphics_Canvas_ == null)
				cb_drawExtras_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DrawExtras_Landroid_graphics_Canvas_);
			return cb_drawExtras_Landroid_graphics_Canvas_;
		}

		static void n_DrawExtras_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.PieChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.DrawExtras (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/method[@name='drawExtras' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawExtras", "(Landroid/graphics/Canvas;)V", "GetDrawExtras_Landroid_graphics_Canvas_Handler")]
		public override unsafe void DrawExtras (global::Android.Graphics.Canvas c)
		{
			const string __id = "drawExtras.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
			}
		}

		static Delegate cb_drawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_;
#pragma warning disable 0169
		static Delegate GetDrawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_Handler ()
		{
			if (cb_drawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_ == null)
				cb_drawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_DrawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_);
			return cb_drawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_;
		}

		static void n_DrawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_indices)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.PieChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			var indices = (global::MikePhil.Charting.Highlight.Highlight[]) JNIEnv.GetArray (native_indices, JniHandleOwnership.DoNotTransfer, typeof (global::MikePhil.Charting.Highlight.Highlight));
			__this.DrawHighlighted (c, indices);
			if (indices != null)
				JNIEnv.CopyArray (indices, native_indices);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/method[@name='drawHighlighted' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.github.mikephil.charting.highlight.Highlight[]']]"
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
				global::System.GC.KeepAlive (c);
				global::System.GC.KeepAlive (indices);
			}
		}

		static Delegate cb_drawHole_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDrawHole_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_drawHole_Landroid_graphics_Canvas_ == null)
				cb_drawHole_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DrawHole_Landroid_graphics_Canvas_);
			return cb_drawHole_Landroid_graphics_Canvas_;
		}

		static void n_DrawHole_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.PieChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.DrawHole (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/method[@name='drawHole' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawHole", "(Landroid/graphics/Canvas;)V", "GetDrawHole_Landroid_graphics_Canvas_Handler")]
		protected virtual unsafe void DrawHole (global::Android.Graphics.Canvas c)
		{
			const string __id = "drawHole.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
			}
		}

		static Delegate cb_drawRoundedSlices_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDrawRoundedSlices_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_drawRoundedSlices_Landroid_graphics_Canvas_ == null)
				cb_drawRoundedSlices_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DrawRoundedSlices_Landroid_graphics_Canvas_);
			return cb_drawRoundedSlices_Landroid_graphics_Canvas_;
		}

		static void n_DrawRoundedSlices_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.PieChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.DrawRoundedSlices (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/method[@name='drawRoundedSlices' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawRoundedSlices", "(Landroid/graphics/Canvas;)V", "GetDrawRoundedSlices_Landroid_graphics_Canvas_Handler")]
		protected virtual unsafe void DrawRoundedSlices (global::Android.Graphics.Canvas c)
		{
			const string __id = "drawRoundedSlices.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
			}
		}

		static Delegate cb_drawValues_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDrawValues_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_drawValues_Landroid_graphics_Canvas_ == null)
				cb_drawValues_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DrawValues_Landroid_graphics_Canvas_);
			return cb_drawValues_Landroid_graphics_Canvas_;
		}

		static void n_DrawValues_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.PieChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.DrawValues (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/method[@name='drawValues' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawValues", "(Landroid/graphics/Canvas;)V", "GetDrawValues_Landroid_graphics_Canvas_Handler")]
		public override unsafe void DrawValues (global::Android.Graphics.Canvas c)
		{
			const string __id = "drawValues.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
			}
		}

		static Delegate cb_getSliceSpace_Lcom_github_mikephil_charting_interfaces_datasets_IPieDataSet_;
#pragma warning disable 0169
		static Delegate GetGetSliceSpace_Lcom_github_mikephil_charting_interfaces_datasets_IPieDataSet_Handler ()
		{
			if (cb_getSliceSpace_Lcom_github_mikephil_charting_interfaces_datasets_IPieDataSet_ == null)
				cb_getSliceSpace_Lcom_github_mikephil_charting_interfaces_datasets_IPieDataSet_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_F) n_GetSliceSpace_Lcom_github_mikephil_charting_interfaces_datasets_IPieDataSet_);
			return cb_getSliceSpace_Lcom_github_mikephil_charting_interfaces_datasets_IPieDataSet_;
		}

		static float n_GetSliceSpace_Lcom_github_mikephil_charting_interfaces_datasets_IPieDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dataSet)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.PieChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dataSet = (global::MikePhil.Charting.Interfaces.Datasets.IPieDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IPieDataSet> (native_dataSet, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetSliceSpace (dataSet);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/method[@name='getSliceSpace' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.interfaces.datasets.IPieDataSet']]"
		[Register ("getSliceSpace", "(Lcom/github/mikephil/charting/interfaces/datasets/IPieDataSet;)F", "GetGetSliceSpace_Lcom_github_mikephil_charting_interfaces_datasets_IPieDataSet_Handler")]
		protected virtual unsafe float GetSliceSpace (global::MikePhil.Charting.Interfaces.Datasets.IPieDataSet dataSet)
		{
			const string __id = "getSliceSpace.(Lcom/github/mikephil/charting/interfaces/datasets/IPieDataSet;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSet).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (dataSet);
			}
		}

		static Delegate cb_initBuffers;
#pragma warning disable 0169
		static Delegate GetInitBuffersHandler ()
		{
			if (cb_initBuffers == null)
				cb_initBuffers = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_InitBuffers);
			return cb_initBuffers;
		}

		static void n_InitBuffers (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.PieChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitBuffers ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/method[@name='initBuffers' and count(parameter)=0]"
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
				cb_releaseBitmap = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ReleaseBitmap);
			return cb_releaseBitmap;
		}

		static void n_ReleaseBitmap (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.PieChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReleaseBitmap ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='PieChartRenderer']/method[@name='releaseBitmap' and count(parameter)=0]"
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
