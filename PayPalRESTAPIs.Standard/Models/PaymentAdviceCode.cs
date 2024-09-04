// <copyright file="PaymentAdviceCode.cs" company="APIMatic">
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
    /// PaymentAdviceCode.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PaymentAdviceCode
    {
        /// <summary>
        /// Enum01.
        /// </summary>
        [EnumMember(Value = "01")]
        Enum01,

        /// <summary>
        /// Enum02.
        /// </summary>
        [EnumMember(Value = "02")]
        Enum02,

        /// <summary>
        /// Enum03.
        /// </summary>
        [EnumMember(Value = "03")]
        Enum03,

        /// <summary>
        /// Enum21.
        /// </summary>
        [EnumMember(Value = "21")]
        Enum21,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}