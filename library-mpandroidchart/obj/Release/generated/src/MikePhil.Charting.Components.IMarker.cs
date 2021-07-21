using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Components {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.mikephil.charting.components']/interface[@name='IMarker']"
	[Register ("com/github/mikephil/charting/components/IMarker", "", "MikePhil.Charting.Components.IMarkerInvoker")]
	public partial interface IMarker : IJavaObject {

		global::MikePhil.Charting.Util.MPPointF Offset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/interface[@name='IMarker']/method[@name='getOffset' and count(parameter)=0]"
			[Register ("getOffset", "()Lcom/github/mikephil/charting/utils/MPPointF;", "GetGetOffsetHandler:MikePhil.Charting.Components.IMarkerInvoker, library-mpandroidchart")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/interface[@name='IMarker']/method[@name='draw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("draw", "(Landroid/graphics/Canvas;FF)V", "GetDraw_Landroid_graphics_Canvas_FFHandler:MikePhil.Charting.Components.IMarkerInvoker, library-mpandroidchart")]
		void Draw (global::Android.Graphics.Canvas p0, float p1, float p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/interface[@name='IMarker']/method[@name='getOffsetForDrawingAtPoint' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("getOffsetForDrawingAtPoint", "(FF)Lcom/github/mikephil/charting/utils/MPPointF;", "GetGetOffsetForDrawingAtPoint_FFHandler:MikePhil.Charting.Components.IMarkerInvoker, library-mpandroidchart")]
		global::MikePhil.Charting.Util.MPPointF GetOffsetForDrawingAtPoint (float p0, float p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/interface[@name='IMarker']/method[@name='refreshContent' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.data.Entry'] and parameter[2][@type='com.github.mikephil.charting.highlight.Highlight']]"
		[Register ("refreshContent", "(Lcom/github/mikephil/charting/data/Entry;Lcom/github/mikephil/charting/highlight/Highlight;)V", "GetRefreshContent_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_Handler:MikePhil.Charting.Components.IMarkerInvoker, library-mpandroidchart")]
		void RefreshContent (global::MikePhil.Charting.Data.Entry p0, global::MikePhil.Charting.Highlight.Highlight p1);

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/components/IMarker", DoNotGenerateAcw=true)]
	internal class IMarkerInvoker : global::Java.Lang.Object, IMarker {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/github/mikephil/charting/components/IMarker", typeof (IMarkerInvoker));

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

		public static IMarker GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMarker> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.github.mikephil.charting.components.IMarker"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMarkerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getOffset;
#pragma warning disable 0169
		static Delegate GetGetOffsetHandler ()
		{
			if (cb_getOffset == null)
				cb_getOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOffset);
			return cb_getOffset;
		}

		static IntPtr n_GetOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.IMarker __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Offset);
		}
#pragma warning restore 0169

		IntPtr id_getOffset;
		public unsafe global::MikePhil.Charting.Util.MPPointF Offset {
			get {
				if (id_getOffset == IntPtr.Zero)
					id_getOffset = JNIEnv.GetMethodID (class_ref, "getOffset", "()Lcom/github/mikephil/charting/utils/MPPointF;");
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOffset), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_draw_Landroid_graphics_Canvas_FF;
#pragma warning disable 0169
		static Delegate GetDraw_Landroid_graphics_Canvas_FFHandler ()
		{
			if (cb_draw_Landroid_graphics_Canvas_FF == null)
				cb_draw_Landroid_graphics_Canvas_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float, float>) n_Draw_Landroid_graphics_Canvas_FF);
			return cb_draw_Landroid_graphics_Canvas_FF;
		}

		static void n_Draw_Landroid_graphics_Canvas_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, float p1, float p2)
		{
			global::MikePhil.Charting.Components.IMarker __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Draw (p0, p1, p2);
		}
#pragma warning restore 0169

		IntPtr id_draw_Landroid_graphics_Canvas_FF;
		public unsafe void Draw (global::Android.Graphics.Canvas p0, float p1, float p2)
		{
			if (id_draw_Landroid_graphics_Canvas_FF == IntPtr.Zero)
				id_draw_Landroid_graphics_Canvas_FF = JNIEnv.GetMethodID (class_ref, "draw", "(Landroid/graphics/Canvas;FF)V");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_draw_Landroid_graphics_Canvas_FF, __args);
		}

		static Delegate cb_getOffsetForDrawingAtPoint_FF;
#pragma warning disable 0169
		static Delegate GetGetOffsetForDrawingAtPoint_FFHandler ()
		{
			if (cb_getOffsetForDrawingAtPoint_FF == null)
				cb_getOffsetForDrawingAtPoint_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_GetOffsetForDrawingAtPoint_FF);
			return cb_getOffsetForDrawingAtPoint_FF;
		}

		static IntPtr n_GetOffsetForDrawingAtPoint_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::MikePhil.Charting.Components.IMarker __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetOffsetForDrawingAtPoint (p0, p1));
		}
#pragma warning restore 0169

		IntPtr id_getOffsetForDrawingAtPoint_FF;
		public unsafe global::MikePhil.Charting.Util.MPPointF GetOffsetForDrawingAtPoint (float p0, float p1)
		{
			if (id_getOffsetForDrawingAtPoint_FF == IntPtr.Zero)
				id_getOffsetForDrawingAtPoint_FF = JNIEnv.GetMethodID (class_ref, "getOffsetForDrawingAtPoint", "(FF)Lcom/github/mikephil/charting/utils/MPPointF;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOffsetForDrawingAtPoint_FF, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_refreshContent_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_;
#pragma warning disable 0169
		static Delegate GetRefreshContent_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_Handler ()
		{
			if (cb_refreshContent_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_ == null)
				cb_refreshContent_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RefreshContent_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_);
			return cb_refreshContent_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_;
		}

		static void n_RefreshContent_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::MikePhil.Charting.Components.IMarker __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.IMarker> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.Entry p0 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.Entry> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Highlight.Highlight p1 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.RefreshContent (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_refreshContent_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_;
		public unsafe void RefreshContent (global::MikePhil.Charting.Data.Entry p0, global::MikePhil.Charting.Highlight.Highlight p1)
		{
			if (id_refreshContent_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_ == IntPtr.Zero)
				id_refreshContent_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_ = JNIEnv.GetMethodID (class_ref, "refreshContent", "(Lcom/github/mikephil/charting/data/Entry;Lcom/github/mikephil/charting/highlight/Highlight;)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			__args [1] = new JValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_refreshContent_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_, __args);
		}

	}

}
