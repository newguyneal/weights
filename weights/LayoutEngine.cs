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

using weights.Models;

namespace weights
{
    public class LayoutEngine
    {
        private int _week_start = 0;
        private int _prim_start = 1;
        private int _sec_start = 6;
        private int _aux1_start = 10;
        private int _aux2_start = 13;
        private int _aux3_start = 16;
        private int _core_start = 19;
        private int _total_items = 23;
        private int _num_weeks;
        private int _cell_width;
        private int _cell_height;

        //default constructor
        public LayoutEngine() { }

        //need to add workout and all of its component classes
        public LayoutEngine(int weeks,int phone_width, int phone_height, Workout wo)
        {
            _num_weeks = weeks;
            _cell_height = phone_height / 24;
            _cell_width = phone_width / weeks+1;
        }
    }
}