// <copyright file="CardType.cs" company="APIMatic">
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
    /// CardType.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum CardType
    {
        /// <summary>
        /// Credit.
        /// </summary>
        [EnumMember(Value = "CREDIT")]
        Credit,

        /// <summary>
        /// Debit.
        /// </summary>
        [EnumMember(Value = "DEBIT")]
        Debit,

        /// <summary>
        /// Prepaid.
        /// </summary>
        [EnumMember(Value = "PREPAID")]
        Prepaid,

        /// <summary>
        /// Store.
        /// </summary>
        [EnumMember(Value = "STORE")]
        Store,

        /// <summary>
        /// Unknown.
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}