// <copyright file="DisputeCategory.cs" company="APIMatic">
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
    /// DisputeCategory.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum DisputeCategory
    {
        /// <summary>
        /// ItemNotReceived.
        /// </summary>
        [EnumMember(Value = "ITEM_NOT_RECEIVED")]
        ItemNotReceived,

        /// <summary>
        /// UnauthorizedTransaction.
        /// </summary>
        [EnumMember(Value = "UNAUTHORIZED_TRANSACTION")]
        UnauthorizedTransaction,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}