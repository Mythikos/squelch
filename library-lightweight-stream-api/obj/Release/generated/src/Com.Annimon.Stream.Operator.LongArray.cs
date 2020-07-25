using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Operator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='LongArray']"
	[global::Android.Runtime.Register ("com/annimon/stream/operator/LongArray", DoNotGenerateAcw=true)]
	public partial class LongArray : global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfLong {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/operator/LongArray", typeof (LongArray));
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

		protected LongArray (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='LongArray']/constructor[@name='LongArray' and count(parameter)=1 and parameter[1][@type='long[]']]"
		[Register (".ctor", "([J)V", "")]
		public unsafe LongArray (long[] values)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_values);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
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
			global::Com.Annimon.Stream.Operator.LongArray __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.LongArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		public override unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='LongArray']/method[@name='hasNext' and count(parameter)=0]"
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
			global::Com.Annimon.Stream.Operator.LongArray __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.LongArray> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextLong ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='LongArray']/method[@name='nextLong' and count(parameter)=0]"
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
