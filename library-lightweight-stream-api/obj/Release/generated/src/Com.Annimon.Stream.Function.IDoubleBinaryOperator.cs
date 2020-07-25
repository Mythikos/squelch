using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='DoubleBinaryOperator']"
	[Register ("com/annimon/stream/function/DoubleBinaryOperator", "", "Com.Annimon.Stream.Function.IDoubleBinaryOperatorInvoker")]
	public partial interface IDoubleBinaryOperator : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='DoubleBinaryOperator']/method[@name='applyAsDouble' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("applyAsDouble", "(DD)D", "GetApplyAsDouble_DDHandler:Com.Annimon.Stream.Function.IDoubleBinaryOperatorInvoker, library-lightweight-stream-api")]
		double ApplyAsDouble (double p0, double p1);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/DoubleBinaryOperator", DoNotGenerateAcw=true)]
	internal partial class IDoubleBinaryOperatorInvoker : global::Java.Lang.Object, IDoubleBinaryOperator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/DoubleBinaryOperator", typeof (IDoubleBinaryOperatorInvoker));

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

		public static IDoubleBinaryOperator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDoubleBinaryOperator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.DoubleBinaryOperator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDoubleBinaryOperatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_applyAsDouble_DD;
#pragma warning disable 0169
		static Delegate GetApplyAsDouble_DDHandler ()
		{
			if (cb_applyAsDouble_DD == null)
				cb_applyAsDouble_DD = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double, double, double>) n_ApplyAsDouble_DD);
			return cb_applyAsDouble_DD;
		}

		static double n_ApplyAsDouble_DD (IntPtr jnienv, IntPtr native__this, double p0, double p1)
		{
			global::Com.Annimon.Stream.Function.IDoubleBinaryOperator __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IDoubleBinaryOperator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ApplyAsDouble (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_applyAsDouble_DD;
		public unsafe double ApplyAsDouble (double p0, double p1)
		{
			if (id_applyAsDouble_DD == IntPtr.Zero)
				id_applyAsDouble_DD = JNIEnv.GetMethodID (class_ref, "applyAsDouble", "(DD)D");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallDoubleMethod (((global::Java.Lang.Object) this).Handle, id_applyAsDouble_DD, __args);
		}

	}

}
