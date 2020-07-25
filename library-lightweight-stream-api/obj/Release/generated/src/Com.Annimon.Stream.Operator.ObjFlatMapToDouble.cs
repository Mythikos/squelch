using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Operator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjFlatMapToDouble']"
	[global::Android.Runtime.Register ("com/annimon/stream/operator/ObjFlatMapToDouble", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class ObjFlatMapToDouble : global::Com.Annimon.Stream.Iterator.PrimitiveExtIterator.OfDouble {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/operator/ObjFlatMapToDouble", typeof (ObjFlatMapToDouble));
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

		protected ObjFlatMapToDouble (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjFlatMapToDouble']/constructor[@name='ObjFlatMapToDouble' and count(parameter)=2 and parameter[1][@type='java.util.Iterator&lt;? extends T&gt;'] and parameter[2][@type='com.annimon.stream.function.Function&lt;? super T, ? extends com.annimon.stream.DoubleStream&gt;']]"
		[Register (".ctor", "(Ljava/util/Iterator;Lcom/annimon/stream/function/Function;)V", "")]
		public unsafe ObjFlatMapToDouble (global::Java.Util.IIterator iterator, global::Com.Annimon.Stream.Function.IFunction mapper)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Iterator;Lcom/annimon/stream/function/Function;)V";

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

		static Delegate cb_nextIteration;
#pragma warning disable 0169
		static Delegate GetNextIterationHandler ()
		{
			if (cb_nextIteration == null)
				cb_nextIteration = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NextIteration);
			return cb_nextIteration;
		}

		static void n_NextIteration (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Operator.ObjFlatMapToDouble __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.ObjFlatMapToDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NextIteration ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjFlatMapToDouble']/method[@name='nextIteration' and count(parameter)=0]"
		[Register ("nextIteration", "()V", "GetNextIterationHandler")]
		protected override unsafe void NextIteration ()
		{
			const string __id = "nextIteration.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
