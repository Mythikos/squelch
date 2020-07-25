using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='LongPredicate.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/LongPredicate$Util", DoNotGenerateAcw=true)]
	public partial class LongPredicateUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/LongPredicate$Util", typeof (LongPredicateUtil));
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

		protected LongPredicateUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='LongPredicate.Util']/method[@name='and' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.LongPredicate'] and parameter[2][@type='com.annimon.stream.function.LongPredicate']]"
		[Register ("and", "(Lcom/annimon/stream/function/LongPredicate;Lcom/annimon/stream/function/LongPredicate;)Lcom/annimon/stream/function/LongPredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.ILongPredicate And (global::Com.Annimon.Stream.Function.ILongPredicate p1, global::Com.Annimon.Stream.Function.ILongPredicate p2)
		{
			const string __id = "and.(Lcom/annimon/stream/function/LongPredicate;Lcom/annimon/stream/function/LongPredicate;)Lcom/annimon/stream/function/LongPredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [1] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ILongPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='LongPredicate.Util']/method[@name='negate' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongPredicate']]"
		[Register ("negate", "(Lcom/annimon/stream/function/LongPredicate;)Lcom/annimon/stream/function/LongPredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.ILongPredicate Negate (global::Com.Annimon.Stream.Function.ILongPredicate p1)
		{
			const string __id = "negate.(Lcom/annimon/stream/function/LongPredicate;)Lcom/annimon/stream/function/LongPredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ILongPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='LongPredicate.Util']/method[@name='or' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.LongPredicate'] and parameter[2][@type='com.annimon.stream.function.LongPredicate']]"
		[Register ("or", "(Lcom/annimon/stream/function/LongPredicate;Lcom/annimon/stream/function/LongPredicate;)Lcom/annimon/stream/function/LongPredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.ILongPredicate Or (global::Com.Annimon.Stream.Function.ILongPredicate p1, global::Com.Annimon.Stream.Function.ILongPredicate p2)
		{
			const string __id = "or.(Lcom/annimon/stream/function/LongPredicate;Lcom/annimon/stream/function/LongPredicate;)Lcom/annimon/stream/function/LongPredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [1] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ILongPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='LongPredicate.Util']/method[@name='safe' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ThrowableLongPredicate&lt;java.lang.Throwable&gt;']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableLongPredicate;)Lcom/annimon/stream/function/LongPredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.ILongPredicate Safe (global::Com.Annimon.Stream.Function.IThrowableLongPredicate throwablePredicate)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableLongPredicate;)Lcom/annimon/stream/function/LongPredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwablePredicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwablePredicate).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ILongPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='LongPredicate.Util']/method[@name='safe' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.ThrowableLongPredicate&lt;java.lang.Throwable&gt;'] and parameter[2][@type='boolean']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableLongPredicate;Z)Lcom/annimon/stream/function/LongPredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.ILongPredicate Safe (global::Com.Annimon.Stream.Function.IThrowableLongPredicate throwablePredicate, bool resultIfFailed)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableLongPredicate;Z)Lcom/annimon/stream/function/LongPredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwablePredicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwablePredicate).Handle);
				__args [1] = new JniArgumentValue (resultIfFailed);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ILongPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='LongPredicate.Util']/method[@name='xor' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.LongPredicate'] and parameter[2][@type='com.annimon.stream.function.LongPredicate']]"
		[Register ("xor", "(Lcom/annimon/stream/function/LongPredicate;Lcom/annimon/stream/function/LongPredicate;)Lcom/annimon/stream/function/LongPredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.ILongPredicate Xor (global::Com.Annimon.Stream.Function.ILongPredicate p1, global::Com.Annimon.Stream.Function.ILongPredicate p2)
		{
			const string __id = "xor.(Lcom/annimon/stream/function/LongPredicate;Lcom/annimon/stream/function/LongPredicate;)Lcom/annimon/stream/function/LongPredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [1] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ILongPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='LongPredicate']"
	[Register ("com/annimon/stream/function/LongPredicate", "", "Com.Annimon.Stream.Function.ILongPredicateInvoker")]
	public partial interface ILongPredicate : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='LongPredicate']/method[@name='test' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("test", "(J)Z", "GetTest_JHandler:Com.Annimon.Stream.Function.ILongPredicateInvoker, library-lightweight-stream-api")]
		bool Test (long p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/LongPredicate", DoNotGenerateAcw=true)]
	internal partial class ILongPredicateInvoker : global::Java.Lang.Object, ILongPredicate {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/LongPredicate", typeof (ILongPredicateInvoker));

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

		public static ILongPredicate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILongPredicate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.LongPredicate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILongPredicateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_test_J;
#pragma warning disable 0169
		static Delegate GetTest_JHandler ()
		{
			if (cb_test_J == null)
				cb_test_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, bool>) n_Test_J);
			return cb_test_J;
		}

		static bool n_Test_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Annimon.Stream.Function.ILongPredicate __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ILongPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Test (p0);
		}
#pragma warning restore 0169

		IntPtr id_test_J;
		public unsafe bool Test (long p0)
		{
			if (id_test_J == IntPtr.Zero)
				id_test_J = JNIEnv.GetMethodID (class_ref, "test", "(J)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_test_J, __args);
		}

	}

}
