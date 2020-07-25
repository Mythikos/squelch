using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='DoubleUnaryOperator.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/DoubleUnaryOperator$Util", DoNotGenerateAcw=true)]
	public partial class DoubleUnaryOperatorUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/DoubleUnaryOperator$Util", typeof (DoubleUnaryOperatorUtil));
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

		protected DoubleUnaryOperatorUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='DoubleUnaryOperator.Util']/method[@name='identity' and count(parameter)=0]"
		[Register ("identity", "()Lcom/annimon/stream/function/DoubleUnaryOperator;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IDoubleUnaryOperator Identity ()
		{
			const string __id = "identity.()Lcom/annimon/stream/function/DoubleUnaryOperator;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IDoubleUnaryOperator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='DoubleUnaryOperator']"
	[Register ("com/annimon/stream/function/DoubleUnaryOperator", "", "Com.Annimon.Stream.Function.IDoubleUnaryOperatorInvoker")]
	public partial interface IDoubleUnaryOperator : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='DoubleUnaryOperator']/method[@name='applyAsDouble' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("applyAsDouble", "(D)D", "GetApplyAsDouble_DHandler:Com.Annimon.Stream.Function.IDoubleUnaryOperatorInvoker, library-lightweight-stream-api")]
		double ApplyAsDouble (double p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/DoubleUnaryOperator", DoNotGenerateAcw=true)]
	internal partial class IDoubleUnaryOperatorInvoker : global::Java.Lang.Object, IDoubleUnaryOperator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/DoubleUnaryOperator", typeof (IDoubleUnaryOperatorInvoker));

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

		public static IDoubleUnaryOperator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDoubleUnaryOperator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.DoubleUnaryOperator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDoubleUnaryOperatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_applyAsDouble_D;
#pragma warning disable 0169
		static Delegate GetApplyAsDouble_DHandler ()
		{
			if (cb_applyAsDouble_D == null)
				cb_applyAsDouble_D = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, double>) n_ApplyAsDouble_D);
			return cb_applyAsDouble_D;
		}

		static double n_ApplyAsDouble_D (IntPtr jnienv, IntPtr native__this, double p0)
		{
			global::Com.Annimon.Stream.Function.IDoubleUnaryOperator __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IDoubleUnaryOperator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ApplyAsDouble (p0);
		}
#pragma warning restore 0169

		IntPtr id_applyAsDouble_D;
		public unsafe double ApplyAsDouble (double p0)
		{
			if (id_applyAsDouble_D == IntPtr.Zero)
				id_applyAsDouble_D = JNIEnv.GetMethodID (class_ref, "applyAsDouble", "(D)D");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_applyAsDouble_D, __args);
		}

	}

}
