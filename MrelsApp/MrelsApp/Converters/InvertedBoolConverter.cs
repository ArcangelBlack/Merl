using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MrelsApp.Converters
{
    public class InvertedBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return !(bool)value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return (bool)value;
        }
    }
}
