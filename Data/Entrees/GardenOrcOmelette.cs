/*
* Author: Logan Peppers
* Class name: GardenOrcOmelette.cs
* Purpose: Holds the Garden Orc Omelette menu item properties.
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Data.Entrees
{
    public class GardenOrcOmelette
    {
        public double Price
        {
            get
            {
                return 4.57;
            }

        }
        public uint Calories
        {
            get
            {
                return 404;
            }

        }
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> empty = new List<String>();
                if (broccoli == false)
                {
                    empty.Append("Hold broccoli");
                }
                if (mushrooms== false)
                {
                    empty.Append("Hold mushrooms");
                }
                if (tomato == false)
                {
                    empty.Append("Hold tomato");
                }
                if (cheddar == false)
                {
                    empty.Append("Hold cheddar");
                }
                
                return empty;
            }
        }
        private bool broccoli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool cheddar = true;
        public bool Broccoli
        {
            get { return broccoli; }
            set { broccoli = value; }
        }
        public bool Mushrooms
        {
            get { return mushrooms; }
            set { mushrooms = value; }
        }
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }
        public bool Cheddar
        {
            get { return cheddar; }
            set { cheddar = value; }
        }

        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
