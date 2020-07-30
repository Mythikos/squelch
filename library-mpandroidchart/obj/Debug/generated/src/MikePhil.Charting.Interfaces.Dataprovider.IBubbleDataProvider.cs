using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Interfaces.Dataprovider {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.dataprovider']/interface[@name='BubbleDataProvider']"
	[Register ("com/github/mikephil/charting/interfaces/dataprovider/BubbleDataProvider", "", "MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProviderInvoker")]
	public partial interface IBubbleDataProvider : global::MikePhil.Charting.Interfaces.Dataprovider.IBarLineScatterCandleBubbleDataProvider {

		global::MikePhil.Charting.Data.BubbleData BubbleData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.dataprovider']/interface[@name='BubbleDataProvider']/method[@name='getBubbleData' and count(parameter)=0]"
			[Register ("getBubbleData", "()Lcom/github/mikephil/charting/data/BubbleData;", "GetGetBubbleDataHandler:MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProviderInvoker, library-mpandroidchart")] get;
		}

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/interfaces/dataprovider/BubbleDataProvider", DoNotGenerateAcw=true)]
	internal partial class IBubbleDataProviderInvoker : global::Java.Lang.Object, IBubbleDataProvider {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/interfaces/dataprovider/BubbleDataProvider", typeof (IBubbleDataProviderInvoker));

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

		public static IBubbleDataProvider GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBubbleDataProvider> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.github.mikephil.charting.interfaces.dataprovider.BubbleDataProvider"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBubbleDataProviderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getBubbleData;
#pragma warning disable 0169
		static Delegate GetGetBubbleDataHandler ()
		{
			if (cb_getBubbleData == null)
				cb_getBubbleData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBubbleData);
			return cb_getBubbleData;
		}

		static IntPtr n_GetBubbleData (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getHighestVisibleX;
#pragma warning disable 0169
		static Delegate GetGetHighestVisibleXHandler ()
		{
			if (cb_getHighestVisibleX == null)
				cb_getHighestVisibleX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetHighestVisibleX);
			return cb_getHighestVisibleX;
		}

		static float n_GetHighestVisibleX (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				cb_getLowestVisibleX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetLowestVisibleX);
			return cb_getLowestVisibleX;
		}

		static float n_GetLowestVisibleX (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				cb_getTransformer_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTransformer_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_getTransformer_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static IntPtr n_GetTransformer_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency p0 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_p0, JniHandleOwnership.DoNotTransfer);
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
			global::MikePhil.Charting.Util.Transformer __ret = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTransformer_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_isInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
#pragma warning disable 0169
		static Delegate GetIsInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler ()
		{
			if (cb_isInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ == null)
				cb_isInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_isInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static bool n_IsInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency p0 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_p0, JniHandleOwnership.DoNotTransfer);
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
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_, __args);
			return __ret;
		}

		static Delegate cb_getCenterOfView;
#pragma warning disable 0169
		static Delegate GetGetCenterOfViewHandler ()
		{
			if (cb_getCenterOfView == null)
				cb_getCenterOfView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCenterOfView);
			return cb_getCenterOfView;
		}

		static IntPtr n_GetCenterOfView (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				cb_getCenterOffsets = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCenterOffsets);
			return cb_getCenterOffsets;
		}

		static IntPtr n_GetCenterOffsets (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				cb_getContentRect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentRect);
			return cb_getContentRect;
		}

		static IntPtr n_GetContentRect (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				cb_getDefaultValueFormatter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultValueFormatter);
			return cb_getDefaultValueFormatter;
		}

		static IntPtr n_GetDefaultValueFormatter (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				cb_getHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHeight);
			return cb_getHeight;
		}

		static int n_GetHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				cb_getMaxHighlightDistance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMaxHighlightDistance);
			return cb_getMaxHighlightDistance;
		}

		static float n_GetMaxHighlightDistance (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				cb_getMaxVisibleCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxVisibleCount);
			return cb_getMaxVisibleCount;
		}

		static int n_GetMaxVisibleCount (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				cb_getWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWidth);
			return cb_getWidth;
		}

		static int n_GetWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				cb_getXChartMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetXChartMax);
			return cb_getXChartMax;
		}

		static float n_GetXChartMax (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				cb_getXChartMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetXChartMin);
			return cb_getXChartMin;
		}

		static float n_GetXChartMin (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				cb_getXRange = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetXRange);
			return cb_getXRange;
		}

		static float n_GetXRange (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				cb_getYChartMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetYChartMax);
			return cb_getYChartMax;
		}

		static float n_GetYChartMax (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
				cb_getYChartMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetYChartMin);
			return cb_getYChartMin;
		}

		static float n_GetYChartMin (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.IBubbleDataProvider> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

	}

}
