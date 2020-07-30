using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Matrix {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/matrix/Vector3", DoNotGenerateAcw=true)]
	public sealed partial class Vector3 : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/field[@name='UNIT_X']"
		[Register ("UNIT_X")]
		public static global::MikePhil.Charting.Matrix.Vector3 UnitX {
			get {
				const string __id = "UNIT_X.Lcom/github/mikephil/charting/matrix/Vector3;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Matrix.Vector3> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/field[@name='UNIT_Y']"
		[Register ("UNIT_Y")]
		public static global::MikePhil.Charting.Matrix.Vector3 UnitY {
			get {
				const string __id = "UNIT_Y.Lcom/github/mikephil/charting/matrix/Vector3;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Matrix.Vector3> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/field[@name='UNIT_Z']"
		[Register ("UNIT_Z")]
		public static global::MikePhil.Charting.Matrix.Vector3 UnitZ {
			get {
				const string __id = "UNIT_Z.Lcom/github/mikephil/charting/matrix/Vector3;";

				var __v = _members.StaticFields.GetObjectValue (__id);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Matrix.Vector3> (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/field[@name='x']"
		[Register ("x")]
		public float X {
			get {
				const string __id = "x.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "x.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/field[@name='y']"
		[Register ("y")]
		public float Y {
			get {
				const string __id = "y.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "y.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/field[@name='z']"
		[Register ("z")]
		public float Z {
			get {
				const string __id = "z.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "z.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/matrix/Vector3", typeof (Vector3));
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

		internal Vector3 (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/constructor[@name='Vector3' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Vector3 ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/constructor[@name='Vector3' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.matrix.Vector3']]"
		[Register (".ctor", "(Lcom/github/mikephil/charting/matrix/Vector3;)V", "")]
		public unsafe Vector3 (global::MikePhil.Charting.Matrix.Vector3 other)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/github/mikephil/charting/matrix/Vector3;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/constructor[@name='Vector3' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register (".ctor", "(FFF)V", "")]
		public unsafe Vector3 (float xValue, float yValue, float zValue)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(FFF)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (xValue);
				__args [1] = new JniArgumentValue (yValue);
				__args [2] = new JniArgumentValue (zValue);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/constructor[@name='Vector3' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register (".ctor", "([F)V", "")]
		public unsafe Vector3 (float[] array)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([F)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_array);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/method[@name='add' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.matrix.Vector3']]"
		[Register ("add", "(Lcom/github/mikephil/charting/matrix/Vector3;)V", "")]
		public unsafe void Add (global::MikePhil.Charting.Matrix.Vector3 other)
		{
			const string __id = "add.(Lcom/github/mikephil/charting/matrix/Vector3;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/method[@name='add' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("add", "(FFF)V", "")]
		public unsafe void Add (float otherX, float otherY, float otherZ)
		{
			const string __id = "add.(FFF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (otherX);
				__args [1] = new JniArgumentValue (otherY);
				__args [2] = new JniArgumentValue (otherZ);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/method[@name='cross' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.matrix.Vector3']]"
		[Register ("cross", "(Lcom/github/mikephil/charting/matrix/Vector3;)Lcom/github/mikephil/charting/matrix/Vector3;", "")]
		public unsafe global::MikePhil.Charting.Matrix.Vector3 Cross (global::MikePhil.Charting.Matrix.Vector3 other)
		{
			const string __id = "cross.(Lcom/github/mikephil/charting/matrix/Vector3;)Lcom/github/mikephil/charting/matrix/Vector3;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Matrix.Vector3> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/method[@name='distance2' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.matrix.Vector3']]"
		[Register ("distance2", "(Lcom/github/mikephil/charting/matrix/Vector3;)F", "")]
		public unsafe float Distance2 (global::MikePhil.Charting.Matrix.Vector3 other)
		{
			const string __id = "distance2.(Lcom/github/mikephil/charting/matrix/Vector3;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/method[@name='divide' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("divide", "(F)V", "")]
		public unsafe void Divide (float magnitude)
		{
			const string __id = "divide.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (magnitude);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/method[@name='dot' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.matrix.Vector3']]"
		[Register ("dot", "(Lcom/github/mikephil/charting/matrix/Vector3;)F", "")]
		public unsafe float Dot (global::MikePhil.Charting.Matrix.Vector3 other)
		{
			const string __id = "dot.(Lcom/github/mikephil/charting/matrix/Vector3;)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualSingleMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/method[@name='length' and count(parameter)=0]"
		[Register ("length", "()F", "")]
		public unsafe float Length ()
		{
			const string __id = "length.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/method[@name='length2' and count(parameter)=0]"
		[Register ("length2", "()F", "")]
		public unsafe float Length2 ()
		{
			const string __id = "length2.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/method[@name='multiply' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.matrix.Vector3']]"
		[Register ("multiply", "(Lcom/github/mikephil/charting/matrix/Vector3;)V", "")]
		public unsafe void Multiply (global::MikePhil.Charting.Matrix.Vector3 other)
		{
			const string __id = "multiply.(Lcom/github/mikephil/charting/matrix/Vector3;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/method[@name='multiply' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("multiply", "(F)V", "")]
		public unsafe void Multiply (float magnitude)
		{
			const string __id = "multiply.(F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (magnitude);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/method[@name='normalize' and count(parameter)=0]"
		[Register ("normalize", "()F", "")]
		public unsafe float Normalize ()
		{
			const string __id = "normalize.()F";
			try {
				var __rm = _members.InstanceMethods.InvokeNonvirtualSingleMethod (__id, this, null);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/method[@name='pointsInSameDirection' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.matrix.Vector3']]"
		[Register ("pointsInSameDirection", "(Lcom/github/mikephil/charting/matrix/Vector3;)Z", "")]
		public unsafe bool PointsInSameDirection (global::MikePhil.Charting.Matrix.Vector3 other)
		{
			const string __id = "pointsInSameDirection.(Lcom/github/mikephil/charting/matrix/Vector3;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				var __rm = _members.InstanceMethods.InvokeNonvirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/method[@name='set' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.matrix.Vector3']]"
		[Register ("set", "(Lcom/github/mikephil/charting/matrix/Vector3;)V", "")]
		public unsafe void Set (global::MikePhil.Charting.Matrix.Vector3 other)
		{
			const string __id = "set.(Lcom/github/mikephil/charting/matrix/Vector3;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/method[@name='set' and count(parameter)=3 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float']]"
		[Register ("set", "(FFF)V", "")]
		public unsafe void Set (float xValue, float yValue, float zValue)
		{
			const string __id = "set.(FFF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (xValue);
				__args [1] = new JniArgumentValue (yValue);
				__args [2] = new JniArgumentValue (zValue);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/method[@name='subtract' and count(parameter)=1 and parameter[1][@type='com.github.mikephil.charting.matrix.Vector3']]"
		[Register ("subtract", "(Lcom/github/mikephil/charting/matrix/Vector3;)V", "")]
		public unsafe void Subtract (global::MikePhil.Charting.Matrix.Vector3 other)
		{
			const string __id = "subtract.(Lcom/github/mikephil/charting/matrix/Vector3;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/method[@name='subtractMultiple' and count(parameter)=2 and parameter[1][@type='com.github.mikephil.charting.matrix.Vector3'] and parameter[2][@type='float']]"
		[Register ("subtractMultiple", "(Lcom/github/mikephil/charting/matrix/Vector3;F)V", "")]
		public unsafe void SubtractMultiple (global::MikePhil.Charting.Matrix.Vector3 other, float multiplicator)
		{
			const string __id = "subtractMultiple.(Lcom/github/mikephil/charting/matrix/Vector3;F)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((other == null) ? IntPtr.Zero : ((global::Java.Lang.Object) other).Handle);
				__args [1] = new JniArgumentValue (multiplicator);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.matrix']/class[@name='Vector3']/method[@name='zero' and count(parameter)=0]"
		[Register ("zero", "()V", "")]
		public unsafe void Zero ()
		{
			const string __id = "zero.()V";
			try {
				_members.InstanceMethods.InvokeNonvirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
