// <copyright file="PatchOp.cs" company="APIMatic">
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
    /// PatchOp.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PatchOp
    {
        /// <summary>
        /// Add.
        /// </summary>
        [EnumMember(Value = "add")]
        Add,

        /// <summary>
        /// Remove.
        /// </summary>
        [EnumMember(Value = "remove")]
        Remove,

        /// <summary>
        /// Replace.
        /// </summary>
        [EnumMember(Value = "replace")]
        Replace,

        /// <summary>
        /// Move.
        /// </summary>
        [EnumMember(Value = "move")]
        Move,

        /// <summary>
        /// Copy.
        /// </summary>
        [EnumMember(Value = "copy")]
        Copy,

        /// <summary>
        /// Test.
        /// </summary>
        [EnumMember(Value = "test")]
        Test,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}