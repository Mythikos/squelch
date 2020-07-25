using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Function {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='BooleanFunction']"
	[Register ("com/annimon/stream/function/BooleanFunction", "", "Com.Annimon.Stream.Function.IBooleanFunctionInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
	public partial interface IBooleanFunction : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.function']/interface[@name='BooleanFunction']/method[@name='apply' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("apply", "(Z)Ljava/lang/Object;", "GetApply_ZHandler:Com.Annimon.Stream.Function.IBooleanFunctionInvoker, library-lightweight-stream-api")]
		global::Java.Lang.Object Apply (bool p0);

	}

	[global::Android.Runtime.Register ("com/annimon/stream/function/BooleanFunction", DoNotGenerateAcw=true)]
	internal partial class IBooleanFunctionInvoker : global::Java.Lang.Object, IBooleanFunction {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/function/BooleanFunction", typeof (IBooleanFunctionInvoker));

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

		public static IBooleanFunction GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IBooleanFunction> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.function.BooleanFunction"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IBooleanFunctionInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_apply_Z;
#pragma warning disable 0169
		static Delegate GetApply_ZHandler ()
		{
			if (cb_apply_Z == null)
				cb_apply_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool, IntPtr>) n_Apply_Z);
			return cb_apply_Z;
		}

		static IntPtr n_Apply_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::Com.Annimon.Stream.Function.IBooleanFunction __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IBooleanFunction> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Apply (p0));
		}
#pragma warning restore 0169

		IntPtr id_apply_Z;
		public unsafe global::Java.Lang.Object Apply (bool p0)
		{
			if (id_apply_Z == IntPtr.Zero)
				id_apply_Z = JNIEnv.GetMethodID (class_ref, "apply", "(Z)Ljava/lang/Object;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_apply_Z, __args), JniHandleOwnership.TransferLocalRef);
		}

	}

}
