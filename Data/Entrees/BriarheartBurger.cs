/*
* Author: Logan Peppers
* Class name: BriarheartBurger.cs
* Purpose: Holds the Briarheart Burger menu item properties.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class representing the Briarheart Burger
    /// </summary>
    public class BriarheartBurger
    {
        /// <summary>
        /// Gets the price (One value)
        /// </summary>
        public double Price
        {
            get
            {
                return 6.32;
            }

        }
        /// <summary>
        /// Gets the calorie count (One value)
        /// </summary>
        public uint Calories
        {
            get
            {
                return 743;
            }

        }
        /// <summary>
        /// Adds instructions to the list based on variable ingredients
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> empty = new List<String>();
                if (bun == false)
                {
                    empty.Add("Hold bun");
                }
                if (ketchup == false)
                {
                    empty.Add("Hold ketchup");
                }
                if (mustard == false)
                {
                    empty.Add("Hold mustard");
                }
                if (pickle == false)
                {
                    empty.Add("Hold pickle");
                }
                if (cheese == false)
                {
                    empty.Add("Hold cheese");
                }
                return empty;
            }
        }
        /* Private variable declarations for the burger */
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;

        /// <summary>
        /// If the burger gets a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }
        /// <summary>
        /// If the burger gets ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }
        /// <summary>
        /// If the burger gets mustard 
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }
        /// <summary>
        /// If the burger gets pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }
        /// <summary>
        /// If the burger gets cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        /// <summary>
        /// Overrides the ToString method to return the name of the entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }

}
