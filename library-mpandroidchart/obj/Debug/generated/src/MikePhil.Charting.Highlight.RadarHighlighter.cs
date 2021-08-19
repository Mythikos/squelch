using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Highlight {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='RadarHighlighter']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/highlight/RadarHighlighter", DoNotGenerateAcw=true)]
	public partial class RadarHighlighter : global::MikePhil.Charting.Highlight.PieRadarHighlighter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/highlight/RadarHighlighter", typeof (RadarHighlighter));

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

		protected RadarHighlighter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='RadarHighlighter']/constructor[@name='RadarHighlighter' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.charts.RadarChart']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/charts/RadarChart;)V", "")]
		public unsafe RadarHighlighter (global::MikePhil.Charting.Charts.RadarChart chart) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/charts/RadarChart;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((chart == null) ? IntPtr.Zero : ((global::Java.Lang.Object) chart).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (chart);
			}
		}

		static Delegate cb_getClosestHighlight_IFF;
#pragma warning disable 0169
		static Delegate GetGetClosestHighlight_IFFHandler ()
		{
			if (cb_getClosestHighlight_IFF == null)
				cb_getClosestHighlight_IFF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPIFF_L) n_GetClosestHighlight_IFF);
			return cb_getClosestHighlight_IFF;
		}

		static IntPtr n_GetClosestHighlight_IFF (IntPtr jnienv, IntPtr native__this, int index, float x, float y)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.RadarHighlighter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetClosestHighlight (index, x, y));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='RadarHighlighter']/method[@name='getClosestHighlight' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("getClosestHighlight", "(IFF)Lcom/github/mikephil/charting/highlight/Highlight;", "GetGetClosestHighlight_IFFHandler")]
		protected override unsafe global::MikePhil.Charting.Highlight.Highlight GetClosestHighlight (int index, float x, float y)
		{
			const string __id = "getClosestHighlight.(IFF)Lcom/github/mikephil/charting/highlight/Highlight;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (index);
				__args [1] = new JniArgumentValue (x);
				__args [2] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getHighlightsAtIndex_I;
#pragma warning disable 0169
		static Delegate GetGetHighlightsAtIndex_IHandler ()
		{
			if (cb_getHighlightsAtIndex_I == null)
				cb_getHighlightsAtIndex_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetHighlightsAtIndex_I);
			return cb_getHighlightsAtIndex_I;
		}

		static IntPtr n_GetHighlightsAtIndex_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.RadarHighlighter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::MikePhil.Charting.Highlight.Highlight>.ToLocalJniHandle (__this.GetHighlightsAtIndex (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='RadarHighlighter']/method[@name='getHighlightsAtIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getHighlightsAtIndex", "(I)Ljava/util/List;", "GetGetHighlightsAtIndex_IHandler")]
		protected virtual unsafe global::System.Collections.Generic.IList<global::MikePhil.Charting.Highlight.Highlight> GetHighlightsAtIndex (int index)
		{
			const string __id = "getHighlightsAtIndex.(I)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList<global::MikePhil.Charting.Highlight.Highlight>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
