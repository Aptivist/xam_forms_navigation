using System;
using System.Globalization;
using Xamarin.Forms;

namespace NavigationPatternsApp.Converters
{
    public class NumberToCelsius : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var celcius = $"{value} {parameter}";
            return celcius;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
