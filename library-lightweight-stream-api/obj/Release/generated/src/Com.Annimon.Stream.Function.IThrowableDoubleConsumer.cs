using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableDoubleConsumer']"
	[Register ("com/annimon/stream/function/ThrowableDoubleConsumer", "", "Com.Annimon.Stream.Function.IThrowableDoubleConsumerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Throwable"})]
	public partial interface IThrowableDoubleConsumer : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableDoubleConsumer']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("accept", "(D)V", "GetAccept_DHandler:Com.Annimon.Stream.Function.IThrowableDoubleConsumerInvoker, library-lightweight-stream-api")]
		void Accept (double p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/ThrowableDoubleConsumer", DoNotGenerateAcw=true)]
	internal partial class IThrowableDoubleConsumerInvoker : global::Java.Lang.Object, IThrowableDoubleConsumer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/ThrowableDoubleConsumer", typeof (IThrowableDoubleConsumerInvoker));

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

		public static IThrowableDoubleConsumer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThrowableDoubleConsumer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.ThrowableDoubleConsumer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThrowableDoubleConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Com.Annimon.Stream.Function.IThrowableDoubleConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IThrowableDoubleConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
