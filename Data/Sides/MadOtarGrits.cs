/*
* Author: Logan Peppers
* Class name: MadOtarGrits.cs
* Purpose: Holds the Mad Otar Grits menu item properties.
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits
    {
        public double Price
        {
            get
            {
                if (size == Size.Medium)
                {
                    return 1.58;
                }
                else if (size == Size.Large)
                {
                    return 1.93;
                }
                else
                    return 1.22;
            }

        }
        public uint Calories
        {
            get
            {
                if (size == Size.Medium)
                {
                    return 142;
                }
                else if (size == Size.Large)
                {
                    return 179;
                }
                else
                    return 105;
            }

        }
        public List<String> SpecialInstructions
        {
            get
            {
                return new List<String>();
            }
        }
        public Size size = Size.Small;
        public Size Size
        {
            get { return size; }
            set { size = value; }
        }

        public override string ToString()
        {
            return size.ToString() + "Mad Otar Grits";
        }
    }
}
