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
        ///Payment is initiated with the active engagement of the customer. e.g. a customer checking out on a merchant website.
        /// Customer.
        /// </summary>
        [EnumMember(Value = "CUSTOMER")]
        Customer,

        /// <summary>
        ///Payment is initiated by merchant on behalf of the customer without the active engagement of customer. e.g. a merchant charging the monthly payment of a subscription to the customer.
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