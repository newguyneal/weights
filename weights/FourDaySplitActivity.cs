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
using Newtonsoft.Json;

namespace weights
{
    [Activity(Label = "FourDaySplitActivity")]
    public class FourDaySplitActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.FourDaySplitLayout);
            Init();
        }

        /// <summary>
        /// sets all of the buttons to variables which will allow button init to be ran on all buttons programmatically
        /// </summary>
        private void Init()
        {
            Button chest = FindViewById<Button>(Resource.Id.chestbutton);
            Button back = FindViewById<Button>(Resource.Id.backbutton);
            Button shoulder = FindViewById<Button>(Resource.Id.shoulderbutton);
            Button legs = FindViewById<Button>(Resource.Id.legbutton);

            //todo: add ButtonInit for all of the buttons and create proper workout templates for each case
        }

        /// <summary>
        /// this takes a button and subscribes to a function that serializes the workout passed in and starts the activity to add exercises to that day.
        /// </summary>
        /// <param name="b"></param>
        /// <param name="wo"></param>
        private void ButtonInit(Button b, Workout wo)
        {
            var activity = new Intent(this, typeof(ExerciseToProgramActivity));
            activity.PutExtra("workout_template", JsonConvert.SerializeObject(wo));
            b.Click += delegate
            {
                StartActivity(activity);
            };
        }
    }
}