using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Buffer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='BarBuffer']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/buffer/BarBuffer", DoNotGenerateAcw=true)]
	public partial class BarBuffer : global::MikePhil.Charting.Buffer.AbstractBuffer {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='BarBuffer']/field[@name='mBarWidth']"
		[Register ("mBarWidth")]
		protected float MBarWidth {
			get {
				const string __id = "mBarWidth.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mBarWidth.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='BarBuffer']/field[@name='mContainsStacks']"
		[Register ("mContainsStacks")]
		protected bool MContainsStacks {
			get {
				const string __id = "mContainsStacks.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mContainsStacks.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='BarBuffer']/field[@name='mDataSetCount']"
		[Register ("mDataSetCount")]
		protected int MDataSetCount {
			get {
				const string __id = "mDataSetCount.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mDataSetCount.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='BarBuffer']/field[@name='mDataSetIndex']"
		[Register ("mDataSetIndex")]
		protected int MDataSetIndex {
			get {
				const string __id = "mDataSetIndex.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mDataSetIndex.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='BarBuffer']/field[@name='mInverted']"
		[Register ("mInverted")]
		protected bool MInverted {
			get {
				const string __id = "mInverted.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mInverted.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/buffer/BarBuffer", typeof (BarBuffer));
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

		protected BarBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='BarBuffer']/constructor[@name='BarBuffer' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register (".ctor", "(IIZ)V", "")]
		public unsafe BarBuffer (int size, int dataSetCount, bool containsStacks)
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

		static Delegate cb_addBar_FFFF;
#pragma warning disable 0169
		static Delegate GetAddBar_FFFFHandler ()
		{
			if (cb_addBar_FFFF == null)
				cb_addBar_FFFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float>) n_AddBar_FFFF);
			return cb_addBar_FFFF;
		}

		static void n_AddBar_FFFF (IntPtr jnienv, IntPtr native__this, float left, float top, float right, float bottom)
		{
			global::MikePhil.Charting.Buffer.BarBuffer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Buffer.BarBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.AddBar (left, top, right, bottom);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='BarBuffer']/method[@name='addBar' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("addBar", "(FFFF)V", "GetAddBar_FFFFHandler")]
		protected virtual unsafe void AddBar (float left, float top, float right, float bottom)
		{
			const string __id = "addBar.(FFFF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (top);
				__args [2] = new JniArgumentValue (right);
				__args [3] = new JniArgumentValue (bottom);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_feed_Lcom_github_mikephil_charting_interfaces_datasets_IBarDataSet_;
#pragma warning disable 0169
		static Delegate GetFeed_Lcom_github_mikephil_charting_interfaces_datasets_IBarDataSet_Handler ()
		{
			if (cb_feed_Lcom_github_mikephil_charting_interfaces_datasets_IBarDataSet_ == null)
				cb_feed_Lcom_github_mikephil_charting_interfaces_datasets_IBarDataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Feed_Lcom_github_mikephil_charting_interfaces_datasets_IBarDataSet_);
			return cb_feed_Lcom_github_mikephil_charting_interfaces_datasets_IBarDataSet_;
		}

		static void n_Feed_Lcom_github_mikephil_charting_interfaces_datasets_IBarDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::MikePhil.Charting.Buffer.BarBuffer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Buffer.BarBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Interfaces.Datasets.IBarDataSet data = (global::MikePhil.Charting.Interfaces.Datasets.IBarDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IBarDataSet> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.Feed (data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='BarBuffer']/method[@name='feed' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.interfaces.datasets.IBarDataSet']]"
		[Register ("feed", "(Lcom/github/mikephil/charting/interfaces/datasets/IBarDataSet;)V", "GetFeed_Lcom_github_mikephil_charting_interfaces_datasets_IBarDataSet_Handler")]
		public virtual unsafe void Feed (global::MikePhil.Charting.Interfaces.Datasets.IBarDataSet data)
		{
			const string __id = "feed.(Lcom/github/mikephil/charting/interfaces/datasets/IBarDataSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setBarWidth_F;
#pragma warning disable 0169
		static Delegate GetSetBarWidth_FHandler ()
		{
			if (cb_setBarWidth_F == null)
				cb_setBarWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetBarWidth_F);
			return cb_setBarWidth_F;
		}

		static void n_SetBarWidth_F (IntPtr jnienv, IntPtr native__this, float barWidth)
		{
			global::MikePhil.Charting.Buffer.BarBuffer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Buffer.BarBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetBarWidth (barWidth);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='BarBuffer']/method[@name='setBarWidth' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setBarWidth", "(F)V", "GetSetBarWidth_FHandler")]
		public virtual unsafe void SetBarWidth (float barWidth)
		{
			const string __id = "setBarWidth.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (barWidth);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDataSet_I;
#pragma warning disable 0169
		static Delegate GetSetDataSet_IHandler ()
		{
			if (cb_setDataSet_I == null)
				cb_setDataSet_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetDataSet_I);
			return cb_setDataSet_I;
		}

		static void n_SetDataSet_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::MikePhil.Charting.Buffer.BarBuffer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Buffer.BarBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDataSet (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='BarBuffer']/method[@name='setDataSet' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setDataSet", "(I)V", "GetSetDataSet_IHandler")]
		public virtual unsafe void SetDataSet (int index)
		{
			const string __id = "setDataSet.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setInverted_Z;
#pragma warning disable 0169
		static Delegate GetSetInverted_ZHandler ()
		{
			if (cb_setInverted_Z == null)
				cb_setInverted_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetInverted_Z);
			return cb_setInverted_Z;
		}

		static void n_SetInverted_Z (IntPtr jnienv, IntPtr native__this, bool inverted)
		{
			global::MikePhil.Charting.Buffer.BarBuffer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Buffer.BarBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetInverted (inverted);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='BarBuffer']/method[@name='setInverted' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setInverted", "(Z)V", "GetSetInverted_ZHandler")]
		public virtual unsafe void SetInverted (bool inverted)
		{
			const string __id = "setInverted.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (inverted);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
