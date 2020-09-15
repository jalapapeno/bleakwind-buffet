/*
 * Author: Zachery Brunner
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {        
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            var SS = new SmokehouseSkeleton();
            Assert.True(SS.SausageLink); 
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            var SS = new SmokehouseSkeleton();
            Assert.True(SS.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            var SS = new SmokehouseSkeleton();
            Assert.True(SS.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            var SS = new SmokehouseSkeleton();
            Assert.True(SS.Pancake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            var SS = new SmokehouseSkeleton();
            SS.SausageLink = false;
            Assert.False(SS.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            var SS = new SmokehouseSkeleton();
            SS.Egg = false;
            Assert.False(SS.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            var SS = new SmokehouseSkeleton();
            SS.HashBrowns = false;
            Assert.False(SS.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            var SS = new SmokehouseSkeleton();
            SS.Pancake = false;
            Assert.False(SS.Pancake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var SS = new SmokehouseSkeleton();
            Assert.Equal(5.62, SS.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var SS = new SmokehouseSkeleton();
            Assert.True(SS.Calories == 602);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            var SS = new SmokehouseSkeleton()
            {
                SausageLink = includeSausage,
                Egg = includeEgg,
                HashBrowns = includeHashbrowns,
                Pancake = includePancake
            };
            if (!includeSausage) Assert.Contains("Hold sausage", SS.SpecialInstructions);
            if (!includeEgg) Assert.Contains("Hold eggs", SS.SpecialInstructions);
            if (!includeHashbrowns) Assert.Contains("Hold hash browns", SS.SpecialInstructions);
            if (!includePancake) Assert.Contains("Hold pancakes", SS.SpecialInstructions);
            if (includeSausage && includeEgg && includeHashbrowns && includePancake) Assert.Empty(SS.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var SS = new SmokehouseSkeleton();
            Assert.Equal("Smokehouse Skeleton", SS.ToString());
        }
        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            var SS = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(SS);
        }
        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            var SS = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<IOrderItem>(SS);
        }
    }
}