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
        /// Created.
        /// </summary>
        [EnumMember(Value = "CREATED")]
        Created,

        /// <summary>
        /// Captured.
        /// </summary>
        [EnumMember(Value = "CAPTURED")]
        Captured,

        /// <summary>
        /// Denied.
        /// </summary>
        [EnumMember(Value = "DENIED")]
        Denied,

        /// <summary>
        /// PartiallyCaptured.
        /// </summary>
        [EnumMember(Value = "PARTIALLY_CAPTURED")]
        PartiallyCaptured,

        /// <summary>
        /// Voided.
        /// </summary>
        [EnumMember(Value = "VOIDED")]
        Voided,

        /// <summary>
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