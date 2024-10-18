// <copyright file="CaptureStatus.cs" company="APIMatic">
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
    /// CaptureStatus.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum CaptureStatus
    {
        /// <summary>
        /// Completed.
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        Completed,

        /// <summary>
        /// Declined.
        /// </summary>
        [EnumMember(Value = "DECLINED")]
        Declined,

        /// <summary>
        /// PartiallyRefunded.
        /// </summary>
        [EnumMember(Value = "PARTIALLY_REFUNDED")]
        PartiallyRefunded,

        /// <summary>
        /// Pending.
        /// </summary>
        [EnumMember(Value = "PENDING")]
        Pending,

        /// <summary>
        /// Refunded.
        /// </summary>
        [EnumMember(Value = "REFUNDED")]
        Refunded,

        /// <summary>
        /// Failed.
        /// </summary>
        [EnumMember(Value = "FAILED")]
        Failed,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}