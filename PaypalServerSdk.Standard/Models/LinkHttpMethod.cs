// <copyright file="LinkHttpMethod.cs" company="APIMatic">
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
    /// LinkHttpMethod.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum LinkHttpMethod
    {
        /// <summary>
        /// Get.
        /// </summary>
        [EnumMember(Value = "GET")]
        Get,

        /// <summary>
        /// Post.
        /// </summary>
        [EnumMember(Value = "POST")]
        Post,

        /// <summary>
        /// Put.
        /// </summary>
        [EnumMember(Value = "PUT")]
        Put,

        /// <summary>
        /// Delete.
        /// </summary>
        [EnumMember(Value = "DELETE")]
        Delete,

        /// <summary>
        /// Head.
        /// </summary>
        [EnumMember(Value = "HEAD")]
        Head,

        /// <summary>
        /// Connect.
        /// </summary>
        [EnumMember(Value = "CONNECT")]
        Connect,

        /// <summary>
        /// Options.
        /// </summary>
        [EnumMember(Value = "OPTIONS")]
        Options,

        /// <summary>
        /// Patch.
        /// </summary>
        [EnumMember(Value = "PATCH")]
        Patch,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}