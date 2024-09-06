// <copyright file="InstrumentAuthorizationStatus.cs" company="APIMatic">
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
    /// InstrumentAuthorizationStatus.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum InstrumentAuthorizationStatus
    {
        /// <summary>
        /// AUTHORIZED.
        /// </summary>
        [EnumMember(Value = "AUTHORIZED")]
        AUTHORIZED,

        /// <summary>
        /// BLOCKED.
        /// </summary>
        [EnumMember(Value = "BLOCKED")]
        BLOCKED,

        /// <summary>
        /// FAILED.
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED,

        /// <summary>
        /// NOTAPPLICABLE.
        /// </summary>
        [EnumMember(Value = "NOT_APPLICABLE")]
        NOTAPPLICABLE,

        /// <summary>
        /// NOTSUPPORTED.
        /// </summary>
        [EnumMember(Value = "NOT_SUPPORTED")]
        NOTSUPPORTED,

        /// <summary>
        /// UNAUTHORIZED.
        /// </summary>
        [EnumMember(Value = "UNAUTHORIZED")]
        UNAUTHORIZED,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}