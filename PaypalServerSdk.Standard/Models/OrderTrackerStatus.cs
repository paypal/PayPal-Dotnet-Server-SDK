// <copyright file="OrderTrackerStatus.cs" company="APIMatic">
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
    /// OrderTrackerStatus.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum OrderTrackerStatus
    {
        /// <summary>
        ///The shipment was cancelled and the tracking number no longer applies.
        /// Cancelled.
        /// </summary>
        [EnumMember(Value = "CANCELLED")]
        Cancelled,

        /// <summary>
        ///The merchant has assigned a tracking number to the items being shipped from the Order. This does not correspond to the carrier's actual status for the shipment. The latest status of the parcel must be retrieved from the carrier.
        /// Shipped.
        /// </summary>
        [EnumMember(Value = "SHIPPED")]
        Shipped,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}