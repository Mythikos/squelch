using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineRadarRenderer']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/renderer/LineRadarRenderer", DoNotGenerateAcw=true)]
	public abstract partial class LineRadarRenderer : global::MikePhil.Charting.Renderer.LineScatterCandleRadarRenderer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/renderer/LineRadarRenderer", typeof (LineRadarRenderer));
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

		protected LineRadarRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineRadarRenderer']/constructor[@name='LineRadarRenderer' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.animation.ChartAnimator'] and parameter[2][@type='com.github.mikephil.charting.utils.ViewPortHandler']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/animation/ChartAnimator;Lcom/github/mikephil/charting/utils/ViewPortHandler;)V", "")]
		public unsafe LineRadarRenderer (global::MikePhil.Charting.Animation.ChartAnimator animator, global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler)
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

		static Delegate cb_drawFilledPath_Landroid_graphics_Canvas_Landroid_graphics_Path_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetDrawFilledPath_Landroid_graphics_Canvas_Landroid_graphics_Path_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_drawFilledPath_Landroid_graphics_Canvas_Landroid_graphics_Path_Landroid_graphics_drawable_Drawable_ == null)
				cb_drawFilledPath_Landroid_graphics_Canvas_Landroid_graphics_Path_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_DrawFilledPath_Landroid_graphics_Canvas_Landroid_graphics_Path_Landroid_graphics_drawable_Drawable_);
			return cb_drawFilledPath_Landroid_graphics_Canvas_Landroid_graphics_Path_Landroid_graphics_drawable_Drawable_;
		}

		static void n_DrawFilledPath_Landroid_graphics_Canvas_Landroid_graphics_Path_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_filledPath, IntPtr native_drawable)
		{
			global::MikePhil.Charting.Renderer.LineRadarRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LineRadarRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Path filledPath = global::Java.Lang.Object.GetObject<global::Android.Graphics.Path> (native_filledPath, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			__this.DrawFilledPath (c, filledPath, drawable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineRadarRenderer']/method[@name='drawFilledPath' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='android.graphics.Path'] and parameter[3][@type='android.graphics.drawable.Drawable']]"
		[Register ("drawFilledPath", "(Landroid/graphics/Canvas;Landroid/graphics/Path;Landroid/graphics/drawable/Drawable;)V", "GetDrawFilledPath_Landroid_graphics_Canvas_Landroid_graphics_Path_Landroid_graphics_drawable_Drawable_Handler")]
		protected virtual unsafe void DrawFilledPath (global::Android.Graphics.Canvas c, global::Android.Graphics.Path filledPath, global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "drawFilledPath.(Landroid/graphics/Canvas;Landroid/graphics/Path;Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue ((filledPath == null) ? IntPtr.Zero : ((global::Java.Lang.Object) filledPath).Handle);
				__args [2] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawFilledPath_Landroid_graphics_Canvas_Landroid_graphics_Path_II;
#pragma warning disable 0169
		static Delegate GetDrawFilledPath_Landroid_graphics_Canvas_Landroid_graphics_Path_IIHandler ()
		{
			if (cb_drawFilledPath_Landroid_graphics_Canvas_Landroid_graphics_Path_II == null)
				cb_drawFilledPath_Landroid_graphics_Canvas_Landroid_graphics_Path_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, int>) n_DrawFilledPath_Landroid_graphics_Canvas_Landroid_graphics_Path_II);
			return cb_drawFilledPath_Landroid_graphics_Canvas_Landroid_graphics_Path_II;
		}

		static void n_DrawFilledPath_Landroid_graphics_Canvas_Landroid_graphics_Path_II (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_filledPath, int fillColor, int fillAlpha)
		{
			global::MikePhil.Charting.Renderer.LineRadarRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LineRadarRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Path filledPath = global::Java.Lang.Object.GetObject<global::Android.Graphics.Path> (native_filledPath, JniHandleOwnership.DoNotTransfer);
			__this.DrawFilledPath (c, filledPath, fillColor, fillAlpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LineRadarRenderer']/method[@name='drawFilledPath' and count(parameter)=4 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='android.graphics.Path'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("drawFilledPath", "(Landroid/graphics/Canvas;Landroid/graphics/Path;II)V", "GetDrawFilledPath_Landroid_graphics_Canvas_Landroid_graphics_Path_IIHandler")]
		protected virtual unsafe void DrawFilledPath (global::Android.Graphics.Canvas c, global::Android.Graphics.Path filledPath, int fillColor, int fillAlpha)
		{
			const string __id = "drawFilledPath.(Landroid/graphics/Canvas;Landroid/graphics/Path;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue ((filledPath == null) ? IntPtr.Zero : ((global::Java.Lang.Object) filledPath).Handle);
				__args [2] = new JniArgumentValue (fillColor);
				__args [3] = new JniArgumentValue (fillAlpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/renderer/LineRadarRenderer", DoNotGenerateAcw=true)]
	internal partial class LineRadarRendererInvoker : LineRadarRenderer {

		public LineRadarRendererInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/renderer/LineRadarRenderer", typeof (LineRadarRendererInvoker));

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
