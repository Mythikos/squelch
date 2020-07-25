using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IntToDoubleFunction']"
	[Register ("com/annimon/stream/function/IntToDoubleFunction", "", "Com.Annimon.Stream.Function.IIntToDoubleFunctionInvoker")]
	public partial interface IIntToDoubleFunction : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IntToDoubleFunction']/method[@name='applyAsDouble' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("applyAsDouble", "(I)D", "GetApplyAsDouble_IHandler:Com.Annimon.Stream.Function.IIntToDoubleFunctionInvoker, library-lightweight-stream-api")]
		double ApplyAsDouble (int p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/IntToDoubleFunction", DoNotGenerateAcw=true)]
	internal partial class IIntToDoubleFunctionInvoker : global::Java.Lang.Object, IIntToDoubleFunction {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IntToDoubleFunction", typeof (IIntToDoubleFunctionInvoker));

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

		public static IIntToDoubleFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIntToDoubleFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.IntToDoubleFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIntToDoubleFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_applyAsDouble_I;
#pragma warning disable 0169
		static Delegate GetApplyAsDouble_IHandler ()
		{
			if (cb_applyAsDouble_I == null)
				cb_applyAsDouble_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double>) n_ApplyAsDouble_I);
			return cb_applyAsDouble_I;
		}

		static double n_ApplyAsDouble_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Annimon.Stream.Function.IIntToDoubleFunction __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIntToDoubleFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ApplyAsDouble (p0);
		}
#pragma warning restore 0169

		IntPtr id_applyAsDouble_I;
		public unsafe double ApplyAsDouble (int p0)
		{
			if (id_applyAsDouble_I == IntPtr.Zero)
				id_applyAsDouble_I = JNIEnv.GetMethodID (class_ref, "applyAsDouble", "(I)D");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_applyAsDouble_I, __args);
		}

	}

}
