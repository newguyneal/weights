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

namespace weights
{
    [Activity(Label = "CreateNewActivity")]
    public class CreateNewActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.CreateNew);

            Button random = FindViewById<Button>(Resource.Id.randomize);
            random.Click += delegate
            {
                var random_act = new Intent(this, typeof(OneDayActivity));
                StartActivity(random_act);
            };
        }
    }
}