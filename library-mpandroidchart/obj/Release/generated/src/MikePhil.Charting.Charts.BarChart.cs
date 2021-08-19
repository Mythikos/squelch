using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Charts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarChart']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/charts/BarChart", DoNotGenerateAcw=true)]
	public partial class BarChart : global::MikePhil.Charting.Charts.BarLineChartBase, global::MikePhil.Charting.Interfaces.Dataprovider.IBarDataProvider {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarChart']/field[@name='mHighlightFullBarEnabled']"
		[Register ("mHighlightFullBarEnabled")]
		protected bool MHighlightFullBarEnabled {
			get {
				const string __id = "mHighlightFullBarEnabled.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mHighlightFullBarEnabled.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/charts/BarChart", typeof (BarChart));

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

		protected BarChart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarChart']/constructor[@name='BarChart' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BarChart (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarChart']/constructor[@name='BarChart' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe BarChart (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarChart']/constructor[@name='BarChart' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe BarChart (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (context);
				global::System.GC.KeepAlive (attrs);
			}
		}

		static Delegate cb_getBarData;
#pragma warning disable 0169
		static Delegate GetGetBarDataHandler ()
		{
			if (cb_getBarData == null)
				cb_getBarData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBarData);
			return cb_getBarData;
		}

		static IntPtr n_GetBarData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BarData);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Data.BarData BarData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarChart']/method[@name='getBarData' and count(parameter)=0]"
			[Register ("getBarData", "()Lcom/github/mikephil/charting/data/BarData;", "GetGetBarDataHandler")]
			get {
				const string __id = "getBarData.()Lcom/github/mikephil/charting/data/BarData;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isDrawBarShadowEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawBarShadowEnabledHandler ()
		{
			if (cb_isDrawBarShadowEnabled == null)
				cb_isDrawBarShadowEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDrawBarShadowEnabled);
			return cb_isDrawBarShadowEnabled;
		}

		static bool n_IsDrawBarShadowEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawBarShadowEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrawBarShadowEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarChart']/method[@name='isDrawBarShadowEnabled' and count(parameter)=0]"
			[Register ("isDrawBarShadowEnabled", "()Z", "GetIsDrawBarShadowEnabledHandler")]
			get {
				const string __id = "isDrawBarShadowEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDrawValueAboveBarEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawValueAboveBarEnabledHandler ()
		{
			if (cb_isDrawValueAboveBarEnabled == null)
				cb_isDrawValueAboveBarEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDrawValueAboveBarEnabled);
			return cb_isDrawValueAboveBarEnabled;
		}

		static bool n_IsDrawValueAboveBarEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawValueAboveBarEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrawValueAboveBarEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarChart']/method[@name='isDrawValueAboveBarEnabled' and count(parameter)=0]"
			[Register ("isDrawValueAboveBarEnabled", "()Z", "GetIsDrawValueAboveBarEnabledHandler")]
			get {
				const string __id = "isDrawValueAboveBarEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isHighlightFullBarEnabled;
#pragma warning disable 0169
		static Delegate GetIsHighlightFullBarEnabledHandler ()
		{
			if (cb_isHighlightFullBarEnabled == null)
				cb_isHighlightFullBarEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsHighlightFullBarEnabled);
			return cb_isHighlightFullBarEnabled;
		}

		static bool n_IsHighlightFullBarEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHighlightFullBarEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsHighlightFullBarEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarChart']/method[@name='isHighlightFullBarEnabled' and count(parameter)=0]"
			[Register ("isHighlightFullBarEnabled", "()Z", "GetIsHighlightFullBarEnabledHandler")]
			get {
				const string __id = "isHighlightFullBarEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getBarBounds_Lcom_github_mikephil_charting_data_BarEntry_;
#pragma warning disable 0169
		static Delegate GetGetBarBounds_Lcom_github_mikephil_charting_data_BarEntry_Handler ()
		{
			if (cb_getBarBounds_Lcom_github_mikephil_charting_data_BarEntry_ == null)
				cb_getBarBounds_Lcom_github_mikephil_charting_data_BarEntry_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetBarBounds_Lcom_github_mikephil_charting_data_BarEntry_);
			return cb_getBarBounds_Lcom_github_mikephil_charting_data_BarEntry_;
		}

		static IntPtr n_GetBarBounds_Lcom_github_mikephil_charting_data_BarEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarEntry> (native_e, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetBarBounds (e));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarChart']/method[@name='getBarBounds' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.BarEntry']]"
		[Register ("getBarBounds", "(Lcom/github/mikephil/charting/data/BarEntry;)Landroid/graphics/RectF;", "GetGetBarBounds_Lcom_github_mikephil_charting_data_BarEntry_Handler")]
		public virtual unsafe global::Android.Graphics.RectF GetBarBounds (global::MikePhil.Charting.Data.BarEntry e)
		{
			const string __id = "getBarBounds.(Lcom/github/mikephil/charting/data/BarEntry;)Landroid/graphics/RectF;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (e);
			}
		}

		static Delegate cb_getBarBounds_Lcom_github_mikephil_charting_data_BarEntry_Landroid_graphics_RectF_;
#pragma warning disable 0169
		static Delegate GetGetBarBounds_Lcom_github_mikephil_charting_data_BarEntry_Landroid_graphics_RectF_Handler ()
		{
			if (cb_getBarBounds_Lcom_github_mikephil_charting_data_BarEntry_Landroid_graphics_RectF_ == null)
				cb_getBarBounds_Lcom_github_mikephil_charting_data_BarEntry_Landroid_graphics_RectF_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_GetBarBounds_Lcom_github_mikephil_charting_data_BarEntry_Landroid_graphics_RectF_);
			return cb_getBarBounds_Lcom_github_mikephil_charting_data_BarEntry_Landroid_graphics_RectF_;
		}

		static void n_GetBarBounds_Lcom_github_mikephil_charting_data_BarEntry_Landroid_graphics_RectF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_outputRect)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarEntry> (native_e, JniHandleOwnership.DoNotTransfer);
			var outputRect = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_outputRect, JniHandleOwnership.DoNotTransfer);
			__this.GetBarBounds (e, outputRect);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarChart']/method[@name='getBarBounds' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.data.BarEntry'] and parameter[2][@type='android.graphics.RectF']]"
		[Register ("getBarBounds", "(Lcom/github/mikephil/charting/data/BarEntry;Landroid/graphics/RectF;)V", "GetGetBarBounds_Lcom_github_mikephil_charting_data_BarEntry_Landroid_graphics_RectF_Handler")]
		public virtual unsafe void GetBarBounds (global::MikePhil.Charting.Data.BarEntry e, global::Android.Graphics.RectF outputRect)
		{
			const string __id = "getBarBounds.(Lcom/github/mikephil/charting/data/BarEntry;Landroid/graphics/RectF;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				__args [1] = new JniArgumentValue ((outputRect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputRect).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (e);
				global::System.GC.KeepAlive (outputRect);
			}
		}

		static Delegate cb_groupBars_FFF;
#pragma warning disable 0169
		static Delegate GetGroupBars_FFFHandler ()
		{
			if (cb_groupBars_FFF == null)
				cb_groupBars_FFF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFFF_V) n_GroupBars_FFF);
			return cb_groupBars_FFF;
		}

		static void n_GroupBars_FFF (IntPtr jnienv, IntPtr native__this, float fromX, float groupSpace, float barSpace)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GroupBars (fromX, groupSpace, barSpace);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarChart']/method[@name='groupBars' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("groupBars", "(FFF)V", "GetGroupBars_FFFHandler")]
		public virtual unsafe void GroupBars (float fromX, float groupSpace, float barSpace)
		{
			const string __id = "groupBars.(FFF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (fromX);
				__args [1] = new JniArgumentValue (groupSpace);
				__args [2] = new JniArgumentValue (barSpace);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_highlightValue_FII;
#pragma warning disable 0169
		static Delegate GetHighlightValue_FIIHandler ()
		{
			if (cb_highlightValue_FII == null)
				cb_highlightValue_FII = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFII_V) n_HighlightValue_FII);
			return cb_highlightValue_FII;
		}

		static void n_HighlightValue_FII (IntPtr jnienv, IntPtr native__this, float x, int dataSetIndex, int stackIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighlightValue (x, dataSetIndex, stackIndex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarChart']/method[@name='highlightValue' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("highlightValue", "(FII)V", "GetHighlightValue_FIIHandler")]
		public virtual unsafe void HighlightValue (float x, int dataSetIndex, int stackIndex)
		{
			const string __id = "highlightValue.(FII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (dataSetIndex);
				__args [2] = new JniArgumentValue (stackIndex);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawBarShadow_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawBarShadow_ZHandler ()
		{
			if (cb_setDrawBarShadow_Z == null)
				cb_setDrawBarShadow_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetDrawBarShadow_Z);
			return cb_setDrawBarShadow_Z;
		}

		static void n_SetDrawBarShadow_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawBarShadow (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarChart']/method[@name='setDrawBarShadow' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawBarShadow", "(Z)V", "GetSetDrawBarShadow_ZHandler")]
		public virtual unsafe void SetDrawBarShadow (bool enabled)
		{
			const string __id = "setDrawBarShadow.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawValueAboveBar_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawValueAboveBar_ZHandler ()
		{
			if (cb_setDrawValueAboveBar_Z == null)
				cb_setDrawValueAboveBar_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetDrawValueAboveBar_Z);
			return cb_setDrawValueAboveBar_Z;
		}

		static void n_SetDrawValueAboveBar_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawValueAboveBar (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarChart']/method[@name='setDrawValueAboveBar' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawValueAboveBar", "(Z)V", "GetSetDrawValueAboveBar_ZHandler")]
		public virtual unsafe void SetDrawValueAboveBar (bool enabled)
		{
			const string __id = "setDrawValueAboveBar.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setFitBars_Z;
#pragma warning disable 0169
		static Delegate GetSetFitBars_ZHandler ()
		{
			if (cb_setFitBars_Z == null)
				cb_setFitBars_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetFitBars_Z);
			return cb_setFitBars_Z;
		}

		static void n_SetFitBars_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetFitBars (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarChart']/method[@name='setFitBars' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setFitBars", "(Z)V", "GetSetFitBars_ZHandler")]
		public virtual unsafe void SetFitBars (bool enabled)
		{
			const string __id = "setFitBars.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setHighlightFullBarEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetHighlightFullBarEnabled_ZHandler ()
		{
			if (cb_setHighlightFullBarEnabled_Z == null)
				cb_setHighlightFullBarEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetHighlightFullBarEnabled_Z);
			return cb_setHighlightFullBarEnabled_Z;
		}

		static void n_SetHighlightFullBarEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHighlightFullBarEnabled (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarChart']/method[@name='setHighlightFullBarEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setHighlightFullBarEnabled", "(Z)V", "GetSetHighlightFullBarEnabled_ZHandler")]
		public virtual unsafe void SetHighlightFullBarEnabled (bool enabled)
		{
			const string __id = "setHighlightFullBarEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
