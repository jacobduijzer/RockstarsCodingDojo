using System.Collections.Generic;
using GildedRose.ConsoleApp;
using Xunit;

namespace GildedRose.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void QualityDecreasesTwiceAsFastAfterSellByDate()
        {
            var originalQuality = 10;
            var itemUnderTest = new Item {Name = "foo", SellIn = 1, Quality = originalQuality};

            // ARRANGE
            IList<Item> Items = new List<Item> {itemUnderTest};

            ConsoleApp.GildedRose app = new ConsoleApp.GildedRose(Items);

            // ACT
            app.UpdateQuality();

            var qualityDecreasedBeforeSellByDate = originalQuality - itemUnderTest.Quality;
            var qualityAfterFirstRun = itemUnderTest.Quality;

            app.UpdateQuality();
            var qualityDecreasedAfterSellByDate = qualityAfterFirstRun - itemUnderTest.Quality;

            // ASSERT
            Assert.Equal(qualityDecreasedBeforeSellByDate * 2, qualityDecreasedAfterSellByDate);
        }

        [Fact]
        public void QualityIsNeverNegative()
        {
            var originalQuality = 2;
            var itemUnderTest = new Item {Name = "foo", SellIn = 1, Quality = originalQuality};

            // ARRANGE
            IList<Item> Items = new List<Item> {itemUnderTest};

            ConsoleApp.GildedRose app = new ConsoleApp.GildedRose(Items);

            // ACT
            for (int i = 0; i < 5; i++)
            {
                app.UpdateQuality();
            }

            // ASSERT
            Assert.True(itemUnderTest.Quality >= 0);
        }

        [Fact]
        public void AgedBrieGetsBetterQualityOverTime()
        {
            var originalQuality = 10;
            var itemUnderTest = new Item {Name = "Aged Brie", SellIn = 10, Quality = originalQuality};

            // ARRANGE
            IList<Item> Items = new List<Item> {itemUnderTest};

            ConsoleApp.GildedRose app = new ConsoleApp.GildedRose(Items);

            // ACT
            for (int i = 0; i < 5; i++)
            {
                app.UpdateQuality();
            }

            // ASSERT
            Assert.True(itemUnderTest.Quality > originalQuality);
            Assert.Equal(5, itemUnderTest.SellIn);
        }

        [Fact]
        public void NoItemHasQualityHigherThan50()
        {
            var originalQuality = 49;
            var itemUnderTest = new Item {Name = "Aged Brie", SellIn = 10, Quality = originalQuality};

            // ARRANGE
            IList<Item> Items = new List<Item> {itemUnderTest};

            ConsoleApp.GildedRose app = new ConsoleApp.GildedRose(Items);

            // ACT
            for (int i = 0; i < 5; i++)
            {
                app.UpdateQuality();
            }

            // ASSERT
            Assert.True(itemUnderTest.Quality <= 50);
        }

        [Fact]
        public void SulfarusNeverHasToBeSoldOrDecreasesInQuality()
        {
            var originalSellIn = 2;
            var originalQuality = 2;
            var itemUnderTest = new Item
                {Name = "Sulfuras, Hand of Ragnaros", SellIn = originalSellIn, Quality = originalQuality};

            // ARRANGE
            IList<Item> Items = new List<Item> {itemUnderTest};

            ConsoleApp.GildedRose app = new ConsoleApp.GildedRose(Items);

            // ACT
            for (int i = 0; i < 5; i++)
            {
                app.UpdateQuality();
            }

            // ASSERT
            Assert.True(itemUnderTest.Quality >= originalQuality);
            Assert.True(itemUnderTest.SellIn >= 0);
        }

        [Fact]
        public void BackstagePassesDecreasing()
        {
            var originalSellIn = 12;
            var originalQuality = 0;
            var itemUnderTest = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = originalSellIn, Quality = originalQuality
            };

            // ARRANGE
            IList<Item> Items = new List<Item> {itemUnderTest};

            ConsoleApp.GildedRose app = new ConsoleApp.GildedRose(Items);

            // ACT & ASSERT
            app.UpdateQuality();
            Assert.Equal(1,itemUnderTest.Quality);
        }
    }
}