using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/utils/ViewPortHandler", DoNotGenerateAcw=true)]
	public partial class ViewPortHandler : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/field[@name='mCenterViewPortMatrixBuffer']"
		[Register ("mCenterViewPortMatrixBuffer")]
		protected global::Android.Graphics.Matrix MCenterViewPortMatrixBuffer {
			get {
				const string __id = "mCenterViewPortMatrixBuffer.Landroid/graphics/Matrix;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mCenterViewPortMatrixBuffer.Landroid/graphics/Matrix;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/field[@name='mChartHeight']"
		[Register ("mChartHeight")]
		protected float MChartHeight {
			get {
				const string __id = "mChartHeight.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mChartHeight.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/field[@name='mChartWidth']"
		[Register ("mChartWidth")]
		protected float MChartWidth {
			get {
				const string __id = "mChartWidth.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mChartWidth.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/field[@name='mContentRect']"
		[Register ("mContentRect")]
		protected global::Android.Graphics.RectF MContentRect {
			get {
				const string __id = "mContentRect.Landroid/graphics/RectF;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mContentRect.Landroid/graphics/RectF;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/field[@name='mMatrixTouch']"
		[Register ("mMatrixTouch")]
		protected global::Android.Graphics.Matrix MMatrixTouch {
			get {
				const string __id = "mMatrixTouch.Landroid/graphics/Matrix;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mMatrixTouch.Landroid/graphics/Matrix;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/field[@name='matrixBuffer']"
		[Register ("matrixBuffer")]
		protected IList<float> MatrixBuffer {
			get {
				const string __id = "matrixBuffer.[F";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<float>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "matrixBuffer.[F";

				IntPtr native_value = global::Android.Runtime.JavaArray<float>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/field[@name='valsBufferForFitScreen']"
		[Register ("valsBufferForFitScreen")]
		protected IList<float> ValsBufferForFitScreen {
			get {
				const string __id = "valsBufferForFitScreen.[F";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<float>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "valsBufferForFitScreen.[F";

				IntPtr native_value = global::Android.Runtime.JavaArray<float>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/utils/ViewPortHandler", typeof (ViewPortHandler));
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

		protected ViewPortHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/constructor[@name='ViewPortHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ViewPortHandler ()
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

		static Delegate cb_getChartHeight;
#pragma warning disable 0169
		static Delegate GetGetChartHeightHandler ()
		{
			if (cb_getChartHeight == null)
				cb_getChartHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetChartHeight);
			return cb_getChartHeight;
		}

		static float n_GetChartHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChartHeight;
		}
#pragma warning restore 0169

		public virtual unsafe float ChartHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='getChartHeight' and count(parameter)=0]"
			[Register ("getChartHeight", "()F", "GetGetChartHeightHandler")]
			get {
				const string __id = "getChartHeight.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getChartWidth;
#pragma warning disable 0169
		static Delegate GetGetChartWidthHandler ()
		{
			if (cb_getChartWidth == null)
				cb_getChartWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetChartWidth);
			return cb_getChartWidth;
		}

		static float n_GetChartWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ChartWidth;
		}
#pragma warning restore 0169

		public virtual unsafe float ChartWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='getChartWidth' and count(parameter)=0]"
			[Register ("getChartWidth", "()F", "GetGetChartWidthHandler")]
			get {
				const string __id = "getChartWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getContentCenter;
#pragma warning disable 0169
		static Delegate GetGetContentCenterHandler ()
		{
			if (cb_getContentCenter == null)
				cb_getContentCenter = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContentCenter);
			return cb_getContentCenter;
		}

		static IntPtr n_GetContentCenter (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentCenter);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Util.MPPointF ContentCenter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='getContentCenter' and count(parameter)=0]"
			[Register ("getContentCenter", "()Lcom/github/mikephil/charting/utils/MPPointF;", "GetGetContentCenterHandler")]
			get {
				const string __id = "getContentCenter.()Lcom/github/mikephil/charting/utils/MPPointF;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
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
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ContentRect);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.RectF ContentRect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='getContentRect' and count(parameter)=0]"
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

		static Delegate cb_hasChartDimens;
#pragma warning disable 0169
		static Delegate GetHasChartDimensHandler ()
		{
			if (cb_hasChartDimens == null)
				cb_hasChartDimens = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasChartDimens);
			return cb_hasChartDimens;
		}

		static bool n_HasChartDimens (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasChartDimens;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasChartDimens {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='hasChartDimens' and count(parameter)=0]"
			[Register ("hasChartDimens", "()Z", "GetHasChartDimensHandler")]
			get {
				const string __id = "hasChartDimens.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
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
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasNoDragOffset;
		}
#pragma warning restore 0169

		public virtual unsafe bool HasNoDragOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='hasNoDragOffset' and count(parameter)=0]"
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
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFullyZoomedOut;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsFullyZoomedOut {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='isFullyZoomedOut' and count(parameter)=0]"
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

		static Delegate cb_isFullyZoomedOutX;
#pragma warning disable 0169
		static Delegate GetIsFullyZoomedOutXHandler ()
		{
			if (cb_isFullyZoomedOutX == null)
				cb_isFullyZoomedOutX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFullyZoomedOutX);
			return cb_isFullyZoomedOutX;
		}

		static bool n_IsFullyZoomedOutX (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFullyZoomedOutX;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsFullyZoomedOutX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='isFullyZoomedOutX' and count(parameter)=0]"
			[Register ("isFullyZoomedOutX", "()Z", "GetIsFullyZoomedOutXHandler")]
			get {
				const string __id = "isFullyZoomedOutX.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isFullyZoomedOutY;
#pragma warning disable 0169
		static Delegate GetIsFullyZoomedOutYHandler ()
		{
			if (cb_isFullyZoomedOutY == null)
				cb_isFullyZoomedOutY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsFullyZoomedOutY);
			return cb_isFullyZoomedOutY;
		}

		static bool n_IsFullyZoomedOutY (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsFullyZoomedOutY;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsFullyZoomedOutY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='isFullyZoomedOutY' and count(parameter)=0]"
			[Register ("isFullyZoomedOutY", "()Z", "GetIsFullyZoomedOutYHandler")]
			get {
				const string __id = "isFullyZoomedOutY.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMatrixTouch;
#pragma warning disable 0169
		static Delegate GetGetMatrixTouchHandler ()
		{
			if (cb_getMatrixTouch == null)
				cb_getMatrixTouch = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMatrixTouch);
			return cb_getMatrixTouch;
		}

		static IntPtr n_GetMatrixTouch (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MatrixTouch);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Matrix MatrixTouch {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='getMatrixTouch' and count(parameter)=0]"
			[Register ("getMatrixTouch", "()Landroid/graphics/Matrix;", "GetGetMatrixTouchHandler")]
			get {
				const string __id = "getMatrixTouch.()Landroid/graphics/Matrix;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxScaleX;
#pragma warning disable 0169
		static Delegate GetGetMaxScaleXHandler ()
		{
			if (cb_getMaxScaleX == null)
				cb_getMaxScaleX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMaxScaleX);
			return cb_getMaxScaleX;
		}

		static float n_GetMaxScaleX (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxScaleX;
		}
#pragma warning restore 0169

		public virtual unsafe float MaxScaleX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='getMaxScaleX' and count(parameter)=0]"
			[Register ("getMaxScaleX", "()F", "GetGetMaxScaleXHandler")]
			get {
				const string __id = "getMaxScaleX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMaxScaleY;
#pragma warning disable 0169
		static Delegate GetGetMaxScaleYHandler ()
		{
			if (cb_getMaxScaleY == null)
				cb_getMaxScaleY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMaxScaleY);
			return cb_getMaxScaleY;
		}

		static float n_GetMaxScaleY (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxScaleY;
		}
#pragma warning restore 0169

		public virtual unsafe float MaxScaleY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='getMaxScaleY' and count(parameter)=0]"
			[Register ("getMaxScaleY", "()F", "GetGetMaxScaleYHandler")]
			get {
				const string __id = "getMaxScaleY.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMinScaleX;
#pragma warning disable 0169
		static Delegate GetGetMinScaleXHandler ()
		{
			if (cb_getMinScaleX == null)
				cb_getMinScaleX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMinScaleX);
			return cb_getMinScaleX;
		}

		static float n_GetMinScaleX (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinScaleX;
		}
#pragma warning restore 0169

		public virtual unsafe float MinScaleX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='getMinScaleX' and count(parameter)=0]"
			[Register ("getMinScaleX", "()F", "GetGetMinScaleXHandler")]
			get {
				const string __id = "getMinScaleX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMinScaleY;
#pragma warning disable 0169
		static Delegate GetGetMinScaleYHandler ()
		{
			if (cb_getMinScaleY == null)
				cb_getMinScaleY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMinScaleY);
			return cb_getMinScaleY;
		}

		static float n_GetMinScaleY (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinScaleY;
		}
#pragma warning restore 0169

		public virtual unsafe float MinScaleY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='getMinScaleY' and count(parameter)=0]"
			[Register ("getMinScaleY", "()F", "GetGetMinScaleYHandler")]
			get {
				const string __id = "getMinScaleY.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getScaleX;
#pragma warning disable 0169
		static Delegate GetGetScaleXHandler ()
		{
			if (cb_getScaleX == null)
				cb_getScaleX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetScaleX);
			return cb_getScaleX;
		}

		static float n_GetScaleX (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScaleX;
		}
#pragma warning restore 0169

		public virtual unsafe float ScaleX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='getScaleX' and count(parameter)=0]"
			[Register ("getScaleX", "()F", "GetGetScaleXHandler")]
			get {
				const string __id = "getScaleX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getScaleY;
#pragma warning disable 0169
		static Delegate GetGetScaleYHandler ()
		{
			if (cb_getScaleY == null)
				cb_getScaleY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetScaleY);
			return cb_getScaleY;
		}

		static float n_GetScaleY (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScaleY;
		}
#pragma warning restore 0169

		public virtual unsafe float ScaleY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='getScaleY' and count(parameter)=0]"
			[Register ("getScaleY", "()F", "GetGetScaleYHandler")]
			get {
				const string __id = "getScaleY.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSmallestContentExtension;
#pragma warning disable 0169
		static Delegate GetGetSmallestContentExtensionHandler ()
		{
			if (cb_getSmallestContentExtension == null)
				cb_getSmallestContentExtension = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetSmallestContentExtension);
			return cb_getSmallestContentExtension;
		}

		static float n_GetSmallestContentExtension (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SmallestContentExtension;
		}
#pragma warning restore 0169

		public virtual unsafe float SmallestContentExtension {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='getSmallestContentExtension' and count(parameter)=0]"
			[Register ("getSmallestContentExtension", "()F", "GetGetSmallestContentExtensionHandler")]
			get {
				const string __id = "getSmallestContentExtension.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTransX;
#pragma warning disable 0169
		static Delegate GetGetTransXHandler ()
		{
			if (cb_getTransX == null)
				cb_getTransX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetTransX);
			return cb_getTransX;
		}

		static float n_GetTransX (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TransX;
		}
#pragma warning restore 0169

		public virtual unsafe float TransX {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='getTransX' and count(parameter)=0]"
			[Register ("getTransX", "()F", "GetGetTransXHandler")]
			get {
				const string __id = "getTransX.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTransY;
#pragma warning disable 0169
		static Delegate GetGetTransYHandler ()
		{
			if (cb_getTransY == null)
				cb_getTransY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetTransY);
			return cb_getTransY;
		}

		static float n_GetTransY (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TransY;
		}
#pragma warning restore 0169

		public virtual unsafe float TransY {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='getTransY' and count(parameter)=0]"
			[Register ("getTransY", "()F", "GetGetTransYHandler")]
			get {
				const string __id = "getTransY.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_canZoomInMoreX;
#pragma warning disable 0169
		static Delegate GetCanZoomInMoreXHandler ()
		{
			if (cb_canZoomInMoreX == null)
				cb_canZoomInMoreX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanZoomInMoreX);
			return cb_canZoomInMoreX;
		}

		static bool n_CanZoomInMoreX (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanZoomInMoreX ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='canZoomInMoreX' and count(parameter)=0]"
		[Register ("canZoomInMoreX", "()Z", "GetCanZoomInMoreXHandler")]
		public virtual unsafe bool CanZoomInMoreX ()
		{
			const string __id = "canZoomInMoreX.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_canZoomInMoreY;
#pragma warning disable 0169
		static Delegate GetCanZoomInMoreYHandler ()
		{
			if (cb_canZoomInMoreY == null)
				cb_canZoomInMoreY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanZoomInMoreY);
			return cb_canZoomInMoreY;
		}

		static bool n_CanZoomInMoreY (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanZoomInMoreY ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='canZoomInMoreY' and count(parameter)=0]"
		[Register ("canZoomInMoreY", "()Z", "GetCanZoomInMoreYHandler")]
		public virtual unsafe bool CanZoomInMoreY ()
		{
			const string __id = "canZoomInMoreY.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_canZoomOutMoreX;
#pragma warning disable 0169
		static Delegate GetCanZoomOutMoreXHandler ()
		{
			if (cb_canZoomOutMoreX == null)
				cb_canZoomOutMoreX = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanZoomOutMoreX);
			return cb_canZoomOutMoreX;
		}

		static bool n_CanZoomOutMoreX (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanZoomOutMoreX ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='canZoomOutMoreX' and count(parameter)=0]"
		[Register ("canZoomOutMoreX", "()Z", "GetCanZoomOutMoreXHandler")]
		public virtual unsafe bool CanZoomOutMoreX ()
		{
			const string __id = "canZoomOutMoreX.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_canZoomOutMoreY;
#pragma warning disable 0169
		static Delegate GetCanZoomOutMoreYHandler ()
		{
			if (cb_canZoomOutMoreY == null)
				cb_canZoomOutMoreY = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanZoomOutMoreY);
			return cb_canZoomOutMoreY;
		}

		static bool n_CanZoomOutMoreY (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanZoomOutMoreY ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='canZoomOutMoreY' and count(parameter)=0]"
		[Register ("canZoomOutMoreY", "()Z", "GetCanZoomOutMoreYHandler")]
		public virtual unsafe bool CanZoomOutMoreY ()
		{
			const string __id = "canZoomOutMoreY.()Z";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_centerViewPort_arrayFLandroid_view_View_;
#pragma warning disable 0169
		static Delegate GetCenterViewPort_arrayFLandroid_view_View_Handler ()
		{
			if (cb_centerViewPort_arrayFLandroid_view_View_ == null)
				cb_centerViewPort_arrayFLandroid_view_View_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CenterViewPort_arrayFLandroid_view_View_);
			return cb_centerViewPort_arrayFLandroid_view_View_;
		}

		static void n_CenterViewPort_arrayFLandroid_view_View_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transformedPts, IntPtr native_view)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] transformedPts = (float[]) JNIEnv.GetArray (native_transformedPts, JniHandleOwnership.DoNotTransfer, typeof (float));
			global::Android.Views.View view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.CenterViewPort (transformedPts, view);
			if (transformedPts != null)
				JNIEnv.CopyArray (transformedPts, native_transformedPts);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='centerViewPort' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='android.view.View']]"
		[Register ("centerViewPort", "([FLandroid/view/View;)V", "GetCenterViewPort_arrayFLandroid_view_View_Handler")]
		public virtual unsafe void CenterViewPort (float[] transformedPts, global::Android.Views.View view)
		{
			const string __id = "centerViewPort.([FLandroid/view/View;)V";
			IntPtr native_transformedPts = JNIEnv.NewArray (transformedPts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_transformedPts);
				__args [1] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (transformedPts != null) {
					JNIEnv.CopyArray (native_transformedPts, transformedPts);
					JNIEnv.DeleteLocalRef (native_transformedPts);
				}
			}
		}

		static Delegate cb_contentBottom;
#pragma warning disable 0169
		static Delegate GetContentBottomHandler ()
		{
			if (cb_contentBottom == null)
				cb_contentBottom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_ContentBottom);
			return cb_contentBottom;
		}

		static float n_ContentBottom (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentBottom ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='contentBottom' and count(parameter)=0]"
		[Register ("contentBottom", "()F", "GetContentBottomHandler")]
		public virtual unsafe float ContentBottom ()
		{
			const string __id = "contentBottom.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_contentHeight;
#pragma warning disable 0169
		static Delegate GetContentHeightHandler ()
		{
			if (cb_contentHeight == null)
				cb_contentHeight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_ContentHeight);
			return cb_contentHeight;
		}

		static float n_ContentHeight (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentHeight ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='contentHeight' and count(parameter)=0]"
		[Register ("contentHeight", "()F", "GetContentHeightHandler")]
		public virtual unsafe float ContentHeight ()
		{
			const string __id = "contentHeight.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_contentLeft;
#pragma warning disable 0169
		static Delegate GetContentLeftHandler ()
		{
			if (cb_contentLeft == null)
				cb_contentLeft = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_ContentLeft);
			return cb_contentLeft;
		}

		static float n_ContentLeft (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentLeft ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='contentLeft' and count(parameter)=0]"
		[Register ("contentLeft", "()F", "GetContentLeftHandler")]
		public virtual unsafe float ContentLeft ()
		{
			const string __id = "contentLeft.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_contentRight;
#pragma warning disable 0169
		static Delegate GetContentRightHandler ()
		{
			if (cb_contentRight == null)
				cb_contentRight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_ContentRight);
			return cb_contentRight;
		}

		static float n_ContentRight (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentRight ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='contentRight' and count(parameter)=0]"
		[Register ("contentRight", "()F", "GetContentRightHandler")]
		public virtual unsafe float ContentRight ()
		{
			const string __id = "contentRight.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_contentTop;
#pragma warning disable 0169
		static Delegate GetContentTopHandler ()
		{
			if (cb_contentTop == null)
				cb_contentTop = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_ContentTop);
			return cb_contentTop;
		}

		static float n_ContentTop (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentTop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='contentTop' and count(parameter)=0]"
		[Register ("contentTop", "()F", "GetContentTopHandler")]
		public virtual unsafe float ContentTop ()
		{
			const string __id = "contentTop.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_contentWidth;
#pragma warning disable 0169
		static Delegate GetContentWidthHandler ()
		{
			if (cb_contentWidth == null)
				cb_contentWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_ContentWidth);
			return cb_contentWidth;
		}

		static float n_ContentWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ContentWidth ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='contentWidth' and count(parameter)=0]"
		[Register ("contentWidth", "()F", "GetContentWidthHandler")]
		public virtual unsafe float ContentWidth ()
		{
			const string __id = "contentWidth.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_fitScreen;
#pragma warning disable 0169
		static Delegate GetFitScreenHandler ()
		{
			if (cb_fitScreen == null)
				cb_fitScreen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_FitScreen);
			return cb_fitScreen;
		}

		static IntPtr n_FitScreen (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FitScreen ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='fitScreen' and count(parameter)=0]"
		[Register ("fitScreen", "()Landroid/graphics/Matrix;", "GetFitScreenHandler")]
		public virtual unsafe global::Android.Graphics.Matrix FitScreen ()
		{
			const string __id = "fitScreen.()Landroid/graphics/Matrix;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_fitScreen_Landroid_graphics_Matrix_;
#pragma warning disable 0169
		static Delegate GetFitScreen_Landroid_graphics_Matrix_Handler ()
		{
			if (cb_fitScreen_Landroid_graphics_Matrix_ == null)
				cb_fitScreen_Landroid_graphics_Matrix_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_FitScreen_Landroid_graphics_Matrix_);
			return cb_fitScreen_Landroid_graphics_Matrix_;
		}

		static void n_FitScreen_Landroid_graphics_Matrix_ (IntPtr jnienv, IntPtr native__this, IntPtr native_outputMatrix)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Matrix outputMatrix = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_outputMatrix, JniHandleOwnership.DoNotTransfer);
			__this.FitScreen (outputMatrix);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='fitScreen' and count(parameter)=1 and parameter[1][@type='android.graphics.Matrix']]"
		[Register ("fitScreen", "(Landroid/graphics/Matrix;)V", "GetFitScreen_Landroid_graphics_Matrix_Handler")]
		public virtual unsafe void FitScreen (global::Android.Graphics.Matrix outputMatrix)
		{
			const string __id = "fitScreen.(Landroid/graphics/Matrix;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((outputMatrix == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputMatrix).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isInBounds_FF;
#pragma warning disable 0169
		static Delegate GetIsInBounds_FFHandler ()
		{
			if (cb_isInBounds_FF == null)
				cb_isInBounds_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, bool>) n_IsInBounds_FF);
			return cb_isInBounds_FF;
		}

		static bool n_IsInBounds_FF (IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInBounds (x, y);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='isInBounds' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("isInBounds", "(FF)Z", "GetIsInBounds_FFHandler")]
		public virtual unsafe bool IsInBounds (float x, float y)
		{
			const string __id = "isInBounds.(FF)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isInBoundsBottom_F;
#pragma warning disable 0169
		static Delegate GetIsInBoundsBottom_FHandler ()
		{
			if (cb_isInBoundsBottom_F == null)
				cb_isInBoundsBottom_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, bool>) n_IsInBoundsBottom_F);
			return cb_isInBoundsBottom_F;
		}

		static bool n_IsInBoundsBottom_F (IntPtr jnienv, IntPtr native__this, float y)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInBoundsBottom (y);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='isInBoundsBottom' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("isInBoundsBottom", "(F)Z", "GetIsInBoundsBottom_FHandler")]
		public virtual unsafe bool IsInBoundsBottom (float y)
		{
			const string __id = "isInBoundsBottom.(F)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isInBoundsLeft_F;
#pragma warning disable 0169
		static Delegate GetIsInBoundsLeft_FHandler ()
		{
			if (cb_isInBoundsLeft_F == null)
				cb_isInBoundsLeft_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, bool>) n_IsInBoundsLeft_F);
			return cb_isInBoundsLeft_F;
		}

		static bool n_IsInBoundsLeft_F (IntPtr jnienv, IntPtr native__this, float x)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInBoundsLeft (x);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='isInBoundsLeft' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("isInBoundsLeft", "(F)Z", "GetIsInBoundsLeft_FHandler")]
		public virtual unsafe bool IsInBoundsLeft (float x)
		{
			const string __id = "isInBoundsLeft.(F)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (x);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isInBoundsRight_F;
#pragma warning disable 0169
		static Delegate GetIsInBoundsRight_FHandler ()
		{
			if (cb_isInBoundsRight_F == null)
				cb_isInBoundsRight_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, bool>) n_IsInBoundsRight_F);
			return cb_isInBoundsRight_F;
		}

		static bool n_IsInBoundsRight_F (IntPtr jnienv, IntPtr native__this, float x)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInBoundsRight (x);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='isInBoundsRight' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("isInBoundsRight", "(F)Z", "GetIsInBoundsRight_FHandler")]
		public virtual unsafe bool IsInBoundsRight (float x)
		{
			const string __id = "isInBoundsRight.(F)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (x);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isInBoundsTop_F;
#pragma warning disable 0169
		static Delegate GetIsInBoundsTop_FHandler ()
		{
			if (cb_isInBoundsTop_F == null)
				cb_isInBoundsTop_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, bool>) n_IsInBoundsTop_F);
			return cb_isInBoundsTop_F;
		}

		static bool n_IsInBoundsTop_F (IntPtr jnienv, IntPtr native__this, float y)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInBoundsTop (y);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='isInBoundsTop' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("isInBoundsTop", "(F)Z", "GetIsInBoundsTop_FHandler")]
		public virtual unsafe bool IsInBoundsTop (float y)
		{
			const string __id = "isInBoundsTop.(F)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isInBoundsX_F;
#pragma warning disable 0169
		static Delegate GetIsInBoundsX_FHandler ()
		{
			if (cb_isInBoundsX_F == null)
				cb_isInBoundsX_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, bool>) n_IsInBoundsX_F);
			return cb_isInBoundsX_F;
		}

		static bool n_IsInBoundsX_F (IntPtr jnienv, IntPtr native__this, float x)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInBoundsX (x);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='isInBoundsX' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("isInBoundsX", "(F)Z", "GetIsInBoundsX_FHandler")]
		public virtual unsafe bool IsInBoundsX (float x)
		{
			const string __id = "isInBoundsX.(F)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (x);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_isInBoundsY_F;
#pragma warning disable 0169
		static Delegate GetIsInBoundsY_FHandler ()
		{
			if (cb_isInBoundsY_F == null)
				cb_isInBoundsY_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, bool>) n_IsInBoundsY_F);
			return cb_isInBoundsY_F;
		}

		static bool n_IsInBoundsY_F (IntPtr jnienv, IntPtr native__this, float y)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInBoundsY (y);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='isInBoundsY' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("isInBoundsY", "(F)Z", "GetIsInBoundsY_FHandler")]
		public virtual unsafe bool IsInBoundsY (float y)
		{
			const string __id = "isInBoundsY.(F)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_limitTransAndScale_Landroid_graphics_Matrix_Landroid_graphics_RectF_;
#pragma warning disable 0169
		static Delegate GetLimitTransAndScale_Landroid_graphics_Matrix_Landroid_graphics_RectF_Handler ()
		{
			if (cb_limitTransAndScale_Landroid_graphics_Matrix_Landroid_graphics_RectF_ == null)
				cb_limitTransAndScale_Landroid_graphics_Matrix_Landroid_graphics_RectF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_LimitTransAndScale_Landroid_graphics_Matrix_Landroid_graphics_RectF_);
			return cb_limitTransAndScale_Landroid_graphics_Matrix_Landroid_graphics_RectF_;
		}

		static void n_LimitTransAndScale_Landroid_graphics_Matrix_Landroid_graphics_RectF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_matrix, IntPtr native_content)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Matrix matrix = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_matrix, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.RectF content = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_content, JniHandleOwnership.DoNotTransfer);
			__this.LimitTransAndScale (matrix, content);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='limitTransAndScale' and count(parameter)=2 and parameter[1][@type='android.graphics.Matrix'] and parameter[2][@type='android.graphics.RectF']]"
		[Register ("limitTransAndScale", "(Landroid/graphics/Matrix;Landroid/graphics/RectF;)V", "GetLimitTransAndScale_Landroid_graphics_Matrix_Landroid_graphics_RectF_Handler")]
		public virtual unsafe void LimitTransAndScale (global::Android.Graphics.Matrix matrix, global::Android.Graphics.RectF content)
		{
			const string __id = "limitTransAndScale.(Landroid/graphics/Matrix;Landroid/graphics/RectF;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((matrix == null) ? IntPtr.Zero : ((global::Java.Lang.Object) matrix).Handle);
				__args [1] = new JniArgumentValue ((content == null) ? IntPtr.Zero : ((global::Java.Lang.Object) content).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_offsetBottom;
#pragma warning disable 0169
		static Delegate GetOffsetBottomHandler ()
		{
			if (cb_offsetBottom == null)
				cb_offsetBottom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_OffsetBottom);
			return cb_offsetBottom;
		}

		static float n_OffsetBottom (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OffsetBottom ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='offsetBottom' and count(parameter)=0]"
		[Register ("offsetBottom", "()F", "GetOffsetBottomHandler")]
		public virtual unsafe float OffsetBottom ()
		{
			const string __id = "offsetBottom.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_offsetLeft;
#pragma warning disable 0169
		static Delegate GetOffsetLeftHandler ()
		{
			if (cb_offsetLeft == null)
				cb_offsetLeft = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_OffsetLeft);
			return cb_offsetLeft;
		}

		static float n_OffsetLeft (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OffsetLeft ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='offsetLeft' and count(parameter)=0]"
		[Register ("offsetLeft", "()F", "GetOffsetLeftHandler")]
		public virtual unsafe float OffsetLeft ()
		{
			const string __id = "offsetLeft.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_offsetRight;
#pragma warning disable 0169
		static Delegate GetOffsetRightHandler ()
		{
			if (cb_offsetRight == null)
				cb_offsetRight = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_OffsetRight);
			return cb_offsetRight;
		}

		static float n_OffsetRight (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OffsetRight ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='offsetRight' and count(parameter)=0]"
		[Register ("offsetRight", "()F", "GetOffsetRightHandler")]
		public virtual unsafe float OffsetRight ()
		{
			const string __id = "offsetRight.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_offsetTop;
#pragma warning disable 0169
		static Delegate GetOffsetTopHandler ()
		{
			if (cb_offsetTop == null)
				cb_offsetTop = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_OffsetTop);
			return cb_offsetTop;
		}

		static float n_OffsetTop (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.OffsetTop ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='offsetTop' and count(parameter)=0]"
		[Register ("offsetTop", "()F", "GetOffsetTopHandler")]
		public virtual unsafe float OffsetTop ()
		{
			const string __id = "offsetTop.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_refresh_Landroid_graphics_Matrix_Landroid_view_View_Z;
#pragma warning disable 0169
		static Delegate GetRefresh_Landroid_graphics_Matrix_Landroid_view_View_ZHandler ()
		{
			if (cb_refresh_Landroid_graphics_Matrix_Landroid_view_View_Z == null)
				cb_refresh_Landroid_graphics_Matrix_Landroid_view_View_Z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool, IntPtr>) n_Refresh_Landroid_graphics_Matrix_Landroid_view_View_Z);
			return cb_refresh_Landroid_graphics_Matrix_Landroid_view_View_Z;
		}

		static IntPtr n_Refresh_Landroid_graphics_Matrix_Landroid_view_View_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_newMatrix, IntPtr native_chart, bool invalidate)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Matrix newMatrix = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_newMatrix, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View chart = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_chart, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Refresh (newMatrix, chart, invalidate));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='refresh' and count(parameter)=3 and parameter[1][@type='android.graphics.Matrix'] and parameter[2][@type='android.view.View'] and parameter[3][@type='boolean']]"
		[Register ("refresh", "(Landroid/graphics/Matrix;Landroid/view/View;Z)Landroid/graphics/Matrix;", "GetRefresh_Landroid_graphics_Matrix_Landroid_view_View_ZHandler")]
		public virtual unsafe global::Android.Graphics.Matrix Refresh (global::Android.Graphics.Matrix newMatrix, global::Android.Views.View chart, bool invalidate)
		{
			const string __id = "refresh.(Landroid/graphics/Matrix;Landroid/view/View;Z)Landroid/graphics/Matrix;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((newMatrix == null) ? IntPtr.Zero : ((global::Java.Lang.Object) newMatrix).Handle);
				__args [1] = new JniArgumentValue ((chart == null) ? IntPtr.Zero : ((global::Java.Lang.Object) chart).Handle);
				__args [2] = new JniArgumentValue (invalidate);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_resetZoom_Landroid_graphics_Matrix_;
#pragma warning disable 0169
		static Delegate GetResetZoom_Landroid_graphics_Matrix_Handler ()
		{
			if (cb_resetZoom_Landroid_graphics_Matrix_ == null)
				cb_resetZoom_Landroid_graphics_Matrix_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ResetZoom_Landroid_graphics_Matrix_);
			return cb_resetZoom_Landroid_graphics_Matrix_;
		}

		static void n_ResetZoom_Landroid_graphics_Matrix_ (IntPtr jnienv, IntPtr native__this, IntPtr native_outputMatrix)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Matrix outputMatrix = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_outputMatrix, JniHandleOwnership.DoNotTransfer);
			__this.ResetZoom (outputMatrix);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='resetZoom' and count(parameter)=1 and parameter[1][@type='android.graphics.Matrix']]"
		[Register ("resetZoom", "(Landroid/graphics/Matrix;)V", "GetResetZoom_Landroid_graphics_Matrix_Handler")]
		public virtual unsafe void ResetZoom (global::Android.Graphics.Matrix outputMatrix)
		{
			const string __id = "resetZoom.(Landroid/graphics/Matrix;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((outputMatrix == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputMatrix).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_restrainViewPort_FFFF;
#pragma warning disable 0169
		static Delegate GetRestrainViewPort_FFFFHandler ()
		{
			if (cb_restrainViewPort_FFFF == null)
				cb_restrainViewPort_FFFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float>) n_RestrainViewPort_FFFF);
			return cb_restrainViewPort_FFFF;
		}

		static void n_RestrainViewPort_FFFF (IntPtr jnienv, IntPtr native__this, float offsetLeft, float offsetTop, float offsetRight, float offsetBottom)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.RestrainViewPort (offsetLeft, offsetTop, offsetRight, offsetBottom);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='restrainViewPort' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("restrainViewPort", "(FFFF)V", "GetRestrainViewPort_FFFFHandler")]
		public virtual unsafe void RestrainViewPort (float offsetLeft, float offsetTop, float offsetRight, float offsetBottom)
		{
			const string __id = "restrainViewPort.(FFFF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (offsetLeft);
				__args [1] = new JniArgumentValue (offsetTop);
				__args [2] = new JniArgumentValue (offsetRight);
				__args [3] = new JniArgumentValue (offsetBottom);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setChartDimens_FF;
#pragma warning disable 0169
		static Delegate GetSetChartDimens_FFHandler ()
		{
			if (cb_setChartDimens_FF == null)
				cb_setChartDimens_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_SetChartDimens_FF);
			return cb_setChartDimens_FF;
		}

		static void n_SetChartDimens_FF (IntPtr jnienv, IntPtr native__this, float width, float height)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetChartDimens (width, height);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='setChartDimens' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setChartDimens", "(FF)V", "GetSetChartDimens_FFHandler")]
		public virtual unsafe void SetChartDimens (float width, float height)
		{
			const string __id = "setChartDimens.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (width);
				__args [1] = new JniArgumentValue (height);
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
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDragOffsetX (offset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='setDragOffsetX' and count(parameter)=1 and parameter[1][@type='float']]"
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
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDragOffsetY (offset);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='setDragOffsetY' and count(parameter)=1 and parameter[1][@type='float']]"
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

		static Delegate cb_setMaximumScaleX_F;
#pragma warning disable 0169
		static Delegate GetSetMaximumScaleX_FHandler ()
		{
			if (cb_setMaximumScaleX_F == null)
				cb_setMaximumScaleX_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMaximumScaleX_F);
			return cb_setMaximumScaleX_F;
		}

		static void n_SetMaximumScaleX_F (IntPtr jnienv, IntPtr native__this, float xScale)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaximumScaleX (xScale);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='setMaximumScaleX' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setMaximumScaleX", "(F)V", "GetSetMaximumScaleX_FHandler")]
		public virtual unsafe void SetMaximumScaleX (float xScale)
		{
			const string __id = "setMaximumScaleX.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (xScale);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMaximumScaleY_F;
#pragma warning disable 0169
		static Delegate GetSetMaximumScaleY_FHandler ()
		{
			if (cb_setMaximumScaleY_F == null)
				cb_setMaximumScaleY_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMaximumScaleY_F);
			return cb_setMaximumScaleY_F;
		}

		static void n_SetMaximumScaleY_F (IntPtr jnienv, IntPtr native__this, float yScale)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMaximumScaleY (yScale);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='setMaximumScaleY' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setMaximumScaleY", "(F)V", "GetSetMaximumScaleY_FHandler")]
		public virtual unsafe void SetMaximumScaleY (float yScale)
		{
			const string __id = "setMaximumScaleY.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (yScale);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMinMaxScaleX_FF;
#pragma warning disable 0169
		static Delegate GetSetMinMaxScaleX_FFHandler ()
		{
			if (cb_setMinMaxScaleX_FF == null)
				cb_setMinMaxScaleX_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_SetMinMaxScaleX_FF);
			return cb_setMinMaxScaleX_FF;
		}

		static void n_SetMinMaxScaleX_FF (IntPtr jnienv, IntPtr native__this, float minScaleX, float maxScaleX)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMinMaxScaleX (minScaleX, maxScaleX);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='setMinMaxScaleX' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setMinMaxScaleX", "(FF)V", "GetSetMinMaxScaleX_FFHandler")]
		public virtual unsafe void SetMinMaxScaleX (float minScaleX, float maxScaleX)
		{
			const string __id = "setMinMaxScaleX.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (minScaleX);
				__args [1] = new JniArgumentValue (maxScaleX);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMinMaxScaleY_FF;
#pragma warning disable 0169
		static Delegate GetSetMinMaxScaleY_FFHandler ()
		{
			if (cb_setMinMaxScaleY_FF == null)
				cb_setMinMaxScaleY_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_SetMinMaxScaleY_FF);
			return cb_setMinMaxScaleY_FF;
		}

		static void n_SetMinMaxScaleY_FF (IntPtr jnienv, IntPtr native__this, float minScaleY, float maxScaleY)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMinMaxScaleY (minScaleY, maxScaleY);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='setMinMaxScaleY' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setMinMaxScaleY", "(FF)V", "GetSetMinMaxScaleY_FFHandler")]
		public virtual unsafe void SetMinMaxScaleY (float minScaleY, float maxScaleY)
		{
			const string __id = "setMinMaxScaleY.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (minScaleY);
				__args [1] = new JniArgumentValue (maxScaleY);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMinimumScaleX_F;
#pragma warning disable 0169
		static Delegate GetSetMinimumScaleX_FHandler ()
		{
			if (cb_setMinimumScaleX_F == null)
				cb_setMinimumScaleX_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMinimumScaleX_F);
			return cb_setMinimumScaleX_F;
		}

		static void n_SetMinimumScaleX_F (IntPtr jnienv, IntPtr native__this, float xScale)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMinimumScaleX (xScale);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='setMinimumScaleX' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setMinimumScaleX", "(F)V", "GetSetMinimumScaleX_FHandler")]
		public virtual unsafe void SetMinimumScaleX (float xScale)
		{
			const string __id = "setMinimumScaleX.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (xScale);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setMinimumScaleY_F;
#pragma warning disable 0169
		static Delegate GetSetMinimumScaleY_FHandler ()
		{
			if (cb_setMinimumScaleY_F == null)
				cb_setMinimumScaleY_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMinimumScaleY_F);
			return cb_setMinimumScaleY_F;
		}

		static void n_SetMinimumScaleY_F (IntPtr jnienv, IntPtr native__this, float yScale)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetMinimumScaleY (yScale);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='setMinimumScaleY' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setMinimumScaleY", "(F)V", "GetSetMinimumScaleY_FHandler")]
		public virtual unsafe void SetMinimumScaleY (float yScale)
		{
			const string __id = "setMinimumScaleY.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (yScale);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setZoom_FF;
#pragma warning disable 0169
		static Delegate GetSetZoom_FFHandler ()
		{
			if (cb_setZoom_FF == null)
				cb_setZoom_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_SetZoom_FF);
			return cb_setZoom_FF;
		}

		static IntPtr n_SetZoom_FF (IntPtr jnienv, IntPtr native__this, float scaleX, float scaleY)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetZoom (scaleX, scaleY));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='setZoom' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setZoom", "(FF)Landroid/graphics/Matrix;", "GetSetZoom_FFHandler")]
		public virtual unsafe global::Android.Graphics.Matrix SetZoom (float scaleX, float scaleY)
		{
			const string __id = "setZoom.(FF)Landroid/graphics/Matrix;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (scaleX);
				__args [1] = new JniArgumentValue (scaleY);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setZoom_FFLandroid_graphics_Matrix_;
#pragma warning disable 0169
		static Delegate GetSetZoom_FFLandroid_graphics_Matrix_Handler ()
		{
			if (cb_setZoom_FFLandroid_graphics_Matrix_ == null)
				cb_setZoom_FFLandroid_graphics_Matrix_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, IntPtr>) n_SetZoom_FFLandroid_graphics_Matrix_);
			return cb_setZoom_FFLandroid_graphics_Matrix_;
		}

		static void n_SetZoom_FFLandroid_graphics_Matrix_ (IntPtr jnienv, IntPtr native__this, float scaleX, float scaleY, IntPtr native_outputMatrix)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Matrix outputMatrix = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_outputMatrix, JniHandleOwnership.DoNotTransfer);
			__this.SetZoom (scaleX, scaleY, outputMatrix);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='setZoom' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='android.graphics.Matrix']]"
		[Register ("setZoom", "(FFLandroid/graphics/Matrix;)V", "GetSetZoom_FFLandroid_graphics_Matrix_Handler")]
		public virtual unsafe void SetZoom (float scaleX, float scaleY, global::Android.Graphics.Matrix outputMatrix)
		{
			const string __id = "setZoom.(FFLandroid/graphics/Matrix;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (scaleX);
				__args [1] = new JniArgumentValue (scaleY);
				__args [2] = new JniArgumentValue ((outputMatrix == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputMatrix).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setZoom_FFFF;
#pragma warning disable 0169
		static Delegate GetSetZoom_FFFFHandler ()
		{
			if (cb_setZoom_FFFF == null)
				cb_setZoom_FFFF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, float, float, IntPtr>) n_SetZoom_FFFF);
			return cb_setZoom_FFFF;
		}

		static IntPtr n_SetZoom_FFFF (IntPtr jnienv, IntPtr native__this, float scaleX, float scaleY, float x, float y)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.SetZoom (scaleX, scaleY, x, y));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='setZoom' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("setZoom", "(FFFF)Landroid/graphics/Matrix;", "GetSetZoom_FFFFHandler")]
		public virtual unsafe global::Android.Graphics.Matrix SetZoom (float scaleX, float scaleY, float x, float y)
		{
			const string __id = "setZoom.(FFFF)Landroid/graphics/Matrix;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (scaleX);
				__args [1] = new JniArgumentValue (scaleY);
				__args [2] = new JniArgumentValue (x);
				__args [3] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_translate_arrayF;
#pragma warning disable 0169
		static Delegate GetTranslate_arrayFHandler ()
		{
			if (cb_translate_arrayF == null)
				cb_translate_arrayF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_Translate_arrayF);
			return cb_translate_arrayF;
		}

		static IntPtr n_Translate_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_transformedPts)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] transformedPts = (float[]) JNIEnv.GetArray (native_transformedPts, JniHandleOwnership.DoNotTransfer, typeof (float));
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.Translate (transformedPts));
			if (transformedPts != null)
				JNIEnv.CopyArray (transformedPts, native_transformedPts);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='translate' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("translate", "([F)Landroid/graphics/Matrix;", "GetTranslate_arrayFHandler")]
		public virtual unsafe global::Android.Graphics.Matrix Translate (float[] transformedPts)
		{
			const string __id = "translate.([F)Landroid/graphics/Matrix;";
			IntPtr native_transformedPts = JNIEnv.NewArray (transformedPts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_transformedPts);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (transformedPts != null) {
					JNIEnv.CopyArray (native_transformedPts, transformedPts);
					JNIEnv.DeleteLocalRef (native_transformedPts);
				}
			}
		}

		static Delegate cb_translate_arrayFLandroid_graphics_Matrix_;
#pragma warning disable 0169
		static Delegate GetTranslate_arrayFLandroid_graphics_Matrix_Handler ()
		{
			if (cb_translate_arrayFLandroid_graphics_Matrix_ == null)
				cb_translate_arrayFLandroid_graphics_Matrix_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Translate_arrayFLandroid_graphics_Matrix_);
			return cb_translate_arrayFLandroid_graphics_Matrix_;
		}

		static void n_Translate_arrayFLandroid_graphics_Matrix_ (IntPtr jnienv, IntPtr native__this, IntPtr native_transformedPts, IntPtr native_outputMatrix)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] transformedPts = (float[]) JNIEnv.GetArray (native_transformedPts, JniHandleOwnership.DoNotTransfer, typeof (float));
			global::Android.Graphics.Matrix outputMatrix = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_outputMatrix, JniHandleOwnership.DoNotTransfer);
			__this.Translate (transformedPts, outputMatrix);
			if (transformedPts != null)
				JNIEnv.CopyArray (transformedPts, native_transformedPts);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='translate' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='android.graphics.Matrix']]"
		[Register ("translate", "([FLandroid/graphics/Matrix;)V", "GetTranslate_arrayFLandroid_graphics_Matrix_Handler")]
		public virtual unsafe void Translate (float[] transformedPts, global::Android.Graphics.Matrix outputMatrix)
		{
			const string __id = "translate.([FLandroid/graphics/Matrix;)V";
			IntPtr native_transformedPts = JNIEnv.NewArray (transformedPts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_transformedPts);
				__args [1] = new JniArgumentValue ((outputMatrix == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputMatrix).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (transformedPts != null) {
					JNIEnv.CopyArray (native_transformedPts, transformedPts);
					JNIEnv.DeleteLocalRef (native_transformedPts);
				}
			}
		}

		static Delegate cb_zoom_FF;
#pragma warning disable 0169
		static Delegate GetZoom_FFHandler ()
		{
			if (cb_zoom_FF == null)
				cb_zoom_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_Zoom_FF);
			return cb_zoom_FF;
		}

		static IntPtr n_Zoom_FF (IntPtr jnienv, IntPtr native__this, float scaleX, float scaleY)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Zoom (scaleX, scaleY));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='zoom' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("zoom", "(FF)Landroid/graphics/Matrix;", "GetZoom_FFHandler")]
		public virtual unsafe global::Android.Graphics.Matrix Zoom (float scaleX, float scaleY)
		{
			const string __id = "zoom.(FF)Landroid/graphics/Matrix;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (scaleX);
				__args [1] = new JniArgumentValue (scaleY);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_zoom_FFLandroid_graphics_Matrix_;
#pragma warning disable 0169
		static Delegate GetZoom_FFLandroid_graphics_Matrix_Handler ()
		{
			if (cb_zoom_FFLandroid_graphics_Matrix_ == null)
				cb_zoom_FFLandroid_graphics_Matrix_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, IntPtr>) n_Zoom_FFLandroid_graphics_Matrix_);
			return cb_zoom_FFLandroid_graphics_Matrix_;
		}

		static void n_Zoom_FFLandroid_graphics_Matrix_ (IntPtr jnienv, IntPtr native__this, float scaleX, float scaleY, IntPtr native_outputMatrix)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Matrix outputMatrix = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_outputMatrix, JniHandleOwnership.DoNotTransfer);
			__this.Zoom (scaleX, scaleY, outputMatrix);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='zoom' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='android.graphics.Matrix']]"
		[Register ("zoom", "(FFLandroid/graphics/Matrix;)V", "GetZoom_FFLandroid_graphics_Matrix_Handler")]
		public virtual unsafe void Zoom (float scaleX, float scaleY, global::Android.Graphics.Matrix outputMatrix)
		{
			const string __id = "zoom.(FFLandroid/graphics/Matrix;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (scaleX);
				__args [1] = new JniArgumentValue (scaleY);
				__args [2] = new JniArgumentValue ((outputMatrix == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputMatrix).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_zoom_FFFF;
#pragma warning disable 0169
		static Delegate GetZoom_FFFFHandler ()
		{
			if (cb_zoom_FFFF == null)
				cb_zoom_FFFF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, float, float, IntPtr>) n_Zoom_FFFF);
			return cb_zoom_FFFF;
		}

		static IntPtr n_Zoom_FFFF (IntPtr jnienv, IntPtr native__this, float scaleX, float scaleY, float x, float y)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Zoom (scaleX, scaleY, x, y));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='zoom' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("zoom", "(FFFF)Landroid/graphics/Matrix;", "GetZoom_FFFFHandler")]
		public virtual unsafe global::Android.Graphics.Matrix Zoom (float scaleX, float scaleY, float x, float y)
		{
			const string __id = "zoom.(FFFF)Landroid/graphics/Matrix;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (scaleX);
				__args [1] = new JniArgumentValue (scaleY);
				__args [2] = new JniArgumentValue (x);
				__args [3] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_zoom_FFFFLandroid_graphics_Matrix_;
#pragma warning disable 0169
		static Delegate GetZoom_FFFFLandroid_graphics_Matrix_Handler ()
		{
			if (cb_zoom_FFFFLandroid_graphics_Matrix_ == null)
				cb_zoom_FFFFLandroid_graphics_Matrix_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float, IntPtr>) n_Zoom_FFFFLandroid_graphics_Matrix_);
			return cb_zoom_FFFFLandroid_graphics_Matrix_;
		}

		static void n_Zoom_FFFFLandroid_graphics_Matrix_ (IntPtr jnienv, IntPtr native__this, float scaleX, float scaleY, float x, float y, IntPtr native_outputMatrix)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Matrix outputMatrix = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_outputMatrix, JniHandleOwnership.DoNotTransfer);
			__this.Zoom (scaleX, scaleY, x, y, outputMatrix);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='zoom' and count(parameter)=5 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='android.graphics.Matrix']]"
		[Register ("zoom", "(FFFFLandroid/graphics/Matrix;)V", "GetZoom_FFFFLandroid_graphics_Matrix_Handler")]
		public virtual unsafe void Zoom (float scaleX, float scaleY, float x, float y, global::Android.Graphics.Matrix outputMatrix)
		{
			const string __id = "zoom.(FFFFLandroid/graphics/Matrix;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (scaleX);
				__args [1] = new JniArgumentValue (scaleY);
				__args [2] = new JniArgumentValue (x);
				__args [3] = new JniArgumentValue (y);
				__args [4] = new JniArgumentValue ((outputMatrix == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputMatrix).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_zoomIn_FF;
#pragma warning disable 0169
		static Delegate GetZoomIn_FFHandler ()
		{
			if (cb_zoomIn_FF == null)
				cb_zoomIn_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_ZoomIn_FF);
			return cb_zoomIn_FF;
		}

		static IntPtr n_ZoomIn_FF (IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ZoomIn (x, y));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='zoomIn' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("zoomIn", "(FF)Landroid/graphics/Matrix;", "GetZoomIn_FFHandler")]
		public virtual unsafe global::Android.Graphics.Matrix ZoomIn (float x, float y)
		{
			const string __id = "zoomIn.(FF)Landroid/graphics/Matrix;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_zoomIn_FFLandroid_graphics_Matrix_;
#pragma warning disable 0169
		static Delegate GetZoomIn_FFLandroid_graphics_Matrix_Handler ()
		{
			if (cb_zoomIn_FFLandroid_graphics_Matrix_ == null)
				cb_zoomIn_FFLandroid_graphics_Matrix_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, IntPtr>) n_ZoomIn_FFLandroid_graphics_Matrix_);
			return cb_zoomIn_FFLandroid_graphics_Matrix_;
		}

		static void n_ZoomIn_FFLandroid_graphics_Matrix_ (IntPtr jnienv, IntPtr native__this, float x, float y, IntPtr native_outputMatrix)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Matrix outputMatrix = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_outputMatrix, JniHandleOwnership.DoNotTransfer);
			__this.ZoomIn (x, y, outputMatrix);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='zoomIn' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='android.graphics.Matrix']]"
		[Register ("zoomIn", "(FFLandroid/graphics/Matrix;)V", "GetZoomIn_FFLandroid_graphics_Matrix_Handler")]
		public virtual unsafe void ZoomIn (float x, float y, global::Android.Graphics.Matrix outputMatrix)
		{
			const string __id = "zoomIn.(FFLandroid/graphics/Matrix;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue ((outputMatrix == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputMatrix).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_zoomOut_FF;
#pragma warning disable 0169
		static Delegate GetZoomOut_FFHandler ()
		{
			if (cb_zoomOut_FF == null)
				cb_zoomOut_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_ZoomOut_FF);
			return cb_zoomOut_FF;
		}

		static IntPtr n_ZoomOut_FF (IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ZoomOut (x, y));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='zoomOut' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("zoomOut", "(FF)Landroid/graphics/Matrix;", "GetZoomOut_FFHandler")]
		public virtual unsafe global::Android.Graphics.Matrix ZoomOut (float x, float y)
		{
			const string __id = "zoomOut.(FF)Landroid/graphics/Matrix;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_zoomOut_FFLandroid_graphics_Matrix_;
#pragma warning disable 0169
		static Delegate GetZoomOut_FFLandroid_graphics_Matrix_Handler ()
		{
			if (cb_zoomOut_FFLandroid_graphics_Matrix_ == null)
				cb_zoomOut_FFLandroid_graphics_Matrix_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, IntPtr>) n_ZoomOut_FFLandroid_graphics_Matrix_);
			return cb_zoomOut_FFLandroid_graphics_Matrix_;
		}

		static void n_ZoomOut_FFLandroid_graphics_Matrix_ (IntPtr jnienv, IntPtr native__this, float x, float y, IntPtr native_outputMatrix)
		{
			global::MikePhil.Charting.Util.ViewPortHandler __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Matrix outputMatrix = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_outputMatrix, JniHandleOwnership.DoNotTransfer);
			__this.ZoomOut (x, y, outputMatrix);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ViewPortHandler']/method[@name='zoomOut' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='android.graphics.Matrix']]"
		[Register ("zoomOut", "(FFLandroid/graphics/Matrix;)V", "GetZoomOut_FFLandroid_graphics_Matrix_Handler")]
		public virtual unsafe void ZoomOut (float x, float y, global::Android.Graphics.Matrix outputMatrix)
		{
			const string __id = "zoomOut.(FFLandroid/graphics/Matrix;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue ((outputMatrix == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputMatrix).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
