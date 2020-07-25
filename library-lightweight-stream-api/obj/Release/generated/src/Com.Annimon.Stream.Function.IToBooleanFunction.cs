using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ToBooleanFunction']"
	[Register ("com/annimon/stream/function/ToBooleanFunction", "", "Com.Annimon.Stream.Function.IToBooleanFunctionInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IToBooleanFunction : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ToBooleanFunction']/method[@name='applyAsBoolean' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("applyAsBoolean", "(Ljava/lang/Object;)Z", "GetApplyAsBoolean_Ljava_lang_Object_Handler:Com.Annimon.Stream.Function.IToBooleanFunctionInvoker, library-lightweight-stream-api")]
		bool ApplyAsBoolean (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/ToBooleanFunction", DoNotGenerateAcw=true)]
	internal partial class IToBooleanFunctionInvoker : global::Java.Lang.Object, IToBooleanFunction {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/ToBooleanFunction", typeof (IToBooleanFunctionInvoker));

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

		public static IToBooleanFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IToBooleanFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.ToBooleanFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IToBooleanFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_applyAsBoolean_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetApplyAsBoolean_Ljava_lang_Object_Handler ()
		{
			if (cb_applyAsBoolean_Ljava_lang_Object_ == null)
				cb_applyAsBoolean_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ApplyAsBoolean_Ljava_lang_Object_);
			return cb_applyAsBoolean_Ljava_lang_Object_;
		}

		static bool n_ApplyAsBoolean_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Annimon.Stream.Function.IToBooleanFunction __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IToBooleanFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ApplyAsBoolean (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_applyAsBoolean_Ljava_lang_Object_;
		public unsafe bool ApplyAsBoolean (global::Java.Lang.Object p0)
		{
			if (id_applyAsBoolean_Ljava_lang_Object_ == IntPtr.Zero)
				id_applyAsBoolean_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "applyAsBoolean", "(Ljava/lang/Object;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_applyAsBoolean_Ljava_lang_Object_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
