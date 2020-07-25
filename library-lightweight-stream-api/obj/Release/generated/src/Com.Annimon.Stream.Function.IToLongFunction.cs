using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ToLongFunction']"
	[Register ("com/annimon/stream/function/ToLongFunction", "", "Com.Annimon.Stream.Function.IToLongFunctionInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IToLongFunction : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ToLongFunction']/method[@name='applyAsLong' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("applyAsLong", "(Ljava/lang/Object;)J", "GetApplyAsLong_Ljava_lang_Object_Handler:Com.Annimon.Stream.Function.IToLongFunctionInvoker, library-lightweight-stream-api")]
		long ApplyAsLong (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/ToLongFunction", DoNotGenerateAcw=true)]
	internal partial class IToLongFunctionInvoker : global::Java.Lang.Object, IToLongFunction {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/ToLongFunction", typeof (IToLongFunctionInvoker));

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

		public static IToLongFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IToLongFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.ToLongFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IToLongFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_applyAsLong_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetApplyAsLong_Ljava_lang_Object_Handler ()
		{
			if (cb_applyAsLong_Ljava_lang_Object_ == null)
				cb_applyAsLong_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, long>) n_ApplyAsLong_Ljava_lang_Object_);
			return cb_applyAsLong_Ljava_lang_Object_;
		}

		static long n_ApplyAsLong_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Annimon.Stream.Function.IToLongFunction __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IToLongFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			long __ret = __this.ApplyAsLong (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_applyAsLong_Ljava_lang_Object_;
		public unsafe long ApplyAsLong (global::Java.Lang.Object p0)
		{
			if (id_applyAsLong_Ljava_lang_Object_ == IntPtr.Zero)
				id_applyAsLong_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "applyAsLong", "(Ljava/lang/Object;)J");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			long __ret = JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_applyAsLong_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
