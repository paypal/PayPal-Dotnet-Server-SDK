// <copyright file="AuthorizationIncompleteReason.cs" company="APIMatic">
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
    /// AuthorizationIncompleteReason.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum AuthorizationIncompleteReason
    {
        /// <summary>
        /// PENDINGREVIEW.
        /// </summary>
        [EnumMember(Value = "PENDING_REVIEW")]
        PENDINGREVIEW,

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