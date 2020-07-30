using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='AxisRenderer']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/renderer/AxisRenderer", DoNotGenerateAcw=true)]
	public abstract partial class AxisRenderer : global::MikePhil.Charting.Renderer.Renderer {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='AxisRenderer']/field[@name='mAxis']"
		[Register ("mAxis")]
		protected global::MikePhil.Charting.Components.AxisBase MAxis {
			get {
				const string __id = "mAxis.Lcom/github/mikephil/charting/components/AxisBase;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAxis.Lcom/github/mikephil/charting/components/AxisBase;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='AxisRenderer']/field[@name='mAxisLabelPaint']"
		[Register ("mAxisLabelPaint")]
		protected global::Android.Graphics.Paint MAxisLabelPaint {
			get {
				const string __id = "mAxisLabelPaint.Landroid/graphics/Paint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAxisLabelPaint.Landroid/graphics/Paint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='AxisRenderer']/field[@name='mAxisLinePaint']"
		[Register ("mAxisLinePaint")]
		protected global::Android.Graphics.Paint MAxisLinePaint {
			get {
				const string __id = "mAxisLinePaint.Landroid/graphics/Paint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAxisLinePaint.Landroid/graphics/Paint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='AxisRenderer']/field[@name='mGridPaint']"
		[Register ("mGridPaint")]
		protected global::Android.Graphics.Paint MGridPaint {
			get {
				const string __id = "mGridPaint.Landroid/graphics/Paint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mGridPaint.Landroid/graphics/Paint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='AxisRenderer']/field[@name='mLimitLinePaint']"
		[Register ("mLimitLinePaint")]
		protected global::Android.Graphics.Paint MLimitLinePaint {
			get {
				const string __id = "mLimitLinePaint.Landroid/graphics/Paint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mLimitLinePaint.Landroid/graphics/Paint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='AxisRenderer']/field[@name='mTrans']"
		[Register ("mTrans")]
		protected global::MikePhil.Charting.Util.Transformer MTrans {
			get {
				const string __id = "mTrans.Lcom/github/mikephil/charting/utils/Transformer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mTrans.Lcom/github/mikephil/charting/utils/Transformer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/renderer/AxisRenderer", typeof (AxisRenderer));
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

		protected AxisRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='AxisRenderer']/constructor[@name='AxisRenderer' and count(parameter)=3 and parameter[1][@type='com.github.mikephil.charting.utils.ViewPortHandler'] and parameter[2][@type='com.github.mikephil.charting.utils.Transformer'] and parameter[3][@type='com.github.mikephil.charting.components.AxisBase']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/utils/ViewPortHandler;Lcom/github/mikephil/charting/utils/Transformer;Lcom/github/mikephil/charting/components/AxisBase;)V", "")]
		public unsafe AxisRenderer (global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler, global::MikePhil.Charting.Util.Transformer trans, global::MikePhil.Charting.Components.AxisBase axis)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/utils/ViewPortHandler;Lcom/github/mikephil/charting/utils/Transformer;Lcom/github/mikephil/charting/components/AxisBase;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((viewPortHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPortHandler).Handle);
				__args [1] = new JniArgumentValue ((trans == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trans).Handle);
				__args [2] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getPaintAxisLabels;
#pragma warning disable 0169
		static Delegate GetGetPaintAxisLabelsHandler ()
		{
			if (cb_getPaintAxisLabels == null)
				cb_getPaintAxisLabels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPaintAxisLabels);
			return cb_getPaintAxisLabels;
		}

		static IntPtr n_GetPaintAxisLabels (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Renderer.AxisRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.AxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PaintAxisLabels);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Paint PaintAxisLabels {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='AxisRenderer']/method[@name='getPaintAxisLabels' and count(parameter)=0]"
			[Register ("getPaintAxisLabels", "()Landroid/graphics/Paint;", "GetGetPaintAxisLabelsHandler")]
			get {
				const string __id = "getPaintAxisLabels.()Landroid/graphics/Paint;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPaintAxisLine;
#pragma warning disable 0169
		static Delegate GetGetPaintAxisLineHandler ()
		{
			if (cb_getPaintAxisLine == null)
				cb_getPaintAxisLine = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPaintAxisLine);
			return cb_getPaintAxisLine;
		}

		static IntPtr n_GetPaintAxisLine (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Renderer.AxisRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.AxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PaintAxisLine);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Paint PaintAxisLine {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='AxisRenderer']/method[@name='getPaintAxisLine' and count(parameter)=0]"
			[Register ("getPaintAxisLine", "()Landroid/graphics/Paint;", "GetGetPaintAxisLineHandler")]
			get {
				const string __id = "getPaintAxisLine.()Landroid/graphics/Paint;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPaintGrid;
#pragma warning disable 0169
		static Delegate GetGetPaintGridHandler ()
		{
			if (cb_getPaintGrid == null)
				cb_getPaintGrid = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPaintGrid);
			return cb_getPaintGrid;
		}

		static IntPtr n_GetPaintGrid (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Renderer.AxisRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.AxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PaintGrid);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Paint PaintGrid {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='AxisRenderer']/method[@name='getPaintGrid' and count(parameter)=0]"
			[Register ("getPaintGrid", "()Landroid/graphics/Paint;", "GetGetPaintGridHandler")]
			get {
				const string __id = "getPaintGrid.()Landroid/graphics/Paint;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTransformer;
#pragma warning disable 0169
		static Delegate GetGetTransformerHandler ()
		{
			if (cb_getTransformer == null)
				cb_getTransformer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTransformer);
			return cb_getTransformer;
		}

		static IntPtr n_GetTransformer (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Renderer.AxisRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.AxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Transformer);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Util.Transformer Transformer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='AxisRenderer']/method[@name='getTransformer' and count(parameter)=0]"
			[Register ("getTransformer", "()Lcom/github/mikephil/charting/utils/Transformer;", "GetGetTransformerHandler")]
			get {
				const string __id = "getTransformer.()Lcom/github/mikephil/charting/utils/Transformer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_computeAxis_FFZ;
#pragma warning disable 0169
		static Delegate GetComputeAxis_FFZHandler ()
		{
			if (cb_computeAxis_FFZ == null)
				cb_computeAxis_FFZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, bool>) n_ComputeAxis_FFZ);
			return cb_computeAxis_FFZ;
		}

		static void n_ComputeAxis_FFZ (IntPtr jnienv, IntPtr native__this, float min, float max, bool inverted)
		{
			global::MikePhil.Charting.Renderer.AxisRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.AxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ComputeAxis (min, max, inverted);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='AxisRenderer']/method[@name='computeAxis' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='boolean']]"
		[Register ("computeAxis", "(FFZ)V", "GetComputeAxis_FFZHandler")]
		public virtual unsafe void ComputeAxis (float min, float max, bool inverted)
		{
			const string __id = "computeAxis.(FFZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (min);
				__args [1] = new JniArgumentValue (max);
				__args [2] = new JniArgumentValue (inverted);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_computeAxisValues_FF;
#pragma warning disable 0169
		static Delegate GetComputeAxisValues_FFHandler ()
		{
			if (cb_computeAxisValues_FF == null)
				cb_computeAxisValues_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_ComputeAxisValues_FF);
			return cb_computeAxisValues_FF;
		}

		static void n_ComputeAxisValues_FF (IntPtr jnienv, IntPtr native__this, float min, float max)
		{
			global::MikePhil.Charting.Renderer.AxisRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.AxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ComputeAxisValues (min, max);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='AxisRenderer']/method[@name='computeAxisValues' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("computeAxisValues", "(FF)V", "GetComputeAxisValues_FFHandler")]
		protected virtual unsafe void ComputeAxisValues (float min, float max)
		{
			const string __id = "computeAxisValues.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (min);
				__args [1] = new JniArgumentValue (max);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_renderAxisLabels_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetRenderAxisLabels_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_renderAxisLabels_Landroid_graphics_Canvas_ == null)
				cb_renderAxisLabels_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RenderAxisLabels_Landroid_graphics_Canvas_);
			return cb_renderAxisLabels_Landroid_graphics_Canvas_;
		}

		static void n_RenderAxisLabels_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Renderer.AxisRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.AxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RenderAxisLabels (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='AxisRenderer']/method[@name='renderAxisLabels' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("renderAxisLabels", "(Landroid/graphics/Canvas;)V", "GetRenderAxisLabels_Landroid_graphics_Canvas_Handler")]
		public abstract void RenderAxisLabels (global::Android.Graphics.Canvas p0);

		static Delegate cb_renderAxisLine_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetRenderAxisLine_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_renderAxisLine_Landroid_graphics_Canvas_ == null)
				cb_renderAxisLine_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RenderAxisLine_Landroid_graphics_Canvas_);
			return cb_renderAxisLine_Landroid_graphics_Canvas_;
		}

		static void n_RenderAxisLine_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Renderer.AxisRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.AxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RenderAxisLine (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='AxisRenderer']/method[@name='renderAxisLine' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("renderAxisLine", "(Landroid/graphics/Canvas;)V", "GetRenderAxisLine_Landroid_graphics_Canvas_Handler")]
		public abstract void RenderAxisLine (global::Android.Graphics.Canvas p0);

		static Delegate cb_renderGridLines_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetRenderGridLines_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_renderGridLines_Landroid_graphics_Canvas_ == null)
				cb_renderGridLines_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RenderGridLines_Landroid_graphics_Canvas_);
			return cb_renderGridLines_Landroid_graphics_Canvas_;
		}

		static void n_RenderGridLines_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Renderer.AxisRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.AxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RenderGridLines (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='AxisRenderer']/method[@name='renderGridLines' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("renderGridLines", "(Landroid/graphics/Canvas;)V", "GetRenderGridLines_Landroid_graphics_Canvas_Handler")]
		public abstract void RenderGridLines (global::Android.Graphics.Canvas p0);

		static Delegate cb_renderLimitLines_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetRenderLimitLines_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_renderLimitLines_Landroid_graphics_Canvas_ == null)
				cb_renderLimitLines_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RenderLimitLines_Landroid_graphics_Canvas_);
			return cb_renderLimitLines_Landroid_graphics_Canvas_;
		}

		static void n_RenderLimitLines_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Renderer.AxisRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.AxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RenderLimitLines (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='AxisRenderer']/method[@name='renderLimitLines' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("renderLimitLines", "(Landroid/graphics/Canvas;)V", "GetRenderLimitLines_Landroid_graphics_Canvas_Handler")]
		public abstract void RenderLimitLines (global::Android.Graphics.Canvas p0);

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/renderer/AxisRenderer", DoNotGenerateAcw=true)]
	internal partial class AxisRendererInvoker : AxisRenderer {

		public AxisRendererInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/renderer/AxisRenderer", typeof (AxisRendererInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='AxisRenderer']/method[@name='renderAxisLabels' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("renderAxisLabels", "(Landroid/graphics/Canvas;)V", "GetRenderAxisLabels_Landroid_graphics_Canvas_Handler")]
		public override unsafe void RenderAxisLabels (global::Android.Graphics.Canvas p0)
		{
			const string __id = "renderAxisLabels.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='AxisRenderer']/method[@name='renderAxisLine' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("renderAxisLine", "(Landroid/graphics/Canvas;)V", "GetRenderAxisLine_Landroid_graphics_Canvas_Handler")]
		public override unsafe void RenderAxisLine (global::Android.Graphics.Canvas p0)
		{
			const string __id = "renderAxisLine.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='AxisRenderer']/method[@name='renderGridLines' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("renderGridLines", "(Landroid/graphics/Canvas;)V", "GetRenderGridLines_Landroid_graphics_Canvas_Handler")]
		public override unsafe void RenderGridLines (global::Android.Graphics.Canvas p0)
		{
			const string __id = "renderGridLines.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='AxisRenderer']/method[@name='renderLimitLines' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("renderLimitLines", "(Landroid/graphics/Canvas;)V", "GetRenderLimitLines_Landroid_graphics_Canvas_Handler")]
		public override unsafe void RenderLimitLines (global::Android.Graphics.Canvas p0)
		{
			const string __id = "renderLimitLines.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

}
