/*
 * Author: Zachery Brunner
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            var GOO = new GardenOrcOmelette();
            Assert.True(GOO.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            var GOO = new GardenOrcOmelette();
            Assert.True(GOO.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            var GOO = new GardenOrcOmelette();
            Assert.True(GOO.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            var GOO = new GardenOrcOmelette();
            Assert.True(GOO.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            var GOO = new GardenOrcOmelette();
            GOO.Broccoli = false;
            Assert.False(GOO.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            var GOO = new GardenOrcOmelette();
            GOO.Mushrooms = false;
            Assert.False(GOO.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            var GOO = new GardenOrcOmelette();
            GOO.Tomato = false;
            Assert.False(GOO.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            var GOO = new GardenOrcOmelette();
            GOO.Cheddar = false;
            Assert.False(GOO.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            var GOO = new GardenOrcOmelette();
            Assert.Equal(4.57, GOO.Price);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            var GOO = new GardenOrcOmelette();
            Assert.True(GOO.Calories == 404);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            var GOO = new GardenOrcOmelette()
            {
                Broccoli = includeBroccoli,
                Mushrooms = includeMushrooms,
                Tomato = includeTomato,
                Cheddar = includeCheddar
            };
            if (!includeBroccoli) Assert.Contains("Hold broccoli", GOO.SpecialInstructions);
            if (!includeMushrooms) Assert.Contains("Hold mushrooms", GOO.SpecialInstructions);
            if (!includeTomato) Assert.Contains("Hold tomato", GOO.SpecialInstructions);
            if (!includeCheddar) Assert.Contains("Hold cheddar", GOO.SpecialInstructions);
            if (includeBroccoli && includeMushrooms && includeTomato && includeCheddar) Assert.Empty(GOO.SpecialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            var GOO = new GardenOrcOmelette();
            Assert.Equal("Garden Orc Omelette", GOO.ToString());
        }
        [Fact]
        public void ShouldBeAssignableToAbstractEntreeClass()
        {
            var GOO = new GardenOrcOmelette();
            Assert.IsAssignableFrom<Entree>(GOO);
        }
        [Fact]
        public void ShouldBeAssignableToIOrderItem()
        {
            var GOO = new GardenOrcOmelette();
            Assert.IsAssignableFrom<IOrderItem>(GOO);
        }
    }
}