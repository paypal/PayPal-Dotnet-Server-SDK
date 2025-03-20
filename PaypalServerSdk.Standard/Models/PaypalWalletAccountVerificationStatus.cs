// <copyright file="PaypalWalletAccountVerificationStatus.cs" company="APIMatic">
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
    /// PaypalWalletAccountVerificationStatus.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PaypalWalletAccountVerificationStatus
    {
        /// <summary>
        ///The buyer has completed the verification of the financial details associated with this PayPal account. For example: confirming their bank account.
        /// Verified.
        /// </summary>
        [EnumMember(Value = "VERIFIED")]
        Verified,

        /// <summary>
        ///The buyer has not completed the verification of the financial details associated with this PayPal account. For example: confirming their bank account.
        /// Unverified.
        /// </summary>
        [EnumMember(Value = "UNVERIFIED")]
        Unverified,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}