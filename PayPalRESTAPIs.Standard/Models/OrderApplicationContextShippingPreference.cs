// <copyright file="OrderApplicationContextShippingPreference.cs" company="APIMatic">
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
    /// OrderApplicationContextShippingPreference.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum OrderApplicationContextShippingPreference
    {
        /// <summary>
        /// GETFROMFILE.
        /// </summary>
        [EnumMember(Value = "GET_FROM_FILE")]
        GETFROMFILE,

        /// <summary>
        /// NOSHIPPING.
        /// </summary>
        [EnumMember(Value = "NO_SHIPPING")]
        NOSHIPPING,

        /// <summary>
        /// SETPROVIDEDADDRESS.
        /// </summary>
        [EnumMember(Value = "SET_PROVIDED_ADDRESS")]
        SETPROVIDEDADDRESS,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}