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
using Object = Java.Lang.Object;

namespace MyAIB.ParcelableCreator
{
    public class CanteenCreator : Object, IParcelableCreator
    {
      


         Object IParcelableCreator.CreateFromParcel(Parcel source)
        {
            CanteenItem canteenitem = new CanteenItem();

            canteenitem.menuid = source.ReadString();
            canteenitem.title = source.ReadString();
            canteenitem.canteenid = source.ReadString();
            canteenitem.canteenname = source.ReadString();
            canteenitem.day = source.ReadString();
            canteenitem.date = source.ReadString();
            canteenitem.allergen = source.ReadString();
            canteenitem.menuitemcode = source.ReadString();
            canteenitem.menuitemtypename = source.ReadString();
            canteenitem.numlikes = source.ReadString();
            canteenitem.diduserlike = source.ReadString();
            canteenitem.descript = source.ReadString();
            canteenitem.price = source.ReadString();

            return canteenitem;
        }

        Object[] IParcelableCreator.NewArray(int size)
        {
            return new Object[size];
        }
    }
}