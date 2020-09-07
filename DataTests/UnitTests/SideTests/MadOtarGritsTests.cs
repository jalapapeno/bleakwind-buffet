/*
 * Author: Zachery Brunner
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var MOG = new MadOtarGrits();
            Assert.True(MOG.Size == Size.Small);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var MOG = new MadOtarGrits();
            MOG.Size = Size.Medium;
            Assert.True(MOG.Size == Size.Medium);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            var MOG = new MadOtarGrits();
            Assert.Empty(MOG.SpecialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            var MOG = new MadOtarGrits()
            {
                Size = size
            };
            Assert.Equal(price, MOG.Price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            var MOG = new MadOtarGrits()
            {
                Size = size
            };
            Assert.Equal(calories, MOG.Calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            string expectedSizeName = "Small";
            var MOG = new MadOtarGrits()
            {
                Size = size
            };

            if (size == Size.Medium) expectedSizeName = "Medium";
            if (size == Size.Large) expectedSizeName = "Large";

            string expectedOutput = expectedSizeName + " Mad Otar Grits";

            Assert.Equal(expectedOutput, name);
        }
    }
}