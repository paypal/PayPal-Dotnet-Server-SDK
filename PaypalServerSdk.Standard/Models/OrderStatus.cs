// <copyright file="OrderStatus.cs" company="APIMatic">
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
    /// OrderStatus.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum OrderStatus
    {
        /// <summary>
        /// Created.
        /// </summary>
        [EnumMember(Value = "CREATED")]
        Created,

        /// <summary>
        /// Saved.
        /// </summary>
        [EnumMember(Value = "SAVED")]
        Saved,

        /// <summary>
        /// Approved.
        /// </summary>
        [EnumMember(Value = "APPROVED")]
        Approved,

        /// <summary>
        /// Voided.
        /// </summary>
        [EnumMember(Value = "VOIDED")]
        Voided,

        /// <summary>
        /// Completed.
        /// </summary>
        [EnumMember(Value = "COMPLETED")]
        Completed,

        /// <summary>
        /// PayerActionRequired.
        /// </summary>
        [EnumMember(Value = "PAYER_ACTION_REQUIRED")]
        PayerActionRequired,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}