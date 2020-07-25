using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']"
	[global::Android.Runtime.Register ("com/annimon/stream/Stream", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class Stream : global::Java.Lang.Object, global::Java.IO.ICloseable {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/Stream", typeof (Stream));
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

		protected Stream (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_allMatch_Lcom_annimon_stream_function_Predicate_;
#pragma warning disable 0169
		static Delegate GetAllMatch_Lcom_annimon_stream_function_Predicate_Handler ()
		{
			if (cb_allMatch_Lcom_annimon_stream_function_Predicate_ == null)
				cb_allMatch_Lcom_annimon_stream_function_Predicate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AllMatch_Lcom_annimon_stream_function_Predicate_);
			return cb_allMatch_Lcom_annimon_stream_function_Predicate_;
		}

		static bool n_AllMatch_Lcom_annimon_stream_function_Predicate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_predicate)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IPredicate predicate = (global::Com.Annimon.Stream.Function.IPredicate)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IPredicate> (native_predicate, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AllMatch (predicate);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='allMatch' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;']]"
		[Register ("allMatch", "(Lcom/annimon/stream/function/Predicate;)Z", "GetAllMatch_Lcom_annimon_stream_function_Predicate_Handler")]
		public virtual unsafe bool AllMatch (global::Com.Annimon.Stream.Function.IPredicate predicate)
		{
			const string __id = "allMatch.(Lcom/annimon/stream/function/Predicate;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_anyMatch_Lcom_annimon_stream_function_Predicate_;
#pragma warning disable 0169
		static Delegate GetAnyMatch_Lcom_annimon_stream_function_Predicate_Handler ()
		{
			if (cb_anyMatch_Lcom_annimon_stream_function_Predicate_ == null)
				cb_anyMatch_Lcom_annimon_stream_function_Predicate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AnyMatch_Lcom_annimon_stream_function_Predicate_);
			return cb_anyMatch_Lcom_annimon_stream_function_Predicate_;
		}

		static bool n_AnyMatch_Lcom_annimon_stream_function_Predicate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_predicate)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IPredicate predicate = (global::Com.Annimon.Stream.Function.IPredicate)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IPredicate> (native_predicate, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AnyMatch (predicate);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='anyMatch' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;']]"
		[Register ("anyMatch", "(Lcom/annimon/stream/function/Predicate;)Z", "GetAnyMatch_Lcom_annimon_stream_function_Predicate_Handler")]
		public virtual unsafe bool AnyMatch (global::Com.Annimon.Stream.Function.IPredicate predicate)
		{
			const string __id = "anyMatch.(Lcom/annimon/stream/function/Predicate;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_chunkBy_Lcom_annimon_stream_function_Function_;
#pragma warning disable 0169
		static Delegate GetChunkBy_Lcom_annimon_stream_function_Function_Handler ()
		{
			if (cb_chunkBy_Lcom_annimon_stream_function_Function_ == null)
				cb_chunkBy_Lcom_annimon_stream_function_Function_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ChunkBy_Lcom_annimon_stream_function_Function_);
			return cb_chunkBy_Lcom_annimon_stream_function_Function_;
		}

		static IntPtr n_ChunkBy_Lcom_annimon_stream_function_Function_ (IntPtr jnienv, IntPtr native__this, IntPtr native_classifier)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IFunction classifier = (global::Com.Annimon.Stream.Function.IFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IFunction> (native_classifier, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ChunkBy (classifier));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='chunkBy' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends K&gt;']]"
		[Register ("chunkBy", "(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Stream;", "GetChunkBy_Lcom_annimon_stream_function_Function_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K"})]
		public virtual unsafe global::Com.Annimon.Stream.Stream ChunkBy (global::Com.Annimon.Stream.Function.IFunction classifier)
		{
			const string __id = "chunkBy.(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((classifier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) classifier).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_close;
#pragma warning disable 0169
		static Delegate GetCloseHandler ()
		{
			if (cb_close == null)
				cb_close = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Close);
			return cb_close;
		}

		static void n_Close (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='close' and count(parameter)=0]"
		[Register ("close", "()V", "GetCloseHandler")]
		public virtual unsafe void Close ()
		{
			const string __id = "close.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_collect_Lcom_annimon_stream_Collector_;
#pragma warning disable 0169
		static Delegate GetCollect_Lcom_annimon_stream_Collector_Handler ()
		{
			if (cb_collect_Lcom_annimon_stream_Collector_ == null)
				cb_collect_Lcom_annimon_stream_Collector_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Collect_Lcom_annimon_stream_Collector_);
			return cb_collect_Lcom_annimon_stream_Collector_;
		}

		static IntPtr n_Collect_Lcom_annimon_stream_Collector_ (IntPtr jnienv, IntPtr native__this, IntPtr native_collector)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.ICollector collector = (global::Com.Annimon.Stream.ICollector)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (native_collector, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Collect (collector));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='collect' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.Collector&lt;? super T, A, R&gt;']]"
		[Register ("collect", "(Lcom/annimon/stream/Collector;)Ljava/lang/Object;", "GetCollect_Lcom_annimon_stream_Collector_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R", "A"})]
		public virtual unsafe global::Java.Lang.Object Collect (global::Com.Annimon.Stream.ICollector collector)
		{
			const string __id = "collect.(Lcom/annimon/stream/Collector;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((collector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) collector).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_collect_Lcom_annimon_stream_function_Supplier_Lcom_annimon_stream_function_BiConsumer_;
#pragma warning disable 0169
		static Delegate GetCollect_Lcom_annimon_stream_function_Supplier_Lcom_annimon_stream_function_BiConsumer_Handler ()
		{
			if (cb_collect_Lcom_annimon_stream_function_Supplier_Lcom_annimon_stream_function_BiConsumer_ == null)
				cb_collect_Lcom_annimon_stream_function_Supplier_Lcom_annimon_stream_function_BiConsumer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Collect_Lcom_annimon_stream_function_Supplier_Lcom_annimon_stream_function_BiConsumer_);
			return cb_collect_Lcom_annimon_stream_function_Supplier_Lcom_annimon_stream_function_BiConsumer_;
		}

		static IntPtr n_Collect_Lcom_annimon_stream_function_Supplier_Lcom_annimon_stream_function_BiConsumer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_supplier, IntPtr native_accumulator)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.ISupplier supplier = (global::Com.Annimon.Stream.Function.ISupplier)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ISupplier> (native_supplier, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IBiConsumer accumulator = (global::Com.Annimon.Stream.Function.IBiConsumer)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IBiConsumer> (native_accumulator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Collect (supplier, accumulator));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='collect' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.Supplier&lt;R&gt;'] and parameter[2][@type='com.annimon.stream.function.BiConsumer&lt;R, ? super T&gt;']]"
		[Register ("collect", "(Lcom/annimon/stream/function/Supplier;Lcom/annimon/stream/function/BiConsumer;)Ljava/lang/Object;", "GetCollect_Lcom_annimon_stream_function_Supplier_Lcom_annimon_stream_function_BiConsumer_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public virtual unsafe global::Java.Lang.Object Collect (global::Com.Annimon.Stream.Function.ISupplier supplier, global::Com.Annimon.Stream.Function.IBiConsumer accumulator)
		{
			const string __id = "collect.(Lcom/annimon/stream/function/Supplier;Lcom/annimon/stream/function/BiConsumer;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((supplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) supplier).Handle);
				__args [1] = new JniArgumentValue ((accumulator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accumulator).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='concat' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.Stream&lt;? extends T&gt;'] and parameter[2][@type='com.annimon.stream.Stream&lt;? extends T&gt;']]"
		[Register ("concat", "(Lcom/annimon/stream/Stream;Lcom/annimon/stream/Stream;)Lcom/annimon/stream/Stream;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Stream Concat (global::Com.Annimon.Stream.Stream stream1, global::Com.Annimon.Stream.Stream stream2)
		{
			const string __id = "concat.(Lcom/annimon/stream/Stream;Lcom/annimon/stream/Stream;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((stream1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stream1).Handle);
				__args [1] = new JniArgumentValue ((stream2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stream2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='concat' and count(parameter)=2 and parameter[1][@type='java.util.Iterator&lt;? extends T&gt;'] and parameter[2][@type='java.util.Iterator&lt;? extends T&gt;']]"
		[Register ("concat", "(Ljava/util/Iterator;Ljava/util/Iterator;)Lcom/annimon/stream/Stream;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Stream Concat (global::Java.Util.IIterator iterator1, global::Java.Util.IIterator iterator2)
		{
			const string __id = "concat.(Ljava/util/Iterator;Ljava/util/Iterator;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((iterator1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator1).Handle);
				__args [1] = new JniArgumentValue ((iterator2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_count;
#pragma warning disable 0169
		static Delegate GetCountHandler ()
		{
			if (cb_count == null)
				cb_count = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_Count);
			return cb_count;
		}

		static long n_Count (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Count ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='count' and count(parameter)=0]"
		[Register ("count", "()J", "GetCountHandler")]
		public virtual unsafe long Count ()
		{
			const string __id = "count.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_custom_Lcom_annimon_stream_function_Function_;
#pragma warning disable 0169
		static Delegate GetCustom_Lcom_annimon_stream_function_Function_Handler ()
		{
			if (cb_custom_Lcom_annimon_stream_function_Function_ == null)
				cb_custom_Lcom_annimon_stream_function_Function_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Custom_Lcom_annimon_stream_function_Function_);
			return cb_custom_Lcom_annimon_stream_function_Function_;
		}

		static IntPtr n_Custom_Lcom_annimon_stream_function_Function_ (IntPtr jnienv, IntPtr native__this, IntPtr native_function)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IFunction function = (global::Com.Annimon.Stream.Function.IFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IFunction> (native_function, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Custom (function));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='custom' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;com.annimon.stream.Stream&lt;T&gt;, R&gt;']]"
		[Register ("custom", "(Lcom/annimon/stream/function/Function;)Ljava/lang/Object;", "GetCustom_Lcom_annimon_stream_function_Function_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public virtual unsafe global::Java.Lang.Object Custom (global::Com.Annimon.Stream.Function.IFunction function)
		{
			const string __id = "custom.(Lcom/annimon/stream/function/Function;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((function == null) ? IntPtr.Zero : ((global::Java.Lang.Object) function).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_distinct;
#pragma warning disable 0169
		static Delegate GetDistinctHandler ()
		{
			if (cb_distinct == null)
				cb_distinct = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Distinct);
			return cb_distinct;
		}

		static IntPtr n_Distinct (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Distinct ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='distinct' and count(parameter)=0]"
		[Register ("distinct", "()Lcom/annimon/stream/Stream;", "GetDistinctHandler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream Distinct ()
		{
			const string __id = "distinct.()Lcom/annimon/stream/Stream;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_distinctBy_Lcom_annimon_stream_function_Function_;
#pragma warning disable 0169
		static Delegate GetDistinctBy_Lcom_annimon_stream_function_Function_Handler ()
		{
			if (cb_distinctBy_Lcom_annimon_stream_function_Function_ == null)
				cb_distinctBy_Lcom_annimon_stream_function_Function_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DistinctBy_Lcom_annimon_stream_function_Function_);
			return cb_distinctBy_Lcom_annimon_stream_function_Function_;
		}

		static IntPtr n_DistinctBy_Lcom_annimon_stream_function_Function_ (IntPtr jnienv, IntPtr native__this, IntPtr native_classifier)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IFunction classifier = (global::Com.Annimon.Stream.Function.IFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IFunction> (native_classifier, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DistinctBy (classifier));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='distinctBy' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends K&gt;']]"
		[Register ("distinctBy", "(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Stream;", "GetDistinctBy_Lcom_annimon_stream_function_Function_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K"})]
		public virtual unsafe global::Com.Annimon.Stream.Stream DistinctBy (global::Com.Annimon.Stream.Function.IFunction classifier)
		{
			const string __id = "distinctBy.(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((classifier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) classifier).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_dropWhile_Lcom_annimon_stream_function_Predicate_;
#pragma warning disable 0169
		static Delegate GetDropWhile_Lcom_annimon_stream_function_Predicate_Handler ()
		{
			if (cb_dropWhile_Lcom_annimon_stream_function_Predicate_ == null)
				cb_dropWhile_Lcom_annimon_stream_function_Predicate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DropWhile_Lcom_annimon_stream_function_Predicate_);
			return cb_dropWhile_Lcom_annimon_stream_function_Predicate_;
		}

		static IntPtr n_DropWhile_Lcom_annimon_stream_function_Predicate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_predicate)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IPredicate predicate = (global::Com.Annimon.Stream.Function.IPredicate)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IPredicate> (native_predicate, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DropWhile (predicate));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='dropWhile' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;']]"
		[Register ("dropWhile", "(Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/Stream;", "GetDropWhile_Lcom_annimon_stream_function_Predicate_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream DropWhile (global::Com.Annimon.Stream.Function.IPredicate predicate)
		{
			const string __id = "dropWhile.(Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_dropWhileIndexed_Lcom_annimon_stream_function_IndexedPredicate_;
#pragma warning disable 0169
		static Delegate GetDropWhileIndexed_Lcom_annimon_stream_function_IndexedPredicate_Handler ()
		{
			if (cb_dropWhileIndexed_Lcom_annimon_stream_function_IndexedPredicate_ == null)
				cb_dropWhileIndexed_Lcom_annimon_stream_function_IndexedPredicate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_DropWhileIndexed_Lcom_annimon_stream_function_IndexedPredicate_);
			return cb_dropWhileIndexed_Lcom_annimon_stream_function_IndexedPredicate_;
		}

		static IntPtr n_DropWhileIndexed_Lcom_annimon_stream_function_IndexedPredicate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_predicate)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IIndexedPredicate predicate = (global::Com.Annimon.Stream.Function.IIndexedPredicate)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedPredicate> (native_predicate, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DropWhileIndexed (predicate));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='dropWhileIndexed' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IndexedPredicate&lt;? super T&gt;']]"
		[Register ("dropWhileIndexed", "(Lcom/annimon/stream/function/IndexedPredicate;)Lcom/annimon/stream/Stream;", "GetDropWhileIndexed_Lcom_annimon_stream_function_IndexedPredicate_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream DropWhileIndexed (global::Com.Annimon.Stream.Function.IIndexedPredicate predicate)
		{
			const string __id = "dropWhileIndexed.(Lcom/annimon/stream/function/IndexedPredicate;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_dropWhileIndexed_IILcom_annimon_stream_function_IndexedPredicate_;
#pragma warning disable 0169
		static Delegate GetDropWhileIndexed_IILcom_annimon_stream_function_IndexedPredicate_Handler ()
		{
			if (cb_dropWhileIndexed_IILcom_annimon_stream_function_IndexedPredicate_ == null)
				cb_dropWhileIndexed_IILcom_annimon_stream_function_IndexedPredicate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_DropWhileIndexed_IILcom_annimon_stream_function_IndexedPredicate_);
			return cb_dropWhileIndexed_IILcom_annimon_stream_function_IndexedPredicate_;
		}

		static IntPtr n_DropWhileIndexed_IILcom_annimon_stream_function_IndexedPredicate_ (IntPtr jnienv, IntPtr native__this, int from, int step, IntPtr native_predicate)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IIndexedPredicate predicate = (global::Com.Annimon.Stream.Function.IIndexedPredicate)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedPredicate> (native_predicate, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.DropWhileIndexed (from, step, predicate));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='dropWhileIndexed' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.annimon.stream.function.IndexedPredicate&lt;? super T&gt;']]"
		[Register ("dropWhileIndexed", "(IILcom/annimon/stream/function/IndexedPredicate;)Lcom/annimon/stream/Stream;", "GetDropWhileIndexed_IILcom_annimon_stream_function_IndexedPredicate_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream DropWhileIndexed (int from, int step, global::Com.Annimon.Stream.Function.IIndexedPredicate predicate)
		{
			const string __id = "dropWhileIndexed.(IILcom/annimon/stream/function/IndexedPredicate;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (from);
				__args [1] = new JniArgumentValue (step);
				__args [2] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='empty' and count(parameter)=0]"
		[Register ("empty", "()Lcom/annimon/stream/Stream;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Stream Empty ()
		{
			const string __id = "empty.()Lcom/annimon/stream/Stream;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_equalsOnly_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetEqualsOnly_Ljava_lang_Object_Handler ()
		{
			if (cb_equalsOnly_Ljava_lang_Object_ == null)
				cb_equalsOnly_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_EqualsOnly_Ljava_lang_Object_);
			return cb_equalsOnly_Ljava_lang_Object_;
		}

		static IntPtr n_EqualsOnly_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native__object)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object @object = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__object, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.EqualsOnly (@object));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='equalsOnly' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("equalsOnly", "(Ljava/lang/Object;)Lcom/annimon/stream/Stream;", "GetEqualsOnly_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream EqualsOnly (global::Java.Lang.Object @object)
		{
			const string __id = "equalsOnly.(Ljava/lang/Object;)Lcom/annimon/stream/Stream;";
			IntPtr native__object = JNIEnv.ToLocalJniHandle (@object);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__object);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native__object);
			}
		}

		static Delegate cb_filter_Lcom_annimon_stream_function_Predicate_;
#pragma warning disable 0169
		static Delegate GetFilter_Lcom_annimon_stream_function_Predicate_Handler ()
		{
			if (cb_filter_Lcom_annimon_stream_function_Predicate_ == null)
				cb_filter_Lcom_annimon_stream_function_Predicate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Filter_Lcom_annimon_stream_function_Predicate_);
			return cb_filter_Lcom_annimon_stream_function_Predicate_;
		}

		static IntPtr n_Filter_Lcom_annimon_stream_function_Predicate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_predicate)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IPredicate predicate = (global::Com.Annimon.Stream.Function.IPredicate)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IPredicate> (native_predicate, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Filter (predicate));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='filter' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;']]"
		[Register ("filter", "(Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/Stream;", "GetFilter_Lcom_annimon_stream_function_Predicate_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream Filter (global::Com.Annimon.Stream.Function.IPredicate predicate)
		{
			const string __id = "filter.(Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_filterIndexed_Lcom_annimon_stream_function_IndexedPredicate_;
#pragma warning disable 0169
		static Delegate GetFilterIndexed_Lcom_annimon_stream_function_IndexedPredicate_Handler ()
		{
			if (cb_filterIndexed_Lcom_annimon_stream_function_IndexedPredicate_ == null)
				cb_filterIndexed_Lcom_annimon_stream_function_IndexedPredicate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FilterIndexed_Lcom_annimon_stream_function_IndexedPredicate_);
			return cb_filterIndexed_Lcom_annimon_stream_function_IndexedPredicate_;
		}

		static IntPtr n_FilterIndexed_Lcom_annimon_stream_function_IndexedPredicate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_predicate)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IIndexedPredicate predicate = (global::Com.Annimon.Stream.Function.IIndexedPredicate)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedPredicate> (native_predicate, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FilterIndexed (predicate));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='filterIndexed' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IndexedPredicate&lt;? super T&gt;']]"
		[Register ("filterIndexed", "(Lcom/annimon/stream/function/IndexedPredicate;)Lcom/annimon/stream/Stream;", "GetFilterIndexed_Lcom_annimon_stream_function_IndexedPredicate_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream FilterIndexed (global::Com.Annimon.Stream.Function.IIndexedPredicate predicate)
		{
			const string __id = "filterIndexed.(Lcom/annimon/stream/function/IndexedPredicate;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_filterIndexed_IILcom_annimon_stream_function_IndexedPredicate_;
#pragma warning disable 0169
		static Delegate GetFilterIndexed_IILcom_annimon_stream_function_IndexedPredicate_Handler ()
		{
			if (cb_filterIndexed_IILcom_annimon_stream_function_IndexedPredicate_ == null)
				cb_filterIndexed_IILcom_annimon_stream_function_IndexedPredicate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_FilterIndexed_IILcom_annimon_stream_function_IndexedPredicate_);
			return cb_filterIndexed_IILcom_annimon_stream_function_IndexedPredicate_;
		}

		static IntPtr n_FilterIndexed_IILcom_annimon_stream_function_IndexedPredicate_ (IntPtr jnienv, IntPtr native__this, int from, int step, IntPtr native_predicate)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IIndexedPredicate predicate = (global::Com.Annimon.Stream.Function.IIndexedPredicate)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedPredicate> (native_predicate, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FilterIndexed (from, step, predicate));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='filterIndexed' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.annimon.stream.function.IndexedPredicate&lt;? super T&gt;']]"
		[Register ("filterIndexed", "(IILcom/annimon/stream/function/IndexedPredicate;)Lcom/annimon/stream/Stream;", "GetFilterIndexed_IILcom_annimon_stream_function_IndexedPredicate_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream FilterIndexed (int from, int step, global::Com.Annimon.Stream.Function.IIndexedPredicate predicate)
		{
			const string __id = "filterIndexed.(IILcom/annimon/stream/function/IndexedPredicate;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (from);
				__args [1] = new JniArgumentValue (step);
				__args [2] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_filterNot_Lcom_annimon_stream_function_Predicate_;
#pragma warning disable 0169
		static Delegate GetFilterNot_Lcom_annimon_stream_function_Predicate_Handler ()
		{
			if (cb_filterNot_Lcom_annimon_stream_function_Predicate_ == null)
				cb_filterNot_Lcom_annimon_stream_function_Predicate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FilterNot_Lcom_annimon_stream_function_Predicate_);
			return cb_filterNot_Lcom_annimon_stream_function_Predicate_;
		}

		static IntPtr n_FilterNot_Lcom_annimon_stream_function_Predicate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_predicate)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IPredicate predicate = (global::Com.Annimon.Stream.Function.IPredicate)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IPredicate> (native_predicate, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FilterNot (predicate));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='filterNot' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;']]"
		[Register ("filterNot", "(Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/Stream;", "GetFilterNot_Lcom_annimon_stream_function_Predicate_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream FilterNot (global::Com.Annimon.Stream.Function.IPredicate predicate)
		{
			const string __id = "filterNot.(Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_findFirst;
#pragma warning disable 0169
		static Delegate GetFindFirstHandler ()
		{
			if (cb_findFirst == null)
				cb_findFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FindFirst);
			return cb_findFirst;
		}

		static IntPtr n_FindFirst (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FindFirst ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='findFirst' and count(parameter)=0]"
		[Register ("findFirst", "()Lcom/annimon/stream/Optional;", "GetFindFirstHandler")]
		public virtual unsafe global::Com.Annimon.Stream.Optional FindFirst ()
		{
			const string __id = "findFirst.()Lcom/annimon/stream/Optional;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_findIndexed_Lcom_annimon_stream_function_IndexedPredicate_;
#pragma warning disable 0169
		static Delegate GetFindIndexed_Lcom_annimon_stream_function_IndexedPredicate_Handler ()
		{
			if (cb_findIndexed_Lcom_annimon_stream_function_IndexedPredicate_ == null)
				cb_findIndexed_Lcom_annimon_stream_function_IndexedPredicate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FindIndexed_Lcom_annimon_stream_function_IndexedPredicate_);
			return cb_findIndexed_Lcom_annimon_stream_function_IndexedPredicate_;
		}

		static IntPtr n_FindIndexed_Lcom_annimon_stream_function_IndexedPredicate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_predicate)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IIndexedPredicate predicate = (global::Com.Annimon.Stream.Function.IIndexedPredicate)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedPredicate> (native_predicate, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FindIndexed (predicate));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='findIndexed' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IndexedPredicate&lt;? super T&gt;']]"
		[Register ("findIndexed", "(Lcom/annimon/stream/function/IndexedPredicate;)Lcom/annimon/stream/Optional;", "GetFindIndexed_Lcom_annimon_stream_function_IndexedPredicate_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Optional FindIndexed (global::Com.Annimon.Stream.Function.IIndexedPredicate predicate)
		{
			const string __id = "findIndexed.(Lcom/annimon/stream/function/IndexedPredicate;)Lcom/annimon/stream/Optional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_findIndexed_IILcom_annimon_stream_function_IndexedPredicate_;
#pragma warning disable 0169
		static Delegate GetFindIndexed_IILcom_annimon_stream_function_IndexedPredicate_Handler ()
		{
			if (cb_findIndexed_IILcom_annimon_stream_function_IndexedPredicate_ == null)
				cb_findIndexed_IILcom_annimon_stream_function_IndexedPredicate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_FindIndexed_IILcom_annimon_stream_function_IndexedPredicate_);
			return cb_findIndexed_IILcom_annimon_stream_function_IndexedPredicate_;
		}

		static IntPtr n_FindIndexed_IILcom_annimon_stream_function_IndexedPredicate_ (IntPtr jnienv, IntPtr native__this, int from, int step, IntPtr native_predicate)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IIndexedPredicate predicate = (global::Com.Annimon.Stream.Function.IIndexedPredicate)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedPredicate> (native_predicate, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FindIndexed (from, step, predicate));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='findIndexed' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.annimon.stream.function.IndexedPredicate&lt;? super T&gt;']]"
		[Register ("findIndexed", "(IILcom/annimon/stream/function/IndexedPredicate;)Lcom/annimon/stream/Optional;", "GetFindIndexed_IILcom_annimon_stream_function_IndexedPredicate_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Optional FindIndexed (int from, int step, global::Com.Annimon.Stream.Function.IIndexedPredicate predicate)
		{
			const string __id = "findIndexed.(IILcom/annimon/stream/function/IndexedPredicate;)Lcom/annimon/stream/Optional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (from);
				__args [1] = new JniArgumentValue (step);
				__args [2] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_findLast;
#pragma warning disable 0169
		static Delegate GetFindLastHandler ()
		{
			if (cb_findLast == null)
				cb_findLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FindLast);
			return cb_findLast;
		}

		static IntPtr n_FindLast (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FindLast ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='findLast' and count(parameter)=0]"
		[Register ("findLast", "()Lcom/annimon/stream/Optional;", "GetFindLastHandler")]
		public virtual unsafe global::Com.Annimon.Stream.Optional FindLast ()
		{
			const string __id = "findLast.()Lcom/annimon/stream/Optional;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_findSingle;
#pragma warning disable 0169
		static Delegate GetFindSingleHandler ()
		{
			if (cb_findSingle == null)
				cb_findSingle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FindSingle);
			return cb_findSingle;
		}

		static IntPtr n_FindSingle (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FindSingle ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='findSingle' and count(parameter)=0]"
		[Register ("findSingle", "()Lcom/annimon/stream/Optional;", "GetFindSingleHandler")]
		public virtual unsafe global::Com.Annimon.Stream.Optional FindSingle ()
		{
			const string __id = "findSingle.()Lcom/annimon/stream/Optional;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_flatMap_Lcom_annimon_stream_function_Function_;
#pragma warning disable 0169
		static Delegate GetFlatMap_Lcom_annimon_stream_function_Function_Handler ()
		{
			if (cb_flatMap_Lcom_annimon_stream_function_Function_ == null)
				cb_flatMap_Lcom_annimon_stream_function_Function_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FlatMap_Lcom_annimon_stream_function_Function_);
			return cb_flatMap_Lcom_annimon_stream_function_Function_;
		}

		static IntPtr n_FlatMap_Lcom_annimon_stream_function_Function_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapper)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IFunction mapper = (global::Com.Annimon.Stream.Function.IFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IFunction> (native_mapper, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FlatMap (mapper));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='flatMap' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends com.annimon.stream.Stream&lt;? extends R&gt;&gt;']]"
		[Register ("flatMap", "(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Stream;", "GetFlatMap_Lcom_annimon_stream_function_Function_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public virtual unsafe global::Com.Annimon.Stream.Stream FlatMap (global::Com.Annimon.Stream.Function.IFunction mapper)
		{
			const string __id = "flatMap.(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_flatMapToDouble_Lcom_annimon_stream_function_Function_;
#pragma warning disable 0169
		static Delegate GetFlatMapToDouble_Lcom_annimon_stream_function_Function_Handler ()
		{
			if (cb_flatMapToDouble_Lcom_annimon_stream_function_Function_ == null)
				cb_flatMapToDouble_Lcom_annimon_stream_function_Function_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FlatMapToDouble_Lcom_annimon_stream_function_Function_);
			return cb_flatMapToDouble_Lcom_annimon_stream_function_Function_;
		}

		static IntPtr n_FlatMapToDouble_Lcom_annimon_stream_function_Function_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapper)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IFunction mapper = (global::Com.Annimon.Stream.Function.IFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IFunction> (native_mapper, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FlatMapToDouble (mapper));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='flatMapToDouble' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends com.annimon.stream.DoubleStream&gt;']]"
		[Register ("flatMapToDouble", "(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/DoubleStream;", "GetFlatMapToDouble_Lcom_annimon_stream_function_Function_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.DoubleStream FlatMapToDouble (global::Com.Annimon.Stream.Function.IFunction mapper)
		{
			const string __id = "flatMapToDouble.(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_flatMapToInt_Lcom_annimon_stream_function_Function_;
#pragma warning disable 0169
		static Delegate GetFlatMapToInt_Lcom_annimon_stream_function_Function_Handler ()
		{
			if (cb_flatMapToInt_Lcom_annimon_stream_function_Function_ == null)
				cb_flatMapToInt_Lcom_annimon_stream_function_Function_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FlatMapToInt_Lcom_annimon_stream_function_Function_);
			return cb_flatMapToInt_Lcom_annimon_stream_function_Function_;
		}

		static IntPtr n_FlatMapToInt_Lcom_annimon_stream_function_Function_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapper)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IFunction mapper = (global::Com.Annimon.Stream.Function.IFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IFunction> (native_mapper, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FlatMapToInt (mapper));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='flatMapToInt' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends com.annimon.stream.IntStream&gt;']]"
		[Register ("flatMapToInt", "(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/IntStream;", "GetFlatMapToInt_Lcom_annimon_stream_function_Function_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.IntStream FlatMapToInt (global::Com.Annimon.Stream.Function.IFunction mapper)
		{
			const string __id = "flatMapToInt.(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_flatMapToLong_Lcom_annimon_stream_function_Function_;
#pragma warning disable 0169
		static Delegate GetFlatMapToLong_Lcom_annimon_stream_function_Function_Handler ()
		{
			if (cb_flatMapToLong_Lcom_annimon_stream_function_Function_ == null)
				cb_flatMapToLong_Lcom_annimon_stream_function_Function_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_FlatMapToLong_Lcom_annimon_stream_function_Function_);
			return cb_flatMapToLong_Lcom_annimon_stream_function_Function_;
		}

		static IntPtr n_FlatMapToLong_Lcom_annimon_stream_function_Function_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapper)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IFunction mapper = (global::Com.Annimon.Stream.Function.IFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IFunction> (native_mapper, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FlatMapToLong (mapper));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='flatMapToLong' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends com.annimon.stream.LongStream&gt;']]"
		[Register ("flatMapToLong", "(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/LongStream;", "GetFlatMapToLong_Lcom_annimon_stream_function_Function_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.LongStream FlatMapToLong (global::Com.Annimon.Stream.Function.IFunction mapper)
		{
			const string __id = "flatMapToLong.(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_forEach_Lcom_annimon_stream_function_Consumer_;
#pragma warning disable 0169
		static Delegate GetForEach_Lcom_annimon_stream_function_Consumer_Handler ()
		{
			if (cb_forEach_Lcom_annimon_stream_function_Consumer_ == null)
				cb_forEach_Lcom_annimon_stream_function_Consumer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ForEach_Lcom_annimon_stream_function_Consumer_);
			return cb_forEach_Lcom_annimon_stream_function_Consumer_;
		}

		static void n_ForEach_Lcom_annimon_stream_function_Consumer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IConsumer action = (global::Com.Annimon.Stream.Function.IConsumer)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IConsumer> (native_action, JniHandleOwnership.DoNotTransfer);
			__this.ForEach (action);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='forEach' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Consumer&lt;? super T&gt;']]"
		[Register ("forEach", "(Lcom/annimon/stream/function/Consumer;)V", "GetForEach_Lcom_annimon_stream_function_Consumer_Handler")]
		public virtual unsafe void ForEach (global::Com.Annimon.Stream.Function.IConsumer action)
		{
			const string __id = "forEach.(Lcom/annimon/stream/function/Consumer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_forEachIndexed_Lcom_annimon_stream_function_IndexedConsumer_;
#pragma warning disable 0169
		static Delegate GetForEachIndexed_Lcom_annimon_stream_function_IndexedConsumer_Handler ()
		{
			if (cb_forEachIndexed_Lcom_annimon_stream_function_IndexedConsumer_ == null)
				cb_forEachIndexed_Lcom_annimon_stream_function_IndexedConsumer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ForEachIndexed_Lcom_annimon_stream_function_IndexedConsumer_);
			return cb_forEachIndexed_Lcom_annimon_stream_function_IndexedConsumer_;
		}

		static void n_ForEachIndexed_Lcom_annimon_stream_function_IndexedConsumer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IIndexedConsumer action = (global::Com.Annimon.Stream.Function.IIndexedConsumer)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedConsumer> (native_action, JniHandleOwnership.DoNotTransfer);
			__this.ForEachIndexed (action);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='forEachIndexed' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IndexedConsumer&lt;? super T&gt;']]"
		[Register ("forEachIndexed", "(Lcom/annimon/stream/function/IndexedConsumer;)V", "GetForEachIndexed_Lcom_annimon_stream_function_IndexedConsumer_Handler")]
		public virtual unsafe void ForEachIndexed (global::Com.Annimon.Stream.Function.IIndexedConsumer action)
		{
			const string __id = "forEachIndexed.(Lcom/annimon/stream/function/IndexedConsumer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_forEachIndexed_IILcom_annimon_stream_function_IndexedConsumer_;
#pragma warning disable 0169
		static Delegate GetForEachIndexed_IILcom_annimon_stream_function_IndexedConsumer_Handler ()
		{
			if (cb_forEachIndexed_IILcom_annimon_stream_function_IndexedConsumer_ == null)
				cb_forEachIndexed_IILcom_annimon_stream_function_IndexedConsumer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_ForEachIndexed_IILcom_annimon_stream_function_IndexedConsumer_);
			return cb_forEachIndexed_IILcom_annimon_stream_function_IndexedConsumer_;
		}

		static void n_ForEachIndexed_IILcom_annimon_stream_function_IndexedConsumer_ (IntPtr jnienv, IntPtr native__this, int from, int step, IntPtr native_action)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IIndexedConsumer action = (global::Com.Annimon.Stream.Function.IIndexedConsumer)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedConsumer> (native_action, JniHandleOwnership.DoNotTransfer);
			__this.ForEachIndexed (from, step, action);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='forEachIndexed' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.annimon.stream.function.IndexedConsumer&lt;? super T&gt;']]"
		[Register ("forEachIndexed", "(IILcom/annimon/stream/function/IndexedConsumer;)V", "GetForEachIndexed_IILcom_annimon_stream_function_IndexedConsumer_Handler")]
		public virtual unsafe void ForEachIndexed (int from, int step, global::Com.Annimon.Stream.Function.IIndexedConsumer action)
		{
			const string __id = "forEachIndexed.(IILcom/annimon/stream/function/IndexedConsumer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (from);
				__args [1] = new JniArgumentValue (step);
				__args [2] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='generate' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Supplier&lt;T&gt;']]"
		[Register ("generate", "(Lcom/annimon/stream/function/Supplier;)Lcom/annimon/stream/Stream;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Stream Generate (global::Com.Annimon.Stream.Function.ISupplier supplier)
		{
			const string __id = "generate.(Lcom/annimon/stream/function/Supplier;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((supplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) supplier).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_groupBy_Lcom_annimon_stream_function_Function_;
#pragma warning disable 0169
		static Delegate GetGroupBy_Lcom_annimon_stream_function_Function_Handler ()
		{
			if (cb_groupBy_Lcom_annimon_stream_function_Function_ == null)
				cb_groupBy_Lcom_annimon_stream_function_Function_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GroupBy_Lcom_annimon_stream_function_Function_);
			return cb_groupBy_Lcom_annimon_stream_function_Function_;
		}

		static IntPtr n_GroupBy_Lcom_annimon_stream_function_Function_ (IntPtr jnienv, IntPtr native__this, IntPtr native_classifier)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IFunction classifier = (global::Com.Annimon.Stream.Function.IFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IFunction> (native_classifier, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GroupBy (classifier));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='groupBy' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends K&gt;']]"
		[Register ("groupBy", "(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Stream;", "GetGroupBy_Lcom_annimon_stream_function_Function_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K"})]
		public virtual unsafe global::Com.Annimon.Stream.Stream GroupBy (global::Com.Annimon.Stream.Function.IFunction classifier)
		{
			const string __id = "groupBy.(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((classifier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) classifier).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_indexed;
#pragma warning disable 0169
		static Delegate GetIndexedHandler ()
		{
			if (cb_indexed == null)
				cb_indexed = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Indexed);
			return cb_indexed;
		}

		static IntPtr n_Indexed (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Indexed ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='indexed' and count(parameter)=0]"
		[Register ("indexed", "()Lcom/annimon/stream/Stream;", "GetIndexedHandler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream Indexed ()
		{
			const string __id = "indexed.()Lcom/annimon/stream/Stream;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_indexed_II;
#pragma warning disable 0169
		static Delegate GetIndexed_IIHandler ()
		{
			if (cb_indexed_II == null)
				cb_indexed_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_Indexed_II);
			return cb_indexed_II;
		}

		static IntPtr n_Indexed_II (IntPtr jnienv, IntPtr native__this, int from, int step)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Indexed (from, step));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='indexed' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("indexed", "(II)Lcom/annimon/stream/Stream;", "GetIndexed_IIHandler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream Indexed (int from, int step)
		{
			const string __id = "indexed.(II)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (from);
				__args [1] = new JniArgumentValue (step);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='iterate' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;'] and parameter[3][@type='com.annimon.stream.function.UnaryOperator&lt;T&gt;']]"
		[Register ("iterate", "(Ljava/lang/Object;Lcom/annimon/stream/function/Predicate;Lcom/annimon/stream/function/UnaryOperator;)Lcom/annimon/stream/Stream;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Stream Iterate (global::Java.Lang.Object seed, global::Com.Annimon.Stream.Function.IPredicate predicate, global::Com.Annimon.Stream.Function.IUnaryOperator op)
		{
			const string __id = "iterate.(Ljava/lang/Object;Lcom/annimon/stream/function/Predicate;Lcom/annimon/stream/function/UnaryOperator;)Lcom/annimon/stream/Stream;";
			IntPtr native_seed = JNIEnv.ToLocalJniHandle (seed);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_seed);
				__args [1] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				__args [2] = new JniArgumentValue ((op == null) ? IntPtr.Zero : ((global::Java.Lang.Object) op).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_seed);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='iterate' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='com.annimon.stream.function.UnaryOperator&lt;T&gt;']]"
		[Register ("iterate", "(Ljava/lang/Object;Lcom/annimon/stream/function/UnaryOperator;)Lcom/annimon/stream/Stream;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Stream Iterate (global::Java.Lang.Object seed, global::Com.Annimon.Stream.Function.IUnaryOperator op)
		{
			const string __id = "iterate.(Ljava/lang/Object;Lcom/annimon/stream/function/UnaryOperator;)Lcom/annimon/stream/Stream;";
			IntPtr native_seed = JNIEnv.ToLocalJniHandle (seed);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_seed);
				__args [1] = new JniArgumentValue ((op == null) ? IntPtr.Zero : ((global::Java.Lang.Object) op).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_seed);
			}
		}

		static Delegate cb_iterator;
#pragma warning disable 0169
		static Delegate GetIteratorHandler ()
		{
			if (cb_iterator == null)
				cb_iterator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Iterator);
			return cb_iterator;
		}

		static IntPtr n_Iterator (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Iterator ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='iterator' and count(parameter)=0]"
		[Register ("iterator", "()Ljava/util/Iterator;", "GetIteratorHandler")]
		public virtual unsafe global::Java.Util.IIterator Iterator ()
		{
			const string __id = "iterator.()Ljava/util/Iterator;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IIterator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_limit_J;
#pragma warning disable 0169
		static Delegate GetLimit_JHandler ()
		{
			if (cb_limit_J == null)
				cb_limit_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_Limit_J);
			return cb_limit_J;
		}

		static IntPtr n_Limit_J (IntPtr jnienv, IntPtr native__this, long maxSize)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Limit (maxSize));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='limit' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("limit", "(J)Lcom/annimon/stream/Stream;", "GetLimit_JHandler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream Limit (long maxSize)
		{
			const string __id = "limit.(J)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxSize);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_map_Lcom_annimon_stream_function_Function_;
#pragma warning disable 0169
		static Delegate GetMap_Lcom_annimon_stream_function_Function_Handler ()
		{
			if (cb_map_Lcom_annimon_stream_function_Function_ == null)
				cb_map_Lcom_annimon_stream_function_Function_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Map_Lcom_annimon_stream_function_Function_);
			return cb_map_Lcom_annimon_stream_function_Function_;
		}

		static IntPtr n_Map_Lcom_annimon_stream_function_Function_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapper)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IFunction mapper = (global::Com.Annimon.Stream.Function.IFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IFunction> (native_mapper, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Map (mapper));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='map' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends R&gt;']]"
		[Register ("map", "(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Stream;", "GetMap_Lcom_annimon_stream_function_Function_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public virtual unsafe global::Com.Annimon.Stream.Stream Map (global::Com.Annimon.Stream.Function.IFunction mapper)
		{
			const string __id = "map.(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_mapIndexed_Lcom_annimon_stream_function_IndexedFunction_;
#pragma warning disable 0169
		static Delegate GetMapIndexed_Lcom_annimon_stream_function_IndexedFunction_Handler ()
		{
			if (cb_mapIndexed_Lcom_annimon_stream_function_IndexedFunction_ == null)
				cb_mapIndexed_Lcom_annimon_stream_function_IndexedFunction_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MapIndexed_Lcom_annimon_stream_function_IndexedFunction_);
			return cb_mapIndexed_Lcom_annimon_stream_function_IndexedFunction_;
		}

		static IntPtr n_MapIndexed_Lcom_annimon_stream_function_IndexedFunction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapper)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IIndexedFunction mapper = (global::Com.Annimon.Stream.Function.IIndexedFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedFunction> (native_mapper, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MapIndexed (mapper));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='mapIndexed' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IndexedFunction&lt;? super T, ? extends R&gt;']]"
		[Register ("mapIndexed", "(Lcom/annimon/stream/function/IndexedFunction;)Lcom/annimon/stream/Stream;", "GetMapIndexed_Lcom_annimon_stream_function_IndexedFunction_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public virtual unsafe global::Com.Annimon.Stream.Stream MapIndexed (global::Com.Annimon.Stream.Function.IIndexedFunction mapper)
		{
			const string __id = "mapIndexed.(Lcom/annimon/stream/function/IndexedFunction;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_mapIndexed_IILcom_annimon_stream_function_IndexedFunction_;
#pragma warning disable 0169
		static Delegate GetMapIndexed_IILcom_annimon_stream_function_IndexedFunction_Handler ()
		{
			if (cb_mapIndexed_IILcom_annimon_stream_function_IndexedFunction_ == null)
				cb_mapIndexed_IILcom_annimon_stream_function_IndexedFunction_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_MapIndexed_IILcom_annimon_stream_function_IndexedFunction_);
			return cb_mapIndexed_IILcom_annimon_stream_function_IndexedFunction_;
		}

		static IntPtr n_MapIndexed_IILcom_annimon_stream_function_IndexedFunction_ (IntPtr jnienv, IntPtr native__this, int from, int step, IntPtr native_mapper)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IIndexedFunction mapper = (global::Com.Annimon.Stream.Function.IIndexedFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedFunction> (native_mapper, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MapIndexed (from, step, mapper));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='mapIndexed' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.annimon.stream.function.IndexedFunction&lt;? super T, ? extends R&gt;']]"
		[Register ("mapIndexed", "(IILcom/annimon/stream/function/IndexedFunction;)Lcom/annimon/stream/Stream;", "GetMapIndexed_IILcom_annimon_stream_function_IndexedFunction_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public virtual unsafe global::Com.Annimon.Stream.Stream MapIndexed (int from, int step, global::Com.Annimon.Stream.Function.IIndexedFunction mapper)
		{
			const string __id = "mapIndexed.(IILcom/annimon/stream/function/IndexedFunction;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (from);
				__args [1] = new JniArgumentValue (step);
				__args [2] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_mapToDouble_Lcom_annimon_stream_function_ToDoubleFunction_;
#pragma warning disable 0169
		static Delegate GetMapToDouble_Lcom_annimon_stream_function_ToDoubleFunction_Handler ()
		{
			if (cb_mapToDouble_Lcom_annimon_stream_function_ToDoubleFunction_ == null)
				cb_mapToDouble_Lcom_annimon_stream_function_ToDoubleFunction_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MapToDouble_Lcom_annimon_stream_function_ToDoubleFunction_);
			return cb_mapToDouble_Lcom_annimon_stream_function_ToDoubleFunction_;
		}

		static IntPtr n_MapToDouble_Lcom_annimon_stream_function_ToDoubleFunction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapper)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IToDoubleFunction mapper = (global::Com.Annimon.Stream.Function.IToDoubleFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IToDoubleFunction> (native_mapper, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MapToDouble (mapper));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='mapToDouble' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ToDoubleFunction&lt;? super T&gt;']]"
		[Register ("mapToDouble", "(Lcom/annimon/stream/function/ToDoubleFunction;)Lcom/annimon/stream/DoubleStream;", "GetMapToDouble_Lcom_annimon_stream_function_ToDoubleFunction_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.DoubleStream MapToDouble (global::Com.Annimon.Stream.Function.IToDoubleFunction mapper)
		{
			const string __id = "mapToDouble.(Lcom/annimon/stream/function/ToDoubleFunction;)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_mapToInt_Lcom_annimon_stream_function_ToIntFunction_;
#pragma warning disable 0169
		static Delegate GetMapToInt_Lcom_annimon_stream_function_ToIntFunction_Handler ()
		{
			if (cb_mapToInt_Lcom_annimon_stream_function_ToIntFunction_ == null)
				cb_mapToInt_Lcom_annimon_stream_function_ToIntFunction_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MapToInt_Lcom_annimon_stream_function_ToIntFunction_);
			return cb_mapToInt_Lcom_annimon_stream_function_ToIntFunction_;
		}

		static IntPtr n_MapToInt_Lcom_annimon_stream_function_ToIntFunction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapper)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IToIntFunction mapper = (global::Com.Annimon.Stream.Function.IToIntFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IToIntFunction> (native_mapper, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MapToInt (mapper));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='mapToInt' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ToIntFunction&lt;? super T&gt;']]"
		[Register ("mapToInt", "(Lcom/annimon/stream/function/ToIntFunction;)Lcom/annimon/stream/IntStream;", "GetMapToInt_Lcom_annimon_stream_function_ToIntFunction_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.IntStream MapToInt (global::Com.Annimon.Stream.Function.IToIntFunction mapper)
		{
			const string __id = "mapToInt.(Lcom/annimon/stream/function/ToIntFunction;)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_mapToLong_Lcom_annimon_stream_function_ToLongFunction_;
#pragma warning disable 0169
		static Delegate GetMapToLong_Lcom_annimon_stream_function_ToLongFunction_Handler ()
		{
			if (cb_mapToLong_Lcom_annimon_stream_function_ToLongFunction_ == null)
				cb_mapToLong_Lcom_annimon_stream_function_ToLongFunction_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MapToLong_Lcom_annimon_stream_function_ToLongFunction_);
			return cb_mapToLong_Lcom_annimon_stream_function_ToLongFunction_;
		}

		static IntPtr n_MapToLong_Lcom_annimon_stream_function_ToLongFunction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapper)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IToLongFunction mapper = (global::Com.Annimon.Stream.Function.IToLongFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IToLongFunction> (native_mapper, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MapToLong (mapper));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='mapToLong' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ToLongFunction&lt;? super T&gt;']]"
		[Register ("mapToLong", "(Lcom/annimon/stream/function/ToLongFunction;)Lcom/annimon/stream/LongStream;", "GetMapToLong_Lcom_annimon_stream_function_ToLongFunction_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.LongStream MapToLong (global::Com.Annimon.Stream.Function.IToLongFunction mapper)
		{
			const string __id = "mapToLong.(Lcom/annimon/stream/function/ToLongFunction;)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_max_Ljava_util_Comparator_;
#pragma warning disable 0169
		static Delegate GetMax_Ljava_util_Comparator_Handler ()
		{
			if (cb_max_Ljava_util_Comparator_ == null)
				cb_max_Ljava_util_Comparator_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Max_Ljava_util_Comparator_);
			return cb_max_Ljava_util_Comparator_;
		}

		static IntPtr n_Max_Ljava_util_Comparator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_comparator)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.IComparator comparator = (global::Java.Util.IComparator)global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (native_comparator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Max (comparator));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='max' and count(parameter)=1 and parameter[1][@type='java.util.Comparator&lt;? super T&gt;']]"
		[Register ("max", "(Ljava/util/Comparator;)Lcom/annimon/stream/Optional;", "GetMax_Ljava_util_Comparator_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Optional Max (global::Java.Util.IComparator comparator)
		{
			const string __id = "max.(Ljava/util/Comparator;)Lcom/annimon/stream/Optional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((comparator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) comparator).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='merge' and count(parameter)=3 and parameter[1][@type='com.annimon.stream.Stream&lt;? extends T&gt;'] and parameter[2][@type='com.annimon.stream.Stream&lt;? extends T&gt;'] and parameter[3][@type='com.annimon.stream.function.BiFunction&lt;? super T, ? super T, com.annimon.stream.operator.ObjMerge.MergeResult&gt;']]"
		[Register ("merge", "(Lcom/annimon/stream/Stream;Lcom/annimon/stream/Stream;Lcom/annimon/stream/function/BiFunction;)Lcom/annimon/stream/Stream;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Stream Merge (global::Com.Annimon.Stream.Stream stream1, global::Com.Annimon.Stream.Stream stream2, global::Com.Annimon.Stream.Function.IBiFunction selector)
		{
			const string __id = "merge.(Lcom/annimon/stream/Stream;Lcom/annimon/stream/Stream;Lcom/annimon/stream/function/BiFunction;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((stream1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stream1).Handle);
				__args [1] = new JniArgumentValue ((stream2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stream2).Handle);
				__args [2] = new JniArgumentValue ((selector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) selector).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='merge' and count(parameter)=3 and parameter[1][@type='java.util.Iterator&lt;? extends T&gt;'] and parameter[2][@type='java.util.Iterator&lt;? extends T&gt;'] and parameter[3][@type='com.annimon.stream.function.BiFunction&lt;? super T, ? super T, com.annimon.stream.operator.ObjMerge.MergeResult&gt;']]"
		[Register ("merge", "(Ljava/util/Iterator;Ljava/util/Iterator;Lcom/annimon/stream/function/BiFunction;)Lcom/annimon/stream/Stream;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Stream Merge (global::Java.Util.IIterator iterator1, global::Java.Util.IIterator iterator2, global::Com.Annimon.Stream.Function.IBiFunction selector)
		{
			const string __id = "merge.(Ljava/util/Iterator;Ljava/util/Iterator;Lcom/annimon/stream/function/BiFunction;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((iterator1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator1).Handle);
				__args [1] = new JniArgumentValue ((iterator2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator2).Handle);
				__args [2] = new JniArgumentValue ((selector == null) ? IntPtr.Zero : ((global::Java.Lang.Object) selector).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_min_Ljava_util_Comparator_;
#pragma warning disable 0169
		static Delegate GetMin_Ljava_util_Comparator_Handler ()
		{
			if (cb_min_Ljava_util_Comparator_ == null)
				cb_min_Ljava_util_Comparator_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Min_Ljava_util_Comparator_);
			return cb_min_Ljava_util_Comparator_;
		}

		static IntPtr n_Min_Ljava_util_Comparator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_comparator)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.IComparator comparator = (global::Java.Util.IComparator)global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (native_comparator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Min (comparator));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='min' and count(parameter)=1 and parameter[1][@type='java.util.Comparator&lt;? super T&gt;']]"
		[Register ("min", "(Ljava/util/Comparator;)Lcom/annimon/stream/Optional;", "GetMin_Ljava_util_Comparator_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Optional Min (global::Java.Util.IComparator comparator)
		{
			const string __id = "min.(Ljava/util/Comparator;)Lcom/annimon/stream/Optional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((comparator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) comparator).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_noneMatch_Lcom_annimon_stream_function_Predicate_;
#pragma warning disable 0169
		static Delegate GetNoneMatch_Lcom_annimon_stream_function_Predicate_Handler ()
		{
			if (cb_noneMatch_Lcom_annimon_stream_function_Predicate_ == null)
				cb_noneMatch_Lcom_annimon_stream_function_Predicate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_NoneMatch_Lcom_annimon_stream_function_Predicate_);
			return cb_noneMatch_Lcom_annimon_stream_function_Predicate_;
		}

		static bool n_NoneMatch_Lcom_annimon_stream_function_Predicate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_predicate)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IPredicate predicate = (global::Com.Annimon.Stream.Function.IPredicate)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IPredicate> (native_predicate, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.NoneMatch (predicate);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='noneMatch' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;']]"
		[Register ("noneMatch", "(Lcom/annimon/stream/function/Predicate;)Z", "GetNoneMatch_Lcom_annimon_stream_function_Predicate_Handler")]
		public virtual unsafe bool NoneMatch (global::Com.Annimon.Stream.Function.IPredicate predicate)
		{
			const string __id = "noneMatch.(Lcom/annimon/stream/function/Predicate;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_nullsOnly;
#pragma warning disable 0169
		static Delegate GetNullsOnlyHandler ()
		{
			if (cb_nullsOnly == null)
				cb_nullsOnly = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_NullsOnly);
			return cb_nullsOnly;
		}

		static IntPtr n_NullsOnly (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NullsOnly ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='nullsOnly' and count(parameter)=0]"
		[Register ("nullsOnly", "()Lcom/annimon/stream/Stream;", "GetNullsOnlyHandler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream NullsOnly ()
		{
			const string __id = "nullsOnly.()Lcom/annimon/stream/Stream;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='of' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;? extends T&gt;']]"
		[Register ("of", "(Ljava/lang/Iterable;)Lcom/annimon/stream/Stream;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Stream Of (global::Java.Lang.IIterable iterable)
		{
			const string __id = "of.(Ljava/lang/Iterable;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((iterable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterable).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='of' and count(parameter)=1 and parameter[1][@type='java.util.Iterator&lt;? extends T&gt;']]"
		[Register ("of", "(Ljava/util/Iterator;)Lcom/annimon/stream/Stream;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Stream Of (global::Java.Util.IIterator iterator)
		{
			const string __id = "of.(Ljava/util/Iterator;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='of' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;K, V&gt;']]"
		[Register ("of", "(Ljava/util/Map;)Lcom/annimon/stream/Stream;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public static unsafe global::Com.Annimon.Stream.Stream Of (global::System.Collections.IDictionary map)
		{
			const string __id = "of.(Ljava/util/Map;)Lcom/annimon/stream/Stream;";
			IntPtr native_map = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (map);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_map);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_map);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='of' and count(parameter)=1 and parameter[1][@type='T...']]"
		[Register ("of", "([Ljava/lang/Object;)Lcom/annimon/stream/Stream;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Stream Of (params global::Java.Lang.Object[] elements)
		{
			const string __id = "of.([Ljava/lang/Object;)Lcom/annimon/stream/Stream;";
			IntPtr native_elements = JNIEnv.NewArray (elements);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_elements);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (elements != null) {
					JNIEnv.CopyArray (native_elements, elements);
					JNIEnv.DeleteLocalRef (native_elements);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='ofNullable' and count(parameter)=1 and parameter[1][@type='java.lang.Iterable&lt;? extends T&gt;']]"
		[Register ("ofNullable", "(Ljava/lang/Iterable;)Lcom/annimon/stream/Stream;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Stream OfNullable (global::Java.Lang.IIterable iterable)
		{
			const string __id = "ofNullable.(Ljava/lang/Iterable;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((iterable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterable).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='ofNullable' and count(parameter)=1 and parameter[1][@type='java.util.Iterator&lt;? extends T&gt;']]"
		[Register ("ofNullable", "(Ljava/util/Iterator;)Lcom/annimon/stream/Stream;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Stream OfNullable (global::Java.Util.IIterator iterator)
		{
			const string __id = "ofNullable.(Ljava/util/Iterator;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='ofNullable' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;K, V&gt;']]"
		[Register ("ofNullable", "(Ljava/util/Map;)Lcom/annimon/stream/Stream;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"K", "V"})]
		public static unsafe global::Com.Annimon.Stream.Stream OfNullable (global::System.Collections.IDictionary map)
		{
			const string __id = "ofNullable.(Ljava/util/Map;)Lcom/annimon/stream/Stream;";
			IntPtr native_map = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (map);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_map);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_map);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='ofNullable' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("ofNullable", "(Ljava/lang/Object;)Lcom/annimon/stream/Stream;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Stream OfNullable (global::Java.Lang.Object element)
		{
			const string __id = "ofNullable.(Ljava/lang/Object;)Lcom/annimon/stream/Stream;";
			IntPtr native_element = JNIEnv.ToLocalJniHandle (element);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_element);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_element);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='ofNullable' and count(parameter)=1 and parameter[1][@type='T[]']]"
		[Register ("ofNullable", "([Ljava/lang/Object;)Lcom/annimon/stream/Stream;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Stream OfNullable (global::Java.Lang.Object[] array)
		{
			const string __id = "ofNullable.([Ljava/lang/Object;)Lcom/annimon/stream/Stream;";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_array);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		static Delegate cb_onClose_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetOnClose_Ljava_lang_Runnable_Handler ()
		{
			if (cb_onClose_Ljava_lang_Runnable_ == null)
				cb_onClose_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnClose_Ljava_lang_Runnable_);
			return cb_onClose_Ljava_lang_Runnable_;
		}

		static IntPtr n_OnClose_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_closeHandler)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable closeHandler = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_closeHandler, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OnClose (closeHandler));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='onClose' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("onClose", "(Ljava/lang/Runnable;)Lcom/annimon/stream/Stream;", "GetOnClose_Ljava_lang_Runnable_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream OnClose (global::Java.Lang.IRunnable closeHandler)
		{
			const string __id = "onClose.(Ljava/lang/Runnable;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((closeHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) closeHandler).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_peek_Lcom_annimon_stream_function_Consumer_;
#pragma warning disable 0169
		static Delegate GetPeek_Lcom_annimon_stream_function_Consumer_Handler ()
		{
			if (cb_peek_Lcom_annimon_stream_function_Consumer_ == null)
				cb_peek_Lcom_annimon_stream_function_Consumer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Peek_Lcom_annimon_stream_function_Consumer_);
			return cb_peek_Lcom_annimon_stream_function_Consumer_;
		}

		static IntPtr n_Peek_Lcom_annimon_stream_function_Consumer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IConsumer action = (global::Com.Annimon.Stream.Function.IConsumer)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IConsumer> (native_action, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Peek (action));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='peek' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Consumer&lt;? super T&gt;']]"
		[Register ("peek", "(Lcom/annimon/stream/function/Consumer;)Lcom/annimon/stream/Stream;", "GetPeek_Lcom_annimon_stream_function_Consumer_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream Peek (global::Com.Annimon.Stream.Function.IConsumer action)
		{
			const string __id = "peek.(Lcom/annimon/stream/function/Consumer;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='range' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("range", "(II)Lcom/annimon/stream/Stream;", "")]
		public static unsafe global::Com.Annimon.Stream.Stream Range (int from, int to)
		{
			const string __id = "range.(II)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (from);
				__args [1] = new JniArgumentValue (to);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='range' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("range", "(JJ)Lcom/annimon/stream/Stream;", "")]
		public static unsafe global::Com.Annimon.Stream.Stream Range (long from, long to)
		{
			const string __id = "range.(JJ)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (from);
				__args [1] = new JniArgumentValue (to);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='rangeClosed' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("rangeClosed", "(II)Lcom/annimon/stream/Stream;", "")]
		public static unsafe global::Com.Annimon.Stream.Stream RangeClosed (int from, int to)
		{
			const string __id = "rangeClosed.(II)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (from);
				__args [1] = new JniArgumentValue (to);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='rangeClosed' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("rangeClosed", "(JJ)Lcom/annimon/stream/Stream;", "")]
		public static unsafe global::Com.Annimon.Stream.Stream RangeClosed (long from, long to)
		{
			const string __id = "rangeClosed.(JJ)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (from);
				__args [1] = new JniArgumentValue (to);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_reduce_Lcom_annimon_stream_function_BiFunction_;
#pragma warning disable 0169
		static Delegate GetReduce_Lcom_annimon_stream_function_BiFunction_Handler ()
		{
			if (cb_reduce_Lcom_annimon_stream_function_BiFunction_ == null)
				cb_reduce_Lcom_annimon_stream_function_BiFunction_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Reduce_Lcom_annimon_stream_function_BiFunction_);
			return cb_reduce_Lcom_annimon_stream_function_BiFunction_;
		}

		static IntPtr n_Reduce_Lcom_annimon_stream_function_BiFunction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_accumulator)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IBiFunction accumulator = (global::Com.Annimon.Stream.Function.IBiFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IBiFunction> (native_accumulator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Reduce (accumulator));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='reduce' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.BiFunction&lt;T, T, T&gt;']]"
		[Register ("reduce", "(Lcom/annimon/stream/function/BiFunction;)Lcom/annimon/stream/Optional;", "GetReduce_Lcom_annimon_stream_function_BiFunction_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Optional Reduce (global::Com.Annimon.Stream.Function.IBiFunction accumulator)
		{
			const string __id = "reduce.(Lcom/annimon/stream/function/BiFunction;)Lcom/annimon/stream/Optional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((accumulator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accumulator).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_reduce_Ljava_lang_Object_Lcom_annimon_stream_function_BiFunction_;
#pragma warning disable 0169
		static Delegate GetReduce_Ljava_lang_Object_Lcom_annimon_stream_function_BiFunction_Handler ()
		{
			if (cb_reduce_Ljava_lang_Object_Lcom_annimon_stream_function_BiFunction_ == null)
				cb_reduce_Ljava_lang_Object_Lcom_annimon_stream_function_BiFunction_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Reduce_Ljava_lang_Object_Lcom_annimon_stream_function_BiFunction_);
			return cb_reduce_Ljava_lang_Object_Lcom_annimon_stream_function_BiFunction_;
		}

		static IntPtr n_Reduce_Ljava_lang_Object_Lcom_annimon_stream_function_BiFunction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_identity, IntPtr native_accumulator)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object identity = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_identity, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IBiFunction accumulator = (global::Com.Annimon.Stream.Function.IBiFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IBiFunction> (native_accumulator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Reduce (identity, accumulator));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='reduce' and count(parameter)=2 and parameter[1][@type='R'] and parameter[2][@type='com.annimon.stream.function.BiFunction&lt;? super R, ? super T, ? extends R&gt;']]"
		[Register ("reduce", "(Ljava/lang/Object;Lcom/annimon/stream/function/BiFunction;)Ljava/lang/Object;", "GetReduce_Ljava_lang_Object_Lcom_annimon_stream_function_BiFunction_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public virtual unsafe global::Java.Lang.Object Reduce (global::Java.Lang.Object identity, global::Com.Annimon.Stream.Function.IBiFunction accumulator)
		{
			const string __id = "reduce.(Ljava/lang/Object;Lcom/annimon/stream/function/BiFunction;)Ljava/lang/Object;";
			IntPtr native_identity = JNIEnv.ToLocalJniHandle (identity);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_identity);
				__args [1] = new JniArgumentValue ((accumulator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accumulator).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_identity);
			}
		}

		static Delegate cb_reduceIndexed_IILjava_lang_Object_Lcom_annimon_stream_function_IndexedBiFunction_;
#pragma warning disable 0169
		static Delegate GetReduceIndexed_IILjava_lang_Object_Lcom_annimon_stream_function_IndexedBiFunction_Handler ()
		{
			if (cb_reduceIndexed_IILjava_lang_Object_Lcom_annimon_stream_function_IndexedBiFunction_ == null)
				cb_reduceIndexed_IILjava_lang_Object_Lcom_annimon_stream_function_IndexedBiFunction_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr, IntPtr>) n_ReduceIndexed_IILjava_lang_Object_Lcom_annimon_stream_function_IndexedBiFunction_);
			return cb_reduceIndexed_IILjava_lang_Object_Lcom_annimon_stream_function_IndexedBiFunction_;
		}

		static IntPtr n_ReduceIndexed_IILjava_lang_Object_Lcom_annimon_stream_function_IndexedBiFunction_ (IntPtr jnienv, IntPtr native__this, int from, int step, IntPtr native_identity, IntPtr native_accumulator)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object identity = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_identity, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IIndexedBiFunction accumulator = (global::Com.Annimon.Stream.Function.IIndexedBiFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedBiFunction> (native_accumulator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReduceIndexed (from, step, identity, accumulator));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='reduceIndexed' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='R'] and parameter[4][@type='com.annimon.stream.function.IndexedBiFunction&lt;? super R, ? super T, ? extends R&gt;']]"
		[Register ("reduceIndexed", "(IILjava/lang/Object;Lcom/annimon/stream/function/IndexedBiFunction;)Ljava/lang/Object;", "GetReduceIndexed_IILjava_lang_Object_Lcom_annimon_stream_function_IndexedBiFunction_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public virtual unsafe global::Java.Lang.Object ReduceIndexed (int from, int step, global::Java.Lang.Object identity, global::Com.Annimon.Stream.Function.IIndexedBiFunction accumulator)
		{
			const string __id = "reduceIndexed.(IILjava/lang/Object;Lcom/annimon/stream/function/IndexedBiFunction;)Ljava/lang/Object;";
			IntPtr native_identity = JNIEnv.ToLocalJniHandle (identity);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (from);
				__args [1] = new JniArgumentValue (step);
				__args [2] = new JniArgumentValue (native_identity);
				__args [3] = new JniArgumentValue ((accumulator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accumulator).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_identity);
			}
		}

		static Delegate cb_reduceIndexed_Ljava_lang_Object_Lcom_annimon_stream_function_IndexedBiFunction_;
#pragma warning disable 0169
		static Delegate GetReduceIndexed_Ljava_lang_Object_Lcom_annimon_stream_function_IndexedBiFunction_Handler ()
		{
			if (cb_reduceIndexed_Ljava_lang_Object_Lcom_annimon_stream_function_IndexedBiFunction_ == null)
				cb_reduceIndexed_Ljava_lang_Object_Lcom_annimon_stream_function_IndexedBiFunction_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_ReduceIndexed_Ljava_lang_Object_Lcom_annimon_stream_function_IndexedBiFunction_);
			return cb_reduceIndexed_Ljava_lang_Object_Lcom_annimon_stream_function_IndexedBiFunction_;
		}

		static IntPtr n_ReduceIndexed_Ljava_lang_Object_Lcom_annimon_stream_function_IndexedBiFunction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_identity, IntPtr native_accumulator)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object identity = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_identity, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IIndexedBiFunction accumulator = (global::Com.Annimon.Stream.Function.IIndexedBiFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedBiFunction> (native_accumulator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ReduceIndexed (identity, accumulator));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='reduceIndexed' and count(parameter)=2 and parameter[1][@type='R'] and parameter[2][@type='com.annimon.stream.function.IndexedBiFunction&lt;? super R, ? super T, ? extends R&gt;']]"
		[Register ("reduceIndexed", "(Ljava/lang/Object;Lcom/annimon/stream/function/IndexedBiFunction;)Ljava/lang/Object;", "GetReduceIndexed_Ljava_lang_Object_Lcom_annimon_stream_function_IndexedBiFunction_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public virtual unsafe global::Java.Lang.Object ReduceIndexed (global::Java.Lang.Object identity, global::Com.Annimon.Stream.Function.IIndexedBiFunction accumulator)
		{
			const string __id = "reduceIndexed.(Ljava/lang/Object;Lcom/annimon/stream/function/IndexedBiFunction;)Ljava/lang/Object;";
			IntPtr native_identity = JNIEnv.ToLocalJniHandle (identity);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_identity);
				__args [1] = new JniArgumentValue ((accumulator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accumulator).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_identity);
			}
		}

		static Delegate cb_sample_I;
#pragma warning disable 0169
		static Delegate GetSample_IHandler ()
		{
			if (cb_sample_I == null)
				cb_sample_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_Sample_I);
			return cb_sample_I;
		}

		static IntPtr n_Sample_I (IntPtr jnienv, IntPtr native__this, int stepWidth)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Sample (stepWidth));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='sample' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("sample", "(I)Lcom/annimon/stream/Stream;", "GetSample_IHandler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream Sample (int stepWidth)
		{
			const string __id = "sample.(I)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (stepWidth);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_scan_Lcom_annimon_stream_function_BiFunction_;
#pragma warning disable 0169
		static Delegate GetScan_Lcom_annimon_stream_function_BiFunction_Handler ()
		{
			if (cb_scan_Lcom_annimon_stream_function_BiFunction_ == null)
				cb_scan_Lcom_annimon_stream_function_BiFunction_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Scan_Lcom_annimon_stream_function_BiFunction_);
			return cb_scan_Lcom_annimon_stream_function_BiFunction_;
		}

		static IntPtr n_Scan_Lcom_annimon_stream_function_BiFunction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_accumulator)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IBiFunction accumulator = (global::Com.Annimon.Stream.Function.IBiFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IBiFunction> (native_accumulator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Scan (accumulator));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='scan' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.BiFunction&lt;T, T, T&gt;']]"
		[Register ("scan", "(Lcom/annimon/stream/function/BiFunction;)Lcom/annimon/stream/Stream;", "GetScan_Lcom_annimon_stream_function_BiFunction_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream Scan (global::Com.Annimon.Stream.Function.IBiFunction accumulator)
		{
			const string __id = "scan.(Lcom/annimon/stream/function/BiFunction;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((accumulator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accumulator).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_scan_Ljava_lang_Object_Lcom_annimon_stream_function_BiFunction_;
#pragma warning disable 0169
		static Delegate GetScan_Ljava_lang_Object_Lcom_annimon_stream_function_BiFunction_Handler ()
		{
			if (cb_scan_Ljava_lang_Object_Lcom_annimon_stream_function_BiFunction_ == null)
				cb_scan_Ljava_lang_Object_Lcom_annimon_stream_function_BiFunction_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_Scan_Ljava_lang_Object_Lcom_annimon_stream_function_BiFunction_);
			return cb_scan_Ljava_lang_Object_Lcom_annimon_stream_function_BiFunction_;
		}

		static IntPtr n_Scan_Ljava_lang_Object_Lcom_annimon_stream_function_BiFunction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_identity, IntPtr native_accumulator)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object identity = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_identity, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IBiFunction accumulator = (global::Com.Annimon.Stream.Function.IBiFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IBiFunction> (native_accumulator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Scan (identity, accumulator));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='scan' and count(parameter)=2 and parameter[1][@type='R'] and parameter[2][@type='com.annimon.stream.function.BiFunction&lt;? super R, ? super T, ? extends R&gt;']]"
		[Register ("scan", "(Ljava/lang/Object;Lcom/annimon/stream/function/BiFunction;)Lcom/annimon/stream/Stream;", "GetScan_Ljava_lang_Object_Lcom_annimon_stream_function_BiFunction_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public virtual unsafe global::Com.Annimon.Stream.Stream Scan (global::Java.Lang.Object identity, global::Com.Annimon.Stream.Function.IBiFunction accumulator)
		{
			const string __id = "scan.(Ljava/lang/Object;Lcom/annimon/stream/function/BiFunction;)Lcom/annimon/stream/Stream;";
			IntPtr native_identity = JNIEnv.ToLocalJniHandle (identity);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_identity);
				__args [1] = new JniArgumentValue ((accumulator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) accumulator).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_identity);
			}
		}

		static Delegate cb_select_Ljava_lang_Class_;
#pragma warning disable 0169
		static Delegate GetSelect_Ljava_lang_Class_Handler ()
		{
			if (cb_select_Ljava_lang_Class_ == null)
				cb_select_Ljava_lang_Class_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Select_Ljava_lang_Class_);
			return cb_select_Ljava_lang_Class_;
		}

		static IntPtr n_Select_Ljava_lang_Class_ (IntPtr jnienv, IntPtr native__this, IntPtr native_clazz)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class clazz = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_clazz, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Select (clazz));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='select' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;TT&gt;']]"
		[Register ("select", "(Ljava/lang/Class;)Lcom/annimon/stream/Stream;", "GetSelect_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"TT"})]
		public virtual unsafe global::Com.Annimon.Stream.Stream Select (global::Java.Lang.Class clazz)
		{
			const string __id = "select.(Ljava/lang/Class;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_single;
#pragma warning disable 0169
		static Delegate GetSingleHandler ()
		{
			if (cb_single == null)
				cb_single = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Single);
			return cb_single;
		}

		static IntPtr n_Single (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Single ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='single' and count(parameter)=0]"
		[Register ("single", "()Ljava/lang/Object;", "GetSingleHandler")]
		public virtual unsafe global::Java.Lang.Object Single ()
		{
			const string __id = "single.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_skip_J;
#pragma warning disable 0169
		static Delegate GetSkip_JHandler ()
		{
			if (cb_skip_J == null)
				cb_skip_J = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long, IntPtr>) n_Skip_J);
			return cb_skip_J;
		}

		static IntPtr n_Skip_J (IntPtr jnienv, IntPtr native__this, long n)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Skip (n));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='skip' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("skip", "(J)Lcom/annimon/stream/Stream;", "GetSkip_JHandler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream Skip (long n)
		{
			const string __id = "skip.(J)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (n);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_slidingWindow_I;
#pragma warning disable 0169
		static Delegate GetSlidingWindow_IHandler ()
		{
			if (cb_slidingWindow_I == null)
				cb_slidingWindow_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_SlidingWindow_I);
			return cb_slidingWindow_I;
		}

		static IntPtr n_SlidingWindow_I (IntPtr jnienv, IntPtr native__this, int windowSize)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SlidingWindow (windowSize));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='slidingWindow' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("slidingWindow", "(I)Lcom/annimon/stream/Stream;", "GetSlidingWindow_IHandler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream SlidingWindow (int windowSize)
		{
			const string __id = "slidingWindow.(I)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (windowSize);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_slidingWindow_II;
#pragma warning disable 0169
		static Delegate GetSlidingWindow_IIHandler ()
		{
			if (cb_slidingWindow_II == null)
				cb_slidingWindow_II = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr>) n_SlidingWindow_II);
			return cb_slidingWindow_II;
		}

		static IntPtr n_SlidingWindow_II (IntPtr jnienv, IntPtr native__this, int windowSize, int stepWidth)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SlidingWindow (windowSize, stepWidth));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='slidingWindow' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("slidingWindow", "(II)Lcom/annimon/stream/Stream;", "GetSlidingWindow_IIHandler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream SlidingWindow (int windowSize, int stepWidth)
		{
			const string __id = "slidingWindow.(II)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (windowSize);
				__args [1] = new JniArgumentValue (stepWidth);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_sortBy_Lcom_annimon_stream_function_Function_;
#pragma warning disable 0169
		static Delegate GetSortBy_Lcom_annimon_stream_function_Function_Handler ()
		{
			if (cb_sortBy_Lcom_annimon_stream_function_Function_ == null)
				cb_sortBy_Lcom_annimon_stream_function_Function_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_SortBy_Lcom_annimon_stream_function_Function_);
			return cb_sortBy_Lcom_annimon_stream_function_Function_;
		}

		static IntPtr n_SortBy_Lcom_annimon_stream_function_Function_ (IntPtr jnienv, IntPtr native__this, IntPtr native_f)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IFunction f = (global::Com.Annimon.Stream.Function.IFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IFunction> (native_f, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.SortBy (f));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='sortBy' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends R&gt;']]"
		[Register ("sortBy", "(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Stream;", "GetSortBy_Lcom_annimon_stream_function_Function_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R extends java.lang.Comparable<? super R>"})]
		public virtual unsafe global::Com.Annimon.Stream.Stream SortBy (global::Com.Annimon.Stream.Function.IFunction f)
		{
			const string __id = "sortBy.(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_sorted;
#pragma warning disable 0169
		static Delegate GetSortedHandler ()
		{
			if (cb_sorted == null)
				cb_sorted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Sorted);
			return cb_sorted;
		}

		static IntPtr n_Sorted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Sorted ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='sorted' and count(parameter)=0]"
		[Register ("sorted", "()Lcom/annimon/stream/Stream;", "GetSortedHandler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream Sorted ()
		{
			const string __id = "sorted.()Lcom/annimon/stream/Stream;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_sorted_Ljava_util_Comparator_;
#pragma warning disable 0169
		static Delegate GetSorted_Ljava_util_Comparator_Handler ()
		{
			if (cb_sorted_Ljava_util_Comparator_ == null)
				cb_sorted_Ljava_util_Comparator_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Sorted_Ljava_util_Comparator_);
			return cb_sorted_Ljava_util_Comparator_;
		}

		static IntPtr n_Sorted_Ljava_util_Comparator_ (IntPtr jnienv, IntPtr native__this, IntPtr native_comparator)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.IComparator comparator = (global::Java.Util.IComparator)global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (native_comparator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Sorted (comparator));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='sorted' and count(parameter)=1 and parameter[1][@type='java.util.Comparator&lt;? super T&gt;']]"
		[Register ("sorted", "(Ljava/util/Comparator;)Lcom/annimon/stream/Stream;", "GetSorted_Ljava_util_Comparator_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream Sorted (global::Java.Util.IComparator comparator)
		{
			const string __id = "sorted.(Ljava/util/Comparator;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((comparator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) comparator).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_takeUntil_Lcom_annimon_stream_function_Predicate_;
#pragma warning disable 0169
		static Delegate GetTakeUntil_Lcom_annimon_stream_function_Predicate_Handler ()
		{
			if (cb_takeUntil_Lcom_annimon_stream_function_Predicate_ == null)
				cb_takeUntil_Lcom_annimon_stream_function_Predicate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TakeUntil_Lcom_annimon_stream_function_Predicate_);
			return cb_takeUntil_Lcom_annimon_stream_function_Predicate_;
		}

		static IntPtr n_TakeUntil_Lcom_annimon_stream_function_Predicate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_stopPredicate)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IPredicate stopPredicate = (global::Com.Annimon.Stream.Function.IPredicate)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IPredicate> (native_stopPredicate, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TakeUntil (stopPredicate));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='takeUntil' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;']]"
		[Register ("takeUntil", "(Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/Stream;", "GetTakeUntil_Lcom_annimon_stream_function_Predicate_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream TakeUntil (global::Com.Annimon.Stream.Function.IPredicate stopPredicate)
		{
			const string __id = "takeUntil.(Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((stopPredicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stopPredicate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_takeUntilIndexed_Lcom_annimon_stream_function_IndexedPredicate_;
#pragma warning disable 0169
		static Delegate GetTakeUntilIndexed_Lcom_annimon_stream_function_IndexedPredicate_Handler ()
		{
			if (cb_takeUntilIndexed_Lcom_annimon_stream_function_IndexedPredicate_ == null)
				cb_takeUntilIndexed_Lcom_annimon_stream_function_IndexedPredicate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TakeUntilIndexed_Lcom_annimon_stream_function_IndexedPredicate_);
			return cb_takeUntilIndexed_Lcom_annimon_stream_function_IndexedPredicate_;
		}

		static IntPtr n_TakeUntilIndexed_Lcom_annimon_stream_function_IndexedPredicate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_stopPredicate)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IIndexedPredicate stopPredicate = (global::Com.Annimon.Stream.Function.IIndexedPredicate)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedPredicate> (native_stopPredicate, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TakeUntilIndexed (stopPredicate));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='takeUntilIndexed' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IndexedPredicate&lt;? super T&gt;']]"
		[Register ("takeUntilIndexed", "(Lcom/annimon/stream/function/IndexedPredicate;)Lcom/annimon/stream/Stream;", "GetTakeUntilIndexed_Lcom_annimon_stream_function_IndexedPredicate_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream TakeUntilIndexed (global::Com.Annimon.Stream.Function.IIndexedPredicate stopPredicate)
		{
			const string __id = "takeUntilIndexed.(Lcom/annimon/stream/function/IndexedPredicate;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((stopPredicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stopPredicate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_takeUntilIndexed_IILcom_annimon_stream_function_IndexedPredicate_;
#pragma warning disable 0169
		static Delegate GetTakeUntilIndexed_IILcom_annimon_stream_function_IndexedPredicate_Handler ()
		{
			if (cb_takeUntilIndexed_IILcom_annimon_stream_function_IndexedPredicate_ == null)
				cb_takeUntilIndexed_IILcom_annimon_stream_function_IndexedPredicate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_TakeUntilIndexed_IILcom_annimon_stream_function_IndexedPredicate_);
			return cb_takeUntilIndexed_IILcom_annimon_stream_function_IndexedPredicate_;
		}

		static IntPtr n_TakeUntilIndexed_IILcom_annimon_stream_function_IndexedPredicate_ (IntPtr jnienv, IntPtr native__this, int from, int step, IntPtr native_stopPredicate)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IIndexedPredicate stopPredicate = (global::Com.Annimon.Stream.Function.IIndexedPredicate)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedPredicate> (native_stopPredicate, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TakeUntilIndexed (from, step, stopPredicate));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='takeUntilIndexed' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.annimon.stream.function.IndexedPredicate&lt;? super T&gt;']]"
		[Register ("takeUntilIndexed", "(IILcom/annimon/stream/function/IndexedPredicate;)Lcom/annimon/stream/Stream;", "GetTakeUntilIndexed_IILcom_annimon_stream_function_IndexedPredicate_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream TakeUntilIndexed (int from, int step, global::Com.Annimon.Stream.Function.IIndexedPredicate stopPredicate)
		{
			const string __id = "takeUntilIndexed.(IILcom/annimon/stream/function/IndexedPredicate;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (from);
				__args [1] = new JniArgumentValue (step);
				__args [2] = new JniArgumentValue ((stopPredicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stopPredicate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_takeWhile_Lcom_annimon_stream_function_Predicate_;
#pragma warning disable 0169
		static Delegate GetTakeWhile_Lcom_annimon_stream_function_Predicate_Handler ()
		{
			if (cb_takeWhile_Lcom_annimon_stream_function_Predicate_ == null)
				cb_takeWhile_Lcom_annimon_stream_function_Predicate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TakeWhile_Lcom_annimon_stream_function_Predicate_);
			return cb_takeWhile_Lcom_annimon_stream_function_Predicate_;
		}

		static IntPtr n_TakeWhile_Lcom_annimon_stream_function_Predicate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_predicate)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IPredicate predicate = (global::Com.Annimon.Stream.Function.IPredicate)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IPredicate> (native_predicate, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TakeWhile (predicate));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='takeWhile' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;']]"
		[Register ("takeWhile", "(Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/Stream;", "GetTakeWhile_Lcom_annimon_stream_function_Predicate_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream TakeWhile (global::Com.Annimon.Stream.Function.IPredicate predicate)
		{
			const string __id = "takeWhile.(Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_takeWhileIndexed_Lcom_annimon_stream_function_IndexedPredicate_;
#pragma warning disable 0169
		static Delegate GetTakeWhileIndexed_Lcom_annimon_stream_function_IndexedPredicate_Handler ()
		{
			if (cb_takeWhileIndexed_Lcom_annimon_stream_function_IndexedPredicate_ == null)
				cb_takeWhileIndexed_Lcom_annimon_stream_function_IndexedPredicate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_TakeWhileIndexed_Lcom_annimon_stream_function_IndexedPredicate_);
			return cb_takeWhileIndexed_Lcom_annimon_stream_function_IndexedPredicate_;
		}

		static IntPtr n_TakeWhileIndexed_Lcom_annimon_stream_function_IndexedPredicate_ (IntPtr jnienv, IntPtr native__this, IntPtr native_predicate)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IIndexedPredicate predicate = (global::Com.Annimon.Stream.Function.IIndexedPredicate)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedPredicate> (native_predicate, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TakeWhileIndexed (predicate));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='takeWhileIndexed' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IndexedPredicate&lt;? super T&gt;']]"
		[Register ("takeWhileIndexed", "(Lcom/annimon/stream/function/IndexedPredicate;)Lcom/annimon/stream/Stream;", "GetTakeWhileIndexed_Lcom_annimon_stream_function_IndexedPredicate_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream TakeWhileIndexed (global::Com.Annimon.Stream.Function.IIndexedPredicate predicate)
		{
			const string __id = "takeWhileIndexed.(Lcom/annimon/stream/function/IndexedPredicate;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_takeWhileIndexed_IILcom_annimon_stream_function_IndexedPredicate_;
#pragma warning disable 0169
		static Delegate GetTakeWhileIndexed_IILcom_annimon_stream_function_IndexedPredicate_Handler ()
		{
			if (cb_takeWhileIndexed_IILcom_annimon_stream_function_IndexedPredicate_ == null)
				cb_takeWhileIndexed_IILcom_annimon_stream_function_IndexedPredicate_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_TakeWhileIndexed_IILcom_annimon_stream_function_IndexedPredicate_);
			return cb_takeWhileIndexed_IILcom_annimon_stream_function_IndexedPredicate_;
		}

		static IntPtr n_TakeWhileIndexed_IILcom_annimon_stream_function_IndexedPredicate_ (IntPtr jnienv, IntPtr native__this, int from, int step, IntPtr native_predicate)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IIndexedPredicate predicate = (global::Com.Annimon.Stream.Function.IIndexedPredicate)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIndexedPredicate> (native_predicate, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.TakeWhileIndexed (from, step, predicate));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='takeWhileIndexed' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.annimon.stream.function.IndexedPredicate&lt;? super T&gt;']]"
		[Register ("takeWhileIndexed", "(IILcom/annimon/stream/function/IndexedPredicate;)Lcom/annimon/stream/Stream;", "GetTakeWhileIndexed_IILcom_annimon_stream_function_IndexedPredicate_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream TakeWhileIndexed (int from, int step, global::Com.Annimon.Stream.Function.IIndexedPredicate predicate)
		{
			const string __id = "takeWhileIndexed.(IILcom/annimon/stream/function/IndexedPredicate;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (from);
				__args [1] = new JniArgumentValue (step);
				__args [2] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_toArray;
#pragma warning disable 0169
		static Delegate GetToArrayHandler ()
		{
			if (cb_toArray == null)
				cb_toArray = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToArray);
			return cb_toArray;
		}

		static IntPtr n_ToArray (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ToArray ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='toArray' and count(parameter)=0]"
		[Register ("toArray", "()[Ljava/lang/Object;", "GetToArrayHandler")]
		public virtual unsafe global::Java.Lang.Object[] ToArray ()
		{
			const string __id = "toArray.()[Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
			}
		}

		static Delegate cb_toArray_Lcom_annimon_stream_function_IntFunction_;
#pragma warning disable 0169
		static Delegate GetToArray_Lcom_annimon_stream_function_IntFunction_Handler ()
		{
			if (cb_toArray_Lcom_annimon_stream_function_IntFunction_ == null)
				cb_toArray_Lcom_annimon_stream_function_IntFunction_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ToArray_Lcom_annimon_stream_function_IntFunction_);
			return cb_toArray_Lcom_annimon_stream_function_IntFunction_;
		}

		static IntPtr n_ToArray_Lcom_annimon_stream_function_IntFunction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_generator)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IIntFunction generator = (global::Com.Annimon.Stream.Function.IIntFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IIntFunction> (native_generator, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.ToArray (generator));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='toArray' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntFunction&lt;R[]&gt;']]"
		[Register ("toArray", "(Lcom/annimon/stream/function/IntFunction;)[Ljava/lang/Object;", "GetToArray_Lcom_annimon_stream_function_IntFunction_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public virtual unsafe global::Java.Lang.Object[] ToArray (global::Com.Annimon.Stream.Function.IIntFunction generator)
		{
			const string __id = "toArray.(Lcom/annimon/stream/function/IntFunction;)[Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((generator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) generator).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::Java.Lang.Object));
			} finally {
			}
		}

		static Delegate cb_toList;
#pragma warning disable 0169
		static Delegate GetToListHandler ()
		{
			if (cb_toList == null)
				cb_toList = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToList);
			return cb_toList;
		}

		static IntPtr n_ToList (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.ToList ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='toList' and count(parameter)=0]"
		[Register ("toList", "()Ljava/util/List;", "GetToListHandler")]
		public virtual unsafe global::System.Collections.IList ToList ()
		{
			const string __id = "toList.()Ljava/util/List;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_withoutNulls;
#pragma warning disable 0169
		static Delegate GetWithoutNullsHandler ()
		{
			if (cb_withoutNulls == null)
				cb_withoutNulls = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_WithoutNulls);
			return cb_withoutNulls;
		}

		static IntPtr n_WithoutNulls (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Stream __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.WithoutNulls ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='withoutNulls' and count(parameter)=0]"
		[Register ("withoutNulls", "()Lcom/annimon/stream/Stream;", "GetWithoutNullsHandler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream WithoutNulls ()
		{
			const string __id = "withoutNulls.()Lcom/annimon/stream/Stream;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='zip' and count(parameter)=3 and parameter[1][@type='com.annimon.stream.Stream&lt;? extends F&gt;'] and parameter[2][@type='com.annimon.stream.Stream&lt;? extends S&gt;'] and parameter[3][@type='com.annimon.stream.function.BiFunction&lt;? super F, ? super S, ? extends R&gt;']]"
		[Register ("zip", "(Lcom/annimon/stream/Stream;Lcom/annimon/stream/Stream;Lcom/annimon/stream/function/BiFunction;)Lcom/annimon/stream/Stream;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"F", "S", "R"})]
		public static unsafe global::Com.Annimon.Stream.Stream Zip (global::Com.Annimon.Stream.Stream stream1, global::Com.Annimon.Stream.Stream stream2, global::Com.Annimon.Stream.Function.IBiFunction combiner)
		{
			const string __id = "zip.(Lcom/annimon/stream/Stream;Lcom/annimon/stream/Stream;Lcom/annimon/stream/function/BiFunction;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((stream1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stream1).Handle);
				__args [1] = new JniArgumentValue ((stream2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) stream2).Handle);
				__args [2] = new JniArgumentValue ((combiner == null) ? IntPtr.Zero : ((global::Java.Lang.Object) combiner).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Stream']/method[@name='zip' and count(parameter)=3 and parameter[1][@type='java.util.Iterator&lt;? extends F&gt;'] and parameter[2][@type='java.util.Iterator&lt;? extends S&gt;'] and parameter[3][@type='com.annimon.stream.function.BiFunction&lt;? super F, ? super S, ? extends R&gt;']]"
		[Register ("zip", "(Ljava/util/Iterator;Ljava/util/Iterator;Lcom/annimon/stream/function/BiFunction;)Lcom/annimon/stream/Stream;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"F", "S", "R"})]
		public static unsafe global::Com.Annimon.Stream.Stream Zip (global::Java.Util.IIterator iterator1, global::Java.Util.IIterator iterator2, global::Com.Annimon.Stream.Function.IBiFunction combiner)
		{
			const string __id = "zip.(Ljava/util/Iterator;Ljava/util/Iterator;Lcom/annimon/stream/function/BiFunction;)Lcom/annimon/stream/Stream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((iterator1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator1).Handle);
				__args [1] = new JniArgumentValue ((iterator2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator2).Handle);
				__args [2] = new JniArgumentValue ((combiner == null) ? IntPtr.Zero : ((global::Java.Lang.Object) combiner).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
