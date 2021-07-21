using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseEntry']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/BaseEntry", DoNotGenerateAcw=true)]
	public abstract partial class BaseEntry : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/data/BaseEntry", typeof (BaseEntry));
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

		protected BaseEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseEntry']/constructor[@name='BaseEntry' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BaseEntry ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseEntry']/constructor[@name='BaseEntry' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register (".ctor", "(F)V", "")]
		public unsafe BaseEntry (float y)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(F)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (y);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseEntry']/constructor[@name='BaseEntry' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register (".ctor", "(FLandroid/graphics/drawable/Drawable;)V", "")]
		public unsafe BaseEntry (float y, global::Android.Graphics.Drawables.Drawable icon)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FLandroid/graphics/drawable/Drawable;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (y);
				__args [1] = new JniArgumentValue ((icon == null) ? IntPtr.Zero : ((global::Java.Lang.Object) icon).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseEntry']/constructor[@name='BaseEntry' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='android.graphics.drawable.Drawable'] and parameter[3][@type='java.lang.Object']]"
		[Register (".ctor", "(FLandroid/graphics/drawable/Drawable;Ljava/lang/Object;)V", "")]
		public unsafe BaseEntry (float y, global::Android.Graphics.Drawables.Drawable icon, global::Java.Lang.Object data)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FLandroid/graphics/drawable/Drawable;Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (y);
				__args [1] = new JniArgumentValue ((icon == null) ? IntPtr.Zero : ((global::Java.Lang.Object) icon).Handle);
				__args [2] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseEntry']/constructor[@name='BaseEntry' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='java.lang.Object']]"
		[Register (".ctor", "(FLjava/lang/Object;)V", "")]
		public unsafe BaseEntry (float y, global::Java.Lang.Object data)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FLjava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (y);
				__args [1] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.BaseEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		static Delegate cb_setData_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSetData_Ljava_lang_Object_Handler ()
		{
			if (cb_setData_Ljava_lang_Object_ == null)
				cb_setData_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Ljava_lang_Object_);
			return cb_setData_Ljava_lang_Object_;
		}

		static void n_SetData_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::MikePhil.Charting.Data.BaseEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object data = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.Data = data;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseEntry']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Ljava/lang/Object;", "GetGetDataHandler")]
			get {
				const string __id = "getData.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseEntry']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
			[Register ("setData", "(Ljava/lang/Object;)V", "GetSetData_Ljava_lang_Object_Handler")]
			set {
				const string __id = "setData.(Ljava/lang/Object;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getIcon;
#pragma warning disable 0169
		static Delegate GetGetIconHandler ()
		{
			if (cb_getIcon == null)
				cb_getIcon = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIcon);
			return cb_getIcon;
		}

		static IntPtr n_GetIcon (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.BaseEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Icon);
		}
#pragma warning restore 0169

		static Delegate cb_setIcon_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetIcon_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setIcon_Landroid_graphics_drawable_Drawable_ == null)
				cb_setIcon_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIcon_Landroid_graphics_drawable_Drawable_);
			return cb_setIcon_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetIcon_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_icon)
		{
			global::MikePhil.Charting.Data.BaseEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable icon = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_icon, JniHandleOwnership.DoNotTransfer);
			__this.Icon = icon;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Drawables.Drawable Icon {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseEntry']/method[@name='getIcon' and count(parameter)=0]"
			[Register ("getIcon", "()Landroid/graphics/drawable/Drawable;", "GetGetIconHandler")]
			get {
				const string __id = "getIcon.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseEntry']/method[@name='setIcon' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setIcon", "(Landroid/graphics/drawable/Drawable;)V", "GetSetIcon_Landroid_graphics_drawable_Drawable_Handler")]
			set {
				const string __id = "setIcon.(Landroid/graphics/drawable/Drawable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getY;
#pragma warning disable 0169
		static Delegate GetGetYHandler ()
		{
			if (cb_getY == null)
				cb_getY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetY);
			return cb_getY;
		}

		static float n_GetY (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.BaseEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetY ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseEntry']/method[@name='getY' and count(parameter)=0]"
		[Register ("getY", "()F", "GetGetYHandler")]
		public virtual unsafe float GetY ()
		{
			const string __id = "getY.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setY_F;
#pragma warning disable 0169
		static Delegate GetSetY_FHandler ()
		{
			if (cb_setY_F == null)
				cb_setY_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetY_F);
			return cb_setY_F;
		}

		static void n_SetY_F (IntPtr jnienv, IntPtr native__this, float y)
		{
			global::MikePhil.Charting.Data.BaseEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BaseEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetY (y);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BaseEntry']/method[@name='setY' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setY", "(F)V", "GetSetY_FHandler")]
		public virtual unsafe void SetY (float y)
		{
			const string __id = "setY.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (y);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/BaseEntry", DoNotGenerateAcw=true)]
	internal partial class BaseEntryInvoker : BaseEntry {

		public BaseEntryInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/github/mikephil/charting/data/BaseEntry", typeof (BaseEntryInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
