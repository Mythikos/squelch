using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableLongFunction']"
	[Register ("com/annimon/stream/function/ThrowableLongFunction", "", "Com.Annimon.Stream.Function.IThrowableLongFunctionInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R", "E extends java.lang.Throwable"})]
	public partial interface IThrowableLongFunction : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableLongFunction']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("apply", "(J)Ljava/lang/Object;", "GetApply_JHandler:Com.Annimon.Stream.Function.IThrowableLongFunctionInvoker, library-lightweight-stream-api")]
		global::Java.Lang.Object Apply (long p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/ThrowableLongFunction", DoNotGenerateAcw=true)]
	internal partial class IThrowableLongFunctionInvoker : global::Java.Lang.Object, IThrowableLongFunction {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/ThrowableLongFunction", typeof (IThrowableLongFunctionInvoker));

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

		public static IThrowableLongFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThrowableLongFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.ThrowableLongFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThrowableLongFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_apply_J;
#pragma warning disable 0169
		static Delegate GetApply_JHandler ()
		{
			if (cb_apply_J == null)
				cb_apply_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_Apply_J);
			return cb_apply_J;
		}

		static IntPtr n_Apply_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Annimon.Stream.Function.IThrowableLongFunction __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IThrowableLongFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Apply (p0));
		}
#pragma warning restore 0169

		IntPtr id_apply_J;
		public unsafe global::Java.Lang.Object Apply (long p0)
		{
			if (id_apply_J == IntPtr.Zero)
				id_apply_J = JNIEnv.GetMethodID (class_ref, "apply", "(J)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_J, __args), JniHandleOwnership.TransferLocalRef);
		}

	}

}
