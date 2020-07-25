using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IntFunction.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/IntFunction$Util", DoNotGenerateAcw=true)]
	public partial class IntFunctionUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IntFunction$Util", typeof (IntFunctionUtil));
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

		protected IntFunctionUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IntFunction.Util']/method[@name='safe' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ThrowableIntFunction&lt;? extends R, java.lang.Throwable&gt;']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableIntFunction;)Lcom/annimon/stream/function/IntFunction;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public static unsafe global::Com.Annimon.Stream.Function.IIntFunction Safe (global::Com.Annimon.Stream.Function.IThrowableIntFunction throwableFunction)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableIntFunction;)Lcom/annimon/stream/function/IntFunction;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwableFunction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwableFunction).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIntFunction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IntFunction.Util']/method[@name='safe' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.ThrowableIntFunction&lt;? extends R, java.lang.Throwable&gt;'] and parameter[2][@type='R']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableIntFunction;Ljava/lang/Object;)Lcom/annimon/stream/function/IntFunction;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public static unsafe global::Com.Annimon.Stream.Function.IIntFunction Safe (global::Com.Annimon.Stream.Function.IThrowableIntFunction throwableFunction, global::Java.Lang.Object resultIfFailed)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableIntFunction;Ljava/lang/Object;)Lcom/annimon/stream/function/IntFunction;";
			IntPtr native_resultIfFailed = JNIEnv.ToLocalJniHandle (resultIfFailed);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwableFunction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwableFunction).Handle);
				__args [1] = new JniArgumentValue (native_resultIfFailed);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIntFunction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_resultIfFailed);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IntFunction']"
	[Register ("com/annimon/stream/function/IntFunction", "", "Com.Annimon.Stream.Function.IIntFunctionInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
	public partial interface IIntFunction : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IntFunction']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("apply", "(I)Ljava/lang/Object;", "GetApply_IHandler:Com.Annimon.Stream.Function.IIntFunctionInvoker, library-lightweight-stream-api")]
		global::Java.Lang.Object Apply (int p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/IntFunction", DoNotGenerateAcw=true)]
	internal partial class IIntFunctionInvoker : global::Java.Lang.Object, IIntFunction {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IntFunction", typeof (IIntFunctionInvoker));

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

		public static IIntFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIntFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.IntFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIntFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_apply_I;
#pragma warning disable 0169
		static Delegate GetApply_IHandler ()
		{
			if (cb_apply_I == null)
				cb_apply_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Apply_I);
			return cb_apply_I;
		}

		static IntPtr n_Apply_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Annimon.Stream.Function.IIntFunction __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIntFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Apply (p0));
		}
#pragma warning restore 0169

		IntPtr id_apply_I;
		public unsafe global::Java.Lang.Object Apply (int p0)
		{
			if (id_apply_I == IntPtr.Zero)
				id_apply_I = JNIEnv.GetMethodID (class_ref, "apply", "(I)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_I, __args), JniHandleOwnership.TransferLocalRef);
		}

	}

}
