using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineRadarDataSet']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/LineRadarDataSet", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.github.mikephil.charting.data.Entry"})]
	public abstract partial class LineRadarDataSet : global::MikePhil.Charting.Data.LineScatterCandleRadarDataSet, global::MikePhil.Charting.Interfaces.Datasets.ILineRadarDataSet {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineRadarDataSet']/field[@name='mFillDrawable']"
		[Register ("mFillDrawable")]
		protected global::Android.Graphics.Drawables.Drawable MFillDrawable {
			get {
				const string __id = "mFillDrawable.Landroid/graphics/drawable/Drawable;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mFillDrawable.Landroid/graphics/drawable/Drawable;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/LineRadarDataSet", typeof (LineRadarDataSet));
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

		protected LineRadarDataSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineRadarDataSet']/constructor[@name='LineRadarDataSet' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;T&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/util/List;Ljava/lang/String;)V", "")]
		public unsafe LineRadarDataSet (global::System.Collections.IList yVals, string label)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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
			}
		}

		static Delegate cb_getFillAlpha;
#pragma warning disable 0169
		static Delegate GetGetFillAlphaHandler ()
		{
			if (cb_getFillAlpha == null)
				cb_getFillAlpha = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFillAlpha);
			return cb_getFillAlpha;
		}

		static int n_GetFillAlpha (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.LineRadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineRadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FillAlpha;
		}
#pragma warning restore 0169

		static Delegate cb_setFillAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetFillAlpha_IHandler ()
		{
			if (cb_setFillAlpha_I == null)
				cb_setFillAlpha_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFillAlpha_I);
			return cb_setFillAlpha_I;
		}

		static void n_SetFillAlpha_I (IntPtr jnienv, IntPtr native__this, int alpha)
		{
			global::MikePhil.Charting.Data.LineRadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineRadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FillAlpha = alpha;
		}
#pragma warning restore 0169

		public virtual unsafe int FillAlpha {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineRadarDataSet']/method[@name='getFillAlpha' and count(parameter)=0]"
			[Register ("getFillAlpha", "()I", "GetGetFillAlphaHandler")]
			get {
				const string __id = "getFillAlpha.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineRadarDataSet']/method[@name='setFillAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFillAlpha", "(I)V", "GetSetFillAlpha_IHandler")]
			set {
				const string __id = "setFillAlpha.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFillColor;
#pragma warning disable 0169
		static Delegate GetGetFillColorHandler ()
		{
			if (cb_getFillColor == null)
				cb_getFillColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFillColor);
			return cb_getFillColor;
		}

		static int n_GetFillColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.LineRadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineRadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FillColor;
		}
#pragma warning restore 0169

		static Delegate cb_setFillColor_I;
#pragma warning disable 0169
		static Delegate GetSetFillColor_IHandler ()
		{
			if (cb_setFillColor_I == null)
				cb_setFillColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetFillColor_I);
			return cb_setFillColor_I;
		}

		static void n_SetFillColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::MikePhil.Charting.Data.LineRadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineRadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FillColor = color;
		}
#pragma warning restore 0169

		public virtual unsafe int FillColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineRadarDataSet']/method[@name='getFillColor' and count(parameter)=0]"
			[Register ("getFillColor", "()I", "GetGetFillColorHandler")]
			get {
				const string __id = "getFillColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineRadarDataSet']/method[@name='setFillColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setFillColor", "(I)V", "GetSetFillColor_IHandler")]
			set {
				const string __id = "setFillColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFillDrawable;
#pragma warning disable 0169
		static Delegate GetGetFillDrawableHandler ()
		{
			if (cb_getFillDrawable == null)
				cb_getFillDrawable = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFillDrawable);
			return cb_getFillDrawable;
		}

		static IntPtr n_GetFillDrawable (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.LineRadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineRadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FillDrawable);
		}
#pragma warning restore 0169

		static Delegate cb_setFillDrawable_Landroid_graphics_drawable_Drawable_;
#pragma warning disable 0169
		static Delegate GetSetFillDrawable_Landroid_graphics_drawable_Drawable_Handler ()
		{
			if (cb_setFillDrawable_Landroid_graphics_drawable_Drawable_ == null)
				cb_setFillDrawable_Landroid_graphics_drawable_Drawable_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFillDrawable_Landroid_graphics_drawable_Drawable_);
			return cb_setFillDrawable_Landroid_graphics_drawable_Drawable_;
		}

		static void n_SetFillDrawable_Landroid_graphics_drawable_Drawable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_drawable)
		{
			global::MikePhil.Charting.Data.LineRadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineRadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Drawables.Drawable drawable = global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (native_drawable, JniHandleOwnership.DoNotTransfer);
			__this.FillDrawable = drawable;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Drawables.Drawable FillDrawable {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineRadarDataSet']/method[@name='getFillDrawable' and count(parameter)=0]"
			[Register ("getFillDrawable", "()Landroid/graphics/drawable/Drawable;", "GetGetFillDrawableHandler")]
			get {
				const string __id = "getFillDrawable.()Landroid/graphics/drawable/Drawable;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineRadarDataSet']/method[@name='setFillDrawable' and count(parameter)=1 and parameter[1][@type='android.graphics.drawable.Drawable']]"
			[Register ("setFillDrawable", "(Landroid/graphics/drawable/Drawable;)V", "GetSetFillDrawable_Landroid_graphics_drawable_Drawable_Handler")]
			set {
				const string __id = "setFillDrawable.(Landroid/graphics/drawable/Drawable;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDrawFilledEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawFilledEnabledHandler ()
		{
			if (cb_isDrawFilledEnabled == null)
				cb_isDrawFilledEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawFilledEnabled);
			return cb_isDrawFilledEnabled;
		}

		static bool n_IsDrawFilledEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.LineRadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineRadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawFilledEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrawFilledEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineRadarDataSet']/method[@name='isDrawFilledEnabled' and count(parameter)=0]"
			[Register ("isDrawFilledEnabled", "()Z", "GetIsDrawFilledEnabledHandler")]
			get {
				const string __id = "isDrawFilledEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLineWidth;
#pragma warning disable 0169
		static Delegate GetGetLineWidthHandler ()
		{
			if (cb_getLineWidth == null)
				cb_getLineWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetLineWidth);
			return cb_getLineWidth;
		}

		static float n_GetLineWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.LineRadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineRadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LineWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setLineWidth_F;
#pragma warning disable 0169
		static Delegate GetSetLineWidth_FHandler ()
		{
			if (cb_setLineWidth_F == null)
				cb_setLineWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetLineWidth_F);
			return cb_setLineWidth_F;
		}

		static void n_SetLineWidth_F (IntPtr jnienv, IntPtr native__this, float width)
		{
			global::MikePhil.Charting.Data.LineRadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineRadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LineWidth = width;
		}
#pragma warning restore 0169

		public virtual unsafe float LineWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineRadarDataSet']/method[@name='getLineWidth' and count(parameter)=0]"
			[Register ("getLineWidth", "()F", "GetGetLineWidthHandler")]
			get {
				const string __id = "getLineWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineRadarDataSet']/method[@name='setLineWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setLineWidth", "(F)V", "GetSetLineWidth_FHandler")]
			set {
				const string __id = "setLineWidth.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_copy_Lcom_github_mikephil_charting_data_LineRadarDataSet_;
#pragma warning disable 0169
		static Delegate GetCopy_Lcom_github_mikephil_charting_data_LineRadarDataSet_Handler ()
		{
			if (cb_copy_Lcom_github_mikephil_charting_data_LineRadarDataSet_ == null)
				cb_copy_Lcom_github_mikephil_charting_data_LineRadarDataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Copy_Lcom_github_mikephil_charting_data_LineRadarDataSet_);
			return cb_copy_Lcom_github_mikephil_charting_data_LineRadarDataSet_;
		}

		static void n_Copy_Lcom_github_mikephil_charting_data_LineRadarDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_lineRadarDataSet)
		{
			global::MikePhil.Charting.Data.LineRadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineRadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.LineRadarDataSet lineRadarDataSet = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineRadarDataSet> (native_lineRadarDataSet, JniHandleOwnership.DoNotTransfer);
			__this.Copy (lineRadarDataSet);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineRadarDataSet']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.LineRadarDataSet']]"
		[Register ("copy", "(Lcom/github/mikephil/charting/data/LineRadarDataSet;)V", "GetCopy_Lcom_github_mikephil_charting_data_LineRadarDataSet_Handler")]
		protected virtual unsafe void Copy (global::MikePhil.Charting.Data.LineRadarDataSet lineRadarDataSet)
		{
			const string __id = "copy.(Lcom/github/mikephil/charting/data/LineRadarDataSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((lineRadarDataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lineRadarDataSet).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawFilled_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawFilled_ZHandler ()
		{
			if (cb_setDrawFilled_Z == null)
				cb_setDrawFilled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawFilled_Z);
			return cb_setDrawFilled_Z;
		}

		static void n_SetDrawFilled_Z (IntPtr jnienv, IntPtr native__this, bool filled)
		{
			global::MikePhil.Charting.Data.LineRadarDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineRadarDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawFilled (filled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='LineRadarDataSet']/method[@name='setDrawFilled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawFilled", "(Z)V", "GetSetDrawFilled_ZHandler")]
		public virtual unsafe void SetDrawFilled (bool filled)
		{
			const string __id = "setDrawFilled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (filled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/LineRadarDataSet", DoNotGenerateAcw=true)]
	internal partial class LineRadarDataSetInvoker : LineRadarDataSet, global::MikePhil.Charting.Interfaces.Datasets.ILineRadarDataSet, global::MikePhil.Charting.Interfaces.Datasets.ILineScatterCandleRadarDataSet, global::MikePhil.Charting.Interfaces.Datasets.IBarLineScatterCandleBubbleDataSet, global::MikePhil.Charting.Interfaces.Datasets.IDataSet {

		public LineRadarDataSetInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/LineRadarDataSet", typeof (LineRadarDataSetInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

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
