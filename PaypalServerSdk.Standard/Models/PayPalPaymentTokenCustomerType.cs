// <copyright file="PayPalPaymentTokenCustomerType.cs" company="APIMatic">
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
    /// PayPalPaymentTokenCustomerType.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PayPalPaymentTokenCustomerType
    {
        /// <summary>
        /// CONSUMER.
        /// </summary>
        [EnumMember(Value = "CONSUMER")]
        CONSUMER,

        /// <summary>
        /// BUSINESS.
        /// </summary>
        [EnumMember(Value = "BUSINESS")]
        BUSINESS,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}