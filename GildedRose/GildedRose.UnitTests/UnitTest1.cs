using System.Collections.Generic;
using GildedRose.ConsoleApp;
using Xunit;

namespace GildedRose.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void ItemQualityShouldDegradeBy1()
        {
            // ARRANGE
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 1, Quality = 1 } };
            ConsoleApp.GildedRose app = new ConsoleApp.GildedRose(Items);

            // ACT
            app.UpdateQuality();

            // ASSERT
            Assert.Equal(0, Items[0].Quality);
            Assert.Equal(0, Items[0].SellIn);
        }
        
        [Fact]
        public void ItemQualityShouldDegradeTwiceAsFastAfterSellByDate()
        {
            // ARRANGE
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 10 } };
            ConsoleApp.GildedRose app = new ConsoleApp.GildedRose(Items);

            // ACT
            app.UpdateQuality();

            // ASSERT
            Assert.Equal(8, Items[0].Quality);
            Assert.Equal(-1, Items[0].SellIn);
        }

        [Fact]
        public void ItemQualityShouldNeverLessThan0()
        {
            // ARRANGE
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 10, Quality = 0 } };
            ConsoleApp.GildedRose app = new ConsoleApp.GildedRose(Items);

            // ACT
            app.UpdateQuality();

            // ASSERT
            Assert.Equal(0, Items[0].Quality);
            Assert.Equal(9, Items[0].SellIn);
        }

        [Theory]
        [InlineData(10, 0, 1)]
        [InlineData(0, 10, 12)]
        public void AgedBrieQualityIncreasesTheOlderItGets(int sellIn, int initialQuality, int expectedQuality)
        {
            // ARRANGE
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = sellIn, Quality = initialQuality } };
            ConsoleApp.GildedRose app = new ConsoleApp.GildedRose(Items);

            // ACT
            app.UpdateQuality();

            // ASSERT
            Assert.Equal(expectedQuality, Items[0].Quality);
        }

        [Theory]       
        [InlineData("Aged Brie", 50, 50)]       
        public void ItemQualityNotMoreThan50(string name, int quality, int expected)
        {
            // ARRANGE
            IList<Item> Items = new List<Item> { new Item { Name = name, SellIn = 10, Quality = quality } };
            ConsoleApp.GildedRose app = new ConsoleApp.GildedRose(Items);

            // ACT
            app.UpdateQuality();

            // ASSERT
            Assert.Equal(expected, Items[0].Quality);
            Assert.Equal(9, Items[0].SellIn);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(0)]
        public void SulfurasNeverIncreasesOrDecreasesInQuality(int sellIn)
        {
            // ARRANGE
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = sellIn, Quality = 10 } };
            ConsoleApp.GildedRose app = new ConsoleApp.GildedRose(Items);

            // ACT
            app.UpdateQuality();

            // ASSERT
            Assert.Equal(10, Items[0].Quality);
        }
        
        

        [Theory]
        [InlineData(30, 10, 11)]
        [InlineData(10, 10, 12)]
        [InlineData(5, 10, 13)]
        [InlineData(0, 10, 0)]
        public void BackstagePassesChangeQualityDependingOnSellIn(int sellIn, int initialQuality, int expectedQuality)
        {
            // ARRANGE
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = sellIn, Quality = initialQuality } };
            ConsoleApp.GildedRose app = new ConsoleApp.GildedRose(Items);

            // ACT
            app.UpdateQuality();

            // ASSERT
            Assert.Equal(expectedQuality, Items[0].Quality);
        }

    }
}