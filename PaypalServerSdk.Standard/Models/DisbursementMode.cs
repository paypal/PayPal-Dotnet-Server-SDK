// <copyright file="DisbursementMode.cs" company="APIMatic">
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
    /// DisbursementMode.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum DisbursementMode
    {
        /// <summary>
        /// INSTANT.
        /// </summary>
        [EnumMember(Value = "INSTANT")]
        INSTANT,

        /// <summary>
        /// DELAYED.
        /// </summary>
        [EnumMember(Value = "DELAYED")]
        DELAYED,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}