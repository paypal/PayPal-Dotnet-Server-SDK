// <copyright file="UpcType.cs" company="APIMatic">
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
    /// UpcType.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum UpcType
    {
        /// <summary>
        /// UpcA.
        /// </summary>
        [EnumMember(Value = "UPC-A")]
        UpcA,

        /// <summary>
        /// UpcB.
        /// </summary>
        [EnumMember(Value = "UPC-B")]
        UpcB,

        /// <summary>
        /// UpcC.
        /// </summary>
        [EnumMember(Value = "UPC-C")]
        UpcC,

        /// <summary>
        /// UpcD.
        /// </summary>
        [EnumMember(Value = "UPC-D")]
        UpcD,

        /// <summary>
        /// UpcE.
        /// </summary>
        [EnumMember(Value = "UPC-E")]
        UpcE,

        /// <summary>
        /// Upc2.
        /// </summary>
        [EnumMember(Value = "UPC-2")]
        Upc2,

        /// <summary>
        /// Upc5.
        /// </summary>
        [EnumMember(Value = "UPC-5")]
        Upc5,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}