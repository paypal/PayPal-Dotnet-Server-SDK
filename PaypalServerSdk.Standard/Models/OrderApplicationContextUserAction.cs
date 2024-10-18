// <copyright file="OrderApplicationContextUserAction.cs" company="APIMatic">
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
    /// OrderApplicationContextUserAction.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum OrderApplicationContextUserAction
    {
        /// <summary>
        /// Continue.
        /// </summary>
        [EnumMember(Value = "CONTINUE")]
        Continue,

        /// <summary>
        /// PayNow.
        /// </summary>
        [EnumMember(Value = "PAY_NOW")]
        PayNow,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}