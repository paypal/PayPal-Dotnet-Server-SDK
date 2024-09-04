// <copyright file="AVSCode.cs" company="APIMatic">
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
    /// AVSCode.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum AVSCode
    {
        /// <summary>
        /// A.
        /// </summary>
        [EnumMember(Value = "A")]
        A,

        /// <summary>
        /// B.
        /// </summary>
        [EnumMember(Value = "B")]
        B,

        /// <summary>
        /// C.
        /// </summary>
        [EnumMember(Value = "C")]
        C,

        /// <summary>
        /// D.
        /// </summary>
        [EnumMember(Value = "D")]
        D,

        /// <summary>
        /// E.
        /// </summary>
        [EnumMember(Value = "E")]
        E,

        /// <summary>
        /// F.
        /// </summary>
        [EnumMember(Value = "F")]
        F,

        /// <summary>
        /// G.
        /// </summary>
        [EnumMember(Value = "G")]
        G,

        /// <summary>
        /// I.
        /// </summary>
        [EnumMember(Value = "I")]
        I,

        /// <summary>
        /// M.
        /// </summary>
        [EnumMember(Value = "M")]
        M,

        /// <summary>
        /// N.
        /// </summary>
        [EnumMember(Value = "N")]
        N,

        /// <summary>
        /// P.
        /// </summary>
        [EnumMember(Value = "P")]
        P,

        /// <summary>
        /// R.
        /// </summary>
        [EnumMember(Value = "R")]
        R,

        /// <summary>
        /// S.
        /// </summary>
        [EnumMember(Value = "S")]
        S,

        /// <summary>
        /// U.
        /// </summary>
        [EnumMember(Value = "U")]
        U,

        /// <summary>
        /// W.
        /// </summary>
        [EnumMember(Value = "W")]
        W,

        /// <summary>
        /// X.
        /// </summary>
        [EnumMember(Value = "X")]
        X,

        /// <summary>
        /// Y.
        /// </summary>
        [EnumMember(Value = "Y")]
        Y,

        /// <summary>
        /// Z.
        /// </summary>
        [EnumMember(Value = "Z")]
        Z,

        /// <summary>
        /// Null.
        /// </summary>
        [EnumMember(Value = "Null")]
        Null,

        /// <summary>
        /// Enum0.
        /// </summary>
        [EnumMember(Value = "0")]
        Enum0,

        /// <summary>
        /// Enum1.
        /// </summary>
        [EnumMember(Value = "1")]
        Enum1,

        /// <summary>
        /// Enum2.
        /// </summary>
        [EnumMember(Value = "2")]
        Enum2,

        /// <summary>
        /// Enum3.
        /// </summary>
        [EnumMember(Value = "3")]
        Enum3,

        /// <summary>
        /// Enum4.
        /// </summary>
        [EnumMember(Value = "4")]
        Enum4,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}