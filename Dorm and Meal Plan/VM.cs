using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dorm_and_Meal_Plan
{
    class VM : INotifyPropertyChanged
    {
        #region public
        public bool Allen
        {
            get { return _allen; }
            set { _allen = value; OnPropertyChanged(); }
        }
        private bool _allen;
        public bool Pike
        {
            get { return _pike; }
            set { _pike = value; OnPropertyChanged(); }
        }
        private bool _pike;
        public bool Farthing
        {
            get { return _farthing; }
            set { _farthing = value; OnPropertyChanged(); }
        }
        private bool _farthing;
        public bool University
        {
            get { return _university; }
            set { _university = value; OnPropertyChanged(); }
        }
        private bool _university;
        public bool SevenMeals
        {
            get { return _sevenMeals; }
            set { _sevenMeals = value; OnPropertyChanged(); }
        }
        private bool _sevenMeals;
        public bool FourteenMeals
        {
            get { return _fourteenMeals; }
            set { _fourteenMeals = value; OnPropertyChanged(); }
        }
        private bool _fourteenMeals;
        public bool UnlimitedMeals
        {
            get { return _unlimitedMeals; }
            set { _unlimitedMeals = value; OnPropertyChanged(); }
        }
        private bool _unlimitedMeals;
        public string Cost
        {
            get { return _cost; }
            set { _cost = value; OnPropertyChanged(); }
        }
        private string _cost;
        #endregion
        #region constants
        public const decimal ALLEN = 1500m;
        public const decimal PIKE = 1600m;
        public const decimal FARTHING = 1800m;
        public const decimal UNIVERSITY = 2500m;
        public const decimal SEVEN = 600m;
        public const decimal FOURTEEN = 1200m;
        public const decimal UNLIMITED = 1700m;
        #endregion
        public decimal Calc()
        {
            decimal result = 0m;
            decimal hall = 0m;
            decimal meal = 0m;
            if (Allen) { hall = ALLEN; }
            if (Pike) { hall = PIKE; }
            if (Farthing) { hall = FARTHING; }
            if (University) { hall = UNIVERSITY; }
            if (SevenMeals) { meal = SEVEN; }
            if (FourteenMeals) { meal = FOURTEEN; }
            if (UnlimitedMeals) { meal = UNLIMITED; }
            result = hall + meal;
            return result;
        }
        public void amount()
        {
            Cost = "Total cost is " + "$" + Calc();
        }
        public void clear()
        {
            Allen = false; Pike = false; Farthing = false; University = false;
            SevenMeals = false; FourteenMeals = false; UnlimitedMeals = false;
        }



        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string caller = null)
        {
            // make sure only to call this if the value actually changes

            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(caller));
            }
        }
    }
}
