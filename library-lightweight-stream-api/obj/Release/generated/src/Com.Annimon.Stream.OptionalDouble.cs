using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalDouble']"
	[global::Android.Runtime.Register ("com/annimon/stream/OptionalDouble", DoNotGenerateAcw=true)]
	public sealed partial class OptionalDouble : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/OptionalDouble", typeof (OptionalDouble));
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

		internal OptionalDouble (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe double AsDouble {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalDouble']/method[@name='getAsDouble' and count(parameter)=0]"
			[Register ("getAsDouble", "()D", "")]
			get {
				const string __id = "getAsDouble.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalDouble']/method[@name='isEmpty' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalDouble']/method[@name='isPresent' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalDouble']/method[@name='custom' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;com.annimon.stream.OptionalDouble, R&gt;']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalDouble']/method[@name='empty' and count(parameter)=0]"
		[Register ("empty", "()Lcom/annimon/stream/OptionalDouble;", "")]
		public static unsafe global::Com.Annimon.Stream.OptionalDouble Empty ()
		{
			const string __id = "empty.()Lcom/annimon/stream/OptionalDouble;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalDouble> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalDouble']/method[@name='executeIfAbsent' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("executeIfAbsent", "(Ljava/lang/Runnable;)Lcom/annimon/stream/OptionalDouble;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalDouble ExecuteIfAbsent (global::Java.Lang.IRunnable action)
		{
			const string __id = "executeIfAbsent.(Ljava/lang/Runnable;)Lcom/annimon/stream/OptionalDouble;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalDouble> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalDouble']/method[@name='executeIfPresent' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoubleConsumer']]"
		[Register ("executeIfPresent", "(Lcom/annimon/stream/function/DoubleConsumer;)Lcom/annimon/stream/OptionalDouble;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalDouble ExecuteIfPresent (global::Com.Annimon.Stream.Function.IDoubleConsumer consumer)
		{
			const string __id = "executeIfPresent.(Lcom/annimon/stream/function/DoubleConsumer;)Lcom/annimon/stream/OptionalDouble;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((consumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consumer).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalDouble> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalDouble']/method[@name='filter' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoublePredicate']]"
		[Register ("filter", "(Lcom/annimon/stream/function/DoublePredicate;)Lcom/annimon/stream/OptionalDouble;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalDouble Filter (global::Com.Annimon.Stream.Function.IDoublePredicate predicate)
		{
			const string __id = "filter.(Lcom/annimon/stream/function/DoublePredicate;)Lcom/annimon/stream/OptionalDouble;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalDouble> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalDouble']/method[@name='filterNot' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoublePredicate']]"
		[Register ("filterNot", "(Lcom/annimon/stream/function/DoublePredicate;)Lcom/annimon/stream/OptionalDouble;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalDouble FilterNot (global::Com.Annimon.Stream.Function.IDoublePredicate predicate)
		{
			const string __id = "filterNot.(Lcom/annimon/stream/function/DoublePredicate;)Lcom/annimon/stream/OptionalDouble;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalDouble> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalDouble']/method[@name='ifPresent' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoubleConsumer']]"
		[Register ("ifPresent", "(Lcom/annimon/stream/function/DoubleConsumer;)V", "")]
		public unsafe void IfPresent (global::Com.Annimon.Stream.Function.IDoubleConsumer consumer)
		{
			const string __id = "ifPresent.(Lcom/annimon/stream/function/DoubleConsumer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((consumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consumer).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalDouble']/method[@name='ifPresentOrElse' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.DoubleConsumer'] and parameter[2][@type='java.lang.Runnable']]"
		[Register ("ifPresentOrElse", "(Lcom/annimon/stream/function/DoubleConsumer;Ljava/lang/Runnable;)V", "")]
		public unsafe void IfPresentOrElse (global::Com.Annimon.Stream.Function.IDoubleConsumer consumer, global::Java.Lang.IRunnable emptyAction)
		{
			const string __id = "ifPresentOrElse.(Lcom/annimon/stream/function/DoubleConsumer;Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((consumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consumer).Handle);
				__args [1] = new JniArgumentValue ((emptyAction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) emptyAction).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalDouble']/method[@name='map' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoubleUnaryOperator']]"
		[Register ("map", "(Lcom/annimon/stream/function/DoubleUnaryOperator;)Lcom/annimon/stream/OptionalDouble;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalDouble Map (global::Com.Annimon.Stream.Function.IDoubleUnaryOperator mapper)
		{
			const string __id = "map.(Lcom/annimon/stream/function/DoubleUnaryOperator;)Lcom/annimon/stream/OptionalDouble;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalDouble> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalDouble']/method[@name='mapToInt' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoubleToIntFunction']]"
		[Register ("mapToInt", "(Lcom/annimon/stream/function/DoubleToIntFunction;)Lcom/annimon/stream/OptionalInt;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalInt MapToInt (global::Com.Annimon.Stream.Function.IDoubleToIntFunction mapper)
		{
			const string __id = "mapToInt.(Lcom/annimon/stream/function/DoubleToIntFunction;)Lcom/annimon/stream/OptionalInt;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalInt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalDouble']/method[@name='mapToLong' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoubleToLongFunction']]"
		[Register ("mapToLong", "(Lcom/annimon/stream/function/DoubleToLongFunction;)Lcom/annimon/stream/OptionalLong;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalLong MapToLong (global::Com.Annimon.Stream.Function.IDoubleToLongFunction mapper)
		{
			const string __id = "mapToLong.(Lcom/annimon/stream/function/DoubleToLongFunction;)Lcom/annimon/stream/OptionalLong;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalLong> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalDouble']/method[@name='mapToObj' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoubleFunction&lt;U&gt;']]"
		[Register ("mapToObj", "(Lcom/annimon/stream/function/DoubleFunction;)Lcom/annimon/stream/Optional;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::Com.Annimon.Stream.Optional MapToObj (global::Com.Annimon.Stream.Function.IDoubleFunction mapper)
		{
			const string __id = "mapToObj.(Lcom/annimon/stream/function/DoubleFunction;)Lcom/annimon/stream/Optional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalDouble']/method[@name='of' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("of", "(D)Lcom/annimon/stream/OptionalDouble;", "")]
		public static unsafe global::Com.Annimon.Stream.OptionalDouble Of (double value)
		{
			const string __id = "of.(D)Lcom/annimon/stream/OptionalDouble;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalDouble> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalDouble']/method[@name='ofNullable' and count(parameter)=1 and parameter[1][@type='java.lang.Double']]"
		[Register ("ofNullable", "(Ljava/lang/Double;)Lcom/annimon/stream/OptionalDouble;", "")]
		public static unsafe global::Com.Annimon.Stream.OptionalDouble OfNullable (global::Java.Lang.Double value)
		{
			const string __id = "ofNullable.(Ljava/lang/Double;)Lcom/annimon/stream/OptionalDouble;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalDouble> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalDouble']/method[@name='or' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Supplier&lt;com.annimon.stream.OptionalDouble&gt;']]"
		[Register ("or", "(Lcom/annimon/stream/function/Supplier;)Lcom/annimon/stream/OptionalDouble;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalDouble Or (global::Com.Annimon.Stream.Function.ISupplier supplier)
		{
			const string __id = "or.(Lcom/annimon/stream/function/Supplier;)Lcom/annimon/stream/OptionalDouble;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((supplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) supplier).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalDouble> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalDouble']/method[@name='orElse' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("orElse", "(D)D", "")]
		public unsafe double OrElse (double other)
		{
			const string __id = "orElse.(D)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (other);
				var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalDouble']/method[@name='orElseGet' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.DoubleSupplier']]"
		[Register ("orElseGet", "(Lcom/annimon/stream/function/DoubleSupplier;)D", "")]
		public unsafe double OrElseGet (global::Com.Annimon.Stream.Function.IDoubleSupplier other)
		{
			const string __id = "orElseGet.(Lcom/annimon/stream/function/DoubleSupplier;)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalDouble']/method[@name='orElseThrow' and count(parameter)=0]"
		[Register ("orElseThrow", "()D", "")]
		public unsafe double OrElseThrow ()
		{
			const string __id = "orElseThrow.()D";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalDouble']/method[@name='orElseThrow' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Supplier&lt;X&gt;']]"
		[Register ("orElseThrow", "(Lcom/annimon/stream/function/Supplier;)D", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"X extends java.lang.Throwable"})]
		public unsafe double OrElseThrow (global::Com.Annimon.Stream.Function.ISupplier exceptionSupplier)
		{
			const string __id = "orElseThrow.(Lcom/annimon/stream/function/Supplier;)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((exceptionSupplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) exceptionSupplier).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalDouble']/method[@name='stream' and count(parameter)=0]"
		[Register ("stream", "()Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream Stream ()
		{
			const string __id = "stream.()Lcom/annimon/stream/DoubleStream;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
