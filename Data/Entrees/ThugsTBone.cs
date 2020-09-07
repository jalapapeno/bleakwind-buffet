/*
* Author: Logan Peppers
* Class name: ThugsTbone.cs
* Purpose: Holds the Thugs T-bone menu item properties.
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class representing the Thugs TBone entree
    /// </summary>
    public class ThugsTBone
    {
        /// <summary>
        /// Gets the price (One value)
        /// </summary>
        public double Price
        {
            get
            {
                return 6.44;
            }

        }
        /// <summary>
        /// Gets the calorie count (One value)
        /// </summary>
        public uint Calories
        {
            get
            {
                return 982;
            }

        }
        /// <summary>
        /// Returns a blank list, as there are no variable ingredients
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                return new List<String>();
            }
        }

        /// <summary>
        /// Overrides the ToString method to return the name of the entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
