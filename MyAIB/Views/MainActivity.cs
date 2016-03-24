using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Newtonsoft.Json;
using Android.Support.V7.App;
using MyAIB.Views.Fragments;
using Android.Util;

namespace MyAIB.Views
{
    [Activity(Label = "MyAIB", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity 
    {


        private CanteenFragment canteenfrag;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);


            canteenfrag = CanteenFragment.newInstance();
            EmptyFrag emptyfrag = EmptyFrag.newInst();
            var fragmentTrans = FragmentManager.BeginTransaction();
            fragmentTrans.Add(Resource.Id.my_nested_llayout, canteenfrag);
            fragmentTrans.Add(Resource.Id.my_nested_llayout, emptyfrag);
            fragmentTrans.Commit();

        }
    }
}

