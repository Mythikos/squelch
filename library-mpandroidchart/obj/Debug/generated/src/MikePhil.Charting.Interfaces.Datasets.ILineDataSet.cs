using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Interfaces.Datasets {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='ILineDataSet']"
	[Register ("com/github/mikephil/charting/interfaces/datasets/ILineDataSet", "", "MikePhil.Charting.Interfaces.Datasets.ILineDataSetInvoker")]
	public partial interface ILineDataSet : global::MikePhil.Charting.Interfaces.Datasets.ILineRadarDataSet {

		int CircleColorCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='ILineDataSet']/method[@name='getCircleColorCount' and count(parameter)=0]"
			[Register ("getCircleColorCount", "()I", "GetGetCircleColorCountHandler:MikePhil.Charting.Interfaces.Datasets.ILineDataSetInvoker, library-mpandroidchart")] get;
		}

		int CircleHoleColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='ILineDataSet']/method[@name='getCircleHoleColor' and count(parameter)=0]"
			[Register ("getCircleHoleColor", "()I", "GetGetCircleHoleColorHandler:MikePhil.Charting.Interfaces.Datasets.ILineDataSetInvoker, library-mpandroidchart")] get;
		}

		float CircleHoleRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='ILineDataSet']/method[@name='getCircleHoleRadius' and count(parameter)=0]"
			[Register ("getCircleHoleRadius", "()F", "GetGetCircleHoleRadiusHandler:MikePhil.Charting.Interfaces.Datasets.ILineDataSetInvoker, library-mpandroidchart")] get;
		}

		float CircleRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='ILineDataSet']/method[@name='getCircleRadius' and count(parameter)=0]"
			[Register ("getCircleRadius", "()F", "GetGetCircleRadiusHandler:MikePhil.Charting.Interfaces.Datasets.ILineDataSetInvoker, library-mpandroidchart")] get;
		}

		float CubicIntensity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='ILineDataSet']/method[@name='getCubicIntensity' and count(parameter)=0]"
			[Register ("getCubicIntensity", "()F", "GetGetCubicIntensityHandler:MikePhil.Charting.Interfaces.Datasets.ILineDataSetInvoker, library-mpandroidchart")] get;
		}

		global::Android.Graphics.DashPathEffect DashPathEffect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='ILineDataSet']/method[@name='getDashPathEffect' and count(parameter)=0]"
			[Register ("getDashPathEffect", "()Landroid/graphics/DashPathEffect;", "GetGetDashPathEffectHandler:MikePhil.Charting.Interfaces.Datasets.ILineDataSetInvoker, library-mpandroidchart")] get;
		}

		global::MikePhil.Charting.Formatter.IFillFormatter FillFormatter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='ILineDataSet']/method[@name='getFillFormatter' and count(parameter)=0]"
			[Register ("getFillFormatter", "()Lcom/github/mikephil/charting/formatter/IFillFormatter;", "GetGetFillFormatterHandler:MikePhil.Charting.Interfaces.Datasets.ILineDataSetInvoker, library-mpandroidchart")] get;
		}

		bool IsDashedLineEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='ILineDataSet']/method[@name='isDashedLineEnabled' and count(parameter)=0]"
			[Register ("isDashedLineEnabled", "()Z", "GetIsDashedLineEnabledHandler:MikePhil.Charting.Interfaces.Datasets.ILineDataSetInvoker, library-mpandroidchart")] get;
		}

		bool IsDrawCircleHoleEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='ILineDataSet']/method[@name='isDrawCircleHoleEnabled' and count(parameter)=0]"
			[Register ("isDrawCircleHoleEnabled", "()Z", "GetIsDrawCircleHoleEnabledHandler:MikePhil.Charting.Interfaces.Datasets.ILineDataSetInvoker, library-mpandroidchart")] get;
		}

		bool IsDrawCirclesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='ILineDataSet']/method[@name='isDrawCirclesEnabled' and count(parameter)=0]"
			[Register ("isDrawCirclesEnabled", "()Z", "GetIsDrawCirclesEnabledHandler:MikePhil.Charting.Interfaces.Datasets.ILineDataSetInvoker, library-mpandroidchart")] get;
		}

		bool IsDrawCubicEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='ILineDataSet']/method[@name='isDrawCubicEnabled' and count(parameter)=0]"
			[Register ("isDrawCubicEnabled", "()Z", "GetIsDrawCubicEnabledHandler:MikePhil.Charting.Interfaces.Datasets.ILineDataSetInvoker, library-mpandroidchart")] get;
		}

		bool IsDrawSteppedEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='ILineDataSet']/method[@name='isDrawSteppedEnabled' and count(parameter)=0]"
			[Register ("isDrawSteppedEnabled", "()Z", "GetIsDrawSteppedEnabledHandler:MikePhil.Charting.Interfaces.Datasets.ILineDataSetInvoker, library-mpandroidchart")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='ILineDataSet']/method[@name='getCircleColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getCircleColor", "(I)I", "GetGetCircleColor_IHandler:MikePhil.Charting.Interfaces.Datasets.ILineDataSetInvoker, library-mpandroidchart")]
		int GetCircleColor (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='ILineDataSet']/method[@name='getMode' and count(parameter)=0]"
		[Register ("getMode", "()Lcom/github/mikephil/charting/data/LineDataSet$Mode;", "GetGetModeHandler:MikePhil.Charting.Interfaces.Datasets.ILineDataSetInvoker, library-mpandroidchart")]
		global::MikePhil.Charting.Data.LineDataSet.Mode GetMode ();

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/interfaces/datasets/ILineDataSet", DoNotGenerateAcw=true)]
	internal class ILineDataSetInvoker : global::Java.Lang.Object, ILineDataSet {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/github/mikephil/charting/interfaces/datasets/ILineDataSet", typeof (ILineDataSetInvoker));

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

		public static ILineDataSet GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILineDataSet> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.github.mikephil.charting.interfaces.datasets.ILineDataSet"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILineDataSetInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getCircleColorCount;
#pragma warning disable 0169
		static Delegate GetGetCircleColorCountHandler ()
		{
			if (cb_getCircleColorCount == null)
				cb_getCircleColorCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCircleColorCount);
			return cb_getCircleColorCount;
		}

		static int n_GetCircleColorCount (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CircleColorCount;
		}
#pragma warning restore 0169

		IntPtr id_getCircleColorCount;
		public unsafe int CircleColorCount {
			get {
				if (id_getCircleColorCount == IntPtr.Zero)
					id_getCircleColorCount = JNIEnv.GetMethodID (class_ref, "getCircleColorCount", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCircleColorCount);
			}
		}

		static Delegate cb_getCircleHoleColor;
#pragma warning disable 0169
		static Delegate GetGetCircleHoleColorHandler ()
		{
			if (cb_getCircleHoleColor == null)
				cb_getCircleHoleColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCircleHoleColor);
			return cb_getCircleHoleColor;
		}

		static int n_GetCircleHoleColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CircleHoleColor;
		}
#pragma warning restore 0169

		IntPtr id_getCircleHoleColor;
		public unsafe int CircleHoleColor {
			get {
				if (id_getCircleHoleColor == IntPtr.Zero)
					id_getCircleHoleColor = JNIEnv.GetMethodID (class_ref, "getCircleHoleColor", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCircleHoleColor);
			}
		}

		static Delegate cb_getCircleHoleRadius;
#pragma warning disable 0169
		static Delegate GetGetCircleHoleRadiusHandler ()
		{
			if (cb_getCircleHoleRadius == null)
				cb_getCircleHoleRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetCircleHoleRadius);
			return cb_getCircleHoleRadius;
		}

		static float n_GetCircleHoleRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CircleHoleRadius;
		}
#pragma warning restore 0169

		IntPtr id_getCircleHoleRadius;
		public unsafe float CircleHoleRadius {
			get {
				if (id_getCircleHoleRadius == IntPtr.Zero)
					id_getCircleHoleRadius = JNIEnv.GetMethodID (class_ref, "getCircleHoleRadius", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getCircleHoleRadius);
			}
		}

		static Delegate cb_getCircleRadius;
#pragma warning disable 0169
		static Delegate GetGetCircleRadiusHandler ()
		{
			if (cb_getCircleRadius == null)
				cb_getCircleRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetCircleRadius);
			return cb_getCircleRadius;
		}

		static float n_GetCircleRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CircleRadius;
		}
#pragma warning restore 0169

		IntPtr id_getCircleRadius;
		public unsafe float CircleRadius {
			get {
				if (id_getCircleRadius == IntPtr.Zero)
					id_getCircleRadius = JNIEnv.GetMethodID (class_ref, "getCircleRadius", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getCircleRadius);
			}
		}

		static Delegate cb_getCubicIntensity;
#pragma warning disable 0169
		static Delegate GetGetCubicIntensityHandler ()
		{
			if (cb_getCubicIntensity == null)
				cb_getCubicIntensity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetCubicIntensity);
			return cb_getCubicIntensity;
		}

		static float n_GetCubicIntensity (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CubicIntensity;
		}
#pragma warning restore 0169

		IntPtr id_getCubicIntensity;
		public unsafe float CubicIntensity {
			get {
				if (id_getCubicIntensity == IntPtr.Zero)
					id_getCubicIntensity = JNIEnv.GetMethodID (class_ref, "getCubicIntensity", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getCubicIntensity);
			}
		}

		static Delegate cb_getDashPathEffect;
#pragma warning disable 0169
		static Delegate GetGetDashPathEffectHandler ()
		{
			if (cb_getDashPathEffect == null)
				cb_getDashPathEffect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDashPathEffect);
			return cb_getDashPathEffect;
		}

		static IntPtr n_GetDashPathEffect (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DashPathEffect);
		}
#pragma warning restore 0169

		IntPtr id_getDashPathEffect;
		public unsafe global::Android.Graphics.DashPathEffect DashPathEffect {
			get {
				if (id_getDashPathEffect == IntPtr.Zero)
					id_getDashPathEffect = JNIEnv.GetMethodID (class_ref, "getDashPathEffect", "()Landroid/graphics/DashPathEffect;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.DashPathEffect> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDashPathEffect), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getFillFormatter;
#pragma warning disable 0169
		static Delegate GetGetFillFormatterHandler ()
		{
			if (cb_getFillFormatter == null)
				cb_getFillFormatter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFillFormatter);
			return cb_getFillFormatter;
		}

		static IntPtr n_GetFillFormatter (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FillFormatter);
		}
#pragma warning restore 0169

		IntPtr id_getFillFormatter;
		public unsafe global::MikePhil.Charting.Formatter.IFillFormatter FillFormatter {
			get {
				if (id_getFillFormatter == IntPtr.Zero)
					id_getFillFormatter = JNIEnv.GetMethodID (class_ref, "getFillFormatter", "()Lcom/github/mikephil/charting/formatter/IFillFormatter;");
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IFillFormatter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFillFormatter), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isDashedLineEnabled;
#pragma warning disable 0169
		static Delegate GetIsDashedLineEnabledHandler ()
		{
			if (cb_isDashedLineEnabled == null)
				cb_isDashedLineEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDashedLineEnabled);
			return cb_isDashedLineEnabled;
		}

		static bool n_IsDashedLineEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDashedLineEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isDashedLineEnabled;
		public unsafe bool IsDashedLineEnabled {
			get {
				if (id_isDashedLineEnabled == IntPtr.Zero)
					id_isDashedLineEnabled = JNIEnv.GetMethodID (class_ref, "isDashedLineEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDashedLineEnabled);
			}
		}

		static Delegate cb_isDrawCircleHoleEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawCircleHoleEnabledHandler ()
		{
			if (cb_isDrawCircleHoleEnabled == null)
				cb_isDrawCircleHoleEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawCircleHoleEnabled);
			return cb_isDrawCircleHoleEnabled;
		}

		static bool n_IsDrawCircleHoleEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawCircleHoleEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isDrawCircleHoleEnabled;
		public unsafe bool IsDrawCircleHoleEnabled {
			get {
				if (id_isDrawCircleHoleEnabled == IntPtr.Zero)
					id_isDrawCircleHoleEnabled = JNIEnv.GetMethodID (class_ref, "isDrawCircleHoleEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDrawCircleHoleEnabled);
			}
		}

		static Delegate cb_isDrawCirclesEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawCirclesEnabledHandler ()
		{
			if (cb_isDrawCirclesEnabled == null)
				cb_isDrawCirclesEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawCirclesEnabled);
			return cb_isDrawCirclesEnabled;
		}

		static bool n_IsDrawCirclesEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawCirclesEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isDrawCirclesEnabled;
		public unsafe bool IsDrawCirclesEnabled {
			get {
				if (id_isDrawCirclesEnabled == IntPtr.Zero)
					id_isDrawCirclesEnabled = JNIEnv.GetMethodID (class_ref, "isDrawCirclesEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDrawCirclesEnabled);
			}
		}

		static Delegate cb_isDrawCubicEnabled;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetIsDrawCubicEnabledHandler ()
		{
			if (cb_isDrawCubicEnabled == null)
				cb_isDrawCubicEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawCubicEnabled);
			return cb_isDrawCubicEnabled;
		}

		[Obsolete]
		static bool n_IsDrawCubicEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawCubicEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isDrawCubicEnabled;
		public unsafe bool IsDrawCubicEnabled {
			get {
				if (id_isDrawCubicEnabled == IntPtr.Zero)
					id_isDrawCubicEnabled = JNIEnv.GetMethodID (class_ref, "isDrawCubicEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDrawCubicEnabled);
			}
		}

		static Delegate cb_isDrawSteppedEnabled;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetIsDrawSteppedEnabledHandler ()
		{
			if (cb_isDrawSteppedEnabled == null)
				cb_isDrawSteppedEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawSteppedEnabled);
			return cb_isDrawSteppedEnabled;
		}

		[Obsolete]
		static bool n_IsDrawSteppedEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawSteppedEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isDrawSteppedEnabled;
		public unsafe bool IsDrawSteppedEnabled {
			get {
				if (id_isDrawSteppedEnabled == IntPtr.Zero)
					id_isDrawSteppedEnabled = JNIEnv.GetMethodID (class_ref, "isDrawSteppedEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDrawSteppedEnabled);
			}
		}

		static Delegate cb_getCircleColor_I;
#pragma warning disable 0169
		static Delegate GetGetCircleColor_IHandler ()
		{
			if (cb_getCircleColor_I == null)
				cb_getCircleColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetCircleColor_I);
			return cb_getCircleColor_I;
		}

		static int n_GetCircleColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetCircleColor (p0);
		}
#pragma warning restore 0169

		IntPtr id_getCircleColor_I;
		public unsafe int GetCircleColor (int p0)
		{
			if (id_getCircleColor_I == IntPtr.Zero)
				id_getCircleColor_I = JNIEnv.GetMethodID (class_ref, "getCircleColor", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCircleColor_I, __args);
		}

		static Delegate cb_getMode;
#pragma warning disable 0169
		static Delegate GetGetModeHandler ()
		{
			if (cb_getMode == null)
				cb_getMode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMode);
			return cb_getMode;
		}

		static IntPtr n_GetMode (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetMode ());
		}
#pragma warning restore 0169

		IntPtr id_getMode;
		public unsafe global::MikePhil.Charting.Data.LineDataSet.Mode GetMode ()
		{
			if (id_getMode == IntPtr.Zero)
				id_getMode = JNIEnv.GetMethodID (class_ref, "getMode", "()Lcom/github/mikephil/charting/data/LineDataSet$Mode;");
			return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet.Mode> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMode), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getFillAlpha;
#pragma warning disable 0169
		static Delegate GetGetFillAlphaHandler ()
		{
			if (cb_getFillAlpha == null)
				cb_getFillAlpha = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFillAlpha);
			return cb_getFillAlpha;
		}

		static int n_GetFillAlpha (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FillAlpha;
		}
#pragma warning restore 0169

		IntPtr id_getFillAlpha;
		public unsafe int FillAlpha {
			get {
				if (id_getFillAlpha == IntPtr.Zero)
					id_getFillAlpha = JNIEnv.GetMethodID (class_ref, "getFillAlpha", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFillAlpha);
			}
		}

		static Delegate cb_getFillColor;
#pragma warning disable 0169
		static Delegate GetGetFillColorHandler ()
		{
			if (cb_getFillColor == null)
				cb_getFillColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFillColor);
			return cb_getFillColor;
		}

		static int n_GetFillColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FillColor;
		}
#pragma warning restore 0169

		IntPtr id_getFillColor;
		public unsafe int FillColor {
			get {
				if (id_getFillColor == IntPtr.Zero)
					id_getFillColor = JNIEnv.GetMethodID (class_ref, "getFillColor", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getFillColor);
			}
		}

		static Delegate cb_getFillDrawable;
#pragma warning disable 0169
		static Delegate GetGetFillDrawableHandler ()
		{
			if (cb_getFillDrawable == null)
				cb_getFillDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFillDrawable);
			return cb_getFillDrawable;
		}

		static IntPtr n_GetFillDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FillDrawable);
		}
#pragma warning restore 0169

		IntPtr id_getFillDrawable;
		public unsafe global::Android.Graphics.Drawables.Drawable FillDrawable {
			get {
				if (id_getFillDrawable == IntPtr.Zero)
					id_getFillDrawable = JNIEnv.GetMethodID (class_ref, "getFillDrawable", "()Landroid/graphics/drawable/Drawable;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFillDrawable), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isDrawFilledEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawFilledEnabledHandler ()
		{
			if (cb_isDrawFilledEnabled == null)
				cb_isDrawFilledEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawFilledEnabled);
			return cb_isDrawFilledEnabled;
		}

		static bool n_IsDrawFilledEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawFilledEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isDrawFilledEnabled;
		public unsafe bool IsDrawFilledEnabled {
			get {
				if (id_isDrawFilledEnabled == IntPtr.Zero)
					id_isDrawFilledEnabled = JNIEnv.GetMethodID (class_ref, "isDrawFilledEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDrawFilledEnabled);
			}
		}

		static Delegate cb_getLineWidth;
#pragma warning disable 0169
		static Delegate GetGetLineWidthHandler ()
		{
			if (cb_getLineWidth == null)
				cb_getLineWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetLineWidth);
			return cb_getLineWidth;
		}

		static float n_GetLineWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LineWidth;
		}
#pragma warning restore 0169

		IntPtr id_getLineWidth;
		public unsafe float LineWidth {
			get {
				if (id_getLineWidth == IntPtr.Zero)
					id_getLineWidth = JNIEnv.GetMethodID (class_ref, "getLineWidth", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getLineWidth);
			}
		}

		static Delegate cb_setDrawFilled_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawFilled_ZHandler ()
		{
			if (cb_setDrawFilled_Z == null)
				cb_setDrawFilled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawFilled_Z);
			return cb_setDrawFilled_Z;
		}

		static void n_SetDrawFilled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawFilled (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDrawFilled_Z;
		public unsafe void SetDrawFilled (bool p0)
		{
			if (id_setDrawFilled_Z == IntPtr.Zero)
				id_setDrawFilled_Z = JNIEnv.GetMethodID (class_ref, "setDrawFilled", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDrawFilled_Z, __args);
		}

		static Delegate cb_getDashPathEffectHighlight;
#pragma warning disable 0169
		static Delegate GetGetDashPathEffectHighlightHandler ()
		{
			if (cb_getDashPathEffectHighlight == null)
				cb_getDashPathEffectHighlight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDashPathEffectHighlight);
			return cb_getDashPathEffectHighlight;
		}

		static IntPtr n_GetDashPathEffectHighlight (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DashPathEffectHighlight);
		}
#pragma warning restore 0169

		IntPtr id_getDashPathEffectHighlight;
		public unsafe global::Android.Graphics.DashPathEffect DashPathEffectHighlight {
			get {
				if (id_getDashPathEffectHighlight == IntPtr.Zero)
					id_getDashPathEffectHighlight = JNIEnv.GetMethodID (class_ref, "getDashPathEffectHighlight", "()Landroid/graphics/DashPathEffect;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.DashPathEffect> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDashPathEffectHighlight), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getHighlightLineWidth;
#pragma warning disable 0169
		static Delegate GetGetHighlightLineWidthHandler ()
		{
			if (cb_getHighlightLineWidth == null)
				cb_getHighlightLineWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetHighlightLineWidth);
			return cb_getHighlightLineWidth;
		}

		static float n_GetHighlightLineWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighlightLineWidth;
		}
#pragma warning restore 0169

		IntPtr id_getHighlightLineWidth;
		public unsafe float HighlightLineWidth {
			get {
				if (id_getHighlightLineWidth == IntPtr.Zero)
					id_getHighlightLineWidth = JNIEnv.GetMethodID (class_ref, "getHighlightLineWidth", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getHighlightLineWidth);
			}
		}

		static Delegate cb_isHorizontalHighlightIndicatorEnabled;
#pragma warning disable 0169
		static Delegate GetIsHorizontalHighlightIndicatorEnabledHandler ()
		{
			if (cb_isHorizontalHighlightIndicatorEnabled == null)
				cb_isHorizontalHighlightIndicatorEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHorizontalHighlightIndicatorEnabled);
			return cb_isHorizontalHighlightIndicatorEnabled;
		}

		static bool n_IsHorizontalHighlightIndicatorEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHorizontalHighlightIndicatorEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isHorizontalHighlightIndicatorEnabled;
		public unsafe bool IsHorizontalHighlightIndicatorEnabled {
			get {
				if (id_isHorizontalHighlightIndicatorEnabled == IntPtr.Zero)
					id_isHorizontalHighlightIndicatorEnabled = JNIEnv.GetMethodID (class_ref, "isHorizontalHighlightIndicatorEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHorizontalHighlightIndicatorEnabled);
			}
		}

		static Delegate cb_isVerticalHighlightIndicatorEnabled;
#pragma warning disable 0169
		static Delegate GetIsVerticalHighlightIndicatorEnabledHandler ()
		{
			if (cb_isVerticalHighlightIndicatorEnabled == null)
				cb_isVerticalHighlightIndicatorEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVerticalHighlightIndicatorEnabled);
			return cb_isVerticalHighlightIndicatorEnabled;
		}

		static bool n_IsVerticalHighlightIndicatorEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsVerticalHighlightIndicatorEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isVerticalHighlightIndicatorEnabled;
		public unsafe bool IsVerticalHighlightIndicatorEnabled {
			get {
				if (id_isVerticalHighlightIndicatorEnabled == IntPtr.Zero)
					id_isVerticalHighlightIndicatorEnabled = JNIEnv.GetMethodID (class_ref, "isVerticalHighlightIndicatorEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isVerticalHighlightIndicatorEnabled);
			}
		}

		static Delegate cb_getHighLightColor;
#pragma warning disable 0169
		static Delegate GetGetHighLightColorHandler ()
		{
			if (cb_getHighLightColor == null)
				cb_getHighLightColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHighLightColor);
			return cb_getHighLightColor;
		}

		static int n_GetHighLightColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighLightColor;
		}
#pragma warning restore 0169

		IntPtr id_getHighLightColor;
		public unsafe int HighLightColor {
			get {
				if (id_getHighLightColor == IntPtr.Zero)
					id_getHighLightColor = JNIEnv.GetMethodID (class_ref, "getHighLightColor", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getHighLightColor);
			}
		}

		static Delegate cb_getAxisDependency;
#pragma warning disable 0169
		static Delegate GetGetAxisDependencyHandler ()
		{
			if (cb_getAxisDependency == null)
				cb_getAxisDependency = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAxisDependency);
			return cb_getAxisDependency;
		}

		static IntPtr n_GetAxisDependency (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AxisDependency);
		}
#pragma warning restore 0169

		static Delegate cb_setAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
#pragma warning disable 0169
		static Delegate GetSetAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler ()
		{
			if (cb_setAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ == null)
				cb_setAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_setAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static void n_SetAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency p0 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AxisDependency = p0;
		}
#pragma warning restore 0169

		IntPtr id_getAxisDependency;
		IntPtr id_setAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		public unsafe global::MikePhil.Charting.Components.YAxis.AxisDependency AxisDependency {
			get {
				if (id_getAxisDependency == IntPtr.Zero)
					id_getAxisDependency = JNIEnv.GetMethodID (class_ref, "getAxisDependency", "()Lcom/github/mikephil/charting/components/YAxis$AxisDependency;");
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAxisDependency), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ == IntPtr.Zero)
					id_setAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNIEnv.GetMethodID (class_ref, "setAxisDependency", "(Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_, __args);
			}
		}

		static Delegate cb_getColor;
#pragma warning disable 0169
		static Delegate GetGetColorHandler ()
		{
			if (cb_getColor == null)
				cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColor);
			return cb_getColor;
		}

		static int n_GetColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Color;
		}
#pragma warning restore 0169

		IntPtr id_getColor;
		public unsafe int Color {
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColor);
			}
		}

		static Delegate cb_getColors;
#pragma warning disable 0169
		static Delegate GetGetColorsHandler ()
		{
			if (cb_getColors == null)
				cb_getColors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetColors);
			return cb_getColors;
		}

		static IntPtr n_GetColors (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (__this.Colors);
		}
#pragma warning restore 0169

		IntPtr id_getColors;
		public unsafe global::System.Collections.Generic.IList<global::Java.Lang.Integer> Colors {
			get {
				if (id_getColors == IntPtr.Zero)
					id_getColors = JNIEnv.GetMethodID (class_ref, "getColors", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getColors), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getEntryCount;
#pragma warning disable 0169
		static Delegate GetGetEntryCountHandler ()
		{
			if (cb_getEntryCount == null)
				cb_getEntryCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEntryCount);
			return cb_getEntryCount;
		}

		static int n_GetEntryCount (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EntryCount;
		}
#pragma warning restore 0169

		IntPtr id_getEntryCount;
		public unsafe int EntryCount {
			get {
				if (id_getEntryCount == IntPtr.Zero)
					id_getEntryCount = JNIEnv.GetMethodID (class_ref, "getEntryCount", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEntryCount);
			}
		}

		static Delegate cb_getForm;
#pragma warning disable 0169
		static Delegate GetGetFormHandler ()
		{
			if (cb_getForm == null)
				cb_getForm = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetForm);
			return cb_getForm;
		}

		static IntPtr n_GetForm (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Form);
		}
#pragma warning restore 0169

		IntPtr id_getForm;
		public unsafe global::MikePhil.Charting.Components.Legend.LegendForm Form {
			get {
				if (id_getForm == IntPtr.Zero)
					id_getForm = JNIEnv.GetMethodID (class_ref, "getForm", "()Lcom/github/mikephil/charting/components/Legend$LegendForm;");
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendForm> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getForm), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getFormLineDashEffect;
#pragma warning disable 0169
		static Delegate GetGetFormLineDashEffectHandler ()
		{
			if (cb_getFormLineDashEffect == null)
				cb_getFormLineDashEffect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormLineDashEffect);
			return cb_getFormLineDashEffect;
		}

		static IntPtr n_GetFormLineDashEffect (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FormLineDashEffect);
		}
#pragma warning restore 0169

		IntPtr id_getFormLineDashEffect;
		public unsafe global::Android.Graphics.DashPathEffect FormLineDashEffect {
			get {
				if (id_getFormLineDashEffect == IntPtr.Zero)
					id_getFormLineDashEffect = JNIEnv.GetMethodID (class_ref, "getFormLineDashEffect", "()Landroid/graphics/DashPathEffect;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.DashPathEffect> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormLineDashEffect), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getFormLineWidth;
#pragma warning disable 0169
		static Delegate GetGetFormLineWidthHandler ()
		{
			if (cb_getFormLineWidth == null)
				cb_getFormLineWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetFormLineWidth);
			return cb_getFormLineWidth;
		}

		static float n_GetFormLineWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FormLineWidth;
		}
#pragma warning restore 0169

		IntPtr id_getFormLineWidth;
		public unsafe float FormLineWidth {
			get {
				if (id_getFormLineWidth == IntPtr.Zero)
					id_getFormLineWidth = JNIEnv.GetMethodID (class_ref, "getFormLineWidth", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getFormLineWidth);
			}
		}

		static Delegate cb_getFormSize;
#pragma warning disable 0169
		static Delegate GetGetFormSizeHandler ()
		{
			if (cb_getFormSize == null)
				cb_getFormSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetFormSize);
			return cb_getFormSize;
		}

		static float n_GetFormSize (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FormSize;
		}
#pragma warning restore 0169

		IntPtr id_getFormSize;
		public unsafe float FormSize {
			get {
				if (id_getFormSize == IntPtr.Zero)
					id_getFormSize = JNIEnv.GetMethodID (class_ref, "getFormSize", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getFormSize);
			}
		}

		static Delegate cb_getGradientColor;
#pragma warning disable 0169
		static Delegate GetGetGradientColorHandler ()
		{
			if (cb_getGradientColor == null)
				cb_getGradientColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGradientColor);
			return cb_getGradientColor;
		}

		static IntPtr n_GetGradientColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GradientColor);
		}
#pragma warning restore 0169

		IntPtr id_getGradientColor;
		public unsafe global::MikePhil.Charting.Model.GradientColor GradientColor {
			get {
				if (id_getGradientColor == IntPtr.Zero)
					id_getGradientColor = JNIEnv.GetMethodID (class_ref, "getGradientColor", "()Lcom/github/mikephil/charting/model/GradientColor;");
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Model.GradientColor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGradientColor), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getGradientColors;
#pragma warning disable 0169
		static Delegate GetGetGradientColorsHandler ()
		{
			if (cb_getGradientColors == null)
				cb_getGradientColors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGradientColors);
			return cb_getGradientColors;
		}

		static IntPtr n_GetGradientColors (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::MikePhil.Charting.Model.GradientColor>.ToLocalJniHandle (__this.GradientColors);
		}
#pragma warning restore 0169

		IntPtr id_getGradientColors;
		public unsafe global::System.Collections.Generic.IList<global::MikePhil.Charting.Model.GradientColor> GradientColors {
			get {
				if (id_getGradientColors == IntPtr.Zero)
					id_getGradientColors = JNIEnv.GetMethodID (class_ref, "getGradientColors", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::MikePhil.Charting.Model.GradientColor>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGradientColors), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isHighlightEnabled;
#pragma warning disable 0169
		static Delegate GetIsHighlightEnabledHandler ()
		{
			if (cb_isHighlightEnabled == null)
				cb_isHighlightEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHighlightEnabled);
			return cb_isHighlightEnabled;
		}

		static bool n_IsHighlightEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighlightEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setHighlightEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetHighlightEnabled_ZHandler ()
		{
			if (cb_setHighlightEnabled_Z == null)
				cb_setHighlightEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHighlightEnabled_Z);
			return cb_setHighlightEnabled_Z;
		}

		static void n_SetHighlightEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighlightEnabled = p0;
		}
#pragma warning restore 0169

		IntPtr id_isHighlightEnabled;
		IntPtr id_setHighlightEnabled_Z;
		public unsafe bool HighlightEnabled {
			get {
				if (id_isHighlightEnabled == IntPtr.Zero)
					id_isHighlightEnabled = JNIEnv.GetMethodID (class_ref, "isHighlightEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHighlightEnabled);
			}
			set {
				if (id_setHighlightEnabled_Z == IntPtr.Zero)
					id_setHighlightEnabled_Z = JNIEnv.GetMethodID (class_ref, "setHighlightEnabled", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHighlightEnabled_Z, __args);
			}
		}

		static Delegate cb_getIconsOffset;
#pragma warning disable 0169
		static Delegate GetGetIconsOffsetHandler ()
		{
			if (cb_getIconsOffset == null)
				cb_getIconsOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconsOffset);
			return cb_getIconsOffset;
		}

		static IntPtr n_GetIconsOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconsOffset);
		}
#pragma warning restore 0169

		static Delegate cb_setIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_;
#pragma warning disable 0169
		static Delegate GetSetIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_Handler ()
		{
			if (cb_setIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_ == null)
				cb_setIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_);
			return cb_setIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_;
		}

		static void n_SetIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Util.MPPointF p0 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IconsOffset = p0;
		}
#pragma warning restore 0169

		IntPtr id_getIconsOffset;
		IntPtr id_setIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_;
		public unsafe global::MikePhil.Charting.Util.MPPointF IconsOffset {
			get {
				if (id_getIconsOffset == IntPtr.Zero)
					id_getIconsOffset = JNIEnv.GetMethodID (class_ref, "getIconsOffset", "()Lcom/github/mikephil/charting/utils/MPPointF;");
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIconsOffset), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_ == IntPtr.Zero)
					id_setIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_ = JNIEnv.GetMethodID (class_ref, "setIconsOffset", "(Lcom/github/mikephil/charting/utils/MPPointF;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_, __args);
			}
		}

		static Delegate cb_isDrawIconsEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawIconsEnabledHandler ()
		{
			if (cb_isDrawIconsEnabled == null)
				cb_isDrawIconsEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawIconsEnabled);
			return cb_isDrawIconsEnabled;
		}

		static bool n_IsDrawIconsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawIconsEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isDrawIconsEnabled;
		public unsafe bool IsDrawIconsEnabled {
			get {
				if (id_isDrawIconsEnabled == IntPtr.Zero)
					id_isDrawIconsEnabled = JNIEnv.GetMethodID (class_ref, "isDrawIconsEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDrawIconsEnabled);
			}
		}

		static Delegate cb_isDrawValuesEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawValuesEnabledHandler ()
		{
			if (cb_isDrawValuesEnabled == null)
				cb_isDrawValuesEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawValuesEnabled);
			return cb_isDrawValuesEnabled;
		}

		static bool n_IsDrawValuesEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawValuesEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isDrawValuesEnabled;
		public unsafe bool IsDrawValuesEnabled {
			get {
				if (id_isDrawValuesEnabled == IntPtr.Zero)
					id_isDrawValuesEnabled = JNIEnv.GetMethodID (class_ref, "isDrawValuesEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDrawValuesEnabled);
			}
		}

		static Delegate cb_getLabel;
#pragma warning disable 0169
		static Delegate GetGetLabelHandler ()
		{
			if (cb_getLabel == null)
				cb_getLabel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLabel);
			return cb_getLabel;
		}

		static IntPtr n_GetLabel (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Label);
		}
#pragma warning restore 0169

		static Delegate cb_setLabel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLabel_Ljava_lang_String_Handler ()
		{
			if (cb_setLabel_Ljava_lang_String_ == null)
				cb_setLabel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLabel_Ljava_lang_String_);
			return cb_setLabel_Ljava_lang_String_;
		}

		static void n_SetLabel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Label = p0;
		}
#pragma warning restore 0169

		IntPtr id_getLabel;
		IntPtr id_setLabel_Ljava_lang_String_;
		public unsafe string Label {
			get {
				if (id_getLabel == IntPtr.Zero)
					id_getLabel = JNIEnv.GetMethodID (class_ref, "getLabel", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLabel), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setLabel_Ljava_lang_String_ == IntPtr.Zero)
					id_setLabel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLabel", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLabel_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getValueFormatter;
#pragma warning disable 0169
		static Delegate GetGetValueFormatterHandler ()
		{
			if (cb_getValueFormatter == null)
				cb_getValueFormatter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValueFormatter);
			return cb_getValueFormatter;
		}

		static IntPtr n_GetValueFormatter (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ValueFormatter);
		}
#pragma warning restore 0169

		static Delegate cb_setValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_;
#pragma warning disable 0169
		static Delegate GetSetValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_Handler ()
		{
			if (cb_setValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_ == null)
				cb_setValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_);
			return cb_setValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_;
		}

		static void n_SetValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Formatter.IValueFormatter p0 = (global::MikePhil.Charting.Formatter.IValueFormatter)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IValueFormatter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ValueFormatter = p0;
		}
#pragma warning restore 0169

		IntPtr id_getValueFormatter;
		IntPtr id_setValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_;
		public unsafe global::MikePhil.Charting.Formatter.IValueFormatter ValueFormatter {
			get {
				if (id_getValueFormatter == IntPtr.Zero)
					id_getValueFormatter = JNIEnv.GetMethodID (class_ref, "getValueFormatter", "()Lcom/github/mikephil/charting/formatter/IValueFormatter;");
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IValueFormatter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValueFormatter), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_ == IntPtr.Zero)
					id_setValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_ = JNIEnv.GetMethodID (class_ref, "setValueFormatter", "(Lcom/github/mikephil/charting/formatter/IValueFormatter;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_, __args);
			}
		}

		static Delegate cb_getValueTextColor;
#pragma warning disable 0169
		static Delegate GetGetValueTextColorHandler ()
		{
			if (cb_getValueTextColor == null)
				cb_getValueTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetValueTextColor);
			return cb_getValueTextColor;
		}

		static int n_GetValueTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ValueTextColor;
		}
#pragma warning restore 0169

		static Delegate cb_setValueTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetValueTextColor_IHandler ()
		{
			if (cb_setValueTextColor_I == null)
				cb_setValueTextColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetValueTextColor_I);
			return cb_setValueTextColor_I;
		}

		static void n_SetValueTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ValueTextColor = p0;
		}
#pragma warning restore 0169

		IntPtr id_getValueTextColor;
		IntPtr id_setValueTextColor_I;
		public unsafe int ValueTextColor {
			get {
				if (id_getValueTextColor == IntPtr.Zero)
					id_getValueTextColor = JNIEnv.GetMethodID (class_ref, "getValueTextColor", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getValueTextColor);
			}
			set {
				if (id_setValueTextColor_I == IntPtr.Zero)
					id_setValueTextColor_I = JNIEnv.GetMethodID (class_ref, "setValueTextColor", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValueTextColor_I, __args);
			}
		}

		static Delegate cb_getValueTextSize;
#pragma warning disable 0169
		static Delegate GetGetValueTextSizeHandler ()
		{
			if (cb_getValueTextSize == null)
				cb_getValueTextSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetValueTextSize);
			return cb_getValueTextSize;
		}

		static float n_GetValueTextSize (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ValueTextSize;
		}
#pragma warning restore 0169

		static Delegate cb_setValueTextSize_F;
#pragma warning disable 0169
		static Delegate GetSetValueTextSize_FHandler ()
		{
			if (cb_setValueTextSize_F == null)
				cb_setValueTextSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetValueTextSize_F);
			return cb_setValueTextSize_F;
		}

		static void n_SetValueTextSize_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ValueTextSize = p0;
		}
#pragma warning restore 0169

		IntPtr id_getValueTextSize;
		IntPtr id_setValueTextSize_F;
		public unsafe float ValueTextSize {
			get {
				if (id_getValueTextSize == IntPtr.Zero)
					id_getValueTextSize = JNIEnv.GetMethodID (class_ref, "getValueTextSize", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getValueTextSize);
			}
			set {
				if (id_setValueTextSize_F == IntPtr.Zero)
					id_setValueTextSize_F = JNIEnv.GetMethodID (class_ref, "setValueTextSize", "(F)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValueTextSize_F, __args);
			}
		}

		static Delegate cb_getValueTypeface;
#pragma warning disable 0169
		static Delegate GetGetValueTypefaceHandler ()
		{
			if (cb_getValueTypeface == null)
				cb_getValueTypeface = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValueTypeface);
			return cb_getValueTypeface;
		}

		static IntPtr n_GetValueTypeface (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ValueTypeface);
		}
#pragma warning restore 0169

		static Delegate cb_setValueTypeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetSetValueTypeface_Landroid_graphics_Typeface_Handler ()
		{
			if (cb_setValueTypeface_Landroid_graphics_Typeface_ == null)
				cb_setValueTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValueTypeface_Landroid_graphics_Typeface_);
			return cb_setValueTypeface_Landroid_graphics_Typeface_;
		}

		static void n_SetValueTypeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Typeface p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ValueTypeface = p0;
		}
#pragma warning restore 0169

		IntPtr id_getValueTypeface;
		IntPtr id_setValueTypeface_Landroid_graphics_Typeface_;
		public unsafe global::Android.Graphics.Typeface ValueTypeface {
			get {
				if (id_getValueTypeface == IntPtr.Zero)
					id_getValueTypeface = JNIEnv.GetMethodID (class_ref, "getValueTypeface", "()Landroid/graphics/Typeface;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValueTypeface), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setValueTypeface_Landroid_graphics_Typeface_ == IntPtr.Zero)
					id_setValueTypeface_Landroid_graphics_Typeface_ = JNIEnv.GetMethodID (class_ref, "setValueTypeface", "(Landroid/graphics/Typeface;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValueTypeface_Landroid_graphics_Typeface_, __args);
			}
		}

		static Delegate cb_isVisible;
#pragma warning disable 0169
		static Delegate GetIsVisibleHandler ()
		{
			if (cb_isVisible == null)
				cb_isVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVisible);
			return cb_isVisible;
		}

		static bool n_IsVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Visible;
		}
#pragma warning restore 0169

		static Delegate cb_setVisible_Z;
#pragma warning disable 0169
		static Delegate GetSetVisible_ZHandler ()
		{
			if (cb_setVisible_Z == null)
				cb_setVisible_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetVisible_Z);
			return cb_setVisible_Z;
		}

		static void n_SetVisible_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Visible = p0;
		}
#pragma warning restore 0169

		IntPtr id_isVisible;
		IntPtr id_setVisible_Z;
		public unsafe bool Visible {
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isVisible);
			}
			set {
				if (id_setVisible_Z == IntPtr.Zero)
					id_setVisible_Z = JNIEnv.GetMethodID (class_ref, "setVisible", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVisible_Z, __args);
			}
		}

		static Delegate cb_getXMax;
#pragma warning disable 0169
		static Delegate GetGetXMaxHandler ()
		{
			if (cb_getXMax == null)
				cb_getXMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetXMax);
			return cb_getXMax;
		}

		static float n_GetXMax (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XMax;
		}
#pragma warning restore 0169

		IntPtr id_getXMax;
		public unsafe float XMax {
			get {
				if (id_getXMax == IntPtr.Zero)
					id_getXMax = JNIEnv.GetMethodID (class_ref, "getXMax", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getXMax);
			}
		}

		static Delegate cb_getXMin;
#pragma warning disable 0169
		static Delegate GetGetXMinHandler ()
		{
			if (cb_getXMin == null)
				cb_getXMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetXMin);
			return cb_getXMin;
		}

		static float n_GetXMin (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XMin;
		}
#pragma warning restore 0169

		IntPtr id_getXMin;
		public unsafe float XMin {
			get {
				if (id_getXMin == IntPtr.Zero)
					id_getXMin = JNIEnv.GetMethodID (class_ref, "getXMin", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getXMin);
			}
		}

		static Delegate cb_getYMax;
#pragma warning disable 0169
		static Delegate GetGetYMaxHandler ()
		{
			if (cb_getYMax == null)
				cb_getYMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetYMax);
			return cb_getYMax;
		}

		static float n_GetYMax (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YMax;
		}
#pragma warning restore 0169

		IntPtr id_getYMax;
		public unsafe float YMax {
			get {
				if (id_getYMax == IntPtr.Zero)
					id_getYMax = JNIEnv.GetMethodID (class_ref, "getYMax", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getYMax);
			}
		}

		static Delegate cb_getYMin;
#pragma warning disable 0169
		static Delegate GetGetYMinHandler ()
		{
			if (cb_getYMin == null)
				cb_getYMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetYMin);
			return cb_getYMin;
		}

		static float n_GetYMin (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YMin;
		}
#pragma warning restore 0169

		IntPtr id_getYMin;
		public unsafe float YMin {
			get {
				if (id_getYMin == IntPtr.Zero)
					id_getYMin = JNIEnv.GetMethodID (class_ref, "getYMin", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getYMin);
			}
		}

		static Delegate cb_calcMinMax;
#pragma warning disable 0169
		static Delegate GetCalcMinMaxHandler ()
		{
			if (cb_calcMinMax == null)
				cb_calcMinMax = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CalcMinMax);
			return cb_calcMinMax;
		}

		static void n_CalcMinMax (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalcMinMax ();
		}
#pragma warning restore 0169

		IntPtr id_calcMinMax;
		public unsafe void CalcMinMax ()
		{
			if (id_calcMinMax == IntPtr.Zero)
				id_calcMinMax = JNIEnv.GetMethodID (class_ref, "calcMinMax", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_calcMinMax);
		}

		static Delegate cb_calcMinMaxY_FF;
#pragma warning disable 0169
		static Delegate GetCalcMinMaxY_FFHandler ()
		{
			if (cb_calcMinMaxY_FF == null)
				cb_calcMinMaxY_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_CalcMinMaxY_FF);
			return cb_calcMinMaxY_FF;
		}

		static void n_CalcMinMaxY_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalcMinMaxY (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_calcMinMaxY_FF;
		public unsafe void CalcMinMaxY (float p0, float p1)
		{
			if (id_calcMinMaxY_FF == IntPtr.Zero)
				id_calcMinMaxY_FF = JNIEnv.GetMethodID (class_ref, "calcMinMaxY", "(FF)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_calcMinMaxY_FF, __args);
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
		}

		static Delegate cb_contains_Lcom_github_mikephil_charting_data_Entry_;
#pragma warning disable 0169
		static Delegate GetContains_Lcom_github_mikephil_charting_data_Entry_Handler ()
		{
			if (cb_contains_Lcom_github_mikephil_charting_data_Entry_ == null)
				cb_contains_Lcom_github_mikephil_charting_data_Entry_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Lcom_github_mikephil_charting_data_Entry_);
			return cb_contains_Lcom_github_mikephil_charting_data_Entry_;
		}

		static bool n_Contains_Lcom_github_mikephil_charting_data_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_contains_Lcom_github_mikephil_charting_data_Entry_;
		public unsafe bool Contains (global::Java.Lang.Object p0)
		{
			if (id_contains_Lcom_github_mikephil_charting_data_Entry_ == IntPtr.Zero)
				id_contains_Lcom_github_mikephil_charting_data_Entry_ = JNIEnv.GetMethodID (class_ref, "contains", "(Lcom/github/mikephil/charting/data/Entry;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_Lcom_github_mikephil_charting_data_Entry_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getColor_I;
#pragma warning disable 0169
		static Delegate GetGetColor_IHandler ()
		{
			if (cb_getColor_I == null)
				cb_getColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetColor_I);
			return cb_getColor_I;
		}

		static int n_GetColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetColor (p0);
		}
#pragma warning restore 0169

		IntPtr id_getColor_I;
		public unsafe int GetColor (int p0)
		{
			if (id_getColor_I == IntPtr.Zero)
				id_getColor_I = JNIEnv.GetMethodID (class_ref, "getColor", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColor_I, __args);
		}

		static Delegate cb_getEntriesForXValue_F;
#pragma warning disable 0169
		static Delegate GetGetEntriesForXValue_FHandler ()
		{
			if (cb_getEntriesForXValue_F == null)
				cb_getEntriesForXValue_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_GetEntriesForXValue_F);
			return cb_getEntriesForXValue_F;
		}

		static IntPtr n_GetEntriesForXValue_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.GetEntriesForXValue (p0));
		}
#pragma warning restore 0169

		IntPtr id_getEntriesForXValue_F;
		public unsafe global::System.Collections.IList GetEntriesForXValue (float p0)
		{
			if (id_getEntriesForXValue_F == IntPtr.Zero)
				id_getEntriesForXValue_F = JNIEnv.GetMethodID (class_ref, "getEntriesForXValue", "(F)Ljava/util/List;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEntriesForXValue_F, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_;
#pragma warning disable 0169
		static Delegate GetGetEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_Handler ()
		{
			if (cb_getEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_ == null)
				cb_getEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr, int>) n_GetEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_);
			return cb_getEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_;
		}

		static int n_GetEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_ (IntPtr jnienv, IntPtr native__this, float p0, float p1, IntPtr native_p2)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.DataSet.Rounding p2 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet.Rounding> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetEntryIndex (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_;
		public unsafe int GetEntryIndex (float p0, float p1, global::MikePhil.Charting.Data.DataSet.Rounding p2)
		{
			if (id_getEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_ == IntPtr.Zero)
				id_getEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_ = JNIEnv.GetMethodID (class_ref, "getEntryIndex", "(FFLcom/github/mikephil/charting/data/DataSet$Rounding;)I");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_, __args);
			return __ret;
		}

		static Delegate cb_getGradientColor_I;
#pragma warning disable 0169
		static Delegate GetGetGradientColor_IHandler ()
		{
			if (cb_getGradientColor_I == null)
				cb_getGradientColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetGradientColor_I);
			return cb_getGradientColor_I;
		}

		static IntPtr n_GetGradientColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetGradientColor (p0));
		}
#pragma warning restore 0169

		IntPtr id_getGradientColor_I;
		public unsafe global::MikePhil.Charting.Model.GradientColor GetGradientColor (int p0)
		{
			if (id_getGradientColor_I == IntPtr.Zero)
				id_getGradientColor_I = JNIEnv.GetMethodID (class_ref, "getGradientColor", "(I)Lcom/github/mikephil/charting/model/GradientColor;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Model.GradientColor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGradientColor_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getIndexInEntries_I;
#pragma warning disable 0169
		static Delegate GetGetIndexInEntries_IHandler ()
		{
			if (cb_getIndexInEntries_I == null)
				cb_getIndexInEntries_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetIndexInEntries_I);
			return cb_getIndexInEntries_I;
		}

		static int n_GetIndexInEntries_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetIndexInEntries (p0);
		}
#pragma warning restore 0169

		IntPtr id_getIndexInEntries_I;
		public unsafe int GetIndexInEntries (int p0)
		{
			if (id_getIndexInEntries_I == IntPtr.Zero)
				id_getIndexInEntries_I = JNIEnv.GetMethodID (class_ref, "getIndexInEntries", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIndexInEntries_I, __args);
		}

		static Delegate cb_getValueTextColor_I;
#pragma warning disable 0169
		static Delegate GetGetValueTextColor_IHandler ()
		{
			if (cb_getValueTextColor_I == null)
				cb_getValueTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetValueTextColor_I);
			return cb_getValueTextColor_I;
		}

		static int n_GetValueTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetValueTextColor (p0);
		}
#pragma warning restore 0169

		IntPtr id_getValueTextColor_I;
		public unsafe int GetValueTextColor (int p0)
		{
			if (id_getValueTextColor_I == IntPtr.Zero)
				id_getValueTextColor_I = JNIEnv.GetMethodID (class_ref, "getValueTextColor", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getValueTextColor_I, __args);
		}

		static Delegate cb_needsFormatter;
#pragma warning disable 0169
		static Delegate GetNeedsFormatterHandler ()
		{
			if (cb_needsFormatter == null)
				cb_needsFormatter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_NeedsFormatter);
			return cb_needsFormatter;
		}

		static bool n_NeedsFormatter (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeedsFormatter ();
		}
#pragma warning restore 0169

		IntPtr id_needsFormatter;
		public unsafe bool NeedsFormatter ()
		{
			if (id_needsFormatter == IntPtr.Zero)
				id_needsFormatter = JNIEnv.GetMethodID (class_ref, "needsFormatter", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_needsFormatter);
		}

		static Delegate cb_removeEntry_I;
#pragma warning disable 0169
		static Delegate GetRemoveEntry_IHandler ()
		{
			if (cb_removeEntry_I == null)
				cb_removeEntry_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_RemoveEntry_I);
			return cb_removeEntry_I;
		}

		static bool n_RemoveEntry_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemoveEntry (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeEntry_I;
		public unsafe bool RemoveEntry (int p0)
		{
			if (id_removeEntry_I == IntPtr.Zero)
				id_removeEntry_I = JNIEnv.GetMethodID (class_ref, "removeEntry", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeEntry_I, __args);
		}

		static Delegate cb_removeEntryByXValue_F;
#pragma warning disable 0169
		static Delegate GetRemoveEntryByXValue_FHandler ()
		{
			if (cb_removeEntryByXValue_F == null)
				cb_removeEntryByXValue_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, bool>) n_RemoveEntryByXValue_F);
			return cb_removeEntryByXValue_F;
		}

		static bool n_RemoveEntryByXValue_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemoveEntryByXValue (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeEntryByXValue_F;
		public unsafe bool RemoveEntryByXValue (float p0)
		{
			if (id_removeEntryByXValue_F == IntPtr.Zero)
				id_removeEntryByXValue_F = JNIEnv.GetMethodID (class_ref, "removeEntryByXValue", "(F)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeEntryByXValue_F, __args);
		}

		static Delegate cb_removeFirst;
#pragma warning disable 0169
		static Delegate GetRemoveFirstHandler ()
		{
			if (cb_removeFirst == null)
				cb_removeFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_RemoveFirst);
			return cb_removeFirst;
		}

		static bool n_RemoveFirst (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemoveFirst ();
		}
#pragma warning restore 0169

		IntPtr id_removeFirst;
		public unsafe bool RemoveFirst ()
		{
			if (id_removeFirst == IntPtr.Zero)
				id_removeFirst = JNIEnv.GetMethodID (class_ref, "removeFirst", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeFirst);
		}

		static Delegate cb_removeLast;
#pragma warning disable 0169
		static Delegate GetRemoveLastHandler ()
		{
			if (cb_removeLast == null)
				cb_removeLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_RemoveLast);
			return cb_removeLast;
		}

		static bool n_RemoveLast (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemoveLast ();
		}
#pragma warning restore 0169

		IntPtr id_removeLast;
		public unsafe bool RemoveLast ()
		{
			if (id_removeLast == IntPtr.Zero)
				id_removeLast = JNIEnv.GetMethodID (class_ref, "removeLast", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeLast);
		}

		static Delegate cb_setDrawIcons_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawIcons_ZHandler ()
		{
			if (cb_setDrawIcons_Z == null)
				cb_setDrawIcons_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawIcons_Z);
			return cb_setDrawIcons_Z;
		}

		static void n_SetDrawIcons_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawIcons (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDrawIcons_Z;
		public unsafe void SetDrawIcons (bool p0)
		{
			if (id_setDrawIcons_Z == IntPtr.Zero)
				id_setDrawIcons_Z = JNIEnv.GetMethodID (class_ref, "setDrawIcons", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDrawIcons_Z, __args);
		}

		static Delegate cb_setDrawValues_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawValues_ZHandler ()
		{
			if (cb_setDrawValues_Z == null)
				cb_setDrawValues_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawValues_Z);
			return cb_setDrawValues_Z;
		}

		static void n_SetDrawValues_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawValues (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDrawValues_Z;
		public unsafe void SetDrawValues (bool p0)
		{
			if (id_setDrawValues_Z == IntPtr.Zero)
				id_setDrawValues_Z = JNIEnv.GetMethodID (class_ref, "setDrawValues", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDrawValues_Z, __args);
		}

		static Delegate cb_setValueTextColors_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetValueTextColors_Ljava_util_List_Handler ()
		{
			if (cb_setValueTextColors_Ljava_util_List_ == null)
				cb_setValueTextColors_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValueTextColors_Ljava_util_List_);
			return cb_setValueTextColors_Ljava_util_List_;
		}

		static void n_SetValueTextColors_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetValueTextColors (p0);
		}
#pragma warning restore 0169

		IntPtr id_setValueTextColors_Ljava_util_List_;
		public unsafe void SetValueTextColors (global::System.Collections.Generic.IList<global::Java.Lang.Integer> p0)
		{
			if (id_setValueTextColors_Ljava_util_List_ == IntPtr.Zero)
				id_setValueTextColors_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setValueTextColors", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValueTextColors_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
