using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='LongFunction.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/LongFunction$Util", DoNotGenerateAcw=true)]
	public partial class LongFunctionUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/LongFunction$Util", typeof (LongFunctionUtil));
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

		protected LongFunctionUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='LongFunction.Util']/method[@name='safe' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ThrowableLongFunction&lt;? extends R, java.lang.Throwable&gt;']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableLongFunction;)Lcom/annimon/stream/function/LongFunction;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public static unsafe global::Com.Annimon.Stream.Function.ILongFunction Safe (global::Com.Annimon.Stream.Function.IThrowableLongFunction throwableFunction)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableLongFunction;)Lcom/annimon/stream/function/LongFunction;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwableFunction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwableFunction).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ILongFunction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='LongFunction.Util']/method[@name='safe' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.ThrowableLongFunction&lt;? extends R, java.lang.Throwable&gt;'] and parameter[2][@type='R']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableLongFunction;Ljava/lang/Object;)Lcom/annimon/stream/function/LongFunction;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public static unsafe global::Com.Annimon.Stream.Function.ILongFunction Safe (global::Com.Annimon.Stream.Function.IThrowableLongFunction throwableFunction, global::Java.Lang.Object resultIfFailed)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableLongFunction;Ljava/lang/Object;)Lcom/annimon/stream/function/LongFunction;";
			IntPtr native_resultIfFailed = JNIEnv.ToLocalJniHandle (resultIfFailed);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwableFunction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwableFunction).Handle);
				__args [1] = new JniArgumentValue (native_resultIfFailed);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ILongFunction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_resultIfFailed);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='LongFunction']"
	[Register ("com/annimon/stream/function/LongFunction", "", "Com.Annimon.Stream.Function.ILongFunctionInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
	public partial interface ILongFunction : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='LongFunction']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("apply", "(J)Ljava/lang/Object;", "GetApply_JHandler:Com.Annimon.Stream.Function.ILongFunctionInvoker, library-lightweight-stream-api")]
		global::Java.Lang.Object Apply (long p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/LongFunction", DoNotGenerateAcw=true)]
	internal partial class ILongFunctionInvoker : global::Java.Lang.Object, ILongFunction {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/LongFunction", typeof (ILongFunctionInvoker));

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

		public static ILongFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILongFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.LongFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILongFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_apply_J;
#pragma warning disable 0169
		static Delegate GetApply_JHandler ()
		{
			if (cb_apply_J == null)
				cb_apply_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_Apply_J);
			return cb_apply_J;
		}

		static IntPtr n_Apply_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Annimon.Stream.Function.ILongFunction __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ILongFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Apply (p0));
		}
#pragma warning restore 0169

		IntPtr id_apply_J;
		public unsafe global::Java.Lang.Object Apply (long p0)
		{
			if (id_apply_J == IntPtr.Zero)
				id_apply_J = JNIEnv.GetMethodID (class_ref, "apply", "(J)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_J, __args), JniHandleOwnership.TransferLocalRef);
		}

	}

}
