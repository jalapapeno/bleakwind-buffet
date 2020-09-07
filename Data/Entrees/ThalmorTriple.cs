/*
* Author: Logan Peppers
* Class name: ThalmorTriple.cs
* Purpose: Holds the Thalmor Triple menu item properties.
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class representing the Thalmor Triple burger
    /// </summary>
    public class ThalmorTriple
    {
        /// <summary>
        /// Gets the price (One value)
        /// </summary>
        public double Price
        {
            get
            {
                return 8.32;
            }

        }
        /// <summary>
        /// Gets the calorie count (One value)
        /// </summary>
        public uint Calories
        {
            get
            {
                return 943;
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
                if (tomato == false)
                {
                    empty.Add("Hold tomato");
                }
                if (lettuce == false)
                {
                    empty.Add("Hold lettuce");
                }
                if (mayo == false)
                {
                    empty.Add("Hold mayo");
                }
                if (bacon == false)
                {
                    empty.Add("Hold bacon");
                }
                if (egg == false)
                {
                    empty.Add("Hold egg");
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
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;
        private bool bacon = true;
        private bool egg = true;

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
        /// If the burger gets tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }
        /// <summary>
        /// If the burger gets lettuce
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }
        /// <summary>
        /// If the burger gets mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }
        /// <summary>
        /// If the burger gets bacon
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set { bacon = value; }
        }
        /// <summary>
        /// If the burger gets an egg
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }

        /// <summary>
        /// Overrides the ToString method to return the name of the entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
