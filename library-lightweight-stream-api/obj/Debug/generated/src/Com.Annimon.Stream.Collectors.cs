using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']"
	[global::Android.Runtime.Register ("com/annimon/stream/Collectors", DoNotGenerateAcw=true)]
	public sealed partial class Collectors : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/Collectors", typeof (Collectors));
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

		internal Collectors (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='averaging' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, java.lang.Double&gt;']]"
		[Obsolete (@"deprecated")]
		[Register ("averaging", "(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.ICollector Averaging (global::Com.Annimon.Stream.Function.IFunction mapper)
		{
			const string __id = "averaging.(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Collector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='averagingDouble' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ToDoubleFunction&lt;? super T&gt;']]"
		[Register ("averagingDouble", "(Lcom/annimon/stream/function/ToDoubleFunction;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.ICollector AveragingDouble (global::Com.Annimon.Stream.Function.IToDoubleFunction mapper)
		{
			const string __id = "averagingDouble.(Lcom/annimon/stream/function/ToDoubleFunction;)Lcom/annimon/stream/Collector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='averagingInt' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ToIntFunction&lt;? super T&gt;']]"
		[Register ("averagingInt", "(Lcom/annimon/stream/function/ToIntFunction;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.ICollector AveragingInt (global::Com.Annimon.Stream.Function.IToIntFunction mapper)
		{
			const string __id = "averagingInt.(Lcom/annimon/stream/function/ToIntFunction;)Lcom/annimon/stream/Collector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='averagingLong' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ToLongFunction&lt;? super T&gt;']]"
		[Register ("averagingLong", "(Lcom/annimon/stream/function/ToLongFunction;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.ICollector AveragingLong (global::Com.Annimon.Stream.Function.IToLongFunction mapper)
		{
			const string __id = "averagingLong.(Lcom/annimon/stream/function/ToLongFunction;)Lcom/annimon/stream/Collector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='collectingAndThen' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.Collector&lt;T, A, IR&gt;'] and parameter[2][@type='com.annimon.stream.function.Function&lt;IR, OR&gt;']]"
		[Register ("collectingAndThen", "(Lcom/annimon/stream/Collector;Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "A", "IR", "OR"})]
		public static unsafe global::Com.Annimon.Stream.ICollector CollectingAndThen (global::Com.Annimon.Stream.ICollector c, global::Com.Annimon.Stream.Function.IFunction finisher)
		{
			const string __id = "collectingAndThen.(Lcom/annimon/stream/Collector;Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Collector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue ((finisher == null) ? IntPtr.Zero : ((global::Java.Lang.Object) finisher).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='counting' and count(parameter)=0]"
		[Register ("counting", "()Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.ICollector Counting ()
		{
			const string __id = "counting.()Lcom/annimon/stream/Collector;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='filtering' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;'] and parameter[2][@type='com.annimon.stream.Collector&lt;? super T, A, R&gt;']]"
		[Register ("filtering", "(Lcom/annimon/stream/function/Predicate;Lcom/annimon/stream/Collector;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "A", "R"})]
		public static unsafe global::Com.Annimon.Stream.ICollector Filtering (global::Com.Annimon.Stream.Function.IPredicate predicate, global::Com.Annimon.Stream.ICollector downstream)
		{
			const string __id = "filtering.(Lcom/annimon/stream/function/Predicate;Lcom/annimon/stream/Collector;)Lcom/annimon/stream/Collector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				__args [1] = new JniArgumentValue ((downstream == null) ? IntPtr.Zero : ((global::Java.Lang.Object) downstream).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='flatMapping' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends com.annimon.stream.Stream&lt;? extends U&gt;&gt;'] and parameter[2][@type='com.annimon.stream.Collector&lt;? super U, A, R&gt;']]"
		[Register ("flatMapping", "(Lcom/annimon/stream/function/Function;Lcom/annimon/stream/Collector;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U", "A", "R"})]
		public static unsafe global::Com.Annimon.Stream.ICollector FlatMapping (global::Com.Annimon.Stream.Function.IFunction mapper, global::Com.Annimon.Stream.ICollector downstream)
		{
			const string __id = "flatMapping.(Lcom/annimon/stream/function/Function;Lcom/annimon/stream/Collector;)Lcom/annimon/stream/Collector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				__args [1] = new JniArgumentValue ((downstream == null) ? IntPtr.Zero : ((global::Java.Lang.Object) downstream).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='groupingBy' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends K&gt;']]"
		[Register ("groupingBy", "(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "K"})]
		public static unsafe global::Com.Annimon.Stream.ICollector GroupingBy (global::Com.Annimon.Stream.Function.IFunction classifier)
		{
			const string __id = "groupingBy.(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Collector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((classifier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) classifier).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='groupingBy' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends K&gt;'] and parameter[2][@type='com.annimon.stream.Collector&lt;? super T, A, D&gt;']]"
		[Register ("groupingBy", "(Lcom/annimon/stream/function/Function;Lcom/annimon/stream/Collector;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "K", "A", "D"})]
		public static unsafe global::Com.Annimon.Stream.ICollector GroupingBy (global::Com.Annimon.Stream.Function.IFunction classifier, global::Com.Annimon.Stream.ICollector downstream)
		{
			const string __id = "groupingBy.(Lcom/annimon/stream/function/Function;Lcom/annimon/stream/Collector;)Lcom/annimon/stream/Collector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((classifier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) classifier).Handle);
				__args [1] = new JniArgumentValue ((downstream == null) ? IntPtr.Zero : ((global::Java.Lang.Object) downstream).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='groupingBy' and count(parameter)=3 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends K&gt;'] and parameter[2][@type='com.annimon.stream.function.Supplier&lt;M&gt;'] and parameter[3][@type='com.annimon.stream.Collector&lt;? super T, A, D&gt;']]"
		[Register ("groupingBy", "(Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/Supplier;Lcom/annimon/stream/Collector;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "K", "D", "A", "M extends java.util.Map<K, D>"})]
		public static unsafe global::Com.Annimon.Stream.ICollector GroupingBy (global::Com.Annimon.Stream.Function.IFunction classifier, global::Com.Annimon.Stream.Function.ISupplier mapFactory, global::Com.Annimon.Stream.ICollector downstream)
		{
			const string __id = "groupingBy.(Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/Supplier;Lcom/annimon/stream/Collector;)Lcom/annimon/stream/Collector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((classifier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) classifier).Handle);
				__args [1] = new JniArgumentValue ((mapFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapFactory).Handle);
				__args [2] = new JniArgumentValue ((downstream == null) ? IntPtr.Zero : ((global::Java.Lang.Object) downstream).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='joining' and count(parameter)=0]"
		[Register ("joining", "()Lcom/annimon/stream/Collector;", "")]
		public static unsafe global::Com.Annimon.Stream.ICollector Joining ()
		{
			const string __id = "joining.()Lcom/annimon/stream/Collector;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='joining' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
		[Register ("joining", "(Ljava/lang/CharSequence;)Lcom/annimon/stream/Collector;", "")]
		public static unsafe global::Com.Annimon.Stream.ICollector Joining (global::Java.Lang.ICharSequence delimiter)
		{
			const string __id = "joining.(Ljava/lang/CharSequence;)Lcom/annimon/stream/Collector;";
			IntPtr native_delimiter = CharSequence.ToLocalJniHandle (delimiter);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_delimiter);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_delimiter);
			}
		}

		public static global::Com.Annimon.Stream.ICollector Joining (string delimiter)
		{
			global::Java.Lang.String jls_delimiter = delimiter == null ? null : new global::Java.Lang.String (delimiter);
			global::Com.Annimon.Stream.ICollector __result = Joining (jls_delimiter);
			var __rsval = __result;
			jls_delimiter?.Dispose ();
			return __rsval;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='joining' and count(parameter)=3 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='java.lang.CharSequence']]"
		[Register ("joining", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Lcom/annimon/stream/Collector;", "")]
		public static unsafe global::Com.Annimon.Stream.ICollector Joining (global::Java.Lang.ICharSequence delimiter, global::Java.Lang.ICharSequence prefix, global::Java.Lang.ICharSequence suffix)
		{
			const string __id = "joining.(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Lcom/annimon/stream/Collector;";
			IntPtr native_delimiter = CharSequence.ToLocalJniHandle (delimiter);
			IntPtr native_prefix = CharSequence.ToLocalJniHandle (prefix);
			IntPtr native_suffix = CharSequence.ToLocalJniHandle (suffix);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_delimiter);
				__args [1] = new JniArgumentValue (native_prefix);
				__args [2] = new JniArgumentValue (native_suffix);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_delimiter);
				JNIEnv.DeleteLocalRef (native_prefix);
				JNIEnv.DeleteLocalRef (native_suffix);
			}
		}

		public static global::Com.Annimon.Stream.ICollector Joining (string delimiter, string prefix, string suffix)
		{
			global::Java.Lang.String jls_delimiter = delimiter == null ? null : new global::Java.Lang.String (delimiter);
			global::Java.Lang.String jls_prefix = prefix == null ? null : new global::Java.Lang.String (prefix);
			global::Java.Lang.String jls_suffix = suffix == null ? null : new global::Java.Lang.String (suffix);
			global::Com.Annimon.Stream.ICollector __result = Joining (jls_delimiter, jls_prefix, jls_suffix);
			var __rsval = __result;
			jls_delimiter?.Dispose ();
			jls_prefix?.Dispose ();
			jls_suffix?.Dispose ();
			return __rsval;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='joining' and count(parameter)=4 and parameter[1][@type='java.lang.CharSequence'] and parameter[2][@type='java.lang.CharSequence'] and parameter[3][@type='java.lang.CharSequence'] and parameter[4][@type='java.lang.String']]"
		[Register ("joining", "(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Ljava/lang/String;)Lcom/annimon/stream/Collector;", "")]
		public static unsafe global::Com.Annimon.Stream.ICollector Joining (global::Java.Lang.ICharSequence delimiter, global::Java.Lang.ICharSequence prefix, global::Java.Lang.ICharSequence suffix, string emptyValue)
		{
			const string __id = "joining.(Ljava/lang/CharSequence;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Ljava/lang/String;)Lcom/annimon/stream/Collector;";
			IntPtr native_delimiter = CharSequence.ToLocalJniHandle (delimiter);
			IntPtr native_prefix = CharSequence.ToLocalJniHandle (prefix);
			IntPtr native_suffix = CharSequence.ToLocalJniHandle (suffix);
			IntPtr native_emptyValue = JNIEnv.NewString (emptyValue);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (native_delimiter);
				__args [1] = new JniArgumentValue (native_prefix);
				__args [2] = new JniArgumentValue (native_suffix);
				__args [3] = new JniArgumentValue (native_emptyValue);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_delimiter);
				JNIEnv.DeleteLocalRef (native_prefix);
				JNIEnv.DeleteLocalRef (native_suffix);
				JNIEnv.DeleteLocalRef (native_emptyValue);
			}
		}

		public static global::Com.Annimon.Stream.ICollector Joining (string delimiter, string prefix, string suffix, string emptyValue)
		{
			global::Java.Lang.String jls_delimiter = delimiter == null ? null : new global::Java.Lang.String (delimiter);
			global::Java.Lang.String jls_prefix = prefix == null ? null : new global::Java.Lang.String (prefix);
			global::Java.Lang.String jls_suffix = suffix == null ? null : new global::Java.Lang.String (suffix);
			global::Com.Annimon.Stream.ICollector __result = Joining (jls_delimiter, jls_prefix, jls_suffix, emptyValue);
			var __rsval = __result;
			jls_delimiter?.Dispose ();
			jls_prefix?.Dispose ();
			jls_suffix?.Dispose ();
			return __rsval;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='mapping' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends U&gt;'] and parameter[2][@type='com.annimon.stream.Collector&lt;? super U, A, R&gt;']]"
		[Register ("mapping", "(Lcom/annimon/stream/function/Function;Lcom/annimon/stream/Collector;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U", "A", "R"})]
		public static unsafe global::Com.Annimon.Stream.ICollector Mapping (global::Com.Annimon.Stream.Function.IFunction mapper, global::Com.Annimon.Stream.ICollector downstream)
		{
			const string __id = "mapping.(Lcom/annimon/stream/function/Function;Lcom/annimon/stream/Collector;)Lcom/annimon/stream/Collector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				__args [1] = new JniArgumentValue ((downstream == null) ? IntPtr.Zero : ((global::Java.Lang.Object) downstream).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='partitioningBy' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;']]"
		[Register ("partitioningBy", "(Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.ICollector PartitioningBy (global::Com.Annimon.Stream.Function.IPredicate predicate)
		{
			const string __id = "partitioningBy.(Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/Collector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='partitioningBy' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;'] and parameter[2][@type='com.annimon.stream.Collector&lt;? super T, A, D&gt;']]"
		[Register ("partitioningBy", "(Lcom/annimon/stream/function/Predicate;Lcom/annimon/stream/Collector;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "D", "A"})]
		public static unsafe global::Com.Annimon.Stream.ICollector PartitioningBy (global::Com.Annimon.Stream.Function.IPredicate predicate, global::Com.Annimon.Stream.ICollector downstream)
		{
			const string __id = "partitioningBy.(Lcom/annimon/stream/function/Predicate;Lcom/annimon/stream/Collector;)Lcom/annimon/stream/Collector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				__args [1] = new JniArgumentValue ((downstream == null) ? IntPtr.Zero : ((global::Java.Lang.Object) downstream).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='reducing' and count(parameter)=3 and parameter[1][@type='R'] and parameter[2][@type='com.annimon.stream.function.Function&lt;? super T, ? extends R&gt;'] and parameter[3][@type='com.annimon.stream.function.BinaryOperator&lt;R&gt;']]"
		[Register ("reducing", "(Ljava/lang/Object;Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/BinaryOperator;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R"})]
		public static unsafe global::Com.Annimon.Stream.ICollector Reducing (global::Java.Lang.Object identity, global::Com.Annimon.Stream.Function.IFunction mapper, global::Com.Annimon.Stream.Function.IBinaryOperator op)
		{
			const string __id = "reducing.(Ljava/lang/Object;Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/BinaryOperator;)Lcom/annimon/stream/Collector;";
			IntPtr native_identity = JNIEnv.ToLocalJniHandle (identity);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_identity);
				__args [1] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				__args [2] = new JniArgumentValue ((op == null) ? IntPtr.Zero : ((global::Java.Lang.Object) op).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_identity);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='reducing' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='com.annimon.stream.function.BinaryOperator&lt;T&gt;']]"
		[Register ("reducing", "(Ljava/lang/Object;Lcom/annimon/stream/function/BinaryOperator;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.ICollector Reducing (global::Java.Lang.Object identity, global::Com.Annimon.Stream.Function.IBinaryOperator op)
		{
			const string __id = "reducing.(Ljava/lang/Object;Lcom/annimon/stream/function/BinaryOperator;)Lcom/annimon/stream/Collector;";
			IntPtr native_identity = JNIEnv.ToLocalJniHandle (identity);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_identity);
				__args [1] = new JniArgumentValue ((op == null) ? IntPtr.Zero : ((global::Java.Lang.Object) op).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_identity);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='summingDouble' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ToDoubleFunction&lt;? super T&gt;']]"
		[Register ("summingDouble", "(Lcom/annimon/stream/function/ToDoubleFunction;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.ICollector SummingDouble (global::Com.Annimon.Stream.Function.IToDoubleFunction mapper)
		{
			const string __id = "summingDouble.(Lcom/annimon/stream/function/ToDoubleFunction;)Lcom/annimon/stream/Collector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='summingInt' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ToIntFunction&lt;? super T&gt;']]"
		[Register ("summingInt", "(Lcom/annimon/stream/function/ToIntFunction;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.ICollector SummingInt (global::Com.Annimon.Stream.Function.IToIntFunction mapper)
		{
			const string __id = "summingInt.(Lcom/annimon/stream/function/ToIntFunction;)Lcom/annimon/stream/Collector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='summingLong' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ToLongFunction&lt;? super T&gt;']]"
		[Register ("summingLong", "(Lcom/annimon/stream/function/ToLongFunction;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.ICollector SummingLong (global::Com.Annimon.Stream.Function.IToLongFunction mapper)
		{
			const string __id = "summingLong.(Lcom/annimon/stream/function/ToLongFunction;)Lcom/annimon/stream/Collector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='toCollection' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Supplier&lt;R&gt;']]"
		[Register ("toCollection", "(Lcom/annimon/stream/function/Supplier;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "R extends java.util.Collection<T>"})]
		public static unsafe global::Com.Annimon.Stream.ICollector ToCollection (global::Com.Annimon.Stream.Function.ISupplier collectionSupplier)
		{
			const string __id = "toCollection.(Lcom/annimon/stream/function/Supplier;)Lcom/annimon/stream/Collector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((collectionSupplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) collectionSupplier).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='toList' and count(parameter)=0]"
		[Register ("toList", "()Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.ICollector ToList ()
		{
			const string __id = "toList.()Lcom/annimon/stream/Collector;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='toMap' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends K&gt;']]"
		[Register ("toMap", "(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "K"})]
		public static unsafe global::Com.Annimon.Stream.ICollector ToMap (global::Com.Annimon.Stream.Function.IFunction keyMapper)
		{
			const string __id = "toMap.(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Collector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((keyMapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyMapper).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='toMap' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends K&gt;'] and parameter[2][@type='com.annimon.stream.function.Function&lt;? super T, ? extends V&gt;']]"
		[Register ("toMap", "(Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "K", "V"})]
		public static unsafe global::Com.Annimon.Stream.ICollector ToMap (global::Com.Annimon.Stream.Function.IFunction keyMapper, global::Com.Annimon.Stream.Function.IFunction valueMapper)
		{
			const string __id = "toMap.(Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Collector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((keyMapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyMapper).Handle);
				__args [1] = new JniArgumentValue ((valueMapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) valueMapper).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='toMap' and count(parameter)=3 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends K&gt;'] and parameter[2][@type='com.annimon.stream.function.Function&lt;? super T, ? extends V&gt;'] and parameter[3][@type='com.annimon.stream.function.BinaryOperator&lt;V&gt;']]"
		[Register ("toMap", "(Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/BinaryOperator;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "K", "V"})]
		public static unsafe global::Com.Annimon.Stream.ICollector ToMap (global::Com.Annimon.Stream.Function.IFunction keyMapper, global::Com.Annimon.Stream.Function.IFunction valueMapper, global::Com.Annimon.Stream.Function.IBinaryOperator mergeFunction)
		{
			const string __id = "toMap.(Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/BinaryOperator;)Lcom/annimon/stream/Collector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((keyMapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyMapper).Handle);
				__args [1] = new JniArgumentValue ((valueMapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) valueMapper).Handle);
				__args [2] = new JniArgumentValue ((mergeFunction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mergeFunction).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='toMap' and count(parameter)=4 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends K&gt;'] and parameter[2][@type='com.annimon.stream.function.Function&lt;? super T, ? extends V&gt;'] and parameter[3][@type='com.annimon.stream.function.BinaryOperator&lt;V&gt;'] and parameter[4][@type='com.annimon.stream.function.Supplier&lt;M&gt;']]"
		[Register ("toMap", "(Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/BinaryOperator;Lcom/annimon/stream/function/Supplier;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "K", "V", "M extends java.util.Map<K, V>"})]
		public static unsafe global::Com.Annimon.Stream.ICollector ToMap (global::Com.Annimon.Stream.Function.IFunction keyMapper, global::Com.Annimon.Stream.Function.IFunction valueMapper, global::Com.Annimon.Stream.Function.IBinaryOperator mergeFunction, global::Com.Annimon.Stream.Function.ISupplier mapFactory)
		{
			const string __id = "toMap.(Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/BinaryOperator;Lcom/annimon/stream/function/Supplier;)Lcom/annimon/stream/Collector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((keyMapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyMapper).Handle);
				__args [1] = new JniArgumentValue ((valueMapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) valueMapper).Handle);
				__args [2] = new JniArgumentValue ((mergeFunction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mergeFunction).Handle);
				__args [3] = new JniArgumentValue ((mapFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapFactory).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='toMap' and count(parameter)=3 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends K&gt;'] and parameter[2][@type='com.annimon.stream.function.Function&lt;? super T, ? extends V&gt;'] and parameter[3][@type='com.annimon.stream.function.Supplier&lt;M&gt;']]"
		[Register ("toMap", "(Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/Supplier;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "K", "V", "M extends java.util.Map<K, V>"})]
		public static unsafe global::Com.Annimon.Stream.ICollector ToMap (global::Com.Annimon.Stream.Function.IFunction keyMapper, global::Com.Annimon.Stream.Function.IFunction valueMapper, global::Com.Annimon.Stream.Function.ISupplier mapFactory)
		{
			const string __id = "toMap.(Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/Supplier;)Lcom/annimon/stream/Collector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((keyMapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyMapper).Handle);
				__args [1] = new JniArgumentValue ((valueMapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) valueMapper).Handle);
				__args [2] = new JniArgumentValue ((mapFactory == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapFactory).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='toSet' and count(parameter)=0]"
		[Register ("toSet", "()Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.ICollector ToSet ()
		{
			const string __id = "toSet.()Lcom/annimon/stream/Collector;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='toUnmodifiableList' and count(parameter)=0]"
		[Register ("toUnmodifiableList", "()Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.ICollector ToUnmodifiableList ()
		{
			const string __id = "toUnmodifiableList.()Lcom/annimon/stream/Collector;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='toUnmodifiableMap' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends K&gt;'] and parameter[2][@type='com.annimon.stream.function.Function&lt;? super T, ? extends V&gt;']]"
		[Register ("toUnmodifiableMap", "(Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "K", "V"})]
		public static unsafe global::Com.Annimon.Stream.ICollector ToUnmodifiableMap (global::Com.Annimon.Stream.Function.IFunction keyMapper, global::Com.Annimon.Stream.Function.IFunction valueMapper)
		{
			const string __id = "toUnmodifiableMap.(Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Collector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((keyMapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyMapper).Handle);
				__args [1] = new JniArgumentValue ((valueMapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) valueMapper).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='toUnmodifiableMap' and count(parameter)=3 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends K&gt;'] and parameter[2][@type='com.annimon.stream.function.Function&lt;? super T, ? extends V&gt;'] and parameter[3][@type='com.annimon.stream.function.BinaryOperator&lt;V&gt;']]"
		[Register ("toUnmodifiableMap", "(Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/BinaryOperator;)Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "K", "V"})]
		public static unsafe global::Com.Annimon.Stream.ICollector ToUnmodifiableMap (global::Com.Annimon.Stream.Function.IFunction keyMapper, global::Com.Annimon.Stream.Function.IFunction valueMapper, global::Com.Annimon.Stream.Function.IBinaryOperator mergeFunction)
		{
			const string __id = "toUnmodifiableMap.(Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/Function;Lcom/annimon/stream/function/BinaryOperator;)Lcom/annimon/stream/Collector;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((keyMapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyMapper).Handle);
				__args [1] = new JniArgumentValue ((valueMapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) valueMapper).Handle);
				__args [2] = new JniArgumentValue ((mergeFunction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mergeFunction).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Collectors']/method[@name='toUnmodifiableSet' and count(parameter)=0]"
		[Register ("toUnmodifiableSet", "()Lcom/annimon/stream/Collector;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.ICollector ToUnmodifiableSet ()
		{
			const string __id = "toUnmodifiableSet.()Lcom/annimon/stream/Collector;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ICollector> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
