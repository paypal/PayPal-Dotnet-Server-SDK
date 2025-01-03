// <copyright file="ApplePayPaymentDataType.cs" company="APIMatic">
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
    /// ApplePayPaymentDataType.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum ApplePayPaymentDataType
    {
        /// <summary>
        /// Enum3Dsecure.
        /// </summary>
        [EnumMember(Value = "3DSECURE")]
        Enum3Dsecure,

        /// <summary>
        /// Emv.
        /// </summary>
        [EnumMember(Value = "EMV")]
        Emv,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}