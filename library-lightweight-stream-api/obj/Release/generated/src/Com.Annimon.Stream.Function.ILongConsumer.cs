using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='LongConsumer.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/LongConsumer$Util", DoNotGenerateAcw=true)]
	public partial class LongConsumerUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/LongConsumer$Util", typeof (LongConsumerUtil));
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

		protected LongConsumerUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='LongConsumer.Util']/method[@name='andThen' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.LongConsumer'] and parameter[2][@type='com.annimon.stream.function.LongConsumer']]"
		[Register ("andThen", "(Lcom/annimon/stream/function/LongConsumer;Lcom/annimon/stream/function/LongConsumer;)Lcom/annimon/stream/function/LongConsumer;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.ILongConsumer AndThen (global::Com.Annimon.Stream.Function.ILongConsumer c1, global::Com.Annimon.Stream.Function.ILongConsumer c2)
		{
			const string __id = "andThen.(Lcom/annimon/stream/function/LongConsumer;Lcom/annimon/stream/function/LongConsumer;)Lcom/annimon/stream/function/LongConsumer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((c1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c1).Handle);
				__args [1] = new JniArgumentValue ((c2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ILongConsumer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='LongConsumer.Util']/method[@name='safe' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ThrowableLongConsumer&lt;java.lang.Throwable&gt;']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableLongConsumer;)Lcom/annimon/stream/function/LongConsumer;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.ILongConsumer Safe (global::Com.Annimon.Stream.Function.IThrowableLongConsumer throwableConsumer)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableLongConsumer;)Lcom/annimon/stream/function/LongConsumer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwableConsumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwableConsumer).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ILongConsumer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='LongConsumer.Util']/method[@name='safe' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.ThrowableLongConsumer&lt;java.lang.Throwable&gt;'] and parameter[2][@type='com.annimon.stream.function.LongConsumer']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableLongConsumer;Lcom/annimon/stream/function/LongConsumer;)Lcom/annimon/stream/function/LongConsumer;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.ILongConsumer Safe (global::Com.Annimon.Stream.Function.IThrowableLongConsumer throwableConsumer, global::Com.Annimon.Stream.Function.ILongConsumer onFailedConsumer)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableLongConsumer;Lcom/annimon/stream/function/LongConsumer;)Lcom/annimon/stream/function/LongConsumer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwableConsumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwableConsumer).Handle);
				__args [1] = new JniArgumentValue ((onFailedConsumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onFailedConsumer).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ILongConsumer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='LongConsumer']"
	[Register ("com/annimon/stream/function/LongConsumer", "", "Com.Annimon.Stream.Function.ILongConsumerInvoker")]
	public partial interface ILongConsumer : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='LongConsumer']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("accept", "(J)V", "GetAccept_JHandler:Com.Annimon.Stream.Function.ILongConsumerInvoker, library-lightweight-stream-api")]
		void Accept (long p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/LongConsumer", DoNotGenerateAcw=true)]
	internal partial class ILongConsumerInvoker : global::Java.Lang.Object, ILongConsumer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/LongConsumer", typeof (ILongConsumerInvoker));

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

		public static ILongConsumer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILongConsumer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.LongConsumer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILongConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_accept_J;
#pragma warning disable 0169
		static Delegate GetAccept_JHandler ()
		{
			if (cb_accept_J == null)
				cb_accept_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Accept_J);
			return cb_accept_J;
		}

		static void n_Accept_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Annimon.Stream.Function.ILongConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ILongConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Accept (p0);
		}
#pragma warning restore 0169

		IntPtr id_accept_J;
		public unsafe void Accept (long p0)
		{
			if (id_accept_J == IntPtr.Zero)
				id_accept_J = JNIEnv.GetMethodID (class_ref, "accept", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_J, __args);
		}

	}

}
