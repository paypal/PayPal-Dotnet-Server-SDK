// <copyright file="ItemCategory.cs" company="APIMatic">
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
    /// ItemCategory.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum ItemCategory
    {
        /// <summary>
        /// DigitalGoods.
        /// </summary>
        [EnumMember(Value = "DIGITAL_GOODS")]
        DigitalGoods,

        /// <summary>
        /// PhysicalGoods.
        /// </summary>
        [EnumMember(Value = "PHYSICAL_GOODS")]
        PhysicalGoods,

        /// <summary>
        /// Donation.
        /// </summary>
        [EnumMember(Value = "DONATION")]
        Donation,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}