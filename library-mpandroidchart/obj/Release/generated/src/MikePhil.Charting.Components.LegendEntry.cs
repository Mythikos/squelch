using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Components {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LegendEntry']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/components/LegendEntry", DoNotGenerateAcw=true)]
	public partial class LegendEntry : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LegendEntry']/field[@name='form']"
		[Register ("form")]
		public global::MikePhil.Charting.Components.Legend.LegendForm Form {
			get {
				const string __id = "form.Lcom/github/mikephil/charting/components/Legend$LegendForm;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendForm> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "form.Lcom/github/mikephil/charting/components/Legend$LegendForm;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LegendEntry']/field[@name='formColor']"
		[Register ("formColor")]
		public int FormColor {
			get {
				const string __id = "formColor.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "formColor.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LegendEntry']/field[@name='formLineDashEffect']"
		[Register ("formLineDashEffect")]
		public global::Android.Graphics.DashPathEffect FormLineDashEffect {
			get {
				const string __id = "formLineDashEffect.Landroid/graphics/DashPathEffect;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.DashPathEffect> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "formLineDashEffect.Landroid/graphics/DashPathEffect;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LegendEntry']/field[@name='formLineWidth']"
		[Register ("formLineWidth")]
		public float FormLineWidth {
			get {
				const string __id = "formLineWidth.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "formLineWidth.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LegendEntry']/field[@name='formSize']"
		[Register ("formSize")]
		public float FormSize {
			get {
				const string __id = "formSize.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "formSize.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LegendEntry']/field[@name='label']"
		[Register ("label")]
		public string Label {
			get {
				const string __id = "label.Ljava/lang/String;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return JNIEnv.GetString (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "label.Ljava/lang/String;";

				IntPtr native_value = JNIEnv.NewString (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/components/LegendEntry", typeof (LegendEntry));
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

		protected LegendEntry (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LegendEntry']/constructor[@name='LegendEntry' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe LegendEntry ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='LegendEntry']/constructor[@name='LegendEntry' and count(parameter)=6 and parameter[1][@type='java.lang.String'] and parameter[2][@type='com.github.mikephil.charting.components.Legend.LegendForm'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='android.graphics.DashPathEffect'] and parameter[6][@type='int']]"
		[Register (".ctor", "(Ljava/lang/String;Lcom/github/mikephil/charting/components/Legend$LegendForm;FFLandroid/graphics/DashPathEffect;I)V", "")]
		public unsafe LegendEntry (string label, global::MikePhil.Charting.Components.Legend.LegendForm form, float formSize, float formLineWidth, global::Android.Graphics.DashPathEffect formLineDashEffect, int formColor)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Lcom/github/mikephil/charting/components/Legend$LegendForm;FFLandroid/graphics/DashPathEffect;I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_label = JNIEnv.NewString (label);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_label);
				__args [1] = new JniArgumentValue ((form == null) ? IntPtr.Zero : ((global::Java.Lang.Object) form).Handle);
				__args [2] = new JniArgumentValue (formSize);
				__args [3] = new JniArgumentValue (formLineWidth);
				__args [4] = new JniArgumentValue ((formLineDashEffect == null) ? IntPtr.Zero : ((global::Java.Lang.Object) formLineDashEffect).Handle);
				__args [5] = new JniArgumentValue (formColor);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_label);
			}
		}

	}
}
