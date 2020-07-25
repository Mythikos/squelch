using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalInt']"
	[global::Android.Runtime.Register ("com/annimon/stream/OptionalInt", DoNotGenerateAcw=true)]
	public sealed partial class OptionalInt : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/OptionalInt", typeof (OptionalInt));
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

		internal OptionalInt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe int AsInt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalInt']/method[@name='getAsInt' and count(parameter)=0]"
			[Register ("getAsInt", "()I", "")]
			get {
				const string __id = "getAsInt.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalInt']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "")]
			get {
				const string __id = "isEmpty.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsPresent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalInt']/method[@name='isPresent' and count(parameter)=0]"
			[Register ("isPresent", "()Z", "")]
			get {
				const string __id = "isPresent.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalInt']/method[@name='custom' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;com.annimon.stream.OptionalInt, R&gt;']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalInt']/method[@name='empty' and count(parameter)=0]"
		[Register ("empty", "()Lcom/annimon/stream/OptionalInt;", "")]
		public static unsafe global::Com.Annimon.Stream.OptionalInt Empty ()
		{
			const string __id = "empty.()Lcom/annimon/stream/OptionalInt;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalInt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalInt']/method[@name='executeIfAbsent' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("executeIfAbsent", "(Ljava/lang/Runnable;)Lcom/annimon/stream/OptionalInt;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalInt ExecuteIfAbsent (global::Java.Lang.IRunnable action)
		{
			const string __id = "executeIfAbsent.(Ljava/lang/Runnable;)Lcom/annimon/stream/OptionalInt;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalInt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalInt']/method[@name='executeIfPresent' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntConsumer']]"
		[Register ("executeIfPresent", "(Lcom/annimon/stream/function/IntConsumer;)Lcom/annimon/stream/OptionalInt;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalInt ExecuteIfPresent (global::Com.Annimon.Stream.Function.IIntConsumer consumer)
		{
			const string __id = "executeIfPresent.(Lcom/annimon/stream/function/IntConsumer;)Lcom/annimon/stream/OptionalInt;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((consumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consumer).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalInt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalInt']/method[@name='filter' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntPredicate']]"
		[Register ("filter", "(Lcom/annimon/stream/function/IntPredicate;)Lcom/annimon/stream/OptionalInt;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalInt Filter (global::Com.Annimon.Stream.Function.IIntPredicate predicate)
		{
			const string __id = "filter.(Lcom/annimon/stream/function/IntPredicate;)Lcom/annimon/stream/OptionalInt;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalInt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalInt']/method[@name='filterNot' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntPredicate']]"
		[Register ("filterNot", "(Lcom/annimon/stream/function/IntPredicate;)Lcom/annimon/stream/OptionalInt;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalInt FilterNot (global::Com.Annimon.Stream.Function.IIntPredicate predicate)
		{
			const string __id = "filterNot.(Lcom/annimon/stream/function/IntPredicate;)Lcom/annimon/stream/OptionalInt;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalInt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalInt']/method[@name='ifPresent' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntConsumer']]"
		[Register ("ifPresent", "(Lcom/annimon/stream/function/IntConsumer;)V", "")]
		public unsafe void IfPresent (global::Com.Annimon.Stream.Function.IIntConsumer consumer)
		{
			const string __id = "ifPresent.(Lcom/annimon/stream/function/IntConsumer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((consumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consumer).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalInt']/method[@name='ifPresentOrElse' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.IntConsumer'] and parameter[2][@type='java.lang.Runnable']]"
		[Register ("ifPresentOrElse", "(Lcom/annimon/stream/function/IntConsumer;Ljava/lang/Runnable;)V", "")]
		public unsafe void IfPresentOrElse (global::Com.Annimon.Stream.Function.IIntConsumer consumer, global::Java.Lang.IRunnable emptyAction)
		{
			const string __id = "ifPresentOrElse.(Lcom/annimon/stream/function/IntConsumer;Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((consumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consumer).Handle);
				__args [1] = new JniArgumentValue ((emptyAction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) emptyAction).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalInt']/method[@name='map' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntUnaryOperator']]"
		[Register ("map", "(Lcom/annimon/stream/function/IntUnaryOperator;)Lcom/annimon/stream/OptionalInt;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalInt Map (global::Com.Annimon.Stream.Function.IIntUnaryOperator mapper)
		{
			const string __id = "map.(Lcom/annimon/stream/function/IntUnaryOperator;)Lcom/annimon/stream/OptionalInt;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalInt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalInt']/method[@name='mapToDouble' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntToDoubleFunction']]"
		[Register ("mapToDouble", "(Lcom/annimon/stream/function/IntToDoubleFunction;)Lcom/annimon/stream/OptionalDouble;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalDouble MapToDouble (global::Com.Annimon.Stream.Function.IIntToDoubleFunction mapper)
		{
			const string __id = "mapToDouble.(Lcom/annimon/stream/function/IntToDoubleFunction;)Lcom/annimon/stream/OptionalDouble;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalDouble> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalInt']/method[@name='mapToLong' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntToLongFunction']]"
		[Register ("mapToLong", "(Lcom/annimon/stream/function/IntToLongFunction;)Lcom/annimon/stream/OptionalLong;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalLong MapToLong (global::Com.Annimon.Stream.Function.IIntToLongFunction mapper)
		{
			const string __id = "mapToLong.(Lcom/annimon/stream/function/IntToLongFunction;)Lcom/annimon/stream/OptionalLong;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalLong> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalInt']/method[@name='mapToObj' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntFunction&lt;U&gt;']]"
		[Register ("mapToObj", "(Lcom/annimon/stream/function/IntFunction;)Lcom/annimon/stream/Optional;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::Com.Annimon.Stream.Optional MapToObj (global::Com.Annimon.Stream.Function.IIntFunction mapper)
		{
			const string __id = "mapToObj.(Lcom/annimon/stream/function/IntFunction;)Lcom/annimon/stream/Optional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalInt']/method[@name='of' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("of", "(I)Lcom/annimon/stream/OptionalInt;", "")]
		public static unsafe global::Com.Annimon.Stream.OptionalInt Of (int value)
		{
			const string __id = "of.(I)Lcom/annimon/stream/OptionalInt;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalInt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalInt']/method[@name='ofNullable' and count(parameter)=1 and parameter[1][@type='java.lang.Integer']]"
		[Register ("ofNullable", "(Ljava/lang/Integer;)Lcom/annimon/stream/OptionalInt;", "")]
		public static unsafe global::Com.Annimon.Stream.OptionalInt OfNullable (global::Java.Lang.Integer value)
		{
			const string __id = "ofNullable.(Ljava/lang/Integer;)Lcom/annimon/stream/OptionalInt;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalInt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalInt']/method[@name='or' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Supplier&lt;com.annimon.stream.OptionalInt&gt;']]"
		[Register ("or", "(Lcom/annimon/stream/function/Supplier;)Lcom/annimon/stream/OptionalInt;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalInt Or (global::Com.Annimon.Stream.Function.ISupplier supplier)
		{
			const string __id = "or.(Lcom/annimon/stream/function/Supplier;)Lcom/annimon/stream/OptionalInt;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((supplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) supplier).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalInt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalInt']/method[@name='orElse' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("orElse", "(I)I", "")]
		public unsafe int OrElse (int other)
		{
			const string __id = "orElse.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (other);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalInt']/method[@name='orElseGet' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.IntSupplier']]"
		[Register ("orElseGet", "(Lcom/annimon/stream/function/IntSupplier;)I", "")]
		public unsafe int OrElseGet (global::Com.Annimon.Stream.Function.IIntSupplier other)
		{
			const string __id = "orElseGet.(Lcom/annimon/stream/function/IntSupplier;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalInt']/method[@name='orElseThrow' and count(parameter)=0]"
		[Register ("orElseThrow", "()I", "")]
		public unsafe int OrElseThrow ()
		{
			const string __id = "orElseThrow.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalInt']/method[@name='orElseThrow' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Supplier&lt;X&gt;']]"
		[Register ("orElseThrow", "(Lcom/annimon/stream/function/Supplier;)I", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"X extends java.lang.Throwable"})]
		public unsafe int OrElseThrow (global::Com.Annimon.Stream.Function.ISupplier exceptionSupplier)
		{
			const string __id = "orElseThrow.(Lcom/annimon/stream/function/Supplier;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((exceptionSupplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) exceptionSupplier).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalInt']/method[@name='stream' and count(parameter)=0]"
		[Register ("stream", "()Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream Stream ()
		{
			const string __id = "stream.()Lcom/annimon/stream/IntStream;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
