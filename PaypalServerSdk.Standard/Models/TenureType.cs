// <copyright file="TenureType.cs" company="APIMatic">
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
    /// TenureType.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum TenureType
    {
        /// <summary>
        ///A regular billing cycle to identify recurring charges for the billing agreement.
        /// Regular.
        /// </summary>
        [EnumMember(Value = "REGULAR")]
        Regular,

        /// <summary>
        ///A trial billing cycle to identify free or discounted charge for the billing agreement. Free trails will not have a price object in pricing scheme where as a discounted trial would have a discounted price compared to regular billing cycle.
        /// Trial.
        /// </summary>
        [EnumMember(Value = "TRIAL")]
        Trial,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}