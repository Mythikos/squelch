using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ObjectPool']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/utils/ObjectPool", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.github.mikephil.charting.utils.ObjectPool.Poolable"})]
	public partial class ObjectPool : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ObjectPool.Poolable']"
		[global::Android.Runtime.Register ("com/github/mikephil/charting/utils/ObjectPool$Poolable", DoNotGenerateAcw=true)]
		public abstract partial class Poolable : global::Java.Lang.Object {

			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ObjectPool.Poolable']/field[@name='NO_OWNER']"
			[Register ("NO_OWNER")]
			public static int NoOwner {
				get {
					const string __id = "NO_OWNER.I";

					var __v = _members.StaticFields.GetInt32Value (__id);
					return __v;
				}
				set {
					const string __id = "NO_OWNER.I";

					try {
						_members.StaticFields.SetValue (__id, value);
					} finally {
					}
				}
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/utils/ObjectPool$Poolable", typeof (Poolable));

			internal static IntPtr class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			protected Poolable (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ObjectPool.Poolable']/constructor[@name='ObjectPool.Poolable' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Poolable () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "()V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_instantiate;
#pragma warning disable 0169
			static Delegate GetInstantiateHandler ()
			{
				if (cb_instantiate == null)
					cb_instantiate = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Instantiate);
				return cb_instantiate;
			}

			static IntPtr n_Instantiate (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ObjectPool.Poolable> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Instantiate ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ObjectPool.Poolable']/method[@name='instantiate' and count(parameter)=0]"
			[Register ("instantiate", "()Lcom/github/mikephil/charting/utils/ObjectPool$Poolable;", "GetInstantiateHandler")]
			protected abstract global::MikePhil.Charting.Util.ObjectPool.Poolable Instantiate ();

		}

		[global::Android.Runtime.Register ("com/github/mikephil/charting/utils/ObjectPool$Poolable", DoNotGenerateAcw=true)]
		internal partial class PoolableInvoker : Poolable {
			public PoolableInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
			{
			}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/utils/ObjectPool$Poolable", typeof (PoolableInvoker));

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ObjectPool.Poolable']/method[@name='instantiate' and count(parameter)=0]"
			[Register ("instantiate", "()Lcom/github/mikephil/charting/utils/ObjectPool$Poolable;", "GetInstantiateHandler")]
			protected override unsafe global::MikePhil.Charting.Util.ObjectPool.Poolable Instantiate ()
			{
				const string __id = "instantiate.()Lcom/github/mikephil/charting/utils/ObjectPool$Poolable;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ObjectPool.Poolable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/utils/ObjectPool", typeof (ObjectPool));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected ObjectPool (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		static Delegate cb_getPoolCapacity;
#pragma warning disable 0169
		static Delegate GetGetPoolCapacityHandler ()
		{
			if (cb_getPoolCapacity == null)
				cb_getPoolCapacity = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPoolCapacity);
			return cb_getPoolCapacity;
		}

		static int n_GetPoolCapacity (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ObjectPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PoolCapacity;
		}
#pragma warning restore 0169

		public virtual unsafe int PoolCapacity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ObjectPool']/method[@name='getPoolCapacity' and count(parameter)=0]"
			[Register ("getPoolCapacity", "()I", "GetGetPoolCapacityHandler")]
			get {
				const string __id = "getPoolCapacity.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPoolCount;
#pragma warning disable 0169
		static Delegate GetGetPoolCountHandler ()
		{
			if (cb_getPoolCount == null)
				cb_getPoolCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPoolCount);
			return cb_getPoolCount;
		}

		static int n_GetPoolCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ObjectPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PoolCount;
		}
#pragma warning restore 0169

		public virtual unsafe int PoolCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ObjectPool']/method[@name='getPoolCount' and count(parameter)=0]"
			[Register ("getPoolCount", "()I", "GetGetPoolCountHandler")]
			get {
				const string __id = "getPoolCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPoolId;
#pragma warning disable 0169
		static Delegate GetGetPoolIdHandler ()
		{
			if (cb_getPoolId == null)
				cb_getPoolId = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetPoolId);
			return cb_getPoolId;
		}

		static int n_GetPoolId (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ObjectPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PoolId;
		}
#pragma warning restore 0169

		public virtual unsafe int PoolId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ObjectPool']/method[@name='getPoolId' and count(parameter)=0]"
			[Register ("getPoolId", "()I", "GetGetPoolIdHandler")]
			get {
				const string __id = "getPoolId.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getReplenishPercentage;
#pragma warning disable 0169
		static Delegate GetGetReplenishPercentageHandler ()
		{
			if (cb_getReplenishPercentage == null)
				cb_getReplenishPercentage = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetReplenishPercentage);
			return cb_getReplenishPercentage;
		}

		static float n_GetReplenishPercentage (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ObjectPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReplenishPercentage;
		}
#pragma warning restore 0169

		static Delegate cb_setReplenishPercentage_F;
#pragma warning disable 0169
		static Delegate GetSetReplenishPercentage_FHandler ()
		{
			if (cb_setReplenishPercentage_F == null)
				cb_setReplenishPercentage_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetReplenishPercentage_F);
			return cb_setReplenishPercentage_F;
		}

		static void n_SetReplenishPercentage_F (IntPtr jnienv, IntPtr native__this, float percentage)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ObjectPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReplenishPercentage = percentage;
		}
#pragma warning restore 0169

		public virtual unsafe float ReplenishPercentage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ObjectPool']/method[@name='getReplenishPercentage' and count(parameter)=0]"
			[Register ("getReplenishPercentage", "()F", "GetGetReplenishPercentageHandler")]
			get {
				const string __id = "getReplenishPercentage.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ObjectPool']/method[@name='setReplenishPercentage' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setReplenishPercentage", "(F)V", "GetSetReplenishPercentage_FHandler")]
			set {
				const string __id = "setReplenishPercentage.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ObjectPool']/method[@name='create' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.github.mikephil.charting.utils.ObjectPool.Poolable']]"
		[Register ("create", "(ILcom/github/mikephil/charting/utils/ObjectPool$Poolable;)Lcom/github/mikephil/charting/utils/ObjectPool;", "")]
		public static unsafe global::MikePhil.Charting.Util.ObjectPool Create (int withCapacity, global::MikePhil.Charting.Util.ObjectPool.Poolable @object)
		{
			const string __id = "create.(ILcom/github/mikephil/charting/utils/ObjectPool$Poolable;)Lcom/github/mikephil/charting/utils/ObjectPool;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (withCapacity);
				__args [1] = new JniArgumentValue ((@object == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @object).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ObjectPool> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (@object);
			}
		}

		static Delegate cb_get;
#pragma warning disable 0169
		static Delegate GetGetHandler ()
		{
			if (cb_get == null)
				cb_get = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Get);
			return cb_get;
		}

		static IntPtr n_Get (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ObjectPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Get ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ObjectPool']/method[@name='get' and count(parameter)=0]"
		[Register ("get", "()Lcom/github/mikephil/charting/utils/ObjectPool$Poolable;", "GetGetHandler")]
		public virtual unsafe global::Java.Lang.Object Get ()
		{
			const string __id = "get.()Lcom/github/mikephil/charting/utils/ObjectPool$Poolable;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_recycle_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetRecycle_Ljava_util_List_Handler ()
		{
			if (cb_recycle_Ljava_util_List_ == null)
				cb_recycle_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Recycle_Ljava_util_List_);
			return cb_recycle_Ljava_util_List_;
		}

		static void n_Recycle_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_objects)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ObjectPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var objects = global::Android.Runtime.JavaList.FromJniHandle (native_objects, JniHandleOwnership.DoNotTransfer);
			__this.Recycle (objects);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ObjectPool']/method[@name='recycle' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;T&gt;']]"
		[Register ("recycle", "(Ljava/util/List;)V", "GetRecycle_Ljava_util_List_Handler")]
		public virtual unsafe void Recycle (global::System.Collections.IList objects)
		{
			const string __id = "recycle.(Ljava/util/List;)V";
			IntPtr native_objects = global::Android.Runtime.JavaList.ToLocalJniHandle (objects);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_objects);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_objects);
				global::System.GC.KeepAlive (objects);
			}
		}

		static Delegate cb_recycle_Lcom_github_mikephil_charting_utils_ObjectPool_Poolable_;
#pragma warning disable 0169
		static Delegate GetRecycle_Lcom_github_mikephil_charting_utils_ObjectPool_Poolable_Handler ()
		{
			if (cb_recycle_Lcom_github_mikephil_charting_utils_ObjectPool_Poolable_ == null)
				cb_recycle_Lcom_github_mikephil_charting_utils_ObjectPool_Poolable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Recycle_Lcom_github_mikephil_charting_utils_ObjectPool_Poolable_);
			return cb_recycle_Lcom_github_mikephil_charting_utils_ObjectPool_Poolable_;
		}

		static void n_Recycle_Lcom_github_mikephil_charting_utils_ObjectPool_Poolable_ (IntPtr jnienv, IntPtr native__this, IntPtr native__object)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ObjectPool> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var @object = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native__object, JniHandleOwnership.DoNotTransfer);
			__this.Recycle (@object);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ObjectPool']/method[@name='recycle' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("recycle", "(Lcom/github/mikephil/charting/utils/ObjectPool$Poolable;)V", "GetRecycle_Lcom_github_mikephil_charting_utils_ObjectPool_Poolable_Handler")]
		public virtual unsafe void Recycle (global::Java.Lang.Object @object)
		{
			const string __id = "recycle.(Lcom/github/mikephil/charting/utils/ObjectPool$Poolable;)V";
			IntPtr native__object = JNIEnv.ToLocalJniHandle (@object);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native__object);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native__object);
				global::System.GC.KeepAlive (@object);
			}
		}

	}
}
