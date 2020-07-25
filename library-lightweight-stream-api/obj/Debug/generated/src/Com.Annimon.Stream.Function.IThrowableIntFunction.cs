using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableIntFunction']"
	[Register ("com/annimon/stream/function/ThrowableIntFunction", "", "Com.Annimon.Stream.Function.IThrowableIntFunctionInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R", "E extends java.lang.Throwable"})]
	public partial interface IThrowableIntFunction : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableIntFunction']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("apply", "(I)Ljava/lang/Object;", "GetApply_IHandler:Com.Annimon.Stream.Function.IThrowableIntFunctionInvoker, library-lightweight-stream-api")]
		global::Java.Lang.Object Apply (int p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/ThrowableIntFunction", DoNotGenerateAcw=true)]
	internal partial class IThrowableIntFunctionInvoker : global::Java.Lang.Object, IThrowableIntFunction {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/ThrowableIntFunction", typeof (IThrowableIntFunctionInvoker));

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

		public static IThrowableIntFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThrowableIntFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.ThrowableIntFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThrowableIntFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_apply_I;
#pragma warning disable 0169
		static Delegate GetApply_IHandler ()
		{
			if (cb_apply_I == null)
				cb_apply_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Apply_I);
			return cb_apply_I;
		}

		static IntPtr n_Apply_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Annimon.Stream.Function.IThrowableIntFunction __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IThrowableIntFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Apply (p0));
		}
#pragma warning restore 0169

		IntPtr id_apply_I;
		public unsafe global::Java.Lang.Object Apply (int p0)
		{
			if (id_apply_I == IntPtr.Zero)
				id_apply_I = JNIEnv.GetMethodID (class_ref, "apply", "(I)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_I, __args), JniHandleOwnership.TransferLocalRef);
		}

	}

}
