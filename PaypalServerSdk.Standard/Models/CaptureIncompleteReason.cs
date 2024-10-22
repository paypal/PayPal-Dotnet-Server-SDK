// <copyright file="CaptureIncompleteReason.cs" company="APIMatic">
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
    /// CaptureIncompleteReason.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum CaptureIncompleteReason
    {
        /// <summary>
        /// BuyerComplaint.
        /// </summary>
        [EnumMember(Value = "BUYER_COMPLAINT")]
        BuyerComplaint,

        /// <summary>
        /// Chargeback.
        /// </summary>
        [EnumMember(Value = "CHARGEBACK")]
        Chargeback,

        /// <summary>
        /// Echeck.
        /// </summary>
        [EnumMember(Value = "ECHECK")]
        Echeck,

        /// <summary>
        /// InternationalWithdrawal.
        /// </summary>
        [EnumMember(Value = "INTERNATIONAL_WITHDRAWAL")]
        InternationalWithdrawal,

        /// <summary>
        /// Other.
        /// </summary>
        [EnumMember(Value = "OTHER")]
        Other,

        /// <summary>
        /// PendingReview.
        /// </summary>
        [EnumMember(Value = "PENDING_REVIEW")]
        PendingReview,

        /// <summary>
        /// ReceivingPreferenceMandatesManualAction.
        /// </summary>
        [EnumMember(Value = "RECEIVING_PREFERENCE_MANDATES_MANUAL_ACTION")]
        ReceivingPreferenceMandatesManualAction,

        /// <summary>
        /// Refunded.
        /// </summary>
        [EnumMember(Value = "REFUNDED")]
        Refunded,

        /// <summary>
        /// TransactionApprovedAwaitingFunding.
        /// </summary>
        [EnumMember(Value = "TRANSACTION_APPROVED_AWAITING_FUNDING")]
        TransactionApprovedAwaitingFunding,

        /// <summary>
        /// Unilateral.
        /// </summary>
        [EnumMember(Value = "UNILATERAL")]
        Unilateral,

        /// <summary>
        /// VerificationRequired.
        /// </summary>
        [EnumMember(Value = "VERIFICATION_REQUIRED")]
        VerificationRequired,

        /// <summary>
        /// DeclinedByRiskFraudFilters.
        /// </summary>
        [EnumMember(Value = "DECLINED_BY_RISK_FRAUD_FILTERS")]
        DeclinedByRiskFraudFilters,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}