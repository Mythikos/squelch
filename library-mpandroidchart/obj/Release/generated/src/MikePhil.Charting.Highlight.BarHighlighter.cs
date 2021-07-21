using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Highlight {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='BarHighlighter']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/highlight/BarHighlighter", DoNotGenerateAcw=true)]
	public partial class BarHighlighter : global::MikePhil.Charting.Highlight.ChartHighlighter {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/highlight/BarHighlighter", typeof (BarHighlighter));
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

		protected BarHighlighter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='BarHighlighter']/constructor[@name='BarHighlighter' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.interfaces.dataprovider.BarDataProvider']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/interfaces/dataprovider/BarDataProvider;)V", "")]
		public unsafe BarHighlighter (global::MikePhil.Charting.Interfaces.Dataprovider.IBarDataProvider chart)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/interfaces/dataprovider/BarDataProvider;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((chart == null) ? IntPtr.Zero : ((global::Java.Lang.Object) chart).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getClosestStackIndex_arrayLcom_github_mikephil_charting_highlight_Range_F;
#pragma warning disable 0169
		static Delegate GetGetClosestStackIndex_arrayLcom_github_mikephil_charting_highlight_Range_FHandler ()
		{
			if (cb_getClosestStackIndex_arrayLcom_github_mikephil_charting_highlight_Range_F == null)
				cb_getClosestStackIndex_arrayLcom_github_mikephil_charting_highlight_Range_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, int>) n_GetClosestStackIndex_arrayLcom_github_mikephil_charting_highlight_Range_F);
			return cb_getClosestStackIndex_arrayLcom_github_mikephil_charting_highlight_Range_F;
		}

		static int n_GetClosestStackIndex_arrayLcom_github_mikephil_charting_highlight_Range_F (IntPtr jnienv, IntPtr native__this, IntPtr native_ranges, float value)
		{
			global::MikePhil.Charting.Highlight.BarHighlighter __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.BarHighlighter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Highlight.Range[] ranges = (global::MikePhil.Charting.Highlight.Range[]) JNIEnv.GetArray (native_ranges, JniHandleOwnership.DoNotTransfer, typeof (global::MikePhil.Charting.Highlight.Range));
			int __ret = __this.GetClosestStackIndex (ranges, value);
			if (ranges != null)
				JNIEnv.CopyArray (ranges, native_ranges);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='BarHighlighter']/method[@name='getClosestStackIndex' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.highlight.Range[]'] and parameter[2][@type='float']]"
		[Register ("getClosestStackIndex", "([Lcom/github/mikephil/charting/highlight/Range;F)I", "GetGetClosestStackIndex_arrayLcom_github_mikephil_charting_highlight_Range_FHandler")]
		protected virtual unsafe int GetClosestStackIndex (global::MikePhil.Charting.Highlight.Range[] ranges, float value)
		{
			const string __id = "getClosestStackIndex.([Lcom/github/mikephil/charting/highlight/Range;F)I";
			IntPtr native_ranges = JNIEnv.NewArray (ranges);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_ranges);
				__args [1] = new JniArgumentValue (value);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				if (ranges != null) {
					JNIEnv.CopyArray (native_ranges, ranges);
					JNIEnv.DeleteLocalRef (native_ranges);
				}
			}
		}

		static Delegate cb_getStackedHighlight_Lcom_github_mikephil_charting_highlight_Highlight_Lcom_github_mikephil_charting_interfaces_datasets_IBarDataSet_FF;
#pragma warning disable 0169
		static Delegate GetGetStackedHighlight_Lcom_github_mikephil_charting_highlight_Highlight_Lcom_github_mikephil_charting_interfaces_datasets_IBarDataSet_FFHandler ()
		{
			if (cb_getStackedHighlight_Lcom_github_mikephil_charting_highlight_Highlight_Lcom_github_mikephil_charting_interfaces_datasets_IBarDataSet_FF == null)
				cb_getStackedHighlight_Lcom_github_mikephil_charting_highlight_Highlight_Lcom_github_mikephil_charting_interfaces_datasets_IBarDataSet_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, float, float, IntPtr>) n_GetStackedHighlight_Lcom_github_mikephil_charting_highlight_Highlight_Lcom_github_mikephil_charting_interfaces_datasets_IBarDataSet_FF);
			return cb_getStackedHighlight_Lcom_github_mikephil_charting_highlight_Highlight_Lcom_github_mikephil_charting_interfaces_datasets_IBarDataSet_FF;
		}

		static IntPtr n_GetStackedHighlight_Lcom_github_mikephil_charting_highlight_Highlight_Lcom_github_mikephil_charting_interfaces_datasets_IBarDataSet_FF (IntPtr jnienv, IntPtr native__this, IntPtr native_high, IntPtr native_set, float xVal, float yVal)
		{
			global::MikePhil.Charting.Highlight.BarHighlighter __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.BarHighlighter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Highlight.Highlight high = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (native_high, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Interfaces.Datasets.IBarDataSet set = (global::MikePhil.Charting.Interfaces.Datasets.IBarDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IBarDataSet> (native_set, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetStackedHighlight (high, set, xVal, yVal));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='BarHighlighter']/method[@name='getStackedHighlight' and count(parameter)=4 and parameter[1][@type='com.github.mikephil.charting.highlight.Highlight'] and parameter[2][@type='com.github.mikephil.charting.interfaces.datasets.IBarDataSet'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("getStackedHighlight", "(Lcom/github/mikephil/charting/highlight/Highlight;Lcom/github/mikephil/charting/interfaces/datasets/IBarDataSet;FF)Lcom/github/mikephil/charting/highlight/Highlight;", "GetGetStackedHighlight_Lcom_github_mikephil_charting_highlight_Highlight_Lcom_github_mikephil_charting_interfaces_datasets_IBarDataSet_FFHandler")]
		public virtual unsafe global::MikePhil.Charting.Highlight.Highlight GetStackedHighlight (global::MikePhil.Charting.Highlight.Highlight high, global::MikePhil.Charting.Interfaces.Datasets.IBarDataSet set, float xVal, float yVal)
		{
			const string __id = "getStackedHighlight.(Lcom/github/mikephil/charting/highlight/Highlight;Lcom/github/mikephil/charting/interfaces/datasets/IBarDataSet;FF)Lcom/github/mikephil/charting/highlight/Highlight;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((high == null) ? IntPtr.Zero : ((global::Java.Lang.Object) high).Handle);
				__args [1] = new JniArgumentValue ((set == null) ? IntPtr.Zero : ((global::Java.Lang.Object) set).Handle);
				__args [2] = new JniArgumentValue (xVal);
				__args [3] = new JniArgumentValue (yVal);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
