using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Iterator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator']"
	[global::Android.Runtime.Register ("com/annimon/stream/iterator/PrimitiveExtIterator", DoNotGenerateAcw=true)]
	public sealed partial class PrimitiveExtIterator : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator.OfDouble']"
		[global::Android.Runtime.Register ("com/annimon/stream/iterator/PrimitiveExtIterator$OfDouble", DoNotGenerateAcw=true)]
		public abstract partial class OfDouble : global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfDouble {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator.OfDouble']/field[@name='isInit']"
			[Register ("isInit")]
			protected bool IsInit {
				get {
					const string __id = "isInit.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "isInit.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator.OfDouble']/field[@name='next']"
			[Register ("next")]
			protected double Next {
				get {
					const string __id = "next.D";

					var __v = _members.InstanceFields.GetDoubleValue (__id, this);
					return __v;
				}
				set {
					const string __id = "next.D";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/iterator/PrimitiveExtIterator$OfDouble", typeof (OfDouble));
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

			protected OfDouble (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator.OfDouble']/constructor[@name='PrimitiveExtIterator.OfDouble' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe OfDouble ()
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

			static Delegate cb_hasNext;
#pragma warning disable 0169
			static Delegate GetHasNextHandler ()
			{
				if (cb_hasNext == null)
					cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNext);
				return cb_hasNext;
			}

			static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Annimon.Stream.Iterator.PrimitiveExtIterator.OfDouble __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveExtIterator.OfDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.HasNext;
			}
#pragma warning restore 0169

			public override unsafe bool HasNext {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator.OfDouble']/method[@name='hasNext' and count(parameter)=0]"
				[Register ("hasNext", "()Z", "GetHasNextHandler")]
				get {
					const string __id = "hasNext.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_nextDouble;
#pragma warning disable 0169
			static Delegate GetNextDoubleHandler ()
			{
				if (cb_nextDouble == null)
					cb_nextDouble = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, double>) n_NextDouble);
				return cb_nextDouble;
			}

			static double n_NextDouble (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Annimon.Stream.Iterator.PrimitiveExtIterator.OfDouble __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveExtIterator.OfDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NextDouble ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator.OfDouble']/method[@name='nextDouble' and count(parameter)=0]"
			[Register ("nextDouble", "()D", "GetNextDoubleHandler")]
			public override unsafe double NextDouble ()
			{
				const string __id = "nextDouble.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_nextIteration;
#pragma warning disable 0169
			static Delegate GetNextIterationHandler ()
			{
				if (cb_nextIteration == null)
					cb_nextIteration = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NextIteration);
				return cb_nextIteration;
			}

			static void n_NextIteration (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Annimon.Stream.Iterator.PrimitiveExtIterator.OfDouble __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveExtIterator.OfDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.NextIteration ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator.OfDouble']/method[@name='nextIteration' and count(parameter)=0]"
			[Register ("nextIteration", "()V", "GetNextIterationHandler")]
			protected abstract void NextIteration ();

		}

		[global::Android.Runtime.Register ("com/annimon/stream/iterator/PrimitiveExtIterator$OfDouble", DoNotGenerateAcw=true)]
		internal partial class OfDoubleInvoker : OfDouble {

			public OfDoubleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/iterator/PrimitiveExtIterator$OfDouble", typeof (OfDoubleInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator.OfDouble']/method[@name='nextIteration' and count(parameter)=0]"
			[Register ("nextIteration", "()V", "GetNextIterationHandler")]
			protected override unsafe void NextIteration ()
			{
				const string __id = "nextIteration.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator.OfInt']"
		[global::Android.Runtime.Register ("com/annimon/stream/iterator/PrimitiveExtIterator$OfInt", DoNotGenerateAcw=true)]
		public abstract partial class OfInt : global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfInt {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator.OfInt']/field[@name='isInit']"
			[Register ("isInit")]
			protected bool IsInit {
				get {
					const string __id = "isInit.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "isInit.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator.OfInt']/field[@name='next']"
			[Register ("next")]
			protected int Next {
				get {
					const string __id = "next.I";

					var __v = _members.InstanceFields.GetInt32Value (__id, this);
					return __v;
				}
				set {
					const string __id = "next.I";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/iterator/PrimitiveExtIterator$OfInt", typeof (OfInt));
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

			protected OfInt (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator.OfInt']/constructor[@name='PrimitiveExtIterator.OfInt' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe OfInt ()
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

			static Delegate cb_hasNext;
#pragma warning disable 0169
			static Delegate GetHasNextHandler ()
			{
				if (cb_hasNext == null)
					cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNext);
				return cb_hasNext;
			}

			static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Annimon.Stream.Iterator.PrimitiveExtIterator.OfInt __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveExtIterator.OfInt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.HasNext;
			}
#pragma warning restore 0169

			public override unsafe bool HasNext {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator.OfInt']/method[@name='hasNext' and count(parameter)=0]"
				[Register ("hasNext", "()Z", "GetHasNextHandler")]
				get {
					const string __id = "hasNext.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_nextInt;
#pragma warning disable 0169
			static Delegate GetNextIntHandler ()
			{
				if (cb_nextInt == null)
					cb_nextInt = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_NextInt);
				return cb_nextInt;
			}

			static int n_NextInt (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Annimon.Stream.Iterator.PrimitiveExtIterator.OfInt __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveExtIterator.OfInt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NextInt ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator.OfInt']/method[@name='nextInt' and count(parameter)=0]"
			[Register ("nextInt", "()I", "GetNextIntHandler")]
			public override unsafe int NextInt ()
			{
				const string __id = "nextInt.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			static Delegate cb_nextIteration;
#pragma warning disable 0169
			static Delegate GetNextIterationHandler ()
			{
				if (cb_nextIteration == null)
					cb_nextIteration = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NextIteration);
				return cb_nextIteration;
			}

			static void n_NextIteration (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Annimon.Stream.Iterator.PrimitiveExtIterator.OfInt __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveExtIterator.OfInt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.NextIteration ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator.OfInt']/method[@name='nextIteration' and count(parameter)=0]"
			[Register ("nextIteration", "()V", "GetNextIterationHandler")]
			protected abstract void NextIteration ();

		}

		[global::Android.Runtime.Register ("com/annimon/stream/iterator/PrimitiveExtIterator$OfInt", DoNotGenerateAcw=true)]
		internal partial class OfIntInvoker : OfInt {

			public OfIntInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/iterator/PrimitiveExtIterator$OfInt", typeof (OfIntInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator.OfInt']/method[@name='nextIteration' and count(parameter)=0]"
			[Register ("nextIteration", "()V", "GetNextIterationHandler")]
			protected override unsafe void NextIteration ()
			{
				const string __id = "nextIteration.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator.OfLong']"
		[global::Android.Runtime.Register ("com/annimon/stream/iterator/PrimitiveExtIterator$OfLong", DoNotGenerateAcw=true)]
		public abstract partial class OfLong : global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfLong {



			// Metadata.xml XPath field reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator.OfLong']/field[@name='isInit']"
			[Register ("isInit")]
			protected bool IsInit {
				get {
					const string __id = "isInit.Z";

					var __v = _members.InstanceFields.GetBooleanValue (__id, this);
					return __v;
				}
				set {
					const string __id = "isInit.Z";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}


			// Metadata.xml XPath field reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator.OfLong']/field[@name='next']"
			[Register ("next")]
			protected long Next {
				get {
					const string __id = "next.J";

					var __v = _members.InstanceFields.GetInt64Value (__id, this);
					return __v;
				}
				set {
					const string __id = "next.J";

					try {
						_members.InstanceFields.SetValue (__id, this, value);
					} finally {
					}
				}
			}
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/iterator/PrimitiveExtIterator$OfLong", typeof (OfLong));
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

			protected OfLong (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator.OfLong']/constructor[@name='PrimitiveExtIterator.OfLong' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe OfLong ()
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

			static Delegate cb_hasNext;
#pragma warning disable 0169
			static Delegate GetHasNextHandler ()
			{
				if (cb_hasNext == null)
					cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasNext);
				return cb_hasNext;
			}

			static bool n_HasNext (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Annimon.Stream.Iterator.PrimitiveExtIterator.OfLong __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveExtIterator.OfLong> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.HasNext;
			}
#pragma warning restore 0169

			public override unsafe bool HasNext {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator.OfLong']/method[@name='hasNext' and count(parameter)=0]"
				[Register ("hasNext", "()Z", "GetHasNextHandler")]
				get {
					const string __id = "hasNext.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

			static Delegate cb_nextIteration;
#pragma warning disable 0169
			static Delegate GetNextIterationHandler ()
			{
				if (cb_nextIteration == null)
					cb_nextIteration = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_NextIteration);
				return cb_nextIteration;
			}

			static void n_NextIteration (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Annimon.Stream.Iterator.PrimitiveExtIterator.OfLong __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveExtIterator.OfLong> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.NextIteration ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator.OfLong']/method[@name='nextIteration' and count(parameter)=0]"
			[Register ("nextIteration", "()V", "GetNextIterationHandler")]
			protected abstract void NextIteration ();

			static Delegate cb_nextLong;
#pragma warning disable 0169
			static Delegate GetNextLongHandler ()
			{
				if (cb_nextLong == null)
					cb_nextLong = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, long>) n_NextLong);
				return cb_nextLong;
			}

			static long n_NextLong (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Annimon.Stream.Iterator.PrimitiveExtIterator.OfLong __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveExtIterator.OfLong> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NextLong ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator.OfLong']/method[@name='nextLong' and count(parameter)=0]"
			[Register ("nextLong", "()J", "GetNextLongHandler")]
			public override unsafe long NextLong ()
			{
				const string __id = "nextLong.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

		}

		[global::Android.Runtime.Register ("com/annimon/stream/iterator/PrimitiveExtIterator$OfLong", DoNotGenerateAcw=true)]
		internal partial class OfLongInvoker : OfLong {

			public OfLongInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/iterator/PrimitiveExtIterator$OfLong", typeof (OfLongInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveExtIterator.OfLong']/method[@name='nextIteration' and count(parameter)=0]"
			[Register ("nextIteration", "()V", "GetNextIterationHandler")]
			protected override unsafe void NextIteration ()
			{
				const string __id = "nextIteration.()V";
				try {
					_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
				} finally {
				}
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/iterator/PrimitiveExtIterator", typeof (PrimitiveExtIterator));
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

		internal PrimitiveExtIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
