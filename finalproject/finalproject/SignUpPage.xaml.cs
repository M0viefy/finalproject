using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using finalproject;

namespace finalproject
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
        }
        private void Register_OnClicked(object sender, EventArgs e)
        {
            //Preferences.Set("mailaddress", "password");

            if (string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(password.Text))
                DisplayAlert("Empty Values", "Please enter E-mail address and Password", "OK");
            else
            {
                Preferences.Set(email.Text, password.Text);
                DisplayAlert("Sign Up Success", "", "Ok");
                Navigation.PushAsync(new MainPage());
            }
        }
    }
}