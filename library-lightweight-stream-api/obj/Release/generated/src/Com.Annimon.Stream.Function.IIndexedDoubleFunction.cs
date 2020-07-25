using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedDoubleFunction.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedDoubleFunction$Util", DoNotGenerateAcw=true)]
	public partial class IndexedDoubleFunctionUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedDoubleFunction$Util", typeof (IndexedDoubleFunctionUtil));
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

		protected IndexedDoubleFunctionUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedDoubleFunction.Util']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoubleFunction&lt;? extends R&gt;']]"
		[Register ("wrap", "(Lcom/annimon/stream/function/DoubleFunction;)Lcom/annimon/stream/function/IndexedDoubleFunction;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public static unsafe global::Com.Annimon.Stream.Function.IIndexedDoubleFunction Wrap (global::Com.Annimon.Stream.Function.IDoubleFunction function)
		{
			const string __id = "wrap.(Lcom/annimon/stream/function/DoubleFunction;)Lcom/annimon/stream/function/IndexedDoubleFunction;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((function == null) ? IntPtr.Zero : ((global::Java.Lang.Object) function).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedDoubleFunction> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedDoubleFunction']"
	[Register ("com/annimon/stream/function/IndexedDoubleFunction", "", "Com.Annimon.Stream.Function.IIndexedDoubleFunctionInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
	public partial interface IIndexedDoubleFunction : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedDoubleFunction']/method[@name='apply' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double']]"
		[Register ("apply", "(ID)Ljava/lang/Object;", "GetApply_IDHandler:Com.Annimon.Stream.Function.IIndexedDoubleFunctionInvoker, library-lightweight-stream-api")]
		global::Java.Lang.Object Apply (int p0, double p1);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedDoubleFunction", DoNotGenerateAcw=true)]
	internal partial class IIndexedDoubleFunctionInvoker : global::Java.Lang.Object, IIndexedDoubleFunction {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedDoubleFunction", typeof (IIndexedDoubleFunctionInvoker));

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

		public static IIndexedDoubleFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIndexedDoubleFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.IndexedDoubleFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIndexedDoubleFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_apply_ID;
#pragma warning disable 0169
		static Delegate GetApply_IDHandler ()
		{
			if (cb_apply_ID == null)
				cb_apply_ID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double, IntPtr>) n_Apply_ID);
			return cb_apply_ID;
		}

		static IntPtr n_Apply_ID (IntPtr jnienv, IntPtr native__this, int p0, double p1)
		{
			global::Com.Annimon.Stream.Function.IIndexedDoubleFunction __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedDoubleFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Apply (p0, p1));
		}
#pragma warning restore 0169

		IntPtr id_apply_ID;
		public unsafe global::Java.Lang.Object Apply (int p0, double p1)
		{
			if (id_apply_ID == IntPtr.Zero)
				id_apply_ID = JNIEnv.GetMethodID (class_ref, "apply", "(ID)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_ID, __args), JniHandleOwnership.TransferLocalRef);
		}

	}

}
