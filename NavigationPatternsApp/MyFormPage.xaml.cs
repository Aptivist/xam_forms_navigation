using System;
using System.Collections.Generic;
using NavigationPatternsApp.ViewModels;
using Xamarin.Forms;

namespace NavigationPatternsApp
{
    public partial class MyFormPage : ContentPage
    {
        public MyFormPage()
        {
            InitializeComponent();
            BindingContext = new MyFormViewModel();
        }
    }
}
