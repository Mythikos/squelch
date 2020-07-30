using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/PieDataSet", DoNotGenerateAcw=true)]
	public partial class PieDataSet : global::MikePhil.Charting.Data.DataSet, global::MikePhil.Charting.Interfaces.Datasets.IPieDataSet {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet.ValuePosition']"
		[global::Android.Runtime.Register ("com/github/mikephil/charting/data/PieDataSet$ValuePosition", DoNotGenerateAcw=true)]
		public sealed partial class ValuePosition : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet.ValuePosition']/field[@name='INSIDE_SLICE']"
			[Register ("INSIDE_SLICE")]
			public static global::MikePhil.Charting.Data.PieDataSet.ValuePosition InsideSlice {
				get {
					const string __id = "INSIDE_SLICE.Lcom/github/mikephil/charting/data/PieDataSet$ValuePosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet.ValuePosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet.ValuePosition']/field[@name='OUTSIDE_SLICE']"
			[Register ("OUTSIDE_SLICE")]
			public static global::MikePhil.Charting.Data.PieDataSet.ValuePosition OutsideSlice {
				get {
					const string __id = "OUTSIDE_SLICE.Lcom/github/mikephil/charting/data/PieDataSet$ValuePosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet.ValuePosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/PieDataSet$ValuePosition", typeof (ValuePosition));
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

			internal ValuePosition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet.ValuePosition']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/github/mikephil/charting/data/PieDataSet$ValuePosition;", "")]
			public static unsafe global::MikePhil.Charting.Data.PieDataSet.ValuePosition ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/github/mikephil/charting/data/PieDataSet$ValuePosition;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet.ValuePosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet.ValuePosition']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/github/mikephil/charting/data/PieDataSet$ValuePosition;", "")]
			public static unsafe global::MikePhil.Charting.Data.PieDataSet.ValuePosition[] Values ()
			{
				const string __id = "values.()[Lcom/github/mikephil/charting/data/PieDataSet$ValuePosition;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::MikePhil.Charting.Data.PieDataSet.ValuePosition[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::MikePhil.Charting.Data.PieDataSet.ValuePosition));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/PieDataSet", typeof (PieDataSet));
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

		protected PieDataSet (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/constructor[@name='PieDataSet' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.github.mikephil.charting.data.PieEntry&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/util/List;Ljava/lang/String;)V", "")]
		public unsafe PieDataSet (global::System.Collections.Generic.IList<global::MikePhil.Charting.Data.PieEntry> yVals, string label)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_yVals = global::Android.Runtime.JavaList<global::MikePhil.Charting.Data.PieEntry>.ToLocalJniHandle (yVals);
			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_yVals);
				__args [1] = new JniArgumentValue (native_label);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_yVals);
				JNIEnv.DeleteLocalRef (native_label);
			}
		}

		static Delegate cb_isAutomaticallyDisableSliceSpacingEnabled;
#pragma warning disable 0169
		static Delegate GetIsAutomaticallyDisableSliceSpacingEnabledHandler ()
		{
			if (cb_isAutomaticallyDisableSliceSpacingEnabled == null)
				cb_isAutomaticallyDisableSliceSpacingEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAutomaticallyDisableSliceSpacingEnabled);
			return cb_isAutomaticallyDisableSliceSpacingEnabled;
		}

		static bool n_IsAutomaticallyDisableSliceSpacingEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAutomaticallyDisableSliceSpacingEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsAutomaticallyDisableSliceSpacingEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='isAutomaticallyDisableSliceSpacingEnabled' and count(parameter)=0]"
			[Register ("isAutomaticallyDisableSliceSpacingEnabled", "()Z", "GetIsAutomaticallyDisableSliceSpacingEnabledHandler")]
			get {
				const string __id = "isAutomaticallyDisableSliceSpacingEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isUsingSliceColorAsValueLineColor;
#pragma warning disable 0169
		static Delegate GetIsUsingSliceColorAsValueLineColorHandler ()
		{
			if (cb_isUsingSliceColorAsValueLineColor == null)
				cb_isUsingSliceColorAsValueLineColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUsingSliceColorAsValueLineColor);
			return cb_isUsingSliceColorAsValueLineColor;
		}

		static bool n_IsUsingSliceColorAsValueLineColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUsingSliceColorAsValueLineColor;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsUsingSliceColorAsValueLineColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='isUsingSliceColorAsValueLineColor' and count(parameter)=0]"
			[Register ("isUsingSliceColorAsValueLineColor", "()Z", "GetIsUsingSliceColorAsValueLineColorHandler")]
			get {
				const string __id = "isUsingSliceColorAsValueLineColor.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isValueLineVariableLength;
#pragma warning disable 0169
		static Delegate GetIsValueLineVariableLengthHandler ()
		{
			if (cb_isValueLineVariableLength == null)
				cb_isValueLineVariableLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsValueLineVariableLength);
			return cb_isValueLineVariableLength;
		}

		static bool n_IsValueLineVariableLength (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsValueLineVariableLength;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsValueLineVariableLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='isValueLineVariableLength' and count(parameter)=0]"
			[Register ("isValueLineVariableLength", "()Z", "GetIsValueLineVariableLengthHandler")]
			get {
				const string __id = "isValueLineVariableLength.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getSelectionShift;
#pragma warning disable 0169
		static Delegate GetGetSelectionShiftHandler ()
		{
			if (cb_getSelectionShift == null)
				cb_getSelectionShift = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetSelectionShift);
			return cb_getSelectionShift;
		}

		static float n_GetSelectionShift (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SelectionShift;
		}
#pragma warning restore 0169

		static Delegate cb_setSelectionShift_F;
#pragma warning disable 0169
		static Delegate GetSetSelectionShift_FHandler ()
		{
			if (cb_setSelectionShift_F == null)
				cb_setSelectionShift_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetSelectionShift_F);
			return cb_setSelectionShift_F;
		}

		static void n_SetSelectionShift_F (IntPtr jnienv, IntPtr native__this, float shift)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SelectionShift = shift;
		}
#pragma warning restore 0169

		public virtual unsafe float SelectionShift {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='getSelectionShift' and count(parameter)=0]"
			[Register ("getSelectionShift", "()F", "GetGetSelectionShiftHandler")]
			get {
				const string __id = "getSelectionShift.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='setSelectionShift' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setSelectionShift", "(F)V", "GetSetSelectionShift_FHandler")]
			set {
				const string __id = "setSelectionShift.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getSliceSpace;
#pragma warning disable 0169
		static Delegate GetGetSliceSpaceHandler ()
		{
			if (cb_getSliceSpace == null)
				cb_getSliceSpace = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetSliceSpace);
			return cb_getSliceSpace;
		}

		static float n_GetSliceSpace (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.SliceSpace;
		}
#pragma warning restore 0169

		static Delegate cb_setSliceSpace_F;
#pragma warning disable 0169
		static Delegate GetSetSliceSpace_FHandler ()
		{
			if (cb_setSliceSpace_F == null)
				cb_setSliceSpace_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetSliceSpace_F);
			return cb_setSliceSpace_F;
		}

		static void n_SetSliceSpace_F (IntPtr jnienv, IntPtr native__this, float spaceDp)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SliceSpace = spaceDp;
		}
#pragma warning restore 0169

		public virtual unsafe float SliceSpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='getSliceSpace' and count(parameter)=0]"
			[Register ("getSliceSpace", "()F", "GetGetSliceSpaceHandler")]
			get {
				const string __id = "getSliceSpace.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='setSliceSpace' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setSliceSpace", "(F)V", "GetSetSliceSpace_FHandler")]
			set {
				const string __id = "setSliceSpace.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getValueLineColor;
#pragma warning disable 0169
		static Delegate GetGetValueLineColorHandler ()
		{
			if (cb_getValueLineColor == null)
				cb_getValueLineColor = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetValueLineColor);
			return cb_getValueLineColor;
		}

		static int n_GetValueLineColor (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ValueLineColor;
		}
#pragma warning restore 0169

		static Delegate cb_setValueLineColor_I;
#pragma warning disable 0169
		static Delegate GetSetValueLineColor_IHandler ()
		{
			if (cb_setValueLineColor_I == null)
				cb_setValueLineColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetValueLineColor_I);
			return cb_setValueLineColor_I;
		}

		static void n_SetValueLineColor_I (IntPtr jnienv, IntPtr native__this, int valueLineColor)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ValueLineColor = valueLineColor;
		}
#pragma warning restore 0169

		public virtual unsafe int ValueLineColor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='getValueLineColor' and count(parameter)=0]"
			[Register ("getValueLineColor", "()I", "GetGetValueLineColorHandler")]
			get {
				const string __id = "getValueLineColor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='setValueLineColor' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setValueLineColor", "(I)V", "GetSetValueLineColor_IHandler")]
			set {
				const string __id = "setValueLineColor.(I)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getValueLinePart1Length;
#pragma warning disable 0169
		static Delegate GetGetValueLinePart1LengthHandler ()
		{
			if (cb_getValueLinePart1Length == null)
				cb_getValueLinePart1Length = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetValueLinePart1Length);
			return cb_getValueLinePart1Length;
		}

		static float n_GetValueLinePart1Length (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ValueLinePart1Length;
		}
#pragma warning restore 0169

		static Delegate cb_setValueLinePart1Length_F;
#pragma warning disable 0169
		static Delegate GetSetValueLinePart1Length_FHandler ()
		{
			if (cb_setValueLinePart1Length_F == null)
				cb_setValueLinePart1Length_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetValueLinePart1Length_F);
			return cb_setValueLinePart1Length_F;
		}

		static void n_SetValueLinePart1Length_F (IntPtr jnienv, IntPtr native__this, float valueLinePart1Length)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ValueLinePart1Length = valueLinePart1Length;
		}
#pragma warning restore 0169

		public virtual unsafe float ValueLinePart1Length {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='getValueLinePart1Length' and count(parameter)=0]"
			[Register ("getValueLinePart1Length", "()F", "GetGetValueLinePart1LengthHandler")]
			get {
				const string __id = "getValueLinePart1Length.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='setValueLinePart1Length' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setValueLinePart1Length", "(F)V", "GetSetValueLinePart1Length_FHandler")]
			set {
				const string __id = "setValueLinePart1Length.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getValueLinePart1OffsetPercentage;
#pragma warning disable 0169
		static Delegate GetGetValueLinePart1OffsetPercentageHandler ()
		{
			if (cb_getValueLinePart1OffsetPercentage == null)
				cb_getValueLinePart1OffsetPercentage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetValueLinePart1OffsetPercentage);
			return cb_getValueLinePart1OffsetPercentage;
		}

		static float n_GetValueLinePart1OffsetPercentage (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ValueLinePart1OffsetPercentage;
		}
#pragma warning restore 0169

		static Delegate cb_setValueLinePart1OffsetPercentage_F;
#pragma warning disable 0169
		static Delegate GetSetValueLinePart1OffsetPercentage_FHandler ()
		{
			if (cb_setValueLinePart1OffsetPercentage_F == null)
				cb_setValueLinePart1OffsetPercentage_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetValueLinePart1OffsetPercentage_F);
			return cb_setValueLinePart1OffsetPercentage_F;
		}

		static void n_SetValueLinePart1OffsetPercentage_F (IntPtr jnienv, IntPtr native__this, float valueLinePart1OffsetPercentage)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ValueLinePart1OffsetPercentage = valueLinePart1OffsetPercentage;
		}
#pragma warning restore 0169

		public virtual unsafe float ValueLinePart1OffsetPercentage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='getValueLinePart1OffsetPercentage' and count(parameter)=0]"
			[Register ("getValueLinePart1OffsetPercentage", "()F", "GetGetValueLinePart1OffsetPercentageHandler")]
			get {
				const string __id = "getValueLinePart1OffsetPercentage.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='setValueLinePart1OffsetPercentage' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setValueLinePart1OffsetPercentage", "(F)V", "GetSetValueLinePart1OffsetPercentage_FHandler")]
			set {
				const string __id = "setValueLinePart1OffsetPercentage.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getValueLinePart2Length;
#pragma warning disable 0169
		static Delegate GetGetValueLinePart2LengthHandler ()
		{
			if (cb_getValueLinePart2Length == null)
				cb_getValueLinePart2Length = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetValueLinePart2Length);
			return cb_getValueLinePart2Length;
		}

		static float n_GetValueLinePart2Length (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ValueLinePart2Length;
		}
#pragma warning restore 0169

		static Delegate cb_setValueLinePart2Length_F;
#pragma warning disable 0169
		static Delegate GetSetValueLinePart2Length_FHandler ()
		{
			if (cb_setValueLinePart2Length_F == null)
				cb_setValueLinePart2Length_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetValueLinePart2Length_F);
			return cb_setValueLinePart2Length_F;
		}

		static void n_SetValueLinePart2Length_F (IntPtr jnienv, IntPtr native__this, float valueLinePart2Length)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ValueLinePart2Length = valueLinePart2Length;
		}
#pragma warning restore 0169

		public virtual unsafe float ValueLinePart2Length {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='getValueLinePart2Length' and count(parameter)=0]"
			[Register ("getValueLinePart2Length", "()F", "GetGetValueLinePart2LengthHandler")]
			get {
				const string __id = "getValueLinePart2Length.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='setValueLinePart2Length' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setValueLinePart2Length", "(F)V", "GetSetValueLinePart2Length_FHandler")]
			set {
				const string __id = "setValueLinePart2Length.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getValueLineWidth;
#pragma warning disable 0169
		static Delegate GetGetValueLineWidthHandler ()
		{
			if (cb_getValueLineWidth == null)
				cb_getValueLineWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetValueLineWidth);
			return cb_getValueLineWidth;
		}

		static float n_GetValueLineWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ValueLineWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setValueLineWidth_F;
#pragma warning disable 0169
		static Delegate GetSetValueLineWidth_FHandler ()
		{
			if (cb_setValueLineWidth_F == null)
				cb_setValueLineWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetValueLineWidth_F);
			return cb_setValueLineWidth_F;
		}

		static void n_SetValueLineWidth_F (IntPtr jnienv, IntPtr native__this, float valueLineWidth)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ValueLineWidth = valueLineWidth;
		}
#pragma warning restore 0169

		public virtual unsafe float ValueLineWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='getValueLineWidth' and count(parameter)=0]"
			[Register ("getValueLineWidth", "()F", "GetGetValueLineWidthHandler")]
			get {
				const string __id = "getValueLineWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='setValueLineWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setValueLineWidth", "(F)V", "GetSetValueLineWidth_FHandler")]
			set {
				const string __id = "setValueLineWidth.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getXValuePosition;
#pragma warning disable 0169
		static Delegate GetGetXValuePositionHandler ()
		{
			if (cb_getXValuePosition == null)
				cb_getXValuePosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetXValuePosition);
			return cb_getXValuePosition;
		}

		static IntPtr n_GetXValuePosition (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.XValuePosition);
		}
#pragma warning restore 0169

		static Delegate cb_setXValuePosition_Lcom_github_mikephil_charting_data_PieDataSet_ValuePosition_;
#pragma warning disable 0169
		static Delegate GetSetXValuePosition_Lcom_github_mikephil_charting_data_PieDataSet_ValuePosition_Handler ()
		{
			if (cb_setXValuePosition_Lcom_github_mikephil_charting_data_PieDataSet_ValuePosition_ == null)
				cb_setXValuePosition_Lcom_github_mikephil_charting_data_PieDataSet_ValuePosition_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetXValuePosition_Lcom_github_mikephil_charting_data_PieDataSet_ValuePosition_);
			return cb_setXValuePosition_Lcom_github_mikephil_charting_data_PieDataSet_ValuePosition_;
		}

		static void n_SetXValuePosition_Lcom_github_mikephil_charting_data_PieDataSet_ValuePosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_xValuePosition)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.PieDataSet.ValuePosition xValuePosition = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet.ValuePosition> (native_xValuePosition, JniHandleOwnership.DoNotTransfer);
			__this.XValuePosition = xValuePosition;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Data.PieDataSet.ValuePosition XValuePosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='getXValuePosition' and count(parameter)=0]"
			[Register ("getXValuePosition", "()Lcom/github/mikephil/charting/data/PieDataSet$ValuePosition;", "GetGetXValuePositionHandler")]
			get {
				const string __id = "getXValuePosition.()Lcom/github/mikephil/charting/data/PieDataSet$ValuePosition;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet.ValuePosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='setXValuePosition' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.PieDataSet.ValuePosition']]"
			[Register ("setXValuePosition", "(Lcom/github/mikephil/charting/data/PieDataSet$ValuePosition;)V", "GetSetXValuePosition_Lcom_github_mikephil_charting_data_PieDataSet_ValuePosition_Handler")]
			set {
				const string __id = "setXValuePosition.(Lcom/github/mikephil/charting/data/PieDataSet$ValuePosition;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getYValuePosition;
#pragma warning disable 0169
		static Delegate GetGetYValuePositionHandler ()
		{
			if (cb_getYValuePosition == null)
				cb_getYValuePosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetYValuePosition);
			return cb_getYValuePosition;
		}

		static IntPtr n_GetYValuePosition (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.YValuePosition);
		}
#pragma warning restore 0169

		static Delegate cb_setYValuePosition_Lcom_github_mikephil_charting_data_PieDataSet_ValuePosition_;
#pragma warning disable 0169
		static Delegate GetSetYValuePosition_Lcom_github_mikephil_charting_data_PieDataSet_ValuePosition_Handler ()
		{
			if (cb_setYValuePosition_Lcom_github_mikephil_charting_data_PieDataSet_ValuePosition_ == null)
				cb_setYValuePosition_Lcom_github_mikephil_charting_data_PieDataSet_ValuePosition_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetYValuePosition_Lcom_github_mikephil_charting_data_PieDataSet_ValuePosition_);
			return cb_setYValuePosition_Lcom_github_mikephil_charting_data_PieDataSet_ValuePosition_;
		}

		static void n_SetYValuePosition_Lcom_github_mikephil_charting_data_PieDataSet_ValuePosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_yValuePosition)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.PieDataSet.ValuePosition yValuePosition = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet.ValuePosition> (native_yValuePosition, JniHandleOwnership.DoNotTransfer);
			__this.YValuePosition = yValuePosition;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Data.PieDataSet.ValuePosition YValuePosition {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='getYValuePosition' and count(parameter)=0]"
			[Register ("getYValuePosition", "()Lcom/github/mikephil/charting/data/PieDataSet$ValuePosition;", "GetGetYValuePositionHandler")]
			get {
				const string __id = "getYValuePosition.()Lcom/github/mikephil/charting/data/PieDataSet$ValuePosition;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet.ValuePosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='setYValuePosition' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.PieDataSet.ValuePosition']]"
			[Register ("setYValuePosition", "(Lcom/github/mikephil/charting/data/PieDataSet$ValuePosition;)V", "GetSetYValuePosition_Lcom_github_mikephil_charting_data_PieDataSet_ValuePosition_Handler")]
			set {
				const string __id = "setYValuePosition.(Lcom/github/mikephil/charting/data/PieDataSet$ValuePosition;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_calcMinMax_Lcom_github_mikephil_charting_data_PieEntry_;
#pragma warning disable 0169
		static Delegate GetCalcMinMax_Lcom_github_mikephil_charting_data_PieEntry_Handler ()
		{
			if (cb_calcMinMax_Lcom_github_mikephil_charting_data_PieEntry_ == null)
				cb_calcMinMax_Lcom_github_mikephil_charting_data_PieEntry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_CalcMinMax_Lcom_github_mikephil_charting_data_PieEntry_);
			return cb_calcMinMax_Lcom_github_mikephil_charting_data_PieEntry_;
		}

		static void n_CalcMinMax_Lcom_github_mikephil_charting_data_PieEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_e)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.PieEntry e = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieEntry> (native_e, JniHandleOwnership.DoNotTransfer);
			__this.CalcMinMax (e);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='calcMinMax' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.PieEntry']]"
		[Register ("calcMinMax", "(Lcom/github/mikephil/charting/data/PieEntry;)V", "GetCalcMinMax_Lcom_github_mikephil_charting_data_PieEntry_Handler")]
		protected virtual unsafe void CalcMinMax (global::MikePhil.Charting.Data.PieEntry e)
		{
			const string __id = "calcMinMax.(Lcom/github/mikephil/charting/data/PieEntry;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((e == null) ? IntPtr.Zero : ((global::Java.Lang.Object) e).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
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
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Copy ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='copy' and count(parameter)=0]"
		[Register ("copy", "()Lcom/github/mikephil/charting/data/DataSet;", "GetCopyHandler")]
		public override unsafe global::MikePhil.Charting.Data.DataSet Copy ()
		{
			const string __id = "copy.()Lcom/github/mikephil/charting/data/DataSet;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.DataSet> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_copy_Lcom_github_mikephil_charting_data_PieDataSet_;
#pragma warning disable 0169
		static Delegate GetCopy_Lcom_github_mikephil_charting_data_PieDataSet_Handler ()
		{
			if (cb_copy_Lcom_github_mikephil_charting_data_PieDataSet_ == null)
				cb_copy_Lcom_github_mikephil_charting_data_PieDataSet_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Copy_Lcom_github_mikephil_charting_data_PieDataSet_);
			return cb_copy_Lcom_github_mikephil_charting_data_PieDataSet_;
		}

		static void n_Copy_Lcom_github_mikephil_charting_data_PieDataSet_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pieDataSet)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.PieDataSet pieDataSet = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (native_pieDataSet, JniHandleOwnership.DoNotTransfer);
			__this.Copy (pieDataSet);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='copy' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.PieDataSet']]"
		[Register ("copy", "(Lcom/github/mikephil/charting/data/PieDataSet;)V", "GetCopy_Lcom_github_mikephil_charting_data_PieDataSet_Handler")]
		protected virtual unsafe void Copy (global::MikePhil.Charting.Data.PieDataSet pieDataSet)
		{
			const string __id = "copy.(Lcom/github/mikephil/charting/data/PieDataSet;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((pieDataSet == null) ? IntPtr.Zero : ((global::Java.Lang.Object) pieDataSet).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setAutomaticallyDisableSliceSpacing_Z;
#pragma warning disable 0169
		static Delegate GetSetAutomaticallyDisableSliceSpacing_ZHandler ()
		{
			if (cb_setAutomaticallyDisableSliceSpacing_Z == null)
				cb_setAutomaticallyDisableSliceSpacing_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAutomaticallyDisableSliceSpacing_Z);
			return cb_setAutomaticallyDisableSliceSpacing_Z;
		}

		static void n_SetAutomaticallyDisableSliceSpacing_Z (IntPtr jnienv, IntPtr native__this, bool autoDisable)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAutomaticallyDisableSliceSpacing (autoDisable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='setAutomaticallyDisableSliceSpacing' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAutomaticallyDisableSliceSpacing", "(Z)V", "GetSetAutomaticallyDisableSliceSpacing_ZHandler")]
		public virtual unsafe void SetAutomaticallyDisableSliceSpacing (bool autoDisable)
		{
			const string __id = "setAutomaticallyDisableSliceSpacing.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (autoDisable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setUsingSliceColorAsValueLineColor_Z;
#pragma warning disable 0169
		static Delegate GetSetUsingSliceColorAsValueLineColor_ZHandler ()
		{
			if (cb_setUsingSliceColorAsValueLineColor_Z == null)
				cb_setUsingSliceColorAsValueLineColor_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUsingSliceColorAsValueLineColor_Z);
			return cb_setUsingSliceColorAsValueLineColor_Z;
		}

		static void n_SetUsingSliceColorAsValueLineColor_Z (IntPtr jnienv, IntPtr native__this, bool usingSliceColorAsValueLineColor)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUsingSliceColorAsValueLineColor (usingSliceColorAsValueLineColor);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='setUsingSliceColorAsValueLineColor' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUsingSliceColorAsValueLineColor", "(Z)V", "GetSetUsingSliceColorAsValueLineColor_ZHandler")]
		public virtual unsafe void SetUsingSliceColorAsValueLineColor (bool usingSliceColorAsValueLineColor)
		{
			const string __id = "setUsingSliceColorAsValueLineColor.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (usingSliceColorAsValueLineColor);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setValueLineVariableLength_Z;
#pragma warning disable 0169
		static Delegate GetSetValueLineVariableLength_ZHandler ()
		{
			if (cb_setValueLineVariableLength_Z == null)
				cb_setValueLineVariableLength_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetValueLineVariableLength_Z);
			return cb_setValueLineVariableLength_Z;
		}

		static void n_SetValueLineVariableLength_Z (IntPtr jnienv, IntPtr native__this, bool valueLineVariableLength)
		{
			global::MikePhil.Charting.Data.PieDataSet __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.PieDataSet> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetValueLineVariableLength (valueLineVariableLength);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='PieDataSet']/method[@name='setValueLineVariableLength' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setValueLineVariableLength", "(Z)V", "GetSetValueLineVariableLength_ZHandler")]
		public virtual unsafe void SetValueLineVariableLength (bool valueLineVariableLength)
		{
			const string __id = "setValueLineVariableLength.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (valueLineVariableLength);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
