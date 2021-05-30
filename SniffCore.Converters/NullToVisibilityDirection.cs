//
// Copyright (c) David Wendland. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
//

namespace SniffCore.Converters
{
    /// <summary>
    ///     Represents the direction to be used in the <see cref="NullToVisibilityConverter" />.
    /// </summary>
    public enum NullToVisibilityDirection
    {
        /// <summary>
        ///     The the value is null, it returns visible; otherwise collapsed.
        /// </summary>
        /// <remarks>
        /// Null: Visible;
        /// Not Null: Collapsed
        /// </remarks>
        NullIsVisible,

        /// <summary>
        ///     The the value is null, it returns visible; otherwise hidden.
        /// </summary>
        /// <remarks>
        /// Null: Visible;
        /// Not Null: Hidden
        /// </remarks>
        NotNullIsHidden,

        /// <summary>
        ///     If the value is null, it returns collapsed; otherwise visible.
        /// </summary>
        /// <remarks>
        /// Null: Collapsed;
        /// Not Null: Visible
        /// </remarks>
        NullIsCollapsed,

        /// <summary>
        ///     If the value is null, it return hidden; otherwise visible.
        /// </summary>
        /// <remarks>
        /// Null: Hidden;
        /// Not Null: Visible
        /// </remarks>
        NullIsHidden
    }
}