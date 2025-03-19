// <copyright file="AuthorizationStatus.cs" company="APIMatic">
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
    /// AuthorizationStatus.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum AuthorizationStatus
    {
        /// <summary>
        ///The authorized payment is created. No captured payments have been made for this authorized payment.
        /// Created.
        /// </summary>
        [EnumMember(Value = "CREATED")]
        Created,

        /// <summary>
        ///The authorized payment has one or more captures against it. The sum of these captured payments is greater than the amount of the original authorized payment.
        /// Captured.
        /// </summary>
        [EnumMember(Value = "CAPTURED")]
        Captured,

        /// <summary>
        ///PayPal cannot authorize funds for this authorized payment.
        /// Denied.
        /// </summary>
        [EnumMember(Value = "DENIED")]
        Denied,

        /// <summary>
        ///A captured payment was made for the authorized payment for an amount that is less than the amount of the original authorized payment.
        /// PartiallyCaptured.
        /// </summary>
        [EnumMember(Value = "PARTIALLY_CAPTURED")]
        PartiallyCaptured,

        /// <summary>
        ///The authorized payment was voided. No more captured payments can be made against this authorized payment.
        /// Voided.
        /// </summary>
        [EnumMember(Value = "VOIDED")]
        Voided,

        /// <summary>
        ///The created authorization is in pending state. For more information, see status.details.
        /// Pending.
        /// </summary>
        [EnumMember(Value = "PENDING")]
        Pending,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}