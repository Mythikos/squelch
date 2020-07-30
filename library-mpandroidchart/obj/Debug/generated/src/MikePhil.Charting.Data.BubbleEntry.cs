using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BubbleEntry']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/BubbleEntry", DoNotGenerateAcw=true)]
	public partial class BubbleEntry : global::MikePhil.Charting.Data.Entry {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/BubbleEntry", typeof (BubbleEntry));
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

		protected BubbleEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BubbleEntry']/constructor[@name='BubbleEntry' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register (".ctor", "(FFF)V", "")]
		public unsafe BubbleEntry (float x, float y, float size)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FFF)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue (size);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BubbleEntry']/constructor[@name='BubbleEntry' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='android.graphics.drawable.Drawable']]"
		[Register (".ctor", "(FFFLandroid/graphics/drawable/Drawable;)V", "")]
		public unsafe BubbleEntry (float x, float y, float size, global::Android.Graphics.Drawables.Drawable icon)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FFFLandroid/graphics/drawable/Drawable;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue (size);
				__args [3] = new JniArgumentValue ((icon == null) ? IntPtr.Zero : ((global::Java.Lang.Object) icon).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BubbleEntry']/constructor[@name='BubbleEntry' and count(parameter)=5 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='android.graphics.drawable.Drawable'] and parameter[5][@type='java.lang.Object']]"
		[Register (".ctor", "(FFFLandroid/graphics/drawable/Drawable;Ljava/lang/Object;)V", "")]
		public unsafe BubbleEntry (float x, float y, float size, global::Android.Graphics.Drawables.Drawable icon, global::Java.Lang.Object data)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FFFLandroid/graphics/drawable/Drawable;Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue (size);
				__args [3] = new JniArgumentValue ((icon == null) ? IntPtr.Zero : ((global::Java.Lang.Object) icon).Handle);
				__args [4] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BubbleEntry']/constructor[@name='BubbleEntry' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='java.lang.Object']]"
		[Register (".ctor", "(FFFLjava/lang/Object;)V", "")]
		public unsafe BubbleEntry (float x, float y, float size, global::Java.Lang.Object data)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FFFLjava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue (size);
				__args [3] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getSize;
#pragma warning disable 0169
		static Delegate GetGetSizeHandler ()
		{
			if (cb_getSize == null)
				cb_getSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetSize);
			return cb_getSize;
		}

		static float n_GetSize (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.BubbleEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BubbleEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size;
		}
#pragma warning restore 0169

		static Delegate cb_setSize_F;
#pragma warning disable 0169
		static Delegate GetSetSize_FHandler ()
		{
			if (cb_setSize_F == null)
				cb_setSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetSize_F);
			return cb_setSize_F;
		}

		static void n_SetSize_F (IntPtr jnienv, IntPtr native__this, float size)
		{
			global::MikePhil.Charting.Data.BubbleEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BubbleEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Size = size;
		}
#pragma warning restore 0169

		public virtual unsafe float Size {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BubbleEntry']/method[@name='getSize' and count(parameter)=0]"
			[Register ("getSize", "()F", "GetGetSizeHandler")]
			get {
				const string __id = "getSize.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BubbleEntry']/method[@name='setSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setSize", "(F)V", "GetSetSize_FHandler")]
			set {
				const string __id = "setSize.(F)V";
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
