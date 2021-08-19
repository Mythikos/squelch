using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Highlight {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='PieRadarHighlighter']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/highlight/PieRadarHighlighter", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.github.mikephil.charting.charts.PieRadarChartBase"})]
	public abstract partial class PieRadarHighlighter : global::Java.Lang.Object, global::MikePhil.Charting.Highlight.IHighlighter {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='PieRadarHighlighter']/field[@name='mChart']"
		[Register ("mChart")]
		protected global::MikePhil.Charting.Charts.PieRadarChartBase MChart {
			get {
				const string __id = "mChart.Lcom/github/mikephil/charting/charts/PieRadarChartBase;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieRadarChartBase> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mChart.Lcom/github/mikephil/charting/charts/PieRadarChartBase;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='PieRadarHighlighter']/field[@name='mHighlightBuffer']"
		[Register ("mHighlightBuffer")]
		protected global::System.Collections.IList MHighlightBuffer {
			get {
				const string __id = "mHighlightBuffer.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mHighlightBuffer.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/highlight/PieRadarHighlighter", typeof (PieRadarHighlighter));

		internal static IntPtr class_ref {
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

		protected PieRadarHighlighter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='PieRadarHighlighter']/constructor[@name='PieRadarHighlighter' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/charts/PieRadarChartBase;)V", "")]
		public unsafe PieRadarHighlighter (global::Java.Lang.Object chart) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/charts/PieRadarChartBase;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_chart = JNIEnv.ToLocalJniHandle (chart);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_chart);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_chart);
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

		static IntPtr n_GetClosestHighlight_IFF (IntPtr jnienv, IntPtr native__this, int p0, float p1, float p2)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.PieRadarHighlighter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetClosestHighlight (p0, p1, p2));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='PieRadarHighlighter']/method[@name='getClosestHighlight' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("getClosestHighlight", "(IFF)Lcom/github/mikephil/charting/highlight/Highlight;", "GetGetClosestHighlight_IFFHandler")]
		protected abstract global::MikePhil.Charting.Highlight.Highlight GetClosestHighlight (int p0, float p1, float p2);

		static Delegate cb_getHighlight_FF;
#pragma warning disable 0169
		static Delegate GetGetHighlight_FFHandler ()
		{
			if (cb_getHighlight_FF == null)
				cb_getHighlight_FF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFF_L) n_GetHighlight_FF);
			return cb_getHighlight_FF;
		}

		static IntPtr n_GetHighlight_FF (IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.PieRadarHighlighter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetHighlight (x, y));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='PieRadarHighlighter']/method[@name='getHighlight' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("getHighlight", "(FF)Lcom/github/mikephil/charting/highlight/Highlight;", "GetGetHighlight_FFHandler")]
		public virtual unsafe global::MikePhil.Charting.Highlight.Highlight GetHighlight (float x, float y)
		{
			const string __id = "getHighlight.(FF)Lcom/github/mikephil/charting/highlight/Highlight;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/highlight/PieRadarHighlighter", DoNotGenerateAcw=true)]
	internal partial class PieRadarHighlighterInvoker : PieRadarHighlighter {
		public PieRadarHighlighterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/highlight/PieRadarHighlighter", typeof (PieRadarHighlighterInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='PieRadarHighlighter']/method[@name='getClosestHighlight' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("getClosestHighlight", "(IFF)Lcom/github/mikephil/charting/highlight/Highlight;", "GetGetClosestHighlight_IFFHandler")]
		protected override unsafe global::MikePhil.Charting.Highlight.Highlight GetClosestHighlight (int p0, float p1, float p2)
		{
			const string __id = "getClosestHighlight.(IFF)Lcom/github/mikephil/charting/highlight/Highlight;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (p0);
				__args [1] = new JniArgumentValue (p1);
				__args [2] = new JniArgumentValue (p2);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
