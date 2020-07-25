using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='DoubleFunction.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/DoubleFunction$Util", DoNotGenerateAcw=true)]
	public partial class DoubleFunctionUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/DoubleFunction$Util", typeof (DoubleFunctionUtil));
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

		protected DoubleFunctionUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='DoubleFunction.Util']/method[@name='safe' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ThrowableDoubleFunction&lt;? extends R, java.lang.Throwable&gt;']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableDoubleFunction;)Lcom/annimon/stream/function/DoubleFunction;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public static unsafe global::Com.Annimon.Stream.Function.IDoubleFunction Safe (global::Com.Annimon.Stream.Function.IThrowableDoubleFunction throwableFunction)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableDoubleFunction;)Lcom/annimon/stream/function/DoubleFunction;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwableFunction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwableFunction).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IDoubleFunction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='DoubleFunction.Util']/method[@name='safe' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.ThrowableDoubleFunction&lt;? extends R, java.lang.Throwable&gt;'] and parameter[2][@type='R']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableDoubleFunction;Ljava/lang/Object;)Lcom/annimon/stream/function/DoubleFunction;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public static unsafe global::Com.Annimon.Stream.Function.IDoubleFunction Safe (global::Com.Annimon.Stream.Function.IThrowableDoubleFunction throwableFunction, global::Java.Lang.Object resultIfFailed)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableDoubleFunction;Ljava/lang/Object;)Lcom/annimon/stream/function/DoubleFunction;";
			IntPtr native_resultIfFailed = JNIEnv.ToLocalJniHandle (resultIfFailed);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwableFunction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwableFunction).Handle);
				__args [1] = new JniArgumentValue (native_resultIfFailed);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IDoubleFunction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_resultIfFailed);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='DoubleFunction']"
	[Register ("com/annimon/stream/function/DoubleFunction", "", "Com.Annimon.Stream.Function.IDoubleFunctionInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
	public partial interface IDoubleFunction : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='DoubleFunction']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("apply", "(D)Ljava/lang/Object;", "GetApply_DHandler:Com.Annimon.Stream.Function.IDoubleFunctionInvoker, library-lightweight-stream-api")]
		global::Java.Lang.Object Apply (double p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/DoubleFunction", DoNotGenerateAcw=true)]
	internal partial class IDoubleFunctionInvoker : global::Java.Lang.Object, IDoubleFunction {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/DoubleFunction", typeof (IDoubleFunctionInvoker));

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

		public static IDoubleFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDoubleFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.DoubleFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDoubleFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_apply_D;
#pragma warning disable 0169
		static Delegate GetApply_DHandler ()
		{
			if (cb_apply_D == null)
				cb_apply_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, IntPtr>) n_Apply_D);
			return cb_apply_D;
		}

		static IntPtr n_Apply_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Annimon.Stream.Function.IDoubleFunction __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IDoubleFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Apply (p0));
		}
#pragma warning restore 0169

		IntPtr id_apply_D;
		public unsafe global::Java.Lang.Object Apply (double p0)
		{
			if (id_apply_D == IntPtr.Zero)
				id_apply_D = JNIEnv.GetMethodID (class_ref, "apply", "(D)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_D, __args), JniHandleOwnership.TransferLocalRef);
		}

	}

}
