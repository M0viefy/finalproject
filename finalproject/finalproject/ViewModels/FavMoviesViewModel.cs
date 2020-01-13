using finalproject.Models;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace finalproject.ViewModels
{
    public class FavMoviesViewModel : BaseViewModel
    {
        public ObservableCollection<FavMovie> FavMovies { get; set; }
        public Command LoadItemsCommand { get; set; }

        public FavMoviesViewModel()
        {
            Title = "Browse";
            FavMovies = new ObservableCollection<FavMovie>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<TabbedPage1, FavMovie>(this, "AddItem", async (obj, item) =>
            {
                var newFavMovie= item as FavMovie;
                FavMovies.Add(newFavMovie);
                await DataStore.AddItemAsync(newFavMovie);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                FavMovies.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    FavMovies.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
