// <copyright file="PaymentInitiator.cs" company="APIMatic">
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
    /// PaymentInitiator.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PaymentInitiator
    {
        /// <summary>
        /// CUSTOMER.
        /// </summary>
        [EnumMember(Value = "CUSTOMER")]
        CUSTOMER,

        /// <summary>
        /// MERCHANT.
        /// </summary>
        [EnumMember(Value = "MERCHANT")]
        MERCHANT,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}