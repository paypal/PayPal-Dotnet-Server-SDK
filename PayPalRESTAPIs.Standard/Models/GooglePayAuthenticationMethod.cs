// <copyright file="GooglePayAuthenticationMethod.cs" company="APIMatic">
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
    /// GooglePayAuthenticationMethod.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum GooglePayAuthenticationMethod
    {
        /// <summary>
        /// PANONLY.
        /// </summary>
        [EnumMember(Value = "PAN_ONLY")]
        PANONLY,

        /// <summary>
        /// CRYPTOGRAM3DS.
        /// </summary>
        [EnumMember(Value = "CRYPTOGRAM_3DS")]
        CRYPTOGRAM3DS,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}