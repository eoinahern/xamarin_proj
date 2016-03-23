package md592e97a33835f007e643cca20cbf05fc5;


public class CanteenAdapter
	extends md592e97a33835f007e643cca20cbf05fc5.MyBaseAdapter_1
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MyAIB.Adapters.CanteenAdapter, MyAIB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", CanteenAdapter.class, __md_methods);
	}


	public CanteenAdapter () throws java.lang.Throwable
	{
		super ();
		if (getClass () == CanteenAdapter.class)
			mono.android.TypeManager.Activate ("MyAIB.Adapters.CanteenAdapter, MyAIB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	java.util.ArrayList refList;
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
