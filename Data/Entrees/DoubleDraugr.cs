/*
* Author: Logan Peppers
* Class name: DoubleDraugr.cs
* Purpose: Holds the Double Draugr menu item properties.
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace BleakwindBuffet.Data.Entrees
{
    public class DoubleDraugr
    {
        public double Price
        {
            get
            {
                return 7.32;
            }

        }
        public uint Calories
        {
            get
            {
                return 843;
            }

        }
        public List<String> SpecialInstructions
        {
            get
            {
                List<String> empty = new List<String>();
                if (bun == false)
                {
                    empty.Append("Hold bun");
                }
                if (ketchup == false)
                {
                    empty.Append("Hold ketchup");
                }
                if (mustard == false)
                {
                    empty.Append("Hold mustard");
                }
                if (pickle == false)
                {
                    empty.Append("Hold pickle");
                }
                if (cheese == false)
                {
                    empty.Append("Hold cheese");
                }
                if (tomato == false)
                {
                    empty.Append("Hold tomato");
                }
                if (lettuce == false)
                {
                    empty.Append("Hold lettuce");
                }
                if (mayo == false)
                {
                    empty.Append("Hold mayo");
                }
                return empty;
            }
        }
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }
        public bool Lettuce
        {
            get { return lettuce; }
            set { lettuce = value; }
        }
        public bool Mayo
        {
            get { return mayo; }
            set { mayo = value; }
        }

        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
