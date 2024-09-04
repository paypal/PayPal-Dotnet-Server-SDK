// <copyright file="PAResStatus.cs" company="APIMatic">
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
    /// PAResStatus.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PAResStatus
    {
        /// <summary>
        /// Y.
        /// </summary>
        [EnumMember(Value = "Y")]
        Y,

        /// <summary>
        /// N.
        /// </summary>
        [EnumMember(Value = "N")]
        N,

        /// <summary>
        /// U.
        /// </summary>
        [EnumMember(Value = "U")]
        U,

        /// <summary>
        /// A.
        /// </summary>
        [EnumMember(Value = "A")]
        A,

        /// <summary>
        /// C.
        /// </summary>
        [EnumMember(Value = "C")]
        C,

        /// <summary>
        /// R.
        /// </summary>
        [EnumMember(Value = "R")]
        R,

        /// <summary>
        /// D.
        /// </summary>
        [EnumMember(Value = "D")]
        D,

        /// <summary>
        /// I.
        /// </summary>
        [EnumMember(Value = "I")]
        I,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}