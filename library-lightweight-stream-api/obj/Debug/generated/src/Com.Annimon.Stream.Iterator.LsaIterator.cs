using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Iterator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='LsaIterator']"
	[global::Android.Runtime.Register ("com/annimon/stream/iterator/LsaIterator", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class LsaIterator : global::Java.Lang.Object, global::Java.Util.IIterator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/iterator/LsaIterator", typeof (LsaIterator));
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

		protected LsaIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='LsaIterator']/constructor[@name='LsaIterator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LsaIterator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='LsaIterator']/method[@name='next' and count(parameter)=0]"
		[Register ("next", "()Ljava/lang/Object;", "")]
		public unsafe global::Java.Lang.Object Next ()
		{
			const string __id = "next.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::Com.Annimon.Stream.Iterator.LsaIterator __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.LsaIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NextIteration ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='LsaIterator']/method[@name='nextIteration' and count(parameter)=0]"
		[Register ("nextIteration", "()Ljava/lang/Object;", "GetNextIterationHandler")]
		public abstract global::Java.Lang.Object NextIteration ();

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
			global::Com.Annimon.Stream.Iterator.LsaIterator __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.LsaIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Remove ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='LsaIterator']/method[@name='remove' and count(parameter)=0]"
		[Register ("remove", "()V", "GetRemoveHandler")]
		public virtual unsafe void Remove ()
		{
			const string __id = "remove.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_hasNext;
#pragma warning disable 0169
		static Delegate GetGetHasNextHandler ()
		{
			if (cb_hasNext == null)
				cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetHasNext);
			return cb_hasNext;
		}

		static bool n_GetHasNext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Iterator.LsaIterator __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.LsaIterator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		public abstract global::System.Boolean HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='LsaIterator']/method[@name='hasNext' and count(parameter)=0]"
			[Register ("hasNext", "()Z", "GetGetHasNextHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/annimon/stream/iterator/LsaIterator", DoNotGenerateAcw=true)]
	internal partial class LsaIteratorInvoker : LsaIterator {

		public LsaIteratorInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/iterator/LsaIterator", typeof (LsaIteratorInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='LsaIterator']/method[@name='nextIteration' and count(parameter)=0]"
		[Register ("nextIteration", "()Ljava/lang/Object;", "GetNextIterationHandler")]
		public override unsafe global::Java.Lang.Object NextIteration ()
		{
			const string __id = "nextIteration.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		public override unsafe global::System.Boolean HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='LsaIterator']/method[@name='hasNext' and count(parameter)=0]"
			[Register ("hasNext", "()Z", "GetGetHasNextHandler")]
			get {
				const string __id = "hasNext.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}

}
