// <copyright file="CaptureStatus.cs" company="APIMatic">
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
    /// CaptureStatus.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum CaptureStatus
    {
        /// <summary>
        ///The funds for this captured payment were credited to the payee's PayPal account.
        /// Completed.
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        Completed,

        /// <summary>
        ///The funds could not be captured.
        /// Declined.
        /// </summary>
        [EnumMember(Value = "DECLINED")]
        Declined,

        /// <summary>
        ///An amount less than this captured payment's amount was partially refunded to the payer.
        /// PartiallyRefunded.
        /// </summary>
        [EnumMember(Value = "PARTIALLY_REFUNDED")]
        PartiallyRefunded,

        /// <summary>
        ///The funds for this captured payment was not yet credited to the payee's PayPal account. For more information, see status.details.
        /// Pending.
        /// </summary>
        [EnumMember(Value = "PENDING")]
        Pending,

        /// <summary>
        ///An amount greater than or equal to this captured payment's amount was refunded to the payer.
        /// Refunded.
        /// </summary>
        [EnumMember(Value = "REFUNDED")]
        Refunded,

        /// <summary>
        ///There was an error while capturing payment.
        /// Failed.
        /// </summary>
        [EnumMember(Value = "FAILED")]
        Failed,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}