using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace SniffCore.Converters
{
    public sealed class BooleanToVisibilityInvertedConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var bValue = false;
            if (value is bool)
            {
                bValue = (bool) value;
            }
            else if (value is bool?)
            {
                var tmp = (bool?) value;
                bValue = tmp.HasValue ? tmp.Value : false;
            }

            return bValue ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is Visibility)
                return (Visibility) value == Visibility.Collapsed;
            return false;
        }
    }
}