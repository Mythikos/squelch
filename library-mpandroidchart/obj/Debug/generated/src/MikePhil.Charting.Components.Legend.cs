using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Components {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/components/Legend", DoNotGenerateAcw=true)]
	public partial class Legend : global::MikePhil.Charting.Components.ComponentBase {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/field[@name='mNeededHeight']"
		[Register ("mNeededHeight")]
		public float MNeededHeight {
			get {
				const string __id = "mNeededHeight.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mNeededHeight.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/field[@name='mNeededWidth']"
		[Register ("mNeededWidth")]
		public float MNeededWidth {
			get {
				const string __id = "mNeededWidth.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mNeededWidth.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/field[@name='mTextHeightMax']"
		[Register ("mTextHeightMax")]
		public float MTextHeightMax {
			get {
				const string __id = "mTextHeightMax.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mTextHeightMax.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/field[@name='mTextWidthMax']"
		[Register ("mTextWidthMax")]
		public float MTextWidthMax {
			get {
				const string __id = "mTextWidthMax.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "mTextWidthMax.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendDirection']"
		[global::Android.Runtime.Register ("com/github/mikephil/charting/components/Legend$LegendDirection", DoNotGenerateAcw=true)]
		public sealed partial class LegendDirection : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendDirection']/field[@name='LEFT_TO_RIGHT']"
			[Register ("LEFT_TO_RIGHT")]
			public static global::MikePhil.Charting.Components.Legend.LegendDirection LeftToRight {
				get {
					const string __id = "LEFT_TO_RIGHT.Lcom/github/mikephil/charting/components/Legend$LegendDirection;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendDirection> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendDirection']/field[@name='RIGHT_TO_LEFT']"
			[Register ("RIGHT_TO_LEFT")]
			public static global::MikePhil.Charting.Components.Legend.LegendDirection RightToLeft {
				get {
					const string __id = "RIGHT_TO_LEFT.Lcom/github/mikephil/charting/components/Legend$LegendDirection;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendDirection> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/components/Legend$LegendDirection", typeof (LegendDirection));
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

			internal LegendDirection (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendDirection']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/github/mikephil/charting/components/Legend$LegendDirection;", "")]
			public static unsafe global::MikePhil.Charting.Components.Legend.LegendDirection ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/github/mikephil/charting/components/Legend$LegendDirection;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendDirection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendDirection']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/github/mikephil/charting/components/Legend$LegendDirection;", "")]
			public static unsafe global::MikePhil.Charting.Components.Legend.LegendDirection[] Values ()
			{
				const string __id = "values.()[Lcom/github/mikephil/charting/components/Legend$LegendDirection;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::MikePhil.Charting.Components.Legend.LegendDirection[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::MikePhil.Charting.Components.Legend.LegendDirection));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendForm']"
		[global::Android.Runtime.Register ("com/github/mikephil/charting/components/Legend$LegendForm", DoNotGenerateAcw=true)]
		public sealed partial class LegendForm : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendForm']/field[@name='CIRCLE']"
			[Register ("CIRCLE")]
			public static global::MikePhil.Charting.Components.Legend.LegendForm Circle {
				get {
					const string __id = "CIRCLE.Lcom/github/mikephil/charting/components/Legend$LegendForm;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendForm> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendForm']/field[@name='DEFAULT']"
			[Register ("DEFAULT")]
			public static global::MikePhil.Charting.Components.Legend.LegendForm Default {
				get {
					const string __id = "DEFAULT.Lcom/github/mikephil/charting/components/Legend$LegendForm;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendForm> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendForm']/field[@name='EMPTY']"
			[Register ("EMPTY")]
			public static global::MikePhil.Charting.Components.Legend.LegendForm Empty {
				get {
					const string __id = "EMPTY.Lcom/github/mikephil/charting/components/Legend$LegendForm;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendForm> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendForm']/field[@name='LINE']"
			[Register ("LINE")]
			public static global::MikePhil.Charting.Components.Legend.LegendForm Line {
				get {
					const string __id = "LINE.Lcom/github/mikephil/charting/components/Legend$LegendForm;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendForm> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendForm']/field[@name='NONE']"
			[Register ("NONE")]
			public static global::MikePhil.Charting.Components.Legend.LegendForm None {
				get {
					const string __id = "NONE.Lcom/github/mikephil/charting/components/Legend$LegendForm;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendForm> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendForm']/field[@name='SQUARE']"
			[Register ("SQUARE")]
			public static global::MikePhil.Charting.Components.Legend.LegendForm Square {
				get {
					const string __id = "SQUARE.Lcom/github/mikephil/charting/components/Legend$LegendForm;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendForm> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/components/Legend$LegendForm", typeof (LegendForm));
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

			internal LegendForm (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendForm']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/github/mikephil/charting/components/Legend$LegendForm;", "")]
			public static unsafe global::MikePhil.Charting.Components.Legend.LegendForm ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/github/mikephil/charting/components/Legend$LegendForm;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendForm> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendForm']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/github/mikephil/charting/components/Legend$LegendForm;", "")]
			public static unsafe global::MikePhil.Charting.Components.Legend.LegendForm[] Values ()
			{
				const string __id = "values.()[Lcom/github/mikephil/charting/components/Legend$LegendForm;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::MikePhil.Charting.Components.Legend.LegendForm[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::MikePhil.Charting.Components.Legend.LegendForm));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendHorizontalAlignment']"
		[global::Android.Runtime.Register ("com/github/mikephil/charting/components/Legend$LegendHorizontalAlignment", DoNotGenerateAcw=true)]
		public sealed partial class LegendHorizontalAlignment : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendHorizontalAlignment']/field[@name='CENTER']"
			[Register ("CENTER")]
			public static global::MikePhil.Charting.Components.Legend.LegendHorizontalAlignment Center {
				get {
					const string __id = "CENTER.Lcom/github/mikephil/charting/components/Legend$LegendHorizontalAlignment;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendHorizontalAlignment> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendHorizontalAlignment']/field[@name='LEFT']"
			[Register ("LEFT")]
			public static global::MikePhil.Charting.Components.Legend.LegendHorizontalAlignment Left {
				get {
					const string __id = "LEFT.Lcom/github/mikephil/charting/components/Legend$LegendHorizontalAlignment;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendHorizontalAlignment> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendHorizontalAlignment']/field[@name='RIGHT']"
			[Register ("RIGHT")]
			public static global::MikePhil.Charting.Components.Legend.LegendHorizontalAlignment Right {
				get {
					const string __id = "RIGHT.Lcom/github/mikephil/charting/components/Legend$LegendHorizontalAlignment;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendHorizontalAlignment> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/components/Legend$LegendHorizontalAlignment", typeof (LegendHorizontalAlignment));
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

			internal LegendHorizontalAlignment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendHorizontalAlignment']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/github/mikephil/charting/components/Legend$LegendHorizontalAlignment;", "")]
			public static unsafe global::MikePhil.Charting.Components.Legend.LegendHorizontalAlignment ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/github/mikephil/charting/components/Legend$LegendHorizontalAlignment;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendHorizontalAlignment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendHorizontalAlignment']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/github/mikephil/charting/components/Legend$LegendHorizontalAlignment;", "")]
			public static unsafe global::MikePhil.Charting.Components.Legend.LegendHorizontalAlignment[] Values ()
			{
				const string __id = "values.()[Lcom/github/mikephil/charting/components/Legend$LegendHorizontalAlignment;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::MikePhil.Charting.Components.Legend.LegendHorizontalAlignment[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::MikePhil.Charting.Components.Legend.LegendHorizontalAlignment));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendOrientation']"
		[global::Android.Runtime.Register ("com/github/mikephil/charting/components/Legend$LegendOrientation", DoNotGenerateAcw=true)]
		public sealed partial class LegendOrientation : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendOrientation']/field[@name='HORIZONTAL']"
			[Register ("HORIZONTAL")]
			public static global::MikePhil.Charting.Components.Legend.LegendOrientation Horizontal {
				get {
					const string __id = "HORIZONTAL.Lcom/github/mikephil/charting/components/Legend$LegendOrientation;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendOrientation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendOrientation']/field[@name='VERTICAL']"
			[Register ("VERTICAL")]
			public static global::MikePhil.Charting.Components.Legend.LegendOrientation Vertical {
				get {
					const string __id = "VERTICAL.Lcom/github/mikephil/charting/components/Legend$LegendOrientation;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendOrientation> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/components/Legend$LegendOrientation", typeof (LegendOrientation));
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

			internal LegendOrientation (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendOrientation']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/github/mikephil/charting/components/Legend$LegendOrientation;", "")]
			public static unsafe global::MikePhil.Charting.Components.Legend.LegendOrientation ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/github/mikephil/charting/components/Legend$LegendOrientation;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendOrientation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendOrientation']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/github/mikephil/charting/components/Legend$LegendOrientation;", "")]
			public static unsafe global::MikePhil.Charting.Components.Legend.LegendOrientation[] Values ()
			{
				const string __id = "values.()[Lcom/github/mikephil/charting/components/Legend$LegendOrientation;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::MikePhil.Charting.Components.Legend.LegendOrientation[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::MikePhil.Charting.Components.Legend.LegendOrientation));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendPosition']"
		[ObsoleteAttribute (@"This class is obsoleted in this android platform")]
		[global::Android.Runtime.Register ("com/github/mikephil/charting/components/Legend$LegendPosition", DoNotGenerateAcw=true)]
		public sealed partial class LegendPosition : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendPosition']/field[@name='ABOVE_CHART_CENTER']"
			[Register ("ABOVE_CHART_CENTER")]
			public static global::MikePhil.Charting.Components.Legend.LegendPosition AboveChartCenter {
				get {
					const string __id = "ABOVE_CHART_CENTER.Lcom/github/mikephil/charting/components/Legend$LegendPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendPosition']/field[@name='ABOVE_CHART_LEFT']"
			[Register ("ABOVE_CHART_LEFT")]
			public static global::MikePhil.Charting.Components.Legend.LegendPosition AboveChartLeft {
				get {
					const string __id = "ABOVE_CHART_LEFT.Lcom/github/mikephil/charting/components/Legend$LegendPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendPosition']/field[@name='ABOVE_CHART_RIGHT']"
			[Register ("ABOVE_CHART_RIGHT")]
			public static global::MikePhil.Charting.Components.Legend.LegendPosition AboveChartRight {
				get {
					const string __id = "ABOVE_CHART_RIGHT.Lcom/github/mikephil/charting/components/Legend$LegendPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendPosition']/field[@name='BELOW_CHART_CENTER']"
			[Register ("BELOW_CHART_CENTER")]
			public static global::MikePhil.Charting.Components.Legend.LegendPosition BelowChartCenter {
				get {
					const string __id = "BELOW_CHART_CENTER.Lcom/github/mikephil/charting/components/Legend$LegendPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendPosition']/field[@name='BELOW_CHART_LEFT']"
			[Register ("BELOW_CHART_LEFT")]
			public static global::MikePhil.Charting.Components.Legend.LegendPosition BelowChartLeft {
				get {
					const string __id = "BELOW_CHART_LEFT.Lcom/github/mikephil/charting/components/Legend$LegendPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendPosition']/field[@name='BELOW_CHART_RIGHT']"
			[Register ("BELOW_CHART_RIGHT")]
			public static global::MikePhil.Charting.Components.Legend.LegendPosition BelowChartRight {
				get {
					const string __id = "BELOW_CHART_RIGHT.Lcom/github/mikephil/charting/components/Legend$LegendPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendPosition']/field[@name='LEFT_OF_CHART']"
			[Register ("LEFT_OF_CHART")]
			public static global::MikePhil.Charting.Components.Legend.LegendPosition LeftOfChart {
				get {
					const string __id = "LEFT_OF_CHART.Lcom/github/mikephil/charting/components/Legend$LegendPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendPosition']/field[@name='LEFT_OF_CHART_CENTER']"
			[Register ("LEFT_OF_CHART_CENTER")]
			public static global::MikePhil.Charting.Components.Legend.LegendPosition LeftOfChartCenter {
				get {
					const string __id = "LEFT_OF_CHART_CENTER.Lcom/github/mikephil/charting/components/Legend$LegendPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendPosition']/field[@name='LEFT_OF_CHART_INSIDE']"
			[Register ("LEFT_OF_CHART_INSIDE")]
			public static global::MikePhil.Charting.Components.Legend.LegendPosition LeftOfChartInside {
				get {
					const string __id = "LEFT_OF_CHART_INSIDE.Lcom/github/mikephil/charting/components/Legend$LegendPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendPosition']/field[@name='PIECHART_CENTER']"
			[Register ("PIECHART_CENTER")]
			public static global::MikePhil.Charting.Components.Legend.LegendPosition PiechartCenter {
				get {
					const string __id = "PIECHART_CENTER.Lcom/github/mikephil/charting/components/Legend$LegendPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendPosition']/field[@name='RIGHT_OF_CHART']"
			[Register ("RIGHT_OF_CHART")]
			public static global::MikePhil.Charting.Components.Legend.LegendPosition RightOfChart {
				get {
					const string __id = "RIGHT_OF_CHART.Lcom/github/mikephil/charting/components/Legend$LegendPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendPosition']/field[@name='RIGHT_OF_CHART_CENTER']"
			[Register ("RIGHT_OF_CHART_CENTER")]
			public static global::MikePhil.Charting.Components.Legend.LegendPosition RightOfChartCenter {
				get {
					const string __id = "RIGHT_OF_CHART_CENTER.Lcom/github/mikephil/charting/components/Legend$LegendPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendPosition']/field[@name='RIGHT_OF_CHART_INSIDE']"
			[Register ("RIGHT_OF_CHART_INSIDE")]
			public static global::MikePhil.Charting.Components.Legend.LegendPosition RightOfChartInside {
				get {
					const string __id = "RIGHT_OF_CHART_INSIDE.Lcom/github/mikephil/charting/components/Legend$LegendPosition;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendPosition> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/components/Legend$LegendPosition", typeof (LegendPosition));
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

			internal LegendPosition (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendPosition']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/github/mikephil/charting/components/Legend$LegendPosition;", "")]
			public static unsafe global::MikePhil.Charting.Components.Legend.LegendPosition ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/github/mikephil/charting/components/Legend$LegendPosition;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendPosition']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/github/mikephil/charting/components/Legend$LegendPosition;", "")]
			public static unsafe global::MikePhil.Charting.Components.Legend.LegendPosition[] Values ()
			{
				const string __id = "values.()[Lcom/github/mikephil/charting/components/Legend$LegendPosition;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::MikePhil.Charting.Components.Legend.LegendPosition[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::MikePhil.Charting.Components.Legend.LegendPosition));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendVerticalAlignment']"
		[global::Android.Runtime.Register ("com/github/mikephil/charting/components/Legend$LegendVerticalAlignment", DoNotGenerateAcw=true)]
		public sealed partial class LegendVerticalAlignment : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendVerticalAlignment']/field[@name='BOTTOM']"
			[Register ("BOTTOM")]
			public static global::MikePhil.Charting.Components.Legend.LegendVerticalAlignment Bottom {
				get {
					const string __id = "BOTTOM.Lcom/github/mikephil/charting/components/Legend$LegendVerticalAlignment;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendVerticalAlignment> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendVerticalAlignment']/field[@name='CENTER']"
			[Register ("CENTER")]
			public static global::MikePhil.Charting.Components.Legend.LegendVerticalAlignment Center {
				get {
					const string __id = "CENTER.Lcom/github/mikephil/charting/components/Legend$LegendVerticalAlignment;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendVerticalAlignment> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendVerticalAlignment']/field[@name='TOP']"
			[Register ("TOP")]
			public static global::MikePhil.Charting.Components.Legend.LegendVerticalAlignment Top {
				get {
					const string __id = "TOP.Lcom/github/mikephil/charting/components/Legend$LegendVerticalAlignment;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendVerticalAlignment> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/components/Legend$LegendVerticalAlignment", typeof (LegendVerticalAlignment));
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

			internal LegendVerticalAlignment (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendVerticalAlignment']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/github/mikephil/charting/components/Legend$LegendVerticalAlignment;", "")]
			public static unsafe global::MikePhil.Charting.Components.Legend.LegendVerticalAlignment ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/github/mikephil/charting/components/Legend$LegendVerticalAlignment;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendVerticalAlignment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend.LegendVerticalAlignment']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/github/mikephil/charting/components/Legend$LegendVerticalAlignment;", "")]
			public static unsafe global::MikePhil.Charting.Components.Legend.LegendVerticalAlignment[] Values ()
			{
				const string __id = "values.()[Lcom/github/mikephil/charting/components/Legend$LegendVerticalAlignment;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::MikePhil.Charting.Components.Legend.LegendVerticalAlignment[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::MikePhil.Charting.Components.Legend.LegendVerticalAlignment));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/components/Legend", typeof (Legend));
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

		protected Legend (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/constructor[@name='Legend' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Legend ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/constructor[@name='Legend' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.LegendEntry[]']]"
		[Register (".ctor", "([Lcom/github/mikephil/charting/components/LegendEntry;)V", "")]
		public unsafe Legend (global::MikePhil.Charting.Components.LegendEntry[] entries)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([Lcom/github/mikephil/charting/components/LegendEntry;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_entries = JNIEnv.NewArray (entries);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_entries);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (entries != null) {
					JNIEnv.CopyArray (native_entries, entries);
					JNIEnv.DeleteLocalRef (native_entries);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/constructor[@name='Legend' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='java.lang.String[]']]"
		[Register (".ctor", "([I[Ljava/lang/String;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe Legend (int[] colors, string[] labels)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([I[Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_colors = JNIEnv.NewArray (colors);
			IntPtr native_labels = JNIEnv.NewArray (labels);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_colors);
				__args [1] = new JniArgumentValue (native_labels);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (colors != null) {
					JNIEnv.CopyArray (native_colors, colors);
					JNIEnv.DeleteLocalRef (native_colors);
				}
				if (labels != null) {
					JNIEnv.CopyArray (native_labels, labels);
					JNIEnv.DeleteLocalRef (native_labels);
				}
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/constructor[@name='Legend' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.Integer&gt;'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register (".ctor", "(Ljava/util/List;Ljava/util/List;)V", "")]
		[Obsolete (@"deprecated")]
		public unsafe Legend (global::System.Collections.Generic.IList<global::Java.Lang.Integer> colors, global::System.Collections.Generic.IList<string> labels)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;Ljava/util/List;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_colors = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (colors);
			IntPtr native_labels = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (labels);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_colors);
				__args [1] = new JniArgumentValue (native_labels);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_colors);
				JNIEnv.DeleteLocalRef (native_labels);
			}
		}

		static Delegate cb_getCalculatedLabelBreakPoints;
#pragma warning disable 0169
		static Delegate GetGetCalculatedLabelBreakPointsHandler ()
		{
			if (cb_getCalculatedLabelBreakPoints == null)
				cb_getCalculatedLabelBreakPoints = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCalculatedLabelBreakPoints);
			return cb_getCalculatedLabelBreakPoints;
		}

		static IntPtr n_GetCalculatedLabelBreakPoints (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.Boolean>.ToLocalJniHandle (__this.CalculatedLabelBreakPoints);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::Java.Lang.Boolean> CalculatedLabelBreakPoints {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getCalculatedLabelBreakPoints' and count(parameter)=0]"
			[Register ("getCalculatedLabelBreakPoints", "()Ljava/util/List;", "GetGetCalculatedLabelBreakPointsHandler")]
			get {
				const string __id = "getCalculatedLabelBreakPoints.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Java.Lang.Boolean>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCalculatedLabelSizes;
#pragma warning disable 0169
		static Delegate GetGetCalculatedLabelSizesHandler ()
		{
			if (cb_getCalculatedLabelSizes == null)
				cb_getCalculatedLabelSizes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCalculatedLabelSizes);
			return cb_getCalculatedLabelSizes;
		}

		static IntPtr n_GetCalculatedLabelSizes (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::MikePhil.Charting.Util.FSize>.ToLocalJniHandle (__this.CalculatedLabelSizes);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::MikePhil.Charting.Util.FSize> CalculatedLabelSizes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getCalculatedLabelSizes' and count(parameter)=0]"
			[Register ("getCalculatedLabelSizes", "()Ljava/util/List;", "GetGetCalculatedLabelSizesHandler")]
			get {
				const string __id = "getCalculatedLabelSizes.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::MikePhil.Charting.Util.FSize>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCalculatedLineSizes;
#pragma warning disable 0169
		static Delegate GetGetCalculatedLineSizesHandler ()
		{
			if (cb_getCalculatedLineSizes == null)
				cb_getCalculatedLineSizes = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCalculatedLineSizes);
			return cb_getCalculatedLineSizes;
		}

		static IntPtr n_GetCalculatedLineSizes (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::MikePhil.Charting.Util.FSize>.ToLocalJniHandle (__this.CalculatedLineSizes);
		}
#pragma warning restore 0169

		public virtual unsafe global::System.Collections.Generic.IList<global::MikePhil.Charting.Util.FSize> CalculatedLineSizes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getCalculatedLineSizes' and count(parameter)=0]"
			[Register ("getCalculatedLineSizes", "()Ljava/util/List;", "GetGetCalculatedLineSizesHandler")]
			get {
				const string __id = "getCalculatedLineSizes.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::MikePhil.Charting.Util.FSize>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getDirection;
#pragma warning disable 0169
		static Delegate GetGetDirectionHandler ()
		{
			if (cb_getDirection == null)
				cb_getDirection = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDirection);
			return cb_getDirection;
		}

		static IntPtr n_GetDirection (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Direction);
		}
#pragma warning restore 0169

		static Delegate cb_setDirection_Lcom_github_mikephil_charting_components_Legend_LegendDirection_;
#pragma warning disable 0169
		static Delegate GetSetDirection_Lcom_github_mikephil_charting_components_Legend_LegendDirection_Handler ()
		{
			if (cb_setDirection_Lcom_github_mikephil_charting_components_Legend_LegendDirection_ == null)
				cb_setDirection_Lcom_github_mikephil_charting_components_Legend_LegendDirection_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetDirection_Lcom_github_mikephil_charting_components_Legend_LegendDirection_);
			return cb_setDirection_Lcom_github_mikephil_charting_components_Legend_LegendDirection_;
		}

		static void n_SetDirection_Lcom_github_mikephil_charting_components_Legend_LegendDirection_ (IntPtr jnienv, IntPtr native__this, IntPtr native_pos)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.Legend.LegendDirection pos = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendDirection> (native_pos, JniHandleOwnership.DoNotTransfer);
			__this.Direction = pos;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Components.Legend.LegendDirection Direction {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getDirection' and count(parameter)=0]"
			[Register ("getDirection", "()Lcom/github/mikephil/charting/components/Legend$LegendDirection;", "GetGetDirectionHandler")]
			get {
				const string __id = "getDirection.()Lcom/github/mikephil/charting/components/Legend$LegendDirection;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendDirection> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='setDirection' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.Legend.LegendDirection']]"
			[Register ("setDirection", "(Lcom/github/mikephil/charting/components/Legend$LegendDirection;)V", "GetSetDirection_Lcom_github_mikephil_charting_components_Legend_LegendDirection_Handler")]
			set {
				const string __id = "setDirection.(Lcom/github/mikephil/charting/components/Legend$LegendDirection;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getForm;
#pragma warning disable 0169
		static Delegate GetGetFormHandler ()
		{
			if (cb_getForm == null)
				cb_getForm = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetForm);
			return cb_getForm;
		}

		static IntPtr n_GetForm (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Form);
		}
#pragma warning restore 0169

		static Delegate cb_setForm_Lcom_github_mikephil_charting_components_Legend_LegendForm_;
#pragma warning disable 0169
		static Delegate GetSetForm_Lcom_github_mikephil_charting_components_Legend_LegendForm_Handler ()
		{
			if (cb_setForm_Lcom_github_mikephil_charting_components_Legend_LegendForm_ == null)
				cb_setForm_Lcom_github_mikephil_charting_components_Legend_LegendForm_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetForm_Lcom_github_mikephil_charting_components_Legend_LegendForm_);
			return cb_setForm_Lcom_github_mikephil_charting_components_Legend_LegendForm_;
		}

		static void n_SetForm_Lcom_github_mikephil_charting_components_Legend_LegendForm_ (IntPtr jnienv, IntPtr native__this, IntPtr native_shape)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.Legend.LegendForm shape = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendForm> (native_shape, JniHandleOwnership.DoNotTransfer);
			__this.Form = shape;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Components.Legend.LegendForm Form {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getForm' and count(parameter)=0]"
			[Register ("getForm", "()Lcom/github/mikephil/charting/components/Legend$LegendForm;", "GetGetFormHandler")]
			get {
				const string __id = "getForm.()Lcom/github/mikephil/charting/components/Legend$LegendForm;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendForm> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='setForm' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.Legend.LegendForm']]"
			[Register ("setForm", "(Lcom/github/mikephil/charting/components/Legend$LegendForm;)V", "GetSetForm_Lcom_github_mikephil_charting_components_Legend_LegendForm_Handler")]
			set {
				const string __id = "setForm.(Lcom/github/mikephil/charting/components/Legend$LegendForm;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFormLineDashEffect;
#pragma warning disable 0169
		static Delegate GetGetFormLineDashEffectHandler ()
		{
			if (cb_getFormLineDashEffect == null)
				cb_getFormLineDashEffect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFormLineDashEffect);
			return cb_getFormLineDashEffect;
		}

		static IntPtr n_GetFormLineDashEffect (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.FormLineDashEffect);
		}
#pragma warning restore 0169

		static Delegate cb_setFormLineDashEffect_Landroid_graphics_DashPathEffect_;
#pragma warning disable 0169
		static Delegate GetSetFormLineDashEffect_Landroid_graphics_DashPathEffect_Handler ()
		{
			if (cb_setFormLineDashEffect_Landroid_graphics_DashPathEffect_ == null)
				cb_setFormLineDashEffect_Landroid_graphics_DashPathEffect_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetFormLineDashEffect_Landroid_graphics_DashPathEffect_);
			return cb_setFormLineDashEffect_Landroid_graphics_DashPathEffect_;
		}

		static void n_SetFormLineDashEffect_Landroid_graphics_DashPathEffect_ (IntPtr jnienv, IntPtr native__this, IntPtr native_dashPathEffect)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.DashPathEffect dashPathEffect = global::Java.Lang.Object.GetObject<global::Android.Graphics.DashPathEffect> (native_dashPathEffect, JniHandleOwnership.DoNotTransfer);
			__this.FormLineDashEffect = dashPathEffect;
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.DashPathEffect FormLineDashEffect {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getFormLineDashEffect' and count(parameter)=0]"
			[Register ("getFormLineDashEffect", "()Landroid/graphics/DashPathEffect;", "GetGetFormLineDashEffectHandler")]
			get {
				const string __id = "getFormLineDashEffect.()Landroid/graphics/DashPathEffect;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.DashPathEffect> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='setFormLineDashEffect' and count(parameter)=1 and parameter[1][@type='android.graphics.DashPathEffect']]"
			[Register ("setFormLineDashEffect", "(Landroid/graphics/DashPathEffect;)V", "GetSetFormLineDashEffect_Landroid_graphics_DashPathEffect_Handler")]
			set {
				const string __id = "setFormLineDashEffect.(Landroid/graphics/DashPathEffect;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFormLineWidth;
#pragma warning disable 0169
		static Delegate GetGetFormLineWidthHandler ()
		{
			if (cb_getFormLineWidth == null)
				cb_getFormLineWidth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetFormLineWidth);
			return cb_getFormLineWidth;
		}

		static float n_GetFormLineWidth (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FormLineWidth;
		}
#pragma warning restore 0169

		static Delegate cb_setFormLineWidth_F;
#pragma warning disable 0169
		static Delegate GetSetFormLineWidth_FHandler ()
		{
			if (cb_setFormLineWidth_F == null)
				cb_setFormLineWidth_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetFormLineWidth_F);
			return cb_setFormLineWidth_F;
		}

		static void n_SetFormLineWidth_F (IntPtr jnienv, IntPtr native__this, float size)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FormLineWidth = size;
		}
#pragma warning restore 0169

		public virtual unsafe float FormLineWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getFormLineWidth' and count(parameter)=0]"
			[Register ("getFormLineWidth", "()F", "GetGetFormLineWidthHandler")]
			get {
				const string __id = "getFormLineWidth.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='setFormLineWidth' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setFormLineWidth", "(F)V", "GetSetFormLineWidth_FHandler")]
			set {
				const string __id = "setFormLineWidth.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFormSize;
#pragma warning disable 0169
		static Delegate GetGetFormSizeHandler ()
		{
			if (cb_getFormSize == null)
				cb_getFormSize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetFormSize);
			return cb_getFormSize;
		}

		static float n_GetFormSize (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FormSize;
		}
#pragma warning restore 0169

		static Delegate cb_setFormSize_F;
#pragma warning disable 0169
		static Delegate GetSetFormSize_FHandler ()
		{
			if (cb_setFormSize_F == null)
				cb_setFormSize_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetFormSize_F);
			return cb_setFormSize_F;
		}

		static void n_SetFormSize_F (IntPtr jnienv, IntPtr native__this, float size)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FormSize = size;
		}
#pragma warning restore 0169

		public virtual unsafe float FormSize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getFormSize' and count(parameter)=0]"
			[Register ("getFormSize", "()F", "GetGetFormSizeHandler")]
			get {
				const string __id = "getFormSize.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='setFormSize' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setFormSize", "(F)V", "GetSetFormSize_FHandler")]
			set {
				const string __id = "setFormSize.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getFormToTextSpace;
#pragma warning disable 0169
		static Delegate GetGetFormToTextSpaceHandler ()
		{
			if (cb_getFormToTextSpace == null)
				cb_getFormToTextSpace = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetFormToTextSpace);
			return cb_getFormToTextSpace;
		}

		static float n_GetFormToTextSpace (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FormToTextSpace;
		}
#pragma warning restore 0169

		static Delegate cb_setFormToTextSpace_F;
#pragma warning disable 0169
		static Delegate GetSetFormToTextSpace_FHandler ()
		{
			if (cb_setFormToTextSpace_F == null)
				cb_setFormToTextSpace_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetFormToTextSpace_F);
			return cb_setFormToTextSpace_F;
		}

		static void n_SetFormToTextSpace_F (IntPtr jnienv, IntPtr native__this, float space)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.FormToTextSpace = space;
		}
#pragma warning restore 0169

		public virtual unsafe float FormToTextSpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getFormToTextSpace' and count(parameter)=0]"
			[Register ("getFormToTextSpace", "()F", "GetGetFormToTextSpaceHandler")]
			get {
				const string __id = "getFormToTextSpace.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='setFormToTextSpace' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setFormToTextSpace", "(F)V", "GetSetFormToTextSpace_FHandler")]
			set {
				const string __id = "setFormToTextSpace.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getHorizontalAlignment;
#pragma warning disable 0169
		static Delegate GetGetHorizontalAlignmentHandler ()
		{
			if (cb_getHorizontalAlignment == null)
				cb_getHorizontalAlignment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHorizontalAlignment);
			return cb_getHorizontalAlignment;
		}

		static IntPtr n_GetHorizontalAlignment (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.HorizontalAlignment);
		}
#pragma warning restore 0169

		static Delegate cb_setHorizontalAlignment_Lcom_github_mikephil_charting_components_Legend_LegendHorizontalAlignment_;
#pragma warning disable 0169
		static Delegate GetSetHorizontalAlignment_Lcom_github_mikephil_charting_components_Legend_LegendHorizontalAlignment_Handler ()
		{
			if (cb_setHorizontalAlignment_Lcom_github_mikephil_charting_components_Legend_LegendHorizontalAlignment_ == null)
				cb_setHorizontalAlignment_Lcom_github_mikephil_charting_components_Legend_LegendHorizontalAlignment_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetHorizontalAlignment_Lcom_github_mikephil_charting_components_Legend_LegendHorizontalAlignment_);
			return cb_setHorizontalAlignment_Lcom_github_mikephil_charting_components_Legend_LegendHorizontalAlignment_;
		}

		static void n_SetHorizontalAlignment_Lcom_github_mikephil_charting_components_Legend_LegendHorizontalAlignment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.Legend.LegendHorizontalAlignment value = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendHorizontalAlignment> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.HorizontalAlignment = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Components.Legend.LegendHorizontalAlignment HorizontalAlignment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getHorizontalAlignment' and count(parameter)=0]"
			[Register ("getHorizontalAlignment", "()Lcom/github/mikephil/charting/components/Legend$LegendHorizontalAlignment;", "GetGetHorizontalAlignmentHandler")]
			get {
				const string __id = "getHorizontalAlignment.()Lcom/github/mikephil/charting/components/Legend$LegendHorizontalAlignment;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendHorizontalAlignment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='setHorizontalAlignment' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.Legend.LegendHorizontalAlignment']]"
			[Register ("setHorizontalAlignment", "(Lcom/github/mikephil/charting/components/Legend$LegendHorizontalAlignment;)V", "GetSetHorizontalAlignment_Lcom_github_mikephil_charting_components_Legend_LegendHorizontalAlignment_Handler")]
			set {
				const string __id = "setHorizontalAlignment.(Lcom/github/mikephil/charting/components/Legend$LegendHorizontalAlignment;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isDrawInsideEnabled;
#pragma warning disable 0169
		static Delegate GetIsDrawInsideEnabledHandler ()
		{
			if (cb_isDrawInsideEnabled == null)
				cb_isDrawInsideEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsDrawInsideEnabled);
			return cb_isDrawInsideEnabled;
		}

		static bool n_IsDrawInsideEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsDrawInsideEnabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsDrawInsideEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='isDrawInsideEnabled' and count(parameter)=0]"
			[Register ("isDrawInsideEnabled", "()Z", "GetIsDrawInsideEnabledHandler")]
			get {
				const string __id = "isDrawInsideEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_isLegendCustom;
#pragma warning disable 0169
		static Delegate GetIsLegendCustomHandler ()
		{
			if (cb_isLegendCustom == null)
				cb_isLegendCustom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsLegendCustom);
			return cb_isLegendCustom;
		}

		static bool n_IsLegendCustom (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsLegendCustom;
		}
#pragma warning restore 0169

		public virtual unsafe bool IsLegendCustom {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='isLegendCustom' and count(parameter)=0]"
			[Register ("isLegendCustom", "()Z", "GetIsLegendCustomHandler")]
			get {
				const string __id = "isLegendCustom.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMaxSizePercent;
#pragma warning disable 0169
		static Delegate GetGetMaxSizePercentHandler ()
		{
			if (cb_getMaxSizePercent == null)
				cb_getMaxSizePercent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMaxSizePercent);
			return cb_getMaxSizePercent;
		}

		static float n_GetMaxSizePercent (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxSizePercent;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxSizePercent_F;
#pragma warning disable 0169
		static Delegate GetSetMaxSizePercent_FHandler ()
		{
			if (cb_setMaxSizePercent_F == null)
				cb_setMaxSizePercent_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMaxSizePercent_F);
			return cb_setMaxSizePercent_F;
		}

		static void n_SetMaxSizePercent_F (IntPtr jnienv, IntPtr native__this, float maxSize)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxSizePercent = maxSize;
		}
#pragma warning restore 0169

		public virtual unsafe float MaxSizePercent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getMaxSizePercent' and count(parameter)=0]"
			[Register ("getMaxSizePercent", "()F", "GetGetMaxSizePercentHandler")]
			get {
				const string __id = "getMaxSizePercent.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='setMaxSizePercent' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMaxSizePercent", "(F)V", "GetSetMaxSizePercent_FHandler")]
			set {
				const string __id = "setMaxSizePercent.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getOrientation;
#pragma warning disable 0169
		static Delegate GetGetOrientationHandler ()
		{
			if (cb_getOrientation == null)
				cb_getOrientation = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOrientation);
			return cb_getOrientation;
		}

		static IntPtr n_GetOrientation (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Orientation);
		}
#pragma warning restore 0169

		static Delegate cb_setOrientation_Lcom_github_mikephil_charting_components_Legend_LegendOrientation_;
#pragma warning disable 0169
		static Delegate GetSetOrientation_Lcom_github_mikephil_charting_components_Legend_LegendOrientation_Handler ()
		{
			if (cb_setOrientation_Lcom_github_mikephil_charting_components_Legend_LegendOrientation_ == null)
				cb_setOrientation_Lcom_github_mikephil_charting_components_Legend_LegendOrientation_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOrientation_Lcom_github_mikephil_charting_components_Legend_LegendOrientation_);
			return cb_setOrientation_Lcom_github_mikephil_charting_components_Legend_LegendOrientation_;
		}

		static void n_SetOrientation_Lcom_github_mikephil_charting_components_Legend_LegendOrientation_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.Legend.LegendOrientation value = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendOrientation> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.Orientation = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Components.Legend.LegendOrientation Orientation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getOrientation' and count(parameter)=0]"
			[Register ("getOrientation", "()Lcom/github/mikephil/charting/components/Legend$LegendOrientation;", "GetGetOrientationHandler")]
			get {
				const string __id = "getOrientation.()Lcom/github/mikephil/charting/components/Legend$LegendOrientation;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendOrientation> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='setOrientation' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.Legend.LegendOrientation']]"
			[Register ("setOrientation", "(Lcom/github/mikephil/charting/components/Legend$LegendOrientation;)V", "GetSetOrientation_Lcom_github_mikephil_charting_components_Legend_LegendOrientation_Handler")]
			set {
				const string __id = "setOrientation.(Lcom/github/mikephil/charting/components/Legend$LegendOrientation;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getPosition;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetPositionHandler ()
		{
			if (cb_getPosition == null)
				cb_getPosition = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPosition);
			return cb_getPosition;
		}

		[Obsolete]
		static IntPtr n_GetPosition (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Position);
		}
#pragma warning restore 0169

		static Delegate cb_setPosition_Lcom_github_mikephil_charting_components_Legend_LegendPosition_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetPosition_Lcom_github_mikephil_charting_components_Legend_LegendPosition_Handler ()
		{
			if (cb_setPosition_Lcom_github_mikephil_charting_components_Legend_LegendPosition_ == null)
				cb_setPosition_Lcom_github_mikephil_charting_components_Legend_LegendPosition_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetPosition_Lcom_github_mikephil_charting_components_Legend_LegendPosition_);
			return cb_setPosition_Lcom_github_mikephil_charting_components_Legend_LegendPosition_;
		}

		[Obsolete]
		static void n_SetPosition_Lcom_github_mikephil_charting_components_Legend_LegendPosition_ (IntPtr jnienv, IntPtr native__this, IntPtr native_newValue)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.Legend.LegendPosition newValue = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendPosition> (native_newValue, JniHandleOwnership.DoNotTransfer);
			__this.Position = newValue;
		}
#pragma warning restore 0169

		[Obsolete (@"deprecated")]
		public virtual unsafe global::MikePhil.Charting.Components.Legend.LegendPosition Position {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getPosition' and count(parameter)=0]"
			[Register ("getPosition", "()Lcom/github/mikephil/charting/components/Legend$LegendPosition;", "GetGetPositionHandler")]
			get {
				const string __id = "getPosition.()Lcom/github/mikephil/charting/components/Legend$LegendPosition;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendPosition> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='setPosition' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.Legend.LegendPosition']]"
			[Register ("setPosition", "(Lcom/github/mikephil/charting/components/Legend$LegendPosition;)V", "GetSetPosition_Lcom_github_mikephil_charting_components_Legend_LegendPosition_Handler")]
			set {
				const string __id = "setPosition.(Lcom/github/mikephil/charting/components/Legend$LegendPosition;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getStackSpace;
#pragma warning disable 0169
		static Delegate GetGetStackSpaceHandler ()
		{
			if (cb_getStackSpace == null)
				cb_getStackSpace = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetStackSpace);
			return cb_getStackSpace;
		}

		static float n_GetStackSpace (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.StackSpace;
		}
#pragma warning restore 0169

		static Delegate cb_setStackSpace_F;
#pragma warning disable 0169
		static Delegate GetSetStackSpace_FHandler ()
		{
			if (cb_setStackSpace_F == null)
				cb_setStackSpace_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetStackSpace_F);
			return cb_setStackSpace_F;
		}

		static void n_SetStackSpace_F (IntPtr jnienv, IntPtr native__this, float space)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StackSpace = space;
		}
#pragma warning restore 0169

		public virtual unsafe float StackSpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getStackSpace' and count(parameter)=0]"
			[Register ("getStackSpace", "()F", "GetGetStackSpaceHandler")]
			get {
				const string __id = "getStackSpace.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='setStackSpace' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setStackSpace", "(F)V", "GetSetStackSpace_FHandler")]
			set {
				const string __id = "setStackSpace.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getVerticalAlignment;
#pragma warning disable 0169
		static Delegate GetGetVerticalAlignmentHandler ()
		{
			if (cb_getVerticalAlignment == null)
				cb_getVerticalAlignment = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVerticalAlignment);
			return cb_getVerticalAlignment;
		}

		static IntPtr n_GetVerticalAlignment (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VerticalAlignment);
		}
#pragma warning restore 0169

		static Delegate cb_setVerticalAlignment_Lcom_github_mikephil_charting_components_Legend_LegendVerticalAlignment_;
#pragma warning disable 0169
		static Delegate GetSetVerticalAlignment_Lcom_github_mikephil_charting_components_Legend_LegendVerticalAlignment_Handler ()
		{
			if (cb_setVerticalAlignment_Lcom_github_mikephil_charting_components_Legend_LegendVerticalAlignment_ == null)
				cb_setVerticalAlignment_Lcom_github_mikephil_charting_components_Legend_LegendVerticalAlignment_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetVerticalAlignment_Lcom_github_mikephil_charting_components_Legend_LegendVerticalAlignment_);
			return cb_setVerticalAlignment_Lcom_github_mikephil_charting_components_Legend_LegendVerticalAlignment_;
		}

		static void n_SetVerticalAlignment_Lcom_github_mikephil_charting_components_Legend_LegendVerticalAlignment_ (IntPtr jnienv, IntPtr native__this, IntPtr native_value)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.Legend.LegendVerticalAlignment value = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendVerticalAlignment> (native_value, JniHandleOwnership.DoNotTransfer);
			__this.VerticalAlignment = value;
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Components.Legend.LegendVerticalAlignment VerticalAlignment {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getVerticalAlignment' and count(parameter)=0]"
			[Register ("getVerticalAlignment", "()Lcom/github/mikephil/charting/components/Legend$LegendVerticalAlignment;", "GetGetVerticalAlignmentHandler")]
			get {
				const string __id = "getVerticalAlignment.()Lcom/github/mikephil/charting/components/Legend$LegendVerticalAlignment;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend.LegendVerticalAlignment> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='setVerticalAlignment' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.Legend.LegendVerticalAlignment']]"
			[Register ("setVerticalAlignment", "(Lcom/github/mikephil/charting/components/Legend$LegendVerticalAlignment;)V", "GetSetVerticalAlignment_Lcom_github_mikephil_charting_components_Legend_LegendVerticalAlignment_Handler")]
			set {
				const string __id = "setVerticalAlignment.(Lcom/github/mikephil/charting/components/Legend$LegendVerticalAlignment;)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((value == null) ? IntPtr.Zero : ((global::Java.Lang.Object) value).Handle);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_isWordWrapEnabled;
#pragma warning disable 0169
		static Delegate GetIsWordWrapEnabledHandler ()
		{
			if (cb_isWordWrapEnabled == null)
				cb_isWordWrapEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsWordWrapEnabled);
			return cb_isWordWrapEnabled;
		}

		static bool n_IsWordWrapEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.WordWrapEnabled;
		}
#pragma warning restore 0169

		static Delegate cb_setWordWrapEnabled_Z;
#pragma warning disable 0169
		static Delegate GetSetWordWrapEnabled_ZHandler ()
		{
			if (cb_setWordWrapEnabled_Z == null)
				cb_setWordWrapEnabled_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetWordWrapEnabled_Z);
			return cb_setWordWrapEnabled_Z;
		}

		static void n_SetWordWrapEnabled_Z (IntPtr jnienv, IntPtr native__this, bool enabled)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.WordWrapEnabled = enabled;
		}
#pragma warning restore 0169

		public virtual unsafe bool WordWrapEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='isWordWrapEnabled' and count(parameter)=0]"
			[Register ("isWordWrapEnabled", "()Z", "GetIsWordWrapEnabledHandler")]
			get {
				const string __id = "isWordWrapEnabled.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='setWordWrapEnabled' and count(parameter)=1 and parameter[1][@type='boolean']]"
			[Register ("setWordWrapEnabled", "(Z)V", "GetSetWordWrapEnabled_ZHandler")]
			set {
				const string __id = "setWordWrapEnabled.(Z)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getXEntrySpace;
#pragma warning disable 0169
		static Delegate GetGetXEntrySpaceHandler ()
		{
			if (cb_getXEntrySpace == null)
				cb_getXEntrySpace = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetXEntrySpace);
			return cb_getXEntrySpace;
		}

		static float n_GetXEntrySpace (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.XEntrySpace;
		}
#pragma warning restore 0169

		static Delegate cb_setXEntrySpace_F;
#pragma warning disable 0169
		static Delegate GetSetXEntrySpace_FHandler ()
		{
			if (cb_setXEntrySpace_F == null)
				cb_setXEntrySpace_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetXEntrySpace_F);
			return cb_setXEntrySpace_F;
		}

		static void n_SetXEntrySpace_F (IntPtr jnienv, IntPtr native__this, float space)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.XEntrySpace = space;
		}
#pragma warning restore 0169

		public virtual unsafe float XEntrySpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getXEntrySpace' and count(parameter)=0]"
			[Register ("getXEntrySpace", "()F", "GetGetXEntrySpaceHandler")]
			get {
				const string __id = "getXEntrySpace.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='setXEntrySpace' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setXEntrySpace", "(F)V", "GetSetXEntrySpace_FHandler")]
			set {
				const string __id = "setXEntrySpace.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_getYEntrySpace;
#pragma warning disable 0169
		static Delegate GetGetYEntrySpaceHandler ()
		{
			if (cb_getYEntrySpace == null)
				cb_getYEntrySpace = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetYEntrySpace);
			return cb_getYEntrySpace;
		}

		static float n_GetYEntrySpace (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.YEntrySpace;
		}
#pragma warning restore 0169

		static Delegate cb_setYEntrySpace_F;
#pragma warning disable 0169
		static Delegate GetSetYEntrySpace_FHandler ()
		{
			if (cb_setYEntrySpace_F == null)
				cb_setYEntrySpace_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetYEntrySpace_F);
			return cb_setYEntrySpace_F;
		}

		static void n_SetYEntrySpace_F (IntPtr jnienv, IntPtr native__this, float space)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.YEntrySpace = space;
		}
#pragma warning restore 0169

		public virtual unsafe float YEntrySpace {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getYEntrySpace' and count(parameter)=0]"
			[Register ("getYEntrySpace", "()F", "GetGetYEntrySpaceHandler")]
			get {
				const string __id = "getYEntrySpace.()F";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='setYEntrySpace' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setYEntrySpace", "(F)V", "GetSetYEntrySpace_FHandler")]
			set {
				const string __id = "setYEntrySpace.(F)V";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (value);
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
				} finally {
				}
			}
		}

		static Delegate cb_calculateDimensions_Landroid_graphics_Paint_Lcom_github_mikephil_charting_utils_ViewPortHandler_;
#pragma warning disable 0169
		static Delegate GetCalculateDimensions_Landroid_graphics_Paint_Lcom_github_mikephil_charting_utils_ViewPortHandler_Handler ()
		{
			if (cb_calculateDimensions_Landroid_graphics_Paint_Lcom_github_mikephil_charting_utils_ViewPortHandler_ == null)
				cb_calculateDimensions_Landroid_graphics_Paint_Lcom_github_mikephil_charting_utils_ViewPortHandler_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_CalculateDimensions_Landroid_graphics_Paint_Lcom_github_mikephil_charting_utils_ViewPortHandler_);
			return cb_calculateDimensions_Landroid_graphics_Paint_Lcom_github_mikephil_charting_utils_ViewPortHandler_;
		}

		static void n_CalculateDimensions_Landroid_graphics_Paint_Lcom_github_mikephil_charting_utils_ViewPortHandler_ (IntPtr jnienv, IntPtr native__this, IntPtr native_labelpaint, IntPtr native_viewPortHandler)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint labelpaint = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_labelpaint, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (native_viewPortHandler, JniHandleOwnership.DoNotTransfer);
			__this.CalculateDimensions (labelpaint, viewPortHandler);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='calculateDimensions' and count(parameter)=2 and parameter[1][@type='android.graphics.Paint'] and parameter[2][@type='com.github.mikephil.charting.utils.ViewPortHandler']]"
		[Register ("calculateDimensions", "(Landroid/graphics/Paint;Lcom/github/mikephil/charting/utils/ViewPortHandler;)V", "GetCalculateDimensions_Landroid_graphics_Paint_Lcom_github_mikephil_charting_utils_ViewPortHandler_Handler")]
		public virtual unsafe void CalculateDimensions (global::Android.Graphics.Paint labelpaint, global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler)
		{
			const string __id = "calculateDimensions.(Landroid/graphics/Paint;Lcom/github/mikephil/charting/utils/ViewPortHandler;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((labelpaint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) labelpaint).Handle);
				__args [1] = new JniArgumentValue ((viewPortHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPortHandler).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getColors;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetColorsHandler ()
		{
			if (cb_getColors == null)
				cb_getColors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetColors);
			return cb_getColors;
		}

		[Obsolete]
		static IntPtr n_GetColors (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetColors ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getColors' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
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

		static Delegate cb_getEntries;
#pragma warning disable 0169
		static Delegate GetGetEntriesHandler ()
		{
			if (cb_getEntries == null)
				cb_getEntries = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEntries);
			return cb_getEntries;
		}

		static IntPtr n_GetEntries (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetEntries ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getEntries' and count(parameter)=0]"
		[Register ("getEntries", "()[Lcom/github/mikephil/charting/components/LegendEntry;", "GetGetEntriesHandler")]
		public virtual unsafe global::MikePhil.Charting.Components.LegendEntry[] GetEntries ()
		{
			const string __id = "getEntries.()[Lcom/github/mikephil/charting/components/LegendEntry;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::MikePhil.Charting.Components.LegendEntry[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::MikePhil.Charting.Components.LegendEntry));
			} finally {
			}
		}

		static Delegate cb_getExtraColors;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetExtraColorsHandler ()
		{
			if (cb_getExtraColors == null)
				cb_getExtraColors = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtraColors);
			return cb_getExtraColors;
		}

		[Obsolete]
		static IntPtr n_GetExtraColors (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetExtraColors ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getExtraColors' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("getExtraColors", "()[I", "GetGetExtraColorsHandler")]
		public virtual unsafe int[] GetExtraColors ()
		{
			const string __id = "getExtraColors.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

		static Delegate cb_getExtraEntries;
#pragma warning disable 0169
		static Delegate GetGetExtraEntriesHandler ()
		{
			if (cb_getExtraEntries == null)
				cb_getExtraEntries = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtraEntries);
			return cb_getExtraEntries;
		}

		static IntPtr n_GetExtraEntries (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetExtraEntries ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getExtraEntries' and count(parameter)=0]"
		[Register ("getExtraEntries", "()[Lcom/github/mikephil/charting/components/LegendEntry;", "GetGetExtraEntriesHandler")]
		public virtual unsafe global::MikePhil.Charting.Components.LegendEntry[] GetExtraEntries ()
		{
			const string __id = "getExtraEntries.()[Lcom/github/mikephil/charting/components/LegendEntry;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (global::MikePhil.Charting.Components.LegendEntry[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::MikePhil.Charting.Components.LegendEntry));
			} finally {
			}
		}

		static Delegate cb_getExtraLabels;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetExtraLabelsHandler ()
		{
			if (cb_getExtraLabels == null)
				cb_getExtraLabels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExtraLabels);
			return cb_getExtraLabels;
		}

		[Obsolete]
		static IntPtr n_GetExtraLabels (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetExtraLabels ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getExtraLabels' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("getExtraLabels", "()[Ljava/lang/String;", "GetGetExtraLabelsHandler")]
		public virtual unsafe string[] GetExtraLabels ()
		{
			const string __id = "getExtraLabels.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_getLabels;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetGetLabelsHandler ()
		{
			if (cb_getLabels == null)
				cb_getLabels = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLabels);
			return cb_getLabels;
		}

		[Obsolete]
		static IntPtr n_GetLabels (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetLabels ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getLabels' and count(parameter)=0]"
		[Obsolete (@"deprecated")]
		[Register ("getLabels", "()[Ljava/lang/String;", "GetGetLabelsHandler")]
		public virtual unsafe string[] GetLabels ()
		{
			const string __id = "getLabels.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

		static Delegate cb_getMaximumEntryHeight_Landroid_graphics_Paint_;
#pragma warning disable 0169
		static Delegate GetGetMaximumEntryHeight_Landroid_graphics_Paint_Handler ()
		{
			if (cb_getMaximumEntryHeight_Landroid_graphics_Paint_ == null)
				cb_getMaximumEntryHeight_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float>) n_GetMaximumEntryHeight_Landroid_graphics_Paint_);
			return cb_getMaximumEntryHeight_Landroid_graphics_Paint_;
		}

		static float n_GetMaximumEntryHeight_Landroid_graphics_Paint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetMaximumEntryHeight (p);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getMaximumEntryHeight' and count(parameter)=1 and parameter[1][@type='android.graphics.Paint']]"
		[Register ("getMaximumEntryHeight", "(Landroid/graphics/Paint;)F", "GetGetMaximumEntryHeight_Landroid_graphics_Paint_Handler")]
		public virtual unsafe float GetMaximumEntryHeight (global::Android.Graphics.Paint p)
		{
			const string __id = "getMaximumEntryHeight.(Landroid/graphics/Paint;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_getMaximumEntryWidth_Landroid_graphics_Paint_;
#pragma warning disable 0169
		static Delegate GetGetMaximumEntryWidth_Landroid_graphics_Paint_Handler ()
		{
			if (cb_getMaximumEntryWidth_Landroid_graphics_Paint_ == null)
				cb_getMaximumEntryWidth_Landroid_graphics_Paint_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float>) n_GetMaximumEntryWidth_Landroid_graphics_Paint_);
			return cb_getMaximumEntryWidth_Landroid_graphics_Paint_;
		}

		static float n_GetMaximumEntryWidth_Landroid_graphics_Paint_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Paint p = global::Java.Lang.Object.GetObject<global::Android.Graphics.Paint> (native_p, JniHandleOwnership.DoNotTransfer);
			float __ret = __this.GetMaximumEntryWidth (p);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='getMaximumEntryWidth' and count(parameter)=1 and parameter[1][@type='android.graphics.Paint']]"
		[Register ("getMaximumEntryWidth", "(Landroid/graphics/Paint;)F", "GetGetMaximumEntryWidth_Landroid_graphics_Paint_Handler")]
		public virtual unsafe float GetMaximumEntryWidth (global::Android.Graphics.Paint p)
		{
			const string __id = "getMaximumEntryWidth.(Landroid/graphics/Paint;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((p == null) ? IntPtr.Zero : ((global::Java.Lang.Object) p).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		static Delegate cb_resetCustom;
#pragma warning disable 0169
		static Delegate GetResetCustomHandler ()
		{
			if (cb_resetCustom == null)
				cb_resetCustom = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ResetCustom);
			return cb_resetCustom;
		}

		static void n_ResetCustom (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ResetCustom ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='resetCustom' and count(parameter)=0]"
		[Register ("resetCustom", "()V", "GetResetCustomHandler")]
		public virtual unsafe void ResetCustom ()
		{
			const string __id = "resetCustom.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setCustom_arrayLcom_github_mikephil_charting_components_LegendEntry_;
#pragma warning disable 0169
		static Delegate GetSetCustom_arrayLcom_github_mikephil_charting_components_LegendEntry_Handler ()
		{
			if (cb_setCustom_arrayLcom_github_mikephil_charting_components_LegendEntry_ == null)
				cb_setCustom_arrayLcom_github_mikephil_charting_components_LegendEntry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustom_arrayLcom_github_mikephil_charting_components_LegendEntry_);
			return cb_setCustom_arrayLcom_github_mikephil_charting_components_LegendEntry_;
		}

		static void n_SetCustom_arrayLcom_github_mikephil_charting_components_LegendEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_entries)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.LegendEntry[] entries = (global::MikePhil.Charting.Components.LegendEntry[]) JNIEnv.GetArray (native_entries, JniHandleOwnership.DoNotTransfer, typeof (global::MikePhil.Charting.Components.LegendEntry));
			__this.SetCustom (entries);
			if (entries != null)
				JNIEnv.CopyArray (entries, native_entries);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='setCustom' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.LegendEntry[]']]"
		[Register ("setCustom", "([Lcom/github/mikephil/charting/components/LegendEntry;)V", "GetSetCustom_arrayLcom_github_mikephil_charting_components_LegendEntry_Handler")]
		public virtual unsafe void SetCustom (global::MikePhil.Charting.Components.LegendEntry[] entries)
		{
			const string __id = "setCustom.([Lcom/github/mikephil/charting/components/LegendEntry;)V";
			IntPtr native_entries = JNIEnv.NewArray (entries);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_entries);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (entries != null) {
					JNIEnv.CopyArray (native_entries, entries);
					JNIEnv.DeleteLocalRef (native_entries);
				}
			}
		}

		static Delegate cb_setCustom_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetCustom_Ljava_util_List_Handler ()
		{
			if (cb_setCustom_Ljava_util_List_ == null)
				cb_setCustom_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetCustom_Ljava_util_List_);
			return cb_setCustom_Ljava_util_List_;
		}

		static void n_SetCustom_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_entries)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var entries = global::Android.Runtime.JavaList<global::MikePhil.Charting.Components.LegendEntry>.FromJniHandle (native_entries, JniHandleOwnership.DoNotTransfer);
			__this.SetCustom (entries);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='setCustom' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.github.mikephil.charting.components.LegendEntry&gt;']]"
		[Register ("setCustom", "(Ljava/util/List;)V", "GetSetCustom_Ljava_util_List_Handler")]
		public virtual unsafe void SetCustom (global::System.Collections.Generic.IList<global::MikePhil.Charting.Components.LegendEntry> entries)
		{
			const string __id = "setCustom.(Ljava/util/List;)V";
			IntPtr native_entries = global::Android.Runtime.JavaList<global::MikePhil.Charting.Components.LegendEntry>.ToLocalJniHandle (entries);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_entries);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_entries);
			}
		}

		static Delegate cb_setDrawInside_Z;
#pragma warning disable 0169
		static Delegate GetSetDrawInside_ZHandler ()
		{
			if (cb_setDrawInside_Z == null)
				cb_setDrawInside_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetDrawInside_Z);
			return cb_setDrawInside_Z;
		}

		static void n_SetDrawInside_Z (IntPtr jnienv, IntPtr native__this, bool value)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetDrawInside (value);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='setDrawInside' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setDrawInside", "(Z)V", "GetSetDrawInside_ZHandler")]
		public virtual unsafe void SetDrawInside (bool value)
		{
			const string __id = "setDrawInside.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (value);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_setEntries_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetEntries_Ljava_util_List_Handler ()
		{
			if (cb_setEntries_Ljava_util_List_ == null)
				cb_setEntries_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetEntries_Ljava_util_List_);
			return cb_setEntries_Ljava_util_List_;
		}

		static void n_SetEntries_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_entries)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var entries = global::Android.Runtime.JavaList<global::MikePhil.Charting.Components.LegendEntry>.FromJniHandle (native_entries, JniHandleOwnership.DoNotTransfer);
			__this.SetEntries (entries);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='setEntries' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.github.mikephil.charting.components.LegendEntry&gt;']]"
		[Register ("setEntries", "(Ljava/util/List;)V", "GetSetEntries_Ljava_util_List_Handler")]
		public virtual unsafe void SetEntries (global::System.Collections.Generic.IList<global::MikePhil.Charting.Components.LegendEntry> entries)
		{
			const string __id = "setEntries.(Ljava/util/List;)V";
			IntPtr native_entries = global::Android.Runtime.JavaList<global::MikePhil.Charting.Components.LegendEntry>.ToLocalJniHandle (entries);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_entries);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_entries);
			}
		}

		static Delegate cb_setExtra_arrayLcom_github_mikephil_charting_components_LegendEntry_;
#pragma warning disable 0169
		static Delegate GetSetExtra_arrayLcom_github_mikephil_charting_components_LegendEntry_Handler ()
		{
			if (cb_setExtra_arrayLcom_github_mikephil_charting_components_LegendEntry_ == null)
				cb_setExtra_arrayLcom_github_mikephil_charting_components_LegendEntry_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExtra_arrayLcom_github_mikephil_charting_components_LegendEntry_);
			return cb_setExtra_arrayLcom_github_mikephil_charting_components_LegendEntry_;
		}

		static void n_SetExtra_arrayLcom_github_mikephil_charting_components_LegendEntry_ (IntPtr jnienv, IntPtr native__this, IntPtr native_entries)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Components.LegendEntry[] entries = (global::MikePhil.Charting.Components.LegendEntry[]) JNIEnv.GetArray (native_entries, JniHandleOwnership.DoNotTransfer, typeof (global::MikePhil.Charting.Components.LegendEntry));
			__this.SetExtra (entries);
			if (entries != null)
				JNIEnv.CopyArray (entries, native_entries);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='setExtra' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.components.LegendEntry[]']]"
		[Register ("setExtra", "([Lcom/github/mikephil/charting/components/LegendEntry;)V", "GetSetExtra_arrayLcom_github_mikephil_charting_components_LegendEntry_Handler")]
		public virtual unsafe void SetExtra (global::MikePhil.Charting.Components.LegendEntry[] entries)
		{
			const string __id = "setExtra.([Lcom/github/mikephil/charting/components/LegendEntry;)V";
			IntPtr native_entries = JNIEnv.NewArray (entries);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_entries);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (entries != null) {
					JNIEnv.CopyArray (native_entries, entries);
					JNIEnv.DeleteLocalRef (native_entries);
				}
			}
		}

		static Delegate cb_setExtra_arrayIarrayLjava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetExtra_arrayIarrayLjava_lang_String_Handler ()
		{
			if (cb_setExtra_arrayIarrayLjava_lang_String_ == null)
				cb_setExtra_arrayIarrayLjava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetExtra_arrayIarrayLjava_lang_String_);
			return cb_setExtra_arrayIarrayLjava_lang_String_;
		}

		static void n_SetExtra_arrayIarrayLjava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_colors, IntPtr native_labels)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			int[] colors = (int[]) JNIEnv.GetArray (native_colors, JniHandleOwnership.DoNotTransfer, typeof (int));
			string[] labels = (string[]) JNIEnv.GetArray (native_labels, JniHandleOwnership.DoNotTransfer, typeof (string));
			__this.SetExtra (colors, labels);
			if (colors != null)
				JNIEnv.CopyArray (colors, native_colors);
			if (labels != null)
				JNIEnv.CopyArray (labels, native_labels);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='setExtra' and count(parameter)=2 and parameter[1][@type='int[]'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("setExtra", "([I[Ljava/lang/String;)V", "GetSetExtra_arrayIarrayLjava_lang_String_Handler")]
		public virtual unsafe void SetExtra (int[] colors, string[] labels)
		{
			const string __id = "setExtra.([I[Ljava/lang/String;)V";
			IntPtr native_colors = JNIEnv.NewArray (colors);
			IntPtr native_labels = JNIEnv.NewArray (labels);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_colors);
				__args [1] = new JniArgumentValue (native_labels);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (colors != null) {
					JNIEnv.CopyArray (native_colors, colors);
					JNIEnv.DeleteLocalRef (native_colors);
				}
				if (labels != null) {
					JNIEnv.CopyArray (native_labels, labels);
					JNIEnv.DeleteLocalRef (native_labels);
				}
			}
		}

		static Delegate cb_setExtra_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetSetExtra_Ljava_util_List_Handler ()
		{
			if (cb_setExtra_Ljava_util_List_ == null)
				cb_setExtra_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetExtra_Ljava_util_List_);
			return cb_setExtra_Ljava_util_List_;
		}

		static void n_SetExtra_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_entries)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var entries = global::Android.Runtime.JavaList<global::MikePhil.Charting.Components.LegendEntry>.FromJniHandle (native_entries, JniHandleOwnership.DoNotTransfer);
			__this.SetExtra (entries);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='setExtra' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;com.github.mikephil.charting.components.LegendEntry&gt;']]"
		[Register ("setExtra", "(Ljava/util/List;)V", "GetSetExtra_Ljava_util_List_Handler")]
		public virtual unsafe void SetExtra (global::System.Collections.Generic.IList<global::MikePhil.Charting.Components.LegendEntry> entries)
		{
			const string __id = "setExtra.(Ljava/util/List;)V";
			IntPtr native_entries = global::Android.Runtime.JavaList<global::MikePhil.Charting.Components.LegendEntry>.ToLocalJniHandle (entries);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_entries);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_entries);
			}
		}

		static Delegate cb_setExtra_Ljava_util_List_Ljava_util_List_;
#pragma warning disable 0169
		[Obsolete]
		static Delegate GetSetExtra_Ljava_util_List_Ljava_util_List_Handler ()
		{
			if (cb_setExtra_Ljava_util_List_Ljava_util_List_ == null)
				cb_setExtra_Ljava_util_List_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SetExtra_Ljava_util_List_Ljava_util_List_);
			return cb_setExtra_Ljava_util_List_Ljava_util_List_;
		}

		[Obsolete]
		static void n_SetExtra_Ljava_util_List_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_colors, IntPtr native_labels)
		{
			global::MikePhil.Charting.Components.Legend __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Components.Legend> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var colors = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (native_colors, JniHandleOwnership.DoNotTransfer);
			var labels = global::Android.Runtime.JavaList<string>.FromJniHandle (native_labels, JniHandleOwnership.DoNotTransfer);
			__this.SetExtra (colors, labels);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.components']/class[@name='Legend']/method[@name='setExtra' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.Integer&gt;'] and parameter[2][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Obsolete (@"deprecated")]
		[Register ("setExtra", "(Ljava/util/List;Ljava/util/List;)V", "GetSetExtra_Ljava_util_List_Ljava_util_List_Handler")]
		public virtual unsafe void SetExtra (global::System.Collections.Generic.IList<global::Java.Lang.Integer> colors, global::System.Collections.Generic.IList<string> labels)
		{
			const string __id = "setExtra.(Ljava/util/List;Ljava/util/List;)V";
			IntPtr native_colors = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (colors);
			IntPtr native_labels = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (labels);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_colors);
				__args [1] = new JniArgumentValue (native_labels);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_colors);
				JNIEnv.DeleteLocalRef (native_labels);
			}
		}

	}
}
