// <copyright file="PayPalWalletAccountVerificationStatus.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using PaypalServerSDK.Standard;
using PaypalServerSDK.Standard.Utilities;

namespace PaypalServerSDK.Standard.Models
{
    /// <summary>
    /// PayPalWalletAccountVerificationStatus.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PayPalWalletAccountVerificationStatus
    {
        /// <summary>
        /// VERIFIED.
        /// </summary>
        [EnumMember(Value = "VERIFIED")]
        VERIFIED,

        /// <summary>
        /// UNVERIFIED.
        /// </summary>
        [EnumMember(Value = "UNVERIFIED")]
        UNVERIFIED,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}