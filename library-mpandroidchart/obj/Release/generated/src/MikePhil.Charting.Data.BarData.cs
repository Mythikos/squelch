using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarData']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/BarData", DoNotGenerateAcw=true)]
	public partial class BarData : global::MikePhil.Charting.Data.BarLineScatterCandleBubbleData {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/BarData", typeof (BarData));

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

		protected BarData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarData']/constructor[@name='BarData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe BarData () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarData']/constructor[@name='BarData' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.interfaces.datasets.IBarDataSet...']]"
		[Register (".ctor", "([Lcom/github/mikephil/charting/interfaces/datasets/IBarDataSet;)V", "")]
		public unsafe BarData (params global::MikePhil.Charting.Interfaces.Datasets.IBarDataSet[] dataSets) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Lcom/github/mikephil/charting/interfaces/datasets/IBarDataSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_dataSets = JNIEnv.NewArray (dataSets);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_dataSets);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (dataSets != null) {
					JNIEnv.CopyArray (native_dataSets, dataSets);
					JNIEnv.DeleteLocalRef (native_dataSets);
				}
				global::System.GC.KeepAlive (dataSets);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarData']/constructor[@name='BarData' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.github.mikephil.charting.interfaces.datasets.IBarDataSet&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe BarData (global::System.Collections.Generic.IList<global::MikePhil.Charting.Interfaces.Datasets.IBarDataSet> dataSets) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_dataSets = global::Android.Runtime.JavaList<global::MikePhil.Charting.Interfaces.Datasets.IBarDataSet>.ToLocalJniHandle (dataSets);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_dataSets);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_dataSets);
				global::System.GC.KeepAlive (dataSets);
			}
		}

		static Delegate cb_getBarWidth;
#pragma warning disable 0169
		static Delegate GetGetBarWidthHandler ()
		{
			if (cb_getBarWidth == null)
				cb_getBarWidth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetBarWidth);
			return cb_getBarWidth;
		}

		static float n_GetBarWidth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BarWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setBarWidth_F;
#pragma warning disable 0169
		static Delegate GetSetBarWidth_FHandler ()
		{
			if (cb_setBarWidth_F == null)
				cb_setBarWidth_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetBarWidth_F);
			return cb_setBarWidth_F;
		}

		static void n_SetBarWidth_F (IntPtr jnienv, IntPtr native__this, float mBarWidth)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.BarWidth = mBarWidth;
		}
#pragma warning restore 0169

		public virtual unsafe float BarWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarData']/method[@name='getBarWidth' and count(parameter)=0]"
			[Register ("getBarWidth", "()F", "GetGetBarWidthHandler")]
			get {
				const string __id = "getBarWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarData']/method[@name='setBarWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setBarWidth", "(F)V", "GetSetBarWidth_FHandler")]
			set {
				const string __id = "setBarWidth.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getGroupWidth_FF;
#pragma warning disable 0169
		static Delegate GetGetGroupWidth_FFHandler ()
		{
			if (cb_getGroupWidth_FF == null)
				cb_getGroupWidth_FF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFF_F) n_GetGroupWidth_FF);
			return cb_getGroupWidth_FF;
		}

		static float n_GetGroupWidth_FF (IntPtr jnienv, IntPtr native__this, float groupSpace, float barSpace)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetGroupWidth (groupSpace, barSpace);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarData']/method[@name='getGroupWidth' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("getGroupWidth", "(FF)F", "GetGetGroupWidth_FFHandler")]
		public virtual unsafe float GetGroupWidth (float groupSpace, float barSpace)
		{
			const string __id = "getGroupWidth.(FF)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (groupSpace);
				__args [1] = new JniArgumentValue (barSpace);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_groupBars_FFF;
#pragma warning disable 0169
		static Delegate GetGroupBars_FFFHandler ()
		{
			if (cb_groupBars_FFF == null)
				cb_groupBars_FFF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFFF_V) n_GroupBars_FFF);
			return cb_groupBars_FFF;
		}

		static void n_GroupBars_FFF (IntPtr jnienv, IntPtr native__this, float fromX, float groupSpace, float barSpace)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.GroupBars (fromX, groupSpace, barSpace);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarData']/method[@name='groupBars' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("groupBars", "(FFF)V", "GetGroupBars_FFFHandler")]
		public virtual unsafe void GroupBars (float fromX, float groupSpace, float barSpace)
		{
			const string __id = "groupBars.(FFF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (fromX);
				__args [1] = new JniArgumentValue (groupSpace);
				__args [2] = new JniArgumentValue (barSpace);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
