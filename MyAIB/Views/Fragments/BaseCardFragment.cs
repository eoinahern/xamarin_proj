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

namespace MyAIB.Views.Fragments
{
    public abstract class BaseCardFragment : Fragment
    {

        
        /*public static BaseCardFragment newInstance(int layoutRes)
        {

            var childfrag = getChildFragment();
            childfrag.Arguments.PutInt("resid", layoutres);
            return childfrag;
        }*/


        /*protected int resid
        {
            get { Arguments.GetInt("resid", -1)}
        }*/


        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return createView(inflater, container);
        }

         public abstract View createView(LayoutInflater inflater,ViewGroup container);
         
       
        }
}