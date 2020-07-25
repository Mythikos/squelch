using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='BinaryOperator.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/BinaryOperator$Util", DoNotGenerateAcw=true)]
	public partial class BinaryOperatorUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/BinaryOperator$Util", typeof (BinaryOperatorUtil));
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

		protected BinaryOperatorUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='BinaryOperator.Util']/method[@name='maxBy' and count(parameter)=1 and parameter[1][@type='java.util.Comparator&lt;? super T&gt;']]"
		[Register ("maxBy", "(Ljava/util/Comparator;)Lcom/annimon/stream/function/BinaryOperator;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Function.IBinaryOperator MaxBy (global::Java.Util.IComparator comparator)
		{
			const string __id = "maxBy.(Ljava/util/Comparator;)Lcom/annimon/stream/function/BinaryOperator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((comparator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) comparator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IBinaryOperator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='BinaryOperator.Util']/method[@name='minBy' and count(parameter)=1 and parameter[1][@type='java.util.Comparator&lt;? super T&gt;']]"
		[Register ("minBy", "(Ljava/util/Comparator;)Lcom/annimon/stream/function/BinaryOperator;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Function.IBinaryOperator MinBy (global::Java.Util.IComparator comparator)
		{
			const string __id = "minBy.(Ljava/util/Comparator;)Lcom/annimon/stream/function/BinaryOperator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((comparator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) comparator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IBinaryOperator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='BinaryOperator']"
	[Register ("com/annimon/stream/function/BinaryOperator", "", "Com.Annimon.Stream.Function.IBinaryOperatorInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial interface IBinaryOperator : global::Com.Annimon.Stream.Function.IBiFunction {

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/BinaryOperator", DoNotGenerateAcw=true)]
	internal partial class IBinaryOperatorInvoker : global::Java.Lang.Object, IBinaryOperator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/BinaryOperator", typeof (IBinaryOperatorInvoker));

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

		public static IBinaryOperator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBinaryOperator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.BinaryOperator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBinaryOperatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
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
			global::Com.Annimon.Stream.Function.IBinaryOperator __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IBinaryOperator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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
