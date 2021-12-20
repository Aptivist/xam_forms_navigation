using System;
using Foundation;
using NavigationPatternsApp.Interfaces;
using NavigationPatternsApp.iOS.Services;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(PhoneDialer))]
namespace NavigationPatternsApp.iOS.Services
{
    public class PhoneDialer : IPhoneDialer
    {
        public void Call(string number)
        {
            var phoneUrl = $"telprompt://{number}";
            UIApplication.SharedApplication.OpenUrl(new NSUrl(phoneUrl));
        }
    }
}
