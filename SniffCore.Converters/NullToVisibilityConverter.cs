//
// Copyright (c) David Wendland. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
//

using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace SniffCore.Converters
{
    public sealed class NullToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var direction = NullToVisibilityDirection.NullIsCollapsed;
            if (parameter is NullToVisibilityDirection)
                direction = (NullToVisibilityDirection) parameter;

            if (value == null)
            {
                if (direction == NullToVisibilityDirection.NullIsCollapsed)
                    return Visibility.Collapsed;
                if (direction == NullToVisibilityDirection.NullIsHidden)
                    return Visibility.Hidden;
                return Visibility.Visible;
            }

            if (direction == NullToVisibilityDirection.NullIsCollapsed)
                return Visibility.Visible;
            if (direction == NullToVisibilityDirection.NullIsHidden)
                return Visibility.Visible;
            return Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}