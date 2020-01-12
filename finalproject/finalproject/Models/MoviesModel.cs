using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace finalproject.Models
{
    public class MoviesModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public ImageSource ImagePath { get; set; }
        public string Description { get; set; }
        public string TrailerUrl { get; set; }
    }
}
