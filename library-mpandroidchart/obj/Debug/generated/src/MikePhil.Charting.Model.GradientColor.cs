using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Model {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.model']/class[@name='GradientColor']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/model/GradientColor", DoNotGenerateAcw=true)]
	public partial class GradientColor : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/model/GradientColor", typeof (GradientColor));
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

		protected GradientColor (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.model']/class[@name='GradientColor']/constructor[@name='GradientColor' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe GradientColor (int startColor, int endColor)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (startColor);
				__args [1] = new JniArgumentValue (endColor);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getEndColor;
#pragma warning disable 0169
		static Delegate GetGetEndColorHandler ()
		{
			if (cb_getEndColor == null)
				cb_getEndColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEndColor);
			return cb_getEndColor;
		}

		static int n_GetEndColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Model.GradientColor __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Model.GradientColor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EndColor;
		}
#pragma warning restore 0169

		static Delegate cb_setEndColor_I;
#pragma warning disable 0169
		static Delegate GetSetEndColor_IHandler ()
		{
			if (cb_setEndColor_I == null)
				cb_setEndColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetEndColor_I);
			return cb_setEndColor_I;
		}

		static void n_SetEndColor_I (IntPtr jnienv, IntPtr native__this, int endColor)
		{
			global::MikePhil.Charting.Model.GradientColor __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Model.GradientColor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EndColor = endColor;
		}
#pragma warning restore 0169

		public virtual unsafe int EndColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.model']/class[@name='GradientColor']/method[@name='getEndColor' and count(parameter)=0]"
			[Register ("getEndColor", "()I", "GetGetEndColorHandler")]
			get {
				const string __id = "getEndColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.model']/class[@name='GradientColor']/method[@name='setEndColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setEndColor", "(I)V", "GetSetEndColor_IHandler")]
			set {
				const string __id = "setEndColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStartColor;
#pragma warning disable 0169
		static Delegate GetGetStartColorHandler ()
		{
			if (cb_getStartColor == null)
				cb_getStartColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStartColor);
			return cb_getStartColor;
		}

		static int n_GetStartColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Model.GradientColor __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Model.GradientColor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StartColor;
		}
#pragma warning restore 0169

		static Delegate cb_setStartColor_I;
#pragma warning disable 0169
		static Delegate GetSetStartColor_IHandler ()
		{
			if (cb_setStartColor_I == null)
				cb_setStartColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetStartColor_I);
			return cb_setStartColor_I;
		}

		static void n_SetStartColor_I (IntPtr jnienv, IntPtr native__this, int startColor)
		{
			global::MikePhil.Charting.Model.GradientColor __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Model.GradientColor> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartColor = startColor;
		}
#pragma warning restore 0169

		public virtual unsafe int StartColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.model']/class[@name='GradientColor']/method[@name='getStartColor' and count(parameter)=0]"
			[Register ("getStartColor", "()I", "GetGetStartColorHandler")]
			get {
				const string __id = "getStartColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.model']/class[@name='GradientColor']/method[@name='setStartColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setStartColor", "(I)V", "GetSetStartColor_IHandler")]
			set {
				const string __id = "setStartColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

	}
}
