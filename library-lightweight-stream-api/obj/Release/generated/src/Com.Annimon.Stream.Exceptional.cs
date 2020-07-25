using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream']/class[@name='Exceptional']"
	[global::Android.Runtime.Register ("com/annimon/stream/Exceptional", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class Exceptional : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/Exceptional", typeof (Exceptional));
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

		protected Exceptional (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_getException;
#pragma warning disable 0169
		static Delegate GetGetExceptionHandler ()
		{
			if (cb_getException == null)
				cb_getException = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetException);
			return cb_getException;
		}

		static IntPtr n_GetException (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Exceptional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Exception);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Throwable Exception {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Exceptional']/method[@name='getException' and count(parameter)=0]"
			[Register ("getException", "()Ljava/lang/Throwable;", "GetGetExceptionHandler")]
			get {
				const string __id = "getException.()Ljava/lang/Throwable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isPresent;
#pragma warning disable 0169
		static Delegate GetIsPresentHandler ()
		{
			if (cb_isPresent == null)
				cb_isPresent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPresent);
			return cb_isPresent;
		}

		static bool n_IsPresent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Exceptional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPresent;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsPresent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Exceptional']/method[@name='isPresent' and count(parameter)=0]"
			[Register ("isPresent", "()Z", "GetIsPresentHandler")]
			get {
				const string __id = "isPresent.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getOptional;
#pragma warning disable 0169
		static Delegate GetGetOptionalHandler ()
		{
			if (cb_getOptional == null)
				cb_getOptional = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOptional);
			return cb_getOptional;
		}

		static IntPtr n_GetOptional (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Exceptional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Optional);
		}
#pragma warning restore 0169

		public virtual unsafe global::Com.Annimon.Stream.Optional Optional {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Exceptional']/method[@name='getOptional' and count(parameter)=0]"
			[Register ("getOptional", "()Lcom/annimon/stream/Optional;", "GetGetOptionalHandler")]
			get {
				const string __id = "getOptional.()Lcom/annimon/stream/Optional;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOrThrow;
#pragma warning disable 0169
		static Delegate GetGetOrThrowHandler ()
		{
			if (cb_getOrThrow == null)
				cb_getOrThrow = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrThrow);
			return cb_getOrThrow;
		}

		static IntPtr n_GetOrThrow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Exceptional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OrThrow);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object OrThrow {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Exceptional']/method[@name='getOrThrow' and count(parameter)=0]"
			[Register ("getOrThrow", "()Ljava/lang/Object;", "GetGetOrThrowHandler")]
			get {
				const string __id = "getOrThrow.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getOrThrowRuntimeException;
#pragma warning disable 0169
		static Delegate GetGetOrThrowRuntimeExceptionHandler ()
		{
			if (cb_getOrThrowRuntimeException == null)
				cb_getOrThrowRuntimeException = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrThrowRuntimeException);
			return cb_getOrThrowRuntimeException;
		}

		static IntPtr n_GetOrThrowRuntimeException (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Exceptional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OrThrowRuntimeException);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object OrThrowRuntimeException {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Exceptional']/method[@name='getOrThrowRuntimeException' and count(parameter)=0]"
			[Register ("getOrThrowRuntimeException", "()Ljava/lang/Object;", "GetGetOrThrowRuntimeExceptionHandler")]
			get {
				const string __id = "getOrThrowRuntimeException.()Ljava/lang/Object;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Annimon.Stream.Exceptional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IFunction function = (global::Com.Annimon.Stream.Function.IFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IFunction> (native_function, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Custom (function));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Exceptional']/method[@name='custom' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;com.annimon.stream.Exceptional&lt;T&gt;, R&gt;']]"
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

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Get);
			return cb_get;
		}

		static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Exceptional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Exceptional']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Ljava/lang/Object;", "GetGetHandler")]
		public virtual unsafe global::Java.Lang.Object Get ()
		{
			const string __id = "get.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getOrElse_Lcom_annimon_stream_function_Supplier_;
#pragma warning disable 0169
		static Delegate GetGetOrElse_Lcom_annimon_stream_function_Supplier_Handler ()
		{
			if (cb_getOrElse_Lcom_annimon_stream_function_Supplier_ == null)
				cb_getOrElse_Lcom_annimon_stream_function_Supplier_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetOrElse_Lcom_annimon_stream_function_Supplier_);
			return cb_getOrElse_Lcom_annimon_stream_function_Supplier_;
		}

		static IntPtr n_GetOrElse_Lcom_annimon_stream_function_Supplier_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::Com.Annimon.Stream.Exceptional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.ISupplier other = (global::Com.Annimon.Stream.Function.ISupplier)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ISupplier> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetOrElse (other));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Exceptional']/method[@name='getOrElse' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Supplier&lt;? extends T&gt;']]"
		[Register ("getOrElse", "(Lcom/annimon/stream/function/Supplier;)Ljava/lang/Object;", "GetGetOrElse_Lcom_annimon_stream_function_Supplier_Handler")]
		public virtual unsafe global::Java.Lang.Object GetOrElse (global::Com.Annimon.Stream.Function.ISupplier other)
		{
			const string __id = "getOrElse.(Lcom/annimon/stream/function/Supplier;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getOrElse_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetOrElse_Ljava_lang_Object_Handler ()
		{
			if (cb_getOrElse_Ljava_lang_Object_ == null)
				cb_getOrElse_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetOrElse_Ljava_lang_Object_);
			return cb_getOrElse_Ljava_lang_Object_;
		}

		static IntPtr n_GetOrElse_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::Com.Annimon.Stream.Exceptional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object other = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetOrElse (other));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Exceptional']/method[@name='getOrElse' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("getOrElse", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetGetOrElse_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object GetOrElse (global::Java.Lang.Object other)
		{
			const string __id = "getOrElse.(Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_other = JNIEnv.ToLocalJniHandle (other);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_other);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_other);
			}
		}

		static Delegate cb_getOrThrow_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetGetOrThrow_Ljava_lang_Throwable_Handler ()
		{
			if (cb_getOrThrow_Ljava_lang_Throwable_ == null)
				cb_getOrThrow_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetOrThrow_Ljava_lang_Throwable_);
			return cb_getOrThrow_Ljava_lang_Throwable_;
		}

		static IntPtr n_GetOrThrow_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_exception)
		{
			global::Com.Annimon.Stream.Exceptional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object exception = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_exception, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetOrThrow (exception));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Exceptional']/method[@name='getOrThrow' and count(parameter)=1 and parameter[1][@type='E']]"
		[Register ("getOrThrow", "(Ljava/lang/Throwable;)Ljava/lang/Object;", "GetGetOrThrow_Ljava_lang_Throwable_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Throwable"})]
		public virtual unsafe global::Java.Lang.Object GetOrThrow (global::Java.Lang.Object exception)
		{
			const string __id = "getOrThrow.(Ljava/lang/Throwable;)Ljava/lang/Object;";
			IntPtr native_exception = JNIEnv.ToLocalJniHandle (exception);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_exception);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_exception);
			}
		}

		static Delegate cb_ifException_Lcom_annimon_stream_function_Consumer_;
#pragma warning disable 0169
		static Delegate GetIfException_Lcom_annimon_stream_function_Consumer_Handler ()
		{
			if (cb_ifException_Lcom_annimon_stream_function_Consumer_ == null)
				cb_ifException_Lcom_annimon_stream_function_Consumer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_IfException_Lcom_annimon_stream_function_Consumer_);
			return cb_ifException_Lcom_annimon_stream_function_Consumer_;
		}

		static IntPtr n_IfException_Lcom_annimon_stream_function_Consumer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_consumer)
		{
			global::Com.Annimon.Stream.Exceptional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IConsumer consumer = (global::Com.Annimon.Stream.Function.IConsumer)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IConsumer> (native_consumer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.IfException (consumer));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Exceptional']/method[@name='ifException' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Consumer&lt;java.lang.Throwable&gt;']]"
		[Register ("ifException", "(Lcom/annimon/stream/function/Consumer;)Lcom/annimon/stream/Exceptional;", "GetIfException_Lcom_annimon_stream_function_Consumer_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Exceptional IfException (global::Com.Annimon.Stream.Function.IConsumer consumer)
		{
			const string __id = "ifException.(Lcom/annimon/stream/function/Consumer;)Lcom/annimon/stream/Exceptional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((consumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consumer).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_ifExceptionIs_Ljava_lang_Class_Lcom_annimon_stream_function_Consumer_;
#pragma warning disable 0169
		static Delegate GetIfExceptionIs_Ljava_lang_Class_Lcom_annimon_stream_function_Consumer_Handler ()
		{
			if (cb_ifExceptionIs_Ljava_lang_Class_Lcom_annimon_stream_function_Consumer_ == null)
				cb_ifExceptionIs_Ljava_lang_Class_Lcom_annimon_stream_function_Consumer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_IfExceptionIs_Ljava_lang_Class_Lcom_annimon_stream_function_Consumer_);
			return cb_ifExceptionIs_Ljava_lang_Class_Lcom_annimon_stream_function_Consumer_;
		}

		static IntPtr n_IfExceptionIs_Ljava_lang_Class_Lcom_annimon_stream_function_Consumer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_throwableClass, IntPtr native_consumer)
		{
			global::Com.Annimon.Stream.Exceptional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class throwableClass = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_throwableClass, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IConsumer consumer = (global::Com.Annimon.Stream.Function.IConsumer)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IConsumer> (native_consumer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.IfExceptionIs (throwableClass, consumer));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Exceptional']/method[@name='ifExceptionIs' and count(parameter)=2 and parameter[1][@type='java.lang.Class&lt;E&gt;'] and parameter[2][@type='com.annimon.stream.function.Consumer&lt;? super E&gt;']]"
		[Register ("ifExceptionIs", "(Ljava/lang/Class;Lcom/annimon/stream/function/Consumer;)Lcom/annimon/stream/Exceptional;", "GetIfExceptionIs_Ljava_lang_Class_Lcom_annimon_stream_function_Consumer_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"E extends java.lang.Throwable"})]
		public virtual unsafe global::Com.Annimon.Stream.Exceptional IfExceptionIs (global::Java.Lang.Class throwableClass, global::Com.Annimon.Stream.Function.IConsumer consumer)
		{
			const string __id = "ifExceptionIs.(Ljava/lang/Class;Lcom/annimon/stream/function/Consumer;)Lcom/annimon/stream/Exceptional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((throwableClass == null) ? IntPtr.Zero : ((global::Java.Lang.Object) throwableClass).Handle);
				__args [1] = new JniArgumentValue ((consumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consumer).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_ifPresent_Lcom_annimon_stream_function_Consumer_;
#pragma warning disable 0169
		static Delegate GetIfPresent_Lcom_annimon_stream_function_Consumer_Handler ()
		{
			if (cb_ifPresent_Lcom_annimon_stream_function_Consumer_ == null)
				cb_ifPresent_Lcom_annimon_stream_function_Consumer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_IfPresent_Lcom_annimon_stream_function_Consumer_);
			return cb_ifPresent_Lcom_annimon_stream_function_Consumer_;
		}

		static IntPtr n_IfPresent_Lcom_annimon_stream_function_Consumer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_consumer)
		{
			global::Com.Annimon.Stream.Exceptional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IConsumer consumer = (global::Com.Annimon.Stream.Function.IConsumer)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IConsumer> (native_consumer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.IfPresent (consumer));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Exceptional']/method[@name='ifPresent' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Consumer&lt;? super T&gt;']]"
		[Register ("ifPresent", "(Lcom/annimon/stream/function/Consumer;)Lcom/annimon/stream/Exceptional;", "GetIfPresent_Lcom_annimon_stream_function_Consumer_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Exceptional IfPresent (global::Com.Annimon.Stream.Function.IConsumer consumer)
		{
			const string __id = "ifPresent.(Lcom/annimon/stream/function/Consumer;)Lcom/annimon/stream/Exceptional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((consumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consumer).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_map_Lcom_annimon_stream_function_ThrowableFunction_;
#pragma warning disable 0169
		static Delegate GetMap_Lcom_annimon_stream_function_ThrowableFunction_Handler ()
		{
			if (cb_map_Lcom_annimon_stream_function_ThrowableFunction_ == null)
				cb_map_Lcom_annimon_stream_function_ThrowableFunction_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Map_Lcom_annimon_stream_function_ThrowableFunction_);
			return cb_map_Lcom_annimon_stream_function_ThrowableFunction_;
		}

		static IntPtr n_Map_Lcom_annimon_stream_function_ThrowableFunction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapper)
		{
			global::Com.Annimon.Stream.Exceptional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IThrowableFunction mapper = (global::Com.Annimon.Stream.Function.IThrowableFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IThrowableFunction> (native_mapper, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Map (mapper));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Exceptional']/method[@name='map' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ThrowableFunction&lt;? super T, ? extends U, java.lang.Throwable&gt;']]"
		[Register ("map", "(Lcom/annimon/stream/function/ThrowableFunction;)Lcom/annimon/stream/Exceptional;", "GetMap_Lcom_annimon_stream_function_ThrowableFunction_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public virtual unsafe global::Com.Annimon.Stream.Exceptional Map (global::Com.Annimon.Stream.Function.IThrowableFunction mapper)
		{
			const string __id = "map.(Lcom/annimon/stream/function/ThrowableFunction;)Lcom/annimon/stream/Exceptional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Exceptional']/method[@name='of' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ThrowableSupplier&lt;T, java.lang.Throwable&gt;']]"
		[Register ("of", "(Lcom/annimon/stream/function/ThrowableSupplier;)Lcom/annimon/stream/Exceptional;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Exceptional Of (global::Com.Annimon.Stream.Function.IThrowableSupplier supplier)
		{
			const string __id = "of.(Lcom/annimon/stream/function/ThrowableSupplier;)Lcom/annimon/stream/Exceptional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((supplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) supplier).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Exceptional']/method[@name='of' and count(parameter)=1 and parameter[1][@type='java.lang.Throwable']]"
		[Register ("of", "(Ljava/lang/Throwable;)Lcom/annimon/stream/Exceptional;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Exceptional Of (global::Java.Lang.Throwable throwable)
		{
			const string __id = "of.(Ljava/lang/Throwable;)Lcom/annimon/stream/Exceptional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((throwable == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) throwable).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_or_Lcom_annimon_stream_function_Supplier_;
#pragma warning disable 0169
		static Delegate GetOr_Lcom_annimon_stream_function_Supplier_Handler ()
		{
			if (cb_or_Lcom_annimon_stream_function_Supplier_ == null)
				cb_or_Lcom_annimon_stream_function_Supplier_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Or_Lcom_annimon_stream_function_Supplier_);
			return cb_or_Lcom_annimon_stream_function_Supplier_;
		}

		static IntPtr n_Or_Lcom_annimon_stream_function_Supplier_ (IntPtr jnienv, IntPtr native__this, IntPtr native_supplier)
		{
			global::Com.Annimon.Stream.Exceptional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.ISupplier supplier = (global::Com.Annimon.Stream.Function.ISupplier)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ISupplier> (native_supplier, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Or (supplier));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Exceptional']/method[@name='or' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Supplier&lt;com.annimon.stream.Exceptional&lt;T&gt;&gt;']]"
		[Register ("or", "(Lcom/annimon/stream/function/Supplier;)Lcom/annimon/stream/Exceptional;", "GetOr_Lcom_annimon_stream_function_Supplier_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Exceptional Or (global::Com.Annimon.Stream.Function.ISupplier supplier)
		{
			const string __id = "or.(Lcom/annimon/stream/function/Supplier;)Lcom/annimon/stream/Exceptional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((supplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) supplier).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_recover_Lcom_annimon_stream_function_ThrowableFunction_;
#pragma warning disable 0169
		static Delegate GetRecover_Lcom_annimon_stream_function_ThrowableFunction_Handler ()
		{
			if (cb_recover_Lcom_annimon_stream_function_ThrowableFunction_ == null)
				cb_recover_Lcom_annimon_stream_function_ThrowableFunction_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Recover_Lcom_annimon_stream_function_ThrowableFunction_);
			return cb_recover_Lcom_annimon_stream_function_ThrowableFunction_;
		}

		static IntPtr n_Recover_Lcom_annimon_stream_function_ThrowableFunction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_function)
		{
			global::Com.Annimon.Stream.Exceptional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IThrowableFunction function = (global::Com.Annimon.Stream.Function.IThrowableFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IThrowableFunction> (native_function, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Recover (function));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Exceptional']/method[@name='recover' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ThrowableFunction&lt;java.lang.Throwable, ? extends T, java.lang.Throwable&gt;']]"
		[Register ("recover", "(Lcom/annimon/stream/function/ThrowableFunction;)Lcom/annimon/stream/Exceptional;", "GetRecover_Lcom_annimon_stream_function_ThrowableFunction_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Exceptional Recover (global::Com.Annimon.Stream.Function.IThrowableFunction function)
		{
			const string __id = "recover.(Lcom/annimon/stream/function/ThrowableFunction;)Lcom/annimon/stream/Exceptional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((function == null) ? IntPtr.Zero : ((global::Java.Lang.Object) function).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_recoverWith_Lcom_annimon_stream_function_Function_;
#pragma warning disable 0169
		static Delegate GetRecoverWith_Lcom_annimon_stream_function_Function_Handler ()
		{
			if (cb_recoverWith_Lcom_annimon_stream_function_Function_ == null)
				cb_recoverWith_Lcom_annimon_stream_function_Function_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_RecoverWith_Lcom_annimon_stream_function_Function_);
			return cb_recoverWith_Lcom_annimon_stream_function_Function_;
		}

		static IntPtr n_RecoverWith_Lcom_annimon_stream_function_Function_ (IntPtr jnienv, IntPtr native__this, IntPtr native_function)
		{
			global::Com.Annimon.Stream.Exceptional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IFunction function = (global::Com.Annimon.Stream.Function.IFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IFunction> (native_function, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.RecoverWith (function));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Exceptional']/method[@name='recoverWith' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;java.lang.Throwable, ? extends com.annimon.stream.Exceptional&lt;T&gt;&gt;']]"
		[Register ("recoverWith", "(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Exceptional;", "GetRecoverWith_Lcom_annimon_stream_function_Function_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Exceptional RecoverWith (global::Com.Annimon.Stream.Function.IFunction function)
		{
			const string __id = "recoverWith.(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Exceptional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((function == null) ? IntPtr.Zero : ((global::Java.Lang.Object) function).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Exceptional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
