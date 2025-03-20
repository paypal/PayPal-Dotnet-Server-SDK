// <copyright file="OrderApplicationContextShippingPreference.cs" company="APIMatic">
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
    /// OrderApplicationContextShippingPreference.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum OrderApplicationContextShippingPreference
    {
        /// <summary>
        ///Use the customer-provided shipping address on the PayPal site.
        /// GetFromFile.
        /// </summary>
        [EnumMember(Value = "GET_FROM_FILE")]
        GetFromFile,

        /// <summary>
        ///Redact the shipping address from the PayPal site. Recommended for digital goods.
        /// NoShipping.
        /// </summary>
        [EnumMember(Value = "NO_SHIPPING")]
        NoShipping,

        /// <summary>
        ///Use the merchant-provided address. The customer cannot change this address on the PayPal site.
        /// SetProvidedAddress.
        /// </summary>
        [EnumMember(Value = "SET_PROVIDED_ADDRESS")]
        SetProvidedAddress,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}