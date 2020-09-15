/*
 * Author: Zachery Brunner
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var TT = new ThugsTBone();
            Assert.Equal(6.44, TT.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var TT = new ThugsTBone();
            Assert.True(TT.Calories == 982);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            var TT = new ThugsTBone();
            Assert.Empty(TT.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var TT = new ThugsTBone();
            Assert.Equal("Thugs T-Bone", TT.ToString());
        }
        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            var TT = new ThugsTBone();
            Assert.IsAssignableFrom<Entree>(TT);
        }
        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            var TT = new ThugsTBone();
            Assert.IsAssignableFrom<IOrderItem>(TT);
        }
    }
}