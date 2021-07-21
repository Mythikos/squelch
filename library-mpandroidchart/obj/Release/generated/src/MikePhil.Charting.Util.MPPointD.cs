using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='MPPointD']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/utils/MPPointD", DoNotGenerateAcw=true)]
	public partial class MPPointD : global::MikePhil.Charting.Util.ObjectPool.Poolable {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='MPPointD']/field[@name='x']"
		[Register ("x")]
		public double X {
			get {
				const string __id = "x.D";

				var __v = _members.InstanceFields.GetDoubleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "x.D";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='MPPointD']/field[@name='y']"
		[Register ("y")]
		public double Y {
			get {
				const string __id = "y.D";

				var __v = _members.InstanceFields.GetDoubleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "y.D";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/utils/MPPointD", typeof (MPPointD));
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

		protected MPPointD (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='MPPointD']/method[@name='getInstance' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("getInstance", "(DD)Lcom/github/mikephil/charting/utils/MPPointD;", "")]
		public static unsafe global::MikePhil.Charting.Util.MPPointD GetInstance (double x, double y)
		{
			const string __id = "getInstance.(DD)Lcom/github/mikephil/charting/utils/MPPointD;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointD> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::MikePhil.Charting.Util.MPPointD __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointD> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Instantiate ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='MPPointD']/method[@name='instantiate' and count(parameter)=0]"
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='MPPointD']/method[@name='recycleInstance' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.utils.MPPointD']]"
		[Register ("recycleInstance", "(Lcom/github/mikephil/charting/utils/MPPointD;)V", "")]
		public static unsafe void RecycleInstance (global::MikePhil.Charting.Util.MPPointD instance)
		{
			const string __id = "recycleInstance.(Lcom/github/mikephil/charting/utils/MPPointD;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((instance == null) ? IntPtr.Zero : ((global::Java.Lang.Object) instance).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='MPPointD']/method[@name='recycleInstances' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.github.mikephil.charting.utils.MPPointD&gt;']]"
		[Register ("recycleInstances", "(Ljava/util/List;)V", "")]
		public static unsafe void RecycleInstances (global::System.Collections.Generic.IList<global::MikePhil.Charting.Util.MPPointD> instances)
		{
			const string __id = "recycleInstances.(Ljava/util/List;)V";
			IntPtr native_instances = global::Android.Runtime.JavaList<global::MikePhil.Charting.Util.MPPointD>.ToLocalJniHandle (instances);
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
