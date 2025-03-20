// <copyright file="PricingModel.cs" company="APIMatic">
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
    /// PricingModel.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PricingModel
    {
        /// <summary>
        ///A fixed pricing scheme where the customer is charged a fixed amount.
        /// Fixed.
        /// </summary>
        [EnumMember(Value = "FIXED")]
        Fixed,

        /// <summary>
        ///A variable pricing scheme where the customer is charged a variable amount.
        /// Variable.
        /// </summary>
        [EnumMember(Value = "VARIABLE")]
        Variable,

        /// <summary>
        ///A auto-reload pricing scheme where the customer is charged a fixed amount for reload.
        /// AutoReload.
        /// </summary>
        [EnumMember(Value = "AUTO_RELOAD")]
        AutoReload,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}