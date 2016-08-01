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
    [Activity(Label = "ProgramTypeActivity")]
    public class ProgramTypeActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ProgramTypeLayout);

            Init();

            // Create your application here
        }

        private void Init()
        {
            Button two_day_split = FindViewById<Button>(Resource.Id.twodaysplitbutton);
            Button four_day_split = FindViewById<Button>(Resource.Id.fourdaysplitbutton);
            Button full_body = FindViewById<Button>(Resource.Id.fullbodybutton);
            Button randomize = FindViewById<Button>(Resource.Id.randomizetypebutton);
            var activity = new Intent(this, typeof(FourDaySplitActivity));
            ButtonInit(four_day_split,activity);

            //todo: add ButtonInit for all buttons add templated workouts for each case
        }

        private void ButtonInit(Button b, Intent activity)
        {
            
            b.Click += delegate
            {
                StartActivity(activity);
            };
        }
    }
}