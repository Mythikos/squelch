using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableLongConsumer']"
	[Register ("com/annimon/stream/function/ThrowableLongConsumer", "", "Com.Annimon.Stream.Function.IThrowableLongConsumerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Throwable"})]
	public partial interface IThrowableLongConsumer : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableLongConsumer']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("accept", "(J)V", "GetAccept_JHandler:Com.Annimon.Stream.Function.IThrowableLongConsumerInvoker, library-lightweight-stream-api")]
		void Accept (long p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/ThrowableLongConsumer", DoNotGenerateAcw=true)]
	internal partial class IThrowableLongConsumerInvoker : global::Java.Lang.Object, IThrowableLongConsumer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/ThrowableLongConsumer", typeof (IThrowableLongConsumerInvoker));

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

		public static IThrowableLongConsumer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThrowableLongConsumer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.ThrowableLongConsumer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThrowableLongConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Com.Annimon.Stream.Function.IThrowableLongConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IThrowableLongConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
