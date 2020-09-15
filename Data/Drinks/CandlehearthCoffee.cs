/*
* Author: Logan Peppers
* Class name: CandlehearthCoffee.cs
* Purpose: Holds the Candlehearth Coffee menu item properties.
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;
using System.Linq;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Class representing a cup of Candlehearth Coffee
    /// </summary>
    public class CandlehearthCoffee : Drink,IOrderItem
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
                    return 1.25;
                }
                else if (size == Size.Large)
                {
                    return 1.75;
                }
                else
                    return .75;
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
                    return 10;
                }
                else if (size == Size.Large)
                {
                    return 20;
                }
                else
                    return 7;
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
                if (RoomForCream)
                {
                    empty.Add("Add cream");
                }
                return empty;
            }
        }
        /* Private variable declarations for the coffee */
        private bool ice = false;
        private bool roomForCream = false;
        private bool decaf = false;
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
        /// If the drink gets ice
        /// </summary>
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        /// <summary>
        /// If the coffee is decaf or not
        /// </summary>
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }
        /// <summary>
        /// If the customer wants cream
        /// </summary>
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }
        /// <summary>
        /// Overrides the ToString method to produce the size and name of the drink
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if(decaf)
                return size.ToString() + " Decaf" + " Candlehearth Coffee";
            else
                return size.ToString() + " Candlehearth Coffee";
        }
    }
}
