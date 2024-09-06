// <copyright file="Environment.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PayPalRESTAPIs.Standard
{
    /// <summary>
    /// Available environments.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Environment
    {
        /// <summary>
        /// PayPal Live Environment.
        /// </summary>
        [EnumMember(Value = "Production")]
        Production,

        /// <summary>
        /// PayPal Sandbox Environment.
        /// </summary>
        [EnumMember(Value = "Sandbox")]
        Sandbox,
    }
}
