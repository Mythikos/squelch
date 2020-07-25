using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Internal {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.internal']/class[@name='Operators']"
	[global::Android.Runtime.Register ("com/annimon/stream/internal/Operators", DoNotGenerateAcw=true)]
	public sealed partial class Operators : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/internal/Operators", typeof (Operators));
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

		internal Operators (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.internal']/class[@name='Operators']/method[@name='toArray' and count(parameter)=2 and parameter[1][@type='java.util.Iterator&lt;? extends T&gt;'] and parameter[2][@type='com.annimon.stream.function.IntFunction&lt;R[]&gt;']]"
		[Register ("toArray", "(Ljava/util/Iterator;Lcom/annimon/stream/function/IntFunction;)[Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::Java.Lang.Object[] ToArray (global::Java.Util.IIterator iterator, global::Com.Annimon.Stream.Function.IIntFunction generator)
		{
			const string __id = "toArray.(Ljava/util/Iterator;Lcom/annimon/stream/function/IntFunction;)[Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
				__args [1] = new JniArgumentValue ((generator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) generator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.internal']/class[@name='Operators']/method[@name='toDoubleArray' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.iterator.PrimitiveIterator.OfDouble']]"
		[Register ("toDoubleArray", "(Lcom/annimon/stream/iterator/PrimitiveIterator$OfDouble;)[D", "")]
		public static unsafe double[] ToDoubleArray (global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfDouble iterator)
		{
			const string __id = "toDoubleArray.(Lcom/annimon/stream/iterator/PrimitiveIterator$OfDouble;)[D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (double[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.internal']/class[@name='Operators']/method[@name='toIntArray' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.iterator.PrimitiveIterator.OfInt']]"
		[Register ("toIntArray", "(Lcom/annimon/stream/iterator/PrimitiveIterator$OfInt;)[I", "")]
		public static unsafe int[] ToIntArray (global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfInt iterator)
		{
			const string __id = "toIntArray.(Lcom/annimon/stream/iterator/PrimitiveIterator$OfInt;)[I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.internal']/class[@name='Operators']/method[@name='toList' and count(parameter)=1 and parameter[1][@type='java.util.Iterator&lt;? extends T&gt;']]"
		[Register ("toList", "(Ljava/util/Iterator;)Ljava/util/List;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::System.Collections.IList ToList (global::Java.Util.IIterator iterator)
		{
			const string __id = "toList.(Ljava/util/Iterator;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.internal']/class[@name='Operators']/method[@name='toLongArray' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.iterator.PrimitiveIterator.OfLong']]"
		[Register ("toLongArray", "(Lcom/annimon/stream/iterator/PrimitiveIterator$OfLong;)[J", "")]
		public static unsafe long[] ToLongArray (global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfLong iterator)
		{
			const string __id = "toLongArray.(Lcom/annimon/stream/iterator/PrimitiveIterator$OfLong;)[J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (long[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (long));
			} finally {
			}
		}

	}
}
