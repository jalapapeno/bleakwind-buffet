/*
 * Author: Zachery Brunner
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            var TT = new ThalmorTriple();
            Assert.True(TT.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            var TT = new ThalmorTriple();
            TT.Bun = false;
            Assert.False(TT.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            var TT = new ThalmorTriple();
            TT.Ketchup = false;
            Assert.False(TT.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            var TT = new ThalmorTriple();
            TT.Mustard = false;
            Assert.False(TT.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            var TT = new ThalmorTriple();
            TT.Pickle = false;
            Assert.False(TT.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            var TT = new ThalmorTriple();
            TT.Tomato = false;
            Assert.False(TT.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            var TT = new ThalmorTriple();
            TT.Lettuce = false;
            Assert.False(TT.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            var TT = new ThalmorTriple();
            TT.Mayo = false;
            Assert.False(TT.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            var TT = new ThalmorTriple();
            TT.Bacon = false;
            Assert.False(TT.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            var TT = new ThalmorTriple();
            TT.Egg = false;
            Assert.False(TT.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var TT = new ThalmorTriple();
            Assert.Equal(8.32, TT.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var TT = new ThalmorTriple();
            Assert.True(943 == TT.Calories);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {
            var TT = new ThalmorTriple()
            {
                Bun = includeBun,
                Ketchup = includeKetchup,
                Mustard = includeMustard,
                Pickle = includePickle,
                Cheese = includeCheese,
                Tomato = includeTomato,
                Lettuce = includeLettuce,
                Mayo = includeMayo,
                Bacon = includeBacon,
                Egg = includeEgg
            };
            if (!includeBun) Assert.Contains("Hold bun", TT.SpecialInstructions);
            if (!includeKetchup) Assert.Contains("Hold ketchup", TT.SpecialInstructions);
            if (!includeMustard) Assert.Contains("Hold mustard", TT.SpecialInstructions);
            if (!includePickle) Assert.Contains("Hold pickle", TT.SpecialInstructions);
            if (!includeCheese) Assert.Contains("Hold cheese", TT.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", TT.SpecialInstructions);
            if (!includeLettuce) Assert.Contains("Hold lettuce", TT.SpecialInstructions);
            if (!includeMayo) Assert.Contains("Hold mayo", TT.SpecialInstructions);
            if (!includeBacon) Assert.Contains("Hold bacon", TT.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold egg", TT.SpecialInstructions);
            if (includeBun && includeKetchup && includeMustard && includePickle && includeCheese && includeTomato && includeMayo && includeLettuce && includeBacon && includeEgg) Assert.Empty(TT.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var TT = new ThalmorTriple();
            Assert.Equal("Thalmor Triple", TT.ToString());
        }
    }
}