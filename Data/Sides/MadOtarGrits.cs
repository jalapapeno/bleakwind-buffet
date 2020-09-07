/*
* Author: Logan Peppers
* Class name: MadOtarGrits.cs
* Purpose: Holds the Mad Otar Grits menu item properties.
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class representing the Mad Otar Grits
    /// </summary>
    public class MadOtarGrits
    {
        /// <summary>
        /// Sets the price based on the size
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Medium)
                {
                    return 1.58;
                }
                else if (size == Size.Large)
                {
                    return 1.93;
                }
                else
                    return 1.22;
            }

        }
        /// <summary>
        /// Sets the calorie count based on the size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Medium)
                {
                    return 142;
                }
                else if (size == Size.Large)
                {
                    return 179;
                }
                else
                    return 105;
            }

        }
        /// <summary>
        /// Returns a blank list because there are no variable ingredients
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                return new List<String>();
            }
        }
        /* The only private variable declaration */
        private Size size = Size.Small;
        /// <summary>
        /// Gets the size
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// Overrides the ToString method to return the size and name of the side
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + "Mad Otar Grits";
        }
    }
}
