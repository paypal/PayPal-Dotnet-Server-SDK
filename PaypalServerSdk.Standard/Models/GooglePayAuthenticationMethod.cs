// <copyright file="GooglePayAuthenticationMethod.cs" company="APIMatic">
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
    /// GooglePayAuthenticationMethod.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum GooglePayAuthenticationMethod
    {
        /// <summary>
        /// PanOnly.
        /// </summary>
        [EnumMember(Value = "PAN_ONLY")]
        PanOnly,

        /// <summary>
        /// Cryptogram3Ds.
        /// </summary>
        [EnumMember(Value = "CRYPTOGRAM_3DS")]
        Cryptogram3Ds,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}