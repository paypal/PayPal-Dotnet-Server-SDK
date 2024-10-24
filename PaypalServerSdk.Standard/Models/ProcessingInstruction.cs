// <copyright file="ProcessingInstruction.cs" company="APIMatic">
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
    /// ProcessingInstruction.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum ProcessingInstruction
    {
        /// <summary>
        /// OrderCompleteOnPaymentApproval.
        /// </summary>
        [EnumMember(Value = "ORDER_COMPLETE_ON_PAYMENT_APPROVAL")]
        OrderCompleteOnPaymentApproval,

        /// <summary>
        /// NoInstruction.
        /// </summary>
        [EnumMember(Value = "NO_INSTRUCTION")]
        NoInstruction,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}