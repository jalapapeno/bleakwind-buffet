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
    public class SailorSoda
    {
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
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> empty = new List<String>();
                if (ice == false)
                {
                    empty.Append("Hold ice");
                }
                
                return empty;
            }
        }
        public bool ice = true;
        public SodaFlavor flavor = SodaFlavor.Cherry;
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
            return size.ToString() + flavor.ToString() + "Sailor Soda";
        }
    }
}
