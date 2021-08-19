using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Charts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/charts/PieRadarChartBase", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.github.mikephil.charting.data.ChartData<? extends com.github.mikephil.charting.interfaces.datasets.IDataSet<? extends com.github.mikephil.charting.data.Entry>>"})]
	public abstract partial class PieRadarChartBase : global::MikePhil.Charting.Charts.Chart {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/field[@name='mMinOffset']"
		[Register ("mMinOffset")]
		protected float MMinOffset {
			get {
				const string __id = "mMinOffset.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mMinOffset.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/field[@name='mRotateEnabled']"
		[Register ("mRotateEnabled")]
		protected bool MRotateEnabled {
			get {
				const string __id = "mRotateEnabled.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mRotateEnabled.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/charts/PieRadarChartBase", typeof (PieRadarChartBase));

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

		protected PieRadarChartBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/constructor[@name='PieRadarChartBase' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe PieRadarChartBase (global::Android.Content.Context context) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/constructor[@name='PieRadarChartBase' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe PieRadarChartBase (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/constructor[@name='PieRadarChartBase' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe PieRadarChartBase (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_getDiameter;
#pragma warning disable 0169
		static Delegate GetGetDiameterHandler ()
		{
			if (cb_getDiameter == null)
				cb_getDiameter = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetDiameter);
			return cb_getDiameter;
		}

		static float n_GetDiameter (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieRadarChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Diameter;
		}
#pragma warning restore 0169

		public virtual unsafe float Diameter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='getDiameter' and count(parameter)=0]"
			[Register ("getDiameter", "()F", "GetGetDiameterHandler")]
			get {
				const string __id = "getDiameter.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieRadarChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxVisibleCount;
		}
#pragma warning restore 0169

		public override unsafe int MaxVisibleCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='getMaxVisibleCount' and count(parameter)=0]"
			[Register ("getMaxVisibleCount", "()I", "GetGetMaxVisibleCountHandler")]
			get {
				const string __id = "getMaxVisibleCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMinOffset;
#pragma warning disable 0169
		static Delegate GetGetMinOffsetHandler ()
		{
			if (cb_getMinOffset == null)
				cb_getMinOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetMinOffset);
			return cb_getMinOffset;
		}

		static float n_GetMinOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieRadarChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinOffset;
		}
#pragma warning restore 0169

		static Delegate cb_setMinOffset_F;
#pragma warning disable 0169
		static Delegate GetSetMinOffset_FHandler ()
		{
			if (cb_setMinOffset_F == null)
				cb_setMinOffset_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetMinOffset_F);
			return cb_setMinOffset_F;
		}

		static void n_SetMinOffset_F (IntPtr jnienv, IntPtr native__this, float minOffset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieRadarChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinOffset = minOffset;
		}
#pragma warning restore 0169

		public virtual unsafe float MinOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='getMinOffset' and count(parameter)=0]"
			[Register ("getMinOffset", "()F", "GetGetMinOffsetHandler")]
			get {
				const string __id = "getMinOffset.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='setMinOffset' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMinOffset", "(F)V", "GetSetMinOffset_FHandler")]
			set {
				const string __id = "setMinOffset.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRadius;
#pragma warning disable 0169
		static Delegate GetGetRadiusHandler ()
		{
			if (cb_getRadius == null)
				cb_getRadius = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetRadius);
			return cb_getRadius;
		}

		static float n_GetRadius (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieRadarChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Radius;
		}
#pragma warning restore 0169

		public abstract float Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()F", "GetGetRadiusHandler")]
			get; 
		}

		static Delegate cb_getRawRotationAngle;
#pragma warning disable 0169
		static Delegate GetGetRawRotationAngleHandler ()
		{
			if (cb_getRawRotationAngle == null)
				cb_getRawRotationAngle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetRawRotationAngle);
			return cb_getRawRotationAngle;
		}

		static float n_GetRawRotationAngle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieRadarChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RawRotationAngle;
		}
#pragma warning restore 0169

		public virtual unsafe float RawRotationAngle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='getRawRotationAngle' and count(parameter)=0]"
			[Register ("getRawRotationAngle", "()F", "GetGetRawRotationAngleHandler")]
			get {
				const string __id = "getRawRotationAngle.()F";
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
				cb_getRequiredBaseOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetRequiredBaseOffset);
			return cb_getRequiredBaseOffset;
		}

		static float n_GetRequiredBaseOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieRadarChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequiredBaseOffset;
		}
#pragma warning restore 0169

		protected abstract float RequiredBaseOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='getRequiredBaseOffset' and count(parameter)=0]"
			[Register ("getRequiredBaseOffset", "()F", "GetGetRequiredBaseOffsetHandler")]
			get; 
		}

		static Delegate cb_getRequiredLegendOffset;
#pragma warning disable 0169
		static Delegate GetGetRequiredLegendOffsetHandler ()
		{
			if (cb_getRequiredLegendOffset == null)
				cb_getRequiredLegendOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetRequiredLegendOffset);
			return cb_getRequiredLegendOffset;
		}

		static float n_GetRequiredLegendOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieRadarChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequiredLegendOffset;
		}
#pragma warning restore 0169

		protected abstract float RequiredLegendOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='getRequiredLegendOffset' and count(parameter)=0]"
			[Register ("getRequiredLegendOffset", "()F", "GetGetRequiredLegendOffsetHandler")]
			get; 
		}

		static Delegate cb_getRotationAngle;
#pragma warning disable 0169
		static Delegate GetGetRotationAngleHandler ()
		{
			if (cb_getRotationAngle == null)
				cb_getRotationAngle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetRotationAngle);
			return cb_getRotationAngle;
		}

		static float n_GetRotationAngle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieRadarChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RotationAngle;
		}
#pragma warning restore 0169

		static Delegate cb_setRotationAngle_F;
#pragma warning disable 0169
		static Delegate GetSetRotationAngle_FHandler ()
		{
			if (cb_setRotationAngle_F == null)
				cb_setRotationAngle_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetRotationAngle_F);
			return cb_setRotationAngle_F;
		}

		static void n_SetRotationAngle_F (IntPtr jnienv, IntPtr native__this, float angle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieRadarChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RotationAngle = angle;
		}
#pragma warning restore 0169

		public virtual unsafe float RotationAngle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='getRotationAngle' and count(parameter)=0]"
			[Register ("getRotationAngle", "()F", "GetGetRotationAngleHandler")]
			get {
				const string __id = "getRotationAngle.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='setRotationAngle' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setRotationAngle", "(F)V", "GetSetRotationAngle_FHandler")]
			set {
				const string __id = "setRotationAngle.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isRotationEnabled;
#pragma warning disable 0169
		static Delegate GetIsRotationEnabledHandler ()
		{
			if (cb_isRotationEnabled == null)
				cb_isRotationEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsRotationEnabled);
			return cb_isRotationEnabled;
		}

		static bool n_IsRotationEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieRadarChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RotationEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setRotationEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetRotationEnabled_ZHandler ()
		{
			if (cb_setRotationEnabled_Z == null)
				cb_setRotationEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetRotationEnabled_Z);
			return cb_setRotationEnabled_Z;
		}

		static void n_SetRotationEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieRadarChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RotationEnabled = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool RotationEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='isRotationEnabled' and count(parameter)=0]"
			[Register ("isRotationEnabled", "()Z", "GetIsRotationEnabledHandler")]
			get {
				const string __id = "isRotationEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='setRotationEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setRotationEnabled", "(Z)V", "GetSetRotationEnabled_ZHandler")]
			set {
				const string __id = "setRotationEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieRadarChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YChartMax;
		}
#pragma warning restore 0169

		public override unsafe float YChartMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='getYChartMax' and count(parameter)=0]"
			[Register ("getYChartMax", "()F", "GetGetYChartMaxHandler")]
			get {
				const string __id = "getYChartMax.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieRadarChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YChartMin;
		}
#pragma warning restore 0169

		public override unsafe float YChartMin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='getYChartMin' and count(parameter)=0]"
			[Register ("getYChartMin", "()F", "GetGetYChartMinHandler")]
			get {
				const string __id = "getYChartMin.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_calcMinMax;
#pragma warning disable 0169
		static Delegate GetCalcMinMaxHandler ()
		{
			if (cb_calcMinMax == null)
				cb_calcMinMax = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CalcMinMax);
			return cb_calcMinMax;
		}

		static void n_CalcMinMax (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieRadarChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalcMinMax ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='calcMinMax' and count(parameter)=0]"
		[Register ("calcMinMax", "()V", "GetCalcMinMaxHandler")]
		protected override unsafe void CalcMinMax ()
		{
			const string __id = "calcMinMax.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_calculateOffsets;
#pragma warning disable 0169
		static Delegate GetCalculateOffsetsHandler ()
		{
			if (cb_calculateOffsets == null)
				cb_calculateOffsets = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CalculateOffsets);
			return cb_calculateOffsets;
		}

		static void n_CalculateOffsets (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieRadarChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalculateOffsets ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='calculateOffsets' and count(parameter)=0]"
		[Register ("calculateOffsets", "()V", "GetCalculateOffsetsHandler")]
		public override unsafe void CalculateOffsets ()
		{
			const string __id = "calculateOffsets.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_distanceToCenter_FF;
#pragma warning disable 0169
		static Delegate GetDistanceToCenter_FFHandler ()
		{
			if (cb_distanceToCenter_FF == null)
				cb_distanceToCenter_FF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFF_F) n_DistanceToCenter_FF);
			return cb_distanceToCenter_FF;
		}

		static float n_DistanceToCenter_FF (IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieRadarChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DistanceToCenter (x, y);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='distanceToCenter' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("distanceToCenter", "(FF)F", "GetDistanceToCenter_FFHandler")]
		public virtual unsafe float DistanceToCenter (float x, float y)
		{
			const string __id = "distanceToCenter.(FF)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getAngleForPoint_FF;
#pragma warning disable 0169
		static Delegate GetGetAngleForPoint_FFHandler ()
		{
			if (cb_getAngleForPoint_FF == null)
				cb_getAngleForPoint_FF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFF_F) n_GetAngleForPoint_FF);
			return cb_getAngleForPoint_FF;
		}

		static float n_GetAngleForPoint_FF (IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieRadarChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetAngleForPoint (x, y);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='getAngleForPoint' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("getAngleForPoint", "(FF)F", "GetGetAngleForPoint_FFHandler")]
		public virtual unsafe float GetAngleForPoint (float x, float y)
		{
			const string __id = "getAngleForPoint.(FF)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getIndexForAngle_F;
#pragma warning disable 0169
		static Delegate GetGetIndexForAngle_FHandler ()
		{
			if (cb_getIndexForAngle_F == null)
				cb_getIndexForAngle_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_I) n_GetIndexForAngle_F);
			return cb_getIndexForAngle_F;
		}

		static int n_GetIndexForAngle_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieRadarChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetIndexForAngle (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='getIndexForAngle' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getIndexForAngle", "(F)I", "GetGetIndexForAngle_FHandler")]
		public abstract int GetIndexForAngle (float p0);

		static Delegate cb_getPosition_Lcom_github_mikephil_charting_utils_MPPointF_FF;
#pragma warning disable 0169
		static Delegate GetGetPosition_Lcom_github_mikephil_charting_utils_MPPointF_FFHandler ()
		{
			if (cb_getPosition_Lcom_github_mikephil_charting_utils_MPPointF_FF == null)
				cb_getPosition_Lcom_github_mikephil_charting_utils_MPPointF_FF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLFF_L) n_GetPosition_Lcom_github_mikephil_charting_utils_MPPointF_FF);
			return cb_getPosition_Lcom_github_mikephil_charting_utils_MPPointF_FF;
		}

		static IntPtr n_GetPosition_Lcom_github_mikephil_charting_utils_MPPointF_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_center, float dist, float angle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieRadarChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var center = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (native_center, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPosition (center, dist, angle));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='getPosition' and count(parameter)=3 and parameter[1][@type='com.github.mikephil.charting.utils.MPPointF'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("getPosition", "(Lcom/github/mikephil/charting/utils/MPPointF;FF)Lcom/github/mikephil/charting/utils/MPPointF;", "GetGetPosition_Lcom_github_mikephil_charting_utils_MPPointF_FFHandler")]
		public virtual unsafe global::MikePhil.Charting.Util.MPPointF GetPosition (global::MikePhil.Charting.Util.MPPointF center, float dist, float angle)
		{
			const string __id = "getPosition.(Lcom/github/mikephil/charting/utils/MPPointF;FF)Lcom/github/mikephil/charting/utils/MPPointF;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((center == null) ? IntPtr.Zero : ((global::Java.Lang.Object) center).Handle);
				__args [1] = new JniArgumentValue (dist);
				__args [2] = new JniArgumentValue (angle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (center);
			}
		}

		static Delegate cb_getPosition_Lcom_github_mikephil_charting_utils_MPPointF_FFLcom_github_mikephil_charting_utils_MPPointF_;
#pragma warning disable 0169
		static Delegate GetGetPosition_Lcom_github_mikephil_charting_utils_MPPointF_FFLcom_github_mikephil_charting_utils_MPPointF_Handler ()
		{
			if (cb_getPosition_Lcom_github_mikephil_charting_utils_MPPointF_FFLcom_github_mikephil_charting_utils_MPPointF_ == null)
				cb_getPosition_Lcom_github_mikephil_charting_utils_MPPointF_FFLcom_github_mikephil_charting_utils_MPPointF_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLFFL_V) n_GetPosition_Lcom_github_mikephil_charting_utils_MPPointF_FFLcom_github_mikephil_charting_utils_MPPointF_);
			return cb_getPosition_Lcom_github_mikephil_charting_utils_MPPointF_FFLcom_github_mikephil_charting_utils_MPPointF_;
		}

		static void n_GetPosition_Lcom_github_mikephil_charting_utils_MPPointF_FFLcom_github_mikephil_charting_utils_MPPointF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_center, float dist, float angle, IntPtr native_outputPoint)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieRadarChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var center = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (native_center, JniHandleOwnership.DoNotTransfer);
			var outputPoint = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (native_outputPoint, JniHandleOwnership.DoNotTransfer);
			__this.GetPosition (center, dist, angle, outputPoint);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='getPosition' and count(parameter)=4 and parameter[1][@type='com.github.mikephil.charting.utils.MPPointF'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='com.github.mikephil.charting.utils.MPPointF']]"
		[Register ("getPosition", "(Lcom/github/mikephil/charting/utils/MPPointF;FFLcom/github/mikephil/charting/utils/MPPointF;)V", "GetGetPosition_Lcom_github_mikephil_charting_utils_MPPointF_FFLcom_github_mikephil_charting_utils_MPPointF_Handler")]
		public virtual unsafe void GetPosition (global::MikePhil.Charting.Util.MPPointF center, float dist, float angle, global::MikePhil.Charting.Util.MPPointF outputPoint)
		{
			const string __id = "getPosition.(Lcom/github/mikephil/charting/utils/MPPointF;FFLcom/github/mikephil/charting/utils/MPPointF;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((center == null) ? IntPtr.Zero : ((global::Java.Lang.Object) center).Handle);
				__args [1] = new JniArgumentValue (dist);
				__args [2] = new JniArgumentValue (angle);
				__args [3] = new JniArgumentValue ((outputPoint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputPoint).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (center);
				global::System.GC.KeepAlive (outputPoint);
			}
		}

		static Delegate cb_notifyDataSetChanged;
#pragma warning disable 0169
		static Delegate GetNotifyDataSetChangedHandler ()
		{
			if (cb_notifyDataSetChanged == null)
				cb_notifyDataSetChanged = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_NotifyDataSetChanged);
			return cb_notifyDataSetChanged;
		}

		static void n_NotifyDataSetChanged (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieRadarChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDataSetChanged ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='notifyDataSetChanged' and count(parameter)=0]"
		[Register ("notifyDataSetChanged", "()V", "GetNotifyDataSetChangedHandler")]
		public override unsafe void NotifyDataSetChanged ()
		{
			const string __id = "notifyDataSetChanged.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_spin_IFFLcom_github_mikephil_charting_animation_Easing_EasingFunction_;
#pragma warning disable 0169
		static Delegate GetSpin_IFFLcom_github_mikephil_charting_animation_Easing_EasingFunction_Handler ()
		{
			if (cb_spin_IFFLcom_github_mikephil_charting_animation_Easing_EasingFunction_ == null)
				cb_spin_IFFLcom_github_mikephil_charting_animation_Easing_EasingFunction_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIFFL_V) n_Spin_IFFLcom_github_mikephil_charting_animation_Easing_EasingFunction_);
			return cb_spin_IFFLcom_github_mikephil_charting_animation_Easing_EasingFunction_;
		}

		static void n_Spin_IFFLcom_github_mikephil_charting_animation_Easing_EasingFunction_ (IntPtr jnienv, IntPtr native__this, int durationmillis, float fromangle, float toangle, IntPtr native_easing)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieRadarChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var easing = (global::MikePhil.Charting.Animation.Easing.IEasingFunction)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.Easing.IEasingFunction> (native_easing, JniHandleOwnership.DoNotTransfer);
			__this.Spin (durationmillis, fromangle, toangle, easing);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='spin' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='com.github.mikephil.charting.animation.Easing.EasingFunction']]"
		[Register ("spin", "(IFFLcom/github/mikephil/charting/animation/Easing$EasingFunction;)V", "GetSpin_IFFLcom_github_mikephil_charting_animation_Easing_EasingFunction_Handler")]
		public virtual unsafe void Spin (int durationmillis, float fromangle, float toangle, global::MikePhil.Charting.Animation.Easing.IEasingFunction easing)
		{
			const string __id = "spin.(IFFLcom/github/mikephil/charting/animation/Easing$EasingFunction;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (durationmillis);
				__args [1] = new JniArgumentValue (fromangle);
				__args [2] = new JniArgumentValue (toangle);
				__args [3] = new JniArgumentValue ((easing == null) ? IntPtr.Zero : ((global::Java.Lang.Object) easing).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (easing);
			}
		}

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/charts/PieRadarChartBase", DoNotGenerateAcw=true)]
	internal partial class PieRadarChartBaseInvoker : PieRadarChartBase {
		public PieRadarChartBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/charts/PieRadarChartBase", typeof (PieRadarChartBaseInvoker));

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

		public override unsafe float Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()F", "GetGetRadiusHandler")]
			get {
				const string __id = "getRadius.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		protected override unsafe float RequiredBaseOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='getRequiredBaseOffset' and count(parameter)=0]"
			[Register ("getRequiredBaseOffset", "()F", "GetGetRequiredBaseOffsetHandler")]
			get {
				const string __id = "getRequiredBaseOffset.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		protected override unsafe float RequiredLegendOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='getRequiredLegendOffset' and count(parameter)=0]"
			[Register ("getRequiredLegendOffset", "()F", "GetGetRequiredLegendOffsetHandler")]
			get {
				const string __id = "getRequiredLegendOffset.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieRadarChartBase']/method[@name='getIndexForAngle' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getIndexForAngle", "(F)I", "GetGetIndexForAngle_FHandler")]
		public override unsafe int GetIndexForAngle (float p0)
		{
			const string __id = "getIndexForAngle.(F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
