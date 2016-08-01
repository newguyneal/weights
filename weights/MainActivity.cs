using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;


namespace weights
{
    [Activity(Label = "weights", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button home_red_button = FindViewById<Button>(Resource.Id.HomeRedButton);
            Button home_blue_button = FindViewById<Button>(Resource.Id.MyButton);

            home_red_button.Click += delegate {
                var activity2 = new Intent(this, typeof(CreateNewActivity));
                StartActivity(activity2);
            };
            home_blue_button.Click += delegate
            {
                var activity3 = new Intent(this, typeof(ExerciseListActivity));
                StartActivity(activity3);
            };
                
        }
    }
}

