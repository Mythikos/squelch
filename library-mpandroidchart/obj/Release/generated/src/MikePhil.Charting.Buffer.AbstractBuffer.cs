using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Buffer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='AbstractBuffer']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/buffer/AbstractBuffer", DoNotGenerateAcw=true)]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T"})]
	public abstract partial class AbstractBuffer : global::Java.Lang.Object {



		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='AbstractBuffer']/field[@name='buffer']"
		[Register ("buffer")]
		public IList<float> Buffer {
			get {
				const string __id = "buffer.[F";

				var __v = _members.InstanceFields.GetObjectValue (__id, this);
				return global::Android.Runtime.JavaArray<float>.FromJniHandle (__v.Handle, JniHandleOwnership.TransferLocalRef);
			}
			set {
				const string __id = "buffer.[F";

				IntPtr native_value = global::Android.Runtime.JavaArray<float>.ToLocalJniHandle (value);
				try {
					_members.InstanceFields.SetValue (__id, this, new JniObjectReference (native_value));
				} finally {
					global::Android.Runtime.JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='AbstractBuffer']/field[@name='index']"
		[Register ("index")]
		protected int Index {
			get {
				const string __id = "index.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "index.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='AbstractBuffer']/field[@name='mFrom']"
		[Register ("mFrom")]
		protected int MFrom {
			get {
				const string __id = "mFrom.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mFrom.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='AbstractBuffer']/field[@name='mTo']"
		[Register ("mTo")]
		protected int MTo {
			get {
				const string __id = "mTo.I";

				var __v = _members.InstanceFields.GetInt32Value (__id, this);
				return __v;
			}
			set {
				const string __id = "mTo.I";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='AbstractBuffer']/field[@name='phaseX']"
		[Register ("phaseX")]
		protected float PhaseX {
			get {
				const string __id = "phaseX.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "phaseX.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}


		// Metadata.xml XPath field reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='AbstractBuffer']/field[@name='phaseY']"
		[Register ("phaseY")]
		protected float PhaseY {
			get {
				const string __id = "phaseY.F";

				var __v = _members.InstanceFields.GetSingleValue (__id, this);
				return __v;
			}
			set {
				const string __id = "phaseY.F";

				try {
					_members.InstanceFields.SetValue (__id, this, value);
				} finally {
				}
			}
		}
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/buffer/AbstractBuffer", typeof (AbstractBuffer));
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

		protected AbstractBuffer (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='AbstractBuffer']/constructor[@name='AbstractBuffer' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register (".ctor", "(I)V", "")]
		public unsafe AbstractBuffer (int size)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(I)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (size);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_feed_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetFeed_Ljava_lang_Object_Handler ()
		{
			if (cb_feed_Ljava_lang_Object_ == null)
				cb_feed_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Feed_Ljava_lang_Object_);
			return cb_feed_Ljava_lang_Object_;
		}

		static void n_Feed_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::MikePhil.Charting.Buffer.AbstractBuffer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Buffer.AbstractBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Feed (p0);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='AbstractBuffer']/method[@name='feed' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("feed", "(Ljava/lang/Object;)V", "GetFeed_Ljava_lang_Object_Handler")]
		public abstract void Feed (global::Java.Lang.Object p0);

		static Delegate cb_limitFrom_I;
#pragma warning disable 0169
		static Delegate GetLimitFrom_IHandler ()
		{
			if (cb_limitFrom_I == null)
				cb_limitFrom_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_LimitFrom_I);
			return cb_limitFrom_I;
		}

		static void n_LimitFrom_I (IntPtr jnienv, IntPtr native__this, int from)
		{
			global::MikePhil.Charting.Buffer.AbstractBuffer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Buffer.AbstractBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LimitFrom (from);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='AbstractBuffer']/method[@name='limitFrom' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("limitFrom", "(I)V", "GetLimitFrom_IHandler")]
		public virtual unsafe void LimitFrom (int from)
		{
			const string __id = "limitFrom.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (from);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_limitTo_I;
#pragma warning disable 0169
		static Delegate GetLimitTo_IHandler ()
		{
			if (cb_limitTo_I == null)
				cb_limitTo_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_LimitTo_I);
			return cb_limitTo_I;
		}

		static void n_LimitTo_I (IntPtr jnienv, IntPtr native__this, int to)
		{
			global::MikePhil.Charting.Buffer.AbstractBuffer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Buffer.AbstractBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.LimitTo (to);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='AbstractBuffer']/method[@name='limitTo' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("limitTo", "(I)V", "GetLimitTo_IHandler")]
		public virtual unsafe void LimitTo (int to)
		{
			const string __id = "limitTo.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (to);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_reset;
#pragma warning disable 0169
		static Delegate GetResetHandler ()
		{
			if (cb_reset == null)
				cb_reset = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Reset);
			return cb_reset;
		}

		static void n_Reset (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Buffer.AbstractBuffer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Buffer.AbstractBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Reset ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='AbstractBuffer']/method[@name='reset' and count(parameter)=0]"
		[Register ("reset", "()V", "GetResetHandler")]
		public virtual unsafe void Reset ()
		{
			const string __id = "reset.()V";
			try {
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_setPhases_FF;
#pragma warning disable 0169
		static Delegate GetSetPhases_FFHandler ()
		{
			if (cb_setPhases_FF == null)
				cb_setPhases_FF = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float>) n_SetPhases_FF);
			return cb_setPhases_FF;
		}

		static void n_SetPhases_FF (IntPtr jnienv, IntPtr native__this, float phaseX, float phaseY)
		{
			global::MikePhil.Charting.Buffer.AbstractBuffer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Buffer.AbstractBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPhases (phaseX, phaseY);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='AbstractBuffer']/method[@name='setPhases' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='float']]"
		[Register ("setPhases", "(FF)V", "GetSetPhases_FFHandler")]
		public virtual unsafe void SetPhases (float phaseX, float phaseY)
		{
			const string __id = "setPhases.(FF)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (phaseX);
				__args [1] = new JniArgumentValue (phaseY);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_size;
#pragma warning disable 0169
		static Delegate GetSizeHandler ()
		{
			if (cb_size == null)
				cb_size = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Size);
			return cb_size;
		}

		static int n_Size (IntPtr jnienv, IntPtr native__this)
		{
			global::MikePhil.Charting.Buffer.AbstractBuffer __this = global::Java.Lang.Object.GetObject<global::MikePhil.Charting.Buffer.AbstractBuffer> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Size ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='AbstractBuffer']/method[@name='size' and count(parameter)=0]"
		[Register ("size", "()I", "GetSizeHandler")]
		public virtual unsafe int Size ()
		{
			const string __id = "size.()I";
			try {
				var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
				return __rm;
			} finally {
			}
		}

	}

	[global::Android.Runtime.Register ("com/github/mikephil/charting/buffer/AbstractBuffer", DoNotGenerateAcw=true)]
	internal partial class AbstractBufferInvoker : AbstractBuffer {

		public AbstractBufferInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/github/mikephil/charting/buffer/AbstractBuffer", typeof (AbstractBufferInvoker));

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.buffer']/class[@name='AbstractBuffer']/method[@name='feed' and count(parameter)=1 and parameter[1][@type='T']]"
		[Register ("feed", "(Ljava/lang/Object;)V", "GetFeed_Ljava_lang_Object_Handler")]
		public override unsafe void Feed (global::Java.Lang.Object p0)
		{
			const string __id = "feed.(Ljava/lang/Object;)V";
			IntPtr native_p0 = JNIEnv.ToLocalJniHandle (p0);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_p0);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

	}

}
