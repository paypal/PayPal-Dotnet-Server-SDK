// <copyright file="PaypalExperienceLandingPage.cs" company="APIMatic">
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
    /// PaypalExperienceLandingPage.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PaypalExperienceLandingPage
    {
        /// <summary>
        /// Login.
        /// </summary>
        [EnumMember(Value = "LOGIN")]
        Login,

        /// <summary>
        /// GuestCheckout.
        /// </summary>
        [EnumMember(Value = "GUEST_CHECKOUT")]
        GuestCheckout,

        /// <summary>
        /// NoPreference.
        /// </summary>
        [EnumMember(Value = "NO_PREFERENCE")]
        NoPreference,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}