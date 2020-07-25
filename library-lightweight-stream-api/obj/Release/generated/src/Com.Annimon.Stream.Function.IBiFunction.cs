using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='BiFunction.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/BiFunction$Util", DoNotGenerateAcw=true)]
	public partial class BiFunctionUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/BiFunction$Util", typeof (BiFunctionUtil));
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

		protected BiFunctionUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='BiFunction.Util']/method[@name='andThen' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.BiFunction&lt;? super T, ? super U, ? extends R&gt;'] and parameter[2][@type='com.annimon.stream.function.Function&lt;? super R, ? extends V&gt;']]"
		[Register ("andThen", "(Lcom/annimon/stream/function/BiFunction;Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/function/BiFunction;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U", "R", "V"})]
		public static unsafe global::Com.Annimon.Stream.Function.IBiFunction AndThen (global::Com.Annimon.Stream.Function.IBiFunction f1, global::Com.Annimon.Stream.Function.IFunction f2)
		{
			const string __id = "andThen.(Lcom/annimon/stream/function/BiFunction;Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/function/BiFunction;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((f1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f1).Handle);
				__args [1] = new JniArgumentValue ((f2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IBiFunction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='BiFunction.Util']/method[@name='reverse' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.BiFunction&lt;? super T, ? super U, ? extends R&gt;']]"
		[Register ("reverse", "(Lcom/annimon/stream/function/BiFunction;)Lcom/annimon/stream/function/BiFunction;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U", "R"})]
		public static unsafe global::Com.Annimon.Stream.Function.IBiFunction Reverse (global::Com.Annimon.Stream.Function.IBiFunction function)
		{
			const string __id = "reverse.(Lcom/annimon/stream/function/BiFunction;)Lcom/annimon/stream/function/BiFunction;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((function == null) ? IntPtr.Zero : ((global::Java.Lang.Object) function).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IBiFunction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='BiFunction']"
	[Register ("com/annimon/stream/function/BiFunction", "", "Com.Annimon.Stream.Function.IBiFunctionInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U", "R"})]
	public partial interface IBiFunction : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='BiFunction']/method[@name='apply' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='U']]"
		[Register ("apply", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetApply_Ljava_lang_Object_Ljava_lang_Object_Handler:Com.Annimon.Stream.Function.IBiFunctionInvoker, library-lightweight-stream-api")]
		global::Java.Lang.Object Apply (global::Java.Lang.Object p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/BiFunction", DoNotGenerateAcw=true)]
	internal partial class IBiFunctionInvoker : global::Java.Lang.Object, IBiFunction {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/BiFunction", typeof (IBiFunctionInvoker));

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

		public static IBiFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBiFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.BiFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBiFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_apply_Ljava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetApply_Ljava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_apply_Ljava_lang_Object_Ljava_lang_Object_ == null)
				cb_apply_Ljava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Apply_Ljava_lang_Object_Ljava_lang_Object_);
			return cb_apply_Ljava_lang_Object_Ljava_lang_Object_;
		}

		static IntPtr n_Apply_Ljava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Annimon.Stream.Function.IBiFunction __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IBiFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Apply (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_apply_Ljava_lang_Object_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Apply (global::Java.Lang.Object p0, global::Java.Lang.Object p1)
		{
			if (id_apply_Ljava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_apply_Ljava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "apply", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (native_p0);
			__args [1] = new JValue (native_p1);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_Ljava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p0);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

}
