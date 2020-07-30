using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Renderer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='XAxisRendererRadarChart']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/renderer/XAxisRendererRadarChart", DoNotGenerateAcw=true)]
	public partial class XAxisRendererRadarChart : global::MikePhil.Charting.Renderer.XAxisRenderer {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/renderer/XAxisRendererRadarChart", typeof (XAxisRendererRadarChart));
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

		protected XAxisRendererRadarChart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.renderer']/class[@name='XAxisRendererRadarChart']/constructor[@name='XAxisRendererRadarChart' and count(parameter)=3 and parameter[1][@type='com.github.mikephil.charting.utils.ViewPortHandler'] and parameter[2][@type='com.github.mikephil.charting.components.XAxis'] and parameter[3][@type='com.github.mikephil.charting.charts.RadarChart']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/utils/ViewPortHandler;Lcom/github/mikephil/charting/components/XAxis;Lcom/github/mikephil/charting/charts/RadarChart;)V", "")]
		public unsafe XAxisRendererRadarChart (global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler, global::MikePhil.Charting.Components.XAxis xAxis, global::MikePhil.Charting.Charts.RadarChart chart)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/utils/ViewPortHandler;Lcom/github/mikephil/charting/components/XAxis;Lcom/github/mikephil/charting/charts/RadarChart;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((viewPortHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPortHandler).Handle);
				__args [1] = new JniArgumentValue ((xAxis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) xAxis).Handle);
				__args [2] = new JniArgumentValue ((chart == null) ? IntPtr.Zero : ((global::Java.Lang.Object) chart).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
