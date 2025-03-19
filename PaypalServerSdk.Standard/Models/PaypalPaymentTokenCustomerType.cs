// <copyright file="PaypalPaymentTokenCustomerType.cs" company="APIMatic">
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
    /// PaypalPaymentTokenCustomerType.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PaypalPaymentTokenCustomerType
    {
        /// <summary>
        ///The customer vaulting the PayPal payment token is a consumer on the merchant / platform.
        /// Consumer.
        /// </summary>
        [EnumMember(Value = "CONSUMER")]
        Consumer,

        /// <summary>
        ///The customer vaulting the PayPal payment token is a business on merchant / platform.
        /// Business.
        /// </summary>
        [EnumMember(Value = "BUSINESS")]
        Business,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}