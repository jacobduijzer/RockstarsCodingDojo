using System.Collections.Generic;
using GildedRose.ConsoleApp;
using Xunit;

namespace GildedRose.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void UpdateQuality_NormalItem()
        {
            // ARRANGE
            IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 1, Quality = 1 } };
            ConsoleApp.GildedRose app = new ConsoleApp.GildedRose(items);

            // ACT
            app.UpdateQuality();

            // ASSERT
            Assert.Equal(0, items[0].SellIn);
            Assert.Equal(0, items[0].Quality);
        }

        [Fact]
        public void UpdateQuality_AfterSellIn()
        {
            // ARRANGE
            IList<Item> items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 10 } };
            ConsoleApp.GildedRose app = new ConsoleApp.GildedRose(items);

            // ACT
            app.UpdateQuality();

            // ASSERT
            Assert.Equal(-1, items[0].SellIn);
            Assert.Equal(8, items[0].Quality);
        }
    }
}