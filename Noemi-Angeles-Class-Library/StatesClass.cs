using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noemi_Angeles_CPT_206_LAB_2
{
    public  class StatesClass
    {
        //method to search states
        public IQueryable<State> SearchStates(string criteria )
        {
            //instance for db
            StateDBDataContext db = new StateDBDataContext();
            var results = from state in db.States
                          where state.State1.Contains( criteria )
                          select state;
            return results;
        }
        //method to search population
        public IQueryable<State> SearchPopulation(string criteria)
        {
            //instance for db
            StateDBDataContext db = new StateDBDataContext();
            var results = from state in db.States
                          where state.Population.Contains(criteria)
                          select state;
            return results;
        }
        //method to search flag desc
        public IQueryable<State> SearchFlagDesc(string criteria)
        {
            //instance for db
            StateDBDataContext db = new StateDBDataContext();
            var results = from state in db.States
                          where state.State_Flag_Description.Contains(criteria)
                          select state;
            return results;
        }
        //method to search flower
        public IQueryable<State> SearchFlower(string criteria)
        {
            //instance for db
            StateDBDataContext db = new StateDBDataContext();
            var results = from state in db.States
                          where state.State_Flower.Contains(criteria)
                          select state;
            return results;
        }
        //method to search bird
        public IQueryable<State> SearchBird(string criteria)
        {
            //instance for db
            StateDBDataContext db = new StateDBDataContext();
            var results = from state in db.States
                          where state.State_Bird.Contains(criteria)
                          select state;
            return results;
        }
        //method to search colors
        public IQueryable<State> SearchColors(string criteria)
        {
            //instance for db
            StateDBDataContext db = new StateDBDataContext();
            var results = from state in db.States
                          where state.State_Colors.Contains(criteria)
                          select state;
            return results;
        }
        //method to search cities
        public IQueryable<State> SearchCities(string criteria)
        {
            //instance for db
            StateDBDataContext db = new StateDBDataContext();
            var results = from state in db.States
                          where state.Three_Largest_Cities.Contains(criteria)
                          select state;
            return results;
        }
        //method to search capitol
        public IQueryable<State> SearchCapitol(string criteria)
        {
            //instance for db
            StateDBDataContext db = new StateDBDataContext();
            var results = from state in db.States
                          where state.State_Flower.Contains(criteria)
                          select state;
            return results;
        }
        //method to search income
        public IQueryable<State> SearchMedianIncome(string criteria)
        {
            //instance for db
            StateDBDataContext db = new StateDBDataContext();
            var results = from state in db.States
                          where state.Median_Income.Contains(criteria)
                          select state;
            return results;
        }
        //method to search %
        public IQueryable<State> SearchPercenteJobs(string criteria)
        {
            //instance for db
            StateDBDataContext db = new StateDBDataContext();
            var results = from state in db.States
                          where state.Percentage_of_Computer_Related_Jobs.Contains(criteria)
                          select state;
            return results;
        }

        //method to sort asc alpha
      
        public IQueryable<State> SortAlphabet(string criteria)
        {
            //instance for db
            StateDBDataContext db = new StateDBDataContext();
            var sort = from state in db.States.OrderBy((state) => state.State1)
                       select state;
            return sort;
        }
        //method to sort asc population

        public IQueryable<State> SortPopulation(string criteria)
        {
            //instance for db
            StateDBDataContext db = new StateDBDataContext();
            var sort = from state in db.States.OrderBy((state) => state.Population)
                       select state;
            return sort;
        }
        //method to sort asc population

        public IQueryable<State> SortBirds(string criteria)
        {
            //instance for db
            StateDBDataContext db = new StateDBDataContext();
            var sort = from state in db.States.OrderBy((state) => state.State_Bird)
                       select state;
            return sort;
        }
        //method to sort asc flowers

        public IQueryable<State> SortFlowers(string criteria)
        {
            //instance for db
            StateDBDataContext db = new StateDBDataContext();
            var sort = from state in db.States.OrderBy((state) => state.State_Flower)
                       select state;
            return sort;
        }
        //method to sort asc income

        public IQueryable<State> SortMedianIncome(string criteria)
        {
            //instance for db
            StateDBDataContext db = new StateDBDataContext();
            var sort = from state in db.States.OrderBy((state) => state.Median_Income)
                       select state;
            return sort;
        }
        //method to sort asc percentage

        public IQueryable<State> SortPercenteJobs(string criteria)
        {
            //instance for db
            StateDBDataContext db = new StateDBDataContext();
            var sort = from state in db.States.OrderBy((state) => state.Percentage_of_Computer_Related_Jobs)
                       select state;
            return sort;
        }
    }
}
