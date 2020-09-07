/*
* Author: Logan Peppers
* Class name: ArentinoAppleJuice.cs
* Purpose: Holds the Arentino Apple Juice menu item properties.
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.Linq;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class for representing ArentinoAppleJuice
    /// </summary>
    public class ArentinoAppleJuice
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
                    return 0.87;
                }
                else if (size == Size.Large)
                {
                    return 1.01;
                }
                else
                    return 0.62;
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
                    return 88;
                }
                else if (size == Size.Large)
                {
                    return 132;
                }
                else
                    return 44;
            }

        }
        /// <summary>
        /// Sets the special instructions based on variable ingredients
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> empty = new List<String>();
                if (ice == true)
                {
                    empty.Add("Add ice");
                }

                return empty;
            }
        }

        /* Private variable declaration for the apple juice */
        private bool ice = false;
        private Size size = Size.Small;

        /// <summary>
        /// What size of apple juice the customer wants
        /// </summary>
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }
        /// <summary>
        /// If this drink is served with ice
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        /// <summary>
        /// Returns the size and name of the drink when the ToString method is called
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + "Arentino Apple Juice";
        }
    }
}
