/*
* Author: Logan Peppers
* Class name: SailorSoda.cs
* Purpose: Holds the Sailor Soda menu item properties.
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.Linq;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class representing a glass of Sailor Soda
    /// </summary>
    public class SailorSoda : Drink, IOrderItem
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
                    return 1.74;
                }
                else if (size == Size.Large)
                {
                    return 2.07;
                }
                else
                    return 1.42;
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
                    return 153;
                }
                else if (size == Size.Large)
                {
                    return 205;
                }
                else
                    return 117;
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
                if (ice == false)
                {
                    empty.Add("Hold ice");
                }
                
                return empty;
            }
        }
        /* Private variable declarations for the soda */
        private bool ice = true;
        private SodaFlavor flavor = SodaFlavor.Cherry;
        private Size size = Size.Small;
        /// <summary>
        /// Sets the flavor of the soda
        /// </summary>
        public SodaFlavor Flavor
        {
            get { return flavor; }
            set { flavor = value; }
        }
        /// <summary>
        /// Sets the size
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }
        /// <summary>
        /// If the drink needs ice
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        /// <summary>
        /// Overrides the ToString method to return the size and name of the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + " " +  flavor.ToString() + " Sailor Soda";
        }
    }
}
