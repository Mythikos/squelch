using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='CombinedChartRenderer']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/renderer/CombinedChartRenderer", DoNotGenerateAcw=true)]
	public partial class CombinedChartRenderer : global::MikePhil.Charting.Renderer.DataRenderer {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='CombinedChartRenderer']/field[@name='mChart']"
		[Register ("mChart")]
		protected global::Java.Lang.Ref.WeakReference MChart {
			get {
				const string __id = "mChart.Ljava/lang/ref/WeakReference;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Ref.WeakReference> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mChart.Ljava/lang/ref/WeakReference;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='CombinedChartRenderer']/field[@name='mHighlightBuffer']"
		[Register ("mHighlightBuffer")]
		protected global::System.Collections.IList MHighlightBuffer {
			get {
				const string __id = "mHighlightBuffer.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mHighlightBuffer.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='CombinedChartRenderer']/field[@name='mRenderers']"
		[Register ("mRenderers")]
		protected global::System.Collections.IList MRenderers {
			get {
				const string __id = "mRenderers.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mRenderers.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/renderer/CombinedChartRenderer", typeof (CombinedChartRenderer));
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

		protected CombinedChartRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='CombinedChartRenderer']/constructor[@name='CombinedChartRenderer' and count(parameter)=3 and parameter[1][@type='com.github.mikephil.charting.charts.CombinedChart'] and parameter[2][@type='com.github.mikephil.charting.animation.ChartAnimator'] and parameter[3][@type='com.github.mikephil.charting.utils.ViewPortHandler']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/charts/CombinedChart;Lcom/github/mikephil/charting/animation/ChartAnimator;Lcom/github/mikephil/charting/utils/ViewPortHandler;)V", "")]
		public unsafe CombinedChartRenderer (global::MikePhil.Charting.Charts.CombinedChart chart, global::MikePhil.Charting.Animation.ChartAnimator animator, global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/charts/CombinedChart;Lcom/github/mikephil/charting/animation/ChartAnimator;Lcom/github/mikephil/charting/utils/ViewPortHandler;)V";

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

		static Delegate cb_getSubRenderers;
#pragma warning disable 0169
		static Delegate GetGetSubRenderersHandler ()
		{
			if (cb_getSubRenderers == null)
				cb_getSubRenderers = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSubRenderers);
			return cb_getSubRenderers;
		}

		static IntPtr n_GetSubRenderers (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Renderer.CombinedChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.CombinedChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::MikePhil.Charting.Renderer.DataRenderer>.ToLocalJniHandle (__this.SubRenderers);
		}
#pragma warning restore 0169

		static Delegate cb_setSubRenderers_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetSubRenderers_Ljava_util_List_Handler ()
		{
			if (cb_setSubRenderers_Ljava_util_List_ == null)
				cb_setSubRenderers_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSubRenderers_Ljava_util_List_);
			return cb_setSubRenderers_Ljava_util_List_;
		}

		static void n_SetSubRenderers_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_renderers)
		{
			global::MikePhil.Charting.Renderer.CombinedChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.CombinedChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var renderers = global::Android.Runtime.JavaList<global::MikePhil.Charting.Renderer.DataRenderer>.FromJniHandle (native_renderers, JniHandleOwnership.DoNotTransfer);
			__this.SubRenderers = renderers;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::MikePhil.Charting.Renderer.DataRenderer> SubRenderers {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='CombinedChartRenderer']/method[@name='getSubRenderers' and count(parameter)=0]"
			[Register ("getSubRenderers", "()Ljava/util/List;", "GetGetSubRenderersHandler")]
			get {
				const string __id = "getSubRenderers.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::MikePhil.Charting.Renderer.DataRenderer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='CombinedChartRenderer']/method[@name='setSubRenderers' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.github.mikephil.charting.renderer.DataRenderer&gt;']]"
			[Register ("setSubRenderers", "(Ljava/util/List;)V", "GetSetSubRenderers_Ljava_util_List_Handler")]
			set {
				const string __id = "setSubRenderers.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::MikePhil.Charting.Renderer.DataRenderer>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_createRenderers;
#pragma warning disable 0169
		static Delegate GetCreateRenderersHandler ()
		{
			if (cb_createRenderers == null)
				cb_createRenderers = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CreateRenderers);
			return cb_createRenderers;
		}

		static void n_CreateRenderers (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Renderer.CombinedChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.CombinedChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CreateRenderers ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='CombinedChartRenderer']/method[@name='createRenderers' and count(parameter)=0]"
		[Register ("createRenderers", "()V", "GetCreateRenderersHandler")]
		public virtual unsafe void CreateRenderers ()
		{
			const string __id = "createRenderers.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::MikePhil.Charting.Renderer.CombinedChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.CombinedChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.DrawData (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='CombinedChartRenderer']/method[@name='drawData' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
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
			global::MikePhil.Charting.Renderer.CombinedChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.CombinedChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.DrawExtras (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='CombinedChartRenderer']/method[@name='drawExtras' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
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
			global::MikePhil.Charting.Renderer.CombinedChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.CombinedChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Highlight.Highlight[] indices = (global::MikePhil.Charting.Highlight.Highlight[]) JNIEnv.GetArray (native_indices, JniHandleOwnership.DoNotTransfer, typeof (global::MikePhil.Charting.Highlight.Highlight));
			__this.DrawHighlighted (c, indices);
			if (indices != null)
				JNIEnv.CopyArray (indices, native_indices);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='CombinedChartRenderer']/method[@name='drawHighlighted' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.github.mikephil.charting.highlight.Highlight[]']]"
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
			global::MikePhil.Charting.Renderer.CombinedChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.CombinedChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.DrawValues (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='CombinedChartRenderer']/method[@name='drawValues' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
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

		static Delegate cb_getSubRenderer_I;
#pragma warning disable 0169
		static Delegate GetGetSubRenderer_IHandler ()
		{
			if (cb_getSubRenderer_I == null)
				cb_getSubRenderer_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetSubRenderer_I);
			return cb_getSubRenderer_I;
		}

		static IntPtr n_GetSubRenderer_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::MikePhil.Charting.Renderer.CombinedChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.CombinedChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetSubRenderer (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='CombinedChartRenderer']/method[@name='getSubRenderer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSubRenderer", "(I)Lcom/github/mikephil/charting/renderer/DataRenderer;", "GetGetSubRenderer_IHandler")]
		public virtual unsafe global::MikePhil.Charting.Renderer.DataRenderer GetSubRenderer (int index)
		{
			const string __id = "getSubRenderer.(I)Lcom/github/mikephil/charting/renderer/DataRenderer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.DataRenderer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::MikePhil.Charting.Renderer.CombinedChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.CombinedChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitBuffers ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='CombinedChartRenderer']/method[@name='initBuffers' and count(parameter)=0]"
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
