using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Components {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/components/LimitLine", DoNotGenerateAcw=true)]
	public partial class LimitLine : global::MikePhil.Charting.Components.ComponentBase {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine.LimitLabelPosition']"
		[global::Android.Runtime.Register ("com/github/mikephil/charting/components/LimitLine$LimitLabelPosition", DoNotGenerateAcw=true)]
		public sealed partial class LimitLabelPosition : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine.LimitLabelPosition']/field[@name='LEFT_BOTTOM']"
			[Register ("LEFT_BOTTOM")]
			public static global::MikePhil.Charting.Components.LimitLine.LimitLabelPosition LeftBottom {
				get {
					const string __id = "LEFT_BOTTOM.Lcom/github/mikephil/charting/components/LimitLine$LimitLabelPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine.LimitLabelPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine.LimitLabelPosition']/field[@name='LEFT_TOP']"
			[Register ("LEFT_TOP")]
			public static global::MikePhil.Charting.Components.LimitLine.LimitLabelPosition LeftTop {
				get {
					const string __id = "LEFT_TOP.Lcom/github/mikephil/charting/components/LimitLine$LimitLabelPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine.LimitLabelPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine.LimitLabelPosition']/field[@name='RIGHT_BOTTOM']"
			[Register ("RIGHT_BOTTOM")]
			public static global::MikePhil.Charting.Components.LimitLine.LimitLabelPosition RightBottom {
				get {
					const string __id = "RIGHT_BOTTOM.Lcom/github/mikephil/charting/components/LimitLine$LimitLabelPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine.LimitLabelPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine.LimitLabelPosition']/field[@name='RIGHT_TOP']"
			[Register ("RIGHT_TOP")]
			public static global::MikePhil.Charting.Components.LimitLine.LimitLabelPosition RightTop {
				get {
					const string __id = "RIGHT_TOP.Lcom/github/mikephil/charting/components/LimitLine$LimitLabelPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine.LimitLabelPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/components/LimitLine$LimitLabelPosition", typeof (LimitLabelPosition));

			internal static IntPtr class_ref {
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

			internal LimitLabelPosition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine.LimitLabelPosition']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/github/mikephil/charting/components/LimitLine$LimitLabelPosition;", "")]
			public static unsafe global::MikePhil.Charting.Components.LimitLine.LimitLabelPosition ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/github/mikephil/charting/components/LimitLine$LimitLabelPosition;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine.LimitLabelPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine.LimitLabelPosition']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/github/mikephil/charting/components/LimitLine$LimitLabelPosition;", "")]
			public static unsafe global::MikePhil.Charting.Components.LimitLine.LimitLabelPosition[] Values ()
			{
				const string __id = "values.()[Lcom/github/mikephil/charting/components/LimitLine$LimitLabelPosition;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::MikePhil.Charting.Components.LimitLine.LimitLabelPosition[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::MikePhil.Charting.Components.LimitLine.LimitLabelPosition));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/components/LimitLine", typeof (LimitLine));

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

		protected LimitLine (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine']/constructor[@name='LimitLine' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register (".ctor", "(F)V", "")]
		public unsafe LimitLine (float limit) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(F)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (limit);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine']/constructor[@name='LimitLine' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(FLjava/lang/String;)V", "")]
		public unsafe LimitLine (float limit, string label) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FLjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (limit);
				__args [1] = new JniArgumentValue (native_label);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_label);
			}
		}

		static Delegate cb_getDashPathEffect;
#pragma warning disable 0169
		static Delegate GetGetDashPathEffectHandler ()
		{
			if (cb_getDashPathEffect == null)
				cb_getDashPathEffect = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDashPathEffect);
			return cb_getDashPathEffect;
		}

		static IntPtr n_GetDashPathEffect (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DashPathEffect);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.DashPathEffect DashPathEffect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine']/method[@name='getDashPathEffect' and count(parameter)=0]"
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

		static Delegate cb_isDashedLineEnabled;
#pragma warning disable 0169
		static Delegate GetIsDashedLineEnabledHandler ()
		{
			if (cb_isDashedLineEnabled == null)
				cb_isDashedLineEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDashedLineEnabled);
			return cb_isDashedLineEnabled;
		}

		static bool n_IsDashedLineEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDashedLineEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDashedLineEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine']/method[@name='isDashedLineEnabled' and count(parameter)=0]"
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

		static Delegate cb_getLabel;
#pragma warning disable 0169
		static Delegate GetGetLabelHandler ()
		{
			if (cb_getLabel == null)
				cb_getLabel = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLabel);
			return cb_getLabel;
		}

		static IntPtr n_GetLabel (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Label);
		}
#pragma warning restore 0169

		static Delegate cb_setLabel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLabel_Ljava_lang_String_Handler ()
		{
			if (cb_setLabel_Ljava_lang_String_ == null)
				cb_setLabel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLabel_Ljava_lang_String_);
			return cb_setLabel_Ljava_lang_String_;
		}

		static void n_SetLabel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_label)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var label = JNIEnv.GetString (native_label, JniHandleOwnership.DoNotTransfer);
			__this.Label = label;
		}
#pragma warning restore 0169

		public virtual unsafe string Label {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine']/method[@name='getLabel' and count(parameter)=0]"
			[Register ("getLabel", "()Ljava/lang/String;", "GetGetLabelHandler")]
			get {
				const string __id = "getLabel.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine']/method[@name='setLabel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
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

		static Delegate cb_getLabelPosition;
#pragma warning disable 0169
		static Delegate GetGetLabelPositionHandler ()
		{
			if (cb_getLabelPosition == null)
				cb_getLabelPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetLabelPosition);
			return cb_getLabelPosition;
		}

		static IntPtr n_GetLabelPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LabelPosition);
		}
#pragma warning restore 0169

		static Delegate cb_setLabelPosition_Lcom_github_mikephil_charting_components_LimitLine_LimitLabelPosition_;
#pragma warning disable 0169
		static Delegate GetSetLabelPosition_Lcom_github_mikephil_charting_components_LimitLine_LimitLabelPosition_Handler ()
		{
			if (cb_setLabelPosition_Lcom_github_mikephil_charting_components_LimitLine_LimitLabelPosition_ == null)
				cb_setLabelPosition_Lcom_github_mikephil_charting_components_LimitLine_LimitLabelPosition_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetLabelPosition_Lcom_github_mikephil_charting_components_LimitLine_LimitLabelPosition_);
			return cb_setLabelPosition_Lcom_github_mikephil_charting_components_LimitLine_LimitLabelPosition_;
		}

		static void n_SetLabelPosition_Lcom_github_mikephil_charting_components_LimitLine_LimitLabelPosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pos)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pos = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine.LimitLabelPosition> (native_pos, JniHandleOwnership.DoNotTransfer);
			__this.LabelPosition = pos;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Components.LimitLine.LimitLabelPosition LabelPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine']/method[@name='getLabelPosition' and count(parameter)=0]"
			[Register ("getLabelPosition", "()Lcom/github/mikephil/charting/components/LimitLine$LimitLabelPosition;", "GetGetLabelPositionHandler")]
			get {
				const string __id = "getLabelPosition.()Lcom/github/mikephil/charting/components/LimitLine$LimitLabelPosition;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine.LimitLabelPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine']/method[@name='setLabelPosition' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.LimitLine.LimitLabelPosition']]"
			[Register ("setLabelPosition", "(Lcom/github/mikephil/charting/components/LimitLine$LimitLabelPosition;)V", "GetSetLabelPosition_Lcom_github_mikephil_charting_components_LimitLine_LimitLabelPosition_Handler")]
			set {
				const string __id = "setLabelPosition.(Lcom/github/mikephil/charting/components/LimitLine$LimitLabelPosition;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getLimit;
#pragma warning disable 0169
		static Delegate GetGetLimitHandler ()
		{
			if (cb_getLimit == null)
				cb_getLimit = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetLimit);
			return cb_getLimit;
		}

		static float n_GetLimit (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Limit;
		}
#pragma warning restore 0169

		public virtual unsafe float Limit {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine']/method[@name='getLimit' and count(parameter)=0]"
			[Register ("getLimit", "()F", "GetGetLimitHandler")]
			get {
				const string __id = "getLimit.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLineColor;
#pragma warning disable 0169
		static Delegate GetGetLineColorHandler ()
		{
			if (cb_getLineColor == null)
				cb_getLineColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetLineColor);
			return cb_getLineColor;
		}

		static int n_GetLineColor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LineColor;
		}
#pragma warning restore 0169

		static Delegate cb_setLineColor_I;
#pragma warning disable 0169
		static Delegate GetSetLineColor_IHandler ()
		{
			if (cb_setLineColor_I == null)
				cb_setLineColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetLineColor_I);
			return cb_setLineColor_I;
		}

		static void n_SetLineColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LineColor = color;
		}
#pragma warning restore 0169

		public virtual unsafe int LineColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine']/method[@name='getLineColor' and count(parameter)=0]"
			[Register ("getLineColor", "()I", "GetGetLineColorHandler")]
			get {
				const string __id = "getLineColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine']/method[@name='setLineColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setLineColor", "(I)V", "GetSetLineColor_IHandler")]
			set {
				const string __id = "setLineColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLineWidth;
#pragma warning disable 0169
		static Delegate GetGetLineWidthHandler ()
		{
			if (cb_getLineWidth == null)
				cb_getLineWidth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetLineWidth);
			return cb_getLineWidth;
		}

		static float n_GetLineWidth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LineWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setLineWidth_F;
#pragma warning disable 0169
		static Delegate GetSetLineWidth_FHandler ()
		{
			if (cb_setLineWidth_F == null)
				cb_setLineWidth_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetLineWidth_F);
			return cb_setLineWidth_F;
		}

		static void n_SetLineWidth_F (IntPtr jnienv, IntPtr native__this, float width)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LineWidth = width;
		}
#pragma warning restore 0169

		public virtual unsafe float LineWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine']/method[@name='getLineWidth' and count(parameter)=0]"
			[Register ("getLineWidth", "()F", "GetGetLineWidthHandler")]
			get {
				const string __id = "getLineWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine']/method[@name='setLineWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setLineWidth", "(F)V", "GetSetLineWidth_FHandler")]
			set {
				const string __id = "setLineWidth.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextStyle;
#pragma warning disable 0169
		static Delegate GetGetTextStyleHandler ()
		{
			if (cb_getTextStyle == null)
				cb_getTextStyle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTextStyle);
			return cb_getTextStyle;
		}

		static IntPtr n_GetTextStyle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextStyle);
		}
#pragma warning restore 0169

		static Delegate cb_setTextStyle_Landroid_graphics_Paint_Style_;
#pragma warning disable 0169
		static Delegate GetSetTextStyle_Landroid_graphics_Paint_Style_Handler ()
		{
			if (cb_setTextStyle_Landroid_graphics_Paint_Style_ == null)
				cb_setTextStyle_Landroid_graphics_Paint_Style_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTextStyle_Landroid_graphics_Paint_Style_);
			return cb_setTextStyle_Landroid_graphics_Paint_Style_;
		}

		static void n_SetTextStyle_Landroid_graphics_Paint_Style_ (IntPtr jnienv, IntPtr native__this, IntPtr native_style)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var style = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Style> (native_style, JniHandleOwnership.DoNotTransfer);
			__this.TextStyle = style;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Paint.Style TextStyle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine']/method[@name='getTextStyle' and count(parameter)=0]"
			[Register ("getTextStyle", "()Landroid/graphics/Paint$Style;", "GetGetTextStyleHandler")]
			get {
				const string __id = "getTextStyle.()Landroid/graphics/Paint$Style;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Style> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine']/method[@name='setTextStyle' and count(parameter)=1 and parameter[1][@type='android.graphics.Paint.Style']]"
			[Register ("setTextStyle", "(Landroid/graphics/Paint$Style;)V", "GetSetTextStyle_Landroid_graphics_Paint_Style_Handler")]
			set {
				const string __id = "setTextStyle.(Landroid/graphics/Paint$Style;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_disableDashedLine;
#pragma warning disable 0169
		static Delegate GetDisableDashedLineHandler ()
		{
			if (cb_disableDashedLine == null)
				cb_disableDashedLine = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_DisableDashedLine);
			return cb_disableDashedLine;
		}

		static void n_DisableDashedLine (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableDashedLine ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine']/method[@name='disableDashedLine' and count(parameter)=0]"
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
				cb_enableDashedLine_FFF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFFF_V) n_EnableDashedLine_FFF);
			return cb_enableDashedLine_FFF;
		}

		static void n_EnableDashedLine_FFF (IntPtr jnienv, IntPtr native__this, float lineLength, float spaceLength, float phase)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.LimitLine> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableDashedLine (lineLength, spaceLength, phase);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LimitLine']/method[@name='enableDashedLine' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
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

	}
}
