// <copyright file="PhoneType.cs" company="APIMatic">
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
    /// PhoneType.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PhoneType
    {
        /// <summary>
        /// FAX.
        /// </summary>
        [EnumMember(Value = "FAX")]
        FAX,

        /// <summary>
        /// HOME.
        /// </summary>
        [EnumMember(Value = "HOME")]
        HOME,

        /// <summary>
        /// MOBILE.
        /// </summary>
        [EnumMember(Value = "MOBILE")]
        MOBILE,

        /// <summary>
        /// OTHER.
        /// </summary>
        [EnumMember(Value = "OTHER")]
        OTHER,

        /// <summary>
        /// PAGER.
        /// </summary>
        [EnumMember(Value = "PAGER")]
        PAGER,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}