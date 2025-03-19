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
        ///One Time payment such as online purchase or donation. (e.g. Checkout with one-click).
        /// OneTime.
        /// </summary>
        [EnumMember(Value = "ONE_TIME")]
        OneTime,

        /// <summary>
        ///Payment which is part of a series of payments with fixed or variable amounts, following a fixed time interval. (e.g. Subscription payments).
        /// Recurring.
        /// </summary>
        [EnumMember(Value = "RECURRING")]
        Recurring,

        /// <summary>
        ///Payment which is part of a series of payments that occur on a non-fixed schedule and/or have variable amounts. (e.g. Account Topup payments).
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