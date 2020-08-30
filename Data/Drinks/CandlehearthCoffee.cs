/*
* Author: Logan Peppers
* Class name: CandlehearthCoffee.cs
* Purpose: Holds the Candlehearth Coffee menu item properties.
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace Data.Drinks
{
    class CandlehearthCoffee
    {
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
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> empty = new List<String>();
                if (ice == true)
                {
                    empty.Append("Add ice");
                }
                if (RoomForCream == true)
                {
                    empty.Append("Add cream");
                }
                return empty;
            }
        }
        public bool ice = false;
        public bool roomForCream = false;
        public bool decaf = false;
        public Size size = Size.Small;
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }
        public bool Ice
        {
            get { return ice; }
            set { ice = value; }
        }
        public bool Decaf
        {
            get { return decaf; }
            set { decaf = value; }
        }
        public bool RoomForCream
        {
            get { return roomForCream; }
            set { roomForCream = value; }
        }
        public override string ToString()
        {
            return size.ToString() + "Candlehearth Coffee";
        }
    }
}
