using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Operator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='IntScanIdentity']"
	[global::Android.Runtime.Register ("com/annimon/stream/operator/IntScanIdentity", DoNotGenerateAcw=true)]
	public partial class IntScanIdentity : global::Com.Annimon.Stream.Iterator.PrimitiveExtIterator.OfInt {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/operator/IntScanIdentity", typeof (IntScanIdentity));
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

		protected IntScanIdentity (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='IntScanIdentity']/constructor[@name='IntScanIdentity' and count(parameter)=3 and parameter[1][@type='com.annimon.stream.iterator.PrimitiveIterator.OfInt'] and parameter[2][@type='int'] and parameter[3][@type='com.annimon.stream.function.IntBinaryOperator']]"
		[Register (".ctor", "(Lcom/annimon/stream/iterator/PrimitiveIterator$OfInt;ILcom/annimon/stream/function/IntBinaryOperator;)V", "")]
		public unsafe IntScanIdentity (global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfInt iterator, int identity, global::Com.Annimon.Stream.Function.IIntBinaryOperator accumulator)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/annimon/stream/iterator/PrimitiveIterator$OfInt;ILcom/annimon/stream/function/IntBinaryOperator;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
				__args [1] = new JniArgumentValue (identity);
				__args [2] = new JniArgumentValue ((accumulator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accumulator).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_nextIteration;
#pragma warning disable 0169
		static Delegate GetNextIterationHandler ()
		{
			if (cb_nextIteration == null)
				cb_nextIteration = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NextIteration);
			return cb_nextIteration;
		}

		static void n_NextIteration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Operator.IntScanIdentity __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.IntScanIdentity> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NextIteration ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='IntScanIdentity']/method[@name='nextIteration' and count(parameter)=0]"
		[Register ("nextIteration", "()V", "GetNextIterationHandler")]
		protected override unsafe void NextIteration ()
		{
			const string __id = "nextIteration.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
