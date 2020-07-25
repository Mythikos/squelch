using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedDoubleConsumer.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedDoubleConsumer$Util", DoNotGenerateAcw=true)]
	public partial class IndexedDoubleConsumerUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedDoubleConsumer$Util", typeof (IndexedDoubleConsumerUtil));
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

		protected IndexedDoubleConsumerUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedDoubleConsumer.Util']/method[@name='accept' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.IntConsumer'] and parameter[2][@type='com.annimon.stream.function.DoubleConsumer']]"
		[Register ("accept", "(Lcom/annimon/stream/function/IntConsumer;Lcom/annimon/stream/function/DoubleConsumer;)Lcom/annimon/stream/function/IndexedDoubleConsumer;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IIndexedDoubleConsumer Accept (global::Com.Annimon.Stream.Function.IIntConsumer c1, global::Com.Annimon.Stream.Function.IDoubleConsumer c2)
		{
			const string __id = "accept.(Lcom/annimon/stream/function/IntConsumer;Lcom/annimon/stream/function/DoubleConsumer;)Lcom/annimon/stream/function/IndexedDoubleConsumer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((c1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c1).Handle);
				__args [1] = new JniArgumentValue ((c2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedDoubleConsumer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedDoubleConsumer.Util']/method[@name='andThen' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.IndexedDoubleConsumer'] and parameter[2][@type='com.annimon.stream.function.IndexedDoubleConsumer']]"
		[Register ("andThen", "(Lcom/annimon/stream/function/IndexedDoubleConsumer;Lcom/annimon/stream/function/IndexedDoubleConsumer;)Lcom/annimon/stream/function/IndexedDoubleConsumer;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IIndexedDoubleConsumer AndThen (global::Com.Annimon.Stream.Function.IIndexedDoubleConsumer c1, global::Com.Annimon.Stream.Function.IIndexedDoubleConsumer c2)
		{
			const string __id = "andThen.(Lcom/annimon/stream/function/IndexedDoubleConsumer;Lcom/annimon/stream/function/IndexedDoubleConsumer;)Lcom/annimon/stream/function/IndexedDoubleConsumer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((c1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c1).Handle);
				__args [1] = new JniArgumentValue ((c2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedDoubleConsumer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedDoubleConsumer']"
	[Register ("com/annimon/stream/function/IndexedDoubleConsumer", "", "Com.Annimon.Stream.Function.IIndexedDoubleConsumerInvoker")]
	public partial interface IIndexedDoubleConsumer : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedDoubleConsumer']/method[@name='accept' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double']]"
		[Register ("accept", "(ID)V", "GetAccept_IDHandler:Com.Annimon.Stream.Function.IIndexedDoubleConsumerInvoker, library-lightweight-stream-api")]
		void Accept (int p0, double p1);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedDoubleConsumer", DoNotGenerateAcw=true)]
	internal partial class IIndexedDoubleConsumerInvoker : global::Java.Lang.Object, IIndexedDoubleConsumer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedDoubleConsumer", typeof (IIndexedDoubleConsumerInvoker));

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

		public static IIndexedDoubleConsumer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIndexedDoubleConsumer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.IndexedDoubleConsumer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIndexedDoubleConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_accept_ID;
#pragma warning disable 0169
		static Delegate GetAccept_IDHandler ()
		{
			if (cb_accept_ID == null)
				cb_accept_ID = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, double>) n_Accept_ID);
			return cb_accept_ID;
		}

		static void n_Accept_ID (IntPtr jnienv, IntPtr native__this, int p0, double p1)
		{
			global::Com.Annimon.Stream.Function.IIndexedDoubleConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedDoubleConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Accept (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_accept_ID;
		public unsafe void Accept (int p0, double p1)
		{
			if (id_accept_ID == IntPtr.Zero)
				id_accept_ID = JNIEnv.GetMethodID (class_ref, "accept", "(ID)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_ID, __args);
		}

	}

}
