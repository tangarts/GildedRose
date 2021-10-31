using System;
using System.Collections.Generic;

namespace GildedRose.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("OMGHAI!");

            var items = new List<Item>
            {
                new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20},
                new Item {Name = "Aged Brie", SellIn = 2, Quality = 0},
                new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7},
                new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80},
                new Item
                    {
                        Name = "Backstage passes to a TAFKAL80ETC concert",
                        SellIn = 15,
                        Quality = 20
                    },
                new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6}
            };

            items.Add(new Item { Name = "Aged Brie", SellIn = 0, Quality = 0 });
            items.Add(new Item { Name = "Elixir of the Mongoose", SellIn = 0, Quality = 0 });

            var app = new App(items);

            app.UpdateQuality();
            foreach(Item item in app.Items)
            {
                System.Console.WriteLine($"name: {item.Name}, sell in: {item.SellIn}, quality: {item.Quality}");
            }    
            System.Console.ReadKey();
        }
    }

}
