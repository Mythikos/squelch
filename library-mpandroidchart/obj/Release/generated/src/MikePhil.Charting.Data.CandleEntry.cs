using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleEntry']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/CandleEntry", DoNotGenerateAcw=true)]
	public partial class CandleEntry : global::MikePhil.Charting.Data.Entry {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/CandleEntry", typeof (CandleEntry));
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

		protected CandleEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleEntry']/constructor[@name='CandleEntry' and count(parameter)=5 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float']]"
		[Register (".ctor", "(FFFFF)V", "")]
		public unsafe CandleEntry (float x, float shadowH, float shadowL, float open, float close)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FFFFF)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (shadowH);
				__args [2] = new JniArgumentValue (shadowL);
				__args [3] = new JniArgumentValue (open);
				__args [4] = new JniArgumentValue (close);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleEntry']/constructor[@name='CandleEntry' and count(parameter)=6 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='android.graphics.drawable.Drawable']]"
		[Register (".ctor", "(FFFFFLandroid/graphics/drawable/Drawable;)V", "")]
		public unsafe CandleEntry (float x, float shadowH, float shadowL, float open, float close, global::Android.Graphics.Drawables.Drawable icon)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FFFFFLandroid/graphics/drawable/Drawable;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (shadowH);
				__args [2] = new JniArgumentValue (shadowL);
				__args [3] = new JniArgumentValue (open);
				__args [4] = new JniArgumentValue (close);
				__args [5] = new JniArgumentValue ((icon == null) ? IntPtr.Zero : ((global::Java.Lang.Object) icon).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleEntry']/constructor[@name='CandleEntry' and count(parameter)=7 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='android.graphics.drawable.Drawable'] and parameter[7][@type='java.lang.Object']]"
		[Register (".ctor", "(FFFFFLandroid/graphics/drawable/Drawable;Ljava/lang/Object;)V", "")]
		public unsafe CandleEntry (float x, float shadowH, float shadowL, float open, float close, global::Android.Graphics.Drawables.Drawable icon, global::Java.Lang.Object data)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FFFFFLandroid/graphics/drawable/Drawable;Ljava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (shadowH);
				__args [2] = new JniArgumentValue (shadowL);
				__args [3] = new JniArgumentValue (open);
				__args [4] = new JniArgumentValue (close);
				__args [5] = new JniArgumentValue ((icon == null) ? IntPtr.Zero : ((global::Java.Lang.Object) icon).Handle);
				__args [6] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleEntry']/constructor[@name='CandleEntry' and count(parameter)=6 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='java.lang.Object']]"
		[Register (".ctor", "(FFFFFLjava/lang/Object;)V", "")]
		public unsafe CandleEntry (float x, float shadowH, float shadowL, float open, float close, global::Java.Lang.Object data)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FFFFFLjava/lang/Object;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (shadowH);
				__args [2] = new JniArgumentValue (shadowL);
				__args [3] = new JniArgumentValue (open);
				__args [4] = new JniArgumentValue (close);
				__args [5] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getBodyRange;
#pragma warning disable 0169
		static Delegate GetGetBodyRangeHandler ()
		{
			if (cb_getBodyRange == null)
				cb_getBodyRange = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetBodyRange);
			return cb_getBodyRange;
		}

		static float n_GetBodyRange (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.CandleEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BodyRange;
		}
#pragma warning restore 0169

		public virtual unsafe float BodyRange {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleEntry']/method[@name='getBodyRange' and count(parameter)=0]"
			[Register ("getBodyRange", "()F", "GetGetBodyRangeHandler")]
			get {
				const string __id = "getBodyRange.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getClose;
#pragma warning disable 0169
		static Delegate GetGetCloseHandler ()
		{
			if (cb_getClose == null)
				cb_getClose = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetClose);
			return cb_getClose;
		}

		static float n_GetClose (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.CandleEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Close;
		}
#pragma warning restore 0169

		static Delegate cb_setClose_F;
#pragma warning disable 0169
		static Delegate GetSetClose_FHandler ()
		{
			if (cb_setClose_F == null)
				cb_setClose_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetClose_F);
			return cb_setClose_F;
		}

		static void n_SetClose_F (IntPtr jnienv, IntPtr native__this, float mClose)
		{
			global::MikePhil.Charting.Data.CandleEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Close = mClose;
		}
#pragma warning restore 0169

		public virtual unsafe float Close {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleEntry']/method[@name='getClose' and count(parameter)=0]"
			[Register ("getClose", "()F", "GetGetCloseHandler")]
			get {
				const string __id = "getClose.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleEntry']/method[@name='setClose' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setClose", "(F)V", "GetSetClose_FHandler")]
			set {
				const string __id = "setClose.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHigh;
#pragma warning disable 0169
		static Delegate GetGetHighHandler ()
		{
			if (cb_getHigh == null)
				cb_getHigh = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetHigh);
			return cb_getHigh;
		}

		static float n_GetHigh (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.CandleEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.High;
		}
#pragma warning restore 0169

		static Delegate cb_setHigh_F;
#pragma warning disable 0169
		static Delegate GetSetHigh_FHandler ()
		{
			if (cb_setHigh_F == null)
				cb_setHigh_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetHigh_F);
			return cb_setHigh_F;
		}

		static void n_SetHigh_F (IntPtr jnienv, IntPtr native__this, float mShadowHigh)
		{
			global::MikePhil.Charting.Data.CandleEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.High = mShadowHigh;
		}
#pragma warning restore 0169

		public virtual unsafe float High {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleEntry']/method[@name='getHigh' and count(parameter)=0]"
			[Register ("getHigh", "()F", "GetGetHighHandler")]
			get {
				const string __id = "getHigh.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleEntry']/method[@name='setHigh' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setHigh", "(F)V", "GetSetHigh_FHandler")]
			set {
				const string __id = "setHigh.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getLow;
#pragma warning disable 0169
		static Delegate GetGetLowHandler ()
		{
			if (cb_getLow == null)
				cb_getLow = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetLow);
			return cb_getLow;
		}

		static float n_GetLow (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.CandleEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Low;
		}
#pragma warning restore 0169

		static Delegate cb_setLow_F;
#pragma warning disable 0169
		static Delegate GetSetLow_FHandler ()
		{
			if (cb_setLow_F == null)
				cb_setLow_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetLow_F);
			return cb_setLow_F;
		}

		static void n_SetLow_F (IntPtr jnienv, IntPtr native__this, float mShadowLow)
		{
			global::MikePhil.Charting.Data.CandleEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Low = mShadowLow;
		}
#pragma warning restore 0169

		public virtual unsafe float Low {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleEntry']/method[@name='getLow' and count(parameter)=0]"
			[Register ("getLow", "()F", "GetGetLowHandler")]
			get {
				const string __id = "getLow.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleEntry']/method[@name='setLow' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setLow", "(F)V", "GetSetLow_FHandler")]
			set {
				const string __id = "setLow.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOpen;
#pragma warning disable 0169
		static Delegate GetGetOpenHandler ()
		{
			if (cb_getOpen == null)
				cb_getOpen = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetOpen);
			return cb_getOpen;
		}

		static float n_GetOpen (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.CandleEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Open;
		}
#pragma warning restore 0169

		static Delegate cb_setOpen_F;
#pragma warning disable 0169
		static Delegate GetSetOpen_FHandler ()
		{
			if (cb_setOpen_F == null)
				cb_setOpen_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetOpen_F);
			return cb_setOpen_F;
		}

		static void n_SetOpen_F (IntPtr jnienv, IntPtr native__this, float mOpen)
		{
			global::MikePhil.Charting.Data.CandleEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Open = mOpen;
		}
#pragma warning restore 0169

		public virtual unsafe float Open {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleEntry']/method[@name='getOpen' and count(parameter)=0]"
			[Register ("getOpen", "()F", "GetGetOpenHandler")]
			get {
				const string __id = "getOpen.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleEntry']/method[@name='setOpen' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setOpen", "(F)V", "GetSetOpen_FHandler")]
			set {
				const string __id = "setOpen.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getShadowRange;
#pragma warning disable 0169
		static Delegate GetGetShadowRangeHandler ()
		{
			if (cb_getShadowRange == null)
				cb_getShadowRange = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetShadowRange);
			return cb_getShadowRange;
		}

		static float n_GetShadowRange (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Data.CandleEntry __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleEntry> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ShadowRange;
		}
#pragma warning restore 0169

		public virtual unsafe float ShadowRange {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data']/class[@name='CandleEntry']/method[@name='getShadowRange' and count(parameter)=0]"
			[Register ("getShadowRange", "()F", "GetGetShadowRangeHandler")]
			get {
				const string __id = "getShadowRange.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
