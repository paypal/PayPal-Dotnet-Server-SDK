// <copyright file="AuthorizationIncompleteReason.cs" company="APIMatic">
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
    /// AuthorizationIncompleteReason.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum AuthorizationIncompleteReason
    {
        /// <summary>
        ///Authorization is pending manual review.
        /// PendingReview.
        /// </summary>
        [EnumMember(Value = "PENDING_REVIEW")]
        PendingReview,

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