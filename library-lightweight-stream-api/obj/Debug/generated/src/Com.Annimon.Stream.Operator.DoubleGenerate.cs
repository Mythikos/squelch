using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Operator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='DoubleGenerate']"
	[global::Android.Runtime.Register ("com/annimon/stream/operator/DoubleGenerate", DoNotGenerateAcw=true)]
	public partial class DoubleGenerate : global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfDouble {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/operator/DoubleGenerate", typeof (DoubleGenerate));
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

		protected DoubleGenerate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='DoubleGenerate']/constructor[@name='DoubleGenerate' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoubleSupplier']]"
		[Register (".ctor", "(Lcom/annimon/stream/function/DoubleSupplier;)V", "")]
		public unsafe DoubleGenerate (global::Com.Annimon.Stream.Function.IDoubleSupplier supplier)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/annimon/stream/function/DoubleSupplier;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((supplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) supplier).Handle);
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
			global::Com.Annimon.Stream.Operator.DoubleGenerate __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.DoubleGenerate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		public override unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='DoubleGenerate']/method[@name='hasNext' and count(parameter)=0]"
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
			global::Com.Annimon.Stream.Operator.DoubleGenerate __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.DoubleGenerate> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextDouble ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='DoubleGenerate']/method[@name='nextDouble' and count(parameter)=0]"
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
