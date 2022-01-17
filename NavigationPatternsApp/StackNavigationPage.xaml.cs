using System;
using System.Collections.Generic;
using NavigationPatternsApp.Interfaces;
using NavigationPatternsApp.Pages;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace NavigationPatternsApp
{
    public partial class StackNavigationPage : ContentPage
    {
        public StackNavigationPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            //Navigation.PushAsync(new MainPage());
            Navigation.PushModalAsync(new MainPage());
            /*if (!string.IsNullOrEmpty(phoneEntry.Text))
            {
                var service = DependencyService.Get<IPhoneDialer>();
                service.Call(phoneEntry.Text);
            }
            else
            {
                this.DisplayAlert(title: "oops", message:"Empty phone", cancel:"OK");
            }*/
        }
    }
}
