using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Applandeo.Materialcalendarview.Exceptions {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.applandeo.materialcalendarview.exceptions']/class[@name='ErrorsMessages']"
	[global::Android.Runtime.Register ("com/applandeo/materialcalendarview/exceptions/ErrorsMessages", DoNotGenerateAcw=true)]
	public sealed partial class ErrorsMessages : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.applandeo.materialcalendarview.exceptions']/class[@name='ErrorsMessages']/field[@name='ONE_DAY_PICKER_MULTIPLE_SELECTION']"
		[Register ("ONE_DAY_PICKER_MULTIPLE_SELECTION")]
		public const string OneDayPickerMultipleSelection = (string) "ONE_DAY_PICKER DOES NOT SUPPORT MULTIPLE DAYS, USE setDate() METHOD INSTEAD";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applandeo.materialcalendarview.exceptions']/class[@name='ErrorsMessages']/field[@name='OUT_OF_RANGE_MAX']"
		[Register ("OUT_OF_RANGE_MAX")]
		public const string OutOfRangeMax = (string) "SET DATE EXCEEDS THE MAXIMUM DATE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applandeo.materialcalendarview.exceptions']/class[@name='ErrorsMessages']/field[@name='OUT_OF_RANGE_MIN']"
		[Register ("OUT_OF_RANGE_MIN")]
		public const string OutOfRangeMin = (string) "SET DATE EXCEEDS THE MINIMUM DATE";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.applandeo.materialcalendarview.exceptions']/class[@name='ErrorsMessages']/field[@name='RANGE_PICKER_NOT_RANGE']"
		[Register ("RANGE_PICKER_NOT_RANGE")]
		public const string RangePickerNotRange = (string) "RANGE_PICKER ACCEPTS ONLY CONTINUOUS LIST OF CALENDARS";
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/applandeo/materialcalendarview/exceptions/ErrorsMessages", typeof (ErrorsMessages));
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

		internal ErrorsMessages (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
