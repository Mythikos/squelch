using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableDoubleSupplier']"
	[Register ("com/annimon/stream/function/ThrowableDoubleSupplier", "", "Com.Annimon.Stream.Function.IThrowableDoubleSupplierInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Throwable"})]
	public partial interface IThrowableDoubleSupplier : IJavaObject, IJavaPeerable {

		double AsDouble {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='ThrowableDoubleSupplier']/method[@name='getAsDouble' and count(parameter)=0]"
			[Register ("getAsDouble", "()D", "GetGetAsDoubleHandler:Com.Annimon.Stream.Function.IThrowableDoubleSupplierInvoker, library-lightweight-stream-api")] get;
		}

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/ThrowableDoubleSupplier", DoNotGenerateAcw=true)]
	internal partial class IThrowableDoubleSupplierInvoker : global::Java.Lang.Object, IThrowableDoubleSupplier {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/ThrowableDoubleSupplier", typeof (IThrowableDoubleSupplierInvoker));

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

		public static IThrowableDoubleSupplier GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IThrowableDoubleSupplier> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.ThrowableDoubleSupplier"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IThrowableDoubleSupplierInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAsDouble;
#pragma warning disable 0169
		static Delegate GetGetAsDoubleHandler ()
		{
			if (cb_getAsDouble == null)
				cb_getAsDouble = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_GetAsDouble);
			return cb_getAsDouble;
		}

		static double n_GetAsDouble (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Function.IThrowableDoubleSupplier __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IThrowableDoubleSupplier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AsDouble;
		}
#pragma warning restore 0169

		IntPtr id_getAsDouble;
		public unsafe double AsDouble {
			get {
				if (id_getAsDouble == IntPtr.Zero)
					id_getAsDouble = JNIEnv.GetMethodID (class_ref, "getAsDouble", "()D");
				return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_getAsDouble);
			}
		}

	}

}
