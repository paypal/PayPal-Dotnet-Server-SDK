// <copyright file="OrderStatus.cs" company="APIMatic">
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
    /// OrderStatus.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum OrderStatus
    {
        /// <summary>
        /// CREATED.
        /// </summary>
        [EnumMember(Value = "CREATED")]
        CREATED,

        /// <summary>
        /// SAVED.
        /// </summary>
        [EnumMember(Value = "SAVED")]
        SAVED,

        /// <summary>
        /// APPROVED.
        /// </summary>
        [EnumMember(Value = "APPROVED")]
        APPROVED,

        /// <summary>
        /// VOIDED.
        /// </summary>
        [EnumMember(Value = "VOIDED")]
        VOIDED,

        /// <summary>
        /// COMPLETED.
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        COMPLETED,

        /// <summary>
        /// PAYERACTIONREQUIRED.
        /// </summary>
        [EnumMember(Value = "PAYER_ACTION_REQUIRED")]
        PAYERACTIONREQUIRED,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}