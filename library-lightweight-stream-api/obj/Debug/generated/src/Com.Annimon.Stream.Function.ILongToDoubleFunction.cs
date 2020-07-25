using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='LongToDoubleFunction']"
	[Register ("com/annimon/stream/function/LongToDoubleFunction", "", "Com.Annimon.Stream.Function.ILongToDoubleFunctionInvoker")]
	public partial interface ILongToDoubleFunction : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='LongToDoubleFunction']/method[@name='applyAsDouble' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("applyAsDouble", "(J)D", "GetApplyAsDouble_JHandler:Com.Annimon.Stream.Function.ILongToDoubleFunctionInvoker, library-lightweight-stream-api")]
		double ApplyAsDouble (long p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/LongToDoubleFunction", DoNotGenerateAcw=true)]
	internal partial class ILongToDoubleFunctionInvoker : global::Java.Lang.Object, ILongToDoubleFunction {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/LongToDoubleFunction", typeof (ILongToDoubleFunctionInvoker));

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

		public static ILongToDoubleFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILongToDoubleFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.LongToDoubleFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILongToDoubleFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_applyAsDouble_J;
#pragma warning disable 0169
		static Delegate GetApplyAsDouble_JHandler ()
		{
			if (cb_applyAsDouble_J == null)
				cb_applyAsDouble_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, double>) n_ApplyAsDouble_J);
			return cb_applyAsDouble_J;
		}

		static double n_ApplyAsDouble_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Annimon.Stream.Function.ILongToDoubleFunction __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ILongToDoubleFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ApplyAsDouble (p0);
		}
#pragma warning restore 0169

		IntPtr id_applyAsDouble_J;
		public unsafe double ApplyAsDouble (long p0)
		{
			if (id_applyAsDouble_J == IntPtr.Zero)
				id_applyAsDouble_J = JNIEnv.GetMethodID (class_ref, "applyAsDouble", "(J)D");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_applyAsDouble_J, __args);
		}

	}

}
