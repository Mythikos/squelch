using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedLongConsumer.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedLongConsumer$Util", DoNotGenerateAcw=true)]
	public partial class IndexedLongConsumerUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedLongConsumer$Util", typeof (IndexedLongConsumerUtil));
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

		protected IndexedLongConsumerUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedLongConsumer.Util']/method[@name='accept' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.IntConsumer'] and parameter[2][@type='com.annimon.stream.function.LongConsumer']]"
		[Register ("accept", "(Lcom/annimon/stream/function/IntConsumer;Lcom/annimon/stream/function/LongConsumer;)Lcom/annimon/stream/function/IndexedLongConsumer;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IIndexedLongConsumer Accept (global::Com.Annimon.Stream.Function.IIntConsumer c1, global::Com.Annimon.Stream.Function.ILongConsumer c2)
		{
			const string __id = "accept.(Lcom/annimon/stream/function/IntConsumer;Lcom/annimon/stream/function/LongConsumer;)Lcom/annimon/stream/function/IndexedLongConsumer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((c1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c1).Handle);
				__args [1] = new JniArgumentValue ((c2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedLongConsumer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedLongConsumer.Util']/method[@name='andThen' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.IndexedLongConsumer'] and parameter[2][@type='com.annimon.stream.function.IndexedLongConsumer']]"
		[Register ("andThen", "(Lcom/annimon/stream/function/IndexedLongConsumer;Lcom/annimon/stream/function/IndexedLongConsumer;)Lcom/annimon/stream/function/IndexedLongConsumer;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IIndexedLongConsumer AndThen (global::Com.Annimon.Stream.Function.IIndexedLongConsumer c1, global::Com.Annimon.Stream.Function.IIndexedLongConsumer c2)
		{
			const string __id = "andThen.(Lcom/annimon/stream/function/IndexedLongConsumer;Lcom/annimon/stream/function/IndexedLongConsumer;)Lcom/annimon/stream/function/IndexedLongConsumer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((c1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c1).Handle);
				__args [1] = new JniArgumentValue ((c2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedLongConsumer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedLongConsumer']"
	[Register ("com/annimon/stream/function/IndexedLongConsumer", "", "Com.Annimon.Stream.Function.IIndexedLongConsumerInvoker")]
	public partial interface IIndexedLongConsumer : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedLongConsumer']/method[@name='accept' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("accept", "(IJ)V", "GetAccept_IJHandler:Com.Annimon.Stream.Function.IIndexedLongConsumerInvoker, library-lightweight-stream-api")]
		void Accept (int p0, long p1);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedLongConsumer", DoNotGenerateAcw=true)]
	internal partial class IIndexedLongConsumerInvoker : global::Java.Lang.Object, IIndexedLongConsumer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedLongConsumer", typeof (IIndexedLongConsumerInvoker));

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

		public static IIndexedLongConsumer GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIndexedLongConsumer> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.IndexedLongConsumer"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIndexedLongConsumerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_accept_IJ;
#pragma warning disable 0169
		static Delegate GetAccept_IJHandler ()
		{
			if (cb_accept_IJ == null)
				cb_accept_IJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, long>) n_Accept_IJ);
			return cb_accept_IJ;
		}

		static void n_Accept_IJ (IntPtr jnienv, IntPtr native__this, int p0, long p1)
		{
			global::Com.Annimon.Stream.Function.IIndexedLongConsumer __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedLongConsumer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Accept (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_accept_IJ;
		public unsafe void Accept (int p0, long p1)
		{
			if (id_accept_IJ == IntPtr.Zero)
				id_accept_IJ = JNIEnv.GetMethodID (class_ref, "accept", "(IJ)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_accept_IJ, __args);
		}

	}

}
