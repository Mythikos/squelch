using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.internal']/class[@name='Compose']"
	[global::Android.Runtime.Register ("com/annimon/stream/internal/Compose", DoNotGenerateAcw=true)]
	public sealed partial class Compose : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/internal/Compose", typeof (Compose));
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

		internal Compose (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.internal']/class[@name='Compose']/method[@name='closeables' and count(parameter)=2 and parameter[1][@type='java.io.Closeable'] and parameter[2][@type='java.io.Closeable']]"
		[Register ("closeables", "(Ljava/io/Closeable;Ljava/io/Closeable;)Ljava/lang/Runnable;", "")]
		public static unsafe global::Java.Lang.IRunnable Closeables (global::Java.IO.ICloseable a, global::Java.IO.ICloseable b)
		{
			const string __id = "closeables.(Ljava/io/Closeable;Ljava/io/Closeable;)Ljava/lang/Runnable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [1] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.internal']/class[@name='Compose']/method[@name='runnables' and count(parameter)=2 and parameter[1][@type='java.lang.Runnable'] and parameter[2][@type='java.lang.Runnable']]"
		[Register ("runnables", "(Ljava/lang/Runnable;Ljava/lang/Runnable;)Ljava/lang/Runnable;", "")]
		public static unsafe global::Java.Lang.IRunnable Runnables (global::Java.Lang.IRunnable a, global::Java.Lang.IRunnable b)
		{
			const string __id = "runnables.(Ljava/lang/Runnable;Ljava/lang/Runnable;)Ljava/lang/Runnable;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [1] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
