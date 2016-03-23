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

namespace MyAIB.Entities
{
    class User
    {

        private static  User app_user;
        //private Dictionary<string, string> userinfo;

        private User()
        {

        }


        public static User getUser()
        {

            if(app_user == null)
            {
                app_user = new User();
            }

            return app_user;
        }


        public Dictionary<string,string> getUserMap()
        {
           return  new Dictionary<string, string>(); 
        }







    }
}