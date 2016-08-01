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
    public class Secondary : Exercise
    {
        public Secondary() { sets = 4; }
        public Secondary(string g, string n)
        {
            group = g;
            name = n;
            sets = 4;
        }
    }
}