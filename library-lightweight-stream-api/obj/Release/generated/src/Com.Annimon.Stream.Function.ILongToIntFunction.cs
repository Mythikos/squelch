using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='LongToIntFunction']"
	[Register ("com/annimon/stream/function/LongToIntFunction", "", "Com.Annimon.Stream.Function.ILongToIntFunctionInvoker")]
	public partial interface ILongToIntFunction : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='LongToIntFunction']/method[@name='applyAsInt' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("applyAsInt", "(J)I", "GetApplyAsInt_JHandler:Com.Annimon.Stream.Function.ILongToIntFunctionInvoker, library-lightweight-stream-api")]
		int ApplyAsInt (long p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/LongToIntFunction", DoNotGenerateAcw=true)]
	internal partial class ILongToIntFunctionInvoker : global::Java.Lang.Object, ILongToIntFunction {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/LongToIntFunction", typeof (ILongToIntFunctionInvoker));

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

		public static ILongToIntFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILongToIntFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.LongToIntFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILongToIntFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_applyAsInt_J;
#pragma warning disable 0169
		static Delegate GetApplyAsInt_JHandler ()
		{
			if (cb_applyAsInt_J == null)
				cb_applyAsInt_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, int>) n_ApplyAsInt_J);
			return cb_applyAsInt_J;
		}

		static int n_ApplyAsInt_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Annimon.Stream.Function.ILongToIntFunction __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ILongToIntFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ApplyAsInt (p0);
		}
#pragma warning restore 0169

		IntPtr id_applyAsInt_J;
		public unsafe int ApplyAsInt (long p0)
		{
			if (id_applyAsInt_J == IntPtr.Zero)
				id_applyAsInt_J = JNIEnv.GetMethodID (class_ref, "applyAsInt", "(J)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_applyAsInt_J, __args);
		}

	}

}
