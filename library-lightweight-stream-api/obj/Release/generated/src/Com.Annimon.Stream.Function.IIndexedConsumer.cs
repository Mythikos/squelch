using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedConsumer.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedConsumer$Util", DoNotGenerateAcw=true)]
	public partial class IndexedConsumerUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedConsumer$Util", typeof (IndexedConsumerUtil));
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

		protected IndexedConsumerUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedConsumer.Util']/method[@name='accept' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.IntConsumer'] and parameter[2][@type='com.annimon.stream.function.Consumer&lt;? super T&gt;']]"
		[Register ("accept", "(Lcom/annimon/stream/function/IntConsumer;Lcom/annimon/stream/function/Consumer;)Lcom/annimon/stream/function/IndexedConsumer;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Function.IIndexedConsumer Accept (global::Com.Annimon.Stream.Function.IIntConsumer c1, global::Com.Annimon.Stream.Function.IConsumer c2)
		{
			const string __id = "accept.(Lcom/annimon/stream/function/IntConsumer;Lcom/annimon/stream/function/Consumer;)Lcom/annimon/stream/function/IndexedConsumer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((c1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c1).Handle);
				__args [1] = new JniArgumentValue ((c2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedConsumer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedConsumer.Util']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Consumer&lt;? super T&gt;']]"
		[Register ("wrap", "(Lcom/annimon/stream/function/Consumer;)Lcom/annimon/stream/function/IndexedConsumer;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Function.IIndexedConsumer Wrap (global::Com.Annimon.Stream.Function.IConsumer consumer)
		{
			const string __id = "wrap.(Lcom/annimon/stream/function/Consumer;)Lcom/annimon/stream/function/IndexedConsumer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((consumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consumer).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedConsumer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedConsumer']"
	[Register ("com/annimon/stream/function/IndexedConsumer", "", "Com.Annimon.Stream.Function.IIndexedConsumerInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IIndexedConsumer : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedConsumer']/method[@name='accept' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='T']]"
		[Register ("accept", "(ILjava/lang/Object;)V", "GetAccept_ILjava_lang_Object_Handler:Com.Annimon.Stream.Function.IIndexedConsumerInvoker, library-lightweight-stream-api")]
		void Accept (int p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedConsumer", DoNotGenerateAcw=true)]
	internal partial class IIndexedConsumerInvoker : global::Java.Lang.Object, IIndexedConsumer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedConsumer", typeof (IIndexedConsumerInvoker));

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

		public static IIndexedConsumer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIndexedConsumer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.IndexedConsumer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIndexedConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_accept_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetAccept_ILjava_lang_Object_Handler ()
		{
			if (cb_accept_ILjava_lang_Object_ == null)
				cb_accept_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_Accept_ILjava_lang_Object_);
			return cb_accept_ILjava_lang_Object_;
		}

		static void n_Accept_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Annimon.Stream.Function.IIndexedConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.Accept (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_accept_ILjava_lang_Object_;
		public unsafe void Accept (int p0, global::Java.Lang.Object p1)
		{
			if (id_accept_ILjava_lang_Object_ == IntPtr.Zero)
				id_accept_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "accept", "(ILjava/lang/Object;)V");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_ILjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
		}

	}

}
