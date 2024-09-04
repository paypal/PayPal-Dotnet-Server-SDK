// <copyright file="EnrollmentStatus.cs" company="APIMatic">
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
    /// EnrollmentStatus.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum EnrollmentStatus
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
        /// B.
        /// </summary>
        [EnumMember(Value = "B")]
        B,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}