using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.annimon.stream']/interface[@name='Collector']"
	[Register ("com/annimon/stream/Collector", "", "Com.Annimon.Stream.ICollectorInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "A", "R"})]
	public partial interface ICollector : IJavaObject, IJavaPeerable {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/interface[@name='Collector']/method[@name='accumulator' and count(parameter)=0]"
		[Register ("accumulator", "()Lcom/annimon/stream/function/BiConsumer;", "GetAccumulatorHandler:Com.Annimon.Stream.ICollectorInvoker, library-lightweight-stream-api")]
		global::Com.Annimon.Stream.Function.IBiConsumer Accumulator ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/interface[@name='Collector']/method[@name='finisher' and count(parameter)=0]"
		[Register ("finisher", "()Lcom/annimon/stream/function/Function;", "GetFinisherHandler:Com.Annimon.Stream.ICollectorInvoker, library-lightweight-stream-api")]
		global::Com.Annimon.Stream.Function.IFunction Finisher ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/interface[@name='Collector']/method[@name='supplier' and count(parameter)=0]"
		[Register ("supplier", "()Lcom/annimon/stream/function/Supplier;", "GetSupplierHandler:Com.Annimon.Stream.ICollectorInvoker, library-lightweight-stream-api")]
		global::Com.Annimon.Stream.Function.ISupplier Supplier ();

	}

	[global::Android.Runtime.Register ("com/annimon/stream/Collector", DoNotGenerateAcw=true)]
	internal partial class ICollectorInvoker : global::Java.Lang.Object, ICollector {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/Collector", typeof (ICollectorInvoker));

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

		public static ICollector GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICollector> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.annimon.stream.Collector"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICollectorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_accumulator;
#pragma warning disable 0169
		static Delegate GetAccumulatorHandler ()
		{
			if (cb_accumulator == null)
				cb_accumulator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Accumulator);
			return cb_accumulator;
		}

		static IntPtr n_Accumulator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.ICollector __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Accumulator ());
		}
#pragma warning restore 0169

		IntPtr id_accumulator;
		public unsafe global::Com.Annimon.Stream.Function.IBiConsumer Accumulator ()
		{
			if (id_accumulator == IntPtr.Zero)
				id_accumulator = JNIEnv.GetMethodID (class_ref, "accumulator", "()Lcom/annimon/stream/function/BiConsumer;");
			return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IBiConsumer> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_accumulator), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_finisher;
#pragma warning disable 0169
		static Delegate GetFinisherHandler ()
		{
			if (cb_finisher == null)
				cb_finisher = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Finisher);
			return cb_finisher;
		}

		static IntPtr n_Finisher (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.ICollector __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Finisher ());
		}
#pragma warning restore 0169

		IntPtr id_finisher;
		public unsafe global::Com.Annimon.Stream.Function.IFunction Finisher ()
		{
			if (id_finisher == IntPtr.Zero)
				id_finisher = JNIEnv.GetMethodID (class_ref, "finisher", "()Lcom/annimon/stream/function/Function;");
			return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IFunction> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_finisher), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_supplier;
#pragma warning disable 0169
		static Delegate GetSupplierHandler ()
		{
			if (cb_supplier == null)
				cb_supplier = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Supplier);
			return cb_supplier;
		}

		static IntPtr n_Supplier (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.ICollector __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Supplier ());
		}
#pragma warning restore 0169

		IntPtr id_supplier;
		public unsafe global::Com.Annimon.Stream.Function.ISupplier Supplier ()
		{
			if (id_supplier == IntPtr.Zero)
				id_supplier = JNIEnv.GetMethodID (class_ref, "supplier", "()Lcom/annimon/stream/function/Supplier;");
			return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ISupplier> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_supplier), JniHandleOwnership.TransferLocalRef);
		}

	}

}
