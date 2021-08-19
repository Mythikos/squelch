using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Components {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/components/YAxis", DoNotGenerateAcw=true)]
	public partial class YAxis : global::MikePhil.Charting.Components.AxisBase {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/field[@name='mDrawZeroLine']"
		[Register ("mDrawZeroLine")]
		protected bool MDrawZeroLine {
			get {
				const string __id = "mDrawZeroLine.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mDrawZeroLine.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/field[@name='mInverted']"
		[Register ("mInverted")]
		protected bool MInverted {
			get {
				const string __id = "mInverted.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mInverted.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/field[@name='mMaxWidth']"
		[Register ("mMaxWidth")]
		protected float MMaxWidth {
			get {
				const string __id = "mMaxWidth.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mMaxWidth.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/field[@name='mMinWidth']"
		[Register ("mMinWidth")]
		protected float MMinWidth {
			get {
				const string __id = "mMinWidth.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mMinWidth.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/field[@name='mSpacePercentBottom']"
		[Register ("mSpacePercentBottom")]
		protected float MSpacePercentBottom {
			get {
				const string __id = "mSpacePercentBottom.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mSpacePercentBottom.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/field[@name='mSpacePercentTop']"
		[Register ("mSpacePercentTop")]
		protected float MSpacePercentTop {
			get {
				const string __id = "mSpacePercentTop.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mSpacePercentTop.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/field[@name='mZeroLineColor']"
		[Register ("mZeroLineColor")]
		protected int MZeroLineColor {
			get {
				const string __id = "mZeroLineColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mZeroLineColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/field[@name='mZeroLineWidth']"
		[Register ("mZeroLineWidth")]
		protected float MZeroLineWidth {
			get {
				const string __id = "mZeroLineWidth.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mZeroLineWidth.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis.AxisDependency']"
		[global::Android.Runtime.Register ("com/github/mikephil/charting/components/YAxis$AxisDependency", DoNotGenerateAcw=true)]
		public sealed partial class AxisDependency : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis.AxisDependency']/field[@name='LEFT']"
			[Register ("LEFT")]
			public static global::MikePhil.Charting.Components.YAxis.AxisDependency Left {
				get {
					const string __id = "LEFT.Lcom/github/mikephil/charting/components/YAxis$AxisDependency;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis.AxisDependency']/field[@name='RIGHT']"
			[Register ("RIGHT")]
			public static global::MikePhil.Charting.Components.YAxis.AxisDependency Right {
				get {
					const string __id = "RIGHT.Lcom/github/mikephil/charting/components/YAxis$AxisDependency;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/components/YAxis$AxisDependency", typeof (AxisDependency));

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

			internal AxisDependency (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis.AxisDependency']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/github/mikephil/charting/components/YAxis$AxisDependency;", "")]
			public static unsafe global::MikePhil.Charting.Components.YAxis.AxisDependency ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/github/mikephil/charting/components/YAxis$AxisDependency;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis.AxisDependency']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/github/mikephil/charting/components/YAxis$AxisDependency;", "")]
			public static unsafe global::MikePhil.Charting.Components.YAxis.AxisDependency[] Values ()
			{
				const string __id = "values.()[Lcom/github/mikephil/charting/components/YAxis$AxisDependency;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::MikePhil.Charting.Components.YAxis.AxisDependency[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::MikePhil.Charting.Components.YAxis.AxisDependency));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis.YAxisLabelPosition']"
		[global::Android.Runtime.Register ("com/github/mikephil/charting/components/YAxis$YAxisLabelPosition", DoNotGenerateAcw=true)]
		public sealed partial class YAxisLabelPosition : global::Java.Lang.Enum {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis.YAxisLabelPosition']/field[@name='INSIDE_CHART']"
			[Register ("INSIDE_CHART")]
			public static global::MikePhil.Charting.Components.YAxis.YAxisLabelPosition InsideChart {
				get {
					const string __id = "INSIDE_CHART.Lcom/github/mikephil/charting/components/YAxis$YAxisLabelPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.YAxisLabelPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis.YAxisLabelPosition']/field[@name='OUTSIDE_CHART']"
			[Register ("OUTSIDE_CHART")]
			public static global::MikePhil.Charting.Components.YAxis.YAxisLabelPosition OutsideChart {
				get {
					const string __id = "OUTSIDE_CHART.Lcom/github/mikephil/charting/components/YAxis$YAxisLabelPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.YAxisLabelPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/components/YAxis$YAxisLabelPosition", typeof (YAxisLabelPosition));

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

			internal YAxisLabelPosition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis.YAxisLabelPosition']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/github/mikephil/charting/components/YAxis$YAxisLabelPosition;", "")]
			public static unsafe global::MikePhil.Charting.Components.YAxis.YAxisLabelPosition ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/github/mikephil/charting/components/YAxis$YAxisLabelPosition;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.YAxisLabelPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis.YAxisLabelPosition']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/github/mikephil/charting/components/YAxis$YAxisLabelPosition;", "")]
			public static unsafe global::MikePhil.Charting.Components.YAxis.YAxisLabelPosition[] Values ()
			{
				const string __id = "values.()[Lcom/github/mikephil/charting/components/YAxis$YAxisLabelPosition;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::MikePhil.Charting.Components.YAxis.YAxisLabelPosition[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::MikePhil.Charting.Components.YAxis.YAxisLabelPosition));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/components/YAxis", typeof (YAxis));

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

		protected YAxis (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/constructor[@name='YAxis' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe YAxis () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/constructor[@name='YAxis' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.YAxis.AxisDependency']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)V", "")]
		public unsafe YAxis (global::MikePhil.Charting.Components.YAxis.AxisDependency position) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((position == null) ? IntPtr.Zero : ((global::Java.Lang.Object) position).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (position);
			}
		}

		static Delegate cb_isInverted;
#pragma warning disable 0169
		static Delegate GetIsInvertedHandler ()
		{
			if (cb_isInverted == null)
				cb_isInverted = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsInverted);
			return cb_isInverted;
		}

		static bool n_IsInverted (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Inverted;
		}
#pragma warning restore 0169

		static Delegate cb_setInverted_Z;
#pragma warning disable 0169
		static Delegate GetSetInverted_ZHandler ()
		{
			if (cb_setInverted_Z == null)
				cb_setInverted_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetInverted_Z);
			return cb_setInverted_Z;
		}

		static void n_SetInverted_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Inverted = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool Inverted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='isInverted' and count(parameter)=0]"
			[Register ("isInverted", "()Z", "GetIsInvertedHandler")]
			get {
				const string __id = "isInverted.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='setInverted' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setInverted", "(Z)V", "GetSetInverted_ZHandler")]
			set {
				const string __id = "setInverted.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDrawBottomYLabelEntryEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawBottomYLabelEntryEnabledHandler ()
		{
			if (cb_isDrawBottomYLabelEntryEnabled == null)
				cb_isDrawBottomYLabelEntryEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDrawBottomYLabelEntryEnabled);
			return cb_isDrawBottomYLabelEntryEnabled;
		}

		static bool n_IsDrawBottomYLabelEntryEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawBottomYLabelEntryEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrawBottomYLabelEntryEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='isDrawBottomYLabelEntryEnabled' and count(parameter)=0]"
			[Register ("isDrawBottomYLabelEntryEnabled", "()Z", "GetIsDrawBottomYLabelEntryEnabledHandler")]
			get {
				const string __id = "isDrawBottomYLabelEntryEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDrawTopYLabelEntryEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawTopYLabelEntryEnabledHandler ()
		{
			if (cb_isDrawTopYLabelEntryEnabled == null)
				cb_isDrawTopYLabelEntryEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDrawTopYLabelEntryEnabled);
			return cb_isDrawTopYLabelEntryEnabled;
		}

		static bool n_IsDrawTopYLabelEntryEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawTopYLabelEntryEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrawTopYLabelEntryEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='isDrawTopYLabelEntryEnabled' and count(parameter)=0]"
			[Register ("isDrawTopYLabelEntryEnabled", "()Z", "GetIsDrawTopYLabelEntryEnabledHandler")]
			get {
				const string __id = "isDrawTopYLabelEntryEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDrawZeroLineEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawZeroLineEnabledHandler ()
		{
			if (cb_isDrawZeroLineEnabled == null)
				cb_isDrawZeroLineEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsDrawZeroLineEnabled);
			return cb_isDrawZeroLineEnabled;
		}

		static bool n_IsDrawZeroLineEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawZeroLineEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrawZeroLineEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='isDrawZeroLineEnabled' and count(parameter)=0]"
			[Register ("isDrawZeroLineEnabled", "()Z", "GetIsDrawZeroLineEnabledHandler")]
			get {
				const string __id = "isDrawZeroLineEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
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
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LabelPosition);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Components.YAxis.YAxisLabelPosition LabelPosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='getLabelPosition' and count(parameter)=0]"
			[Register ("getLabelPosition", "()Lcom/github/mikephil/charting/components/YAxis$YAxisLabelPosition;", "GetGetLabelPositionHandler")]
			get {
				const string __id = "getLabelPosition.()Lcom/github/mikephil/charting/components/YAxis$YAxisLabelPosition;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.YAxisLabelPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxWidth;
#pragma warning disable 0169
		static Delegate GetGetMaxWidthHandler ()
		{
			if (cb_getMaxWidth == null)
				cb_getMaxWidth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetMaxWidth);
			return cb_getMaxWidth;
		}

		static float n_GetMaxWidth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxWidth_F;
#pragma warning disable 0169
		static Delegate GetSetMaxWidth_FHandler ()
		{
			if (cb_setMaxWidth_F == null)
				cb_setMaxWidth_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetMaxWidth_F);
			return cb_setMaxWidth_F;
		}

		static void n_SetMaxWidth_F (IntPtr jnienv, IntPtr native__this, float maxWidth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxWidth = maxWidth;
		}
#pragma warning restore 0169

		public virtual unsafe float MaxWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='getMaxWidth' and count(parameter)=0]"
			[Register ("getMaxWidth", "()F", "GetGetMaxWidthHandler")]
			get {
				const string __id = "getMaxWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='setMaxWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMaxWidth", "(F)V", "GetSetMaxWidth_FHandler")]
			set {
				const string __id = "setMaxWidth.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMinWidth;
#pragma warning disable 0169
		static Delegate GetGetMinWidthHandler ()
		{
			if (cb_getMinWidth == null)
				cb_getMinWidth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetMinWidth);
			return cb_getMinWidth;
		}

		static float n_GetMinWidth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setMinWidth_F;
#pragma warning disable 0169
		static Delegate GetSetMinWidth_FHandler ()
		{
			if (cb_setMinWidth_F == null)
				cb_setMinWidth_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetMinWidth_F);
			return cb_setMinWidth_F;
		}

		static void n_SetMinWidth_F (IntPtr jnienv, IntPtr native__this, float minWidth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinWidth = minWidth;
		}
#pragma warning restore 0169

		public virtual unsafe float MinWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='getMinWidth' and count(parameter)=0]"
			[Register ("getMinWidth", "()F", "GetGetMinWidthHandler")]
			get {
				const string __id = "getMinWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='setMinWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMinWidth", "(F)V", "GetSetMinWidth_FHandler")]
			set {
				const string __id = "setMinWidth.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSpaceBottom;
#pragma warning disable 0169
		static Delegate GetGetSpaceBottomHandler ()
		{
			if (cb_getSpaceBottom == null)
				cb_getSpaceBottom = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetSpaceBottom);
			return cb_getSpaceBottom;
		}

		static float n_GetSpaceBottom (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SpaceBottom;
		}
#pragma warning restore 0169

		static Delegate cb_setSpaceBottom_F;
#pragma warning disable 0169
		static Delegate GetSetSpaceBottom_FHandler ()
		{
			if (cb_setSpaceBottom_F == null)
				cb_setSpaceBottom_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetSpaceBottom_F);
			return cb_setSpaceBottom_F;
		}

		static void n_SetSpaceBottom_F (IntPtr jnienv, IntPtr native__this, float percent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SpaceBottom = percent;
		}
#pragma warning restore 0169

		public virtual unsafe float SpaceBottom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='getSpaceBottom' and count(parameter)=0]"
			[Register ("getSpaceBottom", "()F", "GetGetSpaceBottomHandler")]
			get {
				const string __id = "getSpaceBottom.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='setSpaceBottom' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setSpaceBottom", "(F)V", "GetSetSpaceBottom_FHandler")]
			set {
				const string __id = "setSpaceBottom.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSpaceTop;
#pragma warning disable 0169
		static Delegate GetGetSpaceTopHandler ()
		{
			if (cb_getSpaceTop == null)
				cb_getSpaceTop = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetSpaceTop);
			return cb_getSpaceTop;
		}

		static float n_GetSpaceTop (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SpaceTop;
		}
#pragma warning restore 0169

		static Delegate cb_setSpaceTop_F;
#pragma warning disable 0169
		static Delegate GetSetSpaceTop_FHandler ()
		{
			if (cb_setSpaceTop_F == null)
				cb_setSpaceTop_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetSpaceTop_F);
			return cb_setSpaceTop_F;
		}

		static void n_SetSpaceTop_F (IntPtr jnienv, IntPtr native__this, float percent)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SpaceTop = percent;
		}
#pragma warning restore 0169

		public virtual unsafe float SpaceTop {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='getSpaceTop' and count(parameter)=0]"
			[Register ("getSpaceTop", "()F", "GetGetSpaceTopHandler")]
			get {
				const string __id = "getSpaceTop.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='setSpaceTop' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setSpaceTop", "(F)V", "GetSetSpaceTop_FHandler")]
			set {
				const string __id = "setSpaceTop.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isUseAutoScaleMaxRestriction;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetIsUseAutoScaleMaxRestrictionHandler ()
		{
			if (cb_isUseAutoScaleMaxRestriction == null)
				cb_isUseAutoScaleMaxRestriction = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUseAutoScaleMaxRestriction);
			return cb_isUseAutoScaleMaxRestriction;
		}

		[Obsolete]
		static bool n_IsUseAutoScaleMaxRestriction (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseAutoScaleMaxRestriction;
		}
#pragma warning restore 0169

		static Delegate cb_setUseAutoScaleMaxRestriction_Z;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetUseAutoScaleMaxRestriction_ZHandler ()
		{
			if (cb_setUseAutoScaleMaxRestriction_Z == null)
				cb_setUseAutoScaleMaxRestriction_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetUseAutoScaleMaxRestriction_Z);
			return cb_setUseAutoScaleMaxRestriction_Z;
		}

		[Obsolete]
		static void n_SetUseAutoScaleMaxRestriction_Z (IntPtr jnienv, IntPtr native__this, bool isEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseAutoScaleMaxRestriction = isEnabled;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe bool UseAutoScaleMaxRestriction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='isUseAutoScaleMaxRestriction' and count(parameter)=0]"
			[Register ("isUseAutoScaleMaxRestriction", "()Z", "GetIsUseAutoScaleMaxRestrictionHandler")]
			get {
				const string __id = "isUseAutoScaleMaxRestriction.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='setUseAutoScaleMaxRestriction' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseAutoScaleMaxRestriction", "(Z)V", "GetSetUseAutoScaleMaxRestriction_ZHandler")]
			set {
				const string __id = "setUseAutoScaleMaxRestriction.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isUseAutoScaleMinRestriction;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetIsUseAutoScaleMinRestrictionHandler ()
		{
			if (cb_isUseAutoScaleMinRestriction == null)
				cb_isUseAutoScaleMinRestriction = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsUseAutoScaleMinRestriction);
			return cb_isUseAutoScaleMinRestriction;
		}

		[Obsolete]
		static bool n_IsUseAutoScaleMinRestriction (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.UseAutoScaleMinRestriction;
		}
#pragma warning restore 0169

		static Delegate cb_setUseAutoScaleMinRestriction_Z;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetUseAutoScaleMinRestriction_ZHandler ()
		{
			if (cb_setUseAutoScaleMinRestriction_Z == null)
				cb_setUseAutoScaleMinRestriction_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetUseAutoScaleMinRestriction_Z);
			return cb_setUseAutoScaleMinRestriction_Z;
		}

		[Obsolete]
		static void n_SetUseAutoScaleMinRestriction_Z (IntPtr jnienv, IntPtr native__this, bool isEnabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.UseAutoScaleMinRestriction = isEnabled;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe bool UseAutoScaleMinRestriction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='isUseAutoScaleMinRestriction' and count(parameter)=0]"
			[Register ("isUseAutoScaleMinRestriction", "()Z", "GetIsUseAutoScaleMinRestrictionHandler")]
			get {
				const string __id = "isUseAutoScaleMinRestriction.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='setUseAutoScaleMinRestriction' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setUseAutoScaleMinRestriction", "(Z)V", "GetSetUseAutoScaleMinRestriction_ZHandler")]
			set {
				const string __id = "setUseAutoScaleMinRestriction.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getZeroLineColor;
#pragma warning disable 0169
		static Delegate GetGetZeroLineColorHandler ()
		{
			if (cb_getZeroLineColor == null)
				cb_getZeroLineColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetZeroLineColor);
			return cb_getZeroLineColor;
		}

		static int n_GetZeroLineColor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZeroLineColor;
		}
#pragma warning restore 0169

		static Delegate cb_setZeroLineColor_I;
#pragma warning disable 0169
		static Delegate GetSetZeroLineColor_IHandler ()
		{
			if (cb_setZeroLineColor_I == null)
				cb_setZeroLineColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetZeroLineColor_I);
			return cb_setZeroLineColor_I;
		}

		static void n_SetZeroLineColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZeroLineColor = color;
		}
#pragma warning restore 0169

		public virtual unsafe int ZeroLineColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='getZeroLineColor' and count(parameter)=0]"
			[Register ("getZeroLineColor", "()I", "GetGetZeroLineColorHandler")]
			get {
				const string __id = "getZeroLineColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='setZeroLineColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setZeroLineColor", "(I)V", "GetSetZeroLineColor_IHandler")]
			set {
				const string __id = "setZeroLineColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getZeroLineWidth;
#pragma warning disable 0169
		static Delegate GetGetZeroLineWidthHandler ()
		{
			if (cb_getZeroLineWidth == null)
				cb_getZeroLineWidth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetZeroLineWidth);
			return cb_getZeroLineWidth;
		}

		static float n_GetZeroLineWidth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ZeroLineWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setZeroLineWidth_F;
#pragma warning disable 0169
		static Delegate GetSetZeroLineWidth_FHandler ()
		{
			if (cb_setZeroLineWidth_F == null)
				cb_setZeroLineWidth_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetZeroLineWidth_F);
			return cb_setZeroLineWidth_F;
		}

		static void n_SetZeroLineWidth_F (IntPtr jnienv, IntPtr native__this, float width)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZeroLineWidth = width;
		}
#pragma warning restore 0169

		public virtual unsafe float ZeroLineWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='getZeroLineWidth' and count(parameter)=0]"
			[Register ("getZeroLineWidth", "()F", "GetGetZeroLineWidthHandler")]
			get {
				const string __id = "getZeroLineWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='setZeroLineWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setZeroLineWidth", "(F)V", "GetSetZeroLineWidth_FHandler")]
			set {
				const string __id = "setZeroLineWidth.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAxisDependency;
#pragma warning disable 0169
		static Delegate GetGetAxisDependencyHandler ()
		{
			if (cb_getAxisDependency == null)
				cb_getAxisDependency = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetAxisDependency);
			return cb_getAxisDependency;
		}

		static IntPtr n_GetAxisDependency (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetAxisDependency ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='getAxisDependency' and count(parameter)=0]"
		[Register ("getAxisDependency", "()Lcom/github/mikephil/charting/components/YAxis$AxisDependency;", "GetGetAxisDependencyHandler")]
		public virtual unsafe global::MikePhil.Charting.Components.YAxis.AxisDependency GetAxisDependency ()
		{
			const string __id = "getAxisDependency.()Lcom/github/mikephil/charting/components/YAxis$AxisDependency;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getRequiredHeightSpace_Landroid_graphics_Paint_;
#pragma warning disable 0169
		static Delegate GetGetRequiredHeightSpace_Landroid_graphics_Paint_Handler ()
		{
			if (cb_getRequiredHeightSpace_Landroid_graphics_Paint_ == null)
				cb_getRequiredHeightSpace_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_F) n_GetRequiredHeightSpace_Landroid_graphics_Paint_);
			return cb_getRequiredHeightSpace_Landroid_graphics_Paint_;
		}

		static float n_GetRequiredHeightSpace_Landroid_graphics_Paint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetRequiredHeightSpace (p);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='getRequiredHeightSpace' and count(parameter)=1 and parameter[1][@type='android.graphics.Paint']]"
		[Register ("getRequiredHeightSpace", "(Landroid/graphics/Paint;)F", "GetGetRequiredHeightSpace_Landroid_graphics_Paint_Handler")]
		public virtual unsafe float GetRequiredHeightSpace (global::Android.Graphics.Paint p)
		{
			const string __id = "getRequiredHeightSpace.(Landroid/graphics/Paint;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p);
			}
		}

		static Delegate cb_getRequiredWidthSpace_Landroid_graphics_Paint_;
#pragma warning disable 0169
		static Delegate GetGetRequiredWidthSpace_Landroid_graphics_Paint_Handler ()
		{
			if (cb_getRequiredWidthSpace_Landroid_graphics_Paint_ == null)
				cb_getRequiredWidthSpace_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_F) n_GetRequiredWidthSpace_Landroid_graphics_Paint_);
			return cb_getRequiredWidthSpace_Landroid_graphics_Paint_;
		}

		static float n_GetRequiredWidthSpace_Landroid_graphics_Paint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetRequiredWidthSpace (p);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='getRequiredWidthSpace' and count(parameter)=1 and parameter[1][@type='android.graphics.Paint']]"
		[Register ("getRequiredWidthSpace", "(Landroid/graphics/Paint;)F", "GetGetRequiredWidthSpace_Landroid_graphics_Paint_Handler")]
		public virtual unsafe float GetRequiredWidthSpace (global::Android.Graphics.Paint p)
		{
			const string __id = "getRequiredWidthSpace.(Landroid/graphics/Paint;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (p);
			}
		}

		static Delegate cb_needsOffset;
#pragma warning disable 0169
		static Delegate GetNeedsOffsetHandler ()
		{
			if (cb_needsOffset == null)
				cb_needsOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_NeedsOffset);
			return cb_needsOffset;
		}

		static bool n_NeedsOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeedsOffset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='needsOffset' and count(parameter)=0]"
		[Register ("needsOffset", "()Z", "GetNeedsOffsetHandler")]
		public virtual unsafe bool NeedsOffset ()
		{
			const string __id = "needsOffset.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setDrawTopYLabelEntry_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawTopYLabelEntry_ZHandler ()
		{
			if (cb_setDrawTopYLabelEntry_Z == null)
				cb_setDrawTopYLabelEntry_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetDrawTopYLabelEntry_Z);
			return cb_setDrawTopYLabelEntry_Z;
		}

		static void n_SetDrawTopYLabelEntry_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawTopYLabelEntry (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='setDrawTopYLabelEntry' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawTopYLabelEntry", "(Z)V", "GetSetDrawTopYLabelEntry_ZHandler")]
		public virtual unsafe void SetDrawTopYLabelEntry (bool enabled)
		{
			const string __id = "setDrawTopYLabelEntry.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawZeroLine_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawZeroLine_ZHandler ()
		{
			if (cb_setDrawZeroLine_Z == null)
				cb_setDrawZeroLine_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetDrawZeroLine_Z);
			return cb_setDrawZeroLine_Z;
		}

		static void n_SetDrawZeroLine_Z (IntPtr jnienv, IntPtr native__this, bool mDrawZeroLine)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawZeroLine (mDrawZeroLine);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='setDrawZeroLine' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawZeroLine", "(Z)V", "GetSetDrawZeroLine_ZHandler")]
		public virtual unsafe void SetDrawZeroLine (bool mDrawZeroLine)
		{
			const string __id = "setDrawZeroLine.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mDrawZeroLine);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPosition_Lcom_github_mikephil_charting_components_YAxis_YAxisLabelPosition_;
#pragma warning disable 0169
		static Delegate GetSetPosition_Lcom_github_mikephil_charting_components_YAxis_YAxisLabelPosition_Handler ()
		{
			if (cb_setPosition_Lcom_github_mikephil_charting_components_YAxis_YAxisLabelPosition_ == null)
				cb_setPosition_Lcom_github_mikephil_charting_components_YAxis_YAxisLabelPosition_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetPosition_Lcom_github_mikephil_charting_components_YAxis_YAxisLabelPosition_);
			return cb_setPosition_Lcom_github_mikephil_charting_components_YAxis_YAxisLabelPosition_;
		}

		static void n_SetPosition_Lcom_github_mikephil_charting_components_YAxis_YAxisLabelPosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pos)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var pos = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.YAxisLabelPosition> (native_pos, JniHandleOwnership.DoNotTransfer);
			__this.SetPosition (pos);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.YAxis.YAxisLabelPosition']]"
		[Register ("setPosition", "(Lcom/github/mikephil/charting/components/YAxis$YAxisLabelPosition;)V", "GetSetPosition_Lcom_github_mikephil_charting_components_YAxis_YAxisLabelPosition_Handler")]
		public virtual unsafe void SetPosition (global::MikePhil.Charting.Components.YAxis.YAxisLabelPosition pos)
		{
			const string __id = "setPosition.(Lcom/github/mikephil/charting/components/YAxis$YAxisLabelPosition;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pos == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pos).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (pos);
			}
		}

		static Delegate cb_setStartAtZero_Z;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetStartAtZero_ZHandler ()
		{
			if (cb_setStartAtZero_Z == null)
				cb_setStartAtZero_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetStartAtZero_Z);
			return cb_setStartAtZero_Z;
		}

		[Obsolete]
		static void n_SetStartAtZero_Z (IntPtr jnienv, IntPtr native__this, bool startAtZero)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetStartAtZero (startAtZero);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='YAxis']/method[@name='setStartAtZero' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("setStartAtZero", "(Z)V", "GetSetStartAtZero_ZHandler")]
		public virtual unsafe void SetStartAtZero (bool startAtZero)
		{
			const string __id = "setStartAtZero.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (startAtZero);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
