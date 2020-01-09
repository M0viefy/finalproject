using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace finalproject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        public TabbedPage1()
        {
            InitializeComponent();
        }

        private async void Horror_Clicked(object sender, EventArgs e)
        {
            //TapGestureRecognizer.NumberOfTapsRequiredProperty.Equals(2);
            await Navigation.PushAsync(new HorrorListPage());
        }

    }
}