using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream.Iterator {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIndexedIterator']"
	[global::Android.Runtime.Register ("com/annimon/stream/iterator/PrimitiveIndexedIterator", DoNotGenerateAcw=true)]
	public sealed partial class PrimitiveIndexedIterator : global::Java.Lang.Object {

		// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIndexedIterator.OfDouble']"
		[global::Android.Runtime.Register ("com/annimon/stream/iterator/PrimitiveIndexedIterator$OfDouble", DoNotGenerateAcw=true)]
		public partial class OfDouble : global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfDouble {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/iterator/PrimitiveIndexedIterator$OfDouble", typeof (OfDouble));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIndexedIterator.OfDouble']/constructor[@name='PrimitiveIndexedIterator.OfDouble' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.iterator.PrimitiveIterator.OfDouble']]"
			[Register (".ctor", "(Lcom/annimon/stream/iterator/PrimitiveIterator$OfDouble;)V", "")]
			public unsafe OfDouble (global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfDouble iterator)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/annimon/stream/iterator/PrimitiveIterator$OfDouble;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIndexedIterator.OfDouble']/constructor[@name='PrimitiveIndexedIterator.OfDouble' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.annimon.stream.iterator.PrimitiveIterator.OfDouble']]"
			[Register (".ctor", "(IILcom/annimon/stream/iterator/PrimitiveIterator$OfDouble;)V", "")]
			public unsafe OfDouble (int start, int step, global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfDouble iterator)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(IILcom/annimon/stream/iterator/PrimitiveIterator$OfDouble;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (start);
					__args [1] = new JniArgumentValue (step);
					__args [2] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
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
				global::Com.Annimon.Stream.Iterator.PrimitiveIndexedIterator.OfDouble __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveIndexedIterator.OfDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.HasNext;
			}
#pragma warning restore 0169

			public override unsafe bool HasNext {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIndexedIterator.OfDouble']/method[@name='hasNext' and count(parameter)=0]"
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

			static Delegate cb_getIndex;
#pragma warning disable 0169
			static Delegate GetGetIndexHandler ()
			{
				if (cb_getIndex == null)
					cb_getIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndex);
				return cb_getIndex;
			}

			static int n_GetIndex (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Annimon.Stream.Iterator.PrimitiveIndexedIterator.OfDouble __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveIndexedIterator.OfDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Index;
			}
#pragma warning restore 0169

			public virtual unsafe int Index {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIndexedIterator.OfDouble']/method[@name='getIndex' and count(parameter)=0]"
				[Register ("getIndex", "()I", "GetGetIndexHandler")]
				get {
					const string __id = "getIndex.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
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
				global::Com.Annimon.Stream.Iterator.PrimitiveIndexedIterator.OfDouble __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveIndexedIterator.OfDouble> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NextDouble ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIndexedIterator.OfDouble']/method[@name='nextDouble' and count(parameter)=0]"
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIndexedIterator.OfInt']"
		[global::Android.Runtime.Register ("com/annimon/stream/iterator/PrimitiveIndexedIterator$OfInt", DoNotGenerateAcw=true)]
		public partial class OfInt : global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfInt {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/iterator/PrimitiveIndexedIterator$OfInt", typeof (OfInt));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIndexedIterator.OfInt']/constructor[@name='PrimitiveIndexedIterator.OfInt' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.iterator.PrimitiveIterator.OfInt']]"
			[Register (".ctor", "(Lcom/annimon/stream/iterator/PrimitiveIterator$OfInt;)V", "")]
			public unsafe OfInt (global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfInt iterator)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/annimon/stream/iterator/PrimitiveIterator$OfInt;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIndexedIterator.OfInt']/constructor[@name='PrimitiveIndexedIterator.OfInt' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.annimon.stream.iterator.PrimitiveIterator.OfInt']]"
			[Register (".ctor", "(IILcom/annimon/stream/iterator/PrimitiveIterator$OfInt;)V", "")]
			public unsafe OfInt (int start, int step, global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfInt iterator)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(IILcom/annimon/stream/iterator/PrimitiveIterator$OfInt;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (start);
					__args [1] = new JniArgumentValue (step);
					__args [2] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
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
				global::Com.Annimon.Stream.Iterator.PrimitiveIndexedIterator.OfInt __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveIndexedIterator.OfInt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.HasNext;
			}
#pragma warning restore 0169

			public override unsafe bool HasNext {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIndexedIterator.OfInt']/method[@name='hasNext' and count(parameter)=0]"
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

			static Delegate cb_getIndex;
#pragma warning disable 0169
			static Delegate GetGetIndexHandler ()
			{
				if (cb_getIndex == null)
					cb_getIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndex);
				return cb_getIndex;
			}

			static int n_GetIndex (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Annimon.Stream.Iterator.PrimitiveIndexedIterator.OfInt __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveIndexedIterator.OfInt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Index;
			}
#pragma warning restore 0169

			public virtual unsafe int Index {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIndexedIterator.OfInt']/method[@name='getIndex' and count(parameter)=0]"
				[Register ("getIndex", "()I", "GetGetIndexHandler")]
				get {
					const string __id = "getIndex.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
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
				global::Com.Annimon.Stream.Iterator.PrimitiveIndexedIterator.OfInt __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveIndexedIterator.OfInt> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NextInt ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIndexedIterator.OfInt']/method[@name='nextInt' and count(parameter)=0]"
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

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIndexedIterator.OfLong']"
		[global::Android.Runtime.Register ("com/annimon/stream/iterator/PrimitiveIndexedIterator$OfLong", DoNotGenerateAcw=true)]
		public partial class OfLong : global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfLong {

			static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/iterator/PrimitiveIndexedIterator$OfLong", typeof (OfLong));
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

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIndexedIterator.OfLong']/constructor[@name='PrimitiveIndexedIterator.OfLong' and count(parameter)=1 and parameter[1][@type='com.annimon.stream.iterator.PrimitiveIterator.OfLong']]"
			[Register (".ctor", "(Lcom/annimon/stream/iterator/PrimitiveIterator$OfLong;)V", "")]
			public unsafe OfLong (global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfLong iterator)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(Lcom/annimon/stream/iterator/PrimitiveIterator$OfLong;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
				} finally {
				}
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIndexedIterator.OfLong']/constructor[@name='PrimitiveIndexedIterator.OfLong' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='com.annimon.stream.iterator.PrimitiveIterator.OfLong']]"
			[Register (".ctor", "(IILcom/annimon/stream/iterator/PrimitiveIterator$OfLong;)V", "")]
			public unsafe OfLong (int start, int step, global::Com.Annimon.Stream.Iterator.PrimitiveIterator.OfLong iterator)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				const string __id = "(IILcom/annimon/stream/iterator/PrimitiveIterator$OfLong;)V";

				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [3];
					__args [0] = new JniArgumentValue (start);
					__args [1] = new JniArgumentValue (step);
					__args [2] = new JniArgumentValue ((iterator == null) ? IntPtr.Zero : ((global::Java.Lang.Object) iterator).Handle);
					var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
					SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
					_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
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
				global::Com.Annimon.Stream.Iterator.PrimitiveIndexedIterator.OfLong __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveIndexedIterator.OfLong> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.HasNext;
			}
#pragma warning restore 0169

			public override unsafe bool HasNext {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIndexedIterator.OfLong']/method[@name='hasNext' and count(parameter)=0]"
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

			static Delegate cb_getIndex;
#pragma warning disable 0169
			static Delegate GetGetIndexHandler ()
			{
				if (cb_getIndex == null)
					cb_getIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetIndex);
				return cb_getIndex;
			}

			static int n_GetIndex (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Annimon.Stream.Iterator.PrimitiveIndexedIterator.OfLong __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveIndexedIterator.OfLong> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Index;
			}
#pragma warning restore 0169

			public virtual unsafe int Index {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIndexedIterator.OfLong']/method[@name='getIndex' and count(parameter)=0]"
				[Register ("getIndex", "()I", "GetGetIndexHandler")]
				get {
					const string __id = "getIndex.()I";
					try {
						var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
						return __rm;
					} finally {
					}
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
				global::Com.Annimon.Stream.Iterator.PrimitiveIndexedIterator.OfLong __this = global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.Iterator.PrimitiveIndexedIterator.OfLong> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.NextLong ();
			}
#pragma warning restore 0169

			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream.iterator']/class[@name='PrimitiveIndexedIterator.OfLong']/method[@name='nextLong' and count(parameter)=0]"
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

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/iterator/PrimitiveIndexedIterator", typeof (PrimitiveIndexedIterator));
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

		internal PrimitiveIndexedIterator (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

	}
}
