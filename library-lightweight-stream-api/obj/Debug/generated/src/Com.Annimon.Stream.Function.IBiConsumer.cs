using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='BiConsumer.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/BiConsumer$Util", DoNotGenerateAcw=true)]
	public partial class BiConsumerUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/BiConsumer$Util", typeof (BiConsumerUtil));
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

		protected BiConsumerUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='BiConsumer.Util']/method[@name='andThen' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.BiConsumer&lt;? super T, ? super U&gt;'] and parameter[2][@type='com.annimon.stream.function.BiConsumer&lt;? super T, ? super U&gt;']]"
		[Register ("andThen", "(Lcom/annimon/stream/function/BiConsumer;Lcom/annimon/stream/function/BiConsumer;)Lcom/annimon/stream/function/BiConsumer;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U"})]
		public static unsafe global::Com.Annimon.Stream.Function.IBiConsumer AndThen (global::Com.Annimon.Stream.Function.IBiConsumer c1, global::Com.Annimon.Stream.Function.IBiConsumer c2)
		{
			const string __id = "andThen.(Lcom/annimon/stream/function/BiConsumer;Lcom/annimon/stream/function/BiConsumer;)Lcom/annimon/stream/function/BiConsumer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((c1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c1).Handle);
				__args [1] = new JniArgumentValue ((c2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IBiConsumer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='BiConsumer']"
	[Register ("com/annimon/stream/function/BiConsumer", "", "Com.Annimon.Stream.Function.IBiConsumerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U"})]
	public partial interface IBiConsumer : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='BiConsumer']/method[@name='accept' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='U']]"
		[Register ("accept", "(Ljava/lang/Object;Ljava/lang/Object;)V", "GetAccept_Ljava_lang_Object_Ljava_lang_Object_Handler:Com.Annimon.Stream.Function.IBiConsumerInvoker, library-lightweight-stream-api")]
		void Accept (global::Java.Lang.Object p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/BiConsumer", DoNotGenerateAcw=true)]
	internal partial class IBiConsumerInvoker : global::Java.Lang.Object, IBiConsumer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/BiConsumer", typeof (IBiConsumerInvoker));

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

		public static IBiConsumer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiConsumer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.BiConsumer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_accept_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAccept_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_accept_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_accept_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Accept_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_accept_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static void n_Accept_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Annimon.Stream.Function.IBiConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IBiConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Accept (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_accept_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe void Accept (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_accept_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_accept_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "accept", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_Ljava_lang_Object_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
