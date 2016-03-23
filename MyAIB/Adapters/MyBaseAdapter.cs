using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Support.V7.Widget;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Util;

namespace MyAIB.Adapters
{
    public abstract class MyBaseAdapter<T> : RecyclerView.Adapter
    {
        protected Context cont;
        protected List<T> list;
        protected int layout_res;

        public MyBaseAdapter(Context contin, List<T> listin)
        {
            cont = contin;
            list = listin;
        }

        public class ViewHolder : RecyclerView.ViewHolder
        {

            private Dictionary<int, View> dict;
            private View v;
       
          


            public ViewHolder(View view) : base(view)
            {
                v = view;
                dict = new Dictionary<int, View>();
                dict.Add(0, v);
            }

          

            public View getView()
            {
                return getView(0);
            }


            public void initViewById(int id)
            {

                View v = (getView() != null) ? getView().FindViewById(id) : null;

                if (v != null)
                    dict.Add(id, v);
            }

            public View getView(int id)
            {

               if(dict.ContainsKey(id))
                {
                     return  dict[id];
                }
                else
                {
                    initViewById(id);
                }

               return dict[id];
                
            }
        }


        public override int ItemCount
        {
            get { return list.Count; }
        }


       

        public T getItem(int pos)
        {
            return list[pos];
        }

    

        public void setList(List<T> listin)
        {
            this.list = listin;
        }


        public List<T> getList()
        {
            return this.list;
        }


        public abstract View createView(Context context, ViewGroup viewGroup, int viewType);
        public abstract void bindView(T item, RecyclerView.ViewHolder viewHolder);
  





        public override void OnBindViewHolder(RecyclerView.ViewHolder vh, int pos)
        {
            bindView(getItem(pos), vh);
            Log.Debug("itempos", pos.ToString());
           
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {

            Log.Debug("on create vh", "oncreate vh");


            View v = createView(cont, parent, viewType);
            if (v == null)
                Log.Debug("view null", "null"); 
            else 
                Log.Debug("view not null", "null");

            return new ViewHolder(createView(cont, parent, viewType));
        }
    }
}