using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='LongUnaryOperator.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/LongUnaryOperator$Util", DoNotGenerateAcw=true)]
	public partial class LongUnaryOperatorUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/LongUnaryOperator$Util", typeof (LongUnaryOperatorUtil));
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

		protected LongUnaryOperatorUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='LongUnaryOperator.Util']/method[@name='identity' and count(parameter)=0]"
		[Register ("identity", "()Lcom/annimon/stream/function/LongUnaryOperator;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.ILongUnaryOperator Identity ()
		{
			const string __id = "identity.()Lcom/annimon/stream/function/LongUnaryOperator;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ILongUnaryOperator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='LongUnaryOperator']"
	[Register ("com/annimon/stream/function/LongUnaryOperator", "", "Com.Annimon.Stream.Function.ILongUnaryOperatorInvoker")]
	public partial interface ILongUnaryOperator : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='LongUnaryOperator']/method[@name='applyAsLong' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("applyAsLong", "(J)J", "GetApplyAsLong_JHandler:Com.Annimon.Stream.Function.ILongUnaryOperatorInvoker, library-lightweight-stream-api")]
		long ApplyAsLong (long p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/LongUnaryOperator", DoNotGenerateAcw=true)]
	internal partial class ILongUnaryOperatorInvoker : global::Java.Lang.Object, ILongUnaryOperator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/LongUnaryOperator", typeof (ILongUnaryOperatorInvoker));

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

		public static ILongUnaryOperator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILongUnaryOperator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.LongUnaryOperator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILongUnaryOperatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_applyAsLong_J;
#pragma warning disable 0169
		static Delegate GetApplyAsLong_JHandler ()
		{
			if (cb_applyAsLong_J == null)
				cb_applyAsLong_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long>) n_ApplyAsLong_J);
			return cb_applyAsLong_J;
		}

		static long n_ApplyAsLong_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Annimon.Stream.Function.ILongUnaryOperator __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ILongUnaryOperator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ApplyAsLong (p0);
		}
#pragma warning restore 0169

		IntPtr id_applyAsLong_J;
		public unsafe long ApplyAsLong (long p0)
		{
			if (id_applyAsLong_J == IntPtr.Zero)
				id_applyAsLong_J = JNIEnv.GetMethodID (class_ref, "applyAsLong", "(J)J");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_applyAsLong_J, __args);
		}

	}

}
