using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/LineDataSet", DoNotGenerateAcw=true)]
	public partial class LineDataSet : global::MikePhil.Charting.Data.LineRadarDataSet, global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet.Mode']"
		[global::Android.Runtime.Register ("com/github/mikephil/charting/data/LineDataSet$Mode", DoNotGenerateAcw=true)]
		public sealed partial class Mode : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet.Mode']/field[@name='CUBIC_BEZIER']"
			[Register ("CUBIC_BEZIER")]
			public static global::MikePhil.Charting.Data.LineDataSet.Mode CubicBezier {
				get {
					const string __id = "CUBIC_BEZIER.Lcom/github/mikephil/charting/data/LineDataSet$Mode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet.Mode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet.Mode']/field[@name='HORIZONTAL_BEZIER']"
			[Register ("HORIZONTAL_BEZIER")]
			public static global::MikePhil.Charting.Data.LineDataSet.Mode HorizontalBezier {
				get {
					const string __id = "HORIZONTAL_BEZIER.Lcom/github/mikephil/charting/data/LineDataSet$Mode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet.Mode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet.Mode']/field[@name='LINEAR']"
			[Register ("LINEAR")]
			public static global::MikePhil.Charting.Data.LineDataSet.Mode Linear {
				get {
					const string __id = "LINEAR.Lcom/github/mikephil/charting/data/LineDataSet$Mode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet.Mode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet.Mode']/field[@name='STEPPED']"
			[Register ("STEPPED")]
			public static global::MikePhil.Charting.Data.LineDataSet.Mode Stepped {
				get {
					const string __id = "STEPPED.Lcom/github/mikephil/charting/data/LineDataSet$Mode;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet.Mode> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/data/LineDataSet$Mode", typeof (Mode));
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

			internal Mode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet.Mode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/github/mikephil/charting/data/LineDataSet$Mode;", "")]
			public static unsafe global::MikePhil.Charting.Data.LineDataSet.Mode ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/github/mikephil/charting/data/LineDataSet$Mode;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet.Mode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet.Mode']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/github/mikephil/charting/data/LineDataSet$Mode;", "")]
			public static unsafe global::MikePhil.Charting.Data.LineDataSet.Mode[] Values ()
			{
				const string __id = "values.()[Lcom/github/mikephil/charting/data/LineDataSet$Mode;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::MikePhil.Charting.Data.LineDataSet.Mode[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::MikePhil.Charting.Data.LineDataSet.Mode));
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/data/LineDataSet", typeof (LineDataSet));
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

		protected LineDataSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/constructor[@name='LineDataSet' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.github.mikephil.charting.data.Entry&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/util/List;Ljava/lang/String;)V", "")]
		public unsafe LineDataSet (global::System.Collections.Generic.IList<global::MikePhil.Charting.Data.Entry> yVals, string label)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_yVals = global::Android.Runtime.JavaList<global::MikePhil.Charting.Data.Entry>.ToLocalJniHandle (yVals);
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
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CircleColorCount;
		}
#pragma warning restore 0169

		public virtual unsafe int CircleColorCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='getCircleColorCount' and count(parameter)=0]"
			[Register ("getCircleColorCount", "()I", "GetGetCircleColorCountHandler")]
			get {
				const string __id = "getCircleColorCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getCircleColors;
#pragma warning disable 0169
		static Delegate GetGetCircleColorsHandler ()
		{
			if (cb_getCircleColors == null)
				cb_getCircleColors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCircleColors);
			return cb_getCircleColors;
		}

		static IntPtr n_GetCircleColors (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (__this.CircleColors);
		}
#pragma warning restore 0169

		static Delegate cb_setCircleColors_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetCircleColors_Ljava_util_List_Handler ()
		{
			if (cb_setCircleColors_Ljava_util_List_ == null)
				cb_setCircleColors_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCircleColors_Ljava_util_List_);
			return cb_setCircleColors_Ljava_util_List_;
		}

		static void n_SetCircleColors_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_colors)
		{
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var colors = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (native_colors, JniHandleOwnership.DoNotTransfer);
			__this.CircleColors = colors;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Lang.Integer> CircleColors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='getCircleColors' and count(parameter)=0]"
			[Register ("getCircleColors", "()Ljava/util/List;", "GetGetCircleColorsHandler")]
			get {
				const string __id = "getCircleColors.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='setCircleColors' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Integer&gt;']]"
			[Register ("setCircleColors", "(Ljava/util/List;)V", "GetSetCircleColors_Ljava_util_List_Handler")]
			set {
				const string __id = "setCircleColors.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
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
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CircleHoleColor;
		}
#pragma warning restore 0169

		static Delegate cb_setCircleHoleColor_I;
#pragma warning disable 0169
		static Delegate GetSetCircleHoleColor_IHandler ()
		{
			if (cb_setCircleHoleColor_I == null)
				cb_setCircleHoleColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCircleHoleColor_I);
			return cb_setCircleHoleColor_I;
		}

		static void n_SetCircleHoleColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CircleHoleColor = color;
		}
#pragma warning restore 0169

		public virtual unsafe int CircleHoleColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='getCircleHoleColor' and count(parameter)=0]"
			[Register ("getCircleHoleColor", "()I", "GetGetCircleHoleColorHandler")]
			get {
				const string __id = "getCircleHoleColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='setCircleHoleColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setCircleHoleColor", "(I)V", "GetSetCircleHoleColor_IHandler")]
			set {
				const string __id = "setCircleHoleColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CircleHoleRadius;
		}
#pragma warning restore 0169

		static Delegate cb_setCircleHoleRadius_F;
#pragma warning disable 0169
		static Delegate GetSetCircleHoleRadius_FHandler ()
		{
			if (cb_setCircleHoleRadius_F == null)
				cb_setCircleHoleRadius_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetCircleHoleRadius_F);
			return cb_setCircleHoleRadius_F;
		}

		static void n_SetCircleHoleRadius_F (IntPtr jnienv, IntPtr native__this, float holeRadius)
		{
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CircleHoleRadius = holeRadius;
		}
#pragma warning restore 0169

		public virtual unsafe float CircleHoleRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='getCircleHoleRadius' and count(parameter)=0]"
			[Register ("getCircleHoleRadius", "()F", "GetGetCircleHoleRadiusHandler")]
			get {
				const string __id = "getCircleHoleRadius.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='setCircleHoleRadius' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setCircleHoleRadius", "(F)V", "GetSetCircleHoleRadius_FHandler")]
			set {
				const string __id = "setCircleHoleRadius.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CircleRadius;
		}
#pragma warning restore 0169

		static Delegate cb_setCircleRadius_F;
#pragma warning disable 0169
		static Delegate GetSetCircleRadius_FHandler ()
		{
			if (cb_setCircleRadius_F == null)
				cb_setCircleRadius_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetCircleRadius_F);
			return cb_setCircleRadius_F;
		}

		static void n_SetCircleRadius_F (IntPtr jnienv, IntPtr native__this, float radius)
		{
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CircleRadius = radius;
		}
#pragma warning restore 0169

		public virtual unsafe float CircleRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='getCircleRadius' and count(parameter)=0]"
			[Register ("getCircleRadius", "()F", "GetGetCircleRadiusHandler")]
			get {
				const string __id = "getCircleRadius.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='setCircleRadius' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setCircleRadius", "(F)V", "GetSetCircleRadius_FHandler")]
			set {
				const string __id = "setCircleRadius.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCircleSize;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetCircleSizeHandler ()
		{
			if (cb_getCircleSize == null)
				cb_getCircleSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetCircleSize);
			return cb_getCircleSize;
		}

		[Obsolete]
		static float n_GetCircleSize (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CircleSize;
		}
#pragma warning restore 0169

		static Delegate cb_setCircleSize_F;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetCircleSize_FHandler ()
		{
			if (cb_setCircleSize_F == null)
				cb_setCircleSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetCircleSize_F);
			return cb_setCircleSize_F;
		}

		[Obsolete]
		static void n_SetCircleSize_F (IntPtr jnienv, IntPtr native__this, float size)
		{
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CircleSize = size;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe float CircleSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='getCircleSize' and count(parameter)=0]"
			[Register ("getCircleSize", "()F", "GetGetCircleSizeHandler")]
			get {
				const string __id = "getCircleSize.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='setCircleSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setCircleSize", "(F)V", "GetSetCircleSize_FHandler")]
			set {
				const string __id = "setCircleSize.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CubicIntensity;
		}
#pragma warning restore 0169

		static Delegate cb_setCubicIntensity_F;
#pragma warning disable 0169
		static Delegate GetSetCubicIntensity_FHandler ()
		{
			if (cb_setCubicIntensity_F == null)
				cb_setCubicIntensity_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetCubicIntensity_F);
			return cb_setCubicIntensity_F;
		}

		static void n_SetCubicIntensity_F (IntPtr jnienv, IntPtr native__this, float intensity)
		{
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CubicIntensity = intensity;
		}
#pragma warning restore 0169

		public virtual unsafe float CubicIntensity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='getCubicIntensity' and count(parameter)=0]"
			[Register ("getCubicIntensity", "()F", "GetGetCubicIntensityHandler")]
			get {
				const string __id = "getCubicIntensity.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='setCubicIntensity' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setCubicIntensity", "(F)V", "GetSetCubicIntensity_FHandler")]
			set {
				const string __id = "setCubicIntensity.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DashPathEffect);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.DashPathEffect DashPathEffect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='getDashPathEffect' and count(parameter)=0]"
			[Register ("getDashPathEffect", "()Landroid/graphics/DashPathEffect;", "GetGetDashPathEffectHandler")]
			get {
				const string __id = "getDashPathEffect.()Landroid/graphics/DashPathEffect;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.DashPathEffect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FillFormatter);
		}
#pragma warning restore 0169

		static Delegate cb_setFillFormatter_Lcom_github_mikephil_charting_formatter_IFillFormatter_;
#pragma warning disable 0169
		static Delegate GetSetFillFormatter_Lcom_github_mikephil_charting_formatter_IFillFormatter_Handler ()
		{
			if (cb_setFillFormatter_Lcom_github_mikephil_charting_formatter_IFillFormatter_ == null)
				cb_setFillFormatter_Lcom_github_mikephil_charting_formatter_IFillFormatter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFillFormatter_Lcom_github_mikephil_charting_formatter_IFillFormatter_);
			return cb_setFillFormatter_Lcom_github_mikephil_charting_formatter_IFillFormatter_;
		}

		static void n_SetFillFormatter_Lcom_github_mikephil_charting_formatter_IFillFormatter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_formatter)
		{
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Formatter.IFillFormatter formatter = (global::MikePhil.Charting.Formatter.IFillFormatter)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IFillFormatter> (native_formatter, JniHandleOwnership.DoNotTransfer);
			__this.FillFormatter = formatter;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Formatter.IFillFormatter FillFormatter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='getFillFormatter' and count(parameter)=0]"
			[Register ("getFillFormatter", "()Lcom/github/mikephil/charting/formatter/IFillFormatter;", "GetGetFillFormatterHandler")]
			get {
				const string __id = "getFillFormatter.()Lcom/github/mikephil/charting/formatter/IFillFormatter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IFillFormatter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='setFillFormatter' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.formatter.IFillFormatter']]"
			[Register ("setFillFormatter", "(Lcom/github/mikephil/charting/formatter/IFillFormatter;)V", "GetSetFillFormatter_Lcom_github_mikephil_charting_formatter_IFillFormatter_Handler")]
			set {
				const string __id = "setFillFormatter.(Lcom/github/mikephil/charting/formatter/IFillFormatter;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDashedLineEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDashedLineEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='isDashedLineEnabled' and count(parameter)=0]"
			[Register ("isDashedLineEnabled", "()Z", "GetIsDashedLineEnabledHandler")]
			get {
				const string __id = "isDashedLineEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawCircleHoleEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrawCircleHoleEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='isDrawCircleHoleEnabled' and count(parameter)=0]"
			[Register ("isDrawCircleHoleEnabled", "()Z", "GetIsDrawCircleHoleEnabledHandler")]
			get {
				const string __id = "isDrawCircleHoleEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawCirclesEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrawCirclesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='isDrawCirclesEnabled' and count(parameter)=0]"
			[Register ("isDrawCirclesEnabled", "()Z", "GetIsDrawCirclesEnabledHandler")]
			get {
				const string __id = "isDrawCirclesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawCubicEnabled;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe bool IsDrawCubicEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='isDrawCubicEnabled' and count(parameter)=0]"
			[Register ("isDrawCubicEnabled", "()Z", "GetIsDrawCubicEnabledHandler")]
			get {
				const string __id = "isDrawCubicEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawSteppedEnabled;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe bool IsDrawSteppedEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='isDrawSteppedEnabled' and count(parameter)=0]"
			[Register ("isDrawSteppedEnabled", "()Z", "GetIsDrawSteppedEnabledHandler")]
			get {
				const string __id = "isDrawSteppedEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
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
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Copy ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='copy' and count(parameter)=0]"
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

		static Delegate cb_copy_Lcom_github_mikephil_charting_data_LineDataSet_;
#pragma warning disable 0169
		static Delegate GetCopy_Lcom_github_mikephil_charting_data_LineDataSet_Handler ()
		{
			if (cb_copy_Lcom_github_mikephil_charting_data_LineDataSet_ == null)
				cb_copy_Lcom_github_mikephil_charting_data_LineDataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Copy_Lcom_github_mikephil_charting_data_LineDataSet_);
			return cb_copy_Lcom_github_mikephil_charting_data_LineDataSet_;
		}

		static void n_Copy_Lcom_github_mikephil_charting_data_LineDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_lineDataSet)
		{
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.LineDataSet lineDataSet = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (native_lineDataSet, JniHandleOwnership.DoNotTransfer);
			__this.Copy (lineDataSet);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.LineDataSet']]"
		[Register ("copy", "(Lcom/github/mikephil/charting/data/LineDataSet;)V", "GetCopy_Lcom_github_mikephil_charting_data_LineDataSet_Handler")]
		protected virtual unsafe void Copy (global::MikePhil.Charting.Data.LineDataSet lineDataSet)
		{
			const string __id = "copy.(Lcom/github/mikephil/charting/data/LineDataSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((lineDataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lineDataSet).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_disableDashedLine;
#pragma warning disable 0169
		static Delegate GetDisableDashedLineHandler ()
		{
			if (cb_disableDashedLine == null)
				cb_disableDashedLine = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableDashedLine);
			return cb_disableDashedLine;
		}

		static void n_DisableDashedLine (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableDashedLine ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='disableDashedLine' and count(parameter)=0]"
		[Register ("disableDashedLine", "()V", "GetDisableDashedLineHandler")]
		public virtual unsafe void DisableDashedLine ()
		{
			const string __id = "disableDashedLine.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_enableDashedLine_FFF;
#pragma warning disable 0169
		static Delegate GetEnableDashedLine_FFFHandler ()
		{
			if (cb_enableDashedLine_FFF == null)
				cb_enableDashedLine_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float>) n_EnableDashedLine_FFF);
			return cb_enableDashedLine_FFF;
		}

		static void n_EnableDashedLine_FFF (IntPtr jnienv, IntPtr native__this, float lineLength, float spaceLength, float phase)
		{
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableDashedLine (lineLength, spaceLength, phase);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='enableDashedLine' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("enableDashedLine", "(FFF)V", "GetEnableDashedLine_FFFHandler")]
		public virtual unsafe void EnableDashedLine (float lineLength, float spaceLength, float phase)
		{
			const string __id = "enableDashedLine.(FFF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (lineLength);
				__args [1] = new JniArgumentValue (spaceLength);
				__args [2] = new JniArgumentValue (phase);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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

		static int n_GetCircleColor_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetCircleColor (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='getCircleColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getCircleColor", "(I)I", "GetGetCircleColor_IHandler")]
		public virtual unsafe int GetCircleColor (int index)
		{
			const string __id = "getCircleColor.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
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
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetMode ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='getMode' and count(parameter)=0]"
		[Register ("getMode", "()Lcom/github/mikephil/charting/data/LineDataSet$Mode;", "GetGetModeHandler")]
		public virtual unsafe global::MikePhil.Charting.Data.LineDataSet.Mode GetMode ()
		{
			const string __id = "getMode.()Lcom/github/mikephil/charting/data/LineDataSet$Mode;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet.Mode> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_resetCircleColors;
#pragma warning disable 0169
		static Delegate GetResetCircleColorsHandler ()
		{
			if (cb_resetCircleColors == null)
				cb_resetCircleColors = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetCircleColors);
			return cb_resetCircleColors;
		}

		static void n_ResetCircleColors (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetCircleColors ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='resetCircleColors' and count(parameter)=0]"
		[Register ("resetCircleColors", "()V", "GetResetCircleColorsHandler")]
		public virtual unsafe void ResetCircleColors ()
		{
			const string __id = "resetCircleColors.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setCircleColor_I;
#pragma warning disable 0169
		static Delegate GetSetCircleColor_IHandler ()
		{
			if (cb_setCircleColor_I == null)
				cb_setCircleColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCircleColor_I);
			return cb_setCircleColor_I;
		}

		static void n_SetCircleColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCircleColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='setCircleColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCircleColor", "(I)V", "GetSetCircleColor_IHandler")]
		public virtual unsafe void SetCircleColor (int color)
		{
			const string __id = "setCircleColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCircleColors_arrayI;
#pragma warning disable 0169
		static Delegate GetSetCircleColors_arrayIHandler ()
		{
			if (cb_setCircleColors_arrayI == null)
				cb_setCircleColors_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCircleColors_arrayI);
			return cb_setCircleColors_arrayI;
		}

		static void n_SetCircleColors_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_colors)
		{
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] colors = (int[]) JNIEnv.GetArray (native_colors, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetCircleColors (colors);
			if (colors != null)
				JNIEnv.CopyArray (colors, native_colors);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='setCircleColors' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("setCircleColors", "([I)V", "GetSetCircleColors_arrayIHandler")]
		public virtual unsafe void SetCircleColors (params int[] colors)
		{
			const string __id = "setCircleColors.([I)V";
			IntPtr native_colors = JNIEnv.NewArray (colors);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_colors);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (colors != null) {
					JNIEnv.CopyArray (native_colors, colors);
					JNIEnv.DeleteLocalRef (native_colors);
				}
			}
		}

		static Delegate cb_setCircleColors_arrayILandroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetSetCircleColors_arrayILandroid_content_Context_Handler ()
		{
			if (cb_setCircleColors_arrayILandroid_content_Context_ == null)
				cb_setCircleColors_arrayILandroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetCircleColors_arrayILandroid_content_Context_);
			return cb_setCircleColors_arrayILandroid_content_Context_;
		}

		static void n_SetCircleColors_arrayILandroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_colors, IntPtr native_c)
		{
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] colors = (int[]) JNIEnv.GetArray (native_colors, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Android.Content.Context c = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.SetCircleColors (colors, c);
			if (colors != null)
				JNIEnv.CopyArray (colors, native_colors);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='setCircleColors' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='android.content.Context']]"
		[Register ("setCircleColors", "([ILandroid/content/Context;)V", "GetSetCircleColors_arrayILandroid_content_Context_Handler")]
		public virtual unsafe void SetCircleColors (int[] colors, global::Android.Content.Context c)
		{
			const string __id = "setCircleColors.([ILandroid/content/Context;)V";
			IntPtr native_colors = JNIEnv.NewArray (colors);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_colors);
				__args [1] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (colors != null) {
					JNIEnv.CopyArray (native_colors, colors);
					JNIEnv.DeleteLocalRef (native_colors);
				}
			}
		}

		static Delegate cb_setDrawCircleHole_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawCircleHole_ZHandler ()
		{
			if (cb_setDrawCircleHole_Z == null)
				cb_setDrawCircleHole_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawCircleHole_Z);
			return cb_setDrawCircleHole_Z;
		}

		static void n_SetDrawCircleHole_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawCircleHole (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='setDrawCircleHole' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawCircleHole", "(Z)V", "GetSetDrawCircleHole_ZHandler")]
		public virtual unsafe void SetDrawCircleHole (bool enabled)
		{
			const string __id = "setDrawCircleHole.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawCircles_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawCircles_ZHandler ()
		{
			if (cb_setDrawCircles_Z == null)
				cb_setDrawCircles_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawCircles_Z);
			return cb_setDrawCircles_Z;
		}

		static void n_SetDrawCircles_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawCircles (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='setDrawCircles' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawCircles", "(Z)V", "GetSetDrawCircles_ZHandler")]
		public virtual unsafe void SetDrawCircles (bool enabled)
		{
			const string __id = "setDrawCircles.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMode_Lcom_github_mikephil_charting_data_LineDataSet_Mode_;
#pragma warning disable 0169
		static Delegate GetSetMode_Lcom_github_mikephil_charting_data_LineDataSet_Mode_Handler ()
		{
			if (cb_setMode_Lcom_github_mikephil_charting_data_LineDataSet_Mode_ == null)
				cb_setMode_Lcom_github_mikephil_charting_data_LineDataSet_Mode_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMode_Lcom_github_mikephil_charting_data_LineDataSet_Mode_);
			return cb_setMode_Lcom_github_mikephil_charting_data_LineDataSet_Mode_;
		}

		static void n_SetMode_Lcom_github_mikephil_charting_data_LineDataSet_Mode_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mode)
		{
			global::MikePhil.Charting.Data.LineDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.LineDataSet.Mode mode = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineDataSet.Mode> (native_mode, JniHandleOwnership.DoNotTransfer);
			__this.SetMode (mode);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineDataSet']/method[@name='setMode' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.LineDataSet.Mode']]"
		[Register ("setMode", "(Lcom/github/mikephil/charting/data/LineDataSet$Mode;)V", "GetSetMode_Lcom_github_mikephil_charting_data_LineDataSet_Mode_Handler")]
		public virtual unsafe void SetMode (global::MikePhil.Charting.Data.LineDataSet.Mode mode)
		{
			const string __id = "setMode.(Lcom/github/mikephil/charting/data/LineDataSet$Mode;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mode == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mode).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
