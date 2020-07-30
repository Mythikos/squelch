using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/RadarDataSet", DoNotGenerateAcw=true)]
	public partial class RadarDataSet : global::MikePhil.Charting.Data.LineRadarDataSet, global::MikePhil.Charting.Interfaces.Datasets.IRadarDataSet {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']/field[@name='mDrawHighlightCircleEnabled']"
		[Register ("mDrawHighlightCircleEnabled")]
		protected bool MDrawHighlightCircleEnabled {
			get {
				const string __id = "mDrawHighlightCircleEnabled.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mDrawHighlightCircleEnabled.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']/field[@name='mHighlightCircleFillColor']"
		[Register ("mHighlightCircleFillColor")]
		protected int MHighlightCircleFillColor {
			get {
				const string __id = "mHighlightCircleFillColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mHighlightCircleFillColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']/field[@name='mHighlightCircleInnerRadius']"
		[Register ("mHighlightCircleInnerRadius")]
		protected float MHighlightCircleInnerRadius {
			get {
				const string __id = "mHighlightCircleInnerRadius.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mHighlightCircleInnerRadius.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']/field[@name='mHighlightCircleOuterRadius']"
		[Register ("mHighlightCircleOuterRadius")]
		protected float MHighlightCircleOuterRadius {
			get {
				const string __id = "mHighlightCircleOuterRadius.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mHighlightCircleOuterRadius.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']/field[@name='mHighlightCircleStrokeAlpha']"
		[Register ("mHighlightCircleStrokeAlpha")]
		protected int MHighlightCircleStrokeAlpha {
			get {
				const string __id = "mHighlightCircleStrokeAlpha.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mHighlightCircleStrokeAlpha.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']/field[@name='mHighlightCircleStrokeColor']"
		[Register ("mHighlightCircleStrokeColor")]
		protected int MHighlightCircleStrokeColor {
			get {
				const string __id = "mHighlightCircleStrokeColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mHighlightCircleStrokeColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']/field[@name='mHighlightCircleStrokeWidth']"
		[Register ("mHighlightCircleStrokeWidth")]
		protected float MHighlightCircleStrokeWidth {
			get {
				const string __id = "mHighlightCircleStrokeWidth.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mHighlightCircleStrokeWidth.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/RadarDataSet", typeof (RadarDataSet));
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

		protected RadarDataSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']/constructor[@name='RadarDataSet' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.github.mikephil.charting.data.RadarEntry&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/util/List;Ljava/lang/String;)V", "")]
		public unsafe RadarDataSet (global::System.Collections.Generic.IList<global::MikePhil.Charting.Data.RadarEntry> yVals, string label)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_yVals = global::Android.Runtime.JavaList<global::MikePhil.Charting.Data.RadarEntry>.ToLocalJniHandle (yVals);
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_yVals);
				__args [1] = new JniArgumentValue (native_label);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_yVals);
				JNIEnv.DeleteLocalRef (native_label);
			}
		}

		static Delegate cb_isDrawHighlightCircleEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawHighlightCircleEnabledHandler ()
		{
			if (cb_isDrawHighlightCircleEnabled == null)
				cb_isDrawHighlightCircleEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawHighlightCircleEnabled);
			return cb_isDrawHighlightCircleEnabled;
		}

		static bool n_IsDrawHighlightCircleEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.RadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.RadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DrawHighlightCircleEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setDrawHighlightCircleEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawHighlightCircleEnabled_ZHandler ()
		{
			if (cb_setDrawHighlightCircleEnabled_Z == null)
				cb_setDrawHighlightCircleEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawHighlightCircleEnabled_Z);
			return cb_setDrawHighlightCircleEnabled_Z;
		}

		static void n_SetDrawHighlightCircleEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Data.RadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.RadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DrawHighlightCircleEnabled = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool DrawHighlightCircleEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']/method[@name='isDrawHighlightCircleEnabled' and count(parameter)=0]"
			[Register ("isDrawHighlightCircleEnabled", "()Z", "GetIsDrawHighlightCircleEnabledHandler")]
			get {
				const string __id = "isDrawHighlightCircleEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']/method[@name='setDrawHighlightCircleEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDrawHighlightCircleEnabled", "(Z)V", "GetSetDrawHighlightCircleEnabled_ZHandler")]
			set {
				const string __id = "setDrawHighlightCircleEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHighlightCircleFillColor;
#pragma warning disable 0169
		static Delegate GetGetHighlightCircleFillColorHandler ()
		{
			if (cb_getHighlightCircleFillColor == null)
				cb_getHighlightCircleFillColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHighlightCircleFillColor);
			return cb_getHighlightCircleFillColor;
		}

		static int n_GetHighlightCircleFillColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.RadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.RadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighlightCircleFillColor;
		}
#pragma warning restore 0169

		static Delegate cb_setHighlightCircleFillColor_I;
#pragma warning disable 0169
		static Delegate GetSetHighlightCircleFillColor_IHandler ()
		{
			if (cb_setHighlightCircleFillColor_I == null)
				cb_setHighlightCircleFillColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHighlightCircleFillColor_I);
			return cb_setHighlightCircleFillColor_I;
		}

		static void n_SetHighlightCircleFillColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::MikePhil.Charting.Data.RadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.RadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighlightCircleFillColor = color;
		}
#pragma warning restore 0169

		public virtual unsafe int HighlightCircleFillColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']/method[@name='getHighlightCircleFillColor' and count(parameter)=0]"
			[Register ("getHighlightCircleFillColor", "()I", "GetGetHighlightCircleFillColorHandler")]
			get {
				const string __id = "getHighlightCircleFillColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']/method[@name='setHighlightCircleFillColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHighlightCircleFillColor", "(I)V", "GetSetHighlightCircleFillColor_IHandler")]
			set {
				const string __id = "setHighlightCircleFillColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHighlightCircleInnerRadius;
#pragma warning disable 0169
		static Delegate GetGetHighlightCircleInnerRadiusHandler ()
		{
			if (cb_getHighlightCircleInnerRadius == null)
				cb_getHighlightCircleInnerRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetHighlightCircleInnerRadius);
			return cb_getHighlightCircleInnerRadius;
		}

		static float n_GetHighlightCircleInnerRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.RadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.RadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighlightCircleInnerRadius;
		}
#pragma warning restore 0169

		static Delegate cb_setHighlightCircleInnerRadius_F;
#pragma warning disable 0169
		static Delegate GetSetHighlightCircleInnerRadius_FHandler ()
		{
			if (cb_setHighlightCircleInnerRadius_F == null)
				cb_setHighlightCircleInnerRadius_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetHighlightCircleInnerRadius_F);
			return cb_setHighlightCircleInnerRadius_F;
		}

		static void n_SetHighlightCircleInnerRadius_F (IntPtr jnienv, IntPtr native__this, float radius)
		{
			global::MikePhil.Charting.Data.RadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.RadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighlightCircleInnerRadius = radius;
		}
#pragma warning restore 0169

		public virtual unsafe float HighlightCircleInnerRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']/method[@name='getHighlightCircleInnerRadius' and count(parameter)=0]"
			[Register ("getHighlightCircleInnerRadius", "()F", "GetGetHighlightCircleInnerRadiusHandler")]
			get {
				const string __id = "getHighlightCircleInnerRadius.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']/method[@name='setHighlightCircleInnerRadius' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setHighlightCircleInnerRadius", "(F)V", "GetSetHighlightCircleInnerRadius_FHandler")]
			set {
				const string __id = "setHighlightCircleInnerRadius.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHighlightCircleOuterRadius;
#pragma warning disable 0169
		static Delegate GetGetHighlightCircleOuterRadiusHandler ()
		{
			if (cb_getHighlightCircleOuterRadius == null)
				cb_getHighlightCircleOuterRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetHighlightCircleOuterRadius);
			return cb_getHighlightCircleOuterRadius;
		}

		static float n_GetHighlightCircleOuterRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.RadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.RadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighlightCircleOuterRadius;
		}
#pragma warning restore 0169

		static Delegate cb_setHighlightCircleOuterRadius_F;
#pragma warning disable 0169
		static Delegate GetSetHighlightCircleOuterRadius_FHandler ()
		{
			if (cb_setHighlightCircleOuterRadius_F == null)
				cb_setHighlightCircleOuterRadius_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetHighlightCircleOuterRadius_F);
			return cb_setHighlightCircleOuterRadius_F;
		}

		static void n_SetHighlightCircleOuterRadius_F (IntPtr jnienv, IntPtr native__this, float radius)
		{
			global::MikePhil.Charting.Data.RadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.RadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighlightCircleOuterRadius = radius;
		}
#pragma warning restore 0169

		public virtual unsafe float HighlightCircleOuterRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']/method[@name='getHighlightCircleOuterRadius' and count(parameter)=0]"
			[Register ("getHighlightCircleOuterRadius", "()F", "GetGetHighlightCircleOuterRadiusHandler")]
			get {
				const string __id = "getHighlightCircleOuterRadius.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']/method[@name='setHighlightCircleOuterRadius' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setHighlightCircleOuterRadius", "(F)V", "GetSetHighlightCircleOuterRadius_FHandler")]
			set {
				const string __id = "setHighlightCircleOuterRadius.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHighlightCircleStrokeAlpha;
#pragma warning disable 0169
		static Delegate GetGetHighlightCircleStrokeAlphaHandler ()
		{
			if (cb_getHighlightCircleStrokeAlpha == null)
				cb_getHighlightCircleStrokeAlpha = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHighlightCircleStrokeAlpha);
			return cb_getHighlightCircleStrokeAlpha;
		}

		static int n_GetHighlightCircleStrokeAlpha (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.RadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.RadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighlightCircleStrokeAlpha;
		}
#pragma warning restore 0169

		static Delegate cb_setHighlightCircleStrokeAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetHighlightCircleStrokeAlpha_IHandler ()
		{
			if (cb_setHighlightCircleStrokeAlpha_I == null)
				cb_setHighlightCircleStrokeAlpha_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHighlightCircleStrokeAlpha_I);
			return cb_setHighlightCircleStrokeAlpha_I;
		}

		static void n_SetHighlightCircleStrokeAlpha_I (IntPtr jnienv, IntPtr native__this, int alpha)
		{
			global::MikePhil.Charting.Data.RadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.RadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighlightCircleStrokeAlpha = alpha;
		}
#pragma warning restore 0169

		public virtual unsafe int HighlightCircleStrokeAlpha {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']/method[@name='getHighlightCircleStrokeAlpha' and count(parameter)=0]"
			[Register ("getHighlightCircleStrokeAlpha", "()I", "GetGetHighlightCircleStrokeAlphaHandler")]
			get {
				const string __id = "getHighlightCircleStrokeAlpha.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']/method[@name='setHighlightCircleStrokeAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHighlightCircleStrokeAlpha", "(I)V", "GetSetHighlightCircleStrokeAlpha_IHandler")]
			set {
				const string __id = "setHighlightCircleStrokeAlpha.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHighlightCircleStrokeColor;
#pragma warning disable 0169
		static Delegate GetGetHighlightCircleStrokeColorHandler ()
		{
			if (cb_getHighlightCircleStrokeColor == null)
				cb_getHighlightCircleStrokeColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHighlightCircleStrokeColor);
			return cb_getHighlightCircleStrokeColor;
		}

		static int n_GetHighlightCircleStrokeColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.RadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.RadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighlightCircleStrokeColor;
		}
#pragma warning restore 0169

		static Delegate cb_setHighlightCircleStrokeColor_I;
#pragma warning disable 0169
		static Delegate GetSetHighlightCircleStrokeColor_IHandler ()
		{
			if (cb_setHighlightCircleStrokeColor_I == null)
				cb_setHighlightCircleStrokeColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHighlightCircleStrokeColor_I);
			return cb_setHighlightCircleStrokeColor_I;
		}

		static void n_SetHighlightCircleStrokeColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::MikePhil.Charting.Data.RadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.RadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighlightCircleStrokeColor = color;
		}
#pragma warning restore 0169

		public virtual unsafe int HighlightCircleStrokeColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']/method[@name='getHighlightCircleStrokeColor' and count(parameter)=0]"
			[Register ("getHighlightCircleStrokeColor", "()I", "GetGetHighlightCircleStrokeColorHandler")]
			get {
				const string __id = "getHighlightCircleStrokeColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']/method[@name='setHighlightCircleStrokeColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHighlightCircleStrokeColor", "(I)V", "GetSetHighlightCircleStrokeColor_IHandler")]
			set {
				const string __id = "setHighlightCircleStrokeColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHighlightCircleStrokeWidth;
#pragma warning disable 0169
		static Delegate GetGetHighlightCircleStrokeWidthHandler ()
		{
			if (cb_getHighlightCircleStrokeWidth == null)
				cb_getHighlightCircleStrokeWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetHighlightCircleStrokeWidth);
			return cb_getHighlightCircleStrokeWidth;
		}

		static float n_GetHighlightCircleStrokeWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.RadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.RadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighlightCircleStrokeWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setHighlightCircleStrokeWidth_F;
#pragma warning disable 0169
		static Delegate GetSetHighlightCircleStrokeWidth_FHandler ()
		{
			if (cb_setHighlightCircleStrokeWidth_F == null)
				cb_setHighlightCircleStrokeWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetHighlightCircleStrokeWidth_F);
			return cb_setHighlightCircleStrokeWidth_F;
		}

		static void n_SetHighlightCircleStrokeWidth_F (IntPtr jnienv, IntPtr native__this, float strokeWidth)
		{
			global::MikePhil.Charting.Data.RadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.RadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighlightCircleStrokeWidth = strokeWidth;
		}
#pragma warning restore 0169

		public virtual unsafe float HighlightCircleStrokeWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']/method[@name='getHighlightCircleStrokeWidth' and count(parameter)=0]"
			[Register ("getHighlightCircleStrokeWidth", "()F", "GetGetHighlightCircleStrokeWidthHandler")]
			get {
				const string __id = "getHighlightCircleStrokeWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']/method[@name='setHighlightCircleStrokeWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setHighlightCircleStrokeWidth", "(F)V", "GetSetHighlightCircleStrokeWidth_FHandler")]
			set {
				const string __id = "setHighlightCircleStrokeWidth.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_copy;
#pragma warning disable 0169
		static Delegate GetCopyHandler ()
		{
			if (cb_copy == null)
				cb_copy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Copy);
			return cb_copy;
		}

		static IntPtr n_Copy (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.RadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.RadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Copy ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']/method[@name='copy' and count(parameter)=0]"
		[Register ("copy", "()Lcom/github/mikephil/charting/data/DataSet;", "GetCopyHandler")]
		public override unsafe global::MikePhil.Charting.Data.DataSet Copy ()
		{
			const string __id = "copy.()Lcom/github/mikephil/charting/data/DataSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_copy_Lcom_github_mikephil_charting_data_RadarDataSet_;
#pragma warning disable 0169
		static Delegate GetCopy_Lcom_github_mikephil_charting_data_RadarDataSet_Handler ()
		{
			if (cb_copy_Lcom_github_mikephil_charting_data_RadarDataSet_ == null)
				cb_copy_Lcom_github_mikephil_charting_data_RadarDataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Copy_Lcom_github_mikephil_charting_data_RadarDataSet_);
			return cb_copy_Lcom_github_mikephil_charting_data_RadarDataSet_;
		}

		static void n_Copy_Lcom_github_mikephil_charting_data_RadarDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_radarDataSet)
		{
			global::MikePhil.Charting.Data.RadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.RadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.RadarDataSet radarDataSet = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.RadarDataSet> (native_radarDataSet, JniHandleOwnership.DoNotTransfer);
			__this.Copy (radarDataSet);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='RadarDataSet']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.RadarDataSet']]"
		[Register ("copy", "(Lcom/github/mikephil/charting/data/RadarDataSet;)V", "GetCopy_Lcom_github_mikephil_charting_data_RadarDataSet_Handler")]
		protected virtual unsafe void Copy (global::MikePhil.Charting.Data.RadarDataSet radarDataSet)
		{
			const string __id = "copy.(Lcom/github/mikephil/charting/data/RadarDataSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((radarDataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) radarDataSet).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
