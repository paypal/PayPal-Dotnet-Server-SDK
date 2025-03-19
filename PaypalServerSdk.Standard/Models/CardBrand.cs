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
        ///Visa card.
        /// Visa.
        /// </summary>
        [EnumMember(Value = "VISA")]
        Visa,

        /// <summary>
        ///Mastecard card.
        /// Mastercard.
        /// </summary>
        [EnumMember(Value = "MASTERCARD")]
        Mastercard,

        /// <summary>
        ///Discover card.
        /// Discover.
        /// </summary>
        [EnumMember(Value = "DISCOVER")]
        Discover,

        /// <summary>
        ///American Express card.
        /// Amex.
        /// </summary>
        [EnumMember(Value = "AMEX")]
        Amex,

        /// <summary>
        ///Solo debit card.
        /// Solo.
        /// </summary>
        [EnumMember(Value = "SOLO")]
        Solo,

        /// <summary>
        ///Japan Credit Bureau card.
        /// Jcb.
        /// </summary>
        [EnumMember(Value = "JCB")]
        Jcb,

        /// <summary>
        ///Military Star card.
        /// Star.
        /// </summary>
        [EnumMember(Value = "STAR")]
        Star,

        /// <summary>
        ///Delta Airlines card.
        /// Delta.
        /// </summary>
        [EnumMember(Value = "DELTA")]
        Delta,

        /// <summary>
        ///Switch credit card.
        /// Switch.
        /// </summary>
        [EnumMember(Value = "SWITCH")]
        Switch,

        /// <summary>
        ///Maestro credit card.
        /// Maestro.
        /// </summary>
        [EnumMember(Value = "MAESTRO")]
        Maestro,

        /// <summary>
        ///Carte Bancaire (CB) credit card.
        /// CbNationale.
        /// </summary>
        [EnumMember(Value = "CB_NATIONALE")]
        CbNationale,

        /// <summary>
        ///Configoga credit card.
        /// Configoga.
        /// </summary>
        [EnumMember(Value = "CONFIGOGA")]
        Configoga,

        /// <summary>
        ///Confidis credit card.
        /// Confidis.
        /// </summary>
        [EnumMember(Value = "CONFIDIS")]
        Confidis,

        /// <summary>
        ///Visa Electron credit card.
        /// Electron.
        /// </summary>
        [EnumMember(Value = "ELECTRON")]
        Electron,

        /// <summary>
        ///Cetelem credit card.
        /// Cetelem.
        /// </summary>
        [EnumMember(Value = "CETELEM")]
        Cetelem,

        /// <summary>
        ///China union pay credit card.
        /// ChinaUnionPay.
        /// </summary>
        [EnumMember(Value = "CHINA_UNION_PAY")]
        ChinaUnionPay,

        /// <summary>
        ///The Diners Club International banking and payment services capability network owned by Discover Financial Services (DFS), one of the most recognized brands in US financial services.
        /// Diners.
        /// </summary>
        [EnumMember(Value = "DINERS")]
        Diners,

        /// <summary>
        ///The Brazilian Elo card payment network.
        /// Elo.
        /// </summary>
        [EnumMember(Value = "ELO")]
        Elo,

        /// <summary>
        ///The Hiper - Ingenico ePayment network.
        /// Hiper.
        /// </summary>
        [EnumMember(Value = "HIPER")]
        Hiper,

        /// <summary>
        ///The Brazilian Hipercard payment network that's widely accepted in the retail market.
        /// Hipercard.
        /// </summary>
        [EnumMember(Value = "HIPERCARD")]
        Hipercard,

        /// <summary>
        ///The RuPay payment network.
        /// Rupay.
        /// </summary>
        [EnumMember(Value = "RUPAY")]
        Rupay,

        /// <summary>
        ///The GE Credit Union 3Point card payment network.
        /// Ge.
        /// </summary>
        [EnumMember(Value = "GE")]
        Ge,

        /// <summary>
        ///The Synchrony Financial (SYF) payment network.
        /// Synchrony.
        /// </summary>
        [EnumMember(Value = "SYNCHRONY")]
        Synchrony,

        /// <summary>
        ///The Electronic Fund Transfer At Point of Sale(EFTPOS) Debit card payment network.
        /// Eftpos.
        /// </summary>
        [EnumMember(Value = "EFTPOS")]
        Eftpos,

        /// <summary>
        ///UNKNOWN payment network.
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