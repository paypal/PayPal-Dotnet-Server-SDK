// <copyright file="ItemCategory.cs" company="APIMatic">
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
    /// ItemCategory.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum ItemCategory
    {
        /// <summary>
        /// DIGITALGOODS.
        /// </summary>
        [EnumMember(Value = "DIGITAL_GOODS")]
        DIGITALGOODS,

        /// <summary>
        /// PHYSICALGOODS.
        /// </summary>
        [EnumMember(Value = "PHYSICAL_GOODS")]
        PHYSICALGOODS,

        /// <summary>
        /// DONATION.
        /// </summary>
        [EnumMember(Value = "DONATION")]
        DONATION,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}