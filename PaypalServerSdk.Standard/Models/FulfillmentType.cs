// <copyright file="FulfillmentType.cs" company="APIMatic">
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
    /// FulfillmentType.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum FulfillmentType
    {
        /// <summary>
        /// Shipping.
        /// </summary>
        [EnumMember(Value = "SHIPPING")]
        Shipping,

        /// <summary>
        /// PickupInPerson.
        /// </summary>
        [EnumMember(Value = "PICKUP_IN_PERSON")]
        PickupInPerson,

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