// <copyright file="StoredPaymentSourceUsageType.cs" company="APIMatic">
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
    /// StoredPaymentSourceUsageType.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum StoredPaymentSourceUsageType
    {
        /// <summary>
        /// FIRST.
        /// </summary>
        [EnumMember(Value = "FIRST")]
        FIRST,

        /// <summary>
        /// SUBSEQUENT.
        /// </summary>
        [EnumMember(Value = "SUBSEQUENT")]
        SUBSEQUENT,

        /// <summary>
        /// DERIVED.
        /// </summary>
        [EnumMember(Value = "DERIVED")]
        DERIVED,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}