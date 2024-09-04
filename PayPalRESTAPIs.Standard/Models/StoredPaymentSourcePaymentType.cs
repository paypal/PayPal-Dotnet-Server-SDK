// <copyright file="StoredPaymentSourcePaymentType.cs" company="APIMatic">
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
    /// StoredPaymentSourcePaymentType.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum StoredPaymentSourcePaymentType
    {
        /// <summary>
        /// ONETIME.
        /// </summary>
        [EnumMember(Value = "ONE_TIME")]
        ONETIME,

        /// <summary>
        /// RECURRING.
        /// </summary>
        [EnumMember(Value = "RECURRING")]
        RECURRING,

        /// <summary>
        /// UNSCHEDULED.
        /// </summary>
        [EnumMember(Value = "UNSCHEDULED")]
        UNSCHEDULED,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}