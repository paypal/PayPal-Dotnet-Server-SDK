// <copyright file="PayPalPaymentTokenUsageType.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using PaypalServerSDK.Standard;
using PaypalServerSDK.Standard.Utilities;

namespace PaypalServerSDK.Standard.Models
{
    /// <summary>
    /// PayPalPaymentTokenUsageType.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PayPalPaymentTokenUsageType
    {
        /// <summary>
        /// MERCHANT.
        /// </summary>
        [EnumMember(Value = "MERCHANT")]
        MERCHANT,

        /// <summary>
        /// PLATFORM.
        /// </summary>
        [EnumMember(Value = "PLATFORM")]
        PLATFORM,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}