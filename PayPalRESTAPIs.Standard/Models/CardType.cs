// <copyright file="CardType.cs" company="APIMatic">
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
    /// CardType.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum CardType
    {
        /// <summary>
        /// CREDIT.
        /// </summary>
        [EnumMember(Value = "CREDIT")]
        CREDIT,

        /// <summary>
        /// DEBIT.
        /// </summary>
        [EnumMember(Value = "DEBIT")]
        DEBIT,

        /// <summary>
        /// PREPAID.
        /// </summary>
        [EnumMember(Value = "PREPAID")]
        PREPAID,

        /// <summary>
        /// STORE.
        /// </summary>
        [EnumMember(Value = "STORE")]
        STORE,

        /// <summary>
        /// UNKNOWN.
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}