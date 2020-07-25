using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableIntPredicate']"
	[Register ("com/annimon/stream/function/ThrowableIntPredicate", "", "Com.Annimon.Stream.Function.IThrowableIntPredicateInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Throwable"})]
	public partial interface IThrowableIntPredicate : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableIntPredicate']/method[@name='test' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("test", "(I)Z", "GetTest_IHandler:Com.Annimon.Stream.Function.IThrowableIntPredicateInvoker, library-lightweight-stream-api")]
		bool Test (int p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/ThrowableIntPredicate", DoNotGenerateAcw=true)]
	internal partial class IThrowableIntPredicateInvoker : global::Java.Lang.Object, IThrowableIntPredicate {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/ThrowableIntPredicate", typeof (IThrowableIntPredicateInvoker));

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

		public static IThrowableIntPredicate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThrowableIntPredicate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.ThrowableIntPredicate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThrowableIntPredicateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Com.Annimon.Stream.Function.IThrowableIntPredicate __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IThrowableIntPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
