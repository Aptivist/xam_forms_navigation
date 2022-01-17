using System;
using System.Collections.Generic;
using NavigationPatternsApp.ViewModels;
using Xamarin.Forms;

namespace NavigationPatternsApp
{
    public partial class NoteDetailMVVMPage : ContentPage
    {
        public NoteDetailMVVMPage()
        {
            InitializeComponent();
            BindingContext = new NoteDetailViewModel();
        }
    }
}
