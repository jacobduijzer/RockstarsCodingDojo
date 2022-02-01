using System.Collections.Generic;

namespace GildedRose.ConsoleApp
{
    public class GildedRose
    {
        IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            for (var i = 0; i < Items.Count; i++)
            {
                var item = Items[i];
                if (IsRegularItem(item))
                {
                    HandleRegularItem(item);
                }
                else
                {
                    if (Items[i].Quality < 50)
                    {
                        item.Quality++;
                        HandleBackstagePass(item);

                    }
                }

                DecreaseItemsSellIn(item);
                HandleNegativeSellIn(item);
            }
        }

      

        private void HandleRegularItem(Item item)
        {
            if (item.Quality > 0 && !IsLegendaryItem(item))
            {
                item.Quality--;
            }
        }

        private void HandleNegativeSellIn(Item item)
        {
            if (item.SellIn < 0)
            {
                if (item.Name != "Aged Brie")
                {
                    if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        if (item.Quality > 0)
                        {
                            if (item.Name != "Sulfuras, Hand of Ragnaros")
                            {
                                item.Quality--;
                            }
                        }
                    }
                    else
                    {
                        item.Quality = item.Quality - item.Quality;
                    }
                }
                else
                {
                    HandleAgedBrie(item);
                }
            }
        }

        private void HandleAgedBrie(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }
        }

        private void DecreaseItemsSellIn(Item item)
        {
            if (!IsLegendaryItem(item))
            {
                item.SellIn = item.SellIn - 1;
            }
        }

        private static bool IsLegendaryItem(Item item)
        {
            return item.Name == "Sulfuras, Hand of Ragnaros";
        }

        private void HandleBackstagePass(Item item)
        {
            if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
                return;

            if (item.SellIn < 11)
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }
            }

            if (item.SellIn < 6)
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }
            }
        }

        private bool IsRegularItem(Item item)
        {
            return item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert";
        }
    }
}