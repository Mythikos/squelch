using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ScatterDataSet']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/ScatterDataSet", DoNotGenerateAcw=true)]
	public partial class ScatterDataSet : global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet, global::MikePhil.Charting.Interfaces.Datasets.IScatterDataSet {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ScatterDataSet']/field[@name='mShapeRenderer']"
		[Register ("mShapeRenderer")]
		protected global::MikePhil.Charting.Renderer.Scatter.IShapeRenderer MShapeRenderer {
			get {
				const string __id = "mShapeRenderer.Lcom/github/mikephil/charting/renderer/scatter/IShapeRenderer;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.Scatter.IShapeRenderer> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mShapeRenderer.Lcom/github/mikephil/charting/renderer/scatter/IShapeRenderer;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/ScatterDataSet", typeof (ScatterDataSet));
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

		protected ScatterDataSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ScatterDataSet']/constructor[@name='ScatterDataSet' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.github.mikephil.charting.data.Entry&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/util/List;Ljava/lang/String;)V", "")]
		public unsafe ScatterDataSet (global::System.Collections.Generic.IList<global::MikePhil.Charting.Data.Entry> yVals, string label)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_yVals = global::Android.Runtime.JavaList<global::MikePhil.Charting.Data.Entry>.ToLocalJniHandle (yVals);
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
			}
		}

		static Delegate cb_getScatterShapeHoleColor;
#pragma warning disable 0169
		static Delegate GetGetScatterShapeHoleColorHandler ()
		{
			if (cb_getScatterShapeHoleColor == null)
				cb_getScatterShapeHoleColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetScatterShapeHoleColor);
			return cb_getScatterShapeHoleColor;
		}

		static int n_GetScatterShapeHoleColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.ScatterDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ScatterDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScatterShapeHoleColor;
		}
#pragma warning restore 0169

		static Delegate cb_setScatterShapeHoleColor_I;
#pragma warning disable 0169
		static Delegate GetSetScatterShapeHoleColor_IHandler ()
		{
			if (cb_setScatterShapeHoleColor_I == null)
				cb_setScatterShapeHoleColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetScatterShapeHoleColor_I);
			return cb_setScatterShapeHoleColor_I;
		}

		static void n_SetScatterShapeHoleColor_I (IntPtr jnienv, IntPtr native__this, int holeColor)
		{
			global::MikePhil.Charting.Data.ScatterDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ScatterDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScatterShapeHoleColor = holeColor;
		}
#pragma warning restore 0169

		public virtual unsafe int ScatterShapeHoleColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ScatterDataSet']/method[@name='getScatterShapeHoleColor' and count(parameter)=0]"
			[Register ("getScatterShapeHoleColor", "()I", "GetGetScatterShapeHoleColorHandler")]
			get {
				const string __id = "getScatterShapeHoleColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ScatterDataSet']/method[@name='setScatterShapeHoleColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setScatterShapeHoleColor", "(I)V", "GetSetScatterShapeHoleColor_IHandler")]
			set {
				const string __id = "setScatterShapeHoleColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScatterShapeHoleRadius;
#pragma warning disable 0169
		static Delegate GetGetScatterShapeHoleRadiusHandler ()
		{
			if (cb_getScatterShapeHoleRadius == null)
				cb_getScatterShapeHoleRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetScatterShapeHoleRadius);
			return cb_getScatterShapeHoleRadius;
		}

		static float n_GetScatterShapeHoleRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.ScatterDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ScatterDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScatterShapeHoleRadius;
		}
#pragma warning restore 0169

		static Delegate cb_setScatterShapeHoleRadius_F;
#pragma warning disable 0169
		static Delegate GetSetScatterShapeHoleRadius_FHandler ()
		{
			if (cb_setScatterShapeHoleRadius_F == null)
				cb_setScatterShapeHoleRadius_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetScatterShapeHoleRadius_F);
			return cb_setScatterShapeHoleRadius_F;
		}

		static void n_SetScatterShapeHoleRadius_F (IntPtr jnienv, IntPtr native__this, float holeRadius)
		{
			global::MikePhil.Charting.Data.ScatterDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ScatterDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScatterShapeHoleRadius = holeRadius;
		}
#pragma warning restore 0169

		public virtual unsafe float ScatterShapeHoleRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ScatterDataSet']/method[@name='getScatterShapeHoleRadius' and count(parameter)=0]"
			[Register ("getScatterShapeHoleRadius", "()F", "GetGetScatterShapeHoleRadiusHandler")]
			get {
				const string __id = "getScatterShapeHoleRadius.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ScatterDataSet']/method[@name='setScatterShapeHoleRadius' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setScatterShapeHoleRadius", "(F)V", "GetSetScatterShapeHoleRadius_FHandler")]
			set {
				const string __id = "setScatterShapeHoleRadius.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getScatterShapeSize;
#pragma warning disable 0169
		static Delegate GetGetScatterShapeSizeHandler ()
		{
			if (cb_getScatterShapeSize == null)
				cb_getScatterShapeSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetScatterShapeSize);
			return cb_getScatterShapeSize;
		}

		static float n_GetScatterShapeSize (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.ScatterDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ScatterDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ScatterShapeSize;
		}
#pragma warning restore 0169

		static Delegate cb_setScatterShapeSize_F;
#pragma warning disable 0169
		static Delegate GetSetScatterShapeSize_FHandler ()
		{
			if (cb_setScatterShapeSize_F == null)
				cb_setScatterShapeSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetScatterShapeSize_F);
			return cb_setScatterShapeSize_F;
		}

		static void n_SetScatterShapeSize_F (IntPtr jnienv, IntPtr native__this, float size)
		{
			global::MikePhil.Charting.Data.ScatterDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ScatterDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ScatterShapeSize = size;
		}
#pragma warning restore 0169

		public virtual unsafe float ScatterShapeSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ScatterDataSet']/method[@name='getScatterShapeSize' and count(parameter)=0]"
			[Register ("getScatterShapeSize", "()F", "GetGetScatterShapeSizeHandler")]
			get {
				const string __id = "getScatterShapeSize.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ScatterDataSet']/method[@name='setScatterShapeSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setScatterShapeSize", "(F)V", "GetSetScatterShapeSize_FHandler")]
			set {
				const string __id = "setScatterShapeSize.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShapeRenderer;
#pragma warning disable 0169
		static Delegate GetGetShapeRendererHandler ()
		{
			if (cb_getShapeRenderer == null)
				cb_getShapeRenderer = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetShapeRenderer);
			return cb_getShapeRenderer;
		}

		static IntPtr n_GetShapeRenderer (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.ScatterDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ScatterDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ShapeRenderer);
		}
#pragma warning restore 0169

		static Delegate cb_setShapeRenderer_Lcom_github_mikephil_charting_renderer_scatter_IShapeRenderer_;
#pragma warning disable 0169
		static Delegate GetSetShapeRenderer_Lcom_github_mikephil_charting_renderer_scatter_IShapeRenderer_Handler ()
		{
			if (cb_setShapeRenderer_Lcom_github_mikephil_charting_renderer_scatter_IShapeRenderer_ == null)
				cb_setShapeRenderer_Lcom_github_mikephil_charting_renderer_scatter_IShapeRenderer_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetShapeRenderer_Lcom_github_mikephil_charting_renderer_scatter_IShapeRenderer_);
			return cb_setShapeRenderer_Lcom_github_mikephil_charting_renderer_scatter_IShapeRenderer_;
		}

		static void n_SetShapeRenderer_Lcom_github_mikephil_charting_renderer_scatter_IShapeRenderer_ (IntPtr jnienv, IntPtr native__this, IntPtr native_shapeRenderer)
		{
			global::MikePhil.Charting.Data.ScatterDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ScatterDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Renderer.Scatter.IShapeRenderer shapeRenderer = (global::MikePhil.Charting.Renderer.Scatter.IShapeRenderer)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.Scatter.IShapeRenderer> (native_shapeRenderer, JniHandleOwnership.DoNotTransfer);
			__this.ShapeRenderer = shapeRenderer;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Renderer.Scatter.IShapeRenderer ShapeRenderer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ScatterDataSet']/method[@name='getShapeRenderer' and count(parameter)=0]"
			[Register ("getShapeRenderer", "()Lcom/github/mikephil/charting/renderer/scatter/IShapeRenderer;", "GetGetShapeRendererHandler")]
			get {
				const string __id = "getShapeRenderer.()Lcom/github/mikephil/charting/renderer/scatter/IShapeRenderer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.Scatter.IShapeRenderer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ScatterDataSet']/method[@name='setShapeRenderer' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.renderer.scatter.IShapeRenderer']]"
			[Register ("setShapeRenderer", "(Lcom/github/mikephil/charting/renderer/scatter/IShapeRenderer;)V", "GetSetShapeRenderer_Lcom_github_mikephil_charting_renderer_scatter_IShapeRenderer_Handler")]
			set {
				const string __id = "setShapeRenderer.(Lcom/github/mikephil/charting/renderer/scatter/IShapeRenderer;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_copy;
#pragma warning disable 0169
		static Delegate GetCopyHandler ()
		{
			if (cb_copy == null)
				cb_copy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Copy);
			return cb_copy;
		}

		static IntPtr n_Copy (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.ScatterDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ScatterDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Copy ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ScatterDataSet']/method[@name='copy' and count(parameter)=0]"
		[Register ("copy", "()Lcom/github/mikephil/charting/data/DataSet;", "GetCopyHandler")]
		public override unsafe global::MikePhil.Charting.Data.DataSet Copy ()
		{
			const string __id = "copy.()Lcom/github/mikephil/charting/data/DataSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_copy_Lcom_github_mikephil_charting_data_ScatterDataSet_;
#pragma warning disable 0169
		static Delegate GetCopy_Lcom_github_mikephil_charting_data_ScatterDataSet_Handler ()
		{
			if (cb_copy_Lcom_github_mikephil_charting_data_ScatterDataSet_ == null)
				cb_copy_Lcom_github_mikephil_charting_data_ScatterDataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Copy_Lcom_github_mikephil_charting_data_ScatterDataSet_);
			return cb_copy_Lcom_github_mikephil_charting_data_ScatterDataSet_;
		}

		static void n_Copy_Lcom_github_mikephil_charting_data_ScatterDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_scatterDataSet)
		{
			global::MikePhil.Charting.Data.ScatterDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ScatterDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.ScatterDataSet scatterDataSet = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ScatterDataSet> (native_scatterDataSet, JniHandleOwnership.DoNotTransfer);
			__this.Copy (scatterDataSet);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ScatterDataSet']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.ScatterDataSet']]"
		[Register ("copy", "(Lcom/github/mikephil/charting/data/ScatterDataSet;)V", "GetCopy_Lcom_github_mikephil_charting_data_ScatterDataSet_Handler")]
		protected virtual unsafe void Copy (global::MikePhil.Charting.Data.ScatterDataSet scatterDataSet)
		{
			const string __id = "copy.(Lcom/github/mikephil/charting/data/ScatterDataSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((scatterDataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) scatterDataSet).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ScatterDataSet']/method[@name='getRendererForShape' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.charts.ScatterChart.ScatterShape']]"
		[Register ("getRendererForShape", "(Lcom/github/mikephil/charting/charts/ScatterChart$ScatterShape;)Lcom/github/mikephil/charting/renderer/scatter/IShapeRenderer;", "")]
		public static unsafe global::MikePhil.Charting.Renderer.Scatter.IShapeRenderer GetRendererForShape (global::MikePhil.Charting.Charts.ScatterChart.ScatterShape shape)
		{
			const string __id = "getRendererForShape.(Lcom/github/mikephil/charting/charts/ScatterChart$ScatterShape;)Lcom/github/mikephil/charting/renderer/scatter/IShapeRenderer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((shape == null) ? IntPtr.Zero : ((global::Java.Lang.Object) shape).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.Scatter.IShapeRenderer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_setScatterShape_Lcom_github_mikephil_charting_charts_ScatterChart_ScatterShape_;
#pragma warning disable 0169
		static Delegate GetSetScatterShape_Lcom_github_mikephil_charting_charts_ScatterChart_ScatterShape_Handler ()
		{
			if (cb_setScatterShape_Lcom_github_mikephil_charting_charts_ScatterChart_ScatterShape_ == null)
				cb_setScatterShape_Lcom_github_mikephil_charting_charts_ScatterChart_ScatterShape_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetScatterShape_Lcom_github_mikephil_charting_charts_ScatterChart_ScatterShape_);
			return cb_setScatterShape_Lcom_github_mikephil_charting_charts_ScatterChart_ScatterShape_;
		}

		static void n_SetScatterShape_Lcom_github_mikephil_charting_charts_ScatterChart_ScatterShape_ (IntPtr jnienv, IntPtr native__this, IntPtr native_shape)
		{
			global::MikePhil.Charting.Data.ScatterDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ScatterDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Charts.ScatterChart.ScatterShape shape = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.ScatterChart.ScatterShape> (native_shape, JniHandleOwnership.DoNotTransfer);
			__this.SetScatterShape (shape);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ScatterDataSet']/method[@name='setScatterShape' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.charts.ScatterChart.ScatterShape']]"
		[Register ("setScatterShape", "(Lcom/github/mikephil/charting/charts/ScatterChart$ScatterShape;)V", "GetSetScatterShape_Lcom_github_mikephil_charting_charts_ScatterChart_ScatterShape_Handler")]
		public virtual unsafe void SetScatterShape (global::MikePhil.Charting.Charts.ScatterChart.ScatterShape shape)
		{
			const string __id = "setScatterShape.(Lcom/github/mikephil/charting/charts/ScatterChart$ScatterShape;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((shape == null) ? IntPtr.Zero : ((global::Java.Lang.Object) shape).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
