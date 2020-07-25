using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Operator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='LongIterate']"
	[global::Android.Runtime.Register ("com/annimon/stream/operator/LongIterate", DoNotGenerateAcw=true)]
	public partial class LongIterate : global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfLong {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/operator/LongIterate", typeof (LongIterate));
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

		protected LongIterate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='LongIterate']/constructor[@name='LongIterate' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.annimon.stream.function.LongUnaryOperator']]"
		[Register (".ctor", "(JLcom/annimon/stream/function/LongUnaryOperator;)V", "")]
		public unsafe LongIterate (long seed, global::Com.Annimon.Stream.Function.ILongUnaryOperator f)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(JLcom/annimon/stream/function/LongUnaryOperator;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (seed);
				__args [1] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
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
			global::Com.Annimon.Stream.Operator.LongIterate __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.LongIterate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		public override unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='LongIterate']/method[@name='hasNext' and count(parameter)=0]"
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

		static Delegate cb_nextLong;
#pragma warning disable 0169
		static Delegate GetNextLongHandler ()
		{
			if (cb_nextLong == null)
				cb_nextLong = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_NextLong);
			return cb_nextLong;
		}

		static long n_NextLong (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Operator.LongIterate __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.LongIterate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextLong ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='LongIterate']/method[@name='nextLong' and count(parameter)=0]"
		[Register ("nextLong", "()J", "GetNextLongHandler")]
		public override unsafe long NextLong ()
		{
			const string __id = "nextLong.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
