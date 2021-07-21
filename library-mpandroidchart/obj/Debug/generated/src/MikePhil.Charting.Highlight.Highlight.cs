using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Highlight {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='Highlight']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/highlight/Highlight", DoNotGenerateAcw=true)]
	public partial class Highlight : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/highlight/Highlight", typeof (Highlight));
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

		protected Highlight (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='Highlight']/constructor[@name='Highlight' and count(parameter)=6 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='int'] and parameter[6][@type='com.github.mikephil.charting.components.YAxis.AxisDependency']]"
		[Register (".ctor", "(FFFFILcom/github/mikephil/charting/components/YAxis$AxisDependency;)V", "")]
		public unsafe Highlight (float x, float y, float xPx, float yPx, int dataSetIndex, global::MikePhil.Charting.Components.YAxis.AxisDependency axis)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FFFFILcom/github/mikephil/charting/components/YAxis$AxisDependency;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue (xPx);
				__args [3] = new JniArgumentValue (yPx);
				__args [4] = new JniArgumentValue (dataSetIndex);
				__args [5] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='Highlight']/constructor[@name='Highlight' and count(parameter)=7 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='com.github.mikephil.charting.components.YAxis.AxisDependency']]"
		[Register (".ctor", "(FFFFIILcom/github/mikephil/charting/components/YAxis$AxisDependency;)V", "")]
		public unsafe Highlight (float x, float y, float xPx, float yPx, int dataSetIndex, int stackIndex, global::MikePhil.Charting.Components.YAxis.AxisDependency axis)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FFFFIILcom/github/mikephil/charting/components/YAxis$AxisDependency;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue (xPx);
				__args [3] = new JniArgumentValue (yPx);
				__args [4] = new JniArgumentValue (dataSetIndex);
				__args [5] = new JniArgumentValue (stackIndex);
				__args [6] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='Highlight']/constructor[@name='Highlight' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='int']]"
		[Register (".ctor", "(FFI)V", "")]
		public unsafe Highlight (float x, float y, int dataSetIndex)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FFI)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue (dataSetIndex);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='Highlight']/constructor[@name='Highlight' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register (".ctor", "(FII)V", "")]
		public unsafe Highlight (float x, int dataSetIndex, int stackIndex)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FII)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (dataSetIndex);
				__args [2] = new JniArgumentValue (stackIndex);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getAxis;
#pragma warning disable 0169
		static Delegate GetGetAxisHandler ()
		{
			if (cb_getAxis == null)
				cb_getAxis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAxis);
			return cb_getAxis;
		}

		static IntPtr n_GetAxis (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Highlight.Highlight __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Axis);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Components.YAxis.AxisDependency Axis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='Highlight']/method[@name='getAxis' and count(parameter)=0]"
			[Register ("getAxis", "()Lcom/github/mikephil/charting/components/YAxis$AxisDependency;", "GetGetAxisHandler")]
			get {
				const string __id = "getAxis.()Lcom/github/mikephil/charting/components/YAxis$AxisDependency;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDataIndex;
#pragma warning disable 0169
		static Delegate GetGetDataIndexHandler ()
		{
			if (cb_getDataIndex == null)
				cb_getDataIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDataIndex);
			return cb_getDataIndex;
		}

		static int n_GetDataIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Highlight.Highlight __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DataIndex;
		}
#pragma warning restore 0169

		static Delegate cb_setDataIndex_I;
#pragma warning disable 0169
		static Delegate GetSetDataIndex_IHandler ()
		{
			if (cb_setDataIndex_I == null)
				cb_setDataIndex_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDataIndex_I);
			return cb_setDataIndex_I;
		}

		static void n_SetDataIndex_I (IntPtr jnienv, IntPtr native__this, int mDataIndex)
		{
			global::MikePhil.Charting.Highlight.Highlight __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DataIndex = mDataIndex;
		}
#pragma warning restore 0169

		public virtual unsafe int DataIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='Highlight']/method[@name='getDataIndex' and count(parameter)=0]"
			[Register ("getDataIndex", "()I", "GetGetDataIndexHandler")]
			get {
				const string __id = "getDataIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='Highlight']/method[@name='setDataIndex' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setDataIndex", "(I)V", "GetSetDataIndex_IHandler")]
			set {
				const string __id = "setDataIndex.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDataSetIndex;
#pragma warning disable 0169
		static Delegate GetGetDataSetIndexHandler ()
		{
			if (cb_getDataSetIndex == null)
				cb_getDataSetIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetDataSetIndex);
			return cb_getDataSetIndex;
		}

		static int n_GetDataSetIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Highlight.Highlight __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DataSetIndex;
		}
#pragma warning restore 0169

		public virtual unsafe int DataSetIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='Highlight']/method[@name='getDataSetIndex' and count(parameter)=0]"
			[Register ("getDataSetIndex", "()I", "GetGetDataSetIndexHandler")]
			get {
				const string __id = "getDataSetIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getDrawX;
#pragma warning disable 0169
		static Delegate GetGetDrawXHandler ()
		{
			if (cb_getDrawX == null)
				cb_getDrawX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetDrawX);
			return cb_getDrawX;
		}

		static float n_GetDrawX (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Highlight.Highlight __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DrawX;
		}
#pragma warning restore 0169

		public virtual unsafe float DrawX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='Highlight']/method[@name='getDrawX' and count(parameter)=0]"
			[Register ("getDrawX", "()F", "GetGetDrawXHandler")]
			get {
				const string __id = "getDrawX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getDrawY;
#pragma warning disable 0169
		static Delegate GetGetDrawYHandler ()
		{
			if (cb_getDrawY == null)
				cb_getDrawY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetDrawY);
			return cb_getDrawY;
		}

		static float n_GetDrawY (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Highlight.Highlight __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DrawY;
		}
#pragma warning restore 0169

		public virtual unsafe float DrawY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='Highlight']/method[@name='getDrawY' and count(parameter)=0]"
			[Register ("getDrawY", "()F", "GetGetDrawYHandler")]
			get {
				const string __id = "getDrawY.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isStacked;
#pragma warning disable 0169
		static Delegate GetIsStackedHandler ()
		{
			if (cb_isStacked == null)
				cb_isStacked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStacked);
			return cb_isStacked;
		}

		static bool n_IsStacked (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Highlight.Highlight __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStacked;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsStacked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='Highlight']/method[@name='isStacked' and count(parameter)=0]"
			[Register ("isStacked", "()Z", "GetIsStackedHandler")]
			get {
				const string __id = "isStacked.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getStackIndex;
#pragma warning disable 0169
		static Delegate GetGetStackIndexHandler ()
		{
			if (cb_getStackIndex == null)
				cb_getStackIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetStackIndex);
			return cb_getStackIndex;
		}

		static int n_GetStackIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Highlight.Highlight __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StackIndex;
		}
#pragma warning restore 0169

		public virtual unsafe int StackIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='Highlight']/method[@name='getStackIndex' and count(parameter)=0]"
			[Register ("getStackIndex", "()I", "GetGetStackIndexHandler")]
			get {
				const string __id = "getStackIndex.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getXPx;
#pragma warning disable 0169
		static Delegate GetGetXPxHandler ()
		{
			if (cb_getXPx == null)
				cb_getXPx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetXPx);
			return cb_getXPx;
		}

		static float n_GetXPx (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Highlight.Highlight __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XPx;
		}
#pragma warning restore 0169

		public virtual unsafe float XPx {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='Highlight']/method[@name='getXPx' and count(parameter)=0]"
			[Register ("getXPx", "()F", "GetGetXPxHandler")]
			get {
				const string __id = "getXPx.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getYPx;
#pragma warning disable 0169
		static Delegate GetGetYPxHandler ()
		{
			if (cb_getYPx == null)
				cb_getYPx = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetYPx);
			return cb_getYPx;
		}

		static float n_GetYPx (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Highlight.Highlight __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YPx;
		}
#pragma warning restore 0169

		public virtual unsafe float YPx {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='Highlight']/method[@name='getYPx' and count(parameter)=0]"
			[Register ("getYPx", "()F", "GetGetYPxHandler")]
			get {
				const string __id = "getYPx.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_equalTo_Lcom_github_mikephil_charting_highlight_Highlight_;
#pragma warning disable 0169
		static Delegate GetEqualTo_Lcom_github_mikephil_charting_highlight_Highlight_Handler ()
		{
			if (cb_equalTo_Lcom_github_mikephil_charting_highlight_Highlight_ == null)
				cb_equalTo_Lcom_github_mikephil_charting_highlight_Highlight_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_EqualTo_Lcom_github_mikephil_charting_highlight_Highlight_);
			return cb_equalTo_Lcom_github_mikephil_charting_highlight_Highlight_;
		}

		static bool n_EqualTo_Lcom_github_mikephil_charting_highlight_Highlight_ (IntPtr jnienv, IntPtr native__this, IntPtr native_h)
		{
			global::MikePhil.Charting.Highlight.Highlight __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Highlight.Highlight h = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (native_h, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.EqualTo (h);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='Highlight']/method[@name='equalTo' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.highlight.Highlight']]"
		[Register ("equalTo", "(Lcom/github/mikephil/charting/highlight/Highlight;)Z", "GetEqualTo_Lcom_github_mikephil_charting_highlight_Highlight_Handler")]
		public virtual unsafe bool EqualTo (global::MikePhil.Charting.Highlight.Highlight h)
		{
			const string __id = "equalTo.(Lcom/github/mikephil/charting/highlight/Highlight;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((h == null) ? IntPtr.Zero : ((global::Java.Lang.Object) h).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
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
			global::MikePhil.Charting.Highlight.Highlight __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetX ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='Highlight']/method[@name='getX' and count(parameter)=0]"
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
			global::MikePhil.Charting.Highlight.Highlight __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetY ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='Highlight']/method[@name='getY' and count(parameter)=0]"
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

		static Delegate cb_setDraw_FF;
#pragma warning disable 0169
		static Delegate GetSetDraw_FFHandler ()
		{
			if (cb_setDraw_FF == null)
				cb_setDraw_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_SetDraw_FF);
			return cb_setDraw_FF;
		}

		static void n_SetDraw_FF (IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			global::MikePhil.Charting.Highlight.Highlight __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDraw (x, y);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='Highlight']/method[@name='setDraw' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setDraw", "(FF)V", "GetSetDraw_FFHandler")]
		public virtual unsafe void SetDraw (float x, float y)
		{
			const string __id = "setDraw.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
