// <copyright file="TokenRequestType.cs" company="APIMatic">
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
    /// TokenRequestType.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum TokenRequestType
    {
        /// <summary>
        /// SetupToken.
        /// </summary>
        [EnumMember(Value = "SETUP_TOKEN")]
        SetupToken,

        /// <summary>
        /// BillingAgreement.
        /// </summary>
        [EnumMember(Value = "BILLING_AGREEMENT")]
        BillingAgreement,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}