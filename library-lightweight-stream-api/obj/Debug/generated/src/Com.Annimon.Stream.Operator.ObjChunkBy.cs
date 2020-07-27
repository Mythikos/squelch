using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Operator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjChunkBy']"
	[global::Android.Runtime.Register ("com/annimon/stream/operator/ObjChunkBy", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T", "K"})]
	public partial class ObjChunkBy : global::Com.Annimon.Stream.Iterator.LsaIterator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/operator/ObjChunkBy", typeof (ObjChunkBy));
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

		protected ObjChunkBy (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjChunkBy']/constructor[@name='ObjChunkBy' and count(parameter)=2 and parameter[1][@type='java.util.Iterator&lt;? extends T&gt;'] and parameter[2][@type='com.annimon.stream.function.Function&lt;? super T, ? extends K&gt;']]"
		[Register (".ctor", "(Ljava/util/Iterator;Lcom/annimon/stream/function/Function;)V", "")]
		public unsafe ObjChunkBy (global::Java.Util.IIterator iterator, global::Com.Annimon.Stream.Function.IFunction classifier)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Iterator;Lcom/annimon/stream/function/Function;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
				__args [1] = new JniArgumentValue ((classifier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) classifier).Handle);
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
			global::Com.Annimon.Stream.Operator.ObjChunkBy __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.ObjChunkBy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		public override unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjChunkBy']/method[@name='hasNext' and count(parameter)=0]"
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
			global::Com.Annimon.Stream.Operator.ObjChunkBy __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.ObjChunkBy> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle ((System.Collections.IList)__this.NextIteration ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjChunkBy']/method[@name='nextIteration' and count(parameter)=0]"
		[Register ("nextIteration", "()Ljava/util/List;", "GetNextIterationHandler")]
		public override unsafe global::Java.Lang.Object NextIteration ()
		{
			const string __id = "nextIteration.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object)global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
