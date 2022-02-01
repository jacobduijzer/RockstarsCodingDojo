using System.Collections.Generic;
using GildedRose.ConsoleApp;
using Xunit;

namespace GildedRose.UnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, 1, 0, 0)]
        [InlineData(0, 10, -1, 8)]
        [InlineData(-1, 8, -2, 6)]
        [InlineData(0, -1, 0, 0)]
        public void UpdateQuality_AfterSellInTwice(int sellIn,
                                                   int quality,
                                                   int expectedSellIn,
                                                   int expectedQuality)
        {
            // ARRANGE
            IList<Item> items = new List<Item> { new Item { Name = "foo",
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
