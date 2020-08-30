/*
* Author: Logan Peppers
* Class name: VokunSalad.cs
* Purpose: Holds the Vokun Salad menu item properties.
*/
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace Data.Sides
{
    public class VokunSalad
    {
        public double Price
        {
            get 
            {
                if (size == Size.Medium)
                {
                    return 1.28;
                }
                else if (size == Size.Large)
                {
                    return 1.82;
                }
                else
                    return .93;
            }

        }
        public uint Calories
        {
            get
            {
                if (size == Size.Medium)
                {
                    return 52;
                }
                else if (size == Size.Large)
                {
                    return 73;
                }
                else
                    return 41;
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
            return size.ToString() + "Vokun Salad";
        }
    }
}

