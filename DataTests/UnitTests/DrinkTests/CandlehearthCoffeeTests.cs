﻿/*
 * Author: Zachery Brunner
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            var CC = new CandlehearthCoffee();
            Assert.False(CC.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            var CC = new CandlehearthCoffee();
            Assert.False(CC.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            var CC = new CandlehearthCoffee();
            Assert.False(CC.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var CC = new CandlehearthCoffee();
            Assert.Equal(Size.Small, CC.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var CC = new CandlehearthCoffee();
            CC.Ice = true;
            Assert.True(CC.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            var CC = new CandlehearthCoffee();
            CC.Decaf = true;
            Assert.True(CC.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            var CC = new CandlehearthCoffee();
            CC.RoomForCream = true;
            Assert.True(CC.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var CC = new CandlehearthCoffee();
            CC.Size = Size.Medium;
            Assert.Equal(Size.Medium, CC.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var CC = new CandlehearthCoffee()
            {
                Size = size
            };
            Assert.Equal(price, CC.Price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            var CC = new CandlehearthCoffee()
            {
                Size = size
            };
            Assert.Equal(cal, CC.Calories);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            var CC = new CandlehearthCoffee()
            {
                Ice = includeIce,
                RoomForCream = includeCream
            };
            if (includeIce) Assert.Contains("Add ice", CC.SpecialInstructions);
            if (includeCream) Assert.Contains("Add cream", CC.SpecialInstructions);
            if (!includeIce && !includeCream) Assert.Empty(CC.SpecialInstructions);
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            var CC = new CandlehearthCoffee()
            {
                Size = size,
                Decaf = decaf
            };
            Assert.Equal(CC.ToString(), name);
        }
        [Fact]
        public void ShouldBeAssignableToAbstractDrinkClass()
        {
            var CC = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(CC);
        }
        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            var CC = new CandlehearthCoffee();
            Assert.IsAssignableFrom<IOrderItem>(CC);
        }
    }
}
