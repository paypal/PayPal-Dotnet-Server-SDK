// <copyright file="StoredPaymentSourcePaymentType.cs" company="APIMatic">
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
    /// StoredPaymentSourcePaymentType.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum StoredPaymentSourcePaymentType
    {
        /// <summary>
        /// OneTime.
        /// </summary>
        [EnumMember(Value = "ONE_TIME")]
        OneTime,

        /// <summary>
        /// Recurring.
        /// </summary>
        [EnumMember(Value = "RECURRING")]
        Recurring,

        /// <summary>
        /// Unscheduled.
        /// </summary>
        [EnumMember(Value = "UNSCHEDULED")]
        Unscheduled,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}