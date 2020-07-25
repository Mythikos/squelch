using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IntSupplier.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/IntSupplier$Util", DoNotGenerateAcw=true)]
	public partial class IntSupplierUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IntSupplier$Util", typeof (IntSupplierUtil));
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

		protected IntSupplierUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IntSupplier.Util']/method[@name='safe' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ThrowableIntSupplier&lt;java.lang.Throwable&gt;']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableIntSupplier;)Lcom/annimon/stream/function/IntSupplier;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IIntSupplier Safe (global::Com.Annimon.Stream.Function.IThrowableIntSupplier throwableSupplier)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableIntSupplier;)Lcom/annimon/stream/function/IntSupplier;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwableSupplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwableSupplier).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIntSupplier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IntSupplier.Util']/method[@name='safe' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.ThrowableIntSupplier&lt;java.lang.Throwable&gt;'] and parameter[2][@type='int']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableIntSupplier;I)Lcom/annimon/stream/function/IntSupplier;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IIntSupplier Safe (global::Com.Annimon.Stream.Function.IThrowableIntSupplier throwableSupplier, int resultIfFailed)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableIntSupplier;I)Lcom/annimon/stream/function/IntSupplier;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwableSupplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwableSupplier).Handle);
				__args [1] = new JniArgumentValue (resultIfFailed);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIntSupplier> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IntSupplier']"
	[Register ("com/annimon/stream/function/IntSupplier", "", "Com.Annimon.Stream.Function.IIntSupplierInvoker")]
	public partial interface IIntSupplier : IJavaObject, IJavaPeerable {

		int AsInt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IntSupplier']/method[@name='getAsInt' and count(parameter)=0]"
			[Register ("getAsInt", "()I", "GetGetAsIntHandler:Com.Annimon.Stream.Function.IIntSupplierInvoker, library-lightweight-stream-api")] get;
		}

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/IntSupplier", DoNotGenerateAcw=true)]
	internal partial class IIntSupplierInvoker : global::Java.Lang.Object, IIntSupplier {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IntSupplier", typeof (IIntSupplierInvoker));

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

		public static IIntSupplier GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIntSupplier> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.IntSupplier"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIntSupplierInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Com.Annimon.Stream.Function.IIntSupplier __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIntSupplier> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
