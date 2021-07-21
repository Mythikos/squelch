using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Buffer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='HorizontalBarBuffer']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/buffer/HorizontalBarBuffer", DoNotGenerateAcw=true)]
	public partial class HorizontalBarBuffer : global::MikePhil.Charting.Buffer.BarBuffer {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/buffer/HorizontalBarBuffer", typeof (HorizontalBarBuffer));
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

		protected HorizontalBarBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='HorizontalBarBuffer']/constructor[@name='HorizontalBarBuffer' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(IIZ)V", "")]
		public unsafe HorizontalBarBuffer (int size, int dataSetCount, bool containsStacks)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(IIZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (size);
				__args [1] = new JniArgumentValue (dataSetCount);
				__args [2] = new JniArgumentValue (containsStacks);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

	}
}
