/*
* Author: Logan Peppers
* Class name: GardenOrcOmelette.cs
* Purpose: Holds the Garden Orc Omelette menu item properties.
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Class representing the Garden Orc Omelette
    /// </summary>
    public class GardenOrcOmelette : Entree, IOrderItem
    {
        /// <summary>
        /// Sets the price (One value)
        /// </summary>
        public double Price
        {
            get
            {
                return 4.57;
            }

        }
        /// <summary>
        /// Gets the calorie count (One value)
        /// </summary>
        public uint Calories
        {
            get
            {
                return 404;
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
                if (broccoli == false)
                {
                    empty.Add("Hold broccoli");
                }
                if (mushrooms== false)
                {
                    empty.Add("Hold mushrooms");
                }
                if (tomato == false)
                {
                    empty.Add("Hold tomato");
                }
                if (cheddar == false)
                {
                    empty.Add("Hold cheddar");
                }
                
                return empty;
            }
        }

        /* Private variable declaration for the omelette */
        private bool broccoli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool cheddar = true;

        /// <summary>
        /// If broccoli is included
        /// </summary>
        public bool Broccoli
        {
            get { return broccoli; }
            set { broccoli = value; }
        }
        /// <summary>
        /// If mushrooms are included
        /// </summary>
        public bool Mushrooms
        {
            get { return mushrooms; }
            set { mushrooms = value; }
        }
        /// <summary>
        /// If tomatoes are included
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }
        /// <summary>
        /// If cheddar is included
        /// </summary>
        public bool Cheddar
        {
            get { return cheddar; }
            set { cheddar = value; }
        }

        /// <summary>
        /// Overrides the ToString method to return the name of the entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
