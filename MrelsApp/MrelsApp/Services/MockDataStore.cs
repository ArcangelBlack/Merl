﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MrelsApp.Models;

[assembly: Xamarin.Forms.Dependency(typeof(MrelsApp.Services.MockDataStore))]
namespace MrelsApp.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Treadmill", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Bench Press", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Tricep Extensions", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Pushups", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Dips", Description="This is an item description." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Incline Dumbell Press", Description="This is an item description." },
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

        public async Task<bool> DeleteItemAsync(Item item)
        {
            var _item = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
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