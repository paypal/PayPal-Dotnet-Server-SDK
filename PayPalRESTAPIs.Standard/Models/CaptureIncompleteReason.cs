// <copyright file="CaptureIncompleteReason.cs" company="APIMatic">
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
    /// CaptureIncompleteReason.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum CaptureIncompleteReason
    {
        /// <summary>
        /// BUYERCOMPLAINT.
        /// </summary>
        [EnumMember(Value = "BUYER_COMPLAINT")]
        BUYERCOMPLAINT,

        /// <summary>
        /// CHARGEBACK.
        /// </summary>
        [EnumMember(Value = "CHARGEBACK")]
        CHARGEBACK,

        /// <summary>
        /// ECHECK.
        /// </summary>
        [EnumMember(Value = "ECHECK")]
        ECHECK,

        /// <summary>
        /// INTERNATIONALWITHDRAWAL.
        /// </summary>
        [EnumMember(Value = "INTERNATIONAL_WITHDRAWAL")]
        INTERNATIONALWITHDRAWAL,

        /// <summary>
        /// OTHER.
        /// </summary>
        [EnumMember(Value = "OTHER")]
        OTHER,

        /// <summary>
        /// PENDINGREVIEW.
        /// </summary>
        [EnumMember(Value = "PENDING_REVIEW")]
        PENDINGREVIEW,

        /// <summary>
        /// RECEIVINGPREFERENCEMANDATESMANUALACTION.
        /// </summary>
        [EnumMember(Value = "RECEIVING_PREFERENCE_MANDATES_MANUAL_ACTION")]
        RECEIVINGPREFERENCEMANDATESMANUALACTION,

        /// <summary>
        /// REFUNDED.
        /// </summary>
        [EnumMember(Value = "REFUNDED")]
        REFUNDED,

        /// <summary>
        /// TRANSACTIONAPPROVEDAWAITINGFUNDING.
        /// </summary>
        [EnumMember(Value = "TRANSACTION_APPROVED_AWAITING_FUNDING")]
        TRANSACTIONAPPROVEDAWAITINGFUNDING,

        /// <summary>
        /// UNILATERAL.
        /// </summary>
        [EnumMember(Value = "UNILATERAL")]
        UNILATERAL,

        /// <summary>
        /// VERIFICATIONREQUIRED.
        /// </summary>
        [EnumMember(Value = "VERIFICATION_REQUIRED")]
        VERIFICATIONREQUIRED,

        /// <summary>
        /// DECLINEDBYRISKFRAUDFILTERS.
        /// </summary>
        [EnumMember(Value = "DECLINED_BY_RISK_FRAUD_FILTERS")]
        DECLINEDBYRISKFRAUDFILTERS,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}