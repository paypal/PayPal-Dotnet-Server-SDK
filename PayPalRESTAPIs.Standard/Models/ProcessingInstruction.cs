// <copyright file="ProcessingInstruction.cs" company="APIMatic">
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
    /// ProcessingInstruction.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum ProcessingInstruction
    {
        /// <summary>
        /// ORDERCOMPLETEONPAYMENTAPPROVAL.
        /// </summary>
        [EnumMember(Value = "ORDER_COMPLETE_ON_PAYMENT_APPROVAL")]
        ORDERCOMPLETEONPAYMENTAPPROVAL,

        /// <summary>
        /// NOINSTRUCTION.
        /// </summary>
        [EnumMember(Value = "NO_INSTRUCTION")]
        NOINSTRUCTION,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}