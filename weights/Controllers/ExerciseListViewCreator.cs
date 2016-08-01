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

namespace weights.Controllers
{
    class ExerciseListViewCreator
    {
        private List<string> _names = new List<string>();
        private List<Exercise> _my_ex;
        private ListView _mlist_view;

        //default constructor
        public ExerciseListViewCreator() { }

        //constructor
        public ExerciseListViewCreator(List<Exercise> ex, ListView lv)
        {
            _my_ex = ex;
            _mlist_view = lv;
            AddNames();
        }

        //helper function that adds names of each exercise to private member var
        private void AddNames()
        {
            _names = new List<string>();
            foreach (Exercise ex in _my_ex)
            {
                _names.Add(ex.Name);
            }

        }

    }
}