using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.Data
{
    public abstract class Drink
    {
        Size Size { get; set; }
        double Price { get; }
        uint Calories { get; }
        List<string> SpecialInstructions { get; }
    }
}
