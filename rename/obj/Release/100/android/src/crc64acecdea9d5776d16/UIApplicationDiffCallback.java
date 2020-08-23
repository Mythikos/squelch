package crc64acecdea9d5776d16;


public class UIApplicationDiffCallback
	extends androidx.recyclerview.widget.DiffUtil.Callback
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getNewListSize:()I:GetGetNewListSizeHandler\n" +
			"n_getOldListSize:()I:GetGetOldListSizeHandler\n" +
			"n_areContentsTheSame:(II)Z:GetAreContentsTheSame_IIHandler\n" +
			"n_areItemsTheSame:(II)Z:GetAreItemsTheSame_IIHandler\n" +
			"";
		mono.android.Runtime.register ("Squelch.Library.UI.UIApplicationDiffCallback, Squelch", UIApplicationDiffCallback.class, __md_methods);
	}


	public UIApplicationDiffCallback ()
	{
		super ();
		if (getClass () == UIApplicationDiffCallback.class)
			mono.android.TypeManager.Activate ("Squelch.Library.UI.UIApplicationDiffCallback, Squelch", "", this, new java.lang.Object[] {  });
	}


	public int getNewListSize ()
	{
		return n_getNewListSize ();
	}

	private native int n_getNewListSize ();


	public int getOldListSize ()
	{
		return n_getOldListSize ();
	}

	private native int n_getOldListSize ();


	public boolean areContentsTheSame (int p0, int p1)
	{
		return n_areContentsTheSame (p0, p1);
	}

	private native boolean n_areContentsTheSame (int p0, int p1);


	public boolean areItemsTheSame (int p0, int p1)
	{
		return n_areItemsTheSame (p0, p1);
	}

	private native boolean n_areItemsTheSame (int p0, int p1);

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
