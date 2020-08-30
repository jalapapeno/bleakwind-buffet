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

namespace Data.Drinks
{
    class ArentinoAppleJuice
    {
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
            get { return ice; }
            set { ice = value; }
        }

        public override string ToString()
        {
            return size.ToString() + "Arentino Apple Juice";
        }
    }
}
