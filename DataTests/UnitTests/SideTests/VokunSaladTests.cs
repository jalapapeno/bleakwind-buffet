/*
 * Author: Zachery Brunner
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var VS = new VokunSalad();
            Assert.Equal(Size.Small, VS.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var VS = new VokunSalad();
            VS.Size = Size.Medium;
            Assert.Equal(Size.Medium, VS.Size);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var VS = new VokunSalad();
            Assert.Empty(VS.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var VS = new VokunSalad()
            {
                Size = size
            };
            Assert.Equal(price, VS.Price);
        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var VS = new VokunSalad()
            {
                Size = size
            };
            Assert.Equal(calories, VS.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            var VS = new VokunSalad()
            {
                Size = size
            };
            Assert.Equal(VS.ToString(), name);
        }
        [Fact]
        public void ShouldBeAssignableToAbstractSideClass()
        {
            var VS = new VokunSalad();
            Assert.IsAssignableFrom<Side>(VS);
        }
        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            var VS = new VokunSalad();
            Assert.IsAssignableFrom<IOrderItem>(VS);
        }
    }
}