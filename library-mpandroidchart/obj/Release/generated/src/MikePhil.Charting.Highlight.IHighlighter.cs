using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Highlight {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/interface[@name='IHighlighter']"
	[Register ("com/github/mikephil/charting/highlight/IHighlighter", "", "MikePhil.Charting.Highlight.IHighlighterInvoker")]
	public partial interface IHighlighter : IJavaObject, IJavaPeerable {
		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.highlight']/interface[@name='IHighlighter']/method[@name='getHighlight' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("getHighlight", "(FF)Lcom/github/mikephil/charting/highlight/Highlight;", "GetGetHighlight_FFHandler:MikePhil.Charting.Highlight.IHighlighterInvoker, library-mpandroidchart")]
		global::MikePhil.Charting.Highlight.Highlight GetHighlight (float p0, float p1);

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/highlight/IHighlighter", DoNotGenerateAcw=true)]
	internal partial class IHighlighterInvoker : global::Java.Lang.Object, IHighlighter {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/highlight/IHighlighter", typeof (IHighlighterInvoker));

		static IntPtr java_class_ref {
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
			get { return class_ref; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IHighlighter GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IHighlighter> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.github.mikephil.charting.highlight.IHighlighter'.");
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IHighlighterInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getHighlight_FF;
#pragma warning disable 0169
		static Delegate GetGetHighlight_FFHandler ()
		{
			if (cb_getHighlight_FF == null)
				cb_getHighlight_FF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFF_L) n_GetHighlight_FF);
			return cb_getHighlight_FF;
		}

		static IntPtr n_GetHighlight_FF (IntPtr jnienv, IntPtr native__this, float p0, float p1)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.IHighlighter> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetHighlight (p0, p1));
		}
#pragma warning restore 0169

		IntPtr id_getHighlight_FF;
		public unsafe global::MikePhil.Charting.Highlight.Highlight GetHighlight (float p0, float p1)
		{
			if (id_getHighlight_FF == IntPtr.Zero)
				id_getHighlight_FF = JNIEnv.GetMethodID (class_ref, "getHighlight", "(FF)Lcom/github/mikephil/charting/highlight/Highlight;");
			JValue* __args = stackalloc JValue [2];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHighlight_FF, __args), JniHandleOwnership.TransferLocalRef);
		}

	}
}
