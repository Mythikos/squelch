using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IntPredicate.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/IntPredicate$Util", DoNotGenerateAcw=true)]
	public partial class IntPredicateUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IntPredicate$Util", typeof (IntPredicateUtil));
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

		protected IntPredicateUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IntPredicate.Util']/method[@name='and' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.IntPredicate'] and parameter[2][@type='com.annimon.stream.function.IntPredicate']]"
		[Register ("and", "(Lcom/annimon/stream/function/IntPredicate;Lcom/annimon/stream/function/IntPredicate;)Lcom/annimon/stream/function/IntPredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IIntPredicate And (global::Com.Annimon.Stream.Function.IIntPredicate p1, global::Com.Annimon.Stream.Function.IIntPredicate p2)
		{
			const string __id = "and.(Lcom/annimon/stream/function/IntPredicate;Lcom/annimon/stream/function/IntPredicate;)Lcom/annimon/stream/function/IntPredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [1] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIntPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IntPredicate.Util']/method[@name='negate' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntPredicate']]"
		[Register ("negate", "(Lcom/annimon/stream/function/IntPredicate;)Lcom/annimon/stream/function/IntPredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IIntPredicate Negate (global::Com.Annimon.Stream.Function.IIntPredicate p1)
		{
			const string __id = "negate.(Lcom/annimon/stream/function/IntPredicate;)Lcom/annimon/stream/function/IntPredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIntPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IntPredicate.Util']/method[@name='or' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.IntPredicate'] and parameter[2][@type='com.annimon.stream.function.IntPredicate']]"
		[Register ("or", "(Lcom/annimon/stream/function/IntPredicate;Lcom/annimon/stream/function/IntPredicate;)Lcom/annimon/stream/function/IntPredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IIntPredicate Or (global::Com.Annimon.Stream.Function.IIntPredicate p1, global::Com.Annimon.Stream.Function.IIntPredicate p2)
		{
			const string __id = "or.(Lcom/annimon/stream/function/IntPredicate;Lcom/annimon/stream/function/IntPredicate;)Lcom/annimon/stream/function/IntPredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [1] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIntPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IntPredicate.Util']/method[@name='safe' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ThrowableIntPredicate&lt;java.lang.Throwable&gt;']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableIntPredicate;)Lcom/annimon/stream/function/IntPredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IIntPredicate Safe (global::Com.Annimon.Stream.Function.IThrowableIntPredicate throwablePredicate)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableIntPredicate;)Lcom/annimon/stream/function/IntPredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwablePredicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwablePredicate).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIntPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IntPredicate.Util']/method[@name='safe' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.ThrowableIntPredicate&lt;java.lang.Throwable&gt;'] and parameter[2][@type='boolean']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableIntPredicate;Z)Lcom/annimon/stream/function/IntPredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IIntPredicate Safe (global::Com.Annimon.Stream.Function.IThrowableIntPredicate throwablePredicate, bool resultIfFailed)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableIntPredicate;Z)Lcom/annimon/stream/function/IntPredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwablePredicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwablePredicate).Handle);
				__args [1] = new JniArgumentValue (resultIfFailed);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIntPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IntPredicate.Util']/method[@name='xor' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.IntPredicate'] and parameter[2][@type='com.annimon.stream.function.IntPredicate']]"
		[Register ("xor", "(Lcom/annimon/stream/function/IntPredicate;Lcom/annimon/stream/function/IntPredicate;)Lcom/annimon/stream/function/IntPredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IIntPredicate Xor (global::Com.Annimon.Stream.Function.IIntPredicate p1, global::Com.Annimon.Stream.Function.IIntPredicate p2)
		{
			const string __id = "xor.(Lcom/annimon/stream/function/IntPredicate;Lcom/annimon/stream/function/IntPredicate;)Lcom/annimon/stream/function/IntPredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [1] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIntPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IntPredicate']"
	[Register ("com/annimon/stream/function/IntPredicate", "", "Com.Annimon.Stream.Function.IIntPredicateInvoker")]
	public partial interface IIntPredicate : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IntPredicate']/method[@name='test' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("test", "(I)Z", "GetTest_IHandler:Com.Annimon.Stream.Function.IIntPredicateInvoker, library-lightweight-stream-api")]
		bool Test (int p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/IntPredicate", DoNotGenerateAcw=true)]
	internal partial class IIntPredicateInvoker : global::Java.Lang.Object, IIntPredicate {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IntPredicate", typeof (IIntPredicateInvoker));

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

		public static IIntPredicate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIntPredicate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.IntPredicate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIntPredicateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_test_I;
#pragma warning disable 0169
		static Delegate GetTest_IHandler ()
		{
			if (cb_test_I == null)
				cb_test_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_Test_I);
			return cb_test_I;
		}

		static bool n_Test_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Annimon.Stream.Function.IIntPredicate __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIntPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Test (p0);
		}
#pragma warning restore 0169

		IntPtr id_test_I;
		public unsafe bool Test (int p0)
		{
			if (id_test_I == IntPtr.Zero)
				id_test_I = JNIEnv.GetMethodID (class_ref, "test", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_test_I, __args);
		}

	}

}
