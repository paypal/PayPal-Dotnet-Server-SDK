// <copyright file="VenmoPaymentTokenUsagePattern.cs" company="APIMatic">
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
    /// VenmoPaymentTokenUsagePattern.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum VenmoPaymentTokenUsagePattern
    {
        /// <summary>
        /// Immediate.
        /// </summary>
        [EnumMember(Value = "IMMEDIATE")]
        Immediate,

        /// <summary>
        /// Deferred.
        /// </summary>
        [EnumMember(Value = "DEFERRED")]
        Deferred,

        /// <summary>
        /// RecurringPrepaid.
        /// </summary>
        [EnumMember(Value = "RECURRING_PREPAID")]
        RecurringPrepaid,

        /// <summary>
        /// RecurringPostpaid.
        /// </summary>
        [EnumMember(Value = "RECURRING_POSTPAID")]
        RecurringPostpaid,

        /// <summary>
        /// ThresholdPrepaid.
        /// </summary>
        [EnumMember(Value = "THRESHOLD_PREPAID")]
        ThresholdPrepaid,

        /// <summary>
        /// ThresholdPostpaid.
        /// </summary>
        [EnumMember(Value = "THRESHOLD_POSTPAID")]
        ThresholdPostpaid,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}