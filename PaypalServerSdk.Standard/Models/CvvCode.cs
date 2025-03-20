// <copyright file="CvvCode.cs" company="APIMatic">
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
    /// CvvCode.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum CvvCode
    {
        /// <summary>
        ///For Visa, Mastercard, Discover, or American Express, error - unrecognized or unknown response.
        /// CvvE.
        /// </summary>
        [EnumMember(Value = "E")]
        CvvE,

        /// <summary>
        ///For Visa, Mastercard, Discover, or American Express, invalid or null.
        /// CvvI.
        /// </summary>
        [EnumMember(Value = "I")]
        CvvI,

        /// <summary>
        ///For Visa, Mastercard, Discover, or American Express, the CVV2/CSC matches.
        /// CvvM.
        /// </summary>
        [EnumMember(Value = "M")]
        CvvM,

        /// <summary>
        ///For Visa, Mastercard, Discover, or American Express, the CVV2/CSC does not match.
        /// CvvN.
        /// </summary>
        [EnumMember(Value = "N")]
        CvvN,

        /// <summary>
        ///For Visa, Mastercard, Discover, or American Express, it was not processed.
        /// CvvP.
        /// </summary>
        [EnumMember(Value = "P")]
        CvvP,

        /// <summary>
        ///For Visa, Mastercard, Discover, or American Express, the service is not supported.
        /// CvvS.
        /// </summary>
        [EnumMember(Value = "S")]
        CvvS,

        /// <summary>
        ///For Visa, Mastercard, Discover, or American Express, unknown - the issuer is not certified.
        /// CvvU.
        /// </summary>
        [EnumMember(Value = "U")]
        CvvU,

        /// <summary>
        ///For Visa, Mastercard, Discover, or American Express, no response. For Maestro, the service is not available.
        /// CvvX.
        /// </summary>
        [EnumMember(Value = "X")]
        CvvX,

        /// <summary>
        ///For Visa, Mastercard, Discover, or American Express, error.
        /// EnumAllOthers.
        /// </summary>
        [EnumMember(Value = "All others")]
        EnumAllOthers,

        /// <summary>
        ///For Maestro, the CVV2 matched.
        /// Cvv0.
        /// </summary>
        [EnumMember(Value = "0")]
        Cvv0,

        /// <summary>
        ///For Maestro, the CVV2 did not match.
        /// Cvv1.
        /// </summary>
        [EnumMember(Value = "1")]
        Cvv1,

        /// <summary>
        ///For Maestro, the merchant has not implemented CVV2 code handling.
        /// Cvv2.
        /// </summary>
        [EnumMember(Value = "2")]
        Cvv2,

        /// <summary>
        ///For Maestro, the merchant has indicated that CVV2 is not present on card.
        /// Cvv3.
        /// </summary>
        [EnumMember(Value = "3")]
        Cvv3,

        /// <summary>
        ///For Maestro, the service is not available.
        /// Cvv4.
        /// </summary>
        [EnumMember(Value = "4")]
        Cvv4,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}