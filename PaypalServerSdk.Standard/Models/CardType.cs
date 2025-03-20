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
        ///A credit card.
        /// Credit.
        /// </summary>
        [EnumMember(Value = "CREDIT")]
        Credit,

        /// <summary>
        ///A debit card.
        /// Debit.
        /// </summary>
        [EnumMember(Value = "DEBIT")]
        Debit,

        /// <summary>
        ///A Prepaid card.
        /// Prepaid.
        /// </summary>
        [EnumMember(Value = "PREPAID")]
        Prepaid,

        /// <summary>
        ///A store card.
        /// Store.
        /// </summary>
        [EnumMember(Value = "STORE")]
        Store,

        /// <summary>
        ///Card type cannot be determined.
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