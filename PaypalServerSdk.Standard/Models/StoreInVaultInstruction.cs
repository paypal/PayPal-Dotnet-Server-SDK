// <copyright file="StoreInVaultInstruction.cs" company="APIMatic">
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
    /// StoreInVaultInstruction.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum StoreInVaultInstruction
    {
        /// <summary>
        ///Defines that the payment_source will be vaulted only when at least one authorization or capture using that payment_source is successful.
        /// OnSuccess.
        /// </summary>
        [EnumMember(Value = "ON_SUCCESS")]
        OnSuccess,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}