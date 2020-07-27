package mono.com.applandeo.materialcalendarview.listeners;


public class OnCalendarPageChangeListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.applandeo.materialcalendarview.listeners.OnCalendarPageChangeListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onChange:()V:GetOnChangeHandler:Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListenerInvoker, library-material-calendar-view\n" +
			"";
		mono.android.Runtime.register ("Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListenerImplementor, library-material-calendar-view", OnCalendarPageChangeListenerImplementor.class, __md_methods);
	}


	public OnCalendarPageChangeListenerImplementor ()
	{
		super ();
		if (getClass () == OnCalendarPageChangeListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Applandeo.Materialcalendarview.Listeners.IOnCalendarPageChangeListenerImplementor, library-material-calendar-view", "", this, new java.lang.Object[] {  });
	}


	public void onChange ()
	{
		n_onChange ();
	}

	private native void n_onChange ();

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
