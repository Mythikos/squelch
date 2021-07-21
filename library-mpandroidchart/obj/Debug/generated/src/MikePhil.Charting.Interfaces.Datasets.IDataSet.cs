using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Interfaces.Datasets {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']"
	[Register ("com/github/mikephil/charting/interfaces/datasets/IDataSet", "", "MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.github.mikephil.charting.data.Entry"})]
	public partial interface IDataSet : IJavaObject {

		global::MikePhil.Charting.Components.YAxis.AxisDependency AxisDependency {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getAxisDependency' and count(parameter)=0]"
			[Register ("getAxisDependency", "()Lcom/github/mikephil/charting/components/YAxis$AxisDependency;", "GetGetAxisDependencyHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='setAxisDependency' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.YAxis.AxisDependency']]"
			[Register ("setAxisDependency", "(Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)V", "GetSetAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] set;
		}

		int Color {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getColor' and count(parameter)=0]"
			[Register ("getColor", "()I", "GetGetColorHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] get;
		}

		global::System.Collections.Generic.IList<global::Java.Lang.Integer> Colors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getColors' and count(parameter)=0]"
			[Register ("getColors", "()Ljava/util/List;", "GetGetColorsHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] get;
		}

		int EntryCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getEntryCount' and count(parameter)=0]"
			[Register ("getEntryCount", "()I", "GetGetEntryCountHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] get;
		}

		global::MikePhil.Charting.Components.Legend.LegendForm Form {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getForm' and count(parameter)=0]"
			[Register ("getForm", "()Lcom/github/mikephil/charting/components/Legend$LegendForm;", "GetGetFormHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] get;
		}

		global::Android.Graphics.DashPathEffect FormLineDashEffect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getFormLineDashEffect' and count(parameter)=0]"
			[Register ("getFormLineDashEffect", "()Landroid/graphics/DashPathEffect;", "GetGetFormLineDashEffectHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] get;
		}

		float FormLineWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getFormLineWidth' and count(parameter)=0]"
			[Register ("getFormLineWidth", "()F", "GetGetFormLineWidthHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] get;
		}

		float FormSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getFormSize' and count(parameter)=0]"
			[Register ("getFormSize", "()F", "GetGetFormSizeHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] get;
		}

		global::MikePhil.Charting.Model.GradientColor GradientColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getGradientColor' and count(parameter)=0]"
			[Register ("getGradientColor", "()Lcom/github/mikephil/charting/model/GradientColor;", "GetGetGradientColorHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] get;
		}

		global::System.Collections.Generic.IList<global::MikePhil.Charting.Model.GradientColor> GradientColors {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getGradientColors' and count(parameter)=0]"
			[Register ("getGradientColors", "()Ljava/util/List;", "GetGetGradientColorsHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] get;
		}

		bool HighlightEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='isHighlightEnabled' and count(parameter)=0]"
			[Register ("isHighlightEnabled", "()Z", "GetIsHighlightEnabledHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='setHighlightEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHighlightEnabled", "(Z)V", "GetSetHighlightEnabled_ZHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] set;
		}

		global::MikePhil.Charting.Util.MPPointF IconsOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getIconsOffset' and count(parameter)=0]"
			[Register ("getIconsOffset", "()Lcom/github/mikephil/charting/utils/MPPointF;", "GetGetIconsOffsetHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='setIconsOffset' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.utils.MPPointF']]"
			[Register ("setIconsOffset", "(Lcom/github/mikephil/charting/utils/MPPointF;)V", "GetSetIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_Handler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] set;
		}

		bool IsDrawIconsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='isDrawIconsEnabled' and count(parameter)=0]"
			[Register ("isDrawIconsEnabled", "()Z", "GetIsDrawIconsEnabledHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] get;
		}

		bool IsDrawValuesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='isDrawValuesEnabled' and count(parameter)=0]"
			[Register ("isDrawValuesEnabled", "()Z", "GetIsDrawValuesEnabledHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] get;
		}

		string Label {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getLabel' and count(parameter)=0]"
			[Register ("getLabel", "()Ljava/lang/String;", "GetGetLabelHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='setLabel' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setLabel", "(Ljava/lang/String;)V", "GetSetLabel_Ljava_lang_String_Handler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] set;
		}

		global::MikePhil.Charting.Formatter.IValueFormatter ValueFormatter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getValueFormatter' and count(parameter)=0]"
			[Register ("getValueFormatter", "()Lcom/github/mikephil/charting/formatter/IValueFormatter;", "GetGetValueFormatterHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='setValueFormatter' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.formatter.IValueFormatter']]"
			[Register ("setValueFormatter", "(Lcom/github/mikephil/charting/formatter/IValueFormatter;)V", "GetSetValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_Handler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] set;
		}

		int ValueTextColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getValueTextColor' and count(parameter)=0]"
			[Register ("getValueTextColor", "()I", "GetGetValueTextColorHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='setValueTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setValueTextColor", "(I)V", "GetSetValueTextColor_IHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] set;
		}

		float ValueTextSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getValueTextSize' and count(parameter)=0]"
			[Register ("getValueTextSize", "()F", "GetGetValueTextSizeHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='setValueTextSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setValueTextSize", "(F)V", "GetSetValueTextSize_FHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] set;
		}

		global::Android.Graphics.Typeface ValueTypeface {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getValueTypeface' and count(parameter)=0]"
			[Register ("getValueTypeface", "()Landroid/graphics/Typeface;", "GetGetValueTypefaceHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='setValueTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
			[Register ("setValueTypeface", "(Landroid/graphics/Typeface;)V", "GetSetValueTypeface_Landroid_graphics_Typeface_Handler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] set;
		}

		bool Visible {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='isVisible' and count(parameter)=0]"
			[Register ("isVisible", "()Z", "GetIsVisibleHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] get;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='setVisible' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setVisible", "(Z)V", "GetSetVisible_ZHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] set;
		}

		float XMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getXMax' and count(parameter)=0]"
			[Register ("getXMax", "()F", "GetGetXMaxHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] get;
		}

		float XMin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getXMin' and count(parameter)=0]"
			[Register ("getXMin", "()F", "GetGetXMinHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] get;
		}

		float YMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getYMax' and count(parameter)=0]"
			[Register ("getYMax", "()F", "GetGetYMaxHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] get;
		}

		float YMin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getYMin' and count(parameter)=0]"
			[Register ("getYMin", "()F", "GetGetYMinHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='calcMinMax' and count(parameter)=0]"
		[Register ("calcMinMax", "()V", "GetCalcMinMaxHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")]
		void CalcMinMax ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='calcMinMaxY' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("calcMinMaxY", "(FF)V", "GetCalcMinMaxY_FFHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")]
		void CalcMinMaxY (float p0, float p1);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")]
		void Clear ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("contains", "(Lcom/github/mikephil/charting/data/Entry;)Z", "GetContains_Lcom_github_mikephil_charting_data_Entry_Handler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")]
		bool Contains (global::Java.Lang.Object p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getColor", "(I)I", "GetGetColor_IHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")]
		int GetColor (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getEntriesForXValue' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getEntriesForXValue", "(F)Ljava/util/List;", "GetGetEntriesForXValue_FHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")]
		global::System.Collections.IList GetEntriesForXValue (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getEntryIndex' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='com.github.mikephil.charting.data.DataSet.Rounding']]"
		[Register ("getEntryIndex", "(FFLcom/github/mikephil/charting/data/DataSet$Rounding;)I", "GetGetEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_Handler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")]
		int GetEntryIndex (float p0, float p1, global::MikePhil.Charting.Data.DataSet.Rounding p2);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getGradientColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getGradientColor", "(I)Lcom/github/mikephil/charting/model/GradientColor;", "GetGetGradientColor_IHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")]
		global::MikePhil.Charting.Model.GradientColor GetGradientColor (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getIndexInEntries' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getIndexInEntries", "(I)I", "GetGetIndexInEntries_IHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")]
		int GetIndexInEntries (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='getValueTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getValueTextColor", "(I)I", "GetGetValueTextColor_IHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")]
		int GetValueTextColor (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='needsFormatter' and count(parameter)=0]"
		[Register ("needsFormatter", "()Z", "GetNeedsFormatterHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")]
		bool NeedsFormatter ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='removeEntry' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeEntry", "(I)Z", "GetRemoveEntry_IHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")]
		bool RemoveEntry (int p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='removeEntryByXValue' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("removeEntryByXValue", "(F)Z", "GetRemoveEntryByXValue_FHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")]
		bool RemoveEntryByXValue (float p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='removeFirst' and count(parameter)=0]"
		[Register ("removeFirst", "()Z", "GetRemoveFirstHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")]
		bool RemoveFirst ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='removeLast' and count(parameter)=0]"
		[Register ("removeLast", "()Z", "GetRemoveLastHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")]
		bool RemoveLast ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='setDrawIcons' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawIcons", "(Z)V", "GetSetDrawIcons_ZHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")]
		void SetDrawIcons (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='setDrawValues' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawValues", "(Z)V", "GetSetDrawValues_ZHandler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")]
		void SetDrawValues (bool p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.interfaces.datasets']/interface[@name='IDataSet']/method[@name='setValueTextColors' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Integer&gt;']]"
		[Register ("setValueTextColors", "(Ljava/util/List;)V", "GetSetValueTextColors_Ljava_util_List_Handler:MikePhil.Charting.Interfaces.Datasets.IDataSetInvoker, library-mpandroidchart")]
		void SetValueTextColors (global::System.Collections.Generic.IList<global::Java.Lang.Integer> p0);

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/interfaces/datasets/IDataSet", DoNotGenerateAcw=true)]
	internal class IDataSetInvoker : global::Java.Lang.Object, IDataSet {

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/github/mikephil/charting/interfaces/datasets/IDataSet", typeof (IDataSetInvoker));

		static IntPtr java_class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IDataSet GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IDataSet> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.github.mikephil.charting.interfaces.datasets.IDataSet"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IDataSetInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getAxisDependency;
#pragma warning disable 0169
		static Delegate GetGetAxisDependencyHandler ()
		{
			if (cb_getAxisDependency == null)
				cb_getAxisDependency = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAxisDependency);
			return cb_getAxisDependency;
		}

		static IntPtr n_GetAxisDependency (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AxisDependency);
		}
#pragma warning restore 0169

		static Delegate cb_setAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
#pragma warning disable 0169
		static Delegate GetSetAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler ()
		{
			if (cb_setAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ == null)
				cb_setAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_setAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static void n_SetAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency p0 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AxisDependency = p0;
		}
#pragma warning restore 0169

		IntPtr id_getAxisDependency;
		IntPtr id_setAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		public unsafe global::MikePhil.Charting.Components.YAxis.AxisDependency AxisDependency {
			get {
				if (id_getAxisDependency == IntPtr.Zero)
					id_getAxisDependency = JNIEnv.GetMethodID (class_ref, "getAxisDependency", "()Lcom/github/mikephil/charting/components/YAxis$AxisDependency;");
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAxisDependency), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ == IntPtr.Zero)
					id_setAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNIEnv.GetMethodID (class_ref, "setAxisDependency", "(Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAxisDependency_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_, __args);
			}
		}

		static Delegate cb_getColor;
#pragma warning disable 0169
		static Delegate GetGetColorHandler ()
		{
			if (cb_getColor == null)
				cb_getColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetColor);
			return cb_getColor;
		}

		static int n_GetColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Color;
		}
#pragma warning restore 0169

		IntPtr id_getColor;
		public unsafe int Color {
			get {
				if (id_getColor == IntPtr.Zero)
					id_getColor = JNIEnv.GetMethodID (class_ref, "getColor", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColor);
			}
		}

		static Delegate cb_getColors;
#pragma warning disable 0169
		static Delegate GetGetColorsHandler ()
		{
			if (cb_getColors == null)
				cb_getColors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetColors);
			return cb_getColors;
		}

		static IntPtr n_GetColors (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (__this.Colors);
		}
#pragma warning restore 0169

		IntPtr id_getColors;
		public unsafe global::System.Collections.Generic.IList<global::Java.Lang.Integer> Colors {
			get {
				if (id_getColors == IntPtr.Zero)
					id_getColors = JNIEnv.GetMethodID (class_ref, "getColors", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getColors), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getEntryCount;
#pragma warning disable 0169
		static Delegate GetGetEntryCountHandler ()
		{
			if (cb_getEntryCount == null)
				cb_getEntryCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEntryCount);
			return cb_getEntryCount;
		}

		static int n_GetEntryCount (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EntryCount;
		}
#pragma warning restore 0169

		IntPtr id_getEntryCount;
		public unsafe int EntryCount {
			get {
				if (id_getEntryCount == IntPtr.Zero)
					id_getEntryCount = JNIEnv.GetMethodID (class_ref, "getEntryCount", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEntryCount);
			}
		}

		static Delegate cb_getForm;
#pragma warning disable 0169
		static Delegate GetGetFormHandler ()
		{
			if (cb_getForm == null)
				cb_getForm = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetForm);
			return cb_getForm;
		}

		static IntPtr n_GetForm (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Form);
		}
#pragma warning restore 0169

		IntPtr id_getForm;
		public unsafe global::MikePhil.Charting.Components.Legend.LegendForm Form {
			get {
				if (id_getForm == IntPtr.Zero)
					id_getForm = JNIEnv.GetMethodID (class_ref, "getForm", "()Lcom/github/mikephil/charting/components/Legend$LegendForm;");
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendForm> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getForm), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getFormLineDashEffect;
#pragma warning disable 0169
		static Delegate GetGetFormLineDashEffectHandler ()
		{
			if (cb_getFormLineDashEffect == null)
				cb_getFormLineDashEffect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormLineDashEffect);
			return cb_getFormLineDashEffect;
		}

		static IntPtr n_GetFormLineDashEffect (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FormLineDashEffect);
		}
#pragma warning restore 0169

		IntPtr id_getFormLineDashEffect;
		public unsafe global::Android.Graphics.DashPathEffect FormLineDashEffect {
			get {
				if (id_getFormLineDashEffect == IntPtr.Zero)
					id_getFormLineDashEffect = JNIEnv.GetMethodID (class_ref, "getFormLineDashEffect", "()Landroid/graphics/DashPathEffect;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.DashPathEffect> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFormLineDashEffect), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getFormLineWidth;
#pragma warning disable 0169
		static Delegate GetGetFormLineWidthHandler ()
		{
			if (cb_getFormLineWidth == null)
				cb_getFormLineWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetFormLineWidth);
			return cb_getFormLineWidth;
		}

		static float n_GetFormLineWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FormLineWidth;
		}
#pragma warning restore 0169

		IntPtr id_getFormLineWidth;
		public unsafe float FormLineWidth {
			get {
				if (id_getFormLineWidth == IntPtr.Zero)
					id_getFormLineWidth = JNIEnv.GetMethodID (class_ref, "getFormLineWidth", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getFormLineWidth);
			}
		}

		static Delegate cb_getFormSize;
#pragma warning disable 0169
		static Delegate GetGetFormSizeHandler ()
		{
			if (cb_getFormSize == null)
				cb_getFormSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetFormSize);
			return cb_getFormSize;
		}

		static float n_GetFormSize (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FormSize;
		}
#pragma warning restore 0169

		IntPtr id_getFormSize;
		public unsafe float FormSize {
			get {
				if (id_getFormSize == IntPtr.Zero)
					id_getFormSize = JNIEnv.GetMethodID (class_ref, "getFormSize", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getFormSize);
			}
		}

		static Delegate cb_getGradientColor;
#pragma warning disable 0169
		static Delegate GetGetGradientColorHandler ()
		{
			if (cb_getGradientColor == null)
				cb_getGradientColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGradientColor);
			return cb_getGradientColor;
		}

		static IntPtr n_GetGradientColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GradientColor);
		}
#pragma warning restore 0169

		IntPtr id_getGradientColor;
		public unsafe global::MikePhil.Charting.Model.GradientColor GradientColor {
			get {
				if (id_getGradientColor == IntPtr.Zero)
					id_getGradientColor = JNIEnv.GetMethodID (class_ref, "getGradientColor", "()Lcom/github/mikephil/charting/model/GradientColor;");
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Model.GradientColor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGradientColor), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getGradientColors;
#pragma warning disable 0169
		static Delegate GetGetGradientColorsHandler ()
		{
			if (cb_getGradientColors == null)
				cb_getGradientColors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetGradientColors);
			return cb_getGradientColors;
		}

		static IntPtr n_GetGradientColors (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::MikePhil.Charting.Model.GradientColor>.ToLocalJniHandle (__this.GradientColors);
		}
#pragma warning restore 0169

		IntPtr id_getGradientColors;
		public unsafe global::System.Collections.Generic.IList<global::MikePhil.Charting.Model.GradientColor> GradientColors {
			get {
				if (id_getGradientColors == IntPtr.Zero)
					id_getGradientColors = JNIEnv.GetMethodID (class_ref, "getGradientColors", "()Ljava/util/List;");
				return global::Android.Runtime.JavaList<global::MikePhil.Charting.Model.GradientColor>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGradientColors), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isHighlightEnabled;
#pragma warning disable 0169
		static Delegate GetIsHighlightEnabledHandler ()
		{
			if (cb_isHighlightEnabled == null)
				cb_isHighlightEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHighlightEnabled);
			return cb_isHighlightEnabled;
		}

		static bool n_IsHighlightEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighlightEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setHighlightEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetHighlightEnabled_ZHandler ()
		{
			if (cb_setHighlightEnabled_Z == null)
				cb_setHighlightEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHighlightEnabled_Z);
			return cb_setHighlightEnabled_Z;
		}

		static void n_SetHighlightEnabled_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighlightEnabled = p0;
		}
#pragma warning restore 0169

		IntPtr id_isHighlightEnabled;
		IntPtr id_setHighlightEnabled_Z;
		public unsafe bool HighlightEnabled {
			get {
				if (id_isHighlightEnabled == IntPtr.Zero)
					id_isHighlightEnabled = JNIEnv.GetMethodID (class_ref, "isHighlightEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHighlightEnabled);
			}
			set {
				if (id_setHighlightEnabled_Z == IntPtr.Zero)
					id_setHighlightEnabled_Z = JNIEnv.GetMethodID (class_ref, "setHighlightEnabled", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setHighlightEnabled_Z, __args);
			}
		}

		static Delegate cb_getIconsOffset;
#pragma warning disable 0169
		static Delegate GetGetIconsOffsetHandler ()
		{
			if (cb_getIconsOffset == null)
				cb_getIconsOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIconsOffset);
			return cb_getIconsOffset;
		}

		static IntPtr n_GetIconsOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.IconsOffset);
		}
#pragma warning restore 0169

		static Delegate cb_setIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_;
#pragma warning disable 0169
		static Delegate GetSetIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_Handler ()
		{
			if (cb_setIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_ == null)
				cb_setIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_);
			return cb_setIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_;
		}

		static void n_SetIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Util.MPPointF p0 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.IconsOffset = p0;
		}
#pragma warning restore 0169

		IntPtr id_getIconsOffset;
		IntPtr id_setIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_;
		public unsafe global::MikePhil.Charting.Util.MPPointF IconsOffset {
			get {
				if (id_getIconsOffset == IntPtr.Zero)
					id_getIconsOffset = JNIEnv.GetMethodID (class_ref, "getIconsOffset", "()Lcom/github/mikephil/charting/utils/MPPointF;");
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIconsOffset), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_ == IntPtr.Zero)
					id_setIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_ = JNIEnv.GetMethodID (class_ref, "setIconsOffset", "(Lcom/github/mikephil/charting/utils/MPPointF;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setIconsOffset_Lcom_github_mikephil_charting_utils_MPPointF_, __args);
			}
		}

		static Delegate cb_isDrawIconsEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawIconsEnabledHandler ()
		{
			if (cb_isDrawIconsEnabled == null)
				cb_isDrawIconsEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawIconsEnabled);
			return cb_isDrawIconsEnabled;
		}

		static bool n_IsDrawIconsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawIconsEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isDrawIconsEnabled;
		public unsafe bool IsDrawIconsEnabled {
			get {
				if (id_isDrawIconsEnabled == IntPtr.Zero)
					id_isDrawIconsEnabled = JNIEnv.GetMethodID (class_ref, "isDrawIconsEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDrawIconsEnabled);
			}
		}

		static Delegate cb_isDrawValuesEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawValuesEnabledHandler ()
		{
			if (cb_isDrawValuesEnabled == null)
				cb_isDrawValuesEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawValuesEnabled);
			return cb_isDrawValuesEnabled;
		}

		static bool n_IsDrawValuesEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawValuesEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isDrawValuesEnabled;
		public unsafe bool IsDrawValuesEnabled {
			get {
				if (id_isDrawValuesEnabled == IntPtr.Zero)
					id_isDrawValuesEnabled = JNIEnv.GetMethodID (class_ref, "isDrawValuesEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isDrawValuesEnabled);
			}
		}

		static Delegate cb_getLabel;
#pragma warning disable 0169
		static Delegate GetGetLabelHandler ()
		{
			if (cb_getLabel == null)
				cb_getLabel = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLabel);
			return cb_getLabel;
		}

		static IntPtr n_GetLabel (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Label);
		}
#pragma warning restore 0169

		static Delegate cb_setLabel_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetLabel_Ljava_lang_String_Handler ()
		{
			if (cb_setLabel_Ljava_lang_String_ == null)
				cb_setLabel_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLabel_Ljava_lang_String_);
			return cb_setLabel_Ljava_lang_String_;
		}

		static void n_SetLabel_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Label = p0;
		}
#pragma warning restore 0169

		IntPtr id_getLabel;
		IntPtr id_setLabel_Ljava_lang_String_;
		public unsafe string Label {
			get {
				if (id_getLabel == IntPtr.Zero)
					id_getLabel = JNIEnv.GetMethodID (class_ref, "getLabel", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLabel), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setLabel_Ljava_lang_String_ == IntPtr.Zero)
					id_setLabel_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setLabel", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setLabel_Ljava_lang_String_, __args);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static Delegate cb_getValueFormatter;
#pragma warning disable 0169
		static Delegate GetGetValueFormatterHandler ()
		{
			if (cb_getValueFormatter == null)
				cb_getValueFormatter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValueFormatter);
			return cb_getValueFormatter;
		}

		static IntPtr n_GetValueFormatter (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ValueFormatter);
		}
#pragma warning restore 0169

		static Delegate cb_setValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_;
#pragma warning disable 0169
		static Delegate GetSetValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_Handler ()
		{
			if (cb_setValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_ == null)
				cb_setValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_);
			return cb_setValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_;
		}

		static void n_SetValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Formatter.IValueFormatter p0 = (global::MikePhil.Charting.Formatter.IValueFormatter)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IValueFormatter> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ValueFormatter = p0;
		}
#pragma warning restore 0169

		IntPtr id_getValueFormatter;
		IntPtr id_setValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_;
		public unsafe global::MikePhil.Charting.Formatter.IValueFormatter ValueFormatter {
			get {
				if (id_getValueFormatter == IntPtr.Zero)
					id_getValueFormatter = JNIEnv.GetMethodID (class_ref, "getValueFormatter", "()Lcom/github/mikephil/charting/formatter/IValueFormatter;");
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IValueFormatter> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValueFormatter), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_ == IntPtr.Zero)
					id_setValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_ = JNIEnv.GetMethodID (class_ref, "setValueFormatter", "(Lcom/github/mikephil/charting/formatter/IValueFormatter;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_, __args);
			}
		}

		static Delegate cb_getValueTextColor;
#pragma warning disable 0169
		static Delegate GetGetValueTextColorHandler ()
		{
			if (cb_getValueTextColor == null)
				cb_getValueTextColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetValueTextColor);
			return cb_getValueTextColor;
		}

		static int n_GetValueTextColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ValueTextColor;
		}
#pragma warning restore 0169

		static Delegate cb_setValueTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetValueTextColor_IHandler ()
		{
			if (cb_setValueTextColor_I == null)
				cb_setValueTextColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetValueTextColor_I);
			return cb_setValueTextColor_I;
		}

		static void n_SetValueTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ValueTextColor = p0;
		}
#pragma warning restore 0169

		IntPtr id_getValueTextColor;
		IntPtr id_setValueTextColor_I;
		public unsafe int ValueTextColor {
			get {
				if (id_getValueTextColor == IntPtr.Zero)
					id_getValueTextColor = JNIEnv.GetMethodID (class_ref, "getValueTextColor", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getValueTextColor);
			}
			set {
				if (id_setValueTextColor_I == IntPtr.Zero)
					id_setValueTextColor_I = JNIEnv.GetMethodID (class_ref, "setValueTextColor", "(I)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValueTextColor_I, __args);
			}
		}

		static Delegate cb_getValueTextSize;
#pragma warning disable 0169
		static Delegate GetGetValueTextSizeHandler ()
		{
			if (cb_getValueTextSize == null)
				cb_getValueTextSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetValueTextSize);
			return cb_getValueTextSize;
		}

		static float n_GetValueTextSize (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ValueTextSize;
		}
#pragma warning restore 0169

		static Delegate cb_setValueTextSize_F;
#pragma warning disable 0169
		static Delegate GetSetValueTextSize_FHandler ()
		{
			if (cb_setValueTextSize_F == null)
				cb_setValueTextSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetValueTextSize_F);
			return cb_setValueTextSize_F;
		}

		static void n_SetValueTextSize_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ValueTextSize = p0;
		}
#pragma warning restore 0169

		IntPtr id_getValueTextSize;
		IntPtr id_setValueTextSize_F;
		public unsafe float ValueTextSize {
			get {
				if (id_getValueTextSize == IntPtr.Zero)
					id_getValueTextSize = JNIEnv.GetMethodID (class_ref, "getValueTextSize", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getValueTextSize);
			}
			set {
				if (id_setValueTextSize_F == IntPtr.Zero)
					id_setValueTextSize_F = JNIEnv.GetMethodID (class_ref, "setValueTextSize", "(F)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValueTextSize_F, __args);
			}
		}

		static Delegate cb_getValueTypeface;
#pragma warning disable 0169
		static Delegate GetGetValueTypefaceHandler ()
		{
			if (cb_getValueTypeface == null)
				cb_getValueTypeface = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValueTypeface);
			return cb_getValueTypeface;
		}

		static IntPtr n_GetValueTypeface (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ValueTypeface);
		}
#pragma warning restore 0169

		static Delegate cb_setValueTypeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetSetValueTypeface_Landroid_graphics_Typeface_Handler ()
		{
			if (cb_setValueTypeface_Landroid_graphics_Typeface_ == null)
				cb_setValueTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValueTypeface_Landroid_graphics_Typeface_);
			return cb_setValueTypeface_Landroid_graphics_Typeface_;
		}

		static void n_SetValueTypeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Typeface p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ValueTypeface = p0;
		}
#pragma warning restore 0169

		IntPtr id_getValueTypeface;
		IntPtr id_setValueTypeface_Landroid_graphics_Typeface_;
		public unsafe global::Android.Graphics.Typeface ValueTypeface {
			get {
				if (id_getValueTypeface == IntPtr.Zero)
					id_getValueTypeface = JNIEnv.GetMethodID (class_ref, "getValueTypeface", "()Landroid/graphics/Typeface;");
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getValueTypeface), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (id_setValueTypeface_Landroid_graphics_Typeface_ == IntPtr.Zero)
					id_setValueTypeface_Landroid_graphics_Typeface_ = JNIEnv.GetMethodID (class_ref, "setValueTypeface", "(Landroid/graphics/Typeface;)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValueTypeface_Landroid_graphics_Typeface_, __args);
			}
		}

		static Delegate cb_isVisible;
#pragma warning disable 0169
		static Delegate GetIsVisibleHandler ()
		{
			if (cb_isVisible == null)
				cb_isVisible = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsVisible);
			return cb_isVisible;
		}

		static bool n_IsVisible (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Visible;
		}
#pragma warning restore 0169

		static Delegate cb_setVisible_Z;
#pragma warning disable 0169
		static Delegate GetSetVisible_ZHandler ()
		{
			if (cb_setVisible_Z == null)
				cb_setVisible_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetVisible_Z);
			return cb_setVisible_Z;
		}

		static void n_SetVisible_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Visible = p0;
		}
#pragma warning restore 0169

		IntPtr id_isVisible;
		IntPtr id_setVisible_Z;
		public unsafe bool Visible {
			get {
				if (id_isVisible == IntPtr.Zero)
					id_isVisible = JNIEnv.GetMethodID (class_ref, "isVisible", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isVisible);
			}
			set {
				if (id_setVisible_Z == IntPtr.Zero)
					id_setVisible_Z = JNIEnv.GetMethodID (class_ref, "setVisible", "(Z)V");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (value);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setVisible_Z, __args);
			}
		}

		static Delegate cb_getXMax;
#pragma warning disable 0169
		static Delegate GetGetXMaxHandler ()
		{
			if (cb_getXMax == null)
				cb_getXMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetXMax);
			return cb_getXMax;
		}

		static float n_GetXMax (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XMax;
		}
#pragma warning restore 0169

		IntPtr id_getXMax;
		public unsafe float XMax {
			get {
				if (id_getXMax == IntPtr.Zero)
					id_getXMax = JNIEnv.GetMethodID (class_ref, "getXMax", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getXMax);
			}
		}

		static Delegate cb_getXMin;
#pragma warning disable 0169
		static Delegate GetGetXMinHandler ()
		{
			if (cb_getXMin == null)
				cb_getXMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetXMin);
			return cb_getXMin;
		}

		static float n_GetXMin (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XMin;
		}
#pragma warning restore 0169

		IntPtr id_getXMin;
		public unsafe float XMin {
			get {
				if (id_getXMin == IntPtr.Zero)
					id_getXMin = JNIEnv.GetMethodID (class_ref, "getXMin", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getXMin);
			}
		}

		static Delegate cb_getYMax;
#pragma warning disable 0169
		static Delegate GetGetYMaxHandler ()
		{
			if (cb_getYMax == null)
				cb_getYMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetYMax);
			return cb_getYMax;
		}

		static float n_GetYMax (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YMax;
		}
#pragma warning restore 0169

		IntPtr id_getYMax;
		public unsafe float YMax {
			get {
				if (id_getYMax == IntPtr.Zero)
					id_getYMax = JNIEnv.GetMethodID (class_ref, "getYMax", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getYMax);
			}
		}

		static Delegate cb_getYMin;
#pragma warning disable 0169
		static Delegate GetGetYMinHandler ()
		{
			if (cb_getYMin == null)
				cb_getYMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetYMin);
			return cb_getYMin;
		}

		static float n_GetYMin (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YMin;
		}
#pragma warning restore 0169

		IntPtr id_getYMin;
		public unsafe float YMin {
			get {
				if (id_getYMin == IntPtr.Zero)
					id_getYMin = JNIEnv.GetMethodID (class_ref, "getYMin", "()F");
				return JNIEnv.CallFloatMethod (((global::Java.Lang.Object) this).Handle, id_getYMin);
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
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalcMinMax ();
		}
#pragma warning restore 0169

		IntPtr id_calcMinMax;
		public unsafe void CalcMinMax ()
		{
			if (id_calcMinMax == IntPtr.Zero)
				id_calcMinMax = JNIEnv.GetMethodID (class_ref, "calcMinMax", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_calcMinMax);
		}

		static Delegate cb_calcMinMaxY_FF;
#pragma warning disable 0169
		static Delegate GetCalcMinMaxY_FFHandler ()
		{
			if (cb_calcMinMaxY_FF == null)
				cb_calcMinMaxY_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_CalcMinMaxY_FF);
			return cb_calcMinMaxY_FF;
		}

		static void n_CalcMinMaxY_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalcMinMaxY (p0, p1);
		}
#pragma warning restore 0169

		IntPtr id_calcMinMaxY_FF;
		public unsafe void CalcMinMaxY (float p0, float p1)
		{
			if (id_calcMinMaxY_FF == IntPtr.Zero)
				id_calcMinMaxY_FF = JNIEnv.GetMethodID (class_ref, "calcMinMaxY", "(FF)V");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_calcMinMaxY_FF, __args);
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		IntPtr id_clear;
		public unsafe void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clear);
		}

		static Delegate cb_contains_Lcom_github_mikephil_charting_data_Entry_;
#pragma warning disable 0169
		static Delegate GetContains_Lcom_github_mikephil_charting_data_Entry_Handler ()
		{
			if (cb_contains_Lcom_github_mikephil_charting_data_Entry_ == null)
				cb_contains_Lcom_github_mikephil_charting_data_Entry_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_Contains_Lcom_github_mikephil_charting_data_Entry_);
			return cb_contains_Lcom_github_mikephil_charting_data_Entry_;
		}

		static bool n_Contains_Lcom_github_mikephil_charting_data_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (p0);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_contains_Lcom_github_mikephil_charting_data_Entry_;
		public unsafe bool Contains (global::Java.Lang.Object p0)
		{
			if (id_contains_Lcom_github_mikephil_charting_data_Entry_ == IntPtr.Zero)
				id_contains_Lcom_github_mikephil_charting_data_Entry_ = JNIEnv.GetMethodID (class_ref, "contains", "(Lcom/github/mikephil/charting/data/Entry;)Z");
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_contains_Lcom_github_mikephil_charting_data_Entry_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_getColor_I;
#pragma warning disable 0169
		static Delegate GetGetColor_IHandler ()
		{
			if (cb_getColor_I == null)
				cb_getColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetColor_I);
			return cb_getColor_I;
		}

		static int n_GetColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetColor (p0);
		}
#pragma warning restore 0169

		IntPtr id_getColor_I;
		public unsafe int GetColor (int p0)
		{
			if (id_getColor_I == IntPtr.Zero)
				id_getColor_I = JNIEnv.GetMethodID (class_ref, "getColor", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getColor_I, __args);
		}

		static Delegate cb_getEntriesForXValue_F;
#pragma warning disable 0169
		static Delegate GetGetEntriesForXValue_FHandler ()
		{
			if (cb_getEntriesForXValue_F == null)
				cb_getEntriesForXValue_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_GetEntriesForXValue_F);
			return cb_getEntriesForXValue_F;
		}

		static IntPtr n_GetEntriesForXValue_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.GetEntriesForXValue (p0));
		}
#pragma warning restore 0169

		IntPtr id_getEntriesForXValue_F;
		public unsafe global::System.Collections.IList GetEntriesForXValue (float p0)
		{
			if (id_getEntriesForXValue_F == IntPtr.Zero)
				id_getEntriesForXValue_F = JNIEnv.GetMethodID (class_ref, "getEntriesForXValue", "(F)Ljava/util/List;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Android.Runtime.JavaList.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEntriesForXValue_F, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_;
#pragma warning disable 0169
		static Delegate GetGetEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_Handler ()
		{
			if (cb_getEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_ == null)
				cb_getEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr, int>) n_GetEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_);
			return cb_getEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_;
		}

		static int n_GetEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_ (IntPtr jnienv, IntPtr native__this, float p0, float p1, IntPtr native_p2)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.DataSet.Rounding p2 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet.Rounding> (native_p2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetEntryIndex (p0, p1, p2);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_;
		public unsafe int GetEntryIndex (float p0, float p1, global::MikePhil.Charting.Data.DataSet.Rounding p2)
		{
			if (id_getEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_ == IntPtr.Zero)
				id_getEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_ = JNIEnv.GetMethodID (class_ref, "getEntryIndex", "(FFLcom/github/mikephil/charting/data/DataSet$Rounding;)I");
			JValue* __args = stackalloc JValue [3];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue ((p2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p2).Handle);
			int __ret = JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_, __args);
			return __ret;
		}

		static Delegate cb_getGradientColor_I;
#pragma warning disable 0169
		static Delegate GetGetGradientColor_IHandler ()
		{
			if (cb_getGradientColor_I == null)
				cb_getGradientColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetGradientColor_I);
			return cb_getGradientColor_I;
		}

		static IntPtr n_GetGradientColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetGradientColor (p0));
		}
#pragma warning restore 0169

		IntPtr id_getGradientColor_I;
		public unsafe global::MikePhil.Charting.Model.GradientColor GetGradientColor (int p0)
		{
			if (id_getGradientColor_I == IntPtr.Zero)
				id_getGradientColor_I = JNIEnv.GetMethodID (class_ref, "getGradientColor", "(I)Lcom/github/mikephil/charting/model/GradientColor;");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Model.GradientColor> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGradientColor_I, __args), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_getIndexInEntries_I;
#pragma warning disable 0169
		static Delegate GetGetIndexInEntries_IHandler ()
		{
			if (cb_getIndexInEntries_I == null)
				cb_getIndexInEntries_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetIndexInEntries_I);
			return cb_getIndexInEntries_I;
		}

		static int n_GetIndexInEntries_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetIndexInEntries (p0);
		}
#pragma warning restore 0169

		IntPtr id_getIndexInEntries_I;
		public unsafe int GetIndexInEntries (int p0)
		{
			if (id_getIndexInEntries_I == IntPtr.Zero)
				id_getIndexInEntries_I = JNIEnv.GetMethodID (class_ref, "getIndexInEntries", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getIndexInEntries_I, __args);
		}

		static Delegate cb_getValueTextColor_I;
#pragma warning disable 0169
		static Delegate GetGetValueTextColor_IHandler ()
		{
			if (cb_getValueTextColor_I == null)
				cb_getValueTextColor_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetValueTextColor_I);
			return cb_getValueTextColor_I;
		}

		static int n_GetValueTextColor_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetValueTextColor (p0);
		}
#pragma warning restore 0169

		IntPtr id_getValueTextColor_I;
		public unsafe int GetValueTextColor (int p0)
		{
			if (id_getValueTextColor_I == IntPtr.Zero)
				id_getValueTextColor_I = JNIEnv.GetMethodID (class_ref, "getValueTextColor", "(I)I");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getValueTextColor_I, __args);
		}

		static Delegate cb_needsFormatter;
#pragma warning disable 0169
		static Delegate GetNeedsFormatterHandler ()
		{
			if (cb_needsFormatter == null)
				cb_needsFormatter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_NeedsFormatter);
			return cb_needsFormatter;
		}

		static bool n_NeedsFormatter (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeedsFormatter ();
		}
#pragma warning restore 0169

		IntPtr id_needsFormatter;
		public unsafe bool NeedsFormatter ()
		{
			if (id_needsFormatter == IntPtr.Zero)
				id_needsFormatter = JNIEnv.GetMethodID (class_ref, "needsFormatter", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_needsFormatter);
		}

		static Delegate cb_removeEntry_I;
#pragma warning disable 0169
		static Delegate GetRemoveEntry_IHandler ()
		{
			if (cb_removeEntry_I == null)
				cb_removeEntry_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_RemoveEntry_I);
			return cb_removeEntry_I;
		}

		static bool n_RemoveEntry_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemoveEntry (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeEntry_I;
		public unsafe bool RemoveEntry (int p0)
		{
			if (id_removeEntry_I == IntPtr.Zero)
				id_removeEntry_I = JNIEnv.GetMethodID (class_ref, "removeEntry", "(I)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeEntry_I, __args);
		}

		static Delegate cb_removeEntryByXValue_F;
#pragma warning disable 0169
		static Delegate GetRemoveEntryByXValue_FHandler ()
		{
			if (cb_removeEntryByXValue_F == null)
				cb_removeEntryByXValue_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, bool>) n_RemoveEntryByXValue_F);
			return cb_removeEntryByXValue_F;
		}

		static bool n_RemoveEntryByXValue_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemoveEntryByXValue (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeEntryByXValue_F;
		public unsafe bool RemoveEntryByXValue (float p0)
		{
			if (id_removeEntryByXValue_F == IntPtr.Zero)
				id_removeEntryByXValue_F = JNIEnv.GetMethodID (class_ref, "removeEntryByXValue", "(F)Z");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeEntryByXValue_F, __args);
		}

		static Delegate cb_removeFirst;
#pragma warning disable 0169
		static Delegate GetRemoveFirstHandler ()
		{
			if (cb_removeFirst == null)
				cb_removeFirst = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_RemoveFirst);
			return cb_removeFirst;
		}

		static bool n_RemoveFirst (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemoveFirst ();
		}
#pragma warning restore 0169

		IntPtr id_removeFirst;
		public unsafe bool RemoveFirst ()
		{
			if (id_removeFirst == IntPtr.Zero)
				id_removeFirst = JNIEnv.GetMethodID (class_ref, "removeFirst", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeFirst);
		}

		static Delegate cb_removeLast;
#pragma warning disable 0169
		static Delegate GetRemoveLastHandler ()
		{
			if (cb_removeLast == null)
				cb_removeLast = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_RemoveLast);
			return cb_removeLast;
		}

		static bool n_RemoveLast (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemoveLast ();
		}
#pragma warning restore 0169

		IntPtr id_removeLast;
		public unsafe bool RemoveLast ()
		{
			if (id_removeLast == IntPtr.Zero)
				id_removeLast = JNIEnv.GetMethodID (class_ref, "removeLast", "()Z");
			return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_removeLast);
		}

		static Delegate cb_setDrawIcons_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawIcons_ZHandler ()
		{
			if (cb_setDrawIcons_Z == null)
				cb_setDrawIcons_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawIcons_Z);
			return cb_setDrawIcons_Z;
		}

		static void n_SetDrawIcons_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawIcons (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDrawIcons_Z;
		public unsafe void SetDrawIcons (bool p0)
		{
			if (id_setDrawIcons_Z == IntPtr.Zero)
				id_setDrawIcons_Z = JNIEnv.GetMethodID (class_ref, "setDrawIcons", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDrawIcons_Z, __args);
		}

		static Delegate cb_setDrawValues_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawValues_ZHandler ()
		{
			if (cb_setDrawValues_Z == null)
				cb_setDrawValues_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawValues_Z);
			return cb_setDrawValues_Z;
		}

		static void n_SetDrawValues_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawValues (p0);
		}
#pragma warning restore 0169

		IntPtr id_setDrawValues_Z;
		public unsafe void SetDrawValues (bool p0)
		{
			if (id_setDrawValues_Z == IntPtr.Zero)
				id_setDrawValues_Z = JNIEnv.GetMethodID (class_ref, "setDrawValues", "(Z)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setDrawValues_Z, __args);
		}

		static Delegate cb_setValueTextColors_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetValueTextColors_Ljava_util_List_Handler ()
		{
			if (cb_setValueTextColors_Ljava_util_List_ == null)
				cb_setValueTextColors_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValueTextColors_Ljava_util_List_);
			return cb_setValueTextColors_Ljava_util_List_;
		}

		static void n_SetValueTextColors_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var p0 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetValueTextColors (p0);
		}
#pragma warning restore 0169

		IntPtr id_setValueTextColors_Ljava_util_List_;
		public unsafe void SetValueTextColors (global::System.Collections.Generic.IList<global::Java.Lang.Integer> p0)
		{
			if (id_setValueTextColors_Ljava_util_List_ == IntPtr.Zero)
				id_setValueTextColors_Ljava_util_List_ = JNIEnv.GetMethodID (class_ref, "setValueTextColors", "(Ljava/util/List;)V");
			IntPtr native_p0 = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (p0);
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (native_p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setValueTextColors_Ljava_util_List_, __args);
			JNIEnv.DeleteLocalRef (native_p0);
		}

	}

}
