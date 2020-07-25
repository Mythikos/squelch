using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream']/class[@name='Objects']"
	[global::Android.Runtime.Register ("com/annimon/stream/Objects", DoNotGenerateAcw=true)]
	public sealed partial class Objects : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/Objects", typeof (Objects));
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

		internal Objects (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Objects']/method[@name='compare' and count(parameter)=3 and parameter[1][@type='T'] and parameter[2][@type='T'] and parameter[3][@type='java.util.Comparator&lt;? super T&gt;']]"
		[Register ("compare", "(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)I", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe int Compare (global::Java.Lang.Object a, global::Java.Lang.Object b, global::Java.Util.IComparator c)
		{
			const string __id = "compare.(Ljava/lang/Object;Ljava/lang/Object;Ljava/util/Comparator;)I";
			IntPtr native_a = JNIEnv.ToLocalJniHandle (a);
			IntPtr native_b = JNIEnv.ToLocalJniHandle (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_a);
				__args [1] = new JniArgumentValue (native_b);
				__args [2] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_a);
				JNIEnv.DeleteLocalRef (native_b);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Objects']/method[@name='compareInt' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("compareInt", "(II)I", "")]
		public static unsafe int CompareInt (int x, int y)
		{
			const string __id = "compareInt.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Objects']/method[@name='compareLong' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("compareLong", "(JJ)I", "")]
		public static unsafe int CompareLong (long x, long y)
		{
			const string __id = "compareLong.(JJ)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Objects']/method[@name='deepEquals' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("deepEquals", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
		public static unsafe bool DeepEquals (global::Java.Lang.Object a, global::Java.Lang.Object b)
		{
			const string __id = "deepEquals.(Ljava/lang/Object;Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [1] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Objects']/method[@name='equals' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.Object']]"
		[Register ("equals", "(Ljava/lang/Object;Ljava/lang/Object;)Z", "")]
		public static unsafe bool Equals (global::Java.Lang.Object a, global::Java.Lang.Object b)
		{
			const string __id = "equals.(Ljava/lang/Object;Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((a == null) ? IntPtr.Zero : ((global::Java.Lang.Object) a).Handle);
				__args [1] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Objects']/method[@name='hash' and count(parameter)=1 and parameter[1][@type='java.lang.Object...']]"
		[Register ("hash", "([Ljava/lang/Object;)I", "")]
		public static unsafe int Hash (params global::Java.Lang.Object[] values)
		{
			const string __id = "hash.([Ljava/lang/Object;)I";
			IntPtr native_values = JNIEnv.NewArray (values);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_values);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (values != null) {
					JNIEnv.CopyArray (native_values, values);
					JNIEnv.DeleteLocalRef (native_values);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Objects']/method[@name='hashCode' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("hashCode", "(Ljava/lang/Object;)I", "")]
		public static unsafe int HashCode (global::Java.Lang.Object o)
		{
			const string __id = "hashCode.(Ljava/lang/Object;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Objects']/method[@name='isNull' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("isNull", "(Ljava/lang/Object;)Z", "")]
		public static unsafe bool IsNull (global::Java.Lang.Object obj)
		{
			const string __id = "isNull.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Objects']/method[@name='nonNull' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("nonNull", "(Ljava/lang/Object;)Z", "")]
		public static unsafe bool NonNull (global::Java.Lang.Object obj)
		{
			const string __id = "nonNull.(Ljava/lang/Object;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Objects']/method[@name='requireNonNull' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("requireNonNull", "(Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object RequireNonNull (global::Java.Lang.Object obj)
		{
			const string __id = "requireNonNull.(Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_obj = JNIEnv.ToLocalJniHandle (obj);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_obj);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Objects']/method[@name='requireNonNull' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='com.annimon.stream.function.Supplier&lt;java.lang.String&gt;']]"
		[Register ("requireNonNull", "(Ljava/lang/Object;Lcom/annimon/stream/function/Supplier;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object RequireNonNull (global::Java.Lang.Object obj, global::Com.Annimon.Stream.Function.ISupplier messageSupplier)
		{
			const string __id = "requireNonNull.(Ljava/lang/Object;Lcom/annimon/stream/function/Supplier;)Ljava/lang/Object;";
			IntPtr native_obj = JNIEnv.ToLocalJniHandle (obj);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_obj);
				__args [1] = new JniArgumentValue ((messageSupplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) messageSupplier).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Objects']/method[@name='requireNonNull' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='java.lang.String']]"
		[Register ("requireNonNull", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object RequireNonNull (global::Java.Lang.Object obj, string message)
		{
			const string __id = "requireNonNull.(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/Object;";
			IntPtr native_obj = JNIEnv.ToLocalJniHandle (obj);
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_obj);
				__args [1] = new JniArgumentValue (native_message);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_obj);
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Objects']/method[@name='requireNonNullElements' and count(parameter)=1 and parameter[1][@type='java.util.Collection&lt;T&gt;']]"
		[Register ("requireNonNullElements", "(Ljava/util/Collection;)Ljava/util/Collection;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::System.Collections.ICollection RequireNonNullElements (global::System.Collections.ICollection collection)
		{
			const string __id = "requireNonNullElements.(Ljava/util/Collection;)Ljava/util/Collection;";
			IntPtr native_collection = global::Android.Runtime.JavaCollection.ToLocalJniHandle (collection);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_collection);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaCollection.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_collection);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Objects']/method[@name='requireNonNullElse' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='T']]"
		[Register ("requireNonNullElse", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object RequireNonNullElse (global::Java.Lang.Object obj, global::Java.Lang.Object defaultObj)
		{
			const string __id = "requireNonNullElse.(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;";
			IntPtr native_obj = JNIEnv.ToLocalJniHandle (obj);
			IntPtr native_defaultObj = JNIEnv.ToLocalJniHandle (defaultObj);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_obj);
				__args [1] = new JniArgumentValue (native_defaultObj);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_obj);
				JNIEnv.DeleteLocalRef (native_defaultObj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Objects']/method[@name='requireNonNullElseGet' and count(parameter)=2 and parameter[1][@type='T'] and parameter[2][@type='com.annimon.stream.function.Supplier&lt;? extends T&gt;']]"
		[Register ("requireNonNullElseGet", "(Ljava/lang/Object;Lcom/annimon/stream/function/Supplier;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
		public static unsafe global::Java.Lang.Object RequireNonNullElseGet (global::Java.Lang.Object obj, global::Com.Annimon.Stream.Function.ISupplier supplier)
		{
			const string __id = "requireNonNullElseGet.(Ljava/lang/Object;Lcom/annimon/stream/function/Supplier;)Ljava/lang/Object;";
			IntPtr native_obj = JNIEnv.ToLocalJniHandle (obj);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_obj);
				__args [1] = new JniArgumentValue ((supplier == null) ? IntPtr.Zero : ((global::Java.Lang.Object) supplier).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_obj);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='Objects']/method[@name='toString' and count(parameter)=2 and parameter[1][@type='java.lang.Object'] and parameter[2][@type='java.lang.String']]"
		[Register ("toString", "(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ToString (global::Java.Lang.Object o, string nullDefault)
		{
			const string __id = "toString.(Ljava/lang/Object;Ljava/lang/String;)Ljava/lang/String;";
			IntPtr native_nullDefault = JNIEnv.NewString (nullDefault);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((o == null) ? IntPtr.Zero : ((global::Java.Lang.Object) o).Handle);
				__args [1] = new JniArgumentValue (native_nullDefault);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_nullDefault);
			}
		}

	}
}
