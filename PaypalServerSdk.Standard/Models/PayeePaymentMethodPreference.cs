// <copyright file="PayeePaymentMethodPreference.cs" company="APIMatic">
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
    /// PayeePaymentMethodPreference.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PayeePaymentMethodPreference
    {
        /// <summary>
        /// Unrestricted.
        /// </summary>
        [EnumMember(Value = "UNRESTRICTED")]
        Unrestricted,

        /// <summary>
        /// ImmediatePaymentRequired.
        /// </summary>
        [EnumMember(Value = "IMMEDIATE_PAYMENT_REQUIRED")]
        ImmediatePaymentRequired,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}