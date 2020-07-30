using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarEntry']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/BarEntry", DoNotGenerateAcw=true)]
	public partial class BarEntry : global::MikePhil.Charting.Data.Entry {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/BarEntry", typeof (BarEntry));
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

		protected BarEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarEntry']/constructor[@name='BarEntry' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register (".ctor", "(FF)V", "")]
		public unsafe BarEntry (float x, float y)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FF)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarEntry']/constructor[@name='BarEntry' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='android.graphics.drawable.Drawable']]"
		[Register (".ctor", "(FFLandroid/graphics/drawable/Drawable;)V", "")]
		public unsafe BarEntry (float x, float y, global::Android.Graphics.Drawables.Drawable icon)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FFLandroid/graphics/drawable/Drawable;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue ((icon == null) ? IntPtr.Zero : ((global::Java.Lang.Object) icon).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarEntry']/constructor[@name='BarEntry' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='android.graphics.drawable.Drawable'] and parameter[4][@type='java.lang.Object']]"
		[Register (".ctor", "(FFLandroid/graphics/drawable/Drawable;Ljava/lang/Object;)V", "")]
		public unsafe BarEntry (float x, float y, global::Android.Graphics.Drawables.Drawable icon, global::Java.Lang.Object data)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FFLandroid/graphics/drawable/Drawable;Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue ((icon == null) ? IntPtr.Zero : ((global::Java.Lang.Object) icon).Handle);
				__args [3] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarEntry']/constructor[@name='BarEntry' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='java.lang.Object']]"
		[Register (".ctor", "(FFLjava/lang/Object;)V", "")]
		public unsafe BarEntry (float x, float y, global::Java.Lang.Object data)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FFLjava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarEntry']/constructor[@name='BarEntry' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float[]']]"
		[Register (".ctor", "(F[F)V", "")]
		public unsafe BarEntry (float x, float[] vals)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(F[F)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_vals = JNIEnv.NewArray (vals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (native_vals);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (vals != null) {
					JNIEnv.CopyArray (native_vals, vals);
					JNIEnv.DeleteLocalRef (native_vals);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarEntry']/constructor[@name='BarEntry' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float[]'] and parameter[3][@type='android.graphics.drawable.Drawable']]"
		[Register (".ctor", "(F[FLandroid/graphics/drawable/Drawable;)V", "")]
		public unsafe BarEntry (float x, float[] vals, global::Android.Graphics.Drawables.Drawable icon)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(F[FLandroid/graphics/drawable/Drawable;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_vals = JNIEnv.NewArray (vals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (native_vals);
				__args [2] = new JniArgumentValue ((icon == null) ? IntPtr.Zero : ((global::Java.Lang.Object) icon).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (vals != null) {
					JNIEnv.CopyArray (native_vals, vals);
					JNIEnv.DeleteLocalRef (native_vals);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarEntry']/constructor[@name='BarEntry' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float[]'] and parameter[3][@type='android.graphics.drawable.Drawable'] and parameter[4][@type='java.lang.Object']]"
		[Register (".ctor", "(F[FLandroid/graphics/drawable/Drawable;Ljava/lang/Object;)V", "")]
		public unsafe BarEntry (float x, float[] vals, global::Android.Graphics.Drawables.Drawable icon, global::Java.Lang.Object data)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(F[FLandroid/graphics/drawable/Drawable;Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_vals = JNIEnv.NewArray (vals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (native_vals);
				__args [2] = new JniArgumentValue ((icon == null) ? IntPtr.Zero : ((global::Java.Lang.Object) icon).Handle);
				__args [3] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (vals != null) {
					JNIEnv.CopyArray (native_vals, vals);
					JNIEnv.DeleteLocalRef (native_vals);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarEntry']/constructor[@name='BarEntry' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float[]'] and parameter[3][@type='java.lang.Object']]"
		[Register (".ctor", "(F[FLjava/lang/Object;)V", "")]
		public unsafe BarEntry (float x, float[] vals, global::Java.Lang.Object data)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(F[FLjava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_vals = JNIEnv.NewArray (vals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (native_vals);
				__args [2] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (vals != null) {
					JNIEnv.CopyArray (native_vals, vals);
					JNIEnv.DeleteLocalRef (native_vals);
				}
			}
		}

		static Delegate cb_isStacked;
#pragma warning disable 0169
		static Delegate GetIsStackedHandler ()
		{
			if (cb_isStacked == null)
				cb_isStacked = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsStacked);
			return cb_isStacked;
		}

		static bool n_IsStacked (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.BarEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsStacked;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsStacked {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarEntry']/method[@name='isStacked' and count(parameter)=0]"
			[Register ("isStacked", "()Z", "GetIsStackedHandler")]
			get {
				const string __id = "isStacked.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getNegativeSum;
#pragma warning disable 0169
		static Delegate GetGetNegativeSumHandler ()
		{
			if (cb_getNegativeSum == null)
				cb_getNegativeSum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetNegativeSum);
			return cb_getNegativeSum;
		}

		static float n_GetNegativeSum (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.BarEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NegativeSum;
		}
#pragma warning restore 0169

		public virtual unsafe float NegativeSum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarEntry']/method[@name='getNegativeSum' and count(parameter)=0]"
			[Register ("getNegativeSum", "()F", "GetGetNegativeSumHandler")]
			get {
				const string __id = "getNegativeSum.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getPositiveSum;
#pragma warning disable 0169
		static Delegate GetGetPositiveSumHandler ()
		{
			if (cb_getPositiveSum == null)
				cb_getPositiveSum = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetPositiveSum);
			return cb_getPositiveSum;
		}

		static float n_GetPositiveSum (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.BarEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PositiveSum;
		}
#pragma warning restore 0169

		public virtual unsafe float PositiveSum {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarEntry']/method[@name='getPositiveSum' and count(parameter)=0]"
			[Register ("getPositiveSum", "()F", "GetGetPositiveSumHandler")]
			get {
				const string __id = "getPositiveSum.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_calcRanges;
#pragma warning disable 0169
		static Delegate GetCalcRangesHandler ()
		{
			if (cb_calcRanges == null)
				cb_calcRanges = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_CalcRanges);
			return cb_calcRanges;
		}

		static void n_CalcRanges (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.BarEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CalcRanges ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarEntry']/method[@name='calcRanges' and count(parameter)=0]"
		[Register ("calcRanges", "()V", "GetCalcRangesHandler")]
		protected virtual unsafe void CalcRanges ()
		{
			const string __id = "calcRanges.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_getBelowSum_I;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetBelowSum_IHandler ()
		{
			if (cb_getBelowSum_I == null)
				cb_getBelowSum_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, float>) n_GetBelowSum_I);
			return cb_getBelowSum_I;
		}

		[Obsolete]
		static float n_GetBelowSum_I (IntPtr jnienv, IntPtr native__this, int stackIndex)
		{
			global::MikePhil.Charting.Data.BarEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetBelowSum (stackIndex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarEntry']/method[@name='getBelowSum' and count(parameter)=1 and parameter[1][@type='int']]"
		[Obsolete (@"deprecated")]
		[Register ("getBelowSum", "(I)F", "GetGetBelowSum_IHandler")]
		public virtual unsafe float GetBelowSum (int stackIndex)
		{
			const string __id = "getBelowSum.(I)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (stackIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getRanges;
#pragma warning disable 0169
		static Delegate GetGetRangesHandler ()
		{
			if (cb_getRanges == null)
				cb_getRanges = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRanges);
			return cb_getRanges;
		}

		static IntPtr n_GetRanges (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.BarEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRanges ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarEntry']/method[@name='getRanges' and count(parameter)=0]"
		[Register ("getRanges", "()[Lcom/github/mikephil/charting/highlight/Range;", "GetGetRangesHandler")]
		public virtual unsafe global::MikePhil.Charting.Highlight.Range[] GetRanges ()
		{
			const string __id = "getRanges.()[Lcom/github/mikephil/charting/highlight/Range;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::MikePhil.Charting.Highlight.Range[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::MikePhil.Charting.Highlight.Range));
			} finally {
			}
		}

		static Delegate cb_getSumBelow_I;
#pragma warning disable 0169
		static Delegate GetGetSumBelow_IHandler ()
		{
			if (cb_getSumBelow_I == null)
				cb_getSumBelow_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, float>) n_GetSumBelow_I);
			return cb_getSumBelow_I;
		}

		static float n_GetSumBelow_I (IntPtr jnienv, IntPtr native__this, int stackIndex)
		{
			global::MikePhil.Charting.Data.BarEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetSumBelow (stackIndex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarEntry']/method[@name='getSumBelow' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getSumBelow", "(I)F", "GetGetSumBelow_IHandler")]
		public virtual unsafe float GetSumBelow (int stackIndex)
		{
			const string __id = "getSumBelow.(I)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (stackIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getYVals;
#pragma warning disable 0169
		static Delegate GetGetYValsHandler ()
		{
			if (cb_getYVals == null)
				cb_getYVals = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetYVals);
			return cb_getYVals;
		}

		static IntPtr n_GetYVals (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.BarEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetYVals ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarEntry']/method[@name='getYVals' and count(parameter)=0]"
		[Register ("getYVals", "()[F", "GetGetYValsHandler")]
		public virtual unsafe float[] GetYVals ()
		{
			const string __id = "getYVals.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_setVals_arrayF;
#pragma warning disable 0169
		static Delegate GetSetVals_arrayFHandler ()
		{
			if (cb_setVals_arrayF == null)
				cb_setVals_arrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVals_arrayF);
			return cb_setVals_arrayF;
		}

		static void n_SetVals_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_vals)
		{
			global::MikePhil.Charting.Data.BarEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] vals = (float[]) JNIEnv.GetArray (native_vals, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.SetVals (vals);
			if (vals != null)
				JNIEnv.CopyArray (vals, native_vals);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='BarEntry']/method[@name='setVals' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("setVals", "([F)V", "GetSetVals_arrayFHandler")]
		public virtual unsafe void SetVals (float[] vals)
		{
			const string __id = "setVals.([F)V";
			IntPtr native_vals = JNIEnv.NewArray (vals);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_vals);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (vals != null) {
					JNIEnv.CopyArray (native_vals, vals);
					JNIEnv.DeleteLocalRef (native_vals);
				}
			}
		}

	}
}
