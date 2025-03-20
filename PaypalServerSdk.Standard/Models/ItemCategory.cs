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
        ///Goods that are stored, delivered, and used in their electronic format. This value is not currently supported for API callers that leverage the PayPal for Commerce Platform product.
        /// DigitalGoods.
        /// </summary>
        [EnumMember(Value = "DIGITAL_GOODS")]
        DigitalGoods,

        /// <summary>
        ///A tangible item that can be shipped with proof of delivery.
        /// PhysicalGoods.
        /// </summary>
        [EnumMember(Value = "PHYSICAL_GOODS")]
        PhysicalGoods,

        /// <summary>
        ///A contribution or gift for which no good or service is exchanged, usually to a not for profit organization.
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