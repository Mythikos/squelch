using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Applandeo.Materialcalendarview.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='EventDayUtils']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/utils/EventDayUtils", DoNotGenerateAcw=true)]
	public partial class EventDayUtils : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/applandeo/materialcalendarview/utils/EventDayUtils", typeof (EventDayUtils));
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

		protected EventDayUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='EventDayUtils']/constructor[@name='EventDayUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe EventDayUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.applandeo.materialcalendarview.utils']/class[@name='EventDayUtils']/method[@name='isEventDayWithLabelColor' and count(parameter)=2 and parameter[1][@type='java.util.Calendar'] and parameter[2][@type='com.applandeo.materialcalendarview.utils.CalendarProperties']]"
		[Register ("isEventDayWithLabelColor", "(Ljava/util/Calendar;Lcom/applandeo/materialcalendarview/utils/CalendarProperties;)Z", "")]
		public static unsafe bool IsEventDayWithLabelColor (global::Java.Util.Calendar day, global::Com.Applandeo.Materialcalendarview.Utils.CalendarProperties calendarProperties)
		{
			const string __id = "isEventDayWithLabelColor.(Ljava/util/Calendar;Lcom/applandeo/materialcalendarview/utils/CalendarProperties;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((day == null) ? IntPtr.Zero : ((global::Java.Lang.Object) day).Handle);
				__args [1] = new JniArgumentValue ((calendarProperties == null) ? IntPtr.Zero : ((global::Java.Lang.Object) calendarProperties).Handle);
				var __rm = _members.StaticMethods.InvokeBooleanMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
