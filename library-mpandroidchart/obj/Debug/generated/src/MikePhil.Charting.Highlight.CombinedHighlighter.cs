using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Highlight {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='CombinedHighlighter']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/highlight/CombinedHighlighter", DoNotGenerateAcw=true)]
	public partial class CombinedHighlighter : global::MikePhil.Charting.Highlight.ChartHighlighter, global::MikePhil.Charting.Highlight.IHighlighter {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='CombinedHighlighter']/field[@name='barHighlighter']"
		[Register ("barHighlighter")]
		protected global::MikePhil.Charting.Highlight.BarHighlighter BarHighlighter {
			get {
				const string __id = "barHighlighter.Lcom/github/mikephil/charting/highlight/BarHighlighter;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.BarHighlighter> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "barHighlighter.Lcom/github/mikephil/charting/highlight/BarHighlighter;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/highlight/CombinedHighlighter", typeof (CombinedHighlighter));

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

		protected CombinedHighlighter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='CombinedHighlighter']/constructor[@name='CombinedHighlighter' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.interfaces.dataprovider.CombinedDataProvider'] and parameter[2][@type='com.github.mikephil.charting.interfaces.dataprovider.BarDataProvider']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/interfaces/dataprovider/CombinedDataProvider;Lcom/github/mikephil/charting/interfaces/dataprovider/BarDataProvider;)V", "")]
		public unsafe CombinedHighlighter (global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider chart, global::MikePhil.Charting.Interfaces.Dataprovider.IBarDataProvider barChart) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/interfaces/dataprovider/CombinedDataProvider;Lcom/github/mikephil/charting/interfaces/dataprovider/BarDataProvider;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((chart == null) ? IntPtr.Zero : ((global::Java.Lang.Object) chart).Handle);
				__args [1] = new JniArgumentValue ((barChart == null) ? IntPtr.Zero : ((global::Java.Lang.Object) barChart).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (chart);
				global::System.GC.KeepAlive (barChart);
			}
		}

	}
}
