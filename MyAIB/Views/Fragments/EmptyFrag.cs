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



namespace MyAIB.Views.Fragments
{
    public class EmptyFrag : Fragment
    {
        
        CardView emptycard;
        public static EmptyFrag newInst()
        {
            EmptyFrag emptyfrag = new EmptyFrag();
            return emptyfrag;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup parent, Bundle savedInstanceState)
        {
            View v = inflater.Inflate(Resource.Layout.empty_card_layout, parent, false);
            emptycard = v.FindViewById<CardView>(Resource.Id.empty_card);
            return v;
        }


        /*public View createView(LayoutInflater inflater, ViewGroup parent)
        {
            var v = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.empty_card_layout, parent, false);
            emptycard = v.FindViewById<CardView>(Resource.Id.empty_card);
            return v;
 	    }*/
}
}