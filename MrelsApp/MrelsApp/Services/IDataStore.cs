using MrelsApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MrelsApp.Services
{
    public interface IDataStore<T>
    {
        //Task<bool> AddItemAsync(T item);

        //Task<bool> UpdateItemAsync(T item);

        //Task<bool> DeleteItemAsync(T item);

        //Task<T> GetItemAsync(string id);

        Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false);

        Task<IEnumerable<T>> GetItemsFromParentIdAsync(string parentId);

        //Task<List<T>> Get<T>(string urlBase, string servicePrefix, string controller);

        //Task<Response> Put<T>(string urlBase, string servicePrefix, string controller, T model);
    }
}
