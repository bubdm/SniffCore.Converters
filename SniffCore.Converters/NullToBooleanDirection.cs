//
// Copyright (c) David Wendland. All rights reserved.
// Licensed under the MIT License. See LICENSE file in the project root for full license information.
//

namespace SniffCore.Converters
{
    /// <summary>
    ///     Represents the direction to be used in the <see cref="NullToBooleanConverter" />.
    /// </summary>
    public enum NullToBooleanDirection
    {
        /// <summary>
        ///     If the value is null, it returns true; otherwise false.
        /// </summary>
        NullIsTrue,

        /// <summary>
        ///     If the value is null, it returns false; otherwise true
        /// </summary>
        NullIsFalse
    }
}