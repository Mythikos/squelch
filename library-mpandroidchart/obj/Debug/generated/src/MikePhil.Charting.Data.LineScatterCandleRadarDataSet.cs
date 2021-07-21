using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineScatterCandleRadarDataSet']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/LineScatterCandleRadarDataSet", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.github.mikephil.charting.data.Entry"})]
	public abstract partial class LineScatterCandleRadarDataSet : global::MikePhil.Charting.Data.BarLineScatterCandleBubbleDataSet, global::MikePhil.Charting.Interfaces.Datasets.ILineScatterCandleRadarDataSet {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineScatterCandleRadarDataSet']/field[@name='mDrawHorizontalHighlightIndicator']"
		[Register ("mDrawHorizontalHighlightIndicator")]
		protected bool MDrawHorizontalHighlightIndicator {
			get {
				const string __id = "mDrawHorizontalHighlightIndicator.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mDrawHorizontalHighlightIndicator.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineScatterCandleRadarDataSet']/field[@name='mDrawVerticalHighlightIndicator']"
		[Register ("mDrawVerticalHighlightIndicator")]
		protected bool MDrawVerticalHighlightIndicator {
			get {
				const string __id = "mDrawVerticalHighlightIndicator.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mDrawVerticalHighlightIndicator.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineScatterCandleRadarDataSet']/field[@name='mHighlightDashPathEffect']"
		[Register ("mHighlightDashPathEffect")]
		protected global::Android.Graphics.DashPathEffect MHighlightDashPathEffect {
			get {
				const string __id = "mHighlightDashPathEffect.Landroid/graphics/DashPathEffect;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.DashPathEffect> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mHighlightDashPathEffect.Landroid/graphics/DashPathEffect;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineScatterCandleRadarDataSet']/field[@name='mHighlightLineWidth']"
		[Register ("mHighlightLineWidth")]
		protected float MHighlightLineWidth {
			get {
				const string __id = "mHighlightLineWidth.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mHighlightLineWidth.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/data/LineScatterCandleRadarDataSet", typeof (LineScatterCandleRadarDataSet));
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

		protected LineScatterCandleRadarDataSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineScatterCandleRadarDataSet']/constructor[@name='LineScatterCandleRadarDataSet' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;T&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/util/List;Ljava/lang/String;)V", "")]
		public unsafe LineScatterCandleRadarDataSet (global::System.Collections.IList yVals, string label)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_yVals = global::Android.Runtime.JavaList.ToLocalJniHandle (yVals);
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
			global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DashPathEffectHighlight);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.DashPathEffect DashPathEffectHighlight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineScatterCandleRadarDataSet']/method[@name='getDashPathEffectHighlight' and count(parameter)=0]"
			[Register ("getDashPathEffectHighlight", "()Landroid/graphics/DashPathEffect;", "GetGetDashPathEffectHighlightHandler")]
			get {
				const string __id = "getDashPathEffectHighlight.()Landroid/graphics/DashPathEffect;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.DashPathEffect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighlightLineWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setHighlightLineWidth_F;
#pragma warning disable 0169
		static Delegate GetSetHighlightLineWidth_FHandler ()
		{
			if (cb_setHighlightLineWidth_F == null)
				cb_setHighlightLineWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetHighlightLineWidth_F);
			return cb_setHighlightLineWidth_F;
		}

		static void n_SetHighlightLineWidth_F (IntPtr jnienv, IntPtr native__this, float width)
		{
			global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighlightLineWidth = width;
		}
#pragma warning restore 0169

		public virtual unsafe float HighlightLineWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineScatterCandleRadarDataSet']/method[@name='getHighlightLineWidth' and count(parameter)=0]"
			[Register ("getHighlightLineWidth", "()F", "GetGetHighlightLineWidthHandler")]
			get {
				const string __id = "getHighlightLineWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineScatterCandleRadarDataSet']/method[@name='setHighlightLineWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setHighlightLineWidth", "(F)V", "GetSetHighlightLineWidth_FHandler")]
			set {
				const string __id = "setHighlightLineWidth.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDashedHighlightLineEnabled;
#pragma warning disable 0169
		static Delegate GetIsDashedHighlightLineEnabledHandler ()
		{
			if (cb_isDashedHighlightLineEnabled == null)
				cb_isDashedHighlightLineEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDashedHighlightLineEnabled);
			return cb_isDashedHighlightLineEnabled;
		}

		static bool n_IsDashedHighlightLineEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDashedHighlightLineEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDashedHighlightLineEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineScatterCandleRadarDataSet']/method[@name='isDashedHighlightLineEnabled' and count(parameter)=0]"
			[Register ("isDashedHighlightLineEnabled", "()Z", "GetIsDashedHighlightLineEnabledHandler")]
			get {
				const string __id = "isDashedHighlightLineEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHorizontalHighlightIndicatorEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsHorizontalHighlightIndicatorEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineScatterCandleRadarDataSet']/method[@name='isHorizontalHighlightIndicatorEnabled' and count(parameter)=0]"
			[Register ("isHorizontalHighlightIndicatorEnabled", "()Z", "GetIsHorizontalHighlightIndicatorEnabledHandler")]
			get {
				const string __id = "isHorizontalHighlightIndicatorEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsVerticalHighlightIndicatorEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsVerticalHighlightIndicatorEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineScatterCandleRadarDataSet']/method[@name='isVerticalHighlightIndicatorEnabled' and count(parameter)=0]"
			[Register ("isVerticalHighlightIndicatorEnabled", "()Z", "GetIsVerticalHighlightIndicatorEnabledHandler")]
			get {
				const string __id = "isVerticalHighlightIndicatorEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_copy_Lcom_github_mikephil_charting_data_LineScatterCandleRadarDataSet_;
#pragma warning disable 0169
		static Delegate GetCopy_Lcom_github_mikephil_charting_data_LineScatterCandleRadarDataSet_Handler ()
		{
			if (cb_copy_Lcom_github_mikephil_charting_data_LineScatterCandleRadarDataSet_ == null)
				cb_copy_Lcom_github_mikephil_charting_data_LineScatterCandleRadarDataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Copy_Lcom_github_mikephil_charting_data_LineScatterCandleRadarDataSet_);
			return cb_copy_Lcom_github_mikephil_charting_data_LineScatterCandleRadarDataSet_;
		}

		static void n_Copy_Lcom_github_mikephil_charting_data_LineScatterCandleRadarDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_lineScatterCandleRadarDataSet)
		{
			global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet lineScatterCandleRadarDataSet = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet> (native_lineScatterCandleRadarDataSet, JniHandleOwnership.DoNotTransfer);
			__this.Copy (lineScatterCandleRadarDataSet);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineScatterCandleRadarDataSet']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.LineScatterCandleRadarDataSet']]"
		[Register ("copy", "(Lcom/github/mikephil/charting/data/LineScatterCandleRadarDataSet;)V", "GetCopy_Lcom_github_mikephil_charting_data_LineScatterCandleRadarDataSet_Handler")]
		protected virtual unsafe void Copy (global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet lineScatterCandleRadarDataSet)
		{
			const string __id = "copy.(Lcom/github/mikephil/charting/data/LineScatterCandleRadarDataSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((lineScatterCandleRadarDataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lineScatterCandleRadarDataSet).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_disableDashedHighlightLine;
#pragma warning disable 0169
		static Delegate GetDisableDashedHighlightLineHandler ()
		{
			if (cb_disableDashedHighlightLine == null)
				cb_disableDashedHighlightLine = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableDashedHighlightLine);
			return cb_disableDashedHighlightLine;
		}

		static void n_DisableDashedHighlightLine (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableDashedHighlightLine ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineScatterCandleRadarDataSet']/method[@name='disableDashedHighlightLine' and count(parameter)=0]"
		[Register ("disableDashedHighlightLine", "()V", "GetDisableDashedHighlightLineHandler")]
		public virtual unsafe void DisableDashedHighlightLine ()
		{
			const string __id = "disableDashedHighlightLine.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_enableDashedHighlightLine_FFF;
#pragma warning disable 0169
		static Delegate GetEnableDashedHighlightLine_FFFHandler ()
		{
			if (cb_enableDashedHighlightLine_FFF == null)
				cb_enableDashedHighlightLine_FFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float>) n_EnableDashedHighlightLine_FFF);
			return cb_enableDashedHighlightLine_FFF;
		}

		static void n_EnableDashedHighlightLine_FFF (IntPtr jnienv, IntPtr native__this, float lineLength, float spaceLength, float phase)
		{
			global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableDashedHighlightLine (lineLength, spaceLength, phase);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineScatterCandleRadarDataSet']/method[@name='enableDashedHighlightLine' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("enableDashedHighlightLine", "(FFF)V", "GetEnableDashedHighlightLine_FFFHandler")]
		public virtual unsafe void EnableDashedHighlightLine (float lineLength, float spaceLength, float phase)
		{
			const string __id = "enableDashedHighlightLine.(FFF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (lineLength);
				__args [1] = new JniArgumentValue (spaceLength);
				__args [2] = new JniArgumentValue (phase);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawHighlightIndicators_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawHighlightIndicators_ZHandler ()
		{
			if (cb_setDrawHighlightIndicators_Z == null)
				cb_setDrawHighlightIndicators_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawHighlightIndicators_Z);
			return cb_setDrawHighlightIndicators_Z;
		}

		static void n_SetDrawHighlightIndicators_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawHighlightIndicators (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineScatterCandleRadarDataSet']/method[@name='setDrawHighlightIndicators' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawHighlightIndicators", "(Z)V", "GetSetDrawHighlightIndicators_ZHandler")]
		public virtual unsafe void SetDrawHighlightIndicators (bool enabled)
		{
			const string __id = "setDrawHighlightIndicators.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawHorizontalHighlightIndicator_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawHorizontalHighlightIndicator_ZHandler ()
		{
			if (cb_setDrawHorizontalHighlightIndicator_Z == null)
				cb_setDrawHorizontalHighlightIndicator_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawHorizontalHighlightIndicator_Z);
			return cb_setDrawHorizontalHighlightIndicator_Z;
		}

		static void n_SetDrawHorizontalHighlightIndicator_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawHorizontalHighlightIndicator (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineScatterCandleRadarDataSet']/method[@name='setDrawHorizontalHighlightIndicator' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawHorizontalHighlightIndicator", "(Z)V", "GetSetDrawHorizontalHighlightIndicator_ZHandler")]
		public virtual unsafe void SetDrawHorizontalHighlightIndicator (bool enabled)
		{
			const string __id = "setDrawHorizontalHighlightIndicator.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawVerticalHighlightIndicator_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawVerticalHighlightIndicator_ZHandler ()
		{
			if (cb_setDrawVerticalHighlightIndicator_Z == null)
				cb_setDrawVerticalHighlightIndicator_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawVerticalHighlightIndicator_Z);
			return cb_setDrawVerticalHighlightIndicator_Z;
		}

		static void n_SetDrawVerticalHighlightIndicator_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawVerticalHighlightIndicator (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineScatterCandleRadarDataSet']/method[@name='setDrawVerticalHighlightIndicator' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawVerticalHighlightIndicator", "(Z)V", "GetSetDrawVerticalHighlightIndicator_ZHandler")]
		public virtual unsafe void SetDrawVerticalHighlightIndicator (bool enabled)
		{
			const string __id = "setDrawVerticalHighlightIndicator.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/LineScatterCandleRadarDataSet", DoNotGenerateAcw=true)]
	internal partial class LineScatterCandleRadarDataSetInvoker : LineScatterCandleRadarDataSet, global::MikePhil.Charting.Interfaces.Datasets.ILineScatterCandleRadarDataSet, global::MikePhil.Charting.Interfaces.Datasets.IBarLineScatterCandleBubbleDataSet, global::MikePhil.Charting.Interfaces.Datasets.IDataSet {

		public LineScatterCandleRadarDataSetInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/github/mikephil/charting/data/LineScatterCandleRadarDataSet", typeof (LineScatterCandleRadarDataSetInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='copy' and count(parameter)=0]"
		[Register ("copy", "()Lcom/github/mikephil/charting/data/DataSet;", "GetCopyHandler")]
		public override unsafe global::MikePhil.Charting.Data.DataSet Copy ()
		{
			const string __id = "copy.()Lcom/github/mikephil/charting/data/DataSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
