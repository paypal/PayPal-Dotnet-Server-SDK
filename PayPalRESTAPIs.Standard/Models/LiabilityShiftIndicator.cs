// <copyright file="LiabilityShiftIndicator.cs" company="APIMatic">
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
    /// LiabilityShiftIndicator.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum LiabilityShiftIndicator
    {
        /// <summary>
        /// NO.
        /// </summary>
        [EnumMember(Value = "NO")]
        NO,

        /// <summary>
        /// POSSIBLE.
        /// </summary>
        [EnumMember(Value = "POSSIBLE")]
        POSSIBLE,

        /// <summary>
        /// UNKNOWN.
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}