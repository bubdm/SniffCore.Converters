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
    ///     Converts a boolean to is opposite.
    /// </summary>
    /// <example>
    ///     <code lang="xaml">
    /// <![CDATA[
    /// <Window xmlns:sniffcore="http://sniffcore.com">
    ///     <Window.Resources>
    ///         <sniffcore:InverseBooleanConverter x:Key="InverseBooleanConverter" />
    ///     </Window.Resources>
    ///     
    ///     <StackPanel>
    ///         <CheckBox IsChecked="{Binding IsUnchecked, Converter={StaticResource InverseBooleanConverter}}" />
    ///     </StackPanel>
    /// </Window>
    /// ]]>
    ///     </code>
    /// </example>
    [ValueConversion(typeof(bool), typeof(bool))]
    public sealed class InverseBooleanConverter : IValueConverter
    {
        /// <summary>
        ///     Converts the value as boolean to its opposite.
        /// </summary>
        /// <param name="value">The value to invert.</param>
        /// <param name="targetType">unused</param>
        /// <param name="parameter">unused</param>
        /// <param name="culture">unused</param>
        /// <returns>False if the value is true; otherwise true.</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool tmp1)
                return !tmp1;
            return true;
        }

        /// <summary>
        ///     Converts the value as boolean to its opposite.
        /// </summary>
        /// <param name="value">The value to invert.</param>
        /// <param name="targetType">unused</param>
        /// <param name="parameter">unused</param>
        /// <param name="culture">unused</param>
        /// <returns>False if the value is true; otherwise true.</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Convert(value, targetType, parameter, culture);
        }
    }
}