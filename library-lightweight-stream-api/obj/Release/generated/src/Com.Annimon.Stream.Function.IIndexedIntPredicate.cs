using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedIntPredicate.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedIntPredicate$Util", DoNotGenerateAcw=true)]
	public partial class IndexedIntPredicateUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedIntPredicate$Util", typeof (IndexedIntPredicateUtil));
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

		protected IndexedIntPredicateUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedIntPredicate.Util']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntPredicate']]"
		[Register ("wrap", "(Lcom/annimon/stream/function/IntPredicate;)Lcom/annimon/stream/function/IndexedIntPredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IIndexedIntPredicate Wrap (global::Com.Annimon.Stream.Function.IIntPredicate predicate)
		{
			const string __id = "wrap.(Lcom/annimon/stream/function/IntPredicate;)Lcom/annimon/stream/function/IndexedIntPredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedIntPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedIntPredicate']"
	[Register ("com/annimon/stream/function/IndexedIntPredicate", "", "Com.Annimon.Stream.Function.IIndexedIntPredicateInvoker")]
	public partial interface IIndexedIntPredicate : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedIntPredicate']/method[@name='test' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("test", "(II)Z", "GetTest_IIHandler:Com.Annimon.Stream.Function.IIndexedIntPredicateInvoker, library-lightweight-stream-api")]
		bool Test (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedIntPredicate", DoNotGenerateAcw=true)]
	internal partial class IIndexedIntPredicateInvoker : global::Java.Lang.Object, IIndexedIntPredicate {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedIntPredicate", typeof (IIndexedIntPredicateInvoker));

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

		public static IIndexedIntPredicate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIndexedIntPredicate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.IndexedIntPredicate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIndexedIntPredicateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_test_II;
#pragma warning disable 0169
		static Delegate GetTest_IIHandler ()
		{
			if (cb_test_II == null)
				cb_test_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, bool>) n_Test_II);
			return cb_test_II;
		}

		static bool n_Test_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Annimon.Stream.Function.IIndexedIntPredicate __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedIntPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Test (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_test_II;
		public unsafe bool Test (int p0, int p1)
		{
			if (id_test_II == IntPtr.Zero)
				id_test_II = JNIEnv.GetMethodID (class_ref, "test", "(II)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_test_II, __args);
		}

	}

}
