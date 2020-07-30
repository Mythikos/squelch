using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/github/mikephil/charting/animation",
						"com/github/mikephil/charting/buffer",
						"com/github/mikephil/charting",
						"com/github/mikephil/charting/charts",
						"com/github/mikephil/charting/components",
						"com/github/mikephil/charting/data",
						"com/github/mikephil/charting/data/filter",
						"com/github/mikephil/charting/exception",
						"com/github/mikephil/charting/formatter",
						"com/github/mikephil/charting/highlight",
						"com/github/mikephil/charting/jobs",
						"com/github/mikephil/charting/listener",
						"com/github/mikephil/charting/matrix",
						"com/github/mikephil/charting/model",
						"com/github/mikephil/charting/renderer",
						"com/github/mikephil/charting/renderer/scatter",
						"com/github/mikephil/charting/utils",
					},
					new Converter<string, Type>[]{
						lookup_com_github_mikephil_charting_animation_package,
						lookup_com_github_mikephil_charting_buffer_package,
						lookup_com_github_mikephil_charting_package,
						lookup_com_github_mikephil_charting_charts_package,
						lookup_com_github_mikephil_charting_components_package,
						lookup_com_github_mikephil_charting_data_package,
						lookup_com_github_mikephil_charting_data_filter_package,
						lookup_com_github_mikephil_charting_exception_package,
						lookup_com_github_mikephil_charting_formatter_package,
						lookup_com_github_mikephil_charting_highlight_package,
						lookup_com_github_mikephil_charting_jobs_package,
						lookup_com_github_mikephil_charting_listener_package,
						lookup_com_github_mikephil_charting_matrix_package,
						lookup_com_github_mikephil_charting_model_package,
						lookup_com_github_mikephil_charting_renderer_package,
						lookup_com_github_mikephil_charting_renderer_scatter_package,
						lookup_com_github_mikephil_charting_utils_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

		static Type Lookup (string[] mappings, string javaType)
		{
			string managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_github_mikephil_charting_animation_mappings;
		static Type lookup_com_github_mikephil_charting_animation_package (string klass)
		{
			if (package_com_github_mikephil_charting_animation_mappings == null) {
				package_com_github_mikephil_charting_animation_mappings = new string[]{
					"com/github/mikephil/charting/animation/ChartAnimator:MikePhil.Charting.Animation.ChartAnimator",
					"com/github/mikephil/charting/animation/Easing:MikePhil.Charting.Animation.Easing",
					"com/github/mikephil/charting/animation/Easing$EasingOption:MikePhil.Charting.Animation.Easing/EasingOption",
				};
			}

			return Lookup (package_com_github_mikephil_charting_animation_mappings, klass);
		}

		static string[] package_com_github_mikephil_charting_buffer_mappings;
		static Type lookup_com_github_mikephil_charting_buffer_package (string klass)
		{
			if (package_com_github_mikephil_charting_buffer_mappings == null) {
				package_com_github_mikephil_charting_buffer_mappings = new string[]{
					"com/github/mikephil/charting/buffer/AbstractBuffer:MikePhil.Charting.Buffer.AbstractBuffer",
					"com/github/mikephil/charting/buffer/BarBuffer:MikePhil.Charting.Buffer.BarBuffer",
					"com/github/mikephil/charting/buffer/HorizontalBarBuffer:MikePhil.Charting.Buffer.HorizontalBarBuffer",
				};
			}

			return Lookup (package_com_github_mikephil_charting_buffer_mappings, klass);
		}

		static string[] package_com_github_mikephil_charting_mappings;
		static Type lookup_com_github_mikephil_charting_package (string klass)
		{
			if (package_com_github_mikephil_charting_mappings == null) {
				package_com_github_mikephil_charting_mappings = new string[]{
					"com/github/mikephil/charting/BuildConfig:MikePhil.Charting.BuildConfig",
				};
			}

			return Lookup (package_com_github_mikephil_charting_mappings, klass);
		}

		static string[] package_com_github_mikephil_charting_charts_mappings;
		static Type lookup_com_github_mikephil_charting_charts_package (string klass)
		{
			if (package_com_github_mikephil_charting_charts_mappings == null) {
				package_com_github_mikephil_charting_charts_mappings = new string[]{
					"com/github/mikephil/charting/charts/BarChart:MikePhil.Charting.Charts.BarChart",
					"com/github/mikephil/charting/charts/BarLineChartBase:MikePhil.Charting.Charts.BarLineChartBase",
					"com/github/mikephil/charting/charts/BubbleChart:MikePhil.Charting.Charts.BubbleChart",
					"com/github/mikephil/charting/charts/CandleStickChart:MikePhil.Charting.Charts.CandleStickChart",
					"com/github/mikephil/charting/charts/Chart:MikePhil.Charting.Charts.Chart",
					"com/github/mikephil/charting/charts/CombinedChart:MikePhil.Charting.Charts.CombinedChart",
					"com/github/mikephil/charting/charts/CombinedChart$DrawOrder:MikePhil.Charting.Charts.CombinedChart/DrawOrder",
					"com/github/mikephil/charting/charts/HorizontalBarChart:MikePhil.Charting.Charts.HorizontalBarChart",
					"com/github/mikephil/charting/charts/LineChart:MikePhil.Charting.Charts.LineChart",
					"com/github/mikephil/charting/charts/PieChart:MikePhil.Charting.Charts.PieChart",
					"com/github/mikephil/charting/charts/PieRadarChartBase:MikePhil.Charting.Charts.PieRadarChartBase",
					"com/github/mikephil/charting/charts/RadarChart:MikePhil.Charting.Charts.RadarChart",
					"com/github/mikephil/charting/charts/ScatterChart:MikePhil.Charting.Charts.ScatterChart",
					"com/github/mikephil/charting/charts/ScatterChart$ScatterShape:MikePhil.Charting.Charts.ScatterChart/ScatterShape",
				};
			}

			return Lookup (package_com_github_mikephil_charting_charts_mappings, klass);
		}

		static string[] package_com_github_mikephil_charting_components_mappings;
		static Type lookup_com_github_mikephil_charting_components_package (string klass)
		{
			if (package_com_github_mikephil_charting_components_mappings == null) {
				package_com_github_mikephil_charting_components_mappings = new string[]{
					"com/github/mikephil/charting/components/AxisBase:MikePhil.Charting.Components.AxisBase",
					"com/github/mikephil/charting/components/ComponentBase:MikePhil.Charting.Components.ComponentBase",
					"com/github/mikephil/charting/components/Description:MikePhil.Charting.Components.Description",
					"com/github/mikephil/charting/components/Legend:MikePhil.Charting.Components.Legend",
					"com/github/mikephil/charting/components/Legend$LegendDirection:MikePhil.Charting.Components.Legend/LegendDirection",
					"com/github/mikephil/charting/components/Legend$LegendForm:MikePhil.Charting.Components.Legend/LegendForm",
					"com/github/mikephil/charting/components/Legend$LegendHorizontalAlignment:MikePhil.Charting.Components.Legend/LegendHorizontalAlignment",
					"com/github/mikephil/charting/components/Legend$LegendOrientation:MikePhil.Charting.Components.Legend/LegendOrientation",
					"com/github/mikephil/charting/components/Legend$LegendPosition:MikePhil.Charting.Components.Legend/LegendPosition",
					"com/github/mikephil/charting/components/Legend$LegendVerticalAlignment:MikePhil.Charting.Components.Legend/LegendVerticalAlignment",
					"com/github/mikephil/charting/components/LegendEntry:MikePhil.Charting.Components.LegendEntry",
					"com/github/mikephil/charting/components/LimitLine:MikePhil.Charting.Components.LimitLine",
					"com/github/mikephil/charting/components/LimitLine$LimitLabelPosition:MikePhil.Charting.Components.LimitLine/LimitLabelPosition",
					"com/github/mikephil/charting/components/MarkerImage:MikePhil.Charting.Components.MarkerImage",
					"com/github/mikephil/charting/components/MarkerView:MikePhil.Charting.Components.MarkerView",
					"com/github/mikephil/charting/components/XAxis:MikePhil.Charting.Components.XAxis",
					"com/github/mikephil/charting/components/XAxis$XAxisPosition:MikePhil.Charting.Components.XAxis/XAxisPosition",
					"com/github/mikephil/charting/components/YAxis:MikePhil.Charting.Components.YAxis",
					"com/github/mikephil/charting/components/YAxis$AxisDependency:MikePhil.Charting.Components.YAxis/AxisDependency",
					"com/github/mikephil/charting/components/YAxis$YAxisLabelPosition:MikePhil.Charting.Components.YAxis/YAxisLabelPosition",
				};
			}

			return Lookup (package_com_github_mikephil_charting_components_mappings, klass);
		}

		static string[] package_com_github_mikephil_charting_data_mappings;
		static Type lookup_com_github_mikephil_charting_data_package (string klass)
		{
			if (package_com_github_mikephil_charting_data_mappings == null) {
				package_com_github_mikephil_charting_data_mappings = new string[]{
					"com/github/mikephil/charting/data/BarData:MikePhil.Charting.Data.BarData",
					"com/github/mikephil/charting/data/BarDataSet:MikePhil.Charting.Data.BarDataSet",
					"com/github/mikephil/charting/data/BarEntry:MikePhil.Charting.Data.BarEntry",
					"com/github/mikephil/charting/data/BarLineScatterCandleBubbleData:MikePhil.Charting.Data.BarLineScatterCandleBubbleData",
					"com/github/mikephil/charting/data/BarLineScatterCandleBubbleDataSet:MikePhil.Charting.Data.BarLineScatterCandleBubbleDataSet",
					"com/github/mikephil/charting/data/BaseDataSet:MikePhil.Charting.Data.BaseDataSet",
					"com/github/mikephil/charting/data/BaseEntry:MikePhil.Charting.Data.BaseEntry",
					"com/github/mikephil/charting/data/BubbleData:MikePhil.Charting.Data.BubbleData",
					"com/github/mikephil/charting/data/BubbleDataSet:MikePhil.Charting.Data.BubbleDataSet",
					"com/github/mikephil/charting/data/BubbleEntry:MikePhil.Charting.Data.BubbleEntry",
					"com/github/mikephil/charting/data/CandleData:MikePhil.Charting.Data.CandleData",
					"com/github/mikephil/charting/data/CandleDataSet:MikePhil.Charting.Data.CandleDataSet",
					"com/github/mikephil/charting/data/CandleEntry:MikePhil.Charting.Data.CandleEntry",
					"com/github/mikephil/charting/data/ChartData:MikePhil.Charting.Data.ChartData",
					"com/github/mikephil/charting/data/CombinedData:MikePhil.Charting.Data.CombinedData",
					"com/github/mikephil/charting/data/DataSet:MikePhil.Charting.Data.DataSet",
					"com/github/mikephil/charting/data/DataSet$Rounding:MikePhil.Charting.Data.DataSet/Rounding",
					"com/github/mikephil/charting/data/Entry:MikePhil.Charting.Data.Entry",
					"com/github/mikephil/charting/data/LineData:MikePhil.Charting.Data.LineData",
					"com/github/mikephil/charting/data/LineDataSet:MikePhil.Charting.Data.LineDataSet",
					"com/github/mikephil/charting/data/LineDataSet$Mode:MikePhil.Charting.Data.LineDataSet/Mode",
					"com/github/mikephil/charting/data/LineRadarDataSet:MikePhil.Charting.Data.LineRadarDataSet",
					"com/github/mikephil/charting/data/LineScatterCandleRadarDataSet:MikePhil.Charting.Data.LineScatterCandleRadarDataSet",
					"com/github/mikephil/charting/data/PieData:MikePhil.Charting.Data.PieData",
					"com/github/mikephil/charting/data/PieDataSet:MikePhil.Charting.Data.PieDataSet",
					"com/github/mikephil/charting/data/PieDataSet$ValuePosition:MikePhil.Charting.Data.PieDataSet/ValuePosition",
					"com/github/mikephil/charting/data/PieEntry:MikePhil.Charting.Data.PieEntry",
					"com/github/mikephil/charting/data/RadarData:MikePhil.Charting.Data.RadarData",
					"com/github/mikephil/charting/data/RadarDataSet:MikePhil.Charting.Data.RadarDataSet",
					"com/github/mikephil/charting/data/RadarEntry:MikePhil.Charting.Data.RadarEntry",
					"com/github/mikephil/charting/data/ScatterData:MikePhil.Charting.Data.ScatterData",
					"com/github/mikephil/charting/data/ScatterDataSet:MikePhil.Charting.Data.ScatterDataSet",
				};
			}

			return Lookup (package_com_github_mikephil_charting_data_mappings, klass);
		}

		static string[] package_com_github_mikephil_charting_data_filter_mappings;
		static Type lookup_com_github_mikephil_charting_data_filter_package (string klass)
		{
			if (package_com_github_mikephil_charting_data_filter_mappings == null) {
				package_com_github_mikephil_charting_data_filter_mappings = new string[]{
					"com/github/mikephil/charting/data/filter/Approximator:MikePhil.Charting.Data.Filter.Approximator",
				};
			}

			return Lookup (package_com_github_mikephil_charting_data_filter_mappings, klass);
		}

		static string[] package_com_github_mikephil_charting_exception_mappings;
		static Type lookup_com_github_mikephil_charting_exception_package (string klass)
		{
			if (package_com_github_mikephil_charting_exception_mappings == null) {
				package_com_github_mikephil_charting_exception_mappings = new string[]{
					"com/github/mikephil/charting/exception/DrawingDataSetNotCreatedException:MikePhil.Charting.Exception.DrawingDataSetNotCreatedException",
				};
			}

			return Lookup (package_com_github_mikephil_charting_exception_mappings, klass);
		}

		static string[] package_com_github_mikephil_charting_formatter_mappings;
		static Type lookup_com_github_mikephil_charting_formatter_package (string klass)
		{
			if (package_com_github_mikephil_charting_formatter_mappings == null) {
				package_com_github_mikephil_charting_formatter_mappings = new string[]{
					"com/github/mikephil/charting/formatter/DefaultAxisValueFormatter:MikePhil.Charting.Formatter.DefaultAxisValueFormatter",
					"com/github/mikephil/charting/formatter/DefaultFillFormatter:MikePhil.Charting.Formatter.DefaultFillFormatter",
					"com/github/mikephil/charting/formatter/DefaultValueFormatter:MikePhil.Charting.Formatter.DefaultValueFormatter",
					"com/github/mikephil/charting/formatter/IndexAxisValueFormatter:MikePhil.Charting.Formatter.IndexAxisValueFormatter",
					"com/github/mikephil/charting/formatter/LargeValueFormatter:MikePhil.Charting.Formatter.LargeValueFormatter",
					"com/github/mikephil/charting/formatter/PercentFormatter:MikePhil.Charting.Formatter.PercentFormatter",
					"com/github/mikephil/charting/formatter/StackedValueFormatter:MikePhil.Charting.Formatter.StackedValueFormatter",
				};
			}

			return Lookup (package_com_github_mikephil_charting_formatter_mappings, klass);
		}

		static string[] package_com_github_mikephil_charting_highlight_mappings;
		static Type lookup_com_github_mikephil_charting_highlight_package (string klass)
		{
			if (package_com_github_mikephil_charting_highlight_mappings == null) {
				package_com_github_mikephil_charting_highlight_mappings = new string[]{
					"com/github/mikephil/charting/highlight/BarHighlighter:MikePhil.Charting.Highlight.BarHighlighter",
					"com/github/mikephil/charting/highlight/ChartHighlighter:MikePhil.Charting.Highlight.ChartHighlighter",
					"com/github/mikephil/charting/highlight/CombinedHighlighter:MikePhil.Charting.Highlight.CombinedHighlighter",
					"com/github/mikephil/charting/highlight/Highlight:MikePhil.Charting.Highlight.Highlight",
					"com/github/mikephil/charting/highlight/HorizontalBarHighlighter:MikePhil.Charting.Highlight.HorizontalBarHighlighter",
					"com/github/mikephil/charting/highlight/PieHighlighter:MikePhil.Charting.Highlight.PieHighlighter",
					"com/github/mikephil/charting/highlight/PieRadarHighlighter:MikePhil.Charting.Highlight.PieRadarHighlighter",
					"com/github/mikephil/charting/highlight/RadarHighlighter:MikePhil.Charting.Highlight.RadarHighlighter",
					"com/github/mikephil/charting/highlight/Range:MikePhil.Charting.Highlight.Range",
				};
			}

			return Lookup (package_com_github_mikephil_charting_highlight_mappings, klass);
		}

		static string[] package_com_github_mikephil_charting_jobs_mappings;
		static Type lookup_com_github_mikephil_charting_jobs_package (string klass)
		{
			if (package_com_github_mikephil_charting_jobs_mappings == null) {
				package_com_github_mikephil_charting_jobs_mappings = new string[]{
					"com/github/mikephil/charting/jobs/AnimatedMoveViewJob:MikePhil.Charting.Jobs.AnimatedMoveViewJob",
					"com/github/mikephil/charting/jobs/AnimatedViewPortJob:MikePhil.Charting.Jobs.AnimatedViewPortJob",
					"com/github/mikephil/charting/jobs/AnimatedZoomJob:MikePhil.Charting.Jobs.AnimatedZoomJob",
					"com/github/mikephil/charting/jobs/MoveViewJob:MikePhil.Charting.Jobs.MoveViewJob",
					"com/github/mikephil/charting/jobs/ViewPortJob:MikePhil.Charting.Jobs.ViewPortJob",
					"com/github/mikephil/charting/jobs/ZoomJob:MikePhil.Charting.Jobs.ZoomJob",
				};
			}

			return Lookup (package_com_github_mikephil_charting_jobs_mappings, klass);
		}

		static string[] package_com_github_mikephil_charting_listener_mappings;
		static Type lookup_com_github_mikephil_charting_listener_package (string klass)
		{
			if (package_com_github_mikephil_charting_listener_mappings == null) {
				package_com_github_mikephil_charting_listener_mappings = new string[]{
					"com/github/mikephil/charting/listener/BarLineChartTouchListener:MikePhil.Charting.Listener.BarLineChartTouchListener",
					"com/github/mikephil/charting/listener/ChartTouchListener:MikePhil.Charting.Listener.ChartTouchListener",
					"com/github/mikephil/charting/listener/ChartTouchListener$ChartGesture:MikePhil.Charting.Listener.ChartTouchListener/ChartGesture",
					"com/github/mikephil/charting/listener/OnDrawLineChartTouchListener:MikePhil.Charting.Listener.OnDrawLineChartTouchListener",
					"com/github/mikephil/charting/listener/PieRadarChartTouchListener:MikePhil.Charting.Listener.PieRadarChartTouchListener",
				};
			}

			return Lookup (package_com_github_mikephil_charting_listener_mappings, klass);
		}

		static string[] package_com_github_mikephil_charting_matrix_mappings;
		static Type lookup_com_github_mikephil_charting_matrix_package (string klass)
		{
			if (package_com_github_mikephil_charting_matrix_mappings == null) {
				package_com_github_mikephil_charting_matrix_mappings = new string[]{
					"com/github/mikephil/charting/matrix/Vector3:MikePhil.Charting.Matrix.Vector3",
				};
			}

			return Lookup (package_com_github_mikephil_charting_matrix_mappings, klass);
		}

		static string[] package_com_github_mikephil_charting_model_mappings;
		static Type lookup_com_github_mikephil_charting_model_package (string klass)
		{
			if (package_com_github_mikephil_charting_model_mappings == null) {
				package_com_github_mikephil_charting_model_mappings = new string[]{
					"com/github/mikephil/charting/model/GradientColor:MikePhil.Charting.Model.GradientColor",
				};
			}

			return Lookup (package_com_github_mikephil_charting_model_mappings, klass);
		}

		static string[] package_com_github_mikephil_charting_renderer_mappings;
		static Type lookup_com_github_mikephil_charting_renderer_package (string klass)
		{
			if (package_com_github_mikephil_charting_renderer_mappings == null) {
				package_com_github_mikephil_charting_renderer_mappings = new string[]{
					"com/github/mikephil/charting/renderer/AxisRenderer:MikePhil.Charting.Renderer.AxisRenderer",
					"com/github/mikephil/charting/renderer/BarChartRenderer:MikePhil.Charting.Renderer.BarChartRenderer",
					"com/github/mikephil/charting/renderer/BarLineScatterCandleBubbleRenderer:MikePhil.Charting.Renderer.BarLineScatterCandleBubbleRenderer",
					"com/github/mikephil/charting/renderer/BarLineScatterCandleBubbleRenderer$XBounds:MikePhil.Charting.Renderer.BarLineScatterCandleBubbleRenderer/XBounds",
					"com/github/mikephil/charting/renderer/BubbleChartRenderer:MikePhil.Charting.Renderer.BubbleChartRenderer",
					"com/github/mikephil/charting/renderer/CandleStickChartRenderer:MikePhil.Charting.Renderer.CandleStickChartRenderer",
					"com/github/mikephil/charting/renderer/CombinedChartRenderer:MikePhil.Charting.Renderer.CombinedChartRenderer",
					"com/github/mikephil/charting/renderer/DataRenderer:MikePhil.Charting.Renderer.DataRenderer",
					"com/github/mikephil/charting/renderer/HorizontalBarChartRenderer:MikePhil.Charting.Renderer.HorizontalBarChartRenderer",
					"com/github/mikephil/charting/renderer/LegendRenderer:MikePhil.Charting.Renderer.LegendRenderer",
					"com/github/mikephil/charting/renderer/LineChartRenderer:MikePhil.Charting.Renderer.LineChartRenderer",
					"com/github/mikephil/charting/renderer/LineRadarRenderer:MikePhil.Charting.Renderer.LineRadarRenderer",
					"com/github/mikephil/charting/renderer/LineScatterCandleRadarRenderer:MikePhil.Charting.Renderer.LineScatterCandleRadarRenderer",
					"com/github/mikephil/charting/renderer/PieChartRenderer:MikePhil.Charting.Renderer.PieChartRenderer",
					"com/github/mikephil/charting/renderer/RadarChartRenderer:MikePhil.Charting.Renderer.RadarChartRenderer",
					"com/github/mikephil/charting/renderer/Renderer:MikePhil.Charting.Renderer.Renderer",
					"com/github/mikephil/charting/renderer/ScatterChartRenderer:MikePhil.Charting.Renderer.ScatterChartRenderer",
					"com/github/mikephil/charting/renderer/XAxisRenderer:MikePhil.Charting.Renderer.XAxisRenderer",
					"com/github/mikephil/charting/renderer/XAxisRendererHorizontalBarChart:MikePhil.Charting.Renderer.XAxisRendererHorizontalBarChart",
					"com/github/mikephil/charting/renderer/XAxisRendererRadarChart:MikePhil.Charting.Renderer.XAxisRendererRadarChart",
					"com/github/mikephil/charting/renderer/YAxisRenderer:MikePhil.Charting.Renderer.YAxisRenderer",
					"com/github/mikephil/charting/renderer/YAxisRendererHorizontalBarChart:MikePhil.Charting.Renderer.YAxisRendererHorizontalBarChart",
					"com/github/mikephil/charting/renderer/YAxisRendererRadarChart:MikePhil.Charting.Renderer.YAxisRendererRadarChart",
				};
			}

			return Lookup (package_com_github_mikephil_charting_renderer_mappings, klass);
		}

		static string[] package_com_github_mikephil_charting_renderer_scatter_mappings;
		static Type lookup_com_github_mikephil_charting_renderer_scatter_package (string klass)
		{
			if (package_com_github_mikephil_charting_renderer_scatter_mappings == null) {
				package_com_github_mikephil_charting_renderer_scatter_mappings = new string[]{
					"com/github/mikephil/charting/renderer/scatter/ChevronDownShapeRenderer:MikePhil.Charting.Renderer.Scatter.ChevronDownShapeRenderer",
					"com/github/mikephil/charting/renderer/scatter/ChevronUpShapeRenderer:MikePhil.Charting.Renderer.Scatter.ChevronUpShapeRenderer",
					"com/github/mikephil/charting/renderer/scatter/CircleShapeRenderer:MikePhil.Charting.Renderer.Scatter.CircleShapeRenderer",
					"com/github/mikephil/charting/renderer/scatter/CrossShapeRenderer:MikePhil.Charting.Renderer.Scatter.CrossShapeRenderer",
					"com/github/mikephil/charting/renderer/scatter/SquareShapeRenderer:MikePhil.Charting.Renderer.Scatter.SquareShapeRenderer",
					"com/github/mikephil/charting/renderer/scatter/TriangleShapeRenderer:MikePhil.Charting.Renderer.Scatter.TriangleShapeRenderer",
					"com/github/mikephil/charting/renderer/scatter/XShapeRenderer:MikePhil.Charting.Renderer.Scatter.XShapeRenderer",
				};
			}

			return Lookup (package_com_github_mikephil_charting_renderer_scatter_mappings, klass);
		}

		static string[] package_com_github_mikephil_charting_utils_mappings;
		static Type lookup_com_github_mikephil_charting_utils_package (string klass)
		{
			if (package_com_github_mikephil_charting_utils_mappings == null) {
				package_com_github_mikephil_charting_utils_mappings = new string[]{
					"com/github/mikephil/charting/utils/ColorTemplate:MikePhil.Charting.Util.ColorTemplate",
					"com/github/mikephil/charting/utils/EntryXComparator:MikePhil.Charting.Util.EntryXComparator",
					"com/github/mikephil/charting/utils/FileUtils:MikePhil.Charting.Util.FileUtils",
					"com/github/mikephil/charting/utils/FSize:MikePhil.Charting.Util.FSize",
					"com/github/mikephil/charting/utils/HorizontalViewPortHandler:MikePhil.Charting.Util.HorizontalViewPortHandler",
					"com/github/mikephil/charting/utils/MPPointD:MikePhil.Charting.Util.MPPointD",
					"com/github/mikephil/charting/utils/MPPointF:MikePhil.Charting.Util.MPPointF",
					"com/github/mikephil/charting/utils/ObjectPool:MikePhil.Charting.Util.ObjectPool",
					"com/github/mikephil/charting/utils/ObjectPool$Poolable:MikePhil.Charting.Util.ObjectPool/Poolable",
					"com/github/mikephil/charting/utils/Transformer:MikePhil.Charting.Util.Transformer",
					"com/github/mikephil/charting/utils/TransformerHorizontalBarChart:MikePhil.Charting.Util.TransformerHorizontalBarChart",
					"com/github/mikephil/charting/utils/Utils:MikePhil.Charting.Util.Utils",
					"com/github/mikephil/charting/utils/ViewPortHandler:MikePhil.Charting.Util.ViewPortHandler",
				};
			}

			return Lookup (package_com_github_mikephil_charting_utils_mappings, klass);
		}
	}
}
