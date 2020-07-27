using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Applandeo.Materialcalendarview.Exceptions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview.exceptions']/class[@name='UnsupportedMethodsException']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/exceptions/UnsupportedMethodsException", DoNotGenerateAcw=true)]
	public partial class UnsupportedMethodsException : global::Java.Lang.RuntimeException {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/applandeo/materialcalendarview/exceptions/UnsupportedMethodsException", typeof (UnsupportedMethodsException));
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

		protected UnsupportedMethodsException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview.exceptions']/class[@name='UnsupportedMethodsException']/constructor[@name='UnsupportedMethodsException' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe UnsupportedMethodsException (string message)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

	}
}
