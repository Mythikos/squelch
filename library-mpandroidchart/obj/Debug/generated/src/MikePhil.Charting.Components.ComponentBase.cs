using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Components {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='ComponentBase']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/components/ComponentBase", DoNotGenerateAcw=true)]
	public abstract partial class ComponentBase : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='ComponentBase']/field[@name='mEnabled']"
		[Register ("mEnabled")]
		protected bool MEnabled {
			get {
				const string __id = "mEnabled.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mEnabled.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='ComponentBase']/field[@name='mTextColor']"
		[Register ("mTextColor")]
		protected int MTextColor {
			get {
				const string __id = "mTextColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mTextColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='ComponentBase']/field[@name='mTextSize']"
		[Register ("mTextSize")]
		protected float MTextSize {
			get {
				const string __id = "mTextSize.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mTextSize.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='ComponentBase']/field[@name='mTypeface']"
		[Register ("mTypeface")]
		protected global::Android.Graphics.Typeface MTypeface {
			get {
				const string __id = "mTypeface.Landroid/graphics/Typeface;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mTypeface.Landroid/graphics/Typeface;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='ComponentBase']/field[@name='mXOffset']"
		[Register ("mXOffset")]
		protected float MXOffset {
			get {
				const string __id = "mXOffset.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mXOffset.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='ComponentBase']/field[@name='mYOffset']"
		[Register ("mYOffset")]
		protected float MYOffset {
			get {
				const string __id = "mYOffset.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mYOffset.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/components/ComponentBase", typeof (ComponentBase));

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

		protected ComponentBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='ComponentBase']/constructor[@name='ComponentBase' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ComponentBase () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		static Delegate cb_isEnabled;
#pragma warning disable 0169
		static Delegate GetIsEnabledHandler ()
		{
			if (cb_isEnabled == null)
				cb_isEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsEnabled);
			return cb_isEnabled;
		}

		static bool n_IsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.ComponentBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Enabled;
		}
#pragma warning restore 0169

		static Delegate cb_setEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetEnabled_ZHandler ()
		{
			if (cb_setEnabled_Z == null)
				cb_setEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetEnabled_Z);
			return cb_setEnabled_Z;
		}

		static void n_SetEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.ComponentBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enabled = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool Enabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='ComponentBase']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Z", "GetIsEnabledHandler")]
			get {
				const string __id = "isEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='ComponentBase']/method[@name='setEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setEnabled", "(Z)V", "GetSetEnabled_ZHandler")]
			set {
				const string __id = "setEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextColor;
#pragma warning disable 0169
		static Delegate GetGetTextColorHandler ()
		{
			if (cb_getTextColor == null)
				cb_getTextColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetTextColor);
			return cb_getTextColor;
		}

		static int n_GetTextColor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.ComponentBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextColor;
		}
#pragma warning restore 0169

		static Delegate cb_setTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetTextColor_IHandler ()
		{
			if (cb_setTextColor_I == null)
				cb_setTextColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetTextColor_I);
			return cb_setTextColor_I;
		}

		static void n_SetTextColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.ComponentBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextColor = color;
		}
#pragma warning restore 0169

		public virtual unsafe int TextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='ComponentBase']/method[@name='getTextColor' and count(parameter)=0]"
			[Register ("getTextColor", "()I", "GetGetTextColorHandler")]
			get {
				const string __id = "getTextColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='ComponentBase']/method[@name='setTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setTextColor", "(I)V", "GetSetTextColor_IHandler")]
			set {
				const string __id = "setTextColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTextSize;
#pragma warning disable 0169
		static Delegate GetGetTextSizeHandler ()
		{
			if (cb_getTextSize == null)
				cb_getTextSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetTextSize);
			return cb_getTextSize;
		}

		static float n_GetTextSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.ComponentBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TextSize;
		}
#pragma warning restore 0169

		static Delegate cb_setTextSize_F;
#pragma warning disable 0169
		static Delegate GetSetTextSize_FHandler ()
		{
			if (cb_setTextSize_F == null)
				cb_setTextSize_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetTextSize_F);
			return cb_setTextSize_F;
		}

		static void n_SetTextSize_F (IntPtr jnienv, IntPtr native__this, float size)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.ComponentBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TextSize = size;
		}
#pragma warning restore 0169

		public virtual unsafe float TextSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='ComponentBase']/method[@name='getTextSize' and count(parameter)=0]"
			[Register ("getTextSize", "()F", "GetGetTextSizeHandler")]
			get {
				const string __id = "getTextSize.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='ComponentBase']/method[@name='setTextSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setTextSize", "(F)V", "GetSetTextSize_FHandler")]
			set {
				const string __id = "setTextSize.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getTypeface;
#pragma warning disable 0169
		static Delegate GetGetTypefaceHandler ()
		{
			if (cb_getTypeface == null)
				cb_getTypeface = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetTypeface);
			return cb_getTypeface;
		}

		static IntPtr n_GetTypeface (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.ComponentBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Typeface);
		}
#pragma warning restore 0169

		static Delegate cb_setTypeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetSetTypeface_Landroid_graphics_Typeface_Handler ()
		{
			if (cb_setTypeface_Landroid_graphics_Typeface_ == null)
				cb_setTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetTypeface_Landroid_graphics_Typeface_);
			return cb_setTypeface_Landroid_graphics_Typeface_;
		}

		static void n_SetTypeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tf)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.ComponentBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tf = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_tf, JniHandleOwnership.DoNotTransfer);
			__this.Typeface = tf;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Typeface Typeface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='ComponentBase']/method[@name='getTypeface' and count(parameter)=0]"
			[Register ("getTypeface", "()Landroid/graphics/Typeface;", "GetGetTypefaceHandler")]
			get {
				const string __id = "getTypeface.()Landroid/graphics/Typeface;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='ComponentBase']/method[@name='setTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
			[Register ("setTypeface", "(Landroid/graphics/Typeface;)V", "GetSetTypeface_Landroid_graphics_Typeface_Handler")]
			set {
				const string __id = "setTypeface.(Landroid/graphics/Typeface;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					global::System.GC.KeepAlive (value);
				}
			}
		}

		static Delegate cb_getXOffset;
#pragma warning disable 0169
		static Delegate GetGetXOffsetHandler ()
		{
			if (cb_getXOffset == null)
				cb_getXOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetXOffset);
			return cb_getXOffset;
		}

		static float n_GetXOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.ComponentBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XOffset;
		}
#pragma warning restore 0169

		static Delegate cb_setXOffset_F;
#pragma warning disable 0169
		static Delegate GetSetXOffset_FHandler ()
		{
			if (cb_setXOffset_F == null)
				cb_setXOffset_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetXOffset_F);
			return cb_setXOffset_F;
		}

		static void n_SetXOffset_F (IntPtr jnienv, IntPtr native__this, float xOffset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.ComponentBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.XOffset = xOffset;
		}
#pragma warning restore 0169

		public virtual unsafe float XOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='ComponentBase']/method[@name='getXOffset' and count(parameter)=0]"
			[Register ("getXOffset", "()F", "GetGetXOffsetHandler")]
			get {
				const string __id = "getXOffset.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='ComponentBase']/method[@name='setXOffset' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setXOffset", "(F)V", "GetSetXOffset_FHandler")]
			set {
				const string __id = "setXOffset.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getYOffset;
#pragma warning disable 0169
		static Delegate GetGetYOffsetHandler ()
		{
			if (cb_getYOffset == null)
				cb_getYOffset = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetYOffset);
			return cb_getYOffset;
		}

		static float n_GetYOffset (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.ComponentBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YOffset;
		}
#pragma warning restore 0169

		static Delegate cb_setYOffset_F;
#pragma warning disable 0169
		static Delegate GetSetYOffset_FHandler ()
		{
			if (cb_setYOffset_F == null)
				cb_setYOffset_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetYOffset_F);
			return cb_setYOffset_F;
		}

		static void n_SetYOffset_F (IntPtr jnienv, IntPtr native__this, float yOffset)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.ComponentBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.YOffset = yOffset;
		}
#pragma warning restore 0169

		public virtual unsafe float YOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='ComponentBase']/method[@name='getYOffset' and count(parameter)=0]"
			[Register ("getYOffset", "()F", "GetGetYOffsetHandler")]
			get {
				const string __id = "getYOffset.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='ComponentBase']/method[@name='setYOffset' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setYOffset", "(F)V", "GetSetYOffset_FHandler")]
			set {
				const string __id = "setYOffset.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/components/ComponentBase", DoNotGenerateAcw=true)]
	internal partial class ComponentBaseInvoker : ComponentBase {
		public ComponentBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/components/ComponentBase", typeof (ComponentBaseInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}
}
