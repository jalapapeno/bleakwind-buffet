/*
* Author: Logan Peppers
* Class name: DragonbornWaffleFries.cs
* Purpose: Holds the DragonbornWaffleFries menu item properties.
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries
    {
        public double Price
        {
            get
            {
                if (size == Size.Medium)
                {
                    return .76;
                }
                else if (size == Size.Large)
                {
                    return .96;
                }
                else
                    return .42;
            }

        }
        public uint Calories
        {
            get
            {
                if (size == Size.Medium)
                {
                    return 89;
                }
                else if (size == Size.Large)
                {
                    return 100;
                }
                else
                    return 77;
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
            return size.ToString() + "Dragonborn Waffle Fries";
        }
    }
}
