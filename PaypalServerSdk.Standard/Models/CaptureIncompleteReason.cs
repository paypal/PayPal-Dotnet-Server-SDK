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
        ///The payer initiated a dispute for this captured payment with PayPal.
        /// BuyerComplaint.
        /// </summary>
        [EnumMember(Value = "BUYER_COMPLAINT")]
        BuyerComplaint,

        /// <summary>
        ///The captured funds were reversed in response to the payer disputing this captured payment with the issuer of the financial instrument used to pay for this captured payment.
        /// Chargeback.
        /// </summary>
        [EnumMember(Value = "CHARGEBACK")]
        Chargeback,

        /// <summary>
        ///The payer paid by an eCheck that has not yet cleared.
        /// Echeck.
        /// </summary>
        [EnumMember(Value = "ECHECK")]
        Echeck,

        /// <summary>
        ///Visit your online account. In your **Account Overview**, accept and deny this payment.
        /// InternationalWithdrawal.
        /// </summary>
        [EnumMember(Value = "INTERNATIONAL_WITHDRAWAL")]
        InternationalWithdrawal,

        /// <summary>
        ///No additional specific reason can be provided. For more information about this captured payment, visit your account online or contact PayPal.
        /// Other.
        /// </summary>
        [EnumMember(Value = "OTHER")]
        Other,

        /// <summary>
        ///The captured payment is pending manual review.
        /// PendingReview.
        /// </summary>
        [EnumMember(Value = "PENDING_REVIEW")]
        PendingReview,

        /// <summary>
        ///The payee has not yet set up appropriate receiving preferences for their account. For more information about how to accept or deny this payment, visit your account online. This reason is typically offered in scenarios such as when the currency of the captured payment is different from the primary holding currency of the payee.
        /// ReceivingPreferenceMandatesManualAction.
        /// </summary>
        [EnumMember(Value = "RECEIVING_PREFERENCE_MANDATES_MANUAL_ACTION")]
        ReceivingPreferenceMandatesManualAction,

        /// <summary>
        ///The captured funds were refunded.
        /// Refunded.
        /// </summary>
        [EnumMember(Value = "REFUNDED")]
        Refunded,

        /// <summary>
        ///The payer must send the funds for this captured payment. This code generally appears for manual EFTs.
        /// TransactionApprovedAwaitingFunding.
        /// </summary>
        [EnumMember(Value = "TRANSACTION_APPROVED_AWAITING_FUNDING")]
        TransactionApprovedAwaitingFunding,

        /// <summary>
        ///The payee does not have a PayPal account.
        /// Unilateral.
        /// </summary>
        [EnumMember(Value = "UNILATERAL")]
        Unilateral,

        /// <summary>
        ///The payee's PayPal account is not verified.
        /// VerificationRequired.
        /// </summary>
        [EnumMember(Value = "VERIFICATION_REQUIRED")]
        VerificationRequired,

        /// <summary>
        ///Risk Filter set by the payee failed for the transaction.
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