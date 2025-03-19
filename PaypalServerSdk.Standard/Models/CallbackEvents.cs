// <copyright file="CallbackEvents.cs" company="APIMatic">
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
    /// CallbackEvents.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum CallbackEvents
    {
        /// <summary>
        ///When Buyer changes or selects the shipping address on the PayPal/Venmo buyer approval flow , PayPal/Venmo will call merchant with the callback URL to update order totals.
        /// ShippingAddress.
        /// </summary>
        [EnumMember(Value = "SHIPPING_ADDRESS")]
        ShippingAddress,

        /// <summary>
        ///When Buyer changes or selects the shipping options on the PayPal/Venmo buyer approval flow , PayPal/Venmo will call merchant with the callback URL to update order totals.
        /// ShippingOptions.
        /// </summary>
        [EnumMember(Value = "SHIPPING_OPTIONS")]
        ShippingOptions,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}