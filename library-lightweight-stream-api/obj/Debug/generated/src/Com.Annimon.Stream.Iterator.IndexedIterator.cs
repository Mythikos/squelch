using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Iterator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='IndexedIterator']"
	[global::Android.Runtime.Register ("com/annimon/stream/iterator/IndexedIterator", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class IndexedIterator : global::Java.Lang.Object, global::Java.Util.IIterator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/iterator/IndexedIterator", typeof (IndexedIterator));
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

		protected IndexedIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='IndexedIterator']/constructor[@name='IndexedIterator' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='java.util.Iterator&lt;? extends T&gt;']]"
		[Register (".ctor", "(IILjava/util/Iterator;)V", "")]
		public unsafe IndexedIterator (int start, int step, global::Java.Util.IIterator iterator)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IILjava/util/Iterator;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (start);
				__args [1] = new JniArgumentValue (step);
				__args [2] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='IndexedIterator']/constructor[@name='IndexedIterator' and count(parameter)=1 and parameter[1][@type='java.util.Iterator&lt;? extends T&gt;']]"
		[Register (".ctor", "(Ljava/util/Iterator;)V", "")]
		public unsafe IndexedIterator (global::Java.Util.IIterator iterator)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Iterator;)V";

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
			global::Com.Annimon.Stream.Iterator.IndexedIterator __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.IndexedIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='IndexedIterator']/method[@name='hasNext' and count(parameter)=0]"
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

		static Delegate cb_getIndex;
#pragma warning disable 0169
		static Delegate GetGetIndexHandler ()
		{
			if (cb_getIndex == null)
				cb_getIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndex);
			return cb_getIndex;
		}

		static int n_GetIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Iterator.IndexedIterator __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.IndexedIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Index;
		}
#pragma warning restore 0169

		public virtual unsafe int Index {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='IndexedIterator']/method[@name='getIndex' and count(parameter)=0]"
			[Register ("getIndex", "()I", "GetGetIndexHandler")]
			get {
				const string __id = "getIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
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
			global::Com.Annimon.Stream.Iterator.IndexedIterator __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.IndexedIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Next ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='IndexedIterator']/method[@name='next' and count(parameter)=0]"
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
			global::Com.Annimon.Stream.Iterator.IndexedIterator __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.IndexedIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='IndexedIterator']/method[@name='remove' and count(parameter)=0]"
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
