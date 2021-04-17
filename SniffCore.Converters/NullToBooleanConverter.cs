using System;
using System.Globalization;
using System.Windows.Data;

namespace SniffCore.Converters
{
    public sealed class NullToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var direction = NullToBooleanDirection.NullIsFalse;
            if (parameter is NullToBooleanDirection)
                direction = (NullToBooleanDirection) parameter;

            if (value == null)
            {
                if (direction == NullToBooleanDirection.NullIsFalse)
                    return false;
                return true;
            }

            if (direction == NullToBooleanDirection.NullIsFalse)
                return true;
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}