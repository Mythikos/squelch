using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/BaseDataSet", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.github.mikephil.charting.data.Entry"})]
	public abstract partial class BaseDataSet : global::Java.Lang.Object, global::MikePhil.Charting.Interfaces.Datasets.IDataSet {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/field[@name='mAxisDependency']"
		[Register ("mAxisDependency")]
		protected global::MikePhil.Charting.Components.YAxis.AxisDependency MAxisDependency {
			get {
				const string __id = "mAxisDependency.Lcom/github/mikephil/charting/components/YAxis$AxisDependency;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAxisDependency.Lcom/github/mikephil/charting/components/YAxis$AxisDependency;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/field[@name='mColors']"
		[Register ("mColors")]
		protected global::System.Collections.IList MColors {
			get {
				const string __id = "mColors.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mColors.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/field[@name='mDrawIcons']"
		[Register ("mDrawIcons")]
		protected bool MDrawIcons {
			get {
				const string __id = "mDrawIcons.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mDrawIcons.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/field[@name='mDrawValues']"
		[Register ("mDrawValues")]
		protected bool MDrawValues {
			get {
				const string __id = "mDrawValues.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mDrawValues.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/field[@name='mGradientColor']"
		[Register ("mGradientColor")]
		protected global::MikePhil.Charting.Model.GradientColor MGradientColor {
			get {
				const string __id = "mGradientColor.Lcom/github/mikephil/charting/model/GradientColor;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Model.GradientColor> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mGradientColor.Lcom/github/mikephil/charting/model/GradientColor;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/field[@name='mGradientColors']"
		[Register ("mGradientColors")]
		protected global::System.Collections.IList MGradientColors {
			get {
				const string __id = "mGradientColors.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mGradientColors.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/field[@name='mHighlightEnabled']"
		[Register ("mHighlightEnabled")]
		protected bool MHighlightEnabled {
			get {
				const string __id = "mHighlightEnabled.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mHighlightEnabled.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/field[@name='mIconsOffset']"
		[Register ("mIconsOffset")]
		protected global::MikePhil.Charting.Util.MPPointF MIconsOffset {
			get {
				const string __id = "mIconsOffset.Lcom/github/mikephil/charting/utils/MPPointF;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mIconsOffset.Lcom/github/mikephil/charting/utils/MPPointF;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/field[@name='mValueColors']"
		[Register ("mValueColors")]
		protected global::System.Collections.IList MValueColors {
			get {
				const string __id = "mValueColors.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mValueColors.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/field[@name='mValueFormatter']"
		[Register ("mValueFormatter")]
		protected global::MikePhil.Charting.Formatter.IValueFormatter MValueFormatter {
			get {
				const string __id = "mValueFormatter.Lcom/github/mikephil/charting/formatter/IValueFormatter;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IValueFormatter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mValueFormatter.Lcom/github/mikephil/charting/formatter/IValueFormatter;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/field[@name='mValueTextSize']"
		[Register ("mValueTextSize")]
		protected float MValueTextSize {
			get {
				const string __id = "mValueTextSize.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mValueTextSize.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/field[@name='mValueTypeface']"
		[Register ("mValueTypeface")]
		protected global::Android.Graphics.Typeface MValueTypeface {
			get {
				const string __id = "mValueTypeface.Landroid/graphics/Typeface;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mValueTypeface.Landroid/graphics/Typeface;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/field[@name='mVisible']"
		[Register ("mVisible")]
		protected bool MVisible {
			get {
				const string __id = "mVisible.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mVisible.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/data/BaseDataSet", typeof (BaseDataSet));
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

		protected BaseDataSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/constructor[@name='BaseDataSet' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseDataSet ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/constructor[@name='BaseDataSet' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe BaseDataSet (string label)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_label);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_label);
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dependency)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency dependency = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_dependency, JniHandleOwnership.DoNotTransfer);
			__this.AxisDependency = dependency;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Components.YAxis.AxisDependency AxisDependency {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getAxisDependency' and count(parameter)=0]"
			[Register ("getAxisDependency", "()Lcom/github/mikephil/charting/components/YAxis$AxisDependency;", "GetGetAxisDependencyHandler")]
			get {
				const string __id = "getAxisDependency.()Lcom/github/mikephil/charting/components/YAxis$AxisDependency;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='setAxisDependency' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.YAxis.AxisDependency']]"
			[Register ("setAxisDependency", "(Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)V", "GetSetAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler")]
			set {
				const string __id = "setAxisDependency.(Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Color;
		}
#pragma warning restore 0169

		static Delegate cb_setColor_I;
#pragma warning disable 0169
		static Delegate GetSetColor_IHandler ()
		{
			if (cb_setColor_I == null)
				cb_setColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetColor_I);
			return cb_setColor_I;
		}

		static void n_SetColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Color = color;
		}
#pragma warning restore 0169

		public virtual unsafe int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler")]
			get {
				const string __id = "getColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='setColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setColor", "(I)V", "GetSetColor_IHandler")]
			set {
				const string __id = "setColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (__this.Colors);
		}
#pragma warning restore 0169

		static Delegate cb_setColors_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetColors_Ljava_util_List_Handler ()
		{
			if (cb_setColors_Ljava_util_List_ == null)
				cb_setColors_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColors_Ljava_util_List_);
			return cb_setColors_Ljava_util_List_;
		}

		static void n_SetColors_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_colors)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var colors = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (native_colors, JniHandleOwnership.DoNotTransfer);
			__this.Colors = colors;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Lang.Integer> Colors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getColors' and count(parameter)=0]"
			[Register ("getColors", "()Ljava/util/List;", "GetGetColorsHandler")]
			get {
				const string __id = "getColors.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='setColors' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Integer&gt;']]"
			[Register ("setColors", "(Ljava/util/List;)V", "GetSetColors_Ljava_util_List_Handler")]
			set {
				const string __id = "setColors.(Ljava/util/List;)V";
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Form);
		}
#pragma warning restore 0169

		static Delegate cb_setForm_Lcom_github_mikephil_charting_components_Legend_LegendForm_;
#pragma warning disable 0169
		static Delegate GetSetForm_Lcom_github_mikephil_charting_components_Legend_LegendForm_Handler ()
		{
			if (cb_setForm_Lcom_github_mikephil_charting_components_Legend_LegendForm_ == null)
				cb_setForm_Lcom_github_mikephil_charting_components_Legend_LegendForm_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetForm_Lcom_github_mikephil_charting_components_Legend_LegendForm_);
			return cb_setForm_Lcom_github_mikephil_charting_components_Legend_LegendForm_;
		}

		static void n_SetForm_Lcom_github_mikephil_charting_components_Legend_LegendForm_ (IntPtr jnienv, IntPtr native__this, IntPtr native_form)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.Legend.LegendForm form = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendForm> (native_form, JniHandleOwnership.DoNotTransfer);
			__this.Form = form;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Components.Legend.LegendForm Form {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getForm' and count(parameter)=0]"
			[Register ("getForm", "()Lcom/github/mikephil/charting/components/Legend$LegendForm;", "GetGetFormHandler")]
			get {
				const string __id = "getForm.()Lcom/github/mikephil/charting/components/Legend$LegendForm;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendForm> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='setForm' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.Legend.LegendForm']]"
			[Register ("setForm", "(Lcom/github/mikephil/charting/components/Legend$LegendForm;)V", "GetSetForm_Lcom_github_mikephil_charting_components_Legend_LegendForm_Handler")]
			set {
				const string __id = "setForm.(Lcom/github/mikephil/charting/components/Legend$LegendForm;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FormLineDashEffect);
		}
#pragma warning restore 0169

		static Delegate cb_setFormLineDashEffect_Landroid_graphics_DashPathEffect_;
#pragma warning disable 0169
		static Delegate GetSetFormLineDashEffect_Landroid_graphics_DashPathEffect_Handler ()
		{
			if (cb_setFormLineDashEffect_Landroid_graphics_DashPathEffect_ == null)
				cb_setFormLineDashEffect_Landroid_graphics_DashPathEffect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFormLineDashEffect_Landroid_graphics_DashPathEffect_);
			return cb_setFormLineDashEffect_Landroid_graphics_DashPathEffect_;
		}

		static void n_SetFormLineDashEffect_Landroid_graphics_DashPathEffect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dashPathEffect)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.DashPathEffect dashPathEffect = global::Java.Lang.Object.GetObject<global::Android.Graphics.DashPathEffect> (native_dashPathEffect, JniHandleOwnership.DoNotTransfer);
			__this.FormLineDashEffect = dashPathEffect;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.DashPathEffect FormLineDashEffect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getFormLineDashEffect' and count(parameter)=0]"
			[Register ("getFormLineDashEffect", "()Landroid/graphics/DashPathEffect;", "GetGetFormLineDashEffectHandler")]
			get {
				const string __id = "getFormLineDashEffect.()Landroid/graphics/DashPathEffect;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.DashPathEffect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='setFormLineDashEffect' and count(parameter)=1 and parameter[1][@type='android.graphics.DashPathEffect']]"
			[Register ("setFormLineDashEffect", "(Landroid/graphics/DashPathEffect;)V", "GetSetFormLineDashEffect_Landroid_graphics_DashPathEffect_Handler")]
			set {
				const string __id = "setFormLineDashEffect.(Landroid/graphics/DashPathEffect;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FormLineWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setFormLineWidth_F;
#pragma warning disable 0169
		static Delegate GetSetFormLineWidth_FHandler ()
		{
			if (cb_setFormLineWidth_F == null)
				cb_setFormLineWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetFormLineWidth_F);
			return cb_setFormLineWidth_F;
		}

		static void n_SetFormLineWidth_F (IntPtr jnienv, IntPtr native__this, float formLineWidth)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FormLineWidth = formLineWidth;
		}
#pragma warning restore 0169

		public virtual unsafe float FormLineWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getFormLineWidth' and count(parameter)=0]"
			[Register ("getFormLineWidth", "()F", "GetGetFormLineWidthHandler")]
			get {
				const string __id = "getFormLineWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='setFormLineWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setFormLineWidth", "(F)V", "GetSetFormLineWidth_FHandler")]
			set {
				const string __id = "setFormLineWidth.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FormSize;
		}
#pragma warning restore 0169

		static Delegate cb_setFormSize_F;
#pragma warning disable 0169
		static Delegate GetSetFormSize_FHandler ()
		{
			if (cb_setFormSize_F == null)
				cb_setFormSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetFormSize_F);
			return cb_setFormSize_F;
		}

		static void n_SetFormSize_F (IntPtr jnienv, IntPtr native__this, float formSize)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FormSize = formSize;
		}
#pragma warning restore 0169

		public virtual unsafe float FormSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getFormSize' and count(parameter)=0]"
			[Register ("getFormSize", "()F", "GetGetFormSizeHandler")]
			get {
				const string __id = "getFormSize.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='setFormSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setFormSize", "(F)V", "GetSetFormSize_FHandler")]
			set {
				const string __id = "setFormSize.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GradientColor);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Model.GradientColor GradientColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getGradientColor' and count(parameter)=0]"
			[Register ("getGradientColor", "()Lcom/github/mikephil/charting/model/GradientColor;", "GetGetGradientColorHandler")]
			get {
				const string __id = "getGradientColor.()Lcom/github/mikephil/charting/model/GradientColor;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Model.GradientColor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::MikePhil.Charting.Model.GradientColor>.ToLocalJniHandle (__this.GradientColors);
		}
#pragma warning restore 0169

		static Delegate cb_setGradientColors_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetGradientColors_Ljava_util_List_Handler ()
		{
			if (cb_setGradientColors_Ljava_util_List_ == null)
				cb_setGradientColors_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetGradientColors_Ljava_util_List_);
			return cb_setGradientColors_Ljava_util_List_;
		}

		static void n_SetGradientColors_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_gradientColors)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var gradientColors = global::Android.Runtime.JavaList<global::MikePhil.Charting.Model.GradientColor>.FromJniHandle (native_gradientColors, JniHandleOwnership.DoNotTransfer);
			__this.GradientColors = gradientColors;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::MikePhil.Charting.Model.GradientColor> GradientColors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getGradientColors' and count(parameter)=0]"
			[Register ("getGradientColors", "()Ljava/util/List;", "GetGetGradientColorsHandler")]
			get {
				const string __id = "getGradientColors.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::MikePhil.Charting.Model.GradientColor>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='setGradientColors' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.github.mikephil.charting.model.GradientColor&gt;']]"
			[Register ("setGradientColors", "(Ljava/util/List;)V", "GetSetGradientColors_Ljava_util_List_Handler")]
			set {
				const string __id = "setGradientColors.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList<global::MikePhil.Charting.Model.GradientColor>.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetHighlightEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighlightEnabled = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool HighlightEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='isHighlightEnabled' and count(parameter)=0]"
			[Register ("isHighlightEnabled", "()Z", "GetIsHighlightEnabledHandler")]
			get {
				const string __id = "isHighlightEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='setHighlightEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHighlightEnabled", "(Z)V", "GetSetHighlightEnabled_ZHandler")]
			set {
				const string __id = "setHighlightEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_offsetDp)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Util.MPPointF offsetDp = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (native_offsetDp, JniHandleOwnership.DoNotTransfer);
			__this.IconsOffset = offsetDp;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Util.MPPointF IconsOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getIconsOffset' and count(parameter)=0]"
			[Register ("getIconsOffset", "()Lcom/github/mikephil/charting/utils/MPPointF;", "GetGetIconsOffsetHandler")]
			get {
				const string __id = "getIconsOffset.()Lcom/github/mikephil/charting/utils/MPPointF;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='setIconsOffset' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.utils.MPPointF']]"
			[Register ("setIconsOffset", "(Lcom/github/mikephil/charting/utils/MPPointF;)V", "GetSetIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_Handler")]
			set {
				const string __id = "setIconsOffset.(Lcom/github/mikephil/charting/utils/MPPointF;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawIconsEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrawIconsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='isDrawIconsEnabled' and count(parameter)=0]"
			[Register ("isDrawIconsEnabled", "()Z", "GetIsDrawIconsEnabledHandler")]
			get {
				const string __id = "isDrawIconsEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawValuesEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrawValuesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='isDrawValuesEnabled' and count(parameter)=0]"
			[Register ("isDrawValuesEnabled", "()Z", "GetIsDrawValuesEnabledHandler")]
			get {
				const string __id = "isDrawValuesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetLabel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_label)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string label = JNIEnv.GetString (native_label, JniHandleOwnership.DoNotTransfer);
			__this.Label = label;
		}
#pragma warning restore 0169

		public virtual unsafe string Label {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getLabel' and count(parameter)=0]"
			[Register ("getLabel", "()Ljava/lang/String;", "GetGetLabelHandler")]
			get {
				const string __id = "getLabel.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='setLabel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLabel", "(Ljava/lang/String;)V", "GetSetLabel_Ljava_lang_String_Handler")]
			set {
				const string __id = "setLabel.(Ljava/lang/String;)V";
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getValueColors;
#pragma warning disable 0169
		static Delegate GetGetValueColorsHandler ()
		{
			if (cb_getValueColors == null)
				cb_getValueColors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValueColors);
			return cb_getValueColors;
		}

		static IntPtr n_GetValueColors (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (__this.ValueColors);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Lang.Integer> ValueColors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getValueColors' and count(parameter)=0]"
			[Register ("getValueColors", "()Ljava/util/List;", "GetGetValueColorsHandler")]
			get {
				const string __id = "getValueColors.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_f)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Formatter.IValueFormatter f = (global::MikePhil.Charting.Formatter.IValueFormatter)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IValueFormatter> (native_f, JniHandleOwnership.DoNotTransfer);
			__this.ValueFormatter = f;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Formatter.IValueFormatter ValueFormatter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getValueFormatter' and count(parameter)=0]"
			[Register ("getValueFormatter", "()Lcom/github/mikephil/charting/formatter/IValueFormatter;", "GetGetValueFormatterHandler")]
			get {
				const string __id = "getValueFormatter.()Lcom/github/mikephil/charting/formatter/IValueFormatter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IValueFormatter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='setValueFormatter' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.formatter.IValueFormatter']]"
			[Register ("setValueFormatter", "(Lcom/github/mikephil/charting/formatter/IValueFormatter;)V", "GetSetValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_Handler")]
			set {
				const string __id = "setValueFormatter.(Lcom/github/mikephil/charting/formatter/IValueFormatter;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetValueTextColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ValueTextColor = color;
		}
#pragma warning restore 0169

		public virtual unsafe int ValueTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getValueTextColor' and count(parameter)=0]"
			[Register ("getValueTextColor", "()I", "GetGetValueTextColorHandler")]
			get {
				const string __id = "getValueTextColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='setValueTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setValueTextColor", "(I)V", "GetSetValueTextColor_IHandler")]
			set {
				const string __id = "setValueTextColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetValueTextSize_F (IntPtr jnienv, IntPtr native__this, float size)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ValueTextSize = size;
		}
#pragma warning restore 0169

		public virtual unsafe float ValueTextSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getValueTextSize' and count(parameter)=0]"
			[Register ("getValueTextSize", "()F", "GetGetValueTextSizeHandler")]
			get {
				const string __id = "getValueTextSize.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='setValueTextSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setValueTextSize", "(F)V", "GetSetValueTextSize_FHandler")]
			set {
				const string __id = "setValueTextSize.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetValueTypeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tf)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Typeface tf = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_tf, JniHandleOwnership.DoNotTransfer);
			__this.ValueTypeface = tf;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Typeface ValueTypeface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getValueTypeface' and count(parameter)=0]"
			[Register ("getValueTypeface", "()Landroid/graphics/Typeface;", "GetGetValueTypefaceHandler")]
			get {
				const string __id = "getValueTypeface.()Landroid/graphics/Typeface;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='setValueTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
			[Register ("setValueTypeface", "(Landroid/graphics/Typeface;)V", "GetSetValueTypeface_Landroid_graphics_Typeface_Handler")]
			set {
				const string __id = "setValueTypeface.(Landroid/graphics/Typeface;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static void n_SetVisible_Z (IntPtr jnienv, IntPtr native__this, bool visible)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Visible = visible;
		}
#pragma warning restore 0169

		public virtual unsafe bool Visible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler")]
			get {
				const string __id = "isVisible.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='setVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVisible", "(Z)V", "GetSetVisible_ZHandler")]
			set {
				const string __id = "setVisible.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_addColor_I;
#pragma warning disable 0169
		static Delegate GetAddColor_IHandler ()
		{
			if (cb_addColor_I == null)
				cb_addColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_AddColor_I);
			return cb_addColor_I;
		}

		static void n_AddColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='addColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("addColor", "(I)V", "GetAddColor_IHandler")]
		public virtual unsafe void AddColor (int color)
		{
			const string __id = "addColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_contains_Lcom_github_mikephil_charting_data_Entry_;
#pragma warning disable 0169
		static Delegate GetContains_Lcom_github_mikephil_charting_data_Entry_Handler ()
		{
			if (cb_contains_Lcom_github_mikephil_charting_data_Entry_ == null)
				cb_contains_Lcom_github_mikephil_charting_data_Entry_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Lcom_github_mikephil_charting_data_Entry_);
			return cb_contains_Lcom_github_mikephil_charting_data_Entry_;
		}

		static bool n_Contains_Lcom_github_mikephil_charting_data_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object e = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("contains", "(Lcom/github/mikephil/charting/data/Entry;)Z", "GetContains_Lcom_github_mikephil_charting_data_Entry_Handler")]
		public virtual unsafe bool Contains (global::Java.Lang.Object e)
		{
			const string __id = "contains.(Lcom/github/mikephil/charting/data/Entry;)Z";
			IntPtr native_e = JNIEnv.ToLocalJniHandle (e);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_e);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_e);
			}
		}

		static Delegate cb_copy_Lcom_github_mikephil_charting_data_BaseDataSet_;
#pragma warning disable 0169
		static Delegate GetCopy_Lcom_github_mikephil_charting_data_BaseDataSet_Handler ()
		{
			if (cb_copy_Lcom_github_mikephil_charting_data_BaseDataSet_ == null)
				cb_copy_Lcom_github_mikephil_charting_data_BaseDataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Copy_Lcom_github_mikephil_charting_data_BaseDataSet_);
			return cb_copy_Lcom_github_mikephil_charting_data_BaseDataSet_;
		}

		static void n_Copy_Lcom_github_mikephil_charting_data_BaseDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_baseDataSet)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.BaseDataSet baseDataSet = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (native_baseDataSet, JniHandleOwnership.DoNotTransfer);
			__this.Copy (baseDataSet);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.BaseDataSet']]"
		[Register ("copy", "(Lcom/github/mikephil/charting/data/BaseDataSet;)V", "GetCopy_Lcom_github_mikephil_charting_data_BaseDataSet_Handler")]
		protected virtual unsafe void Copy (global::MikePhil.Charting.Data.BaseDataSet baseDataSet)
		{
			const string __id = "copy.(Lcom/github/mikephil/charting/data/BaseDataSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((baseDataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) baseDataSet).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getColor_I;
#pragma warning disable 0169
		static Delegate GetGetColor_IHandler ()
		{
			if (cb_getColor_I == null)
				cb_getColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetColor_I);
			return cb_getColor_I;
		}

		static int n_GetColor_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetColor (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getColor", "(I)I", "GetGetColor_IHandler")]
		public virtual unsafe int GetColor (int index)
		{
			const string __id = "getColor.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getGradientColor_I;
#pragma warning disable 0169
		static Delegate GetGetGradientColor_IHandler ()
		{
			if (cb_getGradientColor_I == null)
				cb_getGradientColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetGradientColor_I);
			return cb_getGradientColor_I;
		}

		static IntPtr n_GetGradientColor_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetGradientColor (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getGradientColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getGradientColor", "(I)Lcom/github/mikephil/charting/model/GradientColor;", "GetGetGradientColor_IHandler")]
		public virtual unsafe global::MikePhil.Charting.Model.GradientColor GetGradientColor (int index)
		{
			const string __id = "getGradientColor.(I)Lcom/github/mikephil/charting/model/GradientColor;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Model.GradientColor> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getIndexInEntries_I;
#pragma warning disable 0169
		static Delegate GetGetIndexInEntries_IHandler ()
		{
			if (cb_getIndexInEntries_I == null)
				cb_getIndexInEntries_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetIndexInEntries_I);
			return cb_getIndexInEntries_I;
		}

		static int n_GetIndexInEntries_I (IntPtr jnienv, IntPtr native__this, int xIndex)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetIndexInEntries (xIndex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getIndexInEntries' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getIndexInEntries", "(I)I", "GetGetIndexInEntries_IHandler")]
		public virtual unsafe int GetIndexInEntries (int xIndex)
		{
			const string __id = "getIndexInEntries.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (xIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getValueTextColor_I;
#pragma warning disable 0169
		static Delegate GetGetValueTextColor_IHandler ()
		{
			if (cb_getValueTextColor_I == null)
				cb_getValueTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetValueTextColor_I);
			return cb_getValueTextColor_I;
		}

		static int n_GetValueTextColor_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetValueTextColor (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getValueTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getValueTextColor", "(I)I", "GetGetValueTextColor_IHandler")]
		public virtual unsafe int GetValueTextColor (int index)
		{
			const string __id = "getValueTextColor.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeedsFormatter ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='needsFormatter' and count(parameter)=0]"
		[Register ("needsFormatter", "()Z", "GetNeedsFormatterHandler")]
		public virtual unsafe bool NeedsFormatter ()
		{
			const string __id = "needsFormatter.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_notifyDataSetChanged;
#pragma warning disable 0169
		static Delegate GetNotifyDataSetChangedHandler ()
		{
			if (cb_notifyDataSetChanged == null)
				cb_notifyDataSetChanged = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyDataSetChanged);
			return cb_notifyDataSetChanged;
		}

		static void n_NotifyDataSetChanged (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDataSetChanged ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='notifyDataSetChanged' and count(parameter)=0]"
		[Register ("notifyDataSetChanged", "()V", "GetNotifyDataSetChangedHandler")]
		public virtual unsafe void NotifyDataSetChanged ()
		{
			const string __id = "notifyDataSetChanged.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeEntry_I;
#pragma warning disable 0169
		static Delegate GetRemoveEntry_IHandler ()
		{
			if (cb_removeEntry_I == null)
				cb_removeEntry_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_RemoveEntry_I);
			return cb_removeEntry_I;
		}

		static bool n_RemoveEntry_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemoveEntry (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='removeEntry' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeEntry", "(I)Z", "GetRemoveEntry_IHandler")]
		public virtual unsafe bool RemoveEntry (int index)
		{
			const string __id = "removeEntry.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_removeEntryByXValue_F;
#pragma warning disable 0169
		static Delegate GetRemoveEntryByXValue_FHandler ()
		{
			if (cb_removeEntryByXValue_F == null)
				cb_removeEntryByXValue_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, bool>) n_RemoveEntryByXValue_F);
			return cb_removeEntryByXValue_F;
		}

		static bool n_RemoveEntryByXValue_F (IntPtr jnienv, IntPtr native__this, float xValue)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemoveEntryByXValue (xValue);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='removeEntryByXValue' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("removeEntryByXValue", "(F)Z", "GetRemoveEntryByXValue_FHandler")]
		public virtual unsafe bool RemoveEntryByXValue (float xValue)
		{
			const string __id = "removeEntryByXValue.(F)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (xValue);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemoveFirst ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='removeFirst' and count(parameter)=0]"
		[Register ("removeFirst", "()Z", "GetRemoveFirstHandler")]
		public virtual unsafe bool RemoveFirst ()
		{
			const string __id = "removeFirst.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemoveLast ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='removeLast' and count(parameter)=0]"
		[Register ("removeLast", "()Z", "GetRemoveLastHandler")]
		public virtual unsafe bool RemoveLast ()
		{
			const string __id = "removeLast.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_resetColors;
#pragma warning disable 0169
		static Delegate GetResetColorsHandler ()
		{
			if (cb_resetColors == null)
				cb_resetColors = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetColors);
			return cb_resetColors;
		}

		static void n_ResetColors (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetColors ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='resetColors' and count(parameter)=0]"
		[Register ("resetColors", "()V", "GetResetColorsHandler")]
		public virtual unsafe void ResetColors ()
		{
			const string __id = "resetColors.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setColor_II;
#pragma warning disable 0169
		static Delegate GetSetColor_IIHandler ()
		{
			if (cb_setColor_II == null)
				cb_setColor_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetColor_II);
			return cb_setColor_II;
		}

		static void n_SetColor_II (IntPtr jnienv, IntPtr native__this, int color, int alpha)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetColor (color, alpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='setColor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setColor", "(II)V", "GetSetColor_IIHandler")]
		public virtual unsafe void SetColor (int color, int alpha)
		{
			const string __id = "setColor.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (color);
				__args [1] = new JniArgumentValue (alpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setColors_arrayI;
#pragma warning disable 0169
		static Delegate GetSetColors_arrayIHandler ()
		{
			if (cb_setColors_arrayI == null)
				cb_setColors_arrayI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetColors_arrayI);
			return cb_setColors_arrayI;
		}

		static void n_SetColors_arrayI (IntPtr jnienv, IntPtr native__this, IntPtr native_colors)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] colors = (int[]) JNIEnv.GetArray (native_colors, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetColors (colors);
			if (colors != null)
				JNIEnv.CopyArray (colors, native_colors);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='setColors' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("setColors", "([I)V", "GetSetColors_arrayIHandler")]
		public virtual unsafe void SetColors (params int[] colors)
		{
			const string __id = "setColors.([I)V";
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

		static Delegate cb_setColors_arrayILandroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetSetColors_arrayILandroid_content_Context_Handler ()
		{
			if (cb_setColors_arrayILandroid_content_Context_ == null)
				cb_setColors_arrayILandroid_content_Context_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetColors_arrayILandroid_content_Context_);
			return cb_setColors_arrayILandroid_content_Context_;
		}

		static void n_SetColors_arrayILandroid_content_Context_ (IntPtr jnienv, IntPtr native__this, IntPtr native_colors, IntPtr native_c)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] colors = (int[]) JNIEnv.GetArray (native_colors, JniHandleOwnership.DoNotTransfer, typeof (int));
			global::Android.Content.Context c = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.SetColors (colors, c);
			if (colors != null)
				JNIEnv.CopyArray (colors, native_colors);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='setColors' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='android.content.Context']]"
		[Register ("setColors", "([ILandroid/content/Context;)V", "GetSetColors_arrayILandroid_content_Context_Handler")]
		public virtual unsafe void SetColors (int[] colors, global::Android.Content.Context c)
		{
			const string __id = "setColors.([ILandroid/content/Context;)V";
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

		static Delegate cb_setColors_arrayII;
#pragma warning disable 0169
		static Delegate GetSetColors_arrayIIHandler ()
		{
			if (cb_setColors_arrayII == null)
				cb_setColors_arrayII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetColors_arrayII);
			return cb_setColors_arrayII;
		}

		static void n_SetColors_arrayII (IntPtr jnienv, IntPtr native__this, IntPtr native_colors, int alpha)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] colors = (int[]) JNIEnv.GetArray (native_colors, JniHandleOwnership.DoNotTransfer, typeof (int));
			__this.SetColors (colors, alpha);
			if (colors != null)
				JNIEnv.CopyArray (colors, native_colors);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='setColors' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='int']]"
		[Register ("setColors", "([II)V", "GetSetColors_arrayIIHandler")]
		public virtual unsafe void SetColors (int[] colors, int alpha)
		{
			const string __id = "setColors.([II)V";
			IntPtr native_colors = JNIEnv.NewArray (colors);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_colors);
				__args [1] = new JniArgumentValue (alpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (colors != null) {
					JNIEnv.CopyArray (native_colors, colors);
					JNIEnv.DeleteLocalRef (native_colors);
				}
			}
		}

		static Delegate cb_setDrawIcons_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawIcons_ZHandler ()
		{
			if (cb_setDrawIcons_Z == null)
				cb_setDrawIcons_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawIcons_Z);
			return cb_setDrawIcons_Z;
		}

		static void n_SetDrawIcons_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawIcons (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='setDrawIcons' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawIcons", "(Z)V", "GetSetDrawIcons_ZHandler")]
		public virtual unsafe void SetDrawIcons (bool enabled)
		{
			const string __id = "setDrawIcons.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawValues_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawValues_ZHandler ()
		{
			if (cb_setDrawValues_Z == null)
				cb_setDrawValues_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawValues_Z);
			return cb_setDrawValues_Z;
		}

		static void n_SetDrawValues_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawValues (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='setDrawValues' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawValues", "(Z)V", "GetSetDrawValues_ZHandler")]
		public virtual unsafe void SetDrawValues (bool enabled)
		{
			const string __id = "setDrawValues.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setGradientColor_II;
#pragma warning disable 0169
		static Delegate GetSetGradientColor_IIHandler ()
		{
			if (cb_setGradientColor_II == null)
				cb_setGradientColor_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_SetGradientColor_II);
			return cb_setGradientColor_II;
		}

		static void n_SetGradientColor_II (IntPtr jnienv, IntPtr native__this, int startColor, int endColor)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetGradientColor (startColor, endColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='setGradientColor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("setGradientColor", "(II)V", "GetSetGradientColor_IIHandler")]
		public virtual unsafe void SetGradientColor (int startColor, int endColor)
		{
			const string __id = "setGradientColor.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (startColor);
				__args [1] = new JniArgumentValue (endColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setValueTextColors_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetValueTextColors_Ljava_util_List_Handler ()
		{
			if (cb_setValueTextColors_Ljava_util_List_ == null)
				cb_setValueTextColors_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValueTextColors_Ljava_util_List_);
			return cb_setValueTextColors_Ljava_util_List_;
		}

		static void n_SetValueTextColors_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_colors)
		{
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var colors = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (native_colors, JniHandleOwnership.DoNotTransfer);
			__this.SetValueTextColors (colors);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='setValueTextColors' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Integer&gt;']]"
		[Register ("setValueTextColors", "(Ljava/util/List;)V", "GetSetValueTextColors_Ljava_util_List_Handler")]
		public virtual unsafe void SetValueTextColors (global::System.Collections.Generic.IList<global::Java.Lang.Integer> colors)
		{
			const string __id = "setValueTextColors.(Ljava/util/List;)V";
			IntPtr native_colors = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (colors);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_colors);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_colors);
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalcMinMax ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='calcMinMax' and count(parameter)=0]"
		[Register ("calcMinMax", "()V", "GetCalcMinMaxHandler")]
		public abstract void CalcMinMax ();

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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalcMinMaxY (p0, p1);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='calcMinMaxY' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("calcMinMaxY", "(FF)V", "GetCalcMinMaxY_FFHandler")]
		public abstract void CalcMinMaxY (float p0, float p1);

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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public abstract void Clear ();

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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.GetEntriesForXValue (p0));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getEntriesForXValue' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getEntriesForXValue", "(F)Ljava/util/List;", "GetGetEntriesForXValue_FHandler")]
		public abstract global::System.Collections.IList GetEntriesForXValue (float p0);

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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.DataSet.Rounding p2 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet.Rounding> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetEntryIndex (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getEntryIndex' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='com.github.mikephil.charting.data.DataSet.Rounding']]"
		[Register ("getEntryIndex", "(FFLcom/github/mikephil/charting/data/DataSet$Rounding;)I", "GetGetEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_Handler")]
		public abstract int GetEntryIndex (float p0, float p1, global::MikePhil.Charting.Data.DataSet.Rounding p2);

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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EntryCount;
		}
#pragma warning restore 0169

		public abstract int EntryCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getEntryCount' and count(parameter)=0]"
			[Register ("getEntryCount", "()I", "GetGetEntryCountHandler")] get;
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XMax;
		}
#pragma warning restore 0169

		public abstract float XMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getXMax' and count(parameter)=0]"
			[Register ("getXMax", "()F", "GetGetXMaxHandler")] get;
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XMin;
		}
#pragma warning restore 0169

		public abstract float XMin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getXMin' and count(parameter)=0]"
			[Register ("getXMin", "()F", "GetGetXMinHandler")] get;
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YMax;
		}
#pragma warning restore 0169

		public abstract float YMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getYMax' and count(parameter)=0]"
			[Register ("getYMax", "()F", "GetGetYMaxHandler")] get;
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
			global::MikePhil.Charting.Data.BaseDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YMin;
		}
#pragma warning restore 0169

		public abstract float YMin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getYMin' and count(parameter)=0]"
			[Register ("getYMin", "()F", "GetGetYMinHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/BaseDataSet", DoNotGenerateAcw=true)]
	internal partial class BaseDataSetInvoker : BaseDataSet, global::MikePhil.Charting.Interfaces.Datasets.IDataSet {

		public BaseDataSetInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/github/mikephil/charting/data/BaseDataSet", typeof (BaseDataSetInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		public override unsafe int EntryCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getEntryCount' and count(parameter)=0]"
			[Register ("getEntryCount", "()I", "GetGetEntryCountHandler")]
			get {
				const string __id = "getEntryCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe float XMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getXMax' and count(parameter)=0]"
			[Register ("getXMax", "()F", "GetGetXMaxHandler")]
			get {
				const string __id = "getXMax.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe float XMin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getXMin' and count(parameter)=0]"
			[Register ("getXMin", "()F", "GetGetXMinHandler")]
			get {
				const string __id = "getXMin.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe float YMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getYMax' and count(parameter)=0]"
			[Register ("getYMax", "()F", "GetGetYMaxHandler")]
			get {
				const string __id = "getYMax.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe float YMin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseDataSet']/method[@name='getYMin' and count(parameter)=0]"
			[Register ("getYMin", "()F", "GetGetYMinHandler")]
			get {
				const string __id = "getYMin.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='calcMinMax' and count(parameter)=0]"
		[Register ("calcMinMax", "()V", "GetCalcMinMaxHandler")]
		public override unsafe void CalcMinMax ()
		{
			const string __id = "calcMinMax.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='calcMinMaxY' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("calcMinMaxY", "(FF)V", "GetCalcMinMaxY_FFHandler")]
		public override unsafe void CalcMinMaxY (float p0, float p1)
		{
			const string __id = "calcMinMaxY.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public override unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getEntriesForXValue' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getEntriesForXValue", "(F)Ljava/util/List;", "GetGetEntriesForXValue_FHandler")]
		public override unsafe global::System.Collections.IList GetEntriesForXValue (float p0)
		{
			const string __id = "getEntriesForXValue.(F)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (p0);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getEntryIndex' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='com.github.mikephil.charting.data.DataSet.Rounding']]"
		[Register ("getEntryIndex", "(FFLcom/github/mikephil/charting/data/DataSet$Rounding;)I", "GetGetEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_Handler")]
		public override unsafe int GetEntryIndex (float p0, float p1, global::MikePhil.Charting.Data.DataSet.Rounding p2)
		{
			const string __id = "getEntryIndex.(FFLcom/github/mikephil/charting/data/DataSet$Rounding;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}

}
