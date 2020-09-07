/*
 * Author: Logan Peppers
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            var WW = new WarriorWater();
            Assert.True(WW.Ice);
        }
        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            var WW = new WarriorWater();
            Assert.False(WW.Lemon);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var WW = new WarriorWater();
            Assert.True(WW.Size == Size.Small);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var WW = new WarriorWater();
            WW.Ice = false;
            Assert.False(WW.Ice);
        }
        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            var WW = new WarriorWater();
            WW.Lemon = true;
            Assert.True(WW.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var WW = new WarriorWater();
            WW.Size = Size.Medium;
            Assert.True(WW.Size == Size.Medium);
        }

        [Theory]
        [InlineData(Size.Small, 0.00)]
        [InlineData(Size.Medium, 0.00)]
        [InlineData(Size.Large, 0.00)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var WW = new WarriorWater()
            {
                Size = size
            };
            Assert.Equal(price, WW.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var WW = new WarriorWater()
            {
                Size = size
            };
            Assert.Equal(cal, WW.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            var WW = new WarriorWater()
            {
                Ice = includeIce,
                Lemon = includeLemon
            };
            if (!includeIce) Assert.Contains("Hold ice", WW.SpecialInstructions);
            if (includeLemon) Assert.Contains("Add lemon", WW.SpecialInstructions);
            if (includeIce && !includeLemon) Assert.Empty(WW.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            string expectedSizeName = "Small";
            var WW = new WarriorWater()
            {
                Size = size
            };

            if (size == Size.Medium) expectedSizeName = "Medium";
            if (size == Size.Large) expectedSizeName = "Large";

            string expectedOutput = expectedSizeName + " Warrior Water";

            Assert.Equal(expectedOutput, name);
        }
    }
}