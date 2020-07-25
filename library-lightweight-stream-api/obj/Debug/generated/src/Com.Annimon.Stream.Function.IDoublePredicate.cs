using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='DoublePredicate.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/DoublePredicate$Util", DoNotGenerateAcw=true)]
	public partial class DoublePredicateUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/DoublePredicate$Util", typeof (DoublePredicateUtil));
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

		protected DoublePredicateUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='DoublePredicate.Util']/method[@name='and' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.DoublePredicate'] and parameter[2][@type='com.annimon.stream.function.DoublePredicate']]"
		[Register ("and", "(Lcom/annimon/stream/function/DoublePredicate;Lcom/annimon/stream/function/DoublePredicate;)Lcom/annimon/stream/function/DoublePredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IDoublePredicate And (global::Com.Annimon.Stream.Function.IDoublePredicate p1, global::Com.Annimon.Stream.Function.IDoublePredicate p2)
		{
			const string __id = "and.(Lcom/annimon/stream/function/DoublePredicate;Lcom/annimon/stream/function/DoublePredicate;)Lcom/annimon/stream/function/DoublePredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [1] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IDoublePredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='DoublePredicate.Util']/method[@name='negate' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoublePredicate']]"
		[Register ("negate", "(Lcom/annimon/stream/function/DoublePredicate;)Lcom/annimon/stream/function/DoublePredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IDoublePredicate Negate (global::Com.Annimon.Stream.Function.IDoublePredicate p1)
		{
			const string __id = "negate.(Lcom/annimon/stream/function/DoublePredicate;)Lcom/annimon/stream/function/DoublePredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IDoublePredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='DoublePredicate.Util']/method[@name='or' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.DoublePredicate'] and parameter[2][@type='com.annimon.stream.function.DoublePredicate']]"
		[Register ("or", "(Lcom/annimon/stream/function/DoublePredicate;Lcom/annimon/stream/function/DoublePredicate;)Lcom/annimon/stream/function/DoublePredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IDoublePredicate Or (global::Com.Annimon.Stream.Function.IDoublePredicate p1, global::Com.Annimon.Stream.Function.IDoublePredicate p2)
		{
			const string __id = "or.(Lcom/annimon/stream/function/DoublePredicate;Lcom/annimon/stream/function/DoublePredicate;)Lcom/annimon/stream/function/DoublePredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [1] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IDoublePredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='DoublePredicate.Util']/method[@name='safe' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ThrowableDoublePredicate&lt;java.lang.Throwable&gt;']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableDoublePredicate;)Lcom/annimon/stream/function/DoublePredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IDoublePredicate Safe (global::Com.Annimon.Stream.Function.IThrowableDoublePredicate throwablePredicate)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableDoublePredicate;)Lcom/annimon/stream/function/DoublePredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwablePredicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwablePredicate).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IDoublePredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='DoublePredicate.Util']/method[@name='safe' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.ThrowableDoublePredicate&lt;java.lang.Throwable&gt;'] and parameter[2][@type='boolean']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableDoublePredicate;Z)Lcom/annimon/stream/function/DoublePredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IDoublePredicate Safe (global::Com.Annimon.Stream.Function.IThrowableDoublePredicate throwablePredicate, bool resultIfFailed)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableDoublePredicate;Z)Lcom/annimon/stream/function/DoublePredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwablePredicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwablePredicate).Handle);
				__args [1] = new JniArgumentValue (resultIfFailed);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IDoublePredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='DoublePredicate.Util']/method[@name='xor' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.DoublePredicate'] and parameter[2][@type='com.annimon.stream.function.DoublePredicate']]"
		[Register ("xor", "(Lcom/annimon/stream/function/DoublePredicate;Lcom/annimon/stream/function/DoublePredicate;)Lcom/annimon/stream/function/DoublePredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IDoublePredicate Xor (global::Com.Annimon.Stream.Function.IDoublePredicate p1, global::Com.Annimon.Stream.Function.IDoublePredicate p2)
		{
			const string __id = "xor.(Lcom/annimon/stream/function/DoublePredicate;Lcom/annimon/stream/function/DoublePredicate;)Lcom/annimon/stream/function/DoublePredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [1] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IDoublePredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='DoublePredicate']"
	[Register ("com/annimon/stream/function/DoublePredicate", "", "Com.Annimon.Stream.Function.IDoublePredicateInvoker")]
	public partial interface IDoublePredicate : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='DoublePredicate']/method[@name='test' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("test", "(D)Z", "GetTest_DHandler:Com.Annimon.Stream.Function.IDoublePredicateInvoker, library-lightweight-stream-api")]
		bool Test (double p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/DoublePredicate", DoNotGenerateAcw=true)]
	internal partial class IDoublePredicateInvoker : global::Java.Lang.Object, IDoublePredicate {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/DoublePredicate", typeof (IDoublePredicateInvoker));

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

		public static IDoublePredicate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDoublePredicate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.DoublePredicate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDoublePredicateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_test_D;
#pragma warning disable 0169
		static Delegate GetTest_DHandler ()
		{
			if (cb_test_D == null)
				cb_test_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, bool>) n_Test_D);
			return cb_test_D;
		}

		static bool n_Test_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Annimon.Stream.Function.IDoublePredicate __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IDoublePredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Test (p0);
		}
#pragma warning restore 0169

		IntPtr id_test_D;
		public unsafe bool Test (double p0)
		{
			if (id_test_D == IntPtr.Zero)
				id_test_D = JNIEnv.GetMethodID (class_ref, "test", "(D)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_test_D, __args);
		}

	}

}
