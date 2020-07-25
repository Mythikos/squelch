using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IntToLongFunction']"
	[Register ("com/annimon/stream/function/IntToLongFunction", "", "Com.Annimon.Stream.Function.IIntToLongFunctionInvoker")]
	public partial interface IIntToLongFunction : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IntToLongFunction']/method[@name='applyAsLong' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("applyAsLong", "(I)J", "GetApplyAsLong_IHandler:Com.Annimon.Stream.Function.IIntToLongFunctionInvoker, library-lightweight-stream-api")]
		long ApplyAsLong (int p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/IntToLongFunction", DoNotGenerateAcw=true)]
	internal partial class IIntToLongFunctionInvoker : global::Java.Lang.Object, IIntToLongFunction {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IntToLongFunction", typeof (IIntToLongFunctionInvoker));

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

		public static IIntToLongFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIntToLongFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.IntToLongFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIntToLongFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_applyAsLong_I;
#pragma warning disable 0169
		static Delegate GetApplyAsLong_IHandler ()
		{
			if (cb_applyAsLong_I == null)
				cb_applyAsLong_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, long>) n_ApplyAsLong_I);
			return cb_applyAsLong_I;
		}

		static long n_ApplyAsLong_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Annimon.Stream.Function.IIntToLongFunction __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIntToLongFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ApplyAsLong (p0);
		}
#pragma warning restore 0169

		IntPtr id_applyAsLong_I;
		public unsafe long ApplyAsLong (int p0)
		{
			if (id_applyAsLong_I == IntPtr.Zero)
				id_applyAsLong_I = JNIEnv.GetMethodID (class_ref, "applyAsLong", "(I)J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_applyAsLong_I, __args);
		}

	}

}
