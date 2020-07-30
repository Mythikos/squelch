using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Charts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/charts/Chart", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.github.mikephil.charting.data.ChartData<? extends com.github.mikephil.charting.interfaces.datasets.IDataSet<? extends com.github.mikephil.charting.data.Entry>>"})]
	public abstract partial class Chart : global::Android.Views.ViewGroup, global::MikePhil.Charting.Interfaces.Dataprovider.IChartInterface {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='LOG_TAG']"
		[Register ("LOG_TAG")]
		public const string LogTag = (string) "MPAndroidChart";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='PAINT_CENTER_TEXT']"
		[Register ("PAINT_CENTER_TEXT")]
		public const int PaintCenterText = (int) 14;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='PAINT_DESCRIPTION']"
		[Register ("PAINT_DESCRIPTION")]
		public const int PaintDescription = (int) 11;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='PAINT_GRID_BACKGROUND']"
		[Register ("PAINT_GRID_BACKGROUND")]
		public const int PaintGridBackground = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='PAINT_HOLE']"
		[Register ("PAINT_HOLE")]
		public const int PaintHole = (int) 13;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='PAINT_INFO']"
		[Register ("PAINT_INFO")]
		public const int PaintInfo = (int) 7;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='PAINT_LEGEND_LABEL']"
		[Register ("PAINT_LEGEND_LABEL")]
		public const int PaintLegendLabel = (int) 18;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='mAnimator']"
		[Register ("mAnimator")]
		protected global::MikePhil.Charting.Animation.ChartAnimator MAnimator {
			get {
				const string __id = "mAnimator.Lcom/github/mikephil/charting/animation/ChartAnimator;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.ChartAnimator> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAnimator.Lcom/github/mikephil/charting/animation/ChartAnimator;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='mChartTouchListener']"
		[Register ("mChartTouchListener")]
		protected global::MikePhil.Charting.Listener.ChartTouchListener MChartTouchListener {
			get {
				const string __id = "mChartTouchListener.Lcom/github/mikephil/charting/listener/ChartTouchListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mChartTouchListener.Lcom/github/mikephil/charting/listener/ChartTouchListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='mData']"
		[Register ("mData")]
		protected global::MikePhil.Charting.Data.ChartData MData {
			get {
				const string __id = "mData.Lcom/github/mikephil/charting/data/ChartData;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mData.Lcom/github/mikephil/charting/data/ChartData;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='mDefaultValueFormatter']"
		[Register ("mDefaultValueFormatter")]
		protected global::MikePhil.Charting.Formatter.DefaultValueFormatter MDefaultValueFormatter {
			get {
				const string __id = "mDefaultValueFormatter.Lcom/github/mikephil/charting/formatter/DefaultValueFormatter;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.DefaultValueFormatter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDefaultValueFormatter.Lcom/github/mikephil/charting/formatter/DefaultValueFormatter;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='mDescPaint']"
		[Register ("mDescPaint")]
		protected global::Android.Graphics.Paint MDescPaint {
			get {
				const string __id = "mDescPaint.Landroid/graphics/Paint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDescPaint.Landroid/graphics/Paint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='mDescription']"
		[Register ("mDescription")]
		protected global::MikePhil.Charting.Components.Description MDescription {
			get {
				const string __id = "mDescription.Lcom/github/mikephil/charting/components/Description;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Description> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDescription.Lcom/github/mikephil/charting/components/Description;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='mDrawMarkers']"
		[Register ("mDrawMarkers")]
		protected bool MDrawMarkers {
			get {
				const string __id = "mDrawMarkers.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mDrawMarkers.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='mHighLightPerTapEnabled']"
		[Register ("mHighLightPerTapEnabled")]
		protected bool MHighLightPerTapEnabled {
			get {
				const string __id = "mHighLightPerTapEnabled.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mHighLightPerTapEnabled.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='mHighlighter']"
		[Register ("mHighlighter")]
		protected global::MikePhil.Charting.Highlight.IHighlighter MHighlighter {
			get {
				const string __id = "mHighlighter.Lcom/github/mikephil/charting/highlight/IHighlighter;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.IHighlighter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mHighlighter.Lcom/github/mikephil/charting/highlight/IHighlighter;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='mIndicesToHighlight']"
		[Register ("mIndicesToHighlight")]
		protected IList<MikePhil.Charting.Highlight.Highlight> MIndicesToHighlight {
			get {
				const string __id = "mIndicesToHighlight.[Lcom/github/mikephil/charting/highlight/Highlight;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<global::MikePhil.Charting.Highlight.Highlight>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mIndicesToHighlight.[Lcom/github/mikephil/charting/highlight/Highlight;";

				IntPtr native_value = global::Android.Runtime.JavaArray<global::MikePhil.Charting.Highlight.Highlight>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='mInfoPaint']"
		[Register ("mInfoPaint")]
		protected global::Android.Graphics.Paint MInfoPaint {
			get {
				const string __id = "mInfoPaint.Landroid/graphics/Paint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mInfoPaint.Landroid/graphics/Paint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='mJobs']"
		[Register ("mJobs")]
		protected global::System.Collections.IList MJobs {
			get {
				const string __id = "mJobs.Ljava/util/ArrayList;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mJobs.Ljava/util/ArrayList;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='mLegend']"
		[Register ("mLegend")]
		protected global::MikePhil.Charting.Components.Legend MLegend {
			get {
				const string __id = "mLegend.Lcom/github/mikephil/charting/components/Legend;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mLegend.Lcom/github/mikephil/charting/components/Legend;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='mLegendRenderer']"
		[Register ("mLegendRenderer")]
		protected global::MikePhil.Charting.Renderer.LegendRenderer MLegendRenderer {
			get {
				const string __id = "mLegendRenderer.Lcom/github/mikephil/charting/renderer/LegendRenderer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LegendRenderer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mLegendRenderer.Lcom/github/mikephil/charting/renderer/LegendRenderer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='mLogEnabled']"
		[Register ("mLogEnabled")]
		protected bool MLogEnabled {
			get {
				const string __id = "mLogEnabled.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mLogEnabled.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='mMarker']"
		[Register ("mMarker")]
		protected global::MikePhil.Charting.Components.IMarker MMarker {
			get {
				const string __id = "mMarker.Lcom/github/mikephil/charting/components/IMarker;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.IMarker> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mMarker.Lcom/github/mikephil/charting/components/IMarker;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='mMaxHighlightDistance']"
		[Register ("mMaxHighlightDistance")]
		protected float MMaxHighlightDistance {
			get {
				const string __id = "mMaxHighlightDistance.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mMaxHighlightDistance.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='mRenderer']"
		[Register ("mRenderer")]
		protected global::MikePhil.Charting.Renderer.DataRenderer MRenderer {
			get {
				const string __id = "mRenderer.Lcom/github/mikephil/charting/renderer/DataRenderer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.DataRenderer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mRenderer.Lcom/github/mikephil/charting/renderer/DataRenderer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='mSelectionListener']"
		[Register ("mSelectionListener")]
		protected global::MikePhil.Charting.Listener.IOnChartValueSelectedListenerSupport MSelectionListener {
			get {
				const string __id = "mSelectionListener.Lcom/github/mikephil/charting/listener/OnChartValueSelectedListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.IOnChartValueSelectedListenerSupport> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mSelectionListener.Lcom/github/mikephil/charting/listener/OnChartValueSelectedListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='mTouchEnabled']"
		[Register ("mTouchEnabled")]
		protected bool MTouchEnabled {
			get {
				const string __id = "mTouchEnabled.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mTouchEnabled.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='mViewPortHandler']"
		[Register ("mViewPortHandler")]
		protected global::MikePhil.Charting.Util.ViewPortHandler MViewPortHandler {
			get {
				const string __id = "mViewPortHandler.Lcom/github/mikephil/charting/utils/ViewPortHandler;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mViewPortHandler.Lcom/github/mikephil/charting/utils/ViewPortHandler;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/field[@name='mXAxis']"
		[Register ("mXAxis")]
		protected global::MikePhil.Charting.Components.XAxis MXAxis {
			get {
				const string __id = "mXAxis.Lcom/github/mikephil/charting/components/XAxis;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.XAxis> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mXAxis.Lcom/github/mikephil/charting/components/XAxis;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/charts/Chart", typeof (Chart));
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

		protected Chart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/constructor[@name='Chart' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe Chart (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/constructor[@name='Chart' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe Chart (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/constructor[@name='Chart' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe Chart (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getAnimator;
#pragma warning disable 0169
		static Delegate GetGetAnimatorHandler ()
		{
			if (cb_getAnimator == null)
				cb_getAnimator = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAnimator);
			return cb_getAnimator;
		}

		static IntPtr n_GetAnimator (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Animator);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Animation.ChartAnimator Animator {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getAnimator' and count(parameter)=0]"
			[Register ("getAnimator", "()Lcom/github/mikephil/charting/animation/ChartAnimator;", "GetGetAnimatorHandler")]
			get {
				const string __id = "getAnimator.()Lcom/github/mikephil/charting/animation/ChartAnimator;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.ChartAnimator> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCenter;
#pragma warning disable 0169
		static Delegate GetGetCenterHandler ()
		{
			if (cb_getCenter == null)
				cb_getCenter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCenter);
			return cb_getCenter;
		}

		static IntPtr n_GetCenter (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Center);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Util.MPPointF Center {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getCenter' and count(parameter)=0]"
			[Register ("getCenter", "()Lcom/github/mikephil/charting/utils/MPPointF;", "GetGetCenterHandler")]
			get {
				const string __id = "getCenter.()Lcom/github/mikephil/charting/utils/MPPointF;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCenterOfView;
#pragma warning disable 0169
		static Delegate GetGetCenterOfViewHandler ()
		{
			if (cb_getCenterOfView == null)
				cb_getCenterOfView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCenterOfView);
			return cb_getCenterOfView;
		}

		static IntPtr n_GetCenterOfView (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CenterOfView);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Util.MPPointF CenterOfView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getCenterOfView' and count(parameter)=0]"
			[Register ("getCenterOfView", "()Lcom/github/mikephil/charting/utils/MPPointF;", "GetGetCenterOfViewHandler")]
			get {
				const string __id = "getCenterOfView.()Lcom/github/mikephil/charting/utils/MPPointF;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCenterOffsets;
#pragma warning disable 0169
		static Delegate GetGetCenterOffsetsHandler ()
		{
			if (cb_getCenterOffsets == null)
				cb_getCenterOffsets = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCenterOffsets);
			return cb_getCenterOffsets;
		}

		static IntPtr n_GetCenterOffsets (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CenterOffsets);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Util.MPPointF CenterOffsets {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getCenterOffsets' and count(parameter)=0]"
			[Register ("getCenterOffsets", "()Lcom/github/mikephil/charting/utils/MPPointF;", "GetGetCenterOffsetsHandler")]
			get {
				const string __id = "getCenterOffsets.()Lcom/github/mikephil/charting/utils/MPPointF;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getChartBitmap;
#pragma warning disable 0169
		static Delegate GetGetChartBitmapHandler ()
		{
			if (cb_getChartBitmap == null)
				cb_getChartBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetChartBitmap);
			return cb_getChartBitmap;
		}

		static IntPtr n_GetChartBitmap (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ChartBitmap);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Bitmap ChartBitmap {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getChartBitmap' and count(parameter)=0]"
			[Register ("getChartBitmap", "()Landroid/graphics/Bitmap;", "GetGetChartBitmapHandler")]
			get {
				const string __id = "getChartBitmap.()Landroid/graphics/Bitmap;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContentRect;
#pragma warning disable 0169
		static Delegate GetGetContentRectHandler ()
		{
			if (cb_getContentRect == null)
				cb_getContentRect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentRect);
			return cb_getContentRect;
		}

		static IntPtr n_GetContentRect (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentRect);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.RectF ContentRect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getContentRect' and count(parameter)=0]"
			[Register ("getContentRect", "()Landroid/graphics/RectF;", "GetGetContentRectHandler")]
			get {
				const string __id = "getContentRect.()Landroid/graphics/RectF;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Data);
		}
#pragma warning restore 0169

		static Delegate cb_setData_Lcom_github_mikephil_charting_data_ChartData_;
#pragma warning disable 0169
		static Delegate GetSetData_Lcom_github_mikephil_charting_data_ChartData_Handler ()
		{
			if (cb_setData_Lcom_github_mikephil_charting_data_ChartData_ == null)
				cb_setData_Lcom_github_mikephil_charting_data_ChartData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Lcom_github_mikephil_charting_data_ChartData_);
			return cb_setData_Lcom_github_mikephil_charting_data_ChartData_;
		}

		static void n_SetData_Lcom_github_mikephil_charting_data_ChartData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.ChartData data = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.Data = data;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Data.ChartData Data {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getData' and count(parameter)=0]"
			[Register ("getData", "()Lcom/github/mikephil/charting/data/ChartData;", "GetGetDataHandler")]
			get {
				const string __id = "getData.()Lcom/github/mikephil/charting/data/ChartData;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.ChartData']]"
			[Register ("setData", "(Lcom/github/mikephil/charting/data/ChartData;)V", "GetSetData_Lcom_github_mikephil_charting_data_ChartData_Handler")]
			set {
				const string __id = "setData.(Lcom/github/mikephil/charting/data/ChartData;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDefaultValueFormatter;
#pragma warning disable 0169
		static Delegate GetGetDefaultValueFormatterHandler ()
		{
			if (cb_getDefaultValueFormatter == null)
				cb_getDefaultValueFormatter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDefaultValueFormatter);
			return cb_getDefaultValueFormatter;
		}

		static IntPtr n_GetDefaultValueFormatter (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DefaultValueFormatter);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Formatter.IValueFormatter DefaultValueFormatter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getDefaultValueFormatter' and count(parameter)=0]"
			[Register ("getDefaultValueFormatter", "()Lcom/github/mikephil/charting/formatter/IValueFormatter;", "GetGetDefaultValueFormatterHandler")]
			get {
				const string __id = "getDefaultValueFormatter.()Lcom/github/mikephil/charting/formatter/IValueFormatter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IValueFormatter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDescription;
#pragma warning disable 0169
		static Delegate GetGetDescriptionHandler ()
		{
			if (cb_getDescription == null)
				cb_getDescription = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDescription);
			return cb_getDescription;
		}

		static IntPtr n_GetDescription (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Description);
		}
#pragma warning restore 0169

		static Delegate cb_setDescription_Lcom_github_mikephil_charting_components_Description_;
#pragma warning disable 0169
		static Delegate GetSetDescription_Lcom_github_mikephil_charting_components_Description_Handler ()
		{
			if (cb_setDescription_Lcom_github_mikephil_charting_components_Description_ == null)
				cb_setDescription_Lcom_github_mikephil_charting_components_Description_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDescription_Lcom_github_mikephil_charting_components_Description_);
			return cb_setDescription_Lcom_github_mikephil_charting_components_Description_;
		}

		static void n_SetDescription_Lcom_github_mikephil_charting_components_Description_ (IntPtr jnienv, IntPtr native__this, IntPtr native_desc)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.Description desc = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Description> (native_desc, JniHandleOwnership.DoNotTransfer);
			__this.Description = desc;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Components.Description Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Lcom/github/mikephil/charting/components/Description;", "GetGetDescriptionHandler")]
			get {
				const string __id = "getDescription.()Lcom/github/mikephil/charting/components/Description;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Description> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setDescription' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.Description']]"
			[Register ("setDescription", "(Lcom/github/mikephil/charting/components/Description;)V", "GetSetDescription_Lcom_github_mikephil_charting_components_Description_Handler")]
			set {
				const string __id = "setDescription.(Lcom/github/mikephil/charting/components/Description;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDragDecelerationEnabled;
#pragma warning disable 0169
		static Delegate GetIsDragDecelerationEnabledHandler ()
		{
			if (cb_isDragDecelerationEnabled == null)
				cb_isDragDecelerationEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDragDecelerationEnabled);
			return cb_isDragDecelerationEnabled;
		}

		static bool n_IsDragDecelerationEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DragDecelerationEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setDragDecelerationEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDragDecelerationEnabled_ZHandler ()
		{
			if (cb_setDragDecelerationEnabled_Z == null)
				cb_setDragDecelerationEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDragDecelerationEnabled_Z);
			return cb_setDragDecelerationEnabled_Z;
		}

		static void n_SetDragDecelerationEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DragDecelerationEnabled = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool DragDecelerationEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='isDragDecelerationEnabled' and count(parameter)=0]"
			[Register ("isDragDecelerationEnabled", "()Z", "GetIsDragDecelerationEnabledHandler")]
			get {
				const string __id = "isDragDecelerationEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setDragDecelerationEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDragDecelerationEnabled", "(Z)V", "GetSetDragDecelerationEnabled_ZHandler")]
			set {
				const string __id = "setDragDecelerationEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDragDecelerationFrictionCoef;
#pragma warning disable 0169
		static Delegate GetGetDragDecelerationFrictionCoefHandler ()
		{
			if (cb_getDragDecelerationFrictionCoef == null)
				cb_getDragDecelerationFrictionCoef = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetDragDecelerationFrictionCoef);
			return cb_getDragDecelerationFrictionCoef;
		}

		static float n_GetDragDecelerationFrictionCoef (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DragDecelerationFrictionCoef;
		}
#pragma warning restore 0169

		static Delegate cb_setDragDecelerationFrictionCoef_F;
#pragma warning disable 0169
		static Delegate GetSetDragDecelerationFrictionCoef_FHandler ()
		{
			if (cb_setDragDecelerationFrictionCoef_F == null)
				cb_setDragDecelerationFrictionCoef_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetDragDecelerationFrictionCoef_F);
			return cb_setDragDecelerationFrictionCoef_F;
		}

		static void n_SetDragDecelerationFrictionCoef_F (IntPtr jnienv, IntPtr native__this, float newValue)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DragDecelerationFrictionCoef = newValue;
		}
#pragma warning restore 0169

		public virtual unsafe float DragDecelerationFrictionCoef {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getDragDecelerationFrictionCoef' and count(parameter)=0]"
			[Register ("getDragDecelerationFrictionCoef", "()F", "GetGetDragDecelerationFrictionCoefHandler")]
			get {
				const string __id = "getDragDecelerationFrictionCoef.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setDragDecelerationFrictionCoef' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setDragDecelerationFrictionCoef", "(F)V", "GetSetDragDecelerationFrictionCoef_FHandler")]
			set {
				const string __id = "setDragDecelerationFrictionCoef.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getExtraBottomOffset;
#pragma warning disable 0169
		static Delegate GetGetExtraBottomOffsetHandler ()
		{
			if (cb_getExtraBottomOffset == null)
				cb_getExtraBottomOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetExtraBottomOffset);
			return cb_getExtraBottomOffset;
		}

		static float n_GetExtraBottomOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExtraBottomOffset;
		}
#pragma warning restore 0169

		static Delegate cb_setExtraBottomOffset_F;
#pragma warning disable 0169
		static Delegate GetSetExtraBottomOffset_FHandler ()
		{
			if (cb_setExtraBottomOffset_F == null)
				cb_setExtraBottomOffset_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetExtraBottomOffset_F);
			return cb_setExtraBottomOffset_F;
		}

		static void n_SetExtraBottomOffset_F (IntPtr jnienv, IntPtr native__this, float offset)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExtraBottomOffset = offset;
		}
#pragma warning restore 0169

		public virtual unsafe float ExtraBottomOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getExtraBottomOffset' and count(parameter)=0]"
			[Register ("getExtraBottomOffset", "()F", "GetGetExtraBottomOffsetHandler")]
			get {
				const string __id = "getExtraBottomOffset.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setExtraBottomOffset' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setExtraBottomOffset", "(F)V", "GetSetExtraBottomOffset_FHandler")]
			set {
				const string __id = "setExtraBottomOffset.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getExtraLeftOffset;
#pragma warning disable 0169
		static Delegate GetGetExtraLeftOffsetHandler ()
		{
			if (cb_getExtraLeftOffset == null)
				cb_getExtraLeftOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetExtraLeftOffset);
			return cb_getExtraLeftOffset;
		}

		static float n_GetExtraLeftOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExtraLeftOffset;
		}
#pragma warning restore 0169

		static Delegate cb_setExtraLeftOffset_F;
#pragma warning disable 0169
		static Delegate GetSetExtraLeftOffset_FHandler ()
		{
			if (cb_setExtraLeftOffset_F == null)
				cb_setExtraLeftOffset_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetExtraLeftOffset_F);
			return cb_setExtraLeftOffset_F;
		}

		static void n_SetExtraLeftOffset_F (IntPtr jnienv, IntPtr native__this, float offset)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExtraLeftOffset = offset;
		}
#pragma warning restore 0169

		public virtual unsafe float ExtraLeftOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getExtraLeftOffset' and count(parameter)=0]"
			[Register ("getExtraLeftOffset", "()F", "GetGetExtraLeftOffsetHandler")]
			get {
				const string __id = "getExtraLeftOffset.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setExtraLeftOffset' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setExtraLeftOffset", "(F)V", "GetSetExtraLeftOffset_FHandler")]
			set {
				const string __id = "setExtraLeftOffset.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getExtraRightOffset;
#pragma warning disable 0169
		static Delegate GetGetExtraRightOffsetHandler ()
		{
			if (cb_getExtraRightOffset == null)
				cb_getExtraRightOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetExtraRightOffset);
			return cb_getExtraRightOffset;
		}

		static float n_GetExtraRightOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExtraRightOffset;
		}
#pragma warning restore 0169

		static Delegate cb_setExtraRightOffset_F;
#pragma warning disable 0169
		static Delegate GetSetExtraRightOffset_FHandler ()
		{
			if (cb_setExtraRightOffset_F == null)
				cb_setExtraRightOffset_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetExtraRightOffset_F);
			return cb_setExtraRightOffset_F;
		}

		static void n_SetExtraRightOffset_F (IntPtr jnienv, IntPtr native__this, float offset)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExtraRightOffset = offset;
		}
#pragma warning restore 0169

		public virtual unsafe float ExtraRightOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getExtraRightOffset' and count(parameter)=0]"
			[Register ("getExtraRightOffset", "()F", "GetGetExtraRightOffsetHandler")]
			get {
				const string __id = "getExtraRightOffset.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setExtraRightOffset' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setExtraRightOffset", "(F)V", "GetSetExtraRightOffset_FHandler")]
			set {
				const string __id = "setExtraRightOffset.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getExtraTopOffset;
#pragma warning disable 0169
		static Delegate GetGetExtraTopOffsetHandler ()
		{
			if (cb_getExtraTopOffset == null)
				cb_getExtraTopOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetExtraTopOffset);
			return cb_getExtraTopOffset;
		}

		static float n_GetExtraTopOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ExtraTopOffset;
		}
#pragma warning restore 0169

		static Delegate cb_setExtraTopOffset_F;
#pragma warning disable 0169
		static Delegate GetSetExtraTopOffset_FHandler ()
		{
			if (cb_setExtraTopOffset_F == null)
				cb_setExtraTopOffset_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetExtraTopOffset_F);
			return cb_setExtraTopOffset_F;
		}

		static void n_SetExtraTopOffset_F (IntPtr jnienv, IntPtr native__this, float offset)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ExtraTopOffset = offset;
		}
#pragma warning restore 0169

		public virtual unsafe float ExtraTopOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getExtraTopOffset' and count(parameter)=0]"
			[Register ("getExtraTopOffset", "()F", "GetGetExtraTopOffsetHandler")]
			get {
				const string __id = "getExtraTopOffset.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setExtraTopOffset' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setExtraTopOffset", "(F)V", "GetSetExtraTopOffset_FHandler")]
			set {
				const string __id = "setExtraTopOffset.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isHighlightPerTapEnabled;
#pragma warning disable 0169
		static Delegate GetIsHighlightPerTapEnabledHandler ()
		{
			if (cb_isHighlightPerTapEnabled == null)
				cb_isHighlightPerTapEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHighlightPerTapEnabled);
			return cb_isHighlightPerTapEnabled;
		}

		static bool n_IsHighlightPerTapEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighlightPerTapEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setHighlightPerTapEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetHighlightPerTapEnabled_ZHandler ()
		{
			if (cb_setHighlightPerTapEnabled_Z == null)
				cb_setHighlightPerTapEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHighlightPerTapEnabled_Z);
			return cb_setHighlightPerTapEnabled_Z;
		}

		static void n_SetHighlightPerTapEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighlightPerTapEnabled = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool HighlightPerTapEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='isHighlightPerTapEnabled' and count(parameter)=0]"
			[Register ("isHighlightPerTapEnabled", "()Z", "GetIsHighlightPerTapEnabledHandler")]
			get {
				const string __id = "isHighlightPerTapEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setHighlightPerTapEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHighlightPerTapEnabled", "(Z)V", "GetSetHighlightPerTapEnabled_ZHandler")]
			set {
				const string __id = "setHighlightPerTapEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHighlighter;
#pragma warning disable 0169
		static Delegate GetGetHighlighterHandler ()
		{
			if (cb_getHighlighter == null)
				cb_getHighlighter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHighlighter);
			return cb_getHighlighter;
		}

		static IntPtr n_GetHighlighter (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Highlighter);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Highlight.IHighlighter Highlighter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getHighlighter' and count(parameter)=0]"
			[Register ("getHighlighter", "()Lcom/github/mikephil/charting/highlight/IHighlighter;", "GetGetHighlighterHandler")]
			get {
				const string __id = "getHighlighter.()Lcom/github/mikephil/charting/highlight/IHighlighter;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.IHighlighter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isDrawMarkerViewsEnabled;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetIsDrawMarkerViewsEnabledHandler ()
		{
			if (cb_isDrawMarkerViewsEnabled == null)
				cb_isDrawMarkerViewsEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawMarkerViewsEnabled);
			return cb_isDrawMarkerViewsEnabled;
		}

		[Obsolete]
		static bool n_IsDrawMarkerViewsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawMarkerViewsEnabled;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe bool IsDrawMarkerViewsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='isDrawMarkerViewsEnabled' and count(parameter)=0]"
			[Register ("isDrawMarkerViewsEnabled", "()Z", "GetIsDrawMarkerViewsEnabledHandler")]
			get {
				const string __id = "isDrawMarkerViewsEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDrawMarkersEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawMarkersEnabledHandler ()
		{
			if (cb_isDrawMarkersEnabled == null)
				cb_isDrawMarkersEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawMarkersEnabled);
			return cb_isDrawMarkersEnabled;
		}

		static bool n_IsDrawMarkersEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawMarkersEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrawMarkersEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='isDrawMarkersEnabled' and count(parameter)=0]"
			[Register ("isDrawMarkersEnabled", "()Z", "GetIsDrawMarkersEnabledHandler")]
			get {
				const string __id = "isDrawMarkersEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isEmpty;
#pragma warning disable 0169
		static Delegate GetIsEmptyHandler ()
		{
			if (cb_isEmpty == null)
				cb_isEmpty = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEmpty);
			return cb_isEmpty;
		}

		static bool n_IsEmpty (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEmpty;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsEmpty {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='isEmpty' and count(parameter)=0]"
			[Register ("isEmpty", "()Z", "GetIsEmptyHandler")]
			get {
				const string __id = "isEmpty.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getJobs;
#pragma warning disable 0169
		static Delegate GetGetJobsHandler ()
		{
			if (cb_getJobs == null)
				cb_getJobs = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetJobs);
			return cb_getJobs;
		}

		static IntPtr n_GetJobs (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.IRunnable>.ToLocalJniHandle (__this.Jobs);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Lang.IRunnable> Jobs {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getJobs' and count(parameter)=0]"
			[Register ("getJobs", "()Ljava/util/ArrayList;", "GetGetJobsHandler")]
			get {
				const string __id = "getJobs.()Ljava/util/ArrayList;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Java.Lang.IRunnable>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLegend;
#pragma warning disable 0169
		static Delegate GetGetLegendHandler ()
		{
			if (cb_getLegend == null)
				cb_getLegend = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLegend);
			return cb_getLegend;
		}

		static IntPtr n_GetLegend (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Legend);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Components.Legend Legend {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getLegend' and count(parameter)=0]"
			[Register ("getLegend", "()Lcom/github/mikephil/charting/components/Legend;", "GetGetLegendHandler")]
			get {
				const string __id = "getLegend.()Lcom/github/mikephil/charting/components/Legend;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLegendRenderer;
#pragma warning disable 0169
		static Delegate GetGetLegendRendererHandler ()
		{
			if (cb_getLegendRenderer == null)
				cb_getLegendRenderer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLegendRenderer);
			return cb_getLegendRenderer;
		}

		static IntPtr n_GetLegendRenderer (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LegendRenderer);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Renderer.LegendRenderer LegendRenderer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getLegendRenderer' and count(parameter)=0]"
			[Register ("getLegendRenderer", "()Lcom/github/mikephil/charting/renderer/LegendRenderer;", "GetGetLegendRendererHandler")]
			get {
				const string __id = "getLegendRenderer.()Lcom/github/mikephil/charting/renderer/LegendRenderer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.LegendRenderer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isLogEnabled;
#pragma warning disable 0169
		static Delegate GetIsLogEnabledHandler ()
		{
			if (cb_isLogEnabled == null)
				cb_isLogEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLogEnabled);
			return cb_isLogEnabled;
		}

		static bool n_IsLogEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LogEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setLogEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetLogEnabled_ZHandler ()
		{
			if (cb_setLogEnabled_Z == null)
				cb_setLogEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetLogEnabled_Z);
			return cb_setLogEnabled_Z;
		}

		static void n_SetLogEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LogEnabled = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool LogEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='isLogEnabled' and count(parameter)=0]"
			[Register ("isLogEnabled", "()Z", "GetIsLogEnabledHandler")]
			get {
				const string __id = "isLogEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setLogEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setLogEnabled", "(Z)V", "GetSetLogEnabled_ZHandler")]
			set {
				const string __id = "setLogEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMarker;
#pragma warning disable 0169
		static Delegate GetGetMarkerHandler ()
		{
			if (cb_getMarker == null)
				cb_getMarker = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMarker);
			return cb_getMarker;
		}

		static IntPtr n_GetMarker (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Marker);
		}
#pragma warning restore 0169

		static Delegate cb_setMarker_Lcom_github_mikephil_charting_components_IMarker_;
#pragma warning disable 0169
		static Delegate GetSetMarker_Lcom_github_mikephil_charting_components_IMarker_Handler ()
		{
			if (cb_setMarker_Lcom_github_mikephil_charting_components_IMarker_ == null)
				cb_setMarker_Lcom_github_mikephil_charting_components_IMarker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMarker_Lcom_github_mikephil_charting_components_IMarker_);
			return cb_setMarker_Lcom_github_mikephil_charting_components_IMarker_;
		}

		static void n_SetMarker_Lcom_github_mikephil_charting_components_IMarker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_marker)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.IMarker marker = (global::MikePhil.Charting.Components.IMarker)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.IMarker> (native_marker, JniHandleOwnership.DoNotTransfer);
			__this.Marker = marker;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Components.IMarker Marker {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getMarker' and count(parameter)=0]"
			[Register ("getMarker", "()Lcom/github/mikephil/charting/components/IMarker;", "GetGetMarkerHandler")]
			get {
				const string __id = "getMarker.()Lcom/github/mikephil/charting/components/IMarker;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.IMarker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setMarker' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.IMarker']]"
			[Register ("setMarker", "(Lcom/github/mikephil/charting/components/IMarker;)V", "GetSetMarker_Lcom_github_mikephil_charting_components_IMarker_Handler")]
			set {
				const string __id = "setMarker.(Lcom/github/mikephil/charting/components/IMarker;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMarkerView;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetMarkerViewHandler ()
		{
			if (cb_getMarkerView == null)
				cb_getMarkerView = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMarkerView);
			return cb_getMarkerView;
		}

		[Obsolete]
		static IntPtr n_GetMarkerView (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MarkerView);
		}
#pragma warning restore 0169

		static Delegate cb_setMarkerView_Lcom_github_mikephil_charting_components_IMarker_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetMarkerView_Lcom_github_mikephil_charting_components_IMarker_Handler ()
		{
			if (cb_setMarkerView_Lcom_github_mikephil_charting_components_IMarker_ == null)
				cb_setMarkerView_Lcom_github_mikephil_charting_components_IMarker_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetMarkerView_Lcom_github_mikephil_charting_components_IMarker_);
			return cb_setMarkerView_Lcom_github_mikephil_charting_components_IMarker_;
		}

		[Obsolete]
		static void n_SetMarkerView_Lcom_github_mikephil_charting_components_IMarker_ (IntPtr jnienv, IntPtr native__this, IntPtr native_v)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.IMarker v = (global::MikePhil.Charting.Components.IMarker)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.IMarker> (native_v, JniHandleOwnership.DoNotTransfer);
			__this.MarkerView = v;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe global::MikePhil.Charting.Components.IMarker MarkerView {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getMarkerView' and count(parameter)=0]"
			[Register ("getMarkerView", "()Lcom/github/mikephil/charting/components/IMarker;", "GetGetMarkerViewHandler")]
			get {
				const string __id = "getMarkerView.()Lcom/github/mikephil/charting/components/IMarker;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.IMarker> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setMarkerView' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.IMarker']]"
			[Register ("setMarkerView", "(Lcom/github/mikephil/charting/components/IMarker;)V", "GetSetMarkerView_Lcom_github_mikephil_charting_components_IMarker_Handler")]
			set {
				const string __id = "setMarkerView.(Lcom/github/mikephil/charting/components/IMarker;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxHighlightDistance;
#pragma warning disable 0169
		static Delegate GetGetMaxHighlightDistanceHandler ()
		{
			if (cb_getMaxHighlightDistance == null)
				cb_getMaxHighlightDistance = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMaxHighlightDistance);
			return cb_getMaxHighlightDistance;
		}

		static float n_GetMaxHighlightDistance (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxHighlightDistance;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxHighlightDistance_F;
#pragma warning disable 0169
		static Delegate GetSetMaxHighlightDistance_FHandler ()
		{
			if (cb_setMaxHighlightDistance_F == null)
				cb_setMaxHighlightDistance_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMaxHighlightDistance_F);
			return cb_setMaxHighlightDistance_F;
		}

		static void n_SetMaxHighlightDistance_F (IntPtr jnienv, IntPtr native__this, float distDp)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxHighlightDistance = distDp;
		}
#pragma warning restore 0169

		public virtual unsafe float MaxHighlightDistance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getMaxHighlightDistance' and count(parameter)=0]"
			[Register ("getMaxHighlightDistance", "()F", "GetGetMaxHighlightDistanceHandler")]
			get {
				const string __id = "getMaxHighlightDistance.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setMaxHighlightDistance' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMaxHighlightDistance", "(F)V", "GetSetMaxHighlightDistance_FHandler")]
			set {
				const string __id = "setMaxHighlightDistance.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOnChartGestureListener;
#pragma warning disable 0169
		static Delegate GetGetOnChartGestureListenerHandler ()
		{
			if (cb_getOnChartGestureListener == null)
				cb_getOnChartGestureListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnChartGestureListener);
			return cb_getOnChartGestureListener;
		}

		static IntPtr n_GetOnChartGestureListener (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnChartGestureListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnChartGestureListener_Lcom_github_mikephil_charting_listener_OnChartGestureListener_;
#pragma warning disable 0169
		static Delegate GetSetOnChartGestureListener_Lcom_github_mikephil_charting_listener_OnChartGestureListener_Handler ()
		{
			if (cb_setOnChartGestureListener_Lcom_github_mikephil_charting_listener_OnChartGestureListener_ == null)
				cb_setOnChartGestureListener_Lcom_github_mikephil_charting_listener_OnChartGestureListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnChartGestureListener_Lcom_github_mikephil_charting_listener_OnChartGestureListener_);
			return cb_setOnChartGestureListener_Lcom_github_mikephil_charting_listener_OnChartGestureListener_;
		}

		static void n_SetOnChartGestureListener_Lcom_github_mikephil_charting_listener_OnChartGestureListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_l)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Listener.IOnChartGestureListenerSupport l = (global::MikePhil.Charting.Listener.IOnChartGestureListenerSupport)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.IOnChartGestureListenerSupport> (native_l, JniHandleOwnership.DoNotTransfer);
			__this.OnChartGestureListener = l;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Listener.IOnChartGestureListenerSupport OnChartGestureListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getOnChartGestureListener' and count(parameter)=0]"
			[Register ("getOnChartGestureListener", "()Lcom/github/mikephil/charting/listener/OnChartGestureListener;", "GetGetOnChartGestureListenerHandler")]
			get {
				const string __id = "getOnChartGestureListener.()Lcom/github/mikephil/charting/listener/OnChartGestureListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.IOnChartGestureListenerSupport> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setOnChartGestureListener' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.listener.OnChartGestureListener']]"
			[Register ("setOnChartGestureListener", "(Lcom/github/mikephil/charting/listener/OnChartGestureListener;)V", "GetSetOnChartGestureListener_Lcom_github_mikephil_charting_listener_OnChartGestureListener_Handler")]
			set {
				const string __id = "setOnChartGestureListener.(Lcom/github/mikephil/charting/listener/OnChartGestureListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOnTouchListener;
#pragma warning disable 0169
		static Delegate GetGetOnTouchListenerHandler ()
		{
			if (cb_getOnTouchListener == null)
				cb_getOnTouchListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOnTouchListener);
			return cb_getOnTouchListener;
		}

		static IntPtr n_GetOnTouchListener (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OnTouchListener);
		}
#pragma warning restore 0169

		static Delegate cb_setOnTouchListener_Lcom_github_mikephil_charting_listener_ChartTouchListener_;
#pragma warning disable 0169
		static Delegate GetSetOnTouchListener_Lcom_github_mikephil_charting_listener_ChartTouchListener_Handler ()
		{
			if (cb_setOnTouchListener_Lcom_github_mikephil_charting_listener_ChartTouchListener_ == null)
				cb_setOnTouchListener_Lcom_github_mikephil_charting_listener_ChartTouchListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnTouchListener_Lcom_github_mikephil_charting_listener_ChartTouchListener_);
			return cb_setOnTouchListener_Lcom_github_mikephil_charting_listener_ChartTouchListener_;
		}

		static void n_SetOnTouchListener_Lcom_github_mikephil_charting_listener_ChartTouchListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_l)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Listener.ChartTouchListener l = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener> (native_l, JniHandleOwnership.DoNotTransfer);
			__this.OnTouchListener = l;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Listener.ChartTouchListener OnTouchListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getOnTouchListener' and count(parameter)=0]"
			[Register ("getOnTouchListener", "()Lcom/github/mikephil/charting/listener/ChartTouchListener;", "GetGetOnTouchListenerHandler")]
			get {
				const string __id = "getOnTouchListener.()Lcom/github/mikephil/charting/listener/ChartTouchListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.ChartTouchListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setOnTouchListener' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.listener.ChartTouchListener']]"
			[Register ("setOnTouchListener", "(Lcom/github/mikephil/charting/listener/ChartTouchListener;)V", "GetSetOnTouchListener_Lcom_github_mikephil_charting_listener_ChartTouchListener_Handler")]
			set {
				const string __id = "setOnTouchListener.(Lcom/github/mikephil/charting/listener/ChartTouchListener;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRenderer;
#pragma warning disable 0169
		static Delegate GetGetRendererHandler ()
		{
			if (cb_getRenderer == null)
				cb_getRenderer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRenderer);
			return cb_getRenderer;
		}

		static IntPtr n_GetRenderer (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Renderer);
		}
#pragma warning restore 0169

		static Delegate cb_setRenderer_Lcom_github_mikephil_charting_renderer_DataRenderer_;
#pragma warning disable 0169
		static Delegate GetSetRenderer_Lcom_github_mikephil_charting_renderer_DataRenderer_Handler ()
		{
			if (cb_setRenderer_Lcom_github_mikephil_charting_renderer_DataRenderer_ == null)
				cb_setRenderer_Lcom_github_mikephil_charting_renderer_DataRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRenderer_Lcom_github_mikephil_charting_renderer_DataRenderer_);
			return cb_setRenderer_Lcom_github_mikephil_charting_renderer_DataRenderer_;
		}

		static void n_SetRenderer_Lcom_github_mikephil_charting_renderer_DataRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_renderer)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Renderer.DataRenderer renderer = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.DataRenderer> (native_renderer, JniHandleOwnership.DoNotTransfer);
			__this.Renderer = renderer;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Renderer.DataRenderer Renderer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getRenderer' and count(parameter)=0]"
			[Register ("getRenderer", "()Lcom/github/mikephil/charting/renderer/DataRenderer;", "GetGetRendererHandler")]
			get {
				const string __id = "getRenderer.()Lcom/github/mikephil/charting/renderer/DataRenderer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.DataRenderer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setRenderer' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.renderer.DataRenderer']]"
			[Register ("setRenderer", "(Lcom/github/mikephil/charting/renderer/DataRenderer;)V", "GetSetRenderer_Lcom_github_mikephil_charting_renderer_DataRenderer_Handler")]
			set {
				const string __id = "setRenderer.(Lcom/github/mikephil/charting/renderer/DataRenderer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getViewPortHandler;
#pragma warning disable 0169
		static Delegate GetGetViewPortHandlerHandler ()
		{
			if (cb_getViewPortHandler == null)
				cb_getViewPortHandler = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetViewPortHandler);
			return cb_getViewPortHandler;
		}

		static IntPtr n_GetViewPortHandler (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ViewPortHandler);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Util.ViewPortHandler ViewPortHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getViewPortHandler' and count(parameter)=0]"
			[Register ("getViewPortHandler", "()Lcom/github/mikephil/charting/utils/ViewPortHandler;", "GetGetViewPortHandlerHandler")]
			get {
				const string __id = "getViewPortHandler.()Lcom/github/mikephil/charting/utils/ViewPortHandler;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getXAxis;
#pragma warning disable 0169
		static Delegate GetGetXAxisHandler ()
		{
			if (cb_getXAxis == null)
				cb_getXAxis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetXAxis);
			return cb_getXAxis;
		}

		static IntPtr n_GetXAxis (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.XAxis);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Components.XAxis XAxis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getXAxis' and count(parameter)=0]"
			[Register ("getXAxis", "()Lcom/github/mikephil/charting/components/XAxis;", "GetGetXAxisHandler")]
			get {
				const string __id = "getXAxis.()Lcom/github/mikephil/charting/components/XAxis;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.XAxis> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getXChartMax;
#pragma warning disable 0169
		static Delegate GetGetXChartMaxHandler ()
		{
			if (cb_getXChartMax == null)
				cb_getXChartMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetXChartMax);
			return cb_getXChartMax;
		}

		static float n_GetXChartMax (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XChartMax;
		}
#pragma warning restore 0169

		public virtual unsafe float XChartMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getXChartMax' and count(parameter)=0]"
			[Register ("getXChartMax", "()F", "GetGetXChartMaxHandler")]
			get {
				const string __id = "getXChartMax.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getXChartMin;
#pragma warning disable 0169
		static Delegate GetGetXChartMinHandler ()
		{
			if (cb_getXChartMin == null)
				cb_getXChartMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetXChartMin);
			return cb_getXChartMin;
		}

		static float n_GetXChartMin (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XChartMin;
		}
#pragma warning restore 0169

		public virtual unsafe float XChartMin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getXChartMin' and count(parameter)=0]"
			[Register ("getXChartMin", "()F", "GetGetXChartMinHandler")]
			get {
				const string __id = "getXChartMin.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getXRange;
#pragma warning disable 0169
		static Delegate GetGetXRangeHandler ()
		{
			if (cb_getXRange == null)
				cb_getXRange = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetXRange);
			return cb_getXRange;
		}

		static float n_GetXRange (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XRange;
		}
#pragma warning restore 0169

		public virtual unsafe float XRange {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getXRange' and count(parameter)=0]"
			[Register ("getXRange", "()F", "GetGetXRangeHandler")]
			get {
				const string __id = "getXRange.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YMax;
		}
#pragma warning restore 0169

		public virtual unsafe float YMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getYMax' and count(parameter)=0]"
			[Register ("getYMax", "()F", "GetGetYMaxHandler")]
			get {
				const string __id = "getYMax.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YMin;
		}
#pragma warning restore 0169

		public virtual unsafe float YMin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getYMin' and count(parameter)=0]"
			[Register ("getYMin", "()F", "GetGetYMinHandler")]
			get {
				const string __id = "getYMin.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_addViewportJob_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetAddViewportJob_Ljava_lang_Runnable_Handler ()
		{
			if (cb_addViewportJob_Ljava_lang_Runnable_ == null)
				cb_addViewportJob_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddViewportJob_Ljava_lang_Runnable_);
			return cb_addViewportJob_Ljava_lang_Runnable_;
		}

		static void n_AddViewportJob_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_job)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable job = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_job, JniHandleOwnership.DoNotTransfer);
			__this.AddViewportJob (job);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='addViewportJob' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("addViewportJob", "(Ljava/lang/Runnable;)V", "GetAddViewportJob_Ljava_lang_Runnable_Handler")]
		public virtual unsafe void AddViewportJob (global::Java.Lang.IRunnable job)
		{
			const string __id = "addViewportJob.(Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((job == null) ? IntPtr.Zero : ((global::Java.Lang.Object) job).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_animateX_I;
#pragma warning disable 0169
		static Delegate GetAnimateX_IHandler ()
		{
			if (cb_animateX_I == null)
				cb_animateX_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_AnimateX_I);
			return cb_animateX_I;
		}

		static void n_AnimateX_I (IntPtr jnienv, IntPtr native__this, int durationMillis)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AnimateX (durationMillis);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='animateX' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("animateX", "(I)V", "GetAnimateX_IHandler")]
		public virtual unsafe void AnimateX (int durationMillis)
		{
			const string __id = "animateX.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (durationMillis);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_animateX_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_;
#pragma warning disable 0169
		static Delegate GetAnimateX_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_Handler ()
		{
			if (cb_animateX_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_ == null)
				cb_animateX_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_AnimateX_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_);
			return cb_animateX_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_;
		}

		static void n_AnimateX_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_ (IntPtr jnienv, IntPtr native__this, int durationMillis, IntPtr native_easing)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Animation.Easing.IEasingFunction easing = (global::MikePhil.Charting.Animation.Easing.IEasingFunction)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.Easing.IEasingFunction> (native_easing, JniHandleOwnership.DoNotTransfer);
			__this.AnimateX (durationMillis, easing);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='animateX' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.github.mikephil.charting.animation.Easing.EasingFunction']]"
		[Register ("animateX", "(ILcom/github/mikephil/charting/animation/Easing$EasingFunction;)V", "GetAnimateX_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_Handler")]
		public virtual unsafe void AnimateX (int durationMillis, global::MikePhil.Charting.Animation.Easing.IEasingFunction easing)
		{
			const string __id = "animateX.(ILcom/github/mikephil/charting/animation/Easing$EasingFunction;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (durationMillis);
				__args [1] = new JniArgumentValue ((easing == null) ? IntPtr.Zero : ((global::Java.Lang.Object) easing).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_animateX_ILcom_github_mikephil_charting_animation_Easing_EasingOption_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetAnimateX_ILcom_github_mikephil_charting_animation_Easing_EasingOption_Handler ()
		{
			if (cb_animateX_ILcom_github_mikephil_charting_animation_Easing_EasingOption_ == null)
				cb_animateX_ILcom_github_mikephil_charting_animation_Easing_EasingOption_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_AnimateX_ILcom_github_mikephil_charting_animation_Easing_EasingOption_);
			return cb_animateX_ILcom_github_mikephil_charting_animation_Easing_EasingOption_;
		}

		[Obsolete]
		static void n_AnimateX_ILcom_github_mikephil_charting_animation_Easing_EasingOption_ (IntPtr jnienv, IntPtr native__this, int durationMillis, IntPtr native_easing)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Animation.Easing.EasingOption easing = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.Easing.EasingOption> (native_easing, JniHandleOwnership.DoNotTransfer);
			__this.AnimateX (durationMillis, easing);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='animateX' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.github.mikephil.charting.animation.Easing.EasingOption']]"
		[Obsolete (@"deprecated")]
		[Register ("animateX", "(ILcom/github/mikephil/charting/animation/Easing$EasingOption;)V", "GetAnimateX_ILcom_github_mikephil_charting_animation_Easing_EasingOption_Handler")]
		public virtual unsafe void AnimateX (int durationMillis, global::MikePhil.Charting.Animation.Easing.EasingOption easing)
		{
			const string __id = "animateX.(ILcom/github/mikephil/charting/animation/Easing$EasingOption;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (durationMillis);
				__args [1] = new JniArgumentValue ((easing == null) ? IntPtr.Zero : ((global::Java.Lang.Object) easing).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_animateXY_II;
#pragma warning disable 0169
		static Delegate GetAnimateXY_IIHandler ()
		{
			if (cb_animateXY_II == null)
				cb_animateXY_II = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int>) n_AnimateXY_II);
			return cb_animateXY_II;
		}

		static void n_AnimateXY_II (IntPtr jnienv, IntPtr native__this, int durationMillisX, int durationMillisY)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AnimateXY (durationMillisX, durationMillisY);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='animateXY' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("animateXY", "(II)V", "GetAnimateXY_IIHandler")]
		public virtual unsafe void AnimateXY (int durationMillisX, int durationMillisY)
		{
			const string __id = "animateXY.(II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (durationMillisX);
				__args [1] = new JniArgumentValue (durationMillisY);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_animateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_;
#pragma warning disable 0169
		static Delegate GetAnimateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_Handler ()
		{
			if (cb_animateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_ == null)
				cb_animateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_AnimateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_);
			return cb_animateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_;
		}

		static void n_AnimateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_ (IntPtr jnienv, IntPtr native__this, int durationMillisX, int durationMillisY, IntPtr native_easing)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Animation.Easing.IEasingFunction easing = (global::MikePhil.Charting.Animation.Easing.IEasingFunction)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.Easing.IEasingFunction> (native_easing, JniHandleOwnership.DoNotTransfer);
			__this.AnimateXY (durationMillisX, durationMillisY, easing);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='animateXY' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.github.mikephil.charting.animation.Easing.EasingFunction']]"
		[Register ("animateXY", "(IILcom/github/mikephil/charting/animation/Easing$EasingFunction;)V", "GetAnimateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_Handler")]
		public virtual unsafe void AnimateXY (int durationMillisX, int durationMillisY, global::MikePhil.Charting.Animation.Easing.IEasingFunction easing)
		{
			const string __id = "animateXY.(IILcom/github/mikephil/charting/animation/Easing$EasingFunction;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (durationMillisX);
				__args [1] = new JniArgumentValue (durationMillisY);
				__args [2] = new JniArgumentValue ((easing == null) ? IntPtr.Zero : ((global::Java.Lang.Object) easing).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_animateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_Lcom_github_mikephil_charting_animation_Easing_EasingFunction_;
#pragma warning disable 0169
		static Delegate GetAnimateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_Lcom_github_mikephil_charting_animation_Easing_EasingFunction_Handler ()
		{
			if (cb_animateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_Lcom_github_mikephil_charting_animation_Easing_EasingFunction_ == null)
				cb_animateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_Lcom_github_mikephil_charting_animation_Easing_EasingFunction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_AnimateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_Lcom_github_mikephil_charting_animation_Easing_EasingFunction_);
			return cb_animateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_Lcom_github_mikephil_charting_animation_Easing_EasingFunction_;
		}

		static void n_AnimateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_Lcom_github_mikephil_charting_animation_Easing_EasingFunction_ (IntPtr jnienv, IntPtr native__this, int durationMillisX, int durationMillisY, IntPtr native_easingX, IntPtr native_easingY)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Animation.Easing.IEasingFunction easingX = (global::MikePhil.Charting.Animation.Easing.IEasingFunction)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.Easing.IEasingFunction> (native_easingX, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Animation.Easing.IEasingFunction easingY = (global::MikePhil.Charting.Animation.Easing.IEasingFunction)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.Easing.IEasingFunction> (native_easingY, JniHandleOwnership.DoNotTransfer);
			__this.AnimateXY (durationMillisX, durationMillisY, easingX, easingY);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='animateXY' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.github.mikephil.charting.animation.Easing.EasingFunction'] and parameter[4][@type='com.github.mikephil.charting.animation.Easing.EasingFunction']]"
		[Register ("animateXY", "(IILcom/github/mikephil/charting/animation/Easing$EasingFunction;Lcom/github/mikephil/charting/animation/Easing$EasingFunction;)V", "GetAnimateXY_IILcom_github_mikephil_charting_animation_Easing_EasingFunction_Lcom_github_mikephil_charting_animation_Easing_EasingFunction_Handler")]
		public virtual unsafe void AnimateXY (int durationMillisX, int durationMillisY, global::MikePhil.Charting.Animation.Easing.IEasingFunction easingX, global::MikePhil.Charting.Animation.Easing.IEasingFunction easingY)
		{
			const string __id = "animateXY.(IILcom/github/mikephil/charting/animation/Easing$EasingFunction;Lcom/github/mikephil/charting/animation/Easing$EasingFunction;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (durationMillisX);
				__args [1] = new JniArgumentValue (durationMillisY);
				__args [2] = new JniArgumentValue ((easingX == null) ? IntPtr.Zero : ((global::Java.Lang.Object) easingX).Handle);
				__args [3] = new JniArgumentValue ((easingY == null) ? IntPtr.Zero : ((global::Java.Lang.Object) easingY).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_animateXY_IILcom_github_mikephil_charting_animation_Easing_EasingOption_Lcom_github_mikephil_charting_animation_Easing_EasingOption_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetAnimateXY_IILcom_github_mikephil_charting_animation_Easing_EasingOption_Lcom_github_mikephil_charting_animation_Easing_EasingOption_Handler ()
		{
			if (cb_animateXY_IILcom_github_mikephil_charting_animation_Easing_EasingOption_Lcom_github_mikephil_charting_animation_Easing_EasingOption_ == null)
				cb_animateXY_IILcom_github_mikephil_charting_animation_Easing_EasingOption_Lcom_github_mikephil_charting_animation_Easing_EasingOption_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr, IntPtr>) n_AnimateXY_IILcom_github_mikephil_charting_animation_Easing_EasingOption_Lcom_github_mikephil_charting_animation_Easing_EasingOption_);
			return cb_animateXY_IILcom_github_mikephil_charting_animation_Easing_EasingOption_Lcom_github_mikephil_charting_animation_Easing_EasingOption_;
		}

		[Obsolete]
		static void n_AnimateXY_IILcom_github_mikephil_charting_animation_Easing_EasingOption_Lcom_github_mikephil_charting_animation_Easing_EasingOption_ (IntPtr jnienv, IntPtr native__this, int durationMillisX, int durationMillisY, IntPtr native_easingX, IntPtr native_easingY)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Animation.Easing.EasingOption easingX = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.Easing.EasingOption> (native_easingX, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Animation.Easing.EasingOption easingY = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.Easing.EasingOption> (native_easingY, JniHandleOwnership.DoNotTransfer);
			__this.AnimateXY (durationMillisX, durationMillisY, easingX, easingY);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='animateXY' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.github.mikephil.charting.animation.Easing.EasingOption'] and parameter[4][@type='com.github.mikephil.charting.animation.Easing.EasingOption']]"
		[Obsolete (@"deprecated")]
		[Register ("animateXY", "(IILcom/github/mikephil/charting/animation/Easing$EasingOption;Lcom/github/mikephil/charting/animation/Easing$EasingOption;)V", "GetAnimateXY_IILcom_github_mikephil_charting_animation_Easing_EasingOption_Lcom_github_mikephil_charting_animation_Easing_EasingOption_Handler")]
		public virtual unsafe void AnimateXY (int durationMillisX, int durationMillisY, global::MikePhil.Charting.Animation.Easing.EasingOption easingX, global::MikePhil.Charting.Animation.Easing.EasingOption easingY)
		{
			const string __id = "animateXY.(IILcom/github/mikephil/charting/animation/Easing$EasingOption;Lcom/github/mikephil/charting/animation/Easing$EasingOption;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (durationMillisX);
				__args [1] = new JniArgumentValue (durationMillisY);
				__args [2] = new JniArgumentValue ((easingX == null) ? IntPtr.Zero : ((global::Java.Lang.Object) easingX).Handle);
				__args [3] = new JniArgumentValue ((easingY == null) ? IntPtr.Zero : ((global::Java.Lang.Object) easingY).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_animateY_I;
#pragma warning disable 0169
		static Delegate GetAnimateY_IHandler ()
		{
			if (cb_animateY_I == null)
				cb_animateY_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_AnimateY_I);
			return cb_animateY_I;
		}

		static void n_AnimateY_I (IntPtr jnienv, IntPtr native__this, int durationMillis)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AnimateY (durationMillis);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='animateY' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("animateY", "(I)V", "GetAnimateY_IHandler")]
		public virtual unsafe void AnimateY (int durationMillis)
		{
			const string __id = "animateY.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (durationMillis);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_animateY_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_;
#pragma warning disable 0169
		static Delegate GetAnimateY_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_Handler ()
		{
			if (cb_animateY_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_ == null)
				cb_animateY_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_AnimateY_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_);
			return cb_animateY_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_;
		}

		static void n_AnimateY_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_ (IntPtr jnienv, IntPtr native__this, int durationMillis, IntPtr native_easing)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Animation.Easing.IEasingFunction easing = (global::MikePhil.Charting.Animation.Easing.IEasingFunction)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.Easing.IEasingFunction> (native_easing, JniHandleOwnership.DoNotTransfer);
			__this.AnimateY (durationMillis, easing);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='animateY' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.github.mikephil.charting.animation.Easing.EasingFunction']]"
		[Register ("animateY", "(ILcom/github/mikephil/charting/animation/Easing$EasingFunction;)V", "GetAnimateY_ILcom_github_mikephil_charting_animation_Easing_EasingFunction_Handler")]
		public virtual unsafe void AnimateY (int durationMillis, global::MikePhil.Charting.Animation.Easing.IEasingFunction easing)
		{
			const string __id = "animateY.(ILcom/github/mikephil/charting/animation/Easing$EasingFunction;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (durationMillis);
				__args [1] = new JniArgumentValue ((easing == null) ? IntPtr.Zero : ((global::Java.Lang.Object) easing).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_animateY_ILcom_github_mikephil_charting_animation_Easing_EasingOption_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetAnimateY_ILcom_github_mikephil_charting_animation_Easing_EasingOption_Handler ()
		{
			if (cb_animateY_ILcom_github_mikephil_charting_animation_Easing_EasingOption_ == null)
				cb_animateY_ILcom_github_mikephil_charting_animation_Easing_EasingOption_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, IntPtr>) n_AnimateY_ILcom_github_mikephil_charting_animation_Easing_EasingOption_);
			return cb_animateY_ILcom_github_mikephil_charting_animation_Easing_EasingOption_;
		}

		[Obsolete]
		static void n_AnimateY_ILcom_github_mikephil_charting_animation_Easing_EasingOption_ (IntPtr jnienv, IntPtr native__this, int durationMillis, IntPtr native_easing)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Animation.Easing.EasingOption easing = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Animation.Easing.EasingOption> (native_easing, JniHandleOwnership.DoNotTransfer);
			__this.AnimateY (durationMillis, easing);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='animateY' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.github.mikephil.charting.animation.Easing.EasingOption']]"
		[Obsolete (@"deprecated")]
		[Register ("animateY", "(ILcom/github/mikephil/charting/animation/Easing$EasingOption;)V", "GetAnimateY_ILcom_github_mikephil_charting_animation_Easing_EasingOption_Handler")]
		public virtual unsafe void AnimateY (int durationMillis, global::MikePhil.Charting.Animation.Easing.EasingOption easing)
		{
			const string __id = "animateY.(ILcom/github/mikephil/charting/animation/Easing$EasingOption;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (durationMillis);
				__args [1] = new JniArgumentValue ((easing == null) ? IntPtr.Zero : ((global::Java.Lang.Object) easing).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
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
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalcMinMax ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='calcMinMax' and count(parameter)=0]"
		[Register ("calcMinMax", "()V", "GetCalcMinMaxHandler")]
		protected abstract void CalcMinMax ();

		static Delegate cb_calculateOffsets;
#pragma warning disable 0169
		static Delegate GetCalculateOffsetsHandler ()
		{
			if (cb_calculateOffsets == null)
				cb_calculateOffsets = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CalculateOffsets);
			return cb_calculateOffsets;
		}

		static void n_CalculateOffsets (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalculateOffsets ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='calculateOffsets' and count(parameter)=0]"
		[Register ("calculateOffsets", "()V", "GetCalculateOffsetsHandler")]
		public abstract void CalculateOffsets ();

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
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_clearAllViewportJobs;
#pragma warning disable 0169
		static Delegate GetClearAllViewportJobsHandler ()
		{
			if (cb_clearAllViewportJobs == null)
				cb_clearAllViewportJobs = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearAllViewportJobs);
			return cb_clearAllViewportJobs;
		}

		static void n_ClearAllViewportJobs (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearAllViewportJobs ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='clearAllViewportJobs' and count(parameter)=0]"
		[Register ("clearAllViewportJobs", "()V", "GetClearAllViewportJobsHandler")]
		public virtual unsafe void ClearAllViewportJobs ()
		{
			const string __id = "clearAllViewportJobs.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_clearValues;
#pragma warning disable 0169
		static Delegate GetClearValuesHandler ()
		{
			if (cb_clearValues == null)
				cb_clearValues = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearValues);
			return cb_clearValues;
		}

		static void n_ClearValues (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearValues ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='clearValues' and count(parameter)=0]"
		[Register ("clearValues", "()V", "GetClearValuesHandler")]
		public virtual unsafe void ClearValues ()
		{
			const string __id = "clearValues.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_disableScroll;
#pragma warning disable 0169
		static Delegate GetDisableScrollHandler ()
		{
			if (cb_disableScroll == null)
				cb_disableScroll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_DisableScroll);
			return cb_disableScroll;
		}

		static void n_DisableScroll (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DisableScroll ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='disableScroll' and count(parameter)=0]"
		[Register ("disableScroll", "()V", "GetDisableScrollHandler")]
		public virtual unsafe void DisableScroll ()
		{
			const string __id = "disableScroll.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_drawDescription_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDrawDescription_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_drawDescription_Landroid_graphics_Canvas_ == null)
				cb_drawDescription_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DrawDescription_Landroid_graphics_Canvas_);
			return cb_drawDescription_Landroid_graphics_Canvas_;
		}

		static void n_DrawDescription_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.DrawDescription (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='drawDescription' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawDescription", "(Landroid/graphics/Canvas;)V", "GetDrawDescription_Landroid_graphics_Canvas_Handler")]
		protected virtual unsafe void DrawDescription (global::Android.Graphics.Canvas c)
		{
			const string __id = "drawDescription.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawMarkers_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDrawMarkers_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_drawMarkers_Landroid_graphics_Canvas_ == null)
				cb_drawMarkers_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DrawMarkers_Landroid_graphics_Canvas_);
			return cb_drawMarkers_Landroid_graphics_Canvas_;
		}

		static void n_DrawMarkers_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_canvas)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas canvas = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_canvas, JniHandleOwnership.DoNotTransfer);
			__this.DrawMarkers (canvas);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='drawMarkers' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawMarkers", "(Landroid/graphics/Canvas;)V", "GetDrawMarkers_Landroid_graphics_Canvas_Handler")]
		protected virtual unsafe void DrawMarkers (global::Android.Graphics.Canvas canvas)
		{
			const string __id = "drawMarkers.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_enableScroll;
#pragma warning disable 0169
		static Delegate GetEnableScrollHandler ()
		{
			if (cb_enableScroll == null)
				cb_enableScroll = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_EnableScroll);
			return cb_enableScroll;
		}

		static void n_EnableScroll (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.EnableScroll ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='enableScroll' and count(parameter)=0]"
		[Register ("enableScroll", "()V", "GetEnableScrollHandler")]
		public virtual unsafe void EnableScroll ()
		{
			const string __id = "enableScroll.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getHighlightByTouchPoint_FF;
#pragma warning disable 0169
		static Delegate GetGetHighlightByTouchPoint_FFHandler ()
		{
			if (cb_getHighlightByTouchPoint_FF == null)
				cb_getHighlightByTouchPoint_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_GetHighlightByTouchPoint_FF);
			return cb_getHighlightByTouchPoint_FF;
		}

		static IntPtr n_GetHighlightByTouchPoint_FF (IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetHighlightByTouchPoint (x, y));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getHighlightByTouchPoint' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("getHighlightByTouchPoint", "(FF)Lcom/github/mikephil/charting/highlight/Highlight;", "GetGetHighlightByTouchPoint_FFHandler")]
		public virtual unsafe global::MikePhil.Charting.Highlight.Highlight GetHighlightByTouchPoint (float x, float y)
		{
			const string __id = "getHighlightByTouchPoint.(FF)Lcom/github/mikephil/charting/highlight/Highlight;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getHighlighted;
#pragma warning disable 0169
		static Delegate GetGetHighlightedHandler ()
		{
			if (cb_getHighlighted == null)
				cb_getHighlighted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHighlighted);
			return cb_getHighlighted;
		}

		static IntPtr n_GetHighlighted (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetHighlighted ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getHighlighted' and count(parameter)=0]"
		[Register ("getHighlighted", "()[Lcom/github/mikephil/charting/highlight/Highlight;", "GetGetHighlightedHandler")]
		public virtual unsafe global::MikePhil.Charting.Highlight.Highlight[] GetHighlighted ()
		{
			const string __id = "getHighlighted.()[Lcom/github/mikephil/charting/highlight/Highlight;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::MikePhil.Charting.Highlight.Highlight[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::MikePhil.Charting.Highlight.Highlight));
			} finally {
			}
		}

		static Delegate cb_getMarkerPosition_Lcom_github_mikephil_charting_highlight_Highlight_;
#pragma warning disable 0169
		static Delegate GetGetMarkerPosition_Lcom_github_mikephil_charting_highlight_Highlight_Handler ()
		{
			if (cb_getMarkerPosition_Lcom_github_mikephil_charting_highlight_Highlight_ == null)
				cb_getMarkerPosition_Lcom_github_mikephil_charting_highlight_Highlight_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetMarkerPosition_Lcom_github_mikephil_charting_highlight_Highlight_);
			return cb_getMarkerPosition_Lcom_github_mikephil_charting_highlight_Highlight_;
		}

		static IntPtr n_GetMarkerPosition_Lcom_github_mikephil_charting_highlight_Highlight_ (IntPtr jnienv, IntPtr native__this, IntPtr native_high)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Highlight.Highlight high = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (native_high, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GetMarkerPosition (high));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getMarkerPosition' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.highlight.Highlight']]"
		[Register ("getMarkerPosition", "(Lcom/github/mikephil/charting/highlight/Highlight;)[F", "GetGetMarkerPosition_Lcom_github_mikephil_charting_highlight_Highlight_Handler")]
		protected virtual unsafe float[] GetMarkerPosition (global::MikePhil.Charting.Highlight.Highlight high)
		{
			const string __id = "getMarkerPosition.(Lcom/github/mikephil/charting/highlight/Highlight;)[F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((high == null) ? IntPtr.Zero : ((global::Java.Lang.Object) high).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getPaint_I;
#pragma warning disable 0169
		static Delegate GetGetPaint_IHandler ()
		{
			if (cb_getPaint_I == null)
				cb_getPaint_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetPaint_I);
			return cb_getPaint_I;
		}

		static IntPtr n_GetPaint_I (IntPtr jnienv, IntPtr native__this, int which)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPaint (which));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getPaint' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getPaint", "(I)Landroid/graphics/Paint;", "GetGetPaint_IHandler")]
		public virtual unsafe global::Android.Graphics.Paint GetPaint (int which)
		{
			const string __id = "getPaint.(I)Landroid/graphics/Paint;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (which);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_highlightValue_Lcom_github_mikephil_charting_highlight_Highlight_;
#pragma warning disable 0169
		static Delegate GetHighlightValue_Lcom_github_mikephil_charting_highlight_Highlight_Handler ()
		{
			if (cb_highlightValue_Lcom_github_mikephil_charting_highlight_Highlight_ == null)
				cb_highlightValue_Lcom_github_mikephil_charting_highlight_Highlight_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HighlightValue_Lcom_github_mikephil_charting_highlight_Highlight_);
			return cb_highlightValue_Lcom_github_mikephil_charting_highlight_Highlight_;
		}

		static void n_HighlightValue_Lcom_github_mikephil_charting_highlight_Highlight_ (IntPtr jnienv, IntPtr native__this, IntPtr native_highlight)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Highlight.Highlight highlight = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (native_highlight, JniHandleOwnership.DoNotTransfer);
			__this.HighlightValue (highlight);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='highlightValue' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.highlight.Highlight']]"
		[Register ("highlightValue", "(Lcom/github/mikephil/charting/highlight/Highlight;)V", "GetHighlightValue_Lcom_github_mikephil_charting_highlight_Highlight_Handler")]
		public virtual unsafe void HighlightValue (global::MikePhil.Charting.Highlight.Highlight highlight)
		{
			const string __id = "highlightValue.(Lcom/github/mikephil/charting/highlight/Highlight;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((highlight == null) ? IntPtr.Zero : ((global::Java.Lang.Object) highlight).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_highlightValue_Lcom_github_mikephil_charting_highlight_Highlight_Z;
#pragma warning disable 0169
		static Delegate GetHighlightValue_Lcom_github_mikephil_charting_highlight_Highlight_ZHandler ()
		{
			if (cb_highlightValue_Lcom_github_mikephil_charting_highlight_Highlight_Z == null)
				cb_highlightValue_Lcom_github_mikephil_charting_highlight_Highlight_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, bool>) n_HighlightValue_Lcom_github_mikephil_charting_highlight_Highlight_Z);
			return cb_highlightValue_Lcom_github_mikephil_charting_highlight_Highlight_Z;
		}

		static void n_HighlightValue_Lcom_github_mikephil_charting_highlight_Highlight_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_high, bool callListener)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Highlight.Highlight high = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (native_high, JniHandleOwnership.DoNotTransfer);
			__this.HighlightValue (high, callListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='highlightValue' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.highlight.Highlight'] and parameter[2][@type='boolean']]"
		[Register ("highlightValue", "(Lcom/github/mikephil/charting/highlight/Highlight;Z)V", "GetHighlightValue_Lcom_github_mikephil_charting_highlight_Highlight_ZHandler")]
		public virtual unsafe void HighlightValue (global::MikePhil.Charting.Highlight.Highlight high, bool callListener)
		{
			const string __id = "highlightValue.(Lcom/github/mikephil/charting/highlight/Highlight;Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((high == null) ? IntPtr.Zero : ((global::Java.Lang.Object) high).Handle);
				__args [1] = new JniArgumentValue (callListener);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_highlightValue_FFI;
#pragma warning disable 0169
		static Delegate GetHighlightValue_FFIHandler ()
		{
			if (cb_highlightValue_FFI == null)
				cb_highlightValue_FFI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, int>) n_HighlightValue_FFI);
			return cb_highlightValue_FFI;
		}

		static void n_HighlightValue_FFI (IntPtr jnienv, IntPtr native__this, float x, float y, int dataSetIndex)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighlightValue (x, y, dataSetIndex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='highlightValue' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='int']]"
		[Register ("highlightValue", "(FFI)V", "GetHighlightValue_FFIHandler")]
		public virtual unsafe void HighlightValue (float x, float y, int dataSetIndex)
		{
			const string __id = "highlightValue.(FFI)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue (dataSetIndex);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_highlightValue_FFIZ;
#pragma warning disable 0169
		static Delegate GetHighlightValue_FFIZHandler ()
		{
			if (cb_highlightValue_FFIZ == null)
				cb_highlightValue_FFIZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, int, bool>) n_HighlightValue_FFIZ);
			return cb_highlightValue_FFIZ;
		}

		static void n_HighlightValue_FFIZ (IntPtr jnienv, IntPtr native__this, float x, float y, int dataSetIndex, bool callListener)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighlightValue (x, y, dataSetIndex, callListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='highlightValue' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='int'] and parameter[4][@type='boolean']]"
		[Register ("highlightValue", "(FFIZ)V", "GetHighlightValue_FFIZHandler")]
		public virtual unsafe void HighlightValue (float x, float y, int dataSetIndex, bool callListener)
		{
			const string __id = "highlightValue.(FFIZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue (dataSetIndex);
				__args [3] = new JniArgumentValue (callListener);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_highlightValue_FI;
#pragma warning disable 0169
		static Delegate GetHighlightValue_FIHandler ()
		{
			if (cb_highlightValue_FI == null)
				cb_highlightValue_FI = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, int>) n_HighlightValue_FI);
			return cb_highlightValue_FI;
		}

		static void n_HighlightValue_FI (IntPtr jnienv, IntPtr native__this, float x, int dataSetIndex)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighlightValue (x, dataSetIndex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='highlightValue' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='int']]"
		[Register ("highlightValue", "(FI)V", "GetHighlightValue_FIHandler")]
		public virtual unsafe void HighlightValue (float x, int dataSetIndex)
		{
			const string __id = "highlightValue.(FI)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (dataSetIndex);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_highlightValue_FIZ;
#pragma warning disable 0169
		static Delegate GetHighlightValue_FIZHandler ()
		{
			if (cb_highlightValue_FIZ == null)
				cb_highlightValue_FIZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, int, bool>) n_HighlightValue_FIZ);
			return cb_highlightValue_FIZ;
		}

		static void n_HighlightValue_FIZ (IntPtr jnienv, IntPtr native__this, float x, int dataSetIndex, bool callListener)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighlightValue (x, dataSetIndex, callListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='highlightValue' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("highlightValue", "(FIZ)V", "GetHighlightValue_FIZHandler")]
		public virtual unsafe void HighlightValue (float x, int dataSetIndex, bool callListener)
		{
			const string __id = "highlightValue.(FIZ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (dataSetIndex);
				__args [2] = new JniArgumentValue (callListener);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_highlightValues_arrayLcom_github_mikephil_charting_highlight_Highlight_;
#pragma warning disable 0169
		static Delegate GetHighlightValues_arrayLcom_github_mikephil_charting_highlight_Highlight_Handler ()
		{
			if (cb_highlightValues_arrayLcom_github_mikephil_charting_highlight_Highlight_ == null)
				cb_highlightValues_arrayLcom_github_mikephil_charting_highlight_Highlight_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_HighlightValues_arrayLcom_github_mikephil_charting_highlight_Highlight_);
			return cb_highlightValues_arrayLcom_github_mikephil_charting_highlight_Highlight_;
		}

		static void n_HighlightValues_arrayLcom_github_mikephil_charting_highlight_Highlight_ (IntPtr jnienv, IntPtr native__this, IntPtr native_highs)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Highlight.Highlight[] highs = (global::MikePhil.Charting.Highlight.Highlight[]) JNIEnv.GetArray (native_highs, JniHandleOwnership.DoNotTransfer, typeof (global::MikePhil.Charting.Highlight.Highlight));
			__this.HighlightValues (highs);
			if (highs != null)
				JNIEnv.CopyArray (highs, native_highs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='highlightValues' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.highlight.Highlight[]']]"
		[Register ("highlightValues", "([Lcom/github/mikephil/charting/highlight/Highlight;)V", "GetHighlightValues_arrayLcom_github_mikephil_charting_highlight_Highlight_Handler")]
		public virtual unsafe void HighlightValues (global::MikePhil.Charting.Highlight.Highlight[] highs)
		{
			const string __id = "highlightValues.([Lcom/github/mikephil/charting/highlight/Highlight;)V";
			IntPtr native_highs = JNIEnv.NewArray (highs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_highs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (highs != null) {
					JNIEnv.CopyArray (native_highs, highs);
					JNIEnv.DeleteLocalRef (native_highs);
				}
			}
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		protected virtual unsafe void Init ()
		{
			const string __id = "init.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_notifyDataSetChanged;
#pragma warning disable 0169
		static Delegate GetNotifyDataSetChangedHandler ()
		{
			if (cb_notifyDataSetChanged == null)
				cb_notifyDataSetChanged = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NotifyDataSetChanged);
			return cb_notifyDataSetChanged;
		}

		static void n_NotifyDataSetChanged (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDataSetChanged ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='notifyDataSetChanged' and count(parameter)=0]"
		[Register ("notifyDataSetChanged", "()V", "GetNotifyDataSetChangedHandler")]
		public abstract void NotifyDataSetChanged ();

		static Delegate cb_onLayout_ZIIII;
#pragma warning disable 0169
		static Delegate GetOnLayout_ZIIIIHandler ()
		{
			if (cb_onLayout_ZIIII == null)
				cb_onLayout_ZIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool, int, int, int, int>) n_OnLayout_ZIIII);
			return cb_onLayout_ZIIII;
		}

		static void n_OnLayout_ZIIII (IntPtr jnienv, IntPtr native__this, bool changed, int left, int top, int right, int bottom)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnLayout (changed, left, top, right, bottom);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='onLayout' and count(parameter)=5 and parameter[1][@type='boolean'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("onLayout", "(ZIIII)V", "GetOnLayout_ZIIIIHandler")]
		protected override unsafe void OnLayout (bool changed, int left, int top, int right, int bottom)
		{
			const string __id = "onLayout.(ZIIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (changed);
				__args [1] = new JniArgumentValue (left);
				__args [2] = new JniArgumentValue (top);
				__args [3] = new JniArgumentValue (right);
				__args [4] = new JniArgumentValue (bottom);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_removeViewportJob_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetRemoveViewportJob_Ljava_lang_Runnable_Handler ()
		{
			if (cb_removeViewportJob_Ljava_lang_Runnable_ == null)
				cb_removeViewportJob_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveViewportJob_Ljava_lang_Runnable_);
			return cb_removeViewportJob_Ljava_lang_Runnable_;
		}

		static void n_RemoveViewportJob_Ljava_lang_Runnable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_job)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable job = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable> (native_job, JniHandleOwnership.DoNotTransfer);
			__this.RemoveViewportJob (job);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='removeViewportJob' and count(parameter)=1 and parameter[1][@type='java.lang.Runnable']]"
		[Register ("removeViewportJob", "(Ljava/lang/Runnable;)V", "GetRemoveViewportJob_Ljava_lang_Runnable_Handler")]
		public virtual unsafe void RemoveViewportJob (global::Java.Lang.IRunnable job)
		{
			const string __id = "removeViewportJob.(Ljava/lang/Runnable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((job == null) ? IntPtr.Zero : ((global::Java.Lang.Object) job).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_saveToGallery_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaveToGallery_Ljava_lang_String_Handler ()
		{
			if (cb_saveToGallery_Ljava_lang_String_ == null)
				cb_saveToGallery_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SaveToGallery_Ljava_lang_String_);
			return cb_saveToGallery_Ljava_lang_String_;
		}

		static bool n_SaveToGallery_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_fileName)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string fileName = JNIEnv.GetString (native_fileName, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SaveToGallery (fileName);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='saveToGallery' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("saveToGallery", "(Ljava/lang/String;)Z", "GetSaveToGallery_Ljava_lang_String_Handler")]
		public virtual unsafe bool SaveToGallery (string fileName)
		{
			const string __id = "saveToGallery.(Ljava/lang/String;)Z";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_fileName);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
			}
		}

		static Delegate cb_saveToGallery_Ljava_lang_String_I;
#pragma warning disable 0169
		static Delegate GetSaveToGallery_Ljava_lang_String_IHandler ()
		{
			if (cb_saveToGallery_Ljava_lang_String_I == null)
				cb_saveToGallery_Ljava_lang_String_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, bool>) n_SaveToGallery_Ljava_lang_String_I);
			return cb_saveToGallery_Ljava_lang_String_I;
		}

		static bool n_SaveToGallery_Ljava_lang_String_I (IntPtr jnienv, IntPtr native__this, IntPtr native_fileName, int quality)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string fileName = JNIEnv.GetString (native_fileName, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SaveToGallery (fileName, quality);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='saveToGallery' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='int']]"
		[Register ("saveToGallery", "(Ljava/lang/String;I)Z", "GetSaveToGallery_Ljava_lang_String_IHandler")]
		public virtual unsafe bool SaveToGallery (string fileName, int quality)
		{
			const string __id = "saveToGallery.(Ljava/lang/String;I)Z";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_fileName);
				__args [1] = new JniArgumentValue (quality);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
			}
		}

		static Delegate cb_saveToGallery_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_graphics_Bitmap_CompressFormat_I;
#pragma warning disable 0169
		static Delegate GetSaveToGallery_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_graphics_Bitmap_CompressFormat_IHandler ()
		{
			if (cb_saveToGallery_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_graphics_Bitmap_CompressFormat_I == null)
				cb_saveToGallery_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_graphics_Bitmap_CompressFormat_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, bool>) n_SaveToGallery_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_graphics_Bitmap_CompressFormat_I);
			return cb_saveToGallery_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_graphics_Bitmap_CompressFormat_I;
		}

		static bool n_SaveToGallery_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_graphics_Bitmap_CompressFormat_I (IntPtr jnienv, IntPtr native__this, IntPtr native_fileName, IntPtr native_subFolderPath, IntPtr native_fileDescription, IntPtr native_format, int quality)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string fileName = JNIEnv.GetString (native_fileName, JniHandleOwnership.DoNotTransfer);
			string subFolderPath = JNIEnv.GetString (native_subFolderPath, JniHandleOwnership.DoNotTransfer);
			string fileDescription = JNIEnv.GetString (native_fileDescription, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Bitmap.CompressFormat format = global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap.CompressFormat> (native_format, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SaveToGallery (fileName, subFolderPath, fileDescription, format, quality);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='saveToGallery' and count(parameter)=5 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='android.graphics.Bitmap.CompressFormat'] and parameter[5][@type='int']]"
		[Register ("saveToGallery", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/graphics/Bitmap$CompressFormat;I)Z", "GetSaveToGallery_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_Landroid_graphics_Bitmap_CompressFormat_IHandler")]
		public virtual unsafe bool SaveToGallery (string fileName, string subFolderPath, string fileDescription, global::Android.Graphics.Bitmap.CompressFormat format, int quality)
		{
			const string __id = "saveToGallery.(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Landroid/graphics/Bitmap$CompressFormat;I)Z";
			IntPtr native_fileName = JNIEnv.NewString (fileName);
			IntPtr native_subFolderPath = JNIEnv.NewString (subFolderPath);
			IntPtr native_fileDescription = JNIEnv.NewString (fileDescription);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (native_fileName);
				__args [1] = new JniArgumentValue (native_subFolderPath);
				__args [2] = new JniArgumentValue (native_fileDescription);
				__args [3] = new JniArgumentValue ((format == null) ? IntPtr.Zero : ((global::Java.Lang.Object) format).Handle);
				__args [4] = new JniArgumentValue (quality);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_fileName);
				JNIEnv.DeleteLocalRef (native_subFolderPath);
				JNIEnv.DeleteLocalRef (native_fileDescription);
			}
		}

		static Delegate cb_saveToPath_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSaveToPath_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_saveToPath_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_saveToPath_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_SaveToPath_Ljava_lang_String_Ljava_lang_String_);
			return cb_saveToPath_Ljava_lang_String_Ljava_lang_String_;
		}

		static bool n_SaveToPath_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_title, IntPtr native_pathOnSD)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string title = JNIEnv.GetString (native_title, JniHandleOwnership.DoNotTransfer);
			string pathOnSD = JNIEnv.GetString (native_pathOnSD, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SaveToPath (title, pathOnSD);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='saveToPath' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("saveToPath", "(Ljava/lang/String;Ljava/lang/String;)Z", "GetSaveToPath_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe bool SaveToPath (string title, string pathOnSD)
		{
			const string __id = "saveToPath.(Ljava/lang/String;Ljava/lang/String;)Z";
			IntPtr native_title = JNIEnv.NewString (title);
			IntPtr native_pathOnSD = JNIEnv.NewString (pathOnSD);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_title);
				__args [1] = new JniArgumentValue (native_pathOnSD);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_title);
				JNIEnv.DeleteLocalRef (native_pathOnSD);
			}
		}

		static Delegate cb_setDrawMarkerViews_Z;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetDrawMarkerViews_ZHandler ()
		{
			if (cb_setDrawMarkerViews_Z == null)
				cb_setDrawMarkerViews_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawMarkerViews_Z);
			return cb_setDrawMarkerViews_Z;
		}

		[Obsolete]
		static void n_SetDrawMarkerViews_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawMarkerViews (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setDrawMarkerViews' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("setDrawMarkerViews", "(Z)V", "GetSetDrawMarkerViews_ZHandler")]
		public virtual unsafe void SetDrawMarkerViews (bool enabled)
		{
			const string __id = "setDrawMarkerViews.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawMarkers_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawMarkers_ZHandler ()
		{
			if (cb_setDrawMarkers_Z == null)
				cb_setDrawMarkers_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawMarkers_Z);
			return cb_setDrawMarkers_Z;
		}

		static void n_SetDrawMarkers_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawMarkers (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setDrawMarkers' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawMarkers", "(Z)V", "GetSetDrawMarkers_ZHandler")]
		public virtual unsafe void SetDrawMarkers (bool enabled)
		{
			const string __id = "setDrawMarkers.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setExtraOffsets_FFFF;
#pragma warning disable 0169
		static Delegate GetSetExtraOffsets_FFFFHandler ()
		{
			if (cb_setExtraOffsets_FFFF == null)
				cb_setExtraOffsets_FFFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float>) n_SetExtraOffsets_FFFF);
			return cb_setExtraOffsets_FFFF;
		}

		static void n_SetExtraOffsets_FFFF (IntPtr jnienv, IntPtr native__this, float left, float top, float right, float bottom)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetExtraOffsets (left, top, right, bottom);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setExtraOffsets' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("setExtraOffsets", "(FFFF)V", "GetSetExtraOffsets_FFFFHandler")]
		public virtual unsafe void SetExtraOffsets (float left, float top, float right, float bottom)
		{
			const string __id = "setExtraOffsets.(FFFF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (top);
				__args [2] = new JniArgumentValue (right);
				__args [3] = new JniArgumentValue (bottom);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setHardwareAccelerationEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetHardwareAccelerationEnabled_ZHandler ()
		{
			if (cb_setHardwareAccelerationEnabled_Z == null)
				cb_setHardwareAccelerationEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHardwareAccelerationEnabled_Z);
			return cb_setHardwareAccelerationEnabled_Z;
		}

		static void n_SetHardwareAccelerationEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHardwareAccelerationEnabled (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setHardwareAccelerationEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setHardwareAccelerationEnabled", "(Z)V", "GetSetHardwareAccelerationEnabled_ZHandler")]
		public virtual unsafe void SetHardwareAccelerationEnabled (bool enabled)
		{
			const string __id = "setHardwareAccelerationEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setHighlighter_Lcom_github_mikephil_charting_highlight_ChartHighlighter_;
#pragma warning disable 0169
		static Delegate GetSetHighlighter_Lcom_github_mikephil_charting_highlight_ChartHighlighter_Handler ()
		{
			if (cb_setHighlighter_Lcom_github_mikephil_charting_highlight_ChartHighlighter_ == null)
				cb_setHighlighter_Lcom_github_mikephil_charting_highlight_ChartHighlighter_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHighlighter_Lcom_github_mikephil_charting_highlight_ChartHighlighter_);
			return cb_setHighlighter_Lcom_github_mikephil_charting_highlight_ChartHighlighter_;
		}

		static void n_SetHighlighter_Lcom_github_mikephil_charting_highlight_ChartHighlighter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_highlighter)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Highlight.ChartHighlighter highlighter = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.ChartHighlighter> (native_highlighter, JniHandleOwnership.DoNotTransfer);
			__this.SetHighlighter (highlighter);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setHighlighter' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.highlight.ChartHighlighter']]"
		[Register ("setHighlighter", "(Lcom/github/mikephil/charting/highlight/ChartHighlighter;)V", "GetSetHighlighter_Lcom_github_mikephil_charting_highlight_ChartHighlighter_Handler")]
		public virtual unsafe void SetHighlighter (global::MikePhil.Charting.Highlight.ChartHighlighter highlighter)
		{
			const string __id = "setHighlighter.(Lcom/github/mikephil/charting/highlight/ChartHighlighter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((highlighter == null) ? IntPtr.Zero : ((global::Java.Lang.Object) highlighter).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setLastHighlighted_arrayLcom_github_mikephil_charting_highlight_Highlight_;
#pragma warning disable 0169
		static Delegate GetSetLastHighlighted_arrayLcom_github_mikephil_charting_highlight_Highlight_Handler ()
		{
			if (cb_setLastHighlighted_arrayLcom_github_mikephil_charting_highlight_Highlight_ == null)
				cb_setLastHighlighted_arrayLcom_github_mikephil_charting_highlight_Highlight_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetLastHighlighted_arrayLcom_github_mikephil_charting_highlight_Highlight_);
			return cb_setLastHighlighted_arrayLcom_github_mikephil_charting_highlight_Highlight_;
		}

		static void n_SetLastHighlighted_arrayLcom_github_mikephil_charting_highlight_Highlight_ (IntPtr jnienv, IntPtr native__this, IntPtr native_highs)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Highlight.Highlight[] highs = (global::MikePhil.Charting.Highlight.Highlight[]) JNIEnv.GetArray (native_highs, JniHandleOwnership.DoNotTransfer, typeof (global::MikePhil.Charting.Highlight.Highlight));
			__this.SetLastHighlighted (highs);
			if (highs != null)
				JNIEnv.CopyArray (highs, native_highs);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setLastHighlighted' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.highlight.Highlight[]']]"
		[Register ("setLastHighlighted", "([Lcom/github/mikephil/charting/highlight/Highlight;)V", "GetSetLastHighlighted_arrayLcom_github_mikephil_charting_highlight_Highlight_Handler")]
		protected virtual unsafe void SetLastHighlighted (global::MikePhil.Charting.Highlight.Highlight[] highs)
		{
			const string __id = "setLastHighlighted.([Lcom/github/mikephil/charting/highlight/Highlight;)V";
			IntPtr native_highs = JNIEnv.NewArray (highs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_highs);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (highs != null) {
					JNIEnv.CopyArray (native_highs, highs);
					JNIEnv.DeleteLocalRef (native_highs);
				}
			}
		}

		static Delegate cb_setNoDataText_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetNoDataText_Ljava_lang_String_Handler ()
		{
			if (cb_setNoDataText_Ljava_lang_String_ == null)
				cb_setNoDataText_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNoDataText_Ljava_lang_String_);
			return cb_setNoDataText_Ljava_lang_String_;
		}

		static void n_SetNoDataText_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string text = JNIEnv.GetString (native_text, JniHandleOwnership.DoNotTransfer);
			__this.SetNoDataText (text);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setNoDataText' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("setNoDataText", "(Ljava/lang/String;)V", "GetSetNoDataText_Ljava_lang_String_Handler")]
		public virtual unsafe void SetNoDataText (string text)
		{
			const string __id = "setNoDataText.(Ljava/lang/String;)V";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_text);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		static Delegate cb_setNoDataTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetNoDataTextColor_IHandler ()
		{
			if (cb_setNoDataTextColor_I == null)
				cb_setNoDataTextColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetNoDataTextColor_I);
			return cb_setNoDataTextColor_I;
		}

		static void n_SetNoDataTextColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNoDataTextColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setNoDataTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setNoDataTextColor", "(I)V", "GetSetNoDataTextColor_IHandler")]
		public virtual unsafe void SetNoDataTextColor (int color)
		{
			const string __id = "setNoDataTextColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setNoDataTextTypeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetSetNoDataTextTypeface_Landroid_graphics_Typeface_Handler ()
		{
			if (cb_setNoDataTextTypeface_Landroid_graphics_Typeface_ == null)
				cb_setNoDataTextTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetNoDataTextTypeface_Landroid_graphics_Typeface_);
			return cb_setNoDataTextTypeface_Landroid_graphics_Typeface_;
		}

		static void n_SetNoDataTextTypeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tf)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Typeface tf = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_tf, JniHandleOwnership.DoNotTransfer);
			__this.SetNoDataTextTypeface (tf);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setNoDataTextTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
		[Register ("setNoDataTextTypeface", "(Landroid/graphics/Typeface;)V", "GetSetNoDataTextTypeface_Landroid_graphics_Typeface_Handler")]
		public virtual unsafe void SetNoDataTextTypeface (global::Android.Graphics.Typeface tf)
		{
			const string __id = "setNoDataTextTypeface.(Landroid/graphics/Typeface;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tf).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnChartValueSelectedListener_Lcom_github_mikephil_charting_listener_OnChartValueSelectedListener_;
#pragma warning disable 0169
		static Delegate GetSetOnChartValueSelectedListener_Lcom_github_mikephil_charting_listener_OnChartValueSelectedListener_Handler ()
		{
			if (cb_setOnChartValueSelectedListener_Lcom_github_mikephil_charting_listener_OnChartValueSelectedListener_ == null)
				cb_setOnChartValueSelectedListener_Lcom_github_mikephil_charting_listener_OnChartValueSelectedListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnChartValueSelectedListener_Lcom_github_mikephil_charting_listener_OnChartValueSelectedListener_);
			return cb_setOnChartValueSelectedListener_Lcom_github_mikephil_charting_listener_OnChartValueSelectedListener_;
		}

		static void n_SetOnChartValueSelectedListener_Lcom_github_mikephil_charting_listener_OnChartValueSelectedListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_l)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Listener.IOnChartValueSelectedListenerSupport l = (global::MikePhil.Charting.Listener.IOnChartValueSelectedListenerSupport)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.IOnChartValueSelectedListenerSupport> (native_l, JniHandleOwnership.DoNotTransfer);
			__this.SetOnChartValueSelectedListener (l);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setOnChartValueSelectedListener' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.listener.OnChartValueSelectedListener']]"
		[Register ("setOnChartValueSelectedListener", "(Lcom/github/mikephil/charting/listener/OnChartValueSelectedListener;)V", "GetSetOnChartValueSelectedListener_Lcom_github_mikephil_charting_listener_OnChartValueSelectedListener_Handler")]
		public virtual unsafe void SetOnChartValueSelectedListener (global::MikePhil.Charting.Listener.IOnChartValueSelectedListenerSupport l)
		{
			const string __id = "setOnChartValueSelectedListener.(Lcom/github/mikephil/charting/listener/OnChartValueSelectedListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((l == null) ? IntPtr.Zero : ((global::Java.Lang.Object) l).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPaint_Landroid_graphics_Paint_I;
#pragma warning disable 0169
		static Delegate GetSetPaint_Landroid_graphics_Paint_IHandler ()
		{
			if (cb_setPaint_Landroid_graphics_Paint_I == null)
				cb_setPaint_Landroid_graphics_Paint_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_SetPaint_Landroid_graphics_Paint_I);
			return cb_setPaint_Landroid_graphics_Paint_I;
		}

		static void n_SetPaint_Landroid_graphics_Paint_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p, int which)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p, JniHandleOwnership.DoNotTransfer);
			__this.SetPaint (p, which);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setPaint' and count(parameter)=2 and parameter[1][@type='android.graphics.Paint'] and parameter[2][@type='int']]"
		[Register ("setPaint", "(Landroid/graphics/Paint;I)V", "GetSetPaint_Landroid_graphics_Paint_IHandler")]
		public virtual unsafe void SetPaint (global::Android.Graphics.Paint p, int which)
		{
			const string __id = "setPaint.(Landroid/graphics/Paint;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				__args [1] = new JniArgumentValue (which);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTouchEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetTouchEnabled_ZHandler ()
		{
			if (cb_setTouchEnabled_Z == null)
				cb_setTouchEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetTouchEnabled_Z);
			return cb_setTouchEnabled_Z;
		}

		static void n_SetTouchEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTouchEnabled (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setTouchEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setTouchEnabled", "(Z)V", "GetSetTouchEnabled_ZHandler")]
		public virtual unsafe void SetTouchEnabled (bool enabled)
		{
			const string __id = "setTouchEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setUnbindEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetUnbindEnabled_ZHandler ()
		{
			if (cb_setUnbindEnabled_Z == null)
				cb_setUnbindEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUnbindEnabled_Z);
			return cb_setUnbindEnabled_Z;
		}

		static void n_SetUnbindEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUnbindEnabled (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setUnbindEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUnbindEnabled", "(Z)V", "GetSetUnbindEnabled_ZHandler")]
		public virtual unsafe void SetUnbindEnabled (bool enabled)
		{
			const string __id = "setUnbindEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setupDefaultFormatter_FF;
#pragma warning disable 0169
		static Delegate GetSetupDefaultFormatter_FFHandler ()
		{
			if (cb_setupDefaultFormatter_FF == null)
				cb_setupDefaultFormatter_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_SetupDefaultFormatter_FF);
			return cb_setupDefaultFormatter_FF;
		}

		static void n_SetupDefaultFormatter_FF (IntPtr jnienv, IntPtr native__this, float min, float max)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetupDefaultFormatter (min, max);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='setupDefaultFormatter' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setupDefaultFormatter", "(FF)V", "GetSetupDefaultFormatter_FFHandler")]
		protected virtual unsafe void SetupDefaultFormatter (float min, float max)
		{
			const string __id = "setupDefaultFormatter.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (min);
				__args [1] = new JniArgumentValue (max);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_valuesToHighlight;
#pragma warning disable 0169
		static Delegate GetValuesToHighlightHandler ()
		{
			if (cb_valuesToHighlight == null)
				cb_valuesToHighlight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_ValuesToHighlight);
			return cb_valuesToHighlight;
		}

		static bool n_ValuesToHighlight (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ValuesToHighlight ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='valuesToHighlight' and count(parameter)=0]"
		[Register ("valuesToHighlight", "()Z", "GetValuesToHighlightHandler")]
		public virtual unsafe bool ValuesToHighlight ()
		{
			const string __id = "valuesToHighlight.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getMaxVisibleCount;
#pragma warning disable 0169
		static Delegate GetGetMaxVisibleCountHandler ()
		{
			if (cb_getMaxVisibleCount == null)
				cb_getMaxVisibleCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetMaxVisibleCount);
			return cb_getMaxVisibleCount;
		}

		static int n_GetMaxVisibleCount (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxVisibleCount;
		}
#pragma warning restore 0169

		public abstract int MaxVisibleCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getMaxVisibleCount' and count(parameter)=0]"
			[Register ("getMaxVisibleCount", "()I", "GetGetMaxVisibleCountHandler")] get;
		}

		static Delegate cb_getYChartMax;
#pragma warning disable 0169
		static Delegate GetGetYChartMaxHandler ()
		{
			if (cb_getYChartMax == null)
				cb_getYChartMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetYChartMax);
			return cb_getYChartMax;
		}

		static float n_GetYChartMax (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YChartMax;
		}
#pragma warning restore 0169

		public abstract float YChartMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getYChartMax' and count(parameter)=0]"
			[Register ("getYChartMax", "()F", "GetGetYChartMaxHandler")] get;
		}

		static Delegate cb_getYChartMin;
#pragma warning disable 0169
		static Delegate GetGetYChartMinHandler ()
		{
			if (cb_getYChartMin == null)
				cb_getYChartMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetYChartMin);
			return cb_getYChartMin;
		}

		static float n_GetYChartMin (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.Chart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.Chart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YChartMin;
		}
#pragma warning restore 0169

		public abstract float YChartMin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getYChartMin' and count(parameter)=0]"
			[Register ("getYChartMin", "()F", "GetGetYChartMinHandler")] get;
		}

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/charts/Chart", DoNotGenerateAcw=true)]
	internal partial class ChartInvoker : Chart {

		public ChartInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/charts/Chart", typeof (ChartInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='calcMinMax' and count(parameter)=0]"
		[Register ("calcMinMax", "()V", "GetCalcMinMaxHandler")]
		protected override unsafe void CalcMinMax ()
		{
			const string __id = "calcMinMax.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='calculateOffsets' and count(parameter)=0]"
		[Register ("calculateOffsets", "()V", "GetCalculateOffsetsHandler")]
		public override unsafe void CalculateOffsets ()
		{
			const string __id = "calculateOffsets.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='notifyDataSetChanged' and count(parameter)=0]"
		[Register ("notifyDataSetChanged", "()V", "GetNotifyDataSetChangedHandler")]
		public override unsafe void NotifyDataSetChanged ()
		{
			const string __id = "notifyDataSetChanged.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

		public override unsafe int MaxVisibleCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getMaxVisibleCount' and count(parameter)=0]"
			[Register ("getMaxVisibleCount", "()I", "GetGetMaxVisibleCountHandler")]
			get {
				const string __id = "getMaxVisibleCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe float YChartMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getYChartMax' and count(parameter)=0]"
			[Register ("getYChartMax", "()F", "GetGetYChartMaxHandler")]
			get {
				const string __id = "getYChartMax.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public override unsafe float YChartMin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='Chart']/method[@name='getYChartMin' and count(parameter)=0]"
			[Register ("getYChartMin", "()F", "GetGetYChartMinHandler")]
			get {
				const string __id = "getYChartMin.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}

}
