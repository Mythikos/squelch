using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Components {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='MarkerImage']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/components/MarkerImage", DoNotGenerateAcw=true)]
	public partial class MarkerImage : global::Java.Lang.Object, global::MikePhil.Charting.Components.IMarker {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/components/MarkerImage", typeof (MarkerImage));
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

		protected MarkerImage (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='MarkerImage']/constructor[@name='MarkerImage' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;I)V", "")]
		public unsafe MarkerImage (global::Android.Content.Context context, int drawableResourceId)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (drawableResourceId);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getChartView;
#pragma warning disable 0169
		static Delegate GetGetChartViewHandler ()
		{
			if (cb_getChartView == null)
				cb_getChartView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChartView);
			return cb_getChartView;
		}

		static IntPtr n_GetChartView (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.MarkerImage __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.MarkerImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ChartView);
		}
#pragma warning restore 0169

		static Delegate cb_setChartView_Lcom_github_mikephil_charting_charts_Chart_;
#pragma warning disable 0169
		static Delegate GetSetChartView_Lcom_github_mikephil_charting_charts_Chart_Handler ()
		{
			if (cb_setChartView_Lcom_github_mikephil_charting_charts_Chart_ == null)
				cb_setChartView_Lcom_github_mikephil_charting_charts_Chart_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetChartView_Lcom_github_mikephil_charting_charts_Chart_);
			return cb_setChartView_Lcom_github_mikephil_charting_charts_Chart_;
		}

		static void n_SetChartView_Lcom_github_mikephil_charting_charts_Chart_ (IntPtr jnienv, IntPtr native__this, IntPtr native_chart)
		{
			global::MikePhil.Charting.Components.MarkerImage __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.MarkerImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Charts.Chart chart = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (native_chart, JniHandleOwnership.DoNotTransfer);
			__this.ChartView = chart;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Charts.Chart ChartView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='MarkerImage']/method[@name='getChartView' and count(parameter)=0]"
			[Register ("getChartView", "()Lcom/github/mikephil/charting/charts/Chart;", "GetGetChartViewHandler")]
			get {
				const string __id = "getChartView.()Lcom/github/mikephil/charting/charts/Chart;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='MarkerImage']/method[@name='setChartView' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.charts.Chart']]"
			[Register ("setChartView", "(Lcom/github/mikephil/charting/charts/Chart;)V", "GetSetChartView_Lcom_github_mikephil_charting_charts_Chart_Handler")]
			set {
				const string __id = "setChartView.(Lcom/github/mikephil/charting/charts/Chart;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
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
			global::MikePhil.Charting.Components.MarkerImage __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.MarkerImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Offset);
		}
#pragma warning restore 0169

		static Delegate cb_setOffset_Lcom_github_mikephil_charting_utils_MPPointF_;
#pragma warning disable 0169
		static Delegate GetSetOffset_Lcom_github_mikephil_charting_utils_MPPointF_Handler ()
		{
			if (cb_setOffset_Lcom_github_mikephil_charting_utils_MPPointF_ == null)
				cb_setOffset_Lcom_github_mikephil_charting_utils_MPPointF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOffset_Lcom_github_mikephil_charting_utils_MPPointF_);
			return cb_setOffset_Lcom_github_mikephil_charting_utils_MPPointF_;
		}

		static void n_SetOffset_Lcom_github_mikephil_charting_utils_MPPointF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_offset)
		{
			global::MikePhil.Charting.Components.MarkerImage __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.MarkerImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Util.MPPointF offset = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (native_offset, JniHandleOwnership.DoNotTransfer);
			__this.Offset = offset;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Util.MPPointF Offset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='MarkerImage']/method[@name='getOffset' and count(parameter)=0]"
			[Register ("getOffset", "()Lcom/github/mikephil/charting/utils/MPPointF;", "GetGetOffsetHandler")]
			get {
				const string __id = "getOffset.()Lcom/github/mikephil/charting/utils/MPPointF;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='MarkerImage']/method[@name='setOffset' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.utils.MPPointF']]"
			[Register ("setOffset", "(Lcom/github/mikephil/charting/utils/MPPointF;)V", "GetSetOffset_Lcom_github_mikephil_charting_utils_MPPointF_Handler")]
			set {
				const string __id = "setOffset.(Lcom/github/mikephil/charting/utils/MPPointF;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSize);
			return cb_getSize;
		}

		static IntPtr n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.MarkerImage __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.MarkerImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Size);
		}
#pragma warning restore 0169

		static Delegate cb_setSize_Lcom_github_mikephil_charting_utils_FSize_;
#pragma warning disable 0169
		static Delegate GetSetSize_Lcom_github_mikephil_charting_utils_FSize_Handler ()
		{
			if (cb_setSize_Lcom_github_mikephil_charting_utils_FSize_ == null)
				cb_setSize_Lcom_github_mikephil_charting_utils_FSize_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetSize_Lcom_github_mikephil_charting_utils_FSize_);
			return cb_setSize_Lcom_github_mikephil_charting_utils_FSize_;
		}

		static void n_SetSize_Lcom_github_mikephil_charting_utils_FSize_ (IntPtr jnienv, IntPtr native__this, IntPtr native_size)
		{
			global::MikePhil.Charting.Components.MarkerImage __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.MarkerImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Util.FSize size = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.FSize> (native_size, JniHandleOwnership.DoNotTransfer);
			__this.Size = size;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Util.FSize Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='MarkerImage']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()Lcom/github/mikephil/charting/utils/FSize;", "GetGetSizeHandler")]
			get {
				const string __id = "getSize.()Lcom/github/mikephil/charting/utils/FSize;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.FSize> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='MarkerImage']/method[@name='setSize' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.utils.FSize']]"
			[Register ("setSize", "(Lcom/github/mikephil/charting/utils/FSize;)V", "GetSetSize_Lcom_github_mikephil_charting_utils_FSize_Handler")]
			set {
				const string __id = "setSize.(Lcom/github/mikephil/charting/utils/FSize;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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

		static void n_Draw_Landroid_graphics_Canvas_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas, float posX, float posY)
		{
			global::MikePhil.Charting.Components.MarkerImage __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.MarkerImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			__this.Draw (canvas, posX, posY);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='MarkerImage']/method[@name='draw' and count(parameter)=3 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("draw", "(Landroid/graphics/Canvas;FF)V", "GetDraw_Landroid_graphics_Canvas_FFHandler")]
		public virtual unsafe void Draw (global::Android.Graphics.Canvas canvas, float posX, float posY)
		{
			const string __id = "draw.(Landroid/graphics/Canvas;FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				__args [1] = new JniArgumentValue (posX);
				__args [2] = new JniArgumentValue (posY);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getOffsetForDrawingAtPoint_FF;
#pragma warning disable 0169
		static Delegate GetGetOffsetForDrawingAtPoint_FFHandler ()
		{
			if (cb_getOffsetForDrawingAtPoint_FF == null)
				cb_getOffsetForDrawingAtPoint_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_GetOffsetForDrawingAtPoint_FF);
			return cb_getOffsetForDrawingAtPoint_FF;
		}

		static IntPtr n_GetOffsetForDrawingAtPoint_FF (IntPtr jnienv, IntPtr native__this, float posX, float posY)
		{
			global::MikePhil.Charting.Components.MarkerImage __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.MarkerImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetOffsetForDrawingAtPoint (posX, posY));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='MarkerImage']/method[@name='getOffsetForDrawingAtPoint' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("getOffsetForDrawingAtPoint", "(FF)Lcom/github/mikephil/charting/utils/MPPointF;", "GetGetOffsetForDrawingAtPoint_FFHandler")]
		public virtual unsafe global::MikePhil.Charting.Util.MPPointF GetOffsetForDrawingAtPoint (float posX, float posY)
		{
			const string __id = "getOffsetForDrawingAtPoint.(FF)Lcom/github/mikephil/charting/utils/MPPointF;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (posX);
				__args [1] = new JniArgumentValue (posY);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_refreshContent_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_;
#pragma warning disable 0169
		static Delegate GetRefreshContent_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_Handler ()
		{
			if (cb_refreshContent_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_ == null)
				cb_refreshContent_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_RefreshContent_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_);
			return cb_refreshContent_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_;
		}

		static void n_RefreshContent_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_highlight)
		{
			global::MikePhil.Charting.Components.MarkerImage __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.MarkerImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.Entry e = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.Entry> (native_e, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Highlight.Highlight highlight = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (native_highlight, JniHandleOwnership.DoNotTransfer);
			__this.RefreshContent (e, highlight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='MarkerImage']/method[@name='refreshContent' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.data.Entry'] and parameter[2][@type='com.github.mikephil.charting.highlight.Highlight']]"
		[Register ("refreshContent", "(Lcom/github/mikephil/charting/data/Entry;Lcom/github/mikephil/charting/highlight/Highlight;)V", "GetRefreshContent_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_highlight_Highlight_Handler")]
		public virtual unsafe void RefreshContent (global::MikePhil.Charting.Data.Entry e, global::MikePhil.Charting.Highlight.Highlight highlight)
		{
			const string __id = "refreshContent.(Lcom/github/mikephil/charting/data/Entry;Lcom/github/mikephil/charting/highlight/Highlight;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				__args [1] = new JniArgumentValue ((highlight == null) ? IntPtr.Zero : ((global::Java.Lang.Object) highlight).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOffset_FF;
#pragma warning disable 0169
		static Delegate GetSetOffset_FFHandler ()
		{
			if (cb_setOffset_FF == null)
				cb_setOffset_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_SetOffset_FF);
			return cb_setOffset_FF;
		}

		static void n_SetOffset_FF (IntPtr jnienv, IntPtr native__this, float offsetX, float offsetY)
		{
			global::MikePhil.Charting.Components.MarkerImage __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.MarkerImage> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetOffset (offsetX, offsetY);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='MarkerImage']/method[@name='setOffset' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setOffset", "(FF)V", "GetSetOffset_FFHandler")]
		public virtual unsafe void SetOffset (float offsetX, float offsetY)
		{
			const string __id = "setOffset.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (offsetX);
				__args [1] = new JniArgumentValue (offsetY);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
