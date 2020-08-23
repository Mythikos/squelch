package crc640722b965c6d4e9e0;


public class StatisticsFragment_IntFormatter
	extends com.github.mikephil.charting.formatter.LargeValueFormatter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getFormattedValue:(FLcom/github/mikephil/charting/data/Entry;ILcom/github/mikephil/charting/utils/ViewPortHandler;)Ljava/lang/String;:GetGetFormattedValue_FLcom_github_mikephil_charting_data_Entry_ILcom_github_mikephil_charting_utils_ViewPortHandler_Handler\n" +
			"";
		mono.android.Runtime.register ("Squelch.Fragments.StatisticsFragment+IntFormatter, Squelch", StatisticsFragment_IntFormatter.class, __md_methods);
	}


	public StatisticsFragment_IntFormatter ()
	{
		super ();
		if (getClass () == StatisticsFragment_IntFormatter.class)
			mono.android.TypeManager.Activate ("Squelch.Fragments.StatisticsFragment+IntFormatter, Squelch", "", this, new java.lang.Object[] {  });
	}


	public StatisticsFragment_IntFormatter (java.lang.String p0)
	{
		super (p0);
		if (getClass () == StatisticsFragment_IntFormatter.class)
			mono.android.TypeManager.Activate ("Squelch.Fragments.StatisticsFragment+IntFormatter, Squelch", "System.String, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public java.lang.String getFormattedValue (float p0, com.github.mikephil.charting.data.Entry p1, int p2, com.github.mikephil.charting.utils.ViewPortHandler p3)
	{
		return n_getFormattedValue (p0, p1, p2, p3);
	}

	private native java.lang.String n_getFormattedValue (float p0, com.github.mikephil.charting.data.Entry p1, int p2, com.github.mikephil.charting.utils.ViewPortHandler p3);

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
