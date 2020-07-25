using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='LongSupplier.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/LongSupplier$Util", DoNotGenerateAcw=true)]
	public partial class LongSupplierUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/LongSupplier$Util", typeof (LongSupplierUtil));
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

		protected LongSupplierUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='LongSupplier.Util']/method[@name='safe' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ThrowableLongSupplier&lt;java.lang.Throwable&gt;']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableLongSupplier;)Lcom/annimon/stream/function/LongSupplier;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.ILongSupplier Safe (global::Com.Annimon.Stream.Function.IThrowableLongSupplier throwableSupplier)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableLongSupplier;)Lcom/annimon/stream/function/LongSupplier;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwableSupplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwableSupplier).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ILongSupplier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='LongSupplier.Util']/method[@name='safe' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.ThrowableLongSupplier&lt;java.lang.Throwable&gt;'] and parameter[2][@type='long']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableLongSupplier;J)Lcom/annimon/stream/function/LongSupplier;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.ILongSupplier Safe (global::Com.Annimon.Stream.Function.IThrowableLongSupplier throwableSupplier, long resultIfFailed)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableLongSupplier;J)Lcom/annimon/stream/function/LongSupplier;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwableSupplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwableSupplier).Handle);
				__args [1] = new JniArgumentValue (resultIfFailed);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ILongSupplier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='LongSupplier']"
	[Register ("com/annimon/stream/function/LongSupplier", "", "Com.Annimon.Stream.Function.ILongSupplierInvoker")]
	public partial interface ILongSupplier : IJavaObject, IJavaPeerable {

		long AsLong {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='LongSupplier']/method[@name='getAsLong' and count(parameter)=0]"
			[Register ("getAsLong", "()J", "GetGetAsLongHandler:Com.Annimon.Stream.Function.ILongSupplierInvoker, library-lightweight-stream-api")] get;
		}

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/LongSupplier", DoNotGenerateAcw=true)]
	internal partial class ILongSupplierInvoker : global::Java.Lang.Object, ILongSupplier {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/LongSupplier", typeof (ILongSupplierInvoker));

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

		public static ILongSupplier GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILongSupplier> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.LongSupplier"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILongSupplierInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Com.Annimon.Stream.Function.ILongSupplier __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ILongSupplier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
