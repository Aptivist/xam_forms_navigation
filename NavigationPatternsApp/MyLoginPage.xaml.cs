using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationPatternsApp
{
    public partial class MyLoginPage : ContentPage
    {
        public MyLoginPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var app = (App) App.Current;

            app.ShowHomePage();
           // Navigation.PushAsync(new MyHomePage());
        }
    }
}
