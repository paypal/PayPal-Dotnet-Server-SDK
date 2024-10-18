// <copyright file="StandardEntryClassCode.cs" company="APIMatic">
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
    /// StandardEntryClassCode.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum StandardEntryClassCode
    {
        /// <summary>
        /// Tel.
        /// </summary>
        [EnumMember(Value = "TEL")]
        Tel,

        /// <summary>
        /// Web.
        /// </summary>
        [EnumMember(Value = "WEB")]
        Web,

        /// <summary>
        /// Ccd.
        /// </summary>
        [EnumMember(Value = "CCD")]
        Ccd,

        /// <summary>
        /// Ppd.
        /// </summary>
        [EnumMember(Value = "PPD")]
        Ppd,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}