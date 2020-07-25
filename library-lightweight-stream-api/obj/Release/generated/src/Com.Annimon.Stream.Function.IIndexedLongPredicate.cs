using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedLongPredicate.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedLongPredicate$Util", DoNotGenerateAcw=true)]
	public partial class IndexedLongPredicateUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedLongPredicate$Util", typeof (IndexedLongPredicateUtil));
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

		protected IndexedLongPredicateUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedLongPredicate.Util']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongPredicate']]"
		[Register ("wrap", "(Lcom/annimon/stream/function/LongPredicate;)Lcom/annimon/stream/function/IndexedLongPredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IIndexedLongPredicate Wrap (global::Com.Annimon.Stream.Function.ILongPredicate predicate)
		{
			const string __id = "wrap.(Lcom/annimon/stream/function/LongPredicate;)Lcom/annimon/stream/function/IndexedLongPredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedLongPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedLongPredicate']"
	[Register ("com/annimon/stream/function/IndexedLongPredicate", "", "Com.Annimon.Stream.Function.IIndexedLongPredicateInvoker")]
	public partial interface IIndexedLongPredicate : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedLongPredicate']/method[@name='test' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='long']]"
		[Register ("test", "(IJ)Z", "GetTest_IJHandler:Com.Annimon.Stream.Function.IIndexedLongPredicateInvoker, library-lightweight-stream-api")]
		bool Test (int p0, long p1);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedLongPredicate", DoNotGenerateAcw=true)]
	internal partial class IIndexedLongPredicateInvoker : global::Java.Lang.Object, IIndexedLongPredicate {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedLongPredicate", typeof (IIndexedLongPredicateInvoker));

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

		public static IIndexedLongPredicate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIndexedLongPredicate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.IndexedLongPredicate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIndexedLongPredicateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_test_IJ;
#pragma warning disable 0169
		static Delegate GetTest_IJHandler ()
		{
			if (cb_test_IJ == null)
				cb_test_IJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long, bool>) n_Test_IJ);
			return cb_test_IJ;
		}

		static bool n_Test_IJ (IntPtr jnienv, IntPtr native__this, int p0, long p1)
		{
			global::Com.Annimon.Stream.Function.IIndexedLongPredicate __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedLongPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Test (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_test_IJ;
		public unsafe bool Test (int p0, long p1)
		{
			if (id_test_IJ == IntPtr.Zero)
				id_test_IJ = JNIEnv.GetMethodID (class_ref, "test", "(IJ)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_test_IJ, __args);
		}

	}

}
