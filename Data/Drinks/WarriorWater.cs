/*
* Author: Logan Peppers
* Class name: WarriorWater.cs
* Purpose: Holds the Warrior Water menu item properties.
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.Linq;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class representing a glass of Warrior Water
    /// </summary>
    public class WarriorWater : Drink, IOrderItem
    {
        /// <summary>
        /// Sets the price (Always 0)
        /// </summary>
        public double Price
        {
            get
            {
                return 0.00;
            }

        }
        /// <summary>
        /// Sets the calorie count based on size (Always zero)
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Medium)
                {
                    return 0;
                }
                else if (size == Size.Large)
                {
                    return 0;
                }
                else
                    return 0;
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
                if (lemon == true)
                {
                    empty.Add("Add lemon");
                }
                return empty;
            }
        }
        /* Private variable declarations for the water */
        private bool ice = true;
        private bool lemon = false;
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
        /// If the drink needs ice
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        /// <summary>
        /// If the drink needs lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }
        /// <summary>
        /// Overrides the ToString method to return the size and name of the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + " Warrior Water";
        }
    }
}
