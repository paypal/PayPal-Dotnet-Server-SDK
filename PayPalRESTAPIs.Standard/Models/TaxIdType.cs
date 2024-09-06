// <copyright file="TaxIdType.cs" company="APIMatic">
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
    /// TaxIdType.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum TaxIdType
    {
        /// <summary>
        /// BRCPF.
        /// </summary>
        [EnumMember(Value = "BR_CPF")]
        BRCPF,

        /// <summary>
        /// BRCNPJ.
        /// </summary>
        [EnumMember(Value = "BR_CNPJ")]
        BRCNPJ,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}