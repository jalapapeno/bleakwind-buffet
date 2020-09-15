/*
* Author: Logan Peppers
* Class name: PhillyPoacher.cs
* Purpose: Holds the Philly Poacher menu item properties.
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class representing the Philly Poacher entree
    /// </summary>
    public class PhillyPoacher : Entree, IOrderItem
    {
        /// <summary>
        /// Gets the price (One value)
        /// </summary>
        public double Price
        {
            get
            {
                return 7.23;
            }

        }
        /// <summary>
        /// Gets the calories (One value)
        /// </summary>
        public uint Calories
        {
            get
            {
                return 784;
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
                if (sirloin == false)
                {
                    empty.Add("Hold sirloin");
                }
                if (onion == false)
                {
                    empty.Add("Hold onions");
                }
                if (roll == false)
                {
                    empty.Add("Hold roll");
                }
                return empty;
            }
        }

        /* Private variable declarations for the entree */
        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;

        /// <summary>
        /// If the entree includes sirloin
        /// </summary>
        public bool Sirloin
        {
            get { return sirloin; }
            set { sirloin = value; }
        }
        /// <summary>
        /// If the entree includes onions
        /// </summary>
        public bool Onion
        {
            get { return onion; }
            set { onion = value; }
        }
        /// <summary>
        /// If the entree includes a roll
        /// </summary>
        public bool Roll
        {
            get { return roll; }
            set { roll = value; }
        }

        /// <summary>
        /// Overrides the ToString method to return the name of the entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
