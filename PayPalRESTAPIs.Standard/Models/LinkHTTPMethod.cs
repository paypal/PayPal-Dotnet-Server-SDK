// <copyright file="LinkHTTPMethod.cs" company="APIMatic">
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
    /// LinkHTTPMethod.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum LinkHTTPMethod
    {
        /// <summary>
        /// GET.
        /// </summary>
        [EnumMember(Value = "GET")]
        GET,

        /// <summary>
        /// POST.
        /// </summary>
        [EnumMember(Value = "POST")]
        POST,

        /// <summary>
        /// PUT.
        /// </summary>
        [EnumMember(Value = "PUT")]
        PUT,

        /// <summary>
        /// DELETE.
        /// </summary>
        [EnumMember(Value = "DELETE")]
        DELETE,

        /// <summary>
        /// HEAD.
        /// </summary>
        [EnumMember(Value = "HEAD")]
        HEAD,

        /// <summary>
        /// CONNECT.
        /// </summary>
        [EnumMember(Value = "CONNECT")]
        CONNECT,

        /// <summary>
        /// OPTIONS.
        /// </summary>
        [EnumMember(Value = "OPTIONS")]
        OPTIONS,

        /// <summary>
        /// PATCH.
        /// </summary>
        [EnumMember(Value = "PATCH")]
        PATCH,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}