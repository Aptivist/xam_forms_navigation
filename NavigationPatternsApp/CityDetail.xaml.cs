using System;
using System.Collections.Generic;
using NavigationPatternsApp.Models;
using Xamarin.Forms;

namespace NavigationPatternsApp
{
    public partial class CityDetail : ContentPage
    {
        public CityDetail(City city)
        {
            InitializeComponent();
            Title = city.Name;
            cityImage.Source = ImageSource.FromUri(new Uri(city.Url));
        }
    }
}
