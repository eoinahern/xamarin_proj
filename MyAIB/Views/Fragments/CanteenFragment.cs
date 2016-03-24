using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Support.V7.Widget;
using MyAIB.Adapters;
using MyAIB.Entities;

namespace MyAIB.Views.Fragments
{
    public class CanteenFragment : Fragment
    {

        private RecyclerView recview;
        private LinearLayoutManager llmanager;
        private BasicCanteenAdapter canteenadapter;



        public static CanteenFragment newInstance()
        {
            return new CanteenFragment();
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }


         private  List<CanteenItem> createDummyList()
        {

            List<CanteenItem> cantlist = new List<CanteenItem>();

            CanteenItem cant1 = new CanteenItem();
            CanteenItem cant2 = new CanteenItem();
            CanteenItem cant3 = new CanteenItem();

            cant1.descript = "food";
            cant1.title = "burger";
            cant1.price = "3.00";

            cant2.descript = "soup";
            cant2.title = "mushroom";
            cant2.price = "50.00";
            cant3.descript = "soup";
            cant3.title = "cauliflower & potato";
            cant3.price = "50.00";

            cantlist.Add(cant1);
            cantlist.Add(cant2);
            cantlist.Add(cant3);

            return cantlist;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            // return inflater.Inflate(Resource.Layout.YourFragment, container, false);
            //base.OnCreateView(inflater, container, savedInstanceState);




            View v = inflater.Inflate(Resource.Layout.canteen_frag_layout, container, false);
            recview = v.FindViewById<RecyclerView>(Resource.Id.canteen_recview);
            createRecview();
            return v;
        }


        private void createRecview()
        {
            canteenadapter = new BasicCanteenAdapter(createDummyList());
            Log.Debug("list len", createDummyList().Count.ToString());
            Log.Debug("cant adapt", " created");
            llmanager = new LinearLayoutManager(Activity, LinearLayoutManager.Vertical, false);
            recview.SetLayoutManager(llmanager);
            recview.SetAdapter(canteenadapter);

        }
    }
}