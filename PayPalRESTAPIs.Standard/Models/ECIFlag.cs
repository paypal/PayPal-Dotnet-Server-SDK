// <copyright file="ECIFlag.cs" company="APIMatic">
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
    /// ECIFlag.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum ECIFlag
    {
        /// <summary>
        /// MASTERCARDNON3DSECURETRANSACTION.
        /// </summary>
        [EnumMember(Value = "MASTERCARD_NON_3D_SECURE_TRANSACTION")]
        MASTERCARDNON3DSECURETRANSACTION,

        /// <summary>
        /// MASTERCARDATTEMPTEDAUTHENTICATIONTRANSACTION.
        /// </summary>
        [EnumMember(Value = "MASTERCARD_ATTEMPTED_AUTHENTICATION_TRANSACTION")]
        MASTERCARDATTEMPTEDAUTHENTICATIONTRANSACTION,

        /// <summary>
        /// MASTERCARDFULLYAUTHENTICATEDTRANSACTION.
        /// </summary>
        [EnumMember(Value = "MASTERCARD_FULLY_AUTHENTICATED_TRANSACTION")]
        MASTERCARDFULLYAUTHENTICATEDTRANSACTION,

        /// <summary>
        /// FULLYAUTHENTICATEDTRANSACTION.
        /// </summary>
        [EnumMember(Value = "FULLY_AUTHENTICATED_TRANSACTION")]
        FULLYAUTHENTICATEDTRANSACTION,

        /// <summary>
        /// ATTEMPTEDAUTHENTICATIONTRANSACTION.
        /// </summary>
        [EnumMember(Value = "ATTEMPTED_AUTHENTICATION_TRANSACTION")]
        ATTEMPTEDAUTHENTICATIONTRANSACTION,

        /// <summary>
        /// NON3DSECURETRANSACTION.
        /// </summary>
        [EnumMember(Value = "NON_3D_SECURE_TRANSACTION")]
        NON3DSECURETRANSACTION,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}