// <copyright file="StoredPaymentSourceUsageType.cs" company="APIMatic">
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
    /// StoredPaymentSourceUsageType.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum StoredPaymentSourceUsageType
    {
        /// <summary>
        ///Indicates the Initial/First payment with a payment_source that is intended to be stored upon successful processing of the payment.
        /// First.
        /// </summary>
        [EnumMember(Value = "FIRST")]
        First,

        /// <summary>
        ///Indicates a payment using a stored payment_source which has been successfully used previously for a payment.
        /// Subsequent.
        /// </summary>
        [EnumMember(Value = "SUBSEQUENT")]
        Subsequent,

        /// <summary>
        ///Indicates that PayPal will derive the value of `FIRST` or `SUBSEQUENT` based on data available to PayPal.
        /// Derived.
        /// </summary>
        [EnumMember(Value = "DERIVED")]
        Derived,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}