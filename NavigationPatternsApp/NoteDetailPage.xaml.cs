using System;
using System.Collections.Generic;
using NavigationPatternsApp.Models;
using Xamarin.Forms;

namespace NavigationPatternsApp
{
    public partial class NoteDetailPage : ContentPage
    {
        public NoteDetailPage()
        {
            InitializeComponent();
        }

        void OnSaveClicked(System.Object sender, System.EventArgs e)
        {
            /*
            var myNote = new Note();
            myNote.Title = titleEntry.Text;
            myNote.Detail = detailEntry.Text;
            */
            var product = new Product();
            //product.ProductName = titleEntry.Text;
            //product.Description = detailEntry.Text;
            Navigation.PushAsync(new MainPage());
            var x = new StackLayout();
            //x.it
            //TODO: save somewhere
           // DisplayAlert("My Note", $"Product Saved: {product.Description}", "OK");
        }
    }
}
