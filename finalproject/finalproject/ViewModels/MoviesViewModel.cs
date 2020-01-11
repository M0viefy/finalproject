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

        private ObservableCollection<MoviesModel> _movies;

        private string _pageTitle;
        public MoviesViewModel()
        {
            _pageTitle = "MoviesViewModel";
            _movies = new ObservableCollection<MoviesModel>();
            _movies.Add(new MoviesModel { Title = "Mr. and Mrs. Smith", ImagePath = "" });
            _movies.Add(new MoviesModel { Title = "Mr. and Mrs. Smith", ImagePath = "" });
            _movies.Add(new MoviesModel { Title = "Mr. and Mrs. Smith", ImagePath = "" });
            _movies.Add(new MoviesModel { Title = "Mr. and Mrs. Smith", ImagePath = "" });
        }
    }
}
