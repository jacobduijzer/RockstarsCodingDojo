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
                UpdateItem(Items[i]);
            }
        }

        bool IsAgedBrie(Item item)
        {
            return item.Name == "Aged Brie";
        }
        
        bool IsBackstagePass(Item item)
        {
            return item.Name == "Backstage passes to a TAFKAL80ETC concert";
        }

        bool IsSulfarus(Item item)
        {
            return item.Name == "Sulfuras, Hand of Ragnaros";
        }

        private void UpdateItem(Item item)
        {
            if (!IsAgedBrie(item) && !IsBackstagePass(item))
            {
                if (item.Quality > 0)
                {
                    if (item.Name != "Sulfuras, Hand of Ragnaros")
                    {
                        item.Quality = item.Quality - 1;
                    }
                }
            }
            else
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;

                    if (IsBackstagePass(item))
                    {
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
                }
            }

            if (!IsSulfarus(item))
            {
                item.SellIn = item.SellIn - 1;
            }

            if (item.SellIn < 0)
            {
                if (!IsAgedBrie(item))
                {
                    if (!IsBackstagePass(item))
                    {
                        if (item.Quality > 0)
                        {
                            if (!IsSulfarus(item))
                            {
                                item.Quality = item.Quality - 1;
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
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }
        }
    }
}