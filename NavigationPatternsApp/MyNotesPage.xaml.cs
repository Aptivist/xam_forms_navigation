using System;
using System.Collections.Generic;
using NavigationPatternsApp.Models;
using NavigationPatternsApp.ViewModels;
using Xamarin.Forms;

namespace NavigationPatternsApp
{
    public partial class MyNotesPage : ContentPage
    {
        public MyNotesPage()
        {
            InitializeComponent();
            BindingContext = new MyNotesViewModel(Navigation);
        }
        /*
        void myList_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var item = e.Item as City;
            //DisplayAlert("Selected", $"CIty: {item.Name}", "OK");
            Navigation.PushAsync(new CityDetail(item));
        }
        */
    }
}
