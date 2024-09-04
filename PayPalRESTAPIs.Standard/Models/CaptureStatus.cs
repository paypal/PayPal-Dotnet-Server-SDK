// <copyright file="CaptureStatus.cs" company="APIMatic">
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
    /// CaptureStatus.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum CaptureStatus
    {
        /// <summary>
        /// COMPLETED.
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        COMPLETED,

        /// <summary>
        /// DECLINED.
        /// </summary>
        [EnumMember(Value = "DECLINED")]
        DECLINED,

        /// <summary>
        /// PARTIALLYREFUNDED.
        /// </summary>
        [EnumMember(Value = "PARTIALLY_REFUNDED")]
        PARTIALLYREFUNDED,

        /// <summary>
        /// PENDING.
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,

        /// <summary>
        /// REFUNDED.
        /// </summary>
        [EnumMember(Value = "REFUNDED")]
        REFUNDED,

        /// <summary>
        /// FAILED.
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}