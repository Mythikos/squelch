package crc64acecdea9d5776d16;


public class UIBlackoutListHolder
	extends androidx.recyclerview.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Squelch.Library.UI.UIBlackoutListHolder, Squelch", UIBlackoutListHolder.class, __md_methods);
	}


	public UIBlackoutListHolder (android.view.View p0)
	{
		super (p0);
		if (getClass () == UIBlackoutListHolder.class)
			mono.android.TypeManager.Activate ("Squelch.Library.UI.UIBlackoutListHolder, Squelch", "Android.Views.View, Mono.Android", this, new java.lang.Object[] { p0 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
