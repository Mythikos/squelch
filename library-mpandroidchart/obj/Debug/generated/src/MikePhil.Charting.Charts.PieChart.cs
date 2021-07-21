using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Charts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/charts/PieChart", DoNotGenerateAcw=true)]
	public partial class PieChart : global::MikePhil.Charting.Charts.PieRadarChartBase {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/field[@name='mMaxAngle']"
		[Register ("mMaxAngle")]
		protected float MMaxAngle {
			get {
				const string __id = "mMaxAngle.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mMaxAngle.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/field[@name='mTransparentCircleRadiusPercent']"
		[Register ("mTransparentCircleRadiusPercent")]
		protected float MTransparentCircleRadiusPercent {
			get {
				const string __id = "mTransparentCircleRadiusPercent.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mTransparentCircleRadiusPercent.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/charts/PieChart", typeof (PieChart));
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

		protected PieChart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/constructor[@name='PieChart' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe PieChart (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/constructor[@name='PieChart' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe PieChart (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/constructor[@name='PieChart' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe PieChart (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle)
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

		static Delegate cb_getCenterCircleBox;
#pragma warning disable 0169
		static Delegate GetGetCenterCircleBoxHandler ()
		{
			if (cb_getCenterCircleBox == null)
				cb_getCenterCircleBox = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCenterCircleBox);
			return cb_getCenterCircleBox;
		}

		static IntPtr n_GetCenterCircleBox (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CenterCircleBox);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Util.MPPointF CenterCircleBox {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='getCenterCircleBox' and count(parameter)=0]"
			[Register ("getCenterCircleBox", "()Lcom/github/mikephil/charting/utils/MPPointF;", "GetGetCenterCircleBoxHandler")]
			get {
				const string __id = "getCenterCircleBox.()Lcom/github/mikephil/charting/utils/MPPointF;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCenterText;
#pragma warning disable 0169
		static Delegate GetGetCenterTextHandler ()
		{
			if (cb_getCenterText == null)
				cb_getCenterText = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCenterText);
			return cb_getCenterText;
		}

		static IntPtr n_GetCenterText (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return CharSequence.ToLocalJniHandle (__this.CenterTextFormatted);
		}
#pragma warning restore 0169

		static Delegate cb_setCenterText_Ljava_lang_CharSequence_;
#pragma warning disable 0169
		static Delegate GetSetCenterText_Ljava_lang_CharSequence_Handler ()
		{
			if (cb_setCenterText_Ljava_lang_CharSequence_ == null)
				cb_setCenterText_Ljava_lang_CharSequence_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCenterText_Ljava_lang_CharSequence_);
			return cb_setCenterText_Ljava_lang_CharSequence_;
		}

		static void n_SetCenterText_Ljava_lang_CharSequence_ (IntPtr jnienv, IntPtr native__this, IntPtr native_text)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.ICharSequence text = global::Java.Lang.Object.GetObject<global::Java.Lang.ICharSequence> (native_text, JniHandleOwnership.DoNotTransfer);
			__this.CenterTextFormatted = text;
		}
#pragma warning restore 0169

		public virtual unsafe global::Java.Lang.ICharSequence CenterTextFormatted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='getCenterText' and count(parameter)=0]"
			[Register ("getCenterText", "()Ljava/lang/CharSequence;", "GetGetCenterTextHandler")]
			get {
				const string __id = "getCenterText.()Ljava/lang/CharSequence;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<Java.Lang.ICharSequence> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='setCenterText' and count(parameter)=1 and parameter[1][@type='java.lang.CharSequence']]"
			[Register ("setCenterText", "(Ljava/lang/CharSequence;)V", "GetSetCenterText_Ljava_lang_CharSequence_Handler")]
			set {
				const string __id = "setCenterText.(Ljava/lang/CharSequence;)V";
				IntPtr native_value = CharSequence.ToLocalJniHandle (value);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		public string CenterText {
			get { return CenterTextFormatted == null ? null : CenterTextFormatted.ToString (); }
			set {
				global::Java.Lang.String jls = value == null ? null : new global::Java.Lang.String (value);
				CenterTextFormatted = jls;
				if (jls != null) jls.Dispose ();
			}
		}

		static Delegate cb_getCenterTextOffset;
#pragma warning disable 0169
		static Delegate GetGetCenterTextOffsetHandler ()
		{
			if (cb_getCenterTextOffset == null)
				cb_getCenterTextOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCenterTextOffset);
			return cb_getCenterTextOffset;
		}

		static IntPtr n_GetCenterTextOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CenterTextOffset);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Util.MPPointF CenterTextOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='getCenterTextOffset' and count(parameter)=0]"
			[Register ("getCenterTextOffset", "()Lcom/github/mikephil/charting/utils/MPPointF;", "GetGetCenterTextOffsetHandler")]
			get {
				const string __id = "getCenterTextOffset.()Lcom/github/mikephil/charting/utils/MPPointF;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCenterTextRadiusPercent;
#pragma warning disable 0169
		static Delegate GetGetCenterTextRadiusPercentHandler ()
		{
			if (cb_getCenterTextRadiusPercent == null)
				cb_getCenterTextRadiusPercent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetCenterTextRadiusPercent);
			return cb_getCenterTextRadiusPercent;
		}

		static float n_GetCenterTextRadiusPercent (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CenterTextRadiusPercent;
		}
#pragma warning restore 0169

		static Delegate cb_setCenterTextRadiusPercent_F;
#pragma warning disable 0169
		static Delegate GetSetCenterTextRadiusPercent_FHandler ()
		{
			if (cb_setCenterTextRadiusPercent_F == null)
				cb_setCenterTextRadiusPercent_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetCenterTextRadiusPercent_F);
			return cb_setCenterTextRadiusPercent_F;
		}

		static void n_SetCenterTextRadiusPercent_F (IntPtr jnienv, IntPtr native__this, float percent)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.CenterTextRadiusPercent = percent;
		}
#pragma warning restore 0169

		public virtual unsafe float CenterTextRadiusPercent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='getCenterTextRadiusPercent' and count(parameter)=0]"
			[Register ("getCenterTextRadiusPercent", "()F", "GetGetCenterTextRadiusPercentHandler")]
			get {
				const string __id = "getCenterTextRadiusPercent.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='setCenterTextRadiusPercent' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setCenterTextRadiusPercent", "(F)V", "GetSetCenterTextRadiusPercent_FHandler")]
			set {
				const string __id = "setCenterTextRadiusPercent.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getCircleBox;
#pragma warning disable 0169
		static Delegate GetGetCircleBoxHandler ()
		{
			if (cb_getCircleBox == null)
				cb_getCircleBox = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCircleBox);
			return cb_getCircleBox;
		}

		static IntPtr n_GetCircleBox (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.CircleBox);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.RectF CircleBox {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='getCircleBox' and count(parameter)=0]"
			[Register ("getCircleBox", "()Landroid/graphics/RectF;", "GetGetCircleBoxHandler")]
			get {
				const string __id = "getCircleBox.()Landroid/graphics/RectF;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isDrawHoleEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawHoleEnabledHandler ()
		{
			if (cb_isDrawHoleEnabled == null)
				cb_isDrawHoleEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawHoleEnabled);
			return cb_isDrawHoleEnabled;
		}

		static bool n_IsDrawHoleEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DrawHoleEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setDrawHoleEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawHoleEnabled_ZHandler ()
		{
			if (cb_setDrawHoleEnabled_Z == null)
				cb_setDrawHoleEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawHoleEnabled_Z);
			return cb_setDrawHoleEnabled_Z;
		}

		static void n_SetDrawHoleEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.DrawHoleEnabled = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool DrawHoleEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='isDrawHoleEnabled' and count(parameter)=0]"
			[Register ("isDrawHoleEnabled", "()Z", "GetIsDrawHoleEnabledHandler")]
			get {
				const string __id = "isDrawHoleEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='setDrawHoleEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setDrawHoleEnabled", "(Z)V", "GetSetDrawHoleEnabled_ZHandler")]
			set {
				const string __id = "setDrawHoleEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHoleRadius;
#pragma warning disable 0169
		static Delegate GetGetHoleRadiusHandler ()
		{
			if (cb_getHoleRadius == null)
				cb_getHoleRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetHoleRadius);
			return cb_getHoleRadius;
		}

		static float n_GetHoleRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HoleRadius;
		}
#pragma warning restore 0169

		static Delegate cb_setHoleRadius_F;
#pragma warning disable 0169
		static Delegate GetSetHoleRadius_FHandler ()
		{
			if (cb_setHoleRadius_F == null)
				cb_setHoleRadius_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetHoleRadius_F);
			return cb_setHoleRadius_F;
		}

		static void n_SetHoleRadius_F (IntPtr jnienv, IntPtr native__this, float percent)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.HoleRadius = percent;
		}
#pragma warning restore 0169

		public virtual unsafe float HoleRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='getHoleRadius' and count(parameter)=0]"
			[Register ("getHoleRadius", "()F", "GetGetHoleRadiusHandler")]
			get {
				const string __id = "getHoleRadius.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='setHoleRadius' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setHoleRadius", "(F)V", "GetSetHoleRadius_FHandler")]
			set {
				const string __id = "setHoleRadius.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDrawCenterTextEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawCenterTextEnabledHandler ()
		{
			if (cb_isDrawCenterTextEnabled == null)
				cb_isDrawCenterTextEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawCenterTextEnabled);
			return cb_isDrawCenterTextEnabled;
		}

		static bool n_IsDrawCenterTextEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawCenterTextEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrawCenterTextEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='isDrawCenterTextEnabled' and count(parameter)=0]"
			[Register ("isDrawCenterTextEnabled", "()Z", "GetIsDrawCenterTextEnabledHandler")]
			get {
				const string __id = "isDrawCenterTextEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDrawEntryLabelsEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawEntryLabelsEnabledHandler ()
		{
			if (cb_isDrawEntryLabelsEnabled == null)
				cb_isDrawEntryLabelsEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawEntryLabelsEnabled);
			return cb_isDrawEntryLabelsEnabled;
		}

		static bool n_IsDrawEntryLabelsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawEntryLabelsEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrawEntryLabelsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='isDrawEntryLabelsEnabled' and count(parameter)=0]"
			[Register ("isDrawEntryLabelsEnabled", "()Z", "GetIsDrawEntryLabelsEnabledHandler")]
			get {
				const string __id = "isDrawEntryLabelsEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDrawRoundedSlicesEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawRoundedSlicesEnabledHandler ()
		{
			if (cb_isDrawRoundedSlicesEnabled == null)
				cb_isDrawRoundedSlicesEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawRoundedSlicesEnabled);
			return cb_isDrawRoundedSlicesEnabled;
		}

		static bool n_IsDrawRoundedSlicesEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawRoundedSlicesEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrawRoundedSlicesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='isDrawRoundedSlicesEnabled' and count(parameter)=0]"
			[Register ("isDrawRoundedSlicesEnabled", "()Z", "GetIsDrawRoundedSlicesEnabledHandler")]
			get {
				const string __id = "isDrawRoundedSlicesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isDrawSlicesUnderHoleEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawSlicesUnderHoleEnabledHandler ()
		{
			if (cb_isDrawSlicesUnderHoleEnabled == null)
				cb_isDrawSlicesUnderHoleEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawSlicesUnderHoleEnabled);
			return cb_isDrawSlicesUnderHoleEnabled;
		}

		static bool n_IsDrawSlicesUnderHoleEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawSlicesUnderHoleEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrawSlicesUnderHoleEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='isDrawSlicesUnderHoleEnabled' and count(parameter)=0]"
			[Register ("isDrawSlicesUnderHoleEnabled", "()Z", "GetIsDrawSlicesUnderHoleEnabledHandler")]
			get {
				const string __id = "isDrawSlicesUnderHoleEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isUsePercentValuesEnabled;
#pragma warning disable 0169
		static Delegate GetIsUsePercentValuesEnabledHandler ()
		{
			if (cb_isUsePercentValuesEnabled == null)
				cb_isUsePercentValuesEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsUsePercentValuesEnabled);
			return cb_isUsePercentValuesEnabled;
		}

		static bool n_IsUsePercentValuesEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsUsePercentValuesEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsUsePercentValuesEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='isUsePercentValuesEnabled' and count(parameter)=0]"
			[Register ("isUsePercentValuesEnabled", "()Z", "GetIsUsePercentValuesEnabledHandler")]
			get {
				const string __id = "isUsePercentValuesEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMaxAngle;
#pragma warning disable 0169
		static Delegate GetGetMaxAngleHandler ()
		{
			if (cb_getMaxAngle == null)
				cb_getMaxAngle = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMaxAngle);
			return cb_getMaxAngle;
		}

		static float n_GetMaxAngle (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxAngle;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxAngle_F;
#pragma warning disable 0169
		static Delegate GetSetMaxAngle_FHandler ()
		{
			if (cb_setMaxAngle_F == null)
				cb_setMaxAngle_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMaxAngle_F);
			return cb_setMaxAngle_F;
		}

		static void n_SetMaxAngle_F (IntPtr jnienv, IntPtr native__this, float maxangle)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxAngle = maxangle;
		}
#pragma warning restore 0169

		public virtual unsafe float MaxAngle {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='getMaxAngle' and count(parameter)=0]"
			[Register ("getMaxAngle", "()F", "GetGetMaxAngleHandler")]
			get {
				const string __id = "getMaxAngle.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='setMaxAngle' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMaxAngle", "(F)V", "GetSetMaxAngle_FHandler")]
			set {
				const string __id = "setMaxAngle.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getRadius;
#pragma warning disable 0169
		static Delegate GetGetRadiusHandler ()
		{
			if (cb_getRadius == null)
				cb_getRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetRadius);
			return cb_getRadius;
		}

		static float n_GetRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Radius;
		}
#pragma warning restore 0169

		public override unsafe float Radius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='getRadius' and count(parameter)=0]"
			[Register ("getRadius", "()F", "GetGetRadiusHandler")]
			get {
				const string __id = "getRadius.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRequiredBaseOffset;
#pragma warning disable 0169
		static Delegate GetGetRequiredBaseOffsetHandler ()
		{
			if (cb_getRequiredBaseOffset == null)
				cb_getRequiredBaseOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetRequiredBaseOffset);
			return cb_getRequiredBaseOffset;
		}

		static float n_GetRequiredBaseOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequiredBaseOffset;
		}
#pragma warning restore 0169

		protected override unsafe float RequiredBaseOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='getRequiredBaseOffset' and count(parameter)=0]"
			[Register ("getRequiredBaseOffset", "()F", "GetGetRequiredBaseOffsetHandler")]
			get {
				const string __id = "getRequiredBaseOffset.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getRequiredLegendOffset;
#pragma warning disable 0169
		static Delegate GetGetRequiredLegendOffsetHandler ()
		{
			if (cb_getRequiredLegendOffset == null)
				cb_getRequiredLegendOffset = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetRequiredLegendOffset);
			return cb_getRequiredLegendOffset;
		}

		static float n_GetRequiredLegendOffset (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequiredLegendOffset;
		}
#pragma warning restore 0169

		protected override unsafe float RequiredLegendOffset {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='getRequiredLegendOffset' and count(parameter)=0]"
			[Register ("getRequiredLegendOffset", "()F", "GetGetRequiredLegendOffsetHandler")]
			get {
				const string __id = "getRequiredLegendOffset.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getTransparentCircleRadius;
#pragma warning disable 0169
		static Delegate GetGetTransparentCircleRadiusHandler ()
		{
			if (cb_getTransparentCircleRadius == null)
				cb_getTransparentCircleRadius = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetTransparentCircleRadius);
			return cb_getTransparentCircleRadius;
		}

		static float n_GetTransparentCircleRadius (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.TransparentCircleRadius;
		}
#pragma warning restore 0169

		static Delegate cb_setTransparentCircleRadius_F;
#pragma warning disable 0169
		static Delegate GetSetTransparentCircleRadius_FHandler ()
		{
			if (cb_setTransparentCircleRadius_F == null)
				cb_setTransparentCircleRadius_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetTransparentCircleRadius_F);
			return cb_setTransparentCircleRadius_F;
		}

		static void n_SetTransparentCircleRadius_F (IntPtr jnienv, IntPtr native__this, float percent)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.TransparentCircleRadius = percent;
		}
#pragma warning restore 0169

		public virtual unsafe float TransparentCircleRadius {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='getTransparentCircleRadius' and count(parameter)=0]"
			[Register ("getTransparentCircleRadius", "()F", "GetGetTransparentCircleRadiusHandler")]
			get {
				const string __id = "getTransparentCircleRadius.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='setTransparentCircleRadius' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setTransparentCircleRadius", "(F)V", "GetSetTransparentCircleRadius_FHandler")]
			set {
				const string __id = "setTransparentCircleRadius.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getAbsoluteAngles;
#pragma warning disable 0169
		static Delegate GetGetAbsoluteAnglesHandler ()
		{
			if (cb_getAbsoluteAngles == null)
				cb_getAbsoluteAngles = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAbsoluteAngles);
			return cb_getAbsoluteAngles;
		}

		static IntPtr n_GetAbsoluteAngles (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetAbsoluteAngles ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='getAbsoluteAngles' and count(parameter)=0]"
		[Register ("getAbsoluteAngles", "()[F", "GetGetAbsoluteAnglesHandler")]
		public virtual unsafe float[] GetAbsoluteAngles ()
		{
			const string __id = "getAbsoluteAngles.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getDataSetIndexForIndex_I;
#pragma warning disable 0169
		static Delegate GetGetDataSetIndexForIndex_IHandler ()
		{
			if (cb_getDataSetIndexForIndex_I == null)
				cb_getDataSetIndexForIndex_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetDataSetIndexForIndex_I);
			return cb_getDataSetIndexForIndex_I;
		}

		static int n_GetDataSetIndexForIndex_I (IntPtr jnienv, IntPtr native__this, int xIndex)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetDataSetIndexForIndex (xIndex);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='getDataSetIndexForIndex' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDataSetIndexForIndex", "(I)I", "GetGetDataSetIndexForIndex_IHandler")]
		public virtual unsafe int GetDataSetIndexForIndex (int xIndex)
		{
			const string __id = "getDataSetIndexForIndex.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (xIndex);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getDrawAngles;
#pragma warning disable 0169
		static Delegate GetGetDrawAnglesHandler ()
		{
			if (cb_getDrawAngles == null)
				cb_getDrawAngles = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDrawAngles);
			return cb_getDrawAngles;
		}

		static IntPtr n_GetDrawAngles (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetDrawAngles ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='getDrawAngles' and count(parameter)=0]"
		[Register ("getDrawAngles", "()[F", "GetGetDrawAnglesHandler")]
		public virtual unsafe float[] GetDrawAngles ()
		{
			const string __id = "getDrawAngles.()[F";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getIndexForAngle_F;
#pragma warning disable 0169
		static Delegate GetGetIndexForAngle_FHandler ()
		{
			if (cb_getIndexForAngle_F == null)
				cb_getIndexForAngle_F = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, int>) n_GetIndexForAngle_F);
			return cb_getIndexForAngle_F;
		}

		static int n_GetIndexForAngle_F (IntPtr jnienv, IntPtr native__this, float angle)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetIndexForAngle (angle);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='getIndexForAngle' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getIndexForAngle", "(F)I", "GetGetIndexForAngle_FHandler")]
		public override unsafe int GetIndexForAngle (float angle)
		{
			const string __id = "getIndexForAngle.(F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (angle);
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_needsHighlight_I;
#pragma warning disable 0169
		static Delegate GetNeedsHighlight_IHandler ()
		{
			if (cb_needsHighlight_I == null)
				cb_needsHighlight_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, bool>) n_NeedsHighlight_I);
			return cb_needsHighlight_I;
		}

		static bool n_NeedsHighlight_I (IntPtr jnienv, IntPtr native__this, int index)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NeedsHighlight (index);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='needsHighlight' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("needsHighlight", "(I)Z", "GetNeedsHighlight_IHandler")]
		public virtual unsafe bool NeedsHighlight (int index)
		{
			const string __id = "needsHighlight.(I)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (index);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_setCenterTextColor_I;
#pragma warning disable 0169
		static Delegate GetSetCenterTextColor_IHandler ()
		{
			if (cb_setCenterTextColor_I == null)
				cb_setCenterTextColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetCenterTextColor_I);
			return cb_setCenterTextColor_I;
		}

		static void n_SetCenterTextColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCenterTextColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='setCenterTextColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setCenterTextColor", "(I)V", "GetSetCenterTextColor_IHandler")]
		public virtual unsafe void SetCenterTextColor (int color)
		{
			const string __id = "setCenterTextColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCenterTextOffset_FF;
#pragma warning disable 0169
		static Delegate GetSetCenterTextOffset_FFHandler ()
		{
			if (cb_setCenterTextOffset_FF == null)
				cb_setCenterTextOffset_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_SetCenterTextOffset_FF);
			return cb_setCenterTextOffset_FF;
		}

		static void n_SetCenterTextOffset_FF (IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCenterTextOffset (x, y);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='setCenterTextOffset' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setCenterTextOffset", "(FF)V", "GetSetCenterTextOffset_FFHandler")]
		public virtual unsafe void SetCenterTextOffset (float x, float y)
		{
			const string __id = "setCenterTextOffset.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCenterTextSize_F;
#pragma warning disable 0169
		static Delegate GetSetCenterTextSize_FHandler ()
		{
			if (cb_setCenterTextSize_F == null)
				cb_setCenterTextSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetCenterTextSize_F);
			return cb_setCenterTextSize_F;
		}

		static void n_SetCenterTextSize_F (IntPtr jnienv, IntPtr native__this, float sizeDp)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCenterTextSize (sizeDp);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='setCenterTextSize' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setCenterTextSize", "(F)V", "GetSetCenterTextSize_FHandler")]
		public virtual unsafe void SetCenterTextSize (float sizeDp)
		{
			const string __id = "setCenterTextSize.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sizeDp);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCenterTextSizePixels_F;
#pragma warning disable 0169
		static Delegate GetSetCenterTextSizePixels_FHandler ()
		{
			if (cb_setCenterTextSizePixels_F == null)
				cb_setCenterTextSizePixels_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetCenterTextSizePixels_F);
			return cb_setCenterTextSizePixels_F;
		}

		static void n_SetCenterTextSizePixels_F (IntPtr jnienv, IntPtr native__this, float sizePixels)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetCenterTextSizePixels (sizePixels);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='setCenterTextSizePixels' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setCenterTextSizePixels", "(F)V", "GetSetCenterTextSizePixels_FHandler")]
		public virtual unsafe void SetCenterTextSizePixels (float sizePixels)
		{
			const string __id = "setCenterTextSizePixels.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (sizePixels);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setCenterTextTypeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetSetCenterTextTypeface_Landroid_graphics_Typeface_Handler ()
		{
			if (cb_setCenterTextTypeface_Landroid_graphics_Typeface_ == null)
				cb_setCenterTextTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCenterTextTypeface_Landroid_graphics_Typeface_);
			return cb_setCenterTextTypeface_Landroid_graphics_Typeface_;
		}

		static void n_SetCenterTextTypeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_t)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Typeface t = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_t, JniHandleOwnership.DoNotTransfer);
			__this.SetCenterTextTypeface (t);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='setCenterTextTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
		[Register ("setCenterTextTypeface", "(Landroid/graphics/Typeface;)V", "GetSetCenterTextTypeface_Landroid_graphics_Typeface_Handler")]
		public virtual unsafe void SetCenterTextTypeface (global::Android.Graphics.Typeface t)
		{
			const string __id = "setCenterTextTypeface.(Landroid/graphics/Typeface;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((t == null) ? IntPtr.Zero : ((global::Java.Lang.Object) t).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawCenterText_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawCenterText_ZHandler ()
		{
			if (cb_setDrawCenterText_Z == null)
				cb_setDrawCenterText_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawCenterText_Z);
			return cb_setDrawCenterText_Z;
		}

		static void n_SetDrawCenterText_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawCenterText (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='setDrawCenterText' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawCenterText", "(Z)V", "GetSetDrawCenterText_ZHandler")]
		public virtual unsafe void SetDrawCenterText (bool enabled)
		{
			const string __id = "setDrawCenterText.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawEntryLabels_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawEntryLabels_ZHandler ()
		{
			if (cb_setDrawEntryLabels_Z == null)
				cb_setDrawEntryLabels_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawEntryLabels_Z);
			return cb_setDrawEntryLabels_Z;
		}

		static void n_SetDrawEntryLabels_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawEntryLabels (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='setDrawEntryLabels' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawEntryLabels", "(Z)V", "GetSetDrawEntryLabels_ZHandler")]
		public virtual unsafe void SetDrawEntryLabels (bool enabled)
		{
			const string __id = "setDrawEntryLabels.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawSliceText_Z;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetDrawSliceText_ZHandler ()
		{
			if (cb_setDrawSliceText_Z == null)
				cb_setDrawSliceText_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawSliceText_Z);
			return cb_setDrawSliceText_Z;
		}

		[Obsolete]
		static void n_SetDrawSliceText_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawSliceText (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='setDrawSliceText' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Obsolete (@"deprecated")]
		[Register ("setDrawSliceText", "(Z)V", "GetSetDrawSliceText_ZHandler")]
		public virtual unsafe void SetDrawSliceText (bool enabled)
		{
			const string __id = "setDrawSliceText.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setDrawSlicesUnderHole_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawSlicesUnderHole_ZHandler ()
		{
			if (cb_setDrawSlicesUnderHole_Z == null)
				cb_setDrawSlicesUnderHole_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawSlicesUnderHole_Z);
			return cb_setDrawSlicesUnderHole_Z;
		}

		static void n_SetDrawSlicesUnderHole_Z (IntPtr jnienv, IntPtr native__this, bool enable)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawSlicesUnderHole (enable);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='setDrawSlicesUnderHole' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawSlicesUnderHole", "(Z)V", "GetSetDrawSlicesUnderHole_ZHandler")]
		public virtual unsafe void SetDrawSlicesUnderHole (bool enable)
		{
			const string __id = "setDrawSlicesUnderHole.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enable);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setEntryLabelColor_I;
#pragma warning disable 0169
		static Delegate GetSetEntryLabelColor_IHandler ()
		{
			if (cb_setEntryLabelColor_I == null)
				cb_setEntryLabelColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetEntryLabelColor_I);
			return cb_setEntryLabelColor_I;
		}

		static void n_SetEntryLabelColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetEntryLabelColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='setEntryLabelColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setEntryLabelColor", "(I)V", "GetSetEntryLabelColor_IHandler")]
		public virtual unsafe void SetEntryLabelColor (int color)
		{
			const string __id = "setEntryLabelColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setEntryLabelTextSize_F;
#pragma warning disable 0169
		static Delegate GetSetEntryLabelTextSize_FHandler ()
		{
			if (cb_setEntryLabelTextSize_F == null)
				cb_setEntryLabelTextSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetEntryLabelTextSize_F);
			return cb_setEntryLabelTextSize_F;
		}

		static void n_SetEntryLabelTextSize_F (IntPtr jnienv, IntPtr native__this, float size)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetEntryLabelTextSize (size);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='setEntryLabelTextSize' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setEntryLabelTextSize", "(F)V", "GetSetEntryLabelTextSize_FHandler")]
		public virtual unsafe void SetEntryLabelTextSize (float size)
		{
			const string __id = "setEntryLabelTextSize.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (size);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setEntryLabelTypeface_Landroid_graphics_Typeface_;
#pragma warning disable 0169
		static Delegate GetSetEntryLabelTypeface_Landroid_graphics_Typeface_Handler ()
		{
			if (cb_setEntryLabelTypeface_Landroid_graphics_Typeface_ == null)
				cb_setEntryLabelTypeface_Landroid_graphics_Typeface_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEntryLabelTypeface_Landroid_graphics_Typeface_);
			return cb_setEntryLabelTypeface_Landroid_graphics_Typeface_;
		}

		static void n_SetEntryLabelTypeface_Landroid_graphics_Typeface_ (IntPtr jnienv, IntPtr native__this, IntPtr native_tf)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Typeface tf = global::Java.Lang.Object.GetObject<global::Android.Graphics.Typeface> (native_tf, JniHandleOwnership.DoNotTransfer);
			__this.SetEntryLabelTypeface (tf);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='setEntryLabelTypeface' and count(parameter)=1 and parameter[1][@type='android.graphics.Typeface']]"
		[Register ("setEntryLabelTypeface", "(Landroid/graphics/Typeface;)V", "GetSetEntryLabelTypeface_Landroid_graphics_Typeface_Handler")]
		public virtual unsafe void SetEntryLabelTypeface (global::Android.Graphics.Typeface tf)
		{
			const string __id = "setEntryLabelTypeface.(Landroid/graphics/Typeface;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((tf == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tf).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setHoleColor_I;
#pragma warning disable 0169
		static Delegate GetSetHoleColor_IHandler ()
		{
			if (cb_setHoleColor_I == null)
				cb_setHoleColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetHoleColor_I);
			return cb_setHoleColor_I;
		}

		static void n_SetHoleColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetHoleColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='setHoleColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setHoleColor", "(I)V", "GetSetHoleColor_IHandler")]
		public virtual unsafe void SetHoleColor (int color)
		{
			const string __id = "setHoleColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTransparentCircleAlpha_I;
#pragma warning disable 0169
		static Delegate GetSetTransparentCircleAlpha_IHandler ()
		{
			if (cb_setTransparentCircleAlpha_I == null)
				cb_setTransparentCircleAlpha_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTransparentCircleAlpha_I);
			return cb_setTransparentCircleAlpha_I;
		}

		static void n_SetTransparentCircleAlpha_I (IntPtr jnienv, IntPtr native__this, int alpha)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTransparentCircleAlpha (alpha);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='setTransparentCircleAlpha' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTransparentCircleAlpha", "(I)V", "GetSetTransparentCircleAlpha_IHandler")]
		public virtual unsafe void SetTransparentCircleAlpha (int alpha)
		{
			const string __id = "setTransparentCircleAlpha.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (alpha);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setTransparentCircleColor_I;
#pragma warning disable 0169
		static Delegate GetSetTransparentCircleColor_IHandler ()
		{
			if (cb_setTransparentCircleColor_I == null)
				cb_setTransparentCircleColor_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetTransparentCircleColor_I);
			return cb_setTransparentCircleColor_I;
		}

		static void n_SetTransparentCircleColor_I (IntPtr jnienv, IntPtr native__this, int color)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetTransparentCircleColor (color);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='setTransparentCircleColor' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setTransparentCircleColor", "(I)V", "GetSetTransparentCircleColor_IHandler")]
		public virtual unsafe void SetTransparentCircleColor (int color)
		{
			const string __id = "setTransparentCircleColor.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (color);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setUsePercentValues_Z;
#pragma warning disable 0169
		static Delegate GetSetUsePercentValues_ZHandler ()
		{
			if (cb_setUsePercentValues_Z == null)
				cb_setUsePercentValues_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetUsePercentValues_Z);
			return cb_setUsePercentValues_Z;
		}

		static void n_SetUsePercentValues_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Charts.PieChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.PieChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetUsePercentValues (enabled);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='PieChart']/method[@name='setUsePercentValues' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setUsePercentValues", "(Z)V", "GetSetUsePercentValues_ZHandler")]
		public virtual unsafe void SetUsePercentValues (bool enabled)
		{
			const string __id = "setUsePercentValues.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (enabled);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
