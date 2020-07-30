using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Charts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/charts/CombinedChart", DoNotGenerateAcw=true)]
	public partial class CombinedChart : global::MikePhil.Charting.Charts.BarLineChartBase, global::MikePhil.Charting.Interfaces.Dataprovider.ICombinedDataProvider {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart']/field[@name='mDrawOrder']"
		[Register ("mDrawOrder")]
		protected IList<MikePhil.Charting.Charts.CombinedChart.DrawOrder> MDrawOrder {
			get {
				const string __id = "mDrawOrder.[Lcom/github/mikephil/charting/charts/CombinedChart$DrawOrder;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<global::MikePhil.Charting.Charts.CombinedChart.DrawOrder>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mDrawOrder.[Lcom/github/mikephil/charting/charts/CombinedChart$DrawOrder;";

				IntPtr native_value = global::Android.Runtime.JavaArray<global::MikePhil.Charting.Charts.CombinedChart.DrawOrder>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart']/field[@name='mHighlightFullBarEnabled']"
		[Register ("mHighlightFullBarEnabled")]
		protected bool MHighlightFullBarEnabled {
			get {
				const string __id = "mHighlightFullBarEnabled.Z";

				var __v = _members.InstanceFields.GetBooleanValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mHighlightFullBarEnabled.Z";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart.DrawOrder']"
		[global::Android.Runtime.Register ("com/github/mikephil/charting/charts/CombinedChart$DrawOrder", DoNotGenerateAcw=true)]
		public sealed partial class DrawOrder : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart.DrawOrder']/field[@name='BAR']"
			[Register ("BAR")]
			public static global::MikePhil.Charting.Charts.CombinedChart.DrawOrder Bar {
				get {
					const string __id = "BAR.Lcom/github/mikephil/charting/charts/CombinedChart$DrawOrder;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.CombinedChart.DrawOrder> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart.DrawOrder']/field[@name='BUBBLE']"
			[Register ("BUBBLE")]
			public static global::MikePhil.Charting.Charts.CombinedChart.DrawOrder Bubble {
				get {
					const string __id = "BUBBLE.Lcom/github/mikephil/charting/charts/CombinedChart$DrawOrder;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.CombinedChart.DrawOrder> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart.DrawOrder']/field[@name='CANDLE']"
			[Register ("CANDLE")]
			public static global::MikePhil.Charting.Charts.CombinedChart.DrawOrder Candle {
				get {
					const string __id = "CANDLE.Lcom/github/mikephil/charting/charts/CombinedChart$DrawOrder;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.CombinedChart.DrawOrder> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart.DrawOrder']/field[@name='LINE']"
			[Register ("LINE")]
			public static global::MikePhil.Charting.Charts.CombinedChart.DrawOrder Line {
				get {
					const string __id = "LINE.Lcom/github/mikephil/charting/charts/CombinedChart$DrawOrder;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.CombinedChart.DrawOrder> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart.DrawOrder']/field[@name='SCATTER']"
			[Register ("SCATTER")]
			public static global::MikePhil.Charting.Charts.CombinedChart.DrawOrder Scatter {
				get {
					const string __id = "SCATTER.Lcom/github/mikephil/charting/charts/CombinedChart$DrawOrder;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.CombinedChart.DrawOrder> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/charts/CombinedChart$DrawOrder", typeof (DrawOrder));
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

			internal DrawOrder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart.DrawOrder']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/github/mikephil/charting/charts/CombinedChart$DrawOrder;", "")]
			public static unsafe global::MikePhil.Charting.Charts.CombinedChart.DrawOrder ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/github/mikephil/charting/charts/CombinedChart$DrawOrder;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.CombinedChart.DrawOrder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart.DrawOrder']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/github/mikephil/charting/charts/CombinedChart$DrawOrder;", "")]
			public static unsafe global::MikePhil.Charting.Charts.CombinedChart.DrawOrder[] Values ()
			{
				const string __id = "values.()[Lcom/github/mikephil/charting/charts/CombinedChart$DrawOrder;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::MikePhil.Charting.Charts.CombinedChart.DrawOrder[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::MikePhil.Charting.Charts.CombinedChart.DrawOrder));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/charts/CombinedChart", typeof (CombinedChart));
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

		protected CombinedChart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart']/constructor[@name='CombinedChart' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe CombinedChart (global::Android.Content.Context context)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart']/constructor[@name='CombinedChart' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe CombinedChart (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart']/constructor[@name='CombinedChart' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe CombinedChart (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/Context;Landroid/util/AttributeSet;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue ((attrs == null) ? IntPtr.Zero : ((global::Java.Lang.Object) attrs).Handle);
				__args [2] = new JniArgumentValue (defStyle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getBarData;
#pragma warning disable 0169
		static Delegate GetGetBarDataHandler ()
		{
			if (cb_getBarData == null)
				cb_getBarData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBarData);
			return cb_getBarData;
		}

		static IntPtr n_GetBarData (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.CombinedChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.CombinedChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BarData);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Data.BarData BarData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart']/method[@name='getBarData' and count(parameter)=0]"
			[Register ("getBarData", "()Lcom/github/mikephil/charting/data/BarData;", "GetGetBarDataHandler")]
			get {
				const string __id = "getBarData.()Lcom/github/mikephil/charting/data/BarData;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BarData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getBubbleData;
#pragma warning disable 0169
		static Delegate GetGetBubbleDataHandler ()
		{
			if (cb_getBubbleData == null)
				cb_getBubbleData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBubbleData);
			return cb_getBubbleData;
		}

		static IntPtr n_GetBubbleData (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.CombinedChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.CombinedChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.BubbleData);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Data.BubbleData BubbleData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart']/method[@name='getBubbleData' and count(parameter)=0]"
			[Register ("getBubbleData", "()Lcom/github/mikephil/charting/data/BubbleData;", "GetGetBubbleDataHandler")]
			get {
				const string __id = "getBubbleData.()Lcom/github/mikephil/charting/data/BubbleData;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.BubbleData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCandleData;
#pragma warning disable 0169
		static Delegate GetGetCandleDataHandler ()
		{
			if (cb_getCandleData == null)
				cb_getCandleData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCandleData);
			return cb_getCandleData;
		}

		static IntPtr n_GetCandleData (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.CombinedChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.CombinedChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CandleData);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Data.CandleData CandleData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart']/method[@name='getCandleData' and count(parameter)=0]"
			[Register ("getCandleData", "()Lcom/github/mikephil/charting/data/CandleData;", "GetGetCandleDataHandler")]
			get {
				const string __id = "getCandleData.()Lcom/github/mikephil/charting/data/CandleData;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CandleData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCombinedData;
#pragma warning disable 0169
		static Delegate GetGetCombinedDataHandler ()
		{
			if (cb_getCombinedData == null)
				cb_getCombinedData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCombinedData);
			return cb_getCombinedData;
		}

		static IntPtr n_GetCombinedData (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.CombinedChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.CombinedChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CombinedData);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Data.CombinedData CombinedData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart']/method[@name='getCombinedData' and count(parameter)=0]"
			[Register ("getCombinedData", "()Lcom/github/mikephil/charting/data/CombinedData;", "GetGetCombinedDataHandler")]
			get {
				const string __id = "getCombinedData.()Lcom/github/mikephil/charting/data/CombinedData;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CombinedData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isDrawBarShadowEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawBarShadowEnabledHandler ()
		{
			if (cb_isDrawBarShadowEnabled == null)
				cb_isDrawBarShadowEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawBarShadowEnabled);
			return cb_isDrawBarShadowEnabled;
		}

		static bool n_IsDrawBarShadowEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.CombinedChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.CombinedChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawBarShadowEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrawBarShadowEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart']/method[@name='isDrawBarShadowEnabled' and count(parameter)=0]"
			[Register ("isDrawBarShadowEnabled", "()Z", "GetIsDrawBarShadowEnabledHandler")]
			get {
				const string __id = "isDrawBarShadowEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDrawValueAboveBarEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawValueAboveBarEnabledHandler ()
		{
			if (cb_isDrawValueAboveBarEnabled == null)
				cb_isDrawValueAboveBarEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawValueAboveBarEnabled);
			return cb_isDrawValueAboveBarEnabled;
		}

		static bool n_IsDrawValueAboveBarEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.CombinedChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.CombinedChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawValueAboveBarEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrawValueAboveBarEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart']/method[@name='isDrawValueAboveBarEnabled' and count(parameter)=0]"
			[Register ("isDrawValueAboveBarEnabled", "()Z", "GetIsDrawValueAboveBarEnabledHandler")]
			get {
				const string __id = "isDrawValueAboveBarEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isHighlightFullBarEnabled;
#pragma warning disable 0169
		static Delegate GetIsHighlightFullBarEnabledHandler ()
		{
			if (cb_isHighlightFullBarEnabled == null)
				cb_isHighlightFullBarEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHighlightFullBarEnabled);
			return cb_isHighlightFullBarEnabled;
		}

		static bool n_IsHighlightFullBarEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.CombinedChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.CombinedChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHighlightFullBarEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsHighlightFullBarEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart']/method[@name='isHighlightFullBarEnabled' and count(parameter)=0]"
			[Register ("isHighlightFullBarEnabled", "()Z", "GetIsHighlightFullBarEnabledHandler")]
			get {
				const string __id = "isHighlightFullBarEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getLineData;
#pragma warning disable 0169
		static Delegate GetGetLineDataHandler ()
		{
			if (cb_getLineData == null)
				cb_getLineData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLineData);
			return cb_getLineData;
		}

		static IntPtr n_GetLineData (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.CombinedChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.CombinedChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.LineData);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Data.LineData LineData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart']/method[@name='getLineData' and count(parameter)=0]"
			[Register ("getLineData", "()Lcom/github/mikephil/charting/data/LineData;", "GetGetLineDataHandler")]
			get {
				const string __id = "getLineData.()Lcom/github/mikephil/charting/data/LineData;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.LineData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getScatterData;
#pragma warning disable 0169
		static Delegate GetGetScatterDataHandler ()
		{
			if (cb_getScatterData == null)
				cb_getScatterData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetScatterData);
			return cb_getScatterData;
		}

		static IntPtr n_GetScatterData (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.CombinedChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.CombinedChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScatterData);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Data.ScatterData ScatterData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart']/method[@name='getScatterData' and count(parameter)=0]"
			[Register ("getScatterData", "()Lcom/github/mikephil/charting/data/ScatterData;", "GetGetScatterDataHandler")]
			get {
				const string __id = "getScatterData.()Lcom/github/mikephil/charting/data/ScatterData;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.ScatterData> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDrawOrder;
#pragma warning disable 0169
		static Delegate GetGetDrawOrderHandler ()
		{
			if (cb_getDrawOrder == null)
				cb_getDrawOrder = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDrawOrder);
			return cb_getDrawOrder;
		}

		static IntPtr n_GetDrawOrder (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.CombinedChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.CombinedChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDrawOrder ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart']/method[@name='getDrawOrder' and count(parameter)=0]"
		[Register ("getDrawOrder", "()[Lcom/github/mikephil/charting/charts/CombinedChart$DrawOrder;", "GetGetDrawOrderHandler")]
		public virtual unsafe global::MikePhil.Charting.Charts.CombinedChart.DrawOrder[] GetDrawOrder ()
		{
			const string __id = "getDrawOrder.()[Lcom/github/mikephil/charting/charts/CombinedChart$DrawOrder;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::MikePhil.Charting.Charts.CombinedChart.DrawOrder[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::MikePhil.Charting.Charts.CombinedChart.DrawOrder));
			} finally {
			}
		}

		static Delegate cb_setData_Lcom_github_mikephil_charting_data_CombinedData_;
#pragma warning disable 0169
		static Delegate GetSetData_Lcom_github_mikephil_charting_data_CombinedData_Handler ()
		{
			if (cb_setData_Lcom_github_mikephil_charting_data_CombinedData_ == null)
				cb_setData_Lcom_github_mikephil_charting_data_CombinedData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetData_Lcom_github_mikephil_charting_data_CombinedData_);
			return cb_setData_Lcom_github_mikephil_charting_data_CombinedData_;
		}

		static void n_SetData_Lcom_github_mikephil_charting_data_CombinedData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_data)
		{
			global::MikePhil.Charting.Charts.CombinedChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.CombinedChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Data.CombinedData data = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.CombinedData> (native_data, JniHandleOwnership.DoNotTransfer);
			__this.SetData (data);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart']/method[@name='setData' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.data.CombinedData']]"
		[Register ("setData", "(Lcom/github/mikephil/charting/data/CombinedData;)V", "GetSetData_Lcom_github_mikephil_charting_data_CombinedData_Handler")]
		public virtual unsafe void SetData (global::MikePhil.Charting.Data.CombinedData data)
		{
			const string __id = "setData.(Lcom/github/mikephil/charting/data/CombinedData;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawBarShadow_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawBarShadow_ZHandler ()
		{
			if (cb_setDrawBarShadow_Z == null)
				cb_setDrawBarShadow_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawBarShadow_Z);
			return cb_setDrawBarShadow_Z;
		}

		static void n_SetDrawBarShadow_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.CombinedChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.CombinedChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawBarShadow (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart']/method[@name='setDrawBarShadow' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawBarShadow", "(Z)V", "GetSetDrawBarShadow_ZHandler")]
		public virtual unsafe void SetDrawBarShadow (bool enabled)
		{
			const string __id = "setDrawBarShadow.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawOrder_arrayLcom_github_mikephil_charting_charts_CombinedChart_DrawOrder_;
#pragma warning disable 0169
		static Delegate GetSetDrawOrder_arrayLcom_github_mikephil_charting_charts_CombinedChart_DrawOrder_Handler ()
		{
			if (cb_setDrawOrder_arrayLcom_github_mikephil_charting_charts_CombinedChart_DrawOrder_ == null)
				cb_setDrawOrder_arrayLcom_github_mikephil_charting_charts_CombinedChart_DrawOrder_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDrawOrder_arrayLcom_github_mikephil_charting_charts_CombinedChart_DrawOrder_);
			return cb_setDrawOrder_arrayLcom_github_mikephil_charting_charts_CombinedChart_DrawOrder_;
		}

		static void n_SetDrawOrder_arrayLcom_github_mikephil_charting_charts_CombinedChart_DrawOrder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_order)
		{
			global::MikePhil.Charting.Charts.CombinedChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.CombinedChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Charts.CombinedChart.DrawOrder[] order = (global::MikePhil.Charting.Charts.CombinedChart.DrawOrder[]) JNIEnv.GetArray (native_order, JniHandleOwnership.DoNotTransfer, typeof (global::MikePhil.Charting.Charts.CombinedChart.DrawOrder));
			__this.SetDrawOrder (order);
			if (order != null)
				JNIEnv.CopyArray (order, native_order);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart']/method[@name='setDrawOrder' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.charts.CombinedChart.DrawOrder[]']]"
		[Register ("setDrawOrder", "([Lcom/github/mikephil/charting/charts/CombinedChart$DrawOrder;)V", "GetSetDrawOrder_arrayLcom_github_mikephil_charting_charts_CombinedChart_DrawOrder_Handler")]
		public virtual unsafe void SetDrawOrder (global::MikePhil.Charting.Charts.CombinedChart.DrawOrder[] order)
		{
			const string __id = "setDrawOrder.([Lcom/github/mikephil/charting/charts/CombinedChart$DrawOrder;)V";
			IntPtr native_order = JNIEnv.NewArray (order);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_order);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (order != null) {
					JNIEnv.CopyArray (native_order, order);
					JNIEnv.DeleteLocalRef (native_order);
				}
			}
		}

		static Delegate cb_setDrawValueAboveBar_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawValueAboveBar_ZHandler ()
		{
			if (cb_setDrawValueAboveBar_Z == null)
				cb_setDrawValueAboveBar_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawValueAboveBar_Z);
			return cb_setDrawValueAboveBar_Z;
		}

		static void n_SetDrawValueAboveBar_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.CombinedChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.CombinedChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawValueAboveBar (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart']/method[@name='setDrawValueAboveBar' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawValueAboveBar", "(Z)V", "GetSetDrawValueAboveBar_ZHandler")]
		public virtual unsafe void SetDrawValueAboveBar (bool enabled)
		{
			const string __id = "setDrawValueAboveBar.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setHighlightFullBarEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetHighlightFullBarEnabled_ZHandler ()
		{
			if (cb_setHighlightFullBarEnabled_Z == null)
				cb_setHighlightFullBarEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetHighlightFullBarEnabled_Z);
			return cb_setHighlightFullBarEnabled_Z;
		}

		static void n_SetHighlightFullBarEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.CombinedChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.CombinedChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHighlightFullBarEnabled (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='CombinedChart']/method[@name='setHighlightFullBarEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setHighlightFullBarEnabled", "(Z)V", "GetSetHighlightFullBarEnabled_ZHandler")]
		public virtual unsafe void SetHighlightFullBarEnabled (bool enabled)
		{
			const string __id = "setHighlightFullBarEnabled.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
