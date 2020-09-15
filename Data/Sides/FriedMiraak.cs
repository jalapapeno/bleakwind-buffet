/*
* Author: Logan Peppers
* Class name: FriedMiraak.cs
* Purpose: Holds the Fried Miraak menu item properties.
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Class representing the Fried Miraak side
    /// </summary>
    public class FriedMiraak : Side, IOrderItem
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
                    return 2.01;
                }
                else if (size == Size.Large)
                {
                    return 2.88;
                }
                else
                    return 1.78;
            }

        }
        /// <summary>
        /// Sets the calorie count based on size
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Medium)
                {
                    return 236;
                }
                else if (size == Size.Large)
                {
                    return 306;
                }
                else
                    return 151;
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
            return size.ToString() + " Fried Miraak";
        }
    }
}
