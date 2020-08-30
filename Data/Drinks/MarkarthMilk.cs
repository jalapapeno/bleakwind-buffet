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

namespace Data.Drinks
{
    class MarkarthMilk
    {
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
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> empty = new List<String>();
                if (ice == true)
                {
                    empty.Append("Add ice");
                }

                return empty;
            }
        }
        public bool ice = false;
        public Size size = Size.Small;
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }
        public bool Ice
        {
            get { return ice;  }
            set { ice = value;  }
        }

        public override string ToString()
        {
            return size.ToString() +"Markarth Milk";
        }
    }
}
