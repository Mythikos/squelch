using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Exception {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.exception']/class[@name='DrawingDataSetNotCreatedException']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/exception/DrawingDataSetNotCreatedException", DoNotGenerateAcw=true)]
	public partial class DrawingDataSetNotCreatedException : global::Java.Lang.RuntimeException {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/exception/DrawingDataSetNotCreatedException", typeof (DrawingDataSetNotCreatedException));

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

		protected DrawingDataSetNotCreatedException (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.exception']/class[@name='DrawingDataSetNotCreatedException']/constructor[@name='DrawingDataSetNotCreatedException' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe DrawingDataSetNotCreatedException () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

	}
}
