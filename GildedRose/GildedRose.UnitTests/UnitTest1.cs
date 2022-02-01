using System.Collections.Generic;
using GildedRose.ConsoleApp;
using Xunit;

namespace GildedRose.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Foo()
        {
            // ARRANGE
            IList<Item> Items = new List<Item> { new Item { Name = "foo", SellIn = 0, Quality = 0 } };
            ConsoleApp.GildedRose app = new ConsoleApp.GildedRose(Items);

            // ACT
            app.UpdateQuality();

            // ASSERT
            Assert.Equal("fixme", Items[0].Name);
        }

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

    }
}