// <copyright file="SellerProtectionStatus.cs" company="APIMatic">
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
    /// SellerProtectionStatus.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum SellerProtectionStatus
    {
        /// <summary>
        /// ELIGIBLE.
        /// </summary>
        [EnumMember(Value = "ELIGIBLE")]
        ELIGIBLE,

        /// <summary>
        /// PARTIALLYELIGIBLE.
        /// </summary>
        [EnumMember(Value = "PARTIALLY_ELIGIBLE")]
        PARTIALLYELIGIBLE,

        /// <summary>
        /// NOTELIGIBLE.
        /// </summary>
        [EnumMember(Value = "NOT_ELIGIBLE")]
        NOTELIGIBLE,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}