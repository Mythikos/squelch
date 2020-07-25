using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Operator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='DoubleScan']"
	[global::Android.Runtime.Register ("com/annimon/stream/operator/DoubleScan", DoNotGenerateAcw=true)]
	public partial class DoubleScan : global::Com.Annimon.Stream.Iterator.PrimitiveExtIterator.OfDouble {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/operator/DoubleScan", typeof (DoubleScan));
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

		protected DoubleScan (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='DoubleScan']/constructor[@name='DoubleScan' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.iterator.PrimitiveIterator.OfDouble'] and parameter[2][@type='com.annimon.stream.function.DoubleBinaryOperator']]"
		[Register (".ctor", "(Lcom/annimon/stream/iterator/PrimitiveIterator$OfDouble;Lcom/annimon/stream/function/DoubleBinaryOperator;)V", "")]
		public unsafe DoubleScan (global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfDouble iterator, global::Com.Annimon.Stream.Function.IDoubleBinaryOperator accumulator)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/annimon/stream/iterator/PrimitiveIterator$OfDouble;Lcom/annimon/stream/function/DoubleBinaryOperator;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
				__args [1] = new JniArgumentValue ((accumulator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accumulator).Handle);
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
			global::Com.Annimon.Stream.Operator.DoubleScan __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.DoubleScan> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NextIteration ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='DoubleScan']/method[@name='nextIteration' and count(parameter)=0]"
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
