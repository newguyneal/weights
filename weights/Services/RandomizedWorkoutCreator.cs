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

namespace weights.Services
{
    public class RandomizedWorkoutCreator
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
        

        private Workout _wo;

        #endregion

        public RandomizedWorkoutCreator(string split, string grp, int reps, List<Primary> p, List<Secondary> s, List<Auxilary> a1, List<Core> c, int week)
        {
            _split = split;
            _group = grp;
            _reps = reps;
            _p = p;
            _s = s;
            _a = a1;
            _c = c;
            _week_no = week;
        }

        //creates a new random workout and returns it to the caller
        public Workout CreateRandomWorkout()
        {
            addExerciesToWorkout();
            return _wo;
        }

        //generates a single exercise for each category in the workout and creates a new work out with the exercises
        private void addExerciesToWorkout()
        {
            //primary
            List<Exercise> exes = _p.Cast<Exercise>().ToList();
            Primary p = (Primary)chooseRandomExFromList(exes);

            //secondary
            exes = _s.Cast<Exercise>().ToList();
            Secondary s = (Secondary)chooseRandomExFromList(exes);

            //auxilary
            exes = _a.Cast<Exercise>().ToList();
            Auxilary a = (Auxilary)chooseRandomExFromList(exes);
            exes.Remove(a);
            Auxilary a2 = (Auxilary)chooseRandomExFromList(exes);
            exes.Remove(a2);

            Auxilary a3 = (Auxilary)chooseRandomExFromList(exes);

            //core
            exes = _c.Cast<Exercise>().ToList();
            Core c = (Core)chooseRandomExFromList(exes);

            _wo = new Workout(_split,_group,_reps,p,s,a,a2,a3,c,_week_no);



        }

        /// <summary>
        /// takes a list of exercises and returns a random exercise from the list
        /// </summary>
        /// <param name="exes"></param>
        /// <returns></returns>
        private Exercise chooseRandomExFromList(List<Exercise> exes)
        {
            Random rand = new Random();
            int index = rand.Next(0, exes.Count);
            return exes[index];

        }
    }
}