using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/utils/Utils", DoNotGenerateAcw=true)]
	public abstract partial class Utils : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/field[@name='DEG2RAD']"
		[Register ("DEG2RAD")]
		public const double Deg2rad = (double) 0.017453292519943295;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/field[@name='DOUBLE_EPSILON']"
		[Register ("DOUBLE_EPSILON")]
		public static double DoubleEpsilon {
			get {
				const string __id = "DOUBLE_EPSILON.D";

				var __v = _members.StaticFields.GetDoubleValue (__id);
				return __v;
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/field[@name='FDEG2RAD']"
		[Register ("FDEG2RAD")]
		public const float Fdeg2rad = (float) 0.0174532924;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/field[@name='FLOAT_EPSILON']"
		[Register ("FLOAT_EPSILON")]
		public static float FloatEpsilon {
			get {
				const string __id = "FLOAT_EPSILON.F";

				var __v = _members.StaticFields.GetSingleValue (__id);
				return __v;
			}
		}
		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/utils/Utils", typeof (Utils));
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

		protected Utils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/constructor[@name='Utils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Utils ()
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

		public static unsafe global::MikePhil.Charting.Formatter.IValueFormatter DefaultValueFormatter {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='getDefaultValueFormatter' and count(parameter)=0]"
			[Register ("getDefaultValueFormatter", "()Lcom/github/mikephil/charting/formatter/IValueFormatter;", "GetGetDefaultValueFormatterHandler")]
			get {
				const string __id = "getDefaultValueFormatter.()Lcom/github/mikephil/charting/formatter/IValueFormatter;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Formatter.IValueFormatter> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public static unsafe int MaximumFlingVelocity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='getMaximumFlingVelocity' and count(parameter)=0]"
			[Register ("getMaximumFlingVelocity", "()I", "GetGetMaximumFlingVelocityHandler")]
			get {
				const string __id = "getMaximumFlingVelocity.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int MinimumFlingVelocity {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='getMinimumFlingVelocity' and count(parameter)=0]"
			[Register ("getMinimumFlingVelocity", "()I", "GetGetMinimumFlingVelocityHandler")]
			get {
				const string __id = "getMinimumFlingVelocity.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		public static unsafe int SDKInt {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='getSDKInt' and count(parameter)=0]"
			[Register ("getSDKInt", "()I", "GetGetSDKIntHandler")]
			get {
				const string __id = "getSDKInt.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='calcTextHeight' and count(parameter)=2 and parameter[1][@type='android.graphics.Paint'] and parameter[2][@type='java.lang.String']]"
		[Register ("calcTextHeight", "(Landroid/graphics/Paint;Ljava/lang/String;)I", "")]
		public static unsafe int CalcTextHeight (global::Android.Graphics.Paint paint, string demoText)
		{
			const string __id = "calcTextHeight.(Landroid/graphics/Paint;Ljava/lang/String;)I";
			IntPtr native_demoText = JNIEnv.NewString (demoText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((paint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paint).Handle);
				__args [1] = new JniArgumentValue (native_demoText);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_demoText);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='calcTextSize' and count(parameter)=2 and parameter[1][@type='android.graphics.Paint'] and parameter[2][@type='java.lang.String']]"
		[Register ("calcTextSize", "(Landroid/graphics/Paint;Ljava/lang/String;)Lcom/github/mikephil/charting/utils/FSize;", "")]
		public static unsafe global::MikePhil.Charting.Util.FSize CalcTextSize (global::Android.Graphics.Paint paint, string demoText)
		{
			const string __id = "calcTextSize.(Landroid/graphics/Paint;Ljava/lang/String;)Lcom/github/mikephil/charting/utils/FSize;";
			IntPtr native_demoText = JNIEnv.NewString (demoText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((paint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paint).Handle);
				__args [1] = new JniArgumentValue (native_demoText);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.FSize> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_demoText);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='calcTextSize' and count(parameter)=3 and parameter[1][@type='android.graphics.Paint'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='com.github.mikephil.charting.utils.FSize']]"
		[Register ("calcTextSize", "(Landroid/graphics/Paint;Ljava/lang/String;Lcom/github/mikephil/charting/utils/FSize;)V", "")]
		public static unsafe void CalcTextSize (global::Android.Graphics.Paint paint, string demoText, global::MikePhil.Charting.Util.FSize outputFSize)
		{
			const string __id = "calcTextSize.(Landroid/graphics/Paint;Ljava/lang/String;Lcom/github/mikephil/charting/utils/FSize;)V";
			IntPtr native_demoText = JNIEnv.NewString (demoText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((paint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paint).Handle);
				__args [1] = new JniArgumentValue (native_demoText);
				__args [2] = new JniArgumentValue ((outputFSize == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputFSize).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_demoText);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='calcTextWidth' and count(parameter)=2 and parameter[1][@type='android.graphics.Paint'] and parameter[2][@type='java.lang.String']]"
		[Register ("calcTextWidth", "(Landroid/graphics/Paint;Ljava/lang/String;)I", "")]
		public static unsafe int CalcTextWidth (global::Android.Graphics.Paint paint, string demoText)
		{
			const string __id = "calcTextWidth.(Landroid/graphics/Paint;Ljava/lang/String;)I";
			IntPtr native_demoText = JNIEnv.NewString (demoText);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((paint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paint).Handle);
				__args [1] = new JniArgumentValue (native_demoText);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_demoText);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='convertDpToPixel' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("convertDpToPixel", "(F)F", "")]
		public static unsafe float ConvertDpToPixel (float dp)
		{
			const string __id = "convertDpToPixel.(F)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (dp);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='convertIntegers' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.Integer&gt;']]"
		[Register ("convertIntegers", "(Ljava/util/List;)[I", "")]
		public static unsafe int[] ConvertIntegers (global::System.Collections.Generic.IList<global::Java.Lang.Integer> integers)
		{
			const string __id = "convertIntegers.(Ljava/util/List;)[I";
			IntPtr native_integers = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (integers);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_integers);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (int[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
				JNIEnv.DeleteLocalRef (native_integers);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='convertPixelsToDp' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("convertPixelsToDp", "(F)F", "")]
		public static unsafe float ConvertPixelsToDp (float px)
		{
			const string __id = "convertPixelsToDp.(F)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (px);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='convertStrings' and count(parameter)=1 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;']]"
		[Register ("convertStrings", "(Ljava/util/List;)[Ljava/lang/String;", "")]
		public static unsafe string[] ConvertStrings (global::System.Collections.Generic.IList<string> strings)
		{
			const string __id = "convertStrings.(Ljava/util/List;)[Ljava/lang/String;";
			IntPtr native_strings = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (strings);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_strings);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return (string[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
				JNIEnv.DeleteLocalRef (native_strings);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='copyIntegers' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.Integer&gt;'] and parameter[2][@type='int[]']]"
		[Register ("copyIntegers", "(Ljava/util/List;[I)V", "")]
		public static unsafe void CopyIntegers (global::System.Collections.Generic.IList<global::Java.Lang.Integer> from, int[] to)
		{
			const string __id = "copyIntegers.(Ljava/util/List;[I)V";
			IntPtr native_from = global::Android.Runtime.JavaList<global::Java.Lang.Integer>.ToLocalJniHandle (from);
			IntPtr native_to = JNIEnv.NewArray (to);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_from);
				__args [1] = new JniArgumentValue (native_to);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_from);
				if (to != null) {
					JNIEnv.CopyArray (native_to, to);
					JNIEnv.DeleteLocalRef (native_to);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='copyStrings' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;java.lang.String&gt;'] and parameter[2][@type='java.lang.String[]']]"
		[Register ("copyStrings", "(Ljava/util/List;[Ljava/lang/String;)V", "")]
		public static unsafe void CopyStrings (global::System.Collections.Generic.IList<string> from, string[] to)
		{
			const string __id = "copyStrings.(Ljava/util/List;[Ljava/lang/String;)V";
			IntPtr native_from = global::Android.Runtime.JavaList<string>.ToLocalJniHandle (from);
			IntPtr native_to = JNIEnv.NewArray (to);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_from);
				__args [1] = new JniArgumentValue (native_to);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_from);
				if (to != null) {
					JNIEnv.CopyArray (native_to, to);
					JNIEnv.DeleteLocalRef (native_to);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='drawImage' and count(parameter)=6 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='android.graphics.drawable.Drawable'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int']]"
		[Register ("drawImage", "(Landroid/graphics/Canvas;Landroid/graphics/drawable/Drawable;IIII)V", "")]
		public static unsafe void DrawImage (global::Android.Graphics.Canvas canvas, global::Android.Graphics.Drawables.Drawable drawable, int x, int y, int width, int height)
		{
			const string __id = "drawImage.(Landroid/graphics/Canvas;Landroid/graphics/drawable/Drawable;IIII)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue ((canvas == null) ? IntPtr.Zero : ((global::Java.Lang.Object) canvas).Handle);
				__args [1] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				__args [2] = new JniArgumentValue (x);
				__args [3] = new JniArgumentValue (y);
				__args [4] = new JniArgumentValue (width);
				__args [5] = new JniArgumentValue (height);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='drawMultilineText' and count(parameter)=7 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='android.text.StaticLayout'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='android.text.TextPaint'] and parameter[6][@type='com.github.mikephil.charting.utils.MPPointF'] and parameter[7][@type='float']]"
		[Register ("drawMultilineText", "(Landroid/graphics/Canvas;Landroid/text/StaticLayout;FFLandroid/text/TextPaint;Lcom/github/mikephil/charting/utils/MPPointF;F)V", "")]
		public static unsafe void DrawMultilineText (global::Android.Graphics.Canvas c, global::Android.Text.StaticLayout textLayout, float x, float y, global::Android.Text.TextPaint paint, global::MikePhil.Charting.Util.MPPointF anchor, float angleDegrees)
		{
			const string __id = "drawMultilineText.(Landroid/graphics/Canvas;Landroid/text/StaticLayout;FFLandroid/text/TextPaint;Lcom/github/mikephil/charting/utils/MPPointF;F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue ((textLayout == null) ? IntPtr.Zero : ((global::Java.Lang.Object) textLayout).Handle);
				__args [2] = new JniArgumentValue (x);
				__args [3] = new JniArgumentValue (y);
				__args [4] = new JniArgumentValue ((paint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paint).Handle);
				__args [5] = new JniArgumentValue ((anchor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) anchor).Handle);
				__args [6] = new JniArgumentValue (angleDegrees);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='drawMultilineText' and count(parameter)=8 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='android.text.TextPaint'] and parameter[6][@type='com.github.mikephil.charting.utils.FSize'] and parameter[7][@type='com.github.mikephil.charting.utils.MPPointF'] and parameter[8][@type='float']]"
		[Register ("drawMultilineText", "(Landroid/graphics/Canvas;Ljava/lang/String;FFLandroid/text/TextPaint;Lcom/github/mikephil/charting/utils/FSize;Lcom/github/mikephil/charting/utils/MPPointF;F)V", "")]
		public static unsafe void DrawMultilineText (global::Android.Graphics.Canvas c, string text, float x, float y, global::Android.Text.TextPaint paint, global::MikePhil.Charting.Util.FSize constrainedToSize, global::MikePhil.Charting.Util.MPPointF anchor, float angleDegrees)
		{
			const string __id = "drawMultilineText.(Landroid/graphics/Canvas;Ljava/lang/String;FFLandroid/text/TextPaint;Lcom/github/mikephil/charting/utils/FSize;Lcom/github/mikephil/charting/utils/MPPointF;F)V";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue (native_text);
				__args [2] = new JniArgumentValue (x);
				__args [3] = new JniArgumentValue (y);
				__args [4] = new JniArgumentValue ((paint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paint).Handle);
				__args [5] = new JniArgumentValue ((constrainedToSize == null) ? IntPtr.Zero : ((global::Java.Lang.Object) constrainedToSize).Handle);
				__args [6] = new JniArgumentValue ((anchor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) anchor).Handle);
				__args [7] = new JniArgumentValue (angleDegrees);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='drawXAxisValue' and count(parameter)=7 and parameter[1][@type='android.graphics.Canvas'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='android.graphics.Paint'] and parameter[6][@type='com.github.mikephil.charting.utils.MPPointF'] and parameter[7][@type='float']]"
		[Register ("drawXAxisValue", "(Landroid/graphics/Canvas;Ljava/lang/String;FFLandroid/graphics/Paint;Lcom/github/mikephil/charting/utils/MPPointF;F)V", "")]
		public static unsafe void DrawXAxisValue (global::Android.Graphics.Canvas c, string text, float x, float y, global::Android.Graphics.Paint paint, global::MikePhil.Charting.Util.MPPointF anchor, float angleDegrees)
		{
			const string __id = "drawXAxisValue.(Landroid/graphics/Canvas;Ljava/lang/String;FFLandroid/graphics/Paint;Lcom/github/mikephil/charting/utils/MPPointF;F)V";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [7];
				__args [0] = new JniArgumentValue ((c == null) ? IntPtr.Zero : ((global::Java.Lang.Object) c).Handle);
				__args [1] = new JniArgumentValue (native_text);
				__args [2] = new JniArgumentValue (x);
				__args [3] = new JniArgumentValue (y);
				__args [4] = new JniArgumentValue ((paint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paint).Handle);
				__args [5] = new JniArgumentValue ((anchor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) anchor).Handle);
				__args [6] = new JniArgumentValue (angleDegrees);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='formatNumber' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='int'] and parameter[3][@type='boolean']]"
		[Register ("formatNumber", "(FIZ)Ljava/lang/String;", "")]
		public static unsafe string FormatNumber (float number, int digitCount, bool separateThousands)
		{
			const string __id = "formatNumber.(FIZ)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (number);
				__args [1] = new JniArgumentValue (digitCount);
				__args [2] = new JniArgumentValue (separateThousands);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='formatNumber' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='int'] and parameter[3][@type='boolean'] and parameter[4][@type='char']]"
		[Register ("formatNumber", "(FIZC)Ljava/lang/String;", "")]
		public static unsafe string FormatNumber (float number, int digitCount, bool separateThousands, char separateChar)
		{
			const string __id = "formatNumber.(FIZC)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (number);
				__args [1] = new JniArgumentValue (digitCount);
				__args [2] = new JniArgumentValue (separateThousands);
				__args [3] = new JniArgumentValue (separateChar);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='getDecimals' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getDecimals", "(F)I", "")]
		public static unsafe int GetDecimals (float number)
		{
			const string __id = "getDecimals.(F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (number);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='getLineHeight' and count(parameter)=1 and parameter[1][@type='android.graphics.Paint']]"
		[Register ("getLineHeight", "(Landroid/graphics/Paint;)F", "")]
		public static unsafe float GetLineHeight (global::Android.Graphics.Paint paint)
		{
			const string __id = "getLineHeight.(Landroid/graphics/Paint;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((paint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paint).Handle);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='getLineHeight' and count(parameter)=2 and parameter[1][@type='android.graphics.Paint'] and parameter[2][@type='android.graphics.Paint.FontMetrics']]"
		[Register ("getLineHeight", "(Landroid/graphics/Paint;Landroid/graphics/Paint$FontMetrics;)F", "")]
		public static unsafe float GetLineHeight (global::Android.Graphics.Paint paint, global::Android.Graphics.Paint.FontMetrics fontMetrics)
		{
			const string __id = "getLineHeight.(Landroid/graphics/Paint;Landroid/graphics/Paint$FontMetrics;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((paint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paint).Handle);
				__args [1] = new JniArgumentValue ((fontMetrics == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fontMetrics).Handle);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='getLineSpacing' and count(parameter)=1 and parameter[1][@type='android.graphics.Paint']]"
		[Register ("getLineSpacing", "(Landroid/graphics/Paint;)F", "")]
		public static unsafe float GetLineSpacing (global::Android.Graphics.Paint paint)
		{
			const string __id = "getLineSpacing.(Landroid/graphics/Paint;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((paint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paint).Handle);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='getLineSpacing' and count(parameter)=2 and parameter[1][@type='android.graphics.Paint'] and parameter[2][@type='android.graphics.Paint.FontMetrics']]"
		[Register ("getLineSpacing", "(Landroid/graphics/Paint;Landroid/graphics/Paint$FontMetrics;)F", "")]
		public static unsafe float GetLineSpacing (global::Android.Graphics.Paint paint, global::Android.Graphics.Paint.FontMetrics fontMetrics)
		{
			const string __id = "getLineSpacing.(Landroid/graphics/Paint;Landroid/graphics/Paint$FontMetrics;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((paint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) paint).Handle);
				__args [1] = new JniArgumentValue ((fontMetrics == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fontMetrics).Handle);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='getNormalizedAngle' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("getNormalizedAngle", "(F)F", "")]
		public static unsafe float GetNormalizedAngle (float angle)
		{
			const string __id = "getNormalizedAngle.(F)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (angle);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='getPosition' and count(parameter)=3 and parameter[1][@type='com.github.mikephil.charting.utils.MPPointF'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("getPosition", "(Lcom/github/mikephil/charting/utils/MPPointF;FF)Lcom/github/mikephil/charting/utils/MPPointF;", "")]
		public static unsafe global::MikePhil.Charting.Util.MPPointF GetPosition (global::MikePhil.Charting.Util.MPPointF center, float dist, float angle)
		{
			const string __id = "getPosition.(Lcom/github/mikephil/charting/utils/MPPointF;FF)Lcom/github/mikephil/charting/utils/MPPointF;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((center == null) ? IntPtr.Zero : ((global::Java.Lang.Object) center).Handle);
				__args [1] = new JniArgumentValue (dist);
				__args [2] = new JniArgumentValue (angle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.MPPointF> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='getPosition' and count(parameter)=4 and parameter[1][@type='com.github.mikephil.charting.utils.MPPointF'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='com.github.mikephil.charting.utils.MPPointF']]"
		[Register ("getPosition", "(Lcom/github/mikephil/charting/utils/MPPointF;FFLcom/github/mikephil/charting/utils/MPPointF;)V", "")]
		public static unsafe void GetPosition (global::MikePhil.Charting.Util.MPPointF center, float dist, float angle, global::MikePhil.Charting.Util.MPPointF outputPoint)
		{
			const string __id = "getPosition.(Lcom/github/mikephil/charting/utils/MPPointF;FFLcom/github/mikephil/charting/utils/MPPointF;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((center == null) ? IntPtr.Zero : ((global::Java.Lang.Object) center).Handle);
				__args [1] = new JniArgumentValue (dist);
				__args [2] = new JniArgumentValue (angle);
				__args [3] = new JniArgumentValue ((outputPoint == null) ? IntPtr.Zero : ((global::Java.Lang.Object) outputPoint).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='getSizeOfRotatedRectangleByDegrees' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.utils.FSize'] and parameter[2][@type='float']]"
		[Register ("getSizeOfRotatedRectangleByDegrees", "(Lcom/github/mikephil/charting/utils/FSize;F)Lcom/github/mikephil/charting/utils/FSize;", "")]
		public static unsafe global::MikePhil.Charting.Util.FSize GetSizeOfRotatedRectangleByDegrees (global::MikePhil.Charting.Util.FSize rectangleSize, float degrees)
		{
			const string __id = "getSizeOfRotatedRectangleByDegrees.(Lcom/github/mikephil/charting/utils/FSize;F)Lcom/github/mikephil/charting/utils/FSize;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((rectangleSize == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rectangleSize).Handle);
				__args [1] = new JniArgumentValue (degrees);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.FSize> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='getSizeOfRotatedRectangleByDegrees' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("getSizeOfRotatedRectangleByDegrees", "(FFF)Lcom/github/mikephil/charting/utils/FSize;", "")]
		public static unsafe global::MikePhil.Charting.Util.FSize GetSizeOfRotatedRectangleByDegrees (float rectangleWidth, float rectangleHeight, float degrees)
		{
			const string __id = "getSizeOfRotatedRectangleByDegrees.(FFF)Lcom/github/mikephil/charting/utils/FSize;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (rectangleWidth);
				__args [1] = new JniArgumentValue (rectangleHeight);
				__args [2] = new JniArgumentValue (degrees);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.FSize> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='getSizeOfRotatedRectangleByRadians' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.utils.FSize'] and parameter[2][@type='float']]"
		[Register ("getSizeOfRotatedRectangleByRadians", "(Lcom/github/mikephil/charting/utils/FSize;F)Lcom/github/mikephil/charting/utils/FSize;", "")]
		public static unsafe global::MikePhil.Charting.Util.FSize GetSizeOfRotatedRectangleByRadians (global::MikePhil.Charting.Util.FSize rectangleSize, float radians)
		{
			const string __id = "getSizeOfRotatedRectangleByRadians.(Lcom/github/mikephil/charting/utils/FSize;F)Lcom/github/mikephil/charting/utils/FSize;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((rectangleSize == null) ? IntPtr.Zero : ((global::Java.Lang.Object) rectangleSize).Handle);
				__args [1] = new JniArgumentValue (radians);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.FSize> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='getSizeOfRotatedRectangleByRadians' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("getSizeOfRotatedRectangleByRadians", "(FFF)Lcom/github/mikephil/charting/utils/FSize;", "")]
		public static unsafe global::MikePhil.Charting.Util.FSize GetSizeOfRotatedRectangleByRadians (float rectangleWidth, float rectangleHeight, float radians)
		{
			const string __id = "getSizeOfRotatedRectangleByRadians.(FFF)Lcom/github/mikephil/charting/utils/FSize;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (rectangleWidth);
				__args [1] = new JniArgumentValue (rectangleHeight);
				__args [2] = new JniArgumentValue (radians);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Util.FSize> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register ("init", "(Landroid/content/Context;)V", "")]
		public static unsafe void Init (global::Android.Content.Context context)
		{
			const string __id = "init.(Landroid/content/Context;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='init' and count(parameter)=1 and parameter[1][@type='android.content.res.Resources']]"
		[Obsolete (@"deprecated")]
		[Register ("init", "(Landroid/content/res/Resources;)V", "")]
		public static unsafe void Init (global::Android.Content.Res.Resources res)
		{
			const string __id = "init.(Landroid/content/res/Resources;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((res == null) ? IntPtr.Zero : ((global::Java.Lang.Object) res).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='nextUp' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("nextUp", "(D)D", "")]
		public static unsafe double NextUp (double d)
		{
			const string __id = "nextUp.(D)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (d);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='postInvalidateOnAnimation' and count(parameter)=1 and parameter[1][@type='android.view.View']]"
		[Register ("postInvalidateOnAnimation", "(Landroid/view/View;)V", "")]
		public static unsafe void PostInvalidateOnAnimation (global::Android.Views.View view)
		{
			const string __id = "postInvalidateOnAnimation.(Landroid/view/View;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='roundToNextSignificant' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("roundToNextSignificant", "(D)F", "")]
		public static unsafe float RoundToNextSignificant (double number)
		{
			const string __id = "roundToNextSignificant.(D)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (number);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='Utils']/method[@name='velocityTrackerPointerUpCleanUpIfNecessary' and count(parameter)=2 and parameter[1][@type='android.view.MotionEvent'] and parameter[2][@type='android.view.VelocityTracker']]"
		[Register ("velocityTrackerPointerUpCleanUpIfNecessary", "(Landroid/view/MotionEvent;Landroid/view/VelocityTracker;)V", "")]
		public static unsafe void VelocityTrackerPointerUpCleanUpIfNecessary (global::Android.Views.MotionEvent ev, global::Android.Views.VelocityTracker tracker)
		{
			const string __id = "velocityTrackerPointerUpCleanUpIfNecessary.(Landroid/view/MotionEvent;Landroid/view/VelocityTracker;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((ev == null) ? IntPtr.Zero : ((global::Java.Lang.Object) ev).Handle);
				__args [1] = new JniArgumentValue ((tracker == null) ? IntPtr.Zero : ((global::Java.Lang.Object) tracker).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/utils/Utils", DoNotGenerateAcw=true)]
	internal partial class UtilsInvoker : Utils {

		public UtilsInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		internal    new     static  readonly    JniPeerMembers  _members    = new JniPeerMembers ("com/github/mikephil/charting/utils/Utils", typeof (UtilsInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

	}

}
