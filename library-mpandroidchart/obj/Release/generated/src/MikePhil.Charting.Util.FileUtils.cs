using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace MikePhil.Charting.Util {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='FileUtils']"
	[global::Android.Runtime.Register ("com/github/mikephil/charting/utils/FileUtils", DoNotGenerateAcw=true)]
	public partial class FileUtils : global::Java.Lang.Object {

		internal    new     static  readonly    JniPeerMembers  _members    = new XAPeerMembers ("com/github/mikephil/charting/utils/FileUtils", typeof (FileUtils));
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

		protected FileUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='FileUtils']/constructor[@name='FileUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe FileUtils ()
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='FileUtils']/method[@name='loadBarEntriesFromAssets' and count(parameter)=2 and parameter[1][@type='android.content.res.AssetManager'] and parameter[2][@type='java.lang.String']]"
		[Register ("loadBarEntriesFromAssets", "(Landroid/content/res/AssetManager;Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::MikePhil.Charting.Data.BarEntry> LoadBarEntriesFromAssets (global::Android.Content.Res.AssetManager am, string path)
		{
			const string __id = "loadBarEntriesFromAssets.(Landroid/content/res/AssetManager;Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((am == null) ? IntPtr.Zero : ((global::Java.Lang.Object) am).Handle);
				__args [1] = new JniArgumentValue (native_path);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::MikePhil.Charting.Data.BarEntry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='FileUtils']/method[@name='loadEntriesFromAssets' and count(parameter)=2 and parameter[1][@type='android.content.res.AssetManager'] and parameter[2][@type='java.lang.String']]"
		[Register ("loadEntriesFromAssets", "(Landroid/content/res/AssetManager;Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::MikePhil.Charting.Data.Entry> LoadEntriesFromAssets (global::Android.Content.Res.AssetManager am, string path)
		{
			const string __id = "loadEntriesFromAssets.(Landroid/content/res/AssetManager;Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((am == null) ? IntPtr.Zero : ((global::Java.Lang.Object) am).Handle);
				__args [1] = new JniArgumentValue (native_path);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::MikePhil.Charting.Data.Entry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='FileUtils']/method[@name='loadEntriesFromFile' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("loadEntriesFromFile", "(Ljava/lang/String;)Ljava/util/List;", "")]
		public static unsafe global::System.Collections.Generic.IList<global::MikePhil.Charting.Data.Entry> LoadEntriesFromFile (string path)
		{
			const string __id = "loadEntriesFromFile.(Ljava/lang/String;)Ljava/util/List;";
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_path);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Android.Runtime.JavaList<global::MikePhil.Charting.Data.Entry>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.github.mikephil.charting.utils']/class[@name='FileUtils']/method[@name='saveToSdCard' and count(parameter)=2 and parameter[1][@type='java.util.List&lt;com.github.mikephil.charting.data.Entry&gt;'] and parameter[2][@type='java.lang.String']]"
		[Register ("saveToSdCard", "(Ljava/util/List;Ljava/lang/String;)V", "")]
		public static unsafe void SaveToSdCard (global::System.Collections.Generic.IList<global::MikePhil.Charting.Data.Entry> entries, string path)
		{
			const string __id = "saveToSdCard.(Ljava/util/List;Ljava/lang/String;)V";
			IntPtr native_entries = global::Android.Runtime.JavaList<global::MikePhil.Charting.Data.Entry>.ToLocalJniHandle (entries);
			IntPtr native_path = JNIEnv.NewString (path);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_entries);
				__args [1] = new JniArgumentValue (native_path);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_entries);
				JNIEnv.DeleteLocalRef (native_path);
			}
		}

	}
}
