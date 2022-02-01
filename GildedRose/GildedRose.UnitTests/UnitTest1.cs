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
            var itemUnderTest = new Item {Name = "Aged Brie", SellIn = 4, Quality = originalQuality};

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
            Assert.Equal(-1, itemUnderTest.SellIn);
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
            for (int i = 0; i < 15; i++)
            {
                app.UpdateQuality();
            }

            // ASSERT
            Assert.True(itemUnderTest.Quality >= originalQuality);
            Assert.True(itemUnderTest.SellIn >= 0);
        }

        [Theory]
        [InlineData(12, 0, 1)]
        [InlineData(11, 0, 1)]
        [InlineData(10, 0, 2)]
        [InlineData(9, 0, 2)]
        [InlineData(8, 0, 2)]
        /*....*/
        [InlineData(5, 0, 3)]
        [InlineData(4, 0, 3)]
        /*....*/
        [InlineData(0, 10, 0)]
        public void BackstagePassesDecreasing(int originalSellIn, int originalQuality, int expectedQuality)
        {
            var itemUnderTest = new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = originalSellIn, Quality = originalQuality
            };

            // ARRANGE
            IList<Item> Items = new List<Item> {itemUnderTest};

            ConsoleApp.GildedRose app = new ConsoleApp.GildedRose(Items);

            // ACT & ASSERT
            app.UpdateQuality();
            Assert.Equal(expectedQuality,itemUnderTest.Quality);
        }
        
        // [Theory]
        // [InlineData(12, 10, 8)]
        // [InlineData(3, 5, 3)]
        // public void ConjuredItemsDegradeTwiceAsFast(int originalSellIn, int originalQuality, int expectedQuality)
        // {
        //     var itemUnderTest = new Item
        //     {
        //         Name = "Conjured", SellIn = originalSellIn, Quality = originalQuality
        //     };
        //
        //     // ARRANGE
        //     IList<Item> Items = new List<Item> {itemUnderTest};
        //
        //     ConsoleApp.GildedRose app = new ConsoleApp.GildedRose(Items);
        //
        //     // ACT & ASSERT
        //     app.UpdateQuality();
        //     Assert.Equal(expectedQuality,itemUnderTest.Quality);
        // }
    }
}