using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='Consumer.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/Consumer$Util", DoNotGenerateAcw=true)]
	public partial class ConsumerUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/Consumer$Util", typeof (ConsumerUtil));
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

		protected ConsumerUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='Consumer.Util']/method[@name='andThen' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.Consumer&lt;? super T&gt;'] and parameter[2][@type='com.annimon.stream.function.Consumer&lt;? super T&gt;']]"
		[Register ("andThen", "(Lcom/annimon/stream/function/Consumer;Lcom/annimon/stream/function/Consumer;)Lcom/annimon/stream/function/Consumer;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Function.IConsumer AndThen (global::Com.Annimon.Stream.Function.IConsumer c1, global::Com.Annimon.Stream.Function.IConsumer c2)
		{
			const string __id = "andThen.(Lcom/annimon/stream/function/Consumer;Lcom/annimon/stream/function/Consumer;)Lcom/annimon/stream/function/Consumer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((c1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c1).Handle);
				__args [1] = new JniArgumentValue ((c2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IConsumer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='Consumer.Util']/method[@name='safe' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ThrowableConsumer&lt;? super T, java.lang.Throwable&gt;']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableConsumer;)Lcom/annimon/stream/function/Consumer;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Function.IConsumer Safe (global::Com.Annimon.Stream.Function.IThrowableConsumer throwableConsumer)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableConsumer;)Lcom/annimon/stream/function/Consumer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwableConsumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwableConsumer).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IConsumer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='Consumer.Util']/method[@name='safe' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.ThrowableConsumer&lt;? super T, java.lang.Throwable&gt;'] and parameter[2][@type='com.annimon.stream.function.Consumer&lt;? super T&gt;']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableConsumer;Lcom/annimon/stream/function/Consumer;)Lcom/annimon/stream/function/Consumer;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Function.IConsumer Safe (global::Com.Annimon.Stream.Function.IThrowableConsumer throwableConsumer, global::Com.Annimon.Stream.Function.IConsumer onFailedConsumer)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableConsumer;Lcom/annimon/stream/function/Consumer;)Lcom/annimon/stream/function/Consumer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwableConsumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwableConsumer).Handle);
				__args [1] = new JniArgumentValue ((onFailedConsumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) onFailedConsumer).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IConsumer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='Consumer']"
	[Register ("com/annimon/stream/function/Consumer", "", "Com.Annimon.Stream.Function.IConsumerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IConsumer : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='Consumer']/method[@name='accept' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("accept", "(Ljava/lang/Object;)V", "GetAccept_Ljava_lang_Object_Handler:Com.Annimon.Stream.Function.IConsumerInvoker, library-lightweight-stream-api")]
		void Accept (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/Consumer", DoNotGenerateAcw=true)]
	internal partial class IConsumerInvoker : global::Java.Lang.Object, IConsumer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/Consumer", typeof (IConsumerInvoker));

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

		public static IConsumer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IConsumer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.Consumer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_accept_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAccept_Ljava_lang_Object_Handler ()
		{
			if (cb_accept_Ljava_lang_Object_ == null)
				cb_accept_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Accept_Ljava_lang_Object_);
			return cb_accept_Ljava_lang_Object_;
		}

		static void n_Accept_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Annimon.Stream.Function.IConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Accept (p0);
		}
#pragma warning restore 0169

		IntPtr id_accept_Ljava_lang_Object_;
		public unsafe void Accept (global::Java.Lang.Object p0)
		{
			if (id_accept_Ljava_lang_Object_ == IntPtr.Zero)
				id_accept_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "accept", "(Ljava/lang/Object;)V");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
