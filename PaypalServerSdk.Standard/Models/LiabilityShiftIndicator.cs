// <copyright file="LiabilityShiftIndicator.cs" company="APIMatic">
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
    /// LiabilityShiftIndicator.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum LiabilityShiftIndicator
    {
        /// <summary>
        ///Liability is with the merchant.
        /// No.
        /// </summary>
        [EnumMember(Value = "NO")]
        No,

        /// <summary>
        ///Liability may shift to the card issuer.
        /// Possible.
        /// </summary>
        [EnumMember(Value = "POSSIBLE")]
        Possible,

        /// <summary>
        ///The authentication system is not available.
        /// Unknown.
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}