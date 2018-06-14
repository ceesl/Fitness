using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Fitness.Models;

[assembly: Xamarin.Forms.Dependency(typeof(Fitness.Services.MockDataStore))]
namespace Fitness.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { Id = Guid.NewGuid().ToString(), ToestelNaam = "Seated Leg Press", Description="Stoel 8", Gewicht=45.543, Herhaling=20, Series=2 },
                new Item { Id = Guid.NewGuid().ToString(), ToestelNaam = "Leg Extension", Description="Stoel 6, Voetrol L, BWB: Max, Links en rechts apart", Gewicht=7, Herhaling=20, Series=2 },
                new Item { Id = Guid.NewGuid().ToString(), ToestelNaam = "Chest press", Description="Stoel hoog", Gewicht=14.543, Herhaling=20, Series=2 },
                new Item { Id = Guid.NewGuid().ToString(), ToestelNaam = "Pectoral Fly", Description="Stoel 5, armen 4", Gewicht=14.42, Herhaling=20, Series=2 },
                new Item { Id = Guid.NewGuid().ToString(), ToestelNaam = "Lat Pulldown", Description="", Gewicht=14, Herhaling=20, Series=2 },
                new Item { Id = Guid.NewGuid().ToString(), ToestelNaam = "Seated Row", Description="Stoel 5, Borststeun 5", Gewicht=14, Herhaling=20, Series=2 },
                new Item { Id = Guid.NewGuid().ToString(), ToestelNaam = "Side raise", Description="Katrol op 50 cm, links en rechts apart", Gewicht=1.25, Herhaling=20, Series=2 },
                new Item { Id = Guid.NewGuid().ToString(), ToestelNaam = "Low Back Extension", Description="Voetsteun 5, Rugsteun XL", Gewicht=35, Herhaling=20, Series=2 },
                new Item { Id = Guid.NewGuid().ToString(), ToestelNaam = "Weighted situp", Description="Situps met bal", Gewicht=3, Herhaling=10, Series=2 },
                new Item { Id = Guid.NewGuid().ToString(), ToestelNaam = "Oblique, twist", Description="Voeten los, bal links en rechts grond raken", Gewicht=3, Herhaling=12, Series=2 },

            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var _item = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(_item);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var _item = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(_item);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}