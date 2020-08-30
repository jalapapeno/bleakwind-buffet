/*
* Author: Logan Peppers
* Class name: FriedMiraak.cs
* Purpose: Holds the Fried Miraak menu item properties.
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace Data.Sides
{
    class FriedMiraak
    {
        public double Price
        {
            get
            {
                if (size == Size.Medium)
                {
                    return 2.01;
                }
                else if (size == Size.Large)
                {
                    return 2.88;
                }
                else
                    return 1.78;
            }

        }
        public uint Calories
        {
            get
            {
                if (size == Size.Medium)
                {
                    return 236;
                }
                else if (size == Size.Large)
                {
                    return 306;
                }
                else
                    return 151;
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
            return size.ToString() + "Fried Miraak";
        }
    }
}
