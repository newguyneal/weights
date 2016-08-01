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
using Android.Graphics;
using static Android.Widget.GridLayout;

namespace weights
{
    [Activity(Label = "OneDayActivity")]
    public class OneDayActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            // Create your application here
            SetContentView(Resource.Layout.OneDay);
            populate();
            
        }

        //try to figure out how to add borders to cells programatically
        private void populate()
        {
            GridLayout grid_layout = FindViewById<GridLayout>(Resource.Id.OneDayGridLayout);
            
            
            int col = 3;
            int row = 23;
            int total = row * col;
            //go through all cells and add borders and spacing to everything
            for(int i = 0, c = 1, r = 1; i < total; i++, r++)
            {
                if (r == row+1)
                {
                    c++;
                    r = 1;
                }
                EditText tv = new EditText(this);
                tv.TextSize = 5;
                tv.SetTextColor(Color.Black);
                //set the parameters for the textview and gridview cell
                tv.LayoutParameters = new ViewGroup.LayoutParams(180, 50);
                tv.SetBackgroundColor(Color.White);
                Spec row_spec = GridLayout.InvokeSpec(r);
                Spec col_spec = GridLayout.InvokeSpec(c);
                GridLayout.LayoutParams grid_params = new GridLayout.LayoutParams(row_spec,col_spec);
                grid_params.Width = 180;
                grid_params.Height = 50;
                grid_params.SetMargins(1, 1, 1, 1);
                grid_layout.AddView(tv, grid_params);
                
            }

        }
    }
}