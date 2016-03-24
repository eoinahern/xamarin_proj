using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using MyAIB.Entities;
using Android.Support.V7.Widget;
using MyAIB.ViewHolders;
using Android.Util;

namespace MyAIB.Adapters
{
    public class CanteenAdapter : MyBaseAdapter<CanteenItem>
    {


        public CanteenAdapter(Context contin, List<CanteenItem> listin) :base(contin, listin)
        {
        }

        
        
        public  override View createView(Context cont, ViewGroup viewGroup, int viewType)
        {
            LayoutInflater inflater = (LayoutInflater)   cont.GetSystemService(Context.LayoutInflaterService);
            View v = inflater.Inflate(Resource.Layout.canteen_row, viewGroup, false);




            Log.Debug("view created", "created");
            
            if(v != null)
            {
                Log.Debug("view not null", "not null");
            }

            return v;
        }

     

        public override void bindView(CanteenItem item, RecyclerView.ViewHolder vh)
        {

            if (item != null)
            {
                ViewHolder viewholder = ((ViewHolder)vh);

                TextView name = (TextView)((ViewHolder)vh).getView(Resource.Id.nametxt);
                TextView type = (TextView)((ViewHolder)vh).getView(Resource.Id.typetxt);
                TextView cost = (TextView)((ViewHolder)vh).getView(Resource.Id.costtxt);

                Log.Debug("name", item.title);
                Log.Debug("type", item.descript);
                Log.Debug("price", item.price);



                name.Text = item.title;
                type.Text = item.descript;
                cost.Text = item.price;
            }
            else
            {
                Log.Debug("item null", "null");
            }

            
        }

    }
}