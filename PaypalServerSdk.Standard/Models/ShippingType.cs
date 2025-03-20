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
        ///The payer intends to receive the items at a specified address.
        /// Shipping.
        /// </summary>
        [EnumMember(Value = "SHIPPING")]
        Shipping,

        /// <summary>
        ///DEPRECATED. To ensure that seller protection is correctly assigned, please use 'PICKUP_IN_STORE' or 'PICKUP_FROM_PERSON' instead. Currently, this field indicates that the payer intends to pick up the items at a specified address (ie. a store address).
        /// Pickup.
        /// </summary>
        [EnumMember(Value = "PICKUP")]
        Pickup,

        /// <summary>
        ///The payer intends to pick up the item(s) from the payee's physical store. Also termed as BOPIS, "Buy Online, Pick-up in Store". Seller protection is provided with this option.
        /// PickupInStore.
        /// </summary>
        [EnumMember(Value = "PICKUP_IN_STORE")]
        PickupInStore,

        /// <summary>
        ///The payer intends to pick up the item(s) from the payee in person. Also termed as BOPIP, "Buy Online, Pick-up in Person". Seller protection is not available, since the payer is receiving the item from the payee in person, and can validate the item prior to payment.
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