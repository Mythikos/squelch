using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IntConsumer.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/IntConsumer$Util", DoNotGenerateAcw=true)]
	public partial class IntConsumerUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IntConsumer$Util", typeof (IntConsumerUtil));
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

		protected IntConsumerUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IntConsumer.Util']/method[@name='andThen' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.IntConsumer'] and parameter[2][@type='com.annimon.stream.function.IntConsumer']]"
		[Register ("andThen", "(Lcom/annimon/stream/function/IntConsumer;Lcom/annimon/stream/function/IntConsumer;)Lcom/annimon/stream/function/IntConsumer;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IIntConsumer AndThen (global::Com.Annimon.Stream.Function.IIntConsumer c1, global::Com.Annimon.Stream.Function.IIntConsumer c2)
		{
			const string __id = "andThen.(Lcom/annimon/stream/function/IntConsumer;Lcom/annimon/stream/function/IntConsumer;)Lcom/annimon/stream/function/IntConsumer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((c1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c1).Handle);
				__args [1] = new JniArgumentValue ((c2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIntConsumer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IntConsumer.Util']/method[@name='safe' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ThrowableIntConsumer&lt;java.lang.Throwable&gt;']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableIntConsumer;)Lcom/annimon/stream/function/IntConsumer;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IIntConsumer Safe (global::Com.Annimon.Stream.Function.IThrowableIntConsumer throwableConsumer)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableIntConsumer;)Lcom/annimon/stream/function/IntConsumer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwableConsumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwableConsumer).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIntConsumer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IntConsumer.Util']/method[@name='safe' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.ThrowableIntConsumer&lt;java.lang.Throwable&gt;'] and parameter[2][@type='com.annimon.stream.function.IntConsumer']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableIntConsumer;Lcom/annimon/stream/function/IntConsumer;)Lcom/annimon/stream/function/IntConsumer;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IIntConsumer Safe (global::Com.Annimon.Stream.Function.IThrowableIntConsumer throwableConsumer, global::Com.Annimon.Stream.Function.IIntConsumer onFailedConsumer)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableIntConsumer;Lcom/annimon/stream/function/IntConsumer;)Lcom/annimon/stream/function/IntConsumer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwableConsumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwableConsumer).Handle);
				__args [1] = new JniArgumentValue ((onFailedConsumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onFailedConsumer).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIntConsumer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IntConsumer']"
	[Register ("com/annimon/stream/function/IntConsumer", "", "Com.Annimon.Stream.Function.IIntConsumerInvoker")]
	public partial interface IIntConsumer : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IntConsumer']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("accept", "(I)V", "GetAccept_IHandler:Com.Annimon.Stream.Function.IIntConsumerInvoker, library-lightweight-stream-api")]
		void Accept (int p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/IntConsumer", DoNotGenerateAcw=true)]
	internal partial class IIntConsumerInvoker : global::Java.Lang.Object, IIntConsumer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IntConsumer", typeof (IIntConsumerInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IIntConsumer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIntConsumer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.IntConsumer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIntConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_accept_I;
#pragma warning disable 0169
		static Delegate GetAccept_IHandler ()
		{
			if (cb_accept_I == null)
				cb_accept_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_Accept_I);
			return cb_accept_I;
		}

		static void n_Accept_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Annimon.Stream.Function.IIntConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIntConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Accept (p0);
		}
#pragma warning restore 0169

		IntPtr id_accept_I;
		public unsafe void Accept (int p0)
		{
			if (id_accept_I == IntPtr.Zero)
				id_accept_I = JNIEnv.GetMethodID (class_ref, "accept", "(I)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_I, __args);
		}

	}

}
