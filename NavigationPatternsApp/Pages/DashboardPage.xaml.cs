using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationPatternsApp.Pages
{
    public partial class DashboardPage : ContentPage
    {
        public DashboardPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ItemsPage());
        }
    }
}
