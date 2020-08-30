/*
* Author: Logan Peppers
* Class name: PhillyPoacher.cs
* Purpose: Holds the Philly Poacher menu item properties.
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Data.Entrees
{
    public class PhillyPoacher
    {
        public double Price
        {
            get
            {
                return 7.23;
            }

        }
        public uint Calories
        {
            get
            {
                return 784;
            }

        }
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> empty = new List<String>();
                if (sirloin == false)
                {
                    empty.Append("Hold sirloin");
                }
                if (onion == false)
                {
                    empty.Append("Hold onions");
                }
                if (roll == false)
                {
                    empty.Append("Hold roll");
                }
                return empty;
            }
        }
        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;
        public bool Sirloin
        {
            get { return sirloin; }
            set { sirloin = value; }
        }
        public bool Onion
        {
            get { return onion; }
            set { onion = value; }
        }
        public bool Roll
        {
            get { return roll; }
            set { roll = value; }
        }

        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
