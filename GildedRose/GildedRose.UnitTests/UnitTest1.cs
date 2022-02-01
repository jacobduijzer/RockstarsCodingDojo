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
            var originalQuality = 10;
            var itemUnderTest = new Item {Name = "foo", SellIn = 1, Quality = originalQuality};
            
            // ARRANGE
            IList<Item> Items = new List<Item> {  itemUnderTest };
            
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
    }
}