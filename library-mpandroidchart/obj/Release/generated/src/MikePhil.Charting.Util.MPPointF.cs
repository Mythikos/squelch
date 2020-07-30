using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='MPPointF']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/utils/MPPointF", DoNotGenerateAcw=true)]
	public partial class MPPointF : global::MikePhil.Charting.Util.ObjectPool.Poolable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='MPPointF']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				const string __id = "CREATOR.Landroid/os/Parcelable$Creator;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='MPPointF']/field[@name='x']"
		[Register ("x")]
		public float X {
			get {
				const string __id = "x.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "x.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='MPPointF']/field[@name='y']"
		[Register ("y")]
		public float Y {
			get {
				const string __id = "y.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "y.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/utils/MPPointF", typeof (MPPointF));
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

		protected MPPointF (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='MPPointF']/constructor[@name='MPPointF' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe MPPointF ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='MPPointF']/constructor[@name='MPPointF' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register (".ctor", "(FF)V", "")]
		public unsafe MPPointF (float x, float y)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FF)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public static unsafe global::MikePhil.Charting.Util.MPPointF Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='MPPointF']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/github/mikephil/charting/utils/MPPointF;", "")]
			get {
				const string __id = "getInstance.()Lcom/github/mikephil/charting/utils/MPPointF;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='MPPointF']/method[@name='getInstance' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.utils.MPPointF']]"
		[Register ("getInstance", "(Lcom/github/mikephil/charting/utils/MPPointF;)Lcom/github/mikephil/charting/utils/MPPointF;", "")]
		public static unsafe global::MikePhil.Charting.Util.MPPointF GetInstance (global::MikePhil.Charting.Util.MPPointF copy)
		{
			const string __id = "getInstance.(Lcom/github/mikephil/charting/utils/MPPointF;)Lcom/github/mikephil/charting/utils/MPPointF;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((copy == null) ? IntPtr.Zero : ((global::Java.Lang.Object) copy).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='MPPointF']/method[@name='getInstance' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("getInstance", "(FF)Lcom/github/mikephil/charting/utils/MPPointF;", "")]
		public static unsafe global::MikePhil.Charting.Util.MPPointF GetInstance (float x, float y)
		{
			const string __id = "getInstance.(FF)Lcom/github/mikephil/charting/utils/MPPointF;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getX;
#pragma warning disable 0169
		static Delegate GetGetXHandler ()
		{
			if (cb_getX == null)
				cb_getX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetX);
			return cb_getX;
		}

		static float n_GetX (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.MPPointF __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetX ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='MPPointF']/method[@name='getX' and count(parameter)=0]"
		[Register ("getX", "()F", "GetGetXHandler")]
		public virtual unsafe float GetX ()
		{
			const string __id = "getX.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getY;
#pragma warning disable 0169
		static Delegate GetGetYHandler ()
		{
			if (cb_getY == null)
				cb_getY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetY);
			return cb_getY;
		}

		static float n_GetY (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.MPPointF __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetY ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='MPPointF']/method[@name='getY' and count(parameter)=0]"
		[Register ("getY", "()F", "GetGetYHandler")]
		public virtual unsafe float GetY ()
		{
			const string __id = "getY.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_instantiate;
#pragma warning disable 0169
		static Delegate GetInstantiateHandler ()
		{
			if (cb_instantiate == null)
				cb_instantiate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Instantiate);
			return cb_instantiate;
		}

		static IntPtr n_Instantiate (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.MPPointF __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Instantiate ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='MPPointF']/method[@name='instantiate' and count(parameter)=0]"
		[Register ("instantiate", "()Lcom/github/mikephil/charting/utils/ObjectPool$Poolable;", "GetInstantiateHandler")]
		protected override unsafe global::MikePhil.Charting.Util.ObjectPool.Poolable Instantiate ()
		{
			const string __id = "instantiate.()Lcom/github/mikephil/charting/utils/ObjectPool$Poolable;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ObjectPool.Poolable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_my_readFromParcel_Landroid_os_Parcel_;
#pragma warning disable 0169
		static Delegate GetMy_readFromParcel_Landroid_os_Parcel_Handler ()
		{
			if (cb_my_readFromParcel_Landroid_os_Parcel_ == null)
				cb_my_readFromParcel_Landroid_os_Parcel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_My_readFromParcel_Landroid_os_Parcel_);
			return cb_my_readFromParcel_Landroid_os_Parcel_;
		}

		static void n_My_readFromParcel_Landroid_os_Parcel_ (IntPtr jnienv, IntPtr native__this, IntPtr native__in)
		{
			global::MikePhil.Charting.Util.MPPointF __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel @in = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native__in, JniHandleOwnership.DoNotTransfer);
			__this.My_readFromParcel (@in);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='MPPointF']/method[@name='my_readFromParcel' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register ("my_readFromParcel", "(Landroid/os/Parcel;)V", "GetMy_readFromParcel_Landroid_os_Parcel_Handler")]
		public virtual unsafe void My_readFromParcel (global::Android.OS.Parcel @in)
		{
			const string __id = "my_readFromParcel.(Landroid/os/Parcel;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((@in == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @in).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='MPPointF']/method[@name='recycleInstance' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.utils.MPPointF']]"
		[Register ("recycleInstance", "(Lcom/github/mikephil/charting/utils/MPPointF;)V", "")]
		public static unsafe void RecycleInstance (global::MikePhil.Charting.Util.MPPointF instance)
		{
			const string __id = "recycleInstance.(Lcom/github/mikephil/charting/utils/MPPointF;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((instance == null) ? IntPtr.Zero : ((global::Java.Lang.Object) instance).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='MPPointF']/method[@name='recycleInstances' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.github.mikephil.charting.utils.MPPointF&gt;']]"
		[Register ("recycleInstances", "(Ljava/util/List;)V", "")]
		public static unsafe void RecycleInstances (global::System.Collections.Generic.IList<global::MikePhil.Charting.Util.MPPointF> instances)
		{
			const string __id = "recycleInstances.(Ljava/util/List;)V";
			IntPtr native_instances = global::Android.Runtime.JavaList<global::MikePhil.Charting.Util.MPPointF>.ToLocalJniHandle (instances);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_instances);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_instances);
			}
		}

	}
}
