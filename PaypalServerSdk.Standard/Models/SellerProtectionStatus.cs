// <copyright file="SellerProtectionStatus.cs" company="APIMatic">
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
    /// SellerProtectionStatus.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum SellerProtectionStatus
    {
        /// <summary>
        /// Eligible.
        /// </summary>
        [EnumMember(Value = "ELIGIBLE")]
        Eligible,

        /// <summary>
        /// PartiallyEligible.
        /// </summary>
        [EnumMember(Value = "PARTIALLY_ELIGIBLE")]
        PartiallyEligible,

        /// <summary>
        /// NotEligible.
        /// </summary>
        [EnumMember(Value = "NOT_ELIGIBLE")]
        NotEligible,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}