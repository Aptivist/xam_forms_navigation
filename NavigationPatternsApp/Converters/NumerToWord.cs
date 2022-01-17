using System;
using System.Globalization;
using Xamarin.Forms;

namespace NavigationPatternsApp.Converters
{
    public class NumerToWord : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            int myNumber = (int)value;

            if (myNumber <= 30)
            {
                return "Good";
            }
            else if (myNumber <= 40)
            {
                return "Bad";
            }
            else
            {
                return "Worst";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var word = (string) value;
            switch (word)
            {
                case "Good":
                    return 20;
                case "Bad":
                    return 35;
                case "Worst":
                    return 100;
                default:
                    return 0;
            }
        }
    }
}
