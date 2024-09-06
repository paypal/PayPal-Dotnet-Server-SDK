// <copyright file="CardBrand.cs" company="APIMatic">
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
    /// CardBrand.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum CardBrand
    {
        /// <summary>
        /// VISA.
        /// </summary>
        [EnumMember(Value = "VISA")]
        VISA,

        /// <summary>
        /// MASTERCARD.
        /// </summary>
        [EnumMember(Value = "MASTERCARD")]
        MASTERCARD,

        /// <summary>
        /// DISCOVER.
        /// </summary>
        [EnumMember(Value = "DISCOVER")]
        DISCOVER,

        /// <summary>
        /// AMEX.
        /// </summary>
        [EnumMember(Value = "AMEX")]
        AMEX,

        /// <summary>
        /// SOLO.
        /// </summary>
        [EnumMember(Value = "SOLO")]
        SOLO,

        /// <summary>
        /// JCB.
        /// </summary>
        [EnumMember(Value = "JCB")]
        JCB,

        /// <summary>
        /// STAR.
        /// </summary>
        [EnumMember(Value = "STAR")]
        STAR,

        /// <summary>
        /// DELTA.
        /// </summary>
        [EnumMember(Value = "DELTA")]
        DELTA,

        /// <summary>
        /// SWITCH.
        /// </summary>
        [EnumMember(Value = "SWITCH")]
        SWITCH,

        /// <summary>
        /// MAESTRO.
        /// </summary>
        [EnumMember(Value = "MAESTRO")]
        MAESTRO,

        /// <summary>
        /// CBNATIONALE.
        /// </summary>
        [EnumMember(Value = "CB_NATIONALE")]
        CBNATIONALE,

        /// <summary>
        /// CONFIGOGA.
        /// </summary>
        [EnumMember(Value = "CONFIGOGA")]
        CONFIGOGA,

        /// <summary>
        /// CONFIDIS.
        /// </summary>
        [EnumMember(Value = "CONFIDIS")]
        CONFIDIS,

        /// <summary>
        /// ELECTRON.
        /// </summary>
        [EnumMember(Value = "ELECTRON")]
        ELECTRON,

        /// <summary>
        /// CETELEM.
        /// </summary>
        [EnumMember(Value = "CETELEM")]
        CETELEM,

        /// <summary>
        /// CHINAUNIONPAY.
        /// </summary>
        [EnumMember(Value = "CHINA_UNION_PAY")]
        CHINAUNIONPAY,

        /// <summary>
        /// DINERS.
        /// </summary>
        [EnumMember(Value = "DINERS")]
        DINERS,

        /// <summary>
        /// ELO.
        /// </summary>
        [EnumMember(Value = "ELO")]
        ELO,

        /// <summary>
        /// HIPER.
        /// </summary>
        [EnumMember(Value = "HIPER")]
        HIPER,

        /// <summary>
        /// HIPERCARD.
        /// </summary>
        [EnumMember(Value = "HIPERCARD")]
        HIPERCARD,

        /// <summary>
        /// RUPAY.
        /// </summary>
        [EnumMember(Value = "RUPAY")]
        RUPAY,

        /// <summary>
        /// GE.
        /// </summary>
        [EnumMember(Value = "GE")]
        GE,

        /// <summary>
        /// SYNCHRONY.
        /// </summary>
        [EnumMember(Value = "SYNCHRONY")]
        SYNCHRONY,

        /// <summary>
        /// UNKNOWN.
        /// </summary>
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}