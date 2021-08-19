using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BubbleChartRenderer']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/renderer/BubbleChartRenderer", DoNotGenerateAcw=true)]
	public partial class BubbleChartRenderer : global::MikePhil.Charting.Renderer.BarLineScatterCandleBubbleRenderer {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BubbleChartRenderer']/field[@name='mChart']"
		[Register ("mChart")]
		protected global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider MChart {
			get {
				const string __id = "mChart.Lcom/github/mikephil/charting/interfaces/dataprovider/BubbleDataProvider;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mChart.Lcom/github/mikephil/charting/interfaces/dataprovider/BubbleDataProvider;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/renderer/BubbleChartRenderer", typeof (BubbleChartRenderer));

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

		protected BubbleChartRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BubbleChartRenderer']/constructor[@name='BubbleChartRenderer' and count(parameter)=3 and parameter[1][@type='com.github.mikephil.charting.interfaces.dataprovider.BubbleDataProvider'] and parameter[2][@type='com.github.mikephil.charting.animation.ChartAnimator'] and parameter[3][@type='com.github.mikephil.charting.utils.ViewPortHandler']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/interfaces/dataprovider/BubbleDataProvider;Lcom/github/mikephil/charting/animation/ChartAnimator;Lcom/github/mikephil/charting/utils/ViewPortHandler;)V", "")]
		public unsafe BubbleChartRenderer (global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider chart, global::MikePhil.Charting.Animation.ChartAnimator animator, global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/interfaces/dataprovider/BubbleDataProvider;Lcom/github/mikephil/charting/animation/ChartAnimator;Lcom/github/mikephil/charting/utils/ViewPortHandler;)V";

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
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.BubbleChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.DrawData (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BubbleChartRenderer']/method[@name='drawData' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
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

		static Delegate cb_drawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IBubbleDataSet_;
#pragma warning disable 0169
		static Delegate GetDrawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IBubbleDataSet_Handler ()
		{
			if (cb_drawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IBubbleDataSet_ == null)
				cb_drawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IBubbleDataSet_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_DrawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IBubbleDataSet_);
			return cb_drawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IBubbleDataSet_;
		}

		static void n_DrawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IBubbleDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_dataSet)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.BubbleChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			var dataSet = (global::MikePhil.Charting.Interfaces.Datasets.IBubbleDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IBubbleDataSet> (native_dataSet, JniHandleOwnership.DoNotTransfer);
			__this.DrawDataSet (c, dataSet);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BubbleChartRenderer']/method[@name='drawDataSet' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.github.mikephil.charting.interfaces.datasets.IBubbleDataSet']]"
		[Register ("drawDataSet", "(Landroid/graphics/Canvas;Lcom/github/mikephil/charting/interfaces/datasets/IBubbleDataSet;)V", "GetDrawDataSet_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IBubbleDataSet_Handler")]
		protected virtual unsafe void DrawDataSet (global::Android.Graphics.Canvas c, global::MikePhil.Charting.Interfaces.Datasets.IBubbleDataSet dataSet)
		{
			const string __id = "drawDataSet.(Landroid/graphics/Canvas;Lcom/github/mikephil/charting/interfaces/datasets/IBubbleDataSet;)V";
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
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.BubbleChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.DrawExtras (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BubbleChartRenderer']/method[@name='drawExtras' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.BubbleChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			var indices = (global::MikePhil.Charting.Highlight.Highlight[]) JNIEnv.GetArray (native_indices, JniHandleOwnership.DoNotTransfer, typeof (global::MikePhil.Charting.Highlight.Highlight));
			__this.DrawHighlighted (c, indices);
			if (indices != null)
				JNIEnv.CopyArray (indices, native_indices);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BubbleChartRenderer']/method[@name='drawHighlighted' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.github.mikephil.charting.highlight.Highlight[]']]"
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
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.BubbleChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.DrawValues (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BubbleChartRenderer']/method[@name='drawValues' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
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

		static Delegate cb_getShapeSize_FFFZ;
#pragma warning disable 0169
		static Delegate GetGetShapeSize_FFFZHandler ()
		{
			if (cb_getShapeSize_FFFZ == null)
				cb_getShapeSize_FFFZ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFFFZ_F) n_GetShapeSize_FFFZ);
			return cb_getShapeSize_FFFZ;
		}

		static float n_GetShapeSize_FFFZ (IntPtr jnienv, IntPtr native__this, float entrySize, float maxSize, float reference, bool normalizeSize)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.BubbleChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetShapeSize (entrySize, maxSize, reference, normalizeSize);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BubbleChartRenderer']/method[@name='getShapeSize' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='boolean']]"
		[Register ("getShapeSize", "(FFFZ)F", "GetGetShapeSize_FFFZHandler")]
		protected virtual unsafe float GetShapeSize (float entrySize, float maxSize, float reference, bool normalizeSize)
		{
			const string __id = "getShapeSize.(FFFZ)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (entrySize);
				__args [1] = new JniArgumentValue (maxSize);
				__args [2] = new JniArgumentValue (reference);
				__args [3] = new JniArgumentValue (normalizeSize);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.BubbleChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitBuffers ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BubbleChartRenderer']/method[@name='initBuffers' and count(parameter)=0]"
		[Register ("initBuffers", "()V", "GetInitBuffersHandler")]
		public override unsafe void InitBuffers ()
		{
			const string __id = "initBuffers.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
