using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Operator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='LongSorted']"
	[global::Android.Runtime.Register ("com/annimon/stream/operator/LongSorted", DoNotGenerateAcw=true)]
	public partial class LongSorted : global::Com.Annimon.Stream.Iterator.PrimitiveExtIterator.OfLong {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/operator/LongSorted", typeof (LongSorted));
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

		protected LongSorted (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='LongSorted']/constructor[@name='LongSorted' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.iterator.PrimitiveIterator.OfLong']]"
		[Register (".ctor", "(Lcom/annimon/stream/iterator/PrimitiveIterator$OfLong;)V", "")]
		public unsafe LongSorted (global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfLong iterator)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/annimon/stream/iterator/PrimitiveIterator$OfLong;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
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
			global::Com.Annimon.Stream.Operator.LongSorted __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.LongSorted> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NextIteration ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='LongSorted']/method[@name='nextIteration' and count(parameter)=0]"
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
