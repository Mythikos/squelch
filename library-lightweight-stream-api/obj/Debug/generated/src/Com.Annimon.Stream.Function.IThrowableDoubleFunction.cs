using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableDoubleFunction']"
	[Register ("com/annimon/stream/function/ThrowableDoubleFunction", "", "Com.Annimon.Stream.Function.IThrowableDoubleFunctionInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R", "E extends java.lang.Throwable"})]
	public partial interface IThrowableDoubleFunction : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableDoubleFunction']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("apply", "(D)Ljava/lang/Object;", "GetApply_DHandler:Com.Annimon.Stream.Function.IThrowableDoubleFunctionInvoker, library-lightweight-stream-api")]
		global::Java.Lang.Object Apply (double p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/ThrowableDoubleFunction", DoNotGenerateAcw=true)]
	internal partial class IThrowableDoubleFunctionInvoker : global::Java.Lang.Object, IThrowableDoubleFunction {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/ThrowableDoubleFunction", typeof (IThrowableDoubleFunctionInvoker));

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

		public static IThrowableDoubleFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThrowableDoubleFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.ThrowableDoubleFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThrowableDoubleFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_apply_D;
#pragma warning disable 0169
		static Delegate GetApply_DHandler ()
		{
			if (cb_apply_D == null)
				cb_apply_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_Apply_D);
			return cb_apply_D;
		}

		static IntPtr n_Apply_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Annimon.Stream.Function.IThrowableDoubleFunction __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IThrowableDoubleFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Apply (p0));
		}
#pragma warning restore 0169

		IntPtr id_apply_D;
		public unsafe global::Java.Lang.Object Apply (double p0)
		{
			if (id_apply_D == IntPtr.Zero)
				id_apply_D = JNIEnv.GetMethodID (class_ref, "apply", "(D)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_D, __args), JniHandleOwnership.TransferLocalRef);
		}

	}

}
