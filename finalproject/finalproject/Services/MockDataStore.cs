using finalproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalproject.Services
{
    public class MockDataStore : IDataStore<FavMovie>
    {
        readonly List<FavMovie> favs;

        public MockDataStore()
        {
            favs = new List<FavMovie>()
            {
                new FavMovie { Id = Guid.NewGuid().ToString(), Title = "First item" },
                new FavMovie { Id = Guid.NewGuid().ToString(), Title = "Second item"},
                new FavMovie { Id = Guid.NewGuid().ToString(), Title = "Third item"},
                new FavMovie { Id = Guid.NewGuid().ToString(), Title = "Fourth item"},
                new FavMovie { Id = Guid.NewGuid().ToString(), Title = "Fifth item"},
                new FavMovie { Id = Guid.NewGuid().ToString(), Title = "Sixth item"}
            };
        }

        public async Task<bool> AddItemAsync(FavMovie fav)
        {
            favs.Add(fav);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(FavMovie fav)
        {
            var oldItem = favs.Where((FavMovie arg) => arg.Id == fav.Id).FirstOrDefault();
            favs.Remove(oldItem);
            favs.Add(fav);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = favs.Where((FavMovie arg) => arg.Id == id).FirstOrDefault();
            favs.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<FavMovie> GetItemAsync(string id)
        {
            return await Task.FromResult(favs.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<FavMovie>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(favs);
        }

        Task IDataStore<FavMovie>.AddItemAsync(FavMovie newFavMovie)
        {
            throw new NotImplementedException();
        }
    }
}
