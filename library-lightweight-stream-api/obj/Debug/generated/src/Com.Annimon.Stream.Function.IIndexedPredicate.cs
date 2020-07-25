using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedPredicate.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedPredicate$Util", DoNotGenerateAcw=true)]
	public partial class IndexedPredicateUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedPredicate$Util", typeof (IndexedPredicateUtil));
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

		protected IndexedPredicateUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedPredicate.Util']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;']]"
		[Register ("wrap", "(Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/function/IndexedPredicate;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Function.IIndexedPredicate Wrap (global::Com.Annimon.Stream.Function.IPredicate predicate)
		{
			const string __id = "wrap.(Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/function/IndexedPredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedPredicate']"
	[Register ("com/annimon/stream/function/IndexedPredicate", "", "Com.Annimon.Stream.Function.IIndexedPredicateInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IIndexedPredicate : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedPredicate']/method[@name='test' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='T']]"
		[Register ("test", "(ILjava/lang/Object;)Z", "GetTest_ILjava_lang_Object_Handler:Com.Annimon.Stream.Function.IIndexedPredicateInvoker, library-lightweight-stream-api")]
		bool Test (int p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedPredicate", DoNotGenerateAcw=true)]
	internal partial class IIndexedPredicateInvoker : global::Java.Lang.Object, IIndexedPredicate {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedPredicate", typeof (IIndexedPredicateInvoker));

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

		public static IIndexedPredicate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIndexedPredicate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.IndexedPredicate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIndexedPredicateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_test_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetTest_ILjava_lang_Object_Handler ()
		{
			if (cb_test_ILjava_lang_Object_ == null)
				cb_test_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, bool>) n_Test_ILjava_lang_Object_);
			return cb_test_ILjava_lang_Object_;
		}

		static bool n_Test_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Annimon.Stream.Function.IIndexedPredicate __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Test (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_test_ILjava_lang_Object_;
		public unsafe bool Test (int p0, global::Java.Lang.Object p1)
		{
			if (id_test_ILjava_lang_Object_ == IntPtr.Zero)
				id_test_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "test", "(ILjava/lang/Object;)Z");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_test_ILjava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

}
