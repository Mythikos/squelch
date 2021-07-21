using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Highlight {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='HorizontalBarHighlighter']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/highlight/HorizontalBarHighlighter", DoNotGenerateAcw=true)]
	public partial class HorizontalBarHighlighter : global::MikePhil.Charting.Highlight.BarHighlighter {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/highlight/HorizontalBarHighlighter", typeof (HorizontalBarHighlighter));
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

		protected HorizontalBarHighlighter (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/class[@name='HorizontalBarHighlighter']/constructor[@name='HorizontalBarHighlighter' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.interfaces.dataprovider.BarDataProvider']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/interfaces/dataprovider/BarDataProvider;)V", "")]
		public unsafe HorizontalBarHighlighter (global::MikePhil.Charting.Interfaces.Dataprovider.IBarDataProvider chart)
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

	}
}
