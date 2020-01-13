using finalproject.Models;
using finalproject.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace finalproject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LikedMovie : ContentPage
    {
        FavMoviesViewModel viewModel;

        public LikedMovie()
        {
            InitializeComponent();

            BindingContext = viewModel = new FavMoviesViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as FavMovie;
            if (item == null)
                return;

            await DisplayAlert("", "", "OK", "Cancel");

            // Manually deselect item.
            ItemsListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("OOOPSS!", "This area not completed but don't worry we will working on it!", "OK", "Cancel");
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.FavMovies.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}
