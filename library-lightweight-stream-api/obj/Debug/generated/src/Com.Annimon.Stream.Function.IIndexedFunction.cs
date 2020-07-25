using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedFunction.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedFunction$Util", DoNotGenerateAcw=true)]
	public partial class IndexedFunctionUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedFunction$Util", typeof (IndexedFunctionUtil));
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

		protected IndexedFunctionUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedFunction.Util']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends R&gt;']]"
		[Register ("wrap", "(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/function/IndexedFunction;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::Com.Annimon.Stream.Function.IIndexedFunction Wrap (global::Com.Annimon.Stream.Function.IFunction function)
		{
			const string __id = "wrap.(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/function/IndexedFunction;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((function == null) ? IntPtr.Zero : ((global::Java.Lang.Object) function).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedFunction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedFunction']"
	[Register ("com/annimon/stream/function/IndexedFunction", "", "Com.Annimon.Stream.Function.IIndexedFunctionInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
	public partial interface IIndexedFunction : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedFunction']/method[@name='apply' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='T']]"
		[Register ("apply", "(ILjava/lang/Object;)Ljava/lang/Object;", "GetApply_ILjava_lang_Object_Handler:Com.Annimon.Stream.Function.IIndexedFunctionInvoker, library-lightweight-stream-api")]
		global::Java.Lang.Object Apply (int p0, global::Java.Lang.Object p1);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedFunction", DoNotGenerateAcw=true)]
	internal partial class IIndexedFunctionInvoker : global::Java.Lang.Object, IIndexedFunction {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedFunction", typeof (IIndexedFunctionInvoker));

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

		public static IIndexedFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIndexedFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.IndexedFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIndexedFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_apply_ILjava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetApply_ILjava_lang_Object_Handler ()
		{
			if (cb_apply_ILjava_lang_Object_ == null)
				cb_apply_ILjava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr>) n_Apply_ILjava_lang_Object_);
			return cb_apply_ILjava_lang_Object_;
		}

		static IntPtr n_Apply_ILjava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1)
		{
			global::Com.Annimon.Stream.Function.IIndexedFunction __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Apply (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_apply_ILjava_lang_Object_;
		public unsafe global::Java.Lang.Object Apply (int p0, global::Java.Lang.Object p1)
		{
			if (id_apply_ILjava_lang_Object_ == IntPtr.Zero)
				id_apply_ILjava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "apply", "(ILjava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_ILjava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			return __ret;
		}

	}

}
