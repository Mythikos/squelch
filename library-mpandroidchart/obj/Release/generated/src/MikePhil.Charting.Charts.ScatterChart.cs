using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Charts {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='ScatterChart']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/charts/ScatterChart", DoNotGenerateAcw=true)]
	public partial class ScatterChart : global::MikePhil.Charting.Charts.BarLineChartBase, global::MikePhil.Charting.Interfaces.Dataprovider.IScatterDataProvider {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='ScatterChart.ScatterShape']"
		[global::Android.Runtime.Register ("com/github/mikephil/charting/charts/ScatterChart$ScatterShape", DoNotGenerateAcw=true)]
		public sealed partial class ScatterShape : global::Java.Lang.Enum {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='ScatterChart.ScatterShape']/field[@name='CHEVRON_DOWN']"
			[Register ("CHEVRON_DOWN")]
			public static global::MikePhil.Charting.Charts.ScatterChart.ScatterShape ChevronDown {
				get {
					const string __id = "CHEVRON_DOWN.Lcom/github/mikephil/charting/charts/ScatterChart$ScatterShape;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.ScatterChart.ScatterShape> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='ScatterChart.ScatterShape']/field[@name='CHEVRON_UP']"
			[Register ("CHEVRON_UP")]
			public static global::MikePhil.Charting.Charts.ScatterChart.ScatterShape ChevronUp {
				get {
					const string __id = "CHEVRON_UP.Lcom/github/mikephil/charting/charts/ScatterChart$ScatterShape;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.ScatterChart.ScatterShape> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='ScatterChart.ScatterShape']/field[@name='CIRCLE']"
			[Register ("CIRCLE")]
			public static global::MikePhil.Charting.Charts.ScatterChart.ScatterShape Circle {
				get {
					const string __id = "CIRCLE.Lcom/github/mikephil/charting/charts/ScatterChart$ScatterShape;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.ScatterChart.ScatterShape> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='ScatterChart.ScatterShape']/field[@name='CROSS']"
			[Register ("CROSS")]
			public static global::MikePhil.Charting.Charts.ScatterChart.ScatterShape Cross {
				get {
					const string __id = "CROSS.Lcom/github/mikephil/charting/charts/ScatterChart$ScatterShape;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.ScatterChart.ScatterShape> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='ScatterChart.ScatterShape']/field[@name='SQUARE']"
			[Register ("SQUARE")]
			public static global::MikePhil.Charting.Charts.ScatterChart.ScatterShape Square {
				get {
					const string __id = "SQUARE.Lcom/github/mikephil/charting/charts/ScatterChart$ScatterShape;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.ScatterChart.ScatterShape> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='ScatterChart.ScatterShape']/field[@name='TRIANGLE']"
			[Register ("TRIANGLE")]
			public static global::MikePhil.Charting.Charts.ScatterChart.ScatterShape Triangle {
				get {
					const string __id = "TRIANGLE.Lcom/github/mikephil/charting/charts/ScatterChart$ScatterShape;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.ScatterChart.ScatterShape> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='ScatterChart.ScatterShape']/field[@name='X']"
			[Register ("X")]
			public static global::MikePhil.Charting.Charts.ScatterChart.ScatterShape X {
				get {
					const string __id = "X.Lcom/github/mikephil/charting/charts/ScatterChart$ScatterShape;";

					var __v = _members.StaticFields.GetObjectValue (__id);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.ScatterChart.ScatterShape> (__v.Handle, JniHandleOwnership.TransferLocalRef);
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/charts/ScatterChart$ScatterShape", typeof (ScatterShape));
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

			internal ScatterShape (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='ScatterChart.ScatterShape']/method[@name='getAllDefaultShapes' and count(parameter)=0]"
			[Register ("getAllDefaultShapes", "()[Lcom/github/mikephil/charting/charts/ScatterChart$ScatterShape;", "")]
			public static unsafe global::MikePhil.Charting.Charts.ScatterChart.ScatterShape[] GetAllDefaultShapes ()
			{
				const string __id = "getAllDefaultShapes.()[Lcom/github/mikephil/charting/charts/ScatterChart$ScatterShape;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::MikePhil.Charting.Charts.ScatterChart.ScatterShape[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::MikePhil.Charting.Charts.ScatterChart.ScatterShape));
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='ScatterChart.ScatterShape']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/github/mikephil/charting/charts/ScatterChart$ScatterShape;", "")]
			public static unsafe global::MikePhil.Charting.Charts.ScatterChart.ScatterShape ValueOf (string name)
			{
				const string __id = "valueOf.(Ljava/lang/String;)Lcom/github/mikephil/charting/charts/ScatterChart$ScatterShape;";
				IntPtr native_name = JNIEnv.NewString (name);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_name);
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.ScatterChart.ScatterShape> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_name);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='ScatterChart.ScatterShape']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/github/mikephil/charting/charts/ScatterChart$ScatterShape;", "")]
			public static unsafe global::MikePhil.Charting.Charts.ScatterChart.ScatterShape[] Values ()
			{
				const string __id = "values.()[Lcom/github/mikephil/charting/charts/ScatterChart$ScatterShape;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return (global::MikePhil.Charting.Charts.ScatterChart.ScatterShape[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (global::MikePhil.Charting.Charts.ScatterChart.ScatterShape));
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/charts/ScatterChart", typeof (ScatterChart));
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

		protected ScatterChart (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='ScatterChart']/constructor[@name='ScatterChart' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ScatterChart (global::Android.Content.Context context)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='ScatterChart']/constructor[@name='ScatterChart' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public unsafe ScatterChart (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs)
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='ScatterChart']/constructor[@name='ScatterChart' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public unsafe ScatterChart (global::Android.Content.Context context, global::Android.Util.IAttributeSet attrs, int defStyle)
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
			global::MikePhil.Charting.Charts.ScatterChart __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Charts.ScatterChart> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ScatterData);
		}
#pragma warning restore 0169

		public virtual unsafe global::MikePhil.Charting.Data.ScatterData ScatterData {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.charts']/class[@name='ScatterChart']/method[@name='getScatterData' and count(parameter)=0]"
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

	}
}
