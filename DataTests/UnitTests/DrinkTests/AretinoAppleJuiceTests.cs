/*
 * Author: Zachery Brunner
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            var AAJ = new ArentinoAppleJuice();
            Assert.False(AAJ.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var AAJ = new ArentinoAppleJuice();
            Assert.True(AAJ.Size == Size.Small);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var AAJ = new ArentinoAppleJuice();
            AAJ.Ice = true;
            Assert.True(AAJ.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var AAJ = new ArentinoAppleJuice();
            AAJ.Size = Size.Medium;
            Assert.True(AAJ.Size == Size.Medium);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var AAJ = new ArentinoAppleJuice()
            {
                Size = size
            };
            Assert.Equal(price, AAJ.Price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var AAJ = new ArentinoAppleJuice()
            {
                Size = size
            };
            Assert.Equal(cal, AAJ.Calories);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            var AAJ = new ArentinoAppleJuice()
            {
                Ice = includeIce
            };
            if (includeIce) Assert.Contains("Add ice", AAJ.SpecialInstructions);
            if (!includeIce) Assert.Empty(AAJ.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var AAJ = new ArentinoAppleJuice()
            {
                Size = size
            };

            Assert.Equal(AAJ.ToString(), name);
        }

        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var AAJ = new ArentinoAppleJuice();
            Assert.IsAssignableFrom<Drink>(AAJ);
        }
        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            var AAJ = new ArentinoAppleJuice();
            Assert.IsAssignableFrom<IOrderItem>(AAJ);
        }
    }
}