using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace finalproject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThrillerMoviePage : ContentPage
    {
        public ThrillerMoviePage()
        {
            InitializeComponent();
        }

        private void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}