using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Renderer.Scatter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.renderer.scatter']/class[@name='ChevronUpShapeRenderer']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/renderer/scatter/ChevronUpShapeRenderer", DoNotGenerateAcw=true)]
	public partial class ChevronUpShapeRenderer : global::Java.Lang.Object, global::MikePhil.Charting.Renderer.Scatter.IShapeRenderer {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/renderer/scatter/ChevronUpShapeRenderer", typeof (ChevronUpShapeRenderer));

		internal static IntPtr class_ref {
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

		protected ChevronUpShapeRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.renderer.scatter']/class[@name='ChevronUpShapeRenderer']/constructor[@name='ChevronUpShapeRenderer' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ChevronUpShapeRenderer () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_renderShape_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_Lcom_github_mikephil_charting_utils_ViewPortHandler_FFLandroid_graphics_Paint_;
#pragma warning disable 0169
		static Delegate GetRenderShape_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_Lcom_github_mikephil_charting_utils_ViewPortHandler_FFLandroid_graphics_Paint_Handler ()
		{
			if (cb_renderShape_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_Lcom_github_mikephil_charting_utils_ViewPortHandler_FFLandroid_graphics_Paint_ == null)
				cb_renderShape_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_Lcom_github_mikephil_charting_utils_ViewPortHandler_FFLandroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLLFFL_V) n_RenderShape_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_Lcom_github_mikephil_charting_utils_ViewPortHandler_FFLandroid_graphics_Paint_);
			return cb_renderShape_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_Lcom_github_mikephil_charting_utils_ViewPortHandler_FFLandroid_graphics_Paint_;
		}

		static void n_RenderShape_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_Lcom_github_mikephil_charting_utils_ViewPortHandler_FFLandroid_graphics_Paint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_dataSet, IntPtr native_viewPortHandler, float posX, float posY, IntPtr native_renderPaint)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.Scatter.ChevronUpShapeRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			var dataSet = (global::MikePhil.Charting.Interfaces.Datasets.IScatterDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IScatterDataSet> (native_dataSet, JniHandleOwnership.DoNotTransfer);
			var viewPortHandler = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (native_viewPortHandler, JniHandleOwnership.DoNotTransfer);
			var renderPaint = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_renderPaint, JniHandleOwnership.DoNotTransfer);
			__this.RenderShape (c, dataSet, viewPortHandler, posX, posY, renderPaint);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer.scatter']/class[@name='ChevronUpShapeRenderer']/method[@name='renderShape' and count(parameter)=6 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.github.mikephil.charting.interfaces.datasets.IScatterDataSet'] and parameter[3][@type='com.github.mikephil.charting.utils.ViewPortHandler'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='android.graphics.Paint']]"
		[Register ("renderShape", "(Landroid/graphics/Canvas;Lcom/github/mikephil/charting/interfaces/datasets/IScatterDataSet;Lcom/github/mikephil/charting/utils/ViewPortHandler;FFLandroid/graphics/Paint;)V", "GetRenderShape_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_Lcom_github_mikephil_charting_utils_ViewPortHandler_FFLandroid_graphics_Paint_Handler")]
		public virtual unsafe void RenderShape (global::Android.Graphics.Canvas c, global::MikePhil.Charting.Interfaces.Datasets.IScatterDataSet dataSet, global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler, float posX, float posY, global::Android.Graphics.Paint renderPaint)
		{
			const string __id = "renderShape.(Landroid/graphics/Canvas;Lcom/github/mikephil/charting/interfaces/datasets/IScatterDataSet;Lcom/github/mikephil/charting/utils/ViewPortHandler;FFLandroid/graphics/Paint;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue ((dataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSet).Handle);
				__args [2] = new JniArgumentValue ((viewPortHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPortHandler).Handle);
				__args [3] = new JniArgumentValue (posX);
				__args [4] = new JniArgumentValue (posY);
				__args [5] = new JniArgumentValue ((renderPaint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) renderPaint).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
				global::System.GC.KeepAlive (dataSet);
				global::System.GC.KeepAlive (viewPortHandler);
				global::System.GC.KeepAlive (renderPaint);
			}
		}

	}
}
