using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']"
	[global::Android.Runtime.Register ("com/annimon/stream/LongStream", DoNotGenerateAcw=true)]
	public sealed partial class LongStream : global::Java.Lang.Object, global::Java.IO.ICloseable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/LongStream", typeof (LongStream));
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

		internal LongStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='allMatch' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongPredicate']]"
		[Register ("allMatch", "(Lcom/annimon/stream/function/LongPredicate;)Z", "")]
		public unsafe bool AllMatch (global::Com.Annimon.Stream.Function.ILongPredicate predicate)
		{
			const string __id = "allMatch.(Lcom/annimon/stream/function/LongPredicate;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='anyMatch' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongPredicate']]"
		[Register ("anyMatch", "(Lcom/annimon/stream/function/LongPredicate;)Z", "")]
		public unsafe bool AnyMatch (global::Com.Annimon.Stream.Function.ILongPredicate predicate)
		{
			const string __id = "anyMatch.(Lcom/annimon/stream/function/LongPredicate;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='boxed' and count(parameter)=0]"
		[Register ("boxed", "()Lcom/annimon/stream/Stream;", "")]
		public unsafe global::Com.Annimon.Stream.Stream Boxed ()
		{
			const string __id = "boxed.()Lcom/annimon/stream/Stream;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='collect' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.Supplier&lt;R&gt;'] and parameter[2][@type='com.annimon.stream.function.ObjLongConsumer&lt;R&gt;']]"
		[Register ("collect", "(Lcom/annimon/stream/function/Supplier;Lcom/annimon/stream/function/ObjLongConsumer;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::Java.Lang.Object Collect (global::Com.Annimon.Stream.Function.ISupplier supplier, global::Com.Annimon.Stream.Function.IObjLongConsumer accumulator)
		{
			const string __id = "collect.(Lcom/annimon/stream/function/Supplier;Lcom/annimon/stream/function/ObjLongConsumer;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((supplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) supplier).Handle);
				__args [1] = new JniArgumentValue ((accumulator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accumulator).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='concat' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.LongStream'] and parameter[2][@type='com.annimon.stream.LongStream']]"
		[Register ("concat", "(Lcom/annimon/stream/LongStream;Lcom/annimon/stream/LongStream;)Lcom/annimon/stream/LongStream;", "")]
		public static unsafe global::Com.Annimon.Stream.LongStream Concat (global::Com.Annimon.Stream.LongStream a, global::Com.Annimon.Stream.LongStream b)
		{
			const string __id = "concat.(Lcom/annimon/stream/LongStream;Lcom/annimon/stream/LongStream;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [1] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='count' and count(parameter)=0]"
		[Register ("count", "()J", "")]
		public unsafe long Count ()
		{
			const string __id = "count.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='custom' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;com.annimon.stream.LongStream, R&gt;']]"
		[Register ("custom", "(Lcom/annimon/stream/function/Function;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::Java.Lang.Object Custom (global::Com.Annimon.Stream.Function.IFunction function)
		{
			const string __id = "custom.(Lcom/annimon/stream/function/Function;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((function == null) ? IntPtr.Zero : ((global::Java.Lang.Object) function).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='distinct' and count(parameter)=0]"
		[Register ("distinct", "()Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream Distinct ()
		{
			const string __id = "distinct.()Lcom/annimon/stream/LongStream;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='dropWhile' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongPredicate']]"
		[Register ("dropWhile", "(Lcom/annimon/stream/function/LongPredicate;)Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream DropWhile (global::Com.Annimon.Stream.Function.ILongPredicate predicate)
		{
			const string __id = "dropWhile.(Lcom/annimon/stream/function/LongPredicate;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='empty' and count(parameter)=0]"
		[Register ("empty", "()Lcom/annimon/stream/LongStream;", "")]
		public static unsafe global::Com.Annimon.Stream.LongStream Empty ()
		{
			const string __id = "empty.()Lcom/annimon/stream/LongStream;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='filter' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongPredicate']]"
		[Register ("filter", "(Lcom/annimon/stream/function/LongPredicate;)Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream Filter (global::Com.Annimon.Stream.Function.ILongPredicate predicate)
		{
			const string __id = "filter.(Lcom/annimon/stream/function/LongPredicate;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='filterIndexed' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IndexedLongPredicate']]"
		[Register ("filterIndexed", "(Lcom/annimon/stream/function/IndexedLongPredicate;)Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream FilterIndexed (global::Com.Annimon.Stream.Function.IIndexedLongPredicate predicate)
		{
			const string __id = "filterIndexed.(Lcom/annimon/stream/function/IndexedLongPredicate;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='filterIndexed' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.annimon.stream.function.IndexedLongPredicate']]"
		[Register ("filterIndexed", "(IILcom/annimon/stream/function/IndexedLongPredicate;)Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream FilterIndexed (int from, int step, global::Com.Annimon.Stream.Function.IIndexedLongPredicate predicate)
		{
			const string __id = "filterIndexed.(IILcom/annimon/stream/function/IndexedLongPredicate;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (from);
				__args [1] = new JniArgumentValue (step);
				__args [2] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='filterNot' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongPredicate']]"
		[Register ("filterNot", "(Lcom/annimon/stream/function/LongPredicate;)Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream FilterNot (global::Com.Annimon.Stream.Function.ILongPredicate predicate)
		{
			const string __id = "filterNot.(Lcom/annimon/stream/function/LongPredicate;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='findFirst' and count(parameter)=0]"
		[Register ("findFirst", "()Lcom/annimon/stream/OptionalLong;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalLong FindFirst ()
		{
			const string __id = "findFirst.()Lcom/annimon/stream/OptionalLong;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalLong> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='findLast' and count(parameter)=0]"
		[Register ("findLast", "()Lcom/annimon/stream/OptionalLong;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalLong FindLast ()
		{
			const string __id = "findLast.()Lcom/annimon/stream/OptionalLong;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalLong> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='findSingle' and count(parameter)=0]"
		[Register ("findSingle", "()Lcom/annimon/stream/OptionalLong;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalLong FindSingle ()
		{
			const string __id = "findSingle.()Lcom/annimon/stream/OptionalLong;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalLong> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='flatMap' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongFunction&lt;? extends com.annimon.stream.LongStream&gt;']]"
		[Register ("flatMap", "(Lcom/annimon/stream/function/LongFunction;)Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream FlatMap (global::Com.Annimon.Stream.Function.ILongFunction mapper)
		{
			const string __id = "flatMap.(Lcom/annimon/stream/function/LongFunction;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='forEach' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongConsumer']]"
		[Register ("forEach", "(Lcom/annimon/stream/function/LongConsumer;)V", "")]
		public unsafe void ForEach (global::Com.Annimon.Stream.Function.ILongConsumer action)
		{
			const string __id = "forEach.(Lcom/annimon/stream/function/LongConsumer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='forEachIndexed' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IndexedLongConsumer']]"
		[Register ("forEachIndexed", "(Lcom/annimon/stream/function/IndexedLongConsumer;)V", "")]
		public unsafe void ForEachIndexed (global::Com.Annimon.Stream.Function.IIndexedLongConsumer action)
		{
			const string __id = "forEachIndexed.(Lcom/annimon/stream/function/IndexedLongConsumer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='forEachIndexed' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.annimon.stream.function.IndexedLongConsumer']]"
		[Register ("forEachIndexed", "(IILcom/annimon/stream/function/IndexedLongConsumer;)V", "")]
		public unsafe void ForEachIndexed (int from, int step, global::Com.Annimon.Stream.Function.IIndexedLongConsumer action)
		{
			const string __id = "forEachIndexed.(IILcom/annimon/stream/function/IndexedLongConsumer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (from);
				__args [1] = new JniArgumentValue (step);
				__args [2] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='generate' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongSupplier']]"
		[Register ("generate", "(Lcom/annimon/stream/function/LongSupplier;)Lcom/annimon/stream/LongStream;", "")]
		public static unsafe global::Com.Annimon.Stream.LongStream Generate (global::Com.Annimon.Stream.Function.ILongSupplier s)
		{
			const string __id = "generate.(Lcom/annimon/stream/function/LongSupplier;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='iterate' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='com.annimon.stream.function.LongPredicate'] and parameter[3][@type='com.annimon.stream.function.LongUnaryOperator']]"
		[Register ("iterate", "(JLcom/annimon/stream/function/LongPredicate;Lcom/annimon/stream/function/LongUnaryOperator;)Lcom/annimon/stream/LongStream;", "")]
		public static unsafe global::Com.Annimon.Stream.LongStream Iterate (long seed, global::Com.Annimon.Stream.Function.ILongPredicate predicate, global::Com.Annimon.Stream.Function.ILongUnaryOperator op)
		{
			const string __id = "iterate.(JLcom/annimon/stream/function/LongPredicate;Lcom/annimon/stream/function/LongUnaryOperator;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (seed);
				__args [1] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				__args [2] = new JniArgumentValue ((op == null) ? IntPtr.Zero : ((global::Java.Lang.Object) op).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='iterate' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.annimon.stream.function.LongUnaryOperator']]"
		[Register ("iterate", "(JLcom/annimon/stream/function/LongUnaryOperator;)Lcom/annimon/stream/LongStream;", "")]
		public static unsafe global::Com.Annimon.Stream.LongStream Iterate (long seed, global::Com.Annimon.Stream.Function.ILongUnaryOperator f)
		{
			const string __id = "iterate.(JLcom/annimon/stream/function/LongUnaryOperator;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (seed);
				__args [1] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Lcom/annimon/stream/iterator/PrimitiveIterator$OfLong;", "")]
		public unsafe global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfLong Iterator ()
		{
			const string __id = "iterator.()Lcom/annimon/stream/iterator/PrimitiveIterator$OfLong;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfLong> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='limit' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("limit", "(J)Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream Limit (long maxSize)
		{
			const string __id = "limit.(J)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxSize);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='map' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongUnaryOperator']]"
		[Register ("map", "(Lcom/annimon/stream/function/LongUnaryOperator;)Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream Map (global::Com.Annimon.Stream.Function.ILongUnaryOperator mapper)
		{
			const string __id = "map.(Lcom/annimon/stream/function/LongUnaryOperator;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='mapIndexed' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IndexedLongUnaryOperator']]"
		[Register ("mapIndexed", "(Lcom/annimon/stream/function/IndexedLongUnaryOperator;)Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream MapIndexed (global::Com.Annimon.Stream.Function.IIndexedLongUnaryOperator mapper)
		{
			const string __id = "mapIndexed.(Lcom/annimon/stream/function/IndexedLongUnaryOperator;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='mapIndexed' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.annimon.stream.function.IndexedLongUnaryOperator']]"
		[Register ("mapIndexed", "(IILcom/annimon/stream/function/IndexedLongUnaryOperator;)Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream MapIndexed (int from, int step, global::Com.Annimon.Stream.Function.IIndexedLongUnaryOperator mapper)
		{
			const string __id = "mapIndexed.(IILcom/annimon/stream/function/IndexedLongUnaryOperator;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (from);
				__args [1] = new JniArgumentValue (step);
				__args [2] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='mapToDouble' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongToDoubleFunction']]"
		[Register ("mapToDouble", "(Lcom/annimon/stream/function/LongToDoubleFunction;)Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream MapToDouble (global::Com.Annimon.Stream.Function.ILongToDoubleFunction mapper)
		{
			const string __id = "mapToDouble.(Lcom/annimon/stream/function/LongToDoubleFunction;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='mapToInt' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongToIntFunction']]"
		[Register ("mapToInt", "(Lcom/annimon/stream/function/LongToIntFunction;)Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream MapToInt (global::Com.Annimon.Stream.Function.ILongToIntFunction mapper)
		{
			const string __id = "mapToInt.(Lcom/annimon/stream/function/LongToIntFunction;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='mapToObj' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongFunction&lt;? extends R&gt;']]"
		[Register ("mapToObj", "(Lcom/annimon/stream/function/LongFunction;)Lcom/annimon/stream/Stream;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::Com.Annimon.Stream.Stream MapToObj (global::Com.Annimon.Stream.Function.ILongFunction mapper)
		{
			const string __id = "mapToObj.(Lcom/annimon/stream/function/LongFunction;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='max' and count(parameter)=0]"
		[Register ("max", "()Lcom/annimon/stream/OptionalLong;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalLong Max ()
		{
			const string __id = "max.()Lcom/annimon/stream/OptionalLong;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalLong> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='min' and count(parameter)=0]"
		[Register ("min", "()Lcom/annimon/stream/OptionalLong;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalLong Min ()
		{
			const string __id = "min.()Lcom/annimon/stream/OptionalLong;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalLong> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='noneMatch' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongPredicate']]"
		[Register ("noneMatch", "(Lcom/annimon/stream/function/LongPredicate;)Z", "")]
		public unsafe bool NoneMatch (global::Com.Annimon.Stream.Function.ILongPredicate predicate)
		{
			const string __id = "noneMatch.(Lcom/annimon/stream/function/LongPredicate;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='of' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.iterator.PrimitiveIterator.OfLong']]"
		[Register ("of", "(Lcom/annimon/stream/iterator/PrimitiveIterator$OfLong;)Lcom/annimon/stream/LongStream;", "")]
		public static unsafe global::Com.Annimon.Stream.LongStream Of (global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfLong iterator)
		{
			const string __id = "of.(Lcom/annimon/stream/iterator/PrimitiveIterator$OfLong;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='of' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("of", "(J)Lcom/annimon/stream/LongStream;", "")]
		public static unsafe global::Com.Annimon.Stream.LongStream Of (long t)
		{
			const string __id = "of.(J)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (t);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='of' and count(parameter)=1 and parameter[1][@type='long...']]"
		[Register ("of", "([J)Lcom/annimon/stream/LongStream;", "")]
		public static unsafe global::Com.Annimon.Stream.LongStream Of (params long[] values)
		{
			const string __id = "of.([J)Lcom/annimon/stream/LongStream;";
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_values);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='onClose' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("onClose", "(Ljava/lang/Runnable;)Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream OnClose (global::Java.Lang.IRunnable closeHandler)
		{
			const string __id = "onClose.(Ljava/lang/Runnable;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((closeHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) closeHandler).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='peek' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongConsumer']]"
		[Register ("peek", "(Lcom/annimon/stream/function/LongConsumer;)Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream Peek (global::Com.Annimon.Stream.Function.ILongConsumer action)
		{
			const string __id = "peek.(Lcom/annimon/stream/function/LongConsumer;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='range' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("range", "(JJ)Lcom/annimon/stream/LongStream;", "")]
		public static unsafe global::Com.Annimon.Stream.LongStream Range (long startInclusive, long endExclusive)
		{
			const string __id = "range.(JJ)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (startInclusive);
				__args [1] = new JniArgumentValue (endExclusive);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='rangeClosed' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("rangeClosed", "(JJ)Lcom/annimon/stream/LongStream;", "")]
		public static unsafe global::Com.Annimon.Stream.LongStream RangeClosed (long startInclusive, long endInclusive)
		{
			const string __id = "rangeClosed.(JJ)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (startInclusive);
				__args [1] = new JniArgumentValue (endInclusive);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='reduce' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongBinaryOperator']]"
		[Register ("reduce", "(Lcom/annimon/stream/function/LongBinaryOperator;)Lcom/annimon/stream/OptionalLong;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalLong Reduce (global::Com.Annimon.Stream.Function.ILongBinaryOperator accumulator)
		{
			const string __id = "reduce.(Lcom/annimon/stream/function/LongBinaryOperator;)Lcom/annimon/stream/OptionalLong;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((accumulator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accumulator).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalLong> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='reduce' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.annimon.stream.function.LongBinaryOperator']]"
		[Register ("reduce", "(JLcom/annimon/stream/function/LongBinaryOperator;)J", "")]
		public unsafe long Reduce (long identity, global::Com.Annimon.Stream.Function.ILongBinaryOperator accumulator)
		{
			const string __id = "reduce.(JLcom/annimon/stream/function/LongBinaryOperator;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (identity);
				__args [1] = new JniArgumentValue ((accumulator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accumulator).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='sample' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("sample", "(I)Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream Sample (int stepWidth)
		{
			const string __id = "sample.(I)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (stepWidth);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='scan' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongBinaryOperator']]"
		[Register ("scan", "(Lcom/annimon/stream/function/LongBinaryOperator;)Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream Scan (global::Com.Annimon.Stream.Function.ILongBinaryOperator accumulator)
		{
			const string __id = "scan.(Lcom/annimon/stream/function/LongBinaryOperator;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((accumulator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accumulator).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='scan' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='com.annimon.stream.function.LongBinaryOperator']]"
		[Register ("scan", "(JLcom/annimon/stream/function/LongBinaryOperator;)Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream Scan (long identity, global::Com.Annimon.Stream.Function.ILongBinaryOperator accumulator)
		{
			const string __id = "scan.(JLcom/annimon/stream/function/LongBinaryOperator;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (identity);
				__args [1] = new JniArgumentValue ((accumulator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accumulator).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='single' and count(parameter)=0]"
		[Register ("single", "()J", "")]
		public unsafe long Single ()
		{
			const string __id = "single.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("skip", "(J)Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream Skip (long n)
		{
			const string __id = "skip.(J)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (n);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='sorted' and count(parameter)=0]"
		[Register ("sorted", "()Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream Sorted ()
		{
			const string __id = "sorted.()Lcom/annimon/stream/LongStream;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='sorted' and count(parameter)=1 and parameter[1][@type='java.util.Comparator&lt;java.lang.Long&gt;']]"
		[Register ("sorted", "(Ljava/util/Comparator;)Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream Sorted (global::Java.Util.IComparator comparator)
		{
			const string __id = "sorted.(Ljava/util/Comparator;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((comparator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) comparator).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='sum' and count(parameter)=0]"
		[Register ("sum", "()J", "")]
		public unsafe long Sum ()
		{
			const string __id = "sum.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='takeUntil' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongPredicate']]"
		[Register ("takeUntil", "(Lcom/annimon/stream/function/LongPredicate;)Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream TakeUntil (global::Com.Annimon.Stream.Function.ILongPredicate stopPredicate)
		{
			const string __id = "takeUntil.(Lcom/annimon/stream/function/LongPredicate;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((stopPredicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stopPredicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='takeWhile' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongPredicate']]"
		[Register ("takeWhile", "(Lcom/annimon/stream/function/LongPredicate;)Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream TakeWhile (global::Com.Annimon.Stream.Function.ILongPredicate predicate)
		{
			const string __id = "takeWhile.(Lcom/annimon/stream/function/LongPredicate;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='LongStream']/method[@name='toArray' and count(parameter)=0]"
		[Register ("toArray", "()[J", "")]
		public unsafe long[] ToArray ()
		{
			const string __id = "toArray.()[J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (long[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (long));
			} finally {
			}
		}

	}
}
