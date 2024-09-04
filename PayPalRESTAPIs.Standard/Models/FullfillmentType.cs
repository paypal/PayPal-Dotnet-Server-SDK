// <copyright file="FullfillmentType.cs" company="APIMatic">
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
    /// FullfillmentType.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum FullfillmentType
    {
        /// <summary>
        /// SHIPPING.
        /// </summary>
        [EnumMember(Value = "SHIPPING")]
        SHIPPING,

        /// <summary>
        /// PICKUPINPERSON.
        /// </summary>
        [EnumMember(Value = "PICKUP_IN_PERSON")]
        PICKUPINPERSON,

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