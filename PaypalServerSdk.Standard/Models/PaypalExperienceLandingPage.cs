// <copyright file="PaypalExperienceLandingPage.cs" company="APIMatic">
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
    /// PaypalExperienceLandingPage.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PaypalExperienceLandingPage
    {
        /// <summary>
        /// LOGIN.
        /// </summary>
        [EnumMember(Value = "LOGIN")]
        LOGIN,

        /// <summary>
        /// GUESTCHECKOUT.
        /// </summary>
        [EnumMember(Value = "GUEST_CHECKOUT")]
        GUESTCHECKOUT,

        /// <summary>
        /// NOPREFERENCE.
        /// </summary>
        [EnumMember(Value = "NO_PREFERENCE")]
        NOPREFERENCE,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}