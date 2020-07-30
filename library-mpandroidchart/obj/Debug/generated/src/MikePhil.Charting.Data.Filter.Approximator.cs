using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Data.Filter {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.data.filter']/class[@name='Approximator']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/data/filter/Approximator", DoNotGenerateAcw=true)]
	public partial class Approximator : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/data/filter/Approximator", typeof (Approximator));
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

		protected Approximator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.data.filter']/class[@name='Approximator']/constructor[@name='Approximator' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Approximator ()
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

		static Delegate cb_reduceWithDouglasPeucker_arrayFF;
#pragma warning disable 0169
		static Delegate GetReduceWithDouglasPeucker_arrayFFHandler ()
		{
			if (cb_reduceWithDouglasPeucker_arrayFF == null)
				cb_reduceWithDouglasPeucker_arrayFF = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, float, IntPtr>) n_ReduceWithDouglasPeucker_arrayFF);
			return cb_reduceWithDouglasPeucker_arrayFF;
		}

		static IntPtr n_ReduceWithDouglasPeucker_arrayFF (IntPtr jnienv, IntPtr native__this, IntPtr native_points, float tolerance)
		{
			global::MikePhil.Charting.Data.Filter.Approximator __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Data.Filter.Approximator> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			float[] points = (float[]) JNIEnv.GetArray (native_points, JniHandleOwnership.DoNotTransfer, typeof (float));
			IntPtr __ret = JNIEnv.NewArray (__this.ReduceWithDouglasPeucker (points, tolerance));
			if (points != null)
				JNIEnv.CopyArray (points, native_points);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.data.filter']/class[@name='Approximator']/method[@name='reduceWithDouglasPeucker' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float']]"
		[Register ("reduceWithDouglasPeucker", "([FF)[F", "GetReduceWithDouglasPeucker_arrayFFHandler")]
		public virtual unsafe float[] ReduceWithDouglasPeucker (float[] points, float tolerance)
		{
			const string __id = "reduceWithDouglasPeucker.([FF)[F";
			IntPtr native_points = JNIEnv.NewArray (points);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_points);
				__args [1] = new JniArgumentValue (tolerance);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
				if (points != null) {
					JNIEnv.CopyArray (native_points, points);
					JNIEnv.DeleteLocalRef (native_points);
				}
			}
		}

	}
}
