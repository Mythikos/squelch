using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/renderer/DataRenderer", DoNotGenerateAcw=true)]
	public abstract partial class DataRenderer : global::MikePhil.Charting.Renderer.Renderer {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/field[@name='mAnimator']"
		[Register ("mAnimator")]
		protected global::MikePhil.Charting.Animation.ChartAnimator MAnimator {
			get {
				const string __id = "mAnimator.Lcom/github/mikephil/charting/animation/ChartAnimator;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.ChartAnimator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAnimator.Lcom/github/mikephil/charting/animation/ChartAnimator;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/field[@name='mDrawPaint']"
		[Register ("mDrawPaint")]
		protected global::Android.Graphics.Paint MDrawPaint {
			get {
				const string __id = "mDrawPaint.Landroid/graphics/Paint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDrawPaint.Landroid/graphics/Paint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/field[@name='mHighlightPaint']"
		[Register ("mHighlightPaint")]
		protected global::Android.Graphics.Paint MHighlightPaint {
			get {
				const string __id = "mHighlightPaint.Landroid/graphics/Paint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mHighlightPaint.Landroid/graphics/Paint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/field[@name='mRenderPaint']"
		[Register ("mRenderPaint")]
		protected global::Android.Graphics.Paint MRenderPaint {
			get {
				const string __id = "mRenderPaint.Landroid/graphics/Paint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mRenderPaint.Landroid/graphics/Paint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/field[@name='mValuePaint']"
		[Register ("mValuePaint")]
		protected global::Android.Graphics.Paint MValuePaint {
			get {
				const string __id = "mValuePaint.Landroid/graphics/Paint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mValuePaint.Landroid/graphics/Paint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/renderer/DataRenderer", typeof (DataRenderer));

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

		protected DataRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/constructor[@name='DataRenderer' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.animation.ChartAnimator'] and parameter[2][@type='com.github.mikephil.charting.utils.ViewPortHandler']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/animation/ChartAnimator;Lcom/github/mikephil/charting/utils/ViewPortHandler;)V", "")]
		public unsafe DataRenderer (global::MikePhil.Charting.Animation.ChartAnimator animator, global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
				global::System.GC.KeepAlive (animator);
				global::System.GC.KeepAlive (viewPortHandler);
			}
		}

		static Delegate cb_getPaintHighlight;
#pragma warning disable 0169
		static Delegate GetGetPaintHighlightHandler ()
		{
			if (cb_getPaintHighlight == null)
				cb_getPaintHighlight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPaintHighlight);
			return cb_getPaintHighlight;
		}

		static IntPtr n_GetPaintHighlight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.DataRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PaintHighlight);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Paint PaintHighlight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/method[@name='getPaintHighlight' and count(parameter)=0]"
			[Register ("getPaintHighlight", "()Landroid/graphics/Paint;", "GetGetPaintHighlightHandler")]
			get {
				const string __id = "getPaintHighlight.()Landroid/graphics/Paint;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPaintRender;
#pragma warning disable 0169
		static Delegate GetGetPaintRenderHandler ()
		{
			if (cb_getPaintRender == null)
				cb_getPaintRender = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPaintRender);
			return cb_getPaintRender;
		}

		static IntPtr n_GetPaintRender (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.DataRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PaintRender);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Paint PaintRender {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/method[@name='getPaintRender' and count(parameter)=0]"
			[Register ("getPaintRender", "()Landroid/graphics/Paint;", "GetGetPaintRenderHandler")]
			get {
				const string __id = "getPaintRender.()Landroid/graphics/Paint;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPaintValues;
#pragma warning disable 0169
		static Delegate GetGetPaintValuesHandler ()
		{
			if (cb_getPaintValues == null)
				cb_getPaintValues = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPaintValues);
			return cb_getPaintValues;
		}

		static IntPtr n_GetPaintValues (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.DataRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PaintValues);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Paint PaintValues {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/method[@name='getPaintValues' and count(parameter)=0]"
			[Register ("getPaintValues", "()Landroid/graphics/Paint;", "GetGetPaintValuesHandler")]
			get {
				const string __id = "getPaintValues.()Landroid/graphics/Paint;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_applyValueTextStyle_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_;
#pragma warning disable 0169
		static Delegate GetApplyValueTextStyle_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_Handler ()
		{
			if (cb_applyValueTextStyle_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ == null)
				cb_applyValueTextStyle_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ApplyValueTextStyle_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_);
			return cb_applyValueTextStyle_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_;
		}

		static void n_ApplyValueTextStyle_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_set)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.DataRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var set = (global::MikePhil.Charting.Interfaces.Datasets.IDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (native_set, JniHandleOwnership.DoNotTransfer);
			__this.ApplyValueTextStyle (set);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/method[@name='applyValueTextStyle' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.interfaces.datasets.IDataSet']]"
		[Register ("applyValueTextStyle", "(Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;)V", "GetApplyValueTextStyle_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_Handler")]
		protected virtual unsafe void ApplyValueTextStyle (global::MikePhil.Charting.Interfaces.Datasets.IDataSet set)
		{
			const string __id = "applyValueTextStyle.(Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((set == null) ? IntPtr.Zero : ((global::Java.Lang.Object) set).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (set);
			}
		}

		static Delegate cb_drawData_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDrawData_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_drawData_Landroid_graphics_Canvas_ == null)
				cb_drawData_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DrawData_Landroid_graphics_Canvas_);
			return cb_drawData_Landroid_graphics_Canvas_;
		}

		static void n_DrawData_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.DataRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DrawData (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/method[@name='drawData' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawData", "(Landroid/graphics/Canvas;)V", "GetDrawData_Landroid_graphics_Canvas_Handler")]
		public abstract void DrawData (global::Android.Graphics.Canvas p0);

		static Delegate cb_drawExtras_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDrawExtras_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_drawExtras_Landroid_graphics_Canvas_ == null)
				cb_drawExtras_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DrawExtras_Landroid_graphics_Canvas_);
			return cb_drawExtras_Landroid_graphics_Canvas_;
		}

		static void n_DrawExtras_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.DataRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DrawExtras (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/method[@name='drawExtras' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawExtras", "(Landroid/graphics/Canvas;)V", "GetDrawExtras_Landroid_graphics_Canvas_Handler")]
		public abstract void DrawExtras (global::Android.Graphics.Canvas p0);

		static Delegate cb_drawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_;
#pragma warning disable 0169
		static Delegate GetDrawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_Handler ()
		{
			if (cb_drawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_ == null)
				cb_drawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_DrawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_);
			return cb_drawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_;
		}

		static void n_DrawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.DataRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = (global::MikePhil.Charting.Highlight.Highlight[]) JNIEnv.GetArray (native_p1, JniHandleOwnership.DoNotTransfer, typeof (global::MikePhil.Charting.Highlight.Highlight));
			__this.DrawHighlighted (p0, p1);
			if (p1 != null)
				JNIEnv.CopyArray (p1, native_p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/method[@name='drawHighlighted' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.github.mikephil.charting.highlight.Highlight[]']]"
		[Register ("drawHighlighted", "(Landroid/graphics/Canvas;[Lcom/github/mikephil/charting/highlight/Highlight;)V", "GetDrawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_Handler")]
		public abstract void DrawHighlighted (global::Android.Graphics.Canvas p0, global::MikePhil.Charting.Highlight.Highlight[] p1);

		static Delegate cb_drawValue_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_formatter_IValueFormatter_FLcom_github_mikephil_charting_data_Entry_IFFI;
#pragma warning disable 0169
		static Delegate GetDrawValue_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_formatter_IValueFormatter_FLcom_github_mikephil_charting_data_Entry_IFFIHandler ()
		{
			if (cb_drawValue_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_formatter_IValueFormatter_FLcom_github_mikephil_charting_data_Entry_IFFI == null)
				cb_drawValue_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_formatter_IValueFormatter_FLcom_github_mikephil_charting_data_Entry_IFFI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLFLIFFI_V) n_DrawValue_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_formatter_IValueFormatter_FLcom_github_mikephil_charting_data_Entry_IFFI);
			return cb_drawValue_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_formatter_IValueFormatter_FLcom_github_mikephil_charting_data_Entry_IFFI;
		}

		static void n_DrawValue_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_formatter_IValueFormatter_FLcom_github_mikephil_charting_data_Entry_IFFI (IntPtr jnienv, IntPtr native__this, IntPtr native_c, IntPtr native_formatter, float value, IntPtr native_entry, int dataSetIndex, float x, float y, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.DataRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			var formatter = (global::MikePhil.Charting.Formatter.IValueFormatter)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IValueFormatter> (native_formatter, JniHandleOwnership.DoNotTransfer);
			var entry = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.Entry> (native_entry, JniHandleOwnership.DoNotTransfer);
			__this.DrawValue (c, formatter, value, entry, dataSetIndex, x, y, color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/method[@name='drawValue' and count(parameter)=8 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.github.mikephil.charting.formatter.IValueFormatter'] and parameter[3][@type='float'] and parameter[4][@type='com.github.mikephil.charting.data.Entry'] and parameter[5][@type='int'] and parameter[6][@type='float'] and parameter[7][@type='float'] and parameter[8][@type='int']]"
		[Register ("drawValue", "(Landroid/graphics/Canvas;Lcom/github/mikephil/charting/formatter/IValueFormatter;FLcom/github/mikephil/charting/data/Entry;IFFI)V", "GetDrawValue_Landroid_graphics_Canvas_Lcom_github_mikephil_charting_formatter_IValueFormatter_FLcom_github_mikephil_charting_data_Entry_IFFIHandler")]
		public virtual unsafe void DrawValue (global::Android.Graphics.Canvas c, global::MikePhil.Charting.Formatter.IValueFormatter formatter, float value, global::MikePhil.Charting.Data.Entry entry, int dataSetIndex, float x, float y, int color)
		{
			const string __id = "drawValue.(Landroid/graphics/Canvas;Lcom/github/mikephil/charting/formatter/IValueFormatter;FLcom/github/mikephil/charting/data/Entry;IFFI)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue ((formatter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) formatter).Handle);
				__args [2] = new JniArgumentValue (value);
				__args [3] = new JniArgumentValue ((entry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) entry).Handle);
				__args [4] = new JniArgumentValue (dataSetIndex);
				__args [5] = new JniArgumentValue (x);
				__args [6] = new JniArgumentValue (y);
				__args [7] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
				global::System.GC.KeepAlive (formatter);
				global::System.GC.KeepAlive (entry);
			}
		}

		static Delegate cb_drawValues_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDrawValues_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_drawValues_Landroid_graphics_Canvas_ == null)
				cb_drawValues_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_DrawValues_Landroid_graphics_Canvas_);
			return cb_drawValues_Landroid_graphics_Canvas_;
		}

		static void n_DrawValues_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.DataRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DrawValues (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/method[@name='drawValues' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawValues", "(Landroid/graphics/Canvas;)V", "GetDrawValues_Landroid_graphics_Canvas_Handler")]
		public abstract void DrawValues (global::Android.Graphics.Canvas p0);

		static Delegate cb_initBuffers;
#pragma warning disable 0169
		static Delegate GetInitBuffersHandler ()
		{
			if (cb_initBuffers == null)
				cb_initBuffers = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_InitBuffers);
			return cb_initBuffers;
		}

		static void n_InitBuffers (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.DataRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.InitBuffers ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/method[@name='initBuffers' and count(parameter)=0]"
		[Register ("initBuffers", "()V", "GetInitBuffersHandler")]
		public abstract void InitBuffers ();

		static Delegate cb_isDrawingValuesAllowed_Lcom_github_mikephil_charting_interfaces_dataprovider_ChartInterface_;
#pragma warning disable 0169
		static Delegate GetIsDrawingValuesAllowed_Lcom_github_mikephil_charting_interfaces_dataprovider_ChartInterface_Handler ()
		{
			if (cb_isDrawingValuesAllowed_Lcom_github_mikephil_charting_interfaces_dataprovider_ChartInterface_ == null)
				cb_isDrawingValuesAllowed_Lcom_github_mikephil_charting_interfaces_dataprovider_ChartInterface_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsDrawingValuesAllowed_Lcom_github_mikephil_charting_interfaces_dataprovider_ChartInterface_);
			return cb_isDrawingValuesAllowed_Lcom_github_mikephil_charting_interfaces_dataprovider_ChartInterface_;
		}

		static bool n_IsDrawingValuesAllowed_Lcom_github_mikephil_charting_interfaces_dataprovider_ChartInterface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_chart)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.DataRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var chart = (global::MikePhil.Charting.Interfaces.Dataprovider.IChartInterface)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.IChartInterface> (native_chart, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsDrawingValuesAllowed (chart);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/method[@name='isDrawingValuesAllowed' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.interfaces.dataprovider.ChartInterface']]"
		[Register ("isDrawingValuesAllowed", "(Lcom/github/mikephil/charting/interfaces/dataprovider/ChartInterface;)Z", "GetIsDrawingValuesAllowed_Lcom_github_mikephil_charting_interfaces_dataprovider_ChartInterface_Handler")]
		protected virtual unsafe bool IsDrawingValuesAllowed (global::MikePhil.Charting.Interfaces.Dataprovider.IChartInterface chart)
		{
			const string __id = "isDrawingValuesAllowed.(Lcom/github/mikephil/charting/interfaces/dataprovider/ChartInterface;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((chart == null) ? IntPtr.Zero : ((global::Java.Lang.Object) chart).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (chart);
			}
		}

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/renderer/DataRenderer", DoNotGenerateAcw=true)]
	internal partial class DataRendererInvoker : DataRenderer {
		public DataRendererInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/renderer/DataRenderer", typeof (DataRendererInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
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
				global::System.GC.KeepAlive (p0);
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
				global::System.GC.KeepAlive (p0);
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
				global::System.GC.KeepAlive (p0);
				global::System.GC.KeepAlive (p1);
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
				global::System.GC.KeepAlive (p0);
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
