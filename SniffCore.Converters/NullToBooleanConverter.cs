//
// Copyright (c) David Wendland. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
//

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
            if (parameter is NullToBooleanDirection booleanDirection)
                direction = booleanDirection;

            if (value == null)
                return direction != NullToBooleanDirection.NullIsFalse;

            return direction == NullToBooleanDirection.NullIsFalse;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}