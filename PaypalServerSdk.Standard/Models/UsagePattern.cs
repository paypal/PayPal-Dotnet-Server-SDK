// <copyright file="UsagePattern.cs" company="APIMatic">
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
    /// UsagePattern.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum UsagePattern
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
        ///Subscription plan where the "amount due" and the "billing frequency" are fixed, and there is no defined duration with the payment due before the good/service is delivered.
        /// SubscriptionPrepaid.
        /// </summary>
        [EnumMember(Value = "SUBSCRIPTION_PREPAID")]
        SubscriptionPrepaid,

        /// <summary>
        ///Subscription plan where the "amount due" and the "billing frequency" are fixed, and there is no defined duration with the payment due after the goods/services are delivered.
        /// SubscriptionPostpaid.
        /// </summary>
        [EnumMember(Value = "SUBSCRIPTION_POSTPAID")]
        SubscriptionPostpaid,

        /// <summary>
        ///Unscheduled card on file plan where the merchant can bill buyer upfront based on an agreed logic, but "amount due" and "frequency" can vary. Inclusive of automatic reload plans.
        /// UnscheduledPrepaid.
        /// </summary>
        [EnumMember(Value = "UNSCHEDULED_PREPAID")]
        UnscheduledPrepaid,

        /// <summary>
        ///Unscheduled card on file plan where the merchant can bill buyer based on an agreed logic, but "amount due" and "frequency" can vary. Inclusive of automatic reload plans.
        /// UnscheduledPostpaid.
        /// </summary>
        [EnumMember(Value = "UNSCHEDULED_POSTPAID")]
        UnscheduledPostpaid,

        /// <summary>
        ///Merchant-managed installment plan when the "amount" to be paid and the "billing frequency" are fixed, but there is a defined number of payments with the payment due before the good/service is delivered.
        /// InstallmentPrepaid.
        /// </summary>
        [EnumMember(Value = "INSTALLMENT_PREPAID")]
        InstallmentPrepaid,

        /// <summary>
        ///Merchant-managed installment plan when the "amount" to be paid and the "billing frequency" are fixed, but there is a defined number of payments with the payment due after the goods/services are delivered.
        /// InstallmentPostpaid.
        /// </summary>
        [EnumMember(Value = "INSTALLMENT_POSTPAID")]
        InstallmentPostpaid,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}