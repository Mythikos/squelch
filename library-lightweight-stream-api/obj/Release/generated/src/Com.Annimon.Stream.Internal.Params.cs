using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.internal']/class[@name='Params']"
	[global::Android.Runtime.Register ("com/annimon/stream/internal/Params", DoNotGenerateAcw=true)]
	public sealed partial class Params : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.annimon.stream.internal']/class[@name='Params']/field[@name='closeHandler']"
		[Register ("closeHandler")]
		public global::Java.Lang.IRunnable CloseHandler {
			get {
				const string __id = "closeHandler.Ljava/lang/Runnable;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "closeHandler.Ljava/lang/Runnable;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/internal/Params", typeof (Params));
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

		internal Params (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.internal']/class[@name='Params']/constructor[@name='Params' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Params ()
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

	}
}
