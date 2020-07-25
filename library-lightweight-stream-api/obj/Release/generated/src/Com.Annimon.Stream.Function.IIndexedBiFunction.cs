using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedBiFunction.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedBiFunction$Util", DoNotGenerateAcw=true)]
	public partial class IndexedBiFunctionUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedBiFunction$Util", typeof (IndexedBiFunctionUtil));
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

		protected IndexedBiFunctionUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedBiFunction.Util']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.BiFunction&lt;? super T, ? super U, ? extends R&gt;']]"
		[Register ("wrap", "(Lcom/annimon/stream/function/BiFunction;)Lcom/annimon/stream/function/IndexedBiFunction;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U", "R"})]
		public static unsafe global::Com.Annimon.Stream.Function.IIndexedBiFunction Wrap (global::Com.Annimon.Stream.Function.IBiFunction function)
		{
			const string __id = "wrap.(Lcom/annimon/stream/function/BiFunction;)Lcom/annimon/stream/function/IndexedBiFunction;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((function == null) ? IntPtr.Zero : ((global::Java.Lang.Object) function).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedBiFunction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedBiFunction']"
	[Register ("com/annimon/stream/function/IndexedBiFunction", "", "Com.Annimon.Stream.Function.IIndexedBiFunctionInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U", "R"})]
	public partial interface IIndexedBiFunction : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedBiFunction']/method[@name='apply' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='T'] and parameter[3][@type='U']]"
		[Register ("apply", "(ILjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "GetApply_ILjava_lang_Object_Ljava_lang_Object_Handler:Com.Annimon.Stream.Function.IIndexedBiFunctionInvoker, library-lightweight-stream-api")]
		global::Java.Lang.Object Apply (int p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedBiFunction", DoNotGenerateAcw=true)]
	internal partial class IIndexedBiFunctionInvoker : global::Java.Lang.Object, IIndexedBiFunction {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedBiFunction", typeof (IIndexedBiFunctionInvoker));

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

		public static IIndexedBiFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIndexedBiFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.IndexedBiFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIndexedBiFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_apply_ILjava_lang_Object_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetApply_ILjava_lang_Object_Ljava_lang_Object_Handler ()
		{
			if (cb_apply_ILjava_lang_Object_Ljava_lang_Object_ == null)
				cb_apply_ILjava_lang_Object_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr, IntPtr, IntPtr>) n_Apply_ILjava_lang_Object_Ljava_lang_Object_);
			return cb_apply_ILjava_lang_Object_Ljava_lang_Object_;
		}

		static IntPtr n_Apply_ILjava_lang_Object_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, int p0, IntPtr native_p1, IntPtr native_p2)
		{
			global::Com.Annimon.Stream.Function.IIndexedBiFunction __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedBiFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p1 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p1, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p2 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p2, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Apply (p0, p1, p2));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_apply_ILjava_lang_Object_Ljava_lang_Object_;
		public unsafe global::Java.Lang.Object Apply (int p0, global::Java.Lang.Object p1, global::Java.Lang.Object p2)
		{
			if (id_apply_ILjava_lang_Object_Ljava_lang_Object_ == IntPtr.Zero)
				id_apply_ILjava_lang_Object_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "apply", "(ILjava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			IntPtr native_p1 = JNIEnv.ToLocalJniHandle (p1);
			IntPtr native_p2 = JNIEnv.ToLocalJniHandle (p2);
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (native_p1);
			__args [2] = new JValue (native_p2);
			global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_ILjava_lang_Object_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef (native_p1);
			JNIEnv.DeleteLocalRef (native_p2);
			return __ret;
		}

	}

}
