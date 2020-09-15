/*
* Author: Logan Peppers
* Class name: MarkarthMilk.cs
* Purpose: Holds the Markarth Milk menu item properties.
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.Linq;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class representing a glass of Markarth Milk
    /// </summary>
    public class MarkarthMilk : Drink, IOrderItem
    {
        /// <summary>
        /// Sets the price based on the size of the drink
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Medium)
                {
                    return 1.11;
                }
                else if (size == Size.Large)
                {
                    return 1.22;
                }
                else
                    return 1.05;
            }

        }
        /// <summary>
        /// Sets the calories based on the size of the drink
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Medium)
                {
                    return 72;
                }
                else if (size == Size.Large)
                {
                    return 93;
                }
                else
                    return 56;
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
                if (ice == true)
                {
                    empty.Add("Add ice");
                }

                return empty;
            }
        }
        /* Private variable declaration for the milk */
        private bool ice = false;
        private Size size = Size.Small;
        /// <summary>
        /// Sets the size of the drink
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
            get { return ice;  }
            set { ice = value;  }
        }
        /// <summary>
        /// Overrides the ToString method to return the size and name of the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() +" Markarth Milk";
        }
    }
}
