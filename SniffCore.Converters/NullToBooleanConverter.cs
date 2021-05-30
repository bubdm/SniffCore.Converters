//
// Copyright (c) David Wendland. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
//

using System;
using System.Globalization;
using System.Windows.Data;

namespace SniffCore.Converters
{
    /// <summary>
    ///     Converts the null or not null value to bool with an optional direction parameter.
    /// </summary>
    /// <example>
    ///     <code lang="xaml">
    /// <![CDATA[
    /// <Window xmlns:sniffcore="http://sniffcore.com">
    ///     <Window.Resources>
    ///         <sniffcore:NullToBooleanConverter x:Key="NullToBooleanConverter" />
    ///     </Window.Resources>
    ///     
    ///     <StackPanel>
    ///         <CheckBox IsChecked="{Binding Object, Converter={StaticResource NullToBooleanConverter}, ConverterParameter={x:Static sniffcore:NullToBooleanDirection.NullIsTrue}}" />
    ///     </StackPanel>
    /// </Window>
    /// ]]>
    ///     </code>
    /// </example>
    [ValueConversion(typeof(object), typeof(bool), ParameterType = typeof(NullToBooleanDirection))]
    public sealed class NullToBooleanConverter : IValueConverter
    {
        /// <summary>
        ///     Converts the value null or not null to true or false.
        /// </summary>
        /// <param name="value">The object value to convert.</param>
        /// <param name="targetType">unused</param>
        /// <param name="parameter">
        ///     [Optional] <see cref="NullToBooleanDirection" />.
        ///     <see cref="NullToBooleanDirection.NullIsFalse" /> if not set.
        /// </param>
        /// <param name="culture">unused</param>
        /// <returns>If NullIsFalse false is returned if the value is null; otherwise opposite.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var direction = NullToBooleanDirection.NullIsFalse;
            if (parameter is NullToBooleanDirection booleanDirection)
                direction = booleanDirection;

            if (value == null)
                return direction != NullToBooleanDirection.NullIsFalse;

            return direction == NullToBooleanDirection.NullIsFalse;
        }

        /// <summary>
        ///     Not Implemented.
        /// </summary>
        /// <param name="value">unused</param>
        /// <param name="targetType">unused</param>
        /// <param name="parameter">unused</param>
        /// <param name="culture">unused</param>
        /// <returns>Not implemented.</returns>
        /// <exception cref="NotImplementedException">The <see cref="ConvertBack" /> is not implemented.</exception>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}