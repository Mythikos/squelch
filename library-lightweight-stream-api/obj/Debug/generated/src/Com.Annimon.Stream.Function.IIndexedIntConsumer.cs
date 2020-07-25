using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedIntConsumer.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedIntConsumer$Util", DoNotGenerateAcw=true)]
	public partial class IndexedIntConsumerUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedIntConsumer$Util", typeof (IndexedIntConsumerUtil));
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

		protected IndexedIntConsumerUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedIntConsumer.Util']/method[@name='accept' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.IntConsumer'] and parameter[2][@type='com.annimon.stream.function.IntConsumer']]"
		[Register ("accept", "(Lcom/annimon/stream/function/IntConsumer;Lcom/annimon/stream/function/IntConsumer;)Lcom/annimon/stream/function/IndexedIntConsumer;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IIndexedIntConsumer Accept (global::Com.Annimon.Stream.Function.IIntConsumer c1, global::Com.Annimon.Stream.Function.IIntConsumer c2)
		{
			const string __id = "accept.(Lcom/annimon/stream/function/IntConsumer;Lcom/annimon/stream/function/IntConsumer;)Lcom/annimon/stream/function/IndexedIntConsumer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((c1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c1).Handle);
				__args [1] = new JniArgumentValue ((c2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedIntConsumer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedIntConsumer.Util']/method[@name='andThen' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.IndexedIntConsumer'] and parameter[2][@type='com.annimon.stream.function.IndexedIntConsumer']]"
		[Register ("andThen", "(Lcom/annimon/stream/function/IndexedIntConsumer;Lcom/annimon/stream/function/IndexedIntConsumer;)Lcom/annimon/stream/function/IndexedIntConsumer;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IIndexedIntConsumer AndThen (global::Com.Annimon.Stream.Function.IIndexedIntConsumer c1, global::Com.Annimon.Stream.Function.IIndexedIntConsumer c2)
		{
			const string __id = "andThen.(Lcom/annimon/stream/function/IndexedIntConsumer;Lcom/annimon/stream/function/IndexedIntConsumer;)Lcom/annimon/stream/function/IndexedIntConsumer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((c1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c1).Handle);
				__args [1] = new JniArgumentValue ((c2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedIntConsumer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedIntConsumer']"
	[Register ("com/annimon/stream/function/IndexedIntConsumer", "", "Com.Annimon.Stream.Function.IIndexedIntConsumerInvoker")]
	public partial interface IIndexedIntConsumer : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedIntConsumer']/method[@name='accept' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("accept", "(II)V", "GetAccept_IIHandler:Com.Annimon.Stream.Function.IIndexedIntConsumerInvoker, library-lightweight-stream-api")]
		void Accept (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedIntConsumer", DoNotGenerateAcw=true)]
	internal partial class IIndexedIntConsumerInvoker : global::Java.Lang.Object, IIndexedIntConsumer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedIntConsumer", typeof (IIndexedIntConsumerInvoker));

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

		public static IIndexedIntConsumer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIndexedIntConsumer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.IndexedIntConsumer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIndexedIntConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_accept_II;
#pragma warning disable 0169
		static Delegate GetAccept_IIHandler ()
		{
			if (cb_accept_II == null)
				cb_accept_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_Accept_II);
			return cb_accept_II;
		}

		static void n_Accept_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Annimon.Stream.Function.IIndexedIntConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedIntConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Accept (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_accept_II;
		public unsafe void Accept (int p0, int p1)
		{
			if (id_accept_II == IntPtr.Zero)
				id_accept_II = JNIEnv.GetMethodID (class_ref, "accept", "(II)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_II, __args);
		}

	}

}
