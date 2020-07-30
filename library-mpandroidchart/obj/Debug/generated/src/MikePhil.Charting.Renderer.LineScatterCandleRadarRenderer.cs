using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineScatterCandleRadarRenderer']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/renderer/LineScatterCandleRadarRenderer", DoNotGenerateAcw=true)]
	public abstract partial class LineScatterCandleRadarRenderer : global::MikePhil.Charting.Renderer.BarLineScatterCandleBubbleRenderer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/renderer/LineScatterCandleRadarRenderer", typeof (LineScatterCandleRadarRenderer));
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

		protected LineScatterCandleRadarRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineScatterCandleRadarRenderer']/constructor[@name='LineScatterCandleRadarRenderer' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.animation.ChartAnimator'] and parameter[2][@type='com.github.mikephil.charting.utils.ViewPortHandler']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/animation/ChartAnimator;Lcom/github/mikephil/charting/utils/ViewPortHandler;)V", "")]
		public unsafe LineScatterCandleRadarRenderer (global::MikePhil.Charting.Animation.ChartAnimator animator, global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/animation/ChartAnimator;Lcom/github/mikephil/charting/utils/ViewPortHandler;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((animator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) animator).Handle);
				__args [1] = new JniArgumentValue ((viewPortHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPortHandler).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawHighlightLines_Landroid_graphics_Canvas_FFLcom_github_mikephil_charting_interfaces_datasets_ILineScatterCandleRadarDataSet_;
#pragma warning disable 0169
		static Delegate GetDrawHighlightLines_Landroid_graphics_Canvas_FFLcom_github_mikephil_charting_interfaces_datasets_ILineScatterCandleRadarDataSet_Handler ()
		{
			if (cb_drawHighlightLines_Landroid_graphics_Canvas_FFLcom_github_mikephil_charting_interfaces_datasets_ILineScatterCandleRadarDataSet_ == null)
				cb_drawHighlightLines_Landroid_graphics_Canvas_FFLcom_github_mikephil_charting_interfaces_datasets_ILineScatterCandleRadarDataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float, IntPtr>) n_DrawHighlightLines_Landroid_graphics_Canvas_FFLcom_github_mikephil_charting_interfaces_datasets_ILineScatterCandleRadarDataSet_);
			return cb_drawHighlightLines_Landroid_graphics_Canvas_FFLcom_github_mikephil_charting_interfaces_datasets_ILineScatterCandleRadarDataSet_;
		}

		static void n_DrawHighlightLines_Landroid_graphics_Canvas_FFLcom_github_mikephil_charting_interfaces_datasets_ILineScatterCandleRadarDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c, float x, float y, IntPtr native_set)
		{
			global::MikePhil.Charting.Renderer.LineScatterCandleRadarRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LineScatterCandleRadarRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Interfaces.Datasets.ILineScatterCandleRadarDataSet set = (global::MikePhil.Charting.Interfaces.Datasets.ILineScatterCandleRadarDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineScatterCandleRadarDataSet> (native_set, JniHandleOwnership.DoNotTransfer);
			__this.DrawHighlightLines (c, x, y, set);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineScatterCandleRadarRenderer']/method[@name='drawHighlightLines' and count(parameter)=4 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='com.github.mikephil.charting.interfaces.datasets.ILineScatterCandleRadarDataSet']]"
		[Register ("drawHighlightLines", "(Landroid/graphics/Canvas;FFLcom/github/mikephil/charting/interfaces/datasets/ILineScatterCandleRadarDataSet;)V", "GetDrawHighlightLines_Landroid_graphics_Canvas_FFLcom_github_mikephil_charting_interfaces_datasets_ILineScatterCandleRadarDataSet_Handler")]
		protected virtual unsafe void DrawHighlightLines (global::Android.Graphics.Canvas c, float x, float y, global::MikePhil.Charting.Interfaces.Datasets.ILineScatterCandleRadarDataSet set)
		{
			const string __id = "drawHighlightLines.(Landroid/graphics/Canvas;FFLcom/github/mikephil/charting/interfaces/datasets/ILineScatterCandleRadarDataSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue (x);
				__args [2] = new JniArgumentValue (y);
				__args [3] = new JniArgumentValue ((set == null) ? IntPtr.Zero : ((global::Java.Lang.Object) set).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/renderer/LineScatterCandleRadarRenderer", DoNotGenerateAcw=true)]
	internal partial class LineScatterCandleRadarRendererInvoker : LineScatterCandleRadarRenderer {

		public LineScatterCandleRadarRendererInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/renderer/LineScatterCandleRadarRenderer", typeof (LineScatterCandleRadarRendererInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/method[@name='drawData' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawData", "(Landroid/graphics/Canvas;)V", "GetDrawData_Landroid_graphics_Canvas_Handler")]
		public override unsafe void DrawData (global::Android.Graphics.Canvas p0)
		{
			const string __id = "drawData.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/method[@name='drawExtras' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawExtras", "(Landroid/graphics/Canvas;)V", "GetDrawExtras_Landroid_graphics_Canvas_Handler")]
		public override unsafe void DrawExtras (global::Android.Graphics.Canvas p0)
		{
			const string __id = "drawExtras.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/method[@name='drawHighlighted' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.github.mikephil.charting.highlight.Highlight[]']]"
		[Register ("drawHighlighted", "(Landroid/graphics/Canvas;[Lcom/github/mikephil/charting/highlight/Highlight;)V", "GetDrawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_Handler")]
		public override unsafe void DrawHighlighted (global::Android.Graphics.Canvas p0, global::MikePhil.Charting.Highlight.Highlight[] p1)
		{
			const string __id = "drawHighlighted.(Landroid/graphics/Canvas;[Lcom/github/mikephil/charting/highlight/Highlight;)V";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/method[@name='drawValues' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawValues", "(Landroid/graphics/Canvas;)V", "GetDrawValues_Landroid_graphics_Canvas_Handler")]
		public override unsafe void DrawValues (global::Android.Graphics.Canvas p0)
		{
			const string __id = "drawValues.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/method[@name='initBuffers' and count(parameter)=0]"
		[Register ("initBuffers", "()V", "GetInitBuffersHandler")]
		public override unsafe void InitBuffers ()
		{
			const string __id = "initBuffers.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

}
