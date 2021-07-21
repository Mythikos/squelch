using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarLineScatterCandleBubbleRenderer']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/renderer/BarLineScatterCandleBubbleRenderer", DoNotGenerateAcw=true)]
	public abstract partial class BarLineScatterCandleBubbleRenderer : global::MikePhil.Charting.Renderer.DataRenderer {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarLineScatterCandleBubbleRenderer']/field[@name='mXBounds']"
		[Register ("mXBounds")]
		protected global::MikePhil.Charting.Renderer.BarLineScatterCandleBubbleRenderer.XBounds MXBounds {
			get {
				const string __id = "mXBounds.Lcom/github/mikephil/charting/renderer/BarLineScatterCandleBubbleRenderer$XBounds;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.BarLineScatterCandleBubbleRenderer.XBounds> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mXBounds.Lcom/github/mikephil/charting/renderer/BarLineScatterCandleBubbleRenderer$XBounds;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarLineScatterCandleBubbleRenderer.XBounds']"
		[global::Android.Runtime.Register ("com/github/mikephil/charting/renderer/BarLineScatterCandleBubbleRenderer$XBounds", DoNotGenerateAcw=true)]
		protected internal partial class XBounds : global::Java.Lang.Object {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarLineScatterCandleBubbleRenderer.XBounds']/field[@name='max']"
			[Register ("max")]
			public int Max {
				get {
					const string __id = "max.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "max.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarLineScatterCandleBubbleRenderer.XBounds']/field[@name='min']"
			[Register ("min")]
			public int Min {
				get {
					const string __id = "min.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "min.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarLineScatterCandleBubbleRenderer.XBounds']/field[@name='range']"
			[Register ("range")]
			public int Range {
				get {
					const string __id = "range.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "range.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/renderer/BarLineScatterCandleBubbleRenderer$XBounds", typeof (XBounds));
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

			protected XBounds (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarLineScatterCandleBubbleRenderer.XBounds']/constructor[@name='BarLineScatterCandleBubbleRenderer.XBounds' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.renderer.BarLineScatterCandleBubbleRenderer']]"
			[Register (".ctor", "(Lcom/github/mikephil/charting/renderer/BarLineScatterCandleBubbleRenderer;)V", "")]
			protected unsafe XBounds (global::MikePhil.Charting.Renderer.BarLineScatterCandleBubbleRenderer __self)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				string __id = "(L" + global::Android.Runtime.JNIEnv.GetJniName (GetType ().DeclaringType) + ";)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((__self == null) ? IntPtr.Zero : ((global::Java.Lang.Object) __self).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			static Delegate cb_set_Lcom_github_mikephil_charting_interfaces_dataprovider_BarLineScatterCandleBubbleDataProvider_Lcom_github_mikephil_charting_interfaces_datasets_IBarLineScatterCandleBubbleDataSet_;
#pragma warning disable 0169
			static Delegate GetSet_Lcom_github_mikephil_charting_interfaces_dataprovider_BarLineScatterCandleBubbleDataProvider_Lcom_github_mikephil_charting_interfaces_datasets_IBarLineScatterCandleBubbleDataSet_Handler ()
			{
				if (cb_set_Lcom_github_mikephil_charting_interfaces_dataprovider_BarLineScatterCandleBubbleDataProvider_Lcom_github_mikephil_charting_interfaces_datasets_IBarLineScatterCandleBubbleDataSet_ == null)
					cb_set_Lcom_github_mikephil_charting_interfaces_dataprovider_BarLineScatterCandleBubbleDataProvider_Lcom_github_mikephil_charting_interfaces_datasets_IBarLineScatterCandleBubbleDataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_Set_Lcom_github_mikephil_charting_interfaces_dataprovider_BarLineScatterCandleBubbleDataProvider_Lcom_github_mikephil_charting_interfaces_datasets_IBarLineScatterCandleBubbleDataSet_);
				return cb_set_Lcom_github_mikephil_charting_interfaces_dataprovider_BarLineScatterCandleBubbleDataProvider_Lcom_github_mikephil_charting_interfaces_datasets_IBarLineScatterCandleBubbleDataSet_;
			}

			static void n_Set_Lcom_github_mikephil_charting_interfaces_dataprovider_BarLineScatterCandleBubbleDataProvider_Lcom_github_mikephil_charting_interfaces_datasets_IBarLineScatterCandleBubbleDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_chart, IntPtr native_dataSet)
			{
				global::MikePhil.Charting.Renderer.BarLineScatterCandleBubbleRenderer.XBounds __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.BarLineScatterCandleBubbleRenderer.XBounds> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				global::MikePhil.Charting.Interfaces.Dataprovider.IBarLineScatterCandleBubbleDataProvider chart = (global::MikePhil.Charting.Interfaces.Dataprovider.IBarLineScatterCandleBubbleDataProvider)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Dataprovider.IBarLineScatterCandleBubbleDataProvider> (native_chart, JniHandleOwnership.DoNotTransfer);
				global::MikePhil.Charting.Interfaces.Datasets.IBarLineScatterCandleBubbleDataSet dataSet = (global::MikePhil.Charting.Interfaces.Datasets.IBarLineScatterCandleBubbleDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IBarLineScatterCandleBubbleDataSet> (native_dataSet, JniHandleOwnership.DoNotTransfer);
				__this.Set (chart, dataSet);
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarLineScatterCandleBubbleRenderer.XBounds']/method[@name='set' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.interfaces.dataprovider.BarLineScatterCandleBubbleDataProvider'] and parameter[2][@type='com.github.mikephil.charting.interfaces.datasets.IBarLineScatterCandleBubbleDataSet']]"
			[Register ("set", "(Lcom/github/mikephil/charting/interfaces/dataprovider/BarLineScatterCandleBubbleDataProvider;Lcom/github/mikephil/charting/interfaces/datasets/IBarLineScatterCandleBubbleDataSet;)V", "GetSet_Lcom_github_mikephil_charting_interfaces_dataprovider_BarLineScatterCandleBubbleDataProvider_Lcom_github_mikephil_charting_interfaces_datasets_IBarLineScatterCandleBubbleDataSet_Handler")]
			public virtual unsafe void Set (global::MikePhil.Charting.Interfaces.Dataprovider.IBarLineScatterCandleBubbleDataProvider chart, global::MikePhil.Charting.Interfaces.Datasets.IBarLineScatterCandleBubbleDataSet dataSet)
			{
				const string __id = "set.(Lcom/github/mikephil/charting/interfaces/dataprovider/BarLineScatterCandleBubbleDataProvider;Lcom/github/mikephil/charting/interfaces/datasets/IBarLineScatterCandleBubbleDataSet;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((chart == null) ? IntPtr.Zero : ((global::Java.Lang.Object) chart).Handle);
					__args [1] = new JniArgumentValue ((dataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSet).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}

		}

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/renderer/BarLineScatterCandleBubbleRenderer", typeof (BarLineScatterCandleBubbleRenderer));
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

		protected BarLineScatterCandleBubbleRenderer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarLineScatterCandleBubbleRenderer']/constructor[@name='BarLineScatterCandleBubbleRenderer' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.animation.ChartAnimator'] and parameter[2][@type='com.github.mikephil.charting.utils.ViewPortHandler']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/animation/ChartAnimator;Lcom/github/mikephil/charting/utils/ViewPortHandler;)V", "")]
		public unsafe BarLineScatterCandleBubbleRenderer (global::MikePhil.Charting.Animation.ChartAnimator animator, global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/animation/ChartAnimator;Lcom/github/mikephil/charting/utils/ViewPortHandler;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((animator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) animator).Handle);
				__args [1] = new JniArgumentValue ((viewPortHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPortHandler).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_isInBoundsX_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_interfaces_datasets_IBarLineScatterCandleBubbleDataSet_;
#pragma warning disable 0169
		static Delegate GetIsInBoundsX_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_interfaces_datasets_IBarLineScatterCandleBubbleDataSet_Handler ()
		{
			if (cb_isInBoundsX_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_interfaces_datasets_IBarLineScatterCandleBubbleDataSet_ == null)
				cb_isInBoundsX_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_interfaces_datasets_IBarLineScatterCandleBubbleDataSet_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_IsInBoundsX_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_interfaces_datasets_IBarLineScatterCandleBubbleDataSet_);
			return cb_isInBoundsX_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_interfaces_datasets_IBarLineScatterCandleBubbleDataSet_;
		}

		static bool n_IsInBoundsX_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_interfaces_datasets_IBarLineScatterCandleBubbleDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_set)
		{
			global::MikePhil.Charting.Renderer.BarLineScatterCandleBubbleRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.BarLineScatterCandleBubbleRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.Entry e = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.Entry> (native_e, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Interfaces.Datasets.IBarLineScatterCandleBubbleDataSet set = (global::MikePhil.Charting.Interfaces.Datasets.IBarLineScatterCandleBubbleDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IBarLineScatterCandleBubbleDataSet> (native_set, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.IsInBoundsX (e, set);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarLineScatterCandleBubbleRenderer']/method[@name='isInBoundsX' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.data.Entry'] and parameter[2][@type='com.github.mikephil.charting.interfaces.datasets.IBarLineScatterCandleBubbleDataSet']]"
		[Register ("isInBoundsX", "(Lcom/github/mikephil/charting/data/Entry;Lcom/github/mikephil/charting/interfaces/datasets/IBarLineScatterCandleBubbleDataSet;)Z", "GetIsInBoundsX_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_interfaces_datasets_IBarLineScatterCandleBubbleDataSet_Handler")]
		protected virtual unsafe bool IsInBoundsX (global::MikePhil.Charting.Data.Entry e, global::MikePhil.Charting.Interfaces.Datasets.IBarLineScatterCandleBubbleDataSet set)
		{
			const string __id = "isInBoundsX.(Lcom/github/mikephil/charting/data/Entry;Lcom/github/mikephil/charting/interfaces/datasets/IBarLineScatterCandleBubbleDataSet;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				__args [1] = new JniArgumentValue ((set == null) ? IntPtr.Zero : ((global::Java.Lang.Object) set).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_shouldDrawValues_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_;
#pragma warning disable 0169
		static Delegate GetShouldDrawValues_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_Handler ()
		{
			if (cb_shouldDrawValues_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ == null)
				cb_shouldDrawValues_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_ShouldDrawValues_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_);
			return cb_shouldDrawValues_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_;
		}

		static bool n_ShouldDrawValues_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_set)
		{
			global::MikePhil.Charting.Renderer.BarLineScatterCandleBubbleRenderer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Renderer.BarLineScatterCandleBubbleRenderer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Interfaces.Datasets.IDataSet set = (global::MikePhil.Charting.Interfaces.Datasets.IDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IDataSet> (native_set, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.ShouldDrawValues (set);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='BarLineScatterCandleBubbleRenderer']/method[@name='shouldDrawValues' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.interfaces.datasets.IDataSet']]"
		[Register ("shouldDrawValues", "(Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;)Z", "GetShouldDrawValues_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_Handler")]
		protected virtual unsafe bool ShouldDrawValues (global::MikePhil.Charting.Interfaces.Datasets.IDataSet set)
		{
			const string __id = "shouldDrawValues.(Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((set == null) ? IntPtr.Zero : ((global::Java.Lang.Object) set).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/renderer/BarLineScatterCandleBubbleRenderer", DoNotGenerateAcw=true)]
	internal partial class BarLineScatterCandleBubbleRendererInvoker : BarLineScatterCandleBubbleRenderer {

		public BarLineScatterCandleBubbleRendererInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/github/mikephil/charting/renderer/BarLineScatterCandleBubbleRenderer", typeof (BarLineScatterCandleBubbleRendererInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/method[@name='drawData' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawData", "(Landroid/graphics/Canvas;)V", "GetDrawData_Landroid_graphics_Canvas_Handler")]
		public override unsafe void DrawData (global::Android.Graphics.Canvas p0)
		{
			const string __id = "drawData.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/method[@name='drawExtras' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawExtras", "(Landroid/graphics/Canvas;)V", "GetDrawExtras_Landroid_graphics_Canvas_Handler")]
		public override unsafe void DrawExtras (global::Android.Graphics.Canvas p0)
		{
			const string __id = "drawExtras.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/method[@name='drawHighlighted' and count(parameter)=2 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='com.github.mikephil.charting.highlight.Highlight[]']]"
		[Register ("drawHighlighted", "(Landroid/graphics/Canvas;[Lcom/github/mikephil/charting/highlight/Highlight;)V", "GetDrawHighlighted_Landroid_graphics_Canvas_arrayLcom_github_mikephil_charting_highlight_Highlight_Handler")]
		public override unsafe void DrawHighlighted (global::Android.Graphics.Canvas p0, global::MikePhil.Charting.Highlight.Highlight[] p1)
		{
			const string __id = "drawHighlighted.(Landroid/graphics/Canvas;[Lcom/github/mikephil/charting/highlight/Highlight;)V";
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				__args [1] = new JniArgumentValue (native_p1);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/method[@name='drawValues' and count(parameter)=1 and parameter[1][@type='android.graphics.Canvas']]"
		[Register ("drawValues", "(Landroid/graphics/Canvas;)V", "GetDrawValues_Landroid_graphics_Canvas_Handler")]
		public override unsafe void DrawValues (global::Android.Graphics.Canvas p0)
		{
			const string __id = "drawValues.(Landroid/graphics/Canvas;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p0).Handle);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='DataRenderer']/method[@name='initBuffers' and count(parameter)=0]"
		[Register ("initBuffers", "()V", "GetInitBuffersHandler")]
		public override unsafe void InitBuffers ()
		{
			const string __id = "initBuffers.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}

}
