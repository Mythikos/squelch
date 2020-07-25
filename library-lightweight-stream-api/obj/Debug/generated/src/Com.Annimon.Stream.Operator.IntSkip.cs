using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Operator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='IntSkip']"
	[global::Android.Runtime.Register ("com/annimon/stream/operator/IntSkip", DoNotGenerateAcw=true)]
	public partial class IntSkip : global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfInt {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/operator/IntSkip", typeof (IntSkip));
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

		protected IntSkip (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='IntSkip']/constructor[@name='IntSkip' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.iterator.PrimitiveIterator.OfInt'] and parameter[2][@type='long']]"
		[Register (".ctor", "(Lcom/annimon/stream/iterator/PrimitiveIterator$OfInt;J)V", "")]
		public unsafe IntSkip (global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfInt iterator, long n)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/annimon/stream/iterator/PrimitiveIterator$OfInt;J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
				__args [1] = new JniArgumentValue (n);
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
			global::Com.Annimon.Stream.Operator.IntSkip __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.IntSkip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		public override unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='IntSkip']/method[@name='hasNext' and count(parameter)=0]"
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

		static Delegate cb_nextInt;
#pragma warning disable 0169
		static Delegate GetNextIntHandler ()
		{
			if (cb_nextInt == null)
				cb_nextInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_NextInt);
			return cb_nextInt;
		}

		static int n_NextInt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Operator.IntSkip __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.IntSkip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextInt ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='IntSkip']/method[@name='nextInt' and count(parameter)=0]"
		[Register ("nextInt", "()I", "GetNextIntHandler")]
		public override unsafe int NextInt ()
		{
			const string __id = "nextInt.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}
}
