using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='DoubleSupplier.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/DoubleSupplier$Util", DoNotGenerateAcw=true)]
	public partial class DoubleSupplierUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/DoubleSupplier$Util", typeof (DoubleSupplierUtil));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected DoubleSupplierUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='DoubleSupplier.Util']/method[@name='safe' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ThrowableDoubleSupplier&lt;java.lang.Throwable&gt;']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableDoubleSupplier;)Lcom/annimon/stream/function/DoubleSupplier;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IDoubleSupplier Safe (global::Com.Annimon.Stream.Function.IThrowableDoubleSupplier throwableSupplier)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableDoubleSupplier;)Lcom/annimon/stream/function/DoubleSupplier;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwableSupplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwableSupplier).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IDoubleSupplier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='DoubleSupplier.Util']/method[@name='safe' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.ThrowableDoubleSupplier&lt;java.lang.Throwable&gt;'] and parameter[2][@type='double']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableDoubleSupplier;D)Lcom/annimon/stream/function/DoubleSupplier;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IDoubleSupplier Safe (global::Com.Annimon.Stream.Function.IThrowableDoubleSupplier throwableSupplier, double resultIfFailed)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableDoubleSupplier;D)Lcom/annimon/stream/function/DoubleSupplier;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwableSupplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwableSupplier).Handle);
				__args [1] = new JniArgumentValue (resultIfFailed);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IDoubleSupplier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='DoubleSupplier']"
	[Register ("com/annimon/stream/function/DoubleSupplier", "", "Com.Annimon.Stream.Function.IDoubleSupplierInvoker")]
	public partial interface IDoubleSupplier : IJavaObject, IJavaPeerable {

		double AsDouble {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='DoubleSupplier']/method[@name='getAsDouble' and count(parameter)=0]"
			[Register ("getAsDouble", "()D", "GetGetAsDoubleHandler:Com.Annimon.Stream.Function.IDoubleSupplierInvoker, library-lightweight-stream-api")] get;
		}

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/DoubleSupplier", DoNotGenerateAcw=true)]
	internal partial class IDoubleSupplierInvoker : global::Java.Lang.Object, IDoubleSupplier {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/DoubleSupplier", typeof (IDoubleSupplierInvoker));

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

		public static IDoubleSupplier GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDoubleSupplier> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.DoubleSupplier"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDoubleSupplierInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Com.Annimon.Stream.Function.IDoubleSupplier __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IDoubleSupplier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
