using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableIntSupplier']"
	[Register ("com/annimon/stream/function/ThrowableIntSupplier", "", "Com.Annimon.Stream.Function.IThrowableIntSupplierInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Throwable"})]
	public partial interface IThrowableIntSupplier : IJavaObject, IJavaPeerable {

		int AsInt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableIntSupplier']/method[@name='getAsInt' and count(parameter)=0]"
			[Register ("getAsInt", "()I", "GetGetAsIntHandler:Com.Annimon.Stream.Function.IThrowableIntSupplierInvoker, library-lightweight-stream-api")] get;
		}

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/ThrowableIntSupplier", DoNotGenerateAcw=true)]
	internal partial class IThrowableIntSupplierInvoker : global::Java.Lang.Object, IThrowableIntSupplier {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/ThrowableIntSupplier", typeof (IThrowableIntSupplierInvoker));

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

		public static IThrowableIntSupplier GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThrowableIntSupplier> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.ThrowableIntSupplier"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThrowableIntSupplierInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAsInt;
#pragma warning disable 0169
		static Delegate GetGetAsIntHandler ()
		{
			if (cb_getAsInt == null)
				cb_getAsInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetAsInt);
			return cb_getAsInt;
		}

		static int n_GetAsInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Function.IThrowableIntSupplier __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IThrowableIntSupplier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsInt;
		}
#pragma warning restore 0169

		IntPtr id_getAsInt;
		public unsafe int AsInt {
			get {
				if (id_getAsInt == IntPtr.Zero)
					id_getAsInt = JNIEnv.GetMethodID (class_ref, "getAsInt", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getAsInt);
			}
		}

	}

}
