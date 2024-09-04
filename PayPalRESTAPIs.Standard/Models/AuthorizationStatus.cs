// <copyright file="AuthorizationStatus.cs" company="APIMatic">
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
    /// AuthorizationStatus.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum AuthorizationStatus
    {
        /// <summary>
        /// CREATED.
        /// </summary>
        [EnumMember(Value = "CREATED")]
        CREATED,

        /// <summary>
        /// CAPTURED.
        /// </summary>
        [EnumMember(Value = "CAPTURED")]
        CAPTURED,

        /// <summary>
        /// DENIED.
        /// </summary>
        [EnumMember(Value = "DENIED")]
        DENIED,

        /// <summary>
        /// PARTIALLYCAPTURED.
        /// </summary>
        [EnumMember(Value = "PARTIALLY_CAPTURED")]
        PARTIALLYCAPTURED,

        /// <summary>
        /// VOIDED.
        /// </summary>
        [EnumMember(Value = "VOIDED")]
        VOIDED,

        /// <summary>
        /// PENDING.
        /// </summary>
        [EnumMember(Value = "PENDING")]
        PENDING,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}