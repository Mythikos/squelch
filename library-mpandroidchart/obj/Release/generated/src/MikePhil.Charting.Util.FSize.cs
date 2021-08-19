using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='FSize']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/utils/FSize", DoNotGenerateAcw=true)]
	public sealed partial class FSize : global::MikePhil.Charting.Util.ObjectPool.Poolable {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='FSize']/field[@name='height']"
		[Register ("height")]
		public float Height {
			get {
				const string __id = "height.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "height.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='FSize']/field[@name='width']"
		[Register ("width")]
		public float Width {
			get {
				const string __id = "width.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "width.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/utils/FSize", typeof (FSize));

		internal static new IntPtr class_ref {
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

		internal FSize (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='FSize']/constructor[@name='FSize' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FSize () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='FSize']/constructor[@name='FSize' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register (".ctor", "(FF)V", "")]
		public unsafe FSize (float width, float height) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FF)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='FSize']/method[@name='getInstance' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("getInstance", "(FF)Lcom/github/mikephil/charting/utils/FSize;", "")]
		public static unsafe global::MikePhil.Charting.Util.FSize GetInstance (float width, float height)
		{
			const string __id = "getInstance.(FF)Lcom/github/mikephil/charting/utils/FSize;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.FSize> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='FSize']/method[@name='instantiate' and count(parameter)=0]"
		[Register ("instantiate", "()Lcom/github/mikephil/charting/utils/ObjectPool$Poolable;", "")]
		protected override unsafe global::MikePhil.Charting.Util.ObjectPool.Poolable Instantiate ()
		{
			const string __id = "instantiate.()Lcom/github/mikephil/charting/utils/ObjectPool$Poolable;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ObjectPool.Poolable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='FSize']/method[@name='recycleInstance' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.utils.FSize']]"
		[Register ("recycleInstance", "(Lcom/github/mikephil/charting/utils/FSize;)V", "")]
		public static unsafe void RecycleInstance (global::MikePhil.Charting.Util.FSize instance)
		{
			const string __id = "recycleInstance.(Lcom/github/mikephil/charting/utils/FSize;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((instance == null) ? IntPtr.Zero : ((global::Java.Lang.Object) instance).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				global::System.GC.KeepAlive (instance);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='FSize']/method[@name='recycleInstances' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.github.mikephil.charting.utils.FSize&gt;']]"
		[Register ("recycleInstances", "(Ljava/util/List;)V", "")]
		public static unsafe void RecycleInstances (global::System.Collections.Generic.IList<global::MikePhil.Charting.Util.FSize> instances)
		{
			const string __id = "recycleInstances.(Ljava/util/List;)V";
			IntPtr native_instances = global::Android.Runtime.JavaList<global::MikePhil.Charting.Util.FSize>.ToLocalJniHandle (instances);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_instances);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_instances);
				global::System.GC.KeepAlive (instances);
			}
		}

	}
}
