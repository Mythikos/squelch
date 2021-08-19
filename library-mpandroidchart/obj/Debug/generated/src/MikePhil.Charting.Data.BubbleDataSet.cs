using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BubbleDataSet']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/BubbleDataSet", DoNotGenerateAcw=true)]
	public partial class BubbleDataSet : global::MikePhil.Charting.Data.BarLineScatterCandleBubbleDataSet, global::MikePhil.Charting.Interfaces.Datasets.IBubbleDataSet {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BubbleDataSet']/field[@name='mMaxSize']"
		[Register ("mMaxSize")]
		protected float MMaxSize {
			get {
				const string __id = "mMaxSize.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mMaxSize.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BubbleDataSet']/field[@name='mNormalizeSize']"
		[Register ("mNormalizeSize")]
		protected bool MNormalizeSize {
			get {
				const string __id = "mNormalizeSize.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mNormalizeSize.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/BubbleDataSet", typeof (BubbleDataSet));

		internal static new IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected BubbleDataSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BubbleDataSet']/constructor[@name='BubbleDataSet' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.github.mikephil.charting.data.BubbleEntry&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/util/List;Ljava/lang/String;)V", "")]
		public unsafe BubbleDataSet (global::System.Collections.Generic.IList<global::MikePhil.Charting.Data.BubbleEntry> yVals, string label) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_yVals = global::Android.Runtime.JavaList<global::MikePhil.Charting.Data.BubbleEntry>.ToLocalJniHandle (yVals);
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
				global::System.GC.KeepAlive (yVals);
			}
		}

		static Delegate cb_getHighlightCircleWidth;
#pragma warning disable 0169
		static Delegate GetGetHighlightCircleWidthHandler ()
		{
			if (cb_getHighlightCircleWidth == null)
				cb_getHighlightCircleWidth = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetHighlightCircleWidth);
			return cb_getHighlightCircleWidth;
		}

		static float n_GetHighlightCircleWidth (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BubbleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighlightCircleWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setHighlightCircleWidth_F;
#pragma warning disable 0169
		static Delegate GetSetHighlightCircleWidth_FHandler ()
		{
			if (cb_setHighlightCircleWidth_F == null)
				cb_setHighlightCircleWidth_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetHighlightCircleWidth_F);
			return cb_setHighlightCircleWidth_F;
		}

		static void n_SetHighlightCircleWidth_F (IntPtr jnienv, IntPtr native__this, float width)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BubbleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighlightCircleWidth = width;
		}
#pragma warning restore 0169

		public virtual unsafe float HighlightCircleWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BubbleDataSet']/method[@name='getHighlightCircleWidth' and count(parameter)=0]"
			[Register ("getHighlightCircleWidth", "()F", "GetGetHighlightCircleWidthHandler")]
			get {
				const string __id = "getHighlightCircleWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BubbleDataSet']/method[@name='setHighlightCircleWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setHighlightCircleWidth", "(F)V", "GetSetHighlightCircleWidth_FHandler")]
			set {
				const string __id = "setHighlightCircleWidth.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isNormalizeSizeEnabled;
#pragma warning disable 0169
		static Delegate GetIsNormalizeSizeEnabledHandler ()
		{
			if (cb_isNormalizeSizeEnabled == null)
				cb_isNormalizeSizeEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsNormalizeSizeEnabled);
			return cb_isNormalizeSizeEnabled;
		}

		static bool n_IsNormalizeSizeEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BubbleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsNormalizeSizeEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsNormalizeSizeEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BubbleDataSet']/method[@name='isNormalizeSizeEnabled' and count(parameter)=0]"
			[Register ("isNormalizeSizeEnabled", "()Z", "GetIsNormalizeSizeEnabledHandler")]
			get {
				const string __id = "isNormalizeSizeEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMaxSize;
#pragma warning disable 0169
		static Delegate GetGetMaxSizeHandler ()
		{
			if (cb_getMaxSize == null)
				cb_getMaxSize = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetMaxSize);
			return cb_getMaxSize;
		}

		static float n_GetMaxSize (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BubbleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxSize;
		}
#pragma warning restore 0169

		public virtual unsafe float MaxSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BubbleDataSet']/method[@name='getMaxSize' and count(parameter)=0]"
			[Register ("getMaxSize", "()F", "GetGetMaxSizeHandler")]
			get {
				const string __id = "getMaxSize.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_calcMinMax_Lcom_github_mikephil_charting_data_BubbleEntry_;
#pragma warning disable 0169
		static Delegate GetCalcMinMax_Lcom_github_mikephil_charting_data_BubbleEntry_Handler ()
		{
			if (cb_calcMinMax_Lcom_github_mikephil_charting_data_BubbleEntry_ == null)
				cb_calcMinMax_Lcom_github_mikephil_charting_data_BubbleEntry_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CalcMinMax_Lcom_github_mikephil_charting_data_BubbleEntry_);
			return cb_calcMinMax_Lcom_github_mikephil_charting_data_BubbleEntry_;
		}

		static void n_CalcMinMax_Lcom_github_mikephil_charting_data_BubbleEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BubbleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BubbleEntry> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.CalcMinMax (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BubbleDataSet']/method[@name='calcMinMax' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.BubbleEntry']]"
		[Register ("calcMinMax", "(Lcom/github/mikephil/charting/data/BubbleEntry;)V", "GetCalcMinMax_Lcom_github_mikephil_charting_data_BubbleEntry_Handler")]
		protected virtual unsafe void CalcMinMax (global::MikePhil.Charting.Data.BubbleEntry e)
		{
			const string __id = "calcMinMax.(Lcom/github/mikephil/charting/data/BubbleEntry;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (e);
			}
		}

		static Delegate cb_copy;
#pragma warning disable 0169
		static Delegate GetCopyHandler ()
		{
			if (cb_copy == null)
				cb_copy = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_Copy);
			return cb_copy;
		}

		static IntPtr n_Copy (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BubbleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Copy ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BubbleDataSet']/method[@name='copy' and count(parameter)=0]"
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

		static Delegate cb_copy_Lcom_github_mikephil_charting_data_BubbleDataSet_;
#pragma warning disable 0169
		static Delegate GetCopy_Lcom_github_mikephil_charting_data_BubbleDataSet_Handler ()
		{
			if (cb_copy_Lcom_github_mikephil_charting_data_BubbleDataSet_ == null)
				cb_copy_Lcom_github_mikephil_charting_data_BubbleDataSet_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_Copy_Lcom_github_mikephil_charting_data_BubbleDataSet_);
			return cb_copy_Lcom_github_mikephil_charting_data_BubbleDataSet_;
		}

		static void n_Copy_Lcom_github_mikephil_charting_data_BubbleDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_bubbleDataSet)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BubbleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var bubbleDataSet = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BubbleDataSet> (native_bubbleDataSet, JniHandleOwnership.DoNotTransfer);
			__this.Copy (bubbleDataSet);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BubbleDataSet']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.BubbleDataSet']]"
		[Register ("copy", "(Lcom/github/mikephil/charting/data/BubbleDataSet;)V", "GetCopy_Lcom_github_mikephil_charting_data_BubbleDataSet_Handler")]
		protected virtual unsafe void Copy (global::MikePhil.Charting.Data.BubbleDataSet bubbleDataSet)
		{
			const string __id = "copy.(Lcom/github/mikephil/charting/data/BubbleDataSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((bubbleDataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) bubbleDataSet).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (bubbleDataSet);
			}
		}

		static Delegate cb_setNormalizeSizeEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetNormalizeSizeEnabled_ZHandler ()
		{
			if (cb_setNormalizeSizeEnabled_Z == null)
				cb_setNormalizeSizeEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetNormalizeSizeEnabled_Z);
			return cb_setNormalizeSizeEnabled_Z;
		}

		static void n_SetNormalizeSizeEnabled_Z (IntPtr jnienv, IntPtr native__this, bool normalizeSize)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BubbleDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetNormalizeSizeEnabled (normalizeSize);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BubbleDataSet']/method[@name='setNormalizeSizeEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setNormalizeSizeEnabled", "(Z)V", "GetSetNormalizeSizeEnabled_ZHandler")]
		public virtual unsafe void SetNormalizeSizeEnabled (bool normalizeSize)
		{
			const string __id = "setNormalizeSizeEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (normalizeSize);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
