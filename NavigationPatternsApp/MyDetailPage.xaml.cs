using System;
using System.Collections.Generic;
using NavigationPatternsApp.Models;
using Xamarin.Forms;

namespace NavigationPatternsApp
{
    public partial class MyDetailPage : ContentPage
    {
        public MyDetailPage()
        {
            InitializeComponent();
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var messageValue = myEntry.Text;
            MessagingCenter.Instance.Send(this, "updateMessage", messageValue);
            Navigation.PopAsync();
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            var item = new FlyoutPageItem();
            item.Title = myEntry.Text;
            MessagingCenter.Instance.Send(this, MyHomePage.MyItemId, item);
            Navigation.PopAsync();
        }
    }
}
