using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LegendRenderer']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/renderer/LegendRenderer", DoNotGenerateAcw=true)]
	public partial class LegendRenderer : global::MikePhil.Charting.Renderer.Renderer {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LegendRenderer']/field[@name='computedEntries']"
		[Register ("computedEntries")]
		protected global::System.Collections.IList ComputedEntries {
			get {
				const string __id = "computedEntries.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "computedEntries.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LegendRenderer']/field[@name='legendFontMetrics']"
		[Register ("legendFontMetrics")]
		protected global::Android.Graphics.Paint.FontMetrics LegendFontMetrics {
			get {
				const string __id = "legendFontMetrics.Landroid/graphics/Paint$FontMetrics;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.FontMetrics> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "legendFontMetrics.Landroid/graphics/Paint$FontMetrics;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LegendRenderer']/field[@name='mLegend']"
		[Register ("mLegend")]
		protected global::MikePhil.Charting.Components.Legend MLegend {
			get {
				const string __id = "mLegend.Lcom/github/mikephil/charting/components/Legend;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mLegend.Lcom/github/mikephil/charting/components/Legend;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LegendRenderer']/field[@name='mLegendFormPaint']"
		[Register ("mLegendFormPaint")]
		protected global::Android.Graphics.Paint MLegendFormPaint {
			get {
				const string __id = "mLegendFormPaint.Landroid/graphics/Paint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mLegendFormPaint.Landroid/graphics/Paint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LegendRenderer']/field[@name='mLegendLabelPaint']"
		[Register ("mLegendLabelPaint")]
		protected global::Android.Graphics.Paint MLegendLabelPaint {
			get {
				const string __id = "mLegendLabelPaint.Landroid/graphics/Paint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mLegendLabelPaint.Landroid/graphics/Paint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/renderer/LegendRenderer", typeof (LegendRenderer));

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

		protected LegendRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LegendRenderer']/constructor[@name='LegendRenderer' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.utils.ViewPortHandler'] and parameter[2][@type='com.github.mikephil.charting.components.Legend']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/utils/ViewPortHandler;Lcom/github/mikephil/charting/components/Legend;)V", "")]
		public unsafe LegendRenderer (global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler, global::MikePhil.Charting.Components.Legend legend) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/utils/ViewPortHandler;Lcom/github/mikephil/charting/components/Legend;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((viewPortHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPortHandler).Handle);
				__args [1] = new JniArgumentValue ((legend == null) ? IntPtr.Zero : ((global::Java.Lang.Object) legend).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (viewPortHandler);
				global::System.GC.KeepAlive (legend);
			}
		}

		static Delegate cb_getFormPaint;
#pragma warning disable 0169
		static Delegate GetGetFormPaintHandler ()
		{
			if (cb_getFormPaint == null)
				cb_getFormPaint = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetFormPaint);
			return cb_getFormPaint;
		}

		static IntPtr n_GetFormPaint (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LegendRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FormPaint);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Paint FormPaint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LegendRenderer']/method[@name='getFormPaint' and count(parameter)=0]"
			[Register ("getFormPaint", "()Landroid/graphics/Paint;", "GetGetFormPaintHandler")]
			get {
				const string __id = "getFormPaint.()Landroid/graphics/Paint;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLabelPaint;
#pragma warning disable 0169
		static Delegate GetGetLabelPaintHandler ()
		{
			if (cb_getLabelPaint == null)
				cb_getLabelPaint = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLabelPaint);
			return cb_getLabelPaint;
		}

		static IntPtr n_GetLabelPaint (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LegendRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LabelPaint);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Paint LabelPaint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LegendRenderer']/method[@name='getLabelPaint' and count(parameter)=0]"
			[Register ("getLabelPaint", "()Landroid/graphics/Paint;", "GetGetLabelPaintHandler")]
			get {
				const string __id = "getLabelPaint.()Landroid/graphics/Paint;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_computeLegend_Lcom_github_mikephil_charting_data_ChartData_;
#pragma warning disable 0169
		static Delegate GetComputeLegend_Lcom_github_mikephil_charting_data_ChartData_Handler ()
		{
			if (cb_computeLegend_Lcom_github_mikephil_charting_data_ChartData_ == null)
				cb_computeLegend_Lcom_github_mikephil_charting_data_ChartData_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_ComputeLegend_Lcom_github_mikephil_charting_data_ChartData_);
			return cb_computeLegend_Lcom_github_mikephil_charting_data_ChartData_;
		}

		static void n_ComputeLegend_Lcom_github_mikephil_charting_data_ChartData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LegendRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var data = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.ComputeLegend (data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LegendRenderer']/method[@name='computeLegend' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.ChartData&lt;?&gt;']]"
		[Register ("computeLegend", "(Lcom/github/mikephil/charting/data/ChartData;)V", "GetComputeLegend_Lcom_github_mikephil_charting_data_ChartData_Handler")]
		public virtual unsafe void ComputeLegend (global::MikePhil.Charting.Data.ChartData data)
		{
			const string __id = "computeLegend.(Lcom/github/mikephil/charting/data/ChartData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (data);
			}
		}

		static Delegate cb_drawForm_Landroid_graphics_Canvas_FFLcom_github_mikephil_charting_components_LegendEntry_Lcom_github_mikephil_charting_components_Legend_;
#pragma warning disable 0169
		static Delegate GetDrawForm_Landroid_graphics_Canvas_FFLcom_github_mikephil_charting_components_LegendEntry_Lcom_github_mikephil_charting_components_Legend_Handler ()
		{
			if (cb_drawForm_Landroid_graphics_Canvas_FFLcom_github_mikephil_charting_components_LegendEntry_Lcom_github_mikephil_charting_components_Legend_ == null)
				cb_drawForm_Landroid_graphics_Canvas_FFLcom_github_mikephil_charting_components_LegendEntry_Lcom_github_mikephil_charting_components_Legend_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLFFLL_V) n_DrawForm_Landroid_graphics_Canvas_FFLcom_github_mikephil_charting_components_LegendEntry_Lcom_github_mikephil_charting_components_Legend_);
			return cb_drawForm_Landroid_graphics_Canvas_FFLcom_github_mikephil_charting_components_LegendEntry_Lcom_github_mikephil_charting_components_Legend_;
		}

		static void n_DrawForm_Landroid_graphics_Canvas_FFLcom_github_mikephil_charting_components_LegendEntry_Lcom_github_mikephil_charting_components_Legend_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c, float x, float y, IntPtr native_entry, IntPtr native_legend)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LegendRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			var entry = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LegendEntry> (native_entry, JniHandleOwnership.DoNotTransfer);
			var legend = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (native_legend, JniHandleOwnership.DoNotTransfer);
			__this.DrawForm (c, x, y, entry, legend);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LegendRenderer']/method[@name='drawForm' and count(parameter)=5 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='com.github.mikephil.charting.components.LegendEntry'] and parameter[5][@type='com.github.mikephil.charting.components.Legend']]"
		[Register ("drawForm", "(Landroid/graphics/Canvas;FFLcom/github/mikephil/charting/components/LegendEntry;Lcom/github/mikephil/charting/components/Legend;)V", "GetDrawForm_Landroid_graphics_Canvas_FFLcom_github_mikephil_charting_components_LegendEntry_Lcom_github_mikephil_charting_components_Legend_Handler")]
		protected virtual unsafe void DrawForm (global::Android.Graphics.Canvas c, float x, float y, global::MikePhil.Charting.Components.LegendEntry entry, global::MikePhil.Charting.Components.Legend legend)
		{
			const string __id = "drawForm.(Landroid/graphics/Canvas;FFLcom/github/mikephil/charting/components/LegendEntry;Lcom/github/mikephil/charting/components/Legend;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue (x);
				__args [2] = new JniArgumentValue (y);
				__args [3] = new JniArgumentValue ((entry == null) ? IntPtr.Zero : ((global::Java.Lang.Object) entry).Handle);
				__args [4] = new JniArgumentValue ((legend == null) ? IntPtr.Zero : ((global::Java.Lang.Object) legend).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (c);
				global::System.GC.KeepAlive (entry);
				global::System.GC.KeepAlive (legend);
			}
		}

		static Delegate cb_drawLabel_Landroid_graphics_Canvas_FFLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetDrawLabel_Landroid_graphics_Canvas_FFLjava_lang_String_Handler ()
		{
			if (cb_drawLabel_Landroid_graphics_Canvas_FFLjava_lang_String_ == null)
				cb_drawLabel_Landroid_graphics_Canvas_FFLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLFFL_V) n_DrawLabel_Landroid_graphics_Canvas_FFLjava_lang_String_);
			return cb_drawLabel_Landroid_graphics_Canvas_FFLjava_lang_String_;
		}

		static void n_DrawLabel_Landroid_graphics_Canvas_FFLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c, float x, float y, IntPtr native_label)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LegendRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			var label = JNIEnv.GetString (native_label, JniHandleOwnership.DoNotTransfer);
			__this.DrawLabel (c, x, y, label);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LegendRenderer']/method[@name='drawLabel' and count(parameter)=4 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='java.lang.String']]"
		[Register ("drawLabel", "(Landroid/graphics/Canvas;FFLjava/lang/String;)V", "GetDrawLabel_Landroid_graphics_Canvas_FFLjava_lang_String_Handler")]
		protected virtual unsafe void DrawLabel (global::Android.Graphics.Canvas c, float x, float y, string label)
		{
			const string __id = "drawLabel.(Landroid/graphics/Canvas;FFLjava/lang/String;)V";
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue (x);
				__args [2] = new JniArgumentValue (y);
				__args [3] = new JniArgumentValue (native_label);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_label);
				global::System.GC.KeepAlive (c);
			}
		}

		static Delegate cb_renderLegend_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetRenderLegend_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_renderLegend_Landroid_graphics_Canvas_ == null)
				cb_renderLegend_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_RenderLegend_Landroid_graphics_Canvas_);
			return cb_renderLegend_Landroid_graphics_Canvas_;
		}

		static void n_RenderLegend_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LegendRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.RenderLegend (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='LegendRenderer']/method[@name='renderLegend' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("renderLegend", "(Landroid/graphics/Canvas;)V", "GetRenderLegend_Landroid_graphics_Canvas_Handler")]
		public virtual unsafe void RenderLegend (global::Android.Graphics.Canvas c)
		{
			const string __id = "renderLegend.(Landroid/graphics/Canvas;)V";
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
