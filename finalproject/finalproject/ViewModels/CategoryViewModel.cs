using finalproject.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;


namespace finalproject.ViewModel
{
    class CategoryViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<MovieCategoryModel> _categories;

        public CategoryViewModel()
        {
            _categories = new ObservableCollection<MovieCategoryModel>();
            _categories.Add(new MovieCategoryModel { CategoryID = 1, CategoryName = "Horror", ImageSource = "horror.png" });
            _categories.Add(new MovieCategoryModel { CategoryID = 2, CategoryName = "Science-Fiction", ImageSource = "horror.png" });
            _categories.Add(new MovieCategoryModel { CategoryID = 3, CategoryName = "Action", ImageSource = "horror.png" });
            _categories.Add(new MovieCategoryModel { CategoryID = 4, CategoryName = "Dram", ImageSource = "horror.png" });
            _categories.Add(new MovieCategoryModel { CategoryID = 5, CategoryName = "Comedy", ImageSource = "horror.png" });
            _categories.Add(new MovieCategoryModel { CategoryID = 6, CategoryName = "Adventure", ImageSource = "horror.png" });
            _categories.Add(new MovieCategoryModel { CategoryID = 7, CategoryName = "Marvel", ImageSource = "horror.png" });
        }

        public ObservableCollection<MovieCategoryModel> Categories
        {
            get
            {
                return _categories;
            }
            set
            {
                if(_categories != value)
                {
                    _categories = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Categories"));
                }
            }
        }

        private void OnPropertyChanged(PropertyChangedEventArgs eventArgs)
        {
            PropertyChanged?.Invoke(this, eventArgs);
        }
    }
}
