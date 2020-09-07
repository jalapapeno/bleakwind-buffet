/*
* Author: Logan Peppers
* Class name: DragonbornWaffleFries.cs
* Purpose: Holds the DragonbornWaffleFries menu item properties.
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class representing the Dragonborn Waffle Fries
    /// </summary>
    public class DragonbornWaffleFries
    {
        /// <summary>
        /// Gets the price based on the size
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Medium)
                {
                    return .76;
                }
                else if (size == Size.Large)
                {
                    return .96;
                }
                else
                    return .42;
            }

        }
        /// <summary>
        /// Gets the calorie count based on size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Medium)
                {
                    return 89;
                }
                else if (size == Size.Large)
                {
                    return 100;
                }
                else
                    return 77;
            }

        }
        /// <summary>
        /// Returns an empty list, as there are no variable ingredients
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                return new List<String>();
            }
        }
        /* The only private variable declaration for the side */
        private Size size = Size.Small;
        /// <summary>
        /// Sets the size
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
            return size.ToString() + "Dragonborn Waffle Fries";
        }
    }
}
