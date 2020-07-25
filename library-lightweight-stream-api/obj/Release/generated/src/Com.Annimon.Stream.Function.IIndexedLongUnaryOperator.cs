using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedLongUnaryOperator.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedLongUnaryOperator$Util", DoNotGenerateAcw=true)]
	public partial class IndexedLongUnaryOperatorUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedLongUnaryOperator$Util", typeof (IndexedLongUnaryOperatorUtil));
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

		protected IndexedLongUnaryOperatorUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedLongUnaryOperator.Util']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongUnaryOperator']]"
		[Register ("wrap", "(Lcom/annimon/stream/function/LongUnaryOperator;)Lcom/annimon/stream/function/IndexedLongUnaryOperator;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IIndexedLongUnaryOperator Wrap (global::Com.Annimon.Stream.Function.ILongUnaryOperator function)
		{
			const string __id = "wrap.(Lcom/annimon/stream/function/LongUnaryOperator;)Lcom/annimon/stream/function/IndexedLongUnaryOperator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((function == null) ? IntPtr.Zero : ((global::Java.Lang.Object) function).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedLongUnaryOperator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedLongUnaryOperator']"
	[Register ("com/annimon/stream/function/IndexedLongUnaryOperator", "", "Com.Annimon.Stream.Function.IIndexedLongUnaryOperatorInvoker")]
	public partial interface IIndexedLongUnaryOperator : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedLongUnaryOperator']/method[@name='applyAsLong' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("applyAsLong", "(IJ)J", "GetApplyAsLong_IJHandler:Com.Annimon.Stream.Function.IIndexedLongUnaryOperatorInvoker, library-lightweight-stream-api")]
		long ApplyAsLong (int p0, long p1);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedLongUnaryOperator", DoNotGenerateAcw=true)]
	internal partial class IIndexedLongUnaryOperatorInvoker : global::Java.Lang.Object, IIndexedLongUnaryOperator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedLongUnaryOperator", typeof (IIndexedLongUnaryOperatorInvoker));

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

		public static IIndexedLongUnaryOperator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIndexedLongUnaryOperator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.IndexedLongUnaryOperator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIndexedLongUnaryOperatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_applyAsLong_IJ;
#pragma warning disable 0169
		static Delegate GetApplyAsLong_IJHandler ()
		{
			if (cb_applyAsLong_IJ == null)
				cb_applyAsLong_IJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long, long>) n_ApplyAsLong_IJ);
			return cb_applyAsLong_IJ;
		}

		static long n_ApplyAsLong_IJ (IntPtr jnienv, IntPtr native__this, int p0, long p1)
		{
			global::Com.Annimon.Stream.Function.IIndexedLongUnaryOperator __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedLongUnaryOperator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ApplyAsLong (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_applyAsLong_IJ;
		public unsafe long ApplyAsLong (int p0, long p1)
		{
			if (id_applyAsLong_IJ == IntPtr.Zero)
				id_applyAsLong_IJ = JNIEnv.GetMethodID (class_ref, "applyAsLong", "(IJ)J");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_applyAsLong_IJ, __args);
		}

	}

}
