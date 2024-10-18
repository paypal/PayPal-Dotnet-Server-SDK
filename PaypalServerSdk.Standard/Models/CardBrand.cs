// <copyright file="CardBrand.cs" company="APIMatic">
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
    /// CardBrand.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum CardBrand
    {
        /// <summary>
        /// Visa.
        /// </summary>
        [EnumMember(Value = "VISA")]
        Visa,

        /// <summary>
        /// Mastercard.
        /// </summary>
        [EnumMember(Value = "MASTERCARD")]
        Mastercard,

        /// <summary>
        /// Discover.
        /// </summary>
        [EnumMember(Value = "DISCOVER")]
        Discover,

        /// <summary>
        /// Amex.
        /// </summary>
        [EnumMember(Value = "AMEX")]
        Amex,

        /// <summary>
        /// Solo.
        /// </summary>
        [EnumMember(Value = "SOLO")]
        Solo,

        /// <summary>
        /// Jcb.
        /// </summary>
        [EnumMember(Value = "JCB")]
        Jcb,

        /// <summary>
        /// Star.
        /// </summary>
        [EnumMember(Value = "STAR")]
        Star,

        /// <summary>
        /// Delta.
        /// </summary>
        [EnumMember(Value = "DELTA")]
        Delta,

        /// <summary>
        /// Switch.
        /// </summary>
        [EnumMember(Value = "SWITCH")]
        Switch,

        /// <summary>
        /// Maestro.
        /// </summary>
        [EnumMember(Value = "MAESTRO")]
        Maestro,

        /// <summary>
        /// CbNationale.
        /// </summary>
        [EnumMember(Value = "CB_NATIONALE")]
        CbNationale,

        /// <summary>
        /// Configoga.
        /// </summary>
        [EnumMember(Value = "CONFIGOGA")]
        Configoga,

        /// <summary>
        /// Confidis.
        /// </summary>
        [EnumMember(Value = "CONFIDIS")]
        Confidis,

        /// <summary>
        /// Electron.
        /// </summary>
        [EnumMember(Value = "ELECTRON")]
        Electron,

        /// <summary>
        /// Cetelem.
        /// </summary>
        [EnumMember(Value = "CETELEM")]
        Cetelem,

        /// <summary>
        /// ChinaUnionPay.
        /// </summary>
        [EnumMember(Value = "CHINA_UNION_PAY")]
        ChinaUnionPay,

        /// <summary>
        /// Diners.
        /// </summary>
        [EnumMember(Value = "DINERS")]
        Diners,

        /// <summary>
        /// Elo.
        /// </summary>
        [EnumMember(Value = "ELO")]
        Elo,

        /// <summary>
        /// Hiper.
        /// </summary>
        [EnumMember(Value = "HIPER")]
        Hiper,

        /// <summary>
        /// Hipercard.
        /// </summary>
        [EnumMember(Value = "HIPERCARD")]
        Hipercard,

        /// <summary>
        /// Rupay.
        /// </summary>
        [EnumMember(Value = "RUPAY")]
        Rupay,

        /// <summary>
        /// Ge.
        /// </summary>
        [EnumMember(Value = "GE")]
        Ge,

        /// <summary>
        /// Synchrony.
        /// </summary>
        [EnumMember(Value = "SYNCHRONY")]
        Synchrony,

        /// <summary>
        /// Eftpos.
        /// </summary>
        [EnumMember(Value = "EFTPOS")]
        Eftpos,

        /// <summary>
        /// Unknown.
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        Unknown,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}