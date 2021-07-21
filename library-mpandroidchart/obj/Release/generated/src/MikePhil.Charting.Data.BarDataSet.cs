using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarDataSet']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/BarDataSet", DoNotGenerateAcw=true)]
	public partial class BarDataSet : global::MikePhil.Charting.Data.BarLineScatterCandleBubbleDataSet, global::MikePhil.Charting.Interfaces.Datasets.IBarDataSet {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/data/BarDataSet", typeof (BarDataSet));
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

		protected BarDataSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarDataSet']/constructor[@name='BarDataSet' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.github.mikephil.charting.data.BarEntry&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/util/List;Ljava/lang/String;)V", "")]
		public unsafe BarDataSet (global::System.Collections.Generic.IList<global::MikePhil.Charting.Data.BarEntry> yVals, string label)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_yVals = global::Android.Runtime.JavaList<global::MikePhil.Charting.Data.BarEntry>.ToLocalJniHandle (yVals);
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

		static Delegate cb_getBarBorderColor;
#pragma warning disable 0169
		static Delegate GetGetBarBorderColorHandler ()
		{
			if (cb_getBarBorderColor == null)
				cb_getBarBorderColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBarBorderColor);
			return cb_getBarBorderColor;
		}

		static int n_GetBarBorderColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.BarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BarBorderColor;
		}
#pragma warning restore 0169

		static Delegate cb_setBarBorderColor_I;
#pragma warning disable 0169
		static Delegate GetSetBarBorderColor_IHandler ()
		{
			if (cb_setBarBorderColor_I == null)
				cb_setBarBorderColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBarBorderColor_I);
			return cb_setBarBorderColor_I;
		}

		static void n_SetBarBorderColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::MikePhil.Charting.Data.BarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BarBorderColor = color;
		}
#pragma warning restore 0169

		public virtual unsafe int BarBorderColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarDataSet']/method[@name='getBarBorderColor' and count(parameter)=0]"
			[Register ("getBarBorderColor", "()I", "GetGetBarBorderColorHandler")]
			get {
				const string __id = "getBarBorderColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarDataSet']/method[@name='setBarBorderColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBarBorderColor", "(I)V", "GetSetBarBorderColor_IHandler")]
			set {
				const string __id = "setBarBorderColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBarBorderWidth;
#pragma warning disable 0169
		static Delegate GetGetBarBorderWidthHandler ()
		{
			if (cb_getBarBorderWidth == null)
				cb_getBarBorderWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetBarBorderWidth);
			return cb_getBarBorderWidth;
		}

		static float n_GetBarBorderWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.BarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BarBorderWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setBarBorderWidth_F;
#pragma warning disable 0169
		static Delegate GetSetBarBorderWidth_FHandler ()
		{
			if (cb_setBarBorderWidth_F == null)
				cb_setBarBorderWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetBarBorderWidth_F);
			return cb_setBarBorderWidth_F;
		}

		static void n_SetBarBorderWidth_F (IntPtr jnienv, IntPtr native__this, float width)
		{
			global::MikePhil.Charting.Data.BarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BarBorderWidth = width;
		}
#pragma warning restore 0169

		public virtual unsafe float BarBorderWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarDataSet']/method[@name='getBarBorderWidth' and count(parameter)=0]"
			[Register ("getBarBorderWidth", "()F", "GetGetBarBorderWidthHandler")]
			get {
				const string __id = "getBarBorderWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarDataSet']/method[@name='setBarBorderWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBarBorderWidth", "(F)V", "GetSetBarBorderWidth_FHandler")]
			set {
				const string __id = "setBarBorderWidth.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getBarShadowColor;
#pragma warning disable 0169
		static Delegate GetGetBarShadowColorHandler ()
		{
			if (cb_getBarShadowColor == null)
				cb_getBarShadowColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBarShadowColor);
			return cb_getBarShadowColor;
		}

		static int n_GetBarShadowColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.BarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BarShadowColor;
		}
#pragma warning restore 0169

		static Delegate cb_setBarShadowColor_I;
#pragma warning disable 0169
		static Delegate GetSetBarShadowColor_IHandler ()
		{
			if (cb_setBarShadowColor_I == null)
				cb_setBarShadowColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBarShadowColor_I);
			return cb_setBarShadowColor_I;
		}

		static void n_SetBarShadowColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::MikePhil.Charting.Data.BarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BarShadowColor = color;
		}
#pragma warning restore 0169

		public virtual unsafe int BarShadowColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarDataSet']/method[@name='getBarShadowColor' and count(parameter)=0]"
			[Register ("getBarShadowColor", "()I", "GetGetBarShadowColorHandler")]
			get {
				const string __id = "getBarShadowColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarDataSet']/method[@name='setBarShadowColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setBarShadowColor", "(I)V", "GetSetBarShadowColor_IHandler")]
			set {
				const string __id = "setBarShadowColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getEntryCountStacks;
#pragma warning disable 0169
		static Delegate GetGetEntryCountStacksHandler ()
		{
			if (cb_getEntryCountStacks == null)
				cb_getEntryCountStacks = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEntryCountStacks);
			return cb_getEntryCountStacks;
		}

		static int n_GetEntryCountStacks (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.BarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EntryCountStacks;
		}
#pragma warning restore 0169

		public virtual unsafe int EntryCountStacks {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarDataSet']/method[@name='getEntryCountStacks' and count(parameter)=0]"
			[Register ("getEntryCountStacks", "()I", "GetGetEntryCountStacksHandler")]
			get {
				const string __id = "getEntryCountStacks.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getHighLightAlpha;
#pragma warning disable 0169
		static Delegate GetGetHighLightAlphaHandler ()
		{
			if (cb_getHighLightAlpha == null)
				cb_getHighLightAlpha = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetHighLightAlpha);
			return cb_getHighLightAlpha;
		}

		static int n_GetHighLightAlpha (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.BarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighLightAlpha;
		}
#pragma warning restore 0169

		static Delegate cb_setHighLightAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetHighLightAlpha_IHandler ()
		{
			if (cb_setHighLightAlpha_I == null)
				cb_setHighLightAlpha_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHighLightAlpha_I);
			return cb_setHighLightAlpha_I;
		}

		static void n_SetHighLightAlpha_I (IntPtr jnienv, IntPtr native__this, int alpha)
		{
			global::MikePhil.Charting.Data.BarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighLightAlpha = alpha;
		}
#pragma warning restore 0169

		public virtual unsafe int HighLightAlpha {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarDataSet']/method[@name='getHighLightAlpha' and count(parameter)=0]"
			[Register ("getHighLightAlpha", "()I", "GetGetHighLightAlphaHandler")]
			get {
				const string __id = "getHighLightAlpha.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarDataSet']/method[@name='setHighLightAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHighLightAlpha", "(I)V", "GetSetHighLightAlpha_IHandler")]
			set {
				const string __id = "setHighLightAlpha.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isStacked;
#pragma warning disable 0169
		static Delegate GetIsStackedHandler ()
		{
			if (cb_isStacked == null)
				cb_isStacked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStacked);
			return cb_isStacked;
		}

		static bool n_IsStacked (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.BarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStacked;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsStacked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarDataSet']/method[@name='isStacked' and count(parameter)=0]"
			[Register ("isStacked", "()Z", "GetIsStackedHandler")]
			get {
				const string __id = "isStacked.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getStackSize;
#pragma warning disable 0169
		static Delegate GetGetStackSizeHandler ()
		{
			if (cb_getStackSize == null)
				cb_getStackSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStackSize);
			return cb_getStackSize;
		}

		static int n_GetStackSize (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.BarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StackSize;
		}
#pragma warning restore 0169

		public virtual unsafe int StackSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarDataSet']/method[@name='getStackSize' and count(parameter)=0]"
			[Register ("getStackSize", "()I", "GetGetStackSizeHandler")]
			get {
				const string __id = "getStackSize.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_calcMinMax_Lcom_github_mikephil_charting_data_BarEntry_;
#pragma warning disable 0169
		static Delegate GetCalcMinMax_Lcom_github_mikephil_charting_data_BarEntry_Handler ()
		{
			if (cb_calcMinMax_Lcom_github_mikephil_charting_data_BarEntry_ == null)
				cb_calcMinMax_Lcom_github_mikephil_charting_data_BarEntry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CalcMinMax_Lcom_github_mikephil_charting_data_BarEntry_);
			return cb_calcMinMax_Lcom_github_mikephil_charting_data_BarEntry_;
		}

		static void n_CalcMinMax_Lcom_github_mikephil_charting_data_BarEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::MikePhil.Charting.Data.BarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.BarEntry e = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarEntry> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.CalcMinMax (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarDataSet']/method[@name='calcMinMax' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.BarEntry']]"
		[Register ("calcMinMax", "(Lcom/github/mikephil/charting/data/BarEntry;)V", "GetCalcMinMax_Lcom_github_mikephil_charting_data_BarEntry_Handler")]
		protected virtual unsafe void CalcMinMax (global::MikePhil.Charting.Data.BarEntry e)
		{
			const string __id = "calcMinMax.(Lcom/github/mikephil/charting/data/BarEntry;)V";
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
			global::MikePhil.Charting.Data.BarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Copy ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarDataSet']/method[@name='copy' and count(parameter)=0]"
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

		static Delegate cb_copy_Lcom_github_mikephil_charting_data_BarDataSet_;
#pragma warning disable 0169
		static Delegate GetCopy_Lcom_github_mikephil_charting_data_BarDataSet_Handler ()
		{
			if (cb_copy_Lcom_github_mikephil_charting_data_BarDataSet_ == null)
				cb_copy_Lcom_github_mikephil_charting_data_BarDataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Copy_Lcom_github_mikephil_charting_data_BarDataSet_);
			return cb_copy_Lcom_github_mikephil_charting_data_BarDataSet_;
		}

		static void n_Copy_Lcom_github_mikephil_charting_data_BarDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_barDataSet)
		{
			global::MikePhil.Charting.Data.BarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.BarDataSet barDataSet = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarDataSet> (native_barDataSet, JniHandleOwnership.DoNotTransfer);
			__this.Copy (barDataSet);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarDataSet']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.BarDataSet']]"
		[Register ("copy", "(Lcom/github/mikephil/charting/data/BarDataSet;)V", "GetCopy_Lcom_github_mikephil_charting_data_BarDataSet_Handler")]
		protected virtual unsafe void Copy (global::MikePhil.Charting.Data.BarDataSet barDataSet)
		{
			const string __id = "copy.(Lcom/github/mikephil/charting/data/BarDataSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((barDataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) barDataSet).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getStackLabels;
#pragma warning disable 0169
		static Delegate GetGetStackLabelsHandler ()
		{
			if (cb_getStackLabels == null)
				cb_getStackLabels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetStackLabels);
			return cb_getStackLabels;
		}

		static IntPtr n_GetStackLabels (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.BarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetStackLabels ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarDataSet']/method[@name='getStackLabels' and count(parameter)=0]"
		[Register ("getStackLabels", "()[Ljava/lang/String;", "GetGetStackLabelsHandler")]
		public virtual unsafe string[] GetStackLabels ()
		{
			const string __id = "getStackLabels.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_setStackLabels_arrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetStackLabels_arrayLjava_lang_String_Handler ()
		{
			if (cb_setStackLabels_arrayLjava_lang_String_ == null)
				cb_setStackLabels_arrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetStackLabels_arrayLjava_lang_String_);
			return cb_setStackLabels_arrayLjava_lang_String_;
		}

		static void n_SetStackLabels_arrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_labels)
		{
			global::MikePhil.Charting.Data.BarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string[] labels = (string[]) JNIEnv.GetArray (native_labels, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetStackLabels (labels);
			if (labels != null)
				JNIEnv.CopyArray (labels, native_labels);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarDataSet']/method[@name='setStackLabels' and count(parameter)=1 and parameter[1][@type='java.lang.String[]']]"
		[Register ("setStackLabels", "([Ljava/lang/String;)V", "GetSetStackLabels_arrayLjava_lang_String_Handler")]
		public virtual unsafe void SetStackLabels (string[] labels)
		{
			const string __id = "setStackLabels.([Ljava/lang/String;)V";
			IntPtr native_labels = JNIEnv.NewArray (labels);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_labels);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (labels != null) {
					JNIEnv.CopyArray (native_labels, labels);
					JNIEnv.DeleteLocalRef (native_labels);
				}
			}
		}

	}
}
