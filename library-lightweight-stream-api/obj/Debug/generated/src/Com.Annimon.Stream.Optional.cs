using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']"
	[global::Android.Runtime.Register ("com/annimon/stream/Optional", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public partial class Optional : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/Optional", typeof (Optional));
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

		protected Optional (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				const string __id = "isEmpty.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
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
			global::Com.Annimon.Stream.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPresent;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsPresent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='isPresent' and count(parameter)=0]"
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
			global::Com.Annimon.Stream.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IFunction function = (global::Com.Annimon.Stream.Function.IFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IFunction> (native_function, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Custom (function));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='custom' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;com.annimon.stream.Optional&lt;T&gt;, R&gt;']]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='empty' and count(parameter)=0]"
		[Register ("empty", "()Lcom/annimon/stream/Optional;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Optional Empty ()
		{
			const string __id = "empty.()Lcom/annimon/stream/Optional;";
			try {
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_executeIfAbsent_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetExecuteIfAbsent_Ljava_lang_Runnable_Handler ()
		{
			if (cb_executeIfAbsent_Ljava_lang_Runnable_ == null)
				cb_executeIfAbsent_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ExecuteIfAbsent_Ljava_lang_Runnable_);
			return cb_executeIfAbsent_Ljava_lang_Runnable_;
		}

		static IntPtr n_ExecuteIfAbsent_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_action)
		{
			global::Com.Annimon.Stream.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable action = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_action, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ExecuteIfAbsent (action));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='executeIfAbsent' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("executeIfAbsent", "(Ljava/lang/Runnable;)Lcom/annimon/stream/Optional;", "GetExecuteIfAbsent_Ljava_lang_Runnable_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Optional ExecuteIfAbsent (global::Java.Lang.IRunnable action)
		{
			const string __id = "executeIfAbsent.(Ljava/lang/Runnable;)Lcom/annimon/stream/Optional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((action == null) ? IntPtr.Zero : ((global::Java.Lang.Object) action).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_executeIfPresent_Lcom_annimon_stream_function_Consumer_;
#pragma warning disable 0169
		static Delegate GetExecuteIfPresent_Lcom_annimon_stream_function_Consumer_Handler ()
		{
			if (cb_executeIfPresent_Lcom_annimon_stream_function_Consumer_ == null)
				cb_executeIfPresent_Lcom_annimon_stream_function_Consumer_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_ExecuteIfPresent_Lcom_annimon_stream_function_Consumer_);
			return cb_executeIfPresent_Lcom_annimon_stream_function_Consumer_;
		}

		static IntPtr n_ExecuteIfPresent_Lcom_annimon_stream_function_Consumer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_consumer)
		{
			global::Com.Annimon.Stream.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IConsumer consumer = (global::Com.Annimon.Stream.Function.IConsumer)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IConsumer> (native_consumer, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.ExecuteIfPresent (consumer));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='executeIfPresent' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Consumer&lt;? super T&gt;']]"
		[Register ("executeIfPresent", "(Lcom/annimon/stream/function/Consumer;)Lcom/annimon/stream/Optional;", "GetExecuteIfPresent_Lcom_annimon_stream_function_Consumer_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Optional ExecuteIfPresent (global::Com.Annimon.Stream.Function.IConsumer consumer)
		{
			const string __id = "executeIfPresent.(Lcom/annimon/stream/function/Consumer;)Lcom/annimon/stream/Optional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((consumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consumer).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::Com.Annimon.Stream.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IPredicate predicate = (global::Com.Annimon.Stream.Function.IPredicate)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IPredicate> (native_predicate, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Filter (predicate));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='filter' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;']]"
		[Register ("filter", "(Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/Optional;", "GetFilter_Lcom_annimon_stream_function_Predicate_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Optional Filter (global::Com.Annimon.Stream.Function.IPredicate predicate)
		{
			const string __id = "filter.(Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/Optional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Annimon.Stream.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IPredicate predicate = (global::Com.Annimon.Stream.Function.IPredicate)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IPredicate> (native_predicate, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FilterNot (predicate));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='filterNot' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Predicate&lt;? super T&gt;']]"
		[Register ("filterNot", "(Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/Optional;", "GetFilterNot_Lcom_annimon_stream_function_Predicate_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Optional FilterNot (global::Com.Annimon.Stream.Function.IPredicate predicate)
		{
			const string __id = "filterNot.(Lcom/annimon/stream/function/Predicate;)Lcom/annimon/stream/Optional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((predicate == null) ? IntPtr.Zero : ((global::Java.Lang.Object) predicate).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
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
			global::Com.Annimon.Stream.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IFunction mapper = (global::Com.Annimon.Stream.Function.IFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IFunction> (native_mapper, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.FlatMap (mapper));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='flatMap' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, com.annimon.stream.Optional&lt;U&gt;&gt;']]"
		[Register ("flatMap", "(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Optional;", "GetFlatMap_Lcom_annimon_stream_function_Function_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public virtual unsafe global::Com.Annimon.Stream.Optional FlatMap (global::Com.Annimon.Stream.Function.IFunction mapper)
		{
			const string __id = "flatMap.(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Optional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Annimon.Stream.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='get' and count(parameter)=0]"
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

		static Delegate cb_ifPresent_Lcom_annimon_stream_function_Consumer_;
#pragma warning disable 0169
		static Delegate GetIfPresent_Lcom_annimon_stream_function_Consumer_Handler ()
		{
			if (cb_ifPresent_Lcom_annimon_stream_function_Consumer_ == null)
				cb_ifPresent_Lcom_annimon_stream_function_Consumer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_IfPresent_Lcom_annimon_stream_function_Consumer_);
			return cb_ifPresent_Lcom_annimon_stream_function_Consumer_;
		}

		static void n_IfPresent_Lcom_annimon_stream_function_Consumer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_consumer)
		{
			global::Com.Annimon.Stream.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IConsumer consumer = (global::Com.Annimon.Stream.Function.IConsumer)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IConsumer> (native_consumer, JniHandleOwnership.DoNotTransfer);
			__this.IfPresent (consumer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='ifPresent' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Consumer&lt;? super T&gt;']]"
		[Register ("ifPresent", "(Lcom/annimon/stream/function/Consumer;)V", "GetIfPresent_Lcom_annimon_stream_function_Consumer_Handler")]
		public virtual unsafe void IfPresent (global::Com.Annimon.Stream.Function.IConsumer consumer)
		{
			const string __id = "ifPresent.(Lcom/annimon/stream/function/Consumer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((consumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consumer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_ifPresentOrElse_Lcom_annimon_stream_function_Consumer_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetIfPresentOrElse_Lcom_annimon_stream_function_Consumer_Ljava_lang_Runnable_Handler ()
		{
			if (cb_ifPresentOrElse_Lcom_annimon_stream_function_Consumer_Ljava_lang_Runnable_ == null)
				cb_ifPresentOrElse_Lcom_annimon_stream_function_Consumer_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_IfPresentOrElse_Lcom_annimon_stream_function_Consumer_Ljava_lang_Runnable_);
			return cb_ifPresentOrElse_Lcom_annimon_stream_function_Consumer_Ljava_lang_Runnable_;
		}

		static void n_IfPresentOrElse_Lcom_annimon_stream_function_Consumer_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_consumer, IntPtr native_emptyAction)
		{
			global::Com.Annimon.Stream.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IConsumer consumer = (global::Com.Annimon.Stream.Function.IConsumer)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IConsumer> (native_consumer, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable emptyAction = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_emptyAction, JniHandleOwnership.DoNotTransfer);
			__this.IfPresentOrElse (consumer, emptyAction);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='ifPresentOrElse' and count(parameter)=2 and parameter[1][@type='com.annimon.stream.function.Consumer&lt;? super T&gt;'] and parameter[2][@type='java.lang.Runnable']]"
		[Register ("ifPresentOrElse", "(Lcom/annimon/stream/function/Consumer;Ljava/lang/Runnable;)V", "GetIfPresentOrElse_Lcom_annimon_stream_function_Consumer_Ljava_lang_Runnable_Handler")]
		public virtual unsafe void IfPresentOrElse (global::Com.Annimon.Stream.Function.IConsumer consumer, global::Java.Lang.IRunnable emptyAction)
		{
			const string __id = "ifPresentOrElse.(Lcom/annimon/stream/function/Consumer;Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((consumer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) consumer).Handle);
				__args [1] = new JniArgumentValue ((emptyAction == null) ? IntPtr.Zero : ((global::Java.Lang.Object) emptyAction).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::Com.Annimon.Stream.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IFunction mapper = (global::Com.Annimon.Stream.Function.IFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IFunction> (native_mapper, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Map (mapper));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='map' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Function&lt;? super T, ? extends U&gt;']]"
		[Register ("map", "(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Optional;", "GetMap_Lcom_annimon_stream_function_Function_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U"})]
		public virtual unsafe global::Com.Annimon.Stream.Optional Map (global::Com.Annimon.Stream.Function.IFunction mapper)
		{
			const string __id = "map.(Lcom/annimon/stream/function/Function;)Lcom/annimon/stream/Optional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_mapToBoolean_Lcom_annimon_stream_function_ToBooleanFunction_;
#pragma warning disable 0169
		static Delegate GetMapToBoolean_Lcom_annimon_stream_function_ToBooleanFunction_Handler ()
		{
			if (cb_mapToBoolean_Lcom_annimon_stream_function_ToBooleanFunction_ == null)
				cb_mapToBoolean_Lcom_annimon_stream_function_ToBooleanFunction_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_MapToBoolean_Lcom_annimon_stream_function_ToBooleanFunction_);
			return cb_mapToBoolean_Lcom_annimon_stream_function_ToBooleanFunction_;
		}

		static IntPtr n_MapToBoolean_Lcom_annimon_stream_function_ToBooleanFunction_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mapper)
		{
			global::Com.Annimon.Stream.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IToBooleanFunction mapper = (global::Com.Annimon.Stream.Function.IToBooleanFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IToBooleanFunction> (native_mapper, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MapToBoolean (mapper));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='mapToBoolean' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ToBooleanFunction&lt;? super T&gt;']]"
		[Register ("mapToBoolean", "(Lcom/annimon/stream/function/ToBooleanFunction;)Lcom/annimon/stream/OptionalBoolean;", "GetMapToBoolean_Lcom_annimon_stream_function_ToBooleanFunction_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.OptionalBoolean MapToBoolean (global::Com.Annimon.Stream.Function.IToBooleanFunction mapper)
		{
			const string __id = "mapToBoolean.(Lcom/annimon/stream/function/ToBooleanFunction;)Lcom/annimon/stream/OptionalBoolean;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalBoolean> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Annimon.Stream.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IToDoubleFunction mapper = (global::Com.Annimon.Stream.Function.IToDoubleFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IToDoubleFunction> (native_mapper, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MapToDouble (mapper));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='mapToDouble' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ToDoubleFunction&lt;? super T&gt;']]"
		[Register ("mapToDouble", "(Lcom/annimon/stream/function/ToDoubleFunction;)Lcom/annimon/stream/OptionalDouble;", "GetMapToDouble_Lcom_annimon_stream_function_ToDoubleFunction_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.OptionalDouble MapToDouble (global::Com.Annimon.Stream.Function.IToDoubleFunction mapper)
		{
			const string __id = "mapToDouble.(Lcom/annimon/stream/function/ToDoubleFunction;)Lcom/annimon/stream/OptionalDouble;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalDouble> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Annimon.Stream.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IToIntFunction mapper = (global::Com.Annimon.Stream.Function.IToIntFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IToIntFunction> (native_mapper, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MapToInt (mapper));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='mapToInt' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ToIntFunction&lt;? super T&gt;']]"
		[Register ("mapToInt", "(Lcom/annimon/stream/function/ToIntFunction;)Lcom/annimon/stream/OptionalInt;", "GetMapToInt_Lcom_annimon_stream_function_ToIntFunction_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.OptionalInt MapToInt (global::Com.Annimon.Stream.Function.IToIntFunction mapper)
		{
			const string __id = "mapToInt.(Lcom/annimon/stream/function/ToIntFunction;)Lcom/annimon/stream/OptionalInt;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalInt> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::Com.Annimon.Stream.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.IToLongFunction mapper = (global::Com.Annimon.Stream.Function.IToLongFunction)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.IToLongFunction> (native_mapper, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.MapToLong (mapper));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='mapToLong' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.ToLongFunction&lt;? super T&gt;']]"
		[Register ("mapToLong", "(Lcom/annimon/stream/function/ToLongFunction;)Lcom/annimon/stream/OptionalLong;", "GetMapToLong_Lcom_annimon_stream_function_ToLongFunction_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.OptionalLong MapToLong (global::Com.Annimon.Stream.Function.IToLongFunction mapper)
		{
			const string __id = "mapToLong.(Lcom/annimon/stream/function/ToLongFunction;)Lcom/annimon/stream/OptionalLong;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((mapper == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mapper).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.OptionalLong> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='of' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("of", "(Ljava/lang/Object;)Lcom/annimon/stream/Optional;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Optional Of (global::Java.Lang.Object value)
		{
			const string __id = "of.(Ljava/lang/Object;)Lcom/annimon/stream/Optional;";
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='ofNullable' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("ofNullable", "(Ljava/lang/Object;)Lcom/annimon/stream/Optional;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Com.Annimon.Stream.Optional OfNullable (global::Java.Lang.Object value)
		{
			const string __id = "ofNullable.(Ljava/lang/Object;)Lcom/annimon/stream/Optional;";
			IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_value);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_value);
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
			global::Com.Annimon.Stream.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.ISupplier supplier = (global::Com.Annimon.Stream.Function.ISupplier)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ISupplier> (native_supplier, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Or (supplier));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='or' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Supplier&lt;com.annimon.stream.Optional&lt;T&gt;&gt;']]"
		[Register ("or", "(Lcom/annimon/stream/function/Supplier;)Lcom/annimon/stream/Optional;", "GetOr_Lcom_annimon_stream_function_Supplier_Handler")]
		public virtual unsafe global::Com.Annimon.Stream.Optional Or (global::Com.Annimon.Stream.Function.ISupplier supplier)
		{
			const string __id = "or.(Lcom/annimon/stream/function/Supplier;)Lcom/annimon/stream/Optional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((supplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) supplier).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_orElse_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetOrElse_Ljava_lang_Object_Handler ()
		{
			if (cb_orElse_Ljava_lang_Object_ == null)
				cb_orElse_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OrElse_Ljava_lang_Object_);
			return cb_orElse_Ljava_lang_Object_;
		}

		static IntPtr n_OrElse_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::Com.Annimon.Stream.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object other = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OrElse (other));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='orElse' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("orElse", "(Ljava/lang/Object;)Ljava/lang/Object;", "GetOrElse_Ljava_lang_Object_Handler")]
		public virtual unsafe global::Java.Lang.Object OrElse (global::Java.Lang.Object other)
		{
			const string __id = "orElse.(Ljava/lang/Object;)Ljava/lang/Object;";
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

		static Delegate cb_orElseGet_Lcom_annimon_stream_function_Supplier_;
#pragma warning disable 0169
		static Delegate GetOrElseGet_Lcom_annimon_stream_function_Supplier_Handler ()
		{
			if (cb_orElseGet_Lcom_annimon_stream_function_Supplier_ == null)
				cb_orElseGet_Lcom_annimon_stream_function_Supplier_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OrElseGet_Lcom_annimon_stream_function_Supplier_);
			return cb_orElseGet_Lcom_annimon_stream_function_Supplier_;
		}

		static IntPtr n_OrElseGet_Lcom_annimon_stream_function_Supplier_ (IntPtr jnienv, IntPtr native__this, IntPtr native_other)
		{
			global::Com.Annimon.Stream.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.ISupplier other = (global::Com.Annimon.Stream.Function.ISupplier)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ISupplier> (native_other, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OrElseGet (other));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='orElseGet' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Supplier&lt;? extends T&gt;']]"
		[Register ("orElseGet", "(Lcom/annimon/stream/function/Supplier;)Ljava/lang/Object;", "GetOrElseGet_Lcom_annimon_stream_function_Supplier_Handler")]
		public virtual unsafe global::Java.Lang.Object OrElseGet (global::Com.Annimon.Stream.Function.ISupplier other)
		{
			const string __id = "orElseGet.(Lcom/annimon/stream/function/Supplier;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_orElseThrow;
#pragma warning disable 0169
		static Delegate GetOrElseThrowHandler ()
		{
			if (cb_orElseThrow == null)
				cb_orElseThrow = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_OrElseThrow);
			return cb_orElseThrow;
		}

		static IntPtr n_OrElseThrow (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OrElseThrow ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='orElseThrow' and count(parameter)=0]"
		[Register ("orElseThrow", "()Ljava/lang/Object;", "GetOrElseThrowHandler")]
		public virtual unsafe global::Java.Lang.Object OrElseThrow ()
		{
			const string __id = "orElseThrow.()Ljava/lang/Object;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_orElseThrow_Lcom_annimon_stream_function_Supplier_;
#pragma warning disable 0169
		static Delegate GetOrElseThrow_Lcom_annimon_stream_function_Supplier_Handler ()
		{
			if (cb_orElseThrow_Lcom_annimon_stream_function_Supplier_ == null)
				cb_orElseThrow_Lcom_annimon_stream_function_Supplier_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_OrElseThrow_Lcom_annimon_stream_function_Supplier_);
			return cb_orElseThrow_Lcom_annimon_stream_function_Supplier_;
		}

		static IntPtr n_OrElseThrow_Lcom_annimon_stream_function_Supplier_ (IntPtr jnienv, IntPtr native__this, IntPtr native_exc)
		{
			global::Com.Annimon.Stream.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Annimon.Stream.Function.ISupplier exc = (global::Com.Annimon.Stream.Function.ISupplier)global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Function.ISupplier> (native_exc, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.OrElseThrow (exc));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='orElseThrow' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.function.Supplier&lt;? extends X&gt;']]"
		[Register ("orElseThrow", "(Lcom/annimon/stream/function/Supplier;)Ljava/lang/Object;", "GetOrElseThrow_Lcom_annimon_stream_function_Supplier_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"X extends java.lang.Throwable"})]
		public virtual unsafe global::Java.Lang.Object OrElseThrow (global::Com.Annimon.Stream.Function.ISupplier exc)
		{
			const string __id = "orElseThrow.(Lcom/annimon/stream/function/Supplier;)Ljava/lang/Object;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((exc == null) ? IntPtr.Zero : ((global::Java.Lang.Object) exc).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
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
			global::Com.Annimon.Stream.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Class clazz = global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (native_clazz, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Select (clazz));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='select' and count(parameter)=1 and parameter[1][@type='java.lang.Class&lt;R&gt;']]"
		[Register ("select", "(Ljava/lang/Class;)Lcom/annimon/stream/Optional;", "GetSelect_Ljava_lang_Class_Handler")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"R"})]
		public virtual unsafe global::Com.Annimon.Stream.Optional Select (global::Java.Lang.Class clazz)
		{
			const string __id = "select.(Ljava/lang/Class;)Lcom/annimon/stream/Optional;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((clazz == null) ? IntPtr.Zero : ((global::Java.Lang.Object) clazz).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_stream;
#pragma warning disable 0169
		static Delegate GetStreamHandler ()
		{
			if (cb_stream == null)
				cb_stream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Stream);
			return cb_stream;
		}

		static IntPtr n_Stream (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Annimon.Stream.Optional __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Optional> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Stream ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Optional']/method[@name='stream' and count(parameter)=0]"
		[Register ("stream", "()Lcom/annimon/stream/Stream;", "GetStreamHandler")]
		public virtual unsafe global::Com.Annimon.Stream.Stream Stream ()
		{
			const string __id = "stream.()Lcom/annimon/stream/Stream;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Stream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
