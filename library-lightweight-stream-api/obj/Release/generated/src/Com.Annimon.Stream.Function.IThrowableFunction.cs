using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableFunction']"
	[Register ("com/annimon/stream/function/ThrowableFunction", "", "Com.Annimon.Stream.Function.IThrowableFunctionInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"I", "R", "E extends java.lang.Throwable"})]
	public partial interface IThrowableFunction : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableFunction']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='I']]"
		[Register ("apply", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetApply_Ljava_lang_Object_Handler:Com.Annimon.Stream.Function.IThrowableFunctionInvoker, library-lightweight-stream-api")]
		global::Java.Lang.Object Apply (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/ThrowableFunction", DoNotGenerateAcw=true)]
	internal partial class IThrowableFunctionInvoker : global::Java.Lang.Object, IThrowableFunction {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/ThrowableFunction", typeof (IThrowableFunctionInvoker));

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

		public static IThrowableFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThrowableFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.ThrowableFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThrowableFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_apply_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetApply_Ljava_lang_Object_Handler ()
		{
			if (cb_apply_Ljava_lang_Object_ == null)
				cb_apply_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Apply_Ljava_lang_Object_);
			return cb_apply_Ljava_lang_Object_;
		}

		static IntPtr n_Apply_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Annimon.Stream.Function.IThrowableFunction __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IThrowableFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Apply (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_apply_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Apply (global::Java.Lang.Object p0)
		{
			if (id_apply_Ljava_lang_Object_ == IntPtr.Zero)
				id_apply_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "apply", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
