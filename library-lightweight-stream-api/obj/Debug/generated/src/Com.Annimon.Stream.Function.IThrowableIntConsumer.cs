using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableIntConsumer']"
	[Register ("com/annimon/stream/function/ThrowableIntConsumer", "", "Com.Annimon.Stream.Function.IThrowableIntConsumerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Throwable"})]
	public partial interface IThrowableIntConsumer : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableIntConsumer']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("accept", "(I)V", "GetAccept_IHandler:Com.Annimon.Stream.Function.IThrowableIntConsumerInvoker, library-lightweight-stream-api")]
		void Accept (int p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/ThrowableIntConsumer", DoNotGenerateAcw=true)]
	internal partial class IThrowableIntConsumerInvoker : global::Java.Lang.Object, IThrowableIntConsumer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/ThrowableIntConsumer", typeof (IThrowableIntConsumerInvoker));

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

		public static IThrowableIntConsumer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThrowableIntConsumer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.ThrowableIntConsumer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThrowableIntConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Com.Annimon.Stream.Function.IThrowableIntConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IThrowableIntConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
