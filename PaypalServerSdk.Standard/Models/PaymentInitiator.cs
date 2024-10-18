// <copyright file="PaymentInitiator.cs" company="APIMatic">
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
    /// PaymentInitiator.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PaymentInitiator
    {
        /// <summary>
        /// Customer.
        /// </summary>
        [EnumMember(Value = "CUSTOMER")]
        Customer,

        /// <summary>
        /// Merchant.
        /// </summary>
        [EnumMember(Value = "MERCHANT")]
        Merchant,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}