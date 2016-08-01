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
    public class Exercise
    {
        protected string name;
        protected string group;
        protected int sets;

        

        public string Name
	    {
		    get{return name;}
            set{name = value;}
		
	    }
	    public string Group
	    {
		    get{ return group; }
		    set{ group = value; }
	    }
	    public int Sets
	    {
		    get{return sets;}
		    set{sets = value;}
	    }
    }
}