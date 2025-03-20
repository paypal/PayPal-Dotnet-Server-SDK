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
        ///The individual tax ID type, typically is 11 characters long.
        /// BrCpf.
        /// </summary>
        [EnumMember(Value = "BR_CPF")]
        BrCpf,

        /// <summary>
        ///The business tax ID type, typically is 14 characters long.
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