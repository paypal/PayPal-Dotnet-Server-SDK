// <copyright file="CardVerificationMethod.cs" company="APIMatic">
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
    /// CardVerificationMethod.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum CardVerificationMethod
    {
        /// <summary>
        /// SCAALWAYS.
        /// </summary>
        [EnumMember(Value = "SCA_ALWAYS")]
        SCAALWAYS,

        /// <summary>
        /// SCAWHENREQUIRED.
        /// </summary>
        [EnumMember(Value = "SCA_WHEN_REQUIRED")]
        SCAWHENREQUIRED,

        /// <summary>
        /// Enum3DSECURE.
        /// </summary>
        [EnumMember(Value = "3D_SECURE")]
        Enum3DSECURE,

        /// <summary>
        /// AVSCVV.
        /// </summary>
        [EnumMember(Value = "AVS_CVV")]
        AVSCVV,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}