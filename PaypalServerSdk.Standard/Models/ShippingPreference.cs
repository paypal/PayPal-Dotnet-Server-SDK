// <copyright file="ShippingPreference.cs" company="APIMatic">
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
    /// ShippingPreference.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum ShippingPreference
    {
        /// <summary>
        ///Get the customer-provided shipping address on the PayPal site.
        /// GetFromFile.
        /// </summary>
        [EnumMember(Value = "GET_FROM_FILE")]
        GetFromFile,

        /// <summary>
        ///Redacts the shipping address from the PayPal site. Recommended for digital goods.
        /// NoShipping.
        /// </summary>
        [EnumMember(Value = "NO_SHIPPING")]
        NoShipping,

        /// <summary>
        ///Get the merchant-provided address. The customer cannot change this address on the PayPal site. If merchant does not pass an address, customer can choose the address on PayPal pages.
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