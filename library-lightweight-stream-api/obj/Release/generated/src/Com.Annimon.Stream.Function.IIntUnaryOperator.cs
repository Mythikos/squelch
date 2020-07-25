using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IntUnaryOperator.Util']"
	[global::Android.Runtime.Register ("com/annimon/stream/function/IntUnaryOperator$Util", DoNotGenerateAcw=true)]
	public partial class IntUnaryOperatorUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IntUnaryOperator$Util", typeof (IntUnaryOperatorUtil));
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

		protected IntUnaryOperatorUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/class[@name='IntUnaryOperator.Util']/method[@name='identity' and count(parameter)=0]"
		[Register ("identity", "()Lcom/annimon/stream/function/IntUnaryOperator;", "")]
		public static unsafe global::Com.Annimon.Stream.Function.IIntUnaryOperator Identity ()
		{
			const string __id = "identity.()Lcom/annimon/stream/function/IntUnaryOperator;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIntUnaryOperator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IntUnaryOperator']"
	[Register ("com/annimon/stream/function/IntUnaryOperator", "", "Com.Annimon.Stream.Function.IIntUnaryOperatorInvoker")]
	public partial interface IIntUnaryOperator : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='IntUnaryOperator']/method[@name='applyAsInt' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("applyAsInt", "(I)I", "GetApplyAsInt_IHandler:Com.Annimon.Stream.Function.IIntUnaryOperatorInvoker, library-lightweight-stream-api")]
		int ApplyAsInt (int p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/IntUnaryOperator", DoNotGenerateAcw=true)]
	internal partial class IIntUnaryOperatorInvoker : global::Java.Lang.Object, IIntUnaryOperator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/IntUnaryOperator", typeof (IIntUnaryOperatorInvoker));

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

		public static IIntUnaryOperator GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IIntUnaryOperator> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.IntUnaryOperator"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IIntUnaryOperatorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_applyAsInt_I;
#pragma warning disable 0169
		static Delegate GetApplyAsInt_IHandler ()
		{
			if (cb_applyAsInt_I == null)
				cb_applyAsInt_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_ApplyAsInt_I);
			return cb_applyAsInt_I;
		}

		static int n_ApplyAsInt_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Annimon.Stream.Function.IIntUnaryOperator __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIntUnaryOperator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ApplyAsInt (p0);
		}
#pragma warning restore 0169

		IntPtr id_applyAsInt_I;
		public unsafe int ApplyAsInt (int p0)
		{
			if (id_applyAsInt_I == IntPtr.Zero)
				id_applyAsInt_I = JNIEnv.GetMethodID (class_ref, "applyAsInt", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_applyAsInt_I, __args);
		}

	}

}
