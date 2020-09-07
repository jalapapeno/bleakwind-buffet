/*
 * Author: Zachery Brunner
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            var PP = new PhillyPoacher();
            Assert.True(PP.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            var PP = new PhillyPoacher();
            Assert.True(PP.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            var PP = new PhillyPoacher();
            Assert.True(PP.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            var PP = new PhillyPoacher();
            PP.Sirloin = false;
            Assert.False(PP.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            var PP = new PhillyPoacher();
            PP.Onion = false;
            Assert.False(PP.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            var PP = new PhillyPoacher();
            PP.Roll = false;
            Assert.False(PP.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var PP = new PhillyPoacher();
            Assert.Equal(7.23, PP.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var PP = new PhillyPoacher();
            Assert.True(PP.Calories == 784);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            var PP = new PhillyPoacher()
            {
                Sirloin = includeSirloin,
                Onion = includeOnion,
                Roll = includeRoll
            };
            if (!includeSirloin) Assert.Contains("Hold sirloin", PP.SpecialInstructions);
            if (!includeOnion) Assert.Contains("Hold onions", PP.SpecialInstructions);
            if (!includeRoll) Assert.Contains("Hold roll", PP.SpecialInstructions);
            if (includeSirloin && includeOnion && includeRoll) Assert.Empty(PP.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var PP = new PhillyPoacher();
            Assert.Equal("Philly Poacher", PP.ToString());
        }
    }
}