using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Renderer.Scatter {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.mikephil.charting.renderer.scatter']/interface[@name='IShapeRenderer']"
	[Register ("com/github/mikephil/charting/renderer/scatter/IShapeRenderer", "", "MikePhil.Charting.Renderer.Scatter.IShapeRendererInvoker")]
	public partial interface IShapeRenderer : IJavaObject {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer.scatter']/interface[@name='IShapeRenderer']/method[@name='renderShape' and count(parameter)=6 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.github.mikephil.charting.interfaces.datasets.IScatterDataSet'] and parameter[3][@type='com.github.mikephil.charting.utils.ViewPortHandler'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='android.graphics.Paint']]"
		[Register ("renderShape", "(Landroid/graphics/Canvas;Lcom/github/mikephil/charting/interfaces/datasets/IScatterDataSet;Lcom/github/mikephil/charting/utils/ViewPortHandler;FFLandroid/graphics/Paint;)V", "GetRenderShape_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_Lcom_github_mikephil_charting_utils_ViewPortHandler_FFLandroid_graphics_Paint_Handler:MikePhil.Charting.Renderer.Scatter.IShapeRendererInvoker, library-mpandroidchart")]
		void RenderShape (global::Android.Graphics.Canvas p0, global::MikePhil.Charting.Interfaces.Datasets.IScatterDataSet p1, global::MikePhil.Charting.Util.ViewPortHandler p2, float p3, float p4, global::Android.Graphics.Paint p5);

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/renderer/scatter/IShapeRenderer", DoNotGenerateAcw=true)]
	internal class IShapeRendererInvoker : global::Java.Lang.Object, IShapeRenderer {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/github/mikephil/charting/renderer/scatter/IShapeRenderer", typeof (IShapeRendererInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IShapeRenderer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IShapeRenderer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.github.mikephil.charting.renderer.scatter.IShapeRenderer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IShapeRendererInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_renderShape_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_Lcom_github_mikephil_charting_utils_ViewPortHandler_FFLandroid_graphics_Paint_;
#pragma warning disable 0169
		static Delegate GetRenderShape_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_Lcom_github_mikephil_charting_utils_ViewPortHandler_FFLandroid_graphics_Paint_Handler ()
		{
			if (cb_renderShape_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_Lcom_github_mikephil_charting_utils_ViewPortHandler_FFLandroid_graphics_Paint_ == null)
				cb_renderShape_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_Lcom_github_mikephil_charting_utils_ViewPortHandler_FFLandroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, float, float, IntPtr>) n_RenderShape_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_Lcom_github_mikephil_charting_utils_ViewPortHandler_FFLandroid_graphics_Paint_);
			return cb_renderShape_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_Lcom_github_mikephil_charting_utils_ViewPortHandler_FFLandroid_graphics_Paint_;
		}

		static void n_RenderShape_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_Lcom_github_mikephil_charting_utils_ViewPortHandler_FFLandroid_graphics_Paint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1, IntPtr native_p2, float p3, float p4, IntPtr native_p5)
		{
			global::MikePhil.Charting.Renderer.Scatter.IShapeRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.Scatter.IShapeRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Interfaces.Datasets.IScatterDataSet p1 = (global::MikePhil.Charting.Interfaces.Datasets.IScatterDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IScatterDataSet> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Util.ViewPortHandler p2 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (native_p2, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p5 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p5, JniHandleOwnership.DoNotTransfer);
			__this.RenderShape (p0, p1, p2, p3, p4, p5);
		}
#pragma warning restore 0169

		IntPtr id_renderShape_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_Lcom_github_mikephil_charting_utils_ViewPortHandler_FFLandroid_graphics_Paint_;
		public unsafe void RenderShape (global::Android.Graphics.Canvas p0, global::MikePhil.Charting.Interfaces.Datasets.IScatterDataSet p1, global::MikePhil.Charting.Util.ViewPortHandler p2, float p3, float p4, global::Android.Graphics.Paint p5)
		{
			if (id_renderShape_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_Lcom_github_mikephil_charting_utils_ViewPortHandler_FFLandroid_graphics_Paint_ == IntPtr.Zero)
				id_renderShape_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_Lcom_github_mikephil_charting_utils_ViewPortHandler_FFLandroid_graphics_Paint_ = JNIEnv.GetMethodID (class_ref, "renderShape", "(Landroid/graphics/Canvas;Lcom/github/mikephil/charting/interfaces/datasets/IScatterDataSet;Lcom/github/mikephil/charting/utils/ViewPortHandler;FFLandroid/graphics/Paint;)V");
			JValue* __args = stackalloc JValue [6];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			__args [5] = new JValue ((p5 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p5).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_renderShape_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_Lcom_github_mikephil_charting_utils_ViewPortHandler_FFLandroid_graphics_Paint_, __args);
		}

	}

}
