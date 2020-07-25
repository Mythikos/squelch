using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IntBinaryOperator']"
	[Register ("com/annimon/stream/function/IntBinaryOperator", "", "Com.Annimon.Stream.Function.IIntBinaryOperatorInvoker")]
	public partial interface IIntBinaryOperator : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IntBinaryOperator']/method[@name='applyAsInt' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("applyAsInt", "(II)I", "GetApplyAsInt_IIHandler:Com.Annimon.Stream.Function.IIntBinaryOperatorInvoker, library-lightweight-stream-api")]
		int ApplyAsInt (int p0, int p1);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/IntBinaryOperator", DoNotGenerateAcw=true)]
	internal partial class IIntBinaryOperatorInvoker : global::Java.Lang.Object, IIntBinaryOperator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IntBinaryOperator", typeof (IIntBinaryOperatorInvoker));

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

		public static IIntBinaryOperator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIntBinaryOperator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.IntBinaryOperator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIntBinaryOperatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_applyAsInt_II;
#pragma warning disable 0169
		static Delegate GetApplyAsInt_IIHandler ()
		{
			if (cb_applyAsInt_II == null)
				cb_applyAsInt_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, int>) n_ApplyAsInt_II);
			return cb_applyAsInt_II;
		}

		static int n_ApplyAsInt_II (IntPtr jnienv, IntPtr native__this, int p0, int p1)
		{
			global::Com.Annimon.Stream.Function.IIntBinaryOperator __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIntBinaryOperator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ApplyAsInt (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_applyAsInt_II;
		public unsafe int ApplyAsInt (int p0, int p1)
		{
			if (id_applyAsInt_II == IntPtr.Zero)
				id_applyAsInt_II = JNIEnv.GetMethodID (class_ref, "applyAsInt", "(II)I");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_applyAsInt_II, __args);
		}

	}

}
