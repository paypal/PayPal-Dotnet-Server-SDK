// <copyright file="AvsCode.cs" company="APIMatic">
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
    /// AvsCode.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum AvsCode
    {
        /// <summary>
        ///For Visa, Mastercard, or Discover transactions, the address matches but the zip code does not match. For American Express transactions, the card holder address is correct.
        /// AvsA.
        /// </summary>
        [EnumMember(Value = "A")]
        AvsA,

        /// <summary>
        ///For Visa, Mastercard, or Discover transactions, the address matches. International A.
        /// AvsB.
        /// </summary>
        [EnumMember(Value = "B")]
        AvsB,

        /// <summary>
        ///For Visa, Mastercard, or Discover transactions, no values match. International N.
        /// AvsC.
        /// </summary>
        [EnumMember(Value = "C")]
        AvsC,

        /// <summary>
        ///For Visa, Mastercard, or Discover transactions, the address and postal code match. International X.
        /// AvsD.
        /// </summary>
        [EnumMember(Value = "D")]
        AvsD,

        /// <summary>
        ///For Visa, Mastercard, or Discover transactions, not allowed for Internet or phone transactions. For American Express card holder, the name is incorrect but the address and postal code match.
        /// AvsE.
        /// </summary>
        [EnumMember(Value = "E")]
        AvsE,

        /// <summary>
        ///For Visa, Mastercard, or Discover transactions, the address and postal code match. UK-specific X. For American Express card holder, the name is incorrect but the address matches.
        /// AvsF.
        /// </summary>
        [EnumMember(Value = "F")]
        AvsF,

        /// <summary>
        ///For Visa, Mastercard, or Discover transactions, global is unavailable. Nothing matches.
        /// AvsG.
        /// </summary>
        [EnumMember(Value = "G")]
        AvsG,

        /// <summary>
        ///For Visa, Mastercard, or Discover transactions, international is unavailable. Not applicable.
        /// AvsI.
        /// </summary>
        [EnumMember(Value = "I")]
        AvsI,

        /// <summary>
        ///For Visa, Mastercard, or Discover transactions, the address and postal code match. For American Express card holder, the name, address, and postal code match.
        /// AvsM.
        /// </summary>
        [EnumMember(Value = "M")]
        AvsM,

        /// <summary>
        ///For Visa, Mastercard, or Discover transactions, nothing matches. For American Express card holder, the address and postal code are both incorrect.
        /// AvsN.
        /// </summary>
        [EnumMember(Value = "N")]
        AvsN,

        /// <summary>
        ///For Visa, Mastercard, or Discover transactions, postal international Z. Postal code only.
        /// AvsP.
        /// </summary>
        [EnumMember(Value = "P")]
        AvsP,

        /// <summary>
        ///For Visa, Mastercard, or Discover transactions, re-try the request. For American Express, the system is unavailable.
        /// AvsR.
        /// </summary>
        [EnumMember(Value = "R")]
        AvsR,

        /// <summary>
        ///For Visa, Mastercard, Discover, or American Express, the service is not supported.
        /// AvsS.
        /// </summary>
        [EnumMember(Value = "S")]
        AvsS,

        /// <summary>
        ///For Visa, Mastercard, or Discover transactions, the service is unavailable. For American Express, information is not available. For Maestro, the address is not checked or the acquirer had no response. The service is not available.
        /// AvsU.
        /// </summary>
        [EnumMember(Value = "U")]
        AvsU,

        /// <summary>
        ///For Visa, Mastercard, or Discover transactions, whole ZIP code. For American Express, the card holder name, address, and postal code are all incorrect.
        /// AvsW.
        /// </summary>
        [EnumMember(Value = "W")]
        AvsW,

        /// <summary>
        ///For Visa, Mastercard, or Discover transactions, exact match of the address and the nine-digit ZIP code. For American Express, the card holder name, address, and postal code are all incorrect.
        /// AvsX.
        /// </summary>
        [EnumMember(Value = "X")]
        AvsX,

        /// <summary>
        ///For Visa, Mastercard, or Discover transactions, the address and five-digit ZIP code match. For American Express, the card holder address and postal code are both correct.
        /// AvsY.
        /// </summary>
        [EnumMember(Value = "Y")]
        AvsY,

        /// <summary>
        ///For Visa, Mastercard, or Discover transactions, the five-digit ZIP code matches but no address. For American Express, only the card holder postal code is correct.
        /// AvsZ.
        /// </summary>
        [EnumMember(Value = "Z")]
        AvsZ,

        /// <summary>
        ///For Maestro, no AVS response was obtained.
        /// AvsNull.
        /// </summary>
        [EnumMember(Value = "Null")]
        AvsNull,

        /// <summary>
        ///For Maestro, all address information matches.
        /// Avs0.
        /// </summary>
        [EnumMember(Value = "0")]
        Avs0,

        /// <summary>
        ///For Maestro, none of the address information matches.
        /// Avs1.
        /// </summary>
        [EnumMember(Value = "1")]
        Avs1,

        /// <summary>
        ///For Maestro, part of the address information matches.
        /// Avs2.
        /// </summary>
        [EnumMember(Value = "2")]
        Avs2,

        /// <summary>
        ///For Maestro, the merchant did not provide AVS information. It was not processed.
        /// Avs3.
        /// </summary>
        [EnumMember(Value = "3")]
        Avs3,

        /// <summary>
        ///For Maestro, the address was not checked or the acquirer had no response. The service is not available.
        /// Avs4.
        /// </summary>
        [EnumMember(Value = "4")]
        Avs4,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}