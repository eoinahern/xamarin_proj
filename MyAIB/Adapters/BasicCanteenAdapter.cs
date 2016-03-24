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
using MyAIB.Entities;
using MyAIB.ViewHolders;

namespace MyAIB.Adapters
{
    class BasicCanteenAdapter : RecyclerView.Adapter
    {

        private List<CanteenItem> canteenlist;
        private CanteenViewHolder cantvh;
      
        
        public BasicCanteenAdapter(List<CanteenItem> cantlistin)
        {
            canteenlist = cantlistin;
        }
        
        public override int ItemCount
        {
            get { return canteenlist.Count; }
        }

        public override void OnBindViewHolder(RecyclerView.ViewHolder vh, int pos)
        {

            CanteenViewHolder cantvh = (CanteenViewHolder)vh;
            CanteenItem tempcantitem = canteenlist[pos];
            cantvh.cost.Text = tempcantitem.price;
            cantvh.type.Text = tempcantitem.descript;
            cantvh.name.Text = tempcantitem.title;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var layout = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.canteen_row, parent, false);
            return new CanteenViewHolder(layout);
        }
    }
}