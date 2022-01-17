using System;
using System.Collections.Generic;
using NavigationPatternsApp.Models;
using Xamarin.Forms;

namespace NavigationPatternsApp
{
    public partial class MyHomePage : ContentPage
    {
        public const string MyItemId = "item";
        public MyHomePage()
        {
            InitializeComponent();
            MessagingCenter.Instance.Subscribe<MyDetailPage, FlyoutPageItem>(this, MyItemId, OnMessageReceived);
            MessagingCenter.Instance.Subscribe<MyDetailPage, string>(this, "updateMessage", OnMessageReceived);
        }

        private void OnMessageReceived(MyDetailPage provider, string message)
        {
            mylabel.Text = message;
        }

        private void OnMessageReceived(MyDetailPage provider, FlyoutPageItem message)
        {
            myentry.Text = message.Title;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            App app = (App) App.Current;
            app.Logout();
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MyDetailPage());
        }
    }
}
