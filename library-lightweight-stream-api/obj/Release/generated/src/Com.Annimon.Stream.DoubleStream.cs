using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']"
	[global::Android.Runtime.Register ("com/annimon/stream/DoubleStream", DoNotGenerateAcw=true)]
	public sealed partial class DoubleStream : global::Java.Lang.Object, global::Java.IO.ICloseable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/DoubleStream", typeof (DoubleStream));
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

		internal DoubleStream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='allMatch' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoublePredicate']]"
		[Register ("allMatch", "(Lcom/annimon/stream/function/DoublePredicate;)Z", "")]
		public unsafe bool AllMatch (global::Com.Annimon.Stream.Function.IDoublePredicate predicate)
		{
			const string __id = "allMatch.(Lcom/annimon/stream/function/DoublePredicate;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='anyMatch' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoublePredicate']]"
		[Register ("anyMatch", "(Lcom/annimon/stream/function/DoublePredicate;)Z", "")]
		public unsafe bool AnyMatch (global::Com.Annimon.Stream.Function.IDoublePredicate predicate)
		{
			const string __id = "anyMatch.(Lcom/annimon/stream/function/DoublePredicate;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='average' and count(parameter)=0]"
		[Register ("average", "()Lcom/annimon/stream/OptionalDouble;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalDouble Average ()
		{
			const string __id = "average.()Lcom/annimon/stream/OptionalDouble;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalDouble> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='boxed' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "")]
		public unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='collect' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.Supplier&lt;R&gt;'] and parameter[2][@type='com.annimon.stream.function.ObjDoubleConsumer&lt;R&gt;']]"
		[Register ("collect", "(Lcom/annimon/stream/function/Supplier;Lcom/annimon/stream/function/ObjDoubleConsumer;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::Java.Lang.Object Collect (global::Com.Annimon.Stream.Function.ISupplier supplier, global::Com.Annimon.Stream.Function.IObjDoubleConsumer accumulator)
		{
			const string __id = "collect.(Lcom/annimon/stream/function/Supplier;Lcom/annimon/stream/function/ObjDoubleConsumer;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((supplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) supplier).Handle);
				__args [1] = new JniArgumentValue ((accumulator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accumulator).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='concat' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.DoubleStream'] and parameter[2][@type='com.annimon.stream.DoubleStream']]"
		[Register ("concat", "(Lcom/annimon/stream/DoubleStream;Lcom/annimon/stream/DoubleStream;)Lcom/annimon/stream/DoubleStream;", "")]
		public static unsafe global::Com.Annimon.Stream.DoubleStream Concat (global::Com.Annimon.Stream.DoubleStream a, global::Com.Annimon.Stream.DoubleStream b)
		{
			const string __id = "concat.(Lcom/annimon/stream/DoubleStream;Lcom/annimon/stream/DoubleStream;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [1] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='count' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='custom' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;com.annimon.stream.DoubleStream, R&gt;']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='distinct' and count(parameter)=0]"
		[Register ("distinct", "()Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream Distinct ()
		{
			const string __id = "distinct.()Lcom/annimon/stream/DoubleStream;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='dropWhile' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoublePredicate']]"
		[Register ("dropWhile", "(Lcom/annimon/stream/function/DoublePredicate;)Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream DropWhile (global::Com.Annimon.Stream.Function.IDoublePredicate predicate)
		{
			const string __id = "dropWhile.(Lcom/annimon/stream/function/DoublePredicate;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='empty' and count(parameter)=0]"
		[Register ("empty", "()Lcom/annimon/stream/DoubleStream;", "")]
		public static unsafe global::Com.Annimon.Stream.DoubleStream Empty ()
		{
			const string __id = "empty.()Lcom/annimon/stream/DoubleStream;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='filter' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoublePredicate']]"
		[Register ("filter", "(Lcom/annimon/stream/function/DoublePredicate;)Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream Filter (global::Com.Annimon.Stream.Function.IDoublePredicate predicate)
		{
			const string __id = "filter.(Lcom/annimon/stream/function/DoublePredicate;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='filterIndexed' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IndexedDoublePredicate']]"
		[Register ("filterIndexed", "(Lcom/annimon/stream/function/IndexedDoublePredicate;)Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream FilterIndexed (global::Com.Annimon.Stream.Function.IIndexedDoublePredicate predicate)
		{
			const string __id = "filterIndexed.(Lcom/annimon/stream/function/IndexedDoublePredicate;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='filterIndexed' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.annimon.stream.function.IndexedDoublePredicate']]"
		[Register ("filterIndexed", "(IILcom/annimon/stream/function/IndexedDoublePredicate;)Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream FilterIndexed (int from, int step, global::Com.Annimon.Stream.Function.IIndexedDoublePredicate predicate)
		{
			const string __id = "filterIndexed.(IILcom/annimon/stream/function/IndexedDoublePredicate;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (from);
				__args [1] = new JniArgumentValue (step);
				__args [2] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='filterNot' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoublePredicate']]"
		[Register ("filterNot", "(Lcom/annimon/stream/function/DoublePredicate;)Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream FilterNot (global::Com.Annimon.Stream.Function.IDoublePredicate predicate)
		{
			const string __id = "filterNot.(Lcom/annimon/stream/function/DoublePredicate;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='findFirst' and count(parameter)=0]"
		[Register ("findFirst", "()Lcom/annimon/stream/OptionalDouble;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalDouble FindFirst ()
		{
			const string __id = "findFirst.()Lcom/annimon/stream/OptionalDouble;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalDouble> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='findLast' and count(parameter)=0]"
		[Register ("findLast", "()Lcom/annimon/stream/OptionalDouble;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalDouble FindLast ()
		{
			const string __id = "findLast.()Lcom/annimon/stream/OptionalDouble;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalDouble> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='findSingle' and count(parameter)=0]"
		[Register ("findSingle", "()Lcom/annimon/stream/OptionalDouble;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalDouble FindSingle ()
		{
			const string __id = "findSingle.()Lcom/annimon/stream/OptionalDouble;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalDouble> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='flatMap' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoubleFunction&lt;? extends com.annimon.stream.DoubleStream&gt;']]"
		[Register ("flatMap", "(Lcom/annimon/stream/function/DoubleFunction;)Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream FlatMap (global::Com.Annimon.Stream.Function.IDoubleFunction mapper)
		{
			const string __id = "flatMap.(Lcom/annimon/stream/function/DoubleFunction;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='forEach' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoubleConsumer']]"
		[Register ("forEach", "(Lcom/annimon/stream/function/DoubleConsumer;)V", "")]
		public unsafe void ForEach (global::Com.Annimon.Stream.Function.IDoubleConsumer action)
		{
			const string __id = "forEach.(Lcom/annimon/stream/function/DoubleConsumer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='forEachIndexed' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IndexedDoubleConsumer']]"
		[Register ("forEachIndexed", "(Lcom/annimon/stream/function/IndexedDoubleConsumer;)V", "")]
		public unsafe void ForEachIndexed (global::Com.Annimon.Stream.Function.IIndexedDoubleConsumer action)
		{
			const string __id = "forEachIndexed.(Lcom/annimon/stream/function/IndexedDoubleConsumer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='forEachIndexed' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.annimon.stream.function.IndexedDoubleConsumer']]"
		[Register ("forEachIndexed", "(IILcom/annimon/stream/function/IndexedDoubleConsumer;)V", "")]
		public unsafe void ForEachIndexed (int from, int step, global::Com.Annimon.Stream.Function.IIndexedDoubleConsumer action)
		{
			const string __id = "forEachIndexed.(IILcom/annimon/stream/function/IndexedDoubleConsumer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (from);
				__args [1] = new JniArgumentValue (step);
				__args [2] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='generate' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoubleSupplier']]"
		[Register ("generate", "(Lcom/annimon/stream/function/DoubleSupplier;)Lcom/annimon/stream/DoubleStream;", "")]
		public static unsafe global::Com.Annimon.Stream.DoubleStream Generate (global::Com.Annimon.Stream.Function.IDoubleSupplier s)
		{
			const string __id = "generate.(Lcom/annimon/stream/function/DoubleSupplier;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((s == null) ? IntPtr.Zero : ((global::Java.Lang.Object) s).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='iterate' and count(parameter)=3 and parameter[1][@type='double'] and parameter[2][@type='com.annimon.stream.function.DoublePredicate'] and parameter[3][@type='com.annimon.stream.function.DoubleUnaryOperator']]"
		[Register ("iterate", "(DLcom/annimon/stream/function/DoublePredicate;Lcom/annimon/stream/function/DoubleUnaryOperator;)Lcom/annimon/stream/DoubleStream;", "")]
		public static unsafe global::Com.Annimon.Stream.DoubleStream Iterate (double seed, global::Com.Annimon.Stream.Function.IDoublePredicate predicate, global::Com.Annimon.Stream.Function.IDoubleUnaryOperator op)
		{
			const string __id = "iterate.(DLcom/annimon/stream/function/DoublePredicate;Lcom/annimon/stream/function/DoubleUnaryOperator;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (seed);
				__args [1] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				__args [2] = new JniArgumentValue ((op == null) ? IntPtr.Zero : ((global::Java.Lang.Object) op).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='iterate' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='com.annimon.stream.function.DoubleUnaryOperator']]"
		[Register ("iterate", "(DLcom/annimon/stream/function/DoubleUnaryOperator;)Lcom/annimon/stream/DoubleStream;", "")]
		public static unsafe global::Com.Annimon.Stream.DoubleStream Iterate (double seed, global::Com.Annimon.Stream.Function.IDoubleUnaryOperator f)
		{
			const string __id = "iterate.(DLcom/annimon/stream/function/DoubleUnaryOperator;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (seed);
				__args [1] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Lcom/annimon/stream/iterator/PrimitiveIterator$OfDouble;", "")]
		public unsafe global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfDouble Iterator ()
		{
			const string __id = "iterator.()Lcom/annimon/stream/iterator/PrimitiveIterator$OfDouble;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfDouble> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='limit' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("limit", "(J)Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream Limit (long maxSize)
		{
			const string __id = "limit.(J)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxSize);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='map' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoubleUnaryOperator']]"
		[Register ("map", "(Lcom/annimon/stream/function/DoubleUnaryOperator;)Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream Map (global::Com.Annimon.Stream.Function.IDoubleUnaryOperator mapper)
		{
			const string __id = "map.(Lcom/annimon/stream/function/DoubleUnaryOperator;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='mapIndexed' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IndexedDoubleUnaryOperator']]"
		[Register ("mapIndexed", "(Lcom/annimon/stream/function/IndexedDoubleUnaryOperator;)Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream MapIndexed (global::Com.Annimon.Stream.Function.IIndexedDoubleUnaryOperator mapper)
		{
			const string __id = "mapIndexed.(Lcom/annimon/stream/function/IndexedDoubleUnaryOperator;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='mapIndexed' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.annimon.stream.function.IndexedDoubleUnaryOperator']]"
		[Register ("mapIndexed", "(IILcom/annimon/stream/function/IndexedDoubleUnaryOperator;)Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream MapIndexed (int from, int step, global::Com.Annimon.Stream.Function.IIndexedDoubleUnaryOperator mapper)
		{
			const string __id = "mapIndexed.(IILcom/annimon/stream/function/IndexedDoubleUnaryOperator;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (from);
				__args [1] = new JniArgumentValue (step);
				__args [2] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='mapToInt' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoubleToIntFunction']]"
		[Register ("mapToInt", "(Lcom/annimon/stream/function/DoubleToIntFunction;)Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream MapToInt (global::Com.Annimon.Stream.Function.IDoubleToIntFunction mapper)
		{
			const string __id = "mapToInt.(Lcom/annimon/stream/function/DoubleToIntFunction;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='mapToLong' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoubleToLongFunction']]"
		[Register ("mapToLong", "(Lcom/annimon/stream/function/DoubleToLongFunction;)Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream MapToLong (global::Com.Annimon.Stream.Function.IDoubleToLongFunction mapper)
		{
			const string __id = "mapToLong.(Lcom/annimon/stream/function/DoubleToLongFunction;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='mapToObj' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoubleFunction&lt;? extends R&gt;']]"
		[Register ("mapToObj", "(Lcom/annimon/stream/function/DoubleFunction;)Lcom/annimon/stream/Stream;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public unsafe global::Com.Annimon.Stream.Stream MapToObj (global::Com.Annimon.Stream.Function.IDoubleFunction mapper)
		{
			const string __id = "mapToObj.(Lcom/annimon/stream/function/DoubleFunction;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='max' and count(parameter)=0]"
		[Register ("max", "()Lcom/annimon/stream/OptionalDouble;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalDouble Max ()
		{
			const string __id = "max.()Lcom/annimon/stream/OptionalDouble;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalDouble> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='min' and count(parameter)=0]"
		[Register ("min", "()Lcom/annimon/stream/OptionalDouble;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalDouble Min ()
		{
			const string __id = "min.()Lcom/annimon/stream/OptionalDouble;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalDouble> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='noneMatch' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoublePredicate']]"
		[Register ("noneMatch", "(Lcom/annimon/stream/function/DoublePredicate;)Z", "")]
		public unsafe bool NoneMatch (global::Com.Annimon.Stream.Function.IDoublePredicate predicate)
		{
			const string __id = "noneMatch.(Lcom/annimon/stream/function/DoublePredicate;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='of' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.iterator.PrimitiveIterator.OfDouble']]"
		[Register ("of", "(Lcom/annimon/stream/iterator/PrimitiveIterator$OfDouble;)Lcom/annimon/stream/DoubleStream;", "")]
		public static unsafe global::Com.Annimon.Stream.DoubleStream Of (global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfDouble iterator)
		{
			const string __id = "of.(Lcom/annimon/stream/iterator/PrimitiveIterator$OfDouble;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='of' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("of", "(D)Lcom/annimon/stream/DoubleStream;", "")]
		public static unsafe global::Com.Annimon.Stream.DoubleStream Of (double t)
		{
			const string __id = "of.(D)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (t);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='of' and count(parameter)=1 and parameter[1][@type='double...']]"
		[Register ("of", "([D)Lcom/annimon/stream/DoubleStream;", "")]
		public static unsafe global::Com.Annimon.Stream.DoubleStream Of (params double[] values)
		{
			const string __id = "of.([D)Lcom/annimon/stream/DoubleStream;";
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_values);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='onClose' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("onClose", "(Ljava/lang/Runnable;)Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream OnClose (global::Java.Lang.IRunnable closeHandler)
		{
			const string __id = "onClose.(Ljava/lang/Runnable;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((closeHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) closeHandler).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='peek' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoubleConsumer']]"
		[Register ("peek", "(Lcom/annimon/stream/function/DoubleConsumer;)Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream Peek (global::Com.Annimon.Stream.Function.IDoubleConsumer action)
		{
			const string __id = "peek.(Lcom/annimon/stream/function/DoubleConsumer;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='reduce' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoubleBinaryOperator']]"
		[Register ("reduce", "(Lcom/annimon/stream/function/DoubleBinaryOperator;)Lcom/annimon/stream/OptionalDouble;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalDouble Reduce (global::Com.Annimon.Stream.Function.IDoubleBinaryOperator accumulator)
		{
			const string __id = "reduce.(Lcom/annimon/stream/function/DoubleBinaryOperator;)Lcom/annimon/stream/OptionalDouble;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((accumulator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accumulator).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalDouble> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='reduce' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='com.annimon.stream.function.DoubleBinaryOperator']]"
		[Register ("reduce", "(DLcom/annimon/stream/function/DoubleBinaryOperator;)D", "")]
		public unsafe double Reduce (double identity, global::Com.Annimon.Stream.Function.IDoubleBinaryOperator accumulator)
		{
			const string __id = "reduce.(DLcom/annimon/stream/function/DoubleBinaryOperator;)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (identity);
				__args [1] = new JniArgumentValue ((accumulator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accumulator).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='sample' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("sample", "(I)Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream Sample (int stepWidth)
		{
			const string __id = "sample.(I)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (stepWidth);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='scan' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoubleBinaryOperator']]"
		[Register ("scan", "(Lcom/annimon/stream/function/DoubleBinaryOperator;)Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream Scan (global::Com.Annimon.Stream.Function.IDoubleBinaryOperator accumulator)
		{
			const string __id = "scan.(Lcom/annimon/stream/function/DoubleBinaryOperator;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((accumulator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accumulator).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='scan' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='com.annimon.stream.function.DoubleBinaryOperator']]"
		[Register ("scan", "(DLcom/annimon/stream/function/DoubleBinaryOperator;)Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream Scan (double identity, global::Com.Annimon.Stream.Function.IDoubleBinaryOperator accumulator)
		{
			const string __id = "scan.(DLcom/annimon/stream/function/DoubleBinaryOperator;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (identity);
				__args [1] = new JniArgumentValue ((accumulator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accumulator).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='single' and count(parameter)=0]"
		[Register ("single", "()D", "")]
		public unsafe double Single ()
		{
			const string __id = "single.()D";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("skip", "(J)Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream Skip (long n)
		{
			const string __id = "skip.(J)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (n);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='sorted' and count(parameter)=0]"
		[Register ("sorted", "()Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream Sorted ()
		{
			const string __id = "sorted.()Lcom/annimon/stream/DoubleStream;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='sorted' and count(parameter)=1 and parameter[1][@type='java.util.Comparator&lt;java.lang.Double&gt;']]"
		[Register ("sorted", "(Ljava/util/Comparator;)Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream Sorted (global::Java.Util.IComparator comparator)
		{
			const string __id = "sorted.(Ljava/util/Comparator;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((comparator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) comparator).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='sum' and count(parameter)=0]"
		[Register ("sum", "()D", "")]
		public unsafe double Sum ()
		{
			const string __id = "sum.()D";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='takeUntil' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoublePredicate']]"
		[Register ("takeUntil", "(Lcom/annimon/stream/function/DoublePredicate;)Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream TakeUntil (global::Com.Annimon.Stream.Function.IDoublePredicate stopPredicate)
		{
			const string __id = "takeUntil.(Lcom/annimon/stream/function/DoublePredicate;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((stopPredicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stopPredicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='takeWhile' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoublePredicate']]"
		[Register ("takeWhile", "(Lcom/annimon/stream/function/DoublePredicate;)Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream TakeWhile (global::Com.Annimon.Stream.Function.IDoublePredicate predicate)
		{
			const string __id = "takeWhile.(Lcom/annimon/stream/function/DoublePredicate;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='DoubleStream']/method[@name='toArray' and count(parameter)=0]"
		[Register ("toArray", "()[D", "")]
		public unsafe double[] ToArray ()
		{
			const string __id = "toArray.()[D";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (double[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (double));
			} finally {
			}
		}

	}
}
