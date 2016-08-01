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
    public class JSONData
    {
        public List<string> prim_chest = new List<string>(){ "Bench Press", "DB Bench Press", "Decline Bench Press", "DB Declin Bench Press", "Reverse-grip Bench Press" };
        private List<string> sec_chest = new List<string>() { "Incline Bench Press", "DB Incline Bench Press", "Military Press", "DB Military Press" };
        private List<string> aux_chest = new List<string>() { "Dumbell Fly", "Tricep Extension", "Single-arm Tricep Extension", "Tricep Dip", "Skullcrusher", "Cable Fly" };

        private List<string> prim_back = new List<string>() { "T-Bar Row", "Lawnmower", "Seated Row", "Bent-over Row", "Cable Row" };
        private List<string> sec_back = new List<string>() { "Lat Pull-down", "Pull-up", "Chin-up", "Upside-down Bodyweight Row" };
        private List<string> aux_back = new List<string>() { " Cable Reverse Fly", "Upright Row", "Bent Over Reverse Fly", "Bicep Curl", "Reverse Grip Bicep Curl", "Hammer Curl" };

        private List<string> prim_legs = new List<string>() { "Front Squat", "Back Squat", "Deadlift", "Power Clean", "Leg Press" };
        private List<string> sec_legs = new List<string>() { "Bulgarian Split Squat", "Box Step-up", "Dumbell Lunge", "Snatch" };
        private List<string> aux_legs = new List<string>() { "Pistol Squat", "Calf Raise", "Hamstring Curl", "Leg Aduction/Abduction", "Side Lunge", "Leg Extension" };

        private List<string> prim_should = new List<string>() { "Military Press", "DB Military Press", "Push Press", "Single Arm Push Press", "Single Arm Barbell Press" };
        private List<string> sec_should = new List<string>() { "Incline Bench Press", "DB Incline Bench Press", "Upright Row", "Shoulder Shrug" };
        private List<string> aux_should = new List<string>() { "Front Raise", "Lateral Raise", "Rotator Cuff Aduction/Abduction", "Forearm Curls", "Pull-Overs", "Reverse Fly" };

        private List<string> core = new List<string>() { "Hanging Leg Raise", "Exercise Ball Jack-knife", "Decline Sit-up", "Russian Twist", "Oblique Extension", "Dragon Flag", "Decline Twist", "Leg Raise" };

        private List<Primary> _prim_chest = new List<Primary>();
        private List<Secondary> _sec_chest = new List<Secondary>();
        private List<Auxilary> _aux_chest = new List<Auxilary>();


        private List<Primary> _prim_back = new List<Primary>();
        private List<Secondary> _sec_back = new List<Secondary>();
        private List<Auxilary> _aux_back = new List<Auxilary>();
 

        private List<Primary> _prim_legs = new List<Primary>();
        private List<Secondary> _sec_legs = new List<Secondary>();
        private List<Auxilary> _aux_legs = new List<Auxilary>();
        

        private List<Primary> _prim_should = new List<Primary>();
        private List<Secondary> _sec_should = new List<Secondary>();
        private List<Auxilary> _aux_should = new List<Auxilary>();

        private List<Core> _core = new List<Core>();


        public JSONData()
        {
            Initialize();
        }
        private void Initialize()
        {
            //primaries
            Exercise ex = new Primary();
            _prim_chest = CreateExerciseList(prim_chest, "Chest", ex).Cast<Primary>().ToList();
            _prim_back = CreateExerciseList(prim_back, "Back", ex).Cast<Primary>().ToList();
            _prim_legs = CreateExerciseList(prim_legs, "Legs", ex).Cast<Primary>().ToList();
            _prim_should = CreateExerciseList(prim_should, "Shoulders", ex).Cast<Primary>().ToList();

            //secondary
            ex = new Secondary();
            _sec_chest = CreateExerciseList(sec_chest, "Chest", ex).Cast<Secondary>().ToList(); 
            _sec_back = CreateExerciseList(sec_back, "Back", ex).Cast<Secondary>().ToList();
            _sec_legs = CreateExerciseList(sec_legs, "Legs", ex).Cast<Secondary>().ToList();
            _sec_should = CreateExerciseList(sec_should, "Shoulders", ex).Cast<Secondary>().ToList();

            //Aux
            ex = new Auxilary();
            _aux_chest = CreateExerciseList(aux_chest, "Chest", ex).Cast<Auxilary>().ToList();
            _aux_back = CreateExerciseList(aux_back, "Back", ex).Cast<Auxilary>().ToList();
            _aux_legs = CreateExerciseList(aux_legs, "Legs", ex).Cast<Auxilary>().ToList();
            _aux_should = CreateExerciseList(aux_should, "Shoulders", ex).Cast<Auxilary>().ToList();

            //Core
            ex = new Core();
            _core = CreateExerciseList(core, "Core", ex).Cast<Core>().ToList(); ;

        }
        private List<Exercise> CreateExerciseList(List<string> names, string group, Exercise ex)
        {
            List< Exercise> exs = new List<Exercise>();
            
            foreach(string name in names)
            {
                ex.Name = name;
                ex.Group = group;
                exs.Add(ex);
            }
            return exs;
        }

        public List<Primary> Prim_chest
        {
            get { return _prim_chest; }
        }
        public List<Secondary> Sec_chest
        {
            get { return _sec_chest; }
        }
        public List<Auxilary> Aux_chest
        {
            get { return _aux_chest; }
        }


        public List<Primary> Prim_back
        {
            get { return _prim_back; }
        }
        public List<Secondary> Sec_back
        {
            get { return _sec_back; }
        }
        public List<Auxilary> Aux_back
        {
            get { return _aux_back; }
        }


        public List<Primary> Prim_legs
        {
            get { return _prim_legs; }
        }
        public List<Secondary> Sec_legs
        {
            get { return _sec_legs; }
        }
        public List<Auxilary> Aux_legs
        {
            get { return _aux_legs; }
        }


        public List<Primary> Prim_should
        {
            get { return _prim_should; }
        }
        public List<Secondary> Sec_should
        {
            get { return _sec_should; }
        }
        public List<Auxilary> Aux_should
        {
            get { return _aux_should; }
        }
        public List<Core> Core
        {
            get { return _core; }
        }



    }
}