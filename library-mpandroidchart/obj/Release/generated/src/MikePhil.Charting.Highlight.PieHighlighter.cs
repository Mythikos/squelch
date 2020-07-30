using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Highlight {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='PieHighlighter']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/highlight/PieHighlighter", DoNotGenerateAcw=true)]
	public partial class PieHighlighter : global::MikePhil.Charting.Highlight.PieRadarHighlighter {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/highlight/PieHighlighter", typeof (PieHighlighter));
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

		protected PieHighlighter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='PieHighlighter']/constructor[@name='PieHighlighter' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.charts.PieChart']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/charts/PieChart;)V", "")]
		public unsafe PieHighlighter (global::MikePhil.Charting.Charts.PieChart chart)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/charts/PieChart;)V";

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

		static Delegate cb_getClosestHighlight_IFF;
#pragma warning disable 0169
		static Delegate GetGetClosestHighlight_IFFHandler ()
		{
			if (cb_getClosestHighlight_IFF == null)
				cb_getClosestHighlight_IFF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, float, float, IntPtr>) n_GetClosestHighlight_IFF);
			return cb_getClosestHighlight_IFF;
		}

		static IntPtr n_GetClosestHighlight_IFF (IntPtr jnienv, IntPtr native__this, int index, float x, float y)
		{
			global::MikePhil.Charting.Highlight.PieHighlighter __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.PieHighlighter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetClosestHighlight (index, x, y));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='PieHighlighter']/method[@name='getClosestHighlight' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
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

	}
}
