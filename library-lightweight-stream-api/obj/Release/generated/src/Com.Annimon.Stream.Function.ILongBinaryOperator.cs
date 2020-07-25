using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='LongBinaryOperator']"
	[Register ("com/annimon/stream/function/LongBinaryOperator", "", "Com.Annimon.Stream.Function.ILongBinaryOperatorInvoker")]
	public partial interface ILongBinaryOperator : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='LongBinaryOperator']/method[@name='applyAsLong' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("applyAsLong", "(JJ)J", "GetApplyAsLong_JJHandler:Com.Annimon.Stream.Function.ILongBinaryOperatorInvoker, library-lightweight-stream-api")]
		long ApplyAsLong (long p0, long p1);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/LongBinaryOperator", DoNotGenerateAcw=true)]
	internal partial class ILongBinaryOperatorInvoker : global::Java.Lang.Object, ILongBinaryOperator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/LongBinaryOperator", typeof (ILongBinaryOperatorInvoker));

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

		public static ILongBinaryOperator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ILongBinaryOperator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.LongBinaryOperator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ILongBinaryOperatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_applyAsLong_JJ;
#pragma warning disable 0169
		static Delegate GetApplyAsLong_JJHandler ()
		{
			if (cb_applyAsLong_JJ == null)
				cb_applyAsLong_JJ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, long, long>) n_ApplyAsLong_JJ);
			return cb_applyAsLong_JJ;
		}

		static long n_ApplyAsLong_JJ (IntPtr jnienv, IntPtr native__this, long p0, long p1)
		{
			global::Com.Annimon.Stream.Function.ILongBinaryOperator __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ILongBinaryOperator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ApplyAsLong (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_applyAsLong_JJ;
		public unsafe long ApplyAsLong (long p0, long p1)
		{
			if (id_applyAsLong_JJ == IntPtr.Zero)
				id_applyAsLong_JJ = JNIEnv.GetMethodID (class_ref, "applyAsLong", "(JJ)J");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallLongMethod (((global::Java.Lang.Object) this).Handle, id_applyAsLong_JJ, __args);
		}

	}

}
