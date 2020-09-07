/*
* Author: Logan Peppers
* Class name: VokunSalad.cs
* Purpose: Holds the Vokun Salad menu item properties.
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class representing the Vokun Salad
    /// </summary>
    public class VokunSalad
    {
        /// <summary>
        /// Sets the price based on the size of the salad
        /// </summary>
        public double Price
        {
            get 
            {
                if (size == Size.Medium)
                {
                    return 1.28;
                }
                else if (size == Size.Large)
                {
                    return 1.82;
                }
                else
                    return .93;
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
                    return 52;
                }
                else if (size == Size.Large)
                {
                    return 73;
                }
                else
                    return 41;
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
            return size.ToString() + "Vokun Salad";
        }
    }
}

