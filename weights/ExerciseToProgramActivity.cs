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
using Newtonsoft.Json;
using weights.Models;

namespace weights
{
    [Activity(Label = "ExerciseToProgramActivity")]
    class ExerciseToProgramActivity : Activity
    {
        /// <summary>
        /// resources: https://developer.xamarin.com/api/type/Xamarin.Forms.ListView/
        /// </summary>
        /// 
        JSONData jd = new JSONData();
        List<Exercise> ex = new List<Exercise>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Define some data.


            Init();

            

        }

        //initialize the activity
        private void Init()
        { 
            //TODO: Create primary, secondary, auxilary, core exercise lists for all splits so i can call them individually for InitButton
            ex = jd.Prim_back.Cast<Exercise>().ToList();
            Button prim_button = FindViewById<Button>(Resource.Id.primListButton);
            Button sec_button = FindViewById<Button>(Resource.Id.secListButton);
            Button aux_button = FindViewById<Button>(Resource.Id.auxListButton);
            Button core_button = FindViewById<Button>(Resource.Id.coreListButton);

            InitButton(prim_button,ex);

        }

        /// <summary>
        /// takes a button and an exercise list and subscibes the click function to it. the activity pupluates a listview of the exercises for the users to select
        /// </summary>
        /// <param name="b"></param>
        /// <param name="ex"></param>
        private void InitButton(Button b, List<Exercise> ex)
        {
            var activity = new Intent(this, typeof(ExerciseListActivity));
            activity.PutExtra("Exercises", JsonConvert.SerializeObject(ex));
            b.Click += delegate
            {
                StartActivity(activity);
            };
            
        }
    }


}