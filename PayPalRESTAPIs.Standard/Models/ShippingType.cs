// <copyright file="ShippingType.cs" company="APIMatic">
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
    /// ShippingType.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum ShippingType
    {
        /// <summary>
        /// SHIPPING.
        /// </summary>
        [EnumMember(Value = "SHIPPING")]
        SHIPPING,

        /// <summary>
        /// PICKUP.
        /// </summary>
        [EnumMember(Value = "PICKUP")]
        PICKUP,

        /// <summary>
        /// PICKUPINSTORE.
        /// </summary>
        [EnumMember(Value = "PICKUP_IN_STORE")]
        PICKUPINSTORE,

        /// <summary>
        /// PICKUPFROMPERSON.
        /// </summary>
        [EnumMember(Value = "PICKUP_FROM_PERSON")]
        PICKUPFROMPERSON,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}