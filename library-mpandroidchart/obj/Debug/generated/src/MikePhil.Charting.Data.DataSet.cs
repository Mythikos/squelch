using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/DataSet", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends com.github.mikephil.charting.data.Entry"})]
	public abstract partial class DataSet : global::MikePhil.Charting.Data.BaseDataSet {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/field[@name='mValues']"
		[Register ("mValues")]
		protected global::System.Collections.IList MValues {
			get {
				const string __id = "mValues.Ljava/util/List;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaList.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mValues.Ljava/util/List;";

				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/field[@name='mXMax']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/field[@name='mXMin']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/field[@name='mYMax']"
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


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/field[@name='mYMin']"
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
		// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet.Rounding']"
		[global::Android.Runtime.Register ("com/github/mikephil/charting/data/DataSet$Rounding", DoNotGenerateAcw=true)]
		public sealed partial class Rounding : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet.Rounding']/field[@name='CLOSEST']"
			[Register ("CLOSEST")]
			public static global::MikePhil.Charting.Data.DataSet.Rounding Closest {
				get {
					const string __id = "CLOSEST.Lcom/github/mikephil/charting/data/DataSet$Rounding;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet.Rounding> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet.Rounding']/field[@name='DOWN']"
			[Register ("DOWN")]
			public static global::MikePhil.Charting.Data.DataSet.Rounding Down {
				get {
					const string __id = "DOWN.Lcom/github/mikephil/charting/data/DataSet$Rounding;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet.Rounding> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet.Rounding']/field[@name='UP']"
			[Register ("UP")]
			public static global::MikePhil.Charting.Data.DataSet.Rounding Up {
				get {
					const string __id = "UP.Lcom/github/mikephil/charting/data/DataSet$Rounding;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet.Rounding> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/DataSet$Rounding", typeof (Rounding));
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

			internal Rounding (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet.Rounding']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/github/mikephil/charting/data/DataSet$Rounding;", "")]
			public static unsafe global::MikePhil.Charting.Data.DataSet.Rounding ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/github/mikephil/charting/data/DataSet$Rounding;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet.Rounding> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet.Rounding']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/github/mikephil/charting/data/DataSet$Rounding;", "")]
			public static unsafe global::MikePhil.Charting.Data.DataSet.Rounding[] Values ()
			{
				const string __id = "values.()[Lcom/github/mikephil/charting/data/DataSet$Rounding;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::MikePhil.Charting.Data.DataSet.Rounding[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::MikePhil.Charting.Data.DataSet.Rounding));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/DataSet", typeof (DataSet));
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

		protected DataSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/constructor[@name='DataSet' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;T&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/util/List;Ljava/lang/String;)V", "")]
		public unsafe DataSet (global::System.Collections.IList values, string label)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_values = global::Android.Runtime.JavaList.ToLocalJniHandle (values);
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_values);
				__args [1] = new JniArgumentValue (native_label);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_values);
				JNIEnv.DeleteLocalRef (native_label);
			}
		}

		static Delegate cb_getEntryCount;
#pragma warning disable 0169
		static Delegate GetGetEntryCountHandler ()
		{
			if (cb_getEntryCount == null)
				cb_getEntryCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetEntryCount);
			return cb_getEntryCount;
		}

		static int n_GetEntryCount (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EntryCount;
		}
#pragma warning restore 0169

		public override unsafe int EntryCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='getEntryCount' and count(parameter)=0]"
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

		static Delegate cb_getValues;
#pragma warning disable 0169
		static Delegate GetGetValuesHandler ()
		{
			if (cb_getValues == null)
				cb_getValues = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValues);
			return cb_getValues;
		}

		static IntPtr n_GetValues (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.Values);
		}
#pragma warning restore 0169

		static Delegate cb_setValues_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetValues_Ljava_util_List_Handler ()
		{
			if (cb_setValues_Ljava_util_List_ == null)
				cb_setValues_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetValues_Ljava_util_List_);
			return cb_setValues_Ljava_util_List_;
		}

		static void n_SetValues_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_values)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var values = global::Android.Runtime.JavaList.FromJniHandle (native_values, JniHandleOwnership.DoNotTransfer);
			__this.Values = values;
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.IList Values {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='getValues' and count(parameter)=0]"
			[Register ("getValues", "()Ljava/util/List;", "GetGetValuesHandler")]
			get {
				const string __id = "getValues.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='setValues' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;T&gt;']]"
			[Register ("setValues", "(Ljava/util/List;)V", "GetSetValues_Ljava_util_List_Handler")]
			set {
				const string __id = "setValues.(Ljava/util/List;)V";
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getXMax;
#pragma warning disable 0169
		static Delegate GetGetXMaxHandler ()
		{
			if (cb_getXMax == null)
				cb_getXMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetXMax);
			return cb_getXMax;
		}

		static float n_GetXMax (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XMax;
		}
#pragma warning restore 0169

		public override unsafe float XMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='getXMax' and count(parameter)=0]"
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
				cb_getXMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetXMin);
			return cb_getXMin;
		}

		static float n_GetXMin (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XMin;
		}
#pragma warning restore 0169

		public override unsafe float XMin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='getXMin' and count(parameter)=0]"
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
				cb_getYMax = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetYMax);
			return cb_getYMax;
		}

		static float n_GetYMax (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YMax;
		}
#pragma warning restore 0169

		public override unsafe float YMax {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='getYMax' and count(parameter)=0]"
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
				cb_getYMin = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetYMin);
			return cb_getYMin;
		}

		static float n_GetYMin (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YMin;
		}
#pragma warning restore 0169

		public override unsafe float YMin {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='getYMin' and count(parameter)=0]"
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

		static Delegate cb_addEntry_Lcom_github_mikephil_charting_data_Entry_;
#pragma warning disable 0169
		static Delegate GetAddEntry_Lcom_github_mikephil_charting_data_Entry_Handler ()
		{
			if (cb_addEntry_Lcom_github_mikephil_charting_data_Entry_ == null)
				cb_addEntry_Lcom_github_mikephil_charting_data_Entry_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_AddEntry_Lcom_github_mikephil_charting_data_Entry_);
			return cb_addEntry_Lcom_github_mikephil_charting_data_Entry_;
		}

		static bool n_AddEntry_Lcom_github_mikephil_charting_data_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object e = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AddEntry (e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='addEntry' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("addEntry", "(Lcom/github/mikephil/charting/data/Entry;)Z", "GetAddEntry_Lcom_github_mikephil_charting_data_Entry_Handler")]
		public virtual unsafe bool AddEntry (global::Java.Lang.Object e)
		{
			const string __id = "addEntry.(Lcom/github/mikephil/charting/data/Entry;)Z";
			IntPtr native_e = JNIEnv.ToLocalJniHandle (e);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_e);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_e);
			}
		}

		static Delegate cb_addEntryOrdered_Lcom_github_mikephil_charting_data_Entry_;
#pragma warning disable 0169
		static Delegate GetAddEntryOrdered_Lcom_github_mikephil_charting_data_Entry_Handler ()
		{
			if (cb_addEntryOrdered_Lcom_github_mikephil_charting_data_Entry_ == null)
				cb_addEntryOrdered_Lcom_github_mikephil_charting_data_Entry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddEntryOrdered_Lcom_github_mikephil_charting_data_Entry_);
			return cb_addEntryOrdered_Lcom_github_mikephil_charting_data_Entry_;
		}

		static void n_AddEntryOrdered_Lcom_github_mikephil_charting_data_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object e = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.AddEntryOrdered (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='addEntryOrdered' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("addEntryOrdered", "(Lcom/github/mikephil/charting/data/Entry;)V", "GetAddEntryOrdered_Lcom_github_mikephil_charting_data_Entry_Handler")]
		public virtual unsafe void AddEntryOrdered (global::Java.Lang.Object e)
		{
			const string __id = "addEntryOrdered.(Lcom/github/mikephil/charting/data/Entry;)V";
			IntPtr native_e = JNIEnv.ToLocalJniHandle (e);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_e);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_e);
			}
		}

		static Delegate cb_calcMinMax;
#pragma warning disable 0169
		static Delegate GetCalcMinMaxHandler ()
		{
			if (cb_calcMinMax == null)
				cb_calcMinMax = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CalcMinMax);
			return cb_calcMinMax;
		}

		static void n_CalcMinMax (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalcMinMax ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='calcMinMax' and count(parameter)=0]"
		[Register ("calcMinMax", "()V", "GetCalcMinMaxHandler")]
		public override unsafe void CalcMinMax ()
		{
			const string __id = "calcMinMax.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_calcMinMax_Lcom_github_mikephil_charting_data_Entry_;
#pragma warning disable 0169
		static Delegate GetCalcMinMax_Lcom_github_mikephil_charting_data_Entry_Handler ()
		{
			if (cb_calcMinMax_Lcom_github_mikephil_charting_data_Entry_ == null)
				cb_calcMinMax_Lcom_github_mikephil_charting_data_Entry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CalcMinMax_Lcom_github_mikephil_charting_data_Entry_);
			return cb_calcMinMax_Lcom_github_mikephil_charting_data_Entry_;
		}

		static void n_CalcMinMax_Lcom_github_mikephil_charting_data_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object e = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.CalcMinMax (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='calcMinMax' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("calcMinMax", "(Lcom/github/mikephil/charting/data/Entry;)V", "GetCalcMinMax_Lcom_github_mikephil_charting_data_Entry_Handler")]
		protected virtual unsafe void CalcMinMax (global::Java.Lang.Object e)
		{
			const string __id = "calcMinMax.(Lcom/github/mikephil/charting/data/Entry;)V";
			IntPtr native_e = JNIEnv.ToLocalJniHandle (e);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_e);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_e);
			}
		}

		static Delegate cb_calcMinMaxX_Lcom_github_mikephil_charting_data_Entry_;
#pragma warning disable 0169
		static Delegate GetCalcMinMaxX_Lcom_github_mikephil_charting_data_Entry_Handler ()
		{
			if (cb_calcMinMaxX_Lcom_github_mikephil_charting_data_Entry_ == null)
				cb_calcMinMaxX_Lcom_github_mikephil_charting_data_Entry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CalcMinMaxX_Lcom_github_mikephil_charting_data_Entry_);
			return cb_calcMinMaxX_Lcom_github_mikephil_charting_data_Entry_;
		}

		static void n_CalcMinMaxX_Lcom_github_mikephil_charting_data_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object e = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.CalcMinMaxX (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='calcMinMaxX' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("calcMinMaxX", "(Lcom/github/mikephil/charting/data/Entry;)V", "GetCalcMinMaxX_Lcom_github_mikephil_charting_data_Entry_Handler")]
		protected virtual unsafe void CalcMinMaxX (global::Java.Lang.Object e)
		{
			const string __id = "calcMinMaxX.(Lcom/github/mikephil/charting/data/Entry;)V";
			IntPtr native_e = JNIEnv.ToLocalJniHandle (e);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_e);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_e);
			}
		}

		static Delegate cb_calcMinMaxY_FF;
#pragma warning disable 0169
		static Delegate GetCalcMinMaxY_FFHandler ()
		{
			if (cb_calcMinMaxY_FF == null)
				cb_calcMinMaxY_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_CalcMinMaxY_FF);
			return cb_calcMinMaxY_FF;
		}

		static void n_CalcMinMaxY_FF (IntPtr jnienv, IntPtr native__this, float fromX, float toX)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalcMinMaxY (fromX, toX);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='calcMinMaxY' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("calcMinMaxY", "(FF)V", "GetCalcMinMaxY_FFHandler")]
		public override unsafe void CalcMinMaxY (float fromX, float toX)
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

		static Delegate cb_calcMinMaxY_Lcom_github_mikephil_charting_data_Entry_;
#pragma warning disable 0169
		static Delegate GetCalcMinMaxY_Lcom_github_mikephil_charting_data_Entry_Handler ()
		{
			if (cb_calcMinMaxY_Lcom_github_mikephil_charting_data_Entry_ == null)
				cb_calcMinMaxY_Lcom_github_mikephil_charting_data_Entry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CalcMinMaxY_Lcom_github_mikephil_charting_data_Entry_);
			return cb_calcMinMaxY_Lcom_github_mikephil_charting_data_Entry_;
		}

		static void n_CalcMinMaxY_Lcom_github_mikephil_charting_data_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object e = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.CalcMinMaxY (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='calcMinMaxY' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("calcMinMaxY", "(Lcom/github/mikephil/charting/data/Entry;)V", "GetCalcMinMaxY_Lcom_github_mikephil_charting_data_Entry_Handler")]
		protected virtual unsafe void CalcMinMaxY (global::Java.Lang.Object e)
		{
			const string __id = "calcMinMaxY.(Lcom/github/mikephil/charting/data/Entry;)V";
			IntPtr native_e = JNIEnv.ToLocalJniHandle (e);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_e);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_e);
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public override unsafe void Clear ()
		{
			const string __id = "clear.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_copy;
#pragma warning disable 0169
		static Delegate GetCopyHandler ()
		{
			if (cb_copy == null)
				cb_copy = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Copy);
			return cb_copy;
		}

		static IntPtr n_Copy (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Copy ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='copy' and count(parameter)=0]"
		[Register ("copy", "()Lcom/github/mikephil/charting/data/DataSet;", "GetCopyHandler")]
		public abstract global::MikePhil.Charting.Data.DataSet Copy ();

		static Delegate cb_copy_Lcom_github_mikephil_charting_data_DataSet_;
#pragma warning disable 0169
		static Delegate GetCopy_Lcom_github_mikephil_charting_data_DataSet_Handler ()
		{
			if (cb_copy_Lcom_github_mikephil_charting_data_DataSet_ == null)
				cb_copy_Lcom_github_mikephil_charting_data_DataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Copy_Lcom_github_mikephil_charting_data_DataSet_);
			return cb_copy_Lcom_github_mikephil_charting_data_DataSet_;
		}

		static void n_Copy_Lcom_github_mikephil_charting_data_DataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dataSet)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.DataSet dataSet = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (native_dataSet, JniHandleOwnership.DoNotTransfer);
			__this.Copy (dataSet);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.DataSet']]"
		[Register ("copy", "(Lcom/github/mikephil/charting/data/DataSet;)V", "GetCopy_Lcom_github_mikephil_charting_data_DataSet_Handler")]
		protected virtual unsafe void Copy (global::MikePhil.Charting.Data.DataSet dataSet)
		{
			const string __id = "copy.(Lcom/github/mikephil/charting/data/DataSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((dataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSet).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getEntriesForXValue_F;
#pragma warning disable 0169
		static Delegate GetGetEntriesForXValue_FHandler ()
		{
			if (cb_getEntriesForXValue_F == null)
				cb_getEntriesForXValue_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, IntPtr>) n_GetEntriesForXValue_F);
			return cb_getEntriesForXValue_F;
		}

		static IntPtr n_GetEntriesForXValue_F (IntPtr jnienv, IntPtr native__this, float xValue)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList.ToLocalJniHandle (__this.GetEntriesForXValue (xValue));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='getEntriesForXValue' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getEntriesForXValue", "(F)Ljava/util/List;", "GetGetEntriesForXValue_FHandler")]
		public override unsafe global::System.Collections.IList GetEntriesForXValue (float xValue)
		{
			const string __id = "getEntriesForXValue.(F)Ljava/util/List;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (xValue);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Android.Runtime.JavaList.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getEntryForIndex_I;
#pragma warning disable 0169
		static Delegate GetGetEntryForIndex_IHandler ()
		{
			if (cb_getEntryForIndex_I == null)
				cb_getEntryForIndex_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetEntryForIndex_I);
			return cb_getEntryForIndex_I;
		}

		static IntPtr n_GetEntryForIndex_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetEntryForIndex (index));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='getEntryForIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getEntryForIndex", "(I)Lcom/github/mikephil/charting/data/Entry;", "GetGetEntryForIndex_IHandler")]
		public virtual unsafe global::Java.Lang.Object GetEntryForIndex (int index)
		{
			const string __id = "getEntryForIndex.(I)Lcom/github/mikephil/charting/data/Entry;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getEntryForXValue_FF;
#pragma warning disable 0169
		static Delegate GetGetEntryForXValue_FFHandler ()
		{
			if (cb_getEntryForXValue_FF == null)
				cb_getEntryForXValue_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_GetEntryForXValue_FF);
			return cb_getEntryForXValue_FF;
		}

		static IntPtr n_GetEntryForXValue_FF (IntPtr jnienv, IntPtr native__this, float xValue, float closestToY)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetEntryForXValue (xValue, closestToY));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='getEntryForXValue' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("getEntryForXValue", "(FF)Lcom/github/mikephil/charting/data/Entry;", "GetGetEntryForXValue_FFHandler")]
		public virtual unsafe global::Java.Lang.Object GetEntryForXValue (float xValue, float closestToY)
		{
			const string __id = "getEntryForXValue.(FF)Lcom/github/mikephil/charting/data/Entry;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (xValue);
				__args [1] = new JniArgumentValue (closestToY);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getEntryForXValue_FFLcom_github_mikephil_charting_data_DataSet_Rounding_;
#pragma warning disable 0169
		static Delegate GetGetEntryForXValue_FFLcom_github_mikephil_charting_data_DataSet_Rounding_Handler ()
		{
			if (cb_getEntryForXValue_FFLcom_github_mikephil_charting_data_DataSet_Rounding_ == null)
				cb_getEntryForXValue_FFLcom_github_mikephil_charting_data_DataSet_Rounding_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr, IntPtr>) n_GetEntryForXValue_FFLcom_github_mikephil_charting_data_DataSet_Rounding_);
			return cb_getEntryForXValue_FFLcom_github_mikephil_charting_data_DataSet_Rounding_;
		}

		static IntPtr n_GetEntryForXValue_FFLcom_github_mikephil_charting_data_DataSet_Rounding_ (IntPtr jnienv, IntPtr native__this, float xValue, float closestToY, IntPtr native_rounding)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.DataSet.Rounding rounding = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet.Rounding> (native_rounding, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.GetEntryForXValue (xValue, closestToY, rounding));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='getEntryForXValue' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='com.github.mikephil.charting.data.DataSet.Rounding']]"
		[Register ("getEntryForXValue", "(FFLcom/github/mikephil/charting/data/DataSet$Rounding;)Lcom/github/mikephil/charting/data/Entry;", "GetGetEntryForXValue_FFLcom_github_mikephil_charting_data_DataSet_Rounding_Handler")]
		public virtual unsafe global::Java.Lang.Object GetEntryForXValue (float xValue, float closestToY, global::MikePhil.Charting.Data.DataSet.Rounding rounding)
		{
			const string __id = "getEntryForXValue.(FFLcom/github/mikephil/charting/data/DataSet$Rounding;)Lcom/github/mikephil/charting/data/Entry;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (xValue);
				__args [1] = new JniArgumentValue (closestToY);
				__args [2] = new JniArgumentValue ((rounding == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rounding).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getEntryIndex_Lcom_github_mikephil_charting_data_Entry_;
#pragma warning disable 0169
		static Delegate GetGetEntryIndex_Lcom_github_mikephil_charting_data_Entry_Handler ()
		{
			if (cb_getEntryIndex_Lcom_github_mikephil_charting_data_Entry_ == null)
				cb_getEntryIndex_Lcom_github_mikephil_charting_data_Entry_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_GetEntryIndex_Lcom_github_mikephil_charting_data_Entry_);
			return cb_getEntryIndex_Lcom_github_mikephil_charting_data_Entry_;
		}

		static int n_GetEntryIndex_Lcom_github_mikephil_charting_data_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.Entry e = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.Entry> (native_e, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetEntryIndex (e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='getEntryIndex' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.Entry']]"
		[Register ("getEntryIndex", "(Lcom/github/mikephil/charting/data/Entry;)I", "GetGetEntryIndex_Lcom_github_mikephil_charting_data_Entry_Handler")]
		public virtual unsafe int GetEntryIndex (global::MikePhil.Charting.Data.Entry e)
		{
			const string __id = "getEntryIndex.(Lcom/github/mikephil/charting/data/Entry;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_;
#pragma warning disable 0169
		static Delegate GetGetEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_Handler ()
		{
			if (cb_getEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_ == null)
				cb_getEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr, int>) n_GetEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_);
			return cb_getEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_;
		}

		static int n_GetEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_ (IntPtr jnienv, IntPtr native__this, float xValue, float closestToY, IntPtr native_rounding)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.DataSet.Rounding rounding = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet.Rounding> (native_rounding, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.GetEntryIndex (xValue, closestToY, rounding);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='getEntryIndex' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='com.github.mikephil.charting.data.DataSet.Rounding']]"
		[Register ("getEntryIndex", "(FFLcom/github/mikephil/charting/data/DataSet$Rounding;)I", "GetGetEntryIndex_FFLcom_github_mikephil_charting_data_DataSet_Rounding_Handler")]
		public override unsafe int GetEntryIndex (float xValue, float closestToY, global::MikePhil.Charting.Data.DataSet.Rounding rounding)
		{
			const string __id = "getEntryIndex.(FFLcom/github/mikephil/charting/data/DataSet$Rounding;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (xValue);
				__args [1] = new JniArgumentValue (closestToY);
				__args [2] = new JniArgumentValue ((rounding == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rounding).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_removeEntry_Lcom_github_mikephil_charting_data_Entry_;
#pragma warning disable 0169
		static Delegate GetRemoveEntry_Lcom_github_mikephil_charting_data_Entry_Handler ()
		{
			if (cb_removeEntry_Lcom_github_mikephil_charting_data_Entry_ == null)
				cb_removeEntry_Lcom_github_mikephil_charting_data_Entry_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_RemoveEntry_Lcom_github_mikephil_charting_data_Entry_);
			return cb_removeEntry_Lcom_github_mikephil_charting_data_Entry_;
		}

		static bool n_RemoveEntry_Lcom_github_mikephil_charting_data_Entry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object e = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_e, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.RemoveEntry (e);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='removeEntry' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("removeEntry", "(Lcom/github/mikephil/charting/data/Entry;)Z", "GetRemoveEntry_Lcom_github_mikephil_charting_data_Entry_Handler")]
		public virtual unsafe bool RemoveEntry (global::Java.Lang.Object e)
		{
			const string __id = "removeEntry.(Lcom/github/mikephil/charting/data/Entry;)Z";
			IntPtr native_e = JNIEnv.ToLocalJniHandle (e);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_e);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_e);
			}
		}

		static Delegate cb_toSimpleString;
#pragma warning disable 0169
		static Delegate GetToSimpleStringHandler ()
		{
			if (cb_toSimpleString == null)
				cb_toSimpleString = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToSimpleString);
			return cb_toSimpleString;
		}

		static IntPtr n_ToSimpleString (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.DataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToSimpleString ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='toSimpleString' and count(parameter)=0]"
		[Register ("toSimpleString", "()Ljava/lang/String;", "GetToSimpleStringHandler")]
		public virtual unsafe string ToSimpleString ()
		{
			const string __id = "toSimpleString.()Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/DataSet", DoNotGenerateAcw=true)]
	internal partial class DataSetInvoker : DataSet {

		public DataSetInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/DataSet", typeof (DataSetInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='DataSet']/method[@name='copy' and count(parameter)=0]"
		[Register ("copy", "()Lcom/github/mikephil/charting/data/DataSet;", "GetCopyHandler")]
		public override unsafe global::MikePhil.Charting.Data.DataSet Copy ()
		{
			const string __id = "copy.()Lcom/github/mikephil/charting/data/DataSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
