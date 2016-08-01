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

namespace weights.Models
{
    public class Program
    {
        private List<Workout> _workouts = new List<Workout>();
        private Workout _cur_workout = new Workout();
    }
}