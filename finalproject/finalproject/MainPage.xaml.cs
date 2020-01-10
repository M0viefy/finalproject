using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace finalproject
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //code in below row has provided hidin title bar 
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private async void SignInButton_OnClicked(object sender, EventArgs e)
        {
            string value = Preferences.Get(email.Text, "");

            if (password.Text == value)
            {
                    await Navigation.PushAsync(new TabbedPage1());
            }
            else
            {
                var result = await DisplayAlert("Login Process", "Username and Password Dismatch!", "", "CANCEL");
                if (result != true) // if it's equal to cancel
                {
                    return; // just return to the page and do nothing.
                }
            }
        }
        void OnTapSignUpLabel(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }

        void OnTapForgotPasswordLabel(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RenewPasswordPage());
        }
    }
}
