using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Operator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='DoubleMapIndexed']"
	[global::Android.Runtime.Register ("com/annimon/stream/operator/DoubleMapIndexed", DoNotGenerateAcw=true)]
	public partial class DoubleMapIndexed : global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfDouble {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/operator/DoubleMapIndexed", typeof (DoubleMapIndexed));
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

		protected DoubleMapIndexed (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='DoubleMapIndexed']/constructor[@name='DoubleMapIndexed' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.iterator.PrimitiveIndexedIterator.OfDouble'] and parameter[2][@type='com.annimon.stream.function.IndexedDoubleUnaryOperator']]"
		[Register (".ctor", "(Lcom/annimon/stream/iterator/PrimitiveIndexedIterator$OfDouble;Lcom/annimon/stream/function/IndexedDoubleUnaryOperator;)V", "")]
		public unsafe DoubleMapIndexed (global::Com.Annimon.Stream.Iterator.PrimitiveIndexedIterator.OfDouble iterator, global::Com.Annimon.Stream.Function.IIndexedDoubleUnaryOperator mapper)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/annimon/stream/iterator/PrimitiveIndexedIterator$OfDouble;Lcom/annimon/stream/function/IndexedDoubleUnaryOperator;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
				__args [1] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_hasNext;
#pragma warning disable 0169
		static Delegate GetHasNextHandler ()
		{
			if (cb_hasNext == null)
				cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNext);
			return cb_hasNext;
		}

		static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Operator.DoubleMapIndexed __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.DoubleMapIndexed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		public override unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='DoubleMapIndexed']/method[@name='hasNext' and count(parameter)=0]"
			[Register ("hasNext", "()Z", "GetHasNextHandler")]
			get {
				const string __id = "hasNext.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_nextDouble;
#pragma warning disable 0169
		static Delegate GetNextDoubleHandler ()
		{
			if (cb_nextDouble == null)
				cb_nextDouble = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_NextDouble);
			return cb_nextDouble;
		}

		static double n_NextDouble (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Operator.DoubleMapIndexed __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.DoubleMapIndexed> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextDouble ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='DoubleMapIndexed']/method[@name='nextDouble' and count(parameter)=0]"
		[Register ("nextDouble", "()D", "GetNextDoubleHandler")]
		public override unsafe double NextDouble ()
		{
			const string __id = "nextDouble.()D";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
