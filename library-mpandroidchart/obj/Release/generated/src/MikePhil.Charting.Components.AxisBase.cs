using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Components {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/components/AxisBase", DoNotGenerateAcw=true)]
	public abstract partial class AxisBase : global::MikePhil.Charting.Components.ComponentBase {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/field[@name='mAxisMaximum']"
		[Register ("mAxisMaximum")]
		public float MAxisMaximum {
			get {
				const string __id = "mAxisMaximum.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mAxisMaximum.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/field[@name='mAxisMinimum']"
		[Register ("mAxisMinimum")]
		public float MAxisMinimum {
			get {
				const string __id = "mAxisMinimum.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mAxisMinimum.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/field[@name='mAxisRange']"
		[Register ("mAxisRange")]
		public float MAxisRange {
			get {
				const string __id = "mAxisRange.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mAxisRange.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/field[@name='mAxisValueFormatter']"
		[Register ("mAxisValueFormatter")]
		protected global::MikePhil.Charting.Formatter.IAxisValueFormatter MAxisValueFormatter {
			get {
				const string __id = "mAxisValueFormatter.Lcom/github/mikephil/charting/formatter/IAxisValueFormatter;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IAxisValueFormatter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAxisValueFormatter.Lcom/github/mikephil/charting/formatter/IAxisValueFormatter;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/field[@name='mCenterAxisLabels']"
		[Register ("mCenterAxisLabels")]
		protected bool MCenterAxisLabels {
			get {
				const string __id = "mCenterAxisLabels.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mCenterAxisLabels.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/field[@name='mCenteredEntries']"
		[Register ("mCenteredEntries")]
		public IList<float> MCenteredEntries {
			get {
				const string __id = "mCenteredEntries.[F";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<float>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mCenteredEntries.[F";

				IntPtr native_value = global::Android.Runtime.JavaArray<float>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/field[@name='mCustomAxisMax']"
		[Register ("mCustomAxisMax")]
		protected bool MCustomAxisMax {
			get {
				const string __id = "mCustomAxisMax.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mCustomAxisMax.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/field[@name='mCustomAxisMin']"
		[Register ("mCustomAxisMin")]
		protected bool MCustomAxisMin {
			get {
				const string __id = "mCustomAxisMin.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mCustomAxisMin.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/field[@name='mDecimals']"
		[Register ("mDecimals")]
		public int MDecimals {
			get {
				const string __id = "mDecimals.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mDecimals.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/field[@name='mDrawAxisLine']"
		[Register ("mDrawAxisLine")]
		protected bool MDrawAxisLine {
			get {
				const string __id = "mDrawAxisLine.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mDrawAxisLine.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/field[@name='mDrawGridLines']"
		[Register ("mDrawGridLines")]
		protected bool MDrawGridLines {
			get {
				const string __id = "mDrawGridLines.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mDrawGridLines.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/field[@name='mDrawGridLinesBehindData']"
		[Register ("mDrawGridLinesBehindData")]
		protected bool MDrawGridLinesBehindData {
			get {
				const string __id = "mDrawGridLinesBehindData.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mDrawGridLinesBehindData.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/field[@name='mDrawLabels']"
		[Register ("mDrawLabels")]
		protected bool MDrawLabels {
			get {
				const string __id = "mDrawLabels.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mDrawLabels.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/field[@name='mDrawLimitLineBehindData']"
		[Register ("mDrawLimitLineBehindData")]
		protected bool MDrawLimitLineBehindData {
			get {
				const string __id = "mDrawLimitLineBehindData.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mDrawLimitLineBehindData.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/field[@name='mEntries']"
		[Register ("mEntries")]
		public IList<float> MEntries {
			get {
				const string __id = "mEntries.[F";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<float>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mEntries.[F";

				IntPtr native_value = global::Android.Runtime.JavaArray<float>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/field[@name='mEntryCount']"
		[Register ("mEntryCount")]
		public int MEntryCount {
			get {
				const string __id = "mEntryCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mEntryCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/field[@name='mForceLabels']"
		[Register ("mForceLabels")]
		protected bool MForceLabels {
			get {
				const string __id = "mForceLabels.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mForceLabels.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/field[@name='mGranularity']"
		[Register ("mGranularity")]
		protected float MGranularity {
			get {
				const string __id = "mGranularity.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mGranularity.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/field[@name='mGranularityEnabled']"
		[Register ("mGranularityEnabled")]
		protected bool MGranularityEnabled {
			get {
				const string __id = "mGranularityEnabled.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mGranularityEnabled.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/field[@name='mLimitLines']"
		[Register ("mLimitLines")]
		protected global::System.Collections.IList MLimitLines {
			get {
				const string __id = "mLimitLines.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mLimitLines.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/field[@name='mSpaceMax']"
		[Register ("mSpaceMax")]
		protected float MSpaceMax {
			get {
				const string __id = "mSpaceMax.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mSpaceMax.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/field[@name='mSpaceMin']"
		[Register ("mSpaceMin")]
		protected float MSpaceMin {
			get {
				const string __id = "mSpaceMin.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mSpaceMin.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/components/AxisBase", typeof (AxisBase));
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

		protected AxisBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/constructor[@name='AxisBase' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AxisBase ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getAxisLineColor;
#pragma warning disable 0169
		static Delegate GetGetAxisLineColorHandler ()
		{
			if (cb_getAxisLineColor == null)
				cb_getAxisLineColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAxisLineColor);
			return cb_getAxisLineColor;
		}

		static int n_GetAxisLineColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AxisLineColor;
		}
#pragma warning restore 0169

		static Delegate cb_setAxisLineColor_I;
#pragma warning disable 0169
		static Delegate GetSetAxisLineColor_IHandler ()
		{
			if (cb_setAxisLineColor_I == null)
				cb_setAxisLineColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetAxisLineColor_I);
			return cb_setAxisLineColor_I;
		}

		static void n_SetAxisLineColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AxisLineColor = color;
		}
#pragma warning restore 0169

		public virtual unsafe int AxisLineColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='getAxisLineColor' and count(parameter)=0]"
			[Register ("getAxisLineColor", "()I", "GetGetAxisLineColorHandler")]
			get {
				const string __id = "getAxisLineColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='setAxisLineColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setAxisLineColor", "(I)V", "GetSetAxisLineColor_IHandler")]
			set {
				const string __id = "setAxisLineColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAxisLineDashPathEffect;
#pragma warning disable 0169
		static Delegate GetGetAxisLineDashPathEffectHandler ()
		{
			if (cb_getAxisLineDashPathEffect == null)
				cb_getAxisLineDashPathEffect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAxisLineDashPathEffect);
			return cb_getAxisLineDashPathEffect;
		}

		static IntPtr n_GetAxisLineDashPathEffect (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AxisLineDashPathEffect);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.DashPathEffect AxisLineDashPathEffect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='getAxisLineDashPathEffect' and count(parameter)=0]"
			[Register ("getAxisLineDashPathEffect", "()Landroid/graphics/DashPathEffect;", "GetGetAxisLineDashPathEffectHandler")]
			get {
				const string __id = "getAxisLineDashPathEffect.()Landroid/graphics/DashPathEffect;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.DashPathEffect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAxisLineWidth;
#pragma warning disable 0169
		static Delegate GetGetAxisLineWidthHandler ()
		{
			if (cb_getAxisLineWidth == null)
				cb_getAxisLineWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetAxisLineWidth);
			return cb_getAxisLineWidth;
		}

		static float n_GetAxisLineWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AxisLineWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setAxisLineWidth_F;
#pragma warning disable 0169
		static Delegate GetSetAxisLineWidth_FHandler ()
		{
			if (cb_setAxisLineWidth_F == null)
				cb_setAxisLineWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetAxisLineWidth_F);
			return cb_setAxisLineWidth_F;
		}

		static void n_SetAxisLineWidth_F (IntPtr jnienv, IntPtr native__this, float width)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AxisLineWidth = width;
		}
#pragma warning restore 0169

		public virtual unsafe float AxisLineWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='getAxisLineWidth' and count(parameter)=0]"
			[Register ("getAxisLineWidth", "()F", "GetGetAxisLineWidthHandler")]
			get {
				const string __id = "getAxisLineWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='setAxisLineWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setAxisLineWidth", "(F)V", "GetSetAxisLineWidth_FHandler")]
			set {
				const string __id = "setAxisLineWidth.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAxisMaximum;
#pragma warning disable 0169
		static Delegate GetGetAxisMaximumHandler ()
		{
			if (cb_getAxisMaximum == null)
				cb_getAxisMaximum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetAxisMaximum);
			return cb_getAxisMaximum;
		}

		static float n_GetAxisMaximum (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AxisMaximum;
		}
#pragma warning restore 0169

		static Delegate cb_setAxisMaximum_F;
#pragma warning disable 0169
		static Delegate GetSetAxisMaximum_FHandler ()
		{
			if (cb_setAxisMaximum_F == null)
				cb_setAxisMaximum_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetAxisMaximum_F);
			return cb_setAxisMaximum_F;
		}

		static void n_SetAxisMaximum_F (IntPtr jnienv, IntPtr native__this, float max)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AxisMaximum = max;
		}
#pragma warning restore 0169

		public virtual unsafe float AxisMaximum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='getAxisMaximum' and count(parameter)=0]"
			[Register ("getAxisMaximum", "()F", "GetGetAxisMaximumHandler")]
			get {
				const string __id = "getAxisMaximum.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='setAxisMaximum' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setAxisMaximum", "(F)V", "GetSetAxisMaximum_FHandler")]
			set {
				const string __id = "setAxisMaximum.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAxisMinimum;
#pragma warning disable 0169
		static Delegate GetGetAxisMinimumHandler ()
		{
			if (cb_getAxisMinimum == null)
				cb_getAxisMinimum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetAxisMinimum);
			return cb_getAxisMinimum;
		}

		static float n_GetAxisMinimum (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AxisMinimum;
		}
#pragma warning restore 0169

		static Delegate cb_setAxisMinimum_F;
#pragma warning disable 0169
		static Delegate GetSetAxisMinimum_FHandler ()
		{
			if (cb_setAxisMinimum_F == null)
				cb_setAxisMinimum_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetAxisMinimum_F);
			return cb_setAxisMinimum_F;
		}

		static void n_SetAxisMinimum_F (IntPtr jnienv, IntPtr native__this, float min)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AxisMinimum = min;
		}
#pragma warning restore 0169

		public virtual unsafe float AxisMinimum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='getAxisMinimum' and count(parameter)=0]"
			[Register ("getAxisMinimum", "()F", "GetGetAxisMinimumHandler")]
			get {
				const string __id = "getAxisMinimum.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='setAxisMinimum' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setAxisMinimum", "(F)V", "GetSetAxisMinimum_FHandler")]
			set {
				const string __id = "setAxisMinimum.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getGranularity;
#pragma warning disable 0169
		static Delegate GetGetGranularityHandler ()
		{
			if (cb_getGranularity == null)
				cb_getGranularity = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetGranularity);
			return cb_getGranularity;
		}

		static float n_GetGranularity (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Granularity;
		}
#pragma warning restore 0169

		static Delegate cb_setGranularity_F;
#pragma warning disable 0169
		static Delegate GetSetGranularity_FHandler ()
		{
			if (cb_setGranularity_F == null)
				cb_setGranularity_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetGranularity_F);
			return cb_setGranularity_F;
		}

		static void n_SetGranularity_F (IntPtr jnienv, IntPtr native__this, float granularity)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Granularity = granularity;
		}
#pragma warning restore 0169

		public virtual unsafe float Granularity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='getGranularity' and count(parameter)=0]"
			[Register ("getGranularity", "()F", "GetGetGranularityHandler")]
			get {
				const string __id = "getGranularity.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='setGranularity' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setGranularity", "(F)V", "GetSetGranularity_FHandler")]
			set {
				const string __id = "setGranularity.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isGranularityEnabled;
#pragma warning disable 0169
		static Delegate GetIsGranularityEnabledHandler ()
		{
			if (cb_isGranularityEnabled == null)
				cb_isGranularityEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsGranularityEnabled);
			return cb_isGranularityEnabled;
		}

		static bool n_IsGranularityEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GranularityEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setGranularityEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetGranularityEnabled_ZHandler ()
		{
			if (cb_setGranularityEnabled_Z == null)
				cb_setGranularityEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetGranularityEnabled_Z);
			return cb_setGranularityEnabled_Z;
		}

		static void n_SetGranularityEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GranularityEnabled = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool GranularityEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='isGranularityEnabled' and count(parameter)=0]"
			[Register ("isGranularityEnabled", "()Z", "GetIsGranularityEnabledHandler")]
			get {
				const string __id = "isGranularityEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='setGranularityEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setGranularityEnabled", "(Z)V", "GetSetGranularityEnabled_ZHandler")]
			set {
				const string __id = "setGranularityEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getGridColor;
#pragma warning disable 0169
		static Delegate GetGetGridColorHandler ()
		{
			if (cb_getGridColor == null)
				cb_getGridColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetGridColor);
			return cb_getGridColor;
		}

		static int n_GetGridColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GridColor;
		}
#pragma warning restore 0169

		static Delegate cb_setGridColor_I;
#pragma warning disable 0169
		static Delegate GetSetGridColor_IHandler ()
		{
			if (cb_setGridColor_I == null)
				cb_setGridColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetGridColor_I);
			return cb_setGridColor_I;
		}

		static void n_SetGridColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GridColor = color;
		}
#pragma warning restore 0169

		public virtual unsafe int GridColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='getGridColor' and count(parameter)=0]"
			[Register ("getGridColor", "()I", "GetGetGridColorHandler")]
			get {
				const string __id = "getGridColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='setGridColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setGridColor", "(I)V", "GetSetGridColor_IHandler")]
			set {
				const string __id = "setGridColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getGridDashPathEffect;
#pragma warning disable 0169
		static Delegate GetGetGridDashPathEffectHandler ()
		{
			if (cb_getGridDashPathEffect == null)
				cb_getGridDashPathEffect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGridDashPathEffect);
			return cb_getGridDashPathEffect;
		}

		static IntPtr n_GetGridDashPathEffect (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GridDashPathEffect);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.DashPathEffect GridDashPathEffect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='getGridDashPathEffect' and count(parameter)=0]"
			[Register ("getGridDashPathEffect", "()Landroid/graphics/DashPathEffect;", "GetGetGridDashPathEffectHandler")]
			get {
				const string __id = "getGridDashPathEffect.()Landroid/graphics/DashPathEffect;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.DashPathEffect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getGridLineWidth;
#pragma warning disable 0169
		static Delegate GetGetGridLineWidthHandler ()
		{
			if (cb_getGridLineWidth == null)
				cb_getGridLineWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetGridLineWidth);
			return cb_getGridLineWidth;
		}

		static float n_GetGridLineWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GridLineWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setGridLineWidth_F;
#pragma warning disable 0169
		static Delegate GetSetGridLineWidth_FHandler ()
		{
			if (cb_setGridLineWidth_F == null)
				cb_setGridLineWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetGridLineWidth_F);
			return cb_setGridLineWidth_F;
		}

		static void n_SetGridLineWidth_F (IntPtr jnienv, IntPtr native__this, float width)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GridLineWidth = width;
		}
#pragma warning restore 0169

		public virtual unsafe float GridLineWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='getGridLineWidth' and count(parameter)=0]"
			[Register ("getGridLineWidth", "()F", "GetGetGridLineWidthHandler")]
			get {
				const string __id = "getGridLineWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='setGridLineWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setGridLineWidth", "(F)V", "GetSetGridLineWidth_FHandler")]
			set {
				const string __id = "setGridLineWidth.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isAxisLineDashedLineEnabled;
#pragma warning disable 0169
		static Delegate GetIsAxisLineDashedLineEnabledHandler ()
		{
			if (cb_isAxisLineDashedLineEnabled == null)
				cb_isAxisLineDashedLineEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAxisLineDashedLineEnabled);
			return cb_isAxisLineDashedLineEnabled;
		}

		static bool n_IsAxisLineDashedLineEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAxisLineDashedLineEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAxisLineDashedLineEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='isAxisLineDashedLineEnabled' and count(parameter)=0]"
			[Register ("isAxisLineDashedLineEnabled", "()Z", "GetIsAxisLineDashedLineEnabledHandler")]
			get {
				const string __id = "isAxisLineDashedLineEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isAxisMaxCustom;
#pragma warning disable 0169
		static Delegate GetIsAxisMaxCustomHandler ()
		{
			if (cb_isAxisMaxCustom == null)
				cb_isAxisMaxCustom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAxisMaxCustom);
			return cb_isAxisMaxCustom;
		}

		static bool n_IsAxisMaxCustom (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAxisMaxCustom;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAxisMaxCustom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='isAxisMaxCustom' and count(parameter)=0]"
			[Register ("isAxisMaxCustom", "()Z", "GetIsAxisMaxCustomHandler")]
			get {
				const string __id = "isAxisMaxCustom.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isAxisMinCustom;
#pragma warning disable 0169
		static Delegate GetIsAxisMinCustomHandler ()
		{
			if (cb_isAxisMinCustom == null)
				cb_isAxisMinCustom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAxisMinCustom);
			return cb_isAxisMinCustom;
		}

		static bool n_IsAxisMinCustom (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAxisMinCustom;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAxisMinCustom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='isAxisMinCustom' and count(parameter)=0]"
			[Register ("isAxisMinCustom", "()Z", "GetIsAxisMinCustomHandler")]
			get {
				const string __id = "isAxisMinCustom.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isCenterAxisLabelsEnabled;
#pragma warning disable 0169
		static Delegate GetIsCenterAxisLabelsEnabledHandler ()
		{
			if (cb_isCenterAxisLabelsEnabled == null)
				cb_isCenterAxisLabelsEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsCenterAxisLabelsEnabled);
			return cb_isCenterAxisLabelsEnabled;
		}

		static bool n_IsCenterAxisLabelsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsCenterAxisLabelsEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsCenterAxisLabelsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='isCenterAxisLabelsEnabled' and count(parameter)=0]"
			[Register ("isCenterAxisLabelsEnabled", "()Z", "GetIsCenterAxisLabelsEnabledHandler")]
			get {
				const string __id = "isCenterAxisLabelsEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDrawAxisLineEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawAxisLineEnabledHandler ()
		{
			if (cb_isDrawAxisLineEnabled == null)
				cb_isDrawAxisLineEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawAxisLineEnabled);
			return cb_isDrawAxisLineEnabled;
		}

		static bool n_IsDrawAxisLineEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawAxisLineEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrawAxisLineEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='isDrawAxisLineEnabled' and count(parameter)=0]"
			[Register ("isDrawAxisLineEnabled", "()Z", "GetIsDrawAxisLineEnabledHandler")]
			get {
				const string __id = "isDrawAxisLineEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDrawGridLinesBehindDataEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawGridLinesBehindDataEnabledHandler ()
		{
			if (cb_isDrawGridLinesBehindDataEnabled == null)
				cb_isDrawGridLinesBehindDataEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawGridLinesBehindDataEnabled);
			return cb_isDrawGridLinesBehindDataEnabled;
		}

		static bool n_IsDrawGridLinesBehindDataEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawGridLinesBehindDataEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrawGridLinesBehindDataEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='isDrawGridLinesBehindDataEnabled' and count(parameter)=0]"
			[Register ("isDrawGridLinesBehindDataEnabled", "()Z", "GetIsDrawGridLinesBehindDataEnabledHandler")]
			get {
				const string __id = "isDrawGridLinesBehindDataEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDrawGridLinesEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawGridLinesEnabledHandler ()
		{
			if (cb_isDrawGridLinesEnabled == null)
				cb_isDrawGridLinesEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawGridLinesEnabled);
			return cb_isDrawGridLinesEnabled;
		}

		static bool n_IsDrawGridLinesEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawGridLinesEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrawGridLinesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='isDrawGridLinesEnabled' and count(parameter)=0]"
			[Register ("isDrawGridLinesEnabled", "()Z", "GetIsDrawGridLinesEnabledHandler")]
			get {
				const string __id = "isDrawGridLinesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDrawLabelsEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawLabelsEnabledHandler ()
		{
			if (cb_isDrawLabelsEnabled == null)
				cb_isDrawLabelsEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawLabelsEnabled);
			return cb_isDrawLabelsEnabled;
		}

		static bool n_IsDrawLabelsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawLabelsEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrawLabelsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='isDrawLabelsEnabled' and count(parameter)=0]"
			[Register ("isDrawLabelsEnabled", "()Z", "GetIsDrawLabelsEnabledHandler")]
			get {
				const string __id = "isDrawLabelsEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDrawLimitLinesBehindDataEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawLimitLinesBehindDataEnabledHandler ()
		{
			if (cb_isDrawLimitLinesBehindDataEnabled == null)
				cb_isDrawLimitLinesBehindDataEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawLimitLinesBehindDataEnabled);
			return cb_isDrawLimitLinesBehindDataEnabled;
		}

		static bool n_IsDrawLimitLinesBehindDataEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawLimitLinesBehindDataEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrawLimitLinesBehindDataEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='isDrawLimitLinesBehindDataEnabled' and count(parameter)=0]"
			[Register ("isDrawLimitLinesBehindDataEnabled", "()Z", "GetIsDrawLimitLinesBehindDataEnabledHandler")]
			get {
				const string __id = "isDrawLimitLinesBehindDataEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isForceLabelsEnabled;
#pragma warning disable 0169
		static Delegate GetIsForceLabelsEnabledHandler ()
		{
			if (cb_isForceLabelsEnabled == null)
				cb_isForceLabelsEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsForceLabelsEnabled);
			return cb_isForceLabelsEnabled;
		}

		static bool n_IsForceLabelsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsForceLabelsEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsForceLabelsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='isForceLabelsEnabled' and count(parameter)=0]"
			[Register ("isForceLabelsEnabled", "()Z", "GetIsForceLabelsEnabledHandler")]
			get {
				const string __id = "isForceLabelsEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isGridDashedLineEnabled;
#pragma warning disable 0169
		static Delegate GetIsGridDashedLineEnabledHandler ()
		{
			if (cb_isGridDashedLineEnabled == null)
				cb_isGridDashedLineEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsGridDashedLineEnabled);
			return cb_isGridDashedLineEnabled;
		}

		static bool n_IsGridDashedLineEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsGridDashedLineEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsGridDashedLineEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='isGridDashedLineEnabled' and count(parameter)=0]"
			[Register ("isGridDashedLineEnabled", "()Z", "GetIsGridDashedLineEnabledHandler")]
			get {
				const string __id = "isGridDashedLineEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLabelCount;
#pragma warning disable 0169
		static Delegate GetGetLabelCountHandler ()
		{
			if (cb_getLabelCount == null)
				cb_getLabelCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLabelCount);
			return cb_getLabelCount;
		}

		static int n_GetLabelCount (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LabelCount;
		}
#pragma warning restore 0169

		static Delegate cb_setLabelCount_I;
#pragma warning disable 0169
		static Delegate GetSetLabelCount_IHandler ()
		{
			if (cb_setLabelCount_I == null)
				cb_setLabelCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetLabelCount_I);
			return cb_setLabelCount_I;
		}

		static void n_SetLabelCount_I (IntPtr jnienv, IntPtr native__this, int count)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LabelCount = count;
		}
#pragma warning restore 0169

		public virtual unsafe int LabelCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='getLabelCount' and count(parameter)=0]"
			[Register ("getLabelCount", "()I", "GetGetLabelCountHandler")]
			get {
				const string __id = "getLabelCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='setLabelCount' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLabelCount", "(I)V", "GetSetLabelCount_IHandler")]
			set {
				const string __id = "setLabelCount.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLimitLines;
#pragma warning disable 0169
		static Delegate GetGetLimitLinesHandler ()
		{
			if (cb_getLimitLines == null)
				cb_getLimitLines = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLimitLines);
			return cb_getLimitLines;
		}

		static IntPtr n_GetLimitLines (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::MikePhil.Charting.Components.LimitLine>.ToLocalJniHandle (__this.LimitLines);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::MikePhil.Charting.Components.LimitLine> LimitLines {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='getLimitLines' and count(parameter)=0]"
			[Register ("getLimitLines", "()Ljava/util/List;", "GetGetLimitLinesHandler")]
			get {
				const string __id = "getLimitLines.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::MikePhil.Charting.Components.LimitLine>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLongestLabel;
#pragma warning disable 0169
		static Delegate GetGetLongestLabelHandler ()
		{
			if (cb_getLongestLabel == null)
				cb_getLongestLabel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLongestLabel);
			return cb_getLongestLabel;
		}

		static IntPtr n_GetLongestLabel (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.LongestLabel);
		}
#pragma warning restore 0169

		public virtual unsafe string LongestLabel {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='getLongestLabel' and count(parameter)=0]"
			[Register ("getLongestLabel", "()Ljava/lang/String;", "GetGetLongestLabelHandler")]
			get {
				const string __id = "getLongestLabel.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getSpaceMax;
#pragma warning disable 0169
		static Delegate GetGetSpaceMaxHandler ()
		{
			if (cb_getSpaceMax == null)
				cb_getSpaceMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetSpaceMax);
			return cb_getSpaceMax;
		}

		static float n_GetSpaceMax (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SpaceMax;
		}
#pragma warning restore 0169

		static Delegate cb_setSpaceMax_F;
#pragma warning disable 0169
		static Delegate GetSetSpaceMax_FHandler ()
		{
			if (cb_setSpaceMax_F == null)
				cb_setSpaceMax_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetSpaceMax_F);
			return cb_setSpaceMax_F;
		}

		static void n_SetSpaceMax_F (IntPtr jnienv, IntPtr native__this, float mSpaceMax)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SpaceMax = mSpaceMax;
		}
#pragma warning restore 0169

		public virtual unsafe float SpaceMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='getSpaceMax' and count(parameter)=0]"
			[Register ("getSpaceMax", "()F", "GetGetSpaceMaxHandler")]
			get {
				const string __id = "getSpaceMax.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='setSpaceMax' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setSpaceMax", "(F)V", "GetSetSpaceMax_FHandler")]
			set {
				const string __id = "setSpaceMax.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSpaceMin;
#pragma warning disable 0169
		static Delegate GetGetSpaceMinHandler ()
		{
			if (cb_getSpaceMin == null)
				cb_getSpaceMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetSpaceMin);
			return cb_getSpaceMin;
		}

		static float n_GetSpaceMin (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SpaceMin;
		}
#pragma warning restore 0169

		static Delegate cb_setSpaceMin_F;
#pragma warning disable 0169
		static Delegate GetSetSpaceMin_FHandler ()
		{
			if (cb_setSpaceMin_F == null)
				cb_setSpaceMin_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetSpaceMin_F);
			return cb_setSpaceMin_F;
		}

		static void n_SetSpaceMin_F (IntPtr jnienv, IntPtr native__this, float mSpaceMin)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SpaceMin = mSpaceMin;
		}
#pragma warning restore 0169

		public virtual unsafe float SpaceMin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='getSpaceMin' and count(parameter)=0]"
			[Register ("getSpaceMin", "()F", "GetGetSpaceMinHandler")]
			get {
				const string __id = "getSpaceMin.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='setSpaceMin' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setSpaceMin", "(F)V", "GetSetSpaceMin_FHandler")]
			set {
				const string __id = "setSpaceMin.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ValueFormatter);
		}
#pragma warning restore 0169

		static Delegate cb_setValueFormatter_Lcom_github_mikephil_charting_formatter_IAxisValueFormatter_;
#pragma warning disable 0169
		static Delegate GetSetValueFormatter_Lcom_github_mikephil_charting_formatter_IAxisValueFormatter_Handler ()
		{
			if (cb_setValueFormatter_Lcom_github_mikephil_charting_formatter_IAxisValueFormatter_ == null)
				cb_setValueFormatter_Lcom_github_mikephil_charting_formatter_IAxisValueFormatter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValueFormatter_Lcom_github_mikephil_charting_formatter_IAxisValueFormatter_);
			return cb_setValueFormatter_Lcom_github_mikephil_charting_formatter_IAxisValueFormatter_;
		}

		static void n_SetValueFormatter_Lcom_github_mikephil_charting_formatter_IAxisValueFormatter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_f)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Formatter.IAxisValueFormatter f = (global::MikePhil.Charting.Formatter.IAxisValueFormatter)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IAxisValueFormatter> (native_f, JniHandleOwnership.DoNotTransfer);
			__this.ValueFormatter = f;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Formatter.IAxisValueFormatter ValueFormatter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='getValueFormatter' and count(parameter)=0]"
			[Register ("getValueFormatter", "()Lcom/github/mikephil/charting/formatter/IAxisValueFormatter;", "GetGetValueFormatterHandler")]
			get {
				const string __id = "getValueFormatter.()Lcom/github/mikephil/charting/formatter/IAxisValueFormatter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IAxisValueFormatter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='setValueFormatter' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.formatter.IAxisValueFormatter']]"
			[Register ("setValueFormatter", "(Lcom/github/mikephil/charting/formatter/IAxisValueFormatter;)V", "GetSetValueFormatter_Lcom_github_mikephil_charting_formatter_IAxisValueFormatter_Handler")]
			set {
				const string __id = "setValueFormatter.(Lcom/github/mikephil/charting/formatter/IAxisValueFormatter;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_addLimitLine_Lcom_github_mikephil_charting_components_LimitLine_;
#pragma warning disable 0169
		static Delegate GetAddLimitLine_Lcom_github_mikephil_charting_components_LimitLine_Handler ()
		{
			if (cb_addLimitLine_Lcom_github_mikephil_charting_components_LimitLine_ == null)
				cb_addLimitLine_Lcom_github_mikephil_charting_components_LimitLine_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddLimitLine_Lcom_github_mikephil_charting_components_LimitLine_);
			return cb_addLimitLine_Lcom_github_mikephil_charting_components_LimitLine_;
		}

		static void n_AddLimitLine_Lcom_github_mikephil_charting_components_LimitLine_ (IntPtr jnienv, IntPtr native__this, IntPtr native_l)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.LimitLine l = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine> (native_l, JniHandleOwnership.DoNotTransfer);
			__this.AddLimitLine (l);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='addLimitLine' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.LimitLine']]"
		[Register ("addLimitLine", "(Lcom/github/mikephil/charting/components/LimitLine;)V", "GetAddLimitLine_Lcom_github_mikephil_charting_components_LimitLine_Handler")]
		public virtual unsafe void AddLimitLine (global::MikePhil.Charting.Components.LimitLine l)
		{
			const string __id = "addLimitLine.(Lcom/github/mikephil/charting/components/LimitLine;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((l == null) ? IntPtr.Zero : ((global::Java.Lang.Object) l).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_calculate_FF;
#pragma warning disable 0169
		static Delegate GetCalculate_FFHandler ()
		{
			if (cb_calculate_FF == null)
				cb_calculate_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_Calculate_FF);
			return cb_calculate_FF;
		}

		static void n_Calculate_FF (IntPtr jnienv, IntPtr native__this, float dataMin, float dataMax)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Calculate (dataMin, dataMax);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='calculate' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("calculate", "(FF)V", "GetCalculate_FFHandler")]
		public virtual unsafe void Calculate (float dataMin, float dataMax)
		{
			const string __id = "calculate.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (dataMin);
				__args [1] = new JniArgumentValue (dataMax);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_disableAxisLineDashedLine;
#pragma warning disable 0169
		static Delegate GetDisableAxisLineDashedLineHandler ()
		{
			if (cb_disableAxisLineDashedLine == null)
				cb_disableAxisLineDashedLine = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableAxisLineDashedLine);
			return cb_disableAxisLineDashedLine;
		}

		static void n_DisableAxisLineDashedLine (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableAxisLineDashedLine ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='disableAxisLineDashedLine' and count(parameter)=0]"
		[Register ("disableAxisLineDashedLine", "()V", "GetDisableAxisLineDashedLineHandler")]
		public virtual unsafe void DisableAxisLineDashedLine ()
		{
			const string __id = "disableAxisLineDashedLine.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_disableGridDashedLine;
#pragma warning disable 0169
		static Delegate GetDisableGridDashedLineHandler ()
		{
			if (cb_disableGridDashedLine == null)
				cb_disableGridDashedLine = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableGridDashedLine);
			return cb_disableGridDashedLine;
		}

		static void n_DisableGridDashedLine (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableGridDashedLine ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='disableGridDashedLine' and count(parameter)=0]"
		[Register ("disableGridDashedLine", "()V", "GetDisableGridDashedLineHandler")]
		public virtual unsafe void DisableGridDashedLine ()
		{
			const string __id = "disableGridDashedLine.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_enableAxisLineDashedLine_FFF;
#pragma warning disable 0169
		static Delegate GetEnableAxisLineDashedLine_FFFHandler ()
		{
			if (cb_enableAxisLineDashedLine_FFF == null)
				cb_enableAxisLineDashedLine_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float>) n_EnableAxisLineDashedLine_FFF);
			return cb_enableAxisLineDashedLine_FFF;
		}

		static void n_EnableAxisLineDashedLine_FFF (IntPtr jnienv, IntPtr native__this, float lineLength, float spaceLength, float phase)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableAxisLineDashedLine (lineLength, spaceLength, phase);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='enableAxisLineDashedLine' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("enableAxisLineDashedLine", "(FFF)V", "GetEnableAxisLineDashedLine_FFFHandler")]
		public virtual unsafe void EnableAxisLineDashedLine (float lineLength, float spaceLength, float phase)
		{
			const string __id = "enableAxisLineDashedLine.(FFF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (lineLength);
				__args [1] = new JniArgumentValue (spaceLength);
				__args [2] = new JniArgumentValue (phase);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_enableGridDashedLine_FFF;
#pragma warning disable 0169
		static Delegate GetEnableGridDashedLine_FFFHandler ()
		{
			if (cb_enableGridDashedLine_FFF == null)
				cb_enableGridDashedLine_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float>) n_EnableGridDashedLine_FFF);
			return cb_enableGridDashedLine_FFF;
		}

		static void n_EnableGridDashedLine_FFF (IntPtr jnienv, IntPtr native__this, float lineLength, float spaceLength, float phase)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableGridDashedLine (lineLength, spaceLength, phase);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='enableGridDashedLine' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("enableGridDashedLine", "(FFF)V", "GetEnableGridDashedLine_FFFHandler")]
		public virtual unsafe void EnableGridDashedLine (float lineLength, float spaceLength, float phase)
		{
			const string __id = "enableGridDashedLine.(FFF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (lineLength);
				__args [1] = new JniArgumentValue (spaceLength);
				__args [2] = new JniArgumentValue (phase);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getFormattedLabel_I;
#pragma warning disable 0169
		static Delegate GetGetFormattedLabel_IHandler ()
		{
			if (cb_getFormattedLabel_I == null)
				cb_getFormattedLabel_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetFormattedLabel_I);
			return cb_getFormattedLabel_I;
		}

		static IntPtr n_GetFormattedLabel_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetFormattedLabel (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='getFormattedLabel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getFormattedLabel", "(I)Ljava/lang/String;", "GetGetFormattedLabel_IHandler")]
		public virtual unsafe string GetFormattedLabel (int index)
		{
			const string __id = "getFormattedLabel.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeAllLimitLines;
#pragma warning disable 0169
		static Delegate GetRemoveAllLimitLinesHandler ()
		{
			if (cb_removeAllLimitLines == null)
				cb_removeAllLimitLines = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_RemoveAllLimitLines);
			return cb_removeAllLimitLines;
		}

		static void n_RemoveAllLimitLines (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RemoveAllLimitLines ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='removeAllLimitLines' and count(parameter)=0]"
		[Register ("removeAllLimitLines", "()V", "GetRemoveAllLimitLinesHandler")]
		public virtual unsafe void RemoveAllLimitLines ()
		{
			const string __id = "removeAllLimitLines.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeLimitLine_Lcom_github_mikephil_charting_components_LimitLine_;
#pragma warning disable 0169
		static Delegate GetRemoveLimitLine_Lcom_github_mikephil_charting_components_LimitLine_Handler ()
		{
			if (cb_removeLimitLine_Lcom_github_mikephil_charting_components_LimitLine_ == null)
				cb_removeLimitLine_Lcom_github_mikephil_charting_components_LimitLine_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveLimitLine_Lcom_github_mikephil_charting_components_LimitLine_);
			return cb_removeLimitLine_Lcom_github_mikephil_charting_components_LimitLine_;
		}

		static void n_RemoveLimitLine_Lcom_github_mikephil_charting_components_LimitLine_ (IntPtr jnienv, IntPtr native__this, IntPtr native_l)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.LimitLine l = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine> (native_l, JniHandleOwnership.DoNotTransfer);
			__this.RemoveLimitLine (l);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='removeLimitLine' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.LimitLine']]"
		[Register ("removeLimitLine", "(Lcom/github/mikephil/charting/components/LimitLine;)V", "GetRemoveLimitLine_Lcom_github_mikephil_charting_components_LimitLine_Handler")]
		public virtual unsafe void RemoveLimitLine (global::MikePhil.Charting.Components.LimitLine l)
		{
			const string __id = "removeLimitLine.(Lcom/github/mikephil/charting/components/LimitLine;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((l == null) ? IntPtr.Zero : ((global::Java.Lang.Object) l).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_resetAxisMaximum;
#pragma warning disable 0169
		static Delegate GetResetAxisMaximumHandler ()
		{
			if (cb_resetAxisMaximum == null)
				cb_resetAxisMaximum = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetAxisMaximum);
			return cb_resetAxisMaximum;
		}

		static void n_ResetAxisMaximum (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetAxisMaximum ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='resetAxisMaximum' and count(parameter)=0]"
		[Register ("resetAxisMaximum", "()V", "GetResetAxisMaximumHandler")]
		public virtual unsafe void ResetAxisMaximum ()
		{
			const string __id = "resetAxisMaximum.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_resetAxisMinimum;
#pragma warning disable 0169
		static Delegate GetResetAxisMinimumHandler ()
		{
			if (cb_resetAxisMinimum == null)
				cb_resetAxisMinimum = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetAxisMinimum);
			return cb_resetAxisMinimum;
		}

		static void n_ResetAxisMinimum (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetAxisMinimum ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='resetAxisMinimum' and count(parameter)=0]"
		[Register ("resetAxisMinimum", "()V", "GetResetAxisMinimumHandler")]
		public virtual unsafe void ResetAxisMinimum ()
		{
			const string __id = "resetAxisMinimum.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setAxisLineDashedLine_Landroid_graphics_DashPathEffect_;
#pragma warning disable 0169
		static Delegate GetSetAxisLineDashedLine_Landroid_graphics_DashPathEffect_Handler ()
		{
			if (cb_setAxisLineDashedLine_Landroid_graphics_DashPathEffect_ == null)
				cb_setAxisLineDashedLine_Landroid_graphics_DashPathEffect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAxisLineDashedLine_Landroid_graphics_DashPathEffect_);
			return cb_setAxisLineDashedLine_Landroid_graphics_DashPathEffect_;
		}

		static void n_SetAxisLineDashedLine_Landroid_graphics_DashPathEffect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_effect)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.DashPathEffect effect = global::Java.Lang.Object.GetObject<global::Android.Graphics.DashPathEffect> (native_effect, JniHandleOwnership.DoNotTransfer);
			__this.SetAxisLineDashedLine (effect);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='setAxisLineDashedLine' and count(parameter)=1 and parameter[1][@type='android.graphics.DashPathEffect']]"
		[Register ("setAxisLineDashedLine", "(Landroid/graphics/DashPathEffect;)V", "GetSetAxisLineDashedLine_Landroid_graphics_DashPathEffect_Handler")]
		public virtual unsafe void SetAxisLineDashedLine (global::Android.Graphics.DashPathEffect effect)
		{
			const string __id = "setAxisLineDashedLine.(Landroid/graphics/DashPathEffect;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((effect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) effect).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setAxisMaxValue_F;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetAxisMaxValue_FHandler ()
		{
			if (cb_setAxisMaxValue_F == null)
				cb_setAxisMaxValue_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetAxisMaxValue_F);
			return cb_setAxisMaxValue_F;
		}

		[Obsolete]
		static void n_SetAxisMaxValue_F (IntPtr jnienv, IntPtr native__this, float max)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAxisMaxValue (max);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='setAxisMaxValue' and count(parameter)=1 and parameter[1][@type='float']]"
		[Obsolete (@"deprecated")]
		[Register ("setAxisMaxValue", "(F)V", "GetSetAxisMaxValue_FHandler")]
		public virtual unsafe void SetAxisMaxValue (float max)
		{
			const string __id = "setAxisMaxValue.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (max);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setAxisMinValue_F;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetAxisMinValue_FHandler ()
		{
			if (cb_setAxisMinValue_F == null)
				cb_setAxisMinValue_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetAxisMinValue_F);
			return cb_setAxisMinValue_F;
		}

		[Obsolete]
		static void n_SetAxisMinValue_F (IntPtr jnienv, IntPtr native__this, float min)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAxisMinValue (min);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='setAxisMinValue' and count(parameter)=1 and parameter[1][@type='float']]"
		[Obsolete (@"deprecated")]
		[Register ("setAxisMinValue", "(F)V", "GetSetAxisMinValue_FHandler")]
		public virtual unsafe void SetAxisMinValue (float min)
		{
			const string __id = "setAxisMinValue.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (min);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCenterAxisLabels_Z;
#pragma warning disable 0169
		static Delegate GetSetCenterAxisLabels_ZHandler ()
		{
			if (cb_setCenterAxisLabels_Z == null)
				cb_setCenterAxisLabels_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetCenterAxisLabels_Z);
			return cb_setCenterAxisLabels_Z;
		}

		static void n_SetCenterAxisLabels_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCenterAxisLabels (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='setCenterAxisLabels' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setCenterAxisLabels", "(Z)V", "GetSetCenterAxisLabels_ZHandler")]
		public virtual unsafe void SetCenterAxisLabels (bool enabled)
		{
			const string __id = "setCenterAxisLabels.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawAxisLine_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawAxisLine_ZHandler ()
		{
			if (cb_setDrawAxisLine_Z == null)
				cb_setDrawAxisLine_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawAxisLine_Z);
			return cb_setDrawAxisLine_Z;
		}

		static void n_SetDrawAxisLine_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawAxisLine (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='setDrawAxisLine' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawAxisLine", "(Z)V", "GetSetDrawAxisLine_ZHandler")]
		public virtual unsafe void SetDrawAxisLine (bool enabled)
		{
			const string __id = "setDrawAxisLine.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawGridLines_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawGridLines_ZHandler ()
		{
			if (cb_setDrawGridLines_Z == null)
				cb_setDrawGridLines_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawGridLines_Z);
			return cb_setDrawGridLines_Z;
		}

		static void n_SetDrawGridLines_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawGridLines (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='setDrawGridLines' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawGridLines", "(Z)V", "GetSetDrawGridLines_ZHandler")]
		public virtual unsafe void SetDrawGridLines (bool enabled)
		{
			const string __id = "setDrawGridLines.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawGridLinesBehindData_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawGridLinesBehindData_ZHandler ()
		{
			if (cb_setDrawGridLinesBehindData_Z == null)
				cb_setDrawGridLinesBehindData_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawGridLinesBehindData_Z);
			return cb_setDrawGridLinesBehindData_Z;
		}

		static void n_SetDrawGridLinesBehindData_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawGridLinesBehindData (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='setDrawGridLinesBehindData' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawGridLinesBehindData", "(Z)V", "GetSetDrawGridLinesBehindData_ZHandler")]
		public virtual unsafe void SetDrawGridLinesBehindData (bool enabled)
		{
			const string __id = "setDrawGridLinesBehindData.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawLabels_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawLabels_ZHandler ()
		{
			if (cb_setDrawLabels_Z == null)
				cb_setDrawLabels_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawLabels_Z);
			return cb_setDrawLabels_Z;
		}

		static void n_SetDrawLabels_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawLabels (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='setDrawLabels' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawLabels", "(Z)V", "GetSetDrawLabels_ZHandler")]
		public virtual unsafe void SetDrawLabels (bool enabled)
		{
			const string __id = "setDrawLabels.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawLimitLinesBehindData_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawLimitLinesBehindData_ZHandler ()
		{
			if (cb_setDrawLimitLinesBehindData_Z == null)
				cb_setDrawLimitLinesBehindData_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawLimitLinesBehindData_Z);
			return cb_setDrawLimitLinesBehindData_Z;
		}

		static void n_SetDrawLimitLinesBehindData_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawLimitLinesBehindData (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='setDrawLimitLinesBehindData' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawLimitLinesBehindData", "(Z)V", "GetSetDrawLimitLinesBehindData_ZHandler")]
		public virtual unsafe void SetDrawLimitLinesBehindData (bool enabled)
		{
			const string __id = "setDrawLimitLinesBehindData.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setGridDashedLine_Landroid_graphics_DashPathEffect_;
#pragma warning disable 0169
		static Delegate GetSetGridDashedLine_Landroid_graphics_DashPathEffect_Handler ()
		{
			if (cb_setGridDashedLine_Landroid_graphics_DashPathEffect_ == null)
				cb_setGridDashedLine_Landroid_graphics_DashPathEffect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGridDashedLine_Landroid_graphics_DashPathEffect_);
			return cb_setGridDashedLine_Landroid_graphics_DashPathEffect_;
		}

		static void n_SetGridDashedLine_Landroid_graphics_DashPathEffect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_effect)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.DashPathEffect effect = global::Java.Lang.Object.GetObject<global::Android.Graphics.DashPathEffect> (native_effect, JniHandleOwnership.DoNotTransfer);
			__this.SetGridDashedLine (effect);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='setGridDashedLine' and count(parameter)=1 and parameter[1][@type='android.graphics.DashPathEffect']]"
		[Register ("setGridDashedLine", "(Landroid/graphics/DashPathEffect;)V", "GetSetGridDashedLine_Landroid_graphics_DashPathEffect_Handler")]
		public virtual unsafe void SetGridDashedLine (global::Android.Graphics.DashPathEffect effect)
		{
			const string __id = "setGridDashedLine.(Landroid/graphics/DashPathEffect;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((effect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) effect).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setLabelCount_IZ;
#pragma warning disable 0169
		static Delegate GetSetLabelCount_IZHandler ()
		{
			if (cb_setLabelCount_IZ == null)
				cb_setLabelCount_IZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, bool>) n_SetLabelCount_IZ);
			return cb_setLabelCount_IZ;
		}

		static void n_SetLabelCount_IZ (IntPtr jnienv, IntPtr native__this, int count, bool force)
		{
			global::MikePhil.Charting.Components.AxisBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.AxisBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetLabelCount (count, force);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='AxisBase']/method[@name='setLabelCount' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setLabelCount", "(IZ)V", "GetSetLabelCount_IZHandler")]
		public virtual unsafe void SetLabelCount (int count, bool force)
		{
			const string __id = "setLabelCount.(IZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (count);
				__args [1] = new JniArgumentValue (force);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/components/AxisBase", DoNotGenerateAcw=true)]
	internal partial class AxisBaseInvoker : AxisBase {

		public AxisBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/github/mikephil/charting/components/AxisBase", typeof (AxisBaseInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
