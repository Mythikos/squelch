using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='Predicate.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/Predicate$Util", DoNotGenerateAcw=true)]
	public partial class PredicateUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/Predicate$Util", typeof (PredicateUtil));
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

		protected PredicateUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='Predicate.Util']/method[@name='and' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;'] and parameter[2][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;']]"
		[Register ("and", "(Lcom/annimon/stream/function/Predicate;Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/function/Predicate;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Function.IPredicate And (global::Com.Annimon.Stream.Function.IPredicate p1, global::Com.Annimon.Stream.Function.IPredicate p2)
		{
			const string __id = "and.(Lcom/annimon/stream/function/Predicate;Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/function/Predicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [1] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='Predicate.Util']/method[@name='and' and count(parameter)=3 and parameter[1][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;'] and parameter[2][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;'] and parameter[3][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;...']]"
		[Register ("and", "(Lcom/annimon/stream/function/Predicate;Lcom/annimon/stream/function/Predicate;[Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/function/Predicate;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Function.IPredicate And (global::Com.Annimon.Stream.Function.IPredicate p1, global::Com.Annimon.Stream.Function.IPredicate p2, params global::Com.Annimon.Stream.Function.IPredicate[] rest)
		{
			const string __id = "and.(Lcom/annimon/stream/function/Predicate;Lcom/annimon/stream/function/Predicate;[Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/function/Predicate;";
			IntPtr native_rest = JNIEnv.NewArray (rest);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [1] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [2] = new JniArgumentValue (native_rest);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (rest != null) {
					JNIEnv.CopyArray (native_rest, rest);
					JNIEnv.DeleteLocalRef (native_rest);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='Predicate.Util']/method[@name='negate' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;']]"
		[Register ("negate", "(Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/function/Predicate;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Function.IPredicate Negate (global::Com.Annimon.Stream.Function.IPredicate p1)
		{
			const string __id = "negate.(Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/function/Predicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='Predicate.Util']/method[@name='notNull' and count(parameter)=0]"
		[Register ("notNull", "()Lcom/annimon/stream/function/Predicate;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Function.IPredicate NotNull ()
		{
			const string __id = "notNull.()Lcom/annimon/stream/function/Predicate;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='Predicate.Util']/method[@name='or' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;'] and parameter[2][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;']]"
		[Register ("or", "(Lcom/annimon/stream/function/Predicate;Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/function/Predicate;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Function.IPredicate Or (global::Com.Annimon.Stream.Function.IPredicate p1, global::Com.Annimon.Stream.Function.IPredicate p2)
		{
			const string __id = "or.(Lcom/annimon/stream/function/Predicate;Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/function/Predicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [1] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='Predicate.Util']/method[@name='or' and count(parameter)=3 and parameter[1][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;'] and parameter[2][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;'] and parameter[3][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;...']]"
		[Register ("or", "(Lcom/annimon/stream/function/Predicate;Lcom/annimon/stream/function/Predicate;[Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/function/Predicate;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Function.IPredicate Or (global::Com.Annimon.Stream.Function.IPredicate p1, global::Com.Annimon.Stream.Function.IPredicate p2, params global::Com.Annimon.Stream.Function.IPredicate[] rest)
		{
			const string __id = "or.(Lcom/annimon/stream/function/Predicate;Lcom/annimon/stream/function/Predicate;[Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/function/Predicate;";
			IntPtr native_rest = JNIEnv.NewArray (rest);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [1] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				__args [2] = new JniArgumentValue (native_rest);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (rest != null) {
					JNIEnv.CopyArray (native_rest, rest);
					JNIEnv.DeleteLocalRef (native_rest);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='Predicate.Util']/method[@name='safe' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ThrowablePredicate&lt;? super T, java.lang.Throwable&gt;']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowablePredicate;)Lcom/annimon/stream/function/Predicate;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Function.IPredicate Safe (global::Com.Annimon.Stream.Function.IThrowablePredicate throwablePredicate)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowablePredicate;)Lcom/annimon/stream/function/Predicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwablePredicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwablePredicate).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='Predicate.Util']/method[@name='safe' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.ThrowablePredicate&lt;? super T, java.lang.Throwable&gt;'] and parameter[2][@type='boolean']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowablePredicate;Z)Lcom/annimon/stream/function/Predicate;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Function.IPredicate Safe (global::Com.Annimon.Stream.Function.IThrowablePredicate throwablePredicate, bool resultIfFailed)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowablePredicate;Z)Lcom/annimon/stream/function/Predicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwablePredicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwablePredicate).Handle);
				__args [1] = new JniArgumentValue (resultIfFailed);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='Predicate.Util']/method[@name='xor' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;'] and parameter[2][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;']]"
		[Register ("xor", "(Lcom/annimon/stream/function/Predicate;Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/function/Predicate;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Function.IPredicate Xor (global::Com.Annimon.Stream.Function.IPredicate p1, global::Com.Annimon.Stream.Function.IPredicate p2)
		{
			const string __id = "xor.(Lcom/annimon/stream/function/Predicate;Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/function/Predicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [1] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='Predicate']"
	[Register ("com/annimon/stream/function/Predicate", "", "Com.Annimon.Stream.Function.IPredicateInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IPredicate : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='Predicate']/method[@name='test' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("test", "(Ljava/lang/Object;)Z", "GetTest_Ljava_lang_Object_Handler:Com.Annimon.Stream.Function.IPredicateInvoker, library-lightweight-stream-api")]
		bool Test (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/Predicate", DoNotGenerateAcw=true)]
	internal partial class IPredicateInvoker : global::Java.Lang.Object, IPredicate {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/Predicate", typeof (IPredicateInvoker));

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

		public static IPredicate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IPredicate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.Predicate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IPredicateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_test_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetTest_Ljava_lang_Object_Handler ()
		{
			if (cb_test_Ljava_lang_Object_ == null)
				cb_test_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Test_Ljava_lang_Object_);
			return cb_test_Ljava_lang_Object_;
		}

		static bool n_Test_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Annimon.Stream.Function.IPredicate __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Test (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_test_Ljava_lang_Object_;
		public unsafe bool Test (global::Java.Lang.Object p0)
		{
			if (id_test_Ljava_lang_Object_ == IntPtr.Zero)
				id_test_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "test", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_test_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
