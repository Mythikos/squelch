using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='YAxisRenderer']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/renderer/YAxisRenderer", DoNotGenerateAcw=true)]
	public partial class YAxisRenderer : global::MikePhil.Charting.Renderer.AxisRenderer {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='YAxisRenderer']/field[@name='mDrawZeroLinePath']"
		[Register ("mDrawZeroLinePath")]
		protected global::Android.Graphics.Path MDrawZeroLinePath {
			get {
				const string __id = "mDrawZeroLinePath.Landroid/graphics/Path;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Path> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDrawZeroLinePath.Landroid/graphics/Path;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='YAxisRenderer']/field[@name='mGetTransformedPositionsBuffer']"
		[Register ("mGetTransformedPositionsBuffer")]
		protected IList<float> MGetTransformedPositionsBuffer {
			get {
				const string __id = "mGetTransformedPositionsBuffer.[F";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<float>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mGetTransformedPositionsBuffer.[F";

				IntPtr native_value = global::Android.Runtime.JavaArray<float>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='YAxisRenderer']/field[@name='mGridClippingRect']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='YAxisRenderer']/field[@name='mLimitLineClippingRect']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='YAxisRenderer']/field[@name='mRenderGridLinesPath']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='YAxisRenderer']/field[@name='mRenderLimitLines']"
		[Register ("mRenderLimitLines")]
		protected global::Android.Graphics.Path MRenderLimitLines {
			get {
				const string __id = "mRenderLimitLines.Landroid/graphics/Path;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Path> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mRenderLimitLines.Landroid/graphics/Path;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='YAxisRenderer']/field[@name='mRenderLimitLinesBuffer']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='YAxisRenderer']/field[@name='mYAxis']"
		[Register ("mYAxis")]
		protected global::MikePhil.Charting.Components.YAxis MYAxis {
			get {
				const string __id = "mYAxis.Lcom/github/mikephil/charting/components/YAxis;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mYAxis.Lcom/github/mikephil/charting/components/YAxis;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='YAxisRenderer']/field[@name='mZeroLineClippingRect']"
		[Register ("mZeroLineClippingRect")]
		protected global::Android.Graphics.RectF MZeroLineClippingRect {
			get {
				const string __id = "mZeroLineClippingRect.Landroid/graphics/RectF;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mZeroLineClippingRect.Landroid/graphics/RectF;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='YAxisRenderer']/field[@name='mZeroLinePaint']"
		[Register ("mZeroLinePaint")]
		protected global::Android.Graphics.Paint MZeroLinePaint {
			get {
				const string __id = "mZeroLinePaint.Landroid/graphics/Paint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mZeroLinePaint.Landroid/graphics/Paint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/renderer/YAxisRenderer", typeof (YAxisRenderer));

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

		protected YAxisRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='YAxisRenderer']/constructor[@name='YAxisRenderer' and count(parameter)=3 and parameter[1][@type='com.github.mikephil.charting.utils.ViewPortHandler'] and parameter[2][@type='com.github.mikephil.charting.components.YAxis'] and parameter[3][@type='com.github.mikephil.charting.utils.Transformer']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/utils/ViewPortHandler;Lcom/github/mikephil/charting/components/YAxis;Lcom/github/mikephil/charting/utils/Transformer;)V", "")]
		public unsafe YAxisRenderer (global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler, global::MikePhil.Charting.Components.YAxis yAxis, global::MikePhil.Charting.Util.Transformer trans) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/utils/ViewPortHandler;Lcom/github/mikephil/charting/components/YAxis;Lcom/github/mikephil/charting/utils/Transformer;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((viewPortHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPortHandler).Handle);
				__args [1] = new JniArgumentValue ((yAxis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) yAxis).Handle);
				__args [2] = new JniArgumentValue ((trans == null) ? IntPtr.Zero : ((global::Java.Lang.Object) trans).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (viewPortHandler);
				global::System.GC.KeepAlive (yAxis);
				global::System.GC.KeepAlive (trans);
			}
		}

		static Delegate cb_getGridClippingRect;
#pragma warning disable 0169
		static Delegate GetGetGridClippingRectHandler ()
		{
			if (cb_getGridClippingRect == null)
				cb_getGridClippingRect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetGridClippingRect);
			return cb_getGridClippingRect;
		}

		static IntPtr n_GetGridClippingRect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.YAxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GridClippingRect);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.RectF GridClippingRect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='YAxisRenderer']/method[@name='getGridClippingRect' and count(parameter)=0]"
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

		static Delegate cb_drawYLabels_Landroid_graphics_Canvas_FarrayFF;
#pragma warning disable 0169
		static Delegate GetDrawYLabels_Landroid_graphics_Canvas_FarrayFFHandler ()
		{
			if (cb_drawYLabels_Landroid_graphics_Canvas_FarrayFF == null)
				cb_drawYLabels_Landroid_graphics_Canvas_FarrayFF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLFLF_V) n_DrawYLabels_Landroid_graphics_Canvas_FarrayFF);
			return cb_drawYLabels_Landroid_graphics_Canvas_FarrayFF;
		}

		static void n_DrawYLabels_Landroid_graphics_Canvas_FarrayFF (IntPtr jnienv, IntPtr native__this, IntPtr native_c, float fixedPosition, IntPtr native_positions, float offset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.YAxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			var positions = (float[]) JNIEnv.GetArray (native_positions, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.DrawYLabels (c, fixedPosition, positions, offset);
			if (positions != null)
				JNIEnv.CopyArray (positions, native_positions);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='YAxisRenderer']/method[@name='drawYLabels' and count(parameter)=4 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='float'] and parameter[3][@type='float[]'] and parameter[4][@type='float']]"
		[Register ("drawYLabels", "(Landroid/graphics/Canvas;F[FF)V", "GetDrawYLabels_Landroid_graphics_Canvas_FarrayFFHandler")]
		protected virtual unsafe void DrawYLabels (global::Android.Graphics.Canvas c, float fixedPosition, float[] positions, float offset)
		{
			const string __id = "drawYLabels.(Landroid/graphics/Canvas;F[FF)V";
			IntPtr native_positions = JNIEnv.NewArray (positions);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue (fixedPosition);
				__args [2] = new JniArgumentValue (native_positions);
				__args [3] = new JniArgumentValue (offset);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (positions != null) {
					JNIEnv.CopyArray (native_positions, positions);
					JNIEnv.DeleteLocalRef (native_positions);
				}
				global::System.GC.KeepAlive (c);
				global::System.GC.KeepAlive (positions);
			}
		}

		static Delegate cb_drawZeroLine_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDrawZeroLine_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_drawZeroLine_Landroid_graphics_Canvas_ == null)
				cb_drawZeroLine_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DrawZeroLine_Landroid_graphics_Canvas_);
			return cb_drawZeroLine_Landroid_graphics_Canvas_;
		}

		static void n_DrawZeroLine_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.YAxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.DrawZeroLine (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='YAxisRenderer']/method[@name='drawZeroLine' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawZeroLine", "(Landroid/graphics/Canvas;)V", "GetDrawZeroLine_Landroid_graphics_Canvas_Handler")]
		protected virtual unsafe void DrawZeroLine (global::Android.Graphics.Canvas c)
		{
			const string __id = "drawZeroLine.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
			}
		}

		static Delegate cb_getTransformedPositions;
#pragma warning disable 0169
		static Delegate GetGetTransformedPositionsHandler ()
		{
			if (cb_getTransformedPositions == null)
				cb_getTransformedPositions = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTransformedPositions);
			return cb_getTransformedPositions;
		}

		static IntPtr n_GetTransformedPositions (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.YAxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetTransformedPositions ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='YAxisRenderer']/method[@name='getTransformedPositions' and count(parameter)=0]"
		[Register ("getTransformedPositions", "()[F", "GetGetTransformedPositionsHandler")]
		protected virtual unsafe float[] GetTransformedPositions ()
		{
			const string __id = "getTransformedPositions.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_linePath_Landroid_graphics_Path_IarrayF;
#pragma warning disable 0169
		static Delegate GetLinePath_Landroid_graphics_Path_IarrayFHandler ()
		{
			if (cb_linePath_Landroid_graphics_Path_IarrayF == null)
				cb_linePath_Landroid_graphics_Path_IarrayF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLIL_L) n_LinePath_Landroid_graphics_Path_IarrayF);
			return cb_linePath_Landroid_graphics_Path_IarrayF;
		}

		static IntPtr n_LinePath_Landroid_graphics_Path_IarrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_p, int i, IntPtr native_positions)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.YAxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p = global::Java.Lang.Object.GetObject<global::Android.Graphics.Path> (native_p, JniHandleOwnership.DoNotTransfer);
			var positions = (float[]) JNIEnv.GetArray (native_positions, JniHandleOwnership.DoNotTransfer, typeof (float));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.LinePath (p, i, positions));
			if (positions != null)
				JNIEnv.CopyArray (positions, native_positions);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='YAxisRenderer']/method[@name='linePath' and count(parameter)=3 and parameter[1][@type='android.graphics.Path'] and parameter[2][@type='int'] and parameter[3][@type='float[]']]"
		[Register ("linePath", "(Landroid/graphics/Path;I[F)Landroid/graphics/Path;", "GetLinePath_Landroid_graphics_Path_IarrayFHandler")]
		protected virtual unsafe global::Android.Graphics.Path LinePath (global::Android.Graphics.Path p, int i, float[] positions)
		{
			const string __id = "linePath.(Landroid/graphics/Path;I[F)Landroid/graphics/Path;";
			IntPtr native_positions = JNIEnv.NewArray (positions);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				__args [1] = new JniArgumentValue (i);
				__args [2] = new JniArgumentValue (native_positions);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Path> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (positions != null) {
					JNIEnv.CopyArray (native_positions, positions);
					JNIEnv.DeleteLocalRef (native_positions);
				}
				global::System.GC.KeepAlive (p);
				global::System.GC.KeepAlive (positions);
			}
		}

		static Delegate cb_renderAxisLabels_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetRenderAxisLabels_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_renderAxisLabels_Landroid_graphics_Canvas_ == null)
				cb_renderAxisLabels_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RenderAxisLabels_Landroid_graphics_Canvas_);
			return cb_renderAxisLabels_Landroid_graphics_Canvas_;
		}

		static void n_RenderAxisLabels_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.YAxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.RenderAxisLabels (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='YAxisRenderer']/method[@name='renderAxisLabels' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("renderAxisLabels", "(Landroid/graphics/Canvas;)V", "GetRenderAxisLabels_Landroid_graphics_Canvas_Handler")]
		public override unsafe void RenderAxisLabels (global::Android.Graphics.Canvas c)
		{
			const string __id = "renderAxisLabels.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
			}
		}

		static Delegate cb_renderAxisLine_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetRenderAxisLine_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_renderAxisLine_Landroid_graphics_Canvas_ == null)
				cb_renderAxisLine_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RenderAxisLine_Landroid_graphics_Canvas_);
			return cb_renderAxisLine_Landroid_graphics_Canvas_;
		}

		static void n_RenderAxisLine_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.YAxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.RenderAxisLine (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='YAxisRenderer']/method[@name='renderAxisLine' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("renderAxisLine", "(Landroid/graphics/Canvas;)V", "GetRenderAxisLine_Landroid_graphics_Canvas_Handler")]
		public override unsafe void RenderAxisLine (global::Android.Graphics.Canvas c)
		{
			const string __id = "renderAxisLine.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
			}
		}

		static Delegate cb_renderGridLines_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetRenderGridLines_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_renderGridLines_Landroid_graphics_Canvas_ == null)
				cb_renderGridLines_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RenderGridLines_Landroid_graphics_Canvas_);
			return cb_renderGridLines_Landroid_graphics_Canvas_;
		}

		static void n_RenderGridLines_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.YAxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.RenderGridLines (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='YAxisRenderer']/method[@name='renderGridLines' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("renderGridLines", "(Landroid/graphics/Canvas;)V", "GetRenderGridLines_Landroid_graphics_Canvas_Handler")]
		public override unsafe void RenderGridLines (global::Android.Graphics.Canvas c)
		{
			const string __id = "renderGridLines.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
			}
		}

		static Delegate cb_renderLimitLines_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetRenderLimitLines_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_renderLimitLines_Landroid_graphics_Canvas_ == null)
				cb_renderLimitLines_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RenderLimitLines_Landroid_graphics_Canvas_);
			return cb_renderLimitLines_Landroid_graphics_Canvas_;
		}

		static void n_RenderLimitLines_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.YAxisRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.RenderLimitLines (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='YAxisRenderer']/method[@name='renderLimitLines' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("renderLimitLines", "(Landroid/graphics/Canvas;)V", "GetRenderLimitLines_Landroid_graphics_Canvas_Handler")]
		public override unsafe void RenderLimitLines (global::Android.Graphics.Canvas c)
		{
			const string __id = "renderLimitLines.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
			}
		}

	}
}
