// <copyright file="TaxIdType.cs" company="APIMatic">
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
    /// TaxIdType.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum TaxIdType
    {
        /// <summary>
        /// BrCpf.
        /// </summary>
        [EnumMember(Value = "BR_CPF")]
        BrCpf,

        /// <summary>
        /// BrCnpj.
        /// </summary>
        [EnumMember(Value = "BR_CNPJ")]
        BrCnpj,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}