using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ObjIntConsumer']"
	[Register ("com/annimon/stream/function/ObjIntConsumer", "", "Com.Annimon.Stream.Function.IObjIntConsumerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IObjIntConsumer : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ObjIntConsumer']/method[@name='accept' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='int']]"
		[Register ("accept", "(Ljava/lang/Object;I)V", "GetAccept_Ljava_lang_Object_IHandler:Com.Annimon.Stream.Function.IObjIntConsumerInvoker, library-lightweight-stream-api")]
		void Accept (global::Java.Lang.Object p0, int p1);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/ObjIntConsumer", DoNotGenerateAcw=true)]
	internal partial class IObjIntConsumerInvoker : global::Java.Lang.Object, IObjIntConsumer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/ObjIntConsumer", typeof (IObjIntConsumerInvoker));

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

		public static IObjIntConsumer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IObjIntConsumer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.ObjIntConsumer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IObjIntConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_accept_Ljava_lang_Object_I;
#pragma warning disable 0169
		static Delegate GetAccept_Ljava_lang_Object_IHandler ()
		{
			if (cb_accept_Ljava_lang_Object_I == null)
				cb_accept_Ljava_lang_Object_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_Accept_Ljava_lang_Object_I);
			return cb_accept_Ljava_lang_Object_I;
		}

		static void n_Accept_Ljava_lang_Object_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Annimon.Stream.Function.IObjIntConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IObjIntConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Accept (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_accept_Ljava_lang_Object_I;
		public unsafe void Accept (global::Java.Lang.Object p0, int p1)
		{
			if (id_accept_Ljava_lang_Object_I == IntPtr.Zero)
				id_accept_Ljava_lang_Object_I = JNIEnv.GetMethodID (class_ref, "accept", "(Ljava/lang/Object;I)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_Ljava_lang_Object_I, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
