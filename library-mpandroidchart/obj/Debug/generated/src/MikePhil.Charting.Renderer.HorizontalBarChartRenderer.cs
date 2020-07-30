using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='HorizontalBarChartRenderer']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/renderer/HorizontalBarChartRenderer", DoNotGenerateAcw=true)]
	public partial class HorizontalBarChartRenderer : global::MikePhil.Charting.Renderer.BarChartRenderer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/renderer/HorizontalBarChartRenderer", typeof (HorizontalBarChartRenderer));
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

		protected HorizontalBarChartRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='HorizontalBarChartRenderer']/constructor[@name='HorizontalBarChartRenderer' and count(parameter)=3 and parameter[1][@type='com.github.mikephil.charting.interfaces.dataprovider.BarDataProvider'] and parameter[2][@type='com.github.mikephil.charting.animation.ChartAnimator'] and parameter[3][@type='com.github.mikephil.charting.utils.ViewPortHandler']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/interfaces/dataprovider/BarDataProvider;Lcom/github/mikephil/charting/animation/ChartAnimator;Lcom/github/mikephil/charting/utils/ViewPortHandler;)V", "")]
		public unsafe HorizontalBarChartRenderer (global::MikePhil.Charting.Interfaces.Dataprovider.IBarDataProvider chart, global::MikePhil.Charting.Animation.ChartAnimator animator, global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			}
		}

		static Delegate cb_drawValue_Landroid_graphics_Canvas_Ljava_lang_String_FFI;
#pragma warning disable 0169
		static Delegate GetDrawValue_Landroid_graphics_Canvas_Ljava_lang_String_FFIHandler ()
		{
			if (cb_drawValue_Landroid_graphics_Canvas_Ljava_lang_String_FFI == null)
				cb_drawValue_Landroid_graphics_Canvas_Ljava_lang_String_FFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, float, float, int>) n_DrawValue_Landroid_graphics_Canvas_Ljava_lang_String_FFI);
			return cb_drawValue_Landroid_graphics_Canvas_Ljava_lang_String_FFI;
		}

		static void n_DrawValue_Landroid_graphics_Canvas_Ljava_lang_String_FFI (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_valueText, float x, float y, int color)
		{
			global::MikePhil.Charting.Renderer.HorizontalBarChartRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.HorizontalBarChartRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			string valueText = JNIEnv.GetString (native_valueText, JniHandleOwnership.DoNotTransfer);
			__this.DrawValue (c, valueText, x, y, color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='HorizontalBarChartRenderer']/method[@name='drawValue' and count(parameter)=5 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='int']]"
		[Register ("drawValue", "(Landroid/graphics/Canvas;Ljava/lang/String;FFI)V", "GetDrawValue_Landroid_graphics_Canvas_Ljava_lang_String_FFIHandler")]
		protected virtual unsafe void DrawValue (global::Android.Graphics.Canvas c, string valueText, float x, float y, int color)
		{
			const string __id = "drawValue.(Landroid/graphics/Canvas;Ljava/lang/String;FFI)V";
			IntPtr native_valueText = JNIEnv.NewString (valueText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue (native_valueText);
				__args [2] = new JniArgumentValue (x);
				__args [3] = new JniArgumentValue (y);
				__args [4] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_valueText);
			}
		}

	}
}
