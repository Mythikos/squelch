using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Charts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/charts/BarLineChartBase", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.github.mikephil.charting.data.BarLineScatterCandleBubbleData<? extends com.github.mikephil.charting.interfaces.datasets.IBarLineScatterCandleBubbleDataSet<? extends com.github.mikephil.charting.data.Entry>>"})]
	public abstract partial class BarLineChartBase : global::MikePhil.Charting.Charts.Chart, global::MikePhil.Charting.Interfaces.Dataprovider.IBarLineScatterCandleBubbleDataProvider {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='mAutoScaleMinMaxEnabled']"
		[Register ("mAutoScaleMinMaxEnabled")]
		protected bool MAutoScaleMinMaxEnabled {
			get {
				const string __id = "mAutoScaleMinMaxEnabled.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mAutoScaleMinMaxEnabled.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='mAxisLeft']"
		[Register ("mAxisLeft")]
		protected global::MikePhil.Charting.Components.YAxis MAxisLeft {
			get {
				const string __id = "mAxisLeft.Lcom/github/mikephil/charting/components/YAxis;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAxisLeft.Lcom/github/mikephil/charting/components/YAxis;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='mAxisRendererLeft']"
		[Register ("mAxisRendererLeft")]
		protected global::MikePhil.Charting.Renderer.YAxisRenderer MAxisRendererLeft {
			get {
				const string __id = "mAxisRendererLeft.Lcom/github/mikephil/charting/renderer/YAxisRenderer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.YAxisRenderer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAxisRendererLeft.Lcom/github/mikephil/charting/renderer/YAxisRenderer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='mAxisRendererRight']"
		[Register ("mAxisRendererRight")]
		protected global::MikePhil.Charting.Renderer.YAxisRenderer MAxisRendererRight {
			get {
				const string __id = "mAxisRendererRight.Lcom/github/mikephil/charting/renderer/YAxisRenderer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.YAxisRenderer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAxisRendererRight.Lcom/github/mikephil/charting/renderer/YAxisRenderer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='mAxisRight']"
		[Register ("mAxisRight")]
		protected global::MikePhil.Charting.Components.YAxis MAxisRight {
			get {
				const string __id = "mAxisRight.Lcom/github/mikephil/charting/components/YAxis;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mAxisRight.Lcom/github/mikephil/charting/components/YAxis;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='mBorderPaint']"
		[Register ("mBorderPaint")]
		protected global::Android.Graphics.Paint MBorderPaint {
			get {
				const string __id = "mBorderPaint.Landroid/graphics/Paint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mBorderPaint.Landroid/graphics/Paint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='mClipValuesToContent']"
		[Register ("mClipValuesToContent")]
		protected bool MClipValuesToContent {
			get {
				const string __id = "mClipValuesToContent.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mClipValuesToContent.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='mDoubleTapToZoomEnabled']"
		[Register ("mDoubleTapToZoomEnabled")]
		protected bool MDoubleTapToZoomEnabled {
			get {
				const string __id = "mDoubleTapToZoomEnabled.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mDoubleTapToZoomEnabled.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='mDrawBorders']"
		[Register ("mDrawBorders")]
		protected bool MDrawBorders {
			get {
				const string __id = "mDrawBorders.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mDrawBorders.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='mDrawGridBackground']"
		[Register ("mDrawGridBackground")]
		protected bool MDrawGridBackground {
			get {
				const string __id = "mDrawGridBackground.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mDrawGridBackground.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='mDrawListener']"
		[Register ("mDrawListener")]
		protected global::MikePhil.Charting.Listener.IOnDrawListenerSupport MDrawListener {
			get {
				const string __id = "mDrawListener.Lcom/github/mikephil/charting/listener/OnDrawListener;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.IOnDrawListenerSupport> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDrawListener.Lcom/github/mikephil/charting/listener/OnDrawListener;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='mFitScreenMatrixBuffer']"
		[Register ("mFitScreenMatrixBuffer")]
		protected global::Android.Graphics.Matrix MFitScreenMatrixBuffer {
			get {
				const string __id = "mFitScreenMatrixBuffer.Landroid/graphics/Matrix;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mFitScreenMatrixBuffer.Landroid/graphics/Matrix;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='mGetPositionBuffer']"
		[Register ("mGetPositionBuffer")]
		protected IList<float> MGetPositionBuffer {
			get {
				const string __id = "mGetPositionBuffer.[F";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<float>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mGetPositionBuffer.[F";

				IntPtr native_value = global::Android.Runtime.JavaArray<float>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='mGridBackgroundPaint']"
		[Register ("mGridBackgroundPaint")]
		protected global::Android.Graphics.Paint MGridBackgroundPaint {
			get {
				const string __id = "mGridBackgroundPaint.Landroid/graphics/Paint;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mGridBackgroundPaint.Landroid/graphics/Paint;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='mHighlightPerDragEnabled']"
		[Register ("mHighlightPerDragEnabled")]
		protected bool MHighlightPerDragEnabled {
			get {
				const string __id = "mHighlightPerDragEnabled.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mHighlightPerDragEnabled.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='mKeepPositionOnRotation']"
		[Register ("mKeepPositionOnRotation")]
		protected bool MKeepPositionOnRotation {
			get {
				const string __id = "mKeepPositionOnRotation.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mKeepPositionOnRotation.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='mLeftAxisTransformer']"
		[Register ("mLeftAxisTransformer")]
		protected global::MikePhil.Charting.Util.Transformer MLeftAxisTransformer {
			get {
				const string __id = "mLeftAxisTransformer.Lcom/github/mikephil/charting/utils/Transformer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mLeftAxisTransformer.Lcom/github/mikephil/charting/utils/Transformer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='mMaxVisibleCount']"
		[Register ("mMaxVisibleCount")]
		protected int MMaxVisibleCount {
			get {
				const string __id = "mMaxVisibleCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mMaxVisibleCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='mMinOffset']"
		[Register ("mMinOffset")]
		protected float MMinOffset {
			get {
				const string __id = "mMinOffset.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mMinOffset.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='mOnSizeChangedBuffer']"
		[Register ("mOnSizeChangedBuffer")]
		protected IList<float> MOnSizeChangedBuffer {
			get {
				const string __id = "mOnSizeChangedBuffer.[F";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<float>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mOnSizeChangedBuffer.[F";

				IntPtr native_value = global::Android.Runtime.JavaArray<float>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='mPinchZoomEnabled']"
		[Register ("mPinchZoomEnabled")]
		protected bool MPinchZoomEnabled {
			get {
				const string __id = "mPinchZoomEnabled.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mPinchZoomEnabled.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='mRightAxisTransformer']"
		[Register ("mRightAxisTransformer")]
		protected global::MikePhil.Charting.Util.Transformer MRightAxisTransformer {
			get {
				const string __id = "mRightAxisTransformer.Lcom/github/mikephil/charting/utils/Transformer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mRightAxisTransformer.Lcom/github/mikephil/charting/utils/Transformer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='mXAxisRenderer']"
		[Register ("mXAxisRenderer")]
		protected global::MikePhil.Charting.Renderer.XAxisRenderer MXAxisRenderer {
			get {
				const string __id = "mXAxisRenderer.Lcom/github/mikephil/charting/renderer/XAxisRenderer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.XAxisRenderer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mXAxisRenderer.Lcom/github/mikephil/charting/renderer/XAxisRenderer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='mZoomMatrixBuffer']"
		[Register ("mZoomMatrixBuffer")]
		protected global::Android.Graphics.Matrix MZoomMatrixBuffer {
			get {
				const string __id = "mZoomMatrixBuffer.Landroid/graphics/Matrix;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mZoomMatrixBuffer.Landroid/graphics/Matrix;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='posForGetHighestVisibleX']"
		[Register ("posForGetHighestVisibleX")]
		protected global::MikePhil.Charting.Util.MPPointD PosForGetHighestVisibleX {
			get {
				const string __id = "posForGetHighestVisibleX.Lcom/github/mikephil/charting/utils/MPPointD;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointD> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "posForGetHighestVisibleX.Lcom/github/mikephil/charting/utils/MPPointD;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/field[@name='posForGetLowestVisibleX']"
		[Register ("posForGetLowestVisibleX")]
		protected global::MikePhil.Charting.Util.MPPointD PosForGetLowestVisibleX {
			get {
				const string __id = "posForGetLowestVisibleX.Lcom/github/mikephil/charting/utils/MPPointD;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointD> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "posForGetLowestVisibleX.Lcom/github/mikephil/charting/utils/MPPointD;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/charts/BarLineChartBase", typeof (BarLineChartBase));
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

		protected BarLineChartBase (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/constructor[@name='BarLineChartBase' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe BarLineChartBase (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/constructor[@name='BarLineChartBase' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe BarLineChartBase (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/constructor[@name='BarLineChartBase' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe BarLineChartBase (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle)
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

		static Delegate cb_isAutoScaleMinMaxEnabled;
#pragma warning disable 0169
		static Delegate GetIsAutoScaleMinMaxEnabledHandler ()
		{
			if (cb_isAutoScaleMinMaxEnabled == null)
				cb_isAutoScaleMinMaxEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAutoScaleMinMaxEnabled);
			return cb_isAutoScaleMinMaxEnabled;
		}

		static bool n_IsAutoScaleMinMaxEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.AutoScaleMinMaxEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setAutoScaleMinMaxEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetAutoScaleMinMaxEnabled_ZHandler ()
		{
			if (cb_setAutoScaleMinMaxEnabled_Z == null)
				cb_setAutoScaleMinMaxEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAutoScaleMinMaxEnabled_Z);
			return cb_setAutoScaleMinMaxEnabled_Z;
		}

		static void n_SetAutoScaleMinMaxEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AutoScaleMinMaxEnabled = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool AutoScaleMinMaxEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='isAutoScaleMinMaxEnabled' and count(parameter)=0]"
			[Register ("isAutoScaleMinMaxEnabled", "()Z", "GetIsAutoScaleMinMaxEnabledHandler")]
			get {
				const string __id = "isAutoScaleMinMaxEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setAutoScaleMinMaxEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setAutoScaleMinMaxEnabled", "(Z)V", "GetSetAutoScaleMinMaxEnabled_ZHandler")]
			set {
				const string __id = "setAutoScaleMinMaxEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAxisLeft;
#pragma warning disable 0169
		static Delegate GetGetAxisLeftHandler ()
		{
			if (cb_getAxisLeft == null)
				cb_getAxisLeft = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAxisLeft);
			return cb_getAxisLeft;
		}

		static IntPtr n_GetAxisLeft (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AxisLeft);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Components.YAxis AxisLeft {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='getAxisLeft' and count(parameter)=0]"
			[Register ("getAxisLeft", "()Lcom/github/mikephil/charting/components/YAxis;", "GetGetAxisLeftHandler")]
			get {
				const string __id = "getAxisLeft.()Lcom/github/mikephil/charting/components/YAxis;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getAxisRight;
#pragma warning disable 0169
		static Delegate GetGetAxisRightHandler ()
		{
			if (cb_getAxisRight == null)
				cb_getAxisRight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAxisRight);
			return cb_getAxisRight;
		}

		static IntPtr n_GetAxisRight (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.AxisRight);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Components.YAxis AxisRight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='getAxisRight' and count(parameter)=0]"
			[Register ("getAxisRight", "()Lcom/github/mikephil/charting/components/YAxis;", "GetGetAxisRightHandler")]
			get {
				const string __id = "getAxisRight.()Lcom/github/mikephil/charting/components/YAxis;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isDoubleTapToZoomEnabled;
#pragma warning disable 0169
		static Delegate GetIsDoubleTapToZoomEnabledHandler ()
		{
			if (cb_isDoubleTapToZoomEnabled == null)
				cb_isDoubleTapToZoomEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDoubleTapToZoomEnabled);
			return cb_isDoubleTapToZoomEnabled;
		}

		static bool n_IsDoubleTapToZoomEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DoubleTapToZoomEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setDoubleTapToZoomEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDoubleTapToZoomEnabled_ZHandler ()
		{
			if (cb_setDoubleTapToZoomEnabled_Z == null)
				cb_setDoubleTapToZoomEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDoubleTapToZoomEnabled_Z);
			return cb_setDoubleTapToZoomEnabled_Z;
		}

		static void n_SetDoubleTapToZoomEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DoubleTapToZoomEnabled = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool DoubleTapToZoomEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='isDoubleTapToZoomEnabled' and count(parameter)=0]"
			[Register ("isDoubleTapToZoomEnabled", "()Z", "GetIsDoubleTapToZoomEnabledHandler")]
			get {
				const string __id = "isDoubleTapToZoomEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setDoubleTapToZoomEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDoubleTapToZoomEnabled", "(Z)V", "GetSetDoubleTapToZoomEnabled_ZHandler")]
			set {
				const string __id = "setDoubleTapToZoomEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDragEnabled;
#pragma warning disable 0169
		static Delegate GetIsDragEnabledHandler ()
		{
			if (cb_isDragEnabled == null)
				cb_isDragEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDragEnabled);
			return cb_isDragEnabled;
		}

		static bool n_IsDragEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DragEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setDragEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDragEnabled_ZHandler ()
		{
			if (cb_setDragEnabled_Z == null)
				cb_setDragEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDragEnabled_Z);
			return cb_setDragEnabled_Z;
		}

		static void n_SetDragEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DragEnabled = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool DragEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='isDragEnabled' and count(parameter)=0]"
			[Register ("isDragEnabled", "()Z", "GetIsDragEnabledHandler")]
			get {
				const string __id = "isDragEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setDragEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDragEnabled", "(Z)V", "GetSetDragEnabled_ZHandler")]
			set {
				const string __id = "setDragEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDragXEnabled;
#pragma warning disable 0169
		static Delegate GetIsDragXEnabledHandler ()
		{
			if (cb_isDragXEnabled == null)
				cb_isDragXEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDragXEnabled);
			return cb_isDragXEnabled;
		}

		static bool n_IsDragXEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DragXEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setDragXEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDragXEnabled_ZHandler ()
		{
			if (cb_setDragXEnabled_Z == null)
				cb_setDragXEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDragXEnabled_Z);
			return cb_setDragXEnabled_Z;
		}

		static void n_SetDragXEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DragXEnabled = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool DragXEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='isDragXEnabled' and count(parameter)=0]"
			[Register ("isDragXEnabled", "()Z", "GetIsDragXEnabledHandler")]
			get {
				const string __id = "isDragXEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setDragXEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDragXEnabled", "(Z)V", "GetSetDragXEnabled_ZHandler")]
			set {
				const string __id = "setDragXEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDragYEnabled;
#pragma warning disable 0169
		static Delegate GetIsDragYEnabledHandler ()
		{
			if (cb_isDragYEnabled == null)
				cb_isDragYEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDragYEnabled);
			return cb_isDragYEnabled;
		}

		static bool n_IsDragYEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DragYEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setDragYEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDragYEnabled_ZHandler ()
		{
			if (cb_setDragYEnabled_Z == null)
				cb_setDragYEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDragYEnabled_Z);
			return cb_setDragYEnabled_Z;
		}

		static void n_SetDragYEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DragYEnabled = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool DragYEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='isDragYEnabled' and count(parameter)=0]"
			[Register ("isDragYEnabled", "()Z", "GetIsDragYEnabledHandler")]
			get {
				const string __id = "isDragYEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setDragYEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDragYEnabled", "(Z)V", "GetSetDragYEnabled_ZHandler")]
			set {
				const string __id = "setDragYEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getDrawListener;
#pragma warning disable 0169
		static Delegate GetGetDrawListenerHandler ()
		{
			if (cb_getDrawListener == null)
				cb_getDrawListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDrawListener);
			return cb_getDrawListener;
		}

		static IntPtr n_GetDrawListener (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DrawListener);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Listener.IOnDrawListenerSupport DrawListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='getDrawListener' and count(parameter)=0]"
			[Register ("getDrawListener", "()Lcom/github/mikephil/charting/listener/OnDrawListener;", "GetGetDrawListenerHandler")]
			get {
				const string __id = "getDrawListener.()Lcom/github/mikephil/charting/listener/OnDrawListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.IOnDrawListenerSupport> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasNoDragOffset;
#pragma warning disable 0169
		static Delegate GetHasNoDragOffsetHandler ()
		{
			if (cb_hasNoDragOffset == null)
				cb_hasNoDragOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNoDragOffset);
			return cb_hasNoDragOffset;
		}

		static bool n_HasNoDragOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNoDragOffset;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasNoDragOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='hasNoDragOffset' and count(parameter)=0]"
			[Register ("hasNoDragOffset", "()Z", "GetHasNoDragOffsetHandler")]
			get {
				const string __id = "hasNoDragOffset.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getHighestVisibleX;
#pragma warning disable 0169
		static Delegate GetGetHighestVisibleXHandler ()
		{
			if (cb_getHighestVisibleX == null)
				cb_getHighestVisibleX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetHighestVisibleX);
			return cb_getHighestVisibleX;
		}

		static float n_GetHighestVisibleX (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighestVisibleX;
		}
#pragma warning restore 0169

		public virtual unsafe float HighestVisibleX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='getHighestVisibleX' and count(parameter)=0]"
			[Register ("getHighestVisibleX", "()F", "GetGetHighestVisibleXHandler")]
			get {
				const string __id = "getHighestVisibleX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isHighlightPerDragEnabled;
#pragma warning disable 0169
		static Delegate GetIsHighlightPerDragEnabledHandler ()
		{
			if (cb_isHighlightPerDragEnabled == null)
				cb_isHighlightPerDragEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHighlightPerDragEnabled);
			return cb_isHighlightPerDragEnabled;
		}

		static bool n_IsHighlightPerDragEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighlightPerDragEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setHighlightPerDragEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetHighlightPerDragEnabled_ZHandler ()
		{
			if (cb_setHighlightPerDragEnabled_Z == null)
				cb_setHighlightPerDragEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHighlightPerDragEnabled_Z);
			return cb_setHighlightPerDragEnabled_Z;
		}

		static void n_SetHighlightPerDragEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighlightPerDragEnabled = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool HighlightPerDragEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='isHighlightPerDragEnabled' and count(parameter)=0]"
			[Register ("isHighlightPerDragEnabled", "()Z", "GetIsHighlightPerDragEnabledHandler")]
			get {
				const string __id = "isHighlightPerDragEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setHighlightPerDragEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHighlightPerDragEnabled", "(Z)V", "GetSetHighlightPerDragEnabled_ZHandler")]
			set {
				const string __id = "setHighlightPerDragEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isAnyAxisInverted;
#pragma warning disable 0169
		static Delegate GetIsAnyAxisInvertedHandler ()
		{
			if (cb_isAnyAxisInverted == null)
				cb_isAnyAxisInverted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAnyAxisInverted);
			return cb_isAnyAxisInverted;
		}

		static bool n_IsAnyAxisInverted (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAnyAxisInverted;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAnyAxisInverted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='isAnyAxisInverted' and count(parameter)=0]"
			[Register ("isAnyAxisInverted", "()Z", "GetIsAnyAxisInvertedHandler")]
			get {
				const string __id = "isAnyAxisInverted.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isClipValuesToContentEnabled;
#pragma warning disable 0169
		static Delegate GetIsClipValuesToContentEnabledHandler ()
		{
			if (cb_isClipValuesToContentEnabled == null)
				cb_isClipValuesToContentEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsClipValuesToContentEnabled);
			return cb_isClipValuesToContentEnabled;
		}

		static bool n_IsClipValuesToContentEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsClipValuesToContentEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsClipValuesToContentEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='isClipValuesToContentEnabled' and count(parameter)=0]"
			[Register ("isClipValuesToContentEnabled", "()Z", "GetIsClipValuesToContentEnabledHandler")]
			get {
				const string __id = "isClipValuesToContentEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDrawBordersEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawBordersEnabledHandler ()
		{
			if (cb_isDrawBordersEnabled == null)
				cb_isDrawBordersEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawBordersEnabled);
			return cb_isDrawBordersEnabled;
		}

		static bool n_IsDrawBordersEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawBordersEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrawBordersEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='isDrawBordersEnabled' and count(parameter)=0]"
			[Register ("isDrawBordersEnabled", "()Z", "GetIsDrawBordersEnabledHandler")]
			get {
				const string __id = "isDrawBordersEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isFullyZoomedOut;
#pragma warning disable 0169
		static Delegate GetIsFullyZoomedOutHandler ()
		{
			if (cb_isFullyZoomedOut == null)
				cb_isFullyZoomedOut = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFullyZoomedOut);
			return cb_isFullyZoomedOut;
		}

		static bool n_IsFullyZoomedOut (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFullyZoomedOut;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsFullyZoomedOut {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='isFullyZoomedOut' and count(parameter)=0]"
			[Register ("isFullyZoomedOut", "()Z", "GetIsFullyZoomedOutHandler")]
			get {
				const string __id = "isFullyZoomedOut.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isPinchZoomEnabled;
#pragma warning disable 0169
		static Delegate GetIsPinchZoomEnabledHandler ()
		{
			if (cb_isPinchZoomEnabled == null)
				cb_isPinchZoomEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsPinchZoomEnabled);
			return cb_isPinchZoomEnabled;
		}

		static bool n_IsPinchZoomEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsPinchZoomEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsPinchZoomEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='isPinchZoomEnabled' and count(parameter)=0]"
			[Register ("isPinchZoomEnabled", "()Z", "GetIsPinchZoomEnabledHandler")]
			get {
				const string __id = "isPinchZoomEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isKeepPositionOnRotation;
#pragma warning disable 0169
		static Delegate GetIsKeepPositionOnRotationHandler ()
		{
			if (cb_isKeepPositionOnRotation == null)
				cb_isKeepPositionOnRotation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsKeepPositionOnRotation);
			return cb_isKeepPositionOnRotation;
		}

		static bool n_IsKeepPositionOnRotation (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.KeepPositionOnRotation;
		}
#pragma warning restore 0169

		static Delegate cb_setKeepPositionOnRotation_Z;
#pragma warning disable 0169
		static Delegate GetSetKeepPositionOnRotation_ZHandler ()
		{
			if (cb_setKeepPositionOnRotation_Z == null)
				cb_setKeepPositionOnRotation_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetKeepPositionOnRotation_Z);
			return cb_setKeepPositionOnRotation_Z;
		}

		static void n_SetKeepPositionOnRotation_Z (IntPtr jnienv, IntPtr native__this, bool keepPositionOnRotation)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.KeepPositionOnRotation = keepPositionOnRotation;
		}
#pragma warning restore 0169

		public virtual unsafe bool KeepPositionOnRotation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='isKeepPositionOnRotation' and count(parameter)=0]"
			[Register ("isKeepPositionOnRotation", "()Z", "GetIsKeepPositionOnRotationHandler")]
			get {
				const string __id = "isKeepPositionOnRotation.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setKeepPositionOnRotation' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setKeepPositionOnRotation", "(Z)V", "GetSetKeepPositionOnRotation_ZHandler")]
			set {
				const string __id = "setKeepPositionOnRotation.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLowestVisibleX;
#pragma warning disable 0169
		static Delegate GetGetLowestVisibleXHandler ()
		{
			if (cb_getLowestVisibleX == null)
				cb_getLowestVisibleX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetLowestVisibleX);
			return cb_getLowestVisibleX;
		}

		static float n_GetLowestVisibleX (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LowestVisibleX;
		}
#pragma warning restore 0169

		public virtual unsafe float LowestVisibleX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='getLowestVisibleX' and count(parameter)=0]"
			[Register ("getLowestVisibleX", "()F", "GetGetLowestVisibleXHandler")]
			get {
				const string __id = "getLowestVisibleX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
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
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxVisibleCount;
		}
#pragma warning restore 0169

		public override unsafe int MaxVisibleCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='getMaxVisibleCount' and count(parameter)=0]"
			[Register ("getMaxVisibleCount", "()I", "GetGetMaxVisibleCountHandler")]
			get {
				const string __id = "getMaxVisibleCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMinOffset;
#pragma warning disable 0169
		static Delegate GetGetMinOffsetHandler ()
		{
			if (cb_getMinOffset == null)
				cb_getMinOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMinOffset);
			return cb_getMinOffset;
		}

		static float n_GetMinOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinOffset;
		}
#pragma warning restore 0169

		static Delegate cb_setMinOffset_F;
#pragma warning disable 0169
		static Delegate GetSetMinOffset_FHandler ()
		{
			if (cb_setMinOffset_F == null)
				cb_setMinOffset_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMinOffset_F);
			return cb_setMinOffset_F;
		}

		static void n_SetMinOffset_F (IntPtr jnienv, IntPtr native__this, float minOffset)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinOffset = minOffset;
		}
#pragma warning restore 0169

		public virtual unsafe float MinOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='getMinOffset' and count(parameter)=0]"
			[Register ("getMinOffset", "()F", "GetGetMinOffsetHandler")]
			get {
				const string __id = "getMinOffset.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setMinOffset' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMinOffset", "(F)V", "GetSetMinOffset_FHandler")]
			set {
				const string __id = "setMinOffset.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRendererLeftYAxis;
#pragma warning disable 0169
		static Delegate GetGetRendererLeftYAxisHandler ()
		{
			if (cb_getRendererLeftYAxis == null)
				cb_getRendererLeftYAxis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRendererLeftYAxis);
			return cb_getRendererLeftYAxis;
		}

		static IntPtr n_GetRendererLeftYAxis (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RendererLeftYAxis);
		}
#pragma warning restore 0169

		static Delegate cb_setRendererLeftYAxis_Lcom_github_mikephil_charting_renderer_YAxisRenderer_;
#pragma warning disable 0169
		static Delegate GetSetRendererLeftYAxis_Lcom_github_mikephil_charting_renderer_YAxisRenderer_Handler ()
		{
			if (cb_setRendererLeftYAxis_Lcom_github_mikephil_charting_renderer_YAxisRenderer_ == null)
				cb_setRendererLeftYAxis_Lcom_github_mikephil_charting_renderer_YAxisRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRendererLeftYAxis_Lcom_github_mikephil_charting_renderer_YAxisRenderer_);
			return cb_setRendererLeftYAxis_Lcom_github_mikephil_charting_renderer_YAxisRenderer_;
		}

		static void n_SetRendererLeftYAxis_Lcom_github_mikephil_charting_renderer_YAxisRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rendererLeftYAxis)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Renderer.YAxisRenderer rendererLeftYAxis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.YAxisRenderer> (native_rendererLeftYAxis, JniHandleOwnership.DoNotTransfer);
			__this.RendererLeftYAxis = rendererLeftYAxis;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Renderer.YAxisRenderer RendererLeftYAxis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='getRendererLeftYAxis' and count(parameter)=0]"
			[Register ("getRendererLeftYAxis", "()Lcom/github/mikephil/charting/renderer/YAxisRenderer;", "GetGetRendererLeftYAxisHandler")]
			get {
				const string __id = "getRendererLeftYAxis.()Lcom/github/mikephil/charting/renderer/YAxisRenderer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.YAxisRenderer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setRendererLeftYAxis' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.renderer.YAxisRenderer']]"
			[Register ("setRendererLeftYAxis", "(Lcom/github/mikephil/charting/renderer/YAxisRenderer;)V", "GetSetRendererLeftYAxis_Lcom_github_mikephil_charting_renderer_YAxisRenderer_Handler")]
			set {
				const string __id = "setRendererLeftYAxis.(Lcom/github/mikephil/charting/renderer/YAxisRenderer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRendererRightYAxis;
#pragma warning disable 0169
		static Delegate GetGetRendererRightYAxisHandler ()
		{
			if (cb_getRendererRightYAxis == null)
				cb_getRendererRightYAxis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRendererRightYAxis);
			return cb_getRendererRightYAxis;
		}

		static IntPtr n_GetRendererRightYAxis (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RendererRightYAxis);
		}
#pragma warning restore 0169

		static Delegate cb_setRendererRightYAxis_Lcom_github_mikephil_charting_renderer_YAxisRenderer_;
#pragma warning disable 0169
		static Delegate GetSetRendererRightYAxis_Lcom_github_mikephil_charting_renderer_YAxisRenderer_Handler ()
		{
			if (cb_setRendererRightYAxis_Lcom_github_mikephil_charting_renderer_YAxisRenderer_ == null)
				cb_setRendererRightYAxis_Lcom_github_mikephil_charting_renderer_YAxisRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetRendererRightYAxis_Lcom_github_mikephil_charting_renderer_YAxisRenderer_);
			return cb_setRendererRightYAxis_Lcom_github_mikephil_charting_renderer_YAxisRenderer_;
		}

		static void n_SetRendererRightYAxis_Lcom_github_mikephil_charting_renderer_YAxisRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rendererRightYAxis)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Renderer.YAxisRenderer rendererRightYAxis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.YAxisRenderer> (native_rendererRightYAxis, JniHandleOwnership.DoNotTransfer);
			__this.RendererRightYAxis = rendererRightYAxis;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Renderer.YAxisRenderer RendererRightYAxis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='getRendererRightYAxis' and count(parameter)=0]"
			[Register ("getRendererRightYAxis", "()Lcom/github/mikephil/charting/renderer/YAxisRenderer;", "GetGetRendererRightYAxisHandler")]
			get {
				const string __id = "getRendererRightYAxis.()Lcom/github/mikephil/charting/renderer/YAxisRenderer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.YAxisRenderer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setRendererRightYAxis' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.renderer.YAxisRenderer']]"
			[Register ("setRendererRightYAxis", "(Lcom/github/mikephil/charting/renderer/YAxisRenderer;)V", "GetSetRendererRightYAxis_Lcom_github_mikephil_charting_renderer_YAxisRenderer_Handler")]
			set {
				const string __id = "setRendererRightYAxis.(Lcom/github/mikephil/charting/renderer/YAxisRenderer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRendererXAxis;
#pragma warning disable 0169
		static Delegate GetGetRendererXAxisHandler ()
		{
			if (cb_getRendererXAxis == null)
				cb_getRendererXAxis = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRendererXAxis);
			return cb_getRendererXAxis;
		}

		static IntPtr n_GetRendererXAxis (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.RendererXAxis);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Renderer.XAxisRenderer RendererXAxis {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='getRendererXAxis' and count(parameter)=0]"
			[Register ("getRendererXAxis", "()Lcom/github/mikephil/charting/renderer/XAxisRenderer;", "GetGetRendererXAxisHandler")]
			get {
				const string __id = "getRendererXAxis.()Lcom/github/mikephil/charting/renderer/XAxisRenderer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.XAxisRenderer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isScaleXEnabled;
#pragma warning disable 0169
		static Delegate GetIsScaleXEnabledHandler ()
		{
			if (cb_isScaleXEnabled == null)
				cb_isScaleXEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsScaleXEnabled);
			return cb_isScaleXEnabled;
		}

		static bool n_IsScaleXEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScaleXEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setScaleXEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetScaleXEnabled_ZHandler ()
		{
			if (cb_setScaleXEnabled_Z == null)
				cb_setScaleXEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScaleXEnabled_Z);
			return cb_setScaleXEnabled_Z;
		}

		static void n_SetScaleXEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScaleXEnabled = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool ScaleXEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='isScaleXEnabled' and count(parameter)=0]"
			[Register ("isScaleXEnabled", "()Z", "GetIsScaleXEnabledHandler")]
			get {
				const string __id = "isScaleXEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setScaleXEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setScaleXEnabled", "(Z)V", "GetSetScaleXEnabled_ZHandler")]
			set {
				const string __id = "setScaleXEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isScaleYEnabled;
#pragma warning disable 0169
		static Delegate GetIsScaleYEnabledHandler ()
		{
			if (cb_isScaleYEnabled == null)
				cb_isScaleYEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsScaleYEnabled);
			return cb_isScaleYEnabled;
		}

		static bool n_IsScaleYEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScaleYEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setScaleYEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetScaleYEnabled_ZHandler ()
		{
			if (cb_setScaleYEnabled_Z == null)
				cb_setScaleYEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScaleYEnabled_Z);
			return cb_setScaleYEnabled_Z;
		}

		static void n_SetScaleYEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScaleYEnabled = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool ScaleYEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='isScaleYEnabled' and count(parameter)=0]"
			[Register ("isScaleYEnabled", "()Z", "GetIsScaleYEnabledHandler")]
			get {
				const string __id = "isScaleYEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setScaleYEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setScaleYEnabled", "(Z)V", "GetSetScaleYEnabled_ZHandler")]
			set {
				const string __id = "setScaleYEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVisibleXRange;
#pragma warning disable 0169
		static Delegate GetGetVisibleXRangeHandler ()
		{
			if (cb_getVisibleXRange == null)
				cb_getVisibleXRange = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetVisibleXRange);
			return cb_getVisibleXRange;
		}

		static float n_GetVisibleXRange (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.VisibleXRange;
		}
#pragma warning restore 0169

		public virtual unsafe float VisibleXRange {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='getVisibleXRange' and count(parameter)=0]"
			[Register ("getVisibleXRange", "()F", "GetGetVisibleXRangeHandler")]
			get {
				const string __id = "getVisibleXRange.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
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
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YChartMax;
		}
#pragma warning restore 0169

		public override unsafe float YChartMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='getYChartMax' and count(parameter)=0]"
			[Register ("getYChartMax", "()F", "GetGetYChartMaxHandler")]
			get {
				const string __id = "getYChartMax.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
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
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YChartMin;
		}
#pragma warning restore 0169

		public override unsafe float YChartMin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='getYChartMin' and count(parameter)=0]"
			[Register ("getYChartMin", "()F", "GetGetYChartMinHandler")]
			get {
				const string __id = "getYChartMin.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_autoScale;
#pragma warning disable 0169
		static Delegate GetAutoScaleHandler ()
		{
			if (cb_autoScale == null)
				cb_autoScale = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_AutoScale);
			return cb_autoScale;
		}

		static void n_AutoScale (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AutoScale ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='autoScale' and count(parameter)=0]"
		[Register ("autoScale", "()V", "GetAutoScaleHandler")]
		protected virtual unsafe void AutoScale ()
		{
			const string __id = "autoScale.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
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
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalcMinMax ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='calcMinMax' and count(parameter)=0]"
		[Register ("calcMinMax", "()V", "GetCalcMinMaxHandler")]
		protected override unsafe void CalcMinMax ()
		{
			const string __id = "calcMinMax.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_calculateLegendOffsets_Landroid_graphics_RectF_;
#pragma warning disable 0169
		static Delegate GetCalculateLegendOffsets_Landroid_graphics_RectF_Handler ()
		{
			if (cb_calculateLegendOffsets_Landroid_graphics_RectF_ == null)
				cb_calculateLegendOffsets_Landroid_graphics_RectF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CalculateLegendOffsets_Landroid_graphics_RectF_);
			return cb_calculateLegendOffsets_Landroid_graphics_RectF_;
		}

		static void n_CalculateLegendOffsets_Landroid_graphics_RectF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_offsets)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.RectF offsets = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_offsets, JniHandleOwnership.DoNotTransfer);
			__this.CalculateLegendOffsets (offsets);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='calculateLegendOffsets' and count(parameter)=1 and parameter[1][@type='android.graphics.RectF']]"
		[Register ("calculateLegendOffsets", "(Landroid/graphics/RectF;)V", "GetCalculateLegendOffsets_Landroid_graphics_RectF_Handler")]
		protected virtual unsafe void CalculateLegendOffsets (global::Android.Graphics.RectF offsets)
		{
			const string __id = "calculateLegendOffsets.(Landroid/graphics/RectF;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((offsets == null) ? IntPtr.Zero : ((global::Java.Lang.Object) offsets).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

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
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalculateOffsets ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='calculateOffsets' and count(parameter)=0]"
		[Register ("calculateOffsets", "()V", "GetCalculateOffsetsHandler")]
		public override unsafe void CalculateOffsets ()
		{
			const string __id = "calculateOffsets.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_centerViewTo_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_;
#pragma warning disable 0169
		static Delegate GetCenterViewTo_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler ()
		{
			if (cb_centerViewTo_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_ == null)
				cb_centerViewTo_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, IntPtr>) n_CenterViewTo_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_centerViewTo_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static void n_CenterViewTo_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, float xValue, float yValue, IntPtr native_axis)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency axis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_axis, JniHandleOwnership.DoNotTransfer);
			__this.CenterViewTo (xValue, yValue, axis);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='centerViewTo' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='com.github.mikephil.charting.components.YAxis.AxisDependency']]"
		[Register ("centerViewTo", "(FFLcom/github/mikephil/charting/components/YAxis$AxisDependency;)V", "GetCenterViewTo_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler")]
		public virtual unsafe void CenterViewTo (float xValue, float yValue, global::MikePhil.Charting.Components.YAxis.AxisDependency axis)
		{
			const string __id = "centerViewTo.(FFLcom/github/mikephil/charting/components/YAxis$AxisDependency;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (xValue);
				__args [1] = new JniArgumentValue (yValue);
				__args [2] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_centerViewToAnimated_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_J;
#pragma warning disable 0169
		static Delegate GetCenterViewToAnimated_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_JHandler ()
		{
			if (cb_centerViewToAnimated_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_J == null)
				cb_centerViewToAnimated_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, IntPtr, long>) n_CenterViewToAnimated_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_J);
			return cb_centerViewToAnimated_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_J;
		}

		static void n_CenterViewToAnimated_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_J (IntPtr jnienv, IntPtr native__this, float xValue, float yValue, IntPtr native_axis, long duration)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency axis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_axis, JniHandleOwnership.DoNotTransfer);
			__this.CenterViewToAnimated (xValue, yValue, axis, duration);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='centerViewToAnimated' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='com.github.mikephil.charting.components.YAxis.AxisDependency'] and parameter[4][@type='long']]"
		[Register ("centerViewToAnimated", "(FFLcom/github/mikephil/charting/components/YAxis$AxisDependency;J)V", "GetCenterViewToAnimated_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_JHandler")]
		public virtual unsafe void CenterViewToAnimated (float xValue, float yValue, global::MikePhil.Charting.Components.YAxis.AxisDependency axis, long duration)
		{
			const string __id = "centerViewToAnimated.(FFLcom/github/mikephil/charting/components/YAxis$AxisDependency;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (xValue);
				__args [1] = new JniArgumentValue (yValue);
				__args [2] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				__args [3] = new JniArgumentValue (duration);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_centerViewToY_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_;
#pragma warning disable 0169
		static Delegate GetCenterViewToY_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler ()
		{
			if (cb_centerViewToY_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_ == null)
				cb_centerViewToY_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, IntPtr>) n_CenterViewToY_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_centerViewToY_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static void n_CenterViewToY_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, float yValue, IntPtr native_axis)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency axis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_axis, JniHandleOwnership.DoNotTransfer);
			__this.CenterViewToY (yValue, axis);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='centerViewToY' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='com.github.mikephil.charting.components.YAxis.AxisDependency']]"
		[Register ("centerViewToY", "(FLcom/github/mikephil/charting/components/YAxis$AxisDependency;)V", "GetCenterViewToY_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler")]
		public virtual unsafe void CenterViewToY (float yValue, global::MikePhil.Charting.Components.YAxis.AxisDependency axis)
		{
			const string __id = "centerViewToY.(FLcom/github/mikephil/charting/components/YAxis$AxisDependency;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (yValue);
				__args [1] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_drawGridBackground_Landroid_graphics_Canvas_;
#pragma warning disable 0169
		static Delegate GetDrawGridBackground_Landroid_graphics_Canvas_Handler ()
		{
			if (cb_drawGridBackground_Landroid_graphics_Canvas_ == null)
				cb_drawGridBackground_Landroid_graphics_Canvas_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DrawGridBackground_Landroid_graphics_Canvas_);
			return cb_drawGridBackground_Landroid_graphics_Canvas_;
		}

		static void n_DrawGridBackground_Landroid_graphics_Canvas_ (IntPtr jnienv, IntPtr native__this, IntPtr native_c)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Canvas c = global::Java.Lang.Object.GetObject<global::Android.Graphics.Canvas> (native_c, JniHandleOwnership.DoNotTransfer);
			__this.DrawGridBackground (c);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='drawGridBackground' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawGridBackground", "(Landroid/graphics/Canvas;)V", "GetDrawGridBackground_Landroid_graphics_Canvas_Handler")]
		protected virtual unsafe void DrawGridBackground (global::Android.Graphics.Canvas c)
		{
			const string __id = "drawGridBackground.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_fitScreen;
#pragma warning disable 0169
		static Delegate GetFitScreenHandler ()
		{
			if (cb_fitScreen == null)
				cb_fitScreen = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_FitScreen);
			return cb_fitScreen;
		}

		static void n_FitScreen (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FitScreen ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='fitScreen' and count(parameter)=0]"
		[Register ("fitScreen", "()V", "GetFitScreenHandler")]
		public virtual unsafe void FitScreen ()
		{
			const string __id = "fitScreen.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getAxis_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
#pragma warning disable 0169
		static Delegate GetGetAxis_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler ()
		{
			if (cb_getAxis_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ == null)
				cb_getAxis_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetAxis_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_getAxis_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static IntPtr n_GetAxis_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, IntPtr native_axis)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency axis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_axis, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetAxis (axis));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='getAxis' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.YAxis.AxisDependency']]"
		[Register ("getAxis", "(Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)Lcom/github/mikephil/charting/components/YAxis;", "GetGetAxis_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler")]
		public virtual unsafe global::MikePhil.Charting.Components.YAxis GetAxis (global::MikePhil.Charting.Components.YAxis.AxisDependency axis)
		{
			const string __id = "getAxis.(Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)Lcom/github/mikephil/charting/components/YAxis;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getAxisRange_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
#pragma warning disable 0169
		static Delegate GetGetAxisRange_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler ()
		{
			if (cb_getAxisRange_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ == null)
				cb_getAxisRange_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float>) n_GetAxisRange_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_getAxisRange_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static float n_GetAxisRange_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, IntPtr native_axis)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency axis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_axis, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetAxisRange (axis);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='getAxisRange' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.YAxis.AxisDependency']]"
		[Register ("getAxisRange", "(Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)F", "GetGetAxisRange_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler")]
		protected virtual unsafe float GetAxisRange (global::MikePhil.Charting.Components.YAxis.AxisDependency axis)
		{
			const string __id = "getAxisRange.(Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getDataSetByTouchPoint_FF;
#pragma warning disable 0169
		static Delegate GetGetDataSetByTouchPoint_FFHandler ()
		{
			if (cb_getDataSetByTouchPoint_FF == null)
				cb_getDataSetByTouchPoint_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_GetDataSetByTouchPoint_FF);
			return cb_getDataSetByTouchPoint_FF;
		}

		static IntPtr n_GetDataSetByTouchPoint_FF (IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetDataSetByTouchPoint (x, y));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='getDataSetByTouchPoint' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("getDataSetByTouchPoint", "(FF)Lcom/github/mikephil/charting/interfaces/datasets/IBarLineScatterCandleBubbleDataSet;", "GetGetDataSetByTouchPoint_FFHandler")]
		public virtual unsafe global::MikePhil.Charting.Interfaces.Datasets.IBarLineScatterCandleBubbleDataSet GetDataSetByTouchPoint (float x, float y)
		{
			const string __id = "getDataSetByTouchPoint.(FF)Lcom/github/mikephil/charting/interfaces/datasets/IBarLineScatterCandleBubbleDataSet;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IBarLineScatterCandleBubbleDataSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getEntryByTouchPoint_FF;
#pragma warning disable 0169
		static Delegate GetGetEntryByTouchPoint_FFHandler ()
		{
			if (cb_getEntryByTouchPoint_FF == null)
				cb_getEntryByTouchPoint_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_GetEntryByTouchPoint_FF);
			return cb_getEntryByTouchPoint_FF;
		}

		static IntPtr n_GetEntryByTouchPoint_FF (IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetEntryByTouchPoint (x, y));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='getEntryByTouchPoint' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("getEntryByTouchPoint", "(FF)Lcom/github/mikephil/charting/data/Entry;", "GetGetEntryByTouchPoint_FFHandler")]
		public virtual unsafe global::MikePhil.Charting.Data.Entry GetEntryByTouchPoint (float x, float y)
		{
			const string __id = "getEntryByTouchPoint.(FF)Lcom/github/mikephil/charting/data/Entry;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.Entry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getPixelForValues_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_;
#pragma warning disable 0169
		static Delegate GetGetPixelForValues_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler ()
		{
			if (cb_getPixelForValues_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_ == null)
				cb_getPixelForValues_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr, IntPtr>) n_GetPixelForValues_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_getPixelForValues_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static IntPtr n_GetPixelForValues_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, float x, float y, IntPtr native_axis)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency axis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_axis, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPixelForValues (x, y, axis));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='getPixelForValues' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='com.github.mikephil.charting.components.YAxis.AxisDependency']]"
		[Register ("getPixelForValues", "(FFLcom/github/mikephil/charting/components/YAxis$AxisDependency;)Lcom/github/mikephil/charting/utils/MPPointD;", "GetGetPixelForValues_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler")]
		public virtual unsafe global::MikePhil.Charting.Util.MPPointD GetPixelForValues (float x, float y, global::MikePhil.Charting.Components.YAxis.AxisDependency axis)
		{
			const string __id = "getPixelForValues.(FFLcom/github/mikephil/charting/components/YAxis$AxisDependency;)Lcom/github/mikephil/charting/utils/MPPointD;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointD> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getPosition_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
#pragma warning disable 0169
		static Delegate GetGetPosition_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler ()
		{
			if (cb_getPosition_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ == null)
				cb_getPosition_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GetPosition_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_getPosition_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static IntPtr n_GetPosition_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_axis)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.Entry e = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.Entry> (native_e, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency axis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_axis, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetPosition (e, axis));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='getPosition' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.data.Entry'] and parameter[2][@type='com.github.mikephil.charting.components.YAxis.AxisDependency']]"
		[Register ("getPosition", "(Lcom/github/mikephil/charting/data/Entry;Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)Lcom/github/mikephil/charting/utils/MPPointF;", "GetGetPosition_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler")]
		public virtual unsafe global::MikePhil.Charting.Util.MPPointF GetPosition (global::MikePhil.Charting.Data.Entry e, global::MikePhil.Charting.Components.YAxis.AxisDependency axis)
		{
			const string __id = "getPosition.(Lcom/github/mikephil/charting/data/Entry;Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)Lcom/github/mikephil/charting/utils/MPPointF;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				__args [1] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getTransformer_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
#pragma warning disable 0169
		static Delegate GetGetTransformer_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler ()
		{
			if (cb_getTransformer_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ == null)
				cb_getTransformer_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetTransformer_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_getTransformer_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static IntPtr n_GetTransformer_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, IntPtr native_which)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency which = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_which, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetTransformer (which));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='getTransformer' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.YAxis.AxisDependency']]"
		[Register ("getTransformer", "(Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)Lcom/github/mikephil/charting/utils/Transformer;", "GetGetTransformer_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler")]
		public virtual unsafe global::MikePhil.Charting.Util.Transformer GetTransformer (global::MikePhil.Charting.Components.YAxis.AxisDependency which)
		{
			const string __id = "getTransformer.(Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)Lcom/github/mikephil/charting/utils/Transformer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((which == null) ? IntPtr.Zero : ((global::Java.Lang.Object) which).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getValuesByTouchPoint_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_;
#pragma warning disable 0169
		static Delegate GetGetValuesByTouchPoint_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler ()
		{
			if (cb_getValuesByTouchPoint_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_ == null)
				cb_getValuesByTouchPoint_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr, IntPtr>) n_GetValuesByTouchPoint_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_getValuesByTouchPoint_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static IntPtr n_GetValuesByTouchPoint_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, float x, float y, IntPtr native_axis)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency axis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_axis, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetValuesByTouchPoint (x, y, axis));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='getValuesByTouchPoint' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='com.github.mikephil.charting.components.YAxis.AxisDependency']]"
		[Register ("getValuesByTouchPoint", "(FFLcom/github/mikephil/charting/components/YAxis$AxisDependency;)Lcom/github/mikephil/charting/utils/MPPointD;", "GetGetValuesByTouchPoint_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler")]
		public virtual unsafe global::MikePhil.Charting.Util.MPPointD GetValuesByTouchPoint (float x, float y, global::MikePhil.Charting.Components.YAxis.AxisDependency axis)
		{
			const string __id = "getValuesByTouchPoint.(FFLcom/github/mikephil/charting/components/YAxis$AxisDependency;)Lcom/github/mikephil/charting/utils/MPPointD;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointD> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getValuesByTouchPoint_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_Lcom_github_mikephil_charting_utils_MPPointD_;
#pragma warning disable 0169
		static Delegate GetGetValuesByTouchPoint_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_Lcom_github_mikephil_charting_utils_MPPointD_Handler ()
		{
			if (cb_getValuesByTouchPoint_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_Lcom_github_mikephil_charting_utils_MPPointD_ == null)
				cb_getValuesByTouchPoint_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_Lcom_github_mikephil_charting_utils_MPPointD_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, IntPtr, IntPtr>) n_GetValuesByTouchPoint_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_Lcom_github_mikephil_charting_utils_MPPointD_);
			return cb_getValuesByTouchPoint_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_Lcom_github_mikephil_charting_utils_MPPointD_;
		}

		static void n_GetValuesByTouchPoint_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_Lcom_github_mikephil_charting_utils_MPPointD_ (IntPtr jnienv, IntPtr native__this, float x, float y, IntPtr native_axis, IntPtr native_outputPoint)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency axis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_axis, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Util.MPPointD outputPoint = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointD> (native_outputPoint, JniHandleOwnership.DoNotTransfer);
			__this.GetValuesByTouchPoint (x, y, axis, outputPoint);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='getValuesByTouchPoint' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='com.github.mikephil.charting.components.YAxis.AxisDependency'] and parameter[4][@type='com.github.mikephil.charting.utils.MPPointD']]"
		[Register ("getValuesByTouchPoint", "(FFLcom/github/mikephil/charting/components/YAxis$AxisDependency;Lcom/github/mikephil/charting/utils/MPPointD;)V", "GetGetValuesByTouchPoint_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_Lcom_github_mikephil_charting_utils_MPPointD_Handler")]
		public virtual unsafe void GetValuesByTouchPoint (float x, float y, global::MikePhil.Charting.Components.YAxis.AxisDependency axis, global::MikePhil.Charting.Util.MPPointD outputPoint)
		{
			const string __id = "getValuesByTouchPoint.(FFLcom/github/mikephil/charting/components/YAxis$AxisDependency;Lcom/github/mikephil/charting/utils/MPPointD;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				__args [3] = new JniArgumentValue ((outputPoint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputPoint).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
#pragma warning disable 0169
		static Delegate GetIsInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler ()
		{
			if (cb_isInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ == null)
				cb_isInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_IsInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_isInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static bool n_IsInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, IntPtr native_axis)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency axis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_axis, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsInverted (axis);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='isInverted' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.YAxis.AxisDependency']]"
		[Register ("isInverted", "(Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)Z", "GetIsInverted_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler")]
		public virtual unsafe bool IsInverted (global::MikePhil.Charting.Components.YAxis.AxisDependency axis)
		{
			const string __id = "isInverted.(Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_moveViewTo_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_;
#pragma warning disable 0169
		static Delegate GetMoveViewTo_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler ()
		{
			if (cb_moveViewTo_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_ == null)
				cb_moveViewTo_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, IntPtr>) n_MoveViewTo_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_moveViewTo_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static void n_MoveViewTo_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, float xValue, float yValue, IntPtr native_axis)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency axis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_axis, JniHandleOwnership.DoNotTransfer);
			__this.MoveViewTo (xValue, yValue, axis);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='moveViewTo' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='com.github.mikephil.charting.components.YAxis.AxisDependency']]"
		[Register ("moveViewTo", "(FFLcom/github/mikephil/charting/components/YAxis$AxisDependency;)V", "GetMoveViewTo_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler")]
		public virtual unsafe void MoveViewTo (float xValue, float yValue, global::MikePhil.Charting.Components.YAxis.AxisDependency axis)
		{
			const string __id = "moveViewTo.(FFLcom/github/mikephil/charting/components/YAxis$AxisDependency;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (xValue);
				__args [1] = new JniArgumentValue (yValue);
				__args [2] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_moveViewToAnimated_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_J;
#pragma warning disable 0169
		static Delegate GetMoveViewToAnimated_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_JHandler ()
		{
			if (cb_moveViewToAnimated_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_J == null)
				cb_moveViewToAnimated_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, IntPtr, long>) n_MoveViewToAnimated_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_J);
			return cb_moveViewToAnimated_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_J;
		}

		static void n_MoveViewToAnimated_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_J (IntPtr jnienv, IntPtr native__this, float xValue, float yValue, IntPtr native_axis, long duration)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency axis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_axis, JniHandleOwnership.DoNotTransfer);
			__this.MoveViewToAnimated (xValue, yValue, axis, duration);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='moveViewToAnimated' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='com.github.mikephil.charting.components.YAxis.AxisDependency'] and parameter[4][@type='long']]"
		[Register ("moveViewToAnimated", "(FFLcom/github/mikephil/charting/components/YAxis$AxisDependency;J)V", "GetMoveViewToAnimated_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_JHandler")]
		public virtual unsafe void MoveViewToAnimated (float xValue, float yValue, global::MikePhil.Charting.Components.YAxis.AxisDependency axis, long duration)
		{
			const string __id = "moveViewToAnimated.(FFLcom/github/mikephil/charting/components/YAxis$AxisDependency;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (xValue);
				__args [1] = new JniArgumentValue (yValue);
				__args [2] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				__args [3] = new JniArgumentValue (duration);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_moveViewToX_F;
#pragma warning disable 0169
		static Delegate GetMoveViewToX_FHandler ()
		{
			if (cb_moveViewToX_F == null)
				cb_moveViewToX_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_MoveViewToX_F);
			return cb_moveViewToX_F;
		}

		static void n_MoveViewToX_F (IntPtr jnienv, IntPtr native__this, float xValue)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MoveViewToX (xValue);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='moveViewToX' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("moveViewToX", "(F)V", "GetMoveViewToX_FHandler")]
		public virtual unsafe void MoveViewToX (float xValue)
		{
			const string __id = "moveViewToX.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (xValue);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDataSetChanged ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='notifyDataSetChanged' and count(parameter)=0]"
		[Register ("notifyDataSetChanged", "()V", "GetNotifyDataSetChangedHandler")]
		public override unsafe void NotifyDataSetChanged ()
		{
			const string __id = "notifyDataSetChanged.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_prepareOffsetMatrix;
#pragma warning disable 0169
		static Delegate GetPrepareOffsetMatrixHandler ()
		{
			if (cb_prepareOffsetMatrix == null)
				cb_prepareOffsetMatrix = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PrepareOffsetMatrix);
			return cb_prepareOffsetMatrix;
		}

		static void n_PrepareOffsetMatrix (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PrepareOffsetMatrix ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='prepareOffsetMatrix' and count(parameter)=0]"
		[Register ("prepareOffsetMatrix", "()V", "GetPrepareOffsetMatrixHandler")]
		protected virtual unsafe void PrepareOffsetMatrix ()
		{
			const string __id = "prepareOffsetMatrix.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_prepareValuePxMatrix;
#pragma warning disable 0169
		static Delegate GetPrepareValuePxMatrixHandler ()
		{
			if (cb_prepareValuePxMatrix == null)
				cb_prepareValuePxMatrix = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_PrepareValuePxMatrix);
			return cb_prepareValuePxMatrix;
		}

		static void n_PrepareValuePxMatrix (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PrepareValuePxMatrix ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='prepareValuePxMatrix' and count(parameter)=0]"
		[Register ("prepareValuePxMatrix", "()V", "GetPrepareValuePxMatrixHandler")]
		protected virtual unsafe void PrepareValuePxMatrix ()
		{
			const string __id = "prepareValuePxMatrix.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_resetTracking;
#pragma warning disable 0169
		static Delegate GetResetTrackingHandler ()
		{
			if (cb_resetTracking == null)
				cb_resetTracking = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetTracking);
			return cb_resetTracking;
		}

		static void n_ResetTracking (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetTracking ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='resetTracking' and count(parameter)=0]"
		[Register ("resetTracking", "()V", "GetResetTrackingHandler")]
		public virtual unsafe void ResetTracking ()
		{
			const string __id = "resetTracking.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_resetViewPortOffsets;
#pragma warning disable 0169
		static Delegate GetResetViewPortOffsetsHandler ()
		{
			if (cb_resetViewPortOffsets == null)
				cb_resetViewPortOffsets = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetViewPortOffsets);
			return cb_resetViewPortOffsets;
		}

		static void n_ResetViewPortOffsets (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetViewPortOffsets ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='resetViewPortOffsets' and count(parameter)=0]"
		[Register ("resetViewPortOffsets", "()V", "GetResetViewPortOffsetsHandler")]
		public virtual unsafe void ResetViewPortOffsets ()
		{
			const string __id = "resetViewPortOffsets.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_resetZoom;
#pragma warning disable 0169
		static Delegate GetResetZoomHandler ()
		{
			if (cb_resetZoom == null)
				cb_resetZoom = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetZoom);
			return cb_resetZoom;
		}

		static void n_ResetZoom (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetZoom ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='resetZoom' and count(parameter)=0]"
		[Register ("resetZoom", "()V", "GetResetZoomHandler")]
		public virtual unsafe void ResetZoom ()
		{
			const string __id = "resetZoom.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setBorderColor_I;
#pragma warning disable 0169
		static Delegate GetSetBorderColor_IHandler ()
		{
			if (cb_setBorderColor_I == null)
				cb_setBorderColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetBorderColor_I);
			return cb_setBorderColor_I;
		}

		static void n_SetBorderColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBorderColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setBorderColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setBorderColor", "(I)V", "GetSetBorderColor_IHandler")]
		public virtual unsafe void SetBorderColor (int color)
		{
			const string __id = "setBorderColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setBorderWidth_F;
#pragma warning disable 0169
		static Delegate GetSetBorderWidth_FHandler ()
		{
			if (cb_setBorderWidth_F == null)
				cb_setBorderWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetBorderWidth_F);
			return cb_setBorderWidth_F;
		}

		static void n_SetBorderWidth_F (IntPtr jnienv, IntPtr native__this, float width)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBorderWidth (width);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setBorderWidth' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setBorderWidth", "(F)V", "GetSetBorderWidth_FHandler")]
		public virtual unsafe void SetBorderWidth (float width)
		{
			const string __id = "setBorderWidth.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (width);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setClipValuesToContent_Z;
#pragma warning disable 0169
		static Delegate GetSetClipValuesToContent_ZHandler ()
		{
			if (cb_setClipValuesToContent_Z == null)
				cb_setClipValuesToContent_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetClipValuesToContent_Z);
			return cb_setClipValuesToContent_Z;
		}

		static void n_SetClipValuesToContent_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetClipValuesToContent (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setClipValuesToContent' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setClipValuesToContent", "(Z)V", "GetSetClipValuesToContent_ZHandler")]
		public virtual unsafe void SetClipValuesToContent (bool enabled)
		{
			const string __id = "setClipValuesToContent.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDragOffsetX_F;
#pragma warning disable 0169
		static Delegate GetSetDragOffsetX_FHandler ()
		{
			if (cb_setDragOffsetX_F == null)
				cb_setDragOffsetX_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetDragOffsetX_F);
			return cb_setDragOffsetX_F;
		}

		static void n_SetDragOffsetX_F (IntPtr jnienv, IntPtr native__this, float offset)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDragOffsetX (offset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setDragOffsetX' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setDragOffsetX", "(F)V", "GetSetDragOffsetX_FHandler")]
		public virtual unsafe void SetDragOffsetX (float offset)
		{
			const string __id = "setDragOffsetX.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (offset);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDragOffsetY_F;
#pragma warning disable 0169
		static Delegate GetSetDragOffsetY_FHandler ()
		{
			if (cb_setDragOffsetY_F == null)
				cb_setDragOffsetY_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetDragOffsetY_F);
			return cb_setDragOffsetY_F;
		}

		static void n_SetDragOffsetY_F (IntPtr jnienv, IntPtr native__this, float offset)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDragOffsetY (offset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setDragOffsetY' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setDragOffsetY", "(F)V", "GetSetDragOffsetY_FHandler")]
		public virtual unsafe void SetDragOffsetY (float offset)
		{
			const string __id = "setDragOffsetY.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (offset);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawBorders_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawBorders_ZHandler ()
		{
			if (cb_setDrawBorders_Z == null)
				cb_setDrawBorders_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawBorders_Z);
			return cb_setDrawBorders_Z;
		}

		static void n_SetDrawBorders_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawBorders (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setDrawBorders' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawBorders", "(Z)V", "GetSetDrawBorders_ZHandler")]
		public virtual unsafe void SetDrawBorders (bool enabled)
		{
			const string __id = "setDrawBorders.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawGridBackground_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawGridBackground_ZHandler ()
		{
			if (cb_setDrawGridBackground_Z == null)
				cb_setDrawGridBackground_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawGridBackground_Z);
			return cb_setDrawGridBackground_Z;
		}

		static void n_SetDrawGridBackground_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawGridBackground (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setDrawGridBackground' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawGridBackground", "(Z)V", "GetSetDrawGridBackground_ZHandler")]
		public virtual unsafe void SetDrawGridBackground (bool enabled)
		{
			const string __id = "setDrawGridBackground.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setGridBackgroundColor_I;
#pragma warning disable 0169
		static Delegate GetSetGridBackgroundColor_IHandler ()
		{
			if (cb_setGridBackgroundColor_I == null)
				cb_setGridBackgroundColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetGridBackgroundColor_I);
			return cb_setGridBackgroundColor_I;
		}

		static void n_SetGridBackgroundColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetGridBackgroundColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setGridBackgroundColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setGridBackgroundColor", "(I)V", "GetSetGridBackgroundColor_IHandler")]
		public virtual unsafe void SetGridBackgroundColor (int color)
		{
			const string __id = "setGridBackgroundColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMaxVisibleValueCount_I;
#pragma warning disable 0169
		static Delegate GetSetMaxVisibleValueCount_IHandler ()
		{
			if (cb_setMaxVisibleValueCount_I == null)
				cb_setMaxVisibleValueCount_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetMaxVisibleValueCount_I);
			return cb_setMaxVisibleValueCount_I;
		}

		static void n_SetMaxVisibleValueCount_I (IntPtr jnienv, IntPtr native__this, int count)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaxVisibleValueCount (count);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setMaxVisibleValueCount' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setMaxVisibleValueCount", "(I)V", "GetSetMaxVisibleValueCount_IHandler")]
		public virtual unsafe void SetMaxVisibleValueCount (int count)
		{
			const string __id = "setMaxVisibleValueCount.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (count);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setOnDrawListener_Lcom_github_mikephil_charting_listener_OnDrawListener_;
#pragma warning disable 0169
		static Delegate GetSetOnDrawListener_Lcom_github_mikephil_charting_listener_OnDrawListener_Handler ()
		{
			if (cb_setOnDrawListener_Lcom_github_mikephil_charting_listener_OnDrawListener_ == null)
				cb_setOnDrawListener_Lcom_github_mikephil_charting_listener_OnDrawListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnDrawListener_Lcom_github_mikephil_charting_listener_OnDrawListener_);
			return cb_setOnDrawListener_Lcom_github_mikephil_charting_listener_OnDrawListener_;
		}

		static void n_SetOnDrawListener_Lcom_github_mikephil_charting_listener_OnDrawListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawListener)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Listener.IOnDrawListenerSupport drawListener = (global::MikePhil.Charting.Listener.IOnDrawListenerSupport)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Listener.IOnDrawListenerSupport> (native_drawListener, JniHandleOwnership.DoNotTransfer);
			__this.SetOnDrawListener (drawListener);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setOnDrawListener' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.listener.OnDrawListener']]"
		[Register ("setOnDrawListener", "(Lcom/github/mikephil/charting/listener/OnDrawListener;)V", "GetSetOnDrawListener_Lcom_github_mikephil_charting_listener_OnDrawListener_Handler")]
		public virtual unsafe void SetOnDrawListener (global::MikePhil.Charting.Listener.IOnDrawListenerSupport drawListener)
		{
			const string __id = "setOnDrawListener.(Lcom/github/mikephil/charting/listener/OnDrawListener;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((drawListener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawListener).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setPinchZoom_Z;
#pragma warning disable 0169
		static Delegate GetSetPinchZoom_ZHandler ()
		{
			if (cb_setPinchZoom_Z == null)
				cb_setPinchZoom_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetPinchZoom_Z);
			return cb_setPinchZoom_Z;
		}

		static void n_SetPinchZoom_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPinchZoom (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setPinchZoom' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setPinchZoom", "(Z)V", "GetSetPinchZoom_ZHandler")]
		public virtual unsafe void SetPinchZoom (bool enabled)
		{
			const string __id = "setPinchZoom.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setScaleEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetScaleEnabled_ZHandler ()
		{
			if (cb_setScaleEnabled_Z == null)
				cb_setScaleEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetScaleEnabled_Z);
			return cb_setScaleEnabled_Z;
		}

		static void n_SetScaleEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScaleEnabled (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setScaleEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setScaleEnabled", "(Z)V", "GetSetScaleEnabled_ZHandler")]
		public virtual unsafe void SetScaleEnabled (bool enabled)
		{
			const string __id = "setScaleEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setScaleMinima_FF;
#pragma warning disable 0169
		static Delegate GetSetScaleMinima_FFHandler ()
		{
			if (cb_setScaleMinima_FF == null)
				cb_setScaleMinima_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_SetScaleMinima_FF);
			return cb_setScaleMinima_FF;
		}

		static void n_SetScaleMinima_FF (IntPtr jnienv, IntPtr native__this, float scaleX, float scaleY)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScaleMinima (scaleX, scaleY);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setScaleMinima' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setScaleMinima", "(FF)V", "GetSetScaleMinima_FFHandler")]
		public virtual unsafe void SetScaleMinima (float scaleX, float scaleY)
		{
			const string __id = "setScaleMinima.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (scaleX);
				__args [1] = new JniArgumentValue (scaleY);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setViewPortOffsets_FFFF;
#pragma warning disable 0169
		static Delegate GetSetViewPortOffsets_FFFFHandler ()
		{
			if (cb_setViewPortOffsets_FFFF == null)
				cb_setViewPortOffsets_FFFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float>) n_SetViewPortOffsets_FFFF);
			return cb_setViewPortOffsets_FFFF;
		}

		static void n_SetViewPortOffsets_FFFF (IntPtr jnienv, IntPtr native__this, float left, float top, float right, float bottom)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetViewPortOffsets (left, top, right, bottom);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setViewPortOffsets' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("setViewPortOffsets", "(FFFF)V", "GetSetViewPortOffsets_FFFFHandler")]
		public virtual unsafe void SetViewPortOffsets (float left, float top, float right, float bottom)
		{
			const string __id = "setViewPortOffsets.(FFFF)V";
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

		static Delegate cb_setVisibleXRange_FF;
#pragma warning disable 0169
		static Delegate GetSetVisibleXRange_FFHandler ()
		{
			if (cb_setVisibleXRange_FF == null)
				cb_setVisibleXRange_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_SetVisibleXRange_FF);
			return cb_setVisibleXRange_FF;
		}

		static void n_SetVisibleXRange_FF (IntPtr jnienv, IntPtr native__this, float minXRange, float maxXRange)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVisibleXRange (minXRange, maxXRange);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setVisibleXRange' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setVisibleXRange", "(FF)V", "GetSetVisibleXRange_FFHandler")]
		public virtual unsafe void SetVisibleXRange (float minXRange, float maxXRange)
		{
			const string __id = "setVisibleXRange.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (minXRange);
				__args [1] = new JniArgumentValue (maxXRange);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setVisibleXRangeMaximum_F;
#pragma warning disable 0169
		static Delegate GetSetVisibleXRangeMaximum_FHandler ()
		{
			if (cb_setVisibleXRangeMaximum_F == null)
				cb_setVisibleXRangeMaximum_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetVisibleXRangeMaximum_F);
			return cb_setVisibleXRangeMaximum_F;
		}

		static void n_SetVisibleXRangeMaximum_F (IntPtr jnienv, IntPtr native__this, float maxXRange)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVisibleXRangeMaximum (maxXRange);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setVisibleXRangeMaximum' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setVisibleXRangeMaximum", "(F)V", "GetSetVisibleXRangeMaximum_FHandler")]
		public virtual unsafe void SetVisibleXRangeMaximum (float maxXRange)
		{
			const string __id = "setVisibleXRangeMaximum.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (maxXRange);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setVisibleXRangeMinimum_F;
#pragma warning disable 0169
		static Delegate GetSetVisibleXRangeMinimum_FHandler ()
		{
			if (cb_setVisibleXRangeMinimum_F == null)
				cb_setVisibleXRangeMinimum_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetVisibleXRangeMinimum_F);
			return cb_setVisibleXRangeMinimum_F;
		}

		static void n_SetVisibleXRangeMinimum_F (IntPtr jnienv, IntPtr native__this, float minXRange)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetVisibleXRangeMinimum (minXRange);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setVisibleXRangeMinimum' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setVisibleXRangeMinimum", "(F)V", "GetSetVisibleXRangeMinimum_FHandler")]
		public virtual unsafe void SetVisibleXRangeMinimum (float minXRange)
		{
			const string __id = "setVisibleXRangeMinimum.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (minXRange);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setVisibleYRange_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_;
#pragma warning disable 0169
		static Delegate GetSetVisibleYRange_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler ()
		{
			if (cb_setVisibleYRange_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_ == null)
				cb_setVisibleYRange_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, IntPtr>) n_SetVisibleYRange_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_setVisibleYRange_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static void n_SetVisibleYRange_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, float minYRange, float maxYRange, IntPtr native_axis)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency axis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_axis, JniHandleOwnership.DoNotTransfer);
			__this.SetVisibleYRange (minYRange, maxYRange, axis);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setVisibleYRange' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='com.github.mikephil.charting.components.YAxis.AxisDependency']]"
		[Register ("setVisibleYRange", "(FFLcom/github/mikephil/charting/components/YAxis$AxisDependency;)V", "GetSetVisibleYRange_FFLcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler")]
		public virtual unsafe void SetVisibleYRange (float minYRange, float maxYRange, global::MikePhil.Charting.Components.YAxis.AxisDependency axis)
		{
			const string __id = "setVisibleYRange.(FFLcom/github/mikephil/charting/components/YAxis$AxisDependency;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (minYRange);
				__args [1] = new JniArgumentValue (maxYRange);
				__args [2] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setVisibleYRangeMaximum_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_;
#pragma warning disable 0169
		static Delegate GetSetVisibleYRangeMaximum_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler ()
		{
			if (cb_setVisibleYRangeMaximum_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_ == null)
				cb_setVisibleYRangeMaximum_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, IntPtr>) n_SetVisibleYRangeMaximum_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_setVisibleYRangeMaximum_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static void n_SetVisibleYRangeMaximum_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, float maxYRange, IntPtr native_axis)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency axis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_axis, JniHandleOwnership.DoNotTransfer);
			__this.SetVisibleYRangeMaximum (maxYRange, axis);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setVisibleYRangeMaximum' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='com.github.mikephil.charting.components.YAxis.AxisDependency']]"
		[Register ("setVisibleYRangeMaximum", "(FLcom/github/mikephil/charting/components/YAxis$AxisDependency;)V", "GetSetVisibleYRangeMaximum_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler")]
		public virtual unsafe void SetVisibleYRangeMaximum (float maxYRange, global::MikePhil.Charting.Components.YAxis.AxisDependency axis)
		{
			const string __id = "setVisibleYRangeMaximum.(FLcom/github/mikephil/charting/components/YAxis$AxisDependency;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (maxYRange);
				__args [1] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setVisibleYRangeMinimum_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_;
#pragma warning disable 0169
		static Delegate GetSetVisibleYRangeMinimum_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler ()
		{
			if (cb_setVisibleYRangeMinimum_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_ == null)
				cb_setVisibleYRangeMinimum_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, IntPtr>) n_SetVisibleYRangeMinimum_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_setVisibleYRangeMinimum_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static void n_SetVisibleYRangeMinimum_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, float minYRange, IntPtr native_axis)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency axis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_axis, JniHandleOwnership.DoNotTransfer);
			__this.SetVisibleYRangeMinimum (minYRange, axis);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setVisibleYRangeMinimum' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='com.github.mikephil.charting.components.YAxis.AxisDependency']]"
		[Register ("setVisibleYRangeMinimum", "(FLcom/github/mikephil/charting/components/YAxis$AxisDependency;)V", "GetSetVisibleYRangeMinimum_FLcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler")]
		public virtual unsafe void SetVisibleYRangeMinimum (float minYRange, global::MikePhil.Charting.Components.YAxis.AxisDependency axis)
		{
			const string __id = "setVisibleYRangeMinimum.(FLcom/github/mikephil/charting/components/YAxis$AxisDependency;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (minYRange);
				__args [1] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setXAxisRenderer_Lcom_github_mikephil_charting_renderer_XAxisRenderer_;
#pragma warning disable 0169
		static Delegate GetSetXAxisRenderer_Lcom_github_mikephil_charting_renderer_XAxisRenderer_Handler ()
		{
			if (cb_setXAxisRenderer_Lcom_github_mikephil_charting_renderer_XAxisRenderer_ == null)
				cb_setXAxisRenderer_Lcom_github_mikephil_charting_renderer_XAxisRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetXAxisRenderer_Lcom_github_mikephil_charting_renderer_XAxisRenderer_);
			return cb_setXAxisRenderer_Lcom_github_mikephil_charting_renderer_XAxisRenderer_;
		}

		static void n_SetXAxisRenderer_Lcom_github_mikephil_charting_renderer_XAxisRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_xAxisRenderer)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Renderer.XAxisRenderer xAxisRenderer = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.XAxisRenderer> (native_xAxisRenderer, JniHandleOwnership.DoNotTransfer);
			__this.SetXAxisRenderer (xAxisRenderer);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='setXAxisRenderer' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.renderer.XAxisRenderer']]"
		[Register ("setXAxisRenderer", "(Lcom/github/mikephil/charting/renderer/XAxisRenderer;)V", "GetSetXAxisRenderer_Lcom_github_mikephil_charting_renderer_XAxisRenderer_Handler")]
		public virtual unsafe void SetXAxisRenderer (global::MikePhil.Charting.Renderer.XAxisRenderer xAxisRenderer)
		{
			const string __id = "setXAxisRenderer.(Lcom/github/mikephil/charting/renderer/XAxisRenderer;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((xAxisRenderer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) xAxisRenderer).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_zoom_FFFF;
#pragma warning disable 0169
		static Delegate GetZoom_FFFFHandler ()
		{
			if (cb_zoom_FFFF == null)
				cb_zoom_FFFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float>) n_Zoom_FFFF);
			return cb_zoom_FFFF;
		}

		static void n_Zoom_FFFF (IntPtr jnienv, IntPtr native__this, float scaleX, float scaleY, float x, float y)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Zoom (scaleX, scaleY, x, y);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='zoom' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("zoom", "(FFFF)V", "GetZoom_FFFFHandler")]
		public virtual unsafe void Zoom (float scaleX, float scaleY, float x, float y)
		{
			const string __id = "zoom.(FFFF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (scaleX);
				__args [1] = new JniArgumentValue (scaleY);
				__args [2] = new JniArgumentValue (x);
				__args [3] = new JniArgumentValue (y);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_zoom_FFFFLcom_github_mikephil_charting_components_YAxis_AxisDependency_;
#pragma warning disable 0169
		static Delegate GetZoom_FFFFLcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler ()
		{
			if (cb_zoom_FFFFLcom_github_mikephil_charting_components_YAxis_AxisDependency_ == null)
				cb_zoom_FFFFLcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float, IntPtr>) n_Zoom_FFFFLcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_zoom_FFFFLcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static void n_Zoom_FFFFLcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, float scaleX, float scaleY, float xValue, float yValue, IntPtr native_axis)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency axis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_axis, JniHandleOwnership.DoNotTransfer);
			__this.Zoom (scaleX, scaleY, xValue, yValue, axis);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='zoom' and count(parameter)=5 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='com.github.mikephil.charting.components.YAxis.AxisDependency']]"
		[Register ("zoom", "(FFFFLcom/github/mikephil/charting/components/YAxis$AxisDependency;)V", "GetZoom_FFFFLcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler")]
		public virtual unsafe void Zoom (float scaleX, float scaleY, float xValue, float yValue, global::MikePhil.Charting.Components.YAxis.AxisDependency axis)
		{
			const string __id = "zoom.(FFFFLcom/github/mikephil/charting/components/YAxis$AxisDependency;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (scaleX);
				__args [1] = new JniArgumentValue (scaleY);
				__args [2] = new JniArgumentValue (xValue);
				__args [3] = new JniArgumentValue (yValue);
				__args [4] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_zoomAndCenterAnimated_FFFFLcom_github_mikephil_charting_components_YAxis_AxisDependency_J;
#pragma warning disable 0169
		static Delegate GetZoomAndCenterAnimated_FFFFLcom_github_mikephil_charting_components_YAxis_AxisDependency_JHandler ()
		{
			if (cb_zoomAndCenterAnimated_FFFFLcom_github_mikephil_charting_components_YAxis_AxisDependency_J == null)
				cb_zoomAndCenterAnimated_FFFFLcom_github_mikephil_charting_components_YAxis_AxisDependency_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float, IntPtr, long>) n_ZoomAndCenterAnimated_FFFFLcom_github_mikephil_charting_components_YAxis_AxisDependency_J);
			return cb_zoomAndCenterAnimated_FFFFLcom_github_mikephil_charting_components_YAxis_AxisDependency_J;
		}

		static void n_ZoomAndCenterAnimated_FFFFLcom_github_mikephil_charting_components_YAxis_AxisDependency_J (IntPtr jnienv, IntPtr native__this, float scaleX, float scaleY, float xValue, float yValue, IntPtr native_axis, long duration)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.YAxis.AxisDependency axis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_axis, JniHandleOwnership.DoNotTransfer);
			__this.ZoomAndCenterAnimated (scaleX, scaleY, xValue, yValue, axis, duration);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='zoomAndCenterAnimated' and count(parameter)=6 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='com.github.mikephil.charting.components.YAxis.AxisDependency'] and parameter[6][@type='long']]"
		[Register ("zoomAndCenterAnimated", "(FFFFLcom/github/mikephil/charting/components/YAxis$AxisDependency;J)V", "GetZoomAndCenterAnimated_FFFFLcom_github_mikephil_charting_components_YAxis_AxisDependency_JHandler")]
		public virtual unsafe void ZoomAndCenterAnimated (float scaleX, float scaleY, float xValue, float yValue, global::MikePhil.Charting.Components.YAxis.AxisDependency axis, long duration)
		{
			const string __id = "zoomAndCenterAnimated.(FFFFLcom/github/mikephil/charting/components/YAxis$AxisDependency;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (scaleX);
				__args [1] = new JniArgumentValue (scaleY);
				__args [2] = new JniArgumentValue (xValue);
				__args [3] = new JniArgumentValue (yValue);
				__args [4] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				__args [5] = new JniArgumentValue (duration);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_zoomIn;
#pragma warning disable 0169
		static Delegate GetZoomInHandler ()
		{
			if (cb_zoomIn == null)
				cb_zoomIn = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ZoomIn);
			return cb_zoomIn;
		}

		static void n_ZoomIn (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomIn ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='zoomIn' and count(parameter)=0]"
		[Register ("zoomIn", "()V", "GetZoomInHandler")]
		public virtual unsafe void ZoomIn ()
		{
			const string __id = "zoomIn.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_zoomOut;
#pragma warning disable 0169
		static Delegate GetZoomOutHandler ()
		{
			if (cb_zoomOut == null)
				cb_zoomOut = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ZoomOut);
			return cb_zoomOut;
		}

		static void n_ZoomOut (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomOut ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='zoomOut' and count(parameter)=0]"
		[Register ("zoomOut", "()V", "GetZoomOutHandler")]
		public virtual unsafe void ZoomOut ()
		{
			const string __id = "zoomOut.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_zoomToCenter_FF;
#pragma warning disable 0169
		static Delegate GetZoomToCenter_FFHandler ()
		{
			if (cb_zoomToCenter_FF == null)
				cb_zoomToCenter_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_ZoomToCenter_FF);
			return cb_zoomToCenter_FF;
		}

		static void n_ZoomToCenter_FF (IntPtr jnienv, IntPtr native__this, float scaleX, float scaleY)
		{
			global::MikePhil.Charting.Charts.BarLineChartBase __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.BarLineChartBase> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ZoomToCenter (scaleX, scaleY);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='BarLineChartBase']/method[@name='zoomToCenter' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("zoomToCenter", "(FF)V", "GetZoomToCenter_FFHandler")]
		public virtual unsafe void ZoomToCenter (float scaleX, float scaleY)
		{
			const string __id = "zoomToCenter.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (scaleX);
				__args [1] = new JniArgumentValue (scaleY);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/charts/BarLineChartBase", DoNotGenerateAcw=true)]
	internal partial class BarLineChartBaseInvoker : BarLineChartBase {

		public BarLineChartBaseInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/charts/BarLineChartBase", typeof (BarLineChartBaseInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
