using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalBoolean']"
	[global::Android.Runtime.Register ("com/annimon/stream/OptionalBoolean", DoNotGenerateAcw=true)]
	public sealed partial class OptionalBoolean : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/OptionalBoolean", typeof (OptionalBoolean));
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

		internal OptionalBoolean (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		public unsafe bool AsBoolean {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalBoolean']/method[@name='getAsBoolean' and count(parameter)=0]"
			[Register ("getAsBoolean", "()Z", "")]
			get {
				const string __id = "getAsBoolean.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalBoolean']/method[@name='isEmpty' and count(parameter)=0]"
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
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalBoolean']/method[@name='isPresent' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalBoolean']/method[@name='custom' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;com.annimon.stream.OptionalBoolean, R&gt;']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalBoolean']/method[@name='empty' and count(parameter)=0]"
		[Register ("empty", "()Lcom/annimon/stream/OptionalBoolean;", "")]
		public static unsafe global::Com.Annimon.Stream.OptionalBoolean Empty ()
		{
			const string __id = "empty.()Lcom/annimon/stream/OptionalBoolean;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalBoolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalBoolean']/method[@name='executeIfAbsent' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("executeIfAbsent", "(Ljava/lang/Runnable;)Lcom/annimon/stream/OptionalBoolean;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalBoolean ExecuteIfAbsent (global::Java.Lang.IRunnable action)
		{
			const string __id = "executeIfAbsent.(Ljava/lang/Runnable;)Lcom/annimon/stream/OptionalBoolean;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalBoolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalBoolean']/method[@name='executeIfPresent' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.BooleanConsumer']]"
		[Register ("executeIfPresent", "(Lcom/annimon/stream/function/BooleanConsumer;)Lcom/annimon/stream/OptionalBoolean;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalBoolean ExecuteIfPresent (global::Com.Annimon.Stream.Function.IBooleanConsumer consumer)
		{
			const string __id = "executeIfPresent.(Lcom/annimon/stream/function/BooleanConsumer;)Lcom/annimon/stream/OptionalBoolean;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((consumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consumer).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalBoolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalBoolean']/method[@name='filter' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.BooleanPredicate']]"
		[Register ("filter", "(Lcom/annimon/stream/function/BooleanPredicate;)Lcom/annimon/stream/OptionalBoolean;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalBoolean Filter (global::Com.Annimon.Stream.Function.IBooleanPredicate predicate)
		{
			const string __id = "filter.(Lcom/annimon/stream/function/BooleanPredicate;)Lcom/annimon/stream/OptionalBoolean;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalBoolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalBoolean']/method[@name='filterNot' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.BooleanPredicate']]"
		[Register ("filterNot", "(Lcom/annimon/stream/function/BooleanPredicate;)Lcom/annimon/stream/OptionalBoolean;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalBoolean FilterNot (global::Com.Annimon.Stream.Function.IBooleanPredicate predicate)
		{
			const string __id = "filterNot.(Lcom/annimon/stream/function/BooleanPredicate;)Lcom/annimon/stream/OptionalBoolean;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalBoolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalBoolean']/method[@name='ifPresent' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.BooleanConsumer']]"
		[Register ("ifPresent", "(Lcom/annimon/stream/function/BooleanConsumer;)V", "")]
		public unsafe void IfPresent (global::Com.Annimon.Stream.Function.IBooleanConsumer consumer)
		{
			const string __id = "ifPresent.(Lcom/annimon/stream/function/BooleanConsumer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((consumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consumer).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalBoolean']/method[@name='ifPresentOrElse' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.BooleanConsumer'] and parameter[2][@type='java.lang.Runnable']]"
		[Register ("ifPresentOrElse", "(Lcom/annimon/stream/function/BooleanConsumer;Ljava/lang/Runnable;)V", "")]
		public unsafe void IfPresentOrElse (global::Com.Annimon.Stream.Function.IBooleanConsumer consumer, global::Java.Lang.IRunnable emptyAction)
		{
			const string __id = "ifPresentOrElse.(Lcom/annimon/stream/function/BooleanConsumer;Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((consumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consumer).Handle);
				__args [1] = new JniArgumentValue ((emptyAction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) emptyAction).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalBoolean']/method[@name='map' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.BooleanPredicate']]"
		[Register ("map", "(Lcom/annimon/stream/function/BooleanPredicate;)Lcom/annimon/stream/OptionalBoolean;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalBoolean Map (global::Com.Annimon.Stream.Function.IBooleanPredicate mapper)
		{
			const string __id = "map.(Lcom/annimon/stream/function/BooleanPredicate;)Lcom/annimon/stream/OptionalBoolean;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalBoolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalBoolean']/method[@name='mapToObj' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.BooleanFunction&lt;U&gt;']]"
		[Register ("mapToObj", "(Lcom/annimon/stream/function/BooleanFunction;)Lcom/annimon/stream/Optional;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public unsafe global::Com.Annimon.Stream.Optional MapToObj (global::Com.Annimon.Stream.Function.IBooleanFunction mapper)
		{
			const string __id = "mapToObj.(Lcom/annimon/stream/function/BooleanFunction;)Lcom/annimon/stream/Optional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalBoolean']/method[@name='of' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("of", "(Z)Lcom/annimon/stream/OptionalBoolean;", "")]
		public static unsafe global::Com.Annimon.Stream.OptionalBoolean Of (bool value)
		{
			const string __id = "of.(Z)Lcom/annimon/stream/OptionalBoolean;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalBoolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalBoolean']/method[@name='ofNullable' and count(parameter)=1 and parameter[1][@type='java.lang.Boolean']]"
		[Register ("ofNullable", "(Ljava/lang/Boolean;)Lcom/annimon/stream/OptionalBoolean;", "")]
		public static unsafe global::Com.Annimon.Stream.OptionalBoolean OfNullable (global::Java.Lang.Boolean value)
		{
			const string __id = "ofNullable.(Ljava/lang/Boolean;)Lcom/annimon/stream/OptionalBoolean;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalBoolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalBoolean']/method[@name='or' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Supplier&lt;com.annimon.stream.OptionalBoolean&gt;']]"
		[Register ("or", "(Lcom/annimon/stream/function/Supplier;)Lcom/annimon/stream/OptionalBoolean;", "")]
		public unsafe global::Com.Annimon.Stream.OptionalBoolean Or (global::Com.Annimon.Stream.Function.ISupplier supplier)
		{
			const string __id = "or.(Lcom/annimon/stream/function/Supplier;)Lcom/annimon/stream/OptionalBoolean;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((supplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) supplier).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalBoolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalBoolean']/method[@name='orElse' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("orElse", "(Z)Z", "")]
		public unsafe bool OrElse (bool other)
		{
			const string __id = "orElse.(Z)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (other);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalBoolean']/method[@name='orElseGet' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.BooleanSupplier']]"
		[Register ("orElseGet", "(Lcom/annimon/stream/function/BooleanSupplier;)Z", "")]
		public unsafe bool OrElseGet (global::Com.Annimon.Stream.Function.IBooleanSupplier other)
		{
			const string __id = "orElseGet.(Lcom/annimon/stream/function/BooleanSupplier;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalBoolean']/method[@name='orElseThrow' and count(parameter)=0]"
		[Register ("orElseThrow", "()Z", "")]
		public unsafe bool OrElseThrow ()
		{
			const string __id = "orElseThrow.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='OptionalBoolean']/method[@name='orElseThrow' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Supplier&lt;X&gt;']]"
		[Register ("orElseThrow", "(Lcom/annimon/stream/function/Supplier;)Z", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"X extends java.lang.Throwable"})]
		public unsafe bool OrElseThrow (global::Com.Annimon.Stream.Function.ISupplier exceptionSupplier)
		{
			const string __id = "orElseThrow.(Lcom/annimon/stream/function/Supplier;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((exceptionSupplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) exceptionSupplier).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
