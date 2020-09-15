using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.Data
{
    public static class Menu
    {
        public static IEnumerable<IOrderItem> Entrees()
        {
            var BB = new BriarheartBurger();
            var DD = new DoubleDraugr();
            var GOO = new GardenOrcOmelette();
            var PP = new PhillyPoacher();
            var SS = new SmokehouseSkeleton();
            var TT = new ThalmorTriple();
            var TTB = new ThugsTBone();
            IOrderItem[] result = { BB, DD, GOO, PP, SS, TT, TTB };
            IEnumerable<IOrderItem> enumerator = new List<IOrderItem>(result);
            return enumerator;
        }
        public static IEnumerable<IOrderItem> Sides()
        {
            var sD = new DragonbornWaffleFries();
            var mD = new DragonbornWaffleFries();
            mD.Size = Size.Medium;
            var lD = new DragonbornWaffleFries();
            lD.Size = Size.Large;
            var sF = new FriedMiraak();
            var mF = new FriedMiraak();
            mF.Size = Size.Medium;
            var lF = new FriedMiraak();
            lF.Size = Size.Large;
            var sM = new MadOtarGrits();
            var mM = new MadOtarGrits();
            mM.Size = Size.Medium;
            var lM = new MadOtarGrits();
            lM.Size = Size.Large;
            var sV = new VokunSalad();
            var mV = new VokunSalad();
            mV.Size = Size.Medium;
            var lV = new VokunSalad();
            lV.Size = Size.Large;
            IOrderItem[] result = { sD,mD,lD,sF,mF,lF,sM,mM,lM,sV,mV,lV };
            IEnumerable<IOrderItem> enumerator = new List<IOrderItem>(result);
            return enumerator;
        }
        public static IEnumerable<IOrderItem> Drinks()
        {
            var sA = new ArentinoAppleJuice();
            var mA = new ArentinoAppleJuice();
            mA.Size = Size.Medium;
            var lA = new ArentinoAppleJuice();
            lA.Size = Size.Large;
            var sC = new CandlehearthCoffee();
            var mC = new CandlehearthCoffee();
            mC.Size = Size.Medium;
            var lC = new CandlehearthCoffee();
            lC.Size = Size.Large;
            var sM = new MarkarthMilk();
            var mM = new MarkarthMilk();
            mM.Size = Size.Medium;
            var lM = new MarkarthMilk();
            lM.Size = Size.Large;
            var sW = new WarriorWater();
            var mW = new WarriorWater();
            mW.Size = Size.Medium;
            var lW = new WarriorWater();
            lW.Size = Size.Large;
            var scS = new SailorSoda();
            scS.Flavor = SodaFlavor.Cherry;
            var mcS = new SailorSoda();
            mcS.Size = Size.Medium;
            mcS.Flavor = SodaFlavor.Cherry;
            var lcS = new SailorSoda();
            lcS.Size = Size.Large;
            lcS.Flavor = SodaFlavor.Cherry;
            var sbS = new SailorSoda 
            { 
                Flavor = SodaFlavor.Blackberry
            };
            var mbS = new SailorSoda
            {
                Flavor = SodaFlavor.Blackberry,
                Size = Size.Medium
        };

            var lbS = new SailorSoda
            {
                Flavor = SodaFlavor.Blackberry,
                Size = Size.Large
    };
            var spS = new SailorSoda
            {
                Flavor = SodaFlavor.Peach
            };
            var mpS = new SailorSoda
            {
                Flavor = SodaFlavor.Peach,
                Size = Size.Medium
};
            var lpS = new SailorSoda
            {
                Flavor = SodaFlavor.Peach,
                Size = Size.Large
            };
            var slS = new SailorSoda
            {
                Flavor = SodaFlavor.Lemon
            };
            var mlS = new SailorSoda
            {
                Flavor = SodaFlavor.Lemon,
                Size = Size.Medium
            };
            var llS = new SailorSoda
            {
                Flavor = SodaFlavor.Lemon,
                Size = Size.Large
            };
            var sgS = new SailorSoda
            {
                Flavor = SodaFlavor.Grapefruit
            };
            var mgS = new SailorSoda
            {
                Flavor = SodaFlavor.Grapefruit,
                Size = Size.Medium
            };
            var lgS = new SailorSoda
            {
                Flavor = SodaFlavor.Grapefruit,
                Size = Size.Large
            };
            var swS = new SailorSoda
            {
                Flavor = SodaFlavor.Watermelon
            };
            var mwS = new SailorSoda
            {
                Flavor = SodaFlavor.Watermelon,
                Size = Size.Medium
            };
            var lwS = new SailorSoda
            {
                Flavor = SodaFlavor.Watermelon,
                Size = Size.Large
            };
            IOrderItem[] result = { sA,mA,lA,sC,mC,lC,sM,mM,lM,sW,mW,lW,scS,mcS,lcS,sbS,mbS,lbS,spS,mpS,lpS,slS, mlS, llS, sgS,mgS,lgS,swS,mwS,lwS};
            IEnumerable<IOrderItem> enumerator = new List<IOrderItem>(result);
            return enumerator;
        }
        public static IEnumerable<IOrderItem> FullMenu()
        {
            var BB = new BriarheartBurger();
            var DD = new DoubleDraugr();
            var GOO = new GardenOrcOmelette();
            var PP = new PhillyPoacher();
            var SS = new SmokehouseSkeleton();
            var TT = new ThalmorTriple();
            var TTB = new ThugsTBone();
            var sD = new DragonbornWaffleFries();
            var mD = new DragonbornWaffleFries();
            mD.Size = Size.Medium;
            var lD = new DragonbornWaffleFries();
            lD.Size = Size.Large;
            var sF = new FriedMiraak();
            var mF = new FriedMiraak();
            mF.Size = Size.Medium;
            var lF = new FriedMiraak();
            lF.Size = Size.Large;
            var sM = new MadOtarGrits();
            var mM = new MadOtarGrits();
            mM.Size = Size.Medium;
            var lM = new MadOtarGrits();
            lM.Size = Size.Large;
            var sV = new VokunSalad();
            var mV = new VokunSalad();
            mV.Size = Size.Medium;
            var lV = new VokunSalad();
            lV.Size = Size.Large;
            var sA = new ArentinoAppleJuice();
            var mA = new ArentinoAppleJuice();
            mA.Size = Size.Medium;
            var lA = new ArentinoAppleJuice();
            lA.Size = Size.Large;
            var sC = new CandlehearthCoffee();
            var mC = new CandlehearthCoffee();
            mC.Size = Size.Medium;
            var lC = new CandlehearthCoffee();
            lC.Size = Size.Large;
            var sMM = new MarkarthMilk();
            var mMM = new MarkarthMilk();
            mMM.Size = Size.Medium;
            var lMM = new MarkarthMilk();
            lMM.Size = Size.Large;
            var sW = new WarriorWater();
            var mW = new WarriorWater();
            mW.Size = Size.Medium;
            var lW = new WarriorWater();
            lW.Size = Size.Large;
            var scS = new SailorSoda();
            scS.Flavor = SodaFlavor.Cherry;
            var mcS = new SailorSoda();
            mcS.Size = Size.Medium;
            mcS.Flavor = SodaFlavor.Cherry;
            var lcS = new SailorSoda();
            lcS.Size = Size.Large;
            lcS.Flavor = SodaFlavor.Cherry;
            var sbS = new SailorSoda
            {
                Flavor = SodaFlavor.Blackberry
            };
            var mbS = new SailorSoda
            {
                Flavor = SodaFlavor.Blackberry,
                Size = Size.Medium
            };

            var lbS = new SailorSoda
            {
                Flavor = SodaFlavor.Blackberry,
                Size = Size.Large
            };
            var spS = new SailorSoda
            {
                Flavor = SodaFlavor.Peach
            };
            var mpS = new SailorSoda
            {
                Flavor = SodaFlavor.Peach,
                Size = Size.Medium
            };
            var lpS = new SailorSoda
            {
                Flavor = SodaFlavor.Peach,
                Size = Size.Large
            };
            var slS = new SailorSoda
            {
                Flavor = SodaFlavor.Lemon
            };
            var mlS = new SailorSoda
            {
                Flavor = SodaFlavor.Lemon,
                Size = Size.Medium
            };
            var llS = new SailorSoda
            {
                Flavor = SodaFlavor.Lemon,
                Size = Size.Large
            };
            var sgS = new SailorSoda
            {
                Flavor = SodaFlavor.Grapefruit
            };
            var mgS = new SailorSoda
            {
                Flavor = SodaFlavor.Grapefruit,
                Size = Size.Medium
            };
            var lgS = new SailorSoda
            {
                Flavor = SodaFlavor.Grapefruit,
                Size = Size.Large
            };
            var swS = new SailorSoda
            {
                Flavor = SodaFlavor.Watermelon
            };
            var mwS = new SailorSoda
            {
                Flavor = SodaFlavor.Watermelon,
                Size = Size.Medium
            };
            var lwS = new SailorSoda
            {
                Flavor = SodaFlavor.Watermelon,
                Size = Size.Large
            };

            IOrderItem[] result = { BB, DD, GOO, PP, SS, TT, TTB, sD, mD, lD, sF, mF, lF, sM, mM, lM, sV, mV, lV, sA, mA, lA, sC, mC, lC, sMM, mMM, lMM, sW, mW, lW, scS, mcS, lcS, sbS, mbS, lbS, spS, mpS, lpS, slS, mlS, llS, sgS, mgS, lgS, swS, mwS, lwS };
            IEnumerable<IOrderItem> enumerator = new List<IOrderItem>(result);
            return enumerator;
        }
    }
}
