// <copyright file="UPCType.cs" company="APIMatic">
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
    /// UPCType.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum UPCType
    {
        /// <summary>
        /// UPCA.
        /// </summary>
        [EnumMember(Value = "UPC-A")]
        UPCA,

        /// <summary>
        /// UPCB.
        /// </summary>
        [EnumMember(Value = "UPC-B")]
        UPCB,

        /// <summary>
        /// UPCC.
        /// </summary>
        [EnumMember(Value = "UPC-C")]
        UPCC,

        /// <summary>
        /// UPCD.
        /// </summary>
        [EnumMember(Value = "UPC-D")]
        UPCD,

        /// <summary>
        /// UPCE.
        /// </summary>
        [EnumMember(Value = "UPC-E")]
        UPCE,

        /// <summary>
        /// UPC2.
        /// </summary>
        [EnumMember(Value = "UPC-2")]
        UPC2,

        /// <summary>
        /// UPC5.
        /// </summary>
        [EnumMember(Value = "UPC-5")]
        UPC5,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}