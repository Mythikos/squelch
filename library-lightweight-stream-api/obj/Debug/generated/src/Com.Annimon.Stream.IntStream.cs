using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']"
	[global::Android.Runtime.Register ("com/annimon/stream/IntStream", DoNotGenerateAcw=true)]
	public sealed partial class IntStream : global::Java.Lang.Object, global::Java.IO.ICloseable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/IntStream", typeof (IntStream));
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

		internal IntStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='allMatch' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntPredicate']]"
		[Register ("allMatch", "(Lcom/annimon/stream/function/IntPredicate;)Z", "")]
		public unsafe bool AllMatch (global::Com.Annimon.Stream.Function.IIntPredicate predicate)
		{
			const string __id = "allMatch.(Lcom/annimon/stream/function/IntPredicate;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='anyMatch' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntPredicate']]"
		[Register ("anyMatch", "(Lcom/annimon/stream/function/IntPredicate;)Z", "")]
		public unsafe bool AnyMatch (global::Com.Annimon.Stream.Function.IIntPredicate predicate)
		{
			const string __id = "anyMatch.(Lcom/annimon/stream/function/IntPredicate;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='boxed' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='collect' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.Supplier&lt;R&gt;'] and parameter[2][@type='com.annimon.stream.function.ObjIntConsumer&lt;R&gt;']]"
		[Register ("collect", "(Lcom/annimon/stream/function/Supplier;Lcom/annimon/stream/function/ObjIntConsumer;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::Java.Lang.Object Collect (global::Com.Annimon.Stream.Function.ISupplier supplier, global::Com.Annimon.Stream.Function.IObjIntConsumer accumulator)
		{
			const string __id = "collect.(Lcom/annimon/stream/function/Supplier;Lcom/annimon/stream/function/ObjIntConsumer;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((supplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) supplier).Handle);
				__args [1] = new JniArgumentValue ((accumulator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accumulator).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='concat' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.IntStream'] and parameter[2][@type='com.annimon.stream.IntStream']]"
		[Register ("concat", "(Lcom/annimon/stream/IntStream;Lcom/annimon/stream/IntStream;)Lcom/annimon/stream/IntStream;", "")]
		public static unsafe global::Com.Annimon.Stream.IntStream Concat (global::Com.Annimon.Stream.IntStream a, global::Com.Annimon.Stream.IntStream b)
		{
			const string __id = "concat.(Lcom/annimon/stream/IntStream;Lcom/annimon/stream/IntStream;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [1] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='count' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='custom' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;com.annimon.stream.IntStream, R&gt;']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='distinct' and count(parameter)=0]"
		[Register ("distinct", "()Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream Distinct ()
		{
			const string __id = "distinct.()Lcom/annimon/stream/IntStream;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='dropWhile' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntPredicate']]"
		[Register ("dropWhile", "(Lcom/annimon/stream/function/IntPredicate;)Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream DropWhile (global::Com.Annimon.Stream.Function.IIntPredicate predicate)
		{
			const string __id = "dropWhile.(Lcom/annimon/stream/function/IntPredicate;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='empty' and count(parameter)=0]"
		[Register ("empty", "()Lcom/annimon/stream/IntStream;", "")]
		public static unsafe global::Com.Annimon.Stream.IntStream Empty ()
		{
			const string __id = "empty.()Lcom/annimon/stream/IntStream;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='filter' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntPredicate']]"
		[Register ("filter", "(Lcom/annimon/stream/function/IntPredicate;)Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream Filter (global::Com.Annimon.Stream.Function.IIntPredicate predicate)
		{
			const string __id = "filter.(Lcom/annimon/stream/function/IntPredicate;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='filterIndexed' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IndexedIntPredicate']]"
		[Register ("filterIndexed", "(Lcom/annimon/stream/function/IndexedIntPredicate;)Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream FilterIndexed (global::Com.Annimon.Stream.Function.IIndexedIntPredicate predicate)
		{
			const string __id = "filterIndexed.(Lcom/annimon/stream/function/IndexedIntPredicate;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='filterIndexed' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.annimon.stream.function.IndexedIntPredicate']]"
		[Register ("filterIndexed", "(IILcom/annimon/stream/function/IndexedIntPredicate;)Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream FilterIndexed (int from, int step, global::Com.Annimon.Stream.Function.IIndexedIntPredicate predicate)
		{
			const string __id = "filterIndexed.(IILcom/annimon/stream/function/IndexedIntPredicate;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (from);
				__args [1] = new JniArgumentValue (step);
				__args [2] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='filterNot' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntPredicate']]"
		[Register ("filterNot", "(Lcom/annimon/stream/function/IntPredicate;)Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream FilterNot (global::Com.Annimon.Stream.Function.IIntPredicate predicate)
		{
			const string __id = "filterNot.(Lcom/annimon/stream/function/IntPredicate;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='findFirst' and count(parameter)=0]"
		[Register ("findFirst", "()Lcom/annimon/stream/OptionalInt;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalInt FindFirst ()
		{
			const string __id = "findFirst.()Lcom/annimon/stream/OptionalInt;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalInt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='findLast' and count(parameter)=0]"
		[Register ("findLast", "()Lcom/annimon/stream/OptionalInt;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalInt FindLast ()
		{
			const string __id = "findLast.()Lcom/annimon/stream/OptionalInt;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalInt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='findSingle' and count(parameter)=0]"
		[Register ("findSingle", "()Lcom/annimon/stream/OptionalInt;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalInt FindSingle ()
		{
			const string __id = "findSingle.()Lcom/annimon/stream/OptionalInt;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalInt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='flatMap' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntFunction&lt;? extends com.annimon.stream.IntStream&gt;']]"
		[Register ("flatMap", "(Lcom/annimon/stream/function/IntFunction;)Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream FlatMap (global::Com.Annimon.Stream.Function.IIntFunction mapper)
		{
			const string __id = "flatMap.(Lcom/annimon/stream/function/IntFunction;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='forEach' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntConsumer']]"
		[Register ("forEach", "(Lcom/annimon/stream/function/IntConsumer;)V", "")]
		public unsafe void ForEach (global::Com.Annimon.Stream.Function.IIntConsumer action)
		{
			const string __id = "forEach.(Lcom/annimon/stream/function/IntConsumer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='forEachIndexed' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IndexedIntConsumer']]"
		[Register ("forEachIndexed", "(Lcom/annimon/stream/function/IndexedIntConsumer;)V", "")]
		public unsafe void ForEachIndexed (global::Com.Annimon.Stream.Function.IIndexedIntConsumer action)
		{
			const string __id = "forEachIndexed.(Lcom/annimon/stream/function/IndexedIntConsumer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='forEachIndexed' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.annimon.stream.function.IndexedIntConsumer']]"
		[Register ("forEachIndexed", "(IILcom/annimon/stream/function/IndexedIntConsumer;)V", "")]
		public unsafe void ForEachIndexed (int from, int step, global::Com.Annimon.Stream.Function.IIndexedIntConsumer action)
		{
			const string __id = "forEachIndexed.(IILcom/annimon/stream/function/IndexedIntConsumer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (from);
				__args [1] = new JniArgumentValue (step);
				__args [2] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='generate' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntSupplier']]"
		[Register ("generate", "(Lcom/annimon/stream/function/IntSupplier;)Lcom/annimon/stream/IntStream;", "")]
		public static unsafe global::Com.Annimon.Stream.IntStream Generate (global::Com.Annimon.Stream.Function.IIntSupplier s)
		{
			const string __id = "generate.(Lcom/annimon/stream/function/IntSupplier;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='iterate' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='com.annimon.stream.function.IntPredicate'] and parameter[3][@type='com.annimon.stream.function.IntUnaryOperator']]"
		[Register ("iterate", "(ILcom/annimon/stream/function/IntPredicate;Lcom/annimon/stream/function/IntUnaryOperator;)Lcom/annimon/stream/IntStream;", "")]
		public static unsafe global::Com.Annimon.Stream.IntStream Iterate (int seed, global::Com.Annimon.Stream.Function.IIntPredicate predicate, global::Com.Annimon.Stream.Function.IIntUnaryOperator op)
		{
			const string __id = "iterate.(ILcom/annimon/stream/function/IntPredicate;Lcom/annimon/stream/function/IntUnaryOperator;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (seed);
				__args [1] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				__args [2] = new JniArgumentValue ((op == null) ? IntPtr.Zero : ((global::Java.Lang.Object) op).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='iterate' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.annimon.stream.function.IntUnaryOperator']]"
		[Register ("iterate", "(ILcom/annimon/stream/function/IntUnaryOperator;)Lcom/annimon/stream/IntStream;", "")]
		public static unsafe global::Com.Annimon.Stream.IntStream Iterate (int seed, global::Com.Annimon.Stream.Function.IIntUnaryOperator f)
		{
			const string __id = "iterate.(ILcom/annimon/stream/function/IntUnaryOperator;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (seed);
				__args [1] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Lcom/annimon/stream/iterator/PrimitiveIterator$OfInt;", "")]
		public unsafe global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfInt Iterator ()
		{
			const string __id = "iterator.()Lcom/annimon/stream/iterator/PrimitiveIterator$OfInt;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfInt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='limit' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("limit", "(J)Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream Limit (long maxSize)
		{
			const string __id = "limit.(J)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxSize);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='map' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntUnaryOperator']]"
		[Register ("map", "(Lcom/annimon/stream/function/IntUnaryOperator;)Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream Map (global::Com.Annimon.Stream.Function.IIntUnaryOperator mapper)
		{
			const string __id = "map.(Lcom/annimon/stream/function/IntUnaryOperator;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='mapIndexed' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntBinaryOperator']]"
		[Register ("mapIndexed", "(Lcom/annimon/stream/function/IntBinaryOperator;)Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream MapIndexed (global::Com.Annimon.Stream.Function.IIntBinaryOperator mapper)
		{
			const string __id = "mapIndexed.(Lcom/annimon/stream/function/IntBinaryOperator;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='mapIndexed' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.annimon.stream.function.IntBinaryOperator']]"
		[Register ("mapIndexed", "(IILcom/annimon/stream/function/IntBinaryOperator;)Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream MapIndexed (int from, int step, global::Com.Annimon.Stream.Function.IIntBinaryOperator mapper)
		{
			const string __id = "mapIndexed.(IILcom/annimon/stream/function/IntBinaryOperator;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (from);
				__args [1] = new JniArgumentValue (step);
				__args [2] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='mapToDouble' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntToDoubleFunction']]"
		[Register ("mapToDouble", "(Lcom/annimon/stream/function/IntToDoubleFunction;)Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream MapToDouble (global::Com.Annimon.Stream.Function.IIntToDoubleFunction mapper)
		{
			const string __id = "mapToDouble.(Lcom/annimon/stream/function/IntToDoubleFunction;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='mapToLong' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntToLongFunction']]"
		[Register ("mapToLong", "(Lcom/annimon/stream/function/IntToLongFunction;)Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream MapToLong (global::Com.Annimon.Stream.Function.IIntToLongFunction mapper)
		{
			const string __id = "mapToLong.(Lcom/annimon/stream/function/IntToLongFunction;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='mapToObj' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntFunction&lt;? extends R&gt;']]"
		[Register ("mapToObj", "(Lcom/annimon/stream/function/IntFunction;)Lcom/annimon/stream/Stream;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::Com.Annimon.Stream.Stream MapToObj (global::Com.Annimon.Stream.Function.IIntFunction mapper)
		{
			const string __id = "mapToObj.(Lcom/annimon/stream/function/IntFunction;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='max' and count(parameter)=0]"
		[Register ("max", "()Lcom/annimon/stream/OptionalInt;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalInt Max ()
		{
			const string __id = "max.()Lcom/annimon/stream/OptionalInt;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalInt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='min' and count(parameter)=0]"
		[Register ("min", "()Lcom/annimon/stream/OptionalInt;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalInt Min ()
		{
			const string __id = "min.()Lcom/annimon/stream/OptionalInt;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalInt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='noneMatch' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntPredicate']]"
		[Register ("noneMatch", "(Lcom/annimon/stream/function/IntPredicate;)Z", "")]
		public unsafe bool NoneMatch (global::Com.Annimon.Stream.Function.IIntPredicate predicate)
		{
			const string __id = "noneMatch.(Lcom/annimon/stream/function/IntPredicate;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='of' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.iterator.PrimitiveIterator.OfInt']]"
		[Register ("of", "(Lcom/annimon/stream/iterator/PrimitiveIterator$OfInt;)Lcom/annimon/stream/IntStream;", "")]
		public static unsafe global::Com.Annimon.Stream.IntStream Of (global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfInt iterator)
		{
			const string __id = "of.(Lcom/annimon/stream/iterator/PrimitiveIterator$OfInt;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='of' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("of", "(I)Lcom/annimon/stream/IntStream;", "")]
		public static unsafe global::Com.Annimon.Stream.IntStream Of (int t)
		{
			const string __id = "of.(I)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (t);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='of' and count(parameter)=1 and parameter[1][@type='int...']]"
		[Register ("of", "([I)Lcom/annimon/stream/IntStream;", "")]
		public static unsafe global::Com.Annimon.Stream.IntStream Of (params int[] values)
		{
			const string __id = "of.([I)Lcom/annimon/stream/IntStream;";
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_values);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='ofCodePoints' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("ofCodePoints", "(Ljava/lang/CharSequence;)Lcom/annimon/stream/IntStream;", "")]
		public static unsafe global::Com.Annimon.Stream.IntStream OfCodePoints (global::Java.Lang.ICharSequence charSequence)
		{
			const string __id = "ofCodePoints.(Ljava/lang/CharSequence;)Lcom/annimon/stream/IntStream;";
			IntPtr native_charSequence = CharSequence.ToLocalJniHandle (charSequence);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_charSequence);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_charSequence);
			}
		}

		public static global::Com.Annimon.Stream.IntStream OfCodePoints (string charSequence)
		{
			global::Java.Lang.String jls_charSequence = charSequence == null ? null : new global::Java.Lang.String (charSequence);
			global::Com.Annimon.Stream.IntStream __result = OfCodePoints (jls_charSequence);
			var __rsval = __result;
			jls_charSequence?.Dispose ();
			return __rsval;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='onClose' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("onClose", "(Ljava/lang/Runnable;)Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream OnClose (global::Java.Lang.IRunnable closeHandler)
		{
			const string __id = "onClose.(Ljava/lang/Runnable;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((closeHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) closeHandler).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='peek' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntConsumer']]"
		[Register ("peek", "(Lcom/annimon/stream/function/IntConsumer;)Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream Peek (global::Com.Annimon.Stream.Function.IIntConsumer action)
		{
			const string __id = "peek.(Lcom/annimon/stream/function/IntConsumer;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='range' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("range", "(II)Lcom/annimon/stream/IntStream;", "")]
		public static unsafe global::Com.Annimon.Stream.IntStream Range (int startInclusive, int endExclusive)
		{
			const string __id = "range.(II)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (startInclusive);
				__args [1] = new JniArgumentValue (endExclusive);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='rangeClosed' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("rangeClosed", "(II)Lcom/annimon/stream/IntStream;", "")]
		public static unsafe global::Com.Annimon.Stream.IntStream RangeClosed (int startInclusive, int endInclusive)
		{
			const string __id = "rangeClosed.(II)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (startInclusive);
				__args [1] = new JniArgumentValue (endInclusive);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='reduce' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntBinaryOperator']]"
		[Register ("reduce", "(Lcom/annimon/stream/function/IntBinaryOperator;)Lcom/annimon/stream/OptionalInt;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalInt Reduce (global::Com.Annimon.Stream.Function.IIntBinaryOperator op)
		{
			const string __id = "reduce.(Lcom/annimon/stream/function/IntBinaryOperator;)Lcom/annimon/stream/OptionalInt;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((op == null) ? IntPtr.Zero : ((global::Java.Lang.Object) op).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalInt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='reduce' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.annimon.stream.function.IntBinaryOperator']]"
		[Register ("reduce", "(ILcom/annimon/stream/function/IntBinaryOperator;)I", "")]
		public unsafe int Reduce (int identity, global::Com.Annimon.Stream.Function.IIntBinaryOperator op)
		{
			const string __id = "reduce.(ILcom/annimon/stream/function/IntBinaryOperator;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (identity);
				__args [1] = new JniArgumentValue ((op == null) ? IntPtr.Zero : ((global::Java.Lang.Object) op).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='sample' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("sample", "(I)Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream Sample (int stepWidth)
		{
			const string __id = "sample.(I)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (stepWidth);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='scan' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntBinaryOperator']]"
		[Register ("scan", "(Lcom/annimon/stream/function/IntBinaryOperator;)Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream Scan (global::Com.Annimon.Stream.Function.IIntBinaryOperator accumulator)
		{
			const string __id = "scan.(Lcom/annimon/stream/function/IntBinaryOperator;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((accumulator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accumulator).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='scan' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.annimon.stream.function.IntBinaryOperator']]"
		[Register ("scan", "(ILcom/annimon/stream/function/IntBinaryOperator;)Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream Scan (int identity, global::Com.Annimon.Stream.Function.IIntBinaryOperator accumulator)
		{
			const string __id = "scan.(ILcom/annimon/stream/function/IntBinaryOperator;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (identity);
				__args [1] = new JniArgumentValue ((accumulator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accumulator).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='single' and count(parameter)=0]"
		[Register ("single", "()I", "")]
		public unsafe int Single ()
		{
			const string __id = "single.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("skip", "(J)Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream Skip (long n)
		{
			const string __id = "skip.(J)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (n);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='sorted' and count(parameter)=0]"
		[Register ("sorted", "()Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream Sorted ()
		{
			const string __id = "sorted.()Lcom/annimon/stream/IntStream;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='sorted' and count(parameter)=1 and parameter[1][@type='java.util.Comparator&lt;java.lang.Integer&gt;']]"
		[Register ("sorted", "(Ljava/util/Comparator;)Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream Sorted (global::Java.Util.IComparator comparator)
		{
			const string __id = "sorted.(Ljava/util/Comparator;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((comparator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) comparator).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='sum' and count(parameter)=0]"
		[Register ("sum", "()I", "")]
		public unsafe int Sum ()
		{
			const string __id = "sum.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='takeUntil' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntPredicate']]"
		[Register ("takeUntil", "(Lcom/annimon/stream/function/IntPredicate;)Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream TakeUntil (global::Com.Annimon.Stream.Function.IIntPredicate stopPredicate)
		{
			const string __id = "takeUntil.(Lcom/annimon/stream/function/IntPredicate;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((stopPredicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stopPredicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='takeWhile' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntPredicate']]"
		[Register ("takeWhile", "(Lcom/annimon/stream/function/IntPredicate;)Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream TakeWhile (global::Com.Annimon.Stream.Function.IIntPredicate predicate)
		{
			const string __id = "takeWhile.(Lcom/annimon/stream/function/IntPredicate;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='IntStream']/method[@name='toArray' and count(parameter)=0]"
		[Register ("toArray", "()[I", "")]
		public unsafe int[] ToArray ()
		{
			const string __id = "toArray.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

	}
}
