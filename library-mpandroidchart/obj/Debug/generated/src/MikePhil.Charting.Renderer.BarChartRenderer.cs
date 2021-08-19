using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarChartRenderer']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/renderer/BarChartRenderer", DoNotGenerateAcw=true)]
	public partial class BarChartRenderer : global::MikePhil.Charting.Renderer.BarLineScatterCandleBubbleRenderer {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarChartRenderer']/field[@name='mBarBorderPaint']"
		[Register ("mBarBorderPaint")]
		protected global::Android.Graphics.Paint MBarBorderPaint {
			get {
				const string __id = "mBarBorderPaint.Landroid/graphics/Paint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mBarBorderPaint.Landroid/graphics/Paint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarChartRenderer']/field[@name='mBarBuffers']"
		[Register ("mBarBuffers")]
		protected IList<MikePhil.Charting.Buffer.BarBuffer> MBarBuffers {
			get {
				const string __id = "mBarBuffers.[Lcom/github/mikephil/charting/buffer/BarBuffer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<global::MikePhil.Charting.Buffer.BarBuffer>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mBarBuffers.[Lcom/github/mikephil/charting/buffer/BarBuffer;";

				IntPtr native_value = global::Android.Runtime.JavaArray<global::MikePhil.Charting.Buffer.BarBuffer>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarChartRenderer']/field[@name='mBarRect']"
		[Register ("mBarRect")]
		protected global::Android.Graphics.RectF MBarRect {
			get {
				const string __id = "mBarRect.Landroid/graphics/RectF;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mBarRect.Landroid/graphics/RectF;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarChartRenderer']/field[@name='mChart']"
		[Register ("mChart")]
		protected global::MikePhil.Charting.Interfaces.Dataprovider.IBarDataProvider MChart {
			get {
				const string __id = "mChart.Lcom/github/mikephil/charting/interfaces/dataprovider/BarDataProvider;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.IBarDataProvider> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mChart.Lcom/github/mikephil/charting/interfaces/dataprovider/BarDataProvider;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarChartRenderer']/field[@name='mShadowPaint']"
		[Register ("mShadowPaint")]
		protected global::Android.Graphics.Paint MShadowPaint {
			get {
				const string __id = "mShadowPaint.Landroid/graphics/Paint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mShadowPaint.Landroid/graphics/Paint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/renderer/BarChartRenderer", typeof (BarChartRenderer));

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

		protected BarChartRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarChartRenderer']/constructor[@name='BarChartRenderer' and count(parameter)=3 and parameter[1][@type='com.github.mikephil.charting.interfaces.dataprovider.BarDataProvider'] and parameter[2][@type='com.github.mikephil.charting.animation.ChartAnimator'] and parameter[3][@type='com.github.mikephil.charting.utils.ViewPortHandler']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/interfaces/dataprovider/BarDataProvider;Lcom/github/mikephil/charting/animation/ChartAnimator;Lcom/github/mikephil/charting/utils/ViewPortHandler;)V", "")]
		public unsafe BarChartRenderer (global::MikePhil.Charting.Interfaces.Dataprovider.IBarDataProvider chart, global::MikePhil.Charting.Animation.ChartAnimator animator, global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/interfaces/dataprovider/BarDataProvider;Lcom/github/mikephil/charting/animation/ChartAnimator;Lcom/github/mikephil/charting/utils/ViewPortHandler;)V";

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
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.BarChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.DrawData (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarChartRenderer']/method[@name='drawData' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
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

		static Delegate cb_drawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IBarDataSet_I;
#pragma warning disable 0169
		static Delegate GetDrawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IBarDataSet_IHandler ()
		{
			if (cb_drawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IBarDataSet_I == null)
				cb_drawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IBarDataSet_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLI_V) n_DrawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IBarDataSet_I);
			return cb_drawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IBarDataSet_I;
		}

		static void n_DrawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IBarDataSet_I (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_dataSet, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.BarChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			var dataSet = (global::MikePhil.Charting.Interfaces.Datasets.IBarDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IBarDataSet> (native_dataSet, JniHandleOwnership.DoNotTransfer);
			__this.DrawDataSet (c, dataSet, index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarChartRenderer']/method[@name='drawDataSet' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.github.mikephil.charting.interfaces.datasets.IBarDataSet'] and parameter[3][@type='int']]"
		[Register ("drawDataSet", "(Landroid/graphics/Canvas;Lcom/github/mikephil/charting/interfaces/datasets/IBarDataSet;I)V", "GetDrawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IBarDataSet_IHandler")]
		protected virtual unsafe void DrawDataSet (global::Android.Graphics.Canvas c, global::MikePhil.Charting.Interfaces.Datasets.IBarDataSet dataSet, int index)
		{
			const string __id = "drawDataSet.(Landroid/graphics/Canvas;Lcom/github/mikephil/charting/interfaces/datasets/IBarDataSet;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue ((dataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSet).Handle);
				__args [2] = new JniArgumentValue (index);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
				global::System.GC.KeepAlive (dataSet);
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
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.BarChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.DrawExtras (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarChartRenderer']/method[@name='drawExtras' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.BarChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			var indices = (global::MikePhil.Charting.Highlight.Highlight[]) JNIEnv.GetArray (native_indices, JniHandleOwnership.DoNotTransfer, typeof (global::MikePhil.Charting.Highlight.Highlight));
			__this.DrawHighlighted (c, indices);
			if (indices != null)
				JNIEnv.CopyArray (indices, native_indices);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarChartRenderer']/method[@name='drawHighlighted' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.github.mikephil.charting.highlight.Highlight[]']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.BarChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.DrawValues (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarChartRenderer']/method[@name='drawValues' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.BarChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitBuffers ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarChartRenderer']/method[@name='initBuffers' and count(parameter)=0]"
		[Register ("initBuffers", "()V", "GetInitBuffersHandler")]
		public override unsafe void InitBuffers ()
		{
			const string __id = "initBuffers.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_prepareBarHighlight_FFFFLcom_github_mikephil_charting_utils_Transformer_;
#pragma warning disable 0169
		static Delegate GetPrepareBarHighlight_FFFFLcom_github_mikephil_charting_utils_Transformer_Handler ()
		{
			if (cb_prepareBarHighlight_FFFFLcom_github_mikephil_charting_utils_Transformer_ == null)
				cb_prepareBarHighlight_FFFFLcom_github_mikephil_charting_utils_Transformer_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFFFFL_V) n_PrepareBarHighlight_FFFFLcom_github_mikephil_charting_utils_Transformer_);
			return cb_prepareBarHighlight_FFFFLcom_github_mikephil_charting_utils_Transformer_;
		}

		static void n_PrepareBarHighlight_FFFFLcom_github_mikephil_charting_utils_Transformer_ (IntPtr jnienv, IntPtr native__this, float x, float y1, float y2, float barWidthHalf, IntPtr native_trans)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.BarChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var trans = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (native_trans, JniHandleOwnership.DoNotTransfer);
			__this.PrepareBarHighlight (x, y1, y2, barWidthHalf, trans);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarChartRenderer']/method[@name='prepareBarHighlight' and count(parameter)=5 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='com.github.mikephil.charting.utils.Transformer']]"
		[Register ("prepareBarHighlight", "(FFFFLcom/github/mikephil/charting/utils/Transformer;)V", "GetPrepareBarHighlight_FFFFLcom_github_mikephil_charting_utils_Transformer_Handler")]
		protected virtual unsafe void PrepareBarHighlight (float x, float y1, float y2, float barWidthHalf, global::MikePhil.Charting.Util.Transformer trans)
		{
			const string __id = "prepareBarHighlight.(FFFFLcom/github/mikephil/charting/utils/Transformer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y1);
				__args [2] = new JniArgumentValue (y2);
				__args [3] = new JniArgumentValue (barWidthHalf);
				__args [4] = new JniArgumentValue ((trans == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trans).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (trans);
			}
		}

		static Delegate cb_setHighlightDrawPos_Lcom_github_mikephil_charting_highlight_Highlight_Landroid_graphics_RectF_;
#pragma warning disable 0169
		static Delegate GetSetHighlightDrawPos_Lcom_github_mikephil_charting_highlight_Highlight_Landroid_graphics_RectF_Handler ()
		{
			if (cb_setHighlightDrawPos_Lcom_github_mikephil_charting_highlight_Highlight_Landroid_graphics_RectF_ == null)
				cb_setHighlightDrawPos_Lcom_github_mikephil_charting_highlight_Highlight_Landroid_graphics_RectF_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_SetHighlightDrawPos_Lcom_github_mikephil_charting_highlight_Highlight_Landroid_graphics_RectF_);
			return cb_setHighlightDrawPos_Lcom_github_mikephil_charting_highlight_Highlight_Landroid_graphics_RectF_;
		}

		static void n_SetHighlightDrawPos_Lcom_github_mikephil_charting_highlight_Highlight_Landroid_graphics_RectF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_high, IntPtr native_bar)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.BarChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var high = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (native_high, JniHandleOwnership.DoNotTransfer);
			var bar = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_bar, JniHandleOwnership.DoNotTransfer);
			__this.SetHighlightDrawPos (high, bar);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarChartRenderer']/method[@name='setHighlightDrawPos' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.highlight.Highlight'] and parameter[2][@type='android.graphics.RectF']]"
		[Register ("setHighlightDrawPos", "(Lcom/github/mikephil/charting/highlight/Highlight;Landroid/graphics/RectF;)V", "GetSetHighlightDrawPos_Lcom_github_mikephil_charting_highlight_Highlight_Landroid_graphics_RectF_Handler")]
		protected virtual unsafe void SetHighlightDrawPos (global::MikePhil.Charting.Highlight.Highlight high, global::Android.Graphics.RectF bar)
		{
			const string __id = "setHighlightDrawPos.(Lcom/github/mikephil/charting/highlight/Highlight;Landroid/graphics/RectF;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((high == null) ? IntPtr.Zero : ((global::Java.Lang.Object) high).Handle);
				__args [1] = new JniArgumentValue ((bar == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bar).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (high);
				global::System.GC.KeepAlive (bar);
			}
		}

	}
}
