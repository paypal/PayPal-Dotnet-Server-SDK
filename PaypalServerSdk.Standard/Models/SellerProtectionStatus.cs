// <copyright file="SellerProtectionStatus.cs" company="APIMatic">
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
    /// SellerProtectionStatus.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum SellerProtectionStatus
    {
        /// <summary>
        ///Your PayPal balance remains intact if the customer claims that they did not receive an item or the account holder claims that they did not authorize the payment.
        /// Eligible.
        /// </summary>
        [EnumMember(Value = "ELIGIBLE")]
        Eligible,

        /// <summary>
        ///Your PayPal balance remains intact if the customer claims that they did not receive an item.
        /// PartiallyEligible.
        /// </summary>
        [EnumMember(Value = "PARTIALLY_ELIGIBLE")]
        PartiallyEligible,

        /// <summary>
        ///This transaction is not eligible for seller protection.
        /// NotEligible.
        /// </summary>
        [EnumMember(Value = "NOT_ELIGIBLE")]
        NotEligible,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}