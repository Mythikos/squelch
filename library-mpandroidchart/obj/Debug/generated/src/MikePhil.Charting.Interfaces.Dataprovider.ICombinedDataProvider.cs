using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Interfaces.Dataprovider {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.dataprovider']/interface[@name='CombinedDataProvider']"
	[Register ("com/github/mikephil/charting/interfaces/dataprovider/CombinedDataProvider", "", "MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProviderInvoker")]
	public partial interface ICombinedDataProvider : global::MikePhil.Charting.Interfaces.Dataprovider.IBarDataProvider, global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider, global::MikePhil.Charting.Interfaces.Dataprovider.ICandleDataProvider, global::MikePhil.Charting.Interfaces.Dataprovider.ILineDataProvider, global::MikePhil.Charting.Interfaces.Dataprovider.IScatterDataProvider {
		global::MikePhil.Charting.Data.CombinedData CombinedData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.dataprovider']/interface[@name='CombinedDataProvider']/method[@name='getCombinedData' and count(parameter)=0]"
			[Register ("getCombinedData", "()Lcom/github/mikephil/charting/data/CombinedData;", "GetGetCombinedDataHandler:MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProviderInvoker, library-mpandroidchart")]
			get; 
		}

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/interfaces/dataprovider/CombinedDataProvider", DoNotGenerateAcw=true)]
	internal partial class ICombinedDataProviderInvoker : global::Java.Lang.Object, ICombinedDataProvider {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/interfaces/dataprovider/CombinedDataProvider", typeof (ICombinedDataProviderInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static ICombinedDataProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICombinedDataProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.github.mikephil.charting.interfaces.dataprovider.CombinedDataProvider'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICombinedDataProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCombinedData;
#pragma warning disable 0169
		static Delegate GetGetCombinedDataHandler ()
		{
			if (cb_getCombinedData == null)
				cb_getCombinedData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCombinedData);
			return cb_getCombinedData;
		}

		static IntPtr n_GetCombinedData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CombinedData);
		}
#pragma warning restore 0169

		IntPtr id_getCombinedData;
		public unsafe global::MikePhil.Charting.Data.CombinedData CombinedData {
			get {
				if (id_getCombinedData == IntPtr.Zero)
					id_getCombinedData = JNIEnv.GetMethodID (class_ref, "getCombinedData", "()Lcom/github/mikephil/charting/data/CombinedData;");
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CombinedData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCombinedData), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BarData);
		}
#pragma warning restore 0169

		IntPtr id_getBarData;
		public unsafe global::MikePhil.Charting.Data.BarData BarData {
			get {
				if (id_getBarData == IntPtr.Zero)
					id_getBarData = JNIEnv.GetMethodID (class_ref, "getBarData", "()Lcom/github/mikephil/charting/data/BarData;");
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBarData), JniHandleOwnership.TransferLocalRef);
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
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawBarShadowEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isDrawBarShadowEnabled;
		public unsafe bool IsDrawBarShadowEnabled {
			get {
				if (id_isDrawBarShadowEnabled == IntPtr.Zero)
					id_isDrawBarShadowEnabled = JNIEnv.GetMethodID (class_ref, "isDrawBarShadowEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDrawBarShadowEnabled);
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
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawValueAboveBarEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isDrawValueAboveBarEnabled;
		public unsafe bool IsDrawValueAboveBarEnabled {
			get {
				if (id_isDrawValueAboveBarEnabled == IntPtr.Zero)
					id_isDrawValueAboveBarEnabled = JNIEnv.GetMethodID (class_ref, "isDrawValueAboveBarEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDrawValueAboveBarEnabled);
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
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHighlightFullBarEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isHighlightFullBarEnabled;
		public unsafe bool IsHighlightFullBarEnabled {
			get {
				if (id_isHighlightFullBarEnabled == IntPtr.Zero)
					id_isHighlightFullBarEnabled = JNIEnv.GetMethodID (class_ref, "isHighlightFullBarEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHighlightFullBarEnabled);
			}
		}

		static Delegate cb_getHighestVisibleX;
#pragma warning disable 0169
		static Delegate GetGetHighestVisibleXHandler ()
		{
			if (cb_getHighestVisibleX == null)
				cb_getHighestVisibleX = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetHighestVisibleX);
			return cb_getHighestVisibleX;
		}

		static float n_GetHighestVisibleX (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighestVisibleX;
		}
#pragma warning restore 0169

		IntPtr id_getHighestVisibleX;
		public unsafe float HighestVisibleX {
			get {
				if (id_getHighestVisibleX == IntPtr.Zero)
					id_getHighestVisibleX = JNIEnv.GetMethodID (class_ref, "getHighestVisibleX", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getHighestVisibleX);
			}
		}

		static Delegate cb_getLowestVisibleX;
#pragma warning disable 0169
		static Delegate GetGetLowestVisibleXHandler ()
		{
			if (cb_getLowestVisibleX == null)
				cb_getLowestVisibleX = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetLowestVisibleX);
			return cb_getLowestVisibleX;
		}

		static float n_GetLowestVisibleX (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LowestVisibleX;
		}
#pragma warning restore 0169

		IntPtr id_getLowestVisibleX;
		public unsafe float LowestVisibleX {
			get {
				if (id_getLowestVisibleX == IntPtr.Zero)
					id_getLowestVisibleX = JNIEnv.GetMethodID (class_ref, "getLowestVisibleX", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getLowestVisibleX);
			}
		}

		static Delegate cb_getTransformer_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
#pragma warning disable 0169
		static Delegate GetGetTransformer_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler ()
		{
			if (cb_getTransformer_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ == null)
				cb_getTransformer_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetTransformer_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_getTransformer_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static IntPtr n_GetTransformer_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTransformer (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getTransformer_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		public unsafe global::MikePhil.Charting.Util.Transformer GetTransformer (global::MikePhil.Charting.Components.YAxis.AxisDependency p0)
		{
			if (id_getTransformer_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ == IntPtr.Zero)
				id_getTransformer_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNIEnv.GetMethodID (class_ref, "getTransformer", "(Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)Lcom/github/mikephil/charting/utils/Transformer;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransformer_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_isInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
#pragma warning disable 0169
		static Delegate GetIsInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler ()
		{
			if (cb_isInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ == null)
				cb_isInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_IsInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_isInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static bool n_IsInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsInverted (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_isInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		public unsafe bool IsInverted (global::MikePhil.Charting.Components.YAxis.AxisDependency p0)
		{
			if (id_isInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ == IntPtr.Zero)
				id_isInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNIEnv.GetMethodID (class_ref, "isInverted", "(Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_, __args);
			return __ret;
		}

		static Delegate cb_getCenterOfView;
#pragma warning disable 0169
		static Delegate GetGetCenterOfViewHandler ()
		{
			if (cb_getCenterOfView == null)
				cb_getCenterOfView = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCenterOfView);
			return cb_getCenterOfView;
		}

		static IntPtr n_GetCenterOfView (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CenterOfView);
		}
#pragma warning restore 0169

		IntPtr id_getCenterOfView;
		public unsafe global::MikePhil.Charting.Util.MPPointF CenterOfView {
			get {
				if (id_getCenterOfView == IntPtr.Zero)
					id_getCenterOfView = JNIEnv.GetMethodID (class_ref, "getCenterOfView", "()Lcom/github/mikephil/charting/utils/MPPointF;");
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCenterOfView), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCenterOffsets;
#pragma warning disable 0169
		static Delegate GetGetCenterOffsetsHandler ()
		{
			if (cb_getCenterOffsets == null)
				cb_getCenterOffsets = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCenterOffsets);
			return cb_getCenterOffsets;
		}

		static IntPtr n_GetCenterOffsets (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CenterOffsets);
		}
#pragma warning restore 0169

		IntPtr id_getCenterOffsets;
		public unsafe global::MikePhil.Charting.Util.MPPointF CenterOffsets {
			get {
				if (id_getCenterOffsets == IntPtr.Zero)
					id_getCenterOffsets = JNIEnv.GetMethodID (class_ref, "getCenterOffsets", "()Lcom/github/mikephil/charting/utils/MPPointF;");
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCenterOffsets), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getContentRect;
#pragma warning disable 0169
		static Delegate GetGetContentRectHandler ()
		{
			if (cb_getContentRect == null)
				cb_getContentRect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetContentRect);
			return cb_getContentRect;
		}

		static IntPtr n_GetContentRect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentRect);
		}
#pragma warning restore 0169

		IntPtr id_getContentRect;
		public unsafe global::Android.Graphics.RectF ContentRect {
			get {
				if (id_getContentRect == IntPtr.Zero)
					id_getContentRect = JNIEnv.GetMethodID (class_ref, "getContentRect", "()Landroid/graphics/RectF;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContentRect), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDefaultValueFormatter;
#pragma warning disable 0169
		static Delegate GetGetDefaultValueFormatterHandler ()
		{
			if (cb_getDefaultValueFormatter == null)
				cb_getDefaultValueFormatter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDefaultValueFormatter);
			return cb_getDefaultValueFormatter;
		}

		static IntPtr n_GetDefaultValueFormatter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultValueFormatter);
		}
#pragma warning restore 0169

		IntPtr id_getDefaultValueFormatter;
		public unsafe global::MikePhil.Charting.Formatter.IValueFormatter DefaultValueFormatter {
			get {
				if (id_getDefaultValueFormatter == IntPtr.Zero)
					id_getDefaultValueFormatter = JNIEnv.GetMethodID (class_ref, "getDefaultValueFormatter", "()Lcom/github/mikephil/charting/formatter/IValueFormatter;");
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IValueFormatter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDefaultValueFormatter), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getHeight;
#pragma warning disable 0169
		static Delegate GetGetHeightHandler ()
		{
			if (cb_getHeight == null)
				cb_getHeight = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Height;
		}
#pragma warning restore 0169

		IntPtr id_getHeight;
		public unsafe int Height {
			get {
				if (id_getHeight == IntPtr.Zero)
					id_getHeight = JNIEnv.GetMethodID (class_ref, "getHeight", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHeight);
			}
		}

		static Delegate cb_getMaxHighlightDistance;
#pragma warning disable 0169
		static Delegate GetGetMaxHighlightDistanceHandler ()
		{
			if (cb_getMaxHighlightDistance == null)
				cb_getMaxHighlightDistance = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetMaxHighlightDistance);
			return cb_getMaxHighlightDistance;
		}

		static float n_GetMaxHighlightDistance (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxHighlightDistance;
		}
#pragma warning restore 0169

		IntPtr id_getMaxHighlightDistance;
		public unsafe float MaxHighlightDistance {
			get {
				if (id_getMaxHighlightDistance == IntPtr.Zero)
					id_getMaxHighlightDistance = JNIEnv.GetMethodID (class_ref, "getMaxHighlightDistance", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getMaxHighlightDistance);
			}
		}

		static Delegate cb_getMaxVisibleCount;
#pragma warning disable 0169
		static Delegate GetGetMaxVisibleCountHandler ()
		{
			if (cb_getMaxVisibleCount == null)
				cb_getMaxVisibleCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMaxVisibleCount);
			return cb_getMaxVisibleCount;
		}

		static int n_GetMaxVisibleCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxVisibleCount;
		}
#pragma warning restore 0169

		IntPtr id_getMaxVisibleCount;
		public unsafe int MaxVisibleCount {
			get {
				if (id_getMaxVisibleCount == IntPtr.Zero)
					id_getMaxVisibleCount = JNIEnv.GetMethodID (class_ref, "getMaxVisibleCount", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getMaxVisibleCount);
			}
		}

		static Delegate cb_getWidth;
#pragma warning disable 0169
		static Delegate GetGetWidthHandler ()
		{
			if (cb_getWidth == null)
				cb_getWidth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Width;
		}
#pragma warning restore 0169

		IntPtr id_getWidth;
		public unsafe int Width {
			get {
				if (id_getWidth == IntPtr.Zero)
					id_getWidth = JNIEnv.GetMethodID (class_ref, "getWidth", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getWidth);
			}
		}

		static Delegate cb_getXChartMax;
#pragma warning disable 0169
		static Delegate GetGetXChartMaxHandler ()
		{
			if (cb_getXChartMax == null)
				cb_getXChartMax = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetXChartMax);
			return cb_getXChartMax;
		}

		static float n_GetXChartMax (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XChartMax;
		}
#pragma warning restore 0169

		IntPtr id_getXChartMax;
		public unsafe float XChartMax {
			get {
				if (id_getXChartMax == IntPtr.Zero)
					id_getXChartMax = JNIEnv.GetMethodID (class_ref, "getXChartMax", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getXChartMax);
			}
		}

		static Delegate cb_getXChartMin;
#pragma warning disable 0169
		static Delegate GetGetXChartMinHandler ()
		{
			if (cb_getXChartMin == null)
				cb_getXChartMin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetXChartMin);
			return cb_getXChartMin;
		}

		static float n_GetXChartMin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XChartMin;
		}
#pragma warning restore 0169

		IntPtr id_getXChartMin;
		public unsafe float XChartMin {
			get {
				if (id_getXChartMin == IntPtr.Zero)
					id_getXChartMin = JNIEnv.GetMethodID (class_ref, "getXChartMin", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getXChartMin);
			}
		}

		static Delegate cb_getXRange;
#pragma warning disable 0169
		static Delegate GetGetXRangeHandler ()
		{
			if (cb_getXRange == null)
				cb_getXRange = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetXRange);
			return cb_getXRange;
		}

		static float n_GetXRange (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XRange;
		}
#pragma warning restore 0169

		IntPtr id_getXRange;
		public unsafe float XRange {
			get {
				if (id_getXRange == IntPtr.Zero)
					id_getXRange = JNIEnv.GetMethodID (class_ref, "getXRange", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getXRange);
			}
		}

		static Delegate cb_getYChartMax;
#pragma warning disable 0169
		static Delegate GetGetYChartMaxHandler ()
		{
			if (cb_getYChartMax == null)
				cb_getYChartMax = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetYChartMax);
			return cb_getYChartMax;
		}

		static float n_GetYChartMax (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YChartMax;
		}
#pragma warning restore 0169

		IntPtr id_getYChartMax;
		public unsafe float YChartMax {
			get {
				if (id_getYChartMax == IntPtr.Zero)
					id_getYChartMax = JNIEnv.GetMethodID (class_ref, "getYChartMax", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getYChartMax);
			}
		}

		static Delegate cb_getYChartMin;
#pragma warning disable 0169
		static Delegate GetGetYChartMinHandler ()
		{
			if (cb_getYChartMin == null)
				cb_getYChartMin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetYChartMin);
			return cb_getYChartMin;
		}

		static float n_GetYChartMin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YChartMin;
		}
#pragma warning restore 0169

		IntPtr id_getYChartMin;
		public unsafe float YChartMin {
			get {
				if (id_getYChartMin == IntPtr.Zero)
					id_getYChartMin = JNIEnv.GetMethodID (class_ref, "getYChartMin", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getYChartMin);
			}
		}

		static Delegate cb_getBubbleData;
#pragma warning disable 0169
		static Delegate GetGetBubbleDataHandler ()
		{
			if (cb_getBubbleData == null)
				cb_getBubbleData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetBubbleData);
			return cb_getBubbleData;
		}

		static IntPtr n_GetBubbleData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BubbleData);
		}
#pragma warning restore 0169

		IntPtr id_getBubbleData;
		public unsafe global::MikePhil.Charting.Data.BubbleData BubbleData {
			get {
				if (id_getBubbleData == IntPtr.Zero)
					id_getBubbleData = JNIEnv.GetMethodID (class_ref, "getBubbleData", "()Lcom/github/mikephil/charting/data/BubbleData;");
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BubbleData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBubbleData), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getCandleData;
#pragma warning disable 0169
		static Delegate GetGetCandleDataHandler ()
		{
			if (cb_getCandleData == null)
				cb_getCandleData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetCandleData);
			return cb_getCandleData;
		}

		static IntPtr n_GetCandleData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CandleData);
		}
#pragma warning restore 0169

		IntPtr id_getCandleData;
		public unsafe global::MikePhil.Charting.Data.CandleData CandleData {
			get {
				if (id_getCandleData == IntPtr.Zero)
					id_getCandleData = JNIEnv.GetMethodID (class_ref, "getCandleData", "()Lcom/github/mikephil/charting/data/CandleData;");
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCandleData), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getLineData;
#pragma warning disable 0169
		static Delegate GetGetLineDataHandler ()
		{
			if (cb_getLineData == null)
				cb_getLineData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLineData);
			return cb_getLineData;
		}

		static IntPtr n_GetLineData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LineData);
		}
#pragma warning restore 0169

		IntPtr id_getLineData;
		public unsafe global::MikePhil.Charting.Data.LineData LineData {
			get {
				if (id_getLineData == IntPtr.Zero)
					id_getLineData = JNIEnv.GetMethodID (class_ref, "getLineData", "()Lcom/github/mikephil/charting/data/LineData;");
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLineData), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getAxis_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
#pragma warning disable 0169
		static Delegate GetGetAxis_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler ()
		{
			if (cb_getAxis_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ == null)
				cb_getAxis_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetAxis_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_getAxis_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static IntPtr n_GetAxis_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAxis (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getAxis_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		public unsafe global::MikePhil.Charting.Components.YAxis GetAxis (global::MikePhil.Charting.Components.YAxis.AxisDependency p0)
		{
			if (id_getAxis_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ == IntPtr.Zero)
				id_getAxis_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNIEnv.GetMethodID (class_ref, "getAxis", "(Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)Lcom/github/mikephil/charting/components/YAxis;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
			var __ret = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAxis_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_getScatterData;
#pragma warning disable 0169
		static Delegate GetGetScatterDataHandler ()
		{
			if (cb_getScatterData == null)
				cb_getScatterData = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetScatterData);
			return cb_getScatterData;
		}

		static IntPtr n_GetScatterData (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScatterData);
		}
#pragma warning restore 0169

		IntPtr id_getScatterData;
		public unsafe global::MikePhil.Charting.Data.ScatterData ScatterData {
			get {
				if (id_getScatterData == IntPtr.Zero)
					id_getScatterData = JNIEnv.GetMethodID (class_ref, "getScatterData", "()Lcom/github/mikephil/charting/data/ScatterData;");
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ScatterData> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getScatterData), JniHandleOwnership.TransferLocalRef);
			}
		}

	}
}
