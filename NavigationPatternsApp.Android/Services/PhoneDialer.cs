using System;
using Android.Content;
using NavigationPatternsApp.Droid.Services;
using NavigationPatternsApp.Interfaces;
using Xamarin.Forms;

//[assembly: Dependency(typeof(PhoneDialer))]
namespace NavigationPatternsApp.Droid.Services
{
    public class PhoneDialer : IPhoneDialer
    {
        private Context _context;

        public PhoneDialer(Context context)
        {
            _context = context;
        }

        public void Call(string number)
        {
            Intent intent = new Intent(Intent.ActionCall);
            intent.SetData(Android.Net.Uri.Parse($"tel: {number}"));
            _context.StartActivity(intent);
        }
    }
}
