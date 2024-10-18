// <copyright file="CheckoutPaymentIntent.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using PaypalServerSdk.Standard;
using PaypalServerSdk.Standard.Utilities;

namespace PaypalServerSdk.Standard.Models
{
    /// <summary>
    /// CheckoutPaymentIntent.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum CheckoutPaymentIntent
    {
        /// <summary>
        /// Capture.
        /// </summary>
        [EnumMember(Value = "CAPTURE")]
        Capture,

        /// <summary>
        /// Authorize.
        /// </summary>
        [EnumMember(Value = "AUTHORIZE")]
        Authorize,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}