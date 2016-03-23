package md592e97a33835f007e643cca20cbf05fc5;


public class MyBaseAdapter_1_ViewHolder
	extends android.support.v7.widget.RecyclerView.ViewHolder
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("MyAIB.Adapters.MyBaseAdapter`1+ViewHolder, MyAIB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MyBaseAdapter_1_ViewHolder.class, __md_methods);
	}


	public MyBaseAdapter_1_ViewHolder (android.view.View p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == MyBaseAdapter_1_ViewHolder.class)
			mono.android.TypeManager.Activate ("MyAIB.Adapters.MyBaseAdapter`1+ViewHolder, MyAIB, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Views.View, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
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
