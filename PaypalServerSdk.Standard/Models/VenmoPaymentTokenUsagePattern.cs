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
        ///On-demand instant payments – non-recurring, pre-paid, variable amount, variable frequency.
        /// Immediate.
        /// </summary>
        [EnumMember(Value = "IMMEDIATE")]
        Immediate,

        /// <summary>
        ///Pay after use, non-recurring post-paid, variable amount, irregular frequency.
        /// Deferred.
        /// </summary>
        [EnumMember(Value = "DEFERRED")]
        Deferred,

        /// <summary>
        ///Pay upfront fixed or variable amount on a fixed date before the goods/service is delivered.
        /// RecurringPrepaid.
        /// </summary>
        [EnumMember(Value = "RECURRING_PREPAID")]
        RecurringPrepaid,

        /// <summary>
        ///Pay on a fixed date based on usage or consumption after the goods/service is delivered.
        /// RecurringPostpaid.
        /// </summary>
        [EnumMember(Value = "RECURRING_POSTPAID")]
        RecurringPostpaid,

        /// <summary>
        ///Charge payer when the set amount is reached or monthly billing cycle, whichever comes first, before the goods/service is delivered.
        /// ThresholdPrepaid.
        /// </summary>
        [EnumMember(Value = "THRESHOLD_PREPAID")]
        ThresholdPrepaid,

        /// <summary>
        ///Charge payer when the set amount is reached or monthly billing cycle, whichever comes first, after the goods/service is delivered.
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