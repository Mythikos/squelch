using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedDoublePredicate.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedDoublePredicate$Util", DoNotGenerateAcw=true)]
	public partial class IndexedDoublePredicateUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedDoublePredicate$Util", typeof (IndexedDoublePredicateUtil));
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

		protected IndexedDoublePredicateUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedDoublePredicate.Util']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoublePredicate']]"
		[Register ("wrap", "(Lcom/annimon/stream/function/DoublePredicate;)Lcom/annimon/stream/function/IndexedDoublePredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IIndexedDoublePredicate Wrap (global::Com.Annimon.Stream.Function.IDoublePredicate predicate)
		{
			const string __id = "wrap.(Lcom/annimon/stream/function/DoublePredicate;)Lcom/annimon/stream/function/IndexedDoublePredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedDoublePredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedDoublePredicate']"
	[Register ("com/annimon/stream/function/IndexedDoublePredicate", "", "Com.Annimon.Stream.Function.IIndexedDoublePredicateInvoker")]
	public partial interface IIndexedDoublePredicate : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedDoublePredicate']/method[@name='test' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double']]"
		[Register ("test", "(ID)Z", "GetTest_IDHandler:Com.Annimon.Stream.Function.IIndexedDoublePredicateInvoker, library-lightweight-stream-api")]
		bool Test (int p0, double p1);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedDoublePredicate", DoNotGenerateAcw=true)]
	internal partial class IIndexedDoublePredicateInvoker : global::Java.Lang.Object, IIndexedDoublePredicate {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedDoublePredicate", typeof (IIndexedDoublePredicateInvoker));

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

		public static IIndexedDoublePredicate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIndexedDoublePredicate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.IndexedDoublePredicate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIndexedDoublePredicateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_test_ID;
#pragma warning disable 0169
		static Delegate GetTest_IDHandler ()
		{
			if (cb_test_ID == null)
				cb_test_ID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double, bool>) n_Test_ID);
			return cb_test_ID;
		}

		static bool n_Test_ID (IntPtr jnienv, IntPtr native__this, int p0, double p1)
		{
			global::Com.Annimon.Stream.Function.IIndexedDoublePredicate __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedDoublePredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Test (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_test_ID;
		public unsafe bool Test (int p0, double p1)
		{
			if (id_test_ID == IntPtr.Zero)
				id_test_ID = JNIEnv.GetMethodID (class_ref, "test", "(ID)Z");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_test_ID, __args);
		}

	}

}
