using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Operator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjMerge']"
	[global::Android.Runtime.Register ("com/annimon/stream/operator/ObjMerge", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class ObjMerge : global::Com.Annimon.Stream.Iterator.LsaIterator {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjMerge.MergeResult']"
		[global::Android.Runtime.Register ("com/annimon/stream/operator/ObjMerge$MergeResult", DoNotGenerateAcw=true)]
		public sealed partial class MergeResult : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjMerge.MergeResult']/field[@name='TAKE_FIRST']"
			[Register ("TAKE_FIRST")]
			public static global::Com.Annimon.Stream.Operator.ObjMerge.MergeResult TakeFirst {
				get {
					const string __id = "TAKE_FIRST.Lcom/annimon/stream/operator/ObjMerge$MergeResult;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.ObjMerge.MergeResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjMerge.MergeResult']/field[@name='TAKE_SECOND']"
			[Register ("TAKE_SECOND")]
			public static global::Com.Annimon.Stream.Operator.ObjMerge.MergeResult TakeSecond {
				get {
					const string __id = "TAKE_SECOND.Lcom/annimon/stream/operator/ObjMerge$MergeResult;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.ObjMerge.MergeResult> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/operator/ObjMerge$MergeResult", typeof (MergeResult));
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

			internal MergeResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjMerge.MergeResult']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/annimon/stream/operator/ObjMerge$MergeResult;", "")]
			public static unsafe global::Com.Annimon.Stream.Operator.ObjMerge.MergeResult ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/annimon/stream/operator/ObjMerge$MergeResult;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.ObjMerge.MergeResult> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjMerge.MergeResult']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/annimon/stream/operator/ObjMerge$MergeResult;", "")]
			public static unsafe global::Com.Annimon.Stream.Operator.ObjMerge.MergeResult[] Values ()
			{
				const string __id = "values.()[Lcom/annimon/stream/operator/ObjMerge$MergeResult;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::Com.Annimon.Stream.Operator.ObjMerge.MergeResult[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Com.Annimon.Stream.Operator.ObjMerge.MergeResult));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/operator/ObjMerge", typeof (ObjMerge));
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

		protected ObjMerge (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjMerge']/constructor[@name='ObjMerge' and count(parameter)=3 and parameter[1][@type='java.util.Iterator&lt;? extends T&gt;'] and parameter[2][@type='java.util.Iterator&lt;? extends T&gt;'] and parameter[3][@type='com.annimon.stream.function.BiFunction&lt;? super T, ? super T, com.annimon.stream.operator.ObjMerge.MergeResult&gt;']]"
		[Register (".ctor", "(Ljava/util/Iterator;Ljava/util/Iterator;Lcom/annimon/stream/function/BiFunction;)V", "")]
		public unsafe ObjMerge (global::Java.Util.IIterator iterator1, global::Java.Util.IIterator iterator2, global::Com.Annimon.Stream.Function.IBiFunction selector)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Iterator;Ljava/util/Iterator;Lcom/annimon/stream/function/BiFunction;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((iterator1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator1).Handle);
				__args [1] = new JniArgumentValue ((iterator2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator2).Handle);
				__args [2] = new JniArgumentValue ((selector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) selector).Handle);
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
			global::Com.Annimon.Stream.Operator.ObjMerge __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.ObjMerge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNext;
		}
#pragma warning restore 0169

		public override unsafe bool HasNext {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjMerge']/method[@name='hasNext' and count(parameter)=0]"
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
			global::Com.Annimon.Stream.Operator.ObjMerge __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Operator.ObjMerge> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NextIteration ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.operator']/class[@name='ObjMerge']/method[@name='nextIteration' and count(parameter)=0]"
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
