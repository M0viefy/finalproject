using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using finalproject.Models;

namespace finalproject.ViewModels
{
    public class MoviesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<MoviesModel> _movies;

        private string _pageTitle;
        public MoviesViewModel()
        {
            _pageTitle = "MoviesViewModel";
            _movies = new ObservableCollection<MoviesModel>();
            _movies.Add(new MoviesModel { ID = 1,Title = "Mr. and Mrs. Smith", ImagePath = "smith.png" });
            _movies.Add(new MoviesModel { ID = 2,Title = "8 Mile", ImagePath = "eightmile.png" });
            _movies.Add(new MoviesModel { ID = 3,Title = "Warrior", ImagePath = "warrior.png" });
            _movies.Add(new MoviesModel { ID = 4,Title = "Fast and Furious 8", ImagePath = "fast8.png" });
            _movies.Add(new MoviesModel { ID = 5,Title = "Jumanji", ImagePath = "jumanji.png" });
            _movies.Add(new MoviesModel { Title = "Mr. and Mrs. Smith", ImagePath = "smith.png" });
            _movies.Add(new MoviesModel { Title = "Mr. and Mrs. Smith", ImagePath = "smith.png" });
            _movies.Add(new MoviesModel { Title = "Mr. and Mrs. Smith", ImagePath = "smith.png" });

        }

        public ObservableCollection<MoviesModel> Movies
        {
            get
            {
                return _movies;
            }
            set
            {
                if(_movies != value)
                {
                    _movies = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Movies"));
                }
            }
        }

        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }
}
