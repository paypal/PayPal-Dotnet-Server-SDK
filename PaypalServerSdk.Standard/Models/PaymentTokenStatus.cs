// <copyright file="PaymentTokenStatus.cs" company="APIMatic">
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
    /// PaymentTokenStatus.
    /// </summary>

    [JsonConverter(typeof(UnknownEnumConverter<StringEnumConverter>), nameof(_Unknown))]
    public enum PaymentTokenStatus
    {
        /// <summary>
        ///A setup token is initialized with minimal information, more data must be added to the setup-token to be vaulted
        /// Created.
        /// </summary>
        [EnumMember(Value = "CREATED")]
        Created,

        /// <summary>
        ///A contingecy on payer approval is required before the payment method can be saved.
        /// PayerActionRequired.
        /// </summary>
        [EnumMember(Value = "PAYER_ACTION_REQUIRED")]
        PayerActionRequired,

        /// <summary>
        ///Setup token is ready to be vaulted. If a buyer approval contigency was returned, it is has been approved.
        /// Approved.
        /// </summary>
        [EnumMember(Value = "APPROVED")]
        Approved,

        /// <summary>
        ///The payment token has been vaulted.
        /// Vaulted.
        /// </summary>
        [EnumMember(Value = "VAULTED")]
        Vaulted,

        /// <summary>
        ///A vaulted payment method token has been tokenized for short term (one time) use.
        /// Tokenized.
        /// </summary>
        [EnumMember(Value = "TOKENIZED")]
        Tokenized,

        /// <summary>
        /// Unknown values will be mapped by this enum member.
        /// </summary>
        _Unknown
    }
}