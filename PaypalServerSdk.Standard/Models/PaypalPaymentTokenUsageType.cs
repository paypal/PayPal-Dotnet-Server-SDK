// <copyright file="PaypalPaymentTokenUsageType.cs" company="APIMatic">
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
    /// PaypalPaymentTokenUsageType.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PaypalPaymentTokenUsageType
    {
        /// <summary>
        ///The PayPal Payment Token will be used for future transaction directly with a merchant.
        /// Merchant.
        /// </summary>
        [EnumMember(Value = "MERCHANT")]
        Merchant,

        /// <summary>
        ///The PayPal Payment Token will be used for future transaction on a platform. A platform is typically a marketplace or a channel that a payer can purchase goods and services from multiple merchants.
        /// Platform.
        /// </summary>
        [EnumMember(Value = "PLATFORM")]
        Platform,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}