using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='BooleanPredicate.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/BooleanPredicate$Util", DoNotGenerateAcw=true)]
	public partial class BooleanPredicateUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/BooleanPredicate$Util", typeof (BooleanPredicateUtil));
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

		protected BooleanPredicateUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='BooleanPredicate.Util']/method[@name='and' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.BooleanPredicate'] and parameter[2][@type='com.annimon.stream.function.BooleanPredicate']]"
		[Register ("and", "(Lcom/annimon/stream/function/BooleanPredicate;Lcom/annimon/stream/function/BooleanPredicate;)Lcom/annimon/stream/function/BooleanPredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IBooleanPredicate And (global::Com.Annimon.Stream.Function.IBooleanPredicate p1, global::Com.Annimon.Stream.Function.IBooleanPredicate p2)
		{
			const string __id = "and.(Lcom/annimon/stream/function/BooleanPredicate;Lcom/annimon/stream/function/BooleanPredicate;)Lcom/annimon/stream/function/BooleanPredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [1] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IBooleanPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='BooleanPredicate.Util']/method[@name='identity' and count(parameter)=0]"
		[Register ("identity", "()Lcom/annimon/stream/function/BooleanPredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IBooleanPredicate Identity ()
		{
			const string __id = "identity.()Lcom/annimon/stream/function/BooleanPredicate;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IBooleanPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='BooleanPredicate.Util']/method[@name='negate' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.BooleanPredicate']]"
		[Register ("negate", "(Lcom/annimon/stream/function/BooleanPredicate;)Lcom/annimon/stream/function/BooleanPredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IBooleanPredicate Negate (global::Com.Annimon.Stream.Function.IBooleanPredicate p1)
		{
			const string __id = "negate.(Lcom/annimon/stream/function/BooleanPredicate;)Lcom/annimon/stream/function/BooleanPredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IBooleanPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='BooleanPredicate.Util']/method[@name='or' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.BooleanPredicate'] and parameter[2][@type='com.annimon.stream.function.BooleanPredicate']]"
		[Register ("or", "(Lcom/annimon/stream/function/BooleanPredicate;Lcom/annimon/stream/function/BooleanPredicate;)Lcom/annimon/stream/function/BooleanPredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IBooleanPredicate Or (global::Com.Annimon.Stream.Function.IBooleanPredicate p1, global::Com.Annimon.Stream.Function.IBooleanPredicate p2)
		{
			const string __id = "or.(Lcom/annimon/stream/function/BooleanPredicate;Lcom/annimon/stream/function/BooleanPredicate;)Lcom/annimon/stream/function/BooleanPredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [1] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IBooleanPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='BooleanPredicate.Util']/method[@name='xor' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.BooleanPredicate'] and parameter[2][@type='com.annimon.stream.function.BooleanPredicate']]"
		[Register ("xor", "(Lcom/annimon/stream/function/BooleanPredicate;Lcom/annimon/stream/function/BooleanPredicate;)Lcom/annimon/stream/function/BooleanPredicate;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IBooleanPredicate Xor (global::Com.Annimon.Stream.Function.IBooleanPredicate p1, global::Com.Annimon.Stream.Function.IBooleanPredicate p2)
		{
			const string __id = "xor.(Lcom/annimon/stream/function/BooleanPredicate;Lcom/annimon/stream/function/BooleanPredicate;)Lcom/annimon/stream/function/BooleanPredicate;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p1).Handle);
				__args [1] = new JniArgumentValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IBooleanPredicate> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='BooleanPredicate']"
	[Register ("com/annimon/stream/function/BooleanPredicate", "", "Com.Annimon.Stream.Function.IBooleanPredicateInvoker")]
	public partial interface IBooleanPredicate : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='BooleanPredicate']/method[@name='test' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("test", "(Z)Z", "GetTest_ZHandler:Com.Annimon.Stream.Function.IBooleanPredicateInvoker, library-lightweight-stream-api")]
		bool Test (bool p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/BooleanPredicate", DoNotGenerateAcw=true)]
	internal partial class IBooleanPredicateInvoker : global::Java.Lang.Object, IBooleanPredicate {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/BooleanPredicate", typeof (IBooleanPredicateInvoker));

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

		public static IBooleanPredicate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBooleanPredicate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.BooleanPredicate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBooleanPredicateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_test_Z;
#pragma warning disable 0169
		static Delegate GetTest_ZHandler ()
		{
			if (cb_test_Z == null)
				cb_test_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, bool>) n_Test_Z);
			return cb_test_Z;
		}

		static bool n_Test_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Annimon.Stream.Function.IBooleanPredicate __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IBooleanPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Test (p0);
		}
#pragma warning restore 0169

		IntPtr id_test_Z;
		public unsafe bool Test (bool p0)
		{
			if (id_test_Z == IntPtr.Zero)
				id_test_Z = JNIEnv.GetMethodID (class_ref, "test", "(Z)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_test_Z, __args);
		}

	}

}
