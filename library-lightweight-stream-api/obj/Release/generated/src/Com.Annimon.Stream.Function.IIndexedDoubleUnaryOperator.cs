using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedDoubleUnaryOperator.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedDoubleUnaryOperator$Util", DoNotGenerateAcw=true)]
	public partial class IndexedDoubleUnaryOperatorUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedDoubleUnaryOperator$Util", typeof (IndexedDoubleUnaryOperatorUtil));
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

		protected IndexedDoubleUnaryOperatorUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IndexedDoubleUnaryOperator.Util']/method[@name='wrap' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoubleUnaryOperator']]"
		[Register ("wrap", "(Lcom/annimon/stream/function/DoubleUnaryOperator;)Lcom/annimon/stream/function/IndexedDoubleUnaryOperator;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IIndexedDoubleUnaryOperator Wrap (global::Com.Annimon.Stream.Function.IDoubleUnaryOperator function)
		{
			const string __id = "wrap.(Lcom/annimon/stream/function/DoubleUnaryOperator;)Lcom/annimon/stream/function/IndexedDoubleUnaryOperator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((function == null) ? IntPtr.Zero : ((global::Java.Lang.Object) function).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedDoubleUnaryOperator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedDoubleUnaryOperator']"
	[Register ("com/annimon/stream/function/IndexedDoubleUnaryOperator", "", "Com.Annimon.Stream.Function.IIndexedDoubleUnaryOperatorInvoker")]
	public partial interface IIndexedDoubleUnaryOperator : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IndexedDoubleUnaryOperator']/method[@name='applyAsDouble' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='double']]"
		[Register ("applyAsDouble", "(ID)D", "GetApplyAsDouble_IDHandler:Com.Annimon.Stream.Function.IIndexedDoubleUnaryOperatorInvoker, library-lightweight-stream-api")]
		double ApplyAsDouble (int p0, double p1);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/IndexedDoubleUnaryOperator", DoNotGenerateAcw=true)]
	internal partial class IIndexedDoubleUnaryOperatorInvoker : global::Java.Lang.Object, IIndexedDoubleUnaryOperator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IndexedDoubleUnaryOperator", typeof (IIndexedDoubleUnaryOperatorInvoker));

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

		public static IIndexedDoubleUnaryOperator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIndexedDoubleUnaryOperator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.IndexedDoubleUnaryOperator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIndexedDoubleUnaryOperatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_applyAsDouble_ID;
#pragma warning disable 0169
		static Delegate GetApplyAsDouble_IDHandler ()
		{
			if (cb_applyAsDouble_ID == null)
				cb_applyAsDouble_ID = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, double, double>) n_ApplyAsDouble_ID);
			return cb_applyAsDouble_ID;
		}

		static double n_ApplyAsDouble_ID (IntPtr jnienv, IntPtr native__this, int p0, double p1)
		{
			global::Com.Annimon.Stream.Function.IIndexedDoubleUnaryOperator __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedDoubleUnaryOperator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ApplyAsDouble (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_applyAsDouble_ID;
		public unsafe double ApplyAsDouble (int p0, double p1)
		{
			if (id_applyAsDouble_ID == IntPtr.Zero)
				id_applyAsDouble_ID = JNIEnv.GetMethodID (class_ref, "applyAsDouble", "(ID)D");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_applyAsDouble_ID, __args);
		}

	}

}
