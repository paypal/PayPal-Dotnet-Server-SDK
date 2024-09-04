// <copyright file="StandardEntryClassCode.cs" company="APIMatic">
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
    /// StandardEntryClassCode.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum StandardEntryClassCode
    {
        /// <summary>
        /// TEL.
        /// </summary>
        [EnumMember(Value = "TEL")]
        TEL,

        /// <summary>
        /// WEB.
        /// </summary>
        [EnumMember(Value = "WEB")]
        WEB,

        /// <summary>
        /// CCD.
        /// </summary>
        [EnumMember(Value = "CCD")]
        CCD,

        /// <summary>
        /// PPD.
        /// </summary>
        [EnumMember(Value = "PPD")]
        PPD,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}