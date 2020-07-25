using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='DoubleToIntFunction']"
	[Register ("com/annimon/stream/function/DoubleToIntFunction", "", "Com.Annimon.Stream.Function.IDoubleToIntFunctionInvoker")]
	public partial interface IDoubleToIntFunction : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='DoubleToIntFunction']/method[@name='applyAsInt' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("applyAsInt", "(D)I", "GetApplyAsInt_DHandler:Com.Annimon.Stream.Function.IDoubleToIntFunctionInvoker, library-lightweight-stream-api")]
		int ApplyAsInt (double p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/DoubleToIntFunction", DoNotGenerateAcw=true)]
	internal partial class IDoubleToIntFunctionInvoker : global::Java.Lang.Object, IDoubleToIntFunction {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/DoubleToIntFunction", typeof (IDoubleToIntFunctionInvoker));

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

		public static IDoubleToIntFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDoubleToIntFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.DoubleToIntFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDoubleToIntFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_applyAsInt_D;
#pragma warning disable 0169
		static Delegate GetApplyAsInt_DHandler ()
		{
			if (cb_applyAsInt_D == null)
				cb_applyAsInt_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, int>) n_ApplyAsInt_D);
			return cb_applyAsInt_D;
		}

		static int n_ApplyAsInt_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Annimon.Stream.Function.IDoubleToIntFunction __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IDoubleToIntFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ApplyAsInt (p0);
		}
#pragma warning restore 0169

		IntPtr id_applyAsInt_D;
		public unsafe int ApplyAsInt (double p0)
		{
			if (id_applyAsInt_D == IntPtr.Zero)
				id_applyAsInt_D = JNIEnv.GetMethodID (class_ref, "applyAsInt", "(D)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_applyAsInt_D, __args);
		}

	}

}
