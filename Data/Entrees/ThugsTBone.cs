/*
* Author: Logan Peppers
* Class name: ThugsTbone.cs
* Purpose: Holds the Thugs T-bone menu item properties.
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    public class ThugsTBone
    {
        public double Price
        {
            get
            {
                return 6.44;
            }

        }
        public uint Calories
        {
            get
            {
                return 982;
            }

        }
        public List<String> SpecialInstructions;

        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
