using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ColorTemplate']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/utils/ColorTemplate", DoNotGenerateAcw=true)]
	public partial class ColorTemplate : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ColorTemplate']/field[@name='COLORFUL_COLORS']"
		[Register ("COLORFUL_COLORS")]
		public static IList<int> ColorfulColors {
			get {
				const string __id = "COLORFUL_COLORS.[I";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ColorTemplate']/field[@name='COLOR_NONE']"
		[Register ("COLOR_NONE")]
		public const int ColorNone = (int) 1122867;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ColorTemplate']/field[@name='COLOR_SKIP']"
		[Register ("COLOR_SKIP")]
		public const int ColorSkip = (int) 1122868;


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ColorTemplate']/field[@name='JOYFUL_COLORS']"
		[Register ("JOYFUL_COLORS")]
		public static IList<int> JoyfulColors {
			get {
				const string __id = "JOYFUL_COLORS.[I";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ColorTemplate']/field[@name='LIBERTY_COLORS']"
		[Register ("LIBERTY_COLORS")]
		public static IList<int> LibertyColors {
			get {
				const string __id = "LIBERTY_COLORS.[I";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ColorTemplate']/field[@name='MATERIAL_COLORS']"
		[Register ("MATERIAL_COLORS")]
		public static IList<int> MaterialColors {
			get {
				const string __id = "MATERIAL_COLORS.[I";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ColorTemplate']/field[@name='PASTEL_COLORS']"
		[Register ("PASTEL_COLORS")]
		public static IList<int> PastelColors {
			get {
				const string __id = "PASTEL_COLORS.[I";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ColorTemplate']/field[@name='VORDIPLOM_COLORS']"
		[Register ("VORDIPLOM_COLORS")]
		public static IList<int> VordiplomColors {
			get {
				const string __id = "VORDIPLOM_COLORS.[I";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Android.Runtime.JavaArray<int>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/utils/ColorTemplate", typeof (ColorTemplate));
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

		protected ColorTemplate (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ColorTemplate']/constructor[@name='ColorTemplate' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ColorTemplate ()
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

		public static unsafe int HoloBlue {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ColorTemplate']/method[@name='getHoloBlue' and count(parameter)=0]"
			[Register ("getHoloBlue", "()I", "")]
			get {
				const string __id = "getHoloBlue.()I";
				try {
					var __rm = _members.StaticMethods.InvokeInt32Method (__id, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ColorTemplate']/method[@name='colorWithAlpha' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("colorWithAlpha", "(II)I", "")]
		public static unsafe int ColorWithAlpha (int color, int alpha)
		{
			const string __id = "colorWithAlpha.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (color);
				__args [1] = new JniArgumentValue (alpha);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ColorTemplate']/method[@name='createColors' and count(parameter)=2 and parameter[1][@type='android.content.res.Resources'] and parameter[2][@type='int[]']]"
		[Register ("createColors", "(Landroid/content/res/Resources;[I)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Integer> CreateColors (global::Android.Content.Res.Resources r, int[] colors)
		{
			const string __id = "createColors.(Landroid/content/res/Resources;[I)Ljava/util/List;";
			IntPtr native_colors = JNIEnv.NewArray (colors);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((r == null) ? IntPtr.Zero : ((global::Java.Lang.Object) r).Handle);
				__args [1] = new JniArgumentValue (native_colors);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (colors != null) {
					JNIEnv.CopyArray (native_colors, colors);
					JNIEnv.DeleteLocalRef (native_colors);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ColorTemplate']/method[@name='createColors' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("createColors", "([I)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Lang.Integer> CreateColors (int[] colors)
		{
			const string __id = "createColors.([I)Ljava/util/List;";
			IntPtr native_colors = JNIEnv.NewArray (colors);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_colors);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Java.Lang.Integer>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (colors != null) {
					JNIEnv.CopyArray (native_colors, colors);
					JNIEnv.DeleteLocalRef (native_colors);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='ColorTemplate']/method[@name='rgb' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("rgb", "(Ljava/lang/String;)I", "")]
		public static unsafe int Rgb (string hex)
		{
			const string __id = "rgb.(Ljava/lang/String;)I";
			IntPtr native_hex = JNIEnv.NewString (hex);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_hex);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				JNIEnv.DeleteLocalRef (native_hex);
			}
		}

	}
}
