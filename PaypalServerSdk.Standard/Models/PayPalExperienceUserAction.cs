// <copyright file="PayPalExperienceUserAction.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using PaypalServerSDK.Standard;
using PaypalServerSDK.Standard.Utilities;

namespace PaypalServerSDK.Standard.Models
{
    /// <summary>
    /// PayPalExperienceUserAction.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PayPalExperienceUserAction
    {
        /// <summary>
        /// CONTINUE.
        /// </summary>
        [EnumMember(Value = "CONTINUE")]
        CONTINUE,

        /// <summary>
        /// PAYNOW.
        /// </summary>
        [EnumMember(Value = "PAY_NOW")]
        PAYNOW,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}