using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Iterator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator']"
	[global::Android.Runtime.Register ("com/annimon/stream/iterator/PrimitiveIterator", DoNotGenerateAcw=true)]
	public sealed partial class PrimitiveIterator : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator.OfDouble']"
		[global::Android.Runtime.Register ("com/annimon/stream/iterator/PrimitiveIterator$OfDouble", DoNotGenerateAcw=true)]
		public abstract partial class OfDouble : global::Java.Lang.Object, global::Java.Util.IIterator {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/iterator/PrimitiveIterator$OfDouble", typeof (OfDouble));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator.OfDouble']/constructor[@name='PrimitiveIterator.OfDouble' and count(parameter)=0]"
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

			static Delegate cb_next;
#pragma warning disable 0169
			static Delegate GetNextHandler ()
			{
				if (cb_next == null)
					cb_next = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Next);
				return cb_next;
			}

			static IntPtr n_Next (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfDouble __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Next ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator.OfDouble']/method[@name='next' and count(parameter)=0]"
			[Register ("next", "()Ljava/lang/Double;", "GetNextHandler")]
			public virtual unsafe global::Java.Lang.Object Next ()
			{
				const string __id = "next.()Ljava/lang/Double;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
				global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfDouble __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NextDouble ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator.OfDouble']/method[@name='nextDouble' and count(parameter)=0]"
			[Register ("nextDouble", "()D", "GetNextDoubleHandler")]
			public abstract double NextDouble ();

			static Delegate cb_remove;
#pragma warning disable 0169
			static Delegate GetRemoveHandler ()
			{
				if (cb_remove == null)
					cb_remove = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Remove);
				return cb_remove;
			}

			static void n_Remove (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfDouble __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Remove ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator.OfDouble']/method[@name='remove' and count(parameter)=0]"
			[Register ("remove", "()V", "GetRemoveHandler")]
			public virtual unsafe void Remove ()
			{
				const string __id = "remove.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_hasNext;
#pragma warning disable 0169
			static Delegate GetGetHasNextHandler ()
			{
				if (cb_hasNext == null)
					cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetHasNext);
				return cb_hasNext;
			}

			static bool n_GetHasNext (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfDouble __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.HasNext;
			}
#pragma warning restore 0169

			public abstract global::System.Boolean HasNext {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator.OfDouble']/method[@name='hasNext' and count(parameter)=0]"
				[Register ("hasNext", "()Z", "GetGetHasNextHandler")] get;
			}

		}

		[global::Android.Runtime.Register ("com/annimon/stream/iterator/PrimitiveIterator$OfDouble", DoNotGenerateAcw=true)]
		internal partial class OfDoubleInvoker : OfDouble {

			public OfDoubleInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/iterator/PrimitiveIterator$OfDouble", typeof (OfDoubleInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator.OfDouble']/method[@name='nextDouble' and count(parameter)=0]"
			[Register ("nextDouble", "()D", "GetNextDoubleHandler")]
			public override unsafe double NextDouble ()
			{
				const string __id = "nextDouble.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}

			public override unsafe global::System.Boolean HasNext {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator.OfDouble']/method[@name='hasNext' and count(parameter)=0]"
				[Register ("hasNext", "()Z", "GetGetHasNextHandler")]
				get {
					const string __id = "hasNext.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator.OfInt']"
		[global::Android.Runtime.Register ("com/annimon/stream/iterator/PrimitiveIterator$OfInt", DoNotGenerateAcw=true)]
		public abstract partial class OfInt : global::Java.Lang.Object, global::Java.Util.IIterator {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/iterator/PrimitiveIterator$OfInt", typeof (OfInt));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator.OfInt']/constructor[@name='PrimitiveIterator.OfInt' and count(parameter)=0]"
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

			static Delegate cb_next;
#pragma warning disable 0169
			static Delegate GetNextHandler ()
			{
				if (cb_next == null)
					cb_next = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Next);
				return cb_next;
			}

			static IntPtr n_Next (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfInt __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfInt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Next ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator.OfInt']/method[@name='next' and count(parameter)=0]"
			[Register ("next", "()Ljava/lang/Integer;", "GetNextHandler")]
			public virtual unsafe global::Java.Lang.Object Next ()
			{
				const string __id = "next.()Ljava/lang/Integer;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
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
				global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfInt __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfInt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NextInt ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator.OfInt']/method[@name='nextInt' and count(parameter)=0]"
			[Register ("nextInt", "()I", "GetNextIntHandler")]
			public abstract int NextInt ();

			static Delegate cb_remove;
#pragma warning disable 0169
			static Delegate GetRemoveHandler ()
			{
				if (cb_remove == null)
					cb_remove = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Remove);
				return cb_remove;
			}

			static void n_Remove (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfInt __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfInt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Remove ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator.OfInt']/method[@name='remove' and count(parameter)=0]"
			[Register ("remove", "()V", "GetRemoveHandler")]
			public virtual unsafe void Remove ()
			{
				const string __id = "remove.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_hasNext;
#pragma warning disable 0169
			static Delegate GetGetHasNextHandler ()
			{
				if (cb_hasNext == null)
					cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetHasNext);
				return cb_hasNext;
			}

			static bool n_GetHasNext (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfInt __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfInt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.HasNext;
			}
#pragma warning restore 0169

			public abstract global::System.Boolean HasNext {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator.OfInt']/method[@name='hasNext' and count(parameter)=0]"
				[Register ("hasNext", "()Z", "GetGetHasNextHandler")] get;
			}

		}

		[global::Android.Runtime.Register ("com/annimon/stream/iterator/PrimitiveIterator$OfInt", DoNotGenerateAcw=true)]
		internal partial class OfIntInvoker : OfInt {

			public OfIntInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/iterator/PrimitiveIterator$OfInt", typeof (OfIntInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator.OfInt']/method[@name='nextInt' and count(parameter)=0]"
			[Register ("nextInt", "()I", "GetNextIntHandler")]
			public override unsafe int NextInt ()
			{
				const string __id = "nextInt.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			public override unsafe global::System.Boolean HasNext {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator.OfInt']/method[@name='hasNext' and count(parameter)=0]"
				[Register ("hasNext", "()Z", "GetGetHasNextHandler")]
				get {
					const string __id = "hasNext.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}


		// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator.OfLong']"
		[global::Android.Runtime.Register ("com/annimon/stream/iterator/PrimitiveIterator$OfLong", DoNotGenerateAcw=true)]
		public abstract partial class OfLong : global::Java.Lang.Object, global::Java.Util.IIterator {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/iterator/PrimitiveIterator$OfLong", typeof (OfLong));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator.OfLong']/constructor[@name='PrimitiveIterator.OfLong' and count(parameter)=0]"
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

			static Delegate cb_next;
#pragma warning disable 0169
			static Delegate GetNextHandler ()
			{
				if (cb_next == null)
					cb_next = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Next);
				return cb_next;
			}

			static IntPtr n_Next (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfLong __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfLong> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.Next ());
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator.OfLong']/method[@name='next' and count(parameter)=0]"
			[Register ("next", "()Ljava/lang/Long;", "GetNextHandler")]
			public virtual unsafe global::Java.Lang.Object Next ()
			{
				const string __id = "next.()Ljava/lang/Long;";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

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
				global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfLong __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfLong> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NextLong ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator.OfLong']/method[@name='nextLong' and count(parameter)=0]"
			[Register ("nextLong", "()J", "GetNextLongHandler")]
			public abstract long NextLong ();

			static Delegate cb_remove;
#pragma warning disable 0169
			static Delegate GetRemoveHandler ()
			{
				if (cb_remove == null)
					cb_remove = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Remove);
				return cb_remove;
			}

			static void n_Remove (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfLong __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfLong> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				__this.Remove ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator.OfLong']/method[@name='remove' and count(parameter)=0]"
			[Register ("remove", "()V", "GetRemoveHandler")]
			public virtual unsafe void Remove ()
			{
				const string __id = "remove.()V";
				try {
					_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, null);
				} finally {
				}
			}

			static Delegate cb_hasNext;
#pragma warning disable 0169
			static Delegate GetGetHasNextHandler ()
			{
				if (cb_hasNext == null)
					cb_hasNext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_GetHasNext);
				return cb_hasNext;
			}

			static bool n_GetHasNext (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfLong __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfLong> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.HasNext;
			}
#pragma warning restore 0169

			public abstract global::System.Boolean HasNext {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator.OfLong']/method[@name='hasNext' and count(parameter)=0]"
				[Register ("hasNext", "()Z", "GetGetHasNextHandler")] get;
			}

		}

		[global::Android.Runtime.Register ("com/annimon/stream/iterator/PrimitiveIterator$OfLong", DoNotGenerateAcw=true)]
		internal partial class OfLongInvoker : OfLong {

			public OfLongInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/iterator/PrimitiveIterator$OfLong", typeof (OfLongInvoker));

			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator.OfLong']/method[@name='nextLong' and count(parameter)=0]"
			[Register ("nextLong", "()J", "GetNextLongHandler")]
			public override unsafe long NextLong ()
			{
				const string __id = "nextLong.()J";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt64Method (__id, this, null);
					return __rm;
				} finally {
				}
			}

			public override unsafe global::System.Boolean HasNext {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIterator.OfLong']/method[@name='hasNext' and count(parameter)=0]"
				[Register ("hasNext", "()Z", "GetGetHasNextHandler")]
				get {
					const string __id = "hasNext.()Z";
					try {
						var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
						return __rm;
					} finally {
					}
				}
			}

		}


		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/iterator/PrimitiveIterator", typeof (PrimitiveIterator));
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

		internal PrimitiveIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
