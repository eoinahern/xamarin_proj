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
using MyAIB.ParcelableCreator;
using Java.Interop;

using Object = Java.Lang.Object;

namespace MyAIB.Entities
{
    public class CanteenItem : Object, IParcelable
    {

    public string menuid { get; set; }
    public string title { get; set; }
    public string canteenid { get; set; }
    public string canteenname { get; set; }
    public string day { get; set; }
    public string date { get; set; }
    public string allergen { get; set; }
    public string menuitemcode { get; set; }
    public string menuitemtypename { get; set; }
    public string numlikes { get; set; }
    public string diduserlike { get; set; }
    public string descript { get; set; }
    public string price { get; set; }

    public CanteenItem()
    {
    }

        //[ExportField("CREATOR")]
        public static CanteenCreator InitializeCreator()
        {
            return new CanteenCreator();
        }


      

        public int DescribeContents()
        {
            return 0;
        }

        public void WriteToParcel(Parcel oot, ParcelableWriteFlags flags)
        {

            oot.WriteString(menuid);
            oot.WriteString(title);
            oot.WriteString(canteenid);
            oot.WriteString(canteenname);
            oot.WriteString(day);
            oot.WriteString(date);
            oot.WriteString(allergen);
            oot.WriteString(menuitemcode);
            oot.WriteString(menuitemtypename);
            oot.WriteString(numlikes);
            oot.WriteString(diduserlike);
            oot.WriteString(descript);
            oot.WriteString(price);
            
        }



       
    }
}