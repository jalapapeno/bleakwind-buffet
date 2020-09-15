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
    /// <summary>
    /// Class representing the Smokehouse Skeleton dish
    /// </summary>
    public class SmokehouseSkeleton : Entree, IOrderItem
    {
        /// <summary>
        /// Gets the price (One value)
        /// </summary>
        public double Price
        {
            get
            {
                return 5.62;
            }

        }
        /// <summary>
        /// Gets the calorie count (One value)
        /// </summary>
        public uint Calories
        {
            get
            {
                return 602;
            }

        }
        /// <summary>
        /// Adds instructions to the list based on variable ingredients
        /// </summary>
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> empty = new List<String>();
                if (sausageLink == false)
                {
                    empty.Add("Hold sausage");
                }
                if (egg == false)
                {
                    empty.Add("Hold eggs");
                }
                if (hashBrowns == false)
                {
                    empty.Add("Hold hash browns");
                }
                if (pancake == false)
                {
                    empty.Add("Hold pancakes");
                }
                
                return empty;
            }
        }

        /* Private variable declarations for the dish */
        private bool sausageLink = true;
        private bool egg = true;
        private bool hashBrowns = true;
        private bool pancake = true;
        /// <summary>
        /// If the dish includes sausage links
        /// </summary>
        public bool SausageLink
        {
            get { return sausageLink; }
            set { sausageLink = value; }
        }
        /// <summary>
        /// If the dish includes eggs
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set { egg = value; }
        }
        /// <summary>
        /// If the dish includes hashbrowns
        /// </summary>
        public bool HashBrowns
        {
            get { return hashBrowns; }
            set { hashBrowns= value; }
        }
        /// <summary>
        /// If the dish includes pancakes
        /// </summary>
        public bool Pancake
        {
            get { return pancake; }
            set { pancake = value; }
        }

        /// <summary>
        /// Overrides the ToString method to return the name of the entree 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
