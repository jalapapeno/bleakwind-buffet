/*
 * Author: Zachery Brunner
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            var MM = new MarkarthMilk();
            Assert.False(MM.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            var MM = new MarkarthMilk();
            Assert.Equal(Size.Small, MM.Size);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            var MM = new MarkarthMilk();
            MM.Ice = true;
            Assert.True(MM.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var MM = new MarkarthMilk();
            MM.Size = Size.Medium;
            Assert.Equal(Size.Medium, MM.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var MM = new MarkarthMilk()
            {
                Size = size
            };
            Assert.Equal(price, MM.Price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var MM = new MarkarthMilk()
            {
                Size = size
            };
            Assert.Equal(cal, MM.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            var MM = new MarkarthMilk()
            {
                Ice = includeIce,
            };
            if (includeIce) Assert.Contains("Add ice", MM.SpecialInstructions);
            if (!includeIce) Assert.Empty(MM.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            string expectedSizeName = "Small";
            string expectedOutput;
            var MM = new MarkarthMilk()
            {
                Size = size,
            };

            if (size == Size.Medium) expectedSizeName = "Medium";
            if (size == Size.Large) expectedSizeName = "Large";
            expectedOutput = expectedSizeName + " Markarth Milk";

            Assert.Equal(expectedOutput, name);
        }
    }
}