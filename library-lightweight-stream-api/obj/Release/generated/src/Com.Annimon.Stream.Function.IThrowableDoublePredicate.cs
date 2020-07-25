using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableDoublePredicate']"
	[Register ("com/annimon/stream/function/ThrowableDoublePredicate", "", "Com.Annimon.Stream.Function.IThrowableDoublePredicateInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Throwable"})]
	public partial interface IThrowableDoublePredicate : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableDoublePredicate']/method[@name='test' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("test", "(D)Z", "GetTest_DHandler:Com.Annimon.Stream.Function.IThrowableDoublePredicateInvoker, library-lightweight-stream-api")]
		bool Test (double p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/ThrowableDoublePredicate", DoNotGenerateAcw=true)]
	internal partial class IThrowableDoublePredicateInvoker : global::Java.Lang.Object, IThrowableDoublePredicate {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/ThrowableDoublePredicate", typeof (IThrowableDoublePredicateInvoker));

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

		public static IThrowableDoublePredicate GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThrowableDoublePredicate> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.ThrowableDoublePredicate"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThrowableDoublePredicateInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Com.Annimon.Stream.Function.IThrowableDoublePredicate __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IThrowableDoublePredicate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
