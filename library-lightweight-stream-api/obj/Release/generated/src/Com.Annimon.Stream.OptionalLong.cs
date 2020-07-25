using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalLong']"
	[global::Android.Runtime.Register ("com/annimon/stream/OptionalLong", DoNotGenerateAcw=true)]
	public sealed partial class OptionalLong : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/OptionalLong", typeof (OptionalLong));
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

		internal OptionalLong (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe long AsLong {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalLong']/method[@name='getAsLong' and count(parameter)=0]"
			[Register ("getAsLong", "()J", "")]
			get {
				const string __id = "getAsLong.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalLong']/method[@name='isEmpty' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalLong']/method[@name='isPresent' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalLong']/method[@name='custom' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;com.annimon.stream.OptionalLong, R&gt;']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalLong']/method[@name='empty' and count(parameter)=0]"
		[Register ("empty", "()Lcom/annimon/stream/OptionalLong;", "")]
		public static unsafe global::Com.Annimon.Stream.OptionalLong Empty ()
		{
			const string __id = "empty.()Lcom/annimon/stream/OptionalLong;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalLong> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalLong']/method[@name='executeIfAbsent' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("executeIfAbsent", "(Ljava/lang/Runnable;)Lcom/annimon/stream/OptionalLong;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalLong ExecuteIfAbsent (global::Java.Lang.IRunnable action)
		{
			const string __id = "executeIfAbsent.(Ljava/lang/Runnable;)Lcom/annimon/stream/OptionalLong;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalLong> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalLong']/method[@name='executeIfPresent' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongConsumer']]"
		[Register ("executeIfPresent", "(Lcom/annimon/stream/function/LongConsumer;)Lcom/annimon/stream/OptionalLong;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalLong ExecuteIfPresent (global::Com.Annimon.Stream.Function.ILongConsumer consumer)
		{
			const string __id = "executeIfPresent.(Lcom/annimon/stream/function/LongConsumer;)Lcom/annimon/stream/OptionalLong;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((consumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consumer).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalLong> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalLong']/method[@name='filter' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongPredicate']]"
		[Register ("filter", "(Lcom/annimon/stream/function/LongPredicate;)Lcom/annimon/stream/OptionalLong;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalLong Filter (global::Com.Annimon.Stream.Function.ILongPredicate predicate)
		{
			const string __id = "filter.(Lcom/annimon/stream/function/LongPredicate;)Lcom/annimon/stream/OptionalLong;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalLong> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalLong']/method[@name='filterNot' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongPredicate']]"
		[Register ("filterNot", "(Lcom/annimon/stream/function/LongPredicate;)Lcom/annimon/stream/OptionalLong;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalLong FilterNot (global::Com.Annimon.Stream.Function.ILongPredicate predicate)
		{
			const string __id = "filterNot.(Lcom/annimon/stream/function/LongPredicate;)Lcom/annimon/stream/OptionalLong;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalLong> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalLong']/method[@name='ifPresent' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongConsumer']]"
		[Register ("ifPresent", "(Lcom/annimon/stream/function/LongConsumer;)V", "")]
		public unsafe void IfPresent (global::Com.Annimon.Stream.Function.ILongConsumer consumer)
		{
			const string __id = "ifPresent.(Lcom/annimon/stream/function/LongConsumer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((consumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consumer).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalLong']/method[@name='ifPresentOrElse' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.LongConsumer'] and parameter[2][@type='java.lang.Runnable']]"
		[Register ("ifPresentOrElse", "(Lcom/annimon/stream/function/LongConsumer;Ljava/lang/Runnable;)V", "")]
		public unsafe void IfPresentOrElse (global::Com.Annimon.Stream.Function.ILongConsumer consumer, global::Java.Lang.IRunnable emptyAction)
		{
			const string __id = "ifPresentOrElse.(Lcom/annimon/stream/function/LongConsumer;Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((consumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consumer).Handle);
				__args [1] = new JniArgumentValue ((emptyAction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) emptyAction).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalLong']/method[@name='map' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongUnaryOperator']]"
		[Register ("map", "(Lcom/annimon/stream/function/LongUnaryOperator;)Lcom/annimon/stream/OptionalLong;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalLong Map (global::Com.Annimon.Stream.Function.ILongUnaryOperator mapper)
		{
			const string __id = "map.(Lcom/annimon/stream/function/LongUnaryOperator;)Lcom/annimon/stream/OptionalLong;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalLong> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalLong']/method[@name='mapToInt' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongToIntFunction']]"
		[Register ("mapToInt", "(Lcom/annimon/stream/function/LongToIntFunction;)Lcom/annimon/stream/OptionalInt;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalInt MapToInt (global::Com.Annimon.Stream.Function.ILongToIntFunction mapper)
		{
			const string __id = "mapToInt.(Lcom/annimon/stream/function/LongToIntFunction;)Lcom/annimon/stream/OptionalInt;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalInt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalLong']/method[@name='mapToObj' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongFunction&lt;U&gt;']]"
		[Register ("mapToObj", "(Lcom/annimon/stream/function/LongFunction;)Lcom/annimon/stream/Optional;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::Com.Annimon.Stream.Optional MapToObj (global::Com.Annimon.Stream.Function.ILongFunction mapper)
		{
			const string __id = "mapToObj.(Lcom/annimon/stream/function/LongFunction;)Lcom/annimon/stream/Optional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalLong']/method[@name='of' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("of", "(J)Lcom/annimon/stream/OptionalLong;", "")]
		public static unsafe global::Com.Annimon.Stream.OptionalLong Of (long value)
		{
			const string __id = "of.(J)Lcom/annimon/stream/OptionalLong;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalLong> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalLong']/method[@name='ofNullable' and count(parameter)=1 and parameter[1][@type='java.lang.Long']]"
		[Register ("ofNullable", "(Ljava/lang/Long;)Lcom/annimon/stream/OptionalLong;", "")]
		public static unsafe global::Com.Annimon.Stream.OptionalLong OfNullable (global::Java.Lang.Long value)
		{
			const string __id = "ofNullable.(Ljava/lang/Long;)Lcom/annimon/stream/OptionalLong;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalLong> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalLong']/method[@name='or' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Supplier&lt;com.annimon.stream.OptionalLong&gt;']]"
		[Register ("or", "(Lcom/annimon/stream/function/Supplier;)Lcom/annimon/stream/OptionalLong;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalLong Or (global::Com.Annimon.Stream.Function.ISupplier supplier)
		{
			const string __id = "or.(Lcom/annimon/stream/function/Supplier;)Lcom/annimon/stream/OptionalLong;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((supplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) supplier).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalLong> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalLong']/method[@name='orElse' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("orElse", "(J)J", "")]
		public unsafe long OrElse (long other)
		{
			const string __id = "orElse.(J)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (other);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalLong']/method[@name='orElseGet' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.LongSupplier']]"
		[Register ("orElseGet", "(Lcom/annimon/stream/function/LongSupplier;)J", "")]
		public unsafe long OrElseGet (global::Com.Annimon.Stream.Function.ILongSupplier other)
		{
			const string __id = "orElseGet.(Lcom/annimon/stream/function/LongSupplier;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalLong']/method[@name='orElseThrow' and count(parameter)=0]"
		[Register ("orElseThrow", "()J", "")]
		public unsafe long OrElseThrow ()
		{
			const string __id = "orElseThrow.()J";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalLong']/method[@name='orElseThrow' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Supplier&lt;X&gt;']]"
		[Register ("orElseThrow", "(Lcom/annimon/stream/function/Supplier;)J", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"X extends java.lang.Throwable"})]
		public unsafe long OrElseThrow (global::Com.Annimon.Stream.Function.ISupplier exceptionSupplier)
		{
			const string __id = "orElseThrow.(Lcom/annimon/stream/function/Supplier;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((exceptionSupplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) exceptionSupplier).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalLong']/method[@name='stream' and count(parameter)=0]"
		[Register ("stream", "()Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream Stream ()
		{
			const string __id = "stream.()Lcom/annimon/stream/LongStream;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
