using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Operator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjZip']"
	[global::Android.Runtime.Register ("com/annimon/stream/operator/ObjZip", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"F", "S", "R"})]
	public partial class ObjZip : global::Com.Annimon.Stream.Iterator.LsaIterator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/operator/ObjZip", typeof (ObjZip));
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

		protected ObjZip (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjZip']/constructor[@name='ObjZip' and count(parameter)=3 and parameter[1][@type='java.util.Iterator&lt;? extends F&gt;'] and parameter[2][@type='java.util.Iterator&lt;? extends S&gt;'] and parameter[3][@type='com.annimon.stream.function.BiFunction&lt;? super F, ? super S, ? extends R&gt;']]"
		[Register (".ctor", "(Ljava/util/Iterator;Ljava/util/Iterator;Lcom/annimon/stream/function/BiFunction;)V", "")]
		public unsafe ObjZip (global::Java.Util.IIterator iterator1, global::Java.Util.IIterator iterator2, global::Com.Annimon.Stream.Function.IBiFunction combiner)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Iterator;Ljava/util/Iterator;Lcom/annimon/stream/function/BiFunction;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((iterator1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator1).Handle);
				__args [1] = new JniArgumentValue ((iterator2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator2).Handle);
				__args [2] = new JniArgumentValue ((combiner == null) ? IntPtr.Zero : ((global::Java.Lang.Object) combiner).Handle);
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
			global::Com.Annimon.Stream.Operator.ObjZip __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.ObjZip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		public override unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjZip']/method[@name='hasNext' and count(parameter)=0]"
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

		static Delegate cb_nextIteration;
#pragma warning disable 0169
		static Delegate GetNextIterationHandler ()
		{
			if (cb_nextIteration == null)
				cb_nextIteration = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NextIteration);
			return cb_nextIteration;
		}

		static IntPtr n_NextIteration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Operator.ObjZip __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.ObjZip> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NextIteration ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjZip']/method[@name='nextIteration' and count(parameter)=0]"
		[Register ("nextIteration", "()Ljava/lang/Object;", "GetNextIterationHandler")]
		public override unsafe global::Java.Lang.Object NextIteration ()
		{
			const string __id = "nextIteration.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
