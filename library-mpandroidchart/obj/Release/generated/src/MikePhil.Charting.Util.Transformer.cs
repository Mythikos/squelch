using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/utils/Transformer", DoNotGenerateAcw=true)]
	public partial class Transformer : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/field[@name='mMatrixOffset']"
		[Register ("mMatrixOffset")]
		protected global::Android.Graphics.Matrix MMatrixOffset {
			get {
				const string __id = "mMatrixOffset.Landroid/graphics/Matrix;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mMatrixOffset.Landroid/graphics/Matrix;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/field[@name='mMatrixValueToPx']"
		[Register ("mMatrixValueToPx")]
		protected global::Android.Graphics.Matrix MMatrixValueToPx {
			get {
				const string __id = "mMatrixValueToPx.Landroid/graphics/Matrix;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mMatrixValueToPx.Landroid/graphics/Matrix;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/field[@name='mPixelToValueMatrixBuffer']"
		[Register ("mPixelToValueMatrixBuffer")]
		protected global::Android.Graphics.Matrix MPixelToValueMatrixBuffer {
			get {
				const string __id = "mPixelToValueMatrixBuffer.Landroid/graphics/Matrix;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mPixelToValueMatrixBuffer.Landroid/graphics/Matrix;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/field[@name='mViewPortHandler']"
		[Register ("mViewPortHandler")]
		protected global::MikePhil.Charting.Util.ViewPortHandler MViewPortHandler {
			get {
				const string __id = "mViewPortHandler.Lcom/github/mikephil/charting/utils/ViewPortHandler;";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.ViewPortHandler> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "mViewPortHandler.Lcom/github/mikephil/charting/utils/ViewPortHandler;";

				IntPtr native_value = global::Android.Runtime.JNIEnv.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/field[@name='valuePointsForGenerateTransformedValuesBubble']"
		[Register ("valuePointsForGenerateTransformedValuesBubble")]
		protected IList<float> ValuePointsForGenerateTransformedValuesBubble {
			get {
				const string __id = "valuePointsForGenerateTransformedValuesBubble.[F";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<float>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "valuePointsForGenerateTransformedValuesBubble.[F";

				IntPtr native_value = global::Android.Runtime.JavaArray<float>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/field[@name='valuePointsForGenerateTransformedValuesCandle']"
		[Register ("valuePointsForGenerateTransformedValuesCandle")]
		protected IList<float> ValuePointsForGenerateTransformedValuesCandle {
			get {
				const string __id = "valuePointsForGenerateTransformedValuesCandle.[F";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<float>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "valuePointsForGenerateTransformedValuesCandle.[F";

				IntPtr native_value = global::Android.Runtime.JavaArray<float>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/field[@name='valuePointsForGenerateTransformedValuesLine']"
		[Register ("valuePointsForGenerateTransformedValuesLine")]
		protected IList<float> ValuePointsForGenerateTransformedValuesLine {
			get {
				const string __id = "valuePointsForGenerateTransformedValuesLine.[F";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<float>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "valuePointsForGenerateTransformedValuesLine.[F";

				IntPtr native_value = global::Android.Runtime.JavaArray<float>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/field[@name='valuePointsForGenerateTransformedValuesScatter']"
		[Register ("valuePointsForGenerateTransformedValuesScatter")]
		protected IList<float> ValuePointsForGenerateTransformedValuesScatter {
			get {
				const string __id = "valuePointsForGenerateTransformedValuesScatter.[F";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<float>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "valuePointsForGenerateTransformedValuesScatter.[F";

				IntPtr native_value = global::Android.Runtime.JavaArray<float>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/utils/Transformer", typeof (Transformer));
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

		protected Transformer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/constructor[@name='Transformer' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.utils.ViewPortHandler']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/utils/ViewPortHandler;)V", "")]
		public unsafe Transformer (global::MikePhil.Charting.Util.ViewPortHandler viewPortHandler)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/utils/ViewPortHandler;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((viewPortHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) viewPortHandler).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getOffsetMatrix;
#pragma warning disable 0169
		static Delegate GetGetOffsetMatrixHandler ()
		{
			if (cb_getOffsetMatrix == null)
				cb_getOffsetMatrix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOffsetMatrix);
			return cb_getOffsetMatrix;
		}

		static IntPtr n_GetOffsetMatrix (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.Transformer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.OffsetMatrix);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Matrix OffsetMatrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/method[@name='getOffsetMatrix' and count(parameter)=0]"
			[Register ("getOffsetMatrix", "()Landroid/graphics/Matrix;", "GetGetOffsetMatrixHandler")]
			get {
				const string __id = "getOffsetMatrix.()Landroid/graphics/Matrix;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPixelToValueMatrix;
#pragma warning disable 0169
		static Delegate GetGetPixelToValueMatrixHandler ()
		{
			if (cb_getPixelToValueMatrix == null)
				cb_getPixelToValueMatrix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPixelToValueMatrix);
			return cb_getPixelToValueMatrix;
		}

		static IntPtr n_GetPixelToValueMatrix (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.Transformer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.PixelToValueMatrix);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Matrix PixelToValueMatrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/method[@name='getPixelToValueMatrix' and count(parameter)=0]"
			[Register ("getPixelToValueMatrix", "()Landroid/graphics/Matrix;", "GetGetPixelToValueMatrixHandler")]
			get {
				const string __id = "getPixelToValueMatrix.()Landroid/graphics/Matrix;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getValueMatrix;
#pragma warning disable 0169
		static Delegate GetGetValueMatrixHandler ()
		{
			if (cb_getValueMatrix == null)
				cb_getValueMatrix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValueMatrix);
			return cb_getValueMatrix;
		}

		static IntPtr n_GetValueMatrix (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.Transformer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ValueMatrix);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Matrix ValueMatrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/method[@name='getValueMatrix' and count(parameter)=0]"
			[Register ("getValueMatrix", "()Landroid/graphics/Matrix;", "GetGetValueMatrixHandler")]
			get {
				const string __id = "getValueMatrix.()Landroid/graphics/Matrix;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getValueToPixelMatrix;
#pragma warning disable 0169
		static Delegate GetGetValueToPixelMatrixHandler ()
		{
			if (cb_getValueToPixelMatrix == null)
				cb_getValueToPixelMatrix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetValueToPixelMatrix);
			return cb_getValueToPixelMatrix;
		}

		static IntPtr n_GetValueToPixelMatrix (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Util.Transformer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ValueToPixelMatrix);
		}
#pragma warning restore 0169

		public virtual unsafe global::Android.Graphics.Matrix ValueToPixelMatrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/method[@name='getValueToPixelMatrix' and count(parameter)=0]"
			[Register ("getValueToPixelMatrix", "()Landroid/graphics/Matrix;", "GetGetValueToPixelMatrixHandler")]
			get {
				const string __id = "getValueToPixelMatrix.()Landroid/graphics/Matrix;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_generateTransformedValuesBubble_Lcom_github_mikephil_charting_interfaces_datasets_IBubbleDataSet_FII;
#pragma warning disable 0169
		static Delegate GetGenerateTransformedValuesBubble_Lcom_github_mikephil_charting_interfaces_datasets_IBubbleDataSet_FIIHandler ()
		{
			if (cb_generateTransformedValuesBubble_Lcom_github_mikephil_charting_interfaces_datasets_IBubbleDataSet_FII == null)
				cb_generateTransformedValuesBubble_Lcom_github_mikephil_charting_interfaces_datasets_IBubbleDataSet_FII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, int, int, IntPtr>) n_GenerateTransformedValuesBubble_Lcom_github_mikephil_charting_interfaces_datasets_IBubbleDataSet_FII);
			return cb_generateTransformedValuesBubble_Lcom_github_mikephil_charting_interfaces_datasets_IBubbleDataSet_FII;
		}

		static IntPtr n_GenerateTransformedValuesBubble_Lcom_github_mikephil_charting_interfaces_datasets_IBubbleDataSet_FII (IntPtr jnienv, IntPtr native__this, IntPtr native_data, float phaseY, int from, int to)
		{
			global::MikePhil.Charting.Util.Transformer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Interfaces.Datasets.IBubbleDataSet data = (global::MikePhil.Charting.Interfaces.Datasets.IBubbleDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IBubbleDataSet> (native_data, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GenerateTransformedValuesBubble (data, phaseY, from, to));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/method[@name='generateTransformedValuesBubble' and count(parameter)=4 and parameter[1][@type='com.github.mikephil.charting.interfaces.datasets.IBubbleDataSet'] and parameter[2][@type='float'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("generateTransformedValuesBubble", "(Lcom/github/mikephil/charting/interfaces/datasets/IBubbleDataSet;FII)[F", "GetGenerateTransformedValuesBubble_Lcom_github_mikephil_charting_interfaces_datasets_IBubbleDataSet_FIIHandler")]
		public virtual unsafe float[] GenerateTransformedValuesBubble (global::MikePhil.Charting.Interfaces.Datasets.IBubbleDataSet data, float phaseY, int from, int to)
		{
			const string __id = "generateTransformedValuesBubble.(Lcom/github/mikephil/charting/interfaces/datasets/IBubbleDataSet;FII)[F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [1] = new JniArgumentValue (phaseY);
				__args [2] = new JniArgumentValue (from);
				__args [3] = new JniArgumentValue (to);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_generateTransformedValuesCandle_Lcom_github_mikephil_charting_interfaces_datasets_ICandleDataSet_FFII;
#pragma warning disable 0169
		static Delegate GetGenerateTransformedValuesCandle_Lcom_github_mikephil_charting_interfaces_datasets_ICandleDataSet_FFIIHandler ()
		{
			if (cb_generateTransformedValuesCandle_Lcom_github_mikephil_charting_interfaces_datasets_ICandleDataSet_FFII == null)
				cb_generateTransformedValuesCandle_Lcom_github_mikephil_charting_interfaces_datasets_ICandleDataSet_FFII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, float, int, int, IntPtr>) n_GenerateTransformedValuesCandle_Lcom_github_mikephil_charting_interfaces_datasets_ICandleDataSet_FFII);
			return cb_generateTransformedValuesCandle_Lcom_github_mikephil_charting_interfaces_datasets_ICandleDataSet_FFII;
		}

		static IntPtr n_GenerateTransformedValuesCandle_Lcom_github_mikephil_charting_interfaces_datasets_ICandleDataSet_FFII (IntPtr jnienv, IntPtr native__this, IntPtr native_data, float phaseX, float phaseY, int from, int to)
		{
			global::MikePhil.Charting.Util.Transformer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Interfaces.Datasets.ICandleDataSet data = (global::MikePhil.Charting.Interfaces.Datasets.ICandleDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ICandleDataSet> (native_data, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GenerateTransformedValuesCandle (data, phaseX, phaseY, from, to));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/method[@name='generateTransformedValuesCandle' and count(parameter)=5 and parameter[1][@type='com.github.mikephil.charting.interfaces.datasets.ICandleDataSet'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("generateTransformedValuesCandle", "(Lcom/github/mikephil/charting/interfaces/datasets/ICandleDataSet;FFII)[F", "GetGenerateTransformedValuesCandle_Lcom_github_mikephil_charting_interfaces_datasets_ICandleDataSet_FFIIHandler")]
		public virtual unsafe float[] GenerateTransformedValuesCandle (global::MikePhil.Charting.Interfaces.Datasets.ICandleDataSet data, float phaseX, float phaseY, int from, int to)
		{
			const string __id = "generateTransformedValuesCandle.(Lcom/github/mikephil/charting/interfaces/datasets/ICandleDataSet;FFII)[F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [1] = new JniArgumentValue (phaseX);
				__args [2] = new JniArgumentValue (phaseY);
				__args [3] = new JniArgumentValue (from);
				__args [4] = new JniArgumentValue (to);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_generateTransformedValuesLine_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_FFII;
#pragma warning disable 0169
		static Delegate GetGenerateTransformedValuesLine_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_FFIIHandler ()
		{
			if (cb_generateTransformedValuesLine_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_FFII == null)
				cb_generateTransformedValuesLine_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_FFII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, float, int, int, IntPtr>) n_GenerateTransformedValuesLine_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_FFII);
			return cb_generateTransformedValuesLine_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_FFII;
		}

		static IntPtr n_GenerateTransformedValuesLine_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_FFII (IntPtr jnienv, IntPtr native__this, IntPtr native_data, float phaseX, float phaseY, int min, int max)
		{
			global::MikePhil.Charting.Util.Transformer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet data = (global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet> (native_data, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GenerateTransformedValuesLine (data, phaseX, phaseY, min, max));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/method[@name='generateTransformedValuesLine' and count(parameter)=5 and parameter[1][@type='com.github.mikephil.charting.interfaces.datasets.ILineDataSet'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("generateTransformedValuesLine", "(Lcom/github/mikephil/charting/interfaces/datasets/ILineDataSet;FFII)[F", "GetGenerateTransformedValuesLine_Lcom_github_mikephil_charting_interfaces_datasets_ILineDataSet_FFIIHandler")]
		public virtual unsafe float[] GenerateTransformedValuesLine (global::MikePhil.Charting.Interfaces.Datasets.ILineDataSet data, float phaseX, float phaseY, int min, int max)
		{
			const string __id = "generateTransformedValuesLine.(Lcom/github/mikephil/charting/interfaces/datasets/ILineDataSet;FFII)[F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [1] = new JniArgumentValue (phaseX);
				__args [2] = new JniArgumentValue (phaseY);
				__args [3] = new JniArgumentValue (min);
				__args [4] = new JniArgumentValue (max);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_generateTransformedValuesScatter_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_FFII;
#pragma warning disable 0169
		static Delegate GetGenerateTransformedValuesScatter_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_FFIIHandler ()
		{
			if (cb_generateTransformedValuesScatter_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_FFII == null)
				cb_generateTransformedValuesScatter_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_FFII = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, float, int, int, IntPtr>) n_GenerateTransformedValuesScatter_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_FFII);
			return cb_generateTransformedValuesScatter_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_FFII;
		}

		static IntPtr n_GenerateTransformedValuesScatter_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_FFII (IntPtr jnienv, IntPtr native__this, IntPtr native_data, float phaseX, float phaseY, int from, int to)
		{
			global::MikePhil.Charting.Util.Transformer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Interfaces.Datasets.IScatterDataSet data = (global::MikePhil.Charting.Interfaces.Datasets.IScatterDataSet)global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Interfaces.Datasets.IScatterDataSet> (native_data, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.GenerateTransformedValuesScatter (data, phaseX, phaseY, from, to));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/method[@name='generateTransformedValuesScatter' and count(parameter)=5 and parameter[1][@type='com.github.mikephil.charting.interfaces.datasets.IScatterDataSet'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("generateTransformedValuesScatter", "(Lcom/github/mikephil/charting/interfaces/datasets/IScatterDataSet;FFII)[F", "GetGenerateTransformedValuesScatter_Lcom_github_mikephil_charting_interfaces_datasets_IScatterDataSet_FFIIHandler")]
		public virtual unsafe float[] GenerateTransformedValuesScatter (global::MikePhil.Charting.Interfaces.Datasets.IScatterDataSet data, float phaseX, float phaseY, int from, int to)
		{
			const string __id = "generateTransformedValuesScatter.(Lcom/github/mikephil/charting/interfaces/datasets/IScatterDataSet;FFII)[F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((data == null) ? IntPtr.Zero : ((global::Java.Lang.Object) data).Handle);
				__args [1] = new JniArgumentValue (phaseX);
				__args [2] = new JniArgumentValue (phaseY);
				__args [3] = new JniArgumentValue (from);
				__args [4] = new JniArgumentValue (to);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
			}
		}

		static Delegate cb_getPixelForValues_FF;
#pragma warning disable 0169
		static Delegate GetGetPixelForValues_FFHandler ()
		{
			if (cb_getPixelForValues_FF == null)
				cb_getPixelForValues_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_GetPixelForValues_FF);
			return cb_getPixelForValues_FF;
		}

		static IntPtr n_GetPixelForValues_FF (IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			global::MikePhil.Charting.Util.Transformer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetPixelForValues (x, y));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/method[@name='getPixelForValues' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("getPixelForValues", "(FF)Lcom/github/mikephil/charting/utils/MPPointD;", "GetGetPixelForValues_FFHandler")]
		public virtual unsafe global::MikePhil.Charting.Util.MPPointD GetPixelForValues (float x, float y)
		{
			const string __id = "getPixelForValues.(FF)Lcom/github/mikephil/charting/utils/MPPointD;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointD> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getValuesByTouchPoint_FF;
#pragma warning disable 0169
		static Delegate GetGetValuesByTouchPoint_FFHandler ()
		{
			if (cb_getValuesByTouchPoint_FF == null)
				cb_getValuesByTouchPoint_FF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float, float, IntPtr>) n_GetValuesByTouchPoint_FF);
			return cb_getValuesByTouchPoint_FF;
		}

		static IntPtr n_GetValuesByTouchPoint_FF (IntPtr jnienv, IntPtr native__this, float x, float y)
		{
			global::MikePhil.Charting.Util.Transformer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.GetValuesByTouchPoint (x, y));
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/method[@name='getValuesByTouchPoint' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("getValuesByTouchPoint", "(FF)Lcom/github/mikephil/charting/utils/MPPointD;", "GetGetValuesByTouchPoint_FFHandler")]
		public virtual unsafe global::MikePhil.Charting.Util.MPPointD GetValuesByTouchPoint (float x, float y)
		{
			const string __id = "getValuesByTouchPoint.(FF)Lcom/github/mikephil/charting/utils/MPPointD;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointD> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getValuesByTouchPoint_FFLcom_github_mikephil_charting_utils_MPPointD_;
#pragma warning disable 0169
		static Delegate GetGetValuesByTouchPoint_FFLcom_github_mikephil_charting_utils_MPPointD_Handler ()
		{
			if (cb_getValuesByTouchPoint_FFLcom_github_mikephil_charting_utils_MPPointD_ == null)
				cb_getValuesByTouchPoint_FFLcom_github_mikephil_charting_utils_MPPointD_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, IntPtr>) n_GetValuesByTouchPoint_FFLcom_github_mikephil_charting_utils_MPPointD_);
			return cb_getValuesByTouchPoint_FFLcom_github_mikephil_charting_utils_MPPointD_;
		}

		static void n_GetValuesByTouchPoint_FFLcom_github_mikephil_charting_utils_MPPointD_ (IntPtr jnienv, IntPtr native__this, float x, float y, IntPtr native_outputPoint)
		{
			global::MikePhil.Charting.Util.Transformer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::MikePhil.Charting.Util.MPPointD outputPoint = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointD> (native_outputPoint, JniHandleOwnership.DoNotTransfer);
			__this.GetValuesByTouchPoint (x, y, outputPoint);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/method[@name='getValuesByTouchPoint' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='com.github.mikephil.charting.utils.MPPointD']]"
		[Register ("getValuesByTouchPoint", "(FFLcom/github/mikephil/charting/utils/MPPointD;)V", "GetGetValuesByTouchPoint_FFLcom_github_mikephil_charting_utils_MPPointD_Handler")]
		public virtual unsafe void GetValuesByTouchPoint (float x, float y, global::MikePhil.Charting.Util.MPPointD outputPoint)
		{
			const string __id = "getValuesByTouchPoint.(FFLcom/github/mikephil/charting/utils/MPPointD;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				__args [2] = new JniArgumentValue ((outputPoint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputPoint).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_pathValueToPixel_Landroid_graphics_Path_;
#pragma warning disable 0169
		static Delegate GetPathValueToPixel_Landroid_graphics_Path_Handler ()
		{
			if (cb_pathValueToPixel_Landroid_graphics_Path_ == null)
				cb_pathValueToPixel_Landroid_graphics_Path_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PathValueToPixel_Landroid_graphics_Path_);
			return cb_pathValueToPixel_Landroid_graphics_Path_;
		}

		static void n_PathValueToPixel_Landroid_graphics_Path_ (IntPtr jnienv, IntPtr native__this, IntPtr native_path)
		{
			global::MikePhil.Charting.Util.Transformer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Path path = global::Java.Lang.Object.GetObject<global::Android.Graphics.Path> (native_path, JniHandleOwnership.DoNotTransfer);
			__this.PathValueToPixel (path);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/method[@name='pathValueToPixel' and count(parameter)=1 and parameter[1][@type='android.graphics.Path']]"
		[Register ("pathValueToPixel", "(Landroid/graphics/Path;)V", "GetPathValueToPixel_Landroid_graphics_Path_Handler")]
		public virtual unsafe void PathValueToPixel (global::Android.Graphics.Path path)
		{
			const string __id = "pathValueToPixel.(Landroid/graphics/Path;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((path == null) ? IntPtr.Zero : ((global::Java.Lang.Object) path).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_pathValuesToPixel_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetPathValuesToPixel_Ljava_util_List_Handler ()
		{
			if (cb_pathValuesToPixel_Ljava_util_List_ == null)
				cb_pathValuesToPixel_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PathValuesToPixel_Ljava_util_List_);
			return cb_pathValuesToPixel_Ljava_util_List_;
		}

		static void n_PathValuesToPixel_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_paths)
		{
			global::MikePhil.Charting.Util.Transformer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var paths = global::Android.Runtime.JavaList<global::Android.Graphics.Path>.FromJniHandle (native_paths, JniHandleOwnership.DoNotTransfer);
			__this.PathValuesToPixel (paths);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/method[@name='pathValuesToPixel' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;android.graphics.Path&gt;']]"
		[Register ("pathValuesToPixel", "(Ljava/util/List;)V", "GetPathValuesToPixel_Ljava_util_List_Handler")]
		public virtual unsafe void PathValuesToPixel (global::System.Collections.Generic.IList<global::Android.Graphics.Path> paths)
		{
			const string __id = "pathValuesToPixel.(Ljava/util/List;)V";
			IntPtr native_paths = global::Android.Runtime.JavaList<global::Android.Graphics.Path>.ToLocalJniHandle (paths);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_paths);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_paths);
			}
		}

		static Delegate cb_pixelsToValue_arrayF;
#pragma warning disable 0169
		static Delegate GetPixelsToValue_arrayFHandler ()
		{
			if (cb_pixelsToValue_arrayF == null)
				cb_pixelsToValue_arrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PixelsToValue_arrayF);
			return cb_pixelsToValue_arrayF;
		}

		static void n_PixelsToValue_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_pixels)
		{
			global::MikePhil.Charting.Util.Transformer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] pixels = (float[]) JNIEnv.GetArray (native_pixels, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.PixelsToValue (pixels);
			if (pixels != null)
				JNIEnv.CopyArray (pixels, native_pixels);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/method[@name='pixelsToValue' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("pixelsToValue", "([F)V", "GetPixelsToValue_arrayFHandler")]
		public virtual unsafe void PixelsToValue (float[] pixels)
		{
			const string __id = "pixelsToValue.([F)V";
			IntPtr native_pixels = JNIEnv.NewArray (pixels);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_pixels);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (pixels != null) {
					JNIEnv.CopyArray (native_pixels, pixels);
					JNIEnv.DeleteLocalRef (native_pixels);
				}
			}
		}

		static Delegate cb_pointValuesToPixel_arrayF;
#pragma warning disable 0169
		static Delegate GetPointValuesToPixel_arrayFHandler ()
		{
			if (cb_pointValuesToPixel_arrayF == null)
				cb_pointValuesToPixel_arrayF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_PointValuesToPixel_arrayF);
			return cb_pointValuesToPixel_arrayF;
		}

		static void n_PointValuesToPixel_arrayF (IntPtr jnienv, IntPtr native__this, IntPtr native_pts)
		{
			global::MikePhil.Charting.Util.Transformer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] pts = (float[]) JNIEnv.GetArray (native_pts, JniHandleOwnership.DoNotTransfer, typeof (float));
			__this.PointValuesToPixel (pts);
			if (pts != null)
				JNIEnv.CopyArray (pts, native_pts);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/method[@name='pointValuesToPixel' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("pointValuesToPixel", "([F)V", "GetPointValuesToPixel_arrayFHandler")]
		public virtual unsafe void PointValuesToPixel (float[] pts)
		{
			const string __id = "pointValuesToPixel.([F)V";
			IntPtr native_pts = JNIEnv.NewArray (pts);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_pts);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				if (pts != null) {
					JNIEnv.CopyArray (native_pts, pts);
					JNIEnv.DeleteLocalRef (native_pts);
				}
			}
		}

		static Delegate cb_prepareMatrixOffset_Z;
#pragma warning disable 0169
		static Delegate GetPrepareMatrixOffset_ZHandler ()
		{
			if (cb_prepareMatrixOffset_Z == null)
				cb_prepareMatrixOffset_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_PrepareMatrixOffset_Z);
			return cb_prepareMatrixOffset_Z;
		}

		static void n_PrepareMatrixOffset_Z (IntPtr jnienv, IntPtr native__this, bool inverted)
		{
			global::MikePhil.Charting.Util.Transformer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PrepareMatrixOffset (inverted);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/method[@name='prepareMatrixOffset' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("prepareMatrixOffset", "(Z)V", "GetPrepareMatrixOffset_ZHandler")]
		public virtual unsafe void PrepareMatrixOffset (bool inverted)
		{
			const string __id = "prepareMatrixOffset.(Z)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (inverted);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_prepareMatrixValuePx_FFFF;
#pragma warning disable 0169
		static Delegate GetPrepareMatrixValuePx_FFFFHandler ()
		{
			if (cb_prepareMatrixValuePx_FFFF == null)
				cb_prepareMatrixValuePx_FFFF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, float>) n_PrepareMatrixValuePx_FFFF);
			return cb_prepareMatrixValuePx_FFFF;
		}

		static void n_PrepareMatrixValuePx_FFFF (IntPtr jnienv, IntPtr native__this, float xChartMin, float deltaX, float deltaY, float yChartMin)
		{
			global::MikePhil.Charting.Util.Transformer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.PrepareMatrixValuePx (xChartMin, deltaX, deltaY, yChartMin);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/method[@name='prepareMatrixValuePx' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("prepareMatrixValuePx", "(FFFF)V", "GetPrepareMatrixValuePx_FFFFHandler")]
		public virtual unsafe void PrepareMatrixValuePx (float xChartMin, float deltaX, float deltaY, float yChartMin)
		{
			const string __id = "prepareMatrixValuePx.(FFFF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (xChartMin);
				__args [1] = new JniArgumentValue (deltaX);
				__args [2] = new JniArgumentValue (deltaY);
				__args [3] = new JniArgumentValue (yChartMin);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_rectToPixelPhase_Landroid_graphics_RectF_F;
#pragma warning disable 0169
		static Delegate GetRectToPixelPhase_Landroid_graphics_RectF_FHandler ()
		{
			if (cb_rectToPixelPhase_Landroid_graphics_RectF_F == null)
				cb_rectToPixelPhase_Landroid_graphics_RectF_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float>) n_RectToPixelPhase_Landroid_graphics_RectF_F);
			return cb_rectToPixelPhase_Landroid_graphics_RectF_F;
		}

		static void n_RectToPixelPhase_Landroid_graphics_RectF_F (IntPtr jnienv, IntPtr native__this, IntPtr native_r, float phaseY)
		{
			global::MikePhil.Charting.Util.Transformer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.RectF r = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_r, JniHandleOwnership.DoNotTransfer);
			__this.RectToPixelPhase (r, phaseY);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/method[@name='rectToPixelPhase' and count(parameter)=2 and parameter[1][@type='android.graphics.RectF'] and parameter[2][@type='float']]"
		[Register ("rectToPixelPhase", "(Landroid/graphics/RectF;F)V", "GetRectToPixelPhase_Landroid_graphics_RectF_FHandler")]
		public virtual unsafe void RectToPixelPhase (global::Android.Graphics.RectF r, float phaseY)
		{
			const string __id = "rectToPixelPhase.(Landroid/graphics/RectF;F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((r == null) ? IntPtr.Zero : ((global::Java.Lang.Object) r).Handle);
				__args [1] = new JniArgumentValue (phaseY);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_rectToPixelPhaseHorizontal_Landroid_graphics_RectF_F;
#pragma warning disable 0169
		static Delegate GetRectToPixelPhaseHorizontal_Landroid_graphics_RectF_FHandler ()
		{
			if (cb_rectToPixelPhaseHorizontal_Landroid_graphics_RectF_F == null)
				cb_rectToPixelPhaseHorizontal_Landroid_graphics_RectF_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float>) n_RectToPixelPhaseHorizontal_Landroid_graphics_RectF_F);
			return cb_rectToPixelPhaseHorizontal_Landroid_graphics_RectF_F;
		}

		static void n_RectToPixelPhaseHorizontal_Landroid_graphics_RectF_F (IntPtr jnienv, IntPtr native__this, IntPtr native_r, float phaseY)
		{
			global::MikePhil.Charting.Util.Transformer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.RectF r = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_r, JniHandleOwnership.DoNotTransfer);
			__this.RectToPixelPhaseHorizontal (r, phaseY);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/method[@name='rectToPixelPhaseHorizontal' and count(parameter)=2 and parameter[1][@type='android.graphics.RectF'] and parameter[2][@type='float']]"
		[Register ("rectToPixelPhaseHorizontal", "(Landroid/graphics/RectF;F)V", "GetRectToPixelPhaseHorizontal_Landroid_graphics_RectF_FHandler")]
		public virtual unsafe void RectToPixelPhaseHorizontal (global::Android.Graphics.RectF r, float phaseY)
		{
			const string __id = "rectToPixelPhaseHorizontal.(Landroid/graphics/RectF;F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((r == null) ? IntPtr.Zero : ((global::Java.Lang.Object) r).Handle);
				__args [1] = new JniArgumentValue (phaseY);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_rectValueToPixel_Landroid_graphics_RectF_;
#pragma warning disable 0169
		static Delegate GetRectValueToPixel_Landroid_graphics_RectF_Handler ()
		{
			if (cb_rectValueToPixel_Landroid_graphics_RectF_ == null)
				cb_rectValueToPixel_Landroid_graphics_RectF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RectValueToPixel_Landroid_graphics_RectF_);
			return cb_rectValueToPixel_Landroid_graphics_RectF_;
		}

		static void n_RectValueToPixel_Landroid_graphics_RectF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_r)
		{
			global::MikePhil.Charting.Util.Transformer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.RectF r = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_r, JniHandleOwnership.DoNotTransfer);
			__this.RectValueToPixel (r);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/method[@name='rectValueToPixel' and count(parameter)=1 and parameter[1][@type='android.graphics.RectF']]"
		[Register ("rectValueToPixel", "(Landroid/graphics/RectF;)V", "GetRectValueToPixel_Landroid_graphics_RectF_Handler")]
		public virtual unsafe void RectValueToPixel (global::Android.Graphics.RectF r)
		{
			const string __id = "rectValueToPixel.(Landroid/graphics/RectF;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((r == null) ? IntPtr.Zero : ((global::Java.Lang.Object) r).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_rectValueToPixelHorizontal_Landroid_graphics_RectF_;
#pragma warning disable 0169
		static Delegate GetRectValueToPixelHorizontal_Landroid_graphics_RectF_Handler ()
		{
			if (cb_rectValueToPixelHorizontal_Landroid_graphics_RectF_ == null)
				cb_rectValueToPixelHorizontal_Landroid_graphics_RectF_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RectValueToPixelHorizontal_Landroid_graphics_RectF_);
			return cb_rectValueToPixelHorizontal_Landroid_graphics_RectF_;
		}

		static void n_RectValueToPixelHorizontal_Landroid_graphics_RectF_ (IntPtr jnienv, IntPtr native__this, IntPtr native_r)
		{
			global::MikePhil.Charting.Util.Transformer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.RectF r = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_r, JniHandleOwnership.DoNotTransfer);
			__this.RectValueToPixelHorizontal (r);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/method[@name='rectValueToPixelHorizontal' and count(parameter)=1 and parameter[1][@type='android.graphics.RectF']]"
		[Register ("rectValueToPixelHorizontal", "(Landroid/graphics/RectF;)V", "GetRectValueToPixelHorizontal_Landroid_graphics_RectF_Handler")]
		public virtual unsafe void RectValueToPixelHorizontal (global::Android.Graphics.RectF r)
		{
			const string __id = "rectValueToPixelHorizontal.(Landroid/graphics/RectF;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((r == null) ? IntPtr.Zero : ((global::Java.Lang.Object) r).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_rectValueToPixelHorizontal_Landroid_graphics_RectF_F;
#pragma warning disable 0169
		static Delegate GetRectValueToPixelHorizontal_Landroid_graphics_RectF_FHandler ()
		{
			if (cb_rectValueToPixelHorizontal_Landroid_graphics_RectF_F == null)
				cb_rectValueToPixelHorizontal_Landroid_graphics_RectF_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, float>) n_RectValueToPixelHorizontal_Landroid_graphics_RectF_F);
			return cb_rectValueToPixelHorizontal_Landroid_graphics_RectF_F;
		}

		static void n_RectValueToPixelHorizontal_Landroid_graphics_RectF_F (IntPtr jnienv, IntPtr native__this, IntPtr native_r, float phaseY)
		{
			global::MikePhil.Charting.Util.Transformer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.RectF r = global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (native_r, JniHandleOwnership.DoNotTransfer);
			__this.RectValueToPixelHorizontal (r, phaseY);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/method[@name='rectValueToPixelHorizontal' and count(parameter)=2 and parameter[1][@type='android.graphics.RectF'] and parameter[2][@type='float']]"
		[Register ("rectValueToPixelHorizontal", "(Landroid/graphics/RectF;F)V", "GetRectValueToPixelHorizontal_Landroid_graphics_RectF_FHandler")]
		public virtual unsafe void RectValueToPixelHorizontal (global::Android.Graphics.RectF r, float phaseY)
		{
			const string __id = "rectValueToPixelHorizontal.(Landroid/graphics/RectF;F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((r == null) ? IntPtr.Zero : ((global::Java.Lang.Object) r).Handle);
				__args [1] = new JniArgumentValue (phaseY);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_rectValuesToPixel_Ljava_util_List_;
#pragma warning disable 0169
		static Delegate GetRectValuesToPixel_Ljava_util_List_Handler ()
		{
			if (cb_rectValuesToPixel_Ljava_util_List_ == null)
				cb_rectValuesToPixel_Ljava_util_List_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RectValuesToPixel_Ljava_util_List_);
			return cb_rectValuesToPixel_Ljava_util_List_;
		}

		static void n_RectValuesToPixel_Ljava_util_List_ (IntPtr jnienv, IntPtr native__this, IntPtr native_rects)
		{
			global::MikePhil.Charting.Util.Transformer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.Transformer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var rects = global::Android.Runtime.JavaList<global::Android.Graphics.RectF>.FromJniHandle (native_rects, JniHandleOwnership.DoNotTransfer);
			__this.RectValuesToPixel (rects);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Transformer']/method[@name='rectValuesToPixel' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;android.graphics.RectF&gt;']]"
		[Register ("rectValuesToPixel", "(Ljava/util/List;)V", "GetRectValuesToPixel_Ljava_util_List_Handler")]
		public virtual unsafe void RectValuesToPixel (global::System.Collections.Generic.IList<global::Android.Graphics.RectF> rects)
		{
			const string __id = "rectValuesToPixel.(Ljava/util/List;)V";
			IntPtr native_rects = global::Android.Runtime.JavaList<global::Android.Graphics.RectF>.ToLocalJniHandle (rects);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_rects);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_rects);
			}
		}

	}
}
