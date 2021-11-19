using System;
using System.Collections.Generic;
using NavigationPatternsApp.Pages;
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
            Navigation.PushAsync(new DashboardPage());
        }
    }
}
