/*
* Author: Logan Peppers
* Class name: SmokehouseSkeleton.cs
* Purpose: Holds the Smokehouse Skeleton menu item properties.
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton
    {
        public double Price
        {
            get
            {
                return 5.62;
            }

        }
        public uint Calories
        {
            get
            {
                return 602;
            }

        }
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> empty = new List<String>();
                if (sausageLink == false)
                {
                    empty.Append("Hold sausage");
                }
                if (egg == false)
                {
                    empty.Append("Hold eggs");
                }
                if (hashBrowns == false)
                {
                    empty.Append("Hold hash browns");
                }
                if (pancake == false)
                {
                    empty.Append("Hold pancakes");
                }
                
                return empty;
            }
        }
        private bool sausageLink = true;
        private bool egg = true;
        private bool hashBrowns = true;
        private bool pancake = true;
        public bool SausageLink
        {
            get { return sausageLink; }
            set { sausageLink = value; }
        }
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }
        public bool HashBrowns
        {
            get { return hashBrowns; }
            set { hashBrowns= value; }
        }
        public bool Pancake
        {
            get { return pancake; }
            set { pancake = value; }
        }

        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
