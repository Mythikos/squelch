using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Components {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Description']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/components/Description", DoNotGenerateAcw=true)]
	public partial class Description : global::MikePhil.Charting.Components.ComponentBase {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/components/Description", typeof (Description));
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

		protected Description (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Description']/constructor[@name='Description' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Description ()
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

		static Delegate cb_getPosition;
#pragma warning disable 0169
		static Delegate GetGetPositionHandler ()
		{
			if (cb_getPosition == null)
				cb_getPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPosition);
			return cb_getPosition;
		}

		static IntPtr n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Description __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Description> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Position);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Util.MPPointF Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Description']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lcom/github/mikephil/charting/utils/MPPointF;", "GetGetPositionHandler")]
			get {
				const string __id = "getPosition.()Lcom/github/mikephil/charting/utils/MPPointF;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getText;
#pragma warning disable 0169
		static Delegate GetGetTextHandler ()
		{
			if (cb_getText == null)
				cb_getText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetText);
			return cb_getText;
		}

		static IntPtr n_GetText (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Description __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Description> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Text);
		}
#pragma warning restore 0169

		static Delegate cb_setText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetText_Ljava_lang_String_Handler ()
		{
			if (cb_setText_Ljava_lang_String_ == null)
				cb_setText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetText_Ljava_lang_String_);
			return cb_setText_Ljava_lang_String_;
		}

		static void n_SetText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			global::MikePhil.Charting.Components.Description __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Description> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			__this.Text = text;
		}
#pragma warning restore 0169

		public virtual unsafe string Text {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Description']/method[@name='getText' and count(parameter)=0]"
			[Register ("getText", "()Ljava/lang/String;", "GetGetTextHandler")]
			get {
				const string __id = "getText.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Description']/method[@name='setText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setText", "(Ljava/lang/String;)V", "GetSetText_Ljava_lang_String_Handler")]
			set {
				const string __id = "setText.(Ljava/lang/String;)V";
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

		static Delegate cb_getTextAlign;
#pragma warning disable 0169
		static Delegate GetGetTextAlignHandler ()
		{
			if (cb_getTextAlign == null)
				cb_getTextAlign = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTextAlign);
			return cb_getTextAlign;
		}

		static IntPtr n_GetTextAlign (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Description __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Description> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.TextAlign);
		}
#pragma warning restore 0169

		static Delegate cb_setTextAlign_Landroid_graphics_Paint_Align_;
#pragma warning disable 0169
		static Delegate GetSetTextAlign_Landroid_graphics_Paint_Align_Handler ()
		{
			if (cb_setTextAlign_Landroid_graphics_Paint_Align_ == null)
				cb_setTextAlign_Landroid_graphics_Paint_Align_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetTextAlign_Landroid_graphics_Paint_Align_);
			return cb_setTextAlign_Landroid_graphics_Paint_Align_;
		}

		static void n_SetTextAlign_Landroid_graphics_Paint_Align_ (IntPtr jnienv, IntPtr native__this, IntPtr native_align)
		{
			global::MikePhil.Charting.Components.Description __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Description> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint.Align align = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Align> (native_align, JniHandleOwnership.DoNotTransfer);
			__this.TextAlign = align;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Paint.Align TextAlign {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Description']/method[@name='getTextAlign' and count(parameter)=0]"
			[Register ("getTextAlign", "()Landroid/graphics/Paint$Align;", "GetGetTextAlignHandler")]
			get {
				const string __id = "getTextAlign.()Landroid/graphics/Paint$Align;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint.Align> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Description']/method[@name='setTextAlign' and count(parameter)=1 and parameter[1][@type='android.graphics.Paint.Align']]"
			[Register ("setTextAlign", "(Landroid/graphics/Paint$Align;)V", "GetSetTextAlign_Landroid_graphics_Paint_Align_Handler")]
			set {
				const string __id = "setTextAlign.(Landroid/graphics/Paint$Align;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_setPosition_FF;
#pragma warning disable 0169
		static Delegate GetSetPosition_FFHandler ()
		{
			if (cb_setPosition_FF == null)
				cb_setPosition_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_SetPosition_FF);
			return cb_setPosition_FF;
		}

		static void n_SetPosition_FF (IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			global::MikePhil.Charting.Components.Description __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Description> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPosition (x, y);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Description']/method[@name='setPosition' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setPosition", "(FF)V", "GetSetPosition_FFHandler")]
		public virtual unsafe void SetPosition (float x, float y)
		{
			const string __id = "setPosition.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
