using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Components {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='XAxis']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/components/XAxis", DoNotGenerateAcw=true)]
	public partial class XAxis : global::MikePhil.Charting.Components.AxisBase {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='XAxis']/field[@name='mLabelHeight']"
		[Register ("mLabelHeight")]
		public int MLabelHeight {
			get {
				const string __id = "mLabelHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mLabelHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='XAxis']/field[@name='mLabelRotatedHeight']"
		[Register ("mLabelRotatedHeight")]
		public int MLabelRotatedHeight {
			get {
				const string __id = "mLabelRotatedHeight.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mLabelRotatedHeight.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='XAxis']/field[@name='mLabelRotatedWidth']"
		[Register ("mLabelRotatedWidth")]
		public int MLabelRotatedWidth {
			get {
				const string __id = "mLabelRotatedWidth.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mLabelRotatedWidth.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='XAxis']/field[@name='mLabelRotationAngle']"
		[Register ("mLabelRotationAngle")]
		protected float MLabelRotationAngle {
			get {
				const string __id = "mLabelRotationAngle.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mLabelRotationAngle.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='XAxis']/field[@name='mLabelWidth']"
		[Register ("mLabelWidth")]
		public int MLabelWidth {
			get {
				const string __id = "mLabelWidth.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mLabelWidth.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='XAxis.XAxisPosition']"
		[global::Android.Runtime.Register ("com/github/mikephil/charting/components/XAxis$XAxisPosition", DoNotGenerateAcw=true)]
		public sealed partial class XAxisPosition : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='XAxis.XAxisPosition']/field[@name='BOTH_SIDED']"
			[Register ("BOTH_SIDED")]
			public static global::MikePhil.Charting.Components.XAxis.XAxisPosition BothSided {
				get {
					const string __id = "BOTH_SIDED.Lcom/github/mikephil/charting/components/XAxis$XAxisPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.XAxis.XAxisPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='XAxis.XAxisPosition']/field[@name='BOTTOM']"
			[Register ("BOTTOM")]
			public static global::MikePhil.Charting.Components.XAxis.XAxisPosition Bottom {
				get {
					const string __id = "BOTTOM.Lcom/github/mikephil/charting/components/XAxis$XAxisPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.XAxis.XAxisPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='XAxis.XAxisPosition']/field[@name='BOTTOM_INSIDE']"
			[Register ("BOTTOM_INSIDE")]
			public static global::MikePhil.Charting.Components.XAxis.XAxisPosition BottomInside {
				get {
					const string __id = "BOTTOM_INSIDE.Lcom/github/mikephil/charting/components/XAxis$XAxisPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.XAxis.XAxisPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='XAxis.XAxisPosition']/field[@name='TOP']"
			[Register ("TOP")]
			public static global::MikePhil.Charting.Components.XAxis.XAxisPosition Top {
				get {
					const string __id = "TOP.Lcom/github/mikephil/charting/components/XAxis$XAxisPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.XAxis.XAxisPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='XAxis.XAxisPosition']/field[@name='TOP_INSIDE']"
			[Register ("TOP_INSIDE")]
			public static global::MikePhil.Charting.Components.XAxis.XAxisPosition TopInside {
				get {
					const string __id = "TOP_INSIDE.Lcom/github/mikephil/charting/components/XAxis$XAxisPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.XAxis.XAxisPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/components/XAxis$XAxisPosition", typeof (XAxisPosition));

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

			internal XAxisPosition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='XAxis.XAxisPosition']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/github/mikephil/charting/components/XAxis$XAxisPosition;", "")]
			public static unsafe global::MikePhil.Charting.Components.XAxis.XAxisPosition ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/github/mikephil/charting/components/XAxis$XAxisPosition;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.XAxis.XAxisPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='XAxis.XAxisPosition']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/github/mikephil/charting/components/XAxis$XAxisPosition;", "")]
			public static unsafe global::MikePhil.Charting.Components.XAxis.XAxisPosition[] Values ()
			{
				const string __id = "values.()[Lcom/github/mikephil/charting/components/XAxis$XAxisPosition;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::MikePhil.Charting.Components.XAxis.XAxisPosition[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::MikePhil.Charting.Components.XAxis.XAxisPosition));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/components/XAxis", typeof (XAxis));

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

		protected XAxis (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='XAxis']/constructor[@name='XAxis' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe XAxis () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isAvoidFirstLastClippingEnabled;
#pragma warning disable 0169
		static Delegate GetIsAvoidFirstLastClippingEnabledHandler ()
		{
			if (cb_isAvoidFirstLastClippingEnabled == null)
				cb_isAvoidFirstLastClippingEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsAvoidFirstLastClippingEnabled);
			return cb_isAvoidFirstLastClippingEnabled;
		}

		static bool n_IsAvoidFirstLastClippingEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.XAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAvoidFirstLastClippingEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAvoidFirstLastClippingEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='XAxis']/method[@name='isAvoidFirstLastClippingEnabled' and count(parameter)=0]"
			[Register ("isAvoidFirstLastClippingEnabled", "()Z", "GetIsAvoidFirstLastClippingEnabledHandler")]
			get {
				const string __id = "isAvoidFirstLastClippingEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLabelRotationAngle;
#pragma warning disable 0169
		static Delegate GetGetLabelRotationAngleHandler ()
		{
			if (cb_getLabelRotationAngle == null)
				cb_getLabelRotationAngle = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetLabelRotationAngle);
			return cb_getLabelRotationAngle;
		}

		static float n_GetLabelRotationAngle (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.XAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LabelRotationAngle;
		}
#pragma warning restore 0169

		static Delegate cb_setLabelRotationAngle_F;
#pragma warning disable 0169
		static Delegate GetSetLabelRotationAngle_FHandler ()
		{
			if (cb_setLabelRotationAngle_F == null)
				cb_setLabelRotationAngle_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetLabelRotationAngle_F);
			return cb_setLabelRotationAngle_F;
		}

		static void n_SetLabelRotationAngle_F (IntPtr jnienv, IntPtr native__this, float angle)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.XAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LabelRotationAngle = angle;
		}
#pragma warning restore 0169

		public virtual unsafe float LabelRotationAngle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='XAxis']/method[@name='getLabelRotationAngle' and count(parameter)=0]"
			[Register ("getLabelRotationAngle", "()F", "GetGetLabelRotationAngleHandler")]
			get {
				const string __id = "getLabelRotationAngle.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='XAxis']/method[@name='setLabelRotationAngle' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setLabelRotationAngle", "(F)V", "GetSetLabelRotationAngle_FHandler")]
			set {
				const string __id = "setLabelRotationAngle.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPosition;
#pragma warning disable 0169
		static Delegate GetGetPositionHandler ()
		{
			if (cb_getPosition == null)
				cb_getPosition = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetPosition);
			return cb_getPosition;
		}

		static IntPtr n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.XAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Position);
		}
#pragma warning restore 0169

		static Delegate cb_setPosition_Lcom_github_mikephil_charting_components_XAxis_XAxisPosition_;
#pragma warning disable 0169
		static Delegate GetSetPosition_Lcom_github_mikephil_charting_components_XAxis_XAxisPosition_Handler ()
		{
			if (cb_setPosition_Lcom_github_mikephil_charting_components_XAxis_XAxisPosition_ == null)
				cb_setPosition_Lcom_github_mikephil_charting_components_XAxis_XAxisPosition_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPosition_Lcom_github_mikephil_charting_components_XAxis_XAxisPosition_);
			return cb_setPosition_Lcom_github_mikephil_charting_components_XAxis_XAxisPosition_;
		}

		static void n_SetPosition_Lcom_github_mikephil_charting_components_XAxis_XAxisPosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pos)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.XAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pos = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.XAxis.XAxisPosition> (native_pos, JniHandleOwnership.DoNotTransfer);
			__this.Position = pos;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Components.XAxis.XAxisPosition Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='XAxis']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lcom/github/mikephil/charting/components/XAxis$XAxisPosition;", "GetGetPositionHandler")]
			get {
				const string __id = "getPosition.()Lcom/github/mikephil/charting/components/XAxis$XAxisPosition;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.XAxis.XAxisPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='XAxis']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.XAxis.XAxisPosition']]"
			[Register ("setPosition", "(Lcom/github/mikephil/charting/components/XAxis$XAxisPosition;)V", "GetSetPosition_Lcom_github_mikephil_charting_components_XAxis_XAxisPosition_Handler")]
			set {
				const string __id = "setPosition.(Lcom/github/mikephil/charting/components/XAxis$XAxisPosition;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_setAvoidFirstLastClipping_Z;
#pragma warning disable 0169
		static Delegate GetSetAvoidFirstLastClipping_ZHandler ()
		{
			if (cb_setAvoidFirstLastClipping_Z == null)
				cb_setAvoidFirstLastClipping_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetAvoidFirstLastClipping_Z);
			return cb_setAvoidFirstLastClipping_Z;
		}

		static void n_SetAvoidFirstLastClipping_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.XAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAvoidFirstLastClipping (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='XAxis']/method[@name='setAvoidFirstLastClipping' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAvoidFirstLastClipping", "(Z)V", "GetSetAvoidFirstLastClipping_ZHandler")]
		public virtual unsafe void SetAvoidFirstLastClipping (bool enabled)
		{
			const string __id = "setAvoidFirstLastClipping.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
