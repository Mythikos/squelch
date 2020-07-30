using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='XAxisRenderer']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/renderer/XAxisRenderer", DoNotGenerateAcw=true)]
	public partial class XAxisRenderer : global::MikePhil.Charting.Renderer.AxisRenderer {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='XAxisRenderer']/field[@name='mGridClippingRect']"
		[Register ("mGridClippingRect")]
		protected global::Android.Graphics.RectF MGridClippingRect {
			get {
				const string __id = "mGridClippingRect.Landroid/graphics/RectF;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mGridClippingRect.Landroid/graphics/RectF;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='XAxisRenderer']/field[@name='mLimitLineClippingRect']"
		[Register ("mLimitLineClippingRect")]
		protected global::Android.Graphics.RectF MLimitLineClippingRect {
			get {
				const string __id = "mLimitLineClippingRect.Landroid/graphics/RectF;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mLimitLineClippingRect.Landroid/graphics/RectF;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='XAxisRenderer']/field[@name='mRenderGridLinesBuffer']"
		[Register ("mRenderGridLinesBuffer")]
		protected IList<float> MRenderGridLinesBuffer {
			get {
				const string __id = "mRenderGridLinesBuffer.[F";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<float>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mRenderGridLinesBuffer.[F";

				IntPtr native_value = global::Android.Runtime.JavaArray<float>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='XAxisRenderer']/field[@name='mRenderGridLinesPath']"
		[Register ("mRenderGridLinesPath")]
		protected global::Android.Graphics.Path MRenderGridLinesPath {
			get {
				const string __id = "mRenderGridLinesPath.Landroid/graphics/Path;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Path> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mRenderGridLinesPath.Landroid/graphics/Path;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='XAxisRenderer']/field[@name='mRenderLimitLinesBuffer']"
		[Register ("mRenderLimitLinesBuffer")]
		protected IList<float> MRenderLimitLinesBuffer {
			get {
				const string __id = "mRenderLimitLinesBuffer.[F";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<float>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mRenderLimitLinesBuffer.[F";

				IntPtr native_value = global::Android.Runtime.JavaArray<float>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='XAxisRenderer']/field[@name='mXAxis']"
		[Register ("mXAxis")]
		protected global::MikePhil.Charting.Components.XAxis MXAxis {
			get {
				const string __id = "mXAxis.Lcom/github/mikephil/charting/components/XAxis;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.XAxis> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mXAxis.Lcom/github/mikephil/charting/components/XAxis;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/renderer/XAxisRenderer", typeof (XAxisRenderer));
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

		protected XAxisRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='XAxisRenderer']/constructor[@name='XAxisRenderer' and count(parameter)=3 and parameter[1][@type='com.github.mikephil.charting.utils.ViewPortHandler'] and parameter[2][@type='com.github.mikephil.charting.components.XAxis'] and parameter[3][@type='com.github.mikephil.charting.utils.Transformer']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/utils/ViewPortHandler;Lcom/github/mikephil/charting/components/XAxis;Lcom/github/mikephil/charting/utils/Transformer;)V", "")]
		public unsafe XAxisRenderer (global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler, global::MikePhil.Charting.Components.XAxis xAxis, global::MikePhil.Charting.Util.Transformer trans)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/utils/ViewPortHandler;Lcom/github/mikephil/charting/components/XAxis;Lcom/github/mikephil/charting/utils/Transformer;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((viewPortHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPortHandler).Handle);
				__args [1] = new JniArgumentValue ((xAxis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) xAxis).Handle);
				__args [2] = new JniArgumentValue ((trans == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trans).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getGridClippingRect;
#pragma warning disable 0169
		static Delegate GetGetGridClippingRectHandler ()
		{
			if (cb_getGridClippingRect == null)
				cb_getGridClippingRect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGridClippingRect);
			return cb_getGridClippingRect;
		}

		static IntPtr n_GetGridClippingRect (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Renderer.XAxisRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.XAxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GridClippingRect);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.RectF GridClippingRect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='XAxisRenderer']/method[@name='getGridClippingRect' and count(parameter)=0]"
			[Register ("getGridClippingRect", "()Landroid/graphics/RectF;", "GetGetGridClippingRectHandler")]
			get {
				const string __id = "getGridClippingRect.()Landroid/graphics/RectF;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_computeSize;
#pragma warning disable 0169
		static Delegate GetComputeSizeHandler ()
		{
			if (cb_computeSize == null)
				cb_computeSize = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ComputeSize);
			return cb_computeSize;
		}

		static void n_ComputeSize (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Renderer.XAxisRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.XAxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ComputeSize ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='XAxisRenderer']/method[@name='computeSize' and count(parameter)=0]"
		[Register ("computeSize", "()V", "GetComputeSizeHandler")]
		protected virtual unsafe void ComputeSize ()
		{
			const string __id = "computeSize.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_drawGridLine_Landroid_graphics_Canvas_FFLandroid_graphics_Path_;
#pragma warning disable 0169
		static Delegate GetDrawGridLine_Landroid_graphics_Canvas_FFLandroid_graphics_Path_Handler ()
		{
			if (cb_drawGridLine_Landroid_graphics_Canvas_FFLandroid_graphics_Path_ == null)
				cb_drawGridLine_Landroid_graphics_Canvas_FFLandroid_graphics_Path_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float, IntPtr>) n_DrawGridLine_Landroid_graphics_Canvas_FFLandroid_graphics_Path_);
			return cb_drawGridLine_Landroid_graphics_Canvas_FFLandroid_graphics_Path_;
		}

		static void n_DrawGridLine_Landroid_graphics_Canvas_FFLandroid_graphics_Path_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c, float x, float y, IntPtr native_gridLinePath)
		{
			global::MikePhil.Charting.Renderer.XAxisRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.XAxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Path gridLinePath = global::Java.Lang.Object.GetObject<global::Android.Graphics.Path> (native_gridLinePath, JniHandleOwnership.DoNotTransfer);
			__this.DrawGridLine (c, x, y, gridLinePath);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='XAxisRenderer']/method[@name='drawGridLine' and count(parameter)=4 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='android.graphics.Path']]"
		[Register ("drawGridLine", "(Landroid/graphics/Canvas;FFLandroid/graphics/Path;)V", "GetDrawGridLine_Landroid_graphics_Canvas_FFLandroid_graphics_Path_Handler")]
		protected virtual unsafe void DrawGridLine (global::Android.Graphics.Canvas c, float x, float y, global::Android.Graphics.Path gridLinePath)
		{
			const string __id = "drawGridLine.(Landroid/graphics/Canvas;FFLandroid/graphics/Path;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue (x);
				__args [2] = new JniArgumentValue (y);
				__args [3] = new JniArgumentValue ((gridLinePath == null) ? IntPtr.Zero : ((global::Java.Lang.Object) gridLinePath).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawLabel_Landroid_graphics_Canvas_Ljava_lang_String_FFLcom_github_mikephil_charting_utils_MPPointF_F;
#pragma warning disable 0169
		static Delegate GetDrawLabel_Landroid_graphics_Canvas_Ljava_lang_String_FFLcom_github_mikephil_charting_utils_MPPointF_FHandler ()
		{
			if (cb_drawLabel_Landroid_graphics_Canvas_Ljava_lang_String_FFLcom_github_mikephil_charting_utils_MPPointF_F == null)
				cb_drawLabel_Landroid_graphics_Canvas_Ljava_lang_String_FFLcom_github_mikephil_charting_utils_MPPointF_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, float, float, IntPtr, float>) n_DrawLabel_Landroid_graphics_Canvas_Ljava_lang_String_FFLcom_github_mikephil_charting_utils_MPPointF_F);
			return cb_drawLabel_Landroid_graphics_Canvas_Ljava_lang_String_FFLcom_github_mikephil_charting_utils_MPPointF_F;
		}

		static void n_DrawLabel_Landroid_graphics_Canvas_Ljava_lang_String_FFLcom_github_mikephil_charting_utils_MPPointF_F (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_formattedLabel, float x, float y, IntPtr native_anchor, float angleDegrees)
		{
			global::MikePhil.Charting.Renderer.XAxisRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.XAxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			string formattedLabel = JNIEnv.GetString (native_formattedLabel, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Util.MPPointF anchor = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (native_anchor, JniHandleOwnership.DoNotTransfer);
			__this.DrawLabel (c, formattedLabel, x, y, anchor, angleDegrees);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='XAxisRenderer']/method[@name='drawLabel' and count(parameter)=6 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='com.github.mikephil.charting.utils.MPPointF'] and parameter[6][@type='float']]"
		[Register ("drawLabel", "(Landroid/graphics/Canvas;Ljava/lang/String;FFLcom/github/mikephil/charting/utils/MPPointF;F)V", "GetDrawLabel_Landroid_graphics_Canvas_Ljava_lang_String_FFLcom_github_mikephil_charting_utils_MPPointF_FHandler")]
		protected virtual unsafe void DrawLabel (global::Android.Graphics.Canvas c, string formattedLabel, float x, float y, global::MikePhil.Charting.Util.MPPointF anchor, float angleDegrees)
		{
			const string __id = "drawLabel.(Landroid/graphics/Canvas;Ljava/lang/String;FFLcom/github/mikephil/charting/utils/MPPointF;F)V";
			IntPtr native_formattedLabel = JNIEnv.NewString (formattedLabel);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue (native_formattedLabel);
				__args [2] = new JniArgumentValue (x);
				__args [3] = new JniArgumentValue (y);
				__args [4] = new JniArgumentValue ((anchor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) anchor).Handle);
				__args [5] = new JniArgumentValue (angleDegrees);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_formattedLabel);
			}
		}

		static Delegate cb_drawLabels_Landroid_graphics_Canvas_FLcom_github_mikephil_charting_utils_MPPointF_;
#pragma warning disable 0169
		static Delegate GetDrawLabels_Landroid_graphics_Canvas_FLcom_github_mikephil_charting_utils_MPPointF_Handler ()
		{
			if (cb_drawLabels_Landroid_graphics_Canvas_FLcom_github_mikephil_charting_utils_MPPointF_ == null)
				cb_drawLabels_Landroid_graphics_Canvas_FLcom_github_mikephil_charting_utils_MPPointF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, IntPtr>) n_DrawLabels_Landroid_graphics_Canvas_FLcom_github_mikephil_charting_utils_MPPointF_);
			return cb_drawLabels_Landroid_graphics_Canvas_FLcom_github_mikephil_charting_utils_MPPointF_;
		}

		static void n_DrawLabels_Landroid_graphics_Canvas_FLcom_github_mikephil_charting_utils_MPPointF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c, float pos, IntPtr native_anchor)
		{
			global::MikePhil.Charting.Renderer.XAxisRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.XAxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Util.MPPointF anchor = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (native_anchor, JniHandleOwnership.DoNotTransfer);
			__this.DrawLabels (c, pos, anchor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='XAxisRenderer']/method[@name='drawLabels' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='float'] and parameter[3][@type='com.github.mikephil.charting.utils.MPPointF']]"
		[Register ("drawLabels", "(Landroid/graphics/Canvas;FLcom/github/mikephil/charting/utils/MPPointF;)V", "GetDrawLabels_Landroid_graphics_Canvas_FLcom_github_mikephil_charting_utils_MPPointF_Handler")]
		protected virtual unsafe void DrawLabels (global::Android.Graphics.Canvas c, float pos, global::MikePhil.Charting.Util.MPPointF anchor)
		{
			const string __id = "drawLabels.(Landroid/graphics/Canvas;FLcom/github/mikephil/charting/utils/MPPointF;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue (pos);
				__args [2] = new JniArgumentValue ((anchor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) anchor).Handle);
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

		static void n_RenderAxisLabels_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			global::MikePhil.Charting.Renderer.XAxisRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.XAxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.RenderAxisLabels (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='XAxisRenderer']/method[@name='renderAxisLabels' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("renderAxisLabels", "(Landroid/graphics/Canvas;)V", "GetRenderAxisLabels_Landroid_graphics_Canvas_Handler")]
		public override unsafe void RenderAxisLabels (global::Android.Graphics.Canvas c)
		{
			const string __id = "renderAxisLabels.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_renderAxisLine_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetRenderAxisLine_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_renderAxisLine_Landroid_graphics_Canvas_ == null)
				cb_renderAxisLine_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RenderAxisLine_Landroid_graphics_Canvas_);
			return cb_renderAxisLine_Landroid_graphics_Canvas_;
		}

		static void n_RenderAxisLine_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			global::MikePhil.Charting.Renderer.XAxisRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.XAxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.RenderAxisLine (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='XAxisRenderer']/method[@name='renderAxisLine' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("renderAxisLine", "(Landroid/graphics/Canvas;)V", "GetRenderAxisLine_Landroid_graphics_Canvas_Handler")]
		public override unsafe void RenderAxisLine (global::Android.Graphics.Canvas c)
		{
			const string __id = "renderAxisLine.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_renderGridLines_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetRenderGridLines_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_renderGridLines_Landroid_graphics_Canvas_ == null)
				cb_renderGridLines_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RenderGridLines_Landroid_graphics_Canvas_);
			return cb_renderGridLines_Landroid_graphics_Canvas_;
		}

		static void n_RenderGridLines_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			global::MikePhil.Charting.Renderer.XAxisRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.XAxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.RenderGridLines (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='XAxisRenderer']/method[@name='renderGridLines' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("renderGridLines", "(Landroid/graphics/Canvas;)V", "GetRenderGridLines_Landroid_graphics_Canvas_Handler")]
		public override unsafe void RenderGridLines (global::Android.Graphics.Canvas c)
		{
			const string __id = "renderGridLines.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_renderLimitLineLabel_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_components_LimitLine_arrayFF;
#pragma warning disable 0169
		static Delegate GetRenderLimitLineLabel_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_components_LimitLine_arrayFFHandler ()
		{
			if (cb_renderLimitLineLabel_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_components_LimitLine_arrayFF == null)
				cb_renderLimitLineLabel_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_components_LimitLine_arrayFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, float>) n_RenderLimitLineLabel_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_components_LimitLine_arrayFF);
			return cb_renderLimitLineLabel_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_components_LimitLine_arrayFF;
		}

		static void n_RenderLimitLineLabel_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_components_LimitLine_arrayFF (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_limitLine, IntPtr native_position, float yOffset)
		{
			global::MikePhil.Charting.Renderer.XAxisRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.XAxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.LimitLine limitLine = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine> (native_limitLine, JniHandleOwnership.DoNotTransfer);
			float[] position = (float[]) JNIEnv.GetArray (native_position, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.RenderLimitLineLabel (c, limitLine, position, yOffset);
			if (position != null)
				JNIEnv.CopyArray (position, native_position);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='XAxisRenderer']/method[@name='renderLimitLineLabel' and count(parameter)=4 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.github.mikephil.charting.components.LimitLine'] and parameter[3][@type='float[]'] and parameter[4][@type='float']]"
		[Register ("renderLimitLineLabel", "(Landroid/graphics/Canvas;Lcom/github/mikephil/charting/components/LimitLine;[FF)V", "GetRenderLimitLineLabel_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_components_LimitLine_arrayFFHandler")]
		public virtual unsafe void RenderLimitLineLabel (global::Android.Graphics.Canvas c, global::MikePhil.Charting.Components.LimitLine limitLine, float[] position, float yOffset)
		{
			const string __id = "renderLimitLineLabel.(Landroid/graphics/Canvas;Lcom/github/mikephil/charting/components/LimitLine;[FF)V";
			IntPtr native_position = JNIEnv.NewArray (position);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue ((limitLine == null) ? IntPtr.Zero : ((global::Java.Lang.Object) limitLine).Handle);
				__args [2] = new JniArgumentValue (native_position);
				__args [3] = new JniArgumentValue (yOffset);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (position != null) {
					JNIEnv.CopyArray (native_position, position);
					JNIEnv.DeleteLocalRef (native_position);
				}
			}
		}

		static Delegate cb_renderLimitLineLine_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_components_LimitLine_arrayF;
#pragma warning disable 0169
		static Delegate GetRenderLimitLineLine_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_components_LimitLine_arrayFHandler ()
		{
			if (cb_renderLimitLineLine_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_components_LimitLine_arrayF == null)
				cb_renderLimitLineLine_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_components_LimitLine_arrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_RenderLimitLineLine_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_components_LimitLine_arrayF);
			return cb_renderLimitLineLine_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_components_LimitLine_arrayF;
		}

		static void n_RenderLimitLineLine_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_components_LimitLine_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_limitLine, IntPtr native_position)
		{
			global::MikePhil.Charting.Renderer.XAxisRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.XAxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.LimitLine limitLine = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine> (native_limitLine, JniHandleOwnership.DoNotTransfer);
			float[] position = (float[]) JNIEnv.GetArray (native_position, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.RenderLimitLineLine (c, limitLine, position);
			if (position != null)
				JNIEnv.CopyArray (position, native_position);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='XAxisRenderer']/method[@name='renderLimitLineLine' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.github.mikephil.charting.components.LimitLine'] and parameter[3][@type='float[]']]"
		[Register ("renderLimitLineLine", "(Landroid/graphics/Canvas;Lcom/github/mikephil/charting/components/LimitLine;[F)V", "GetRenderLimitLineLine_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_components_LimitLine_arrayFHandler")]
		public virtual unsafe void RenderLimitLineLine (global::Android.Graphics.Canvas c, global::MikePhil.Charting.Components.LimitLine limitLine, float[] position)
		{
			const string __id = "renderLimitLineLine.(Landroid/graphics/Canvas;Lcom/github/mikephil/charting/components/LimitLine;[F)V";
			IntPtr native_position = JNIEnv.NewArray (position);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue ((limitLine == null) ? IntPtr.Zero : ((global::Java.Lang.Object) limitLine).Handle);
				__args [2] = new JniArgumentValue (native_position);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (position != null) {
					JNIEnv.CopyArray (native_position, position);
					JNIEnv.DeleteLocalRef (native_position);
				}
			}
		}

		static Delegate cb_renderLimitLines_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetRenderLimitLines_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_renderLimitLines_Landroid_graphics_Canvas_ == null)
				cb_renderLimitLines_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RenderLimitLines_Landroid_graphics_Canvas_);
			return cb_renderLimitLines_Landroid_graphics_Canvas_;
		}

		static void n_RenderLimitLines_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			global::MikePhil.Charting.Renderer.XAxisRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.XAxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.RenderLimitLines (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='XAxisRenderer']/method[@name='renderLimitLines' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("renderLimitLines", "(Landroid/graphics/Canvas;)V", "GetRenderLimitLines_Landroid_graphics_Canvas_Handler")]
		public override unsafe void RenderLimitLines (global::Android.Graphics.Canvas c)
		{
			const string __id = "renderLimitLines.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setupGridPaint;
#pragma warning disable 0169
		static Delegate GetSetupGridPaintHandler ()
		{
			if (cb_setupGridPaint == null)
				cb_setupGridPaint = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_SetupGridPaint);
			return cb_setupGridPaint;
		}

		static void n_SetupGridPaint (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Renderer.XAxisRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.XAxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetupGridPaint ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='XAxisRenderer']/method[@name='setupGridPaint' and count(parameter)=0]"
		[Register ("setupGridPaint", "()V", "GetSetupGridPaintHandler")]
		protected virtual unsafe void SetupGridPaint ()
		{
			const string __id = "setupGridPaint.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
