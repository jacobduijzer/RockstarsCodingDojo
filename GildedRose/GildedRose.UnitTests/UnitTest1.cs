using System.Collections.Generic;
using GildedRose.ConsoleApp;
using Xunit;

namespace GildedRose.UnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("foo", 1, 1, 0, 0)]
        [InlineData("foo", 0, 10, -1, 8)]
        [InlineData("foo", -1, 8, -2, 6)]
        [InlineData("foo", 2, 0, 1, 0)]
        [InlineData("foo", 0, 0, -1, 0)]
        [InlineData("Aged Brie", 1, 0, 0, 1)]
        [InlineData("Aged Brie", 0, 0, -1, 2)]
        [InlineData("Aged Brie", 0, 49, -1, 50)]
        public void UpdateQuality_AfterSellInTwice(string itemName,
                                                   int sellIn,
                                                   int quality,
                                                   int expectedSellIn,
                                                   int expectedQuality)
        {
            // ARRANGE
            IList<Item> items = new List<Item> { new Item { Name = itemName,
                    SellIn = sellIn,
                    Quality = quality } };
            ConsoleApp.GildedRose app = new ConsoleApp.GildedRose(items);

            // ACT
            app.UpdateQuality();

            // ASSERT
            Assert.Equal(expectedSellIn, items[0].SellIn);
            Assert.Equal(expectedQuality, items[0].Quality);
        }


    }
}
