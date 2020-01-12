using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using TabbedPage = Xamarin.Forms.TabbedPage;
using finalproject.ViewModels;

namespace finalproject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPage1 : TabbedPage
    {
        public TabbedPage1()
        {
            InitializeComponent();
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            BackgroundColor = Color.FromHex("#FF252526");
            BarBackgroundColor = Color.FromHex("#FF252526");
            BindingContext = new MoviesViewModel();
            SearchListView.ItemsSource = movies;

        }
        List<string> movies = new List<string>
        {
            "Interstealler" , "Up" , "Hannibal" , "Avengers:End Game" , "I am Legend"
        };
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var keyword = MainSearchBar.Text;
            SearchListView.ItemsSource =
                 movies.Where(name =>
                 name.ToLower().Contains(keyword.ToLower()));
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void Horror_Clicked(object sender, EventArgs e)
        {
            //TapGestureRecognizer.NumberOfTapsRequiredProperty.Equals(2);
            await Navigation.PushAsync(new HorrorListPage());
            
        }

        private async void Daily_MovieClicked(object sender, EventArgs e)
        {
            Xamarin.Forms.ImageButton imageButton = (Xamarin.Forms.ImageButton)sender;


            //string TrailerUrl = imageButton.CommandParameter.ToString();
            int ID = int.Parse(string.Format("{0}", imageButton.CommandParameter));
           
            string TrailerUrl = "";
            if (ID == 1)
            {
                TrailerUrl = "https://www.youtube.com/watch?v=CZ0B22z22pI";
                var ans = await DisplayAlert("Mr. and Mrs. Smith" + Title, "Sıradan bir evlilik yaşayan John ve Jane Smith'in hayatları gün geçtikçe daha sıkıcı bir hal almaktadır. " +
                    "Hayatlarındaki monotonluğu bozan tek şey; birbirlerine söyledikleri yalanlardır. Çift, aslında, birbirine rakip iki organizasyona tetikçi olarak çalışmaktadır."
                    , "Watch the trailer", "Back");
                if (ans == true)
                {
                    Device.OpenUri(new System.Uri(TrailerUrl));
                }
                else
                {
                   
                }
            }
            else if(ID == 2)
            {
                TrailerUrl = "https://www.youtube.com/watch?v=axGVrfwm9L4";
                var ans = await DisplayAlert("8 Mile" + Title, "Freestyle Rap Movie"
                  , "Watch the trailer", "Back");
                if (ans == true)
                {
                    Device.OpenUri(new System.Uri(TrailerUrl));
                }
                else
                {
                    
                }
            }
            else if(ID == 3)
            {
                TrailerUrl = "https://www.youtube.com/watch?v=I5kzcwcQA1Q";
                 var ans = await DisplayAlert("Warrior", "Tom Hardy Movie", "Watch the trailer", "Back");
                if (ans == true)
                {
                    Device.OpenUri(new System.Uri(TrailerUrl));
                }
                else
                {
                    
                }
            }
            else if (ID == 4)
            {
                TrailerUrl = "https://www.youtube.com/watch?v=-NTRVR7evUg";
                var ans = await DisplayAlert("Fast and Furious 8", "Faster and wilder! ", "Watch the trailer", "Back");
                if (ans == true)
                {
                    Device.OpenUri(new System.Uri(TrailerUrl));
                }
                else
                {
                    
                }
            }
            else if (ID == 5)
            {
                TrailerUrl = "https://www.youtube.com/watch?v=2QKg5SZ_35I";
                var ans = await DisplayAlert("Jumanji", "a Dwayne Johnson Movie", "Watch the trailer", "Back");
                if (ans == true)
                {
                    Device.OpenUri(new System.Uri(TrailerUrl));
                }
                else
                {

                }
            }




        }

        private void layer1_Clicked(object sender, EventArgs e)
        {

        }

        private void layer2_Clicked(object sender, EventArgs e)
        {

        }

        private void layer3_Clicked(object sender, EventArgs e)
        {

        }

        private void layer4_Clicked(object sender, EventArgs e)
        {

        }

        private void layer5_Clicked(object sender, EventArgs e)
        {

        }

        private void top20_Clicked(object sender, EventArgs e)
        {

        }
    }
}