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
using Android.Support.V7.Widget;

namespace MyAIB.ViewHolders
{
    public class CanteenViewHolder :RecyclerView.ViewHolder
    {
        public TextView name { get; set; }
        public TextView type { get; set; }
        public TextView cost { get; set; }


        public CanteenViewHolder(View v) :base(v)
        {

          name = (TextView) v.FindViewById(Resource.Id.nametxt);
          type = (TextView) v.FindViewById(Resource.Id.typetxt);
          cost = (TextView)v.FindViewById(Resource.Id.costtxt);
        }




    }
}