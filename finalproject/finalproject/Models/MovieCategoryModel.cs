using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace finalproject.Models
{
    class MovieCategoryModel
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public ImageSource ImageSource { get; set; }

        public ICollection<MoviesModel> MoviesModels { get; set; }
    }
    
}
