//
// Copyright (c) David Wendland. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
//

using System;
using System.Globalization;
using System.Windows.Data;

namespace SniffCore.Converters
{
    public sealed class InverseBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool tmp1)
                return !tmp1;
            return true;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Convert(value, targetType, parameter, culture);
        }
    }
}