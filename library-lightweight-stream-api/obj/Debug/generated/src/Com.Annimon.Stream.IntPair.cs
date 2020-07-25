using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntPair']"
	[global::Android.Runtime.Register ("com/annimon/stream/IntPair", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class IntPair : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/IntPair", typeof (IntPair));
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

		internal IntPair (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntPair']/constructor[@name='IntPair' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='T']]"
		[Register (".ctor", "(ILjava/lang/Object;)V", "")]
		public unsafe IntPair (int first, global::Java.Lang.Object second)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(ILjava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_second = JNIEnv.ToLocalJniHandle (second);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (first);
				__args [1] = new JniArgumentValue (native_second);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_second);
			}
		}

		public unsafe int First {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntPair']/method[@name='getFirst' and count(parameter)=0]"
			[Register ("getFirst", "()I", "")]
			get {
				const string __id = "getFirst.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::Java.Lang.Object Second {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntPair']/method[@name='getSecond' and count(parameter)=0]"
			[Register ("getSecond", "()Ljava/lang/Object;", "")]
			get {
				const string __id = "getSecond.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
