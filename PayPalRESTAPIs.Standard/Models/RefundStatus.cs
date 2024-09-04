// <copyright file="RefundStatus.cs" company="APIMatic">
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
    /// RefundStatus.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum RefundStatus
    {
        /// <summary>
        /// CANCELLED.
        /// </summary>
        [EnumMember(Value = "CANCELLED")]
        CANCELLED,

        /// <summary>
        /// FAILED.
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED,

        /// <summary>
        /// PENDING.
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,

        /// <summary>
        /// COMPLETED.
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        COMPLETED,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}