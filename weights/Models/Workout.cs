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
    public class Workout
    {
        #region Fields
        private string _split;
        private string _group;
        private int _reps;
        private int _week_no;
        private List<Primary> _p;
        private List<Secondary> _s;
        private List<Auxilary> _a;
        private List<Core> _c;
        private List<string> _records;
        #endregion

        #region Constructors
        //default constructor
        public Workout()
        { }

        /// <summary>
        /// this constructor takes a group, split, rep range, week, and a single exercise to add to the workout
        /// </summary>
        /// <param name="split"></param>
        /// <param name="grp"></param>
        /// <param name="reps"></param>
        /// <param name="p"></param>
        /// <param name="s"></param>
        /// <param name="a1"></param>
        /// <param name="a2"></param>
        /// <param name="a3"></param>
        /// <param name="c"></param>
        /// <param name="week"></param>
        public Workout(string split,string grp,int reps, Primary p, Secondary s, Auxilary a1, Auxilary a2, Auxilary a3, Core c, int week)
        {
            _split = split;
            _group = grp;
            _reps = reps;
            _p.Add(p);
            _s.Add(s);
            _a.Add(a1);
            _a.Add(a2);
            _a.Add(a3);
            _c.Add(c);
            _week_no = week;
            PopulateRecords();
        }

        /// <summary>
        /// this constructor takes a group, split, rep range, week, and  a list of exercises to add to each type of exercise in the workout
        /// </summary>
        /// <param name="split"></param>
        /// <param name="grp"></param>
        /// <param name="reps"></param>
        /// <param name="p"></param>
        /// <param name="s"></param>
        /// <param name="a1"></param>
        /// <param name="c"></param>
        /// <param name="week"></param>
        public Workout(string split, string grp, int reps, List<Primary> p, List<Secondary> s, List<Auxilary> a1, List<Core> c, int week)
        {
            _split = split;
            _group = grp;
            _reps = reps;
            _p = p;
            _s = s;
            _a = a1;
            _c = c;
            _week_no = week;
            PopulateRecords();
        }
        #endregion


        #region Properties
        //Getters and setters
        public List<Primary> Primaries
        {
            get { return _p; }
            set
            {
                _p = value;
                PopulateRecords();
            }
        }

        public List<Secondary> Secondaries
        {
            get { return _s; }
            set
            {
                _s = value;
                PopulateRecords();
            }
        }

        public List<Auxilary> Auxilaries
        {
            get { return _a; }
            set
            {
                _a = value;
                PopulateRecords();
            }
        }

        public List<Core> Cores
        {
            get { return _c; }
            set
            {
                _c = value;
                PopulateRecords();
            }
        }
        public string Group
        {
            get { return _group; }
            set
            { _group = value; }
        }

        public int Reps
        {
            get { return _reps; }
            set { _reps = value; }
        }

        public int Week
        {
            get { return _week_no; }
            set { _week_no = value; }
        }

        public List<string> Records
        {
            get { return _records; }
            set { _records = value;  }
            
        }
        #endregion


        #region Methods
        //method that populates the records list with empty strings to hold data
        private void PopulateRecords()
        {
            _records = new List<string>();
            //primaries
            List<Exercise> tmp = _p.Cast<Exercise>().ToList();
            AddExToRec(tmp);

            //secondaries
            tmp = _s.Cast<Exercise>().ToList();
            AddExToRec(tmp);

            //auxiliaries
            tmp = _a.Cast<Exercise>().ToList();
            AddExToRec(tmp);

            //cores
            tmp = _c.Cast<Exercise>().ToList();
            AddExToRec(tmp);

        }
        //foreach exercise in the exercise list add a record for each set
        private void AddExToRec(List<Exercise> exs)
        {
            foreach (Exercise ex in exs)
            {
                AddRec(ex.Sets);

            }
        }
        //add a record for each 
        private void AddRec(int num_sets)
        {
            for(int i = 0; i < num_sets; i++)
            {
                _records.Add("");
            }
        }

        #endregion

    }
}