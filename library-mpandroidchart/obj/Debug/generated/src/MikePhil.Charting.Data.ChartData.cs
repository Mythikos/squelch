using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/ChartData", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.github.mikephil.charting.interfaces.datasets.IDataSet<? extends com.github.mikephil.charting.data.Entry>"})]
	public abstract partial class ChartData : global::Java.Lang.Object {

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/field[@name='mDataSets']"
		[Register ("mDataSets")]
		protected global::System.Collections.IList MDataSets {
			get {
				const string __id = "mDataSets.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDataSets.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/field[@name='mLeftAxisMax']"
		[Register ("mLeftAxisMax")]
		protected float MLeftAxisMax {
			get {
				const string __id = "mLeftAxisMax.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mLeftAxisMax.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/field[@name='mLeftAxisMin']"
		[Register ("mLeftAxisMin")]
		protected float MLeftAxisMin {
			get {
				const string __id = "mLeftAxisMin.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mLeftAxisMin.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/field[@name='mRightAxisMax']"
		[Register ("mRightAxisMax")]
		protected float MRightAxisMax {
			get {
				const string __id = "mRightAxisMax.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mRightAxisMax.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/field[@name='mRightAxisMin']"
		[Register ("mRightAxisMin")]
		protected float MRightAxisMin {
			get {
				const string __id = "mRightAxisMin.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mRightAxisMin.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/field[@name='mXMax']"
		[Register ("mXMax")]
		protected float MXMax {
			get {
				const string __id = "mXMax.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mXMax.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/field[@name='mXMin']"
		[Register ("mXMin")]
		protected float MXMin {
			get {
				const string __id = "mXMin.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mXMin.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/field[@name='mYMax']"
		[Register ("mYMax")]
		protected float MYMax {
			get {
				const string __id = "mYMax.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mYMax.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/field[@name='mYMin']"
		[Register ("mYMin")]
		protected float MYMin {
			get {
				const string __id = "mYMin.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mYMin.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/ChartData", typeof (ChartData));

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

		protected ChartData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/constructor[@name='ChartData' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ChartData () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/constructor[@name='ChartData' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;T&gt;']]"
		[Register (".ctor", "(Ljava/util/List;)V", "")]
		public unsafe ChartData (global::System.Collections.IList sets) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_sets = global::Android.Runtime.JavaList.ToLocalJniHandle (sets);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sets);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_sets);
				global::System.GC.KeepAlive (sets);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/constructor[@name='ChartData' and count(parameter)=1 and parameter[1][@type='T...']]"
		[Register (".ctor", "([Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;)V", "")]
		public unsafe ChartData (params global::Java.Lang.Object[] dataSets) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_dataSets = JNIEnv.NewArray (dataSets);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_dataSets);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (dataSets != null) {
					JNIEnv.CopyArray (native_dataSets, dataSets);
					JNIEnv.DeleteLocalRef (native_dataSets);
				}
				global::System.GC.KeepAlive (dataSets);
			}
		}

		static Delegate cb_getDataSetCount;
#pragma warning disable 0169
		static Delegate GetGetDataSetCountHandler ()
		{
			if (cb_getDataSetCount == null)
				cb_getDataSetCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetDataSetCount);
			return cb_getDataSetCount;
		}

		static int n_GetDataSetCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DataSetCount;
		}
#pragma warning restore 0169

		public virtual unsafe int DataSetCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='getDataSetCount' and count(parameter)=0]"
			[Register ("getDataSetCount", "()I", "GetGetDataSetCountHandler")]
			get {
				const string __id = "getDataSetCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getDataSets;
#pragma warning disable 0169
		static Delegate GetGetDataSetsHandler ()
		{
			if (cb_getDataSets == null)
				cb_getDataSets = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDataSets);
			return cb_getDataSets;
		}

		static IntPtr n_GetDataSets (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.DataSets);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.IList DataSets {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='getDataSets' and count(parameter)=0]"
			[Register ("getDataSets", "()Ljava/util/List;", "GetGetDataSetsHandler")]
			get {
				const string __id = "getDataSets.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEntryCount;
#pragma warning disable 0169
		static Delegate GetGetEntryCountHandler ()
		{
			if (cb_getEntryCount == null)
				cb_getEntryCount = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetEntryCount);
			return cb_getEntryCount;
		}

		static int n_GetEntryCount (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EntryCount;
		}
#pragma warning restore 0169

		public virtual unsafe int EntryCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='getEntryCount' and count(parameter)=0]"
			[Register ("getEntryCount", "()I", "GetGetEntryCountHandler")]
			get {
				const string __id = "getEntryCount.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isHighlightEnabled;
#pragma warning disable 0169
		static Delegate GetIsHighlightEnabledHandler ()
		{
			if (cb_isHighlightEnabled == null)
				cb_isHighlightEnabled = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_Z) n_IsHighlightEnabled);
			return cb_isHighlightEnabled;
		}

		static bool n_IsHighlightEnabled (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HighlightEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setHighlightEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetHighlightEnabled_ZHandler ()
		{
			if (cb_setHighlightEnabled_Z == null)
				cb_setHighlightEnabled_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetHighlightEnabled_Z);
			return cb_setHighlightEnabled_Z;
		}

		static void n_SetHighlightEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HighlightEnabled = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool HighlightEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='isHighlightEnabled' and count(parameter)=0]"
			[Register ("isHighlightEnabled", "()Z", "GetIsHighlightEnabledHandler")]
			get {
				const string __id = "isHighlightEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='setHighlightEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setHighlightEnabled", "(Z)V", "GetSetHighlightEnabled_ZHandler")]
			set {
				const string __id = "setHighlightEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getMaxEntryCountSet;
#pragma warning disable 0169
		static Delegate GetGetMaxEntryCountSetHandler ()
		{
			if (cb_getMaxEntryCountSet == null)
				cb_getMaxEntryCountSet = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetMaxEntryCountSet);
			return cb_getMaxEntryCountSet;
		}

		static IntPtr n_GetMaxEntryCountSet (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.MaxEntryCountSet);
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.Object MaxEntryCountSet {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='getMaxEntryCountSet' and count(parameter)=0]"
			[Register ("getMaxEntryCountSet", "()Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;", "GetGetMaxEntryCountSetHandler")]
			get {
				const string __id = "getMaxEntryCountSet.()Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getXMax;
#pragma warning disable 0169
		static Delegate GetGetXMaxHandler ()
		{
			if (cb_getXMax == null)
				cb_getXMax = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetXMax);
			return cb_getXMax;
		}

		static float n_GetXMax (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XMax;
		}
#pragma warning restore 0169

		public virtual unsafe float XMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='getXMax' and count(parameter)=0]"
			[Register ("getXMax", "()F", "GetGetXMaxHandler")]
			get {
				const string __id = "getXMax.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getXMin;
#pragma warning disable 0169
		static Delegate GetGetXMinHandler ()
		{
			if (cb_getXMin == null)
				cb_getXMin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetXMin);
			return cb_getXMin;
		}

		static float n_GetXMin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XMin;
		}
#pragma warning restore 0169

		public virtual unsafe float XMin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='getXMin' and count(parameter)=0]"
			[Register ("getXMin", "()F", "GetGetXMinHandler")]
			get {
				const string __id = "getXMin.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getYMax;
#pragma warning disable 0169
		static Delegate GetGetYMaxHandler ()
		{
			if (cb_getYMax == null)
				cb_getYMax = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetYMax);
			return cb_getYMax;
		}

		static float n_GetYMax (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YMax;
		}
#pragma warning restore 0169

		public virtual unsafe float YMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='getYMax' and count(parameter)=0]"
			[Register ("getYMax", "()F", "GetGetYMaxHandler")]
			get {
				const string __id = "getYMax.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getYMin;
#pragma warning disable 0169
		static Delegate GetGetYMinHandler ()
		{
			if (cb_getYMin == null)
				cb_getYMin = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_F) n_GetYMin);
			return cb_getYMin;
		}

		static float n_GetYMin (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YMin;
		}
#pragma warning restore 0169

		public virtual unsafe float YMin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='getYMin' and count(parameter)=0]"
			[Register ("getYMin", "()F", "GetGetYMinHandler")]
			get {
				const string __id = "getYMin.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_addDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_;
#pragma warning disable 0169
		static Delegate GetAddDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_Handler ()
		{
			if (cb_addDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ == null)
				cb_addDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_AddDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_);
			return cb_addDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_;
		}

		static void n_AddDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_d)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var d = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_d, JniHandleOwnership.DoNotTransfer);
			__this.AddDataSet (d);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='addDataSet' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("addDataSet", "(Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;)V", "GetAddDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_Handler")]
		public virtual unsafe void AddDataSet (global::Java.Lang.Object d)
		{
			const string __id = "addDataSet.(Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;)V";
			IntPtr native_d = JNIEnv.ToLocalJniHandle (d);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_d);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_d);
				global::System.GC.KeepAlive (d);
			}
		}

		static Delegate cb_addEntry_Lcom_github_mikephil_charting_data_Entry_I;
#pragma warning disable 0169
		static Delegate GetAddEntry_Lcom_github_mikephil_charting_data_Entry_IHandler ()
		{
			if (cb_addEntry_Lcom_github_mikephil_charting_data_Entry_I == null)
				cb_addEntry_Lcom_github_mikephil_charting_data_Entry_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_V) n_AddEntry_Lcom_github_mikephil_charting_data_Entry_I);
			return cb_addEntry_Lcom_github_mikephil_charting_data_Entry_I;
		}

		static void n_AddEntry_Lcom_github_mikephil_charting_data_Entry_I (IntPtr jnienv, IntPtr native__this, IntPtr native_e, int dataSetIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.Entry> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.AddEntry (e, dataSetIndex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='addEntry' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.data.Entry'] and parameter[2][@type='int']]"
		[Register ("addEntry", "(Lcom/github/mikephil/charting/data/Entry;I)V", "GetAddEntry_Lcom_github_mikephil_charting_data_Entry_IHandler")]
		public virtual unsafe void AddEntry (global::MikePhil.Charting.Data.Entry e, int dataSetIndex)
		{
			const string __id = "addEntry.(Lcom/github/mikephil/charting/data/Entry;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				__args [1] = new JniArgumentValue (dataSetIndex);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (e);
			}
		}

		static Delegate cb_calcMinMax;
#pragma warning disable 0169
		static Delegate GetCalcMinMaxHandler ()
		{
			if (cb_calcMinMax == null)
				cb_calcMinMax = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_CalcMinMax);
			return cb_calcMinMax;
		}

		static void n_CalcMinMax (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalcMinMax ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='calcMinMax' and count(parameter)=0]"
		[Register ("calcMinMax", "()V", "GetCalcMinMaxHandler")]
		protected virtual unsafe void CalcMinMax ()
		{
			const string __id = "calcMinMax.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_calcMinMax_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
#pragma warning disable 0169
		static Delegate GetCalcMinMax_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler ()
		{
			if (cb_calcMinMax_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ == null)
				cb_calcMinMax_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_CalcMinMax_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_calcMinMax_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static void n_CalcMinMax_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e, IntPtr native_axis)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.Entry> (native_e, JniHandleOwnership.DoNotTransfer);
			var axis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_axis, JniHandleOwnership.DoNotTransfer);
			__this.CalcMinMax (e, axis);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='calcMinMax' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.data.Entry'] and parameter[2][@type='com.github.mikephil.charting.components.YAxis.AxisDependency']]"
		[Register ("calcMinMax", "(Lcom/github/mikephil/charting/data/Entry;Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)V", "GetCalcMinMax_Lcom_github_mikephil_charting_data_Entry_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler")]
		protected virtual unsafe void CalcMinMax (global::MikePhil.Charting.Data.Entry e, global::MikePhil.Charting.Components.YAxis.AxisDependency axis)
		{
			const string __id = "calcMinMax.(Lcom/github/mikephil/charting/data/Entry;Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				__args [1] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (e);
				global::System.GC.KeepAlive (axis);
			}
		}

		static Delegate cb_calcMinMax_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_;
#pragma warning disable 0169
		static Delegate GetCalcMinMax_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_Handler ()
		{
			if (cb_calcMinMax_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ == null)
				cb_calcMinMax_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_CalcMinMax_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_);
			return cb_calcMinMax_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_;
		}

		static void n_CalcMinMax_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_d)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var d = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_d, JniHandleOwnership.DoNotTransfer);
			__this.CalcMinMax (d);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='calcMinMax' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("calcMinMax", "(Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;)V", "GetCalcMinMax_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_Handler")]
		protected virtual unsafe void CalcMinMax (global::Java.Lang.Object d)
		{
			const string __id = "calcMinMax.(Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;)V";
			IntPtr native_d = JNIEnv.ToLocalJniHandle (d);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_d);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_d);
				global::System.GC.KeepAlive (d);
			}
		}

		static Delegate cb_calcMinMaxY_FF;
#pragma warning disable 0169
		static Delegate GetCalcMinMaxY_FFHandler ()
		{
			if (cb_calcMinMaxY_FF == null)
				cb_calcMinMaxY_FF = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFF_V) n_CalcMinMaxY_FF);
			return cb_calcMinMaxY_FF;
		}

		static void n_CalcMinMaxY_FF (IntPtr jnienv, IntPtr native__this, float fromX, float toX)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalcMinMaxY (fromX, toX);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='calcMinMaxY' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("calcMinMaxY", "(FF)V", "GetCalcMinMaxY_FFHandler")]
		public virtual unsafe void CalcMinMaxY (float fromX, float toX)
		{
			const string __id = "calcMinMaxY.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (fromX);
				__args [1] = new JniArgumentValue (toX);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_clearValues;
#pragma warning disable 0169
		static Delegate GetClearValuesHandler ()
		{
			if (cb_clearValues == null)
				cb_clearValues = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_ClearValues);
			return cb_clearValues;
		}

		static void n_ClearValues (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearValues ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='clearValues' and count(parameter)=0]"
		[Register ("clearValues", "()V", "GetClearValuesHandler")]
		public virtual unsafe void ClearValues ()
		{
			const string __id = "clearValues.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_contains_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_;
#pragma warning disable 0169
		static Delegate GetContains_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_Handler ()
		{
			if (cb_contains_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ == null)
				cb_contains_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Contains_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_);
			return cb_contains_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_;
		}

		static bool n_Contains_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dataSet)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dataSet = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_dataSet, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Contains (dataSet);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='contains' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("contains", "(Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;)Z", "GetContains_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_Handler")]
		public virtual unsafe bool Contains (global::Java.Lang.Object dataSet)
		{
			const string __id = "contains.(Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;)Z";
			IntPtr native_dataSet = JNIEnv.ToLocalJniHandle (dataSet);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_dataSet);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_dataSet);
				global::System.GC.KeepAlive (dataSet);
			}
		}

		static Delegate cb_getColors;
#pragma warning disable 0169
		static Delegate GetGetColorsHandler ()
		{
			if (cb_getColors == null)
				cb_getColors = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetColors);
			return cb_getColors;
		}

		static IntPtr n_GetColors (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetColors ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='getColors' and count(parameter)=0]"
		[Register ("getColors", "()[I", "GetGetColorsHandler")]
		public virtual unsafe int[] GetColors ()
		{
			const string __id = "getColors.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getDataSetByIndex_I;
#pragma warning disable 0169
		static Delegate GetGetDataSetByIndex_IHandler ()
		{
			if (cb_getDataSetByIndex_I == null)
				cb_getDataSetByIndex_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_L) n_GetDataSetByIndex_I);
			return cb_getDataSetByIndex_I;
		}

		static IntPtr n_GetDataSetByIndex_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetDataSetByIndex (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='getDataSetByIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDataSetByIndex", "(I)Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;", "GetGetDataSetByIndex_IHandler")]
		public virtual unsafe global::Java.Lang.Object GetDataSetByIndex (int index)
		{
			const string __id = "getDataSetByIndex.(I)Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getDataSetByLabel_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetDataSetByLabel_Ljava_lang_String_ZHandler ()
		{
			if (cb_getDataSetByLabel_Ljava_lang_String_Z == null)
				cb_getDataSetByLabel_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLZ_L) n_GetDataSetByLabel_Ljava_lang_String_Z);
			return cb_getDataSetByLabel_Ljava_lang_String_Z;
		}

		static IntPtr n_GetDataSetByLabel_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_label, bool ignorecase)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var label = JNIEnv.GetString (native_label, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDataSetByLabel (label, ignorecase));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='getDataSetByLabel' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='boolean']]"
		[Register ("getDataSetByLabel", "(Ljava/lang/String;Z)Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;", "GetGetDataSetByLabel_Ljava_lang_String_ZHandler")]
		public virtual unsafe global::Java.Lang.Object GetDataSetByLabel (string label, bool ignorecase)
		{
			const string __id = "getDataSetByLabel.(Ljava/lang/String;Z)Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;";
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_label);
				__args [1] = new JniArgumentValue (ignorecase);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_label);
			}
		}

		static Delegate cb_getDataSetForEntry_Lcom_github_mikephil_charting_data_Entry_;
#pragma warning disable 0169
		static Delegate GetGetDataSetForEntry_Lcom_github_mikephil_charting_data_Entry_Handler ()
		{
			if (cb_getDataSetForEntry_Lcom_github_mikephil_charting_data_Entry_ == null)
				cb_getDataSetForEntry_Lcom_github_mikephil_charting_data_Entry_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetDataSetForEntry_Lcom_github_mikephil_charting_data_Entry_);
			return cb_getDataSetForEntry_Lcom_github_mikephil_charting_data_Entry_;
		}

		static IntPtr n_GetDataSetForEntry_Lcom_github_mikephil_charting_data_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.Entry> (native_e, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetDataSetForEntry (e));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='getDataSetForEntry' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.Entry']]"
		[Register ("getDataSetForEntry", "(Lcom/github/mikephil/charting/data/Entry;)Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;", "GetGetDataSetForEntry_Lcom_github_mikephil_charting_data_Entry_Handler")]
		public virtual unsafe global::Java.Lang.Object GetDataSetForEntry (global::MikePhil.Charting.Data.Entry e)
		{
			const string __id = "getDataSetForEntry.(Lcom/github/mikephil/charting/data/Entry;)Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (e);
			}
		}

		static Delegate cb_getDataSetIndexByLabel_Ljava_util_List_Ljava_lang_String_Z;
#pragma warning disable 0169
		static Delegate GetGetDataSetIndexByLabel_Ljava_util_List_Ljava_lang_String_ZHandler ()
		{
			if (cb_getDataSetIndexByLabel_Ljava_util_List_Ljava_lang_String_Z == null)
				cb_getDataSetIndexByLabel_Ljava_util_List_Ljava_lang_String_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLLZ_I) n_GetDataSetIndexByLabel_Ljava_util_List_Ljava_lang_String_Z);
			return cb_getDataSetIndexByLabel_Ljava_util_List_Ljava_lang_String_Z;
		}

		static int n_GetDataSetIndexByLabel_Ljava_util_List_Ljava_lang_String_Z (IntPtr jnienv, IntPtr native__this, IntPtr native_dataSets, IntPtr native_label, bool ignorecase)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dataSets = global::Android.Runtime.JavaList.FromJniHandle (native_dataSets, JniHandleOwnership.DoNotTransfer);
			var label = JNIEnv.GetString (native_label, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetDataSetIndexByLabel (dataSets, label, ignorecase);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='getDataSetIndexByLabel' and count(parameter)=3 and parameter[1][@type='java.util.List&lt;T&gt;'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='boolean']]"
		[Register ("getDataSetIndexByLabel", "(Ljava/util/List;Ljava/lang/String;Z)I", "GetGetDataSetIndexByLabel_Ljava_util_List_Ljava_lang_String_ZHandler")]
		protected virtual unsafe int GetDataSetIndexByLabel (global::System.Collections.IList dataSets, string label, bool ignorecase)
		{
			const string __id = "getDataSetIndexByLabel.(Ljava/util/List;Ljava/lang/String;Z)I";
			IntPtr native_dataSets = global::Android.Runtime.JavaList.ToLocalJniHandle (dataSets);
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_dataSets);
				__args [1] = new JniArgumentValue (native_label);
				__args [2] = new JniArgumentValue (ignorecase);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_dataSets);
				JNIEnv.DeleteLocalRef (native_label);
				global::System.GC.KeepAlive (dataSets);
			}
		}

		static Delegate cb_getDataSetLabels;
#pragma warning disable 0169
		static Delegate GetGetDataSetLabelsHandler ()
		{
			if (cb_getDataSetLabels == null)
				cb_getDataSetLabels = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_GetDataSetLabels);
			return cb_getDataSetLabels;
		}

		static IntPtr n_GetDataSetLabels (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDataSetLabels ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='getDataSetLabels' and count(parameter)=0]"
		[Register ("getDataSetLabels", "()[Ljava/lang/String;", "GetGetDataSetLabelsHandler")]
		public virtual unsafe string[] GetDataSetLabels ()
		{
			const string __id = "getDataSetLabels.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_getEntryForHighlight_Lcom_github_mikephil_charting_highlight_Highlight_;
#pragma warning disable 0169
		static Delegate GetGetEntryForHighlight_Lcom_github_mikephil_charting_highlight_Highlight_Handler ()
		{
			if (cb_getEntryForHighlight_Lcom_github_mikephil_charting_highlight_Highlight_ == null)
				cb_getEntryForHighlight_Lcom_github_mikephil_charting_highlight_Highlight_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetEntryForHighlight_Lcom_github_mikephil_charting_highlight_Highlight_);
			return cb_getEntryForHighlight_Lcom_github_mikephil_charting_highlight_Highlight_;
		}

		static IntPtr n_GetEntryForHighlight_Lcom_github_mikephil_charting_highlight_Highlight_ (IntPtr jnienv, IntPtr native__this, IntPtr native_highlight)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var highlight = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Highlight.Highlight> (native_highlight, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetEntryForHighlight (highlight));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='getEntryForHighlight' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.highlight.Highlight']]"
		[Register ("getEntryForHighlight", "(Lcom/github/mikephil/charting/highlight/Highlight;)Lcom/github/mikephil/charting/data/Entry;", "GetGetEntryForHighlight_Lcom_github_mikephil_charting_highlight_Highlight_Handler")]
		public virtual unsafe global::MikePhil.Charting.Data.Entry GetEntryForHighlight (global::MikePhil.Charting.Highlight.Highlight highlight)
		{
			const string __id = "getEntryForHighlight.(Lcom/github/mikephil/charting/highlight/Highlight;)Lcom/github/mikephil/charting/data/Entry;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((highlight == null) ? IntPtr.Zero : ((global::Java.Lang.Object) highlight).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.Entry> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (highlight);
			}
		}

		static Delegate cb_getFirstLeft_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetFirstLeft_Ljava_util_List_Handler ()
		{
			if (cb_getFirstLeft_Ljava_util_List_ == null)
				cb_getFirstLeft_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetFirstLeft_Ljava_util_List_);
			return cb_getFirstLeft_Ljava_util_List_;
		}

		static IntPtr n_GetFirstLeft_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sets)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var sets = global::Android.Runtime.JavaList.FromJniHandle (native_sets, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetFirstLeft (sets));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='getFirstLeft' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;T&gt;']]"
		[Register ("getFirstLeft", "(Ljava/util/List;)Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;", "GetGetFirstLeft_Ljava_util_List_Handler")]
		protected virtual unsafe global::Java.Lang.Object GetFirstLeft (global::System.Collections.IList sets)
		{
			const string __id = "getFirstLeft.(Ljava/util/List;)Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;";
			IntPtr native_sets = global::Android.Runtime.JavaList.ToLocalJniHandle (sets);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sets);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_sets);
				global::System.GC.KeepAlive (sets);
			}
		}

		static Delegate cb_getFirstRight_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetGetFirstRight_Ljava_util_List_Handler ()
		{
			if (cb_getFirstRight_Ljava_util_List_ == null)
				cb_getFirstRight_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_GetFirstRight_Ljava_util_List_);
			return cb_getFirstRight_Ljava_util_List_;
		}

		static IntPtr n_GetFirstRight_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_sets)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var sets = global::Android.Runtime.JavaList.FromJniHandle (native_sets, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetFirstRight (sets));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='getFirstRight' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;T&gt;']]"
		[Register ("getFirstRight", "(Ljava/util/List;)Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;", "GetGetFirstRight_Ljava_util_List_Handler")]
		public virtual unsafe global::Java.Lang.Object GetFirstRight (global::System.Collections.IList sets)
		{
			const string __id = "getFirstRight.(Ljava/util/List;)Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;";
			IntPtr native_sets = global::Android.Runtime.JavaList.ToLocalJniHandle (sets);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_sets);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (global::Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_sets);
				global::System.GC.KeepAlive (sets);
			}
		}

		static Delegate cb_getIndexOfDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_;
#pragma warning disable 0169
		static Delegate GetGetIndexOfDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_Handler ()
		{
			if (cb_getIndexOfDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ == null)
				cb_getIndexOfDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_I) n_GetIndexOfDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_);
			return cb_getIndexOfDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_;
		}

		static int n_GetIndexOfDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dataSet)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var dataSet = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_dataSet, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetIndexOfDataSet (dataSet);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='getIndexOfDataSet' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("getIndexOfDataSet", "(Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;)I", "GetGetIndexOfDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_Handler")]
		public virtual unsafe int GetIndexOfDataSet (global::Java.Lang.Object dataSet)
		{
			const string __id = "getIndexOfDataSet.(Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;)I";
			IntPtr native_dataSet = JNIEnv.ToLocalJniHandle (dataSet);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_dataSet);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_dataSet);
				global::System.GC.KeepAlive (dataSet);
			}
		}

		static Delegate cb_getYMax_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
#pragma warning disable 0169
		static Delegate GetGetYMax_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler ()
		{
			if (cb_getYMax_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ == null)
				cb_getYMax_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_F) n_GetYMax_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_getYMax_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static float n_GetYMax_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, IntPtr native_axis)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var axis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_axis, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetYMax (axis);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='getYMax' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.YAxis.AxisDependency']]"
		[Register ("getYMax", "(Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)F", "GetGetYMax_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler")]
		public virtual unsafe float GetYMax (global::MikePhil.Charting.Components.YAxis.AxisDependency axis)
		{
			const string __id = "getYMax.(Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (axis);
			}
		}

		static Delegate cb_getYMin_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
#pragma warning disable 0169
		static Delegate GetGetYMin_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler ()
		{
			if (cb_getYMin_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ == null)
				cb_getYMin_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_F) n_GetYMin_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_);
			return cb_getYMin_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_;
		}

		static float n_GetYMin_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_ (IntPtr jnienv, IntPtr native__this, IntPtr native_axis)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var axis = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.YAxis.AxisDependency> (native_axis, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetYMin (axis);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='getYMin' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.YAxis.AxisDependency']]"
		[Register ("getYMin", "(Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)F", "GetGetYMin_Lcom_github_mikephil_charting_components_YAxis_AxisDependency_Handler")]
		public virtual unsafe float GetYMin (global::MikePhil.Charting.Components.YAxis.AxisDependency axis)
		{
			const string __id = "getYMin.(Lcom/github/mikephil/charting/components/YAxis$AxisDependency;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((axis == null) ? IntPtr.Zero : ((global::Java.Lang.Object) axis).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (axis);
			}
		}

		static Delegate cb_notifyDataChanged;
#pragma warning disable 0169
		static Delegate GetNotifyDataChangedHandler ()
		{
			if (cb_notifyDataChanged == null)
				cb_notifyDataChanged = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_NotifyDataChanged);
			return cb_notifyDataChanged;
		}

		static void n_NotifyDataChanged (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.NotifyDataChanged ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='notifyDataChanged' and count(parameter)=0]"
		[Register ("notifyDataChanged", "()V", "GetNotifyDataChangedHandler")]
		public virtual unsafe void NotifyDataChanged ()
		{
			const string __id = "notifyDataChanged.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_removeDataSet_I;
#pragma warning disable 0169
		static Delegate GetRemoveDataSet_IHandler ()
		{
			if (cb_removeDataSet_I == null)
				cb_removeDataSet_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_Z) n_RemoveDataSet_I);
			return cb_removeDataSet_I;
		}

		static bool n_RemoveDataSet_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemoveDataSet (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='removeDataSet' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("removeDataSet", "(I)Z", "GetRemoveDataSet_IHandler")]
		public virtual unsafe bool RemoveDataSet (int index)
		{
			const string __id = "removeDataSet.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_removeDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_;
#pragma warning disable 0169
		static Delegate GetRemoveDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_Handler ()
		{
			if (cb_removeDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ == null)
				cb_removeDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_RemoveDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_);
			return cb_removeDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_;
		}

		static bool n_RemoveDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_d)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var d = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_d, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveDataSet (d);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='removeDataSet' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("removeDataSet", "(Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;)Z", "GetRemoveDataSet_Lcom_github_mikephil_charting_interfaces_datasets_IDataSet_Handler")]
		public virtual unsafe bool RemoveDataSet (global::Java.Lang.Object d)
		{
			const string __id = "removeDataSet.(Lcom/github/mikephil/charting/interfaces/datasets/IDataSet;)Z";
			IntPtr native_d = JNIEnv.ToLocalJniHandle (d);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_d);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_d);
				global::System.GC.KeepAlive (d);
			}
		}

		static Delegate cb_removeEntry_Lcom_github_mikephil_charting_data_Entry_I;
#pragma warning disable 0169
		static Delegate GetRemoveEntry_Lcom_github_mikephil_charting_data_Entry_IHandler ()
		{
			if (cb_removeEntry_Lcom_github_mikephil_charting_data_Entry_I == null)
				cb_removeEntry_Lcom_github_mikephil_charting_data_Entry_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLI_Z) n_RemoveEntry_Lcom_github_mikephil_charting_data_Entry_I);
			return cb_removeEntry_Lcom_github_mikephil_charting_data_Entry_I;
		}

		static bool n_RemoveEntry_Lcom_github_mikephil_charting_data_Entry_I (IntPtr jnienv, IntPtr native__this, IntPtr native_e, int dataSetIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var e = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.Entry> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveEntry (e, dataSetIndex);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='removeEntry' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.data.Entry'] and parameter[2][@type='int']]"
		[Register ("removeEntry", "(Lcom/github/mikephil/charting/data/Entry;I)Z", "GetRemoveEntry_Lcom_github_mikephil_charting_data_Entry_IHandler")]
		public virtual unsafe bool RemoveEntry (global::MikePhil.Charting.Data.Entry e, int dataSetIndex)
		{
			const string __id = "removeEntry.(Lcom/github/mikephil/charting/data/Entry;I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				__args [1] = new JniArgumentValue (dataSetIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (e);
			}
		}

		static Delegate cb_removeEntry_FI;
#pragma warning disable 0169
		static Delegate GetRemoveEntry_FIHandler ()
		{
			if (cb_removeEntry_FI == null)
				cb_removeEntry_FI = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPFI_Z) n_RemoveEntry_FI);
			return cb_removeEntry_FI;
		}

		static bool n_RemoveEntry_FI (IntPtr jnienv, IntPtr native__this, float xValue, int dataSetIndex)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RemoveEntry (xValue, dataSetIndex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='removeEntry' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='int']]"
		[Register ("removeEntry", "(FI)Z", "GetRemoveEntry_FIHandler")]
		public virtual unsafe bool RemoveEntry (float xValue, int dataSetIndex)
		{
			const string __id = "removeEntry.(FI)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (xValue);
				__args [1] = new JniArgumentValue (dataSetIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setDrawValues_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawValues_ZHandler ()
		{
			if (cb_setDrawValues_Z == null)
				cb_setDrawValues_Z = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPZ_V) n_SetDrawValues_Z);
			return cb_setDrawValues_Z;
		}

		static void n_SetDrawValues_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawValues (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='setDrawValues' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawValues", "(Z)V", "GetSetDrawValues_ZHandler")]
		public virtual unsafe void SetDrawValues (bool enabled)
		{
			const string __id = "setDrawValues.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_;
#pragma warning disable 0169
		static Delegate GetSetValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_Handler ()
		{
			if (cb_setValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_ == null)
				cb_setValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_);
			return cb_setValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_;
		}

		static void n_SetValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_ (IntPtr jnienv, IntPtr native__this, IntPtr native_f)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var f = (global::MikePhil.Charting.Formatter.IValueFormatter)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IValueFormatter> (native_f, JniHandleOwnership.DoNotTransfer);
			__this.SetValueFormatter (f);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='setValueFormatter' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.formatter.IValueFormatter']]"
		[Register ("setValueFormatter", "(Lcom/github/mikephil/charting/formatter/IValueFormatter;)V", "GetSetValueFormatter_Lcom_github_mikephil_charting_formatter_IValueFormatter_Handler")]
		public virtual unsafe void SetValueFormatter (global::MikePhil.Charting.Formatter.IValueFormatter f)
		{
			const string __id = "setValueFormatter.(Lcom/github/mikephil/charting/formatter/IValueFormatter;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (f);
			}
		}

		static Delegate cb_setValueTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetValueTextColor_IHandler ()
		{
			if (cb_setValueTextColor_I == null)
				cb_setValueTextColor_I = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPI_V) n_SetValueTextColor_I);
			return cb_setValueTextColor_I;
		}

		static void n_SetValueTextColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetValueTextColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='setValueTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setValueTextColor", "(I)V", "GetSetValueTextColor_IHandler")]
		public virtual unsafe void SetValueTextColor (int color)
		{
			const string __id = "setValueTextColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setValueTextColors_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetValueTextColors_Ljava_util_List_Handler ()
		{
			if (cb_setValueTextColors_Ljava_util_List_ == null)
				cb_setValueTextColors_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetValueTextColors_Ljava_util_List_);
			return cb_setValueTextColors_Ljava_util_List_;
		}

		static void n_SetValueTextColors_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_colors)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var colors = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (native_colors, JniHandleOwnership.DoNotTransfer);
			__this.SetValueTextColors (colors);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='setValueTextColors' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Integer&gt;']]"
		[Register ("setValueTextColors", "(Ljava/util/List;)V", "GetSetValueTextColors_Ljava_util_List_Handler")]
		public virtual unsafe void SetValueTextColors (global::System.Collections.Generic.IList<global::Java.Lang.Integer> colors)
		{
			const string __id = "setValueTextColors.(Ljava/util/List;)V";
			IntPtr native_colors = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (colors);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_colors);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_colors);
				global::System.GC.KeepAlive (colors);
			}
		}

		static Delegate cb_setValueTextSize_F;
#pragma warning disable 0169
		static Delegate GetSetValueTextSize_FHandler ()
		{
			if (cb_setValueTextSize_F == null)
				cb_setValueTextSize_F = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPF_V) n_SetValueTextSize_F);
			return cb_setValueTextSize_F;
		}

		static void n_SetValueTextSize_F (IntPtr jnienv, IntPtr native__this, float size)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetValueTextSize (size);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='setValueTextSize' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setValueTextSize", "(F)V", "GetSetValueTextSize_FHandler")]
		public virtual unsafe void SetValueTextSize (float size)
		{
			const string __id = "setValueTextSize.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (size);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setValueTypeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetSetValueTypeface_Landroid_graphics_Typeface_Handler ()
		{
			if (cb_setValueTypeface_Landroid_graphics_Typeface_ == null)
				cb_setValueTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_SetValueTypeface_Landroid_graphics_Typeface_);
			return cb_setValueTypeface_Landroid_graphics_Typeface_;
		}

		static void n_SetValueTypeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tf)
		{
			var __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ChartData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tf = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_tf, JniHandleOwnership.DoNotTransfer);
			__this.SetValueTypeface (tf);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='ChartData']/method[@name='setValueTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
		[Register ("setValueTypeface", "(Landroid/graphics/Typeface;)V", "GetSetValueTypeface_Landroid_graphics_Typeface_Handler")]
		public virtual unsafe void SetValueTypeface (global::Android.Graphics.Typeface tf)
		{
			const string __id = "setValueTypeface.(Landroid/graphics/Typeface;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tf).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (tf);
			}
		}

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/ChartData", DoNotGenerateAcw=true)]
	internal partial class ChartDataInvoker : ChartData {
		public ChartDataInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/ChartData", typeof (ChartDataInvoker));

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

	}
}
