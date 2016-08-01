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
    [Activity(Label = "ExerciseListActivity")]
    public class ExerciseListActivity : Activity
    {
        JSONData jd = new JSONData();
        ArrayAdapter<string> adapter;
        ListView lv;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ExerciseList);
            PopulateList();

        }

        //resource: http://stackoverflow.com/questions/23020408/java-lang-illegalstateexception-arrayadapter-requires-the-resource-id-to-be-a-t
        private void PopulateList()
        {
            lv = FindViewById<ListView>(Resource.Id.ExerciseListView);

            adapter = new ArrayAdapter<string>(this, Resource.Layout.ExerciseListItem,Resource.Id.ExListItem, jd.prim_chest);

            lv.Adapter = adapter;
        }
    }
}