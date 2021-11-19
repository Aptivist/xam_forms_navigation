using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationPatternsApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new HomeTabbedPage();
            //MainPage = new FlyoutNavigationPage();
            //MainPage = new NavigationPage(new StackNavigationPage());
            //MainPage = new HomeCarouselPage();
            MainPage = new HomeShellPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
