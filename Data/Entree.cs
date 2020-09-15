using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    public abstract class Entree
    {
        double Price { get; }
        uint Calories { get; }
        List<string> SpecialInstructions { get; }
    }
}
