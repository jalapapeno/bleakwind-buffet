/*
* Author: Logan Peppers
* Class name: BriarheartBurger.cs
* Purpose: Holds the Briarheart Burger menu item properties.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data.Entrees
{
    public class BriarheartBurger
    {
        public double Price
        {
            get
            {
                return 6.32;
            }

        }
        public uint Calories
        {
            get
            {
                return 743;
            }

        }
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> empty = new List<String>();
                if (bun == false)
                {
                    empty.Append("Hold bun");
                }
                if (ketchup == false)
                {
                    empty.Append("Hold ketchup");
                }
                if (mustard == false)
                {
                    empty.Append("Hold mustard");
                }
                if (pickle == false)
                {
                    empty.Append("Hold pickle");
                }
                if (cheese == false)
                {
                    empty.Append("Hold cheese");
                }
                return empty;
            }
        }
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;

        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }


        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }

}
