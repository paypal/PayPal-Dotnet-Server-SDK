// <copyright file="PayeePaymentMethodPreference.cs" company="APIMatic">
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
    /// PayeePaymentMethodPreference.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PayeePaymentMethodPreference
    {
        /// <summary>
        /// UNRESTRICTED.
        /// </summary>
        [EnumMember(Value = "UNRESTRICTED")]
        UNRESTRICTED,

        /// <summary>
        /// IMMEDIATEPAYMENTREQUIRED.
        /// </summary>
        [EnumMember(Value = "IMMEDIATE_PAYMENT_REQUIRED")]
        IMMEDIATEPAYMENTREQUIRED,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}