using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CombinedData']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/CombinedData", DoNotGenerateAcw=true)]
	public partial class CombinedData : global::MikePhil.Charting.Data.BarLineScatterCandleBubbleData {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/CombinedData", typeof (CombinedData));
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

		protected CombinedData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CombinedData']/constructor[@name='CombinedData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CombinedData ()
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

		static Delegate cb_getAllData;
#pragma warning disable 0169
		static Delegate GetGetAllDataHandler ()
		{
			if (cb_getAllData == null)
				cb_getAllData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAllData);
			return cb_getAllData;
		}

		static IntPtr n_GetAllData (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.CombinedData __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CombinedData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::MikePhil.Charting.Data.BarLineScatterCandleBubbleData>.ToLocalJniHandle (__this.AllData);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::MikePhil.Charting.Data.BarLineScatterCandleBubbleData> AllData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CombinedData']/method[@name='getAllData' and count(parameter)=0]"
			[Register ("getAllData", "()Ljava/util/List;", "GetGetAllDataHandler")]
			get {
				const string __id = "getAllData.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::MikePhil.Charting.Data.BarLineScatterCandleBubbleData>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBarData;
#pragma warning disable 0169
		static Delegate GetGetBarDataHandler ()
		{
			if (cb_getBarData == null)
				cb_getBarData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBarData);
			return cb_getBarData;
		}

		static IntPtr n_GetBarData (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.CombinedData __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CombinedData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BarData);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Data.BarData BarData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CombinedData']/method[@name='getBarData' and count(parameter)=0]"
			[Register ("getBarData", "()Lcom/github/mikephil/charting/data/BarData;", "GetGetBarDataHandler")]
			get {
				const string __id = "getBarData.()Lcom/github/mikephil/charting/data/BarData;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBubbleData;
#pragma warning disable 0169
		static Delegate GetGetBubbleDataHandler ()
		{
			if (cb_getBubbleData == null)
				cb_getBubbleData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBubbleData);
			return cb_getBubbleData;
		}

		static IntPtr n_GetBubbleData (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.CombinedData __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CombinedData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BubbleData);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Data.BubbleData BubbleData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CombinedData']/method[@name='getBubbleData' and count(parameter)=0]"
			[Register ("getBubbleData", "()Lcom/github/mikephil/charting/data/BubbleData;", "GetGetBubbleDataHandler")]
			get {
				const string __id = "getBubbleData.()Lcom/github/mikephil/charting/data/BubbleData;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BubbleData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCandleData;
#pragma warning disable 0169
		static Delegate GetGetCandleDataHandler ()
		{
			if (cb_getCandleData == null)
				cb_getCandleData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCandleData);
			return cb_getCandleData;
		}

		static IntPtr n_GetCandleData (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.CombinedData __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CombinedData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CandleData);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Data.CandleData CandleData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CombinedData']/method[@name='getCandleData' and count(parameter)=0]"
			[Register ("getCandleData", "()Lcom/github/mikephil/charting/data/CandleData;", "GetGetCandleDataHandler")]
			get {
				const string __id = "getCandleData.()Lcom/github/mikephil/charting/data/CandleData;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLineData;
#pragma warning disable 0169
		static Delegate GetGetLineDataHandler ()
		{
			if (cb_getLineData == null)
				cb_getLineData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLineData);
			return cb_getLineData;
		}

		static IntPtr n_GetLineData (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.CombinedData __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CombinedData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LineData);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Data.LineData LineData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CombinedData']/method[@name='getLineData' and count(parameter)=0]"
			[Register ("getLineData", "()Lcom/github/mikephil/charting/data/LineData;", "GetGetLineDataHandler")]
			get {
				const string __id = "getLineData.()Lcom/github/mikephil/charting/data/LineData;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getScatterData;
#pragma warning disable 0169
		static Delegate GetGetScatterDataHandler ()
		{
			if (cb_getScatterData == null)
				cb_getScatterData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScatterData);
			return cb_getScatterData;
		}

		static IntPtr n_GetScatterData (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.CombinedData __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CombinedData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScatterData);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Data.ScatterData ScatterData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CombinedData']/method[@name='getScatterData' and count(parameter)=0]"
			[Register ("getScatterData", "()Lcom/github/mikephil/charting/data/ScatterData;", "GetGetScatterDataHandler")]
			get {
				const string __id = "getScatterData.()Lcom/github/mikephil/charting/data/ScatterData;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ScatterData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_calcMinMax;
#pragma warning disable 0169
		static Delegate GetCalcMinMaxHandler ()
		{
			if (cb_calcMinMax == null)
				cb_calcMinMax = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CalcMinMax);
			return cb_calcMinMax;
		}

		static void n_CalcMinMax (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.CombinedData __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CombinedData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalcMinMax ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CombinedData']/method[@name='calcMinMax' and count(parameter)=0]"
		[Register ("calcMinMax", "()V", "GetCalcMinMaxHandler")]
		public virtual unsafe void CalcMinMax ()
		{
			const string __id = "calcMinMax.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getDataByIndex_I;
#pragma warning disable 0169
		static Delegate GetGetDataByIndex_IHandler ()
		{
			if (cb_getDataByIndex_I == null)
				cb_getDataByIndex_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetDataByIndex_I);
			return cb_getDataByIndex_I;
		}

		static IntPtr n_GetDataByIndex_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::MikePhil.Charting.Data.CombinedData __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CombinedData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetDataByIndex (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CombinedData']/method[@name='getDataByIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDataByIndex", "(I)Lcom/github/mikephil/charting/data/BarLineScatterCandleBubbleData;", "GetGetDataByIndex_IHandler")]
		public virtual unsafe global::MikePhil.Charting.Data.BarLineScatterCandleBubbleData GetDataByIndex (int index)
		{
			const string __id = "getDataByIndex.(I)Lcom/github/mikephil/charting/data/BarLineScatterCandleBubbleData;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarLineScatterCandleBubbleData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getDataIndex_Lcom_github_mikephil_charting_data_ChartData_;
#pragma warning disable 0169
		static Delegate GetGetDataIndex_Lcom_github_mikephil_charting_data_ChartData_Handler ()
		{
			if (cb_getDataIndex_Lcom_github_mikephil_charting_data_ChartData_ == null)
				cb_getDataIndex_Lcom_github_mikephil_charting_data_ChartData_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetDataIndex_Lcom_github_mikephil_charting_data_ChartData_);
			return cb_getDataIndex_Lcom_github_mikephil_charting_data_ChartData_;
		}

		static int n_GetDataIndex_Lcom_github_mikephil_charting_data_ChartData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::MikePhil.Charting.Data.CombinedData __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CombinedData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.ChartData data = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (native_data, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetDataIndex (data);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CombinedData']/method[@name='getDataIndex' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.ChartData']]"
		[Register ("getDataIndex", "(Lcom/github/mikephil/charting/data/ChartData;)I", "GetGetDataIndex_Lcom_github_mikephil_charting_data_ChartData_Handler")]
		public virtual unsafe int GetDataIndex (global::MikePhil.Charting.Data.ChartData data)
		{
			const string __id = "getDataIndex.(Lcom/github/mikephil/charting/data/ChartData;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getDataSetByHighlight_Lcom_github_mikephil_charting_highlight_Highlight_;
#pragma warning disable 0169
		static Delegate GetGetDataSetByHighlight_Lcom_github_mikephil_charting_highlight_Highlight_Handler ()
		{
			if (cb_getDataSetByHighlight_Lcom_github_mikephil_charting_highlight_Highlight_ == null)
				cb_getDataSetByHighlight_Lcom_github_mikephil_charting_highlight_Highlight_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDataSetByHighlight_Lcom_github_mikephil_charting_highlight_Highlight_);
			return cb_getDataSetByHighlight_Lcom_github_mikephil_charting_highlight_Highlight_;
		}

		static IntPtr n_GetDataSetByHighlight_Lcom_github_mikephil_charting_highlight_Highlight_ (IntPtr jnienv, IntPtr native__this, IntPtr native_highlight)
		{
			global::MikePhil.Charting.Data.CombinedData __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CombinedData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Highlight.Highlight highlight = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (native_highlight, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDataSetByHighlight (highlight));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CombinedData']/method[@name='getDataSetByHighlight' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.highlight.Highlight']]"
		[Register ("getDataSetByHighlight", "(Lcom/github/mikephil/charting/highlight/Highlight;)Lcom/github/mikephil/charting/interfaces/datasets/IBarLineScatterCandleBubbleDataSet;", "GetGetDataSetByHighlight_Lcom_github_mikephil_charting_highlight_Highlight_Handler")]
		public virtual unsafe global::MikePhil.Charting.Interfaces.Datasets.IBarLineScatterCandleBubbleDataSet GetDataSetByHighlight (global::MikePhil.Charting.Highlight.Highlight highlight)
		{
			const string __id = "getDataSetByHighlight.(Lcom/github/mikephil/charting/highlight/Highlight;)Lcom/github/mikephil/charting/interfaces/datasets/IBarLineScatterCandleBubbleDataSet;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((highlight == null) ? IntPtr.Zero : ((global::Java.Lang.Object) highlight).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IBarLineScatterCandleBubbleDataSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_removeDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IBarLineScatterCandleBubbleDataSet_;
#pragma warning disable 0169
		static Delegate GetRemoveDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IBarLineScatterCandleBubbleDataSet_Handler ()
		{
			if (cb_removeDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IBarLineScatterCandleBubbleDataSet_ == null)
				cb_removeDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IBarLineScatterCandleBubbleDataSet_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IBarLineScatterCandleBubbleDataSet_);
			return cb_removeDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IBarLineScatterCandleBubbleDataSet_;
		}

		static bool n_RemoveDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IBarLineScatterCandleBubbleDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_d)
		{
			global::MikePhil.Charting.Data.CombinedData __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CombinedData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Interfaces.Datasets.IBarLineScatterCandleBubbleDataSet d = (global::MikePhil.Charting.Interfaces.Datasets.IBarLineScatterCandleBubbleDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IBarLineScatterCandleBubbleDataSet> (native_d, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveDataSet (d);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CombinedData']/method[@name='removeDataSet' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.interfaces.datasets.IBarLineScatterCandleBubbleDataSet&lt;? extends com.github.mikephil.charting.data.Entry&gt;']]"
		[Register ("removeDataSet", "(Lcom/github/mikephil/charting/interfaces/datasets/IBarLineScatterCandleBubbleDataSet;)Z", "GetRemoveDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IBarLineScatterCandleBubbleDataSet_Handler")]
		public virtual unsafe bool RemoveDataSet (global::MikePhil.Charting.Interfaces.Datasets.IBarLineScatterCandleBubbleDataSet d)
		{
			const string __id = "removeDataSet.(Lcom/github/mikephil/charting/interfaces/datasets/IBarLineScatterCandleBubbleDataSet;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((d == null) ? IntPtr.Zero : ((global::Java.Lang.Object) d).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setData_Lcom_github_mikephil_charting_data_BarData_;
#pragma warning disable 0169
		static Delegate GetSetData_Lcom_github_mikephil_charting_data_BarData_Handler ()
		{
			if (cb_setData_Lcom_github_mikephil_charting_data_BarData_ == null)
				cb_setData_Lcom_github_mikephil_charting_data_BarData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Lcom_github_mikephil_charting_data_BarData_);
			return cb_setData_Lcom_github_mikephil_charting_data_BarData_;
		}

		static void n_SetData_Lcom_github_mikephil_charting_data_BarData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::MikePhil.Charting.Data.CombinedData __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CombinedData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.BarData data = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarData> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.SetData (data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CombinedData']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.BarData']]"
		[Register ("setData", "(Lcom/github/mikephil/charting/data/BarData;)V", "GetSetData_Lcom_github_mikephil_charting_data_BarData_Handler")]
		public virtual unsafe void SetData (global::MikePhil.Charting.Data.BarData data)
		{
			const string __id = "setData.(Lcom/github/mikephil/charting/data/BarData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setData_Lcom_github_mikephil_charting_data_BubbleData_;
#pragma warning disable 0169
		static Delegate GetSetData_Lcom_github_mikephil_charting_data_BubbleData_Handler ()
		{
			if (cb_setData_Lcom_github_mikephil_charting_data_BubbleData_ == null)
				cb_setData_Lcom_github_mikephil_charting_data_BubbleData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Lcom_github_mikephil_charting_data_BubbleData_);
			return cb_setData_Lcom_github_mikephil_charting_data_BubbleData_;
		}

		static void n_SetData_Lcom_github_mikephil_charting_data_BubbleData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::MikePhil.Charting.Data.CombinedData __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CombinedData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.BubbleData data = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BubbleData> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.SetData (data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CombinedData']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.BubbleData']]"
		[Register ("setData", "(Lcom/github/mikephil/charting/data/BubbleData;)V", "GetSetData_Lcom_github_mikephil_charting_data_BubbleData_Handler")]
		public virtual unsafe void SetData (global::MikePhil.Charting.Data.BubbleData data)
		{
			const string __id = "setData.(Lcom/github/mikephil/charting/data/BubbleData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setData_Lcom_github_mikephil_charting_data_CandleData_;
#pragma warning disable 0169
		static Delegate GetSetData_Lcom_github_mikephil_charting_data_CandleData_Handler ()
		{
			if (cb_setData_Lcom_github_mikephil_charting_data_CandleData_ == null)
				cb_setData_Lcom_github_mikephil_charting_data_CandleData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Lcom_github_mikephil_charting_data_CandleData_);
			return cb_setData_Lcom_github_mikephil_charting_data_CandleData_;
		}

		static void n_SetData_Lcom_github_mikephil_charting_data_CandleData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::MikePhil.Charting.Data.CombinedData __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CombinedData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.CandleData data = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleData> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.SetData (data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CombinedData']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.CandleData']]"
		[Register ("setData", "(Lcom/github/mikephil/charting/data/CandleData;)V", "GetSetData_Lcom_github_mikephil_charting_data_CandleData_Handler")]
		public virtual unsafe void SetData (global::MikePhil.Charting.Data.CandleData data)
		{
			const string __id = "setData.(Lcom/github/mikephil/charting/data/CandleData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setData_Lcom_github_mikephil_charting_data_LineData_;
#pragma warning disable 0169
		static Delegate GetSetData_Lcom_github_mikephil_charting_data_LineData_Handler ()
		{
			if (cb_setData_Lcom_github_mikephil_charting_data_LineData_ == null)
				cb_setData_Lcom_github_mikephil_charting_data_LineData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Lcom_github_mikephil_charting_data_LineData_);
			return cb_setData_Lcom_github_mikephil_charting_data_LineData_;
		}

		static void n_SetData_Lcom_github_mikephil_charting_data_LineData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::MikePhil.Charting.Data.CombinedData __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CombinedData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.LineData data = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineData> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.SetData (data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CombinedData']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.LineData']]"
		[Register ("setData", "(Lcom/github/mikephil/charting/data/LineData;)V", "GetSetData_Lcom_github_mikephil_charting_data_LineData_Handler")]
		public virtual unsafe void SetData (global::MikePhil.Charting.Data.LineData data)
		{
			const string __id = "setData.(Lcom/github/mikephil/charting/data/LineData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setData_Lcom_github_mikephil_charting_data_ScatterData_;
#pragma warning disable 0169
		static Delegate GetSetData_Lcom_github_mikephil_charting_data_ScatterData_Handler ()
		{
			if (cb_setData_Lcom_github_mikephil_charting_data_ScatterData_ == null)
				cb_setData_Lcom_github_mikephil_charting_data_ScatterData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Lcom_github_mikephil_charting_data_ScatterData_);
			return cb_setData_Lcom_github_mikephil_charting_data_ScatterData_;
		}

		static void n_SetData_Lcom_github_mikephil_charting_data_ScatterData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::MikePhil.Charting.Data.CombinedData __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CombinedData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.ScatterData data = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ScatterData> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.SetData (data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CombinedData']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.ScatterData']]"
		[Register ("setData", "(Lcom/github/mikephil/charting/data/ScatterData;)V", "GetSetData_Lcom_github_mikephil_charting_data_ScatterData_Handler")]
		public virtual unsafe void SetData (global::MikePhil.Charting.Data.ScatterData data)
		{
			const string __id = "setData.(Lcom/github/mikephil/charting/data/ScatterData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
