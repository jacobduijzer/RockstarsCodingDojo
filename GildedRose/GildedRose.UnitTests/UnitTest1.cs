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
    }
}