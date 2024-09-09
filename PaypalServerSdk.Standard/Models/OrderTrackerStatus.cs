// <copyright file="OrderTrackerStatus.cs" company="APIMatic">
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
    /// OrderTrackerStatus.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum OrderTrackerStatus
    {
        /// <summary>
        /// CANCELLED.
        /// </summary>
        [EnumMember(Value = "CANCELLED")]
        CANCELLED,

        /// <summary>
        /// SHIPPED.
        /// </summary>
        [EnumMember(Value = "SHIPPED")]
        SHIPPED,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}