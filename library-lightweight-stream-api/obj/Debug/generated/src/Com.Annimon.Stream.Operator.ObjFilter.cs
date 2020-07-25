using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Operator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjFilter']"
	[global::Android.Runtime.Register ("com/annimon/stream/operator/ObjFilter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class ObjFilter : global::Java.Lang.Object, global::Java.Util.IIterator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/operator/ObjFilter", typeof (ObjFilter));
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

		protected ObjFilter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjFilter']/constructor[@name='ObjFilter' and count(parameter)=2 and parameter[1][@type='java.util.Iterator&lt;? extends T&gt;'] and parameter[2][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;']]"
		[Register (".ctor", "(Ljava/util/Iterator;Lcom/annimon/stream/function/Predicate;)V", "")]
		public unsafe ObjFilter (global::Java.Util.IIterator iterator, global::Com.Annimon.Stream.Function.IPredicate predicate)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Iterator;Lcom/annimon/stream/function/Predicate;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
				__args [1] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
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
			global::Com.Annimon.Stream.Operator.ObjFilter __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.ObjFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjFilter']/method[@name='hasNext' and count(parameter)=0]"
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

		static Delegate cb_next;
#pragma warning disable 0169
		static Delegate GetNextHandler ()
		{
			if (cb_next == null)
				cb_next = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Next);
			return cb_next;
		}

		static IntPtr n_Next (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Operator.ObjFilter __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.ObjFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Next ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjFilter']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()Ljava/lang/Object;", "GetNextHandler")]
		public virtual unsafe global::Java.Lang.Object Next ()
		{
			const string __id = "next.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_remove;
#pragma warning disable 0169
		static Delegate GetRemoveHandler ()
		{
			if (cb_remove == null)
				cb_remove = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Remove);
			return cb_remove;
		}

		static void n_Remove (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Operator.ObjFilter __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.ObjFilter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjFilter']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()V", "GetRemoveHandler")]
		public virtual unsafe void Remove ()
		{
			const string __id = "remove.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
