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
        /// Upca.
        /// </summary>
        [EnumMember(Value = "UPC-A")]
        Upca,

        /// <summary>
        /// Upcb.
        /// </summary>
        [EnumMember(Value = "UPC-B")]
        Upcb,

        /// <summary>
        /// Upcc.
        /// </summary>
        [EnumMember(Value = "UPC-C")]
        Upcc,

        /// <summary>
        /// Upcd.
        /// </summary>
        [EnumMember(Value = "UPC-D")]
        Upcd,

        /// <summary>
        /// Upce.
        /// </summary>
        [EnumMember(Value = "UPC-E")]
        Upce,

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