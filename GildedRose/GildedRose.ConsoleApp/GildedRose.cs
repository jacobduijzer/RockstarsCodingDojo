using System;
using System.Collections.Generic;

namespace GildedRose.ConsoleApp
{
    public class GildedRose
    {
        private const string SULFURAS = "Sulfuras, Hand of Ragnaros";
        IList<Item> Items;

        public GildedRose(IList<Item> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach(var item in Items)
            {
                UpdateQualityForItem(item);
            }
        }

        private static void UpdateQualityForSulfuras(Item item)
        {
            // VOID // NOP
        }

        private static void UpdateQualityForItem(Item item)
        {
            if (item.Name == SULFURAS)
            {
                UpdateQualityForSulfuras(item);
                return;
            }

            if (item.Name != "Aged Brie" && item.Name != "Backstage passes to a TAFKAL80ETC concert")
            {
                item.Quality = Math.Max(item.Quality - 1, 0);
            }
            else
            {
                item.Quality = item.Quality + 1;

                if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
                {
                    if (item.SellIn < 11)
                    {
                        item.Quality = Math.Min(item.Quality + 1, 50);
                    }

                    if (item.SellIn < 6)
                    {
                        item.Quality = Math.Min(item.Quality + 1, 50);
                    }
                }

            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                if (item.Name != "Aged Brie")
                {
                    if (item.Name != "Backstage passes to a TAFKAL80ETC concert")
                    {
                        item.Quality = Math.Max(item.Quality - 1, 0);
                    }
                    else
                    {
                        item.Quality = 0;
                    }
                }
                else
                {
                    item.Quality = Math.Min(item.Quality + 1, 50);
                }
            }
        }
    }
}
