using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='DoubleConsumer.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/DoubleConsumer$Util", DoNotGenerateAcw=true)]
	public partial class DoubleConsumerUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/DoubleConsumer$Util", typeof (DoubleConsumerUtil));
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

		protected DoubleConsumerUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='DoubleConsumer.Util']/method[@name='andThen' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.DoubleConsumer'] and parameter[2][@type='com.annimon.stream.function.DoubleConsumer']]"
		[Register ("andThen", "(Lcom/annimon/stream/function/DoubleConsumer;Lcom/annimon/stream/function/DoubleConsumer;)Lcom/annimon/stream/function/DoubleConsumer;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IDoubleConsumer AndThen (global::Com.Annimon.Stream.Function.IDoubleConsumer c1, global::Com.Annimon.Stream.Function.IDoubleConsumer c2)
		{
			const string __id = "andThen.(Lcom/annimon/stream/function/DoubleConsumer;Lcom/annimon/stream/function/DoubleConsumer;)Lcom/annimon/stream/function/DoubleConsumer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((c1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c1).Handle);
				__args [1] = new JniArgumentValue ((c2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IDoubleConsumer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='DoubleConsumer.Util']/method[@name='safe' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ThrowableDoubleConsumer&lt;java.lang.Throwable&gt;']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableDoubleConsumer;)Lcom/annimon/stream/function/DoubleConsumer;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IDoubleConsumer Safe (global::Com.Annimon.Stream.Function.IThrowableDoubleConsumer throwableConsumer)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableDoubleConsumer;)Lcom/annimon/stream/function/DoubleConsumer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwableConsumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwableConsumer).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IDoubleConsumer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='DoubleConsumer.Util']/method[@name='safe' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.ThrowableDoubleConsumer&lt;java.lang.Throwable&gt;'] and parameter[2][@type='com.annimon.stream.function.DoubleConsumer']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableDoubleConsumer;Lcom/annimon/stream/function/DoubleConsumer;)Lcom/annimon/stream/function/DoubleConsumer;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IDoubleConsumer Safe (global::Com.Annimon.Stream.Function.IThrowableDoubleConsumer throwableConsumer, global::Com.Annimon.Stream.Function.IDoubleConsumer onFailedConsumer)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableDoubleConsumer;Lcom/annimon/stream/function/DoubleConsumer;)Lcom/annimon/stream/function/DoubleConsumer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwableConsumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwableConsumer).Handle);
				__args [1] = new JniArgumentValue ((onFailedConsumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onFailedConsumer).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IDoubleConsumer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='DoubleConsumer']"
	[Register ("com/annimon/stream/function/DoubleConsumer", "", "Com.Annimon.Stream.Function.IDoubleConsumerInvoker")]
	public partial interface IDoubleConsumer : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='DoubleConsumer']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("accept", "(D)V", "GetAccept_DHandler:Com.Annimon.Stream.Function.IDoubleConsumerInvoker, library-lightweight-stream-api")]
		void Accept (double p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/DoubleConsumer", DoNotGenerateAcw=true)]
	internal partial class IDoubleConsumerInvoker : global::Java.Lang.Object, IDoubleConsumer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/DoubleConsumer", typeof (IDoubleConsumerInvoker));

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

		public static IDoubleConsumer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDoubleConsumer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.DoubleConsumer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDoubleConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_accept_D;
#pragma warning disable 0169
		static Delegate GetAccept_DHandler ()
		{
			if (cb_accept_D == null)
				cb_accept_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, double>) n_Accept_D);
			return cb_accept_D;
		}

		static void n_Accept_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Annimon.Stream.Function.IDoubleConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IDoubleConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Accept (p0);
		}
#pragma warning restore 0169

		IntPtr id_accept_D;
		public unsafe void Accept (double p0)
		{
			if (id_accept_D == IntPtr.Zero)
				id_accept_D = JNIEnv.GetMethodID (class_ref, "accept", "(D)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_D, __args);
		}

	}

}
