using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Applandeo.Materialcalendarview.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='ImageUtils']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/utils/ImageUtils", DoNotGenerateAcw=true)]
	public partial class ImageUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/applandeo/materialcalendarview/utils/ImageUtils", typeof (ImageUtils));
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

		protected ImageUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='ImageUtils']/method[@name='loadImage' and count(parameter)=2 and parameter[1][@type='android.widget.ImageView'] and parameter[2][@type='java.lang.Object']]"
		[Register ("loadImage", "(Landroid/widget/ImageView;Ljava/lang/Object;)V", "")]
		public static unsafe void LoadImage (global::Android.Widget.ImageView imageView, global::Java.Lang.Object image)
		{
			const string __id = "loadImage.(Landroid/widget/ImageView;Ljava/lang/Object;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((imageView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) imageView).Handle);
				__args [1] = new JniArgumentValue ((image == null) ? IntPtr.Zero : ((global::Java.Lang.Object) image).Handle);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
