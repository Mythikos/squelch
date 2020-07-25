using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']"
	[global::Android.Runtime.Register ("com/annimon/stream/ComparatorCompat", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public sealed partial class ComparatorCompat : global::Java.Lang.Object, global::Java.Util.IComparator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/ComparatorCompat", typeof (ComparatorCompat));
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

		internal ComparatorCompat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']/constructor[@name='ComparatorCompat' and count(parameter)=1 and parameter[1][@type='java.util.Comparator&lt;? super T&gt;']]"
		[Register (".ctor", "(Ljava/util/Comparator;)V", "")]
		public unsafe ComparatorCompat (global::Java.Util.IComparator comparator)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Comparator;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((comparator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) comparator).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']/method[@name='chain' and count(parameter)=1 and parameter[1][@type='java.util.Comparator&lt;T&gt;']]"
		[Register ("chain", "(Ljava/util/Comparator;)Lcom/annimon/stream/ComparatorCompat;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.ComparatorCompat Chain (global::Java.Util.IComparator comparator)
		{
			const string __id = "chain.(Ljava/util/Comparator;)Lcom/annimon/stream/ComparatorCompat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((comparator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) comparator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ComparatorCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']/method[@name='comparator' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("comparator", "()Ljava/util/Comparator;", "")]
		public unsafe global::Java.Util.IComparator Comparator ()
		{
			const string __id = "comparator.()Ljava/util/Comparator;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='T']]"
		[Register ("compare", "(Ljava/lang/Object;Ljava/lang/Object;)I", "")]
		public unsafe int Compare (global::Java.Lang.Object o1, global::Java.Lang.Object o2)
		{
			const string __id = "compare.(Ljava/lang/Object;Ljava/lang/Object;)I";
			IntPtr native_o1 = JNIEnv.ToLocalJniHandle (o1);
			IntPtr native_o2 = JNIEnv.ToLocalJniHandle (o2);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_o1);
				__args [1] = new JniArgumentValue (native_o2);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_o1);
				JNIEnv.DeleteLocalRef (native_o2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']/method[@name='comparing' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends U&gt;']]"
		[Register ("comparing", "(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/ComparatorCompat;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U extends java.lang.Comparable<? super U>"})]
		public static unsafe global::Com.Annimon.Stream.ComparatorCompat Comparing (global::Com.Annimon.Stream.Function.IFunction keyExtractor)
		{
			const string __id = "comparing.(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/ComparatorCompat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((keyExtractor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyExtractor).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ComparatorCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']/method[@name='comparing' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends U&gt;'] and parameter[2][@type='java.util.Comparator&lt;? super U&gt;']]"
		[Register ("comparing", "(Lcom/annimon/stream/function/Function;Ljava/util/Comparator;)Lcom/annimon/stream/ComparatorCompat;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T", "U"})]
		public static unsafe global::Com.Annimon.Stream.ComparatorCompat Comparing (global::Com.Annimon.Stream.Function.IFunction keyExtractor, global::Java.Util.IComparator keyComparator)
		{
			const string __id = "comparing.(Lcom/annimon/stream/function/Function;Ljava/util/Comparator;)Lcom/annimon/stream/ComparatorCompat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((keyExtractor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyExtractor).Handle);
				__args [1] = new JniArgumentValue ((keyComparator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyComparator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ComparatorCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']/method[@name='comparingDouble' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ToDoubleFunction&lt;? super T&gt;']]"
		[Register ("comparingDouble", "(Lcom/annimon/stream/function/ToDoubleFunction;)Lcom/annimon/stream/ComparatorCompat;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.ComparatorCompat ComparingDouble (global::Com.Annimon.Stream.Function.IToDoubleFunction keyExtractor)
		{
			const string __id = "comparingDouble.(Lcom/annimon/stream/function/ToDoubleFunction;)Lcom/annimon/stream/ComparatorCompat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((keyExtractor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyExtractor).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ComparatorCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']/method[@name='comparingInt' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ToIntFunction&lt;? super T&gt;']]"
		[Register ("comparingInt", "(Lcom/annimon/stream/function/ToIntFunction;)Lcom/annimon/stream/ComparatorCompat;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.ComparatorCompat ComparingInt (global::Com.Annimon.Stream.Function.IToIntFunction keyExtractor)
		{
			const string __id = "comparingInt.(Lcom/annimon/stream/function/ToIntFunction;)Lcom/annimon/stream/ComparatorCompat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((keyExtractor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyExtractor).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ComparatorCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']/method[@name='comparingLong' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ToLongFunction&lt;? super T&gt;']]"
		[Register ("comparingLong", "(Lcom/annimon/stream/function/ToLongFunction;)Lcom/annimon/stream/ComparatorCompat;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.ComparatorCompat ComparingLong (global::Com.Annimon.Stream.Function.IToLongFunction keyExtractor)
		{
			const string __id = "comparingLong.(Lcom/annimon/stream/function/ToLongFunction;)Lcom/annimon/stream/ComparatorCompat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((keyExtractor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyExtractor).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ComparatorCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']/method[@name='naturalOrder' and count(parameter)=0]"
		[Register ("naturalOrder", "()Lcom/annimon/stream/ComparatorCompat;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Comparable<? super T>"})]
		public static unsafe global::Com.Annimon.Stream.ComparatorCompat NaturalOrder ()
		{
			const string __id = "naturalOrder.()Lcom/annimon/stream/ComparatorCompat;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ComparatorCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']/method[@name='nullsFirst' and count(parameter)=0]"
		[Register ("nullsFirst", "()Lcom/annimon/stream/ComparatorCompat;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.ComparatorCompat NullsFirst ()
		{
			const string __id = "nullsFirst.()Lcom/annimon/stream/ComparatorCompat;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ComparatorCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']/method[@name='nullsFirst' and count(parameter)=1 and parameter[1][@type='java.util.Comparator&lt;? super T&gt;']]"
		[Register ("nullsFirst", "(Ljava/util/Comparator;)Lcom/annimon/stream/ComparatorCompat;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.ComparatorCompat NullsFirst (global::Java.Util.IComparator comparator)
		{
			const string __id = "nullsFirst.(Ljava/util/Comparator;)Lcom/annimon/stream/ComparatorCompat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((comparator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) comparator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ComparatorCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']/method[@name='nullsLast' and count(parameter)=0]"
		[Register ("nullsLast", "()Lcom/annimon/stream/ComparatorCompat;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.ComparatorCompat NullsLast ()
		{
			const string __id = "nullsLast.()Lcom/annimon/stream/ComparatorCompat;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ComparatorCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']/method[@name='nullsLast' and count(parameter)=1 and parameter[1][@type='java.util.Comparator&lt;? super T&gt;']]"
		[Register ("nullsLast", "(Ljava/util/Comparator;)Lcom/annimon/stream/ComparatorCompat;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.ComparatorCompat NullsLast (global::Java.Util.IComparator comparator)
		{
			const string __id = "nullsLast.(Ljava/util/Comparator;)Lcom/annimon/stream/ComparatorCompat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((comparator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) comparator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ComparatorCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']/method[@name='reverseOrder' and count(parameter)=0]"
		[Register ("reverseOrder", "()Lcom/annimon/stream/ComparatorCompat;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Comparable<? super T>"})]
		public static unsafe global::Com.Annimon.Stream.ComparatorCompat ReverseOrder ()
		{
			const string __id = "reverseOrder.()Lcom/annimon/stream/ComparatorCompat;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ComparatorCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']/method[@name='reversed' and count(parameter)=0]"
		[Register ("reversed", "()Lcom/annimon/stream/ComparatorCompat;", "")]
		public unsafe global::Com.Annimon.Stream.ComparatorCompat Reversed ()
		{
			const string __id = "reversed.()Lcom/annimon/stream/ComparatorCompat;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ComparatorCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']/method[@name='reversed' and count(parameter)=1 and parameter[1][@type='java.util.Comparator&lt;T&gt;']]"
		[Register ("reversed", "(Ljava/util/Comparator;)Ljava/util/Comparator;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Util.IComparator Reversed (global::Java.Util.IComparator comparator)
		{
			const string __id = "reversed.(Ljava/util/Comparator;)Ljava/util/Comparator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((comparator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) comparator).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']/method[@name='thenComparing' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends U&gt;']]"
		[Register ("thenComparing", "(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/ComparatorCompat;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U extends java.lang.Comparable<? super U>"})]
		public unsafe global::Com.Annimon.Stream.ComparatorCompat ThenComparing (global::Com.Annimon.Stream.Function.IFunction keyExtractor)
		{
			const string __id = "thenComparing.(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/ComparatorCompat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((keyExtractor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyExtractor).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ComparatorCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']/method[@name='thenComparing' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends U&gt;'] and parameter[2][@type='java.util.Comparator&lt;? super U&gt;']]"
		[Register ("thenComparing", "(Lcom/annimon/stream/function/Function;Ljava/util/Comparator;)Lcom/annimon/stream/ComparatorCompat;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::Com.Annimon.Stream.ComparatorCompat ThenComparing (global::Com.Annimon.Stream.Function.IFunction keyExtractor, global::Java.Util.IComparator keyComparator)
		{
			const string __id = "thenComparing.(Lcom/annimon/stream/function/Function;Ljava/util/Comparator;)Lcom/annimon/stream/ComparatorCompat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((keyExtractor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyExtractor).Handle);
				__args [1] = new JniArgumentValue ((keyComparator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyComparator).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ComparatorCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']/method[@name='thenComparing' and count(parameter)=1 and parameter[1][@type='java.util.Comparator&lt;? super T&gt;']]"
		[Register ("thenComparing", "(Ljava/util/Comparator;)Lcom/annimon/stream/ComparatorCompat;", "")]
		public unsafe global::Com.Annimon.Stream.ComparatorCompat ThenComparing (global::Java.Util.IComparator other)
		{
			const string __id = "thenComparing.(Ljava/util/Comparator;)Lcom/annimon/stream/ComparatorCompat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ComparatorCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']/method[@name='thenComparing' and count(parameter)=2 and parameter[1][@type='java.util.Comparator&lt;? super T&gt;'] and parameter[2][@type='java.util.Comparator&lt;? super T&gt;']]"
		[Register ("thenComparing", "(Ljava/util/Comparator;Ljava/util/Comparator;)Ljava/util/Comparator;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Util.IComparator ThenComparing (global::Java.Util.IComparator c1, global::Java.Util.IComparator c2)
		{
			const string __id = "thenComparing.(Ljava/util/Comparator;Ljava/util/Comparator;)Ljava/util/Comparator;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((c1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c1).Handle);
				__args [1] = new JniArgumentValue ((c2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c2).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Util.IComparator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']/method[@name='thenComparingDouble' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ToDoubleFunction&lt;? super T&gt;']]"
		[Register ("thenComparingDouble", "(Lcom/annimon/stream/function/ToDoubleFunction;)Lcom/annimon/stream/ComparatorCompat;", "")]
		public unsafe global::Com.Annimon.Stream.ComparatorCompat ThenComparingDouble (global::Com.Annimon.Stream.Function.IToDoubleFunction keyExtractor)
		{
			const string __id = "thenComparingDouble.(Lcom/annimon/stream/function/ToDoubleFunction;)Lcom/annimon/stream/ComparatorCompat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((keyExtractor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyExtractor).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ComparatorCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']/method[@name='thenComparingInt' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ToIntFunction&lt;? super T&gt;']]"
		[Register ("thenComparingInt", "(Lcom/annimon/stream/function/ToIntFunction;)Lcom/annimon/stream/ComparatorCompat;", "")]
		public unsafe global::Com.Annimon.Stream.ComparatorCompat ThenComparingInt (global::Com.Annimon.Stream.Function.IToIntFunction keyExtractor)
		{
			const string __id = "thenComparingInt.(Lcom/annimon/stream/function/ToIntFunction;)Lcom/annimon/stream/ComparatorCompat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((keyExtractor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyExtractor).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ComparatorCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='ComparatorCompat']/method[@name='thenComparingLong' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ToLongFunction&lt;? super T&gt;']]"
		[Register ("thenComparingLong", "(Lcom/annimon/stream/function/ToLongFunction;)Lcom/annimon/stream/ComparatorCompat;", "")]
		public unsafe global::Com.Annimon.Stream.ComparatorCompat ThenComparingLong (global::Com.Annimon.Stream.Function.IToLongFunction keyExtractor)
		{
			const string __id = "thenComparingLong.(Lcom/annimon/stream/function/ToLongFunction;)Lcom/annimon/stream/ComparatorCompat;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((keyExtractor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) keyExtractor).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.ComparatorCompat> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
