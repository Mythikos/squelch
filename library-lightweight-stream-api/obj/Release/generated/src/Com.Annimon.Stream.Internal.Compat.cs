using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.internal']/class[@name='Compat']"
	[global::Android.Runtime.Register ("com/annimon/stream/internal/Compat", DoNotGenerateAcw=true)]
	public sealed partial class Compat : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/internal/Compat", typeof (Compat));
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

		internal Compat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.internal']/class[@name='Compat']/constructor[@name='Compat' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Compat ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.internal']/class[@name='Compat']/method[@name='newArray' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='E...']]"
		[Register ("newArray", "(I[Ljava/lang/Object;)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E"})]
		public static unsafe global::Java.Lang.Object[] NewArray (int length, params global::Java.Lang.Object[] array)
		{
			const string __id = "newArray.(I[Ljava/lang/Object;)[Ljava/lang/Object;";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (length);
				__args [1] = new JniArgumentValue (native_array);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.internal']/class[@name='Compat']/method[@name='newArrayCompat' and count(parameter)=2 and parameter[1][@type='E[]'] and parameter[2][@type='int']]"
		[Register ("newArrayCompat", "([Ljava/lang/Object;I)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E"})]
		public static unsafe global::Java.Lang.Object[] NewArrayCompat (global::Java.Lang.Object[] array, int length)
		{
			const string __id = "newArrayCompat.([Ljava/lang/Object;I)[Ljava/lang/Object;";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_array);
				__args [1] = new JniArgumentValue (length);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.internal']/class[@name='Compat']/method[@name='queue' and count(parameter)=0]"
		[Register ("queue", "()Ljava/util/Queue;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Util.IQueue Queue ()
		{
			const string __id = "queue.()Ljava/util/Queue;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IQueue> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
