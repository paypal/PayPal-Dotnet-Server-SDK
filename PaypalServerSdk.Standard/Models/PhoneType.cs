// <copyright file="PhoneType.cs" company="APIMatic">
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
    /// PhoneType.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PhoneType
    {
        /// <summary>
        /// Fax.
        /// </summary>
        [EnumMember(Value = "FAX")]
        Fax,

        /// <summary>
        /// Home.
        /// </summary>
        [EnumMember(Value = "HOME")]
        Home,

        /// <summary>
        /// Mobile.
        /// </summary>
        [EnumMember(Value = "MOBILE")]
        Mobile,

        /// <summary>
        /// Other.
        /// </summary>
        [EnumMember(Value = "OTHER")]
        Other,

        /// <summary>
        /// Pager.
        /// </summary>
        [EnumMember(Value = "PAGER")]
        Pager,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}