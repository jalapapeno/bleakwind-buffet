﻿/*
 * Author: Zachery Brunner
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;

using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var DWF = new DragonbornWaffleFries();
            Assert.Equal(Size.Small, DWF.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var DWF = new DragonbornWaffleFries();
            DWF.Size = Size.Medium;
            Assert.Equal(Size.Medium, DWF.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var DWF = new DragonbornWaffleFries();
            Assert.Empty(DWF.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var DWF = new DragonbornWaffleFries()
            {
                Size = size
            };
            Assert.Equal(price, DWF.Price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var DWF = new DragonbornWaffleFries()
            {
                Size = size
            };
            Assert.Equal(calories, DWF.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var DWF = new DragonbornWaffleFries()
            {
                Size = size
            };
            Assert.Equal(DWF.ToString(), name);
        }
        [Fact]
        public void ShouldBeAssignableToAbstractSideClass()
        {
            var DWF = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(DWF);
        }
        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            var DWF = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<IOrderItem>(DWF);
        }
    }
}