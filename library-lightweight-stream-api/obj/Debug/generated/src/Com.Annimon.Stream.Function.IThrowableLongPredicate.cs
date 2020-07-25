using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableLongPredicate']"
	[Register ("com/annimon/stream/function/ThrowableLongPredicate", "", "Com.Annimon.Stream.Function.IThrowableLongPredicateInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Throwable"})]
	public partial interface IThrowableLongPredicate : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableLongPredicate']/method[@name='test' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("test", "(J)Z", "GetTest_JHandler:Com.Annimon.Stream.Function.IThrowableLongPredicateInvoker, library-lightweight-stream-api")]
		bool Test (long p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/ThrowableLongPredicate", DoNotGenerateAcw=true)]
	internal partial class IThrowableLongPredicateInvoker : global::Java.Lang.Object, IThrowableLongPredicate {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/ThrowableLongPredicate", typeof (IThrowableLongPredicateInvoker));

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

		public static IThrowableLongPredicate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThrowableLongPredicate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.ThrowableLongPredicate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThrowableLongPredicateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Com.Annimon.Stream.Function.IThrowableLongPredicate __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IThrowableLongPredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
