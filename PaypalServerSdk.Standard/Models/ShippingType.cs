// <copyright file="ShippingType.cs" company="APIMatic">
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
    /// ShippingType.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum ShippingType
    {
        /// <summary>
        /// Shipping.
        /// </summary>
        [EnumMember(Value = "SHIPPING")]
        Shipping,

        /// <summary>
        /// Pickup.
        /// </summary>
        [EnumMember(Value = "PICKUP")]
        Pickup,

        /// <summary>
        /// PickupInStore.
        /// </summary>
        [EnumMember(Value = "PICKUP_IN_STORE")]
        PickupInStore,

        /// <summary>
        /// PickupFromPerson.
        /// </summary>
        [EnumMember(Value = "PICKUP_FROM_PERSON")]
        PickupFromPerson,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}