using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Charts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/charts/RadarChart", DoNotGenerateAcw=true)]
	public partial class RadarChart : global::MikePhil.Charting.Charts.PieRadarChartBase {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/field[@name='mXAxisRenderer']"
		[Register ("mXAxisRenderer")]
		protected global::MikePhil.Charting.Renderer.XAxisRendererRadarChart MXAxisRenderer {
			get {
				const string __id = "mXAxisRenderer.Lcom/github/mikephil/charting/renderer/XAxisRendererRadarChart;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.XAxisRendererRadarChart> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mXAxisRenderer.Lcom/github/mikephil/charting/renderer/XAxisRendererRadarChart;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/field[@name='mYAxisRenderer']"
		[Register ("mYAxisRenderer")]
		protected global::MikePhil.Charting.Renderer.YAxisRendererRadarChart MYAxisRenderer {
			get {
				const string __id = "mYAxisRenderer.Lcom/github/mikephil/charting/renderer/YAxisRendererRadarChart;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.YAxisRendererRadarChart> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mYAxisRenderer.Lcom/github/mikephil/charting/renderer/YAxisRendererRadarChart;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/charts/RadarChart", typeof (RadarChart));
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

		protected RadarChart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/constructor[@name='RadarChart' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe RadarChart (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/constructor[@name='RadarChart' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe RadarChart (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/constructor[@name='RadarChart' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe RadarChart (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			}
		}

		static Delegate cb_getFactor;
#pragma warning disable 0169
		static Delegate GetGetFactorHandler ()
		{
			if (cb_getFactor == null)
				cb_getFactor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetFactor);
			return cb_getFactor;
		}

		static float n_GetFactor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.RadarChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.RadarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Factor;
		}
#pragma warning restore 0169

		public virtual unsafe float Factor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/method[@name='getFactor' and count(parameter)=0]"
			[Register ("getFactor", "()F", "GetGetFactorHandler")]
			get {
				const string __id = "getFactor.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRadius;
#pragma warning disable 0169
		static Delegate GetGetRadiusHandler ()
		{
			if (cb_getRadius == null)
				cb_getRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetRadius);
			return cb_getRadius;
		}

		static float n_GetRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.RadarChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.RadarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Radius;
		}
#pragma warning restore 0169

		public override unsafe float Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()F", "GetGetRadiusHandler")]
			get {
				const string __id = "getRadius.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRequiredBaseOffset;
#pragma warning disable 0169
		static Delegate GetGetRequiredBaseOffsetHandler ()
		{
			if (cb_getRequiredBaseOffset == null)
				cb_getRequiredBaseOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetRequiredBaseOffset);
			return cb_getRequiredBaseOffset;
		}

		static float n_GetRequiredBaseOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.RadarChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.RadarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequiredBaseOffset;
		}
#pragma warning restore 0169

		protected override unsafe float RequiredBaseOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/method[@name='getRequiredBaseOffset' and count(parameter)=0]"
			[Register ("getRequiredBaseOffset", "()F", "GetGetRequiredBaseOffsetHandler")]
			get {
				const string __id = "getRequiredBaseOffset.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRequiredLegendOffset;
#pragma warning disable 0169
		static Delegate GetGetRequiredLegendOffsetHandler ()
		{
			if (cb_getRequiredLegendOffset == null)
				cb_getRequiredLegendOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetRequiredLegendOffset);
			return cb_getRequiredLegendOffset;
		}

		static float n_GetRequiredLegendOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.RadarChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.RadarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequiredLegendOffset;
		}
#pragma warning restore 0169

		protected override unsafe float RequiredLegendOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/method[@name='getRequiredLegendOffset' and count(parameter)=0]"
			[Register ("getRequiredLegendOffset", "()F", "GetGetRequiredLegendOffsetHandler")]
			get {
				const string __id = "getRequiredLegendOffset.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSkipWebLineCount;
#pragma warning disable 0169
		static Delegate GetGetSkipWebLineCountHandler ()
		{
			if (cb_getSkipWebLineCount == null)
				cb_getSkipWebLineCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetSkipWebLineCount);
			return cb_getSkipWebLineCount;
		}

		static int n_GetSkipWebLineCount (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.RadarChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.RadarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SkipWebLineCount;
		}
#pragma warning restore 0169

		static Delegate cb_setSkipWebLineCount_I;
#pragma warning disable 0169
		static Delegate GetSetSkipWebLineCount_IHandler ()
		{
			if (cb_setSkipWebLineCount_I == null)
				cb_setSkipWebLineCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetSkipWebLineCount_I);
			return cb_setSkipWebLineCount_I;
		}

		static void n_SetSkipWebLineCount_I (IntPtr jnienv, IntPtr native__this, int count)
		{
			global::MikePhil.Charting.Charts.RadarChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.RadarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SkipWebLineCount = count;
		}
#pragma warning restore 0169

		public virtual unsafe int SkipWebLineCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/method[@name='getSkipWebLineCount' and count(parameter)=0]"
			[Register ("getSkipWebLineCount", "()I", "GetGetSkipWebLineCountHandler")]
			get {
				const string __id = "getSkipWebLineCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/method[@name='setSkipWebLineCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setSkipWebLineCount", "(I)V", "GetSetSkipWebLineCount_IHandler")]
			set {
				const string __id = "setSkipWebLineCount.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSliceAngle;
#pragma warning disable 0169
		static Delegate GetGetSliceAngleHandler ()
		{
			if (cb_getSliceAngle == null)
				cb_getSliceAngle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetSliceAngle);
			return cb_getSliceAngle;
		}

		static float n_GetSliceAngle (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.RadarChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.RadarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SliceAngle;
		}
#pragma warning restore 0169

		public virtual unsafe float SliceAngle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/method[@name='getSliceAngle' and count(parameter)=0]"
			[Register ("getSliceAngle", "()F", "GetGetSliceAngleHandler")]
			get {
				const string __id = "getSliceAngle.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getWebAlpha;
#pragma warning disable 0169
		static Delegate GetGetWebAlphaHandler ()
		{
			if (cb_getWebAlpha == null)
				cb_getWebAlpha = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWebAlpha);
			return cb_getWebAlpha;
		}

		static int n_GetWebAlpha (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.RadarChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.RadarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WebAlpha;
		}
#pragma warning restore 0169

		static Delegate cb_setWebAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetWebAlpha_IHandler ()
		{
			if (cb_setWebAlpha_I == null)
				cb_setWebAlpha_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetWebAlpha_I);
			return cb_setWebAlpha_I;
		}

		static void n_SetWebAlpha_I (IntPtr jnienv, IntPtr native__this, int alpha)
		{
			global::MikePhil.Charting.Charts.RadarChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.RadarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WebAlpha = alpha;
		}
#pragma warning restore 0169

		public virtual unsafe int WebAlpha {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/method[@name='getWebAlpha' and count(parameter)=0]"
			[Register ("getWebAlpha", "()I", "GetGetWebAlphaHandler")]
			get {
				const string __id = "getWebAlpha.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/method[@name='setWebAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWebAlpha", "(I)V", "GetSetWebAlpha_IHandler")]
			set {
				const string __id = "setWebAlpha.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWebColor;
#pragma warning disable 0169
		static Delegate GetGetWebColorHandler ()
		{
			if (cb_getWebColor == null)
				cb_getWebColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWebColor);
			return cb_getWebColor;
		}

		static int n_GetWebColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.RadarChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.RadarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WebColor;
		}
#pragma warning restore 0169

		static Delegate cb_setWebColor_I;
#pragma warning disable 0169
		static Delegate GetSetWebColor_IHandler ()
		{
			if (cb_setWebColor_I == null)
				cb_setWebColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetWebColor_I);
			return cb_setWebColor_I;
		}

		static void n_SetWebColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::MikePhil.Charting.Charts.RadarChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.RadarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WebColor = color;
		}
#pragma warning restore 0169

		public virtual unsafe int WebColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/method[@name='getWebColor' and count(parameter)=0]"
			[Register ("getWebColor", "()I", "GetGetWebColorHandler")]
			get {
				const string __id = "getWebColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/method[@name='setWebColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWebColor", "(I)V", "GetSetWebColor_IHandler")]
			set {
				const string __id = "setWebColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWebColorInner;
#pragma warning disable 0169
		static Delegate GetGetWebColorInnerHandler ()
		{
			if (cb_getWebColorInner == null)
				cb_getWebColorInner = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetWebColorInner);
			return cb_getWebColorInner;
		}

		static int n_GetWebColorInner (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.RadarChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.RadarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WebColorInner;
		}
#pragma warning restore 0169

		static Delegate cb_setWebColorInner_I;
#pragma warning disable 0169
		static Delegate GetSetWebColorInner_IHandler ()
		{
			if (cb_setWebColorInner_I == null)
				cb_setWebColorInner_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetWebColorInner_I);
			return cb_setWebColorInner_I;
		}

		static void n_SetWebColorInner_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::MikePhil.Charting.Charts.RadarChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.RadarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WebColorInner = color;
		}
#pragma warning restore 0169

		public virtual unsafe int WebColorInner {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/method[@name='getWebColorInner' and count(parameter)=0]"
			[Register ("getWebColorInner", "()I", "GetGetWebColorInnerHandler")]
			get {
				const string __id = "getWebColorInner.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/method[@name='setWebColorInner' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setWebColorInner", "(I)V", "GetSetWebColorInner_IHandler")]
			set {
				const string __id = "setWebColorInner.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWebLineWidth;
#pragma warning disable 0169
		static Delegate GetGetWebLineWidthHandler ()
		{
			if (cb_getWebLineWidth == null)
				cb_getWebLineWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetWebLineWidth);
			return cb_getWebLineWidth;
		}

		static float n_GetWebLineWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.RadarChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.RadarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WebLineWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setWebLineWidth_F;
#pragma warning disable 0169
		static Delegate GetSetWebLineWidth_FHandler ()
		{
			if (cb_setWebLineWidth_F == null)
				cb_setWebLineWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetWebLineWidth_F);
			return cb_setWebLineWidth_F;
		}

		static void n_SetWebLineWidth_F (IntPtr jnienv, IntPtr native__this, float width)
		{
			global::MikePhil.Charting.Charts.RadarChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.RadarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WebLineWidth = width;
		}
#pragma warning restore 0169

		public virtual unsafe float WebLineWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/method[@name='getWebLineWidth' and count(parameter)=0]"
			[Register ("getWebLineWidth", "()F", "GetGetWebLineWidthHandler")]
			get {
				const string __id = "getWebLineWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/method[@name='setWebLineWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setWebLineWidth", "(F)V", "GetSetWebLineWidth_FHandler")]
			set {
				const string __id = "setWebLineWidth.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getWebLineWidthInner;
#pragma warning disable 0169
		static Delegate GetGetWebLineWidthInnerHandler ()
		{
			if (cb_getWebLineWidthInner == null)
				cb_getWebLineWidthInner = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetWebLineWidthInner);
			return cb_getWebLineWidthInner;
		}

		static float n_GetWebLineWidthInner (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.RadarChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.RadarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WebLineWidthInner;
		}
#pragma warning restore 0169

		static Delegate cb_setWebLineWidthInner_F;
#pragma warning disable 0169
		static Delegate GetSetWebLineWidthInner_FHandler ()
		{
			if (cb_setWebLineWidthInner_F == null)
				cb_setWebLineWidthInner_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetWebLineWidthInner_F);
			return cb_setWebLineWidthInner_F;
		}

		static void n_SetWebLineWidthInner_F (IntPtr jnienv, IntPtr native__this, float width)
		{
			global::MikePhil.Charting.Charts.RadarChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.RadarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WebLineWidthInner = width;
		}
#pragma warning restore 0169

		public virtual unsafe float WebLineWidthInner {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/method[@name='getWebLineWidthInner' and count(parameter)=0]"
			[Register ("getWebLineWidthInner", "()F", "GetGetWebLineWidthInnerHandler")]
			get {
				const string __id = "getWebLineWidthInner.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/method[@name='setWebLineWidthInner' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setWebLineWidthInner", "(F)V", "GetSetWebLineWidthInner_FHandler")]
			set {
				const string __id = "setWebLineWidthInner.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getYAxis;
#pragma warning disable 0169
		static Delegate GetGetYAxisHandler ()
		{
			if (cb_getYAxis == null)
				cb_getYAxis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetYAxis);
			return cb_getYAxis;
		}

		static IntPtr n_GetYAxis (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.RadarChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.RadarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.YAxis);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Components.YAxis YAxis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/method[@name='getYAxis' and count(parameter)=0]"
			[Register ("getYAxis", "()Lcom/github/mikephil/charting/components/YAxis;", "GetGetYAxisHandler")]
			get {
				const string __id = "getYAxis.()Lcom/github/mikephil/charting/components/YAxis;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getYRange;
#pragma warning disable 0169
		static Delegate GetGetYRangeHandler ()
		{
			if (cb_getYRange == null)
				cb_getYRange = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetYRange);
			return cb_getYRange;
		}

		static float n_GetYRange (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.RadarChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.RadarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YRange;
		}
#pragma warning restore 0169

		public virtual unsafe float YRange {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/method[@name='getYRange' and count(parameter)=0]"
			[Register ("getYRange", "()F", "GetGetYRangeHandler")]
			get {
				const string __id = "getYRange.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getIndexForAngle_F;
#pragma warning disable 0169
		static Delegate GetGetIndexForAngle_FHandler ()
		{
			if (cb_getIndexForAngle_F == null)
				cb_getIndexForAngle_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, int>) n_GetIndexForAngle_F);
			return cb_getIndexForAngle_F;
		}

		static int n_GetIndexForAngle_F (IntPtr jnienv, IntPtr native__this, float angle)
		{
			global::MikePhil.Charting.Charts.RadarChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.RadarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetIndexForAngle (angle);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/method[@name='getIndexForAngle' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getIndexForAngle", "(F)I", "GetGetIndexForAngle_FHandler")]
		public override unsafe int GetIndexForAngle (float angle)
		{
			const string __id = "getIndexForAngle.(F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (angle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setDrawWeb_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawWeb_ZHandler ()
		{
			if (cb_setDrawWeb_Z == null)
				cb_setDrawWeb_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawWeb_Z);
			return cb_setDrawWeb_Z;
		}

		static void n_SetDrawWeb_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.RadarChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.RadarChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawWeb (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='RadarChart']/method[@name='setDrawWeb' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawWeb", "(Z)V", "GetSetDrawWeb_ZHandler")]
		public virtual unsafe void SetDrawWeb (bool enabled)
		{
			const string __id = "setDrawWeb.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
