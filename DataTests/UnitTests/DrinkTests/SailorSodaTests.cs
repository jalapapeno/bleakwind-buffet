/*
 * Author: Zachery Brunner
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            var SS = new SailorSoda();
            Assert.True(SS.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var SS = new SailorSoda();
            Assert.True(SS.Size == Size.Small);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            var SS = new SailorSoda();
            Assert.True(SS.Flavor == SodaFlavor.Cherry);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var SS = new SailorSoda();
            SS.Ice = false;
            Assert.False(SS.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var SS = new SailorSoda();
            SS.Size = Size.Medium;
            Assert.Equal(Size.Medium, SS.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            var SS = new SailorSoda();
            SS.Flavor = SodaFlavor.Peach;
            Assert.Equal(SodaFlavor.Peach, SS.Flavor);
        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var SS = new SailorSoda()
            {
                Size = size
            };
            Assert.Equal(price, SS.Price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var SS = new SailorSoda()
            {
                Size = size
            };
            Assert.Equal(cal, SS.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            var SS = new SailorSoda()
            {
                Ice = includeIce,
            };
            if (!includeIce) Assert.Contains("Hold ice", SS.SpecialInstructions);
            if (includeIce) Assert.Empty(SS.SpecialInstructions);
        }

        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            string expectedSizeName = "Small";
            string expectedOutput;
            var SS = new SailorSoda()
            {
                Size = size,
                Flavor = flavor
            };

            if (size == Size.Medium) expectedSizeName = "Medium";
            if (size == Size.Large) expectedSizeName = "Large";
            if (flavor == SodaFlavor.Blackberry)
            {
                expectedOutput = expectedSizeName + " Blackberry" + " Sailor Soda";
            }
            else if (flavor == SodaFlavor.Watermelon)
            {
                expectedOutput = expectedSizeName + " Watermelon" + " Sailor Soda";
            }
            else if (flavor == SodaFlavor.Peach)
            {
                expectedOutput = expectedSizeName + " Peach" + " Sailor Soda";
            }
            else if (flavor == SodaFlavor.Grapefruit)
            {
                expectedOutput = expectedSizeName + " Grapefruit" + " Sailor Soda";
            }
            else if (flavor == SodaFlavor.Lemon)
            {
                expectedOutput = expectedSizeName + " Lemon" + " Sailor Soda";
            }
            else
                expectedOutput = expectedSizeName + " Cherry" + " Sailor Soda";
            Assert.Equal(expectedOutput, name);
        }
    }
}
