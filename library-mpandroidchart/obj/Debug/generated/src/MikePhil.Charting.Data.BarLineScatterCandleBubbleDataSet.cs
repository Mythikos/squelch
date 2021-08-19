using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarLineScatterCandleBubbleDataSet']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/BarLineScatterCandleBubbleDataSet", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.github.mikephil.charting.data.Entry"})]
	public abstract partial class BarLineScatterCandleBubbleDataSet : global::MikePhil.Charting.Data.DataSet, global::MikePhil.Charting.Interfaces.Datasets.IBarLineScatterCandleBubbleDataSet {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarLineScatterCandleBubbleDataSet']/field[@name='mHighLightColor']"
		[Register ("mHighLightColor")]
		protected int MHighLightColor {
			get {
				const string __id = "mHighLightColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mHighLightColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/BarLineScatterCandleBubbleDataSet", typeof (BarLineScatterCandleBubbleDataSet));

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

		protected BarLineScatterCandleBubbleDataSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarLineScatterCandleBubbleDataSet']/constructor[@name='BarLineScatterCandleBubbleDataSet' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;T&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/util/List;Ljava/lang/String;)V", "")]
		public unsafe BarLineScatterCandleBubbleDataSet (global::System.Collections.IList yVals, string label) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_yVals = global::Android.Runtime.JavaList.ToLocalJniHandle (yVals);
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_yVals);
				__args [1] = new JniArgumentValue (native_label);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_yVals);
				JNIEnv.DeleteLocalRef (native_label);
				global::System.GC.KeepAlive (yVals);
			}
		}

		static Delegate cb_getHighLightColor;
#pragma warning disable 0169
		static Delegate GetGetHighLightColorHandler ()
		{
			if (cb_getHighLightColor == null)
				cb_getHighLightColor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHighLightColor);
			return cb_getHighLightColor;
		}

		static int n_GetHighLightColor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarLineScatterCandleBubbleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighLightColor;
		}
#pragma warning restore 0169

		static Delegate cb_setHighLightColor_I;
#pragma warning disable 0169
		static Delegate GetSetHighLightColor_IHandler ()
		{
			if (cb_setHighLightColor_I == null)
				cb_setHighLightColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetHighLightColor_I);
			return cb_setHighLightColor_I;
		}

		static void n_SetHighLightColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarLineScatterCandleBubbleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighLightColor = color;
		}
#pragma warning restore 0169

		public virtual unsafe int HighLightColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarLineScatterCandleBubbleDataSet']/method[@name='getHighLightColor' and count(parameter)=0]"
			[Register ("getHighLightColor", "()I", "GetGetHighLightColorHandler")]
			get {
				const string __id = "getHighLightColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarLineScatterCandleBubbleDataSet']/method[@name='setHighLightColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setHighLightColor", "(I)V", "GetSetHighLightColor_IHandler")]
			set {
				const string __id = "setHighLightColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_copy_Lcom_github_mikephil_charting_data_BarLineScatterCandleBubbleDataSet_;
#pragma warning disable 0169
		static Delegate GetCopy_Lcom_github_mikephil_charting_data_BarLineScatterCandleBubbleDataSet_Handler ()
		{
			if (cb_copy_Lcom_github_mikephil_charting_data_BarLineScatterCandleBubbleDataSet_ == null)
				cb_copy_Lcom_github_mikephil_charting_data_BarLineScatterCandleBubbleDataSet_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Copy_Lcom_github_mikephil_charting_data_BarLineScatterCandleBubbleDataSet_);
			return cb_copy_Lcom_github_mikephil_charting_data_BarLineScatterCandleBubbleDataSet_;
		}

		static void n_Copy_Lcom_github_mikephil_charting_data_BarLineScatterCandleBubbleDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_barLineScatterCandleBubbleDataSet)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarLineScatterCandleBubbleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var barLineScatterCandleBubbleDataSet = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarLineScatterCandleBubbleDataSet> (native_barLineScatterCandleBubbleDataSet, JniHandleOwnership.DoNotTransfer);
			__this.Copy (barLineScatterCandleBubbleDataSet);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarLineScatterCandleBubbleDataSet']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.BarLineScatterCandleBubbleDataSet']]"
		[Register ("copy", "(Lcom/github/mikephil/charting/data/BarLineScatterCandleBubbleDataSet;)V", "GetCopy_Lcom_github_mikephil_charting_data_BarLineScatterCandleBubbleDataSet_Handler")]
		protected virtual unsafe void Copy (global::MikePhil.Charting.Data.BarLineScatterCandleBubbleDataSet barLineScatterCandleBubbleDataSet)
		{
			const string __id = "copy.(Lcom/github/mikephil/charting/data/BarLineScatterCandleBubbleDataSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((barLineScatterCandleBubbleDataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) barLineScatterCandleBubbleDataSet).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (barLineScatterCandleBubbleDataSet);
			}
		}

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/BarLineScatterCandleBubbleDataSet", DoNotGenerateAcw=true)]
	internal partial class BarLineScatterCandleBubbleDataSetInvoker : BarLineScatterCandleBubbleDataSet, global::MikePhil.Charting.Interfaces.Datasets.IBarLineScatterCandleBubbleDataSet, global::MikePhil.Charting.Interfaces.Datasets.IDataSet {
		public BarLineScatterCandleBubbleDataSetInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/BarLineScatterCandleBubbleDataSet", typeof (BarLineScatterCandleBubbleDataSetInvoker));

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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='copy' and count(parameter)=0]"
		[Register ("copy", "()Lcom/github/mikephil/charting/data/DataSet;", "GetCopyHandler")]
		public override unsafe global::MikePhil.Charting.Data.DataSet Copy ()
		{
			const string __id = "copy.()Lcom/github/mikephil/charting/data/DataSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
