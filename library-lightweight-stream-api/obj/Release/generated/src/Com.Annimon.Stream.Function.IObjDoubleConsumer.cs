using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ObjDoubleConsumer']"
	[Register ("com/annimon/stream/function/ObjDoubleConsumer", "", "Com.Annimon.Stream.Function.IObjDoubleConsumerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IObjDoubleConsumer : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ObjDoubleConsumer']/method[@name='accept' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='double']]"
		[Register ("accept", "(Ljava/lang/Object;D)V", "GetAccept_Ljava_lang_Object_DHandler:Com.Annimon.Stream.Function.IObjDoubleConsumerInvoker, library-lightweight-stream-api")]
		void Accept (global::Java.Lang.Object p0, double p1);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/ObjDoubleConsumer", DoNotGenerateAcw=true)]
	internal partial class IObjDoubleConsumerInvoker : global::Java.Lang.Object, IObjDoubleConsumer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/ObjDoubleConsumer", typeof (IObjDoubleConsumerInvoker));

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

		public static IObjDoubleConsumer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IObjDoubleConsumer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.ObjDoubleConsumer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IObjDoubleConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_accept_Ljava_lang_Object_D;
#pragma warning disable 0169
		static Delegate GetAccept_Ljava_lang_Object_DHandler ()
		{
			if (cb_accept_Ljava_lang_Object_D == null)
				cb_accept_Ljava_lang_Object_D = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, double>) n_Accept_Ljava_lang_Object_D);
			return cb_accept_Ljava_lang_Object_D;
		}

		static void n_Accept_Ljava_lang_Object_D (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, double p1)
		{
			global::Com.Annimon.Stream.Function.IObjDoubleConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IObjDoubleConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Accept (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_accept_Ljava_lang_Object_D;
		public unsafe void Accept (global::Java.Lang.Object p0, double p1)
		{
			if (id_accept_Ljava_lang_Object_D == IntPtr.Zero)
				id_accept_Ljava_lang_Object_D = JNIEnv.GetMethodID (class_ref, "accept", "(Ljava/lang/Object;D)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_Ljava_lang_Object_D, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
