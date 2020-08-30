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

namespace Data.Drinks
{
    class WarriorWater
    {
        public double Price
        {
            get
            {
                return 0.00;
            }

        }
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
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> empty = new List<String>();
                if (ice == false)
                {
                    empty.Append("Hold ice");
                }
                if (lemon == true)
                {
                    empty.Append("Add lemon");
                }
                return empty;
            }
        }
        public bool ice = true;
        public bool lemon = false;
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
        public bool Lemon
        {
            get { return lemon; }
            set { lemon = value; }
        }
        public override string ToString()
        {
            return size.ToString() + "Warrior Water";
        }
    }
}
