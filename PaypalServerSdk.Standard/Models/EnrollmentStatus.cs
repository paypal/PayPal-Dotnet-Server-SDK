// <copyright file="EnrollmentStatus.cs" company="APIMatic">
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
    /// EnrollmentStatus.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum EnrollmentStatus
    {
        /// <summary>
        ///Yes. The bank is participating in 3-D Secure protocol and will return the ACSUrl.
        /// Enrolled.
        /// </summary>
        [EnumMember(Value = "Y")]
        Enrolled,

        /// <summary>
        ///No. The bank is not participating in 3-D Secure protocol.
        /// NotEnrolled.
        /// </summary>
        [EnumMember(Value = "N")]
        NotEnrolled,

        /// <summary>
        ///Unavailable. The DS or ACS is not available for authentication at the time of the request.
        /// Unavailable.
        /// </summary>
        [EnumMember(Value = "U")]
        Unavailable,

        /// <summary>
        ///Bypass. The merchant authentication rule is triggered to bypass authentication.
        /// Bypass.
        /// </summary>
        [EnumMember(Value = "B")]
        Bypass,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}