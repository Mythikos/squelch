using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/CandleDataSet", DoNotGenerateAcw=true)]
	public partial class CandleDataSet : global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet, global::MikePhil.Charting.Interfaces.Datasets.ICandleDataSet {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/field[@name='mDecreasingColor']"
		[Register ("mDecreasingColor")]
		protected int MDecreasingColor {
			get {
				const string __id = "mDecreasingColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mDecreasingColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/field[@name='mDecreasingPaintStyle']"
		[Register ("mDecreasingPaintStyle")]
		protected global::Android.Graphics.Paint.Style MDecreasingPaintStyle {
			get {
				const string __id = "mDecreasingPaintStyle.Landroid/graphics/Paint$Style;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Style> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDecreasingPaintStyle.Landroid/graphics/Paint$Style;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/field[@name='mIncreasingColor']"
		[Register ("mIncreasingColor")]
		protected int MIncreasingColor {
			get {
				const string __id = "mIncreasingColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mIncreasingColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/field[@name='mIncreasingPaintStyle']"
		[Register ("mIncreasingPaintStyle")]
		protected global::Android.Graphics.Paint.Style MIncreasingPaintStyle {
			get {
				const string __id = "mIncreasingPaintStyle.Landroid/graphics/Paint$Style;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Style> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mIncreasingPaintStyle.Landroid/graphics/Paint$Style;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/field[@name='mNeutralColor']"
		[Register ("mNeutralColor")]
		protected int MNeutralColor {
			get {
				const string __id = "mNeutralColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mNeutralColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/field[@name='mShadowColor']"
		[Register ("mShadowColor")]
		protected int MShadowColor {
			get {
				const string __id = "mShadowColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mShadowColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/CandleDataSet", typeof (CandleDataSet));
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

		protected CandleDataSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/constructor[@name='CandleDataSet' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.github.mikephil.charting.data.CandleEntry&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/util/List;Ljava/lang/String;)V", "")]
		public unsafe CandleDataSet (global::System.Collections.Generic.IList<global::MikePhil.Charting.Data.CandleEntry> yVals, string label)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_yVals = global::Android.Runtime.JavaList<global::MikePhil.Charting.Data.CandleEntry>.ToLocalJniHandle (yVals);
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

		static Delegate cb_getBarSpace;
#pragma warning disable 0169
		static Delegate GetGetBarSpaceHandler ()
		{
			if (cb_getBarSpace == null)
				cb_getBarSpace = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetBarSpace);
			return cb_getBarSpace;
		}

		static float n_GetBarSpace (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.CandleDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BarSpace;
		}
#pragma warning restore 0169

		static Delegate cb_setBarSpace_F;
#pragma warning disable 0169
		static Delegate GetSetBarSpace_FHandler ()
		{
			if (cb_setBarSpace_F == null)
				cb_setBarSpace_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetBarSpace_F);
			return cb_setBarSpace_F;
		}

		static void n_SetBarSpace_F (IntPtr jnienv, IntPtr native__this, float space)
		{
			global::MikePhil.Charting.Data.CandleDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BarSpace = space;
		}
#pragma warning restore 0169

		public virtual unsafe float BarSpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/method[@name='getBarSpace' and count(parameter)=0]"
			[Register ("getBarSpace", "()F", "GetGetBarSpaceHandler")]
			get {
				const string __id = "getBarSpace.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/method[@name='setBarSpace' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBarSpace", "(F)V", "GetSetBarSpace_FHandler")]
			set {
				const string __id = "setBarSpace.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDecreasingColor;
#pragma warning disable 0169
		static Delegate GetGetDecreasingColorHandler ()
		{
			if (cb_getDecreasingColor == null)
				cb_getDecreasingColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDecreasingColor);
			return cb_getDecreasingColor;
		}

		static int n_GetDecreasingColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.CandleDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DecreasingColor;
		}
#pragma warning restore 0169

		static Delegate cb_setDecreasingColor_I;
#pragma warning disable 0169
		static Delegate GetSetDecreasingColor_IHandler ()
		{
			if (cb_setDecreasingColor_I == null)
				cb_setDecreasingColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDecreasingColor_I);
			return cb_setDecreasingColor_I;
		}

		static void n_SetDecreasingColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::MikePhil.Charting.Data.CandleDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DecreasingColor = color;
		}
#pragma warning restore 0169

		public virtual unsafe int DecreasingColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/method[@name='getDecreasingColor' and count(parameter)=0]"
			[Register ("getDecreasingColor", "()I", "GetGetDecreasingColorHandler")]
			get {
				const string __id = "getDecreasingColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/method[@name='setDecreasingColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDecreasingColor", "(I)V", "GetSetDecreasingColor_IHandler")]
			set {
				const string __id = "setDecreasingColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDecreasingPaintStyle;
#pragma warning disable 0169
		static Delegate GetGetDecreasingPaintStyleHandler ()
		{
			if (cb_getDecreasingPaintStyle == null)
				cb_getDecreasingPaintStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDecreasingPaintStyle);
			return cb_getDecreasingPaintStyle;
		}

		static IntPtr n_GetDecreasingPaintStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.CandleDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DecreasingPaintStyle);
		}
#pragma warning restore 0169

		static Delegate cb_setDecreasingPaintStyle_Landroid_graphics_Paint_Style_;
#pragma warning disable 0169
		static Delegate GetSetDecreasingPaintStyle_Landroid_graphics_Paint_Style_Handler ()
		{
			if (cb_setDecreasingPaintStyle_Landroid_graphics_Paint_Style_ == null)
				cb_setDecreasingPaintStyle_Landroid_graphics_Paint_Style_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDecreasingPaintStyle_Landroid_graphics_Paint_Style_);
			return cb_setDecreasingPaintStyle_Landroid_graphics_Paint_Style_;
		}

		static void n_SetDecreasingPaintStyle_Landroid_graphics_Paint_Style_ (IntPtr jnienv, IntPtr native__this, IntPtr native_decreasingPaintStyle)
		{
			global::MikePhil.Charting.Data.CandleDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint.Style decreasingPaintStyle = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Style> (native_decreasingPaintStyle, JniHandleOwnership.DoNotTransfer);
			__this.DecreasingPaintStyle = decreasingPaintStyle;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Paint.Style DecreasingPaintStyle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/method[@name='getDecreasingPaintStyle' and count(parameter)=0]"
			[Register ("getDecreasingPaintStyle", "()Landroid/graphics/Paint$Style;", "GetGetDecreasingPaintStyleHandler")]
			get {
				const string __id = "getDecreasingPaintStyle.()Landroid/graphics/Paint$Style;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Style> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/method[@name='setDecreasingPaintStyle' and count(parameter)=1 and parameter[1][@type='android.graphics.Paint.Style']]"
			[Register ("setDecreasingPaintStyle", "(Landroid/graphics/Paint$Style;)V", "GetSetDecreasingPaintStyle_Landroid_graphics_Paint_Style_Handler")]
			set {
				const string __id = "setDecreasingPaintStyle.(Landroid/graphics/Paint$Style;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIncreasingColor;
#pragma warning disable 0169
		static Delegate GetGetIncreasingColorHandler ()
		{
			if (cb_getIncreasingColor == null)
				cb_getIncreasingColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIncreasingColor);
			return cb_getIncreasingColor;
		}

		static int n_GetIncreasingColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.CandleDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IncreasingColor;
		}
#pragma warning restore 0169

		static Delegate cb_setIncreasingColor_I;
#pragma warning disable 0169
		static Delegate GetSetIncreasingColor_IHandler ()
		{
			if (cb_setIncreasingColor_I == null)
				cb_setIncreasingColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetIncreasingColor_I);
			return cb_setIncreasingColor_I;
		}

		static void n_SetIncreasingColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::MikePhil.Charting.Data.CandleDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.IncreasingColor = color;
		}
#pragma warning restore 0169

		public virtual unsafe int IncreasingColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/method[@name='getIncreasingColor' and count(parameter)=0]"
			[Register ("getIncreasingColor", "()I", "GetGetIncreasingColorHandler")]
			get {
				const string __id = "getIncreasingColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/method[@name='setIncreasingColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setIncreasingColor", "(I)V", "GetSetIncreasingColor_IHandler")]
			set {
				const string __id = "setIncreasingColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIncreasingPaintStyle;
#pragma warning disable 0169
		static Delegate GetGetIncreasingPaintStyleHandler ()
		{
			if (cb_getIncreasingPaintStyle == null)
				cb_getIncreasingPaintStyle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIncreasingPaintStyle);
			return cb_getIncreasingPaintStyle;
		}

		static IntPtr n_GetIncreasingPaintStyle (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.CandleDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IncreasingPaintStyle);
		}
#pragma warning restore 0169

		static Delegate cb_setIncreasingPaintStyle_Landroid_graphics_Paint_Style_;
#pragma warning disable 0169
		static Delegate GetSetIncreasingPaintStyle_Landroid_graphics_Paint_Style_Handler ()
		{
			if (cb_setIncreasingPaintStyle_Landroid_graphics_Paint_Style_ == null)
				cb_setIncreasingPaintStyle_Landroid_graphics_Paint_Style_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIncreasingPaintStyle_Landroid_graphics_Paint_Style_);
			return cb_setIncreasingPaintStyle_Landroid_graphics_Paint_Style_;
		}

		static void n_SetIncreasingPaintStyle_Landroid_graphics_Paint_Style_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paintStyle)
		{
			global::MikePhil.Charting.Data.CandleDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint.Style paintStyle = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Style> (native_paintStyle, JniHandleOwnership.DoNotTransfer);
			__this.IncreasingPaintStyle = paintStyle;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Paint.Style IncreasingPaintStyle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/method[@name='getIncreasingPaintStyle' and count(parameter)=0]"
			[Register ("getIncreasingPaintStyle", "()Landroid/graphics/Paint$Style;", "GetGetIncreasingPaintStyleHandler")]
			get {
				const string __id = "getIncreasingPaintStyle.()Landroid/graphics/Paint$Style;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Style> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/method[@name='setIncreasingPaintStyle' and count(parameter)=1 and parameter[1][@type='android.graphics.Paint.Style']]"
			[Register ("setIncreasingPaintStyle", "(Landroid/graphics/Paint$Style;)V", "GetSetIncreasingPaintStyle_Landroid_graphics_Paint_Style_Handler")]
			set {
				const string __id = "setIncreasingPaintStyle.(Landroid/graphics/Paint$Style;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getNeutralColor;
#pragma warning disable 0169
		static Delegate GetGetNeutralColorHandler ()
		{
			if (cb_getNeutralColor == null)
				cb_getNeutralColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNeutralColor);
			return cb_getNeutralColor;
		}

		static int n_GetNeutralColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.CandleDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeutralColor;
		}
#pragma warning restore 0169

		static Delegate cb_setNeutralColor_I;
#pragma warning disable 0169
		static Delegate GetSetNeutralColor_IHandler ()
		{
			if (cb_setNeutralColor_I == null)
				cb_setNeutralColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNeutralColor_I);
			return cb_setNeutralColor_I;
		}

		static void n_SetNeutralColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::MikePhil.Charting.Data.CandleDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NeutralColor = color;
		}
#pragma warning restore 0169

		public virtual unsafe int NeutralColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/method[@name='getNeutralColor' and count(parameter)=0]"
			[Register ("getNeutralColor", "()I", "GetGetNeutralColorHandler")]
			get {
				const string __id = "getNeutralColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/method[@name='setNeutralColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setNeutralColor", "(I)V", "GetSetNeutralColor_IHandler")]
			set {
				const string __id = "setNeutralColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShadowColor;
#pragma warning disable 0169
		static Delegate GetGetShadowColorHandler ()
		{
			if (cb_getShadowColor == null)
				cb_getShadowColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetShadowColor);
			return cb_getShadowColor;
		}

		static int n_GetShadowColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.CandleDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShadowColor;
		}
#pragma warning restore 0169

		static Delegate cb_setShadowColor_I;
#pragma warning disable 0169
		static Delegate GetSetShadowColor_IHandler ()
		{
			if (cb_setShadowColor_I == null)
				cb_setShadowColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetShadowColor_I);
			return cb_setShadowColor_I;
		}

		static void n_SetShadowColor_I (IntPtr jnienv, IntPtr native__this, int shadowColor)
		{
			global::MikePhil.Charting.Data.CandleDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShadowColor = shadowColor;
		}
#pragma warning restore 0169

		public virtual unsafe int ShadowColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/method[@name='getShadowColor' and count(parameter)=0]"
			[Register ("getShadowColor", "()I", "GetGetShadowColorHandler")]
			get {
				const string __id = "getShadowColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/method[@name='setShadowColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setShadowColor", "(I)V", "GetSetShadowColor_IHandler")]
			set {
				const string __id = "setShadowColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShadowColorSameAsCandle;
#pragma warning disable 0169
		static Delegate GetGetShadowColorSameAsCandleHandler ()
		{
			if (cb_getShadowColorSameAsCandle == null)
				cb_getShadowColorSameAsCandle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetShadowColorSameAsCandle);
			return cb_getShadowColorSameAsCandle;
		}

		static bool n_GetShadowColorSameAsCandle (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.CandleDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShadowColorSameAsCandle;
		}
#pragma warning restore 0169

		static Delegate cb_setShadowColorSameAsCandle_Z;
#pragma warning disable 0169
		static Delegate GetSetShadowColorSameAsCandle_ZHandler ()
		{
			if (cb_setShadowColorSameAsCandle_Z == null)
				cb_setShadowColorSameAsCandle_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShadowColorSameAsCandle_Z);
			return cb_setShadowColorSameAsCandle_Z;
		}

		static void n_SetShadowColorSameAsCandle_Z (IntPtr jnienv, IntPtr native__this, bool shadowColorSameAsCandle)
		{
			global::MikePhil.Charting.Data.CandleDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShadowColorSameAsCandle = shadowColorSameAsCandle;
		}
#pragma warning restore 0169

		public virtual unsafe bool ShadowColorSameAsCandle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/method[@name='getShadowColorSameAsCandle' and count(parameter)=0]"
			[Register ("getShadowColorSameAsCandle", "()Z", "GetGetShadowColorSameAsCandleHandler")]
			get {
				const string __id = "getShadowColorSameAsCandle.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/method[@name='setShadowColorSameAsCandle' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShadowColorSameAsCandle", "(Z)V", "GetSetShadowColorSameAsCandle_ZHandler")]
			set {
				const string __id = "setShadowColorSameAsCandle.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShadowWidth;
#pragma warning disable 0169
		static Delegate GetGetShadowWidthHandler ()
		{
			if (cb_getShadowWidth == null)
				cb_getShadowWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetShadowWidth);
			return cb_getShadowWidth;
		}

		static float n_GetShadowWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.CandleDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShadowWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setShadowWidth_F;
#pragma warning disable 0169
		static Delegate GetSetShadowWidth_FHandler ()
		{
			if (cb_setShadowWidth_F == null)
				cb_setShadowWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetShadowWidth_F);
			return cb_setShadowWidth_F;
		}

		static void n_SetShadowWidth_F (IntPtr jnienv, IntPtr native__this, float width)
		{
			global::MikePhil.Charting.Data.CandleDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShadowWidth = width;
		}
#pragma warning restore 0169

		public virtual unsafe float ShadowWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/method[@name='getShadowWidth' and count(parameter)=0]"
			[Register ("getShadowWidth", "()F", "GetGetShadowWidthHandler")]
			get {
				const string __id = "getShadowWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/method[@name='setShadowWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setShadowWidth", "(F)V", "GetSetShadowWidth_FHandler")]
			set {
				const string __id = "setShadowWidth.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShowCandleBar;
#pragma warning disable 0169
		static Delegate GetGetShowCandleBarHandler ()
		{
			if (cb_getShowCandleBar == null)
				cb_getShowCandleBar = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetShowCandleBar);
			return cb_getShowCandleBar;
		}

		static bool n_GetShowCandleBar (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.CandleDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShowCandleBar;
		}
#pragma warning restore 0169

		static Delegate cb_setShowCandleBar_Z;
#pragma warning disable 0169
		static Delegate GetSetShowCandleBar_ZHandler ()
		{
			if (cb_setShowCandleBar_Z == null)
				cb_setShowCandleBar_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetShowCandleBar_Z);
			return cb_setShowCandleBar_Z;
		}

		static void n_SetShowCandleBar_Z (IntPtr jnienv, IntPtr native__this, bool showCandleBar)
		{
			global::MikePhil.Charting.Data.CandleDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ShowCandleBar = showCandleBar;
		}
#pragma warning restore 0169

		public virtual unsafe bool ShowCandleBar {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/method[@name='getShowCandleBar' and count(parameter)=0]"
			[Register ("getShowCandleBar", "()Z", "GetGetShowCandleBarHandler")]
			get {
				const string __id = "getShowCandleBar.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/method[@name='setShowCandleBar' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setShowCandleBar", "(Z)V", "GetSetShowCandleBar_ZHandler")]
			set {
				const string __id = "setShowCandleBar.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_calcMinMax_Lcom_github_mikephil_charting_data_CandleEntry_;
#pragma warning disable 0169
		static Delegate GetCalcMinMax_Lcom_github_mikephil_charting_data_CandleEntry_Handler ()
		{
			if (cb_calcMinMax_Lcom_github_mikephil_charting_data_CandleEntry_ == null)
				cb_calcMinMax_Lcom_github_mikephil_charting_data_CandleEntry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CalcMinMax_Lcom_github_mikephil_charting_data_CandleEntry_);
			return cb_calcMinMax_Lcom_github_mikephil_charting_data_CandleEntry_;
		}

		static void n_CalcMinMax_Lcom_github_mikephil_charting_data_CandleEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::MikePhil.Charting.Data.CandleDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.CandleEntry e = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleEntry> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.CalcMinMax (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/method[@name='calcMinMax' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.CandleEntry']]"
		[Register ("calcMinMax", "(Lcom/github/mikephil/charting/data/CandleEntry;)V", "GetCalcMinMax_Lcom_github_mikephil_charting_data_CandleEntry_Handler")]
		protected virtual unsafe void CalcMinMax (global::MikePhil.Charting.Data.CandleEntry e)
		{
			const string __id = "calcMinMax.(Lcom/github/mikephil/charting/data/CandleEntry;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_calcMinMaxY_Lcom_github_mikephil_charting_data_CandleEntry_;
#pragma warning disable 0169
		static Delegate GetCalcMinMaxY_Lcom_github_mikephil_charting_data_CandleEntry_Handler ()
		{
			if (cb_calcMinMaxY_Lcom_github_mikephil_charting_data_CandleEntry_ == null)
				cb_calcMinMaxY_Lcom_github_mikephil_charting_data_CandleEntry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CalcMinMaxY_Lcom_github_mikephil_charting_data_CandleEntry_);
			return cb_calcMinMaxY_Lcom_github_mikephil_charting_data_CandleEntry_;
		}

		static void n_CalcMinMaxY_Lcom_github_mikephil_charting_data_CandleEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::MikePhil.Charting.Data.CandleDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.CandleEntry e = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleEntry> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.CalcMinMaxY (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/method[@name='calcMinMaxY' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.CandleEntry']]"
		[Register ("calcMinMaxY", "(Lcom/github/mikephil/charting/data/CandleEntry;)V", "GetCalcMinMaxY_Lcom_github_mikephil_charting_data_CandleEntry_Handler")]
		protected virtual unsafe void CalcMinMaxY (global::MikePhil.Charting.Data.CandleEntry e)
		{
			const string __id = "calcMinMaxY.(Lcom/github/mikephil/charting/data/CandleEntry;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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
			global::MikePhil.Charting.Data.CandleDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Copy ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/method[@name='copy' and count(parameter)=0]"
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

		static Delegate cb_copy_Lcom_github_mikephil_charting_data_CandleDataSet_;
#pragma warning disable 0169
		static Delegate GetCopy_Lcom_github_mikephil_charting_data_CandleDataSet_Handler ()
		{
			if (cb_copy_Lcom_github_mikephil_charting_data_CandleDataSet_ == null)
				cb_copy_Lcom_github_mikephil_charting_data_CandleDataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Copy_Lcom_github_mikephil_charting_data_CandleDataSet_);
			return cb_copy_Lcom_github_mikephil_charting_data_CandleDataSet_;
		}

		static void n_Copy_Lcom_github_mikephil_charting_data_CandleDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_candleDataSet)
		{
			global::MikePhil.Charting.Data.CandleDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.CandleDataSet candleDataSet = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleDataSet> (native_candleDataSet, JniHandleOwnership.DoNotTransfer);
			__this.Copy (candleDataSet);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleDataSet']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.CandleDataSet']]"
		[Register ("copy", "(Lcom/github/mikephil/charting/data/CandleDataSet;)V", "GetCopy_Lcom_github_mikephil_charting_data_CandleDataSet_Handler")]
		protected virtual unsafe void Copy (global::MikePhil.Charting.Data.CandleDataSet candleDataSet)
		{
			const string __id = "copy.(Lcom/github/mikephil/charting/data/CandleDataSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((candleDataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) candleDataSet).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
