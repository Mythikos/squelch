using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableLongSupplier']"
	[Register ("com/annimon/stream/function/ThrowableLongSupplier", "", "Com.Annimon.Stream.Function.IThrowableLongSupplierInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Throwable"})]
	public partial interface IThrowableLongSupplier : IJavaObject, IJavaPeerable {

		long AsLong {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableLongSupplier']/method[@name='getAsLong' and count(parameter)=0]"
			[Register ("getAsLong", "()J", "GetGetAsLongHandler:Com.Annimon.Stream.Function.IThrowableLongSupplierInvoker, library-lightweight-stream-api")] get;
		}

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/ThrowableLongSupplier", DoNotGenerateAcw=true)]
	internal partial class IThrowableLongSupplierInvoker : global::Java.Lang.Object, IThrowableLongSupplier {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/ThrowableLongSupplier", typeof (IThrowableLongSupplierInvoker));

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

		public static IThrowableLongSupplier GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThrowableLongSupplier> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.ThrowableLongSupplier"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThrowableLongSupplierInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAsLong;
#pragma warning disable 0169
		static Delegate GetGetAsLongHandler ()
		{
			if (cb_getAsLong == null)
				cb_getAsLong = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_GetAsLong);
			return cb_getAsLong;
		}

		static long n_GetAsLong (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Function.IThrowableLongSupplier __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IThrowableLongSupplier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsLong;
		}
#pragma warning restore 0169

		IntPtr id_getAsLong;
		public unsafe long AsLong {
			get {
				if (id_getAsLong == IntPtr.Zero)
					id_getAsLong = JNIEnv.GetMethodID (class_ref, "getAsLong", "()J");
				return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_getAsLong);
			}
		}

	}

}
