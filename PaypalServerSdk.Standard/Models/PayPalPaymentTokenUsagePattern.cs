// <copyright file="PaypalPaymentTokenUsagePattern.cs" company="APIMatic">
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
    /// PaypalPaymentTokenUsagePattern.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PaypalPaymentTokenUsagePattern
    {
        /// <summary>
        /// IMMEDIATE.
        /// </summary>
        [EnumMember(Value = "IMMEDIATE")]
        IMMEDIATE,

        /// <summary>
        /// DEFERRED.
        /// </summary>
        [EnumMember(Value = "DEFERRED")]
        DEFERRED,

        /// <summary>
        /// RECURRINGPREPAID.
        /// </summary>
        [EnumMember(Value = "RECURRING_PREPAID")]
        RECURRINGPREPAID,

        /// <summary>
        /// RECURRINGPOSTPAID.
        /// </summary>
        [EnumMember(Value = "RECURRING_POSTPAID")]
        RECURRINGPOSTPAID,

        /// <summary>
        /// THRESHOLDPREPAID.
        /// </summary>
        [EnumMember(Value = "THRESHOLD_PREPAID")]
        THRESHOLDPREPAID,

        /// <summary>
        /// THRESHOLDPOSTPAID.
        /// </summary>
        [EnumMember(Value = "THRESHOLD_POSTPAID")]
        THRESHOLDPOSTPAID,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}