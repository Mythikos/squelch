using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='EntryXComparator']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/utils/EntryXComparator", DoNotGenerateAcw=true)]
	public partial class EntryXComparator : global::Java.Lang.Object, global::Java.Util.IComparator {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/utils/EntryXComparator", typeof (EntryXComparator));
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

		protected EntryXComparator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='EntryXComparator']/constructor[@name='EntryXComparator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EntryXComparator ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_compare_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_data_Entry_;
#pragma warning disable 0169
		static Delegate GetCompare_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_data_Entry_Handler ()
		{
			if (cb_compare_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_data_Entry_ == null)
				cb_compare_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_data_Entry_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, int>) n_Compare_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_data_Entry_);
			return cb_compare_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_data_Entry_;
		}

		static int n_Compare_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_data_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_entry1, IntPtr native_entry2)
		{
			global::MikePhil.Charting.Util.EntryXComparator __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.EntryXComparator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.Entry entry1 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.Entry> (native_entry1, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.Entry entry2 = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.Entry> (native_entry2, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Compare (entry1, entry2);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='EntryXComparator']/method[@name='compare' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.data.Entry'] and parameter[2][@type='com.github.mikephil.charting.data.Entry']]"
		[Register ("compare", "(Lcom/github/mikephil/charting/data/Entry;Lcom/github/mikephil/charting/data/Entry;)I", "GetCompare_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_data_Entry_Handler")]
		public virtual unsafe int Compare (global::MikePhil.Charting.Data.Entry entry1, global::MikePhil.Charting.Data.Entry entry2)
		{
			const string __id = "compare.(Lcom/github/mikephil/charting/data/Entry;Lcom/github/mikephil/charting/data/Entry;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((entry1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) entry1).Handle);
				__args [1] = new JniArgumentValue ((entry2 == null) ? IntPtr.Zero : ((global::Java.Lang.Object) entry2).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

	}
}
