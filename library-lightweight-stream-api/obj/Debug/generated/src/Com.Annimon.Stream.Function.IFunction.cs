using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='Function.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/Function$Util", DoNotGenerateAcw=true)]
	public partial class FunctionUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/Function$Util", typeof (FunctionUtil));
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

		protected FunctionUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='Function.Util']/method[@name='andThen' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends R&gt;'] and parameter[2][@type='com.annimon.stream.function.Function&lt;? super R, ? extends V&gt;']]"
		[Register ("andThen", "(Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/function/Function;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R", "V"})]
		public static unsafe global::Com.Annimon.Stream.Function.IFunction AndThen (global::Com.Annimon.Stream.Function.IFunction f1, global::Com.Annimon.Stream.Function.IFunction f2)
		{
			const string __id = "andThen.(Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/function/Function;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((f1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f1).Handle);
				__args [1] = new JniArgumentValue ((f2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IFunction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='Function.Util']/method[@name='compose' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends R&gt;'] and parameter[2][@type='com.annimon.stream.function.Function&lt;? super V, ? extends T&gt;']]"
		[Register ("compose", "(Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/function/Function;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"V", "T", "R"})]
		public static unsafe global::Com.Annimon.Stream.Function.IFunction Compose (global::Com.Annimon.Stream.Function.IFunction f1, global::Com.Annimon.Stream.Function.IFunction f2)
		{
			const string __id = "compose.(Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/function/Function;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((f1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f1).Handle);
				__args [1] = new JniArgumentValue ((f2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IFunction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='Function.Util']/method[@name='safe' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ThrowableFunction&lt;? super T, ? extends R, java.lang.Throwable&gt;']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableFunction;)Lcom/annimon/stream/function/Function;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::Com.Annimon.Stream.Function.IFunction Safe (global::Com.Annimon.Stream.Function.IThrowableFunction throwableFunction)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableFunction;)Lcom/annimon/stream/function/Function;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwableFunction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwableFunction).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IFunction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='Function.Util']/method[@name='safe' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.ThrowableFunction&lt;? super T, ? extends R, java.lang.Throwable&gt;'] and parameter[2][@type='R']]"
		[Register ("safe", "(Lcom/annimon/stream/function/ThrowableFunction;Ljava/lang/Object;)Lcom/annimon/stream/function/Function;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::Com.Annimon.Stream.Function.IFunction Safe (global::Com.Annimon.Stream.Function.IThrowableFunction throwableFunction, global::Java.Lang.Object resultIfFailed)
		{
			const string __id = "safe.(Lcom/annimon/stream/function/ThrowableFunction;Ljava/lang/Object;)Lcom/annimon/stream/function/Function;";
			IntPtr native_resultIfFailed = JNIEnv.ToLocalJniHandle (resultIfFailed);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwableFunction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwableFunction).Handle);
				__args [1] = new JniArgumentValue (native_resultIfFailed);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IFunction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_resultIfFailed);
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='Function']"
	[Register ("com/annimon/stream/function/Function", "", "Com.Annimon.Stream.Function.IFunctionInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
	public partial interface IFunction : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='Function']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("apply", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetApply_Ljava_lang_Object_Handler:Com.Annimon.Stream.Function.IFunctionInvoker, library-lightweight-stream-api")]
		global::Java.Lang.Object Apply (global::Java.Lang.Object p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/Function", DoNotGenerateAcw=true)]
	internal partial class IFunctionInvoker : global::Java.Lang.Object, IFunction {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/Function", typeof (IFunctionInvoker));

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

		public static IFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.Function"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_apply_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetApply_Ljava_lang_Object_Handler ()
		{
			if (cb_apply_Ljava_lang_Object_ == null)
				cb_apply_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Apply_Ljava_lang_Object_);
			return cb_apply_Ljava_lang_Object_;
		}

		static IntPtr n_Apply_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Annimon.Stream.Function.IFunction __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Apply (p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_apply_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Apply (global::Java.Lang.Object p0)
		{
			if (id_apply_Ljava_lang_Object_ == IntPtr.Zero)
				id_apply_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "apply", "(Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

	}

}
