// <copyright file="PayPalWalletVaultStatus.cs" company="APIMatic">
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
    /// PayPalWalletVaultStatus.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PayPalWalletVaultStatus
    {
        /// <summary>
        /// VAULTED.
        /// </summary>
        [EnumMember(Value = "VAULTED")]
        VAULTED,

        /// <summary>
        /// CREATED.
        /// </summary>
        [EnumMember(Value = "CREATED")]
        CREATED,

        /// <summary>
        /// APPROVED.
        /// </summary>
        [EnumMember(Value = "APPROVED")]
        APPROVED,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}