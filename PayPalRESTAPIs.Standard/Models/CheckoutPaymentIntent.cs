// <copyright file="CheckoutPaymentIntent.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using PayPalRESTAPIs.Standard;
using PayPalRESTAPIs.Standard.Utilities;

namespace PayPalRESTAPIs.Standard.Models
{
    /// <summary>
    /// CheckoutPaymentIntent.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum CheckoutPaymentIntent
    {
        /// <summary>
        /// CAPTURE.
        /// </summary>
        [EnumMember(Value = "CAPTURE")]
        CAPTURE,

        /// <summary>
        /// AUTHORIZE.
        /// </summary>
        [EnumMember(Value = "AUTHORIZE")]
        AUTHORIZE,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}