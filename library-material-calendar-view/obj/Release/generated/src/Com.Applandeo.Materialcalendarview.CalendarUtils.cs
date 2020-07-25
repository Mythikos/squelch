using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Applandeo.Materialcalendarview {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarUtils']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/CalendarUtils", DoNotGenerateAcw=true)]
	public sealed partial class CalendarUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/applandeo/materialcalendarview/CalendarUtils", typeof (CalendarUtils));
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

		internal CalendarUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarUtils']/method[@name='getDatesRange' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='java.util.Calendar']]"
		[Register ("getDatesRange", "(Ljava/util/Calendar;Ljava/util/Calendar;)Ljava/util/ArrayList;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::Java.Util.Calendar> GetDatesRange (global::Java.Util.Calendar firstDay, global::Java.Util.Calendar lastDay)
		{
			const string __id = "getDatesRange.(Ljava/util/Calendar;Ljava/util/Calendar;)Ljava/util/ArrayList;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((firstDay == null) ? IntPtr.Zero : ((global::Java.Lang.Object) firstDay).Handle);
				__args [1] = new JniArgumentValue ((lastDay == null) ? IntPtr.Zero : ((global::Java.Lang.Object) lastDay).Handle);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::Java.Util.Calendar>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview']/class[@name='CalendarUtils']/method[@name='getDrawableText' and count(parameter)=5 and parameter[1][@type='android.content.Context'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='android.graphics.Typeface'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("getDrawableText", "(Landroid/content/Context;Ljava/lang/String;Landroid/graphics/Typeface;II)Landroid/graphics/drawable/Drawable;", "")]
		public static unsafe global::Android.Graphics.Drawables.Drawable GetDrawableText (global::Android.Content.Context context, string text, global::Android.Graphics.Typeface typeface, int color, int size)
		{
			const string __id = "getDrawableText.(Landroid/content/Context;Ljava/lang/String;Landroid/graphics/Typeface;II)Landroid/graphics/drawable/Drawable;";
			IntPtr native_text = JNIEnv.NewString (text);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [5];
				__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
				__args [1] = new JniArgumentValue (native_text);
				__args [2] = new JniArgumentValue ((typeface == null) ? IntPtr.Zero : ((global::Java.Lang.Object) typeface).Handle);
				__args [3] = new JniArgumentValue (color);
				__args [4] = new JniArgumentValue (size);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Drawables.Drawable> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_text);
			}
		}

	}
}
