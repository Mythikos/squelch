using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Applandeo.Materialcalendarview.Listeners {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview.listeners']/class[@name='DayRowClickListener']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/listeners/DayRowClickListener", DoNotGenerateAcw=true)]
	public partial class DayRowClickListener : global::Java.Lang.Object, global::Android.Widget.AdapterView.IOnItemClickListener {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/applandeo/materialcalendarview/listeners/DayRowClickListener", typeof (DayRowClickListener));
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

		protected DayRowClickListener (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static Delegate cb_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ;
#pragma warning disable 0169
		static Delegate GetOnItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJHandler ()
		{
			if (cb_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ == null)
				cb_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr, int, long>) n_OnItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ);
			return cb_onItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ;
		}

		static void n_OnItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJ (IntPtr jnienv, IntPtr native__this, IntPtr native_adapterView, IntPtr native_view, int position, long id)
		{
			global::Com.Applandeo.Materialcalendarview.Listeners.DayRowClickListener __this = global::Java.Lang.Object.GetObject<global::Com.Applandeo.Materialcalendarview.Listeners.DayRowClickListener> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Widget.AdapterView adapterView = global::Java.Lang.Object.GetObject<global::Android.Widget.AdapterView> (native_adapterView, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.View view = global::Java.Lang.Object.GetObject<global::Android.Views.View> (native_view, JniHandleOwnership.DoNotTransfer);
			__this.OnItemClick (adapterView, view, position, id);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.listeners']/class[@name='DayRowClickListener']/method[@name='onItemClick' and count(parameter)=4 and parameter[1][@type='android.widget.AdapterView&lt;?&gt;'] and parameter[2][@type='android.view.View'] and parameter[3][@type='int'] and parameter[4][@type='long']]"
		[Register ("onItemClick", "(Landroid/widget/AdapterView;Landroid/view/View;IJ)V", "GetOnItemClick_Landroid_widget_AdapterView_Landroid_view_View_IJHandler")]
		public virtual unsafe void OnItemClick (global::Android.Widget.AdapterView adapterView, global::Android.Views.View view, int position, long id)
		{
			const string __id = "onItemClick.(Landroid/widget/AdapterView;Landroid/view/View;IJ)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((adapterView == null) ? IntPtr.Zero : ((global::Java.Lang.Object) adapterView).Handle);
				__args [1] = new JniArgumentValue ((view == null) ? IntPtr.Zero : ((global::Java.Lang.Object) view).Handle);
				__args [2] = new JniArgumentValue (position);
				__args [3] = new JniArgumentValue (id);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

	}
}
