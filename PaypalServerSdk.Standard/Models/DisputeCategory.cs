// <copyright file="DisputeCategory.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using APIMatic.Core.Utilities.Converters;
using Newtonsoft.Json;
using PaypalServerSDK.Standard;
using PaypalServerSDK.Standard.Utilities;

namespace PaypalServerSDK.Standard.Models
{
    /// <summary>
    /// DisputeCategory.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum DisputeCategory
    {
        /// <summary>
        /// ITEMNOTRECEIVED.
        /// </summary>
        [EnumMember(Value = "ITEM_NOT_RECEIVED")]
        ITEMNOTRECEIVED,

        /// <summary>
        /// UNAUTHORIZEDTRANSACTION.
        /// </summary>
        [EnumMember(Value = "UNAUTHORIZED_TRANSACTION")]
        UNAUTHORIZEDTRANSACTION,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}