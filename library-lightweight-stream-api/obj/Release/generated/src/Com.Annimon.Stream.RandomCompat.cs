using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Annimon.Stream {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.annimon.stream']/class[@name='RandomCompat']"
	[global::Android.Runtime.Register ("com/annimon/stream/RandomCompat", DoNotGenerateAcw=true)]
	public sealed partial class RandomCompat : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/annimon/stream/RandomCompat", typeof (RandomCompat));
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

		internal RandomCompat (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream']/class[@name='RandomCompat']/constructor[@name='RandomCompat' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe RandomCompat ()
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

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream']/class[@name='RandomCompat']/constructor[@name='RandomCompat' and count(parameter)=1 and parameter[1][@type='java.util.Random']]"
		[Register (".ctor", "(Ljava/util/Random;)V", "")]
		public unsafe RandomCompat (global::Java.Util.Random random)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/Random;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((random == null) ? IntPtr.Zero : ((global::Java.Lang.Object) random).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.annimon.stream']/class[@name='RandomCompat']/constructor[@name='RandomCompat' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register (".ctor", "(J)V", "")]
		public unsafe RandomCompat (long seed)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (seed);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		public unsafe global::Java.Util.Random Random {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='RandomCompat']/method[@name='getRandom' and count(parameter)=0]"
			[Register ("getRandom", "()Ljava/util/Random;", "")]
			get {
				const string __id = "getRandom.()Ljava/util/Random;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Random> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='RandomCompat']/method[@name='doubles' and count(parameter)=0]"
		[Register ("doubles", "()Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream Doubles ()
		{
			const string __id = "doubles.()Lcom/annimon/stream/DoubleStream;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='RandomCompat']/method[@name='doubles' and count(parameter)=2 and parameter[1][@type='double'] and parameter[2][@type='double']]"
		[Register ("doubles", "(DD)Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream Doubles (double randomNumberOrigin, double randomNumberBound)
		{
			const string __id = "doubles.(DD)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (randomNumberOrigin);
				__args [1] = new JniArgumentValue (randomNumberBound);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='RandomCompat']/method[@name='doubles' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("doubles", "(J)Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream Doubles (long streamSize)
		{
			const string __id = "doubles.(J)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (streamSize);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='RandomCompat']/method[@name='doubles' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='double'] and parameter[3][@type='double']]"
		[Register ("doubles", "(JDD)Lcom/annimon/stream/DoubleStream;", "")]
		public unsafe global::Com.Annimon.Stream.DoubleStream Doubles (long streamSize, double randomNumberOrigin, double randomNumberBound)
		{
			const string __id = "doubles.(JDD)Lcom/annimon/stream/DoubleStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (streamSize);
				__args [1] = new JniArgumentValue (randomNumberOrigin);
				__args [2] = new JniArgumentValue (randomNumberBound);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.DoubleStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='RandomCompat']/method[@name='ints' and count(parameter)=0]"
		[Register ("ints", "()Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream Ints ()
		{
			const string __id = "ints.()Lcom/annimon/stream/IntStream;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='RandomCompat']/method[@name='ints' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("ints", "(II)Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream Ints (int randomNumberOrigin, int randomNumberBound)
		{
			const string __id = "ints.(II)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (randomNumberOrigin);
				__args [1] = new JniArgumentValue (randomNumberBound);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='RandomCompat']/method[@name='ints' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("ints", "(J)Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream Ints (long streamSize)
		{
			const string __id = "ints.(J)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (streamSize);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='RandomCompat']/method[@name='ints' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("ints", "(JII)Lcom/annimon/stream/IntStream;", "")]
		public unsafe global::Com.Annimon.Stream.IntStream Ints (long streamSize, int randomNumberOrigin, int randomNumberBound)
		{
			const string __id = "ints.(JII)Lcom/annimon/stream/IntStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (streamSize);
				__args [1] = new JniArgumentValue (randomNumberOrigin);
				__args [2] = new JniArgumentValue (randomNumberBound);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.IntStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='RandomCompat']/method[@name='longs' and count(parameter)=0]"
		[Register ("longs", "()Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream Longs ()
		{
			const string __id = "longs.()Lcom/annimon/stream/LongStream;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='RandomCompat']/method[@name='longs' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("longs", "(J)Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream Longs (long streamSize)
		{
			const string __id = "longs.(J)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (streamSize);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='RandomCompat']/method[@name='longs' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("longs", "(JJ)Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream Longs (long randomNumberOrigin, long randomNumberBound)
		{
			const string __id = "longs.(JJ)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (randomNumberOrigin);
				__args [1] = new JniArgumentValue (randomNumberBound);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.annimon.stream']/class[@name='RandomCompat']/method[@name='longs' and count(parameter)=3 and parameter[1][@type='long'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register ("longs", "(JJJ)Lcom/annimon/stream/LongStream;", "")]
		public unsafe global::Com.Annimon.Stream.LongStream Longs (long streamSize, long randomNumberOrigin, long randomNumberBound)
		{
			const string __id = "longs.(JJJ)Lcom/annimon/stream/LongStream;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (streamSize);
				__args [1] = new JniArgumentValue (randomNumberOrigin);
				__args [2] = new JniArgumentValue (randomNumberBound);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Annimon.Stream.LongStream> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
