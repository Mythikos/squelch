using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Applandeo.Materialcalendarview.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='AppearanceUtils']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/utils/AppearanceUtils", DoNotGenerateAcw=true)]
	public sealed partial class AppearanceUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/applandeo/materialcalendarview/utils/AppearanceUtils", typeof (AppearanceUtils));
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

		internal AppearanceUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='AppearanceUtils']/method[@name='setAbbreviationsBarColor' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("setAbbreviationsBarColor", "(Landroid/view/View;I)V", "")]
		public static unsafe void SetAbbreviationsBarColor (global::Android.Views.View view, int color)
		{
			const string __id = "setAbbreviationsBarColor.(Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (color);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='AppearanceUtils']/method[@name='setAbbreviationsBarVisibility' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("setAbbreviationsBarVisibility", "(Landroid/view/View;I)V", "")]
		public static unsafe void SetAbbreviationsBarVisibility (global::Android.Views.View view, int visibility)
		{
			const string __id = "setAbbreviationsBarVisibility.(Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (visibility);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='AppearanceUtils']/method[@name='setAbbreviationsLabels' and count(parameter)=3 and parameter[1][@type='android.view.View'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("setAbbreviationsLabels", "(Landroid/view/View;II)V", "")]
		public static unsafe void SetAbbreviationsLabels (global::Android.Views.View view, int color, int firstDayOfWeek)
		{
			const string __id = "setAbbreviationsLabels.(Landroid/view/View;II)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (color);
				__args [2] = new JniArgumentValue (firstDayOfWeek);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='AppearanceUtils']/method[@name='setForwardButtonImage' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("setForwardButtonImage", "(Landroid/view/View;Landroid/graphics/drawable/Drawable;)V", "")]
		public static unsafe void SetForwardButtonImage (global::Android.Views.View view, global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "setForwardButtonImage.(Landroid/view/View;Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='AppearanceUtils']/method[@name='setHeaderColor' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("setHeaderColor", "(Landroid/view/View;I)V", "")]
		public static unsafe void SetHeaderColor (global::Android.Views.View view, int color)
		{
			const string __id = "setHeaderColor.(Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (color);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='AppearanceUtils']/method[@name='setHeaderLabelColor' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("setHeaderLabelColor", "(Landroid/view/View;I)V", "")]
		public static unsafe void SetHeaderLabelColor (global::Android.Views.View view, int color)
		{
			const string __id = "setHeaderLabelColor.(Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (color);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='AppearanceUtils']/method[@name='setHeaderVisibility' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("setHeaderVisibility", "(Landroid/view/View;I)V", "")]
		public static unsafe void SetHeaderVisibility (global::Android.Views.View view, int visibility)
		{
			const string __id = "setHeaderVisibility.(Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (visibility);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='AppearanceUtils']/method[@name='setNavigationVisibility' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("setNavigationVisibility", "(Landroid/view/View;I)V", "")]
		public static unsafe void SetNavigationVisibility (global::Android.Views.View view, int visibility)
		{
			const string __id = "setNavigationVisibility.(Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (visibility);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='AppearanceUtils']/method[@name='setPagesColor' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='int']]"
		[Register ("setPagesColor", "(Landroid/view/View;I)V", "")]
		public static unsafe void SetPagesColor (global::Android.Views.View view, int color)
		{
			const string __id = "setPagesColor.(Landroid/view/View;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue (color);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='AppearanceUtils']/method[@name='setPreviousButtonImage' and count(parameter)=2 and parameter[1][@type='android.view.View'] and parameter[2][@type='android.graphics.drawable.Drawable']]"
		[Register ("setPreviousButtonImage", "(Landroid/view/View;Landroid/graphics/drawable/Drawable;)V", "")]
		public static unsafe void SetPreviousButtonImage (global::Android.Views.View view, global::Android.Graphics.Drawables.Drawable drawable)
		{
			const string __id = "setPreviousButtonImage.(Landroid/view/View;Landroid/graphics/drawable/Drawable;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [1] = new JniArgumentValue ((drawable == null) ? IntPtr.Zero : ((global::Java.Lang.Object) drawable).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
