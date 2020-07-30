using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Highlight {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='ChartHighlighter']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/highlight/ChartHighlighter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.github.mikephil.charting.interfaces.dataprovider.BarLineScatterCandleBubbleDataProvider"})]
	public partial class ChartHighlighter : global::Java.Lang.Object, global::MikePhil.Charting.Highlight.IHighlighter {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='ChartHighlighter']/field[@name='mChart']"
		[Register ("mChart")]
		protected global::MikePhil.Charting.Interfaces.Dataprovider.IBarLineScatterCandleBubbleDataProvider MChart {
			get {
				const string __id = "mChart.Lcom/github/mikephil/charting/interfaces/dataprovider/BarLineScatterCandleBubbleDataProvider;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.IBarLineScatterCandleBubbleDataProvider> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mChart.Lcom/github/mikephil/charting/interfaces/dataprovider/BarLineScatterCandleBubbleDataProvider;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='ChartHighlighter']/field[@name='mHighlightBuffer']"
		[Register ("mHighlightBuffer")]
		protected global::System.Collections.IList MHighlightBuffer {
			get {
				const string __id = "mHighlightBuffer.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mHighlightBuffer.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/highlight/ChartHighlighter", typeof (ChartHighlighter));
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

		protected ChartHighlighter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='ChartHighlighter']/constructor[@name='ChartHighlighter' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/interfaces/dataprovider/BarLineScatterCandleBubbleDataProvider;)V", "")]
		public unsafe ChartHighlighter (global::Java.Lang.Object chart)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/interfaces/dataprovider/BarLineScatterCandleBubbleDataProvider;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_chart = JNIEnv.ToLocalJniHandle (chart);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_chart);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_chart);
			}
		}

		static Delegate cb_getData;
#pragma warning disable 0169
		static Delegate GetGetDataHandler ()
		{
			if (cb_getData == null)
				cb_getData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetData);
			return cb_getData;
		}

		static IntPtr n_GetData (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Highlight.ChartHighlighter __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.ChartHighlighter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		protected virtual unsafe global::MikePhil.Charting.Data.BarLineScatterCandleBubbleData Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='ChartHighlighter']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Lcom/github/mikephil/charting/data/BarLineScatterCandleBubbleData;", "GetGetDataHandler")]
			get {
				const string __id = "getData.()Lcom/github/mikephil/charting/data/BarLineScatterCandleBubbleData;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarLineScatterCandleBubbleData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_buildHighlights_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_IFLcom_github_mikephil_charting_data_DataSet_Rounding_;
#pragma warning disable 0169
		static Delegate GetBuildHighlights_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_IFLcom_github_mikephil_charting_data_DataSet_Rounding_Handler ()
		{
			if (cb_buildHighlights_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_IFLcom_github_mikephil_charting_data_DataSet_Rounding_ == null)
				cb_buildHighlights_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_IFLcom_github_mikephil_charting_data_DataSet_Rounding_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, float, IntPtr, IntPtr>) n_BuildHighlights_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_IFLcom_github_mikephil_charting_data_DataSet_Rounding_);
			return cb_buildHighlights_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_IFLcom_github_mikephil_charting_data_DataSet_Rounding_;
		}

		static IntPtr n_BuildHighlights_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_IFLcom_github_mikephil_charting_data_DataSet_Rounding_ (IntPtr jnienv, IntPtr native__this, IntPtr native_set, int dataSetIndex, float xVal, IntPtr native_rounding)
		{
			global::MikePhil.Charting.Highlight.ChartHighlighter __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.ChartHighlighter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet set = (global::MikePhil.Charting.Interfaces.Datasets.IDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (native_set, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.DataSet.Rounding rounding = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet.Rounding> (native_rounding, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::MikePhil.Charting.Highlight.Highlight>.ToLocalJniHandle (__this.BuildHighlights (set, dataSetIndex, xVal, rounding));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='ChartHighlighter']/method[@name='buildHighlights' and count(parameter)=4 and parameter[1][@type='com.github.mikephil.charting.interfaces.datasets.IDataSet'] and parameter[2][@type='int'] and parameter[3][@type='float'] and parameter[4][@type='com.github.mikephil.charting.data.DataSet.Rounding']]"
		[Register ("buildHighlights", "(Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;IFLcom/github/mikephil/charting/data/DataSet$Rounding;)Ljava/util/List;", "GetBuildHighlights_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_IFLcom_github_mikephil_charting_data_DataSet_Rounding_Handler")]
		protected virtual unsafe global::System.Collections.Generic.IList<global::MikePhil.Charting.Highlight.Highlight> BuildHighlights (global::MikePhil.Charting.Interfaces.Datasets.IDataSet set, int dataSetIndex, float xVal, global::MikePhil.Charting.Data.DataSet.Rounding rounding)
		{
			const string __id = "buildHighlights.(Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;IFLcom/github/mikephil/charting/data/DataSet$Rounding;)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((set == null) ? IntPtr.Zero : ((global::Java.Lang.Object) set).Handle);
				__args [1] = new JniArgumentValue (dataSetIndex);
				__args [2] = new JniArgumentValue (xVal);
				__args [3] = new JniArgumentValue ((rounding == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rounding).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::MikePhil.Charting.Highlight.Highlight>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getClosestHighlightByPixel_Ljava_util_List_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_F;
#pragma warning disable 0169
		static Delegate GetGetClosestHighlightByPixel_Ljava_util_List_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_FHandler ()
		{
			if (cb_getClosestHighlightByPixel_Ljava_util_List_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_F == null)
				cb_getClosestHighlightByPixel_Ljava_util_List_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, float, IntPtr, float, IntPtr>) n_GetClosestHighlightByPixel_Ljava_util_List_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_F);
			return cb_getClosestHighlightByPixel_Ljava_util_List_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_F;
		}

		static IntPtr n_GetClosestHighlightByPixel_Ljava_util_List_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_F (IntPtr jnienv, IntPtr native__this, IntPtr native_closestValues, float x, float y, IntPtr native_axis, float minSelectionDistance)
		{
			global::MikePhil.Charting.Highlight.ChartHighlighter __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.ChartHighlighter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var closestValues = global::Android.Runtime.JavaList<global::MikePhil.Charting.Highlight.Highlight>.FromJniHandle (native_closestValues, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency axis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_axis, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetClosestHighlightByPixel (closestValues, x, y, axis, minSelectionDistance));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='ChartHighlighter']/method[@name='getClosestHighlightByPixel' and count(parameter)=5 and parameter[1][@type='java.util.List&lt;com.github.mikephil.charting.highlight.Highlight&gt;'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='com.github.mikephil.charting.components.YAxis.AxisDependency'] and parameter[5][@type='float']]"
		[Register ("getClosestHighlightByPixel", "(Ljava/util/List;FFLcom/github/mikephil/charting/components/YAxis$AxisDependency;F)Lcom/github/mikephil/charting/highlight/Highlight;", "GetGetClosestHighlightByPixel_Ljava_util_List_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_FHandler")]
		public virtual unsafe global::MikePhil.Charting.Highlight.Highlight GetClosestHighlightByPixel (global::System.Collections.Generic.IList<global::MikePhil.Charting.Highlight.Highlight> closestValues, float x, float y, global::MikePhil.Charting.Components.YAxis.AxisDependency axis, float minSelectionDistance)
		{
			const string __id = "getClosestHighlightByPixel.(Ljava/util/List;FFLcom/github/mikephil/charting/components/YAxis$AxisDependency;F)Lcom/github/mikephil/charting/highlight/Highlight;";
			IntPtr native_closestValues = global::Android.Runtime.JavaList<global::MikePhil.Charting.Highlight.Highlight>.ToLocalJniHandle (closestValues);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_closestValues);
				__args [1] = new JniArgumentValue (x);
				__args [2] = new JniArgumentValue (y);
				__args [3] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				__args [4] = new JniArgumentValue (minSelectionDistance);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_closestValues);
			}
		}

		static Delegate cb_getDistance_FFFF;
#pragma warning disable 0169
		static Delegate GetGetDistance_FFFFHandler ()
		{
			if (cb_getDistance_FFFF == null)
				cb_getDistance_FFFF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, float, float, float>) n_GetDistance_FFFF);
			return cb_getDistance_FFFF;
		}

		static float n_GetDistance_FFFF (IntPtr jnienv, IntPtr native__this, float x1, float y1, float x2, float y2)
		{
			global::MikePhil.Charting.Highlight.ChartHighlighter __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.ChartHighlighter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetDistance (x1, y1, x2, y2);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='ChartHighlighter']/method[@name='getDistance' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("getDistance", "(FFFF)F", "GetGetDistance_FFFFHandler")]
		protected virtual unsafe float GetDistance (float x1, float y1, float x2, float y2)
		{
			const string __id = "getDistance.(FFFF)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (x1);
				__args [1] = new JniArgumentValue (y1);
				__args [2] = new JniArgumentValue (x2);
				__args [3] = new JniArgumentValue (y2);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getHighlight_FF;
#pragma warning disable 0169
		static Delegate GetGetHighlight_FFHandler ()
		{
			if (cb_getHighlight_FF == null)
				cb_getHighlight_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_GetHighlight_FF);
			return cb_getHighlight_FF;
		}

		static IntPtr n_GetHighlight_FF (IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			global::MikePhil.Charting.Highlight.ChartHighlighter __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.ChartHighlighter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetHighlight (x, y));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='ChartHighlighter']/method[@name='getHighlight' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("getHighlight", "(FF)Lcom/github/mikephil/charting/highlight/Highlight;", "GetGetHighlight_FFHandler")]
		public virtual unsafe global::MikePhil.Charting.Highlight.Highlight GetHighlight (float x, float y)
		{
			const string __id = "getHighlight.(FF)Lcom/github/mikephil/charting/highlight/Highlight;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getHighlightForX_FFF;
#pragma warning disable 0169
		static Delegate GetGetHighlightForX_FFFHandler ()
		{
			if (cb_getHighlightForX_FFF == null)
				cb_getHighlightForX_FFF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, float, IntPtr>) n_GetHighlightForX_FFF);
			return cb_getHighlightForX_FFF;
		}

		static IntPtr n_GetHighlightForX_FFF (IntPtr jnienv, IntPtr native__this, float xVal, float x, float y)
		{
			global::MikePhil.Charting.Highlight.ChartHighlighter __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.ChartHighlighter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetHighlightForX (xVal, x, y));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='ChartHighlighter']/method[@name='getHighlightForX' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("getHighlightForX", "(FFF)Lcom/github/mikephil/charting/highlight/Highlight;", "GetGetHighlightForX_FFFHandler")]
		protected virtual unsafe global::MikePhil.Charting.Highlight.Highlight GetHighlightForX (float xVal, float x, float y)
		{
			const string __id = "getHighlightForX.(FFF)Lcom/github/mikephil/charting/highlight/Highlight;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (xVal);
				__args [1] = new JniArgumentValue (x);
				__args [2] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getHighlightPos_Lcom_github_mikephil_charting_highlight_Highlight_;
#pragma warning disable 0169
		static Delegate GetGetHighlightPos_Lcom_github_mikephil_charting_highlight_Highlight_Handler ()
		{
			if (cb_getHighlightPos_Lcom_github_mikephil_charting_highlight_Highlight_ == null)
				cb_getHighlightPos_Lcom_github_mikephil_charting_highlight_Highlight_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float>) n_GetHighlightPos_Lcom_github_mikephil_charting_highlight_Highlight_);
			return cb_getHighlightPos_Lcom_github_mikephil_charting_highlight_Highlight_;
		}

		static float n_GetHighlightPos_Lcom_github_mikephil_charting_highlight_Highlight_ (IntPtr jnienv, IntPtr native__this, IntPtr native_h)
		{
			global::MikePhil.Charting.Highlight.ChartHighlighter __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.ChartHighlighter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Highlight.Highlight h = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (native_h, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetHighlightPos (h);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='ChartHighlighter']/method[@name='getHighlightPos' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.highlight.Highlight']]"
		[Register ("getHighlightPos", "(Lcom/github/mikephil/charting/highlight/Highlight;)F", "GetGetHighlightPos_Lcom_github_mikephil_charting_highlight_Highlight_Handler")]
		protected virtual unsafe float GetHighlightPos (global::MikePhil.Charting.Highlight.Highlight h)
		{
			const string __id = "getHighlightPos.(Lcom/github/mikephil/charting/highlight/Highlight;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((h == null) ? IntPtr.Zero : ((global::Java.Lang.Object) h).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getHighlightsAtXValue_FFF;
#pragma warning disable 0169
		static Delegate GetGetHighlightsAtXValue_FFFHandler ()
		{
			if (cb_getHighlightsAtXValue_FFF == null)
				cb_getHighlightsAtXValue_FFF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, float, IntPtr>) n_GetHighlightsAtXValue_FFF);
			return cb_getHighlightsAtXValue_FFF;
		}

		static IntPtr n_GetHighlightsAtXValue_FFF (IntPtr jnienv, IntPtr native__this, float xVal, float x, float y)
		{
			global::MikePhil.Charting.Highlight.ChartHighlighter __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.ChartHighlighter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::MikePhil.Charting.Highlight.Highlight>.ToLocalJniHandle (__this.GetHighlightsAtXValue (xVal, x, y));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='ChartHighlighter']/method[@name='getHighlightsAtXValue' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("getHighlightsAtXValue", "(FFF)Ljava/util/List;", "GetGetHighlightsAtXValue_FFFHandler")]
		protected virtual unsafe global::System.Collections.Generic.IList<global::MikePhil.Charting.Highlight.Highlight> GetHighlightsAtXValue (float xVal, float x, float y)
		{
			const string __id = "getHighlightsAtXValue.(FFF)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (xVal);
				__args [1] = new JniArgumentValue (x);
				__args [2] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::MikePhil.Charting.Highlight.Highlight>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getMinimumDistance_Ljava_util_List_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_;
#pragma warning disable 0169
		static Delegate GetGetMinimumDistance_Ljava_util_List_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler ()
		{
			if (cb_getMinimumDistance_Ljava_util_List_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_ == null)
				cb_getMinimumDistance_Ljava_util_List_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, IntPtr, float>) n_GetMinimumDistance_Ljava_util_List_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_getMinimumDistance_Ljava_util_List_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static float n_GetMinimumDistance_Ljava_util_List_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, IntPtr native_closestValues, float pos, IntPtr native_axis)
		{
			global::MikePhil.Charting.Highlight.ChartHighlighter __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.ChartHighlighter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var closestValues = global::Android.Runtime.JavaList<global::MikePhil.Charting.Highlight.Highlight>.FromJniHandle (native_closestValues, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency axis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_axis, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetMinimumDistance (closestValues, pos, axis);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='ChartHighlighter']/method[@name='getMinimumDistance' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;com.github.mikephil.charting.highlight.Highlight&gt;'] and parameter[2][@type='float'] and parameter[3][@type='com.github.mikephil.charting.components.YAxis.AxisDependency']]"
		[Register ("getMinimumDistance", "(Ljava/util/List;FLcom/github/mikephil/charting/components/YAxis$AxisDependency;)F", "GetGetMinimumDistance_Ljava_util_List_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler")]
		protected virtual unsafe float GetMinimumDistance (global::System.Collections.Generic.IList<global::MikePhil.Charting.Highlight.Highlight> closestValues, float pos, global::MikePhil.Charting.Components.YAxis.AxisDependency axis)
		{
			const string __id = "getMinimumDistance.(Ljava/util/List;FLcom/github/mikephil/charting/components/YAxis$AxisDependency;)F";
			IntPtr native_closestValues = global::Android.Runtime.JavaList<global::MikePhil.Charting.Highlight.Highlight>.ToLocalJniHandle (closestValues);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_closestValues);
				__args [1] = new JniArgumentValue (pos);
				__args [2] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_closestValues);
			}
		}

		static Delegate cb_getValsForTouch_FF;
#pragma warning disable 0169
		static Delegate GetGetValsForTouch_FFHandler ()
		{
			if (cb_getValsForTouch_FF == null)
				cb_getValsForTouch_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_GetValsForTouch_FF);
			return cb_getValsForTouch_FF;
		}

		static IntPtr n_GetValsForTouch_FF (IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			global::MikePhil.Charting.Highlight.ChartHighlighter __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.ChartHighlighter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetValsForTouch (x, y));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='ChartHighlighter']/method[@name='getValsForTouch' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("getValsForTouch", "(FF)Lcom/github/mikephil/charting/utils/MPPointD;", "GetGetValsForTouch_FFHandler")]
		protected virtual unsafe global::MikePhil.Charting.Util.MPPointD GetValsForTouch (float x, float y)
		{
			const string __id = "getValsForTouch.(FF)Lcom/github/mikephil/charting/utils/MPPointD;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointD> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
