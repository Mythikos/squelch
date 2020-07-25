using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='DoubleToLongFunction']"
	[Register ("com/annimon/stream/function/DoubleToLongFunction", "", "Com.Annimon.Stream.Function.IDoubleToLongFunctionInvoker")]
	public partial interface IDoubleToLongFunction : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='DoubleToLongFunction']/method[@name='applyAsLong' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("applyAsLong", "(D)J", "GetApplyAsLong_DHandler:Com.Annimon.Stream.Function.IDoubleToLongFunctionInvoker, library-lightweight-stream-api")]
		long ApplyAsLong (double p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/DoubleToLongFunction", DoNotGenerateAcw=true)]
	internal partial class IDoubleToLongFunctionInvoker : global::Java.Lang.Object, IDoubleToLongFunction {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/DoubleToLongFunction", typeof (IDoubleToLongFunctionInvoker));

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

		public static IDoubleToLongFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDoubleToLongFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.DoubleToLongFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDoubleToLongFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_applyAsLong_D;
#pragma warning disable 0169
		static Delegate GetApplyAsLong_DHandler ()
		{
			if (cb_applyAsLong_D == null)
				cb_applyAsLong_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, long>) n_ApplyAsLong_D);
			return cb_applyAsLong_D;
		}

		static long n_ApplyAsLong_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Annimon.Stream.Function.IDoubleToLongFunction __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IDoubleToLongFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ApplyAsLong (p0);
		}
#pragma warning restore 0169

		IntPtr id_applyAsLong_D;
		public unsafe long ApplyAsLong (double p0)
		{
			if (id_applyAsLong_D == IntPtr.Zero)
				id_applyAsLong_D = JNIEnv.GetMethodID (class_ref, "applyAsLong", "(D)J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_applyAsLong_D, __args);
		}

	}

}
