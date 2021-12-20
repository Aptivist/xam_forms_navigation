using System;
using System.Collections.Generic;
using NavigationPatternsApp.Interfaces;
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
            var service = DependencyService.Get<IPhoneDialer>();
            service.Call(phoneEntry.Text);
        }
    }
}
