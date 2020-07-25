using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='BooleanConsumer.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/BooleanConsumer$Util", DoNotGenerateAcw=true)]
	public partial class BooleanConsumerUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/BooleanConsumer$Util", typeof (BooleanConsumerUtil));
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

		protected BooleanConsumerUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='BooleanConsumer.Util']/method[@name='andThen' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.BooleanConsumer'] and parameter[2][@type='com.annimon.stream.function.BooleanConsumer']]"
		[Register ("andThen", "(Lcom/annimon/stream/function/BooleanConsumer;Lcom/annimon/stream/function/BooleanConsumer;)Lcom/annimon/stream/function/BooleanConsumer;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IBooleanConsumer AndThen (global::Com.Annimon.Stream.Function.IBooleanConsumer c1, global::Com.Annimon.Stream.Function.IBooleanConsumer c2)
		{
			const string __id = "andThen.(Lcom/annimon/stream/function/BooleanConsumer;Lcom/annimon/stream/function/BooleanConsumer;)Lcom/annimon/stream/function/BooleanConsumer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((c1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c1).Handle);
				__args [1] = new JniArgumentValue ((c2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IBooleanConsumer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='BooleanConsumer']"
	[Register ("com/annimon/stream/function/BooleanConsumer", "", "Com.Annimon.Stream.Function.IBooleanConsumerInvoker")]
	public partial interface IBooleanConsumer : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='BooleanConsumer']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("accept", "(Z)V", "GetAccept_ZHandler:Com.Annimon.Stream.Function.IBooleanConsumerInvoker, library-lightweight-stream-api")]
		void Accept (bool p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/BooleanConsumer", DoNotGenerateAcw=true)]
	internal partial class IBooleanConsumerInvoker : global::Java.Lang.Object, IBooleanConsumer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/BooleanConsumer", typeof (IBooleanConsumerInvoker));

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

		public static IBooleanConsumer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBooleanConsumer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.BooleanConsumer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBooleanConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_accept_Z;
#pragma warning disable 0169
		static Delegate GetAccept_ZHandler ()
		{
			if (cb_accept_Z == null)
				cb_accept_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_Accept_Z);
			return cb_accept_Z;
		}

		static void n_Accept_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Annimon.Stream.Function.IBooleanConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IBooleanConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Accept (p0);
		}
#pragma warning restore 0169

		IntPtr id_accept_Z;
		public unsafe void Accept (bool p0)
		{
			if (id_accept_Z == IntPtr.Zero)
				id_accept_Z = JNIEnv.GetMethodID (class_ref, "accept", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_Z, __args);
		}

	}

}
